Imports System.Data.OleDb

Public Class EliminarProducto
    Private da As OleDbDataAdapter
    Private ds As DataSet
    Private dr As OleDbDataReader
    Private comando As OleDbCommand
    Private indiceProducto As Integer

    Private Sub ProductoEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectarse()
        ds = New DataSet
        da = New OleDbDataAdapter

        ds.Tables.Add("Productos")

        da.SelectCommand = New OleDbCommand("SELECT nombre FROM productos", Conexion)

        da.Fill(ds.Tables("Productos"))

        cbProd.DataSource = ds.Tables("Productos").DefaultView
        cbProd.ValueMember = "nombre"
        cbProd.Text = ""
        cbTipoProd.Text = ""
        Desconectarse()

        cbTipoProd.Enabled = False
        btnAceptar.Enabled = False
    End Sub

    Private Sub cbProd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProd.SelectedIndexChanged
        Conectarse()
        BuscarIndiceProducto()

        ds = New DataSet

        'SE COMPLETA EL cbTipoProductos CON LOS TIPOS DE PRODUCTOS DISPONIBLES
        ds.Tables.Add("TiposProductos")
        da.SelectCommand = New OleDbCommand("SELECT tipo_producto FROM productos_tipos WHERE id_producto =" & indiceProducto, Conexion)
        da.Fill(ds.Tables("TiposProductos"))
        cbTipoProd.DataSource = ds.Tables("TiposProductos").DefaultView
        cbTipoProd.ValueMember = "tipo_producto"

        Desconectarse()
        cbTipoProd.Enabled = True

        If cbProd.Text <> "" And cbTipoProd.Text <> "" And cbTipoProd.Enabled = True Then
            btnAceptar.Enabled = True
        End If
    End Sub

    Private Sub BuscarIndiceProducto()
        Conectarse()

        comando = New OleDbCommand("SELECT id_producto FROM productos WHERE nombre = '" & cbProd.Text & "'", Conexion)
        dr = comando.ExecuteReader()
        If dr.HasRows Then
            While dr.Read
                indiceProducto = dr("id_producto")
            End While
        End If
        Desconectarse()

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        If MsgBox("¿Está seguro que quiere eliminar el producto seleccionado?", MsgBoxStyle.YesNo, "Eliminar producto") = MsgBoxResult.Yes Then
            BuscarIndiceProducto()

            ds = New DataSet
            da = New OleDbDataAdapter

            ds.Tables.Add("Productos")
            da.SelectCommand = New OleDbCommand("SELECT * FROM productos", Conexion)
            da.Fill(ds.Tables("Productos"))
            ds.Tables("Productos").Rows(0).Delete()
            da.DeleteCommand = New OleDbCommand("DELETE FROM productos WHERE nombre = '" & cbProd.Text & "'", Conexion)
            da.Update(ds.Tables("Productos"))

            ds.Tables.Add("ProductosTipos")
            da.SelectCommand = New OleDbCommand("SELECT * FROM productos_tipos", Conexion)
            da.Fill(ds.Tables("ProductosTipos"))
            ds.Tables("ProductosTipos").Rows(0).Delete()
            da.DeleteCommand = New OleDbCommand("DELETE FROM productos_tipos WHERE id_producto = " & indiceProducto & " AND tipo_producto = '" & cbTipoProd.Text.ToString & "'", Conexion)
            da.Update(ds.Tables("ProductosTipos"))

            AdministrarProducto.Show()
            Me.Close()
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        AdministrarProducto.Show()
        Me.Close()
    End Sub

    Private Sub ProductoEliminar_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        AdministrarProducto.Show()
    End Sub

    Private Sub cbTipoProd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipoProd.SelectedIndexChanged

    End Sub
End Class