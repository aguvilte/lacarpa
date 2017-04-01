<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductoEliminar
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
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.cbProd = New System.Windows.Forms.ComboBox()
        Me.cbTipoProd = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(97, 184)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'cbProd
        '
        Me.cbProd.FormattingEnabled = True
        Me.cbProd.Location = New System.Drawing.Point(41, 48)
        Me.cbProd.Name = "cbProd"
        Me.cbProd.Size = New System.Drawing.Size(160, 21)
        Me.cbProd.TabIndex = 2
        '
        'cbTipoProd
        '
        Me.cbTipoProd.FormattingEnabled = True
        Me.cbTipoProd.Location = New System.Drawing.Point(41, 116)
        Me.cbTipoProd.Name = "cbTipoProd"
        Me.cbTipoProd.Size = New System.Drawing.Size(160, 21)
        Me.cbTipoProd.TabIndex = 2
        '
        'ProductoEliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.cbTipoProd)
        Me.Controls.Add(Me.cbProd)
        Me.Controls.Add(Me.btnAceptar)
        Me.Name = "ProductoEliminar"
        Me.Text = "ProductoEliminar"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAceptar As Button
    Friend WithEvents cbProd As ComboBox
    Friend WithEvents cbTipoProd As ComboBox
End Class
