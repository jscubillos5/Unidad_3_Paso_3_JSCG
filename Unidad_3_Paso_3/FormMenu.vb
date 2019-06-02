Public Class FormMenu

#Region "Funcionalidades del ménu principal"

    Private Sub RegisterStudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterStudentsToolStripMenuItem.Click
        Hide()
        ' Dar acceso al formulario seleciconado, JSCG, UNAD, 20190601
        Dim formRegisterStudent = New FormRegisterStudent
        formRegisterStudent.ShowDialog()
    End Sub

    Private Sub FormMenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub ModifyStudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifyStudentsToolStripMenuItem.Click
        Hide()
        Dim formModifyStudent = New FormModifyStudent
        ' Mostrar el formulario seleciconado, JSCG, UNAD, 20190601
        formModifyStudent.ShowDialog()
    End Sub

    Private Sub DeleteStudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteStudentsToolStripMenuItem.Click
        ' Ocultar el formulario actual, JSCG, UNAD, 20190601
        Hide()
        Dim formDeleteStudent = New FormDeleteStudent
        formDeleteStudent.ShowDialog()
    End Sub

    Private Sub SearchStudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchStudentsToolStripMenuItem.Click
        Hide()
        Dim formSearchStudent = New FormSearchStudent
        formSearchStudent.ShowDialog()
    End Sub

#End Region

End Class