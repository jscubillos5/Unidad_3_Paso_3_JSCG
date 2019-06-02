<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormModifyStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormModifyStudent))
        Me.ErrorProviderFormModifyStudent = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PanelHelpFormModifyStudent = New System.Windows.Forms.Panel()
        Me.LabelHelpFormModifyStudent = New System.Windows.Forms.Label()
        Me.PanelSearchStudent = New System.Windows.Forms.Panel()
        Me.DataGridViewFormModifyStudent = New System.Windows.Forms.DataGridView()
        Me.IDENTIFICATIONDOCUMENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRSTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MIDDLENAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SURNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SECONDSURNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PERSONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.STUDENTSDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.STUDENTSDataSet = New Unidad_3_Paso_3.STUDENTSDataSet()
        Me.BindingNavigatorFormModifyStudent = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PanelModifyStudent = New System.Windows.Forms.Panel()
        Me.TextBoxAddress = New System.Windows.Forms.TextBox()
        Me.LabelAddress = New System.Windows.Forms.Label()
        Me.TextBoxTelephone = New System.Windows.Forms.TextBox()
        Me.LabelTelephone = New System.Windows.Forms.Label()
        Me.ComboBoxTypeSex = New System.Windows.Forms.ComboBox()
        Me.TYPESEXBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelTypeSex = New System.Windows.Forms.Label()
        Me.TextBoxSecondSurname = New System.Windows.Forms.TextBox()
        Me.LabelSecondSurname = New System.Windows.Forms.Label()
        Me.TextBoxFirstSurname = New System.Windows.Forms.TextBox()
        Me.LabelFirstSurname = New System.Windows.Forms.Label()
        Me.TextBoxMiddleName = New System.Windows.Forms.TextBox()
        Me.LabelMiddleName = New System.Windows.Forms.Label()
        Me.TextBoxFirstName = New System.Windows.Forms.TextBox()
        Me.LabelFirstName = New System.Windows.Forms.Label()
        Me.TextBoxNumberIdentification = New System.Windows.Forms.TextBox()
        Me.LabelNumberIdentification = New System.Windows.Forms.Label()
        Me.ComboBoxTypeIdentification = New System.Windows.Forms.ComboBox()
        Me.TYPEIDENTITYDOCUMENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelTypeIdentification = New System.Windows.Forms.Label()
        Me.PanelButton = New System.Windows.Forms.Panel()
        Me.ButtonModifyStudent = New System.Windows.Forms.Button()
        Me.PERSONTableAdapter = New Unidad_3_Paso_3.STUDENTSDataSetTableAdapters.PERSONTableAdapter()
        Me.TYPE_IDENTITY_DOCUMENTTableAdapter = New Unidad_3_Paso_3.STUDENTSDataSetTableAdapters.TYPE_IDENTITY_DOCUMENTTableAdapter()
        Me.TYPE_SEXTableAdapter = New Unidad_3_Paso_3.STUDENTSDataSetTableAdapters.TYPE_SEXTableAdapter()
        CType(Me.ErrorProviderFormModifyStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHelpFormModifyStudent.SuspendLayout()
        Me.PanelSearchStudent.SuspendLayout()
        CType(Me.DataGridViewFormModifyStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PERSONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STUDENTSDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STUDENTSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigatorFormModifyStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigatorFormModifyStudent.SuspendLayout()
        Me.PanelModifyStudent.SuspendLayout()
        CType(Me.TYPESEXBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TYPEIDENTITYDOCUMENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelButton.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorProviderFormModifyStudent
        '
        Me.ErrorProviderFormModifyStudent.ContainerControl = Me
        '
        'PanelHelpFormModifyStudent
        '
        Me.PanelHelpFormModifyStudent.Controls.Add(Me.LabelHelpFormModifyStudent)
        Me.PanelHelpFormModifyStudent.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHelpFormModifyStudent.Location = New System.Drawing.Point(0, 0)
        Me.PanelHelpFormModifyStudent.Name = "PanelHelpFormModifyStudent"
        Me.PanelHelpFormModifyStudent.Size = New System.Drawing.Size(918, 54)
        Me.PanelHelpFormModifyStudent.TabIndex = 0
        '
        'LabelHelpFormModifyStudent
        '
        Me.LabelHelpFormModifyStudent.Location = New System.Drawing.Point(10, 15)
        Me.LabelHelpFormModifyStudent.Name = "LabelHelpFormModifyStudent"
        Me.LabelHelpFormModifyStudent.Size = New System.Drawing.Size(898, 25)
        Me.LabelHelpFormModifyStudent.TabIndex = 12
        Me.LabelHelpFormModifyStudent.Text = "Bienvenido señor usuario en este formulario, usted podra modificar un estudiante." &
    ""
        Me.LabelHelpFormModifyStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelSearchStudent
        '
        Me.PanelSearchStudent.Controls.Add(Me.DataGridViewFormModifyStudent)
        Me.PanelSearchStudent.Controls.Add(Me.BindingNavigatorFormModifyStudent)
        Me.PanelSearchStudent.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSearchStudent.Location = New System.Drawing.Point(0, 54)
        Me.PanelSearchStudent.Name = "PanelSearchStudent"
        Me.PanelSearchStudent.Size = New System.Drawing.Size(918, 184)
        Me.PanelSearchStudent.TabIndex = 1
        '
        'DataGridViewFormModifyStudent
        '
        Me.DataGridViewFormModifyStudent.AllowUserToAddRows = False
        Me.DataGridViewFormModifyStudent.AllowUserToDeleteRows = False
        Me.DataGridViewFormModifyStudent.AutoGenerateColumns = False
        Me.DataGridViewFormModifyStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewFormModifyStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewFormModifyStudent.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDENTIFICATIONDOCUMENTDataGridViewTextBoxColumn, Me.FIRSTNAMEDataGridViewTextBoxColumn, Me.MIDDLENAMEDataGridViewTextBoxColumn, Me.SURNAMEDataGridViewTextBoxColumn, Me.SECONDSURNAMEDataGridViewTextBoxColumn})
        Me.DataGridViewFormModifyStudent.DataSource = Me.PERSONBindingSource
        Me.DataGridViewFormModifyStudent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewFormModifyStudent.Location = New System.Drawing.Point(0, 27)
        Me.DataGridViewFormModifyStudent.MultiSelect = False
        Me.DataGridViewFormModifyStudent.Name = "DataGridViewFormModifyStudent"
        Me.DataGridViewFormModifyStudent.ReadOnly = True
        Me.DataGridViewFormModifyStudent.RowTemplate.Height = 24
        Me.DataGridViewFormModifyStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewFormModifyStudent.Size = New System.Drawing.Size(918, 157)
        Me.DataGridViewFormModifyStudent.TabIndex = 1
        '
        'IDENTIFICATIONDOCUMENTDataGridViewTextBoxColumn
        '
        Me.IDENTIFICATIONDOCUMENTDataGridViewTextBoxColumn.DataPropertyName = "IDENTIFICATION_DOCUMENT"
        Me.IDENTIFICATIONDOCUMENTDataGridViewTextBoxColumn.HeaderText = "Número de identificación"
        Me.IDENTIFICATIONDOCUMENTDataGridViewTextBoxColumn.Name = "IDENTIFICATIONDOCUMENTDataGridViewTextBoxColumn"
        Me.IDENTIFICATIONDOCUMENTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FIRSTNAMEDataGridViewTextBoxColumn
        '
        Me.FIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FIRST_NAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "Primer nombre"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.Name = "FIRSTNAMEDataGridViewTextBoxColumn"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MIDDLENAMEDataGridViewTextBoxColumn
        '
        Me.MIDDLENAMEDataGridViewTextBoxColumn.DataPropertyName = "MIDDLE_NAME"
        Me.MIDDLENAMEDataGridViewTextBoxColumn.HeaderText = "Segundo nombre"
        Me.MIDDLENAMEDataGridViewTextBoxColumn.Name = "MIDDLENAMEDataGridViewTextBoxColumn"
        Me.MIDDLENAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SURNAMEDataGridViewTextBoxColumn
        '
        Me.SURNAMEDataGridViewTextBoxColumn.DataPropertyName = "SURNAME"
        Me.SURNAMEDataGridViewTextBoxColumn.HeaderText = "Primer apellido"
        Me.SURNAMEDataGridViewTextBoxColumn.Name = "SURNAMEDataGridViewTextBoxColumn"
        Me.SURNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SECONDSURNAMEDataGridViewTextBoxColumn
        '
        Me.SECONDSURNAMEDataGridViewTextBoxColumn.DataPropertyName = "SECOND_SURNAME"
        Me.SECONDSURNAMEDataGridViewTextBoxColumn.HeaderText = "Segundo apellido"
        Me.SECONDSURNAMEDataGridViewTextBoxColumn.Name = "SECONDSURNAMEDataGridViewTextBoxColumn"
        Me.SECONDSURNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PERSONBindingSource
        '
        Me.PERSONBindingSource.DataMember = "PERSON"
        Me.PERSONBindingSource.DataSource = Me.STUDENTSDataSetBindingSource
        '
        'STUDENTSDataSetBindingSource
        '
        Me.STUDENTSDataSetBindingSource.DataSource = Me.STUDENTSDataSet
        Me.STUDENTSDataSetBindingSource.Position = 0
        '
        'STUDENTSDataSet
        '
        Me.STUDENTSDataSet.DataSetName = "STUDENTSDataSet"
        Me.STUDENTSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorFormModifyStudent
        '
        Me.BindingNavigatorFormModifyStudent.AddNewItem = Nothing
        Me.BindingNavigatorFormModifyStudent.BindingSource = Me.PERSONBindingSource
        Me.BindingNavigatorFormModifyStudent.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigatorFormModifyStudent.DeleteItem = Nothing
        Me.BindingNavigatorFormModifyStudent.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindingNavigatorFormModifyStudent.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.BindingNavigatorFormModifyStudent.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigatorFormModifyStudent.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigatorFormModifyStudent.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigatorFormModifyStudent.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigatorFormModifyStudent.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigatorFormModifyStudent.Name = "BindingNavigatorFormModifyStudent"
        Me.BindingNavigatorFormModifyStudent.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigatorFormModifyStudent.Size = New System.Drawing.Size(918, 27)
        Me.BindingNavigatorFormModifyStudent.TabIndex = 0
        Me.BindingNavigatorFormModifyStudent.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 24)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'PanelModifyStudent
        '
        Me.PanelModifyStudent.Controls.Add(Me.TextBoxAddress)
        Me.PanelModifyStudent.Controls.Add(Me.LabelAddress)
        Me.PanelModifyStudent.Controls.Add(Me.TextBoxTelephone)
        Me.PanelModifyStudent.Controls.Add(Me.LabelTelephone)
        Me.PanelModifyStudent.Controls.Add(Me.ComboBoxTypeSex)
        Me.PanelModifyStudent.Controls.Add(Me.LabelTypeSex)
        Me.PanelModifyStudent.Controls.Add(Me.TextBoxSecondSurname)
        Me.PanelModifyStudent.Controls.Add(Me.LabelSecondSurname)
        Me.PanelModifyStudent.Controls.Add(Me.TextBoxFirstSurname)
        Me.PanelModifyStudent.Controls.Add(Me.LabelFirstSurname)
        Me.PanelModifyStudent.Controls.Add(Me.TextBoxMiddleName)
        Me.PanelModifyStudent.Controls.Add(Me.LabelMiddleName)
        Me.PanelModifyStudent.Controls.Add(Me.TextBoxFirstName)
        Me.PanelModifyStudent.Controls.Add(Me.LabelFirstName)
        Me.PanelModifyStudent.Controls.Add(Me.TextBoxNumberIdentification)
        Me.PanelModifyStudent.Controls.Add(Me.LabelNumberIdentification)
        Me.PanelModifyStudent.Controls.Add(Me.ComboBoxTypeIdentification)
        Me.PanelModifyStudent.Controls.Add(Me.LabelTypeIdentification)
        Me.PanelModifyStudent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelModifyStudent.Location = New System.Drawing.Point(0, 238)
        Me.PanelModifyStudent.Name = "PanelModifyStudent"
        Me.PanelModifyStudent.Size = New System.Drawing.Size(918, 299)
        Me.PanelModifyStudent.TabIndex = 2
        '
        'TextBoxAddress
        '
        Me.TextBoxAddress.Location = New System.Drawing.Point(210, 262)
        Me.TextBoxAddress.MaxLength = 15
        Me.TextBoxAddress.Name = "TextBoxAddress"
        Me.TextBoxAddress.Size = New System.Drawing.Size(679, 22)
        Me.TextBoxAddress.TabIndex = 8
        '
        'LabelAddress
        '
        Me.LabelAddress.AutoSize = True
        Me.LabelAddress.Location = New System.Drawing.Point(29, 267)
        Me.LabelAddress.Name = "LabelAddress"
        Me.LabelAddress.Size = New System.Drawing.Size(82, 17)
        Me.LabelAddress.TabIndex = 33
        Me.LabelAddress.Text = "Dirección(*)"
        '
        'TextBoxTelephone
        '
        Me.TextBoxTelephone.Location = New System.Drawing.Point(650, 200)
        Me.TextBoxTelephone.MaxLength = 15
        Me.TextBoxTelephone.Name = "TextBoxTelephone"
        Me.TextBoxTelephone.Size = New System.Drawing.Size(239, 22)
        Me.TextBoxTelephone.TabIndex = 7
        '
        'LabelTelephone
        '
        Me.LabelTelephone.AutoSize = True
        Me.LabelTelephone.Location = New System.Drawing.Point(470, 207)
        Me.LabelTelephone.Name = "LabelTelephone"
        Me.LabelTelephone.Size = New System.Drawing.Size(79, 17)
        Me.LabelTelephone.TabIndex = 37
        Me.LabelTelephone.Text = "Teléfono(*)"
        '
        'ComboBoxTypeSex
        '
        Me.ComboBoxTypeSex.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TYPESEXBindingSource, "CODE", True))
        Me.ComboBoxTypeSex.DataSource = Me.TYPESEXBindingSource
        Me.ComboBoxTypeSex.DisplayMember = "DESCRIPTION"
        Me.ComboBoxTypeSex.FormattingEnabled = True
        Me.ComboBoxTypeSex.Location = New System.Drawing.Point(210, 200)
        Me.ComboBoxTypeSex.Name = "ComboBoxTypeSex"
        Me.ComboBoxTypeSex.Size = New System.Drawing.Size(239, 24)
        Me.ComboBoxTypeSex.TabIndex = 6
        Me.ComboBoxTypeSex.ValueMember = "ID_TYPE_SEX"
        '
        'TYPESEXBindingSource
        '
        Me.TYPESEXBindingSource.DataMember = "TYPE_SEX"
        Me.TYPESEXBindingSource.DataSource = Me.STUDENTSDataSetBindingSource
        '
        'LabelTypeSex
        '
        Me.LabelTypeSex.AutoSize = True
        Me.LabelTypeSex.Location = New System.Drawing.Point(29, 207)
        Me.LabelTypeSex.Name = "LabelTypeSex"
        Me.LabelTypeSex.Size = New System.Drawing.Size(71, 17)
        Me.LabelTypeSex.TabIndex = 32
        Me.LabelTypeSex.Text = "Género(*)"
        '
        'TextBoxSecondSurname
        '
        Me.TextBoxSecondSurname.Location = New System.Drawing.Point(650, 139)
        Me.TextBoxSecondSurname.MaxLength = 25
        Me.TextBoxSecondSurname.Name = "TextBoxSecondSurname"
        Me.TextBoxSecondSurname.Size = New System.Drawing.Size(239, 22)
        Me.TextBoxSecondSurname.TabIndex = 5
        '
        'LabelSecondSurname
        '
        Me.LabelSecondSurname.AutoSize = True
        Me.LabelSecondSurname.Location = New System.Drawing.Point(470, 144)
        Me.LabelSecondSurname.Name = "LabelSecondSurname"
        Me.LabelSecondSurname.Size = New System.Drawing.Size(118, 17)
        Me.LabelSecondSurname.TabIndex = 36
        Me.LabelSecondSurname.Text = "Segundo apellido"
        '
        'TextBoxFirstSurname
        '
        Me.TextBoxFirstSurname.Location = New System.Drawing.Point(210, 139)
        Me.TextBoxFirstSurname.MaxLength = 25
        Me.TextBoxFirstSurname.Name = "TextBoxFirstSurname"
        Me.TextBoxFirstSurname.Size = New System.Drawing.Size(239, 22)
        Me.TextBoxFirstSurname.TabIndex = 4
        '
        'LabelFirstSurname
        '
        Me.LabelFirstSurname.AutoSize = True
        Me.LabelFirstSurname.Location = New System.Drawing.Point(29, 144)
        Me.LabelFirstSurname.Name = "LabelFirstSurname"
        Me.LabelFirstSurname.Size = New System.Drawing.Size(117, 17)
        Me.LabelFirstSurname.TabIndex = 31
        Me.LabelFirstSurname.Text = "Primer apellido(*)"
        '
        'TextBoxMiddleName
        '
        Me.TextBoxMiddleName.Location = New System.Drawing.Point(650, 78)
        Me.TextBoxMiddleName.MaxLength = 25
        Me.TextBoxMiddleName.Name = "TextBoxMiddleName"
        Me.TextBoxMiddleName.Size = New System.Drawing.Size(239, 22)
        Me.TextBoxMiddleName.TabIndex = 3
        '
        'LabelMiddleName
        '
        Me.LabelMiddleName.AutoSize = True
        Me.LabelMiddleName.Location = New System.Drawing.Point(470, 83)
        Me.LabelMiddleName.Name = "LabelMiddleName"
        Me.LabelMiddleName.Size = New System.Drawing.Size(117, 17)
        Me.LabelMiddleName.TabIndex = 35
        Me.LabelMiddleName.Text = "Segundo nombre"
        '
        'TextBoxFirstName
        '
        Me.TextBoxFirstName.Location = New System.Drawing.Point(210, 78)
        Me.TextBoxFirstName.MaxLength = 25
        Me.TextBoxFirstName.Name = "TextBoxFirstName"
        Me.TextBoxFirstName.Size = New System.Drawing.Size(239, 22)
        Me.TextBoxFirstName.TabIndex = 2
        '
        'LabelFirstName
        '
        Me.LabelFirstName.AutoSize = True
        Me.LabelFirstName.Location = New System.Drawing.Point(29, 83)
        Me.LabelFirstName.Name = "LabelFirstName"
        Me.LabelFirstName.Size = New System.Drawing.Size(116, 17)
        Me.LabelFirstName.TabIndex = 30
        Me.LabelFirstName.Text = "Primer nombre(*)"
        '
        'TextBoxNumberIdentification
        '
        Me.TextBoxNumberIdentification.Location = New System.Drawing.Point(650, 15)
        Me.TextBoxNumberIdentification.MaxLength = 30
        Me.TextBoxNumberIdentification.Name = "TextBoxNumberIdentification"
        Me.TextBoxNumberIdentification.Size = New System.Drawing.Size(239, 22)
        Me.TextBoxNumberIdentification.TabIndex = 1
        '
        'LabelNumberIdentification
        '
        Me.LabelNumberIdentification.AutoSize = True
        Me.LabelNumberIdentification.Location = New System.Drawing.Point(470, 22)
        Me.LabelNumberIdentification.Name = "LabelNumberIdentification"
        Me.LabelNumberIdentification.Size = New System.Drawing.Size(159, 17)
        Me.LabelNumberIdentification.TabIndex = 34
        Me.LabelNumberIdentification.Text = "Número identificación(*)"
        '
        'ComboBoxTypeIdentification
        '
        Me.ComboBoxTypeIdentification.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TYPEIDENTITYDOCUMENTBindingSource, "CODE", True))
        Me.ComboBoxTypeIdentification.DataSource = Me.TYPEIDENTITYDOCUMENTBindingSource
        Me.ComboBoxTypeIdentification.DisplayMember = "DESCRIPTION"
        Me.ComboBoxTypeIdentification.FormattingEnabled = True
        Me.ComboBoxTypeIdentification.Location = New System.Drawing.Point(210, 15)
        Me.ComboBoxTypeIdentification.Name = "ComboBoxTypeIdentification"
        Me.ComboBoxTypeIdentification.Size = New System.Drawing.Size(239, 24)
        Me.ComboBoxTypeIdentification.TabIndex = 0
        Me.ComboBoxTypeIdentification.ValueMember = "ID_TYPE_IDENTITY_DOCUMENT"
        '
        'TYPEIDENTITYDOCUMENTBindingSource
        '
        Me.TYPEIDENTITYDOCUMENTBindingSource.DataMember = "TYPE_IDENTITY_DOCUMENT"
        Me.TYPEIDENTITYDOCUMENTBindingSource.DataSource = Me.STUDENTSDataSetBindingSource
        '
        'LabelTypeIdentification
        '
        Me.LabelTypeIdentification.AutoSize = True
        Me.LabelTypeIdentification.Location = New System.Drawing.Point(29, 22)
        Me.LabelTypeIdentification.Name = "LabelTypeIdentification"
        Me.LabelTypeIdentification.Size = New System.Drawing.Size(137, 17)
        Me.LabelTypeIdentification.TabIndex = 29
        Me.LabelTypeIdentification.Text = "Tipo identificación(*)"
        '
        'PanelButton
        '
        Me.PanelButton.Controls.Add(Me.ButtonModifyStudent)
        Me.PanelButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelButton.Location = New System.Drawing.Point(0, 537)
        Me.PanelButton.Name = "PanelButton"
        Me.PanelButton.Size = New System.Drawing.Size(918, 62)
        Me.PanelButton.TabIndex = 3
        '
        'ButtonModifyStudent
        '
        Me.ButtonModifyStudent.Location = New System.Drawing.Point(373, 11)
        Me.ButtonModifyStudent.Name = "ButtonModifyStudent"
        Me.ButtonModifyStudent.Size = New System.Drawing.Size(172, 40)
        Me.ButtonModifyStudent.TabIndex = 0
        Me.ButtonModifyStudent.Text = "Modificar estudiante"
        Me.ButtonModifyStudent.UseVisualStyleBackColor = True
        '
        'PERSONTableAdapter
        '
        Me.PERSONTableAdapter.ClearBeforeFill = True
        '
        'TYPE_IDENTITY_DOCUMENTTableAdapter
        '
        Me.TYPE_IDENTITY_DOCUMENTTableAdapter.ClearBeforeFill = True
        '
        'TYPE_SEXTableAdapter
        '
        Me.TYPE_SEXTableAdapter.ClearBeforeFill = True
        '
        'FormModifyStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 599)
        Me.Controls.Add(Me.PanelModifyStudent)
        Me.Controls.Add(Me.PanelButton)
        Me.Controls.Add(Me.PanelSearchStudent)
        Me.Controls.Add(Me.PanelHelpFormModifyStudent)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(936, 646)
        Me.MinimumSize = New System.Drawing.Size(936, 646)
        Me.Name = "FormModifyStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar estudiante"
        CType(Me.ErrorProviderFormModifyStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHelpFormModifyStudent.ResumeLayout(False)
        Me.PanelSearchStudent.ResumeLayout(False)
        Me.PanelSearchStudent.PerformLayout()
        CType(Me.DataGridViewFormModifyStudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PERSONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STUDENTSDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STUDENTSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigatorFormModifyStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigatorFormModifyStudent.ResumeLayout(False)
        Me.BindingNavigatorFormModifyStudent.PerformLayout()
        Me.PanelModifyStudent.ResumeLayout(False)
        Me.PanelModifyStudent.PerformLayout()
        CType(Me.TYPESEXBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TYPEIDENTITYDOCUMENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelButton.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ErrorProviderFormModifyStudent As ErrorProvider
    Friend WithEvents PanelSearchStudent As Panel
    Friend WithEvents PanelHelpFormModifyStudent As Panel
    Friend WithEvents PanelModifyStudent As Panel
    Friend WithEvents PanelButton As Panel
    Friend WithEvents LabelHelpFormModifyStudent As Label
    Friend WithEvents DataGridViewFormModifyStudent As DataGridView
    Friend WithEvents BindingNavigatorFormModifyStudent As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents STUDENTSDataSetBindingSource As BindingSource
    Friend WithEvents STUDENTSDataSet As STUDENTSDataSet
    Friend WithEvents PERSONBindingSource As BindingSource
    Friend WithEvents PERSONTableAdapter As STUDENTSDataSetTableAdapters.PERSONTableAdapter
    Friend WithEvents IDENTIFICATIONDOCUMENTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FIRSTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MIDDLENAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SURNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SECONDSURNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TextBoxAddress As TextBox
    Friend WithEvents LabelAddress As Label
    Friend WithEvents TextBoxTelephone As TextBox
    Friend WithEvents LabelTelephone As Label
    Friend WithEvents ComboBoxTypeSex As ComboBox
    Friend WithEvents LabelTypeSex As Label
    Friend WithEvents TextBoxSecondSurname As TextBox
    Friend WithEvents LabelSecondSurname As Label
    Friend WithEvents TextBoxFirstSurname As TextBox
    Friend WithEvents LabelFirstSurname As Label
    Friend WithEvents TextBoxMiddleName As TextBox
    Friend WithEvents LabelMiddleName As Label
    Friend WithEvents TextBoxFirstName As TextBox
    Friend WithEvents LabelFirstName As Label
    Friend WithEvents TextBoxNumberIdentification As TextBox
    Friend WithEvents LabelNumberIdentification As Label
    Friend WithEvents ComboBoxTypeIdentification As ComboBox
    Friend WithEvents LabelTypeIdentification As Label
    Friend WithEvents TYPEIDENTITYDOCUMENTBindingSource As BindingSource
    Friend WithEvents TYPE_IDENTITY_DOCUMENTTableAdapter As STUDENTSDataSetTableAdapters.TYPE_IDENTITY_DOCUMENTTableAdapter
    Friend WithEvents TYPESEXBindingSource As BindingSource
    Friend WithEvents TYPE_SEXTableAdapter As STUDENTSDataSetTableAdapters.TYPE_SEXTableAdapter
    Friend WithEvents ButtonModifyStudent As Button
End Class
