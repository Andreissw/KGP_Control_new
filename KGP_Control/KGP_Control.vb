Imports System.Data.OleDb
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports System.Threading

Public Class FailCounter
    Dim SQL As String
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label12.Text = Date.Now.ToString("HH.mm.ss  dd-MM ")     'настройка таймера, показывает настоящее время 
    End Sub
    Private Sub KGP_Control_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCombo(ComboError, "USE FAS SELECT      distinct [ErrorCode]  FROM [FAS].[dbo].[FAS_ErrorCode] order by ErrorCode desc ")
        Number.Text = 1

        If IO.Directory.Exists("C:\Test_Log") Then
        Else
            IO.Directory.CreateDirectory("C:\Test_Log") ' создает папку на диске С, если папки нет 
        End If

        RFID_ID.Focus()
        PassRadio.Checked = True
        InRadio.Checked = True
        check = True
        RFID_ID.Select()
    End Sub

    Dim check, checkVhod As Boolean


    Dim counterCadden, counterCaddenPass, CounterCaddenFail, CounterSputnik, CounterSputnikPass, CounterSputnikFail As Integer
    Dim FormMode As ModeForm = New ModeForm
    Sub MethodMode()
        FormMode.ShowDialog()
        If FormMode.Mode = True Then
            LBMode.Text = "Контроль: Выборочный"
        Else
            LBMode.Text = "Контроль: Сплошной"
        End If
    End Sub

    Private Sub RFID_ID_KeyDown(sender As Object, e As KeyEventArgs) Handles RFID_ID.KeyDown

        If e.KeyCode = Keys.Enter And RFID_ID.Text.Length = 10 Or RFID_ID.Text = "1" Then

            Try
                GetConnect() ' присоединяется к серверу, без нее ничего работать не будет
                If RFID_ID.Text = "" Then
                    MsgBox("Введите пользователя")  'Если нажать кнопку и ничего не будет написано то выйдет сообщение
                Else        'в другом случае если будет не правильно введен логин, выведет другое сообщение
                    conn.Close()
                    GetConnect()

                    SQL = "use FAS SELECT   [UserName]   FROM [FAS].[dbo].[FAS_Users]  where RFID = '" & RFID_ID.Text & "'" 'Достает данные (логин) с базы 
                    NickLabel.Text = SelectString(SQL)  'наодит в базе rfid омер логина и выводит его в лейбле который спрятан
                    conn.Close()
                    GetConnect()
                    SQL = "use FAS SELECT     UserID   FROM [FAS].[dbo].[FAS_Users] where RFID = '" & RFID_ID.Text & "'" 'Достает данные (логин) с базы 
                    UserID = SelectString(SQL)  'наодит в базе rfid омер логина и выводит его в лейбле который спрятан 
                    conn.Close()

                    'МетодРежимаСканирования
                    MethodMode()

                    If NickLabel.Text = "" Then
                        MsgBox("нет в базе")
                        RFID_ID.Text = "" 'стрирается после недуачной попытке строка
                        RFID_ID.Enabled = True
                        RFID_ID.Focus()   'снова фокусируется на текст боксе
                    Else
                        GetUserID() ' получаем userid
                        GetCounterCadden() 'получаем количество добавленных за день  на входе
                        GetCaddenVhod() 'получаем колчество добавленных на выходе PASS
                        GetCaddenVihod() 'получаем колчество добавленных на выходе FAIL

                        GettSputnikCounter()
                        GetSputnikPass()
                        GetSputnikFail()
                        Visible()
                    End If
                End If

            Catch ex As SqlException
                MessageBox.Show(ex.Message) 'в случае исключения программа выводит сообщение
            Finally
                conn.Dispose()         'освобождает неуправляемые ресуры вместе со сборщиком мусора
            End Try
        ElseIf e.KeyCode = Keys.Enter Then
            RFID_ID.Clear()
            RFID_ID.Focus()
        End If

    End Sub

    Private Sub GettSputnikCounter()
        GetConnect()
        SQL = "Select  count(*)    FROM [FAS].[dbo].[KGP_Control_Sputnik]  Where TestByStart = '" & UserID & "' and START_DATE  between  cast(CONVERT(varchar(10), getdate(), 120) as smalldatetime)  and CURRENT_TIMESTAMP" 'Изделиеов на входе
        CounterSputnik = SelectString(SQL)
        conn.Close()
    End Sub

    Private Sub GetSputnikPass()
        GetConnect()
        SQL = "Select  count(*)  FROM [FAS].[dbo].[KGP_Control_Sputnik] Where TestByEnd = '" & UserID & "' and pass = 1 and  END_DATE  between  cast(CONVERT(varchar(10), getdate(), 120) as smalldatetime)  and CURRENT_TIMESTAMP" 'Изделиеов на выходе pass
        CounterSputnikPass = SelectString(SQL)
        conn.Close()
    End Sub

    Private Sub GetSputnikFail()
        GetConnect()
        SQL = "Select  count(*) FROM [FAS].[dbo].[KGP_Control_Sputnik]  Where TestByEnd = '" & UserID & "' and fail = 1  and END_DATE  between  cast(CONVERT(varchar(10), getdate(), 120) as smalldatetime)  and CURRENT_TIMESTAMP" 'Изделиеов на выходе pass
        CounterSputnikFail = SelectString(SQL)
        conn.Close()
    End Sub

    Private Sub GetCaddenVihod()
        GetConnect()
        SQL = "Select  count(*)  From [FAS].[dbo].[KGP_CONTROL_CADEN]  Where TestByEnd = '" & UserID & "' and fail = 1  and END_DATE  between  cast(CONVERT(varchar(10), getdate(), 120) as smalldatetime)  and CURRENT_TIMESTAMP" 'Изделиеов на выходе pass
        CounterCaddenFail = SelectString(SQL)
        conn.Close()
    End Sub

    Private Sub GetCaddenVhod()
        GetConnect()
        SQL = "Select  count(*)  From [FAS].[dbo].[KGP_CONTROL_CADEN]  Where TestByEnd = '" & UserID & "' and pass = 1 and  END_DATE  between  cast(CONVERT(varchar(10), getdate(), 120) as smalldatetime)  and CURRENT_TIMESTAMP" 'Изделиеов на выходе pass
        counterCaddenPass = SelectString(SQL)
        conn.Close()
    End Sub

    Private Sub GetCounterCadden()
        GetConnect()
        SQL = "Select  count(*)  From [FAS].[dbo].[KGP_CONTROL_CADEN]  Where TestByStart = '" & UserID & "' and START_DATE  between  cast(CONVERT(varchar(10), getdate(), 120) as smalldatetime)  and CURRENT_TIMESTAMP" 'Изделиеов на входе
        counterCadden = SelectString(SQL)
        conn.Close()
    End Sub

    Private Sub GetUserID()
        GetConnect()

        SQL = "use FAS SELECT     UserID   FROM [FAS].[dbo].[FAS_Users] where RFID = '" & RFID_ID.Text & "'" 'Достает данные (логин) с базы 
        UserID = SelectString(SQL)
        conn.Close()
    End Sub

    Private Sub Visible()
        Timer1.Enabled = True
        Label1.Visible = False
        GroupBox1.Visible = False
        RFID_ID.Visible = False
        NickLabel.Visible = True
        GroupBox2.Visible = True
        Label2.Visible = True
        SN_IN.Visible = True
        GroupBox5.Visible = True
        BTMode.Visible = True
        LBMode.Visible = True
        Label6.Visible = True
        InRadio.Visible = True
        EndRadio.Visible = True
        GroupBox4.Visible = True

        Label12.Visible = True
        GroupBox6.Visible = True
        Button2.Visible = True
        Button1.Visible = True
        conn.Close()
        SN_IN.Focus()
    End Sub

    Dim SNIn, UserID, SNMID, checkTrid As String
    Dim MyArray As String() = {}
    Dim DefectCode As String

    Sub AQV()

        If SelectString("use SMDCOMPONETS SELECT content  FROM [SMDCOMPONETS].[dbo].[LazerBase]  where content = '" & SN_IN.Text & "'") = "" Then

            If SelectString("use fas SELECT TRID  From [FAS].[dbo].[M_CadenaID] Where TRID = '" & SN_IN.Text & "'") = "" Then

                If SelectString("use fas SELECT [series bar]  From  [FAS].[dbo].[CT_TCC_SN_MAC] Where [series bar] = '" & SN_IN.Text & "'") = "" Then

                    If SelectString("use fas SELECT SN  FROM [FAS].[dbo].[Ct_FASSN_reg]  where SN = '" & SN_IN.Text & "'") = "" Then
                        TextLabel.Visible = True
                        TextLabel.ForeColor = Color.Red
                        TextLabel.Text = "Номер изделия не найден в базе"
                        SN_IN.Clear()
                        SN_IN.Focus()
                        Return
                    End If

                End If
            End If
        End If

        If checkVhod = False Then 'Вход
            If SelectString("use FAS SELECT barcode   FROM [FAS].[dbo].[KGP_Control]  where barcode = '" & SN_IN.Text & "'") <> "" Then
                TextLabel.Visible = True
                TextLabel.ForeColor = Color.Red
                TextLabel.Text = "Номер изделия Был ранее добавлен в базу"
                SN_IN.Clear()
                SN_IN.Focus()
                Return
            End If

            SQL = " USE FAS insert into  [FAS].[dbo].[KGP_Control]  (barcode,pass,fail,DefectCode,[START_DATE],TestByStart,END_DATE,TestByEnd,[Description],ControlMode)  VALUES
                    ('" & SN_IN.Text & "', 1, 0,null ,CURRENT_TIMESTAMP, '" & UserID & "' ,null,null,null,'" & LBMode.Text & "')"
            SelectString(SQL)
            TextLabel.Visible = True
            TextLabel.ForeColor = Color.Green
            TextLabel.Text = "Изделие успешно добавлено"
            SN_IN.Clear()
            SN_IN.Focus()

        ElseIf checkVhod = True Then 'Выход

            If SelectString("use FAS SELECT id  FROM [FAS].[dbo].[KGP_Control]  where barcode = '" & SN_IN.Text & "'") = "" Then
                TextLabel.Visible = True
                TextLabel.ForeColor = Color.Red
                TextLabel.Text = "Номер изделия не был добавлен на входе"
                SN_IN.Clear()
                SN_IN.Focus()
                Return
            End If

            If PassRadio.Checked = True Then 'без дефектов

                SQL = "  USE FAS update [FAS].[dbo].[KGP_Control]  set  [PASS] = 1, [FAIL] = 0, [DefectCode] = null, END_DATE = CURRENT_TIMESTAMP, TestByEnd = '" & UserID & "'  where barcode = '" & SN_IN.Text & "'"
                SelectString(SQL)
                TextLabel.ForeColor = Color.Green
                TextLabel.Text = "Изделие зарегестрировано на выходе"
                TextLabel.Visible = True
                InRadio.Checked = True
                PassRadio.Checked = True
                SN_IN.Clear()
                SN_IN.Focus()

                Return
            End If

            Dim erid As Integer = SelectString("USE FAS SELECT ErrorCodeID FROM [FAS].[dbo].[FAS_ErrorCode] where ErrorCode = '" & ComboError.Text & "'")
            SQL = "  USE FAS update [FAS].[dbo].[KGP_Control]  set [Description] = '" & Description.Text & "', [Pass] = 0, [Fail] = 1,  [DefectCode] = '" & erid & "', END_DATE = CURRENT_TIMESTAMP, TestByEnd = '" & UserID & "'  where barcode = '" & SN_IN.Text & "'"
            SelectString(SQL)
            TextLabel.ForeColor = Color.Green
            TextLabel.Text = "Изделие зарегестрирован на входе, код ошибки - '" & ComboError.Text & "', Изделие - '" & SN_IN.Text & "'"
            TextLabel.Visible = True
            PassRadio.Checked = True
            InRadio.Checked = True
            SN_IN.Clear()
            SN_IN.Focus()

        End If
    End Sub

    Private Sub SN_IN_KeyDown(sender As Object, e As KeyEventArgs) Handles SN_IN.KeyDown

        If e.KeyCode = Keys.Enter Then
            If SN_IN.Text = "" Then
                Return
            End If
            SQL = "USE FAS SELECT FullSTBSN     FROM [FAS].[dbo].[FAS_Start]  where FullSTBSN = '" & SN_IN.Text & "'"

            Dim Result = SelectString(SQL)



            If Result <> "" Then
                SNMID = Mid(SN_IN.Text, 16)
                If checkVhod = False Then 'Изделие на входе

                    If CheckTRIDSNSP(SNMID) <> "" Then 'Проверка в базе KGP
                        TextLabel.Visible = True
                        TextLabel.ForeColor = Color.Red
                        TextLabel.Text = "Номер Изделиеа Был ранее добавлен в базу"
                        Return
                    End If

                    SQL = " USE FAS insert into  [FAS].[dbo].[KGP_Control_Sputnik] (ID,pass,fail,DefectCode,[START_DATE],TestByStart,END_DATE,TestByEnd,[Description],ControlMode)  VALUES
                    ('" & SNMID & "', 1, 0,null ,CURRENT_TIMESTAMP, '" & UserID & "' ,null,null,null,'" & LBMode.Text & "')"
                    SelectString(SQL)
                    TextLabel.ForeColor = Color.Green
                    TextLabel.Text = "Изделие добавлен на вход"
                    TextLabel.Visible = True
                    PassRadio.Checked = True
                    SN_IN.Clear()
                    SN_IN.Focus()

                Else 'Изделие на выходе

                    If CheckTRIDSNSP(SNMID) = "" Then
                        TextLabel.Visible = True
                        TextLabel.ForeColor = Color.Red
                        TextLabel.Text = "Номер Изделиеа не был зарегистрирован на входе"
                        Return
                    End If

                    If PassRadio.Checked = True Then 'Без брака
                        SQL = "  USE FAS update [FAS].[dbo].[KGP_Control_Sputnik]  set  [PASS] = 1, [FAIL] = 0, [DefectCode] = null, END_DATE = CURRENT_TIMESTAMP, TestByEnd = '" & UserID & "'  where id = '" & SNMID & "'"
                        SelectString(SQL)
                        TextLabel.ForeColor = Color.Green
                        TextLabel.Text = "Изделие зарегестрирован на выходе"
                        TextLabel.Visible = True
                        SN_IN.Clear()
                        SN_IN.Focus()
                        InRadio.Checked = True
                        PassRadio.Checked = True
                    Else 'С браком
                        Dim erid As Integer = SelectString("USE FAS SELECT ErrorCodeID FROM [FAS].[dbo].[FAS_ErrorCode] where ErrorCode = '" & ComboError.Text & "'")
                        SQL = "  USE FAS update [FAS].[dbo].[KGP_Control_Sputnik]  set [Description] = '" + Description.Text + "', [Pass] = 0, [Fail] = 1,  [DefectCode] = '" & erid & "', END_DATE = CURRENT_TIMESTAMP, TestByEnd = '" & UserID & "'  where id = '" & SNMID & "'"
                        SelectString(SQL)
                        TextLabel.ForeColor = Color.Green
                        TextLabel.Text = "Изделие зарегестрирован на входе, код ошибки - '" & ComboError.Text & "', Изделие - '" & SN_IN.Text & "'"
                        TextLabel.Visible = True
                        PassRadio.Checked = True
                        InRadio.Checked = True
                        SN_IN.Clear()
                        SN_IN.Focus()
                    End If



                End If
                GetLog()
                Return
            End If
            AQV()

            GetLog()

        End If

#Region "Страый код"
        'If e.KeyCode = Keys.Enter Then

        '    If SN_IN.Text.Length = 14 Then 'Условие на CADEN 

        '        If checkVhod = False Then 'Изделие на входе

        '            'CADENADD() 'добавляем Изделие

        '        ElseIf checkVhod = True Then
        '            CADENADDChange()
        '        End If
        '    ElseIf SN_IN.Text.Length = 23 Then
        '        If checkVhod = False Then 'Изделие на входе
        '            Sputnik()

        '        ElseIf checkVhod = True Then
        '            SputnikADDChange()
        '        End If
        '    End If
        '    'GridLog.Sort(GridLog.Columns(4), System.ComponentModel.ListSortDirection.Descending)



        'ElseIf e.KeyCode = Keys.Enter Then
        '    SN_IN.Clear()
        '    SN_IN.Focus()
        'End If
#End Region

    End Sub

    Private Sub GetLog()
        SQL = "SELECT       [Barcode] as 'Номер'      ,[Pass]       ,[Fail]      ,[DefectCode] as 'КодОшибки'      ,[START_DATE] as 'Дата входа'       ,[END_DATE]   as 'Дата выхода' 
                  ,[Description] as 'Описание', ControlMode 'РежимСканирования'  FROM [FAS].[dbo].[KGP_Control]
                 where START_DATE >= '" & DateTime.Now.ToString("yyyy-MM-dd") & "'  
                 union
SELECT Cast(id as nvarchar(100))      ,[Pass]      ,[Fail]      ,[DefectCode]      ,[START_DATE]       ,[END_DATE]  
      ,[Description], ControlMode   FROM [FAS].[dbo].[KGP_Control_Sputnik]    where START_DATE >= '" & DateTime.Now.ToString("yyyy-MM-dd") & "'"
        LoadGridFromDB(GridLog, SQL)
        GridLog.Sort(GridLog.Columns(4), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub FailRadio_CheckedChanged(sender As Object, e As EventArgs) Handles FailRadio.CheckedChanged
        FAILGROUP.Visible = True
    End Sub

    Private Sub PassRadio_CheckedChanged(sender As Object, e As EventArgs) Handles PassRadio.CheckedChanged
        FAILGROUP.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BTMode.Click
        MethodMode()
    End Sub



    Public Sub Sputnik()
        SNMID = Mid(SN_IN.Text, 16)
        GetConnect()
        SQL = "USE FAS SELECT FullSTBSN     FROM [FAS].[dbo].[FAS_Start]  where FullSTBSN = '" & SN_IN.Text & "'"
        checkTrid = SelectString(SQL) ' проверка в основной базе номера
        checkBase = CheckTRIDSNSP(SNMID) 'проверка в базе KGP
        conn.Close()

        If checkTrid = "" Then
            TextLabel.ForeColor = Color.Red
            TextLabel.Text = "Не найден Изделие в базе"
            TextLabel.Visible = True
            SN_IN.Clear()
            SN_IN.Focus()
            GridLog.BackgroundColor = Color.Red
        ElseIf checkTrid = SN_IN.Text Then ' ЕСЛИ нашел в основной базе номер то выполняет условие 
            If checkBase = SNMID Then 'защита на дубликат
                TextLabel.ForeColor = Color.Red
                TextLabel.Text = "Изделие был добавлен в базе"
                TextLabel.Visible = True
                SN_IN.Clear()
                SN_IN.Focus()
                GridLog.BackgroundColor = Color.Red
            Else
                GetConnect()
                SQL = " USE FAS insert into  [FAS].[dbo].[KGP_Control_Sputnik] (ID,pass,fail,DefectCode,[START_DATE],TestByStart,END_DATE,TestByEnd,[Description],ControlMode)  VALUES
                    ('" & SNMID & "', 1, 0,null ,CURRENT_TIMESTAMP, '" & UserID & "' ,null,null,null,'" & LBMode.Text & "')"
                SelectString(SQL)
                conn.Close()
                TextLabel.ForeColor = Color.Green
                TextLabel.Text = "Изделие добавлен на вход"
                TextLabel.Visible = True
                PassRadio.Checked = True
                SN_IN.Clear()
                SN_IN.Focus()

                Me.GridLog.Rows.Add(checkTrid, 1, "", "", Date.Now, UserID)
                GridLog.BackgroundColor = Color.Green
            End If
        End If


    End Sub
    'Function CADENADD() ' Добавление CADDEN на вход
    '    SNMID = Mid(SN_IN.Text, 8) 'отрезаем номер 
    '    GetConnect()
    '    SQL = "USE FAS SELECT trid  FROM [FAS].[dbo].[M_CadenaID]  where trid = '" & SN_IN.Text & "'"
    '    checkTrid = SelectString(SQL)
    '    checkBase = SelectString(CheckTRIDSN(SNMID))
    '    conn.Close()

    '    If checkTrid = "" Then
    '        TextLabel.ForeColor = Color.Red
    '        TextLabel.Text = "Не найден Изделие в базе"
    '        TextLabel.Visible = True
    '        SN_IN.Clear()
    '        SN_IN.Focus()
    '        GridLog.BackgroundColor = Color.Red
    '        Return False
    '    ElseIf checkTrid = SN_IN.Text Then
    '        If checkBase = SNMID Then
    '            TextLabel.ForeColor = Color.Red
    '            TextLabel.Text = "Изделие был добавлен в базе"
    '            TextLabel.Visible = True
    '            SN_IN.Clear()
    '            SN_IN.Focus()
    '            GridLog.BackgroundColor = Color.Red

    '        Else
    '            GetConnect()
    '            SQL = " USE FAS insert into  [FAS].[dbo].[KGP_CONTROL_CADEN] (ID,pass,fail,DefectCode,[START_DATE],TestByStart,END_DATE,TestByEnd,[Description])  VALUES
    '                ('" & SNMID & "', 1, 0,null ,CURRENT_TIMESTAMP, '" & UserID & "' ,null,null,null)"
    '            SelectString(SQL)
    '            conn.Close()
    '            TextLabel.ForeColor = Color.Green
    '            TextLabel.Text = "Изделие добавлен на вход"
    '            TextLabel.Visible = True
    '            PassRadio.Checked = True
    '            SN_IN.Clear()
    '            SN_IN.Focus()
    '            Me.GridLog.Rows.Add(checkTrid, 1, "", "", Date.Now, UserID)
    '            GridLog.BackgroundColor = Color.Green

    '        End If
    '    End If

    'End Function

    Dim CheckID



    Public Sub SputnikADDChange()
        SNMID = Mid(SN_IN.Text, 16)
        GetConnect()
        SQL = "USE FAS SELECT id   FROM [FAS].[dbo].[KGP_Control_Sputnik] where id = '" & SNMID & "'"
        CheckID = SelectString(SQL)
        conn.Close()
        If CheckID = SNMID Then
            If check = True Then

                GetConnect()
                SQL = "  USE FAS update [FAS].[dbo].[KGP_Control_Sputnik]  set  [PASS] = 1, [FAIL] = 0, [DefectCode] = null, END_DATE = CURRENT_TIMESTAMP, TestByEnd = '" & UserID & "'  where id = '" & SNMID & "'"
                SelectString(SQL)
                TextLabel.ForeColor = Color.Green
                TextLabel.Text = "Изделие зарегестрирован на выходе"
                Me.GridLog.Rows.Add(checkTrid, 1, 0, "", Date.Now, UserID)
                TextLabel.Visible = True
                SN_IN.Clear()
                SN_IN.Focus()
                InRadio.Checked = True
                PassRadio.Checked = True
                GridLog.BackgroundColor = Color.Green

            ElseIf check = False Then 'если С БРАКОМ
                GetConnect()
                SQL = "  USE FAS update [FAS].[dbo].[KGP_Control_Sputnik]  set [Description] = '', [Pass] = 0, [Fail] = 1,  [DefectCode] = '', END_DATE = CURRENT_TIMESTAMP, TestByEnd = '" & UserID & "'  where id = '" & SNMID & "'"
                SelectString(SQL)
                TextLabel.ForeColor = Color.Green
                TextLabel.Text = "Изделие зарегестрирован на входе, код ошибки - '', Изделие - '" & SN_IN.Text & "'"
                TextLabel.Visible = True

                PassRadio.Checked = True
                InRadio.Checked = True
                SN_IN.Clear()
                SN_IN.Focus()


                GridLog.BackgroundColor = Color.LightPink
            End If
        Else
            TextLabel.ForeColor = Color.Red
            TextLabel.Text = "Не найден Изделие на входе"
            TextLabel.Visible = True
            SN_IN.Clear()
            SN_IN.Focus()
            GridLog.BackgroundColor = Color.Red

        End If
    End Sub


    Public Sub CADENADDChange()
        SNMID = Mid(SN_IN.Text, 8)
        GetConnect()
        SQL = "USE FAS SELECT id  FROM [FAS].[dbo].[KGP_CONTROL_CADEN]  where id = '" & SNMID & "'"
        CheckID = SelectString(SQL)
        conn.Close()
        If CheckID = SNMID Then
            If check = True Then

                GetConnect()
                SQL = "  USE FAS update [FAS].[dbo].[KGP_CONTROL_CADEN]  set  [PASS] = 1, [FAIL] = 0, [DefectCode] = null, END_DATE = CURRENT_TIMESTAMP, TestByEnd = '" & UserID & "'  where id = '" & SNMID & "'"
                SelectString(SQL)
                TextLabel.ForeColor = Color.Green
                TextLabel.Text = "Изделие зарегестрирован на выходе"
                Me.GridLog.Rows.Add(checkTrid, 1, 0, "", Date.Now, UserID)
                TextLabel.Visible = True
                SN_IN.Clear()
                SN_IN.Focus()
                InRadio.Checked = True
                PassRadio.Checked = True
                GridLog.BackgroundColor = Color.Green

            ElseIf check = False Then 'если С БРАКОМ
                GetConnect()
                SQL = "  USE FAS update [FAS].[dbo].[KGP_CONTROL_CADEN]  set [Description] = '', [Pass] = 0, [Fail] = 1,  [DefectCode] = '', END_DATE = CURRENT_TIMESTAMP, TestByEnd = '" & UserID & "'  where id = '" & SNMID & "'"
                SelectString(SQL)
                TextLabel.ForeColor = Color.Green
                TextLabel.Text = "Изделие зарегестрирован на входе, код ошибки - '', Изделие - '" & SN_IN.Text & "'"
                TextLabel.Visible = True
                Me.GridLog.Rows.Add(checkTrid, 0, 1, Date.Now, UserID)
                PassRadio.Checked = True
                InRadio.Checked = True
                SN_IN.Clear()
                SN_IN.Focus()


                GridLog.BackgroundColor = Color.LightPink
            End If
        Else
            TextLabel.ForeColor = Color.Red
            TextLabel.Text = "Не найден Изделие на входе"
            TextLabel.Visible = True
            SN_IN.Clear()
            SN_IN.Focus()
            GridLog.BackgroundColor = Color.Red

        End If
    End Sub
    Dim checkBase As String


    Private Sub EndRadio_CheckedChanged(sender As Object, e As EventArgs) Handles EndRadio.CheckedChanged
        checkVhod = True
        GroupBox3.Visible = True
        PassRadio.Visible = True
        FailRadio.Visible = True
        Label3.Visible = True
        SN_IN.Text = ""
        SN_IN.Focus()
        PassRadio.Checked = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = False
        Label1.Visible = True
        GroupBox1.Visible = True
        RFID_ID.Visible = True
        NickLabel.Visible = False
        GroupBox2.Visible = False
        BTMode.Visible = False
        LBMode.Visible = False

        Label2.Visible = False
        SN_IN.Visible = False
        GroupBox5.Visible = False

        Label6.Visible = False
        InRadio.Visible = False
        EndRadio.Visible = False
        GroupBox4.Visible = False

        Label12.Visible = False
        GroupBox6.Visible = False
        Button2.Visible = False
        GroupBox3.Visible = False
        PassRadio.Checked = True
        InRadio.Checked = True
        RFID_ID.Focus()
        labelUserID.Text = ""
        RFID_ID.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim iexit As DialogResult
        iexit = MessageBox.Show("Уверены, что хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question)        'спрашивает у пользователя уверен ли он в своем выборе
        If iexit = DialogResult.No Then
        Else
            Application.Exit()
        End If

    End Sub

    Private Sub InRadio_CheckedChanged(sender As Object, e As EventArgs) Handles InRadio.CheckedChanged
        checkVhod = False
        FAILGROUP.Visible = False
        GroupBox3.Visible = False
        PassRadio.Visible = False
        FailRadio.Visible = False
        Label3.Visible = False
        SN_IN.Focus()
        SN_IN.Text = ""
        PassRadio.Checked = True
    End Sub


End Class
