Imports System.Data.OleDb

Public Class NuevoProducto
    Private da As OleDbDataAdapter
    Private ds As DataSet
    Private dr As OleDbDataReader
    Private comando As OleDbCommand
    Private vistaDatos As DataView
    Private indiceProducto As Integer

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If MsgBox("¿Está seguro de agregar el producto?", MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes Then
            ds = New DataSet
            da = New OleDbDataAdapter

            ds.Tables.Add("Productos")
            da.SelectCommand = New OleDbCommand("SELECT * FROM productos", Conexion)
            da.Fill(ds.Tables("Productos"))

            Dim row As DataRow
            row = ds.Tables("Productos").NewRow
            row("nombre") = tbNombreProd.Text.ToString

            ds.Tables("Productos").Rows.Add(row)

            da.InsertCommand = New OleDbCommand("INSERT INTO productos (nombre) VALUES (@nom)", Conexion)
            da.InsertCommand.Parameters.Add("@nom", OleDbType.VarChar, 30, "nombre")

            da.Update(ds.Tables("Productos"))

            BuscarIndiceProducto()

            ds.Tables.Add("ProductosTipos")
            da.SelectCommand = New OleDbCommand("SELECT * FROM productos_tipos", Conexion)
            da.Fill(ds.Tables("ProductosTipos"))

            row = ds.Tables("ProductosTipos").NewRow
            row("id_producto") = indiceProducto
            row("tipo_producto") = tbTipoProd.Text.ToString
            row("precio") = CInt(tbPrecioProd.Text)

            MsgBox(indiceProducto)

            ds.Tables("ProductosTipos").Rows.Add(row)

            da.InsertCommand = New OleDbCommand("INSERT INTO productos_tipos (id_producto, tipo_producto, precio) VALUES (@idProd, @tipoProd, @precio)", Conexion)

            da.InsertCommand.Parameters.Add("@idProd", OleDbType.BigInt, 3, "id_producto")
            da.InsertCommand.Parameters.Add("@tipoProd", OleDbType.VarChar, 30, "tipo_producto")
            da.InsertCommand.Parameters.Add("@precio", OleDbType.BigInt, 4, "precio")

            da.Update(ds.Tables("ProductosTipos"))

            tbNombreProd.Text = ""
            tbTipoProd.Text = ""
            tbPrecioProd.Text = ""
            btnCancelar.Text = "Finalizar"
        End If

    End Sub

    Private Sub BuscarIndiceProducto()
        Conectarse()
        comando = New OleDbCommand("SELECT id_producto FROM productos WHERE nombre = '" & tbNombreProd.Text & "'", Conexion)
        dr = comando.ExecuteReader()
        If dr.HasRows Then
            While dr.Read
                indiceProducto = dr("id_producto")
            End While
        End If
        Desconectarse()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        AdministrarProducto.Show()
        Me.Close()
    End Sub

    Private Sub ActivarBoton()
        If tbNombreProd.Text <> "" And tbTipoProd.Text <> "" And IsNumeric(tbPrecioProd.Text) Then
            btnGuardar.Enabled = True
        ElseIf tbNombreProd.Text = "" Or tbTipoProd.Text = "" Or tbPrecioProd.Text = "" Then
            btnGuardar.Enabled = False
        End If
    End Sub

    Private Sub tbNombreProd_TextChanged(sender As Object, e As EventArgs) Handles tbNombreProd.TextChanged
        ActivarBoton()
    End Sub

    Private Sub tbTipoProd_TextChanged(sender As Object, e As EventArgs) Handles tbTipoProd.TextChanged
        ActivarBoton()
    End Sub

    Private Sub tbPrecioProd_TextChanged(sender As Object, e As EventArgs) Handles tbPrecioProd.TextChanged
        ActivarBoton()
    End Sub

    Private Sub NuevoProducto_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        AdministrarProducto.Show()
    End Sub
End Class