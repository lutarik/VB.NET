<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loteria
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
        Me.pnl_chk = New System.Windows.Forms.Panel()
        Me.divisor = New System.Windows.Forms.SplitContainer()
        Me.txt_reintegro = New System.Windows.Forms.TextBox()
        Me.lbl_reintegro = New System.Windows.Forms.Label()
        Me.btn_check = New System.Windows.Forms.Button()
        Me.btn_auto = New System.Windows.Forms.Button()
        Me.btn_manual = New System.Windows.Forms.Button()
        Me.btn_borrar = New System.Windows.Forms.Button()
        Me.pnl_chk.SuspendLayout()
        CType(Me.divisor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.divisor.Panel1.SuspendLayout()
        Me.divisor.Panel2.SuspendLayout()
        Me.divisor.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_chk
        '
        Me.pnl_chk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnl_chk.Controls.Add(Me.divisor)
        Me.pnl_chk.Location = New System.Drawing.Point(200, 116)
        Me.pnl_chk.Name = "pnl_chk"
        Me.pnl_chk.Size = New System.Drawing.Size(358, 271)
        Me.pnl_chk.TabIndex = 0
        '
        'divisor
        '
        Me.divisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.divisor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.divisor.Location = New System.Drawing.Point(0, 0)
        Me.divisor.Name = "divisor"
        Me.divisor.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'divisor.Panel1
        '
        Me.divisor.Panel1.Controls.Add(Me.txt_reintegro)
        Me.divisor.Panel1.Controls.Add(Me.lbl_reintegro)
        '
        'divisor.Panel2
        '
        Me.divisor.Panel2.Controls.Add(Me.btn_check)
        Me.divisor.Panel2.Controls.Add(Me.btn_auto)
        Me.divisor.Panel2.Controls.Add(Me.btn_manual)
        Me.divisor.Panel2.Controls.Add(Me.btn_borrar)
        Me.divisor.Size = New System.Drawing.Size(354, 267)
        Me.divisor.SplitterDistance = 231
        Me.divisor.TabIndex = 0
        '
        'txt_reintegro
        '
        Me.txt_reintegro.Enabled = False
        Me.txt_reintegro.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_reintegro.Location = New System.Drawing.Point(196, 203)
        Me.txt_reintegro.Name = "txt_reintegro"
        Me.txt_reintegro.Size = New System.Drawing.Size(53, 25)
        Me.txt_reintegro.TabIndex = 1
        Me.txt_reintegro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_reintegro
        '
        Me.lbl_reintegro.AutoSize = True
        Me.lbl_reintegro.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_reintegro.Location = New System.Drawing.Point(111, 206)
        Me.lbl_reintegro.Name = "lbl_reintegro"
        Me.lbl_reintegro.Size = New System.Drawing.Size(83, 18)
        Me.lbl_reintegro.TabIndex = 0
        Me.lbl_reintegro.Text = "Reintegro:"
        '
        'btn_check
        '
        Me.btn_check.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_check.Location = New System.Drawing.Point(254, 4)
        Me.btn_check.Name = "btn_check"
        Me.btn_check.Size = New System.Drawing.Size(95, 23)
        Me.btn_check.TabIndex = 3
        Me.btn_check.Text = "Comprobar"
        Me.btn_check.UseVisualStyleBackColor = True
        '
        'btn_auto
        '
        Me.btn_auto.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_auto.Location = New System.Drawing.Point(151, 4)
        Me.btn_auto.Name = "btn_auto"
        Me.btn_auto.Size = New System.Drawing.Size(104, 23)
        Me.btn_auto.TabIndex = 2
        Me.btn_auto.Text = "Automático"
        Me.btn_auto.UseVisualStyleBackColor = True
        '
        'btn_manual
        '
        Me.btn_manual.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_manual.Location = New System.Drawing.Point(77, 4)
        Me.btn_manual.Name = "btn_manual"
        Me.btn_manual.Size = New System.Drawing.Size(75, 23)
        Me.btn_manual.TabIndex = 1
        Me.btn_manual.Text = "Manual"
        Me.btn_manual.UseVisualStyleBackColor = True
        '
        'btn_borrar
        '
        Me.btn_borrar.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_borrar.Location = New System.Drawing.Point(3, 4)
        Me.btn_borrar.Name = "btn_borrar"
        Me.btn_borrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_borrar.TabIndex = 0
        Me.btn_borrar.Text = "Borrar"
        Me.btn_borrar.UseVisualStyleBackColor = True
        '
        'Loteria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 549)
        Me.Controls.Add(Me.pnl_chk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Loteria"
        Me.Text = "Simulador Lotero"
        Me.pnl_chk.ResumeLayout(False)
        Me.divisor.Panel1.ResumeLayout(False)
        Me.divisor.Panel1.PerformLayout()
        Me.divisor.Panel2.ResumeLayout(False)
        CType(Me.divisor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.divisor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_chk As System.Windows.Forms.Panel
    Friend WithEvents divisor As System.Windows.Forms.SplitContainer
    Friend WithEvents txt_reintegro As System.Windows.Forms.TextBox
    Friend WithEvents lbl_reintegro As System.Windows.Forms.Label
    Friend WithEvents btn_borrar As System.Windows.Forms.Button
    Friend WithEvents btn_check As System.Windows.Forms.Button
    Friend WithEvents btn_auto As System.Windows.Forms.Button
    Friend WithEvents btn_manual As System.Windows.Forms.Button

End Class
