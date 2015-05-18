Public Class Parejas
    Dim random As New Random

    Dim temporaryArray() As String = {"!", "!", "N", "N", ",", ",", "k", "k", _
                                      "b", "b", "v", "v", "w", "w", "z", "z"}

    Dim icons As List(Of String) = temporaryArray.ToList

    Dim firstClicked As Label = Nothing
    Dim secondClicked As Label = Nothing


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        AssignIconsToSquares()
    End Sub

    ''' <summary>
    ''' Asigna los iconos a las baldosas
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AssignIconsToSquares()
        'Recorro cada celda en el tablelayout 'contenedor'
        For Each Control In contenedor.Controls
            Dim iconLabel As Label = TryCast(Control, Label)
            If iconLabel IsNot Nothing Then
                'Calculo numero aleatorio teniendo como maximo el num maximo de iconos disponible
                Dim randomNumber As Integer = random.Next(icons.Count)
                'Asignos el icono al label
                iconLabel.Text = icons.ElementAt(randomNumber)
                iconLabel.ForeColor = iconLabel.BackColor
                'Elimino la posición de la lista 'icons'
                icons.RemoveAt(randomNumber)
            End If
        Next
    End Sub

    ''' <summary>
    ''' Controlamos cuando se clica en cada label
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub label_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click, Label8.Click, Label7.Click, Label6.Click, Label5.Click, Label4.Click, Label3.Click, Label2.Click, Label16.Click, Label15.Click, Label14.Click, Label13.Click, Label12.Click, Label11.Click, Label10.Click, Label1.Click

        'Comprobamos si el temporizador está en marcha, si es así salimos
        If (temporizador.Enabled = True) Then
            Return
        End If

        Dim clickedLabel As Label = TryCast(sender, Label)

        If clickedLabel IsNot Nothing Then
            'Controlamos si hemos pulsado en una ficha ya seleccionada
            If (clickedLabel.ForeColor = Color.Black) Then
                Return
            End If

            'Comprobamos si es la primera ficha pulsada, si así cambiamos el color y salimos
            If (firstClicked Is Nothing) Then
                firstClicked = clickedLabel
                firstClicked.ForeColor = Color.Black
                Return
            End If

            'Cambiamos el color de la segunda ficha pulsada
            secondClicked = clickedLabel
            secondClicked.ForeColor = Color.Black

            'Comprobamos el panel
            CheckForWinner()

            'Si coinciden las dos fichas reiniciamos los "clicked"
            If (firstClicked.Text = secondClicked.Text) Then
                firstClicked = Nothing
                secondClicked = Nothing
                Return
            End If

            'Reiniciamos el temporizador
            temporizador.Start()
        End If
    End Sub

    Private Sub temporizador_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles temporizador.Tick

        'Paramos el temporizador
        temporizador.Stop()

        'Ocultamos los iconos haciendolos del mismo color del fondo
        firstClicked.ForeColor = firstClicked.BackColor
        secondClicked.ForeColor = secondClicked.BackColor

        'Reseteamos los 'clicked'
        firstClicked = Nothing
        secondClicked = Nothing

    End Sub

    Private Sub CheckForWinner()

        'Recorre el contenedor buscando si encentra alguna ficha, si la encuentra se sale, sino continua
        For Each control In contenedor.Controls
            Dim iconLabel As Label = TryCast(control, Label)
            If iconLabel IsNot Nothing Then
                If (iconLabel.ForeColor = iconLabel.BackColor) Then
                    Return
                End If
            End If
        Next

        'Muestra mensaje de enhorabuena
        MessageBox.Show("Has conseguido emparejar todas las fichas", "Enhorabuena!")
        Close()

    End Sub
End Class
