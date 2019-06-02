Imports System.Data.SqlClient

Public Class FormModifyStudent

#Region "Variables y constantes del formulario"

    Private student As PERSON
    Private Const TEXT_SELECT = "Seleccionar"

#End Region

#Region "Funcionalidades del formulario"

    ' Evento de carga del formulario, JSCG, UNAD, 20190601
    Private Sub FormModifyStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar los combos del formulario, JSCG, UNAD, 20190601
        TYPE_SEXTableAdapter.Fill(STUDENTSDataSet.TYPE_SEX)
        TYPE_IDENTITY_DOCUMENTTableAdapter.Fill(STUDENTSDataSet.TYPE_IDENTITY_DOCUMENT)
        PERSONTableAdapter.Fill(STUDENTSDataSet.PERSON)
        ' Asignar el texto de busqueda de los combos del formulario, JSCG, UNAD, 20190601
        ComboBoxTypeIdentification.Text = TEXT_SELECT
        ComboBoxTypeSex.Text = TEXT_SELECT
        SetStatusForm(False)
    End Sub

    Private Sub FormModifyStudent_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FormMenu.Show()
    End Sub

    ' Cuando el usuario de click sobre la grilla, se buscaran los datos del estudiante, JSCG, UNAD, 20190601
    Private Sub DataGridViewFormModifyStudent_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewFormModifyStudent.CellClick
        ' Buscar siempre que no sea con los valores del titulo, JSCG, UNAD, 20190601
        If e.RowIndex >= 0 Then
            ' Obtener el número de identificación del estudiante, JSCG, UNAD, 20190601
            Dim identificationNumber As String = DataGridViewFormModifyStudent.Item(0, e.RowIndex).Value.ToString
            Dim DBConnection As New SqlConnection(Configuration.ConfigurationManager.ConnectionStrings("Unidad_3_Paso_3.My.MySettings.STUDENTSConnectionString").ConnectionString)
            Dim db = New DataClassesSTUDENTSDataContext(DBConnection)
            ' Buscar y obtener los datos del estudiante, JSCG, UNAD, 20190601
            Dim queryPerson = (From persons In db.PERSON Where persons.IDENTIFICATION_DOCUMENT = identificationNumber.Trim Select New With {.ID_PERSON = persons.ID_PERSON, .IDENTIFICATION_DOCUMENT = persons.IDENTIFICATION_DOCUMENT, .TYPE_IDENTITY_DOCUMENT = persons.TYPE_IDENTITY_DOCUMENT, .FIRST_NAME = persons.FIRST_NAME, .MIDDLE_NAME = persons.MIDDLE_NAME, .SURNAME = persons.SURNAME, .SECOND_SURNAME = persons.SECOND_SURNAME, .TELEPHONE = persons.TELEPHONE, .ADDRESS = persons.ADDRESS, .TYPE_SEX = persons.TYPE_SEX}).FirstOrDefault
            ' Cargar los datos del estudiante en una instancia de la clase PERSON, JSCG, UNAD, 20190601
            student = New PERSON
            student.ID_PERSON = queryPerson.ID_PERSON
            student.IDENTIFICATION_DOCUMENT = queryPerson.IDENTIFICATION_DOCUMENT
            student.TYPE_IDENTITY_DOCUMENT = queryPerson.TYPE_IDENTITY_DOCUMENT
            student.FIRST_NAME = queryPerson.FIRST_NAME
            student.MIDDLE_NAME = queryPerson.MIDDLE_NAME
            student.SURNAME = queryPerson.SURNAME
            student.SECOND_SURNAME = queryPerson.SECOND_SURNAME
            student.TELEPHONE = queryPerson.TELEPHONE
            student.ADDRESS = queryPerson.ADDRESS
            student.TYPE_SEX = queryPerson.TYPE_SEX
            ' Cargar los datos del formulario, JSCG, UNAD, 20190601
            ComboBoxTypeIdentification.SelectedValue = -1
            ComboBoxTypeIdentification.SelectedValue = student.TYPE_IDENTITY_DOCUMENT
            ComboBoxTypeIdentification.Update()
            TextBoxNumberIdentification.Text = student.IDENTIFICATION_DOCUMENT
            TextBoxFirstName.Text = student.FIRST_NAME.Trim
            TextBoxMiddleName.Text = student.MIDDLE_NAME.Trim
            TextBoxFirstSurname.Text = student.SURNAME.Trim
            TextBoxSecondSurname.Text = student.SECOND_SURNAME.Trim
            ComboBoxTypeSex.SelectedValue = -1
            ComboBoxTypeSex.SelectedValue = student.TYPE_SEX
            ComboBoxTypeSex.Update()
            TextBoxTelephone.Text = student.TELEPHONE.Trim
            TextBoxAddress.Text = student.ADDRESS.Trim
            ' Cambiar el estado del formulario, JSCG, UNAD, 20190601
            SetStatusForm(True)
        End If
    End Sub

    ' Dependiendo del valor de verdad enviado, procesar el estado de los objetos del formulario, JSCG, UNAD, 20190601
    Private Sub SetStatusForm(status As Boolean)
        ComboBoxTypeIdentification.Enabled = status
        TextBoxNumberIdentification.Enabled = status
        TextBoxFirstName.Enabled = status
        TextBoxMiddleName.Enabled = status
        TextBoxFirstSurname.Enabled = status
        TextBoxSecondSurname.Enabled = status
        ComboBoxTypeSex.Enabled = status
        TextBoxTelephone.Enabled = status
        TextBoxAddress.Enabled = status
        ButtonModifyStudent.Enabled = status
        ' El estado de estos objetos siempre es contrario al de los demas, ya que tener un estudiante para editar, no se debe buscar otro, JSCG, UNAD, 20190601
        DataGridViewFormModifyStudent.Enabled = Not status
        BindingNavigatorFormModifyStudent.Enabled = Not status
    End Sub

    Private Sub ButtonModifyStudent_Click(sender As Object, e As EventArgs) Handles ButtonModifyStudent.Click
        If ErrorInDataForm() Then
            ' Alertar al usuario, el formulario tiene datos inconsistentes, JSCG, UNAD, 20190601
            MessageBox.Show("Existe un error en el diligenciamiento del formulario", "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                ' La actualización realizada en este sistema, es fisica, ya que el dato actualizado es eliminado y luego insertado con sus nuevos valores, JSCG, UNAD, 20190601
                Dim DBConnection As New SqlConnection(Configuration.ConfigurationManager.ConnectionStrings("Unidad_3_Paso_3.My.MySettings.STUDENTSConnectionString").ConnectionString)
                Dim db = New DataClassesSTUDENTSDataContext(DBConnection)
                ' Borrar el estudiante anterior, JSCG, UNAD, 20190601
                Dim queryDeletePerson = (From person In db.PERSON Where person.ID_PERSON = student.ID_PERSON Select person).FirstOrDefault
                db.PERSON.DeleteOnSubmit(queryDeletePerson)
                ' Crear un nuevo estudiante, JSCG, UNAD, 20190601
                Dim studentNew As New PERSON
                studentNew.IDENTIFICATION_DOCUMENT = TextBoxNumberIdentification.Text
                studentNew.TYPE_IDENTITY_DOCUMENT = ComboBoxTypeIdentification.SelectedValue
                studentNew.FIRST_NAME = TextBoxFirstName.Text
                studentNew.MIDDLE_NAME = TextBoxMiddleName.Text
                studentNew.SURNAME = TextBoxFirstSurname.Text
                studentNew.SECOND_SURNAME = TextBoxSecondSurname.Text
                studentNew.TELEPHONE = TextBoxTelephone.Text
                studentNew.ADDRESS = TextBoxAddress.Text
                studentNew.TYPE_SEX = ComboBoxTypeSex.SelectedValue
                ' Guardar el nuevo estudiante, JSCG, UNAD, 20190601
                db.PERSON.InsertOnSubmit(studentNew)
                db.SubmitChanges()
                ' Los cambios, fueron aceptados, actualizar los recursos del formulario, JSCG, UNAD, 20190601
                PERSONTableAdapter.Fill(STUDENTSDataSet.PERSON)
                DataGridViewFormModifyStudent.Refresh()
                MessageBox.Show("El estudiante, Nombre: " + studentNew.FIRST_NAME + " Apellido: " + studentNew.SURNAME + ". Fue actualizado con éxito.", "Estudiante modificado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CleanForm()
            Catch ex As Exception
                MessageBox.Show("Atención, señor usuario ocurrio un error al modificar el estudiante, el error especifico es: " + ex.Message, "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            SetStatusForm(False)
        End If
    End Sub

    ' Validar los objetos del formulario, JSCG, UNAD, 20190601
    Private Function ErrorInDataForm() As Boolean
        Dim errorInData As Boolean = False
        ErrorProviderFormModifyStudent.Clear()
        If ComboBoxTypeIdentification.SelectedIndex = -1 Then
            ComboBoxTypeIdentification.Focus()
            errorInData = True
            ErrorProviderFormModifyStudent.SetError(ComboBoxTypeIdentification, "Por favor seleccione un tipo de identificación, para el estudiante")
        End If
        If String.IsNullOrEmpty(TextBoxNumberIdentification.Text) Then
            TextBoxNumberIdentification.Focus()
            errorInData = True
            ErrorProviderFormModifyStudent.SetError(TextBoxNumberIdentification, "El número de identificación del estudiante es obligatorio")
        End If
        If String.IsNullOrEmpty(TextBoxFirstName.Text) Then
            TextBoxFirstName.Focus()
            errorInData = True
            ErrorProviderFormModifyStudent.SetError(TextBoxFirstName, "El primer nombre del estudiante es obligatorio")
        End If
        If String.IsNullOrEmpty(TextBoxFirstSurname.Text) Then
            TextBoxFirstSurname.Focus()
            errorInData = True
            ErrorProviderFormModifyStudent.SetError(TextBoxFirstSurname, "El primer apellido del estudiante es obligatorio")
        End If
        If ComboBoxTypeSex.SelectedIndex = -1 Then
            ComboBoxTypeSex.Focus()
            errorInData = True
            ErrorProviderFormModifyStudent.SetError(ComboBoxTypeSex, "Por favor seleccione un género, para el estudiante")
        End If
        If String.IsNullOrEmpty(TextBoxTelephone.Text) Then
            TextBoxTelephone.Focus()
            errorInData = True
            ErrorProviderFormModifyStudent.SetError(TextBoxTelephone, "El número de teléfono del estudiante es obligatorio")
        End If
        If String.IsNullOrEmpty(TextBoxAddress.Text) Then
            TextBoxAddress.Focus()
            errorInData = True
            ErrorProviderFormModifyStudent.SetError(TextBoxAddress, "La dirección del estudiante es obligatorio")
        End If
        Return errorInData
    End Function

    ' Limpiar el formulario, JSCG, UNAD, 20190601
    Private Sub CleanForm()
        ComboBoxTypeIdentification.SelectedValue = -1
        TextBoxNumberIdentification.Text = Nothing
        TextBoxFirstName.Text = Nothing
        TextBoxMiddleName.Text = Nothing
        TextBoxFirstSurname.Text = Nothing
        TextBoxSecondSurname.Text = Nothing
        ComboBoxTypeSex.SelectedValue = -1
        TextBoxTelephone.Text = Nothing
        TextBoxAddress.Text = Nothing
        ComboBoxTypeIdentification.Text = TEXT_SELECT
        ComboBoxTypeSex.Text = TEXT_SELECT
    End Sub

#End Region

End Class