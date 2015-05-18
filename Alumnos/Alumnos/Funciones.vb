Module Funciones

    Public Function conexion() As MySqlConnection
        Dim con As MySqlConnection

        Try
            con = New MySqlConnection()
            con.ConnectionString = "Data Source=partnerinformatico.com; Database=SDAM_Testing; User Id=testing;Password=Sd@m2014"

            Return con
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function Do_Select(ByVal campos As String, ByVal tabla As String, ByVal filtro As String, ByVal con As MySqlConnection) As MySqlDataAdapter
        Dim cad_select As String
        Dim contenedor As MySqlDataAdapter

        Try
            cad_select = "SELECT " & campos & " FROM " & tabla
            If filtro.Length > 0 Then
                cad_select = cad_select & " WHERE " & filtro
            End If

            contenedor = New MySqlDataAdapter(cad_select, con)

            Return contenedor

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Function

    Public Sub Do_Delete(ByVal tabla As String, ByVal filtro As String, ByVal con As MySqlConnection)
        Dim cad_delete As String

        Try
            cad_delete = "DELETE * FROM" & tabla & " WHERE " & filtro
            Dim ejecutor As New MySqlCommand
            ejecutor.CommandText = cad_delete
            ejecutor.Connection = con
            con.Open()
            ejecutor.ExecuteReader()

        Catch ex As Exception

        End Try
    End Sub

    Public Sub Do_Update()

    End Sub

    Public Sub Creador_Et(ByVal nombre As String, ByVal texto As String, ByVal posicion As Point)
        Dim etiqueta As New Label

        With etiqueta
            .Name = nombre
            .Text = texto
            .AutoSize = True
            .Location = posicion
            .Parent = Frm_Insert
        End With
    End Sub

    Public Sub Creador_Datos(ByVal nombre As String, ByVal tipo As String, ByVal posicion As Point)
        If tipo = "fecha" Then
            Dim objeto As New DateTimePicker
            With objeto
                .Name = nombre
                .Location = posicion
                .Width = 150
                .Parent = Frm_Insert
            End With
        Else
            Dim objeto As New TextBox
        End If

    End Sub
End Module
