Public Class Principal

    '**********VARIABLES GLOBALES**********'
    Dim arreu As New Random
    'Variable para ver de quien es el turno
    Dim turno As Integer = 0
    'Guardo los aciertos de cada jugador
    Dim j1, j2 As Integer
    'Variable donde guardo la ficha del jugador
    Public fj1, fj2 As Image
    'Variable donde guardo los movimientos, si es 8 es empate
    Dim mov As Integer = 0
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

    ''' <summary>
    ''' Funcion que impide que la misma ficha sea elegida por ambos jugadores
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub quitar_eleccion(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_jugador2.SelectedIndexChanged, cmb_jugador1.SelectedIndexChanged
        'If sender.name = "cmb_jugador1" Then
        '    If cmb_jugador1.SelectedIndex = 0 Then
        '        fj1 = "X"
        '        cmb_jugador2.SelectedIndex = 1
        '        fj2 = "O"
        '    ElseIf cmb_jugador1.SelectedIndex = 1 Then
        '        fj1 = "O"
        '        cmb_jugador2.SelectedIndex = 0
        '        fj2 = "X"
        '    End If
        'ElseIf sender.name = "cmb_jugador2" Then
        '    If cmb_jugador2.SelectedIndex = 0 Then
        '        fj2 = "X"
        '        cmb_jugador1.SelectedIndex = 1
        '        fj1 = "O"
        '    ElseIf cmb_jugador2.SelectedIndex = 1 Then
        '        fj2 = "O"
        '        cmb_jugador1.SelectedIndex = 0
        '        fj1 = "X"
        '    End If
        'End If
    End Sub

    ''' <summary>
    ''' Función que crea un nuevo juego. Desde aqui llamaremos al constructor de las fichas
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub new_game(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_arx_new_game.Click
        Configuracion.ShowDialog()
        cmb_jugador1.SelectedIndex = -1
        cmb_jugador2.SelectedIndex = -1
        If tbl_tablero.Controls.Count > 0 Then
            tbl_tablero.Controls.Clear()
        End If

        For i = 0 To 8
            constructor(i)
        Next
 
        group_jugadores.Visible = True
        turno = arreu.Next(1, 3)
        MsgBox("Empieza el Jugador " & turno)
        j1 = 0
        j2 = 0
    End Sub

    ''' <summary>
    ''' Crea los labels que nos servirán para guardar las fichas
    ''' </summary>
    ''' <param name="i"></param>
    ''' <remarks></remarks>
    Private Sub constructor(ByVal i As Integer)
        Dim cuadrado As New Label

        With cuadrado
            .BorderStyle = BorderStyle.FixedSingle
            .Name = "lbl_" & i.ToString
            .Text = ""
            .Tag = i
            .TextAlign = ContentAlignment.MiddleCenter
            .Font = New System.Drawing.Font("Arial", 80, FontStyle.Bold)
            .Dock = DockStyle.Fill
            If i Mod 2 = 0 Then
                .BackColor = Color.White
            Else
                .BackColor = Color.Black
            End If
            .Parent = tbl_tablero
            AddHandler .Click, AddressOf clic
        End With
    End Sub

    ''' <summary>
    ''' Muestro los las fichas
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub clic(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'If (cmb_jugador1.SelectedIndex = -1) Or (cmb_jugador2.SelectedIndex = -1) Then
        '    MsgBox("Hay que seleccionar ficha")
        '    Exit Sub
        'End If
        If turno = 1 Then
            'Controlo que no haya ya una ficha puesta
            If sender.text.length = 0 Then
                sender.backcolor = Nothing
                sender.image = fj1
                'Cambio de turno para que el siguiente movimiento se lo asocie al otro jugador
                turno = 2
                mov += 1
            Else
                MsgBox("Posición ocupada, por favor seleccione otra.")
            End If
        ElseIf turno = 2 Then
            If sender.text.length = 0 Then
                sender.image = fj2
                sender.backcolor = Nothing
                turno = 1
                mov += 1
            Else
                MsgBox("Posición ocupada, por favor seleccione otra.")
            End If
        End If
        comprobar_combinacion(sender.tag)
    End Sub

    Private Sub comprobar_combinacion(ByVal pos As Integer)
        Dim match As Boolean = False
        Dim i, j, k As Integer

        'Comprobamos combinaciones posibles
        '***VERTICALES***'
        If ((tbl_tablero.Controls(0).Text.Equals(tbl_tablero.Controls(1).Text)) And (tbl_tablero.Controls(1).Text.Equals(tbl_tablero.Controls(2).Text))) _
            And (tbl_tablero.Controls(0).Text.Length > 0) Then
            match = True
            i = 0
            j = 1
            k = 2
        ElseIf ((tbl_tablero.Controls(3).Text.Equals(tbl_tablero.Controls(4).Text)) And (tbl_tablero.Controls(4).Text.Equals(tbl_tablero.Controls(5).Text))) _
            And (tbl_tablero.Controls(3).Text.Length > 0) Then
            match = True
            i = 3
            j = 4
            k = 5
        ElseIf ((tbl_tablero.Controls(6).Text.Equals(tbl_tablero.Controls(7).Text)) And (tbl_tablero.Controls(7).Text.Equals(tbl_tablero.Controls(8).Text))) _
            And (tbl_tablero.Controls(6).Text.Length > 0) Then
            match = True
            i = 6
            j = 7
            k = 8

            '***HORIZONTALES***'
        ElseIf ((tbl_tablero.Controls(0).Text.Equals(tbl_tablero.Controls(3).Text)) And (tbl_tablero.Controls(3).Text.Equals(tbl_tablero.Controls(6).Text))) _
            And (tbl_tablero.Controls(0).Text.Length > 0) Then
            match = True
            i = 0
            j = 3
            k = 6
        ElseIf ((tbl_tablero.Controls(1).Text.Equals(tbl_tablero.Controls(4).Text)) And (tbl_tablero.Controls(4).Text.Equals(tbl_tablero.Controls(7).Text))) _
            And (tbl_tablero.Controls(1).Text.Length > 0) Then
            match = True
            i = 1
            j = 4
            k = 7
        ElseIf ((tbl_tablero.Controls(2).Text.Equals(tbl_tablero.Controls(5).Text)) And (tbl_tablero.Controls(5).Text.Equals(tbl_tablero.Controls(8).Text))) _
            And (tbl_tablero.Controls(2).Text.Length > 0) Then
            match = True
            i = 2
            j = 5
            k = 8

            '***DIAGONALES***'
        ElseIf ((tbl_tablero.Controls(0).Text.Equals(tbl_tablero.Controls(4).Text)) And (tbl_tablero.Controls(4).Text.Equals(tbl_tablero.Controls(8).Text))) _
            And (tbl_tablero.Controls(0).Text.Length > 0) Then
            match = True
            i = 0
            j = 4
            k = 8
        ElseIf ((tbl_tablero.Controls(6).Text.Equals(tbl_tablero.Controls(4).Text)) And (tbl_tablero.Controls(4).Text.Equals(tbl_tablero.Controls(2).Text))) _
            And (tbl_tablero.Controls(6).Text.Length > 0) Then
            match = True
            i = 6
            j = 4
            k = 2
        End If
        'Si hay coincidencia miro que ficha ha ganado
        If match Then
            If tbl_tablero.Controls(i).Text.Equals(fj1) Then
                MsgBox("Partida finalizada. Ha ganado el Jugador 1")
            Else
                MsgBox("Partida finalizada. Ha ganado el Jugador 2")
            End If
            fin_partida(i, j, k)
        ElseIf mov = 8 Then
            MsgBox("No hay más movimientos, se ha producido un empate")
        End If
    End Sub

    Private Sub fin_partida(ByVal i As Integer, ByVal j As Integer, ByVal k As Integer)
        tbl_tablero.Controls(i).BackColor = Color.Pink
        tbl_tablero.Controls(j).BackColor = Color.Pink
        tbl_tablero.Controls(k).BackColor = Color.Pink
        For z = 0 To tbl_tablero.Controls.Count - 1
            tbl_tablero.Controls(z).Enabled = False
        Next
    End Sub
End Class
