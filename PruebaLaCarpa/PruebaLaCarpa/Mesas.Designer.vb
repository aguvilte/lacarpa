<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mesas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mesas))
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.cbNombreProd = New System.Windows.Forms.ComboBox()
        Me.cbTipoProd = New System.Windows.Forms.ComboBox()
        Me.tbCantProd = New System.Windows.Forms.TextBox()
        Me.btnCerrarPedido = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.PictureBox()
        Me.btnAgregarProd = New System.Windows.Forms.PictureBox()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnVolver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregarProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvProductos
        '
        Me.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvProductos.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvProductos.ColumnHeadersHeight = 35
        Me.dgvProductos.Location = New System.Drawing.Point(13, 68)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.ReadOnly = True
        Me.dgvProductos.RowHeadersWidth = 4
        Me.dgvProductos.Size = New System.Drawing.Size(360, 150)
        Me.dgvProductos.TabIndex = 0
        '
        'cbNombreProd
        '
        Me.cbNombreProd.BackColor = System.Drawing.SystemColors.Window
        Me.cbNombreProd.FormattingEnabled = True
        Me.cbNombreProd.ItemHeight = 13
        Me.cbNombreProd.Location = New System.Drawing.Point(99, 249)
        Me.cbNombreProd.Name = "cbNombreProd"
        Me.cbNombreProd.Size = New System.Drawing.Size(189, 21)
        Me.cbNombreProd.TabIndex = 1
        '
        'cbTipoProd
        '
        Me.cbTipoProd.Enabled = False
        Me.cbTipoProd.FormattingEnabled = True
        Me.cbTipoProd.Location = New System.Drawing.Point(99, 298)
        Me.cbTipoProd.Name = "cbTipoProd"
        Me.cbTipoProd.Size = New System.Drawing.Size(189, 21)
        Me.cbTipoProd.TabIndex = 2
        '
        'tbCantProd
        '
        Me.tbCantProd.Location = New System.Drawing.Point(127, 351)
        Me.tbCantProd.Name = "tbCantProd"
        Me.tbCantProd.Size = New System.Drawing.Size(52, 20)
        Me.tbCantProd.TabIndex = 3
        Me.tbCantProd.Text = "1"
        '
        'btnCerrarPedido
        '
        Me.btnCerrarPedido.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnCerrarPedido.Enabled = False
        Me.btnCerrarPedido.ForeColor = System.Drawing.Color.Black
        Me.btnCerrarPedido.Location = New System.Drawing.Point(12, 415)
        Me.btnCerrarPedido.Name = "btnCerrarPedido"
        Me.btnCerrarPedido.Size = New System.Drawing.Size(361, 34)
        Me.btnCerrarPedido.TabIndex = 5
        Me.btnCerrarPedido.Text = "Cerrar pedido"
        Me.btnCerrarPedido.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(96, 233)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Producto: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Location = New System.Drawing.Point(96, 282)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Tipo: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label4.Location = New System.Drawing.Point(124, 335)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Cantidad: "
        '
        'btnVolver
        '
        Me.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVolver.Image = Global.PruebaLaCarpa.My.Resources.Resources.home
        Me.btnVolver.Location = New System.Drawing.Point(172, 12)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(40, 40)
        Me.btnVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnVolver.TabIndex = 9
        Me.btnVolver.TabStop = False
        '
        'btnAgregarProd
        '
        Me.btnAgregarProd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarProd.Image = Global.PruebaLaCarpa.My.Resources.Resources.checked
        Me.btnAgregarProd.Location = New System.Drawing.Point(207, 335)
        Me.btnAgregarProd.Name = "btnAgregarProd"
        Me.btnAgregarProd.Size = New System.Drawing.Size(40, 40)
        Me.btnAgregarProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnAgregarProd.TabIndex = 8
        Me.btnAgregarProd.TabStop = False
        '
        'Mesas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(386, 465)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnAgregarProd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCerrarPedido)
        Me.Controls.Add(Me.tbCantProd)
        Me.Controls.Add(Me.cbTipoProd)
        Me.Controls.Add(Me.cbNombreProd)
        Me.Controls.Add(Me.dgvProductos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Mesas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mesas"
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnVolver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregarProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents cbNombreProd As ComboBox
    Friend WithEvents cbTipoProd As ComboBox
    Friend WithEvents tbCantProd As TextBox
    Friend WithEvents btnCerrarPedido As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAgregarProd As PictureBox
    Friend WithEvents btnVolver As PictureBox
End Class
