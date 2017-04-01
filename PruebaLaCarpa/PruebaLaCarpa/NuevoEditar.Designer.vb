<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoEditar
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
        Me.CbNombre = New System.Windows.Forms.ComboBox()
        Me.CbTipo = New System.Windows.Forms.ComboBox()
        Me.CbPrecio = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtNueGuardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CbNombre
        '
        Me.CbNombre.FormattingEnabled = True
        Me.CbNombre.Location = New System.Drawing.Point(78, 46)
        Me.CbNombre.Name = "CbNombre"
        Me.CbNombre.Size = New System.Drawing.Size(121, 21)
        Me.CbNombre.TabIndex = 0
        '
        'CbTipo
        '
        Me.CbTipo.FormattingEnabled = True
        Me.CbTipo.Location = New System.Drawing.Point(78, 87)
        Me.CbTipo.Name = "CbTipo"
        Me.CbTipo.Size = New System.Drawing.Size(121, 21)
        Me.CbTipo.TabIndex = 0
        '
        'CbPrecio
        '
        Me.CbPrecio.FormattingEnabled = True
        Me.CbPrecio.Location = New System.Drawing.Point(78, 132)
        Me.CbPrecio.Name = "CbPrecio"
        Me.CbPrecio.Size = New System.Drawing.Size(121, 21)
        Me.CbPrecio.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Precio"
        '
        'BtNueGuardar
        '
        Me.BtNueGuardar.Location = New System.Drawing.Point(89, 181)
        Me.BtNueGuardar.Name = "BtNueGuardar"
        Me.BtNueGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BtNueGuardar.TabIndex = 2
        Me.BtNueGuardar.Text = "Guardar"
        Me.BtNueGuardar.UseVisualStyleBackColor = True
        '
        'NuevoEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(268, 240)
        Me.Controls.Add(Me.BtNueGuardar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CbPrecio)
        Me.Controls.Add(Me.CbTipo)
        Me.Controls.Add(Me.CbNombre)
        Me.Name = "NuevoEditar"
        Me.Text = "Edicion de Productos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CbNombre As ComboBox
    Friend WithEvents CbTipo As ComboBox
    Friend WithEvents CbPrecio As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtNueGuardar As Button
End Class
