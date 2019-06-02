Imports System.Data.SqlClient

Public Class FormDeleteStudent

#Region "Funcionalidades del formulario"

    ' Al cerrar ir al formulario principal, JSCG, UNAD, 20190601
    Private Sub FormDeleteStudent_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FormMenu.Show()
    End Sub

    Private Sub FormDeleteStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar los estudiantes del sistema, JSCG, UNAD, 20190601
        PERSONTableAdapter.Fill(STUDENTSDataSet.PERSON)
    End Sub

    Private Sub DataGridViewFormDeleteStudent_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewFormDeleteStudent.CellClick
        ' Seleccionar el estudiante a borrar, JSCG, UNAD, 20190601
        If e.RowIndex >= 0 Then
            Dim identificationNumber As String = DataGridViewFormDeleteStudent.Item(0, e.RowIndex).Value.ToString.Trim
            Dim DBConnection As New SqlConnection(Configuration.ConfigurationManager.ConnectionStrings("Unidad_3_Paso_3.My.MySettings.STUDENTSConnectionString").ConnectionString)
            Dim db = New DataClassesSTUDENTSDataContext(DBConnection)
            ' Buscar el estudiante, JSCG, UNAD, 20190601
            Dim queryPerson = (From persons In db.PERSON Where persons.IDENTIFICATION_DOCUMENT = identificationNumber Select New With {.ID_PERSON = persons.ID_PERSON, .FIRST_NAME = persons.FIRST_NAME, .SURNAME = persons.SURNAME}).FirstOrDefault
            ' Confirmar la eliminación, JSCG, UNAD, 20190601
            Dim selection As DialogResult = MessageBox.Show("¿Está seguro?, esto eliminará al estudiante. Nombre: " + queryPerson.FIRST_NAME.Trim + " Apellido: " + queryPerson.SURNAME.Trim, "Confirmar salir evaluación primer nivel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If selection = vbYes Then
                Try
                    ' Borrar con LINQ to SQL, el estudiante, JSCG, UNAD, 20190601
                    Dim queryDeletePerson = (From person In db.PERSON Where person.ID_PERSON = queryPerson.ID_PERSON Select person).FirstOrDefault
                    db.PERSON.DeleteOnSubmit(queryDeletePerson)
                    db.SubmitChanges()
                    ' Refrescar los obetos del formulario, JSCG, UNAD, 20190601
                    PERSONTableAdapter.Fill(STUDENTSDataSet.PERSON)
                    DataGridViewFormDeleteStudent.Refresh()
                    MessageBox.Show("El estudiante, Nombre:" + queryPerson.FIRST_NAME.Trim + " Apellido: " + queryPerson.SURNAME.Trim + ". Fue eliminado con éxito.", "Estudiante eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Atención, señor usuario ocurrio un error al eliminar el estudiante, el error especifico es: " + ex.Message, "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

#End Region

End Class