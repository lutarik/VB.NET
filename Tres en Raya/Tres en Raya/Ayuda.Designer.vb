<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ayuda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ayuda))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(372, 183)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(626, 518)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 26.25!)
        Me.Label1.Location = New System.Drawing.Point(366, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ayuda 3 en Raya"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1010, 713)
        Me.ShapeContainer1.TabIndex = 2
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 251
        Me.LineShape1.X2 = 396
        Me.LineShape1.Y1 = 239
        Me.LineShape1.Y2 = 397
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 57)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Seleccion de la ficha con la que queremos jugar siendo una X o un O"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.Label3.Location = New System.Drawing.Point(750, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tablero"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Enabled = False
        Me.RichTextBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.RichTextBox1.Location = New System.Drawing.Point(26, 38)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(297, 88)
        Me.RichTextBox1.TabIndex = 5
        Me.RichTextBox1.Text = "Desde Archivo -> Nuevo juego iniciaremos un nuevo juego, pudiendo elegir los juga" & _
            "dores las fichas con las que quieren jugar. Ganará el que consiga tener tres fic" & _
            "has seguidas"
        '
        'Ayuda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 713)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Ayuda"
        Me.Text = "Ayuda"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
End Class
