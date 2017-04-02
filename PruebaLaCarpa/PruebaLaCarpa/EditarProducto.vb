Imports System.Data.OleDb
Public Class EditarProducto

    Private da As OleDbDataAdapter
    Private ds As DataSet
    Private dr As OleDbDataReader
    Private comando As OleDbCommand
    Private vistaDatos As DataView
    Private indiceProducto As Integer
    Private PrecioNuevoDistinto As Boolean = False

    Private Sub EditarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ds = New DataSet
        da = New OleDbDataAdapter

        ds.Tables.Add("Productos")

        da.SelectCommand = New OleDbCommand("SELECT nombre FROM productos", Conexion)

        da.Fill(ds.Tables("Productos"))

        cbNombreProd.DataSource = ds.Tables("Productos").DefaultView
        cbNombreProd.ValueMember = "nombre"
        cbNombreProd.Text = ""
        cbTipoProd.Text = ""
        tbPrecio.Text = ""
    End Sub

    Private Sub cbNombreProd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbNombreProd.SelectedIndexChanged
        Conectarse()
        BuscarIndiceProducto()

        ds = New DataSet
        ds.Tables.Add("TiposProductos")
        da.SelectCommand = New OleDbCommand("SELECT tipo_producto FROM productos_tipos WHERE id_producto =" & indiceProducto, Conexion)
        da.Fill(ds.Tables("TiposProductos"))
        cbTipoProd.DataSource = ds.Tables("TiposProductos").DefaultView
        cbTipoProd.ValueMember = "tipo_producto"

        Desconectarse()
        Conectarse()

        comando = New OleDbCommand("SELECT precio FROM productos_tipos WHERE id_producto =" & indiceProducto & " AND tipo_producto = '" & cbTipoProd.Text & "'", Conexion)
        dr = comando.ExecuteReader()
        If dr.HasRows Then
            While dr.Read
                tbPrecio.Text = dr("precio").ToString
            End While
        End If

        Desconectarse()
    End Sub

    Private Sub BuscarIndiceProducto()

        comando = New OleDbCommand("SELECT id_producto FROM productos WHERE nombre = '" & cbNombreProd.Text & "'", Conexion)
        dr = comando.ExecuteReader()
        If dr.HasRows Then
            While dr.Read
                indiceProducto = dr("id_producto")
            End While
        End If
    End Sub

    Private Sub tbPrecioNuevo_TextChanged(sender As Object, e As EventArgs) Handles tbPrecioNuevo.TextChanged
        If tbPrecioNuevo.Text = "" Then
            btnModificar.Enabled = False
        Else
            btnModificar.Enabled = True
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        ComprobarCambioPrecio()

        If PrecioNuevoDistinto = True Then

            ds.Tables.Add("Precios")
            da.SelectCommand = New OleDbCommand("SELECT * FROM productos_tipos", Conexion)
            da.Fill(ds.Tables("Precios"))

            Dim row As DataRow
            row = ds.Tables("Precios").Rows(0)
            row("precio") = CInt(tbPrecioNuevo.Text)
            row("id_producto") = indiceProducto
            row("tipo_producto") = cbTipoProd.Text

            da.UpdateCommand = New OleDbCommand("UPDATE productos_tipos SET precio=@pre WHERE id_producto=@id AND tipo_producto=@tipo", Conexion)
            da.UpdateCommand.Parameters.Add("@pre", OleDbType.BigInt, 3, "precio")
            da.UpdateCommand.Parameters.Add("@id", OleDbType.BigInt, 3, "id_producto")
            da.UpdateCommand.Parameters.Add("@tipo", OleDbType.VarChar, 10, "tipo_producto")
            da.Update(ds.Tables("Precios"))
            ds.Tables.Remove("Precios")

            MsgBox("El precio del producto '" & cbNombreProd.Text & " - " & cbTipoProd.Text & "' ha sido modificado")

            ActualizarMonto()
        Else
            MsgBox("El precio que insertó es el mismo que el precio actual. Ingrese un precio distinto")
        End If

    End Sub
    Private Sub ActualizarMonto()
        Conectarse()

        comando = New OleDbCommand("SELECT precio FROM productos_tipos WHERE id_producto =" & indiceProducto & " AND tipo_producto = '" & cbTipoProd.Text & "'", Conexion)
        dr = comando.ExecuteReader()
        If dr.HasRows Then
            While dr.Read
                tbPrecio.Text = dr("precio").ToString
            End While
        End If

        Desconectarse()

        tbPrecioNuevo.Text = ""
    End Sub


    Private Sub cbTipoProd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipoProd.SelectedIndexChanged
        ActualizarMonto()
    End Sub

    Private Sub ComprobarCambioPrecio()
        If CInt(tbPrecio.Text) = CInt(tbPrecioNuevo.Text) Then
            PrecioNuevoDistinto = False
        Else
            PrecioNuevoDistinto = True
        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        PrNuevoEdit.Show()
        Me.Close()
    End Sub

    Private Sub EditarProducto_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        PrNuevoEdit.Show()
    End Sub
End Class