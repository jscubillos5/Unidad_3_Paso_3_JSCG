<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRegisterStudent
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRegisterStudent))
        Me.LabelHelpFormRegisterStudent = New System.Windows.Forms.Label()
        Me.LabelTypeIdentification = New System.Windows.Forms.Label()
        Me.ComboBoxTypeIdentification = New System.Windows.Forms.ComboBox()
        Me.LabelNumberIdentification = New System.Windows.Forms.Label()
        Me.TextBoxNumberIdentification = New System.Windows.Forms.TextBox()
        Me.LabelFirstName = New System.Windows.Forms.Label()
        Me.TextBoxFirstName = New System.Windows.Forms.TextBox()
        Me.LabelMiddleName = New System.Windows.Forms.Label()
        Me.TextBoxMiddleName = New System.Windows.Forms.TextBox()
        Me.TextBoxFirstSurname = New System.Windows.Forms.TextBox()
        Me.LabelFirstSurname = New System.Windows.Forms.Label()
        Me.TextBoxSecondSurname = New System.Windows.Forms.TextBox()
        Me.LabelSecondSurname = New System.Windows.Forms.Label()
        Me.ComboBoxTypeSex = New System.Windows.Forms.ComboBox()
        Me.LabelTypeSex = New System.Windows.Forms.Label()
        Me.TextBoxTelephone = New System.Windows.Forms.TextBox()
        Me.LabelTelephone = New System.Windows.Forms.Label()
        Me.TextBoxAddress = New System.Windows.Forms.TextBox()
        Me.LabelAddress = New System.Windows.Forms.Label()
        Me.ButtonRegisterStudent = New System.Windows.Forms.Button()
        Me.ErrorProviderFormRegisterStudent = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.STUDENTSDataSet = New Unidad_3_Paso_3.STUDENTSDataSet()
        Me.STUDENTSDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TYPEIDENTITYDOCUMENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TYPE_IDENTITY_DOCUMENTTableAdapter = New Unidad_3_Paso_3.STUDENTSDataSetTableAdapters.TYPE_IDENTITY_DOCUMENTTableAdapter()
        Me.TYPESEXBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TYPE_SEXTableAdapter = New Unidad_3_Paso_3.STUDENTSDataSetTableAdapters.TYPE_SEXTableAdapter()
        CType(Me.ErrorProviderFormRegisterStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STUDENTSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STUDENTSDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TYPEIDENTITYDOCUMENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TYPESEXBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelHelpFormRegisterStudent
        '
        Me.LabelHelpFormRegisterStudent.Location = New System.Drawing.Point(12, 13)
        Me.LabelHelpFormRegisterStudent.Name = "LabelHelpFormRegisterStudent"
        Me.LabelHelpFormRegisterStudent.Size = New System.Drawing.Size(898, 25)
        Me.LabelHelpFormRegisterStudent.TabIndex = 10
        Me.LabelHelpFormRegisterStudent.Text = "Bienvenido señor usuario en este formulario, usted podra registrar un nuevo estud" &
    "iante."
        Me.LabelHelpFormRegisterStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelTypeIdentification
        '
        Me.LabelTypeIdentification.AutoSize = True
        Me.LabelTypeIdentification.Location = New System.Drawing.Point(15, 98)
        Me.LabelTypeIdentification.Name = "LabelTypeIdentification"
        Me.LabelTypeIdentification.Size = New System.Drawing.Size(137, 17)
        Me.LabelTypeIdentification.TabIndex = 11
        Me.LabelTypeIdentification.Text = "Tipo identificación(*)"
        '
        'ComboBoxTypeIdentification
        '
        Me.ComboBoxTypeIdentification.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TYPEIDENTITYDOCUMENTBindingSource, "CODE", True))
        Me.ComboBoxTypeIdentification.DataSource = Me.TYPEIDENTITYDOCUMENTBindingSource
        Me.ComboBoxTypeIdentification.DisplayMember = "DESCRIPTION"
        Me.ComboBoxTypeIdentification.FormattingEnabled = True
        Me.ComboBoxTypeIdentification.Location = New System.Drawing.Point(196, 91)
        Me.ComboBoxTypeIdentification.Name = "ComboBoxTypeIdentification"
        Me.ComboBoxTypeIdentification.Size = New System.Drawing.Size(239, 24)
        Me.ComboBoxTypeIdentification.TabIndex = 0
        Me.ComboBoxTypeIdentification.ValueMember = "ID_TYPE_IDENTITY_DOCUMENT"
        '
        'LabelNumberIdentification
        '
        Me.LabelNumberIdentification.AutoSize = True
        Me.LabelNumberIdentification.Location = New System.Drawing.Point(456, 98)
        Me.LabelNumberIdentification.Name = "LabelNumberIdentification"
        Me.LabelNumberIdentification.Size = New System.Drawing.Size(159, 17)
        Me.LabelNumberIdentification.TabIndex = 16
        Me.LabelNumberIdentification.Text = "Número identificación(*)"
        '
        'TextBoxNumberIdentification
        '
        Me.TextBoxNumberIdentification.Enabled = False
        Me.TextBoxNumberIdentification.Location = New System.Drawing.Point(636, 91)
        Me.TextBoxNumberIdentification.MaxLength = 30
        Me.TextBoxNumberIdentification.Name = "TextBoxNumberIdentification"
        Me.TextBoxNumberIdentification.Size = New System.Drawing.Size(239, 22)
        Me.TextBoxNumberIdentification.TabIndex = 1
        '
        'LabelFirstName
        '
        Me.LabelFirstName.AutoSize = True
        Me.LabelFirstName.Location = New System.Drawing.Point(15, 159)
        Me.LabelFirstName.Name = "LabelFirstName"
        Me.LabelFirstName.Size = New System.Drawing.Size(116, 17)
        Me.LabelFirstName.TabIndex = 12
        Me.LabelFirstName.Text = "Primer nombre(*)"
        '
        'TextBoxFirstName
        '
        Me.TextBoxFirstName.Location = New System.Drawing.Point(196, 154)
        Me.TextBoxFirstName.MaxLength = 25
        Me.TextBoxFirstName.Name = "TextBoxFirstName"
        Me.TextBoxFirstName.Size = New System.Drawing.Size(239, 22)
        Me.TextBoxFirstName.TabIndex = 2
        '
        'LabelMiddleName
        '
        Me.LabelMiddleName.AutoSize = True
        Me.LabelMiddleName.Location = New System.Drawing.Point(456, 159)
        Me.LabelMiddleName.Name = "LabelMiddleName"
        Me.LabelMiddleName.Size = New System.Drawing.Size(117, 17)
        Me.LabelMiddleName.TabIndex = 17
        Me.LabelMiddleName.Text = "Segundo nombre"
        '
        'TextBoxMiddleName
        '
        Me.TextBoxMiddleName.Location = New System.Drawing.Point(636, 154)
        Me.TextBoxMiddleName.MaxLength = 25
        Me.TextBoxMiddleName.Name = "TextBoxMiddleName"
        Me.TextBoxMiddleName.Size = New System.Drawing.Size(239, 22)
        Me.TextBoxMiddleName.TabIndex = 3
        '
        'TextBoxFirstSurname
        '
        Me.TextBoxFirstSurname.Location = New System.Drawing.Point(196, 215)
        Me.TextBoxFirstSurname.MaxLength = 25
        Me.TextBoxFirstSurname.Name = "TextBoxFirstSurname"
        Me.TextBoxFirstSurname.Size = New System.Drawing.Size(239, 22)
        Me.TextBoxFirstSurname.TabIndex = 4
        '
        'LabelFirstSurname
        '
        Me.LabelFirstSurname.AutoSize = True
        Me.LabelFirstSurname.Location = New System.Drawing.Point(15, 220)
        Me.LabelFirstSurname.Name = "LabelFirstSurname"
        Me.LabelFirstSurname.Size = New System.Drawing.Size(117, 17)
        Me.LabelFirstSurname.TabIndex = 13
        Me.LabelFirstSurname.Text = "Primer apellido(*)"
        '
        'TextBoxSecondSurname
        '
        Me.TextBoxSecondSurname.Location = New System.Drawing.Point(636, 215)
        Me.TextBoxSecondSurname.MaxLength = 25
        Me.TextBoxSecondSurname.Name = "TextBoxSecondSurname"
        Me.TextBoxSecondSurname.Size = New System.Drawing.Size(239, 22)
        Me.TextBoxSecondSurname.TabIndex = 5
        '
        'LabelSecondSurname
        '
        Me.LabelSecondSurname.AutoSize = True
        Me.LabelSecondSurname.Location = New System.Drawing.Point(456, 220)
        Me.LabelSecondSurname.Name = "LabelSecondSurname"
        Me.LabelSecondSurname.Size = New System.Drawing.Size(118, 17)
        Me.LabelSecondSurname.TabIndex = 18
        Me.LabelSecondSurname.Text = "Segundo apellido"
        '
        'ComboBoxTypeSex
        '
        Me.ComboBoxTypeSex.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TYPESEXBindingSource, "CODE", True))
        Me.ComboBoxTypeSex.DataSource = Me.TYPESEXBindingSource
        Me.ComboBoxTypeSex.DisplayMember = "DESCRIPTION"
        Me.ComboBoxTypeSex.FormattingEnabled = True
        Me.ComboBoxTypeSex.Location = New System.Drawing.Point(196, 276)
        Me.ComboBoxTypeSex.Name = "ComboBoxTypeSex"
        Me.ComboBoxTypeSex.Size = New System.Drawing.Size(239, 24)
        Me.ComboBoxTypeSex.TabIndex = 6
        Me.ComboBoxTypeSex.ValueMember = "ID_TYPE_SEX"
        '
        'LabelTypeSex
        '
        Me.LabelTypeSex.AutoSize = True
        Me.LabelTypeSex.Location = New System.Drawing.Point(15, 283)
        Me.LabelTypeSex.Name = "LabelTypeSex"
        Me.LabelTypeSex.Size = New System.Drawing.Size(71, 17)
        Me.LabelTypeSex.TabIndex = 14
        Me.LabelTypeSex.Text = "Género(*)"
        '
        'TextBoxTelephone
        '
        Me.TextBoxTelephone.Location = New System.Drawing.Point(636, 276)
        Me.TextBoxTelephone.MaxLength = 15
        Me.TextBoxTelephone.Name = "TextBoxTelephone"
        Me.TextBoxTelephone.Size = New System.Drawing.Size(239, 22)
        Me.TextBoxTelephone.TabIndex = 7
        '
        'LabelTelephone
        '
        Me.LabelTelephone.AutoSize = True
        Me.LabelTelephone.Location = New System.Drawing.Point(456, 283)
        Me.LabelTelephone.Name = "LabelTelephone"
        Me.LabelTelephone.Size = New System.Drawing.Size(79, 17)
        Me.LabelTelephone.TabIndex = 19
        Me.LabelTelephone.Text = "Teléfono(*)"
        '
        'TextBoxAddress
        '
        Me.TextBoxAddress.Location = New System.Drawing.Point(196, 338)
        Me.TextBoxAddress.MaxLength = 15
        Me.TextBoxAddress.Name = "TextBoxAddress"
        Me.TextBoxAddress.Size = New System.Drawing.Size(679, 22)
        Me.TextBoxAddress.TabIndex = 8
        '
        'LabelAddress
        '
        Me.LabelAddress.AutoSize = True
        Me.LabelAddress.Location = New System.Drawing.Point(15, 343)
        Me.LabelAddress.Name = "LabelAddress"
        Me.LabelAddress.Size = New System.Drawing.Size(82, 17)
        Me.LabelAddress.TabIndex = 15
        Me.LabelAddress.Text = "Dirección(*)"
        '
        'ButtonRegisterStudent
        '
        Me.ButtonRegisterStudent.Location = New System.Drawing.Point(373, 376)
        Me.ButtonRegisterStudent.Name = "ButtonRegisterStudent"
        Me.ButtonRegisterStudent.Size = New System.Drawing.Size(172, 40)
        Me.ButtonRegisterStudent.TabIndex = 9
        Me.ButtonRegisterStudent.Text = "Registrar estudiante"
        Me.ButtonRegisterStudent.UseVisualStyleBackColor = True
        '
        'ErrorProviderFormRegisterStudent
        '
        Me.ErrorProviderFormRegisterStudent.ContainerControl = Me
        '
        'STUDENTSDataSet
        '
        Me.STUDENTSDataSet.DataSetName = "STUDENTSDataSet"
        Me.STUDENTSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'STUDENTSDataSetBindingSource
        '
        Me.STUDENTSDataSetBindingSource.DataSource = Me.STUDENTSDataSet
        Me.STUDENTSDataSetBindingSource.Position = 0
        '
        'TYPEIDENTITYDOCUMENTBindingSource
        '
        Me.TYPEIDENTITYDOCUMENTBindingSource.DataMember = "TYPE_IDENTITY_DOCUMENT"
        Me.TYPEIDENTITYDOCUMENTBindingSource.DataSource = Me.STUDENTSDataSetBindingSource
        '
        'TYPE_IDENTITY_DOCUMENTTableAdapter
        '
        Me.TYPE_IDENTITY_DOCUMENTTableAdapter.ClearBeforeFill = True
        '
        'TYPESEXBindingSource
        '
        Me.TYPESEXBindingSource.DataMember = "TYPE_SEX"
        Me.TYPESEXBindingSource.DataSource = Me.STUDENTSDataSetBindingSource
        '
        'TYPE_SEXTableAdapter
        '
        Me.TYPE_SEXTableAdapter.ClearBeforeFill = True
        '
        'FormRegisterStudent
        '
        Me.AcceptButton = Me.ButtonRegisterStudent
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 429)
        Me.Controls.Add(Me.ButtonRegisterStudent)
        Me.Controls.Add(Me.TextBoxAddress)
        Me.Controls.Add(Me.LabelAddress)
        Me.Controls.Add(Me.TextBoxTelephone)
        Me.Controls.Add(Me.LabelTelephone)
        Me.Controls.Add(Me.ComboBoxTypeSex)
        Me.Controls.Add(Me.LabelTypeSex)
        Me.Controls.Add(Me.TextBoxSecondSurname)
        Me.Controls.Add(Me.LabelSecondSurname)
        Me.Controls.Add(Me.TextBoxFirstSurname)
        Me.Controls.Add(Me.LabelFirstSurname)
        Me.Controls.Add(Me.TextBoxMiddleName)
        Me.Controls.Add(Me.LabelMiddleName)
        Me.Controls.Add(Me.TextBoxFirstName)
        Me.Controls.Add(Me.LabelFirstName)
        Me.Controls.Add(Me.TextBoxNumberIdentification)
        Me.Controls.Add(Me.LabelNumberIdentification)
        Me.Controls.Add(Me.ComboBoxTypeIdentification)
        Me.Controls.Add(Me.LabelTypeIdentification)
        Me.Controls.Add(Me.LabelHelpFormRegisterStudent)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(936, 476)
        Me.MinimumSize = New System.Drawing.Size(936, 476)
        Me.Name = "FormRegisterStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar estudiante"
        CType(Me.ErrorProviderFormRegisterStudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STUDENTSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STUDENTSDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TYPEIDENTITYDOCUMENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TYPESEXBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelHelpFormRegisterStudent As Label
    Friend WithEvents LabelTypeIdentification As Label
    Friend WithEvents ComboBoxTypeIdentification As ComboBox
    Friend WithEvents LabelNumberIdentification As Label
    Friend WithEvents TextBoxNumberIdentification As TextBox
    Friend WithEvents LabelFirstName As Label
    Friend WithEvents TextBoxFirstName As TextBox
    Friend WithEvents LabelMiddleName As Label
    Friend WithEvents TextBoxMiddleName As TextBox
    Friend WithEvents TextBoxFirstSurname As TextBox
    Friend WithEvents LabelFirstSurname As Label
    Friend WithEvents TextBoxSecondSurname As TextBox
    Friend WithEvents LabelSecondSurname As Label
    Friend WithEvents ComboBoxTypeSex As ComboBox
    Friend WithEvents LabelTypeSex As Label
    Friend WithEvents TextBoxTelephone As TextBox
    Friend WithEvents LabelTelephone As Label
    Friend WithEvents TextBoxAddress As TextBox
    Friend WithEvents LabelAddress As Label
    Friend WithEvents ButtonRegisterStudent As Button
    Friend WithEvents ErrorProviderFormRegisterStudent As ErrorProvider
    Friend WithEvents STUDENTSDataSetBindingSource As BindingSource
    Friend WithEvents STUDENTSDataSet As STUDENTSDataSet
    Friend WithEvents TYPEIDENTITYDOCUMENTBindingSource As BindingSource
    Friend WithEvents TYPE_IDENTITY_DOCUMENTTableAdapter As STUDENTSDataSetTableAdapters.TYPE_IDENTITY_DOCUMENTTableAdapter
    Friend WithEvents TYPESEXBindingSource As BindingSource
    Friend WithEvents TYPE_SEXTableAdapter As STUDENTSDataSetTableAdapters.TYPE_SEXTableAdapter
End Class
