Imports System.Drawing.Text

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Merhaba Dünya")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label2.Text = "Büşra"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label6.Text = "Büşra"
        Label7.Text = "KARA"
        Label8.Text = "Öğrenci"

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox2.Text = "Sizi Seviyorum"
        Label9.Text = TextBox2.Text
    End Sub
End Class
