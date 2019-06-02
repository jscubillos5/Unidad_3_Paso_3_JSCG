Imports System.Data.SqlClient

Public Class FormRegisterStudent

#Region "Variables y constantes del formulario"

    Private Const TEXT_SELECT = "Seleccionar"

#End Region

#Region "Funcionalidades del formulario"

    Private Sub ButtonRegisterStudent_Click(sender As Object, e As EventArgs) Handles ButtonRegisterStudent.Click
        Dim validation As DialogResult = MessageBox.Show("¿Está seguro?, por favor revise los datos", "Confirmación registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        ' Confirmar si el usuario desea registrar el estudiante, JSCG, UNAD, 20190601
        If validation = vbYes Then
            If ErrorInDataForm() Then
                MessageBox.Show("Existe un error en el diligenciamiento del formulario", "Error al registrar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Try
                    ' Utilizar la conexión establecida en el archivo App.config, JSCG, UNAD, 20190601
                    Dim DBConnection As New SqlConnection(Configuration.ConfigurationManager.ConnectionStrings("Unidad_3_Paso_3.My.MySettings.STUDENTSConnectionString").ConnectionString)
                    ' Utilizar el DataContex de LINQ to SQL, para obtener acceso a la tabla PERSON, JSCG, UNAD, 20190601
                    Dim db = New DataClassesSTUDENTSDataContext(DBConnection)
                    ' Crear un objeto de la tabla PERSON, JSCG, UNAD, 20190601
                    Dim student As New PERSON()
                    student.IDENTIFICATION_DOCUMENT = TextBoxNumberIdentification.Text
                    student.TYPE_IDENTITY_DOCUMENT = ComboBoxTypeIdentification.SelectedValue
                    student.FIRST_NAME = TextBoxFirstName.Text
                    student.MIDDLE_NAME = TextBoxMiddleName.Text
                    student.SURNAME = TextBoxFirstSurname.Text
                    student.SECOND_SURNAME = TextBoxSecondSurname.Text
                    student.TELEPHONE = TextBoxTelephone.Text
                    student.ADDRESS = TextBoxAddress.Text
                    student.TYPE_SEX = ComboBoxTypeSex.SelectedValue
                    ' Enviar el comando de inserción del estudiante, JSCG, UNAD, 20190601
                    db.PERSON.InsertOnSubmit(student)
                    ' Guardar el estudiante, JSCG, UNAD, 20190601
                    db.SubmitChanges()
                    MessageBox.Show("El estudiante: " + student.FIRST_NAME + " " + student.SURNAME + ". Fue registrado con éxito.", "Estudiante registrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CleanForm()
                Catch ex As Exception
                    MessageBox.Show("Atención, señor usuario ocurrio un error al registrar el estudiante, el error especifico es: " + ex.Message, "Error al registrar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    ' Validar los datos obligatorios del formulario, JSCG, UNAD, 20190601
    Private Function ErrorInDataForm() As Boolean
        Dim errorInData As Boolean = False
        ErrorProviderFormRegisterStudent.Clear()
        If ComboBoxTypeIdentification.SelectedIndex = -1 Then
            ComboBoxTypeIdentification.Focus()
            errorInData = True
            ErrorProviderFormRegisterStudent.SetError(ComboBoxTypeIdentification, "Por favor seleccione un tipo de identificación, para el estudiante")
        End If
        If String.IsNullOrEmpty(TextBoxNumberIdentification.Text) Then
            TextBoxNumberIdentification.Focus()
            errorInData = True
            ErrorProviderFormRegisterStudent.SetError(TextBoxNumberIdentification, "El número de identificación del estudiante es obligatorio")
        End If
        If String.IsNullOrEmpty(TextBoxFirstName.Text) Then
            TextBoxFirstName.Focus()
            errorInData = True
            ErrorProviderFormRegisterStudent.SetError(TextBoxFirstName, "El primer nombre del estudiante es obligatorio")
        End If
        If String.IsNullOrEmpty(TextBoxFirstSurname.Text) Then
            TextBoxFirstSurname.Focus()
            errorInData = True
            ErrorProviderFormRegisterStudent.SetError(TextBoxFirstSurname, "El primer apellido del estudiante es obligatorio")
        End If
        If ComboBoxTypeSex.SelectedIndex = -1 Then
            ComboBoxTypeSex.Focus()
            errorInData = True
            ErrorProviderFormRegisterStudent.SetError(ComboBoxTypeSex, "Por favor seleccione un género, para el estudiante")
        End If
        If String.IsNullOrEmpty(TextBoxTelephone.Text) Then
            TextBoxTelephone.Focus()
            errorInData = True
            ErrorProviderFormRegisterStudent.SetError(TextBoxTelephone, "El número de teléfono del estudiante es obligatorio")
        End If
        If String.IsNullOrEmpty(TextBoxAddress.Text) Then
            TextBoxAddress.Focus()
            errorInData = True
            ErrorProviderFormRegisterStudent.SetError(TextBoxAddress, "La dirección del estudiante es obligatorio")
        End If
        Return errorInData
    End Function

    ' Evento de carga del formulario, JSCG, UNAD, 20190601
    Private Sub FormRegisterStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TYPE_SEXTableAdapter.Fill(STUDENTSDataSet.TYPE_SEX)
        TYPE_IDENTITY_DOCUMENTTableAdapter.Fill(STUDENTSDataSet.TYPE_IDENTITY_DOCUMENT)
        ComboBoxTypeIdentification.Focus()
        ComboBoxTypeIdentification.Text = TEXT_SELECT
        ComboBoxTypeSex.Text = TEXT_SELECT
    End Sub

    ' Solo numeros, JSCG, UNAD, 20190601
    Private Sub TextBoxTelephone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxTelephone.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Al cerrar ir al formulario principal, JSCG, UNAD, 20190601
    Private Sub FormRegisterStudent_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FormMenu.Show()
    End Sub

    ' Limpiar el contenido del formulario, JSCG, UNAD, 20190601
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

    ' Al seleccionar un tipo de documento especifico este puede o no tener letras, JSCG, UNAD, 20190601
    Private Sub ComboBoxTypeIdentification_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTypeIdentification.SelectedIndexChanged
        ' Limpiar el contenido del número de identificación, JSCG, UNAD, 20190601
        TextBoxNumberIdentification.Text = Nothing
        Dim DBConnection As New SqlConnection(Configuration.ConfigurationManager.ConnectionStrings("Unidad_3_Paso_3.My.MySettings.STUDENTSConnectionString").ConnectionString)
        Dim db = New DataClassesSTUDENTSDataContext(DBConnection)
        ' Buscar si el tipo del documento seleccionado por el usuario, permite letras o no, JSCG, UNAD, 20190601
        Dim onlyNumber = (From type In db.TYPE_IDENTITY_DOCUMENT Where type.ID_TYPE_IDENTITY_DOCUMENT = Convert.ToInt16(ComboBoxTypeIdentification.SelectedValue) Select type.ONLY_NUMBER).FirstOrDefault()
        If Not onlyNumber Then
            ' El tipo de documento permite letras, por ende, se quita de forma dinamica el evento TextBoxNumberIdentification.KeyPress, JSCG, UNAD, 20190601
            RemoveHandler TextBoxNumberIdentification.KeyPress, AddressOf TextBoxNumberIdentification_KeyPress
        Else
            ' El tipo de documento no permite letras, por ende, se asigna de forma dinamica el evento TextBoxNumberIdentification.KeyPress, JSCG, UNAD, 20190601
            AddHandler TextBoxNumberIdentification.KeyPress, AddressOf TextBoxNumberIdentification_KeyPress
        End If
        TextBoxNumberIdentification.Enabled = True
    End Sub

    Private Sub TextBoxNumberIdentification_KeyPress(sender As Object, e As KeyPressEventArgs)
        ' Solo números, JSCG, UNAD, 20190601
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

#End Region

End Class