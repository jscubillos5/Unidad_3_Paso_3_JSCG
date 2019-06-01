Imports System.Data.SqlClient

Public Class FormLogin

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        If (String.IsNullOrEmpty(TextBoxUser.Text) Or String.IsNullOrEmpty(TextBoxPassword.Text)) Then
            TextBoxUser.Focus()
            MessageBox.Show("El usuario o la contraseña, no pueden estar vacios", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DBConnection As New SqlConnection(Configuration.ConfigurationManager.ConnectionStrings("Unidad_3_Paso_3.My.MySettings.STUDENTSConnectionString").ConnectionString)
            Dim db = New DataClassesSTUDENTSDataContext(DBConnection)
            Dim countUser = (Aggregate user In db.USER Where user.USER_NAME = TextBoxUser.Text And user.PASSWORD = TextBoxPassword.Text Into Count())
            If countUser <= 0 Then
                TextBoxUser.Focus()
                TextBoxUser.Text = Nothing
                TextBoxPassword.Text = Nothing
                MessageBox.Show("Usuario o contraseña incorrectos", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Hide()
                Dim formMenu = New FormMenu
                formMenu.ShowDialog()
            End If
        End If
    End Sub
End Class
