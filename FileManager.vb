Imports System.IO
Public Class FileManager
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents DriveListBox1 As Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FileManager))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.Button3 = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.DriveListBox1 = New Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(504, 48)
        Me.Panel1.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Image)
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Location = New System.Drawing.Point(280, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 32)
        Me.Label8.TabIndex = 7
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Location = New System.Drawing.Point(240, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 32)
        Me.Label7.TabIndex = 6
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(200, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 32)
        Me.Label6.TabIndex = 5
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(136, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 32)
        Me.Label5.TabIndex = 4
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(96, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 32)
        Me.Label4.TabIndex = 3
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(56, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(320, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Файлы."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(24, 20)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(72, 49)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(352, 20)
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.Text = ""
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(424, 320)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Отмена."
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(320, 320)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "ОК."
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.ContextMenu = Me.ContextMenu1
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(0, 72)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(504, 240)
        Me.ListView1.SmallImageList = Me.ImageList1
        Me.ListView1.StateImageList = Me.ImageList1
        Me.ListView1.TabIndex = 13
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem7, Me.MenuItem10, Me.MenuItem16, Me.MenuItem17, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem12, Me.MenuItem11, Me.MenuItem5, Me.MenuItem6})
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 0
        Me.MenuItem7.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem8, Me.MenuItem9})
        Me.MenuItem7.Text = "Открыть с помощью."
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 0
        Me.MenuItem8.Text = "Блокнот"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 1
        Me.MenuItem9.Text = "WordPad"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 1
        Me.MenuItem10.Text = "-"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 2
        Me.MenuItem16.Text = "Вставить."
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 3
        Me.MenuItem17.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 4
        Me.MenuItem1.Text = "Вырезать."
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 5
        Me.MenuItem2.Text = "Копировать."
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 6
        Me.MenuItem3.Text = "Переименовать."
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 7
        Me.MenuItem4.Text = "Удалить."
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 8
        Me.MenuItem12.Text = "-"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 9
        Me.MenuItem11.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem13, Me.MenuItem14, Me.MenuItem15})
        Me.MenuItem11.Text = "Создать."
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 0
        Me.MenuItem13.Text = "Папку."
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 1
        Me.MenuItem14.Text = "Файл *.vb"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 2
        Me.MenuItem15.Text = "Файл *.txt"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 10
        Me.MenuItem5.Text = "-"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 11
        Me.MenuItem6.Text = "Свойство."
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(424, 48)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 23)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Переход"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.Items.AddRange(New Object() {"*.vb", "*.txt", "*.*"})
        Me.ComboBox1.Location = New System.Drawing.Point(0, 320)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(312, 21)
        Me.ComboBox1.TabIndex = 15
        Me.ComboBox1.Text = "*.vb"
        '
        'DriveListBox1
        '
        Me.DriveListBox1.Location = New System.Drawing.Point(0, 48)
        Me.DriveListBox1.Name = "DriveListBox1"
        Me.DriveListBox1.Size = New System.Drawing.Size(72, 21)
        Me.DriveListBox1.TabIndex = 16
        '
        'FileManager
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(504, 350)
        Me.Controls.Add(Me.DriveListBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FileManager"
        Me.Text = "FileManager"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FileManager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Папки
        Try
            'Dim dirs As String() = Directory.GetDirectories("c:\", "p*")
            Dim dirs As String() = Directory.GetDirectories(DriveListBox1.Drive.ToString + "\")
            Dim dir As String
            ListView1.Clear()
            Dim Index As Integer = 0
            Dim LastIndex As Integer
            Dim FolderName As String
            For Each dir In dirs
                LastIndex = dir.Length - 1
                For i As Integer = 0 To dir.Length - 1
                    If (dir.Chars(LastIndex) = "\") Then
                        FolderName = dir.Remove(0, LastIndex + 1)
                        Exit For
                    End If
                    LastIndex = LastIndex - 1
                Next
                ListView1.Items.Add(FolderName)
                ListView1.Items.Item(Index).ImageIndex = 0
                Index = Index + 1
            Next
            TextBox1.Text = DriveListBox1.Drive

            'Файлы
            LastIndex = 0
            Dim DirFiles As String() = Directory.GetFiles(DriveListBox1.Drive.ToString + "\", ComboBox1.Text)
            Dim AllFilesDir As String
            Dim FileName As String
            For Each AllFilesDir In DirFiles
                LastIndex = AllFilesDir.Length - 1
                For iFile As Integer = 0 To AllFilesDir.Length - 1
                    If (AllFilesDir.Chars(LastIndex) = "\") Then
                        FileName = AllFilesDir.Remove(0, LastIndex + 1)
                        Exit For
                    End If
                    LastIndex = LastIndex - 1
                Next
                ListView1.Items.Add(FileName)
                ListView1.Items.Item(Index).ImageIndex = 1
                Index = Index + 1
            Next
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        Try
            If (ListView1.SelectedIndices.Count > 0) Then
                If (ListView1.FocusedItem.ImageIndex = 0) Then
                    TextBox1.Text = TextBox1.Text + "\" + ListView1.FocusedItem.Text
                    Dim dirs As String() = Directory.GetDirectories(TextBox1.Text + "\")
                    Dim dir As String
                    ListView1.Clear()
                    Dim Index As Integer = 0
                    Dim LastIndex As Integer
                    Dim FolderName As String
                    For Each dir In dirs
                        LastIndex = dir.Length - 1
                        For i As Integer = 0 To dir.Length - 1
                            If (dir.Chars(LastIndex) = "\") Then
                                FolderName = dir.Remove(0, LastIndex + 1)
                                Exit For
                            End If
                            LastIndex = LastIndex - 1
                        Next
                        ListView1.Items.Add(FolderName)
                        ListView1.Items.Item(Index).ImageIndex = 0
                        Index = Index + 1
                    Next

                    'Файлы
                    'Удаление имени файла в командной строке
                    LastIndex = 0
                    Dim DirFiles As String() = Directory.GetFiles(TextBox1.Text + "\", ComboBox1.Text)
                    Dim AllFilesDir As String
                    Dim FileName As String
                    For Each AllFilesDir In DirFiles
                        LastIndex = AllFilesDir.Length - 1
                        For iFile As Integer = 0 To AllFilesDir.Length - 1
                            If (AllFilesDir.Chars(LastIndex) = "\") Then
                                FileName = AllFilesDir.Remove(0, LastIndex + 1)
                                Exit For
                            End If
                            LastIndex = LastIndex - 1
                        Next
                        ListView1.Items.Add(FileName)
                        ListView1.Items.Item(Index).ImageIndex = 1
                        Index = Index + 1
                    Next
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
            TextBox1.Text = DriveListBox1.Drive
            UpdateFileManager()
        End Try
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Try
            If (SelectFile = True) Then
                Dim LastIndex As Integer
                Dim EditPath As String
                LastIndex = TextBox1.Text.Length - 1
                EditPath = TextBox1.Text
                For i As Integer = 0 To EditPath.Length - 1
                    If (EditPath.Chars(LastIndex) = "\") Then
                        EditPath = TextBox1.Text.Remove(LastIndex, i + 1)
                        TextBox1.Clear()
                        TextBox1.Text = EditPath
                        SelectFile = False
                        Exit For
                    End If
                    LastIndex = LastIndex - 1
                Next
            End If


            If (TextBox1.Text <> DriveListBox1.Drive.ToString) Then
                Dim IndexBack As Integer
                IndexBack = TextBox1.TextLength - 1
                For iBack As Integer = 0 To TextBox1.TextLength - 1
                    If (TextBox1.Text.Chars(IndexBack) = "\") Then
                        TextBox1.Text = TextBox1.Text.Remove(IndexBack + 1, iBack)
                        Exit For
                    End If
                    IndexBack = IndexBack - 1
                Next

                TextBox1.Text = TextBox1.Text.Remove(TextBox1.TextLength - 1, 1)
                Dim dirs As String() = Directory.GetDirectories(TextBox1.Text + "\")
                Dim dir As String
                ListView1.Clear()
                Dim Index As Integer = 0
                Dim LastIndex As Integer
                Dim FolderName As String
                For Each dir In dirs
                    LastIndex = dir.Length - 1
                    For i As Integer = 0 To dir.Length - 1
                        If (dir.Chars(LastIndex) = "\") Then
                            FolderName = dir.Remove(0, LastIndex + 1)
                            Exit For
                        End If
                        LastIndex = LastIndex - 1
                    Next
                    ListView1.Items.Add(FolderName)
                    ListView1.Items.Item(Index).ImageIndex = 0
                    Index = Index + 1
                Next

                'Файлы
                LastIndex = 0
                Dim DirFiles As String() = Directory.GetFiles(TextBox1.Text + "\", ComboBox1.Text)
                Dim AllFilesDir As String
                Dim FileName As String
                For Each AllFilesDir In DirFiles
                    LastIndex = AllFilesDir.Length - 1
                    For iFile As Integer = 0 To AllFilesDir.Length - 1
                        If (AllFilesDir.Chars(LastIndex) = "\") Then
                            FileName = AllFilesDir.Remove(0, LastIndex + 1)
                            Exit For
                        End If
                        LastIndex = LastIndex - 1
                    Next
                    ListView1.Items.Add(FileName)
                    ListView1.Items.Item(Index).ImageIndex = 1
                    Index = Index + 1
                Next
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
            TextBox1.Text = DriveListBox1.Drive
            UpdateFileManager()
        End Try
    End Sub

    Private Sub Label2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label2.MouseMove
        Try
            Label2.BorderStyle = BorderStyle.FixedSingle
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub Label2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.MouseLeave
        Try
            Label2.BorderStyle = BorderStyle.None
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub DriveListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DriveListBox1.SelectedIndexChanged
        'Папки
        Try
            'Dim dirs As String() = Directory.GetDirectories("c:\", "p*")
            Dim dirs As String() = Directory.GetDirectories(DriveListBox1.Drive.ToString + "\")
            Dim dir As String
            ListView1.Clear()
            Dim Index As Integer = 0
            Dim LastIndex As Integer
            Dim FolderName As String
            For Each dir In dirs
                LastIndex = dir.Length - 1
                For i As Integer = 0 To dir.Length - 1
                    If (dir.Chars(LastIndex) = "\") Then
                        FolderName = dir.Remove(0, LastIndex + 1)
                        Exit For
                    End If
                    LastIndex = LastIndex - 1
                Next
                ListView1.Items.Add(FolderName)
                ListView1.Items.Item(Index).ImageIndex = 0
                Index = Index + 1
            Next
            TextBox1.Text = DriveListBox1.Drive

            'Файлы
            LastIndex = 0
            Dim DirFiles As String() = Directory.GetFiles(DriveListBox1.Drive.ToString + "\", ComboBox1.Text)
            Dim AllFilesDir As String
            Dim FileName As String
            For Each AllFilesDir In DirFiles
                LastIndex = AllFilesDir.Length - 1
                For iFile As Integer = 0 To AllFilesDir.Length - 1
                    If (AllFilesDir.Chars(LastIndex) = "\") Then
                        FileName = AllFilesDir.Remove(0, LastIndex + 1)
                        Exit For
                    End If
                    LastIndex = LastIndex - 1
                Next
                ListView1.Items.Add(FileName)
                ListView1.Items.Item(Index).ImageIndex = 1
                Index = Index + 1
            Next
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
            TextBox1.Text = DriveListBox1.Drive
            UpdateFileManager()
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim dirs As String() = Directory.GetDirectories(TextBox1.Text + "\")
            Dim dir As String
            ListView1.Clear()
            Dim Index As Integer = 0
            Dim LastIndex As Integer
            Dim FolderName As String
            For Each dir In dirs
                LastIndex = dir.Length - 1
                For i As Integer = 0 To dir.Length - 1
                    If (dir.Chars(LastIndex) = "\") Then
                        FolderName = dir.Remove(0, LastIndex + 1)
                        Exit For
                    End If
                    LastIndex = LastIndex - 1
                Next
                ListView1.Items.Add(FolderName)
                ListView1.Items.Item(Index).ImageIndex = 0
                Index = Index + 1
            Next

            'Файлы
            LastIndex = 0
            Dim DirFiles As String() = Directory.GetFiles(TextBox1.Text + "\", ComboBox1.Text)
            Dim AllFilesDir As String
            Dim FileName As String
            For Each AllFilesDir In DirFiles
                LastIndex = AllFilesDir.Length - 1
                For iFile As Integer = 0 To AllFilesDir.Length - 1
                    If (AllFilesDir.Chars(LastIndex) = "\") Then
                        FileName = AllFilesDir.Remove(0, LastIndex + 1)
                        Exit For
                    End If
                    LastIndex = LastIndex - 1
                Next
                ListView1.Items.Add(FileName)
                ListView1.Items.Item(Index).ImageIndex = 1
                Index = Index + 1
            Next
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
            TextBox1.Text = DriveListBox1.Drive
            UpdateFileManager()
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Close()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Dim SelectFile As Boolean = False
    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        Try
            If (ListView1.SelectedIndices.Count > 0) Then
                If (ListView1.FocusedItem.ImageIndex = 1) And (SelectFile = False) Then
                    TextBox1.Text = TextBox1.Text + "\" + ListView1.FocusedItem.Text
                    SelectFile = True
                    ListView1.Update()
                Else
                    If (ListView1.FocusedItem.ImageIndex = 1) And (SelectFile = True) Then
                        'Удаление имени файла в командной строке
                        Dim LastIndex As Integer
                        Dim EditPath As String
                        LastIndex = TextBox1.Text.Length - 1
                        EditPath = TextBox1.Text
                        For i As Integer = 0 To EditPath.Length - 1
                            If (EditPath.Chars(LastIndex) = "\") Then
                                EditPath = TextBox1.Text.Remove(LastIndex, i + 1)
                                TextBox1.Clear()
                                TextBox1.Text = EditPath
                                SelectFile = False
                                Exit For
                            End If
                            LastIndex = LastIndex - 1
                        Next
                    End If
                    If (ListView1.FocusedItem.ImageIndex = 0) And (SelectFile = True) Then
                        'Удаление имени файла в командной строке
                        Dim LastIndex As Integer
                        Dim EditPath As String
                        LastIndex = TextBox1.Text.Length - 1
                        EditPath = TextBox1.Text
                        For i As Integer = 0 To EditPath.Length - 1
                            If (EditPath.Chars(LastIndex) = "\") Then
                                EditPath = TextBox1.Text.Remove(LastIndex, i + 1)
                                TextBox1.Clear()
                                TextBox1.Text = EditPath
                                SelectFile = False
                                Exit For
                            End If
                            LastIndex = LastIndex - 1
                        Next
                    End If
                End If
            Else
                If (SelectFile = True) Then
                    'Удаление имени файла в командной строке
                    Dim LastIndex As Integer
                    Dim EditPath As String
                    LastIndex = TextBox1.Text.Length - 1
                    EditPath = TextBox1.Text
                    For i As Integer = 0 To EditPath.Length - 1
                        If (EditPath.Chars(LastIndex) = "\") Then
                            EditPath = TextBox1.Text.Remove(LastIndex, i + 1)
                            TextBox1.Clear()
                            TextBox1.Text = EditPath
                            SelectFile = False
                            Exit For
                        End If
                        LastIndex = LastIndex - 1
                    Next
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
            TextBox1.Text = DriveListBox1.Drive
            UpdateFileManager()
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If (Me.Text = "Открыть файл в модуле.") Then
                ModuleCube.LoadPModule()
                ModuleCube.PModule.MdiParent = ModuleCube.DesignerCube.ActiveForm
                ModuleCube.PModule.Folder.Text = ModuleCube.DesignerCube.StatusBarPanel2.Text
                ModuleCube.PModule.Text = "Модуль OpenGL: Новый модуль."
                ModuleCube.PModule.RichTextBox1.LoadFile(TextBox1.Text, RichTextBoxStreamType.PlainText)
                ModuleCube.PModule.Show()
                Close()
            End If
            If (Me.Text = "Открыть файл как...") Then
                ModuleCube.PModule.RichTextBox1.LoadFile(TextBox1.Text, RichTextBoxStreamType.PlainText)
                Close()
            End If
            If (Me.Text = "Сохранить файл как...") Then
                If (ListView1.SelectedIndices.Count > 0) Then
                    If (ListView1.FocusedItem.ImageIndex = 1) And (SelectFile = True) Then
                        ModuleCube.PModule.RichTextBox1.SaveFile(TextBox1.Text, RichTextBoxStreamType.PlainText)
                        Close()
                        MsgBox("Данные в файл успешно сохранены.", MsgBoxStyle.OKOnly, "Сообщение:")
                    Else
                        MsgBox("Выберите файл для сохранения.", MsgBoxStyle.OKOnly, "Сообщение:")
                    End If
                Else
                    MsgBox("Выберите файл для сохранения.", MsgBoxStyle.OKOnly, "Сообщение:")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            If (SelectFile = False) Then
                UpdateFileManager()
            Else
                Dim LastIndex As Integer
                Dim EditPath As String
                LastIndex = TextBox1.Text.Length - 1
                EditPath = TextBox1.Text
                For i As Integer = 0 To EditPath.Length - 1
                    If (EditPath.Chars(LastIndex) = "\") Then
                        EditPath = TextBox1.Text.Remove(LastIndex, i + 1)
                        TextBox1.Clear()
                        TextBox1.Text = EditPath
                        SelectFile = False
                        Exit For
                    End If
                    LastIndex = LastIndex - 1
                Next
                UpdateFileManager()
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
            TextBox1.Text = DriveListBox1.Drive
            UpdateFileManager()
        End Try
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Try
            Dim NameFolder As String
            NameFolder = InputBox("Введите имя папки:", "Новая папка.", "")
            If (NameFolder <> "") Then
                TextBox1.Text = TextBox1.Text + "\" + NameFolder
                Dim NewFolder As Directory
                NewFolder.CreateDirectory(TextBox1.Text)

                Dim dirs As String() = Directory.GetDirectories(TextBox1.Text + "\")
                Dim dir As String
                ListView1.Clear()
                Dim Index As Integer = 0
                Dim LastIndex As Integer
                Dim FolderName As String
                For Each dir In dirs
                    LastIndex = dir.Length - 1
                    For i As Integer = 0 To dir.Length - 1
                        If (dir.Chars(LastIndex) = "\") Then
                            FolderName = dir.Remove(0, LastIndex + 1)
                            Exit For
                        End If
                        LastIndex = LastIndex - 1
                    Next
                    ListView1.Items.Add(FolderName)
                    ListView1.Items.Item(Index).ImageIndex = 0
                    Index = Index + 1
                Next

                'Файлы
                LastIndex = 0
                Dim DirFiles As String() = Directory.GetFiles(TextBox1.Text + "\", ComboBox1.Text)
                Dim AllFilesDir As String
                Dim FileName As String
                For Each AllFilesDir In DirFiles
                    LastIndex = AllFilesDir.Length - 1
                    For iFile As Integer = 0 To AllFilesDir.Length - 1
                        If (AllFilesDir.Chars(LastIndex) = "\") Then
                            FileName = AllFilesDir.Remove(0, LastIndex + 1)
                            Exit For
                        End If
                        LastIndex = LastIndex - 1
                    Next
                    ListView1.Items.Add(FileName)
                    ListView1.Items.Item(Index).ImageIndex = 1
                    Index = Index + 1
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub Label3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label3.MouseMove
        Try
            Label3.BorderStyle = BorderStyle.FixedSingle
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub Label3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.MouseLeave
        Try
            Label3.BorderStyle = BorderStyle.None
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Try
            Dim NameFile As String
            NameFile = InputBox("Введите имя файла:", "Новый файл *.vb", "")
            If (NameFile <> "") Then
                Dim NewFile As File
                NewFile.Create(TextBox1.Text + "\" + NameFile + ".vb")

                Dim dirs As String() = Directory.GetDirectories(TextBox1.Text + "\")
                Dim dir As String
                ListView1.Clear()
                Dim Index As Integer = 0
                Dim LastIndex As Integer
                Dim FolderName As String
                For Each dir In dirs
                    LastIndex = dir.Length - 1
                    For i As Integer = 0 To dir.Length - 1
                        If (dir.Chars(LastIndex) = "\") Then
                            FolderName = dir.Remove(0, LastIndex + 1)
                            Exit For
                        End If
                        LastIndex = LastIndex - 1
                    Next
                    ListView1.Items.Add(FolderName)
                    ListView1.Items.Item(Index).ImageIndex = 0
                    Index = Index + 1
                Next

                'Файлы
                LastIndex = 0
                Dim DirFiles As String() = Directory.GetFiles(TextBox1.Text + "\", ComboBox1.Text)
                Dim AllFilesDir As String
                Dim FileName As String
                For Each AllFilesDir In DirFiles
                    LastIndex = AllFilesDir.Length - 1
                    For iFile As Integer = 0 To AllFilesDir.Length - 1
                        If (AllFilesDir.Chars(LastIndex) = "\") Then
                            FileName = AllFilesDir.Remove(0, LastIndex + 1)
                            Exit For
                        End If
                        LastIndex = LastIndex - 1
                    Next
                    ListView1.Items.Add(FileName)
                    ListView1.Items.Item(Index).ImageIndex = 1
                    Index = Index + 1
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub Label4_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label4.MouseMove
        Try
            Label4.BorderStyle = BorderStyle.FixedSingle
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub Label4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label4.MouseLeave
        Try
            Label4.BorderStyle = BorderStyle.None
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Try
            Dim NameFile As String
            NameFile = InputBox("Введите имя файла:", "Новый файл *.txt", "")
            If (NameFile <> "") Then
                Dim NewFile As File
                NewFile.Create(TextBox1.Text + "\" + NameFile + ".txt")

                Dim dirs As String() = Directory.GetDirectories(TextBox1.Text + "\")
                Dim dir As String
                ListView1.Clear()
                Dim Index As Integer = 0
                Dim LastIndex As Integer
                Dim FolderName As String
                For Each dir In dirs
                    LastIndex = dir.Length - 1
                    For i As Integer = 0 To dir.Length - 1
                        If (dir.Chars(LastIndex) = "\") Then
                            FolderName = dir.Remove(0, LastIndex + 1)
                            Exit For
                        End If
                        LastIndex = LastIndex - 1
                    Next
                    ListView1.Items.Add(FolderName)
                    ListView1.Items.Item(Index).ImageIndex = 0
                    Index = Index + 1
                Next

                'Файлы
                LastIndex = 0
                Dim DirFiles As String() = Directory.GetFiles(TextBox1.Text + "\", ComboBox1.Text)
                Dim AllFilesDir As String
                Dim FileName As String
                For Each AllFilesDir In DirFiles
                    LastIndex = AllFilesDir.Length - 1
                    For iFile As Integer = 0 To AllFilesDir.Length - 1
                        If (AllFilesDir.Chars(LastIndex) = "\") Then
                            FileName = AllFilesDir.Remove(0, LastIndex + 1)
                            Exit For
                        End If
                        LastIndex = LastIndex - 1
                    Next
                    ListView1.Items.Add(FileName)
                    ListView1.Items.Item(Index).ImageIndex = 1
                    Index = Index + 1
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub Label5_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label5.MouseMove
        Try
            Label5.BorderStyle = BorderStyle.FixedSingle
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub Label5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label5.MouseLeave
        Try
            Label5.BorderStyle = BorderStyle.None
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Try
            ListView1.View = View.LargeIcon
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub Label6_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label6.MouseMove
        Try
            Label6.BorderStyle = BorderStyle.FixedSingle
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub Label6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label6.MouseLeave
        Try
            Label6.BorderStyle = BorderStyle.None
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        Try
            ListView1.View = View.SmallIcon
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub Label7_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label7.MouseMove
        Try
            Label7.BorderStyle = BorderStyle.FixedSingle
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub Label7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label7.MouseLeave
        Try
            Label7.BorderStyle = BorderStyle.None
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        Try
            ListView1.View = View.List
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub Label8_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label8.MouseMove
        Try
            Label8.BorderStyle = BorderStyle.FixedSingle
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub Label8_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label8.MouseLeave
        Try
            Label8.BorderStyle = BorderStyle.None
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        Try
            Dim NameFolder As String
            NameFolder = InputBox("Введите имя папки:", "Новая папка.", "")
            If (NameFolder <> "") Then
                TextBox1.Text = TextBox1.Text + "\" + NameFolder
                Dim NewFolder As Directory
                NewFolder.CreateDirectory(TextBox1.Text)

                Dim dirs As String() = Directory.GetDirectories(TextBox1.Text + "\")
                Dim dir As String
                ListView1.Clear()
                Dim Index As Integer = 0
                Dim LastIndex As Integer
                Dim FolderName As String
                For Each dir In dirs
                    LastIndex = dir.Length - 1
                    For i As Integer = 0 To dir.Length - 1
                        If (dir.Chars(LastIndex) = "\") Then
                            FolderName = dir.Remove(0, LastIndex + 1)
                            Exit For
                        End If
                        LastIndex = LastIndex - 1
                    Next
                    ListView1.Items.Add(FolderName)
                    ListView1.Items.Item(Index).ImageIndex = 0
                    Index = Index + 1
                Next

                'Файлы
                LastIndex = 0
                Dim DirFiles As String() = Directory.GetFiles(TextBox1.Text + "\", ComboBox1.Text)
                Dim AllFilesDir As String
                Dim FileName As String
                For Each AllFilesDir In DirFiles
                    LastIndex = AllFilesDir.Length - 1
                    For iFile As Integer = 0 To AllFilesDir.Length - 1
                        If (AllFilesDir.Chars(LastIndex) = "\") Then
                            FileName = AllFilesDir.Remove(0, LastIndex + 1)
                            Exit For
                        End If
                        LastIndex = LastIndex - 1
                    Next
                    ListView1.Items.Add(FileName)
                    ListView1.Items.Item(Index).ImageIndex = 1
                    Index = Index + 1
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        Try
            Dim NameFile As String
            NameFile = InputBox("Введите имя файла:", "Новый файл *.vb", "")
            If (NameFile <> "") Then
                Dim NewFile As File
                NewFile.Create(TextBox1.Text + "\" + NameFile + ".vb")

                Dim dirs As String() = Directory.GetDirectories(TextBox1.Text + "\")
                Dim dir As String
                ListView1.Clear()
                Dim Index As Integer = 0
                Dim LastIndex As Integer
                Dim FolderName As String
                For Each dir In dirs
                    LastIndex = dir.Length - 1
                    For i As Integer = 0 To dir.Length - 1
                        If (dir.Chars(LastIndex) = "\") Then
                            FolderName = dir.Remove(0, LastIndex + 1)
                            Exit For
                        End If
                        LastIndex = LastIndex - 1
                    Next
                    ListView1.Items.Add(FolderName)
                    ListView1.Items.Item(Index).ImageIndex = 0
                    Index = Index + 1
                Next

                'Файлы
                LastIndex = 0
                Dim DirFiles As String() = Directory.GetFiles(TextBox1.Text + "\", ComboBox1.Text)
                Dim AllFilesDir As String
                Dim FileName As String
                For Each AllFilesDir In DirFiles
                    LastIndex = AllFilesDir.Length - 1
                    For iFile As Integer = 0 To AllFilesDir.Length - 1
                        If (AllFilesDir.Chars(LastIndex) = "\") Then
                            FileName = AllFilesDir.Remove(0, LastIndex + 1)
                            Exit For
                        End If
                        LastIndex = LastIndex - 1
                    Next
                    ListView1.Items.Add(FileName)
                    ListView1.Items.Item(Index).ImageIndex = 1
                    Index = Index + 1
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        Try
            Dim NameFile As String
            NameFile = InputBox("Введите имя файла:", "Новый файл *.txt", "")
            If (NameFile <> "") Then
                Dim NewFile As File
                NewFile.Create(TextBox1.Text + "\" + NameFile + ".txt")

                Dim dirs As String() = Directory.GetDirectories(TextBox1.Text + "\")
                Dim dir As String
                ListView1.Clear()
                Dim Index As Integer = 0
                Dim LastIndex As Integer
                Dim FolderName As String
                For Each dir In dirs
                    LastIndex = dir.Length - 1
                    For i As Integer = 0 To dir.Length - 1
                        If (dir.Chars(LastIndex) = "\") Then
                            FolderName = dir.Remove(0, LastIndex + 1)
                            Exit For
                        End If
                        LastIndex = LastIndex - 1
                    Next
                    ListView1.Items.Add(FolderName)
                    ListView1.Items.Item(Index).ImageIndex = 0
                    Index = Index + 1
                Next

                'Файлы
                LastIndex = 0
                Dim DirFiles As String() = Directory.GetFiles(TextBox1.Text + "\", ComboBox1.Text)
                Dim AllFilesDir As String
                Dim FileName As String
                For Each AllFilesDir In DirFiles
                    LastIndex = AllFilesDir.Length - 1
                    For iFile As Integer = 0 To AllFilesDir.Length - 1
                        If (AllFilesDir.Chars(LastIndex) = "\") Then
                            FileName = AllFilesDir.Remove(0, LastIndex + 1)
                            Exit For
                        End If
                        LastIndex = LastIndex - 1
                    Next
                    ListView1.Items.Add(FileName)
                    ListView1.Items.Item(Index).ImageIndex = 1
                    Index = Index + 1
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub ListView1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseDown
        Try
            If (e.Button = MouseButtons.Right) Then
                If (ListView1.SelectedIndices.Count > 0) Then
                    MenuItem1.Enabled = True
                    MenuItem2.Enabled = True
                    MenuItem3.Enabled = True
                    MenuItem4.Enabled = True
                    MenuItem6.Enabled = True
                    If (ListView1.FocusedItem.ImageIndex = 1) Then
                        MenuItem7.Enabled = True
                    Else
                        MenuItem7.Enabled = False
                    End If
                    MenuItem11.Enabled = False
                    MenuItem16.Enabled = False
                Else
                    MenuItem1.Enabled = False
                    MenuItem2.Enabled = False
                    MenuItem3.Enabled = False
                    MenuItem4.Enabled = False
                    MenuItem6.Enabled = False
                    MenuItem7.Enabled = False
                    MenuItem11.Enabled = True
                    If (PathCopyFile <> "") Or (PathCopyFolder <> "") Or (PathCutFile <> "") Or (PathCutFolder <> "") Then
                        MenuItem16.Enabled = True
                    Else
                        MenuItem16.Enabled = False
                    End If
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
            TextBox1.Text = DriveListBox1.Drive
            UpdateFileManager()
        End Try
    End Sub

    Dim NameFile As String
    Dim NameFolder As String
    Dim PathCopyFile As String
    Dim PathPasteFile As String
    Dim PathDeleteFile As String
    Dim PathCutFile As String
    Dim PathCopyFolder As String
    Dim PathPasteFolder As String
    Dim PathDeleteFolder As String
    Dim PathCutFolder As String
    Dim ActionCopyFile, ActionCopyFolder As Boolean
    Dim ActionCutFile, ActionCutFolder As Boolean
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        'Копировать
        Try
            ActionCutFile = False
            ActionCutFolder = False
            ActionCopyFile = False
            ActionCopyFolder = False
            NameFile = ""
            NameFolder = ""
            '...............
            PathCopyFile = ""
            PathPasteFile = ""
            PathDeleteFile = ""
            PathCutFile = ""
            '................
            PathCopyFolder = ""
            PathPasteFolder = ""
            PathDeleteFolder = ""
            PathCutFolder = ""
            If (ListView1.SelectedIndices.Count > 0) Then
                If (ListView1.FocusedItem.ImageIndex = 0) Then 'Папка
                    NameFolder = ListView1.FocusedItem.Text
                    PathCopyFolder = TextBox1.Text + "\" + NameFolder
                    ActionCopyFile = False
                    ActionCopyFolder = True
                Else
                    If (ListView1.FocusedItem.ImageIndex = 1) Then 'Файл
                        NameFile = ListView1.FocusedItem.Text
                        PathCopyFile = TextBox1.Text
                        ActionCopyFile = True
                        ActionCopyFolder = False
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        'ФАЙЛ
        Try
            If (ActionCopyFile = True) Then
                File.Copy(PathCopyFile, TextBox1.Text + "\" + NameFile, True)
                If (File.Exists(TextBox1.Text + "\" + NameFile) = True) Then
                    ActionCopyFile = False
                    ActionCutFile = False
                    ActionCopyFolder = False
                    ActionCutFolder = False
                    NameFile = ""
                    NameFolder = ""
                    '...............
                    PathCopyFile = ""
                    PathPasteFile = ""
                    PathDeleteFile = ""
                    PathCutFile = ""
                    '................
                    PathCopyFolder = ""
                    PathPasteFolder = ""
                    PathDeleteFolder = ""
                    PathCutFolder = ""
                    '................
                    UpdateFileManager()
                    MsgBox("Файл успешно скопирован.", MsgBoxStyle.OKOnly, "Сообщение:")
                Else
                    MsgBox("Ощибка!!! Файл не получилось скопировать.", MsgBoxStyle.OKOnly, "Сообщение:")
                End If
            End If
            If (ActionCutFile = True) Then
                File.Move(PathCutFile, TextBox1.Text + "\" + NameFile)
                If (File.Exists(TextBox1.Text + "\" + NameFile) = True) Then
                    ActionCopyFile = False
                    ActionCutFile = False
                    ActionCopyFolder = False
                    ActionCutFolder = False
                    NameFile = ""
                    NameFolder = ""
                    '...............
                    PathCopyFile = ""
                    PathPasteFile = ""
                    PathDeleteFile = ""
                    PathCutFile = ""
                    '................
                    PathCopyFolder = ""
                    PathPasteFolder = ""
                    PathDeleteFolder = ""
                    PathCutFolder = ""
                    '................
                    UpdateFileManager()
                    MsgBox("Файл успешно перемещен.", MsgBoxStyle.OKOnly, "Сообщение:")
                Else
                    MsgBox("Ощибка!!! Файл не был перемещен.", MsgBoxStyle.OKOnly, "Сообщение:")
                End If
            End If
            'ПАПКА
            If (ActionCutFolder = True) Then
                Directory.Move(PathCutFolder, TextBox1.Text + "\" + NameFolder)
                If (Directory.Exists(TextBox1.Text + "\" + NameFolder) = True) Then
                    ActionCopyFile = False
                    ActionCutFile = False
                    ActionCopyFolder = False
                    ActionCutFolder = False
                    NameFile = ""
                    NameFolder = ""
                    '...............
                    PathCopyFile = ""
                    PathPasteFile = ""
                    PathDeleteFile = ""
                    PathCutFile = ""
                    '................
                    PathCopyFolder = ""
                    PathPasteFolder = ""
                    PathDeleteFolder = ""
                    PathCutFolder = ""
                    '................
                    UpdateFileManager()
                    MsgBox("Папка успешно перемещена.", MsgBoxStyle.OKOnly, "Сообщение:")
                Else
                    MsgBox("Ощибка!!! Папка не перемещена.", MsgBoxStyle.OKOnly, "Сообщение:")
                End If
            End If
            If (ActionCopyFolder = True) Then
                ActionCopyFile = False
                ActionCutFile = False
                ActionCopyFolder = False
                ActionCutFolder = False
                NameFile = ""
                NameFolder = ""
                '...............
                PathCopyFile = ""
                PathPasteFile = ""
                PathDeleteFile = ""
                PathCutFile = ""
                '................
                PathCopyFolder = ""
                PathPasteFolder = ""
                PathDeleteFolder = ""
                PathCutFolder = ""
                '................
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        'Вырезать
        Try
            ActionCutFile = False
            ActionCutFolder = False
            ActionCopyFile = False
            ActionCopyFolder = False
            NameFile = ""
            NameFolder = ""
            '...............
            PathCopyFile = ""
            PathPasteFile = ""
            PathDeleteFile = ""
            PathCutFile = ""
            '................
            PathCopyFolder = ""
            PathPasteFolder = ""
            PathDeleteFolder = ""
            PathCutFolder = ""
            If (ListView1.SelectedIndices.Count > 0) Then
                If (ListView1.FocusedItem.ImageIndex = 0) Then 'Папка
                    NameFolder = ListView1.FocusedItem.Text
                    PathCutFolder = TextBox1.Text + "\" + NameFolder
                    ActionCutFile = False
                    ActionCutFolder = True
                Else
                    If (ListView1.FocusedItem.ImageIndex = 1) Then 'Файл
                        NameFile = ListView1.FocusedItem.Text
                        PathCutFile = TextBox1.Text
                        ActionCutFile = True
                        ActionCutFolder = False
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub


    Private Sub UpdateFileManager()
        Try
            Dim dirs As String() = Directory.GetDirectories(TextBox1.Text + "\")
            Dim dir As String
            ListView1.Clear()
            Dim Index As Integer = 0
            Dim LastIndex As Integer
            Dim FolderName As String
            For Each dir In dirs
                LastIndex = dir.Length - 1
                For i As Integer = 0 To dir.Length - 1
                    If (dir.Chars(LastIndex) = "\") Then
                        FolderName = dir.Remove(0, LastIndex + 1)
                        Exit For
                    End If
                    LastIndex = LastIndex - 1
                Next
                ListView1.Items.Add(FolderName)
                ListView1.Items.Item(Index).ImageIndex = 0
                Index = Index + 1
            Next

            'Файлы
            LastIndex = 0
            Dim DirFiles As String() = Directory.GetFiles(TextBox1.Text + "\", ComboBox1.Text)
            Dim AllFilesDir As String
            Dim FileName As String
            For Each AllFilesDir In DirFiles
                LastIndex = AllFilesDir.Length - 1
                For iFile As Integer = 0 To AllFilesDir.Length - 1
                    If (AllFilesDir.Chars(LastIndex) = "\") Then
                        FileName = AllFilesDir.Remove(0, LastIndex + 1)
                        Exit For
                    End If
                    LastIndex = LastIndex - 1
                Next
                ListView1.Items.Add(FileName)
                ListView1.Items.Item(Index).ImageIndex = 1
                Index = Index + 1
            Next
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        'Переименовать
        Try
            If (ListView1.SelectedIndices.Count > 0) Then
                If (ListView1.FocusedItem.ImageIndex = 0) Then 'Папка
                    NameFolder = InputBox("Введите новое имя папки", "Переименовать папку:", ListView1.FocusedItem.Text)
                    If (NameFolder <> "") Then
                        Directory.Move(TextBox1.Text + "\" + ListView1.FocusedItem.Text, TextBox1.Text + "\" + NameFolder)
                        If (Directory.Exists(TextBox1.Text + "\" + NameFolder) = True) Then
                            ActionCopyFile = False
                            ActionCutFile = False
                            ActionCopyFolder = False
                            ActionCutFolder = False
                            NameFile = ""
                            NameFolder = ""
                            '...............
                            PathCopyFile = ""
                            PathPasteFile = ""
                            PathDeleteFile = ""
                            PathCutFile = ""
                            '................
                            PathCopyFolder = ""
                            PathPasteFolder = ""
                            PathDeleteFolder = ""
                            PathCutFolder = ""
                            '................
                            UpdateFileManager()
                            MsgBox("Папка успешно переименованна.", MsgBoxStyle.OKOnly, "Сообщение:")
                        Else
                            MsgBox("Ощибка!!! Папка не переименованна.", MsgBoxStyle.OKOnly, "Сообщение:")
                        End If
                    End If
                Else
                    If (ListView1.FocusedItem.ImageIndex = 1) Then 'Файл
                        NameFile = InputBox("Введите новое имя и расширение файла", "Переименовать папку:", ListView1.FocusedItem.Text)
                        If (NameFile <> "") Then
                            Dim LastIndex As Integer
                            Dim EditPath As String
                            LastIndex = TextBox1.Text.Length - 1
                            EditPath = TextBox1.Text
                            For i As Integer = 0 To EditPath.Length - 1
                                If (EditPath.Chars(LastIndex) = "\") Then
                                    EditPath = TextBox1.Text.Remove(LastIndex, i + 1)
                                    Exit For
                                End If
                                LastIndex = LastIndex - 1
                            Next
                            File.Move(TextBox1.Text, EditPath + "\" + NameFile)
                            If (File.Exists(EditPath + "\" + NameFile) = True) Then
                                SelectFile = False
                                ActionCopyFile = False
                                ActionCutFile = False
                                ActionCopyFolder = False
                                ActionCutFolder = False
                                NameFile = ""
                                NameFolder = ""
                                '...............
                                PathCopyFile = ""
                                PathPasteFile = ""
                                PathDeleteFile = ""
                                PathCutFile = ""
                                '................
                                PathCopyFolder = ""
                                PathPasteFolder = ""
                                PathDeleteFolder = ""
                                PathCutFolder = ""
                                '................
                                TextBox1.Text = EditPath
                                UpdateFileManager()
                                MsgBox("Файл успешно переименован.", MsgBoxStyle.OKOnly, "Сообщение:")
                            Else
                                MsgBox("Ощибка!!! Файл не переименован.", MsgBoxStyle.OKOnly, "Сообщение:")
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        Try
            If (ListView1.SelectedIndices.Count > 0) Then
                If (ListView1.FocusedItem.ImageIndex = 1) Then 'Файл
                    Diagnostics.Process.Start("notepad.exe", TextBox1.Text)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        Try
            If (ListView1.SelectedIndices.Count > 0) Then
                If (ListView1.FocusedItem.ImageIndex = 1) Then 'Файл
                    Diagnostics.Process.Start("wordpad.exe", TextBox1.Text)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        'Удалить
        Try
            ActionCutFile = False
            ActionCutFolder = False
            ActionCopyFile = False
            ActionCopyFolder = False
            NameFile = ""
            NameFolder = ""
            '...............
            PathCopyFile = ""
            PathPasteFile = ""
            PathDeleteFile = ""
            PathCutFile = ""
            '................
            PathCopyFolder = ""
            PathPasteFolder = ""
            PathDeleteFolder = ""
            PathCutFolder = ""
            If (ListView1.SelectedIndices.Count > 0) Then
                If (ListView1.FocusedItem.ImageIndex = 0) Then 'Папка
                    NameFolder = ListView1.FocusedItem.Text
                    If (MsgBox("Вы желаете безвозвратно удалить папку [" + NameFolder + "] и всё её содержимое?", MsgBoxStyle.YesNo, "Вопрос:") = MsgBoxResult.Yes) Then
                        Directory.Delete(TextBox1.Text + "\" + NameFolder, True)
                        If (Directory.Exists(TextBox1.Text + "\" + NameFolder) = False) Then
                            MsgBox("Папка успешно удалена.", MsgBoxStyle.OKOnly, "Сообщение:")
                        Else
                            MsgBox("Ошибка!!! Папка не удалена.", MsgBoxStyle.OKOnly, "Сообщение:")
                        End If
                        UpdateFileManager()
                    End If
                Else
                    If (ListView1.FocusedItem.ImageIndex = 1) Then 'Файл
                        If (MsgBox("Удалить файл [" + ListView1.FocusedItem.Text + "] безвозвратно?", MsgBoxStyle.YesNo, "Вопрос:") = MsgBoxResult.Yes) Then
                            File.Delete(TextBox1.Text)
                            If (File.Exists(TextBox1.Text) = False) Then
                                MsgBox("Файл успешно удалена.", MsgBoxStyle.OKOnly, "Сообщение:")
                            Else
                                MsgBox("Ошибка!!! Файл не удален.", MsgBoxStyle.OKOnly, "Сообщение:")
                            End If
                            'Удаление имени файла в командной строке
                            Dim LastIndex As Integer
                            Dim EditPath As String
                            LastIndex = TextBox1.Text.Length - 1
                            EditPath = TextBox1.Text
                            For i As Integer = 0 To EditPath.Length - 1
                                If (EditPath.Chars(LastIndex) = "\") Then
                                    EditPath = TextBox1.Text.Remove(LastIndex, i + 1)
                                    TextBox1.Clear()
                                    TextBox1.Text = EditPath
                                    SelectFile = False
                                    Exit For
                                End If
                                LastIndex = LastIndex - 1
                            Next
                            UpdateFileManager()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        'Свойства
        Try
            If (ListView1.SelectedIndices.Count > 0) Then
                If (ListView1.FocusedItem.ImageIndex = 0) Then 'Папка
                    Dim FolderP As New FileProperty
                    NameFolder = ListView1.FocusedItem.Text
                    Dim FolderInformation As DirectoryInfo = New DirectoryInfo(TextBox1.Text + "\" + NameFolder)
                    Dim SizeBT, SizeMB, SizeGB As Double
                    FolderP.LabelFolder.Visible = True
                    'Имя Папки
                    FolderP.TextBoxName.Text = FolderInformation.Name
                    'Размер папки
                    'SizeBT = GetFolderSize(TextBox1.Text + "\" + NameFolder, True)
                    'SizeMB = (SizeBT / 1024) / 1024
                    'SizeGB = SizeMB / 1024
                    'FolderP.Label1.Text = SizeBT.ToString + " байт."
                    'FolderP.Label2.Text = SizeMB.ToString + " Мбайт."
                    'FolderP.Label3.Text = SizeGB.ToString + " Гб."
                    'Описание
                    FolderP.TextBoxPath.Text = TextBox1.Text + "\"
                    FolderP.Label7.Text = "Файл создан  : " + FolderInformation.CreationTime.ToString
                    FolderP.Label6.Text = "Файл открыт  : " + FolderInformation.LastAccessTime.ToString
                    FolderP.Label5.Text = "Файл изменен : " + FolderInformation.LastWriteTime.ToString
                    'Атрибуты
                    FolderP.AtributFile = FolderInformation.Attributes.ToString
                    '-----------
                    FolderP.Show()
                    'Размер папки
                    FolderP.Update()
                    SizeBT = GetFolderSize(TextBox1.Text + "\" + NameFolder, FolderP, True)
                    SizeMB = Format((SizeBT / 1024) / 1024, "###0")
                    SizeGB = Format(SizeMB / 1024, "###0.00")
                    FolderP.Label1.Text = SizeBT.ToString + " байт."
                    FolderP.Label2.Text = SizeMB.ToString + " Мбайт."
                    FolderP.Label3.Text = SizeGB.ToString + " Гб."
                    FolderP.Update()
                Else
                    If (ListView1.FocusedItem.ImageIndex = 1) Then 'Файл
                        Dim FileInformation As FileInfo = New FileInfo(TextBox1.Text)
                        Dim SizeBT, SizeMB, SizeGB As Integer
                        Dim FileP As New FileProperty
                        FileP.LabelFile.Visible = True
                        'Имя файла
                        FileP.TextBoxName.Text = FileInformation.Name
                        'Размер файла
                        SizeBT = FileInformation.Length / 1024
                        SizeMB = SizeBT / 1024
                        SizeGB = SizeMB / 1024
                        FileP.Label1.Text = SizeBT.ToString + " байт."
                        FileP.Label2.Text = SizeMB.ToString + " Мбайт."
                        FileP.Label3.Text = SizeGB.ToString + " Гб."
                        'Описание
                        FileP.TextBoxPath.Text = TextBox1.Text
                        FileP.Label7.Text = "Файл создан  : " + FileInformation.CreationTime.ToString
                        FileP.Label6.Text = "Файл открыт  : " + FileInformation.LastAccessTime.ToString
                        FileP.Label5.Text = "Файл изменен : " + FileInformation.LastWriteTime.ToString
                        'Атрибуты
                        FileP.AtributFile = FileInformation.Attributes.ToString
                        '-----------
                        FileP.Show()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Public Function GetFolderSize(ByVal DirPath As String, ByVal FormP As FileProperty, Optional ByVal IncludeSubFolders As Boolean = True) As Long
        Dim lngDirSize As Long
        Dim objFileInfo As FileInfo
        Dim objDir As DirectoryInfo = New DirectoryInfo(DirPath)
        Dim objSubFolder As DirectoryInfo

        Try
            'Сложить размер каждого файла
            For Each objFileInfo In objDir.GetFiles()
                lngDirSize += objFileInfo.Length
                FormP.Update()
                FormP.Label1.Text = lngDirSize.ToString + " байт."
                FormP.Update()
            Next

            'Рекурсивно вызывать функцию для получения
            'размера подпапок...
            If IncludeSubFolders Then
                For Each objSubFolder In objDir.GetDirectories()
                    lngDirSize += GetFolderSize(objSubFolder.FullName, FormP)
                Next
            End If
        Catch Ex As Exception
            MessageBox.Show(Err.Description)
        End Try
        Return lngDirSize
    End Function

    Private Sub ComboBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyDown
        Try
            If (e.KeyData = Keys.Enter) Then
                If (SelectFile = False) Then
                    UpdateFileManager()
                Else
                    Dim LastIndex As Integer
                    Dim EditPath As String
                    LastIndex = TextBox1.Text.Length - 1
                    EditPath = TextBox1.Text
                    For i As Integer = 0 To EditPath.Length - 1
                        If (EditPath.Chars(LastIndex) = "\") Then
                            EditPath = TextBox1.Text.Remove(LastIndex, i + 1)
                            TextBox1.Clear()
                            TextBox1.Text = EditPath
                            SelectFile = False
                            Exit For
                        End If
                        LastIndex = LastIndex - 1
                    Next
                    UpdateFileManager()
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
            TextBox1.Text = DriveListBox1.Drive
            UpdateFileManager()
        End Try
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        Try
            If (e.KeyData = Keys.Enter) Then
                Dim dirs As String() = Directory.GetDirectories(TextBox1.Text + "\")
                Dim dir As String
                ListView1.Clear()
                Dim Index As Integer = 0
                Dim LastIndex As Integer
                Dim FolderName As String
                For Each dir In dirs
                    LastIndex = dir.Length - 1
                    For i As Integer = 0 To dir.Length - 1
                        If (dir.Chars(LastIndex) = "\") Then
                            FolderName = dir.Remove(0, LastIndex + 1)
                            Exit For
                        End If
                        LastIndex = LastIndex - 1
                    Next
                    ListView1.Items.Add(FolderName)
                    ListView1.Items.Item(Index).ImageIndex = 0
                    Index = Index + 1
                Next

                'Файлы
                LastIndex = 0
                Dim DirFiles As String() = Directory.GetFiles(TextBox1.Text + "\", ComboBox1.Text)
                Dim AllFilesDir As String
                Dim FileName As String
                For Each AllFilesDir In DirFiles
                    LastIndex = AllFilesDir.Length - 1
                    For iFile As Integer = 0 To AllFilesDir.Length - 1
                        If (AllFilesDir.Chars(LastIndex) = "\") Then
                            FileName = AllFilesDir.Remove(0, LastIndex + 1)
                            Exit For
                        End If
                        LastIndex = LastIndex - 1
                    Next
                    ListView1.Items.Add(FileName)
                    ListView1.Items.Item(Index).ImageIndex = 1
                    Index = Index + 1
                Next
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
            TextBox1.Text = DriveListBox1.Drive
            UpdateFileManager()
        End Try
    End Sub
End Class
