Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Threading
Imports System.Windows
Imports System.Xml
Imports CG.Web.MegaApiClient

Public Class FormTiempo

    Dim temperatura
    Dim estado
    Dim viento
    Private Sub FormTiempo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim api = New DBApi
        Dim Url = "https://api.tutiempo.net/xml/?lan=es&apid=45YXaXzaqzq8xd3&lid=8143"
        Dim headers = New List(Of Parametro)
        Dim parametros = New List(Of Parametro)
        Dim response = api.MGet(Url, headers, parametros)
        If My.Computer.FileSystem.FileExists("..\..\..\xmlTiempo\meteorologia.xml") Then
            My.Computer.FileSystem.DeleteFile("..\..\..\xmlTiempo\meteorologia.xml")
            My.Computer.FileSystem.WriteAllText("..\..\..\xmlTiempo\meteorologia.xml",
        response, True)
        Else
            My.Computer.FileSystem.WriteAllText("..\..\..\xmlTiempo\meteorologia.xml",
        response, True)
        End If

        Try
            Dim documentxml As XmlDocument
            Dim nodeList As XmlNodeList
            Dim nodo As XmlNode
            documentxml = New XmlDocument
            documentxml.Load("..\..\..\xmlTiempo\meteorologia.xml")
            nodeList = documentxml.SelectNodes("/data/day1")

            For Each nodo In nodeList
                temperatura = nodo.ChildNodes(1).InnerText
                estado = nodo.ChildNodes(4).InnerText
                viento = nodo.ChildNodes(6).InnerText

                MsgBox(estado.ToString() & " Actualmente hay una temperatura de: " & temperatura.ToString() & "ºC " & " y la fuerza del viento es de: " & viento.ToString() & " km/h. Consultar la aplicacion del tiempo para ver recomendaciones")
            Next


        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

        Dim escribir As New StreamWriter("..\..\..\txtTiempo\txtTiempo.txt")
        Try
            escribir.WriteLine(temperatura + "," + estado + "," + viento)
            escribir.Close()
        Catch ex As Exception
            MsgBox("Se presento un problema al escribir en el archivo: " & ex.Message, MsgBoxStyle.Critical, ":::Gestión de Ficheros y Directorios:::")
        End Try
        Button1.PerformClick()

    End Sub

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim arch As String = "txtTiempo.txt"
        Dim path As String = "../../../txtTiempo/" & arch

        Dim api As New MegaApiClient()

        ' Iniciar sesión
        api.Login("ikermurga74@gmail.com", "bumbum24")

        ' Cargar archivo
        Dim nodes As IEnumerable(Of INode) = Await api.GetNodesAsync()

        Dim nodePath As INode = nodes.Where(Function(n) n.Name = arch).FirstOrDefault()
        If nodePath IsNot Nothing Then
            api.Delete(nodePath, False)
        End If

        nodePath = nodes.Where(Function(n) n.Name = "vbFiles").FirstOrDefault()
        api.UploadFile(path, nodePath)
    End Sub
End Class