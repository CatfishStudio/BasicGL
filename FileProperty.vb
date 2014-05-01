Imports System.IO
Public Class FileProperty
    Inherits System.Windows.Forms.Form

#Region " Код, автоматически созданный конструктором форм Windows "

    Public Sub New()
        MyBase.New()

        'Этот вызов требуется конструктором форм Windows.
        InitializeComponent()

        'Добавьте код инициализации после вызова InitializeComponent()

    End Sub

    'Форма переопределяет метод Dispose для очистки списка компонентов.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Требуется конструктором форм Windows
    Private components As System.ComponentModel.IContainer

    'ПРИМЕЧАНИЕ: следующая процедура требуется для конструктора форм Windows.
    'Ее можно изменить в конструкторе форм Windows.  
    'Не изменяйте ее в редакторе исходного текста.
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents LabelFolder As System.Windows.Forms.Label
    Friend WithEvents LabelFile As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBoxName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPath As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FileProperty))
        Me.LabelFolder = New System.Windows.Forms.Label
        Me.LabelFile = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.CheckBox5 = New System.Windows.Forms.CheckBox
        Me.CheckBox6 = New System.Windows.Forms.CheckBox
        Me.CheckBox7 = New System.Windows.Forms.CheckBox
        Me.CheckBox8 = New System.Windows.Forms.CheckBox
        Me.CheckBox4 = New System.Windows.Forms.CheckBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBoxPath = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBoxName = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelFolder
        '
        Me.LabelFolder.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelFolder.Image = CType(resources.GetObject("LabelFolder.Image"), System.Drawing.Image)
        Me.LabelFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelFolder.Location = New System.Drawing.Point(8, 8)
        Me.LabelFolder.Name = "LabelFolder"
        Me.LabelFolder.Size = New System.Drawing.Size(32, 32)
        Me.LabelFolder.TabIndex = 3
        Me.LabelFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LabelFolder.Visible = False
        '
        'LabelFile
        '
        Me.LabelFile.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelFile.Image = CType(resources.GetObject("LabelFile.Image"), System.Drawing.Image)
        Me.LabelFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelFile.Location = New System.Drawing.Point(8, 8)
        Me.LabelFile.Name = "LabelFile"
        Me.LabelFile.Size = New System.Drawing.Size(32, 32)
        Me.LabelFile.TabIndex = 4
        Me.LabelFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LabelFile.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(322, 416)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.TextBoxName)
        Me.TabPage1.Controls.Add(Me.LabelFolder)
        Me.TabPage1.Controls.Add(Me.LabelFile)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(314, 390)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Общие."
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.CheckBox5)
        Me.GroupBox3.Controls.Add(Me.CheckBox6)
        Me.GroupBox3.Controls.Add(Me.CheckBox7)
        Me.GroupBox3.Controls.Add(Me.CheckBox8)
        Me.GroupBox3.Controls.Add(Me.CheckBox4)
        Me.GroupBox3.Controls.Add(Me.CheckBox3)
        Me.GroupBox3.Controls.Add(Me.CheckBox2)
        Me.GroupBox3.Controls.Add(Me.CheckBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 264)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(302, 120)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Атрибуты:"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(80, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(116, 20)
        Me.TextBox1.TabIndex = 17
        Me.TextBox1.Text = ""
        Me.TextBox1.Visible = False
        '
        'CheckBox5
        '
        Me.CheckBox5.Location = New System.Drawing.Point(156, 92)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.TabIndex = 16
        Me.CheckBox5.Text = "Временный."
        '
        'CheckBox6
        '
        Me.CheckBox6.Location = New System.Drawing.Point(156, 68)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.TabIndex = 15
        Me.CheckBox6.Text = "Системный."
        '
        'CheckBox7
        '
        Me.CheckBox7.Location = New System.Drawing.Point(156, 44)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.TabIndex = 14
        Me.CheckBox7.Text = "Только чтение."
        '
        'CheckBox8
        '
        Me.CheckBox8.Location = New System.Drawing.Point(156, 20)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.TabIndex = 13
        Me.CheckBox8.Text = "Автономный."
        '
        'CheckBox4
        '
        Me.CheckBox4.Location = New System.Drawing.Point(16, 92)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.TabIndex = 12
        Me.CheckBox4.Text = "Обычный."
        '
        'CheckBox3
        '
        Me.CheckBox3.Location = New System.Drawing.Point(16, 68)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.TabIndex = 11
        Me.CheckBox3.Text = "Скрытый."
        '
        'CheckBox2
        '
        Me.CheckBox2.Location = New System.Drawing.Point(16, 44)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.TabIndex = 10
        Me.CheckBox2.Text = "Сжатый."
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(16, 20)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Архивный."
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TextBoxPath)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(302, 128)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Описание:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Location = New System.Drawing.Point(8, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(286, 23)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "..."
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.Location = New System.Drawing.Point(8, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(286, 23)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "..."
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.Location = New System.Drawing.Point(8, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(286, 23)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "..."
        '
        'TextBoxPath
        '
        Me.TextBoxPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxPath.Location = New System.Drawing.Point(40, 16)
        Me.TextBoxPath.Name = "TextBoxPath"
        Me.TextBoxPath.Size = New System.Drawing.Size(254, 20)
        Me.TextBoxPath.TabIndex = 1
        Me.TextBoxPath.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Петь:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 96)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Размер:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Location = New System.Drawing.Point(8, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(286, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "..."
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(286, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "..."
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "..."
        '
        'TextBoxName
        '
        Me.TextBoxName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxName.Location = New System.Drawing.Point(48, 16)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(254, 20)
        Me.TextBoxName.TabIndex = 5
        Me.TextBoxName.Text = ""
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(238, 424)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Закрыть"
        '
        'FileProperty
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(322, 456)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FileProperty"
        Me.Text = "Свойство."
        Me.TopMost = True
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public AtributFile As String
    
    Private Sub FileProperty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim CheckAtribut As String
        TextBox1.Text = AtributFile
        For i As Integer = 0 To AtributFile.Length - 1
            If (AtributFile.Chars(i) <> ",") Then
                CheckAtribut = CheckAtribut + AtributFile.Chars(i)
            Else
                If CheckAtribut = "Archive" Then
                    CheckBox1.Checked = True
                    CheckAtribut = ""
                    i = i + 1
                End If
                If CheckAtribut = "Compressed" Then
                    CheckBox2.Checked = True
                    CheckAtribut = ""
                    i = i + 1
                End If
                If CheckAtribut = "Hidden" Then
                    CheckBox3.Checked = True
                    CheckAtribut = ""
                    i = i + 1
                End If
                If CheckAtribut = "Normal" Then
                    CheckBox4.Checked = True
                    CheckAtribut = ""
                    i = i + 1
                End If
                If CheckAtribut = "Offline" Then
                    CheckBox8.Checked = True
                    CheckAtribut = ""
                    i = i + 1
                End If
                If CheckAtribut = "ReadOnly" Then
                    CheckBox7.Checked = True
                    CheckAtribut = ""
                    i = i + 1
                End If
                If CheckAtribut = "System" Then
                    CheckBox6.Checked = True
                    CheckAtribut = ""
                    i = i + 1
                End If
                If CheckAtribut = "Temporary" Then
                    CheckBox5.Checked = True
                    CheckAtribut = ""
                    i = i + 1
                End If
            End If
        Next
        If CheckAtribut = "Archive" Then
            CheckBox1.Checked = True
            CheckAtribut = ""
        End If
        If CheckAtribut = "Compressed" Then
            CheckBox2.Checked = True
            CheckAtribut = ""
        End If
        If CheckAtribut = "Hidden" Then
            CheckBox3.Checked = True
            CheckAtribut = ""
        End If
        If CheckAtribut = "Normal" Then
            CheckBox4.Checked = True
            CheckAtribut = ""
        End If
        If CheckAtribut = "Offline" Then
            CheckBox8.Checked = True
            CheckAtribut = ""
        End If
        If CheckAtribut = "ReadOnly" Then
            CheckBox7.Checked = True
            CheckAtribut = ""
        End If
        If CheckAtribut = "System" Then
            CheckBox6.Checked = True
            CheckAtribut = ""
        End If
        If CheckAtribut = "Temporary" Then
            CheckBox5.Checked = True
            CheckAtribut = ""
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

End Class
