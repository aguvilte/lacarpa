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
        Me.dgvStock.Enabled = False
        Me.dgvStock.Location = New System.Drawing.Point(0, 74)
        Me.dgvStock.Name = "dgvStock"
        Me.dgvStock.RowHeadersWidth = 4
        Me.dgvStock.Size = New System.Drawing.Size(283, 115)
        Me.dgvStock.TabIndex = 0
        '
        'cbTipoStock
        '
        Me.cbTipoStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoStock.FormattingEnabled = True
        Me.cbTipoStock.Items.AddRange(New Object() {"Carne", "Pollo", "Cerdo"})
        Me.cbTipoStock.Location = New System.Drawing.Point(11, 230)
        Me.cbTipoStock.Name = "cbTipoStock"
        Me.cbTipoStock.Size = New System.Drawing.Size(260, 24)
        Me.cbTipoStock.TabIndex = 1
        '
        'tbCantidadStock
        '
        Me.tbCantidadStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCantidadStock.Location = New System.Drawing.Point(12, 289)
        Me.tbCantidadStock.Name = "tbCantidadStock"
        Me.tbCantidadStock.Size = New System.Drawing.Size(162, 23)
        Me.tbCantidadStock.TabIndex = 2
        '
        'btnAgregarStock
        '
        Me.btnAgregarStock.BackColor = System.Drawing.SystemColors.Control
        Me.btnAgregarStock.Enabled = False
        Me.btnAgregarStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarStock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAgregarStock.Location = New System.Drawing.Point(101, 349)
        Me.btnAgregarStock.Name = "btnAgregarStock"
        Me.btnAgregarStock.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarStock.TabIndex = 3
        Me.btnAgregarStock.Text = "Agregar"
        Me.btnAgregarStock.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label1.Location = New System.Drawing.Point(9, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label2.Location = New System.Drawing.Point(9, 269)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Cantidad (en gramos)"
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.Transparent
        Me.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVolver.Image = Global.PruebaLaCarpa.My.Resources.Resources.home
        Me.btnVolver.Location = New System.Drawing.Point(120, 15)
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
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(283, 401)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAgregarStock)
        Me.Controls.Add(Me.tbCantidadStock)
        Me.Controls.Add(Me.cbTipoStock)
        Me.Controls.Add(Me.dgvStock)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(299, 440)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(299, 440)
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
