<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarProducto
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
        Me.tbPrecioNuevo = New System.Windows.Forms.TextBox()
        Me.tbPrecio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbTipoProd = New System.Windows.Forms.ComboBox()
        Me.cbNombreProd = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbPrecioNuevo
        '
        Me.tbPrecioNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPrecioNuevo.Location = New System.Drawing.Point(112, 142)
        Me.tbPrecioNuevo.Name = "tbPrecioNuevo"
        Me.tbPrecioNuevo.Size = New System.Drawing.Size(69, 23)
        Me.tbPrecioNuevo.TabIndex = 25
        '
        'tbPrecio
        '
        Me.tbPrecio.Enabled = False
        Me.tbPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPrecio.Location = New System.Drawing.Point(12, 142)
        Me.tbPrecio.Name = "tbPrecio"
        Me.tbPrecio.Size = New System.Drawing.Size(69, 23)
        Me.tbPrecio.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(85, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 17)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = ">>"
        '
        'cbTipoProd
        '
        Me.cbTipoProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoProd.FormattingEnabled = True
        Me.cbTipoProd.Location = New System.Drawing.Point(12, 86)
        Me.cbTipoProd.Name = "cbTipoProd"
        Me.cbTipoProd.Size = New System.Drawing.Size(169, 24)
        Me.cbTipoProd.TabIndex = 23
        '
        'cbNombreProd
        '
        Me.cbNombreProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNombreProd.FormattingEnabled = True
        Me.cbNombreProd.Location = New System.Drawing.Point(12, 29)
        Me.cbNombreProd.Name = "cbNombreProd"
        Me.cbNombreProd.Size = New System.Drawing.Size(169, 24)
        Me.cbNombreProd.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 17)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Precio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 17)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Tipo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 17)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Nombre"
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(61, 239)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 35
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Enabled = False
        Me.btnModificar.Location = New System.Drawing.Point(61, 201)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 34
        Me.btnModificar.Text = "Aceptar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'EditarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(198, 274)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.tbPrecioNuevo)
        Me.Controls.Add(Me.tbPrecio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbTipoProd)
        Me.Controls.Add(Me.cbNombreProd)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditarProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar producto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbPrecioNuevo As TextBox
    Friend WithEvents tbPrecio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbTipoProd As ComboBox
    Friend WithEvents cbNombreProd As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnModificar As Button
End Class
