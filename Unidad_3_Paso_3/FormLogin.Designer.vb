<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.LabelUser = New System.Windows.Forms.Label()
        Me.TextBoxUser = New System.Windows.Forms.TextBox()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.PictureBoxImageLogin = New System.Windows.Forms.PictureBox()
        Me.LinkLabelCopyright = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBoxImageLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelUser
        '
        Me.LabelUser.AutoSize = True
        Me.LabelUser.Location = New System.Drawing.Point(287, 24)
        Me.LabelUser.Name = "LabelUser"
        Me.LabelUser.Size = New System.Drawing.Size(57, 17)
        Me.LabelUser.TabIndex = 4
        Me.LabelUser.Text = "Usuario"
        '
        'TextBoxUser
        '
        Me.TextBoxUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxUser.Location = New System.Drawing.Point(351, 19)
        Me.TextBoxUser.Name = "TextBoxUser"
        Me.TextBoxUser.Size = New System.Drawing.Size(144, 22)
        Me.TextBoxUser.TabIndex = 0
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Location = New System.Drawing.Point(263, 54)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(81, 17)
        Me.LabelPassword.TabIndex = 5
        Me.LabelPassword.Text = "Contraseña"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(351, 49)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPassword.Size = New System.Drawing.Size(144, 22)
        Me.TextBoxPassword.TabIndex = 1
        '
        'ButtonLogin
        '
        Me.ButtonLogin.Location = New System.Drawing.Point(384, 87)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(111, 40)
        Me.ButtonLogin.TabIndex = 2
        Me.ButtonLogin.Text = "Iniciar sesión"
        Me.ButtonLogin.UseVisualStyleBackColor = True
        '
        'PictureBoxImageLogin
        '
        Me.PictureBoxImageLogin.Image = Global.Unidad_3_Paso_3.My.Resources.Resources.II_Principal_Image
        Me.PictureBoxImageLogin.Location = New System.Drawing.Point(12, 12)
        Me.PictureBoxImageLogin.Name = "PictureBoxImageLogin"
        Me.PictureBoxImageLogin.Size = New System.Drawing.Size(144, 137)
        Me.PictureBoxImageLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxImageLogin.TabIndex = 5
        Me.PictureBoxImageLogin.TabStop = False
        '
        'LinkLabelCopyright
        '
        Me.LinkLabelCopyright.AutoSize = True
        Me.LinkLabelCopyright.Location = New System.Drawing.Point(8, 160)
        Me.LinkLabelCopyright.Name = "LinkLabelCopyright"
        Me.LinkLabelCopyright.Size = New System.Drawing.Size(497, 17)
        Me.LinkLabelCopyright.TabIndex = 3
        Me.LinkLabelCopyright.TabStop = True
        Me.LinkLabelCopyright.Text = "Derechos de autor © 2019 por Juan Cubillos. Todos los derechos reservados"
        '
        'FormLogin
        '
        Me.AcceptButton = Me.ButtonLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 186)
        Me.Controls.Add(Me.LinkLabelCopyright)
        Me.Controls.Add(Me.PictureBoxImageLogin)
        Me.Controls.Add(Me.ButtonLogin)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.TextBoxUser)
        Me.Controls.Add(Me.LabelUser)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(535, 233)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(535, 233)
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar sesión"
        CType(Me.PictureBoxImageLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelUser As Label
    Friend WithEvents TextBoxUser As TextBox
    Friend WithEvents LabelPassword As Label
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents PictureBoxImageLogin As PictureBox
    Friend WithEvents LinkLabelCopyright As LinkLabel
End Class
