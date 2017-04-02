Imports System.Data.OleDb


Public Class PrNuevoEdit


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        NuevoProducto.Show()
        Me.Hide()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ProductoEliminar.Show()
        Me.Hide()
<<<<<<< HEAD
    End Sub

    Private Sub tbPrecioNuevo_TextChanged(sender As Object, e As EventArgs) Handles tbPrecioNuevo.TextChanged
        If tbPrecioNuevo.Text = "" Then
            btnModificar.Enabled = False
        Else
            btnModificar.Enabled = True
        End If
=======
>>>>>>> origin/ricardo
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Principal.Show()
        Me.Close()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        EditarProducto.Show()
        Me.Hide()
    End Sub

    Private Sub PrNuevoEdit_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Principal.Show()
    End Sub

    Private Sub PrNuevoEdit_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Principal.Show()
    End Sub

End Class