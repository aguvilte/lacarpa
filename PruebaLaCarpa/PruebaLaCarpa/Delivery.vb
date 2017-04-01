Imports System.Data.OleDb

Public Class Delivery

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
        ActivarBotonCerrarPedido()

        For i As Integer = 200 To 403
            If i = Principal.NumeroMesa Then
                numeroMesa = i
            End If
        Next
        Me.Text = "Delivery " & numeroMesa

        ds = New DataSet
        da = New OleDbDataAdapter
        CompletarDataGridView()

        'SE COMPLETA EL cbNombreProductos CON LOS PRODUCTOS DISPONIBLES
        ds.Tables.Add("Productos")
        da.SelectCommand = New OleDbCommand("SELECT nombre FROM productos", Conexion)
        da.Fill(ds.Tables("Productos"))
        cbNombreProd.DataSource = ds.Tables("Productos").DefaultView
        cbNombreProd.ValueMember = "nombre"
        cbNombreProd.Text = ""
        cbTipoProd.Text = ""
        cantidadProducto = CInt(tbCantProd.Text)

        btnAgregarProd1.Visible = False
        btnAgregarProd2.Visible = False
        btnAgregarProd3.Visible = False

        dgvProductos1.DataSource = ""
        dgvProductos2.DataSource = ""
        dgvProductos3.DataSource = ""

        'ACTUALIZA MONTO DEL PEDIDO ACTUAL
        CalculaMonto(numeroMesa)
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Desconectarse()
        Principal.Show()
        Me.Close()
    End Sub

    Private Sub cbNombreProd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbNombreProd.SelectedIndexChanged

        BuscarIndiceProducto()
        If cbNombreProd.Text = "" Then
            btnAgregarProd1.Visible = False
            btnAgregarProd2.Visible = False
            btnAgregarProd3.Visible = False
        Else
            btnAgregarProd1.Visible = True
            btnAgregarProd2.Visible = True
            btnAgregarProd3.Visible = True
        End If

        'SE COMPLETA EL cbTipoProductos CON LOS TIPOS DE PRODUCTOS DISPONIBLES
        ds = New DataSet
        ds.Tables.Add("TiposProductos")
        da.SelectCommand = New OleDbCommand("SELECT tipo_producto FROM productos_tipos WHERE id_producto =" & indiceProducto, Conexion)
        da.Fill(ds.Tables("TiposProductos"))
        cbTipoProd.DataSource = ds.Tables("TiposProductos").DefaultView
        cbTipoProd.ValueMember = "tipo_producto"


    End Sub

    Private Sub btnCerrarPedido1_Click(sender As Object, e As EventArgs) Handles btnCerrarPedido1.Click
        Select Case numeroMesa
            Case 200
                CerrarPedido(200)
            Case 300
                CerrarPedido(300)
            Case 400
                CerrarPedido(400)
        End Select
    End Sub

    Private Sub btnCerrarPedido2_Click(sender As Object, e As EventArgs) Handles btnCerrarPedido2.Click
        Select Case numeroMesa
            Case 200
                CerrarPedido(201)
            Case 300
                CerrarPedido(301)
            Case 400
                CerrarPedido(401)
        End Select
    End Sub

    Private Sub btnCerrarPedido3_Click(sender As Object, e As EventArgs) Handles btnCerrarPedido3.Click
        Select Case numeroMesa
            Case 200
                CerrarPedido(202)
            Case 300
                CerrarPedido(302)
            Case 400
                CerrarPedido(402)
        End Select
    End Sub

    Private Sub btnAgregarProd1_Click(sender As Object, e As EventArgs) Handles btnAgregarProd1.Click
        Select Case numeroMesa
            Case 200
                AgregarProducto(200)
            Case 300
                AgregarProducto(300)
            Case 400
                AgregarProducto(400)
        End Select
    End Sub

    Private Sub btnAgregarProd2_Click(sender As Object, e As EventArgs) Handles btnAgregarProd2.Click
        Select Case numeroMesa
            Case 200
                AgregarProducto(201)
            Case 300
                AgregarProducto(301)
            Case 400
                AgregarProducto(401)
        End Select
    End Sub

    Private Sub btnAgregarProd3_Click(sender As Object, e As EventArgs) Handles btnAgregarProd3.Click
        Select Case numeroMesa
            Case 200
                AgregarProducto(202)
            Case 300
                AgregarProducto(302)
            Case 400
                AgregarProducto(402)
        End Select
    End Sub

    Private Function CalculaMonto(numero As Integer)
        Dim devuelveMonto As Integer
        Dim numeroOriginal As Integer = numero
        For i As Integer = 0 To 2
            montoTotal = 0
            comando = New OleDbCommand("SELECT precio FROM productos_tipos INNER JOIN mesas_productos ON productos_tipos.id_producto = mesas_productos.id_producto And productos_tipos.tipo_producto = mesas_productos.tipo_producto WHERE mesas_productos.id_mesa = " & numero, Conexion)
            dr = comando.ExecuteReader()
            If dr.HasRows Then
                While dr.Read
                    montoTotal += dr("precio")
                End While
            Else
                If numero = 200 Or numero = 300 Or numero = 400 Then
                    btnCerrarPedido1.Enabled = False
                ElseIf numero = 201 Or numero = 301 Or numero = 401 Then
                    btnCerrarPedido2.Enabled = False
                ElseIf numero = 202 Or numero = 302 Or numero = 402 Then
                    btnCerrarPedido3.Enabled = False
                End If
            End If

            If numero = 200 Or numero = 300 Or numero = 400 Then
                btnCerrarPedido1.Text = "Cerrar pedido - Monto total: $" & montoTotal
                If numero = numeroOriginal Then
                    devuelveMonto = montoTotal
                End If
            ElseIf numero = 201 Or numero = 301 Or numero = 401 Then
                btnCerrarPedido2.Text = "Cerrar pedido - Monto total: $" & montoTotal
                If numero = numeroOriginal Then
                    devuelveMonto = montoTotal
                End If
            ElseIf numero = 202 Or numero = 302 Or numero = 402 Then
                btnCerrarPedido3.Text = "Cerrar pedido - Monto total: $" & montoTotal
                If numero = numeroOriginal Then
                    devuelveMonto = montoTotal
                End If
            End If

            numero += 1
        Next
        Return devuelveMonto
    End Function

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

    Private Sub CerrarPedido(numero As Integer)
        mesaOcupadaBoolean = False

        If MsgBox("¿Está seguro que quiere cerrar el pedido?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            ds = New DataSet
            ds.Tables.Add("Ventas")
            ds.Tables.Add("MesasProductos")

            Dim row As DataRow
            row = ds.Tables("Ventas").NewRow

            da.InsertCommand = New OleDbCommand("INSERT INTO ventas (fecha, monto) VALUES ('" & DateTime.Now.ToString & "', " & CalculaMonto(numero) & ")", Conexion)
            ds.Tables("Ventas").Rows.Add(row)
            da.Update(ds.Tables("Ventas"))

            da.SelectCommand = New OleDbCommand("SELECT nombre, tipo_producto FROM productos INNER JOIN mesas_productos ON productos.id_producto = mesas_productos.id_producto WHERE id_mesa=" & numero, Conexion)
            da.Fill(ds.Tables("MesasProductos"))
            ds.Tables("MesasProductos").Rows(0).Delete()
            da.DeleteCommand = New OleDbCommand("DELETE FROM mesas_productos WHERE id_mesa = " & numero, Conexion)
            da.Update(ds.Tables("MesasProductos"))

            'PintarMesaOcupada()
            If numero = 200 Or numero = 300 Or numero = 400 Then
                dgvProductos1.DataSource = ""
                btnCerrarPedido1.Text = "Cerrar pedido - Monto total: $0"
                btnCerrarPedido1.Enabled = False
            ElseIf numero = 201 Or numero = 301 Or numero = 401 Then
                dgvProductos2.DataSource = ""
                btnCerrarPedido2.Text = "Cerrar pedido - Monto total: $0"
                btnCerrarPedido2.Enabled = False
            ElseIf numero = 202 Or numero = 302 Or numero = 402 Then
                dgvProductos3.DataSource = ""
                btnCerrarPedido3.Text = "Cerrar pedido - Monto total: $0"
                btnCerrarPedido3.Enabled = False
            End If
        End If
    End Sub

    Private Sub AgregarProducto(numero As Integer)
        mesaOcupadaBoolean = True

        Dim row As DataRow
        Dim index As Integer
        Dim cantidad As Integer = CInt(tbCantProd.Text)

        'btnCerrarPedido.Enabled = True

        If cantidad > 0 Then
            ds = New DataSet
            ds.Tables.Add("MesasProductos")
            da.SelectCommand = New OleDbCommand("SELECT * FROM mesas_productos WHERE id_mesa=" & numero, Conexion)
            da.Fill(ds.Tables("MesasProductos"))

            BuscarIndiceProducto()

            cantidadStock = 0

            For index = 1 To cantidad
                row = ds.Tables("MesasProductos").NewRow
                row("id_mesa") = numero
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
        da.SelectCommand = New OleDbCommand("SELECT nombre, tipo_producto FROM productos INNER JOIN mesas_productos ON productos.id_producto = mesas_productos.id_producto WHERE id_mesa=" & numero, Conexion)
        da.Fill(ds.Tables("MesasProductos2"))

        If numero = 200 Or numero = 300 Or numero = 400 Then
            dgvProductos1.DataSource = ds.Tables("MesasProductos2").DefaultView
            dgvProductos1.Columns(0).HeaderText = "Nombre de producto"
            dgvProductos1.Columns(1).HeaderText = "Tipo de producto"
            btnCerrarPedido1.Enabled = True
        ElseIf numero = 201 Or numero = 301 Or numero = 401 Then
            dgvProductos2.DataSource = ds.Tables("MesasProductos2").DefaultView
            dgvProductos2.Columns(0).HeaderText = "Nombre de producto"
            dgvProductos2.Columns(1).HeaderText = "Tipo de producto"
            btnCerrarPedido2.Enabled = True
        Else
            dgvProductos3.DataSource = ds.Tables("MesasProductos2").DefaultView
            dgvProductos3.Columns(0).HeaderText = "Nombre de producto"
            dgvProductos3.Columns(1).HeaderText = "Tipo de producto"
            btnCerrarPedido3.Enabled = True
        End If

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

        CalculaMonto(numero)
        'PintarMesaOcupada()
    End Sub

    Private Sub ActivarBotonCerrarPedido()
        numeroMesa = 100
        For i As Integer = 1 To 4
            comando = New OleDbCommand("SELECT * FROM mesas_productos WHERE id_mesa=" & numeroMesa, Conexion)
            dr = comando.ExecuteReader()
            If dr.HasRows Then
                Select Case numeroMesa
                    Case 200 Or 300 Or 400
                        btnCerrarPedido1.Enabled = True
                    Case 201 Or 301 Or 401
                        btnCerrarPedido2.Enabled = True
                    Case 202 Or 302 Or 402
                        btnCerrarPedido3.Enabled = True
                End Select
            Else
                Select Case numeroMesa
                    Case 200 Or 300 Or 400
                        btnCerrarPedido1.Enabled = False
                    Case 201 Or 301 Or 401
                        btnCerrarPedido2.Enabled = False
                    Case 202 Or 302 Or 402
                        btnCerrarPedido3.Enabled = False
                End Select
            End If
            numeroMesa += 1
        Next

    End Sub

    Private Sub CompletarDataGridView()
        ds.Tables.Add("MesasProductos1")
        da.SelectCommand = New OleDbCommand("SELECT nombre, tipo_producto FROM productos INNER JOIN mesas_productos ON productos.id_producto = mesas_productos.id_producto WHERE id_mesa=" & numeroMesa, Conexion)
        da.Fill(ds.Tables("MesasProductos1"))
        dgvProductos1.DataSource = ds.Tables("MesasProductos1").DefaultView
        dgvProductos1.Columns(0).HeaderText = "Nombre"
        dgvProductos1.Columns(1).HeaderText = "Tipo"
        dgvProductos1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ds.Tables.Add("MesasProductos2")
        numeroMesa += 1
        da.SelectCommand = New OleDbCommand("SELECT nombre, tipo_producto FROM productos INNER JOIN mesas_productos ON productos.id_producto = mesas_productos.id_producto WHERE id_mesa=" & numeroMesa, Conexion)
        da.Fill(ds.Tables("MesasProductos2"))
        dgvProductos2.DataSource = ds.Tables("MesasProductos2").DefaultView
        dgvProductos2.Columns(0).HeaderText = "Nombre"
        dgvProductos2.Columns(1).HeaderText = "Tipo"
        dgvProductos2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ds.Tables.Add("MesasProductos3")
        numeroMesa += 1
        da.SelectCommand = New OleDbCommand("SELECT nombre, tipo_producto FROM productos INNER JOIN mesas_productos ON productos.id_producto = mesas_productos.id_producto WHERE id_mesa=" & numeroMesa, Conexion)
        da.Fill(ds.Tables("MesasProductos3"))
        dgvProductos3.DataSource = ds.Tables("MesasProductos3").DefaultView
        dgvProductos3.Columns(0).HeaderText = "Nombre"
        dgvProductos3.Columns(1).HeaderText = "Tipo"
        dgvProductos3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        numeroMesa -= 2
    End Sub

End Class