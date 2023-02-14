Public Class Venta
    Dim idVenta As Integer
    Dim nombre As String
    Dim cantidad As Integer
    Dim precio As Double

    Public Sub New(idVenta1 As Integer, nombre1 As String, cantidad1 As Integer, precio1 As Double)
        idVenta = idVenta1
        nombre = nombre1
        cantidad = cantidad1
        precio = precio1
    End Sub

    Public Function getidVenta()
        Return idVenta
    End Function

    Public Function getNombre()
        Return nombre
    End Function

    Public Function getCantidad()
        Return cantidad
    End Function

    Public Function getPrecio()
        Return precio
    End Function

End Class
