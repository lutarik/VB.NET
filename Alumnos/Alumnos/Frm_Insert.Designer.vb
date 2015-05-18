<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Insert
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
        Me.txt_campo1 = New System.Windows.Forms.TextBox()
        Me.txt_campo2 = New System.Windows.Forms.TextBox()
        Me.txt_campo3 = New System.Windows.Forms.TextBox()
        Me.txt_campo4 = New System.Windows.Forms.TextBox()
        Me.lbl_campo1 = New System.Windows.Forms.Label()
        Me.lbl_campo2 = New System.Windows.Forms.Label()
        Me.lbl_campo3 = New System.Windows.Forms.Label()
        Me.lbl_campo4 = New System.Windows.Forms.Label()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.cmd_action = New System.Windows.Forms.Button()
        Me.cmd_exit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_campo1
        '
        Me.txt_campo1.Location = New System.Drawing.Point(190, 72)
        Me.txt_campo1.Name = "txt_campo1"
        Me.txt_campo1.Size = New System.Drawing.Size(100, 20)
        Me.txt_campo1.TabIndex = 0
        '
        'txt_campo2
        '
        Me.txt_campo2.Location = New System.Drawing.Point(190, 111)
        Me.txt_campo2.Name = "txt_campo2"
        Me.txt_campo2.Size = New System.Drawing.Size(100, 20)
        Me.txt_campo2.TabIndex = 1
        '
        'txt_campo3
        '
        Me.txt_campo3.Location = New System.Drawing.Point(190, 154)
        Me.txt_campo3.Name = "txt_campo3"
        Me.txt_campo3.Size = New System.Drawing.Size(100, 20)
        Me.txt_campo3.TabIndex = 2
        '
        'txt_campo4
        '
        Me.txt_campo4.Location = New System.Drawing.Point(190, 199)
        Me.txt_campo4.Name = "txt_campo4"
        Me.txt_campo4.Size = New System.Drawing.Size(100, 20)
        Me.txt_campo4.TabIndex = 3
        '
        'lbl_campo1
        '
        Me.lbl_campo1.AutoSize = True
        Me.lbl_campo1.Location = New System.Drawing.Point(57, 77)
        Me.lbl_campo1.Name = "lbl_campo1"
        Me.lbl_campo1.Size = New System.Drawing.Size(49, 13)
        Me.lbl_campo1.TabIndex = 4
        Me.lbl_campo1.Text = "Campo 1"
        '
        'lbl_campo2
        '
        Me.lbl_campo2.AutoSize = True
        Me.lbl_campo2.Location = New System.Drawing.Point(57, 118)
        Me.lbl_campo2.Name = "lbl_campo2"
        Me.lbl_campo2.Size = New System.Drawing.Size(49, 13)
        Me.lbl_campo2.TabIndex = 5
        Me.lbl_campo2.Text = "Campo 1"
        '
        'lbl_campo3
        '
        Me.lbl_campo3.AutoSize = True
        Me.lbl_campo3.Location = New System.Drawing.Point(57, 161)
        Me.lbl_campo3.Name = "lbl_campo3"
        Me.lbl_campo3.Size = New System.Drawing.Size(49, 13)
        Me.lbl_campo3.TabIndex = 6
        Me.lbl_campo3.Text = "Campo 1"
        '
        'lbl_campo4
        '
        Me.lbl_campo4.AutoSize = True
        Me.lbl_campo4.Location = New System.Drawing.Point(57, 206)
        Me.lbl_campo4.Name = "lbl_campo4"
        Me.lbl_campo4.Size = New System.Drawing.Size(49, 13)
        Me.lbl_campo4.TabIndex = 7
        Me.lbl_campo4.Text = "Campo 1"
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(28, 9)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(251, 39)
        Me.lbl_titulo.TabIndex = 8
        Me.lbl_titulo.Text = "Añadir / Editar"
        '
        'cmd_action
        '
        Me.cmd_action.Location = New System.Drawing.Point(94, 268)
        Me.cmd_action.Name = "cmd_action"
        Me.cmd_action.Size = New System.Drawing.Size(75, 23)
        Me.cmd_action.TabIndex = 9
        Me.cmd_action.Text = "Insertar"
        Me.cmd_action.UseVisualStyleBackColor = True
        '
        'cmd_exit
        '
        Me.cmd_exit.Location = New System.Drawing.Point(204, 268)
        Me.cmd_exit.Name = "cmd_exit"
        Me.cmd_exit.Size = New System.Drawing.Size(75, 23)
        Me.cmd_exit.TabIndex = 10
        Me.cmd_exit.Text = "Salir"
        Me.cmd_exit.UseVisualStyleBackColor = True
        '
        'Frm_Insert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 310)
        Me.Controls.Add(Me.cmd_exit)
        Me.Controls.Add(Me.cmd_action)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.lbl_campo4)
        Me.Controls.Add(Me.lbl_campo3)
        Me.Controls.Add(Me.lbl_campo2)
        Me.Controls.Add(Me.lbl_campo1)
        Me.Controls.Add(Me.txt_campo4)
        Me.Controls.Add(Me.txt_campo3)
        Me.Controls.Add(Me.txt_campo2)
        Me.Controls.Add(Me.txt_campo1)
        Me.Name = "Frm_Insert"
        Me.Text = "Añadir / Editar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_campo1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_campo2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_campo3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_campo4 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_campo1 As System.Windows.Forms.Label
    Friend WithEvents lbl_campo2 As System.Windows.Forms.Label
    Friend WithEvents lbl_campo3 As System.Windows.Forms.Label
    Friend WithEvents lbl_campo4 As System.Windows.Forms.Label
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents cmd_action As System.Windows.Forms.Button
    Friend WithEvents cmd_exit As System.Windows.Forms.Button
End Class
