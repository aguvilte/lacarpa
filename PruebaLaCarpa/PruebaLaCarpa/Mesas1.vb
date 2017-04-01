Imports System.Data.OleDb

Public Class Mesas1
    Private da As OleDbDataAdapter
    Private dr As OleDbDataReader
    Private comando As OleDbCommand

    Private ds As DataSet

    Private vistaDatos As DataView

    Private numeroMesa As Integer
    Private cantidadProducto As Integer
    Private montoTotal As Integer = 0
    Private indiceProducto As Integer
    Private cantidadStock As Integer
    Private mesaOcupadaBoolean As Boolean

    Private Sub Mesas1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectarse()

        'ELIGE NÚMERO MESA
        For i As Integer = 0 To 51
            If i = Principal.NumeroMesa Then
                numeroMesa = i
            End If
        Next
        Me.Text = "Mesa " & numeroMesa

        'ACTIVA/DESACTIVA EL BOTÓN CerrarPedido SI LA MESA NO TIENE 
        comando = New OleDbCommand("SELECT * FROM mesas_productos WHERE id_mesa=" & numeroMesa, Conexion)
        dr = comando.ExecuteReader()
        If dr.HasRows Then
            btnCerrarPedido.Enabled = True
        Else
            btnCerrarPedido.Enabled = False
        End If
        dr.Close()

        'SE COMPLETA EL dgv CON LOS PRODUCTOS ACTUALES DE LA MESA
        ds = New DataSet
        da = New OleDbDataAdapter
        ds.Tables.Add("MesasProductos")
        da.SelectCommand = New OleDbCommand("SELECT nombre, tipo_producto FROM productos INNER JOIN mesas_productos ON productos.id_producto = mesas_productos.id_producto WHERE id_mesa=" & numeroMesa, Conexion)
        da.Fill(ds.Tables("MesasProductos"))
        dgvProductos.DataSource = ds.Tables("MesasProductos").DefaultView
        dgvProductos.Columns(0).HeaderText = "Nombre"
        dgvProductos.Columns(1).HeaderText = "Tipo"
        dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        'SE COMPLETA EL cbNombreProductos CON LOS PRODUCTOS DISPONIBLES
        ds.Tables.Add("Productos")
        da.SelectCommand = New OleDbCommand("SELECT nombre FROM productos", Conexion)
        da.Fill(ds.Tables("Productos"))
        cbNombreProd.DataSource = ds.Tables("Productos").DefaultView
        cbNombreProd.ValueMember = "nombre"
        cbNombreProd.Text = ""
        cbTipoProd.Text = ""
        cantidadProducto = CInt(tbCantProd.Text)

        'ACTUALIZA MONTO DEL PEDIDO ACTUAL
        CalculaMonto()
        btnAgregarProd.Visible = False
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Desconectarse()
        Principal.Show()
        Me.Close()
    End Sub

    Private Sub cbNombreProd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbNombreProd.SelectedIndexChanged
        'SE BUSCA EL id DEL PRODUCTO SELECCIONADO EN cbNombreProductos
        BuscarIndiceProducto()

        'SE COMPLETA EL cbTipoProductos CON LOS TIPOS DE PRODUCTOS DISPONIBLES
        ds = New DataSet
        ds.Tables.Add("TiposProductos")
        da.SelectCommand = New OleDbCommand("SELECT tipo_producto FROM productos_tipos WHERE id_producto =" & indiceProducto, Conexion)
        da.Fill(ds.Tables("TiposProductos"))
        cbTipoProd.DataSource = ds.Tables("TiposProductos").DefaultView
        cbTipoProd.ValueMember = "tipo_producto"

        btnAgregarProd.Visible = True
    End Sub

    Private Sub btnCerrarPedido_Click(sender As Object, e As EventArgs) Handles btnCerrarPedido.Click
        mesaOcupadaBoolean = False

        If MsgBox("¿Está seguro que quiere cerrar el pedido?", MsgBoxStyle.OkCancel, "Cerrar pedido") = MsgBoxResult.Ok Then
            ds = New DataSet
            ds.Tables.Add("Ventas")
            ds.Tables.Add("MesasProductos")

            Dim row As DataRow
            row = ds.Tables("Ventas").NewRow

            da.InsertCommand = New OleDbCommand("INSERT INTO ventas (fecha, monto) VALUES ('" & DateTime.Now.ToString & "', " & montoTotal & ")", Conexion)
            ds.Tables("Ventas").Rows.Add(row)
            da.Update(ds.Tables("Ventas"))

            da.SelectCommand = New OleDbCommand("SELECT nombre, tipo_producto FROM productos INNER JOIN mesas_productos ON productos.id_producto = mesas_productos.id_producto WHERE id_mesa=" & numeroMesa, Conexion)
            da.Fill(ds.Tables("MesasProductos"))
            ds.Tables("MesasProductos").Rows(0).Delete()
            da.DeleteCommand = New OleDbCommand("DELETE FROM mesas_productos WHERE id_mesa = " & numeroMesa, Conexion)
            da.Update(ds.Tables("MesasProductos"))

            PintarMesaOcupada()
            Me.Close()
            Principal.Show()
        End If

    End Sub

    Private Sub btnAgregarProd_Click(sender As Object, e As EventArgs) Handles btnAgregarProd.Click
        mesaOcupadaBoolean = True

        Dim row As DataRow
        Dim index As Integer
        Dim cantidad As Integer = CInt(tbCantProd.Text)

        btnCerrarPedido.Enabled = True

        If cantidad > 0 Then
            ds = New DataSet
            ds.Tables.Add("MesasProductos")
            da.SelectCommand = New OleDbCommand("SELECT * FROM mesas_productos WHERE id_mesa=" & numeroMesa, Conexion)
            da.Fill(ds.Tables("MesasProductos"))

            BuscarIndiceProducto()

            cantidadStock = 0

            For index = 1 To cantidad
                row = ds.Tables("MesasProductos").NewRow
                row("id_mesa") = numeroMesa
                row("id_producto") = indiceProducto
                row("tipo_producto") = cbTipoProd.Text.ToString

                ds.Tables("MesasProductos").Rows.Add(row)

                da.InsertCommand = New OleDbCommand("INSERT INTO mesas_productos (id_mesa, id_producto, tipo_producto) VALUES (@idMesa, @idProd, @tipoProd)", Conexion)
                da.InsertCommand.Parameters.Add("@idMesa", OleDbType.BigInt, 3, "id_mesa")
                da.InsertCommand.Parameters.Add("@idProd", OleDbType.BigInt, 1, "id_producto")
                da.InsertCommand.Parameters.Add("@tipoProd", OleDbType.VarChar, 30, "tipo_producto")

                cantidadStock += 150
            Next
            da.Update(ds.Tables("MesasProductos"))
        End If

        ds.Tables.Add("MesasProductos2")
        da.SelectCommand = New OleDbCommand("SELECT nombre, tipo_producto FROM productos INNER JOIN mesas_productos ON productos.id_producto = mesas_productos.id_producto WHERE id_mesa=" & numeroMesa, Conexion)
        da.Fill(ds.Tables("MesasProductos2"))

        dgvProductos.DataSource = ds.Tables("MesasProductos2").DefaultView
        dgvProductos.Columns(0).HeaderText = "Nombre de producto"
        dgvProductos.Columns(1).HeaderText = "Tipo de producto"

        If cbTipoProd.Text = "Carne" Or cbTipoProd.Text = "Pollo" Or cbTipoProd.Text = "Cerdo" Then
            ds.Tables.Add("Stock")
            da.SelectCommand = New OleDbCommand("SELECT * FROM stock WHERE nombre = '" & cbTipoProd.Text & "'", Conexion)
            da.Fill(ds.Tables("Stock"))

            cantidadStock = ds.Tables("Stock").Rows(0)("cantidad") - cantidadStock

            row = ds.Tables("Stock").Rows(0)
            row("nombre") = cbTipoProd.Text
            row("cantidad") = cantidadStock

            da.UpdateCommand = New OleDbCommand("UPDATE stock SET cantidad= @cant WHERE nombre = @nom", Conexion)
            da.UpdateCommand.Parameters.Add("@cant", OleDbType.BigInt, 5, "cantidad")
            da.UpdateCommand.Parameters.Add("@nom", OleDbType.VarChar, 10, "nombre")
            da.Update(ds.Tables("Stock"))
        End If

        CalculaMonto()
        PintarMesaOcupada()
    End Sub

    Private Sub CalculaMonto()
        comando = New OleDbCommand("SELECT precio FROM productos_tipos INNER JOIN mesas_productos ON productos_tipos.id_producto = mesas_productos.id_producto And productos_tipos.tipo_producto = mesas_productos.tipo_producto WHERE mesas_productos.id_mesa = " & numeroMesa, Conexion)
        dr = comando.ExecuteReader()
        If dr.HasRows Then
            montoTotal = 0
            While dr.Read
                montoTotal += dr("precio")
            End While
        End If
        btnCerrarPedido.Text = "Cerrar pedido - Monto total: $" & montoTotal
    End Sub

    Private Sub PintarMesaOcupada()
        ds = New DataSet
        ds.Tables.Add("Mesas")
        da.SelectCommand = New OleDbCommand("SELECT * FROM mesas", Conexion)
        da.Fill(ds.Tables("Mesas"))

        Dim row As DataRow
        row = ds.Tables("Mesas").Rows(0)
        If mesaOcupadaBoolean = True Then
            row("ocupada") = -1
        Else
            row("ocupada") = 0
        End If

        da.UpdateCommand = New OleDbCommand("UPDATE mesas SET ocupada=@ocu WHERE id_mesa=" & numeroMesa, Conexion)
        da.UpdateCommand.Parameters.Add("@ocu", OleDbType.Boolean, 10, "ocupada")
        da.Update(ds.Tables("Mesas"))
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
End Class