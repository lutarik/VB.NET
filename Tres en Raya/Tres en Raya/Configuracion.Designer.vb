<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configuracion
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nombre1 = New System.Windows.Forms.TextBox()
        Me.txt_nombre2 = New System.Windows.Forms.TextBox()
        Me.btn_img1 = New System.Windows.Forms.Button()
        Me.btn_img2 = New System.Windows.Forms.Button()
        Me.ofd_imagen = New System.Windows.Forms.OpenFileDialog()
        Me.pic_jug2 = New System.Windows.Forms.PictureBox()
        Me.pic_jug1 = New System.Windows.Forms.PictureBox()
        Me.chk_defecto1 = New System.Windows.Forms.CheckBox()
        Me.chk_defecto2 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.opt_3x3 = New System.Windows.Forms.RadioButton()
        Me.opt_4x4 = New System.Windows.Forms.RadioButton()
        Me.opt_5x5 = New System.Windows.Forms.RadioButton()
        Me.chk_pc = New System.Windows.Forms.CheckBox()
        Me.mnu_app = New System.Windows.Forms.MenuStrip()
        Me.mnu_arx = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_arx_save = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.pic_jug2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_jug1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.mnu_app.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jugador 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(387, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jugador 2:"
        '
        'txt_nombre1
        '
        Me.txt_nombre1.Location = New System.Drawing.Point(114, 31)
        Me.txt_nombre1.Name = "txt_nombre1"
        Me.txt_nombre1.Size = New System.Drawing.Size(129, 20)
        Me.txt_nombre1.TabIndex = 2
        Me.txt_nombre1.Text = "Jugador 1"
        Me.txt_nombre1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_nombre2
        '
        Me.txt_nombre2.Location = New System.Drawing.Point(450, 31)
        Me.txt_nombre2.Name = "txt_nombre2"
        Me.txt_nombre2.Size = New System.Drawing.Size(129, 20)
        Me.txt_nombre2.TabIndex = 3
        Me.txt_nombre2.Text = "Jugador 2"
        Me.txt_nombre2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_img1
        '
        Me.btn_img1.Location = New System.Drawing.Point(32, 117)
        Me.btn_img1.Name = "btn_img1"
        Me.btn_img1.Size = New System.Drawing.Size(75, 23)
        Me.btn_img1.TabIndex = 6
        Me.btn_img1.Text = "Imagen"
        Me.btn_img1.UseVisualStyleBackColor = True
        '
        'btn_img2
        '
        Me.btn_img2.Location = New System.Drawing.Point(369, 117)
        Me.btn_img2.Name = "btn_img2"
        Me.btn_img2.Size = New System.Drawing.Size(75, 23)
        Me.btn_img2.TabIndex = 7
        Me.btn_img2.Text = "Imagen"
        Me.btn_img2.UseVisualStyleBackColor = True
        '
        'ofd_imagen
        '
        Me.ofd_imagen.FileName = "OpenFileDialog1"
        '
        'pic_jug2
        '
        Me.pic_jug2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_jug2.InitialImage = Nothing
        Me.pic_jug2.Location = New System.Drawing.Point(450, 71)
        Me.pic_jug2.Name = "pic_jug2"
        Me.pic_jug2.Size = New System.Drawing.Size(128, 107)
        Me.pic_jug2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_jug2.TabIndex = 5
        Me.pic_jug2.TabStop = False
        '
        'pic_jug1
        '
        Me.pic_jug1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_jug1.Location = New System.Drawing.Point(114, 71)
        Me.pic_jug1.Name = "pic_jug1"
        Me.pic_jug1.Size = New System.Drawing.Size(128, 107)
        Me.pic_jug1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_jug1.TabIndex = 4
        Me.pic_jug1.TabStop = False
        '
        'chk_defecto1
        '
        Me.chk_defecto1.AutoSize = True
        Me.chk_defecto1.Location = New System.Drawing.Point(131, 194)
        Me.chk_defecto1.Name = "chk_defecto1"
        Me.chk_defecto1.Size = New System.Drawing.Size(83, 17)
        Me.chk_defecto1.TabIndex = 8
        Me.chk_defecto1.Text = "Por Defecto"
        Me.chk_defecto1.UseVisualStyleBackColor = True
        '
        'chk_defecto2
        '
        Me.chk_defecto2.AutoSize = True
        Me.chk_defecto2.Location = New System.Drawing.Point(472, 194)
        Me.chk_defecto2.Name = "chk_defecto2"
        Me.chk_defecto2.Size = New System.Drawing.Size(83, 17)
        Me.chk_defecto2.TabIndex = 9
        Me.chk_defecto2.Text = "Por Defecto"
        Me.chk_defecto2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.opt_5x5)
        Me.GroupBox1.Controls.Add(Me.opt_4x4)
        Me.GroupBox1.Controls.Add(Me.opt_3x3)
        Me.GroupBox1.Location = New System.Drawing.Point(131, 241)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(446, 43)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selección de tipo de juego:"
        '
        'opt_3x3
        '
        Me.opt_3x3.AutoSize = True
        Me.opt_3x3.Location = New System.Drawing.Point(130, 19)
        Me.opt_3x3.Name = "opt_3x3"
        Me.opt_3x3.Size = New System.Drawing.Size(42, 17)
        Me.opt_3x3.TabIndex = 0
        Me.opt_3x3.TabStop = True
        Me.opt_3x3.Text = "3x3"
        Me.opt_3x3.UseVisualStyleBackColor = True
        '
        'opt_4x4
        '
        Me.opt_4x4.AutoSize = True
        Me.opt_4x4.Location = New System.Drawing.Point(209, 19)
        Me.opt_4x4.Name = "opt_4x4"
        Me.opt_4x4.Size = New System.Drawing.Size(42, 17)
        Me.opt_4x4.TabIndex = 1
        Me.opt_4x4.TabStop = True
        Me.opt_4x4.Text = "4x4"
        Me.opt_4x4.UseVisualStyleBackColor = True
        '
        'opt_5x5
        '
        Me.opt_5x5.AutoSize = True
        Me.opt_5x5.Location = New System.Drawing.Point(283, 19)
        Me.opt_5x5.Name = "opt_5x5"
        Me.opt_5x5.Size = New System.Drawing.Size(42, 17)
        Me.opt_5x5.TabIndex = 2
        Me.opt_5x5.TabStop = True
        Me.opt_5x5.Text = "5x5"
        Me.opt_5x5.UseVisualStyleBackColor = True
        '
        'chk_pc
        '
        Me.chk_pc.AutoSize = True
        Me.chk_pc.Location = New System.Drawing.Point(472, 215)
        Me.chk_pc.Name = "chk_pc"
        Me.chk_pc.Size = New System.Drawing.Size(76, 17)
        Me.chk_pc.TabIndex = 11
        Me.chk_pc.Text = "Ordenador"
        Me.chk_pc.UseVisualStyleBackColor = True
        '
        'mnu_app
        '
        Me.mnu_app.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_arx})
        Me.mnu_app.Location = New System.Drawing.Point(0, 0)
        Me.mnu_app.Name = "mnu_app"
        Me.mnu_app.Size = New System.Drawing.Size(648, 24)
        Me.mnu_app.TabIndex = 12
        Me.mnu_app.Text = "MenuStrip1"
        '
        'mnu_arx
        '
        Me.mnu_arx.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_arx_save})
        Me.mnu_arx.Name = "mnu_arx"
        Me.mnu_arx.Size = New System.Drawing.Size(60, 20)
        Me.mnu_arx.Text = "Archivo"
        '
        'mnu_arx_save
        '
        Me.mnu_arx_save.Name = "mnu_arx_save"
        Me.mnu_arx_save.Size = New System.Drawing.Size(195, 22)
        Me.mnu_arx_save.Text = "Guardar Configuración"
        '
        'Configuracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 296)
        Me.Controls.Add(Me.chk_pc)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chk_defecto2)
        Me.Controls.Add(Me.chk_defecto1)
        Me.Controls.Add(Me.btn_img2)
        Me.Controls.Add(Me.btn_img1)
        Me.Controls.Add(Me.pic_jug2)
        Me.Controls.Add(Me.pic_jug1)
        Me.Controls.Add(Me.txt_nombre2)
        Me.Controls.Add(Me.txt_nombre1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mnu_app)
        Me.MainMenuStrip = Me.mnu_app
        Me.Name = "Configuracion"
        Me.Text = "Configuracion"
        CType(Me.pic_jug2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_jug1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.mnu_app.ResumeLayout(False)
        Me.mnu_app.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre2 As System.Windows.Forms.TextBox
    Friend WithEvents pic_jug1 As System.Windows.Forms.PictureBox
    Friend WithEvents pic_jug2 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_img1 As System.Windows.Forms.Button
    Friend WithEvents btn_img2 As System.Windows.Forms.Button
    Friend WithEvents ofd_imagen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents chk_defecto1 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_defecto2 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents opt_5x5 As System.Windows.Forms.RadioButton
    Friend WithEvents opt_4x4 As System.Windows.Forms.RadioButton
    Friend WithEvents opt_3x3 As System.Windows.Forms.RadioButton
    Friend WithEvents chk_pc As System.Windows.Forms.CheckBox
    Friend WithEvents mnu_app As System.Windows.Forms.MenuStrip
    Friend WithEvents mnu_arx As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_arx_save As System.Windows.Forms.ToolStripMenuItem
End Class
