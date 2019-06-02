Public Class FormSearchStudent

#Region "Funcionalidades del formulario"

    Private Sub FormSearchStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PERSONTableAdapter.Fill(STUDENTSDataSet.PERSON)
    End Sub

    Private Sub FormSearchStudent_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FormMenu.Show()
    End Sub

    ' Permitir al usuario buscar un estudiante, por medio de los valores digitados, este tipo de busqueda se conoce como incremental, JSCG, UNAD, 20190601
    Private Sub ToolStripTextBoxFormSearchStudent_KeyDown(sender As Object, e As KeyEventArgs) Handles ToolStripTextBoxFormSearchStudent.KeyDown
        Try
            If ToolStripTextBoxFormSearchStudent.TextLength > 0 Then
                ' Filtrar el origen de datos, JSCG, UNAD, 20190601
                PERSONBindingSource.Filter = "FIRST_NAME like '%" & ToolStripTextBoxFormSearchStudent.Text.Replace("'", "''") & "%'"
            Else
                ' Quitar el filtro, JSCG, UNAD, 20190601
                PERSONBindingSource.Filter = ""
            End If
        Catch ex As Exception
            MessageBox.Show("Atención, señor usuario ocurrio un error al buscar el estudiante, el error especifico es: " + ex.Message, "Error al buscar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

End Class