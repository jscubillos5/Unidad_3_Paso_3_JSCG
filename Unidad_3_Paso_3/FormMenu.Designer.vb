<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenu))
        Me.MenuStripFormMenu = New System.Windows.Forms.MenuStrip()
        Me.StudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterStudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyStudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteStudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchStudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripFormMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStripFormMenu
        '
        Me.MenuStripFormMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStripFormMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentsToolStripMenuItem})
        Me.MenuStripFormMenu.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripFormMenu.Name = "MenuStripFormMenu"
        Me.MenuStripFormMenu.Size = New System.Drawing.Size(754, 28)
        Me.MenuStripFormMenu.TabIndex = 0
        Me.MenuStripFormMenu.Text = "MenuStrip1"
        '
        'StudentsToolStripMenuItem
        '
        Me.StudentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegisterStudentsToolStripMenuItem, Me.ModifyStudentsToolStripMenuItem, Me.DeleteStudentsToolStripMenuItem, Me.SearchStudentsToolStripMenuItem})
        Me.StudentsToolStripMenuItem.Name = "StudentsToolStripMenuItem"
        Me.StudentsToolStripMenuItem.Size = New System.Drawing.Size(96, 24)
        Me.StudentsToolStripMenuItem.Text = "Estudiantes"
        '
        'RegisterStudentsToolStripMenuItem
        '
        Me.RegisterStudentsToolStripMenuItem.Name = "RegisterStudentsToolStripMenuItem"
        Me.RegisterStudentsToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.RegisterStudentsToolStripMenuItem.Text = "Registrar"
        '
        'ModifyStudentsToolStripMenuItem
        '
        Me.ModifyStudentsToolStripMenuItem.Name = "ModifyStudentsToolStripMenuItem"
        Me.ModifyStudentsToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.ModifyStudentsToolStripMenuItem.Text = "Modificar"
        '
        'DeleteStudentsToolStripMenuItem
        '
        Me.DeleteStudentsToolStripMenuItem.Name = "DeleteStudentsToolStripMenuItem"
        Me.DeleteStudentsToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.DeleteStudentsToolStripMenuItem.Text = "Eliminar"
        '
        'SearchStudentsToolStripMenuItem
        '
        Me.SearchStudentsToolStripMenuItem.Name = "SearchStudentsToolStripMenuItem"
        Me.SearchStudentsToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.SearchStudentsToolStripMenuItem.Text = "Consultar"
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 252)
        Me.Controls.Add(Me.MenuStripFormMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStripFormMenu
        Me.MaximumSize = New System.Drawing.Size(772, 299)
        Me.MinimumSize = New System.Drawing.Size(772, 299)
        Me.Name = "FormMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú principal"
        Me.MenuStripFormMenu.ResumeLayout(False)
        Me.MenuStripFormMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStripFormMenu As MenuStrip
    Friend WithEvents StudentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegisterStudentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifyStudentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteStudentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchStudentsToolStripMenuItem As ToolStripMenuItem
End Class
