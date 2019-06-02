<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDeleteStudent
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDeleteStudent))
        Me.PanelHelpFormDeleteStudent = New System.Windows.Forms.Panel()
        Me.LabelHelpFormDeleteStudent = New System.Windows.Forms.Label()
        Me.DataGridViewFormDeleteStudent = New System.Windows.Forms.DataGridView()
        Me.BindingNavigatorFormDeleteStudent = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.STUDENTSDataSet = New Unidad_3_Paso_3.STUDENTSDataSet()
        Me.PERSONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PERSONTableAdapter = New Unidad_3_Paso_3.STUDENTSDataSetTableAdapters.PERSONTableAdapter()
        Me.IDENTIFICATIONDOCUMENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRSTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MIDDLENAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SURNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SECONDSURNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.PanelHelpFormDeleteStudent.SuspendLayout()
        CType(Me.DataGridViewFormDeleteStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigatorFormDeleteStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigatorFormDeleteStudent.SuspendLayout()
        CType(Me.STUDENTSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PERSONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelHelpFormDeleteStudent
        '
        Me.PanelHelpFormDeleteStudent.Controls.Add(Me.LabelHelpFormDeleteStudent)
        Me.PanelHelpFormDeleteStudent.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHelpFormDeleteStudent.Location = New System.Drawing.Point(0, 0)
        Me.PanelHelpFormDeleteStudent.Name = "PanelHelpFormDeleteStudent"
        Me.PanelHelpFormDeleteStudent.Size = New System.Drawing.Size(800, 55)
        Me.PanelHelpFormDeleteStudent.TabIndex = 14
        '
        'LabelHelpFormDeleteStudent
        '
        Me.LabelHelpFormDeleteStudent.Location = New System.Drawing.Point(111, 19)
        Me.LabelHelpFormDeleteStudent.Name = "LabelHelpFormDeleteStudent"
        Me.LabelHelpFormDeleteStudent.Size = New System.Drawing.Size(579, 25)
        Me.LabelHelpFormDeleteStudent.TabIndex = 14
        Me.LabelHelpFormDeleteStudent.Text = "Bienvenido señor usuario en este formulario, usted podra eliminar un estudiante."
        Me.LabelHelpFormDeleteStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridViewFormDeleteStudent
        '
        Me.DataGridViewFormDeleteStudent.AllowUserToAddRows = False
        Me.DataGridViewFormDeleteStudent.AllowUserToDeleteRows = False
        Me.DataGridViewFormDeleteStudent.AutoGenerateColumns = False
        Me.DataGridViewFormDeleteStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewFormDeleteStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewFormDeleteStudent.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDENTIFICATIONDOCUMENTDataGridViewTextBoxColumn, Me.FIRSTNAMEDataGridViewTextBoxColumn, Me.MIDDLENAMEDataGridViewTextBoxColumn, Me.SURNAMEDataGridViewTextBoxColumn, Me.SECONDSURNAMEDataGridViewTextBoxColumn})
        Me.DataGridViewFormDeleteStudent.DataSource = Me.PERSONBindingSource
        Me.DataGridViewFormDeleteStudent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewFormDeleteStudent.Location = New System.Drawing.Point(0, 82)
        Me.DataGridViewFormDeleteStudent.MultiSelect = False
        Me.DataGridViewFormDeleteStudent.Name = "DataGridViewFormDeleteStudent"
        Me.DataGridViewFormDeleteStudent.ReadOnly = True
        Me.DataGridViewFormDeleteStudent.RowTemplate.Height = 24
        Me.DataGridViewFormDeleteStudent.Size = New System.Drawing.Size(800, 368)
        Me.DataGridViewFormDeleteStudent.TabIndex = 1
        '
        'BindingNavigatorFormDeleteStudent
        '
        Me.BindingNavigatorFormDeleteStudent.AddNewItem = Nothing
        Me.BindingNavigatorFormDeleteStudent.BindingSource = Me.PERSONBindingSource
        Me.BindingNavigatorFormDeleteStudent.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigatorFormDeleteStudent.DeleteItem = Nothing
        Me.BindingNavigatorFormDeleteStudent.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindingNavigatorFormDeleteStudent.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.BindingNavigatorFormDeleteStudent.Location = New System.Drawing.Point(0, 55)
        Me.BindingNavigatorFormDeleteStudent.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigatorFormDeleteStudent.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigatorFormDeleteStudent.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigatorFormDeleteStudent.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigatorFormDeleteStudent.Name = "BindingNavigatorFormDeleteStudent"
        Me.BindingNavigatorFormDeleteStudent.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigatorFormDeleteStudent.Size = New System.Drawing.Size(800, 27)
        Me.BindingNavigatorFormDeleteStudent.TabIndex = 0
        Me.BindingNavigatorFormDeleteStudent.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 24)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'STUDENTSDataSet
        '
        Me.STUDENTSDataSet.DataSetName = "STUDENTSDataSet"
        Me.STUDENTSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PERSONBindingSource
        '
        Me.PERSONBindingSource.DataMember = "PERSON"
        Me.PERSONBindingSource.DataSource = Me.STUDENTSDataSet
        '
        'PERSONTableAdapter
        '
        Me.PERSONTableAdapter.ClearBeforeFill = True
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
        Me.SURNAMEDataGridViewTextBoxColumn.HeaderText = "Apellido"
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
        'FormDeleteStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridViewFormDeleteStudent)
        Me.Controls.Add(Me.BindingNavigatorFormDeleteStudent)
        Me.Controls.Add(Me.PanelHelpFormDeleteStudent)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(818, 497)
        Me.MinimumSize = New System.Drawing.Size(818, 497)
        Me.Name = "FormDeleteStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar estudiante"
        Me.PanelHelpFormDeleteStudent.ResumeLayout(False)
        CType(Me.DataGridViewFormDeleteStudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigatorFormDeleteStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigatorFormDeleteStudent.ResumeLayout(False)
        Me.BindingNavigatorFormDeleteStudent.PerformLayout()
        CType(Me.STUDENTSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PERSONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelHelpFormDeleteStudent As Panel
    Friend WithEvents LabelHelpFormDeleteStudent As Label
    Friend WithEvents DataGridViewFormDeleteStudent As DataGridView
    Friend WithEvents BindingNavigatorFormDeleteStudent As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents STUDENTSDataSet As STUDENTSDataSet
    Friend WithEvents PERSONBindingSource As BindingSource
    Friend WithEvents PERSONTableAdapter As STUDENTSDataSetTableAdapters.PERSONTableAdapter
    Friend WithEvents IDENTIFICATIONDOCUMENTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FIRSTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MIDDLENAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SURNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SECONDSURNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
