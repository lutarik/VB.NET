<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmppal
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
        Me.Contenedor = New System.Windows.Forms.SplitContainer()
        Me.combo_tabla = New System.Windows.Forms.ComboBox()
        Me.ColegioDataSet = New Colegio.ColegioDataSet()
        Me.dta_datoscole = New System.Windows.Forms.DataGridView()
        Me.ColegioDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlumnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlumnosTableAdapter = New Colegio.ColegioDataSetTableAdapters.alumnosTableAdapter()
        CType(Me.Contenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Contenedor.Panel1.SuspendLayout()
        Me.Contenedor.Panel2.SuspendLayout()
        Me.Contenedor.SuspendLayout()
        CType(Me.ColegioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dta_datoscole, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColegioDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Contenedor
        '
        Me.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Contenedor.Location = New System.Drawing.Point(0, 0)
        Me.Contenedor.Name = "Contenedor"
        Me.Contenedor.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'Contenedor.Panel1
        '
        Me.Contenedor.Panel1.Controls.Add(Me.combo_tabla)
        '
        'Contenedor.Panel2
        '
        Me.Contenedor.Panel2.Controls.Add(Me.dta_datoscole)
        Me.Contenedor.Size = New System.Drawing.Size(1017, 739)
        Me.Contenedor.SplitterDistance = 92
        Me.Contenedor.TabIndex = 0
        '
        'combo_tabla
        '
        Me.combo_tabla.FormattingEnabled = True
        Me.combo_tabla.Items.AddRange(New Object() {"Alumnos", "Asignaturas", "Matriculas"})
        Me.combo_tabla.Location = New System.Drawing.Point(373, 37)
        Me.combo_tabla.Name = "combo_tabla"
        Me.combo_tabla.Size = New System.Drawing.Size(160, 21)
        Me.combo_tabla.TabIndex = 0
        '
        'ColegioDataSet
        '
        Me.ColegioDataSet.DataSetName = "ColegioDataSet"
        Me.ColegioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dta_datoscole
        '
        Me.dta_datoscole.AutoGenerateColumns = False
        Me.dta_datoscole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dta_datoscole.DataSource = Me.ColegioDataSetBindingSource
        Me.dta_datoscole.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dta_datoscole.Location = New System.Drawing.Point(0, 0)
        Me.dta_datoscole.Name = "dta_datoscole"
        Me.dta_datoscole.Size = New System.Drawing.Size(1017, 643)
        Me.dta_datoscole.TabIndex = 0
        '
        'ColegioDataSetBindingSource
        '
        Me.ColegioDataSetBindingSource.DataSource = Me.ColegioDataSet
        Me.ColegioDataSetBindingSource.Position = 0
        '
        'AlumnosBindingSource
        '
        Me.AlumnosBindingSource.DataMember = "alumnos"
        Me.AlumnosBindingSource.DataSource = Me.ColegioDataSetBindingSource
        '
        'AlumnosTableAdapter
        '
        Me.AlumnosTableAdapter.ClearBeforeFill = True
        '
        'frmppal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 739)
        Me.Controls.Add(Me.Contenedor)
        Me.Name = "frmppal"
        Me.Text = "Mantenimiento BD"
        Me.Contenedor.Panel1.ResumeLayout(False)
        Me.Contenedor.Panel2.ResumeLayout(False)
        CType(Me.Contenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Contenedor.ResumeLayout(False)
        CType(Me.ColegioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dta_datoscole, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColegioDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Contenedor As System.Windows.Forms.SplitContainer
    Friend WithEvents dta_datoscole As System.Windows.Forms.DataGridView
    Friend WithEvents ColegioDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ColegioDataSet As Colegio.ColegioDataSet
    Friend WithEvents combo_tabla As System.Windows.Forms.ComboBox
    Friend WithEvents AlumnosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AlumnosTableAdapter As Colegio.ColegioDataSetTableAdapters.alumnosTableAdapter

End Class
