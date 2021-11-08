<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FailCounter
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FailCounter))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RFID_ID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NickLabel = New System.Windows.Forms.Label()
        Me.labelUserID = New System.Windows.Forms.Label()
        Me.SN_IN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.FailRadio = New System.Windows.Forms.RadioButton()
        Me.PassRadio = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Add_Click = New System.Windows.Forms.Button()
        Me.TestBox1 = New System.Windows.Forms.TextBox()
        Me.GridCheck = New System.Windows.Forms.DataGridView()
        Me.LOTID = New System.Windows.Forms.Label()
        Me.ManufSNShrt = New System.Windows.Forms.Label()
        Me.UnitID = New System.Windows.Forms.Label()
        Me.PassTB = New System.Windows.Forms.TextBox()
        Me.FailTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.InRadio = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.EndRadio = New System.Windows.Forms.RadioButton()
        Me.GridSerial = New System.Windows.Forms.DataGridView()
        Me.LabelDefectCode = New System.Windows.Forms.Label()
        Me.Line = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CountGridPass = New System.Windows.Forms.DataGridView()
        Me.CountGridFail = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.IDUser = New System.Windows.Forms.Label()
        Me.InGrid = New System.Windows.Forms.DataGridView()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GridLog = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Number = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextLabel = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.FAILGROUP = New System.Windows.Forms.GroupBox()
        Me.Description = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboError = New System.Windows.Forms.ComboBox()
        Me.BTMode = New System.Windows.Forms.Button()
        Me.LBMode = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GridCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.GridSerial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CountGridPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CountGridFail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.GridLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.FAILGROUP.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RFID_ID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(413, 90)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Вход"
        '
        'RFID_ID
        '
        Me.RFID_ID.Location = New System.Drawing.Point(216, 40)
        Me.RFID_ID.Name = "RFID_ID"
        Me.RFID_ID.Size = New System.Drawing.Size(182, 22)
        Me.RFID_ID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Пользователь"
        '
        'NickLabel
        '
        Me.NickLabel.AutoSize = True
        Me.NickLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.NickLabel.Location = New System.Drawing.Point(145, 19)
        Me.NickLabel.Name = "NickLabel"
        Me.NickLabel.Size = New System.Drawing.Size(68, 29)
        Me.NickLabel.TabIndex = 1
        Me.NickLabel.Text = "User"
        Me.NickLabel.Visible = False
        '
        'labelUserID
        '
        Me.labelUserID.AutoSize = True
        Me.labelUserID.Location = New System.Drawing.Point(1599, 9)
        Me.labelUserID.Name = "labelUserID"
        Me.labelUserID.Size = New System.Drawing.Size(40, 13)
        Me.labelUserID.TabIndex = 1
        Me.labelUserID.Text = "UserID"
        Me.labelUserID.Visible = False
        '
        'SN_IN
        '
        Me.SN_IN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SN_IN.Location = New System.Drawing.Point(139, 25)
        Me.SN_IN.Name = "SN_IN"
        Me.SN_IN.Size = New System.Drawing.Size(435, 21)
        Me.SN_IN.TabIndex = 2
        Me.SN_IN.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 31)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Ввод SN"
        Me.Label2.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SN_IN)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 167)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(582, 64)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ввод"
        Me.GroupBox2.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.FailRadio)
        Me.GroupBox3.Controls.Add(Me.PassRadio)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox3.Location = New System.Drawing.Point(600, 167)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(259, 92)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Result"
        Me.GroupBox3.Visible = False
        '
        'FailRadio
        '
        Me.FailRadio.AutoSize = True
        Me.FailRadio.BackColor = System.Drawing.Color.Transparent
        Me.FailRadio.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.FailRadio.FlatAppearance.BorderSize = 7
        Me.FailRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FailRadio.Location = New System.Drawing.Point(190, 36)
        Me.FailRadio.Name = "FailRadio"
        Me.FailRadio.Size = New System.Drawing.Size(58, 28)
        Me.FailRadio.TabIndex = 1
        Me.FailRadio.TabStop = True
        Me.FailRadio.Text = "Fail"
        Me.FailRadio.UseVisualStyleBackColor = False
        Me.FailRadio.Visible = False
        '
        'PassRadio
        '
        Me.PassRadio.AutoSize = True
        Me.PassRadio.BackColor = System.Drawing.Color.Transparent
        Me.PassRadio.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.PassRadio.FlatAppearance.BorderSize = 7
        Me.PassRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.PassRadio.Location = New System.Drawing.Point(116, 36)
        Me.PassRadio.Name = "PassRadio"
        Me.PassRadio.Size = New System.Drawing.Size(68, 28)
        Me.PassRadio.TabIndex = 1
        Me.PassRadio.TabStop = True
        Me.PassRadio.Text = "Pass"
        Me.PassRadio.UseVisualStyleBackColor = False
        Me.PassRadio.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Result_Test"
        Me.Label3.Visible = False
        '
        'Add_Click
        '
        Me.Add_Click.Location = New System.Drawing.Point(1656, 30)
        Me.Add_Click.Name = "Add_Click"
        Me.Add_Click.Size = New System.Drawing.Size(136, 23)
        Me.Add_Click.TabIndex = 5
        Me.Add_Click.Text = "Кнопка добавления"
        Me.Add_Click.UseVisualStyleBackColor = True
        Me.Add_Click.Visible = False
        '
        'TestBox1
        '
        Me.TestBox1.Location = New System.Drawing.Point(1624, 63)
        Me.TestBox1.Multiline = True
        Me.TestBox1.Name = "TestBox1"
        Me.TestBox1.Size = New System.Drawing.Size(168, 114)
        Me.TestBox1.TabIndex = 6
        Me.TestBox1.Visible = False
        '
        'GridCheck
        '
        Me.GridCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridCheck.Location = New System.Drawing.Point(1624, 183)
        Me.GridCheck.Name = "GridCheck"
        Me.GridCheck.Size = New System.Drawing.Size(168, 76)
        Me.GridCheck.TabIndex = 7
        Me.GridCheck.Visible = False
        '
        'LOTID
        '
        Me.LOTID.AutoSize = True
        Me.LOTID.Location = New System.Drawing.Point(1709, 488)
        Me.LOTID.Name = "LOTID"
        Me.LOTID.Size = New System.Drawing.Size(39, 13)
        Me.LOTID.TabIndex = 8
        Me.LOTID.Text = "LOTID"
        Me.LOTID.Visible = False
        '
        'ManufSNShrt
        '
        Me.ManufSNShrt.AutoSize = True
        Me.ManufSNShrt.Location = New System.Drawing.Point(1709, 501)
        Me.ManufSNShrt.Name = "ManufSNShrt"
        Me.ManufSNShrt.Size = New System.Drawing.Size(71, 13)
        Me.ManufSNShrt.TabIndex = 8
        Me.ManufSNShrt.Text = "ManufSNShrt"
        Me.ManufSNShrt.Visible = False
        '
        'UnitID
        '
        Me.UnitID.AutoSize = True
        Me.UnitID.Location = New System.Drawing.Point(1711, 514)
        Me.UnitID.Name = "UnitID"
        Me.UnitID.Size = New System.Drawing.Size(37, 13)
        Me.UnitID.TabIndex = 8
        Me.UnitID.Text = "UnitID"
        Me.UnitID.Visible = False
        '
        'PassTB
        '
        Me.PassTB.Location = New System.Drawing.Point(1728, 528)
        Me.PassTB.Name = "PassTB"
        Me.PassTB.Size = New System.Drawing.Size(37, 20)
        Me.PassTB.TabIndex = 9
        Me.PassTB.Visible = False
        '
        'FailTB
        '
        Me.FailTB.Location = New System.Drawing.Point(1728, 554)
        Me.FailTB.Name = "FailTB"
        Me.FailTB.Size = New System.Drawing.Size(37, 20)
        Me.FailTB.TabIndex = 9
        Me.FailTB.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1707, 541)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Pass"
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1692, 554)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Fail"
        Me.Label5.Visible = False
        '
        'InRadio
        '
        Me.InRadio.AutoSize = True
        Me.InRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.InRadio.Location = New System.Drawing.Point(90, 18)
        Me.InRadio.Name = "InRadio"
        Me.InRadio.Size = New System.Drawing.Size(160, 20)
        Me.InRadio.TabIndex = 11
        Me.InRadio.TabStop = True
        Me.InRadio.Text = "Изделие на входе"
        Me.InRadio.UseVisualStyleBackColor = True
        Me.InRadio.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.EndRadio)
        Me.GroupBox4.Controls.Add(Me.InRadio)
        Me.GroupBox4.Location = New System.Drawing.Point(592, 108)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(621, 53)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Статус"
        Me.Label6.Visible = False
        '
        'EndRadio
        '
        Me.EndRadio.AutoSize = True
        Me.EndRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.EndRadio.Location = New System.Drawing.Point(265, 18)
        Me.EndRadio.Name = "EndRadio"
        Me.EndRadio.Size = New System.Drawing.Size(170, 20)
        Me.EndRadio.TabIndex = 11
        Me.EndRadio.TabStop = True
        Me.EndRadio.Text = "Изделие на выходе"
        Me.EndRadio.UseVisualStyleBackColor = True
        Me.EndRadio.Visible = False
        '
        'GridSerial
        '
        Me.GridSerial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridSerial.Location = New System.Drawing.Point(1624, 384)
        Me.GridSerial.Name = "GridSerial"
        Me.GridSerial.Size = New System.Drawing.Size(171, 27)
        Me.GridSerial.TabIndex = 7
        Me.GridSerial.Visible = False
        '
        'LabelDefectCode
        '
        Me.LabelDefectCode.AutoSize = True
        Me.LabelDefectCode.Location = New System.Drawing.Point(1660, 11)
        Me.LabelDefectCode.Name = "LabelDefectCode"
        Me.LabelDefectCode.Size = New System.Drawing.Size(85, 13)
        Me.LabelDefectCode.TabIndex = 82
        Me.LabelDefectCode.Text = "LabelErrorCodes"
        Me.LabelDefectCode.Visible = False
        '
        'Line
        '
        Me.Line.AutoSize = True
        Me.Line.Location = New System.Drawing.Point(1711, 475)
        Me.Line.Name = "Line"
        Me.Line.Size = New System.Drawing.Size(27, 13)
        Me.Line.TabIndex = 8
        Me.Line.Text = "Line"
        Me.Line.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DataGridView1)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 9)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(574, 152)
        Me.GroupBox5.TabIndex = 83
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 18)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(273, 117)
        Me.DataGridView1.TabIndex = 0
        '
        'CountGridPass
        '
        Me.CountGridPass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CountGridPass.Location = New System.Drawing.Point(1624, 342)
        Me.CountGridPass.Name = "CountGridPass"
        Me.CountGridPass.Size = New System.Drawing.Size(168, 15)
        Me.CountGridPass.TabIndex = 84
        Me.CountGridPass.Visible = False
        '
        'CountGridFail
        '
        Me.CountGridFail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CountGridFail.Location = New System.Drawing.Point(1624, 363)
        Me.CountGridFail.Name = "CountGridFail"
        Me.CountGridFail.Size = New System.Drawing.Size(168, 15)
        Me.CountGridFail.TabIndex = 84
        Me.CountGridFail.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label12.Location = New System.Drawing.Point(635, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 34)
        Me.Label12.TabIndex = 85
        '
        'Timer1
        '
        '
        'IDUser
        '
        Me.IDUser.AutoSize = True
        Me.IDUser.Location = New System.Drawing.Point(1685, 439)
        Me.IDUser.Name = "IDUser"
        Me.IDUser.Size = New System.Drawing.Size(27, 13)
        Me.IDUser.TabIndex = 8
        Me.IDUser.Text = "Line"
        Me.IDUser.Visible = False
        '
        'InGrid
        '
        Me.InGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InGrid.Location = New System.Drawing.Point(1624, 318)
        Me.InGrid.Name = "InGrid"
        Me.InGrid.Size = New System.Drawing.Size(171, 18)
        Me.InGrid.TabIndex = 86
        Me.InGrid.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.GridLog)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 301)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1203, 383)
        Me.GroupBox6.TabIndex = 88
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Log"
        Me.GroupBox6.Visible = False
        '
        'GridLog
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GridLog.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GridLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.GridLog.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridLog.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GridLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridLog.DefaultCellStyle = DataGridViewCellStyle3
        Me.GridLog.Location = New System.Drawing.Point(12, 19)
        Me.GridLog.Name = "GridLog"
        Me.GridLog.Size = New System.Drawing.Size(1184, 373)
        Me.GridLog.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(1125, 690)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 35)
        Me.Button1.TabIndex = 89
        Me.Button1.Text = "Выход"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button2.Location = New System.Drawing.Point(871, 690)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(248, 35)
        Me.Button2.TabIndex = 89
        Me.Button2.Text = "Выход из учетной записи"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Number
        '
        Me.Number.AutoSize = True
        Me.Number.Location = New System.Drawing.Point(1364, 33)
        Me.Number.Name = "Number"
        Me.Number.Size = New System.Drawing.Size(0, 13)
        Me.Number.TabIndex = 90
        Me.Number.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1490, 199)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 91
        Me.TextBox1.Visible = False
        '
        'TextLabel
        '
        Me.TextLabel.AutoSize = True
        Me.TextLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextLabel.Location = New System.Drawing.Point(9, 271)
        Me.TextLabel.Name = "TextLabel"
        Me.TextLabel.Size = New System.Drawing.Size(68, 16)
        Me.TextLabel.TabIndex = 93
        Me.TextLabel.Text = "TextLabel"
        Me.TextLabel.Visible = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label10)
        Me.GroupBox8.Controls.Add(Me.NickLabel)
        Me.GroupBox8.Location = New System.Drawing.Point(592, 13)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(543, 79)
        Me.GroupBox8.TabIndex = 12
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(133, 20)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Пользователь"
        Me.Label10.Visible = False
        '
        'FAILGROUP
        '
        Me.FAILGROUP.BackColor = System.Drawing.Color.Gainsboro
        Me.FAILGROUP.Controls.Add(Me.Description)
        Me.FAILGROUP.Controls.Add(Me.Label7)
        Me.FAILGROUP.Controls.Add(Me.Label8)
        Me.FAILGROUP.Controls.Add(Me.ComboError)
        Me.FAILGROUP.Location = New System.Drawing.Point(865, 167)
        Me.FAILGROUP.Name = "FAILGROUP"
        Me.FAILGROUP.Size = New System.Drawing.Size(350, 120)
        Me.FAILGROUP.TabIndex = 94
        Me.FAILGROUP.TabStop = False
        Me.FAILGROUP.Visible = False
        '
        'Description
        '
        Me.Description.Location = New System.Drawing.Point(132, 24)
        Me.Description.MaxLength = 1200
        Me.Description.Multiline = True
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(216, 90)
        Me.Description.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!)
        Me.Label7.Location = New System.Drawing.Point(128, 2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 19)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Описание"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!)
        Me.Label8.Location = New System.Drawing.Point(3, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 19)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Код Ошибки"
        '
        'ComboError
        '
        Me.ComboError.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboError.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboError.FormattingEnabled = True
        Me.ComboError.Location = New System.Drawing.Point(7, 25)
        Me.ComboError.Name = "ComboError"
        Me.ComboError.Size = New System.Drawing.Size(121, 24)
        Me.ComboError.TabIndex = 0
        '
        'BTMode
        '
        Me.BTMode.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.BTMode.Location = New System.Drawing.Point(870, 25)
        Me.BTMode.Name = "BTMode"
        Me.BTMode.Size = New System.Drawing.Size(249, 32)
        Me.BTMode.TabIndex = 95
        Me.BTMode.Text = "Поменять режим сканирования"
        Me.BTMode.UseVisualStyleBackColor = False
        Me.BTMode.Visible = False
        '
        'LBMode
        '
        Me.LBMode.AutoSize = True
        Me.LBMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LBMode.Location = New System.Drawing.Point(873, 64)
        Me.LBMode.Name = "LBMode"
        Me.LBMode.Size = New System.Drawing.Size(87, 20)
        Me.LBMode.TabIndex = 96
        Me.LBMode.Text = "Контроль:"
        Me.LBMode.Visible = False
        '
        'FailCounter
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1711, 783)
        Me.Controls.Add(Me.LBMode)
        Me.Controls.Add(Me.BTMode)
        Me.Controls.Add(Me.FAILGROUP)
        Me.Controls.Add(Me.TextLabel)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Number)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.InGrid)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.CountGridFail)
        Me.Controls.Add(Me.CountGridPass)
        Me.Controls.Add(Me.LabelDefectCode)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FailTB)
        Me.Controls.Add(Me.PassTB)
        Me.Controls.Add(Me.UnitID)
        Me.Controls.Add(Me.ManufSNShrt)
        Me.Controls.Add(Me.IDUser)
        Me.Controls.Add(Me.Line)
        Me.Controls.Add(Me.LOTID)
        Me.Controls.Add(Me.GridSerial)
        Me.Controls.Add(Me.GridCheck)
        Me.Controls.Add(Me.TestBox1)
        Me.Controls.Add(Me.Add_Click)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.labelUserID)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FailCounter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KGP_Control"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.GridCheck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.GridSerial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CountGridPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CountGridFail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.GridLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.FAILGROUP.ResumeLayout(False)
        Me.FAILGROUP.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RFID_ID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents NickLabel As Label
    Friend WithEvents labelUserID As Label
    Friend WithEvents SN_IN As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents FailRadio As RadioButton
    Friend WithEvents PassRadio As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Add_Click As Button
    Friend WithEvents TestBox1 As TextBox
    Friend WithEvents GridCheck As DataGridView
    Friend WithEvents LOTID As Label
    Friend WithEvents ManufSNShrt As Label
    Friend WithEvents UnitID As Label
    Friend WithEvents PassTB As TextBox
    Friend WithEvents FailTB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents InRadio As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents EndRadio As RadioButton
    Friend WithEvents GridSerial As DataGridView
    Friend WithEvents LabelDefectCode As Label
    Friend WithEvents Line As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents CountGridPass As DataGridView
    Friend WithEvents CountGridFail As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents IDUser As Label
    Friend WithEvents InGrid As DataGridView
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GridLog As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Number As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextLabel As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Private WithEvents FAILGROUP As GroupBox
    Private WithEvents Description As TextBox
    Private WithEvents Label7 As Label
    Private WithEvents Label8 As Label
    Private WithEvents ComboError As ComboBox
    Friend WithEvents BTMode As Button
    Friend WithEvents LBMode As Label
End Class
