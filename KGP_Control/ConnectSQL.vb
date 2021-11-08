Imports System.Data.SqlClient

Imports System.IO
Module SQLConnectionMOD
    Public conn As SqlConnection
    Public Server As String
    Public DataBase1 As String
    Public UserName As String
    Public Password As String



    Public Function GetConnect() As Boolean
        Try
            conn = New SqlConnection("Data Source= traceability\flat; Initial Catalog= ; User Id = volodin; Password = volodin;")
            conn.Open()
            Return 1
        Catch ex As Exception
            MsgBox("Ошибка подключения к SQL сервер. " & ex.Message)
            Return 0
        End Try
    End Function

    Public Sub LoadCombo(ByVal CB As ComboBox, cmd As String)
        GetConnect()
        Dim c As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim ds As New DataTable

        c = conn.CreateCommand
        c.CommandText = cmd

        da.SelectCommand = c
        da.Fill(ds)

        CB.DataSource = ds
        CB.DisplayMember = ds.Columns(0).ToString
        conn.Close()
    End Sub

    Public Function ExecuteQuery(query As String)
        Dim command As New SqlCommand(query, conn)
        conn.Open()
        command.ExecuteNonQuery()
        conn.Close()

    End Function


    Public Sub LoadGridFromDB(ByVal Grid1 As DataGridView, cmd As String)
        Dim c As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet

        c = conn.CreateCommand
        c.CommandText = cmd

        da.SelectCommand = c
        da.Fill(ds, "Table1")

        Grid1.DataSource = ds
        Grid1.DataMember = "Table1"

    End Sub

    Public Sub RunCommand(cmd As String)
        Dim c As New SqlCommand
        c = conn.CreateCommand
        c.Connection = conn
        c.CommandType = CommandType.Text
        c.CommandText = cmd
        c.ExecuteNonQuery()

    End Sub

    Public ErrorCodesList As String = "use FAS SELECT ID, Category+Code as ErrorCode, [Description] FROM [FAS].[dbo].[M_ErrorCode]"

    Public Function CheckTRIDSN(a As String)
        GetConnect()
        CheckTRIDSN = "USE FAS SELECT id  FROM [FAS].[dbo].[KGP_CONTROL_CADEN]  where id = '" & a & "'"
    End Function

    Public Function CheckTRIDSNSP(a As String)
        Return SelectString("USE FAS SELECT id  FROM [FAS].[dbo].[KGP_Control_Sputnik]  where id = '" & a & "'")
    End Function


    Public Function SelectString(cmd As String) As String
        GetConnect()
        Dim c As New SqlCommand
        Dim r As SqlDataReader
        Dim k As String
        k = ""
        c = conn.CreateCommand
        c.CommandType = CommandType.Text
        c.CommandText = cmd

        r = c.ExecuteReader
        If r.Read Then
            k = r.Item(0)
            r.Close()
        End If
        conn.Close()
        Return k
    End Function

    Public Function SelectFloat(cmd As String) As Double
        Dim c As New SqlCommand
        Dim r As SqlDataReader
        Dim k As Double

        c = conn.CreateCommand
        c.CommandType = CommandType.Text
        c.CommandText = cmd

        r = c.ExecuteReader
        If r.Read Then
            k = r.Item(0)
            r.Close()
        End If

        Return k
    End Function



    Public Function SelectBoolean(cmd As String) As Boolean
        Dim c As New SqlCommand
        Dim r As SqlDataReader
        Dim k As Boolean

        c = conn.CreateCommand
        c.CommandType = CommandType.Text
        c.CommandText = cmd

        r = c.ExecuteReader
        If r.Read Then
            k = r.Item(0)
            r.Close()
        End If

        Return k
    End Function

    Public Function addGridParam(N As String(), Grid As DataGridView)
        'если длинна массива больше чем количество элементов массива то добавляем столбцы
        While (N.Length > Grid.ColumnCount)
            'если колонок нехватает добавляем их пока их будет хватать
            Grid.Columns.Add("", "")
            'пока столбцов не станет нужное количество
        End While
        'создаем новую запись, вносим целиком массив
        Grid.Rows.Add(N)
    End Function





    Sub Main()

        Dim readPath As String = "C:\Users\a.volodin\Desktop\Contract_production\Log.txt"
        Dim writePath As String = "C:\Users\a.volodin\Desktop\Contract_production\Log.txt"
        Dim text As String
        Try

            Using reader As New StreamReader(readPath)
                text = reader.ReadToEnd()
            End Using


            Using writer As New StreamWriter(writePath, False, System.Text.Encoding.UTF8)
                writer.WriteLine(text)
            End Using

            Using writer As New StreamWriter(writePath, True, System.Text.Encoding.UTF8)
                writer.WriteLine("Дозапись")
                writer.Write(4.5)
            End Using

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.ReadLine()
    End Sub



End Module

