Public Class Laberinto

    'Modificacion Tutorial 2 Opcion 1
    Dim startSoundPlayer = New System.Media.SoundPlayer("C:\Windows\Media\notify.wav")
    Dim finishSoundPlayer = New System.Media.SoundPlayer("C:\Windows\Media\Ring01.wav")

    'Dim startSoundPlayer = New System.Media.SoundPlayer("C:\Windows\Media\chord.wav")
    'Dim finishSoundPlayer = New System.Media.SoundPlayer("C:\Windows\Media\tada.wav")

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        MoveToStart()
    End Sub


    Private Sub lbl_finish_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_finish.MouseEnter

        'Mensaje de felicitación y cerramos el programa
        finishSoundPlayer.Play()
        MessageBox.Show("Enhorabuena! Has llegado a la meta", "Fin", MessageBoxButtons.OK)
        'Haciendo Tutorial 2 Opcion 3
        MoveToStart()
        'Si descomentamos la linea se cierra el programa. Tutorial original
        'Close()
    End Sub

    ''' <summary>
    ''' Mueve el cursor al principio del laberinto.
    ''' Reproduce un sonido
    ''' </summary>
    ''' <remarks></remarks>

    Private Sub MoveToStart()
        'Modificacion Tutorial 2 Opcion 2
        'startSoundPlayer.play()
        Dim startingPoint = pnl_laberinto.Location
        startingPoint.Offset(10, 10)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub wall_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.MouseEnter, Label9.MouseEnter, Label8.MouseEnter, Label74.MouseEnter, Label73.MouseEnter, Label72.MouseEnter, Label70.MouseEnter, Label7.MouseEnter, Label69.MouseEnter, Label68.MouseEnter, Label67.MouseEnter, Label66.MouseEnter, Label65.MouseEnter, Label64.MouseEnter, Label63.MouseEnter, Label62.MouseEnter, Label61.MouseEnter, Label60.MouseEnter, Label6.MouseEnter, Label59.MouseEnter, Label58.MouseEnter, Label57.MouseEnter, Label56.MouseEnter, Label55.MouseEnter, Label54.MouseEnter, Label53.MouseEnter, Label52.MouseEnter, Label51.MouseEnter, Label50.MouseEnter, Label5.MouseEnter, Label49.MouseEnter, Label48.MouseEnter, Label47.MouseEnter, Label46.MouseEnter, Label45.MouseEnter, Label44.MouseEnter, Label43.MouseEnter, Label42.MouseEnter, Label41.MouseEnter, Label40.MouseEnter, Label4.MouseEnter, Label39.MouseEnter, Label38.MouseEnter, Label37.MouseEnter, Label36.MouseEnter, Label35.MouseEnter, Label34.MouseEnter, Label33.MouseEnter, Label32.MouseEnter, Label31.MouseEnter, Label30.MouseEnter, Label3.MouseEnter, Label29.MouseEnter, Label28.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label2.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter, pnl_laberinto.MouseEnter
        'Cuando el cursos golpea contra uno de los muros vuelve al principio.
        'Modificacion Tutorial 2 Opcion 4

        Dim CrashRed = New System.Media.SoundPlayer("C:\Windows\Media\ir_begin.wav")
        Dim CrashYellow = New System.Media.SoundPlayer("C:\Windows\Media\ir_end.wav")
        Dim CrashBlue = New System.Media.SoundPlayer("C:\Windows\Media\ir_inter.wav")

        If sender.BackColor = Color.Crimson Then
            CrashRed.Play()
        ElseIf sender.BackColor = Color.Yellow Then
            CrashYellow.Play()
        ElseIf sender.BackColor = Color.RoyalBlue Then
            CrashBlue.Play()
        End If

        MoveToStart()
    End Sub

End Class
