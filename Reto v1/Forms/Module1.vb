Imports System.Windows.Controls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Xml

Module Module1
    Dim id = 0
    Dim precio As Double = 0
    Dim idPedidoAnterior = 0
    Dim precioTotal As Double = 0
    Dim nombre As String
    Public ventas(20) As Venta
    Dim i As Integer = -1
    Dim ruta = "..\..\..\Ticket\Ventas.xml"
    Dim docXml As New XmlDocument

    Public Sub setId(a As Integer)
        id = a
    End Sub

    Public Function getId()
        Return id
    End Function

    Public Sub setNombre(a As String)
        nombre = a
    End Sub

    Public Function getNombre()
        Return nombre
    End Function

    Public Sub setprecioTotal(a As Double)
        precioTotal = a
    End Sub

    Public Function getprecioTotal()
        Return precioTotal
    End Function
    Public Sub setidPedidoAnterior(a As Integer)
        idPedidoAnterior = a
    End Sub

    Public Function getidPedidoAnterior()
        Return idPedidoAnterior
    End Function
    Public Sub setPrecio(a As Double)
        precio = a
    End Sub

    Public Function getPrecio()
        Return precio
    End Function

    Public Function setVentas(v1 As Venta)
        i = i + 1
        ventas(i) = v1
    End Function

    Public Function escribirVenta()
        docXml.Load(ruta)
        Dim ultimonodo As XmlNode = docXml.DocumentElement.LastChild
        Dim Venta As XmlElement = docXml.CreateElement("venta")
        Dim fecha As XmlAttribute = docXml.CreateAttribute("fecha")

        Dim a = i + 1
        While a <> 0
            Dim Producto As XmlElement = docXml.CreateElement("producto")

            Dim id As XmlElement = docXml.CreateElement("id")
            Dim nombre As XmlElement = docXml.CreateElement("nombre")
            Dim cantidad As XmlElement = docXml.CreateElement("cantidad")
            Dim precio As XmlElement = docXml.CreateElement("precio")

            fecha.InnerText = Today.Date
            id.InnerText = Trim(ventas(i).getidVenta)
            nombre.InnerText = Trim(ventas(i).getNombre)
            cantidad.InnerText = Trim(ventas(i).getCantidad)
            precio.InnerText = Trim(ventas(i).getPrecio)

            Producto.AppendChild(id)
            Producto.AppendChild(nombre)
            Producto.AppendChild(cantidad)
            Producto.AppendChild(precio)

            Venta.AppendChild(Producto)
            i = i - 1
            a = a - 1
        End While
        Venta.SetAttributeNode(fecha)
        docXml.DocumentElement.InsertAfter(Venta, ultimonodo)
        docXml.Save(ruta)
    End Function

    Public Function limpiar()
        Array.Clear(ventas, 0, ventas.Length)
    End Function

End Module