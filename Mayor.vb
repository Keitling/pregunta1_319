Public Class Mayor

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Integer

        a = Convert.ToInt32(TextBox1.Text)
        b = Convert.ToInt32(TextBox2.Text)
        c = Convert.ToInt32(TextBox3.Text)

        If a > b Then GoTo a_mayor Else GoTo b_mayor
a_mayor:
        TextBox4.Text = "a es mayor"
        GoTo Final

b_mayor:
        If b > c Then GoTo a_mayor Else GoTo c_mayor
        TextBox4.Text = "b es mayor"
        GoTo Final
c_mayor:
        TextBox4.Text = "c es mayor"
        GoTo Final


Final:

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

       
