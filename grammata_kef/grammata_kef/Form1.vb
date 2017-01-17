Imports System.Text.RegularExpressions
Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim letters As Regex = New Regex("[^\p{IsGreek}]")

        TextBox1.Text = TextBox1.Text.ToUpper()
        TextBox1.Text = letters.Replace(TextBox1.Text, "")



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub
End Class
