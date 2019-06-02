Public Class FormMenu

    Private Sub RegisterStudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterStudentsToolStripMenuItem.Click
        Hide()
        Dim formRegisterStudent = New FormRegisterStudent
        formRegisterStudent.ShowDialog()
    End Sub

    Private Sub FormMenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub ModifyStudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifyStudentsToolStripMenuItem.Click
        Hide()
        Dim formModifyStudent = New FormModifyStudent
        formModifyStudent.ShowDialog()
    End Sub

    Private Sub DeleteStudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteStudentsToolStripMenuItem.Click
        Hide()
        Dim formDeleteStudent = New FormDeleteStudent
        formDeleteStudent.ShowDialog()
    End Sub
End Class