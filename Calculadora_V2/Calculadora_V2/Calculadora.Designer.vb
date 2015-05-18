<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculadora
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
        Me.txt_result = New System.Windows.Forms.TextBox()
        Me.btn_vaciar = New System.Windows.Forms.Button()
        Me.btn_1 = New System.Windows.Forms.Button()
        Me.btn_2 = New System.Windows.Forms.Button()
        Me.btn_3 = New System.Windows.Forms.Button()
        Me.btn_4 = New System.Windows.Forms.Button()
        Me.btn_5 = New System.Windows.Forms.Button()
        Me.btn_6 = New System.Windows.Forms.Button()
        Me.btn_7 = New System.Windows.Forms.Button()
        Me.btn_8 = New System.Windows.Forms.Button()
        Me.btn_9 = New System.Windows.Forms.Button()
        Me.btn_0 = New System.Windows.Forms.Button()
        Me.btn_suma = New System.Windows.Forms.Button()
        Me.btn_resta = New System.Windows.Forms.Button()
        Me.btn_mult = New System.Windows.Forms.Button()
        Me.btn_div = New System.Windows.Forms.Button()
        Me.btn_igual = New System.Windows.Forms.Button()
        Me.btn_dec = New System.Windows.Forms.Button()
        Me.btn_empty = New System.Windows.Forms.Button()
        Me.btn_out1 = New System.Windows.Forms.Button()
        Me.btn_negativo = New System.Windows.Forms.Button()
        Me.btn_porcentaje = New System.Windows.Forms.Button()
        Me.btn_inversa = New System.Windows.Forms.Button()
        Me.lbl_foco = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_Estandar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_Cientifica = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_Ayuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_AcercaDe = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_factorial = New System.Windows.Forms.Button()
        Me.btn_enesima = New System.Windows.Forms.Button()
        Me.btn_cubo = New System.Windows.Forms.Button()
        Me.btn_cuadrado = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_result
        '
        Me.txt_result.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_result.Location = New System.Drawing.Point(12, 46)
        Me.txt_result.MaxLength = 255
        Me.txt_result.Multiline = True
        Me.txt_result.Name = "txt_result"
        Me.txt_result.ReadOnly = True
        Me.txt_result.Size = New System.Drawing.Size(224, 30)
        Me.txt_result.TabIndex = 0
        Me.txt_result.Text = "0"
        Me.txt_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_vaciar
        '
        Me.btn_vaciar.AutoSize = True
        Me.btn_vaciar.BackColor = System.Drawing.Color.Red
        Me.btn_vaciar.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_vaciar.Location = New System.Drawing.Point(58, 82)
        Me.btn_vaciar.Name = "btn_vaciar"
        Me.btn_vaciar.Size = New System.Drawing.Size(40, 40)
        Me.btn_vaciar.TabIndex = 1
        Me.btn_vaciar.Text = "CE"
        Me.btn_vaciar.UseVisualStyleBackColor = False
        '
        'btn_1
        '
        Me.btn_1.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_1.Location = New System.Drawing.Point(12, 128)
        Me.btn_1.Name = "btn_1"
        Me.btn_1.Size = New System.Drawing.Size(40, 40)
        Me.btn_1.TabIndex = 2
        Me.btn_1.Text = "1"
        Me.btn_1.UseVisualStyleBackColor = True
        '
        'btn_2
        '
        Me.btn_2.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_2.Location = New System.Drawing.Point(58, 128)
        Me.btn_2.Name = "btn_2"
        Me.btn_2.Size = New System.Drawing.Size(40, 40)
        Me.btn_2.TabIndex = 3
        Me.btn_2.Text = "2"
        Me.btn_2.UseVisualStyleBackColor = True
        '
        'btn_3
        '
        Me.btn_3.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_3.Location = New System.Drawing.Point(104, 128)
        Me.btn_3.Name = "btn_3"
        Me.btn_3.Size = New System.Drawing.Size(40, 40)
        Me.btn_3.TabIndex = 4
        Me.btn_3.Text = "3"
        Me.btn_3.UseVisualStyleBackColor = True
        '
        'btn_4
        '
        Me.btn_4.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_4.Location = New System.Drawing.Point(12, 174)
        Me.btn_4.Name = "btn_4"
        Me.btn_4.Size = New System.Drawing.Size(40, 40)
        Me.btn_4.TabIndex = 5
        Me.btn_4.Text = "4"
        Me.btn_4.UseVisualStyleBackColor = True
        '
        'btn_5
        '
        Me.btn_5.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_5.Location = New System.Drawing.Point(58, 174)
        Me.btn_5.Name = "btn_5"
        Me.btn_5.Size = New System.Drawing.Size(40, 40)
        Me.btn_5.TabIndex = 6
        Me.btn_5.Text = "5"
        Me.btn_5.UseVisualStyleBackColor = True
        '
        'btn_6
        '
        Me.btn_6.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_6.Location = New System.Drawing.Point(104, 174)
        Me.btn_6.Name = "btn_6"
        Me.btn_6.Size = New System.Drawing.Size(40, 40)
        Me.btn_6.TabIndex = 7
        Me.btn_6.Text = "6"
        Me.btn_6.UseVisualStyleBackColor = True
        '
        'btn_7
        '
        Me.btn_7.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_7.Location = New System.Drawing.Point(12, 220)
        Me.btn_7.Name = "btn_7"
        Me.btn_7.Size = New System.Drawing.Size(40, 40)
        Me.btn_7.TabIndex = 8
        Me.btn_7.Text = "7"
        Me.btn_7.UseVisualStyleBackColor = True
        '
        'btn_8
        '
        Me.btn_8.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_8.Location = New System.Drawing.Point(58, 220)
        Me.btn_8.Name = "btn_8"
        Me.btn_8.Size = New System.Drawing.Size(40, 40)
        Me.btn_8.TabIndex = 9
        Me.btn_8.Text = "8"
        Me.btn_8.UseVisualStyleBackColor = True
        '
        'btn_9
        '
        Me.btn_9.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_9.Location = New System.Drawing.Point(104, 220)
        Me.btn_9.Name = "btn_9"
        Me.btn_9.Size = New System.Drawing.Size(40, 40)
        Me.btn_9.TabIndex = 10
        Me.btn_9.Text = "9"
        Me.btn_9.UseVisualStyleBackColor = True
        '
        'btn_0
        '
        Me.btn_0.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_0.Location = New System.Drawing.Point(12, 266)
        Me.btn_0.Name = "btn_0"
        Me.btn_0.Size = New System.Drawing.Size(86, 40)
        Me.btn_0.TabIndex = 11
        Me.btn_0.Text = "0"
        Me.btn_0.UseVisualStyleBackColor = True
        '
        'btn_suma
        '
        Me.btn_suma.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_suma.Location = New System.Drawing.Point(150, 128)
        Me.btn_suma.Name = "btn_suma"
        Me.btn_suma.Size = New System.Drawing.Size(40, 40)
        Me.btn_suma.TabIndex = 12
        Me.btn_suma.Text = "+"
        Me.btn_suma.UseVisualStyleBackColor = True
        '
        'btn_resta
        '
        Me.btn_resta.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_resta.Location = New System.Drawing.Point(150, 174)
        Me.btn_resta.Name = "btn_resta"
        Me.btn_resta.Size = New System.Drawing.Size(40, 40)
        Me.btn_resta.TabIndex = 13
        Me.btn_resta.Text = "-"
        Me.btn_resta.UseVisualStyleBackColor = True
        '
        'btn_mult
        '
        Me.btn_mult.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mult.Location = New System.Drawing.Point(150, 220)
        Me.btn_mult.Name = "btn_mult"
        Me.btn_mult.Size = New System.Drawing.Size(40, 40)
        Me.btn_mult.TabIndex = 14
        Me.btn_mult.Text = "x"
        Me.btn_mult.UseVisualStyleBackColor = True
        '
        'btn_div
        '
        Me.btn_div.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_div.Location = New System.Drawing.Point(150, 266)
        Me.btn_div.Name = "btn_div"
        Me.btn_div.Size = New System.Drawing.Size(40, 40)
        Me.btn_div.TabIndex = 15
        Me.btn_div.Text = "/"
        Me.btn_div.UseVisualStyleBackColor = True
        '
        'btn_igual
        '
        Me.btn_igual.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_igual.Location = New System.Drawing.Point(196, 220)
        Me.btn_igual.Name = "btn_igual"
        Me.btn_igual.Size = New System.Drawing.Size(40, 86)
        Me.btn_igual.TabIndex = 16
        Me.btn_igual.Text = "="
        Me.btn_igual.UseVisualStyleBackColor = True
        '
        'btn_dec
        '
        Me.btn_dec.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dec.Location = New System.Drawing.Point(104, 266)
        Me.btn_dec.Name = "btn_dec"
        Me.btn_dec.Size = New System.Drawing.Size(40, 40)
        Me.btn_dec.TabIndex = 17
        Me.btn_dec.Text = ","
        Me.btn_dec.UseVisualStyleBackColor = True
        '
        'btn_empty
        '
        Me.btn_empty.AutoSize = True
        Me.btn_empty.BackColor = System.Drawing.Color.Red
        Me.btn_empty.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_empty.Location = New System.Drawing.Point(104, 82)
        Me.btn_empty.Name = "btn_empty"
        Me.btn_empty.Size = New System.Drawing.Size(40, 40)
        Me.btn_empty.TabIndex = 18
        Me.btn_empty.Text = "C"
        Me.btn_empty.UseVisualStyleBackColor = False
        '
        'btn_out1
        '
        Me.btn_out1.AutoSize = True
        Me.btn_out1.BackColor = System.Drawing.Color.Red
        Me.btn_out1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_out1.Location = New System.Drawing.Point(12, 82)
        Me.btn_out1.Name = "btn_out1"
        Me.btn_out1.Size = New System.Drawing.Size(40, 40)
        Me.btn_out1.TabIndex = 19
        Me.btn_out1.Text = "<-"
        Me.btn_out1.UseVisualStyleBackColor = False
        '
        'btn_negativo
        '
        Me.btn_negativo.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_negativo.Location = New System.Drawing.Point(150, 82)
        Me.btn_negativo.Name = "btn_negativo"
        Me.btn_negativo.Size = New System.Drawing.Size(40, 40)
        Me.btn_negativo.TabIndex = 20
        Me.btn_negativo.Text = "(-)"
        Me.btn_negativo.UseVisualStyleBackColor = True
        '
        'btn_porcentaje
        '
        Me.btn_porcentaje.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_porcentaje.Location = New System.Drawing.Point(196, 128)
        Me.btn_porcentaje.Name = "btn_porcentaje"
        Me.btn_porcentaje.Size = New System.Drawing.Size(40, 40)
        Me.btn_porcentaje.TabIndex = 21
        Me.btn_porcentaje.Text = "%"
        Me.btn_porcentaje.UseVisualStyleBackColor = True
        '
        'btn_inversa
        '
        Me.btn_inversa.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_inversa.Location = New System.Drawing.Point(196, 174)
        Me.btn_inversa.Name = "btn_inversa"
        Me.btn_inversa.Size = New System.Drawing.Size(40, 40)
        Me.btn_inversa.TabIndex = 22
        Me.btn_inversa.Text = "1/x"
        Me.btn_inversa.UseVisualStyleBackColor = True
        '
        'lbl_foco
        '
        Me.lbl_foco.AutoSize = True
        Me.lbl_foco.Location = New System.Drawing.Point(0, 0)
        Me.lbl_foco.Name = "lbl_foco"
        Me.lbl_foco.Size = New System.Drawing.Size(0, 13)
        Me.lbl_foco.TabIndex = 24
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(318, 24)
        Me.MenuStrip1.TabIndex = 25
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_Estandar, Me.mnu_Cientifica})
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(36, 20)
        Me.VerToolStripMenuItem.Text = "Ver"
        '
        'mnu_Estandar
        '
        Me.mnu_Estandar.Name = "mnu_Estandar"
        Me.mnu_Estandar.Size = New System.Drawing.Size(124, 22)
        Me.mnu_Estandar.Text = "Estándar"
        '
        'mnu_Cientifica
        '
        Me.mnu_Cientifica.Name = "mnu_Cientifica"
        Me.mnu_Cientifica.Size = New System.Drawing.Size(124, 22)
        Me.mnu_Cientifica.Text = "Científica"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_Ayuda, Me.mnu_AcercaDe})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'mnu_Ayuda
        '
        Me.mnu_Ayuda.Name = "mnu_Ayuda"
        Me.mnu_Ayuda.Size = New System.Drawing.Size(152, 22)
        Me.mnu_Ayuda.Text = "Ver Ayuda"
        '
        'mnu_AcercaDe
        '
        Me.mnu_AcercaDe.Name = "mnu_AcercaDe"
        Me.mnu_AcercaDe.Size = New System.Drawing.Size(152, 22)
        Me.mnu_AcercaDe.Text = "Acerca de..."
        '
        'btn_factorial
        '
        Me.btn_factorial.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_factorial.Location = New System.Drawing.Point(253, 266)
        Me.btn_factorial.Name = "btn_factorial"
        Me.btn_factorial.Size = New System.Drawing.Size(40, 40)
        Me.btn_factorial.TabIndex = 29
        Me.btn_factorial.Text = "n!"
        Me.btn_factorial.UseVisualStyleBackColor = True
        '
        'btn_enesima
        '
        Me.btn_enesima.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_enesima.Location = New System.Drawing.Point(253, 220)
        Me.btn_enesima.Name = "btn_enesima"
        Me.btn_enesima.Size = New System.Drawing.Size(40, 40)
        Me.btn_enesima.TabIndex = 28
        Me.btn_enesima.Text = "y^x"
        Me.btn_enesima.UseVisualStyleBackColor = True
        '
        'btn_cubo
        '
        Me.btn_cubo.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cubo.Location = New System.Drawing.Point(253, 174)
        Me.btn_cubo.Name = "btn_cubo"
        Me.btn_cubo.Size = New System.Drawing.Size(40, 40)
        Me.btn_cubo.TabIndex = 27
        Me.btn_cubo.Text = "x^3"
        Me.btn_cubo.UseVisualStyleBackColor = True
        '
        'btn_cuadrado
        '
        Me.btn_cuadrado.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cuadrado.Location = New System.Drawing.Point(253, 128)
        Me.btn_cuadrado.Name = "btn_cuadrado"
        Me.btn_cuadrado.Size = New System.Drawing.Size(40, 40)
        Me.btn_cuadrado.TabIndex = 26
        Me.btn_cuadrado.Text = "x^2"
        Me.btn_cuadrado.UseVisualStyleBackColor = True
        '
        'Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 321)
        Me.Controls.Add(Me.btn_factorial)
        Me.Controls.Add(Me.btn_enesima)
        Me.Controls.Add(Me.btn_cubo)
        Me.Controls.Add(Me.btn_cuadrado)
        Me.Controls.Add(Me.lbl_foco)
        Me.Controls.Add(Me.btn_inversa)
        Me.Controls.Add(Me.btn_porcentaje)
        Me.Controls.Add(Me.btn_negativo)
        Me.Controls.Add(Me.btn_out1)
        Me.Controls.Add(Me.btn_empty)
        Me.Controls.Add(Me.btn_dec)
        Me.Controls.Add(Me.btn_igual)
        Me.Controls.Add(Me.btn_div)
        Me.Controls.Add(Me.btn_mult)
        Me.Controls.Add(Me.btn_resta)
        Me.Controls.Add(Me.btn_suma)
        Me.Controls.Add(Me.btn_0)
        Me.Controls.Add(Me.btn_9)
        Me.Controls.Add(Me.btn_8)
        Me.Controls.Add(Me.btn_7)
        Me.Controls.Add(Me.btn_6)
        Me.Controls.Add(Me.btn_5)
        Me.Controls.Add(Me.btn_4)
        Me.Controls.Add(Me.btn_3)
        Me.Controls.Add(Me.btn_2)
        Me.Controls.Add(Me.btn_1)
        Me.Controls.Add(Me.btn_vaciar)
        Me.Controls.Add(Me.txt_result)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Calculadora"
        Me.Text = "Calculadora"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_result As System.Windows.Forms.TextBox
    Friend WithEvents btn_vaciar As System.Windows.Forms.Button
    Friend WithEvents btn_1 As System.Windows.Forms.Button
    Friend WithEvents btn_2 As System.Windows.Forms.Button
    Friend WithEvents btn_3 As System.Windows.Forms.Button
    Friend WithEvents btn_4 As System.Windows.Forms.Button
    Friend WithEvents btn_5 As System.Windows.Forms.Button
    Friend WithEvents btn_6 As System.Windows.Forms.Button
    Friend WithEvents btn_7 As System.Windows.Forms.Button
    Friend WithEvents btn_8 As System.Windows.Forms.Button
    Friend WithEvents btn_9 As System.Windows.Forms.Button
    Friend WithEvents btn_0 As System.Windows.Forms.Button
    Friend WithEvents btn_suma As System.Windows.Forms.Button
    Friend WithEvents btn_resta As System.Windows.Forms.Button
    Friend WithEvents btn_mult As System.Windows.Forms.Button
    Friend WithEvents btn_div As System.Windows.Forms.Button
    Friend WithEvents btn_igual As System.Windows.Forms.Button
    Friend WithEvents btn_dec As System.Windows.Forms.Button
    Friend WithEvents btn_empty As System.Windows.Forms.Button
    Friend WithEvents btn_out1 As System.Windows.Forms.Button
    Friend WithEvents btn_negativo As System.Windows.Forms.Button
    Friend WithEvents btn_porcentaje As System.Windows.Forms.Button
    Friend WithEvents btn_inversa As System.Windows.Forms.Button
    Friend WithEvents lbl_foco As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents VerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_Estandar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_Cientifica As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_Ayuda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_AcercaDe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_factorial As System.Windows.Forms.Button
    Friend WithEvents btn_enesima As System.Windows.Forms.Button
    Friend WithEvents btn_cubo As System.Windows.Forms.Button
    Friend WithEvents btn_cuadrado As System.Windows.Forms.Button

End Class
