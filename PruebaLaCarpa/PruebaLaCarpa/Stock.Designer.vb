<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stock))
        Me.dgvStock = New System.Windows.Forms.DataGridView()
        Me.cbTipoStock = New System.Windows.Forms.ComboBox()
        Me.tbCantidadStock = New System.Windows.Forms.TextBox()
        Me.btnAgregarStock = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.PictureBox()
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnVolver, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvStock
        '
        Me.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStock.Location = New System.Drawing.Point(13, 13)
        Me.dgvStock.Name = "dgvStock"
        Me.dgvStock.RowHeadersWidth = 4
        Me.dgvStock.Size = New System.Drawing.Size(259, 115)
        Me.dgvStock.TabIndex = 0
        '
        'cbTipoStock
        '
        Me.cbTipoStock.FormattingEnabled = True
        Me.cbTipoStock.Items.AddRange(New Object() {"Carne", "Cerdo", "Pollo"})
        Me.cbTipoStock.Location = New System.Drawing.Point(78, 169)
        Me.cbTipoStock.Name = "cbTipoStock"
        Me.cbTipoStock.Size = New System.Drawing.Size(121, 21)
        Me.cbTipoStock.TabIndex = 1
        '
        'tbCantidadStock
        '
        Me.tbCantidadStock.Location = New System.Drawing.Point(78, 222)
        Me.tbCantidadStock.Name = "tbCantidadStock"
        Me.tbCantidadStock.Size = New System.Drawing.Size(121, 20)
        Me.tbCantidadStock.TabIndex = 2
        '
        'btnAgregarStock
        '
        Me.btnAgregarStock.Location = New System.Drawing.Point(101, 263)
        Me.btnAgregarStock.Name = "btnAgregarStock"
        Me.btnAgregarStock.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarStock.TabIndex = 3
        Me.btnAgregarStock.Text = "Agregar"
        Me.btnAgregarStock.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Cantidad (en gramos):"
        '
        'btnVolver
        '
        Me.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVolver.Image = Global.PruebaLaCarpa.My.Resources.Resources.home
        Me.btnVolver.Location = New System.Drawing.Point(116, 313)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(40, 40)
        Me.btnVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnVolver.TabIndex = 20
        Me.btnVolver.TabStop = False
        '
        'Stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 365)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAgregarStock)
        Me.Controls.Add(Me.tbCantidadStock)
        Me.Controls.Add(Me.cbTipoStock)
        Me.Controls.Add(Me.dgvStock)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Stock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock"
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnVolver, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvStock As DataGridView
    Friend WithEvents cbTipoStock As ComboBox
    Friend WithEvents tbCantidadStock As TextBox
    Friend WithEvents btnAgregarStock As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnVolver As PictureBox
End Class
