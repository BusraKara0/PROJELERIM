Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ComboBox1.Items.Add("Antalya")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        ComboBox1.Items.Add(TextBox1.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Add("Kasiyer")
        ListBox1.Items.Add("Futbolcu")
        ListBox1.Items.Add("Muhasebeci")
        ListBox1.Items.Add("Antrenör")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Add(TextBox2.Text)
    End Sub
End Class
