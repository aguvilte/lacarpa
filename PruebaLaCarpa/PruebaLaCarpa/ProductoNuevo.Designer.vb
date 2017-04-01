<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductoNuevo
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
        Me.GrBoxProductoNuevo = New System.Windows.Forms.GroupBox()
        Me.TbPrecio = New System.Windows.Forms.TextBox()
        Me.TbTipo = New System.Windows.Forms.TextBox()
        Me.TbNombre = New System.Windows.Forms.TextBox()
        Me.LbPrecio = New System.Windows.Forms.Label()
        Me.LbTipo = New System.Windows.Forms.Label()
        Me.LbNombre = New System.Windows.Forms.Label()
        Me.BtGuardarNuevo = New System.Windows.Forms.Button()
        Me.GrBoxProductoNuevo.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrBoxProductoNuevo
        '
        Me.GrBoxProductoNuevo.Controls.Add(Me.TbPrecio)
        Me.GrBoxProductoNuevo.Controls.Add(Me.TbTipo)
        Me.GrBoxProductoNuevo.Controls.Add(Me.TbNombre)
        Me.GrBoxProductoNuevo.Controls.Add(Me.LbPrecio)
        Me.GrBoxProductoNuevo.Controls.Add(Me.LbTipo)
        Me.GrBoxProductoNuevo.Controls.Add(Me.LbNombre)
        Me.GrBoxProductoNuevo.Controls.Add(Me.BtGuardarNuevo)
        Me.GrBoxProductoNuevo.Location = New System.Drawing.Point(12, 12)
        Me.GrBoxProductoNuevo.Name = "GrBoxProductoNuevo"
        Me.GrBoxProductoNuevo.Size = New System.Drawing.Size(333, 220)
        Me.GrBoxProductoNuevo.TabIndex = 0
        Me.GrBoxProductoNuevo.TabStop = False
        '
        'TbPrecio
        '
        Me.TbPrecio.Location = New System.Drawing.Point(113, 130)
        Me.TbPrecio.Name = "TbPrecio"
        Me.TbPrecio.Size = New System.Drawing.Size(100, 20)
        Me.TbPrecio.TabIndex = 2
        '
        'TbTipo
        '
        Me.TbTipo.Location = New System.Drawing.Point(113, 77)
        Me.TbTipo.Name = "TbTipo"
        Me.TbTipo.Size = New System.Drawing.Size(100, 20)
        Me.TbTipo.TabIndex = 2
        '
        'TbNombre
        '
        Me.TbNombre.Location = New System.Drawing.Point(113, 30)
        Me.TbNombre.Name = "TbNombre"
        Me.TbNombre.Size = New System.Drawing.Size(100, 20)
        Me.TbNombre.TabIndex = 2
        '
        'LbPrecio
        '
        Me.LbPrecio.AutoSize = True
        Me.LbPrecio.Location = New System.Drawing.Point(67, 133)
        Me.LbPrecio.Name = "LbPrecio"
        Me.LbPrecio.Size = New System.Drawing.Size(40, 13)
        Me.LbPrecio.TabIndex = 1
        Me.LbPrecio.Text = "Precio:"
        '
        'LbTipo
        '
        Me.LbTipo.AutoSize = True
        Me.LbTipo.Location = New System.Drawing.Point(76, 80)
        Me.LbTipo.Name = "LbTipo"
        Me.LbTipo.Size = New System.Drawing.Size(31, 13)
        Me.LbTipo.TabIndex = 1
        Me.LbTipo.Text = "Tipo:"
        '
        'LbNombre
        '
        Me.LbNombre.AutoSize = True
        Me.LbNombre.Location = New System.Drawing.Point(60, 33)
        Me.LbNombre.Name = "LbNombre"
        Me.LbNombre.Size = New System.Drawing.Size(47, 13)
        Me.LbNombre.TabIndex = 1
        Me.LbNombre.Text = "Nombre:"
        '
        'BtGuardarNuevo
        '
        Me.BtGuardarNuevo.Location = New System.Drawing.Point(130, 180)
        Me.BtGuardarNuevo.Name = "BtGuardarNuevo"
        Me.BtGuardarNuevo.Size = New System.Drawing.Size(75, 23)
        Me.BtGuardarNuevo.TabIndex = 0
        Me.BtGuardarNuevo.Text = "Guardar"
        Me.BtGuardarNuevo.UseVisualStyleBackColor = True
        '
        'ProductoNuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 261)
        Me.Controls.Add(Me.GrBoxProductoNuevo)
        Me.Name = "ProductoNuevo"
        Me.Text = "ProductoNuevo"
        Me.GrBoxProductoNuevo.ResumeLayout(False)
        Me.GrBoxProductoNuevo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GrBoxProductoNuevo As GroupBox
    Friend WithEvents TbPrecio As TextBox
    Friend WithEvents TbTipo As TextBox
    Friend WithEvents TbNombre As TextBox
    Friend WithEvents LbPrecio As Label
    Friend WithEvents LbTipo As Label
    Friend WithEvents LbNombre As Label
    Friend WithEvents BtGuardarNuevo As Button
End Class
