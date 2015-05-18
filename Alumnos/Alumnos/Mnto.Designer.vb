<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mnto
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
        Me.divisor = New System.Windows.Forms.SplitContainer()
        Me.cmd_delete = New System.Windows.Forms.Button()
        Me.cmd_update = New System.Windows.Forms.Button()
        Me.cmd_insert = New System.Windows.Forms.Button()
        Me.lbl_tablas = New System.Windows.Forms.Label()
        Me.list_tablas = New System.Windows.Forms.ListBox()
        Me.dta_formulario = New System.Windows.Forms.DataGridView()
        CType(Me.divisor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.divisor.Panel1.SuspendLayout()
        Me.divisor.Panel2.SuspendLayout()
        Me.divisor.SuspendLayout()
        CType(Me.dta_formulario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'divisor
        '
        Me.divisor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.divisor.Location = New System.Drawing.Point(0, 0)
        Me.divisor.Name = "divisor"
        Me.divisor.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'divisor.Panel1
        '
        Me.divisor.Panel1.Controls.Add(Me.cmd_delete)
        Me.divisor.Panel1.Controls.Add(Me.cmd_update)
        Me.divisor.Panel1.Controls.Add(Me.cmd_insert)
        Me.divisor.Panel1.Controls.Add(Me.lbl_tablas)
        Me.divisor.Panel1.Controls.Add(Me.list_tablas)
        '
        'divisor.Panel2
        '
        Me.divisor.Panel2.Controls.Add(Me.dta_formulario)
        Me.divisor.Size = New System.Drawing.Size(1140, 634)
        Me.divisor.SplitterDistance = 64
        Me.divisor.TabIndex = 0
        '
        'cmd_delete
        '
        Me.cmd_delete.Location = New System.Drawing.Point(576, 18)
        Me.cmd_delete.Name = "cmd_delete"
        Me.cmd_delete.Size = New System.Drawing.Size(75, 37)
        Me.cmd_delete.TabIndex = 4
        Me.cmd_delete.Text = "Eliminar Registro"
        Me.cmd_delete.UseVisualStyleBackColor = True
        '
        'cmd_update
        '
        Me.cmd_update.Location = New System.Drawing.Point(462, 18)
        Me.cmd_update.Name = "cmd_update"
        Me.cmd_update.Size = New System.Drawing.Size(75, 37)
        Me.cmd_update.TabIndex = 3
        Me.cmd_update.Text = "Editar Registro"
        Me.cmd_update.UseVisualStyleBackColor = True
        '
        'cmd_insert
        '
        Me.cmd_insert.Location = New System.Drawing.Point(356, 18)
        Me.cmd_insert.Name = "cmd_insert"
        Me.cmd_insert.Size = New System.Drawing.Size(75, 37)
        Me.cmd_insert.TabIndex = 2
        Me.cmd_insert.Text = "Añadir Registro"
        Me.cmd_insert.UseVisualStyleBackColor = True
        '
        'lbl_tablas
        '
        Me.lbl_tablas.AutoSize = True
        Me.lbl_tablas.Location = New System.Drawing.Point(37, 12)
        Me.lbl_tablas.Name = "lbl_tablas"
        Me.lbl_tablas.Size = New System.Drawing.Size(93, 13)
        Me.lbl_tablas.TabIndex = 1
        Me.lbl_tablas.Text = "Seleccione Tabla:"
        '
        'list_tablas
        '
        Me.list_tablas.FormattingEnabled = True
        Me.list_tablas.Items.AddRange(New Object() {"Alumnos", "Asignaturas", "Matrículas"})
        Me.list_tablas.Location = New System.Drawing.Point(136, 12)
        Me.list_tablas.Name = "list_tablas"
        Me.list_tablas.Size = New System.Drawing.Size(120, 43)
        Me.list_tablas.TabIndex = 0
        '
        'dta_formulario
        '
        Me.dta_formulario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dta_formulario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dta_formulario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dta_formulario.Location = New System.Drawing.Point(0, 0)
        Me.dta_formulario.Name = "dta_formulario"
        Me.dta_formulario.ReadOnly = True
        Me.dta_formulario.Size = New System.Drawing.Size(1140, 566)
        Me.dta_formulario.TabIndex = 0
        '
        'Mnto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1140, 634)
        Me.Controls.Add(Me.divisor)
        Me.Name = "Mnto"
        Me.Text = "Mantenimiento BD"
        Me.divisor.Panel1.ResumeLayout(False)
        Me.divisor.Panel1.PerformLayout()
        Me.divisor.Panel2.ResumeLayout(False)
        CType(Me.divisor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.divisor.ResumeLayout(False)
        CType(Me.dta_formulario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents divisor As System.Windows.Forms.SplitContainer
    Friend WithEvents lbl_tablas As System.Windows.Forms.Label
    Friend WithEvents list_tablas As System.Windows.Forms.ListBox
    Friend WithEvents dta_formulario As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_delete As System.Windows.Forms.Button
    Friend WithEvents cmd_update As System.Windows.Forms.Button
    Friend WithEvents cmd_insert As System.Windows.Forms.Button

End Class
