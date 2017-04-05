<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Estadisticas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Estadisticas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblEstadistica = New System.Windows.Forms.Label()
        Me.cbItems = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ver estadísticas de:"
        '
        'lblEstadistica
        '
        Me.lblEstadistica.AutoSize = True
        Me.lblEstadistica.Location = New System.Drawing.Point(52, 100)
        Me.lblEstadistica.Name = "lblEstadistica"
        Me.lblEstadistica.Size = New System.Drawing.Size(63, 13)
        Me.lblEstadistica.TabIndex = 0
        Me.lblEstadistica.Text = "Monto total:"
        '
        'cbItems
        '
        Me.cbItems.FormattingEnabled = True
        Me.cbItems.Items.AddRange(New Object() {"Último día", "Última semana", "Último mes"})
        Me.cbItems.Location = New System.Drawing.Point(55, 50)
        Me.cbItems.Name = "cbItems"
        Me.cbItems.Size = New System.Drawing.Size(159, 21)
        Me.cbItems.TabIndex = 1
        '
        'Estadisticas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.cbItems)
        Me.Controls.Add(Me.lblEstadistica)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Estadisticas"
        Me.Text = "Estadísticas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblEstadistica As Label
    Friend WithEvents cbItems As ComboBox
End Class
