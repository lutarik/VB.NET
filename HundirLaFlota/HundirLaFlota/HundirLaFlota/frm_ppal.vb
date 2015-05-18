Imports System.Data.OleDb
Imports System.IO

Public Class frm_ppal

    '*****VARIABLES GLOBALES*****'
    'Barcos en juego
    Dim barcos As Integer = 6

    'Barcos de cada tipo en juego
    Dim tmp_ship() As String = {}
    Public barquitos As List(Of String) = tmp_ship.ToList
    Dim partes As Integer = 12

    'Numero casillas
    Dim col As Integer = 6
    Dim fila As Integer = 5
    Dim casillas As Integer = col * fila

    'Valor aleatorio
    Dim arreu As New Random

    'Numero de disparos
    Dim disparos As Integer = 0

    'Tiempo de juego
    Dim t_usado As TimeSpan
    Dim hora_ini As Date
    Dim hoy As Date = Today
    Dim sg As Integer


    Private Sub frm_ppal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Variables para cargar barco en lista
        Dim i, j As Integer

        'Comprobamos si el numero de casillas es menor que el numero de espacios requeridos
        If casillas < 12 Then
            MsgBox("El número de casillas es inferior a la suma de los tamaños de los barcos. Modifique el valor y vuelva a ejecutar la aplicación.", , "Atención!")
            Me.Close()
        End If

        'Cargamos los barcos en una lista
        For i = 1 To 3
            For j = i To 1 Step -1
                barquitos.Add(i.ToString & j.ToString)
                barquitos.Add((i + 3).ToString & j.ToString)
            Next
        Next
        barquitos.Sort()

    End Sub


    Private Sub salir(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_exit.Click
        Me.Close()
    End Sub

    Private Sub mostrar_solucion(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_solucion.Click
        Dim celda As PictureBox
        mnu_solucion.Enabled = False

        For i As Integer = 0 To casillas - 1
            celda = pnl_tablero.Controls(i)
            If celda.Tag = "M" Then

                celda.image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath)), "resources\mar.jpg"))
            Else
                celda.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath)), "resources\" & celda.Tag & ".png"))

            End If
        Next
    End Sub

    Private Sub nuevo_juego(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_newgame.Click

        'Variables para recorrer tablero
        Dim i, j As Integer
        Dim x, y As Integer
        Dim counter As Integer = 0

        'Variables para calcular el col/alto de cada celda
        Dim celda_col, celda_alto As Double

        'Inicializamos los disparos
        If pnl_tablero.Controls.Count > 0 Then
            pnl_tablero.Controls.Clear()

            For i = 1 To 3
                For j = i To 1 Step -1
                    barquitos.Add(i.ToString & j.ToString)
                    barquitos.Add((i + 3).ToString & j.ToString)
                Next
            Next
            barquitos.Sort()

            disparos = 0
            partes = 12
        End If

        'Guardamos la hora en la que se inició el juego
        hora_ini = Now

        'Mostramos el panel
        If pnl_tablero.Enabled = False Then
            pnl_tablero.Enabled = True
        End If

        celda_col = pnl_tablero.Width / col
        celda_alto = pnl_tablero.Height / fila

        'Generamos el panel
        For i = 0 To col - 1
            For j = 0 To fila - 1
                x = i * celda_col
                y = j * celda_alto
                generator(i, j, x, y, celda_col, celda_alto, counter)
                counter += 1
            Next
        Next

        'Cargamos los barcos
        For i = 0 To 5
            new_ship()
        Next

        MsgBox("A jugar!!")
        mnu_solucion.Enabled = True

    End Sub

    'Generamos los picturebox
    Private Sub generator(ByRef f As Integer, ByRef c As Integer, ByRef x As Integer, ByRef y As Integer, ByVal col As Integer, ByVal alto As Integer, ByVal i As Integer)
        Dim celda As New PictureBox
        With celda
            'Nombre
            .Name = "pic_" & i
            'Posicion y tamaño
            .Location = New Point(x, y)
            .Height = alto
            .Width = col
            'Identificador
            .Tag = "M" 'Por defecto va a ser mar
            'Silueta y ajuste de imagen
            .SizeMode = PictureBoxSizeMode.StretchImage
            .BorderStyle = BorderStyle.FixedSingle
            .Parent = pnl_tablero
            'Añado evento
            AddHandler .Click, AddressOf clic
        End With
    End Sub

    'Generamos los barcos
    Private Sub new_ship()
        'Calculamos posición inicial al azar.
        Dim p_ini As Integer

        'Guardamos tamaño del barco
        Dim tam, tam1, tam2 As Integer
        'Orientacion. Si es = 1 la orientacion es vertical, sino horizontal
        Dim vert As Boolean

        'exito = si en la posicion se puede poner el barco. la inicializamos a 0
        'barco_dispo = si la medida del barco esta disponible
        Dim exito As Boolean
        exito = False

        'Recalcularemos mientras no hayamos tenido "exito" al ver si la posicion del barco esta libre
        Do Until exito
            'Obtenemos la posicion
            p_ini = arreu.Next(casillas - 1)
            'Calculamos el tamaño
            tam = arreu.Next(1, 4)

            'Multiplicamos por 10 y luego sumamos 1 para ver si esta el barco en la lista, y luego le sumamos 30 para ver si el otro tamaño está tambien
            'Ej: tam = 1 (barcos de una casilla). tam = (1*10)+1 = 11
            '    tam2 = tam1+30 = 41, que es el segundo barco de tamaño 1
            tam1 = (tam * 10) + 1
            tam2 = tam1 + 30

            'Obtenemos la orientacion
            vert = arreu.Next(1, 3)

            'Miramos si barquitos contiene tam o tam2 (Ejemplo: 11 o 41, que serian los barcos de tamaño 1)
            If barquitos.Contains(tam1) Then
                exito = comprobar_posicion(p_ini, tam, vert, tam1)
            ElseIf barquitos.Contains(tam2) Then
                exito = comprobar_posicion(p_ini, tam, vert, tam2)
                tam1 = tam2
            Else
                exito = False
            End If
        Loop

        For i As Integer = 0 To tam - 1
            barquitos.Remove(CInt(tam1))
            tam1 += 1
        Next

    End Sub

    'Comprobamos si puede ponerse los barcos
    Private Function comprobar_posicion(ByVal pos As Integer, ByVal tam As Integer, ByVal vert As Boolean, ByVal ship As Integer) As Boolean
        Dim exito As Boolean
        Dim aux, aux1, aux2 As Integer

        aux1 = 1

        If vert Then
            'Si la posicion esta libre
            If pnl_tablero.Controls(pos).Tag.Equals("M") Then
                'Si es de 1 tamaño ponemos el barco y devolvemos
                If tam = 1 Then
                    pnl_tablero.Controls(pos).Tag = CStr(ship)
                    exito = True
                    Return exito
                Else
                    'Comprobamos si la fila mas los espacios del barco excede el numero de filas
                    aux = pos + (fila * (tam - 1))
                    aux2 = (casillas - 1)
                    If aux > aux2 Then
                        exito = False
                        Return exito
                    Else
                        'TODO: Si no exece comprobaremos los espacios que ocupara para ver si estan libres
                        For i As Integer = 1 To tam - 1
                            aux = pos + (fila * (tam - i))
                            'Si hay una M añadiremos uno a aux
                            If pnl_tablero.Controls(aux).Tag.Equals("M") Then
                                aux1 += 1
                            End If
                        Next
                        'Si las tres posiciones estan libres devolvemos true
                        If aux1 = tam Then
                            For i As Integer = tam - 1 To 0 Step -1
                                'MsgBox(pos)
                                pnl_tablero.Controls(pos).Tag = CStr(ship)
                                pos = pos + fila
                                ship = ship + 1
                            Next
                            exito = True
                            Return exito
                        Else
                            exito = False
                            Return exito
                        End If
                    End If
                End If
            Else 'Si la primera posicion no esta libre
                exito = False
                Return exito
            End If

            'Si es en horizontal
        Else

            'Si la posicion esta libre
            If pnl_tablero.Controls(pos).Tag.Equals("M") Then
                'Si es de 1 tamaño devolvemos
                If tam = 1 Then
                    pnl_tablero.Controls(pos).Tag = CStr(ship)
                    exito = True
                    Return exito
                Else
                    'Comprobamos si cabrian en la misma fila
                    aux = (pos + (tam - 1)) Mod col
                    If aux = 0 Then 'En este caso no cabrian
                        exito = False
                        Return exito
                    Else 'Al igual que la vertical aqui comprobaremos si las casillas a ocupar estan libres
                        'TODO: Si no exece comprobaremos los espacios que ocupara para ver si estan libres
                        For i As Integer = 1 To tam - 1
                            aux = pos + (tam - i)
                            'Si hay una M añadiremos uno a aux
                            If pnl_tablero.Controls(aux).Tag.Equals("M") Then
                                aux1 += 1
                            End If
                        Next
                        'Si las tres posiciones estan libres devolvemos true
                        If aux1 = tam Then
                            For i As Integer = tam - 1 To 1 Step -1
                                MsgBox(pos)
                                pnl_tablero.Controls(pos).Tag = CStr(ship)
                                pos = pos + (tam - i)
                                ship = ship + 1
                            Next
                            exito = True
                            Return exito
                        Else
                            exito = False
                            Return exito
                        End If
                    End If
                End If

            Else 'Si la primera posicion no esta libre
                exito = False
                Return exito
            End If
        End If

    End Function


    'Cuando hacemos clic en la casilla
    Private Sub clic(ByVal sender As Object, ByVal e As EventArgs)
        If sender.tag = "M" Then
            sender.image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath)), "resources\mar.jpg"))
        ElseIf sender.tag Then
            sender.image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath)), "resources\" & sender.tag & ".png"))
            partes -= 1
        End If

        disparos += 1

        If partes = 0 Then
            MsgBox("Fin de partida")
            insertar_puntuacion()
            pnl_tablero.Enabled = False
        End If
    End Sub

    '**************MOSTRAMOS FORMULARIOS DE PUNTUACIONES***********************'
    Private Sub mnu_puntuaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_puntuaciones.Click
        frm_puntuaciones.Text = "Mejores puntuaciones"
        frm_puntuaciones.Show()
    End Sub

    Private Sub mnu_puntuacionesXtiempo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_puntuacionesXtiempo.Click
        frm_puntuaciones.Text = "Mejores puntuaciones Por Tiempo"
        frm_puntuaciones.PuntuacionesBindingSource.Sort = "Tiempo DESC, Disparos DESC"
        frm_puntuaciones.Show()
    End Sub

    Private Sub mnu_puntuacionesXtablero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_puntuacionesXtablero.Click
        frm_puntuaciones.Text = "Mejores puntuaciones Por Tablero"
        frm_puntuaciones.PuntuacionesBindingSource.Sort = "Tablero DESC, Disparos DESC"
        frm_puntuaciones.Show()
    End Sub

    Private Sub mnu_puntuacionesDia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_puntuacionesDia.Click
        frm_puntuaciones.Text = "Mejores puntuaciones Del Dia Actual"
        frm_puntuaciones.PuntuacionesBindingSource.Filter = "Fecha = '" & CDate(hoy) & "'"
        frm_puntuaciones.Show()
    End Sub

    'Insertamos puntuaciones
    Private Sub insertar_puntuacion()
        Dim bd As String = Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath)), "resources\Hundirlaflota.mdb")
        Dim nombre As String = InputBox("Introduzca nombre del jugador:", "Nombre", "Jugador 1")
        Dim conexion As OleDbConnection

        conexion = New OleDbConnection

        
        conexion.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & bd

        'Calculamos el tiempo usado para ganar la partida y lo convertimos a segundos
        t_usado = Now.Subtract(hora_ini)
        sg = t_usado.Seconds + (t_usado.Minutes * 60)

        'Insertamos la 
        Dim comando As New OleDbCommand()
        Dim cadena As String = "INSERT INTO Puntuaciones (Nombre, Fecha, Disparos, Tiempo, Tablero) VALUES ('" & nombre & "', #" & hoy & "#, " & disparos & ", " & sg & ", " & casillas & ")"

        comando.CommandText = cadena
        comando.Connection = conexion
        conexion.Open()

        Dim insertada As Integer = comando.ExecuteNonQuery()
        conexion.Close()
        MsgBox("Puntuación guardada")
    End Sub

 

End Class
