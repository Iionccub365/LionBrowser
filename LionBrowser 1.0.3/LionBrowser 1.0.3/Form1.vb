Public Class Form1
    Private b21 As Object

    Private Sub b11_Click(sender As Object, e As EventArgs) Handles b11.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub b12_Click(sender As Object, e As EventArgs) Handles b12.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub b13_Click(sender As Object, e As EventArgs) Handles b13.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub b14_Click(sender As Object, e As EventArgs) Handles b14.Click
        WebBrowser1.Navigate("sites.google.com/view/lionbrowser/home")
    End Sub

    Private Sub b15_Click(sender As Object, e As EventArgs) Handles b15.Click
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("sites.google.com/view/lionbrowser/home")
        WebBrowser1.BringToFront()
        TextBox1.BringToFront()
        b11.BringToFront()
        b12.BringToFront()
        b13.BringToFront()
        b14.BringToFront()
        b15.BringToFront()
    End Sub

    Private Sub Tab1_Click(sender As Object, e As EventArgs) Handles Tab1.Click
        WebBrowser1.BringToFront()
        TextBox1.BringToFront()
        b11.BringToFront()
        b12.BringToFront()
        b13.BringToFront()
        b14.BringToFront()
        b15.BringToFront()
    End Sub
    Private Sub b2_Click(sender As Object, e As EventArgs) Handles b2.Click
        WebBrowser2.GoBack()
    End Sub

    Private Sub b22_Click(sender As Object, e As EventArgs) Handles b22.Click
        WebBrowser2.GoForward()
    End Sub

    Private Sub b23_Click(sender As Object, e As EventArgs) Handles b23.Click
        WebBrowser2.Refresh()
    End Sub

    Private Sub b24_Click(sender As Object, e As EventArgs) Handles b24.Click
        WebBrowser2.Navigate("sites.google.com/view/lionbrowser/home")
    End Sub

    Private Sub b25_Click(sender As Object, e As EventArgs) Handles b25.Click
        WebBrowser2.Navigate(TextBox2.Text)
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        TextBox2.Text = ""
    End Sub

    Private Sub Tab2_Click(sender As Object, e As EventArgs) Handles Tab2.Click
        WebBrowser2.BringToFront()
        TextBox2.BringToFront()
        b2.BringToFront()
        b22.BringToFront()
        b23.BringToFront()
        b24.BringToFront()
        b25.BringToFront()
    End Sub
End Class