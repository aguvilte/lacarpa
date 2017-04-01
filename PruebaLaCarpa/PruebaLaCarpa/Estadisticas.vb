Imports System.Data.OleDb

Public Class Estadisticas

    Private ds As DataSet

    Private dr As OleDbDataReader
    Private comando As OleDbCommand

    Private diaActual As Integer
    Private mesActual As Integer
    Private añoActual As Integer
    Private montoTotal As Integer = 0


    Private Sub cbItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbItems.SelectedIndexChanged
        Conectarse()

        ds = New DataSet

        Select Case cbItems.Text
            Case "Último día"
                comando = New OleDbCommand("SELECT monto FROM ventas WHERE fecha BETWEEN '" & diaActual - 1 & "/" & mesActual & "/" & añoActual & " 21:00' AND '" & Date.Now & "'", Conexion)
            Case "Última semana"
                comando = New OleDbCommand("SELECT monto FROM ventas WHERE fecha BETWEEN '" & diaActual - 7 & "/" & mesActual & "/" & añoActual & " 21:00' AND '" & Date.Now & "'", Conexion)
            Case "Último mes"
                comando = New OleDbCommand("SELECT monto FROM ventas WHERE fecha BETWEEN '1/" & mesActual & "/" & añoActual & " 21:00' AND '" & Date.Now & "'", Conexion)
        End Select

        dr = comando.ExecuteReader()
        If dr.HasRows Then
            While dr.Read()
                montoTotal += dr("monto")
            End While
        End If

        lblEstadistica.Text = "Monto total: "
        lblEstadistica.Text += "$" & montoTotal
        montoTotal = 0

        dr.Close()

        Desconectarse()
    End Sub

    Private Sub Estadísticas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        diaActual = Date.Now.Day
        mesActual = Date.Now.Month
        añoActual = Date.Now.Year
    End Sub
End Class