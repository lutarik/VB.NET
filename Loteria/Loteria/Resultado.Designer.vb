<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Resultado
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
        Me.pnl_seleccion = New System.Windows.Forms.Panel()
        Me.pnl_combinacion = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tu combinación es:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(372, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "La combinación ganadora es:"
        '
        'pnl_seleccion
        '
        Me.pnl_seleccion.Location = New System.Drawing.Point(18, 87)
        Me.pnl_seleccion.Name = "pnl_seleccion"
        Me.pnl_seleccion.Size = New System.Drawing.Size(350, 50)
        Me.pnl_seleccion.TabIndex = 2
        '
        'pnl_combinacion
        '
        Me.pnl_combinacion.Location = New System.Drawing.Point(18, 224)
        Me.pnl_combinacion.Name = "pnl_combinacion"
        Me.pnl_combinacion.Size = New System.Drawing.Size(350, 50)
        Me.pnl_combinacion.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 303)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(325, 32)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "El número de aciertos es:"
        '
        'btn_salir
        '
        Me.btn_salir.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.Location = New System.Drawing.Point(151, 376)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_salir.TabIndex = 5
        Me.btn_salir.Text = "Cerrar"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'Resultado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 426)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pnl_combinacion)
        Me.Controls.Add(Me.pnl_seleccion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Resultado"
        Me.Text = "Combinaciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnl_seleccion As System.Windows.Forms.Panel
    Friend WithEvents pnl_combinacion As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_salir As System.Windows.Forms.Button
End Class
