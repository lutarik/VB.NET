<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BtnConsultaDesc = New System.Windows.Forms.Button()
        Me.btnConsulta = New System.Windows.Forms.Button()
        Me.ListaAlumnos = New System.Windows.Forms.ListBox()
        Me.BtnConsultaEsc = New System.Windows.Forms.Button()
        Me.BtnInsercion = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnConsultaDesc
        '
        Me.BtnConsultaDesc.Location = New System.Drawing.Point(9, 291)
        Me.BtnConsultaDesc.Name = "BtnConsultaDesc"
        Me.BtnConsultaDesc.Size = New System.Drawing.Size(91, 43)
        Me.BtnConsultaDesc.TabIndex = 10
        Me.BtnConsultaDesc.Text = "Consulta Desconectado"
        Me.BtnConsultaDesc.UseVisualStyleBackColor = True
        '
        'btnConsulta
        '
        Me.btnConsulta.Location = New System.Drawing.Point(9, 221)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(91, 46)
        Me.btnConsulta.TabIndex = 9
        Me.btnConsulta.Text = "Consulta"
        Me.btnConsulta.UseVisualStyleBackColor = True
        '
        'ListaAlumnos
        '
        Me.ListaAlumnos.FormattingEnabled = True
        Me.ListaAlumnos.Location = New System.Drawing.Point(132, 200)
        Me.ListaAlumnos.Name = "ListaAlumnos"
        Me.ListaAlumnos.Size = New System.Drawing.Size(143, 134)
        Me.ListaAlumnos.TabIndex = 8
        '
        'BtnConsultaEsc
        '
        Me.BtnConsultaEsc.Location = New System.Drawing.Point(9, 155)
        Me.BtnConsultaEsc.Name = "BtnConsultaEsc"
        Me.BtnConsultaEsc.Size = New System.Drawing.Size(91, 43)
        Me.BtnConsultaEsc.TabIndex = 7
        Me.BtnConsultaEsc.Text = "ConsultaEscalar"
        Me.BtnConsultaEsc.UseVisualStyleBackColor = True
        '
        'BtnInsercion
        '
        Me.BtnInsercion.Location = New System.Drawing.Point(9, 86)
        Me.BtnInsercion.Name = "BtnInsercion"
        Me.BtnInsercion.Size = New System.Drawing.Size(92, 45)
        Me.BtnInsercion.TabIndex = 5
        Me.BtnInsercion.Text = "Insercion"
        Me.BtnInsercion.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 45)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Conexion"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 348)
        Me.Controls.Add(Me.BtnConsultaDesc)
        Me.Controls.Add(Me.btnConsulta)
        Me.Controls.Add(Me.ListaAlumnos)
        Me.Controls.Add(Me.BtnConsultaEsc)
        Me.Controls.Add(Me.BtnInsercion)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnConsultaDesc As System.Windows.Forms.Button
    Friend WithEvents btnConsulta As System.Windows.Forms.Button
    Friend WithEvents ListaAlumnos As System.Windows.Forms.ListBox
    Friend WithEvents BtnConsultaEsc As System.Windows.Forms.Button
    Friend WithEvents BtnInsercion As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
