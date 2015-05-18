Public Class Calculadora
    'Almacenaremos los valores en las siguientes variables
    Dim op1 As Decimal = 0
    Dim op2 As Decimal = 0
    'Controladores
    Dim controller As Integer = 0
    Dim igual As Integer = 0
    'Almacenamos el operador
    Dim operacion As Char

    ' Añadimos el numero correspondiente al botón que hemos pulsado
    Private Sub add_num(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_9.Click, btn_8.Click, btn_7.Click, btn_6.Click, btn_5.Click, btn_4.Click, btn_3.Click, btn_2.Click, btn_1.Click, btn_0.Click, btn_dec.Click
        pantalla(sender.text)
        lbl_foco.Focus() 'Mandamos el foco a un label invisible para que no se quede resaltado el boton pulsado (como en la de Windows)
    End Sub

    'Recogemos las teclas que se pulsan
    Private Sub Calculadora_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Dim n As Char = e.KeyChar
        'MessageBox.Show(n)
        'Controlo si la tecla pulsada es un numero
        If Char.IsDigit(n) Then
            'txt_result.Text = txt_result.Text + n
            pantalla(n)
        End If
        If n = "," Or n = "." Then
            pantalla(n)
        End If
    End Sub

    ''' <summary>
    ''' Esta funcion nos rellenará la pantalla. Puede resultar un poco sin sentido el tener dos funciones que lo unico que hacen es llamar a esta
    ''' pero creo que es una forma optima de trabajar ya que no tendré que modificar código dos veces
    ''' </summary>
    ''' <param name="numero"> Numero que vamos a pasar a la función para agregar a la pantalla</param>
    ''' <remarks></remarks>
    Private Sub pantalla(ByVal numero As Char)
        If txt_result.Text.Length < 11 Then
            If (txt_result.Text = "0" Or igual = 1) Then 'Si es el primer número que introducimo o si hemos pulsado la tecla igual ya que sino se acumularía con el resultado anterior
                igual = 0
                txt_result.Text = numero
            Else
                txt_result.Text = txt_result.Text + numero
            End If

        End If
    End Sub

    'Borramos la pantalla
    Private Sub borrado(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_vaciar.Click, btn_out1.Click, btn_empty.Click
        
        'Pulsamos C borramos todo lo que haya
        If sender.name = "btn_empty" Then
            txt_result.Text = "0"
            controller = 0
            igual = 1
            op1 = 0
            op2 = 0
        ElseIf sender.name = "btn_out1" Then 'Si pulsamos <- borramos el último digito introducido
            If txt_result.Text.Length > 1 Then
                txt_result.Text = txt_result.Text.Remove(txt_result.Text.Length - 1, 1)
            Else
                txt_result.Text = "0"
            End If
        ElseIf sender.name = "btn_vaciar" Then 'Si pulsamos CE borramos lo que haya en pantalla, pero mantenemos lo que se haya guardado
            txt_result.Text = "0"
        End If


    End Sub


    Private Sub operaciones(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_suma.Click, btn_resta.Click, btn_mult.Click, btn_div.Click, btn_igual.Click, btn_porcentaje.Click, btn_negativo.Click, btn_inversa.Click, btn_factorial.Click, btn_enesima.Click, btn_cubo.Click, btn_cuadrado.Click
        Dim tmp As Decimal
        'Funcion inversa
        If sender.name = "btn_inversa" Then
            op1 = txt_result.Text
            operacion = sender.text
            acumulador("1/x", op1)
            txt_result.Text = op1
            Return
        ElseIf sender.name = "btn_cuadrado" Then
            op1 = txt_result.Text
            tmp = op1 * op1
            txt_result.Text = tmp
            igual = 1
            Return
        ElseIf sender.name = "btn_cubo" Then
            op1 = txt_result.Text
            tmp = op1 * op1 * op1
            txt_result.Text = tmp
            igual = 1
            Return
        ElseIf sender.name = "btn_factorial" Then
            op1 = txt_result.Text
            tmp = 1
            If op1 > 0 Then
                For i = 1 To op1
                    tmp = tmp * i
                Next
            Else
                MessageBox.Show("No se puede hacer un factorial de un número negativo")
            End If
            
            txt_result.Text = tmp
            igual = 1
            Return
        End If
        'Comprobamos si es el primer valor introducido y lo metemos en op1, sino lo meteremos en op2
        If controller = 0 Then 'Primer valor introducido
            op1 = txt_result.Text
            operacion = sender.text
            controller = 1
            txt_result.Text = 0
        ElseIf controller = 1 Then 'Segundo valor introducido
            If sender.name = "btn_negativo" Then
                txt_result.Text = 0 - txt_result.Text
            ElseIf sender.name = "btn_porcentaje" Then
                tmp = (op1 * txt_result.Text) / 100
                txt_result.Text = tmp
            ElseIf sender.name = "btn_cuadrado" Then
                tmp = op1 * op1
                txt_result.Text = tmp
            End If
            op2 = txt_result.Text
            acumulador(operacion, op2)
            operacion = sender.text
            If (sender.name IsNot "btn_porcentaje" And sender.name IsNot "btn_negativo") Then
                txt_result.Text = 0
            End If
        End If

        If sender.name = "btn_igual" Then
            igual = 1
            If controller = 0 Then
                txt_result.Text = op1
            Else
                'acumulador(operacion, op2)
                txt_result.Text = op1
            End If
        End If

    End Sub

    ''' <summary>
    ''' Esta función acumula los operandos que se le envia desde la funcion operaciones
    ''' </summary>
    ''' <param name="oper">El operador</param>
    ''' <param name="num">Segundo número</param>
    ''' <remarks></remarks>
    Private Sub acumulador(ByVal oper As String, ByVal num As Decimal)
        If oper = "+" Then
            op1 = op1 + num
        ElseIf oper = "-" Then
            op1 = op1 - num
        ElseIf oper = "x" Then
            op1 = op1 * num
        ElseIf oper = "/" Then
            If num = 0 Then
                MessageBox.Show("No se puede dividir entre 0!", "Atención")
            Else
                op1 = op1 / num
            End If
        ElseIf oper = "1/x" Then
            op1 = 1 / num
        ElseIf oper = "y" Then
            Dim tmp As Decimal
            tmp = op1
            For i = 1 To num - 1
                tmp = tmp * op1
            Next
            op1 = tmp
            igual = 1
            controller = 0
        End If

    End Sub

    Private Sub calc_estandar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Estandar.Click, MyBase.Load
        If Me.Width <> 308 Then
            Me.Width = 258
        End If
        If Me.Width = 308 Then
            For i = 308 To 258 Step -1
                Me.Width = i
            Next
        End If
        mnu_Estandar.Enabled = False
        If mnu_Cientifica.Enabled = False Then
            mnu_Cientifica.Enabled = True
        End If
    End Sub

    Private Sub calc_cientifica(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Cientifica.Click
        'Me.Width = 308

        For i = 258 To 308
            Me.Width = i
        Next

        mnu_Cientifica.Enabled = False
        If mnu_Estandar.Enabled = False Then
            mnu_Estandar.Enabled = True
        End If
    End Sub

    Private Sub abrir_AcercaDe(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_AcercaDe.Click
        AcercaDe.ShowDialog()
    End Sub

    Private Sub abrir_Ayuda(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Ayuda.Click
        Help.Show()
    End Sub
End Class
