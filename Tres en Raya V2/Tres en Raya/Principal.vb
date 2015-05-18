Public Class Principal

    '**********VARIABLES GLOBALES**********'
    Dim arreu As New Random
    'Variable para ver de quien es el turno
    Dim turno As Integer = 0
    'Variable donde guardo la ficha del jugador
    Public fj1, fj2 As PictureBox
    'Variable donde guardo los movimientos, si es 8 es empate
    Dim mov As Integer = 0
    'Variable donde se indica la dimensión del tablero
    Public dimen As Integer
    'Juega PC
    Public pc As Boolean
    'Alguno gana
    Dim gana As Boolean = False
    '**********FIN VARIABLES GLOBALES**********'

    ''' <summary>
    ''' Sale del programa
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub salir(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_arx_exit.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Abre nuevo form para mostrar la ayuda
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub mostrar_ayuda(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_ayuda_help.Click
        Ayuda.Show()
    End Sub


    Private Sub NewGame(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_arx_new_game.Click
        Dim ancho, largo, x, y, counter As Integer
        'Si ya habiamos iniciado una partida vacio el tablero por si cambia la configuración
        pnl_tablero.Enabled = True
        If pnl_tablero.Controls.Count > 0 Then
            'Si ya hemos jugado reiniciamos variables
            pnl_tablero.Controls.Clear()
            gana = False
            mov = 0
        End If
        'Pido datos
        Configuracion.ShowDialog()
        'Calculos varios
        largo = (pnl_tablero.Height / dimen)
        ancho = (pnl_tablero.Width / dimen)
        counter = 1
        'Creacion del tablero
        For i = 0 To dimen - 1 'fila
            For j = 0 To dimen - 1 'columna
                x = (i * largo)
                y = (j * ancho)
                generator(i, j, x, y, ancho, largo, counter)
                counter += 1
            Next
        Next
        'Si da 1 empieza jugador 1, si es 2 el jugador 2
        turno = arreu.Next(1, 3)
        If turno = 1 Then
            MsgBox("Empieza el jugador: " & Configuracion.txt_nombre1.Text)
            Me.Text = "Turno de " & Configuracion.txt_nombre1.Text
        Else
            MsgBox("Empieza el jugador: " & Configuracion.txt_nombre2.Text)
            Me.Text = "Turno de " & Configuracion.txt_nombre2.Text
            If pc Then
                Dim i As Integer = arreu.Next(dimen * dimen)
                clic(pnl_tablero.Controls(i), Nothing)
            End If
        End If
    End Sub

    Private Sub generator(ByRef f As Integer, ByRef c As Integer, ByRef x As Integer, ByRef y As Integer, ByVal ancho As Integer, ByVal largo As Integer, ByVal i As Integer)
        Dim celda As New PictureBox
        With celda
            'Nombre
            .Name = "pic_" & i
            'Posicion y tamaño
            .Location = New Point(x, y)
            .Height = largo
            .Width = ancho
            'Identificador
            .Tag = 0
            'Color fondo
            If (i Mod 2) = 0 Then
                .BackColor = Color.White
            Else
                .BackColor = Color.Black
            End If
            'Silueta y ajuste de imagen
            .SizeMode = PictureBoxSizeMode.StretchImage
            .BorderStyle = BorderStyle.FixedSingle
            .Parent = pnl_tablero
            'Añado evento
            AddHandler .Click, AddressOf clic
        End With


    End Sub

    Private Sub clic(ByVal sender As Object, ByVal e As EventArgs)
        Dim i As Integer
        If sender.tag = 0 Then
            If turno = 1 Then
                sender.image = Configuracion.pic_jug1.Image
                sender.backcolor = Nothing
                sender.tag = 1
                turno = 2
                Me.Text = "Turno de " & Configuracion.txt_nombre2.Text
                'Comprobamos combinaciones lo pongo en los ifs xa q me detecte la victoria xa evitar movimiento pc
                comprobar_juego()
                If pc And (Not gana) Then
                    i = arreu.Next(dimen * dimen)
                    Do While pnl_tablero.Controls(i).Tag > 0
                        i = arreu.Next(dimen * dimen)
                    Loop
                    clic(pnl_tablero.Controls(i), Nothing)
                End If
            ElseIf turno = 2 Then
                sender.image = Configuracion.pic_jug2.Image
                sender.backcolor = Nothing
                turno = 1
                sender.tag = 2
                Me.Text = "Turno de " & Configuracion.txt_nombre1.Text
                'Comprobamos combinaciones
                comprobar_juego()
            End If
        End If
        mov += 1
    End Sub

    Private Sub comprobar_juego()
        'Almaceno las coincidencias de cada jugador o totales pulsadas
        Dim vj1, vj2 As Integer
        Dim a As Integer = 0

        'Comprobamos combinaciones horizontales
        ganar(vj1, vj2)
        If gana Then
            Exit Sub
        End If

        For i = 0 To dimen - 1
            For j = 0 To dimen - 1
                Dim k As Integer = a + j
                If pnl_tablero.Controls(k).Tag = 1 Then
                    vj1 += 1
                ElseIf pnl_tablero.Controls(k).Tag = 2 Then
                    vj2 += 1
                End If
                If gana Then
                    a = 0
                    Exit Sub
                End If
                ganar(vj1, vj2)
            Next
            vj1 = 0
            vj2 = 0
            a = a + dimen
        Next
        vj1 = 0
        vj2 = 0
        'Comprobamos combinaciones verticales
        For i = 0 To dimen - 1
            For j = 0 To dimen - 1
                Dim k As Integer = (i + (dimen * j))
                If pnl_tablero.Controls(k).Tag = 1 Then
                    vj1 += 1
                ElseIf pnl_tablero.Controls(k).Tag = 2 Then
                    vj2 += 1
                End If
                If gana Then
                    Exit Sub
                End If
                ganar(vj1, vj2)
            Next
            vj1 = 0
            vj2 = 0
        Next
        vj1 = 0
        vj2 = 0
        'Comprobamos combinacion diagonal de arriba-izda a abajo-dcha
        For i = 0 To (dimen * dimen) Step dimen + 1
            If pnl_tablero.Controls(i).Tag = 1 Then
                vj1 += 1
            ElseIf pnl_tablero.Controls(i).Tag = 2 Then
                vj2 += 1
            End If
            ganar(vj1, vj2)
        Next
        vj1 = 0
        vj2 = 0
        'Comprobacion diagonal de arriba-dcha a abajo-izda
        For i = (dimen * dimen) - dimen To 1 Step -(dimen - 1)
            If pnl_tablero.Controls(i).Tag = 1 Then
                vj1 += 1
            ElseIf pnl_tablero.Controls(i).Tag = 2 Then
                vj2 += 1
            End If
            ganar(vj1, vj2)
        Next
        vj1 = 0
        vj2 = 0
        If gana Then
            Exit Sub
        End If
        'Comprobamos si hay movimientos disponibles
        'emp = 0
        'For i = 0 To pnl_tablero.Controls.Count - 1
        '    If pnl_tablero.Controls(i).Tag > 0 Then
        '        emp += 1
        '    End If
        '    ganar(vj1, vj2, emp)
        'Next
    End Sub

    Private Sub ganar(ByVal j1, ByVal j2)
        If j1 = dimen Or j2 = dimen Or mov = (dimen * dimen) Then
            gana = True
            If mov = dimen * dimen Then
                MsgBox("Empata")
            Else
                If j1 = dimen Then
                    gana = True
                    MsgBox("Gana el jugador " & Configuracion.txt_nombre1.Text)
                Else
                    gana = True
                    MsgBox("Gana el jugador " & Configuracion.txt_nombre2.Text)
                End If
                pnl_tablero.Enabled = False
            End If
        End If
    End Sub
End Class
