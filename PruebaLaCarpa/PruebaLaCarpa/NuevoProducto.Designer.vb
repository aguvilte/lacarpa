<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoProducto
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
        Me.tbNombreProd = New System.Windows.Forms.TextBox()
        Me.tbTipoProd = New System.Windows.Forms.TextBox()
        Me.tbPrecioProd = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbNombreProd
        '
        Me.tbNombreProd.Location = New System.Drawing.Point(12, 60)
        Me.tbNombreProd.Name = "tbNombreProd"
        Me.tbNombreProd.Size = New System.Drawing.Size(167, 20)
        Me.tbNombreProd.TabIndex = 0
        '
        'tbTipoProd
        '
        Me.tbTipoProd.Location = New System.Drawing.Point(12, 96)
        Me.tbTipoProd.Name = "tbTipoProd"
        Me.tbTipoProd.Size = New System.Drawing.Size(167, 20)
        Me.tbTipoProd.TabIndex = 0
        '
        'tbPrecioProd
        '
        Me.tbPrecioProd.Location = New System.Drawing.Point(12, 132)
        Me.tbPrecioProd.Name = "tbPrecioProd"
        Me.tbPrecioProd.Size = New System.Drawing.Size(100, 20)
        Me.tbPrecioProd.TabIndex = 0
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(40, 180)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'NuevoProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(198, 261)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.tbPrecioProd)
        Me.Controls.Add(Me.tbTipoProd)
        Me.Controls.Add(Me.tbNombreProd)
        Me.Name = "NuevoProducto"
        Me.Text = "NuevoProducto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbNombreProd As TextBox
    Friend WithEvents tbTipoProd As TextBox
    Friend WithEvents tbPrecioProd As TextBox
    Friend WithEvents btnGuardar As Button
End Class
