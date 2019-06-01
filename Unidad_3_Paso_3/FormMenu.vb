Public Class FormMenu

    Private Sub RegisterStudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterStudentsToolStripMenuItem.Click
        Hide()
        Dim formRegisterStudent = New FormRegisterStudent
        formRegisterStudent.ShowDialog()
    End Sub

    Private Sub FormMenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class