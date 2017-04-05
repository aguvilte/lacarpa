<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MesaRecepcion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MesaRecepcion))
        Me.btnAgregarProd1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCerrarPedido1 = New System.Windows.Forms.Button()
        Me.tbCantProd = New System.Windows.Forms.TextBox()
        Me.cbTipoProd = New System.Windows.Forms.ComboBox()
        Me.cbNombreProd = New System.Windows.Forms.ComboBox()
        Me.dgvProductos1 = New System.Windows.Forms.DataGridView()
        Me.dgvProductos2 = New System.Windows.Forms.DataGridView()
        Me.btnCerrarPedido2 = New System.Windows.Forms.Button()
        Me.btnAgregarProd2 = New System.Windows.Forms.PictureBox()
        Me.dgvProductos3 = New System.Windows.Forms.DataGridView()
        Me.dgvProductos4 = New System.Windows.Forms.DataGridView()
        Me.btnCerrarPedido3 = New System.Windows.Forms.Button()
        Me.btnCerrarPedido4 = New System.Windows.Forms.Button()
        Me.btnAgregarProd3 = New System.Windows.Forms.PictureBox()
        Me.btnAgregarProd4 = New System.Windows.Forms.PictureBox()
        Me.btnVolver = New System.Windows.Forms.PictureBox()
        CType(Me.btnAgregarProd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProductos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProductos2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregarProd2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProductos3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProductos4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregarProd3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregarProd4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnVolver, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAgregarProd1
        '
        Me.btnAgregarProd1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarProd1.Image = Global.PruebaLaCarpa.My.Resources.Resources.checked
        Me.btnAgregarProd1.Location = New System.Drawing.Point(405, 136)
        Me.btnAgregarProd1.Name = "btnAgregarProd1"
        Me.btnAgregarProd1.Size = New System.Drawing.Size(40, 40)
        Me.btnAgregarProd1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnAgregarProd1.TabIndex = 27
        Me.btnAgregarProd1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label4.Location = New System.Drawing.Point(690, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Cantidad: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Location = New System.Drawing.Point(447, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Tipo: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(204, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Producto: "
        '
        'btnCerrarPedido1
        '
        Me.btnCerrarPedido1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnCerrarPedido1.ForeColor = System.Drawing.Color.Black
        Me.btnCerrarPedido1.Location = New System.Drawing.Point(388, 182)
        Me.btnCerrarPedido1.Name = "btnCerrarPedido1"
        Me.btnCerrarPedido1.Size = New System.Drawing.Size(79, 70)
        Me.btnCerrarPedido1.TabIndex = 23
        Me.btnCerrarPedido1.Text = "Cerrar pedido"
        Me.btnCerrarPedido1.UseVisualStyleBackColor = False
        '
        'tbCantProd
        '
        Me.tbCantProd.Location = New System.Drawing.Point(693, 40)
        Me.tbCantProd.Name = "tbCantProd"
        Me.tbCantProd.Size = New System.Drawing.Size(52, 20)
        Me.tbCantProd.TabIndex = 22
        Me.tbCantProd.Text = "1"
        '
        'cbTipoProd
        '
        Me.cbTipoProd.FormattingEnabled = True
        Me.cbTipoProd.Location = New System.Drawing.Point(450, 40)
        Me.cbTipoProd.Name = "cbTipoProd"
        Me.cbTipoProd.Size = New System.Drawing.Size(189, 21)
        Me.cbTipoProd.TabIndex = 21
        '
        'cbNombreProd
        '
        Me.cbNombreProd.BackColor = System.Drawing.SystemColors.Window
        Me.cbNombreProd.FormattingEnabled = True
        Me.cbNombreProd.ItemHeight = 13
        Me.cbNombreProd.Location = New System.Drawing.Point(207, 40)
        Me.cbNombreProd.Name = "cbNombreProd"
        Me.cbNombreProd.Size = New System.Drawing.Size(189, 21)
        Me.cbNombreProd.TabIndex = 20
        '
        'dgvProductos1
        '
        Me.dgvProductos1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvProductos1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvProductos1.ColumnHeadersHeight = 35
        Me.dgvProductos1.Location = New System.Drawing.Point(22, 102)
        Me.dgvProductos1.Name = "dgvProductos1"
        Me.dgvProductos1.ReadOnly = True
        Me.dgvProductos1.RowHeadersWidth = 4
        Me.dgvProductos1.Size = New System.Drawing.Size(360, 150)
        Me.dgvProductos1.TabIndex = 19
        '
        'dgvProductos2
        '
        Me.dgvProductos2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvProductos2.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvProductos2.ColumnHeadersHeight = 35
        Me.dgvProductos2.Location = New System.Drawing.Point(22, 258)
        Me.dgvProductos2.Name = "dgvProductos2"
        Me.dgvProductos2.ReadOnly = True
        Me.dgvProductos2.RowHeadersWidth = 4
        Me.dgvProductos2.Size = New System.Drawing.Size(360, 150)
        Me.dgvProductos2.TabIndex = 19
        '
        'btnCerrarPedido2
        '
        Me.btnCerrarPedido2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnCerrarPedido2.ForeColor = System.Drawing.Color.Black
        Me.btnCerrarPedido2.Location = New System.Drawing.Point(388, 338)
        Me.btnCerrarPedido2.Name = "btnCerrarPedido2"
        Me.btnCerrarPedido2.Size = New System.Drawing.Size(79, 70)
        Me.btnCerrarPedido2.TabIndex = 23
        Me.btnCerrarPedido2.Text = "Cerrar pedido"
        Me.btnCerrarPedido2.UseVisualStyleBackColor = False
        '
        'btnAgregarProd2
        '
        Me.btnAgregarProd2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarProd2.Image = Global.PruebaLaCarpa.My.Resources.Resources.checked
        Me.btnAgregarProd2.Location = New System.Drawing.Point(405, 292)
        Me.btnAgregarProd2.Name = "btnAgregarProd2"
        Me.btnAgregarProd2.Size = New System.Drawing.Size(40, 40)
        Me.btnAgregarProd2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnAgregarProd2.TabIndex = 27
        Me.btnAgregarProd2.TabStop = False
        '
        'dgvProductos3
        '
        Me.dgvProductos3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvProductos3.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvProductos3.ColumnHeadersHeight = 35
        Me.dgvProductos3.Location = New System.Drawing.Point(539, 102)
        Me.dgvProductos3.Name = "dgvProductos3"
        Me.dgvProductos3.ReadOnly = True
        Me.dgvProductos3.RowHeadersWidth = 4
        Me.dgvProductos3.Size = New System.Drawing.Size(360, 150)
        Me.dgvProductos3.TabIndex = 19
        '
        'dgvProductos4
        '
        Me.dgvProductos4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvProductos4.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvProductos4.ColumnHeadersHeight = 35
        Me.dgvProductos4.Location = New System.Drawing.Point(539, 258)
        Me.dgvProductos4.Name = "dgvProductos4"
        Me.dgvProductos4.ReadOnly = True
        Me.dgvProductos4.RowHeadersWidth = 4
        Me.dgvProductos4.Size = New System.Drawing.Size(360, 150)
        Me.dgvProductos4.TabIndex = 19
        '
        'btnCerrarPedido3
        '
        Me.btnCerrarPedido3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnCerrarPedido3.ForeColor = System.Drawing.Color.Black
        Me.btnCerrarPedido3.Location = New System.Drawing.Point(905, 182)
        Me.btnCerrarPedido3.Name = "btnCerrarPedido3"
        Me.btnCerrarPedido3.Size = New System.Drawing.Size(79, 70)
        Me.btnCerrarPedido3.TabIndex = 23
        Me.btnCerrarPedido3.Text = "Cerrar pedido"
        Me.btnCerrarPedido3.UseVisualStyleBackColor = False
        '
        'btnCerrarPedido4
        '
        Me.btnCerrarPedido4.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnCerrarPedido4.ForeColor = System.Drawing.Color.Black
        Me.btnCerrarPedido4.Location = New System.Drawing.Point(905, 338)
        Me.btnCerrarPedido4.Name = "btnCerrarPedido4"
        Me.btnCerrarPedido4.Size = New System.Drawing.Size(79, 70)
        Me.btnCerrarPedido4.TabIndex = 23
        Me.btnCerrarPedido4.Text = "Cerrar pedido"
        Me.btnCerrarPedido4.UseVisualStyleBackColor = False
        '
        'btnAgregarProd3
        '
        Me.btnAgregarProd3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarProd3.Image = Global.PruebaLaCarpa.My.Resources.Resources.checked
        Me.btnAgregarProd3.Location = New System.Drawing.Point(922, 136)
        Me.btnAgregarProd3.Name = "btnAgregarProd3"
        Me.btnAgregarProd3.Size = New System.Drawing.Size(40, 40)
        Me.btnAgregarProd3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnAgregarProd3.TabIndex = 27
        Me.btnAgregarProd3.TabStop = False
        '
        'btnAgregarProd4
        '
        Me.btnAgregarProd4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarProd4.Image = Global.PruebaLaCarpa.My.Resources.Resources.checked
        Me.btnAgregarProd4.Location = New System.Drawing.Point(922, 292)
        Me.btnAgregarProd4.Name = "btnAgregarProd4"
        Me.btnAgregarProd4.Size = New System.Drawing.Size(40, 40)
        Me.btnAgregarProd4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnAgregarProd4.TabIndex = 27
        Me.btnAgregarProd4.TabStop = False
        '
        'btnVolver
        '
        Me.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVolver.Image = Global.PruebaLaCarpa.My.Resources.Resources.home
        Me.btnVolver.Location = New System.Drawing.Point(12, 12)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(40, 40)
        Me.btnVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnVolver.TabIndex = 28
        Me.btnVolver.TabStop = False
        '
        'MesaRecepcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 452)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnAgregarProd4)
        Me.Controls.Add(Me.btnAgregarProd2)
        Me.Controls.Add(Me.btnAgregarProd3)
        Me.Controls.Add(Me.btnAgregarProd1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCerrarPedido4)
        Me.Controls.Add(Me.btnCerrarPedido2)
        Me.Controls.Add(Me.btnCerrarPedido3)
        Me.Controls.Add(Me.btnCerrarPedido1)
        Me.Controls.Add(Me.tbCantProd)
        Me.Controls.Add(Me.cbTipoProd)
        Me.Controls.Add(Me.cbNombreProd)
        Me.Controls.Add(Me.dgvProductos4)
        Me.Controls.Add(Me.dgvProductos3)
        Me.Controls.Add(Me.dgvProductos2)
        Me.Controls.Add(Me.dgvProductos1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MesaRecepcion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MesaRecepcion"
        CType(Me.btnAgregarProd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProductos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProductos2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregarProd2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProductos3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProductos4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregarProd3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregarProd4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnVolver, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAgregarProd1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCerrarPedido1 As Button
    Friend WithEvents tbCantProd As TextBox
    Friend WithEvents cbTipoProd As ComboBox
    Friend WithEvents cbNombreProd As ComboBox
    Friend WithEvents dgvProductos1 As DataGridView
    Friend WithEvents dgvProductos2 As DataGridView
    Friend WithEvents btnCerrarPedido2 As Button
    Friend WithEvents btnAgregarProd2 As PictureBox
    Friend WithEvents dgvProductos3 As DataGridView
    Friend WithEvents dgvProductos4 As DataGridView
    Friend WithEvents btnCerrarPedido3 As Button
    Friend WithEvents btnCerrarPedido4 As Button
    Friend WithEvents btnAgregarProd3 As PictureBox
    Friend WithEvents btnAgregarProd4 As PictureBox
    Friend WithEvents btnVolver As PictureBox
End Class
