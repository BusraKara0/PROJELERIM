Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add(TextBox1.Text + " " + TextBox2.Text + " " + MaskedTextBox1.Text + " " + MaskedTextBox2.Text + " " + ComboBox1.Text + " " + DateTimePicker1.Text)
    End Sub
End Class
