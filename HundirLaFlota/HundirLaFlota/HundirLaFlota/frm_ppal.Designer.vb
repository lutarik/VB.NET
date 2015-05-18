<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ppal
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
        Me.mnu_app = New System.Windows.Forms.MenuStrip()
        Me.mnu_archivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_newgame = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_opciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_solucion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_puntuaciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_puntuacionesXtiempo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_puntuacionesXtablero = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_puntuacionesDia = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_insert = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnl_tablero = New System.Windows.Forms.Panel()
        Me.mnu_app.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnu_app
        '
        Me.mnu_app.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_archivo, Me.mnu_opciones})
        Me.mnu_app.Location = New System.Drawing.Point(0, 0)
        Me.mnu_app.Name = "mnu_app"
        Me.mnu_app.Size = New System.Drawing.Size(624, 24)
        Me.mnu_app.TabIndex = 0
        Me.mnu_app.Text = "MenuStrip1"
        '
        'mnu_archivo
        '
        Me.mnu_archivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_newgame, Me.mnu_exit})
        Me.mnu_archivo.Name = "mnu_archivo"
        Me.mnu_archivo.Size = New System.Drawing.Size(60, 20)
        Me.mnu_archivo.Text = "Archivo"
        '
        'mnu_newgame
        '
        Me.mnu_newgame.Name = "mnu_newgame"
        Me.mnu_newgame.Size = New System.Drawing.Size(143, 22)
        Me.mnu_newgame.Text = "Nuevo Juego"
        '
        'mnu_exit
        '
        Me.mnu_exit.Name = "mnu_exit"
        Me.mnu_exit.Size = New System.Drawing.Size(143, 22)
        Me.mnu_exit.Text = "Sair"
        '
        'mnu_opciones
        '
        Me.mnu_opciones.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_solucion, Me.mnu_puntuaciones, Me.mnu_puntuacionesXtiempo, Me.mnu_puntuacionesXtablero, Me.mnu_puntuacionesDia, Me.mnu_insert})
        Me.mnu_opciones.Name = "mnu_opciones"
        Me.mnu_opciones.Size = New System.Drawing.Size(69, 20)
        Me.mnu_opciones.Text = "Opciones"
        '
        'mnu_solucion
        '
        Me.mnu_solucion.Enabled = False
        Me.mnu_solucion.Name = "mnu_solucion"
        Me.mnu_solucion.Size = New System.Drawing.Size(177, 22)
        Me.mnu_solucion.Text = "Ver Barcos"
        '
        'mnu_puntuaciones
        '
        Me.mnu_puntuaciones.Name = "mnu_puntuaciones"
        Me.mnu_puntuaciones.Size = New System.Drawing.Size(177, 22)
        Me.mnu_puntuaciones.Text = "Ver Puntuaciones"
        '
        'mnu_puntuacionesXtiempo
        '
        Me.mnu_puntuacionesXtiempo.Name = "mnu_puntuacionesXtiempo"
        Me.mnu_puntuacionesXtiempo.Size = New System.Drawing.Size(177, 22)
        Me.mnu_puntuacionesXtiempo.Text = "Ord. Por Tiempo"
        '
        'mnu_puntuacionesXtablero
        '
        Me.mnu_puntuacionesXtablero.Name = "mnu_puntuacionesXtablero"
        Me.mnu_puntuacionesXtablero.Size = New System.Drawing.Size(177, 22)
        Me.mnu_puntuacionesXtablero.Text = "Ord. Por Tablero"
        '
        'mnu_puntuacionesDia
        '
        Me.mnu_puntuacionesDia.Name = "mnu_puntuacionesDia"
        Me.mnu_puntuacionesDia.Size = New System.Drawing.Size(177, 22)
        Me.mnu_puntuacionesDia.Text = "Del Dia Actual"
        '
        'mnu_insert
        '
        Me.mnu_insert.Name = "mnu_insert"
        Me.mnu_insert.Size = New System.Drawing.Size(177, 22)
        Me.mnu_insert.Text = "Insertar Puntuación"
        '
        'pnl_tablero
        '
        Me.pnl_tablero.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_tablero.Location = New System.Drawing.Point(0, 24)
        Me.pnl_tablero.Name = "pnl_tablero"
        Me.pnl_tablero.Size = New System.Drawing.Size(624, 577)
        Me.pnl_tablero.TabIndex = 1
        '
        'frm_ppal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 601)
        Me.Controls.Add(Me.pnl_tablero)
        Me.Controls.Add(Me.mnu_app)
        Me.MainMenuStrip = Me.mnu_app
        Me.Name = "frm_ppal"
        Me.Text = "Hundir La Flota"
        Me.mnu_app.ResumeLayout(False)
        Me.mnu_app.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnu_app As System.Windows.Forms.MenuStrip
    Friend WithEvents mnu_archivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_newgame As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_exit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_opciones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_solucion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_puntuaciones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_puntuacionesXtiempo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_puntuacionesXtablero As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_puntuacionesDia As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnl_tablero As System.Windows.Forms.Panel
    Friend WithEvents mnu_insert As System.Windows.Forms.ToolStripMenuItem

End Class
