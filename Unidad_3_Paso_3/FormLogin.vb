Imports System.Data.SqlClient

Public Class FormLogin

#Region "Funcionalidades del inicio de sesión"

    ' Permite iniciar sesión en el sistema, JSCG, UNAD, 20190601
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        If (String.IsNullOrEmpty(TextBoxUser.Text) Or String.IsNullOrEmpty(TextBoxPassword.Text)) Then
            TextBoxUser.Focus()
            MessageBox.Show("El usuario o la contraseña, no pueden estar vacios", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DBConnection As New SqlConnection(Configuration.ConfigurationManager.ConnectionStrings("Unidad_3_Paso_3.My.MySettings.STUDENTSConnectionString").ConnectionString)
            Dim db = New DataClassesSTUDENTSDataContext(DBConnection)
            ' Buscar el usuario en el sistema, JSCG, UNAD, 20190601
            Dim countUser = (Aggregate user In db.USER Where user.USER_NAME = TextBoxUser.Text And user.PASSWORD = TextBoxPassword.Text Into Count())
            If countUser <= 0 Then
                TextBoxUser.Focus()
                TextBoxUser.Text = Nothing
                TextBoxPassword.Text = Nothing
                ' Alertar al usuario, los valores ingresados, no son validos, JSCG, UNAD, 20190601
                MessageBox.Show("Usuario o contraseña incorrectos", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                ' Dar acceso al sistema, JSCG, UNAD, 20190601
                Hide()
                Dim formMenu = New FormMenu
                formMenu.ShowDialog()
            End If
        End If
    End Sub

    Private Sub LinkLabelCopyright_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelCopyright.LinkClicked
        MessageBox.Show("Las imagenes usadas, en este sistema, son diseñadas por terceros y estan protegidas por derechos de autor, para más detalles lo invitamos ir a: https://www.freepikcompany.com/copyright", "Derechos de autor terceros")
        Process.Start("https://www.freepikcompany.com/copyright")
    End Sub

#End Region

End Class
