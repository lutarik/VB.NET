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
        Me.layout_calculadora = New System.Windows.Forms.TableLayoutPanel()
        Me.layout1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_1 = New System.Windows.Forms.Button()
        Me.btn_2 = New System.Windows.Forms.Button()
        Me.btn_3 = New System.Windows.Forms.Button()
        Me.btn_suma = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_4 = New System.Windows.Forms.Button()
        Me.btn_5 = New System.Windows.Forms.Button()
        Me.btn_6 = New System.Windows.Forms.Button()
        Me.btn_resta = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_7 = New System.Windows.Forms.Button()
        Me.btn_8 = New System.Windows.Forms.Button()
        Me.btn_9 = New System.Windows.Forms.Button()
        Me.btn_mult = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_0 = New System.Windows.Forms.Button()
        Me.btn_igual = New System.Windows.Forms.Button()
        Me.btn_div = New System.Windows.Forms.Button()
        Me.txt_display = New System.Windows.Forms.TextBox()
        Me.layout_calculadora.SuspendLayout()
        Me.layout1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'layout_calculadora
        '
        Me.layout_calculadora.AutoSize = True
        Me.layout_calculadora.ColumnCount = 1
        Me.layout_calculadora.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.layout_calculadora.Controls.Add(Me.layout1, 0, 1)
        Me.layout_calculadora.Controls.Add(Me.TableLayoutPanel1, 0, 2)
        Me.layout_calculadora.Controls.Add(Me.TableLayoutPanel2, 0, 3)
        Me.layout_calculadora.Controls.Add(Me.TableLayoutPanel3, 0, 4)
        Me.layout_calculadora.Controls.Add(Me.txt_display, 0, 0)
        Me.layout_calculadora.Dock = System.Windows.Forms.DockStyle.Fill
        Me.layout_calculadora.Location = New System.Drawing.Point(0, 0)
        Me.layout_calculadora.Name = "layout_calculadora"
        Me.layout_calculadora.RowCount = 5
        Me.layout_calculadora.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.layout_calculadora.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.layout_calculadora.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.layout_calculadora.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.layout_calculadora.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.layout_calculadora.Size = New System.Drawing.Size(362, 261)
        Me.layout_calculadora.TabIndex = 0
        '
        'layout1
        '
        Me.layout1.ColumnCount = 4
        Me.layout1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.layout1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.layout1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.layout1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.layout1.Controls.Add(Me.btn_1, 0, 0)
        Me.layout1.Controls.Add(Me.btn_2, 1, 0)
        Me.layout1.Controls.Add(Me.btn_3, 2, 0)
        Me.layout1.Controls.Add(Me.btn_suma, 3, 0)
        Me.layout1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.layout1.Location = New System.Drawing.Point(3, 55)
        Me.layout1.Name = "layout1"
        Me.layout1.RowCount = 1
        Me.layout1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.layout1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.layout1.Size = New System.Drawing.Size(356, 46)
        Me.layout1.TabIndex = 0
        '
        'btn_1
        '
        Me.btn_1.AutoSize = True
        Me.btn_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_1.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_1.Location = New System.Drawing.Point(3, 3)
        Me.btn_1.Name = "btn_1"
        Me.btn_1.Size = New System.Drawing.Size(83, 40)
        Me.btn_1.TabIndex = 0
        Me.btn_1.Text = "1"
        Me.btn_1.UseVisualStyleBackColor = True
        '
        'btn_2
        '
        Me.btn_2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_2.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_2.Location = New System.Drawing.Point(92, 3)
        Me.btn_2.Name = "btn_2"
        Me.btn_2.Size = New System.Drawing.Size(83, 40)
        Me.btn_2.TabIndex = 1
        Me.btn_2.Text = "2"
        Me.btn_2.UseVisualStyleBackColor = True
        '
        'btn_3
        '
        Me.btn_3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_3.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_3.Location = New System.Drawing.Point(181, 3)
        Me.btn_3.Name = "btn_3"
        Me.btn_3.Size = New System.Drawing.Size(83, 40)
        Me.btn_3.TabIndex = 2
        Me.btn_3.Text = "3"
        Me.btn_3.UseVisualStyleBackColor = True
        '
        'btn_suma
        '
        Me.btn_suma.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_suma.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_suma.Location = New System.Drawing.Point(270, 3)
        Me.btn_suma.Name = "btn_suma"
        Me.btn_suma.Size = New System.Drawing.Size(83, 40)
        Me.btn_suma.TabIndex = 3
        Me.btn_suma.Text = "+"
        Me.btn_suma.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_5, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_6, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_resta, 3, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 107)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(356, 46)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'btn_4
        '
        Me.btn_4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_4.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_4.Location = New System.Drawing.Point(3, 3)
        Me.btn_4.Name = "btn_4"
        Me.btn_4.Size = New System.Drawing.Size(83, 40)
        Me.btn_4.TabIndex = 0
        Me.btn_4.Text = "4"
        Me.btn_4.UseVisualStyleBackColor = True
        '
        'btn_5
        '
        Me.btn_5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_5.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_5.Location = New System.Drawing.Point(92, 3)
        Me.btn_5.Name = "btn_5"
        Me.btn_5.Size = New System.Drawing.Size(83, 40)
        Me.btn_5.TabIndex = 1
        Me.btn_5.Text = "5"
        Me.btn_5.UseVisualStyleBackColor = True
        '
        'btn_6
        '
        Me.btn_6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_6.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_6.Location = New System.Drawing.Point(181, 3)
        Me.btn_6.Name = "btn_6"
        Me.btn_6.Size = New System.Drawing.Size(83, 40)
        Me.btn_6.TabIndex = 2
        Me.btn_6.Text = "6"
        Me.btn_6.UseVisualStyleBackColor = True
        '
        'btn_resta
        '
        Me.btn_resta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_resta.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_resta.Location = New System.Drawing.Point(270, 3)
        Me.btn_resta.Name = "btn_resta"
        Me.btn_resta.Size = New System.Drawing.Size(83, 40)
        Me.btn_resta.TabIndex = 3
        Me.btn_resta.Text = "-"
        Me.btn_resta.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btn_7, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_8, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_9, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_mult, 3, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 159)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(356, 46)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'btn_7
        '
        Me.btn_7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_7.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_7.Location = New System.Drawing.Point(3, 3)
        Me.btn_7.Name = "btn_7"
        Me.btn_7.Size = New System.Drawing.Size(83, 40)
        Me.btn_7.TabIndex = 0
        Me.btn_7.Text = "7"
        Me.btn_7.UseVisualStyleBackColor = True
        '
        'btn_8
        '
        Me.btn_8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_8.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_8.Location = New System.Drawing.Point(92, 3)
        Me.btn_8.Name = "btn_8"
        Me.btn_8.Size = New System.Drawing.Size(83, 40)
        Me.btn_8.TabIndex = 1
        Me.btn_8.Text = "8"
        Me.btn_8.UseVisualStyleBackColor = True
        '
        'btn_9
        '
        Me.btn_9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_9.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_9.Location = New System.Drawing.Point(181, 3)
        Me.btn_9.Name = "btn_9"
        Me.btn_9.Size = New System.Drawing.Size(83, 40)
        Me.btn_9.TabIndex = 2
        Me.btn_9.Text = "9"
        Me.btn_9.UseVisualStyleBackColor = True
        '
        'btn_mult
        '
        Me.btn_mult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_mult.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mult.Location = New System.Drawing.Point(270, 3)
        Me.btn_mult.Name = "btn_mult"
        Me.btn_mult.Size = New System.Drawing.Size(83, 40)
        Me.btn_mult.TabIndex = 3
        Me.btn_mult.Text = "*"
        Me.btn_mult.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btn_0, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_igual, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_div, 2, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 211)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(356, 47)
        Me.TableLayoutPanel3.TabIndex = 3
        '
        'btn_0
        '
        Me.btn_0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_0.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_0.Location = New System.Drawing.Point(3, 3)
        Me.btn_0.Name = "btn_0"
        Me.btn_0.Size = New System.Drawing.Size(83, 41)
        Me.btn_0.TabIndex = 0
        Me.btn_0.Text = "0"
        Me.btn_0.UseVisualStyleBackColor = True
        '
        'btn_igual
        '
        Me.btn_igual.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_igual.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_igual.Location = New System.Drawing.Point(92, 3)
        Me.btn_igual.Name = "btn_igual"
        Me.btn_igual.Size = New System.Drawing.Size(172, 41)
        Me.btn_igual.TabIndex = 1
        Me.btn_igual.Text = "="
        Me.btn_igual.UseVisualStyleBackColor = True
        '
        'btn_div
        '
        Me.btn_div.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_div.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_div.Location = New System.Drawing.Point(270, 3)
        Me.btn_div.Name = "btn_div"
        Me.btn_div.Size = New System.Drawing.Size(83, 41)
        Me.btn_div.TabIndex = 2
        Me.btn_div.Text = "/"
        Me.btn_div.UseVisualStyleBackColor = True
        '
        'txt_display
        '
        Me.txt_display.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_display.Font = New System.Drawing.Font("Arial Narrow", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_display.Location = New System.Drawing.Point(3, 3)
        Me.txt_display.Multiline = True
        Me.txt_display.Name = "txt_display"
        Me.txt_display.Size = New System.Drawing.Size(264, 46)
        Me.txt_display.TabIndex = 4
        Me.txt_display.Text = "0"
        Me.txt_display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 261)
        Me.Controls.Add(Me.layout_calculadora)
        Me.KeyPreview = True
        Me.Name = "Calculadora"
        Me.Text = "Caulculin"
        Me.layout_calculadora.ResumeLayout(False)
        Me.layout_calculadora.PerformLayout()
        Me.layout1.ResumeLayout(False)
        Me.layout1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents layout_calculadora As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents layout1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btn_1 As System.Windows.Forms.Button
    Friend WithEvents btn_2 As System.Windows.Forms.Button
    Friend WithEvents btn_3 As System.Windows.Forms.Button
    Friend WithEvents btn_suma As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btn_4 As System.Windows.Forms.Button
    Friend WithEvents btn_5 As System.Windows.Forms.Button
    Friend WithEvents btn_6 As System.Windows.Forms.Button
    Friend WithEvents btn_resta As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btn_7 As System.Windows.Forms.Button
    Friend WithEvents btn_8 As System.Windows.Forms.Button
    Friend WithEvents btn_9 As System.Windows.Forms.Button
    Friend WithEvents btn_mult As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btn_0 As System.Windows.Forms.Button
    Friend WithEvents btn_igual As System.Windows.Forms.Button
    Friend WithEvents btn_div As System.Windows.Forms.Button
    Friend WithEvents txt_display As System.Windows.Forms.TextBox

End Class
