Public Class Presentacion
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        contador = contador + Timer1.Interval
        If contador = 2500 Then
            Login.Show()
            Me.Hide()
        End If
    End Sub

    Dim contador As Integer = 0

    Private Sub Presentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer1.Interval = 500
    End Sub
End Class