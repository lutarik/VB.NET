<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.mnu_arx = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_arx_new_game = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_arx_exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_help_varios = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_ayuda_help = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnl_tablero = New System.Windows.Forms.Panel()
        Me.mnu_app.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnu_app
        '
        Me.mnu_app.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_arx, Me.mnu_help_varios})
        Me.mnu_app.Location = New System.Drawing.Point(0, 0)
        Me.mnu_app.Name = "mnu_app"
        Me.mnu_app.Size = New System.Drawing.Size(509, 24)
        Me.mnu_app.TabIndex = 1
        Me.mnu_app.Text = "MenuStrip1"
        '
        'mnu_arx
        '
        Me.mnu_arx.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_arx_new_game, Me.mnu_arx_exit})
        Me.mnu_arx.Name = "mnu_arx"
        Me.mnu_arx.Size = New System.Drawing.Size(60, 20)
        Me.mnu_arx.Text = "Archivo"
        '
        'mnu_arx_new_game
        '
        Me.mnu_arx_new_game.Name = "mnu_arx_new_game"
        Me.mnu_arx_new_game.Size = New System.Drawing.Size(152, 22)
        Me.mnu_arx_new_game.Text = "Nuevo Juego"
        '
        'mnu_arx_exit
        '
        Me.mnu_arx_exit.Name = "mnu_arx_exit"
        Me.mnu_arx_exit.Size = New System.Drawing.Size(152, 22)
        Me.mnu_arx_exit.Text = "Salir"
        '
        'mnu_help_varios
        '
        Me.mnu_help_varios.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_ayuda_help})
        Me.mnu_help_varios.Name = "mnu_help_varios"
        Me.mnu_help_varios.Size = New System.Drawing.Size(53, 20)
        Me.mnu_help_varios.Text = "Ayuda"
        '
        'mnu_ayuda_help
        '
        Me.mnu_ayuda_help.Name = "mnu_ayuda_help"
        Me.mnu_ayuda_help.Size = New System.Drawing.Size(108, 22)
        Me.mnu_ayuda_help.Text = "Ayuda"
        '
        'pnl_tablero
        '
        Me.pnl_tablero.Location = New System.Drawing.Point(12, 27)
        Me.pnl_tablero.Name = "pnl_tablero"
        Me.pnl_tablero.Size = New System.Drawing.Size(485, 485)
        Me.pnl_tablero.TabIndex = 2
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 524)
        Me.Controls.Add(Me.pnl_tablero)
        Me.Controls.Add(Me.mnu_app)
        Me.MaximizeBox = False
        Me.Name = "Principal"
        Me.Text = "Tres en Raya: El Juego"
        Me.mnu_app.ResumeLayout(False)
        Me.mnu_app.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnu_app As System.Windows.Forms.MenuStrip
    Friend WithEvents mnu_arx As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_arx_new_game As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_arx_exit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_help_varios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_ayuda_help As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnl_tablero As System.Windows.Forms.Panel

End Class
