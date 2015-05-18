Public Class Plataformas
    '********VARIABLES*******

    Dim randomize As New Random

    'Guardo los nombre de los bloques
    Dim str_bloque() As String = {}
    Dim bloques As List(Of String) = str_bloque.ToList

    'Almaceno los labels creados
    Dim str_labels() As Label = {}
    Dim labels As List(Of Label) = str_labels.ToList

    'Almaceno los colores
    Dim colores() As Color = {Color.GreenYellow, Color.Black, Color.Blue, Color.Yellow, Color.Crimson, Color.Green, Color.Brown, Color.DarkOliveGreen, Color.Gold}
    Dim colorin As List(Of Color) = colores.ToList()

    'Indica los bloques que podemos crear
    Dim repeticiones As Integer = 0
    'Guardo la puntuación
    Dim score As Integer = 0

    'Almaceno las posiciones de los bloques
    Dim pos_x() As Integer = {}
    Dim posiciones As List(Of Integer) = pos_x.ToList()

    '********FIN VARIABLES*******

    ''' <summary>
    ''' Al cargar el formulario situo la barra en medio del formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Plataformas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        barra.Left = (Me.Width / 2) - (barra.Width / 2)
        Carga_Posiciones()
    End Sub


    ''' <summary>
    ''' Cargo las posiciones en función a los huecos que haya
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Carga_Posiciones()
        Dim i As Integer = 1
        Dim n As Integer = 1
        posiciones.Clear()
        bloques.Clear()
        While i < Me.Width - 55
            posiciones.Add(i)
            bloques.Add("Bloque" + n.ToString)
            i = i + 55
            n += 1
            repeticiones += 1
        End While
    End Sub

    ''' <summary>
    ''' La barra se mueve con el raton
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub movimiento(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        'Si la posición del raton es una en la que la barra se sale fuera del formulario me quedo en el borde
        If ((barra.Width + e.X) > Me.Width) Then
            barra.Left = e.X - barra.Width
        Else 'Si no continuo
            barra.Left = e.X
        End If
    End Sub

    ''' <summary>
    ''' Cada vez que se modifica el tamaño situo la barra en la parte inferior y recargo las posiciones
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Plataformas_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged
        barra.Top = Me.Height - 60
        Carga_Posiciones()
    End Sub

    ''' <summary>
    ''' Creo los bloques
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub creator()
        Dim bloque As New Label
        Dim x As Integer
        Dim i As Integer

        x = randomize.Next(posiciones.Count)

        'Atributos de los bloques
        With bloque
            'Nombre del bloque
            .Name = bloques.ElementAt(x)
            .Tag = bloques.ElementAt(x)
            'Tamaño
            .Size = barra.Size
            'Ubicación
            Dim pos As Integer = posiciones.ElementAt(x)
            .Location = New Point(pos, 20)
            'Obtengo un color aleatorio
            i = randomize.Next(colorin.Count)
            .BackColor = colorin.ElementAt(i)
            'Le inidico donde lo tiene que colocar
            .Parent = Me
        End With
        'Añado el label al array labels
        labels.Add(bloque)
        'Quito la posición y el nombre
        posiciones.RemoveAt(x)
        bloques.RemoveAt(x)
    End Sub

    ''' <summary>
    ''' Generamos los bloques
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub panel_gen(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_creador.Tick
        'Mientras hayan posiciones por poner voy creando
        If (posiciones.Count > 0) Then
            Call creator()
        Else
        End If
    End Sub

    ''' <summary>
    ''' Al pulsar el boton se enciende o apaga el boton
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub start(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_start.Click
        'Pongo los timers en marcha y cambio Start! por Stop
        If btn_start.Text = "Start!" Then
            tmr_creador.Enabled = True
            tmr_caida.Enabled = True
            btn_start.Text = "Stop"
            'Paro los timers y cambio Stop por Start!
        Else
            tmr_creador.Enabled = False
            tmr_caida.Enabled = True
            btn_start.Text = "Start!"
        End If

    End Sub

    ''' <summary>
    ''' Los bloques van cayendo
    ''' </summary>
    Private Sub caida(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_caida.Tick
        For i = 1 To labels.Count
            Dim x, y As Integer
            'Nuevas posiciones. La X es la misma, pero así luego ocupa menos espacio en la linea
            x = labels(i - 1).Location.X
            y = labels(i - 1).Location.Y + barra.Height
            labels(i - 1).Location = New Point(x, y)
            'Si goal devuelve un valor positivo significa que o he llegado al final o lo he recogido, por eso lo borro de Controls y de labels (array de obejetos)
            If goal(labels(i - 1).Location, labels(i - 1).Name) Then
                Controls.Remove(labels(i - 1))
                labels.RemoveAt(i - 1)
                'Le meto un Exit For xq sino "peta" al variar los indices
                Exit For
            End If
        Next
        lbl_score.Text = "Puntuación: " + score.ToString
    End Sub

    ''' <summary>
    ''' Comprueba si lo recogemos o cae al fondo
    ''' </summary>
    ''' <param name="pos_bloque">La posicion actual del bloque</param>
    ''' <param name="nom_bloque">Nombre del bloque</param>
    ''' <remarks></remarks>
    Private Function goal(ByVal pos_bloque As Point, ByVal nom_bloque As String) As Boolean
        'Si cae al fondo
        If pos_bloque.Y >= Me.Height Then
            posiciones.Add(pos_bloque.X)
            bloques.Add(nom_bloque)
            Return True
            'Si lo recojo
        ElseIf pos_bloque = barra.Location Then
            posiciones.Add(pos_bloque.X)
            bloques.Add(nom_bloque)
            score += 10
            Return True
            'Si no pasa nada
        Else
            Return False
        End If
    End Function
End Class
