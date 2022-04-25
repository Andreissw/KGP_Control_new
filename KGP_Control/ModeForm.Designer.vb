<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModeForm
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RBChoise = New System.Windows.Forms.RadioButton()
        Me.RBControl = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RBChoise
        '
        Me.RBChoise.AutoSize = True
        Me.RBChoise.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RBChoise.Location = New System.Drawing.Point(12, 12)
        Me.RBChoise.Name = "RBChoise"
        Me.RBChoise.Size = New System.Drawing.Size(231, 28)
        Me.RBChoise.TabIndex = 0
        Me.RBChoise.TabStop = True
        Me.RBChoise.Text = "Выборочный контроль"
        Me.RBChoise.UseVisualStyleBackColor = True
        '
        'RBControl
        '
        Me.RBControl.AutoSize = True
        Me.RBControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RBControl.Location = New System.Drawing.Point(256, 12)
        Me.RBControl.Name = "RBControl"
        Me.RBControl.Size = New System.Drawing.Size(209, 28)
        Me.RBControl.TabIndex = 1
        Me.RBControl.TabStop = True
        Me.RBControl.Text = "Сплошной контроль"
        Me.RBControl.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 60)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(453, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Выбрать"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ModeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(477, 104)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RBControl)
        Me.Controls.Add(Me.RBChoise)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ModeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModeForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RBChoise As RadioButton
    Friend WithEvents RBControl As RadioButton
    Friend WithEvents Button1 As Button
End Class
