﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTpv
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.ibTiempo = New FontAwesome.Sharp.IconButton()
        Me.ibArticulos = New FontAwesome.Sharp.IconButton()
        Me.ibEmpleados = New FontAwesome.Sharp.IconButton()
        Me.ibPedido = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.btnMinimizar = New FontAwesome.Sharp.IconButton()
        Me.btnMaximizar = New FontAwesome.Sharp.IconButton()
        Me.btnCerrar = New FontAwesome.Sharp.IconButton()
        Me.lblTitulo1 = New System.Windows.Forms.Label()
        Me.ipbHome = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelEscritorio = New System.Windows.Forms.Panel()
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTop.SuspendLayout()
        CType(Me.ipbHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.Transparent
        Me.PanelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelMenu.Controls.Add(Me.ibTiempo)
        Me.PanelMenu.Controls.Add(Me.ibArticulos)
        Me.PanelMenu.Controls.Add(Me.ibEmpleados)
        Me.PanelMenu.Controls.Add(Me.ibPedido)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(230, 794)
        Me.PanelMenu.TabIndex = 0
        '
        'ibTiempo
        '
        Me.ibTiempo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ibTiempo.Dock = System.Windows.Forms.DockStyle.Top
        Me.ibTiempo.FlatAppearance.BorderSize = 0
        Me.ibTiempo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ibTiempo.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ibTiempo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ibTiempo.IconChar = FontAwesome.Sharp.IconChar.Cloud
        Me.ibTiempo.IconColor = System.Drawing.Color.MidnightBlue
        Me.ibTiempo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ibTiempo.IconSize = 32
        Me.ibTiempo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ibTiempo.Location = New System.Drawing.Point(0, 389)
        Me.ibTiempo.Name = "ibTiempo"
        Me.ibTiempo.Padding = New System.Windows.Forms.Padding(10, 0, 5, 0)
        Me.ibTiempo.Size = New System.Drawing.Size(230, 83)
        Me.ibTiempo.TabIndex = 4
        Me.ibTiempo.Text = "Tiempo Atmosférico"
        Me.ibTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ibTiempo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ibTiempo.UseVisualStyleBackColor = True
        '
        'ibArticulos
        '
        Me.ibArticulos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ibArticulos.Dock = System.Windows.Forms.DockStyle.Top
        Me.ibArticulos.FlatAppearance.BorderSize = 0
        Me.ibArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ibArticulos.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ibArticulos.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ibArticulos.IconChar = FontAwesome.Sharp.IconChar.Box
        Me.ibArticulos.IconColor = System.Drawing.Color.MidnightBlue
        Me.ibArticulos.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ibArticulos.IconSize = 32
        Me.ibArticulos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ibArticulos.Location = New System.Drawing.Point(0, 306)
        Me.ibArticulos.Name = "ibArticulos"
        Me.ibArticulos.Padding = New System.Windows.Forms.Padding(10, 0, 5, 0)
        Me.ibArticulos.Size = New System.Drawing.Size(230, 83)
        Me.ibArticulos.TabIndex = 3
        Me.ibArticulos.Text = "Gestión Articulos"
        Me.ibArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ibArticulos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ibArticulos.UseVisualStyleBackColor = True
        '
        'ibEmpleados
        '
        Me.ibEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ibEmpleados.Dock = System.Windows.Forms.DockStyle.Top
        Me.ibEmpleados.FlatAppearance.BorderSize = 0
        Me.ibEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ibEmpleados.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ibEmpleados.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ibEmpleados.IconChar = FontAwesome.Sharp.IconChar.User
        Me.ibEmpleados.IconColor = System.Drawing.Color.MidnightBlue
        Me.ibEmpleados.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ibEmpleados.IconSize = 32
        Me.ibEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ibEmpleados.Location = New System.Drawing.Point(0, 223)
        Me.ibEmpleados.Name = "ibEmpleados"
        Me.ibEmpleados.Padding = New System.Windows.Forms.Padding(10, 0, 5, 0)
        Me.ibEmpleados.Size = New System.Drawing.Size(230, 83)
        Me.ibEmpleados.TabIndex = 2
        Me.ibEmpleados.Text = "Gestión Empleados"
        Me.ibEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ibEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ibEmpleados.UseVisualStyleBackColor = True
        '
        'ibPedido
        '
        Me.ibPedido.BackColor = System.Drawing.Color.Transparent
        Me.ibPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ibPedido.Dock = System.Windows.Forms.DockStyle.Top
        Me.ibPedido.FlatAppearance.BorderSize = 0
        Me.ibPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ibPedido.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ibPedido.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ibPedido.IconChar = FontAwesome.Sharp.IconChar.Cutlery
        Me.ibPedido.IconColor = System.Drawing.Color.MidnightBlue
        Me.ibPedido.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ibPedido.IconSize = 32
        Me.ibPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ibPedido.Location = New System.Drawing.Point(0, 140)
        Me.ibPedido.Name = "ibPedido"
        Me.ibPedido.Padding = New System.Windows.Forms.Padding(10, 0, 5, 0)
        Me.ibPedido.Size = New System.Drawing.Size(230, 83)
        Me.ibPedido.TabIndex = 1
        Me.ibPedido.Text = "Nuevo Pedido"
        Me.ibPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ibPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ibPedido.UseVisualStyleBackColor = False
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.pbLogo)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(230, 140)
        Me.PanelLogo.TabIndex = 0
        '
        'pbLogo
        '
        Me.pbLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbLogo.ErrorImage = Nothing
        Me.pbLogo.Image = Global.Reto_v1.My.Resources.Resources.descarga_removebg_preview
        Me.pbLogo.Location = New System.Drawing.Point(0, 3)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(227, 131)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLogo.TabIndex = 0
        Me.pbLogo.TabStop = False
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.MidnightBlue
        Me.PanelTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PanelTop.Controls.Add(Me.btnMinimizar)
        Me.PanelTop.Controls.Add(Me.btnMaximizar)
        Me.PanelTop.Controls.Add(Me.btnCerrar)
        Me.PanelTop.Controls.Add(Me.lblTitulo1)
        Me.PanelTop.Controls.Add(Me.ipbHome)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.ForeColor = System.Drawing.Color.Gainsboro
        Me.PanelTop.Location = New System.Drawing.Point(230, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(1392, 79)
        Me.PanelTop.TabIndex = 1
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.btnMinimizar.IconColor = System.Drawing.Color.Gainsboro
        Me.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMinimizar.IconSize = 15
        Me.btnMinimizar.Location = New System.Drawing.Point(1285, -5)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(35, 40)
        Me.btnMinimizar.TabIndex = 4
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.FlatAppearance.BorderSize = 0
        Me.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        Me.btnMaximizar.IconColor = System.Drawing.Color.Gainsboro
        Me.btnMaximizar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMaximizar.IconSize = 15
        Me.btnMaximizar.Location = New System.Drawing.Point(1321, 0)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(35, 35)
        Me.btnMaximizar.TabIndex = 5
        Me.btnMaximizar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.X
        Me.btnCerrar.IconColor = System.Drawing.Color.Gainsboro
        Me.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCerrar.IconSize = 15
        Me.btnCerrar.Location = New System.Drawing.Point(1357, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(35, 35)
        Me.btnCerrar.TabIndex = 6
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'lblTitulo1
        '
        Me.lblTitulo1.AutoSize = True
        Me.lblTitulo1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTitulo1.Location = New System.Drawing.Point(76, 30)
        Me.lblTitulo1.Name = "lblTitulo1"
        Me.lblTitulo1.Size = New System.Drawing.Size(59, 21)
        Me.lblTitulo1.TabIndex = 1
        Me.lblTitulo1.Text = "Home"
        '
        'ipbHome
        '
        Me.ipbHome.BackColor = System.Drawing.Color.Transparent
        Me.ipbHome.ForeColor = System.Drawing.Color.MintCream
        Me.ipbHome.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.ipbHome.IconColor = System.Drawing.Color.MintCream
        Me.ipbHome.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ipbHome.IconSize = 53
        Me.ipbHome.Location = New System.Drawing.Point(18, 12)
        Me.ipbHome.Name = "ipbHome"
        Me.ipbHome.Size = New System.Drawing.Size(53, 54)
        Me.ipbHome.TabIndex = 0
        Me.ipbHome.TabStop = False
        '
        'PanelEscritorio
        '
        Me.PanelEscritorio.BackColor = System.Drawing.Color.Transparent
        Me.PanelEscritorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelEscritorio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEscritorio.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PanelEscritorio.Location = New System.Drawing.Point(230, 79)
        Me.PanelEscritorio.Name = "PanelEscritorio"
        Me.PanelEscritorio.Size = New System.Drawing.Size(1392, 715)
        Me.PanelEscritorio.TabIndex = 2
        '
        'FormTpv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(1622, 794)
        Me.Controls.Add(Me.PanelEscritorio)
        Me.Controls.Add(Me.PanelTop)
        Me.Controls.Add(Me.PanelMenu)
        Me.Name = "FormTpv"
        Me.Text = "FormTpv"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        CType(Me.ipbHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents ibPedido As FontAwesome.Sharp.IconButton
    Friend WithEvents ibArticulos As FontAwesome.Sharp.IconButton
    Friend WithEvents ibEmpleados As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTop As Panel
    Friend WithEvents lblTitulo1 As Label
    Friend WithEvents ipbHome As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PanelEscritorio As Panel
    Friend WithEvents btnCerrar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMaximizar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMinimizar As FontAwesome.Sharp.IconButton
    Friend WithEvents ibTiempo As FontAwesome.Sharp.IconButton
End Class
