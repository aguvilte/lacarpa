Imports System.Data.OleDb

Public Class Mesas

    Private daMesasProductos As OleDbDataAdapter
    Private daMesas As OleDbDataAdapter
    Private daProductos As OleDbDataAdapter
    Private daTiposProductos As OleDbDataAdapter
    Private daBebidas As OleDbDataAdapter
    Private daTiposBebidas As OleDbDataAdapter
    Private daVentas As OleDbDataAdapter
    Private daPrecio As OleDbDataAdapter
    Private daStock As OleDbDataAdapter
    Private daStock2 As OleDbDataAdapter
    Private daMesasProductos2 As OleDbDataAdapter

    Private dr As OleDbDataReader

    Private ds As DataSet

    Private vistaDatos As New DataView
    Private vistaDatos2 As New DataView

    Private dataReader As OleDbDataReader

    Dim comando As OleDbCommand

    Public nuevoPedido As Boolean = True
    Private mesaOcupadaBoolean As Boolean = False

    Public indiceProducto As Integer
    Public indiceBebida As Integer
    Public cantidadProducto As Integer
    Public cantidadBebida
    Public numeroMesa As Integer
    Public idVenta As Integer
    Public idProd As Integer
    Public montoTotal As Integer
    Public cantidadStock As Integer
    Public posicionfila As Integer

    Private Sub Mesas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectarse()

        For i As Integer = 0 To 51
            If i = Principal.NumeroMesa Then
                numeroMesa = i
            End If
        Next

        MesaTienePedido()

        Me.Text = "Mesa " & numeroMesa
        posicionfila = 0
        'PASO 1
        daMesasProductos = New OleDbDataAdapter
        daMesasProductos.SelectCommand = New OleDbCommand("SELECT nombre, tipo_producto FROM productos INNER JOIN mesas_productos ON productos.id_producto = mesas_productos.id_producto WHERE id_mesa=" & numeroMesa, ConnectionDB.Conexion)

        daProductos = New OleDbDataAdapter
        daProductos.SelectCommand = New OleDbCommand("SELECT nombre FROM productos", ConnectionDB.Conexion)

        'PASO 2
        ds = New DataSet
        ds.Tables.Add("MesasProductos")

        ds.Tables.Add("Productos")

        daMesasProductos.Fill(ds.Tables("MesasProductos"))
        daProductos.Fill(ds.Tables("Productos"))

        vistaDatos = ds.Tables("MesasProductos").DefaultView
        dgvProductos.DataSource = vistaDatos

        dgvProductos.Columns(0).HeaderText = "Nombre"
        dgvProductos.Columns(1).HeaderText = "Tipo"

        dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        cbNombreProd.DataSource = ds.Tables("Productos").DefaultView

        cbNombreProd.ValueMember = "nombre"

        indiceProducto = cbNombreProd.SelectedIndex + 1

        cbNombreProd.Text = ""
        cbTipoProd.Text = ""
        cbTipoProd.MaxDropDownItems = 3

        cantidadProducto = CInt(tbCantProd.Text)

        Monto()
        Desconectarse()

        cbNombreProd.Focus()
    End Sub

    Private Sub cbNombreProd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbNombreProd.SelectedIndexChanged
        If cbNombreProd.SelectedIndex >= 0 And cbNombreProd.Text IsNot Nothing Then
            cbTipoProd.Enabled = True
        End If

        ds = New DataSet

        'PARA COMIDAS
        ds.Tables.Add("TiposProductos")

        indiceProducto = cbNombreProd.SelectedIndex + 1

        daTiposProductos = New OleDbDataAdapter
        daTiposProductos.SelectCommand = New OleDbCommand("SELECT tipo_producto FROM productos_tipos WHERE id_producto =" & indiceProducto, Conexion)

        daTiposProductos.Fill(ds.Tables("TiposProductos"))

        cbTipoProd.DataSource = ds.Tables("TiposProductos").DefaultView
        cbTipoProd.ValueMember = "tipo_producto"

    End Sub

    Private Sub btnCerrarPedido_Click(sender As Object, e As EventArgs) Handles btnCerrarPedido.Click
        mesaOcupadaBoolean = False
        MesaOcupada()

        If MsgBox("¿Está seguro que quiere cerrar el pedido?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            ds = New DataSet
            ds.Tables.Add("Ventas")
            ds.Tables.Add("MesasProductos")

            Dim row As DataRow

            row = ds.Tables("Ventas").NewRow

            daVentas = New OleDbDataAdapter
            daVentas.InsertCommand = New OleDbCommand("INSERT INTO ventas (fecha, monto) VALUES ('" & DateTime.Now.ToString & "', " & montoTotal & ")", Conexion)

            ds.Tables("Ventas").Rows.Add(row)

            daVentas.Update(ds.Tables("Ventas"))

            daMesasProductos.SelectCommand = New OleDbCommand("SELECT nombre, tipo_producto FROM productos INNER JOIN mesas_productos ON productos.id_producto = mesas_productos.id_producto WHERE id_mesa=" & numeroMesa, Conexion)

            daMesasProductos.Fill(ds.Tables("MesasProductos"))
            ds.Tables("MesasProductos").Rows(posicionfila).Delete()

            daMesasProductos.DeleteCommand = New OleDbCommand("DELETE FROM mesas_productos WHERE id_mesa = " & numeroMesa, Conexion)

            daMesasProductos.Update(ds.Tables("MesasProductos"))

            Me.Close()
            Principal.Show()

        End If
    End Sub

    Public Sub Monto()
        Conectarse()

        comando = New OleDbCommand("SELECT precio FROM productos_tipos INNER JOIN mesas_productos ON productos_tipos.id_producto = mesas_productos.id_producto And productos_tipos.tipo_producto = mesas_productos.tipo_producto WHERE mesas_productos.id_mesa = " & numeroMesa, Conexion)

        montoTotal = 0

        dr = comando.ExecuteReader()

        If dr.HasRows Then
            While dr.Read
                montoTotal += dr("precio")
            End While
        End If

        btnCerrarPedido.Text = "Cerrar pedido - Monto total: $" & montoTotal

        Desconectarse()

    End Sub

    Public Sub MesaOcupada()
        Dim row2 As DataRow

        daMesas = New OleDbDataAdapter
        daMesas.SelectCommand = New OleDbCommand("SELECT * FROM mesas", Conexion)

        ds.Tables.Add("Mesas")
        daMesas.Fill(ds.Tables("Mesas"))

        row2 = ds.Tables("Mesas").Rows(0)
        If mesaOcupadaBoolean = True Then
            row2("ocupada") = -1
        Else
            row2("ocupada") = 0
        End If

        daMesas.UpdateCommand = New OleDbCommand("UPDATE mesas SET ocupada=@ocu WHERE id_mesa=" & numeroMesa, Conexion)
        daMesas.UpdateCommand.Parameters.Add("@ocu", OleDbType.Boolean, 10, "ocupada")

        daMesas.Update(ds.Tables("Mesas"))
    End Sub

    Private Sub btnAgregarProd_Click(sender As Object, e As EventArgs) Handles btnAgregarProd.Click

        Conectarse()

        Dim row As DataRow
        Dim index As Integer
        Dim cantidad As Integer = CInt(tbCantProd.Text)

        If cantidad > 0 Then
            ds = New DataSet
            ds.Tables.Add("MesasProductos")
            ds.Tables.Add("MesasProductos2")

            daMesasProductos = New OleDbDataAdapter
            daMesasProductos.SelectCommand = New OleDbCommand("SELECT * FROM mesas_productos WHERE id_mesa=" & numeroMesa, Conexion)

            daMesasProductos.Fill(ds.Tables("MesasProductos"))

            Select Case cbNombreProd.Text
                Case "Lomito común"
                    idProd = 1
                Case "Lomito especial"
                    idProd = 2
                Case "Hamburguesa común"
                    idProd = 3
                Case "Hamburguesa especial"
                    idProd = 4
                Case "Barroluco"
                    idProd = 5
                Case "Superlomo doble"
                    idProd = 6
                Case "Coca Cola"
                    idProd = 7
                Case "Sprite"
                    idProd = 8
                Case "Fanta"
                    idProd = 9
                Case "Aquarius"
                    idProd = 10
                Case "Quilmes"
                    idProd = 11
                Case "Budweiser"
                    idProd = 12
                Case "Corona"
                    idProd = 13
                Case "Heineken"
                    idProd = 14
                Case "Stella Artois"
                    idProd = 15
                Case "Imperial"
                    idProd = 16
                Case "Stou"
                    idProd = 17
                Case "Iguana"
                    idProd = 18
                Case "Patagonia"
                    idProd = 19
                Case "Salta Negra"
                    idProd = 20
                Case "Boca ancha"
                    idProd = 21
                Case "ChoP"
                    idProd = 22
                Case "Agua"
                    idProd = 23
            End Select

            cantidadStock = 0

            For index = 1 To cantidad
                row = ds.Tables("MesasProductos").NewRow
                row("id_mesa") = numeroMesa
                row("id_producto") = idProd
                row("tipo_producto") = cbTipoProd.Text.ToString

                ds.Tables("MesasProductos").Rows.Add(row)

                daMesasProductos = New OleDbDataAdapter
                daMesasProductos.InsertCommand = New OleDbCommand("INSERT INTO mesas_productos (id_mesa, id_producto, tipo_producto) VALUES (@idMesa, @idProd, @tipoProd)", Conexion)
                daMesasProductos.InsertCommand.Parameters.Add("@idMesa", OleDbType.BigInt, 3, "id_mesa")
                daMesasProductos.InsertCommand.Parameters.Add("@idProd", OleDbType.BigInt, 1, "id_producto")
                daMesasProductos.InsertCommand.Parameters.Add("@tipoProd", OleDbType.VarChar, 30, "tipo_producto")

                cantidadStock += 150
            Next

            daMesasProductos.Update(ds.Tables("MesasProductos"))
        Else
            MsgBox("CALLATE, GASPAR CULIAO")
        End If

        dgvProductos.DataSource = Nothing

        daMesasProductos2 = New OleDbDataAdapter
        daMesasProductos2.SelectCommand = New OleDbCommand("SELECT nombre, tipo_producto FROM productos INNER JOIN mesas_productos ON productos.id_producto = mesas_productos.id_producto WHERE id_mesa=" & numeroMesa, Conexion)

        daMesasProductos2.Fill(ds.Tables("MesasProductos2"))

        vistaDatos = ds.Tables("MesasProductos2").DefaultView
        dgvProductos.DataSource = vistaDatos

        dgvProductos.Columns(0).HeaderText = "Nombre de producto"
        dgvProductos.Columns(1).HeaderText = "Tipo de producto"


        If cbTipoProd.Text = "Carne" Or cbTipoProd.Text = "Pollo" Or cbTipoProd.Text = "Cerdo" Then

            daStock = New OleDbDataAdapter
            daStock2 = New OleDbDataAdapter
            ds.Tables.Add("Stock")

            daStock2.SelectCommand = New OleDbCommand("SELECT * FROM stock WHERE nombre = '" & cbTipoProd.Text & "'", Conexion)

            daStock2.Fill(ds.Tables("Stock"))

            cantidadStock = ds.Tables("Stock").Rows(0)("cantidad") - cantidadStock

            row = ds.Tables("Stock").Rows(0)

            row("nombre") = cbTipoProd.Text
            row("cantidad") = cantidadStock

            daStock.UpdateCommand = New OleDbCommand("UPDATE stock SET cantidad= @cant WHERE nombre = @nom", Conexion)
            daStock.UpdateCommand.Parameters.Add("@cant", OleDbType.BigInt, 5, "cantidad")
            daStock.UpdateCommand.Parameters.Add("@nom", OleDbType.VarChar, 10, "nombre")

            daStock.Update(ds.Tables("Stock"))
        End If

        Monto()
        Desconectarse()

        mesaOcupadaBoolean = True
        MesaOcupada()
        'btnCerrarPedido.Enabled = True
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Principal.Show()
        Me.Close()
    End Sub

    Private Sub MesaTienePedido()
        Conectarse()

        comando = New OleDbCommand("SELECT * FROM mesas_productos WHERE id_mesa=" & numeroMesa, Conexion)

        dataReader = comando.ExecuteReader()

        If dataReader.HasRows Then
            btnCerrarPedido.Enabled = True
        Else
            btnCerrarPedido.Enabled = False
        End If

        dataReader.Close()
        Desconectarse()
    End Sub
End Class