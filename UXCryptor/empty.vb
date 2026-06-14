Public Class empty
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub empty_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
    End Sub
End Class