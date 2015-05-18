Public Class Prueba_Matematica

    Dim randomizer As New Random

    'variables para asignar el valor a los Text
    Dim addend1, addend2 As Integer
    Dim minuend, subtrahend As Integer
    Dim multiplicand, multiplier As Integer
    Dim dividend, divisor As Integer

    'temporizador
    Dim timeleft As Integer

    ''' <summary>
    ''' Rellena todos los problemas e inicial el temporizador
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub StartTheQuiz()

        'Rellenamos el bloque de la suma.
        addend1 = randomizer.Next(51) 'Ponemos 51 en vez de 50 para que calcule del 0 al 50, sino lo haría del 0 al 49
        addend2 = randomizer.Next(51)
        plusLeftLabel.Text = addend1.ToString
        plusRightLabel.Text = addend2.ToString
        suma.Value = 0

        'Rellenamos el bloque de la resta
        minuend = randomizer.Next(1, 101)
        subtrahend = randomizer.Next(1, minuend)
        minusLeftLabel.Text = minuend.ToString
        minusRightLabel.Text = subtrahend.ToString
        diferencia.Value = 0

        'Rellenamos el bloque de la multiplicacion
        multiplicand = randomizer.Next(2, 11)
        multiplier = randomizer.Next(2, 11)
        timesLeftLabel.Text = multiplicand.ToString
        timesRightLabel.Text = multiplier.ToString
        multiplicacion.Value = 0

        'Rellenamos el bloque de la división
        divisor = randomizer.Next(2, 11)
        Dim temporaryQuotient As Integer = randomizer.Next(2, 11)
        dividend = divisor * temporaryQuotient
        dividedLeftLabel.Text = dividend.ToString
        dividedRightLabel.Text = divisor.ToString
        division.Value = 0

        'Iniciamos el temporizador
        timeleft = 20
        timeLabel.Text = "30 Segundos"
        Timer1.Start()
    End Sub

    ''' <summary>
    ''' Comprobamos los resultados
    ''' </summary>
    ''' <remarks></remarks>
    Public Function CheckTheAnswer()

        'Comprobamos la suma
        If (addend1 + addend2 = suma.Value) AndAlso (minuend - subtrahend = diferencia.Value) AndAlso (multiplicand * multiplier = multiplicacion.Value) AndAlso (dividend / divisor = division.Value) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub startButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startButton.Click
        startButton.Enabled = False
        StartTheQuiz()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If CheckTheAnswer() Then
            Timer1.Stop()
            MessageBox.Show("Las respuestas son correctas", "Enhorabuena!")
            timeLabel.Text = ""
            timeLabel.BackColor = Color.WhiteSmoke
            startButton.Enabled = True
        ElseIf (timeleft > 0) Then
            'actualiza el temporizador
            timeleft = timeleft - 1
            timeLabel.Text = timeleft & " Segundos"
            If timeleft < 6 Then
                timeLabel.BackColor = Color.Red
            End If
        Else
            'si se ha acabado el tiempo paro el temporizador y muestro un mensaje.
            Timer1.Stop()
            timeLabel.Text = "Se acabó el tiempo!"
            MessageBox.Show("No has acabado en el tiempo", "Lo siento!")
            suma.Value = addend1 + addend2
            diferencia.Value = minuend - subtrahend
            multiplicacion.Value = multiplicand * multiplier
            division.Value = dividend / divisor
            timeLabel.BackColor = Color.WhiteSmoke
            startButton.Enabled = True
        End If
    End Sub

    Private Sub answer_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles suma.Enter, multiplicacion.Enter, division.Enter, diferencia.Enter
        Dim answerBox As NumericUpDown = TryCast(sender, NumericUpDown)

        If answerBox IsNot Nothing Then
            Dim lengthOfAnswer As Integer = answerBox.Value.ToString.Length
            answerBox.Select(0, lengthOfAnswer)
        End If
    End Sub
End Class
