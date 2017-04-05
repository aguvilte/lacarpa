<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mesa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mesa))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCerrarPedido = New System.Windows.Forms.Button()
        Me.tbCantProd = New System.Windows.Forms.TextBox()
        Me.cbTipoProd = New System.Windows.Forms.ComboBox()
        Me.cbNombreProd = New System.Windows.Forms.ComboBox()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.tbAtajo = New System.Windows.Forms.TextBox()
        Me.btnVolver = New System.Windows.Forms.PictureBox()
        Me.btnAgregarProd = New System.Windows.Forms.PictureBox()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnVolver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregarProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label4.Location = New System.Drawing.Point(110, 323)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Cantidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label2.Location = New System.Drawing.Point(82, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Tipo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label1.Location = New System.Drawing.Point(82, 221)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Producto"
        '
        'btnCerrarPedido
        '
        Me.btnCerrarPedido.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnCerrarPedido.ForeColor = System.Drawing.Color.Black
        Me.btnCerrarPedido.Location = New System.Drawing.Point(36, 385)
        Me.btnCerrarPedido.Name = "btnCerrarPedido"
        Me.btnCerrarPedido.Size = New System.Drawing.Size(288, 34)
        Me.btnCerrarPedido.TabIndex = 14
        Me.btnCerrarPedido.Text = "Cerrar pedido"
        Me.btnCerrarPedido.UseVisualStyleBackColor = False
        '
        'tbCantProd
        '
        Me.tbCantProd.Location = New System.Drawing.Point(113, 339)
        Me.tbCantProd.Name = "tbCantProd"
        Me.tbCantProd.Size = New System.Drawing.Size(52, 20)
        Me.tbCantProd.TabIndex = 13
        Me.tbCantProd.Text = "1"
        '
        'cbTipoProd
        '
        Me.cbTipoProd.FormattingEnabled = True
        Me.cbTipoProd.Location = New System.Drawing.Point(85, 286)
        Me.cbTipoProd.Name = "cbTipoProd"
        Me.cbTipoProd.Size = New System.Drawing.Size(189, 21)
        Me.cbTipoProd.TabIndex = 12
        '
        'cbNombreProd
        '
        Me.cbNombreProd.BackColor = System.Drawing.SystemColors.Window
        Me.cbNombreProd.FormattingEnabled = True
        Me.cbNombreProd.ItemHeight = 13
        Me.cbNombreProd.Location = New System.Drawing.Point(85, 237)
        Me.cbNombreProd.Name = "cbNombreProd"
        Me.cbNombreProd.Size = New System.Drawing.Size(189, 21)
        Me.cbNombreProd.TabIndex = 11
        '
        'dgvProductos
        '
        Me.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvProductos.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvProductos.ColumnHeadersHeight = 35
        Me.dgvProductos.Location = New System.Drawing.Point(1, 58)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.ReadOnly = True
        Me.dgvProductos.RowHeadersWidth = 4
        Me.dgvProductos.Size = New System.Drawing.Size(361, 150)
        Me.dgvProductos.TabIndex = 10
        '
        'tbAtajo
        '
        Me.tbAtajo.Location = New System.Drawing.Point(317, 450)
        Me.tbAtajo.Name = "tbAtajo"
        Me.tbAtajo.Size = New System.Drawing.Size(45, 20)
        Me.tbAtajo.TabIndex = 0
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.Transparent
        Me.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVolver.Image = Global.PruebaLaCarpa.My.Resources.Resources.home
        Me.btnVolver.Location = New System.Drawing.Point(157, 10)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(40, 40)
        Me.btnVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnVolver.TabIndex = 19
        Me.btnVolver.TabStop = False
        '
        'btnAgregarProd
        '
        Me.btnAgregarProd.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregarProd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarProd.Image = Global.PruebaLaCarpa.My.Resources.Resources.checked
        Me.btnAgregarProd.Location = New System.Drawing.Point(193, 323)
        Me.btnAgregarProd.Name = "btnAgregarProd"
        Me.btnAgregarProd.Size = New System.Drawing.Size(40, 40)
        Me.btnAgregarProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnAgregarProd.TabIndex = 18
        Me.btnAgregarProd.TabStop = False
        '
        'Mesas1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(362, 470)
        Me.Controls.Add(Me.tbAtajo)
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
        Me.Name = "Mesas1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mesas1"
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnVolver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregarProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAgregarProd As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCerrarPedido As Button
    Friend WithEvents tbCantProd As TextBox
    Friend WithEvents cbTipoProd As ComboBox
    Friend WithEvents cbNombreProd As ComboBox
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents btnVolver As PictureBox
    Friend WithEvents tbAtajo As TextBox
End Class
