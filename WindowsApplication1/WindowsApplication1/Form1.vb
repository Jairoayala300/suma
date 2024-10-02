Public Class Form1

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Lblnum1.Click

    End Sub

    Private Sub Txtnum1_TextChanged(sender As Object, e As EventArgs) Handles Txtnum1.TextChanged

    End Sub

    Private Sub Btncalcular_Click(sender As Object, e As EventArgs) Handles Btncalcular.Click
        Txtres.Text = Val(Txtnum1.Text) + Val(Txtnum2.Text)
    End Sub
End Class
