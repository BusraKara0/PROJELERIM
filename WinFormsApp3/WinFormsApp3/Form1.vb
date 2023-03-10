Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add(MaskedTextBox1.Text + " " + MaskedTextBox2.Text + " " + MaskedTextBox3.Text + " " + MaskedTextBox4.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Add(DateTimePicker1.Text)
    End Sub
End Class
