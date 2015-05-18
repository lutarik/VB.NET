<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Plataformas
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
        Me.barra = New System.Windows.Forms.Label()
        Me.tmr_creador = New System.Windows.Forms.Timer(Me.components)
        Me.btn_start = New System.Windows.Forms.Button()
        Me.tmr_caida = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_score = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'barra
        '
        Me.barra.BackColor = System.Drawing.Color.DarkOrange
        Me.barra.Location = New System.Drawing.Point(139, 287)
        Me.barra.Name = "barra"
        Me.barra.Size = New System.Drawing.Size(50, 15)
        Me.barra.TabIndex = 0
        '
        'tmr_creador
        '
        Me.tmr_creador.Interval = 1500
        '
        'btn_start
        '
        Me.btn_start.Location = New System.Drawing.Point(122, 124)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(75, 23)
        Me.btn_start.TabIndex = 1
        Me.btn_start.Text = "Start!"
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'tmr_caida
        '
        Me.tmr_caida.Interval = 500
        '
        'lbl_score
        '
        Me.lbl_score.AutoSize = True
        Me.lbl_score.Location = New System.Drawing.Point(93, 158)
        Me.lbl_score.Name = "lbl_score"
        Me.lbl_score.Size = New System.Drawing.Size(67, 13)
        Me.lbl_score.TabIndex = 2
        Me.lbl_score.Text = "Puntuación: "
        '
        'Plataformas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 311)
        Me.Controls.Add(Me.lbl_score)
        Me.Controls.Add(Me.btn_start)
        Me.Controls.Add(Me.barra)
        Me.Name = "Plataformas"
        Me.Text = "Juego Plataformas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents barra As System.Windows.Forms.Label
    Friend WithEvents tmr_creador As System.Windows.Forms.Timer
    Friend WithEvents btn_start As System.Windows.Forms.Button
    Friend WithEvents tmr_caida As System.Windows.Forms.Timer
    Friend WithEvents lbl_score As System.Windows.Forms.Label

End Class
