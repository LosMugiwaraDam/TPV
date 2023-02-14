Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp

Public Class FormPedidos

    Private btnPanel As IconButton
    Private formHijoActual As Form
    Public conexion As New Conexion
    Public MiDataSet As DataSet
    Dim cant As Integer = 1
    Public total As Double
    Dim Venta As Venta

    Public idPedidoAnterior As Integer

    Private Sub FormPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarTodo()
        btnAñadir.Visible = True
        btnFin.Visible = True
        lblNombre.Visible = True
        lblTotal.Visible = True
        InicializarId()
        Module1.limpiar()
    End Sub


    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
        WindowState = FormWindowState.Maximized
    End Sub
    Private Sub ActivateButton(senderbtn As Object, customColor As Color)
        If senderbtn IsNot Nothing Then
            disableButton()
            btnPanel = CType(senderbtn, IconButton)
            btnPanel.BackColor = Color.AliceBlue
            btnPanel.ForeColor = Color.MidnightBlue
            btnPanel.IconColor = Color.MidnightBlue
            btnPanel.TextAlign = ContentAlignment.MiddleCenter
            btnPanel.ImageAlign = ContentAlignment.MiddleRight
            btnPanel.TextImageRelation = TextImageRelation.TextBeforeImage

        End If
    End Sub

    Private Sub disableButton()
        If btnPanel IsNot Nothing Then
            btnPanel.BackColor = Color.Transparent
            btnPanel.ForeColor = Color.MidnightBlue
            btnPanel.IconColor = Color.MidnightBlue
            btnPanel.TextAlign = ContentAlignment.MiddleLeft
            btnPanel.ImageAlign = ContentAlignment.MiddleLeft
            btnPanel.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub OpenChildForm(formHijo As Form)
        If formHijoActual IsNot Nothing Then
            formHijoActual.Close()
        End If
        formHijoActual = formHijo

        formHijo.TopLevel = False
        formHijo.FormBorderStyle = FormBorderStyle.None
        formHijo.Dock = DockStyle.Fill
        PanelPrincipal.Controls.Add(formHijo)
        PanelPrincipal.Tag = formHijo
        formHijo.BringToFront()
        formHijo.Show()
        lblTitulo.Text = formHijo.Text
    End Sub

    Private Sub ibPrincipal_Click(sender As Object, e As EventArgs) Handles ibPrincipal.Click
        btnAñadir.Visible = True
        btnFin.Visible = True
        lblNombre.Visible = True
        lblTotal.Visible = True
        btnRestar.Visible = True
        btnSumar.Visible = True
        lblCantidad.Visible = True
        ActivateButton(sender, Color.White)
        OpenChildForm(New FormPrincipal)
    End Sub
    Private Sub ibBebidas_Click(sender As Object, e As EventArgs) Handles ibBebidas.Click
        btnAñadir.Visible = True
        btnFin.Visible = True
        lblNombre.Visible = True
        lblTotal.Visible = True
        btnRestar.Visible = True
        btnSumar.Visible = True
        lblCantidad.Visible = True
        ActivateButton(sender, Color.White)
        OpenChildForm(New FormBebidas)
    End Sub

    Private Sub ibEntrantes_Click(sender As Object, e As EventArgs) Handles ibEntrantes.Click
        btnAñadir.Visible = True
        btnFin.Visible = True
        lblNombre.Visible = True
        lblTotal.Visible = True
        btnRestar.Visible = True
        btnSumar.Visible = True
        lblCantidad.Visible = True
        ActivateButton(sender, Color.White)
        OpenChildForm(New FormEntrantes)
    End Sub

    <DllImport("user32.DLL”, EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapure()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal Wind As System.IntPtr, ByVal wii As Integer, ByVal waram As Integer, ByVal Param As Integer)
    End Sub

    Public Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        Try
            Dim miDataRow As DataRow
            miDataRow = conexion.MiDataSet.Tables("Ventas").NewRow
            miDataRow("IdPedido") = idPedidoAnterior + 1
            miDataRow("IdEmpleado") = Login.user("IdEmpleado")
            miDataRow("IdArticulo") = Module1.getId
            miDataRow("Fecha") = Today.Date
            miDataRow("Cantidad") = cant

            Dim precioTotal As Double
            precioTotal = Module1.getPrecio
            Dim vprecioTotal = cant * precioTotal
            miDataRow("PrecioTotal") = vprecioTotal

            total = total + vprecioTotal
            setprecioTotal(total)
            lblTotal.Text = total

            Dim miTabla As DataTable
            Dim miDataRowArticulos() As DataRow
            miTabla = conexion.MiDataSet.Tables("Articulos")
            miDataRowArticulos = miTabla.Select("IdArticulo = '" & CStr(getId()) & "'")
            Dim stockArticulos = miDataRowArticulos(0)
            Dim stock = stockArticulos("Stock")
            stock = stock - cant
            stockArticulos("Stock") = stock

            conexion.MiDataSet.Tables("Ventas").Rows.Add(miDataRow)
            conexion.MiDataAdapter3.Update(conexion.MiDataSet, "Ventas")
            conexion.MiDataAdapter.Update(conexion.MiDataSet, "Articulos")
            CargarTodo()
            Venta = New Venta(Module1.getId, Module1.getNombre, cant, Module1.getPrecio)
            Module1.setVentas(Venta)
        Catch ex As Exception
            MsgBox("Selecciona al menos un articulo para añadir al pedido")
        End Try

    End Sub

    Private Sub btnFin_Click(sender As Object, e As EventArgs) Handles btnFin.Click
        OpenChildForm(New FormFinal)
        btnAñadir.Visible = False
        btnFin.Visible = False
        lblNombre.Visible = False
        lblTotal.Visible = False
        btnRestar.Visible = False
        btnSumar.Visible = False
        lblCantidad.Visible = False
    End Sub
    Private Sub CargarTodo()
        conexion.Conectar()
        conexion.CargarDatosArticulos()

        FormFinal.dgvVentas.DataSource = conexion.MiDataSet
        FormFinal.dgvVentas.DataMember = "Ventas"
    End Sub

    Public Sub InicializarId()
        Dim MiDataAdapter As SqlDataAdapter
        MiDataAdapter = New SqlDataAdapter("Select IIF(max(IdPedido) Is Null, 0, max(IdPedido)) as IdPedido From Ventas WHERE Eliminado= 'False'", conexion.MiConexion)
        MiDataSet = New DataSet
        MiDataAdapter.Fill(MiDataSet)

        idPedidoAnterior = MiDataSet.Tables(0).Rows(0).Item("IdPedido")
        Module1.setidPedidoAnterior(idPedidoAnterior)
    End Sub

    Private Sub btnSumar_Click(sender As Object, e As EventArgs) Handles btnSumar.Click
        cant = lblCantidad.Text + 1
        lblCantidad.Text = cant
    End Sub

    Private Sub btnRestar_Click(sender As Object, e As EventArgs) Handles btnRestar.Click
        If lblCantidad.Text.Equals("1") = False Then
            cant = lblCantidad.Text - 1
            lblCantidad.Text = cant
        End If
    End Sub
End Class