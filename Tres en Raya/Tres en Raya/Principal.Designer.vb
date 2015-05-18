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
        Me.tbl_tablero = New System.Windows.Forms.TableLayoutPanel()
        Me.cmb_jugador1 = New System.Windows.Forms.ComboBox()
        Me.cmb_jugador2 = New System.Windows.Forms.ComboBox()
        Me.lbl_jugador1 = New System.Windows.Forms.Label()
        Me.lbl_jugador2 = New System.Windows.Forms.Label()
        Me.group_jugadores = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mnu_app.SuspendLayout()
        Me.group_jugadores.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnu_app
        '
        Me.mnu_app.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_arx, Me.mnu_help_varios})
        Me.mnu_app.Location = New System.Drawing.Point(0, 0)
        Me.mnu_app.Name = "mnu_app"
        Me.mnu_app.Size = New System.Drawing.Size(660, 24)
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
        Me.mnu_arx_new_game.Size = New System.Drawing.Size(143, 22)
        Me.mnu_arx_new_game.Text = "Nuevo Juego"
        '
        'mnu_arx_exit
        '
        Me.mnu_arx_exit.Name = "mnu_arx_exit"
        Me.mnu_arx_exit.Size = New System.Drawing.Size(143, 22)
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
        'tbl_tablero
        '
        Me.tbl_tablero.ColumnCount = 3
        Me.tbl_tablero.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333282!))
        Me.tbl_tablero.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333282!))
        Me.tbl_tablero.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333282!))
        Me.tbl_tablero.Location = New System.Drawing.Point(225, 77)
        Me.tbl_tablero.Name = "tbl_tablero"
        Me.tbl_tablero.RowCount = 3
        Me.tbl_tablero.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333282!))
        Me.tbl_tablero.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333282!))
        Me.tbl_tablero.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333282!))
        Me.tbl_tablero.Size = New System.Drawing.Size(423, 367)
        Me.tbl_tablero.TabIndex = 2
        '
        'cmb_jugador1
        '
        Me.cmb_jugador1.FormattingEnabled = True
        Me.cmb_jugador1.Items.AddRange(New Object() {"Cruz", "Circulo"})
        Me.cmb_jugador1.Location = New System.Drawing.Point(9, 69)
        Me.cmb_jugador1.Name = "cmb_jugador1"
        Me.cmb_jugador1.Size = New System.Drawing.Size(121, 25)
        Me.cmb_jugador1.TabIndex = 3
        '
        'cmb_jugador2
        '
        Me.cmb_jugador2.FormattingEnabled = True
        Me.cmb_jugador2.Items.AddRange(New Object() {"Cruz", "Circulo"})
        Me.cmb_jugador2.Location = New System.Drawing.Point(9, 139)
        Me.cmb_jugador2.Name = "cmb_jugador2"
        Me.cmb_jugador2.Size = New System.Drawing.Size(121, 25)
        Me.cmb_jugador2.TabIndex = 4
        '
        'lbl_jugador1
        '
        Me.lbl_jugador1.AutoSize = True
        Me.lbl_jugador1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_jugador1.Location = New System.Drawing.Point(6, 36)
        Me.lbl_jugador1.Name = "lbl_jugador1"
        Me.lbl_jugador1.Size = New System.Drawing.Size(76, 17)
        Me.lbl_jugador1.TabIndex = 5
        Me.lbl_jugador1.Text = "Jugador 1:"
        '
        'lbl_jugador2
        '
        Me.lbl_jugador2.AutoSize = True
        Me.lbl_jugador2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_jugador2.Location = New System.Drawing.Point(6, 109)
        Me.lbl_jugador2.Name = "lbl_jugador2"
        Me.lbl_jugador2.Size = New System.Drawing.Size(76, 17)
        Me.lbl_jugador2.TabIndex = 6
        Me.lbl_jugador2.Text = "Jugador 2:"
        '
        'group_jugadores
        '
        Me.group_jugadores.Controls.Add(Me.lbl_jugador1)
        Me.group_jugadores.Controls.Add(Me.lbl_jugador2)
        Me.group_jugadores.Controls.Add(Me.cmb_jugador1)
        Me.group_jugadores.Controls.Add(Me.cmb_jugador2)
        Me.group_jugadores.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.group_jugadores.Location = New System.Drawing.Point(21, 117)
        Me.group_jugadores.Name = "group_jugadores"
        Me.group_jugadores.Size = New System.Drawing.Size(147, 203)
        Me.group_jugadores.TabIndex = 7
        Me.group_jugadores.TabStop = False
        Me.group_jugadores.Text = "Selección ficha:"
        Me.group_jugadores.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 347)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Label1"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 493)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.group_jugadores)
        Me.Controls.Add(Me.tbl_tablero)
        Me.Controls.Add(Me.mnu_app)
        Me.MaximizeBox = False
        Me.Name = "Principal"
        Me.Text = "Tres en Raya: El Juego"
        Me.mnu_app.ResumeLayout(False)
        Me.mnu_app.PerformLayout()
        Me.group_jugadores.ResumeLayout(False)
        Me.group_jugadores.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnu_app As System.Windows.Forms.MenuStrip
    Friend WithEvents mnu_arx As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_arx_new_game As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_arx_exit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_help_varios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_ayuda_help As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbl_tablero As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmb_jugador1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_jugador2 As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_jugador1 As System.Windows.Forms.Label
    Friend WithEvents lbl_jugador2 As System.Windows.Forms.Label
    Friend WithEvents group_jugadores As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
