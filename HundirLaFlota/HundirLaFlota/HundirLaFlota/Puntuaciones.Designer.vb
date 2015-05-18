<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_puntuaciones
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
        Me.dta_puntuaciones = New System.Windows.Forms.DataGridView()
        Me.HundirLaFlotaDS = New HundirLaFlota.HundirLaFlotaDS()
        Me.PuntuacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PuntuacionesTableAdapter = New HundirLaFlota.HundirLaFlotaDSTableAdapters.PuntuacionesTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DisparosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TiempoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dta_puntuaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HundirLaFlotaDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PuntuacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dta_puntuaciones
        '
        Me.dta_puntuaciones.AutoGenerateColumns = False
        Me.dta_puntuaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dta_puntuaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidosDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.DisparosDataGridViewTextBoxColumn, Me.TiempoDataGridViewTextBoxColumn, Me.TableroDataGridViewTextBoxColumn})
        Me.dta_puntuaciones.DataSource = Me.PuntuacionesBindingSource
        Me.dta_puntuaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dta_puntuaciones.Location = New System.Drawing.Point(0, 0)
        Me.dta_puntuaciones.Name = "dta_puntuaciones"
        Me.dta_puntuaciones.Size = New System.Drawing.Size(744, 379)
        Me.dta_puntuaciones.TabIndex = 0
        '
        'HundirLaFlotaDS
        '
        Me.HundirLaFlotaDS.DataSetName = "HundirLaFlotaDS"
        Me.HundirLaFlotaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PuntuacionesBindingSource
        '
        Me.PuntuacionesBindingSource.DataMember = "Puntuaciones"
        Me.PuntuacionesBindingSource.DataSource = Me.HundirLaFlotaDS
        '
        'PuntuacionesTableAdapter
        '
        Me.PuntuacionesTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'ApellidosDataGridViewTextBoxColumn
        '
        Me.ApellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.Name = "ApellidosDataGridViewTextBoxColumn"
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        '
        'DisparosDataGridViewTextBoxColumn
        '
        Me.DisparosDataGridViewTextBoxColumn.DataPropertyName = "Disparos"
        Me.DisparosDataGridViewTextBoxColumn.HeaderText = "Disparos"
        Me.DisparosDataGridViewTextBoxColumn.Name = "DisparosDataGridViewTextBoxColumn"
        '
        'TiempoDataGridViewTextBoxColumn
        '
        Me.TiempoDataGridViewTextBoxColumn.DataPropertyName = "Tiempo"
        Me.TiempoDataGridViewTextBoxColumn.HeaderText = "Tiempo"
        Me.TiempoDataGridViewTextBoxColumn.Name = "TiempoDataGridViewTextBoxColumn"
        '
        'TableroDataGridViewTextBoxColumn
        '
        Me.TableroDataGridViewTextBoxColumn.DataPropertyName = "Tablero"
        Me.TableroDataGridViewTextBoxColumn.HeaderText = "Tablero"
        Me.TableroDataGridViewTextBoxColumn.Name = "TableroDataGridViewTextBoxColumn"
        '
        'frm_puntuaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 379)
        Me.Controls.Add(Me.dta_puntuaciones)
        Me.Name = "frm_puntuaciones"
        Me.Text = "Ver Puntuaciones"
        CType(Me.dta_puntuaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HundirLaFlotaDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PuntuacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dta_puntuaciones As System.Windows.Forms.DataGridView
    Friend WithEvents HundirLaFlotaDS As HundirLaFlota.HundirLaFlotaDS
    Friend WithEvents PuntuacionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PuntuacionesTableAdapter As HundirLaFlota.HundirLaFlotaDSTableAdapters.PuntuacionesTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DisparosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TiempoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
