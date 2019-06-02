<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSearchStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSearchStudent))
        Me.BindingNavigatorFormSearchStudent = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DataGridViewFormSearchStudent = New System.Windows.Forms.DataGridView()
        Me.STUDENTSDataSet = New Unidad_3_Paso_3.STUDENTSDataSet()
        Me.PERSONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PERSONTableAdapter = New Unidad_3_Paso_3.STUDENTSDataSetTableAdapters.PERSONTableAdapter()
        Me.IDPERSONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDENTIFICATIONDOCUMENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRSTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MIDDLENAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SURNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SECONDSURNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TELEPHONEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStripLabelFormSearchStudent = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBoxFormSearchStudent = New System.Windows.Forms.ToolStripTextBox()
        CType(Me.BindingNavigatorFormSearchStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigatorFormSearchStudent.SuspendLayout()
        CType(Me.DataGridViewFormSearchStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STUDENTSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PERSONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingNavigatorFormSearchStudent
        '
        Me.BindingNavigatorFormSearchStudent.AddNewItem = Nothing
        Me.BindingNavigatorFormSearchStudent.BindingSource = Me.PERSONBindingSource
        Me.BindingNavigatorFormSearchStudent.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigatorFormSearchStudent.DeleteItem = Nothing
        Me.BindingNavigatorFormSearchStudent.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindingNavigatorFormSearchStudent.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripLabelFormSearchStudent, Me.ToolStripTextBoxFormSearchStudent})
        Me.BindingNavigatorFormSearchStudent.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigatorFormSearchStudent.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigatorFormSearchStudent.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigatorFormSearchStudent.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigatorFormSearchStudent.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigatorFormSearchStudent.Name = "BindingNavigatorFormSearchStudent"
        Me.BindingNavigatorFormSearchStudent.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigatorFormSearchStudent.Size = New System.Drawing.Size(1768, 27)
        Me.BindingNavigatorFormSearchStudent.TabIndex = 0
        Me.BindingNavigatorFormSearchStudent.Text = "BindingNavigator1"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'DataGridViewFormSearchStudent
        '
        Me.DataGridViewFormSearchStudent.AllowUserToAddRows = False
        Me.DataGridViewFormSearchStudent.AllowUserToDeleteRows = False
        Me.DataGridViewFormSearchStudent.AutoGenerateColumns = False
        Me.DataGridViewFormSearchStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewFormSearchStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewFormSearchStudent.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDPERSONDataGridViewTextBoxColumn, Me.IDENTIFICATIONDOCUMENTDataGridViewTextBoxColumn, Me.FIRSTNAMEDataGridViewTextBoxColumn, Me.MIDDLENAMEDataGridViewTextBoxColumn, Me.SURNAMEDataGridViewTextBoxColumn, Me.SECONDSURNAMEDataGridViewTextBoxColumn, Me.TELEPHONEDataGridViewTextBoxColumn, Me.ADDRESSDataGridViewTextBoxColumn})
        Me.DataGridViewFormSearchStudent.DataSource = Me.PERSONBindingSource
        Me.DataGridViewFormSearchStudent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewFormSearchStudent.Location = New System.Drawing.Point(0, 27)
        Me.DataGridViewFormSearchStudent.Name = "DataGridViewFormSearchStudent"
        Me.DataGridViewFormSearchStudent.ReadOnly = True
        Me.DataGridViewFormSearchStudent.RowTemplate.Height = 24
        Me.DataGridViewFormSearchStudent.Size = New System.Drawing.Size(1768, 423)
        Me.DataGridViewFormSearchStudent.TabIndex = 1
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
        'IDPERSONDataGridViewTextBoxColumn
        '
        Me.IDPERSONDataGridViewTextBoxColumn.DataPropertyName = "ID_PERSON"
        Me.IDPERSONDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDPERSONDataGridViewTextBoxColumn.Name = "IDPERSONDataGridViewTextBoxColumn"
        Me.IDPERSONDataGridViewTextBoxColumn.ReadOnly = True
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
        'TELEPHONEDataGridViewTextBoxColumn
        '
        Me.TELEPHONEDataGridViewTextBoxColumn.DataPropertyName = "TELEPHONE"
        Me.TELEPHONEDataGridViewTextBoxColumn.HeaderText = "Teléfono"
        Me.TELEPHONEDataGridViewTextBoxColumn.Name = "TELEPHONEDataGridViewTextBoxColumn"
        Me.TELEPHONEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ADDRESSDataGridViewTextBoxColumn
        '
        Me.ADDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS"
        Me.ADDRESSDataGridViewTextBoxColumn.HeaderText = "Dirección"
        Me.ADDRESSDataGridViewTextBoxColumn.Name = "ADDRESSDataGridViewTextBoxColumn"
        Me.ADDRESSDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ToolStripLabelFormSearchStudent
        '
        Me.ToolStripLabelFormSearchStudent.Name = "ToolStripLabelFormSearchStudent"
        Me.ToolStripLabelFormSearchStudent.Size = New System.Drawing.Size(55, 24)
        Me.ToolStripLabelFormSearchStudent.Text = "Buscar:"
        '
        'ToolStripTextBoxFormSearchStudent
        '
        Me.ToolStripTextBoxFormSearchStudent.Name = "ToolStripTextBoxFormSearchStudent"
        Me.ToolStripTextBoxFormSearchStudent.Size = New System.Drawing.Size(200, 27)
        '
        'FormSearchStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1768, 450)
        Me.Controls.Add(Me.DataGridViewFormSearchStudent)
        Me.Controls.Add(Me.BindingNavigatorFormSearchStudent)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1786, 497)
        Me.MinimumSize = New System.Drawing.Size(1786, 497)
        Me.Name = "FormSearchStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar estudiante"
        CType(Me.BindingNavigatorFormSearchStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigatorFormSearchStudent.ResumeLayout(False)
        Me.BindingNavigatorFormSearchStudent.PerformLayout()
        CType(Me.DataGridViewFormSearchStudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STUDENTSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PERSONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BindingNavigatorFormSearchStudent As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents DataGridViewFormSearchStudent As DataGridView
    Friend WithEvents STUDENTSDataSet As STUDENTSDataSet
    Friend WithEvents PERSONBindingSource As BindingSource
    Friend WithEvents PERSONTableAdapter As STUDENTSDataSetTableAdapters.PERSONTableAdapter
    Friend WithEvents IDPERSONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDENTIFICATIONDOCUMENTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FIRSTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MIDDLENAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SURNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SECONDSURNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TELEPHONEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ADDRESSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripLabelFormSearchStudent As ToolStripLabel
    Friend WithEvents ToolStripTextBoxFormSearchStudent As ToolStripTextBox
End Class
