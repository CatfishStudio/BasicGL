Public Class ProcessModule
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox3 As System.Windows.Forms.RichTextBox
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DataSet31 As BasicGL.DataSet3
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Folder As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents PanelMessageError As System.Windows.Forms.Panel
    Friend WithEvents DataSet41 As BasicGL.DataSet4
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ModuleCompile As System.Windows.Forms.TextBox
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem33 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem34 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem35 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem36 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem37 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem38 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem39 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem40 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem41 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem42 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem43 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem44 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem45 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem46 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem47 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem48 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem49 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem50 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem51 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem52 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem53 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem54 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem55 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem56 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem57 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem58 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem59 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem60 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem61 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem62 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem63 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem64 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem65 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem66 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem67 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem68 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem69 As System.Windows.Forms.MenuItem
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents MenuItem70 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem71 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem72 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem73 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem74 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem75 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem76 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem77 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem78 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem79 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem80 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem81 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem82 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem83 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem84 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem85 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem86 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem87 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem88 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem89 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem90 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem91 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem92 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem93 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem94 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem95 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem96 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem97 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem98 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem99 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem100 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem101 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem102 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem103 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem104 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem105 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem106 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem107 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem108 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem109 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem110 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem111 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem112 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem113 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem114 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem115 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem116 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem117 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem118 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem119 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem120 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem121 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem122 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem123 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem124 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem125 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem126 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem127 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem128 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem129 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem130 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem131 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem132 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem133 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem134 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem135 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem136 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem137 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem138 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem139 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem140 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem141 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem142 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem143 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem144 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem145 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem146 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem147 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem148 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem149 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem150 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem151 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem152 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem153 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem154 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem156 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem157 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem155 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem158 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem159 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem160 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem161 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem162 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem163 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem164 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ProcessModule))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem44 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.MenuItem42 = New System.Windows.Forms.MenuItem
        Me.MenuItem43 = New System.Windows.Forms.MenuItem
        Me.MenuItem45 = New System.Windows.Forms.MenuItem
        Me.MenuItem46 = New System.Windows.Forms.MenuItem
        Me.MenuItem47 = New System.Windows.Forms.MenuItem
        Me.MenuItem60 = New System.Windows.Forms.MenuItem
        Me.MenuItem61 = New System.Windows.Forms.MenuItem
        Me.MenuItem62 = New System.Windows.Forms.MenuItem
        Me.MenuItem24 = New System.Windows.Forms.MenuItem
        Me.MenuItem25 = New System.Windows.Forms.MenuItem
        Me.MenuItem26 = New System.Windows.Forms.MenuItem
        Me.MenuItem27 = New System.Windows.Forms.MenuItem
        Me.MenuItem28 = New System.Windows.Forms.MenuItem
        Me.MenuItem29 = New System.Windows.Forms.MenuItem
        Me.MenuItem30 = New System.Windows.Forms.MenuItem
        Me.MenuItem31 = New System.Windows.Forms.MenuItem
        Me.MenuItem32 = New System.Windows.Forms.MenuItem
        Me.MenuItem33 = New System.Windows.Forms.MenuItem
        Me.MenuItem34 = New System.Windows.Forms.MenuItem
        Me.MenuItem35 = New System.Windows.Forms.MenuItem
        Me.MenuItem36 = New System.Windows.Forms.MenuItem
        Me.MenuItem37 = New System.Windows.Forms.MenuItem
        Me.MenuItem38 = New System.Windows.Forms.MenuItem
        Me.MenuItem39 = New System.Windows.Forms.MenuItem
        Me.MenuItem40 = New System.Windows.Forms.MenuItem
        Me.MenuItem41 = New System.Windows.Forms.MenuItem
        Me.MenuItem67 = New System.Windows.Forms.MenuItem
        Me.MenuItem65 = New System.Windows.Forms.MenuItem
        Me.MenuItem66 = New System.Windows.Forms.MenuItem
        Me.MenuItem48 = New System.Windows.Forms.MenuItem
        Me.MenuItem49 = New System.Windows.Forms.MenuItem
        Me.MenuItem50 = New System.Windows.Forms.MenuItem
        Me.MenuItem63 = New System.Windows.Forms.MenuItem
        Me.MenuItem58 = New System.Windows.Forms.MenuItem
        Me.MenuItem59 = New System.Windows.Forms.MenuItem
        Me.MenuItem51 = New System.Windows.Forms.MenuItem
        Me.MenuItem52 = New System.Windows.Forms.MenuItem
        Me.MenuItem53 = New System.Windows.Forms.MenuItem
        Me.MenuItem56 = New System.Windows.Forms.MenuItem
        Me.MenuItem64 = New System.Windows.Forms.MenuItem
        Me.MenuItem54 = New System.Windows.Forms.MenuItem
        Me.MenuItem55 = New System.Windows.Forms.MenuItem
        Me.MenuItem57 = New System.Windows.Forms.MenuItem
        Me.MenuItem70 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem71 = New System.Windows.Forms.MenuItem
        Me.MenuItem72 = New System.Windows.Forms.MenuItem
        Me.MenuItem73 = New System.Windows.Forms.MenuItem
        Me.MenuItem74 = New System.Windows.Forms.MenuItem
        Me.MenuItem75 = New System.Windows.Forms.MenuItem
        Me.MenuItem76 = New System.Windows.Forms.MenuItem
        Me.MenuItem77 = New System.Windows.Forms.MenuItem
        Me.MenuItem78 = New System.Windows.Forms.MenuItem
        Me.MenuItem79 = New System.Windows.Forms.MenuItem
        Me.MenuItem80 = New System.Windows.Forms.MenuItem
        Me.MenuItem81 = New System.Windows.Forms.MenuItem
        Me.MenuItem82 = New System.Windows.Forms.MenuItem
        Me.MenuItem83 = New System.Windows.Forms.MenuItem
        Me.MenuItem84 = New System.Windows.Forms.MenuItem
        Me.MenuItem85 = New System.Windows.Forms.MenuItem
        Me.MenuItem86 = New System.Windows.Forms.MenuItem
        Me.MenuItem87 = New System.Windows.Forms.MenuItem
        Me.MenuItem88 = New System.Windows.Forms.MenuItem
        Me.MenuItem89 = New System.Windows.Forms.MenuItem
        Me.MenuItem90 = New System.Windows.Forms.MenuItem
        Me.MenuItem91 = New System.Windows.Forms.MenuItem
        Me.MenuItem92 = New System.Windows.Forms.MenuItem
        Me.MenuItem93 = New System.Windows.Forms.MenuItem
        Me.MenuItem94 = New System.Windows.Forms.MenuItem
        Me.MenuItem95 = New System.Windows.Forms.MenuItem
        Me.MenuItem96 = New System.Windows.Forms.MenuItem
        Me.MenuItem97 = New System.Windows.Forms.MenuItem
        Me.MenuItem98 = New System.Windows.Forms.MenuItem
        Me.MenuItem99 = New System.Windows.Forms.MenuItem
        Me.MenuItem100 = New System.Windows.Forms.MenuItem
        Me.MenuItem101 = New System.Windows.Forms.MenuItem
        Me.MenuItem102 = New System.Windows.Forms.MenuItem
        Me.MenuItem103 = New System.Windows.Forms.MenuItem
        Me.MenuItem104 = New System.Windows.Forms.MenuItem
        Me.MenuItem105 = New System.Windows.Forms.MenuItem
        Me.MenuItem106 = New System.Windows.Forms.MenuItem
        Me.MenuItem107 = New System.Windows.Forms.MenuItem
        Me.MenuItem108 = New System.Windows.Forms.MenuItem
        Me.MenuItem109 = New System.Windows.Forms.MenuItem
        Me.MenuItem110 = New System.Windows.Forms.MenuItem
        Me.MenuItem111 = New System.Windows.Forms.MenuItem
        Me.MenuItem112 = New System.Windows.Forms.MenuItem
        Me.MenuItem113 = New System.Windows.Forms.MenuItem
        Me.MenuItem114 = New System.Windows.Forms.MenuItem
        Me.MenuItem115 = New System.Windows.Forms.MenuItem
        Me.MenuItem116 = New System.Windows.Forms.MenuItem
        Me.MenuItem117 = New System.Windows.Forms.MenuItem
        Me.MenuItem118 = New System.Windows.Forms.MenuItem
        Me.MenuItem119 = New System.Windows.Forms.MenuItem
        Me.MenuItem120 = New System.Windows.Forms.MenuItem
        Me.MenuItem121 = New System.Windows.Forms.MenuItem
        Me.MenuItem122 = New System.Windows.Forms.MenuItem
        Me.MenuItem123 = New System.Windows.Forms.MenuItem
        Me.MenuItem124 = New System.Windows.Forms.MenuItem
        Me.MenuItem125 = New System.Windows.Forms.MenuItem
        Me.MenuItem126 = New System.Windows.Forms.MenuItem
        Me.MenuItem127 = New System.Windows.Forms.MenuItem
        Me.MenuItem128 = New System.Windows.Forms.MenuItem
        Me.MenuItem129 = New System.Windows.Forms.MenuItem
        Me.MenuItem130 = New System.Windows.Forms.MenuItem
        Me.MenuItem131 = New System.Windows.Forms.MenuItem
        Me.MenuItem132 = New System.Windows.Forms.MenuItem
        Me.MenuItem133 = New System.Windows.Forms.MenuItem
        Me.MenuItem134 = New System.Windows.Forms.MenuItem
        Me.MenuItem135 = New System.Windows.Forms.MenuItem
        Me.MenuItem136 = New System.Windows.Forms.MenuItem
        Me.MenuItem137 = New System.Windows.Forms.MenuItem
        Me.MenuItem138 = New System.Windows.Forms.MenuItem
        Me.MenuItem139 = New System.Windows.Forms.MenuItem
        Me.MenuItem140 = New System.Windows.Forms.MenuItem
        Me.MenuItem141 = New System.Windows.Forms.MenuItem
        Me.MenuItem151 = New System.Windows.Forms.MenuItem
        Me.MenuItem142 = New System.Windows.Forms.MenuItem
        Me.MenuItem143 = New System.Windows.Forms.MenuItem
        Me.MenuItem144 = New System.Windows.Forms.MenuItem
        Me.MenuItem145 = New System.Windows.Forms.MenuItem
        Me.MenuItem146 = New System.Windows.Forms.MenuItem
        Me.MenuItem161 = New System.Windows.Forms.MenuItem
        Me.MenuItem148 = New System.Windows.Forms.MenuItem
        Me.MenuItem160 = New System.Windows.Forms.MenuItem
        Me.MenuItem149 = New System.Windows.Forms.MenuItem
        Me.MenuItem155 = New System.Windows.Forms.MenuItem
        Me.MenuItem162 = New System.Windows.Forms.MenuItem
        Me.MenuItem150 = New System.Windows.Forms.MenuItem
        Me.MenuItem152 = New System.Windows.Forms.MenuItem
        Me.MenuItem153 = New System.Windows.Forms.MenuItem
        Me.MenuItem147 = New System.Windows.Forms.MenuItem
        Me.MenuItem154 = New System.Windows.Forms.MenuItem
        Me.MenuItem156 = New System.Windows.Forms.MenuItem
        Me.MenuItem157 = New System.Windows.Forms.MenuItem
        Me.MenuItem158 = New System.Windows.Forms.MenuItem
        Me.MenuItem159 = New System.Windows.Forms.MenuItem
        Me.MenuItem163 = New System.Windows.Forms.MenuItem
        Me.MenuItem164 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem68 = New System.Windows.Forms.MenuItem
        Me.MenuItem69 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label12 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.PanelMessageError = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label9 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.ModuleCompile = New System.Windows.Forms.TextBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Folder = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.DataSet31 = New BasicGL.DataSet3
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.DataSet41 = New BasicGL.DataSet4
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PanelMessageError.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataSet31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet41, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(656, 48)
        Me.Panel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(8, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 32)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Выполнить."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(200, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 32)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Сохранить как..."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(320, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Открыть как..."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(104, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Сохранить в базу."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(472, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Visual Basic"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(0, 458)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(656, 20)
        Me.Panel2.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.Location = New System.Drawing.Point(376, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(272, 16)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "(F3)Поиск   (F4)Настройка   (F12)Окно сообщений."
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(368, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Строка:"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.AcceptsTab = True
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.BackColor = System.Drawing.Color.White
        Me.RichTextBox1.ContextMenu = Me.ContextMenu1
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.RichTextBox1.ShowSelectionMargin = True
        Me.RichTextBox1.Size = New System.Drawing.Size(648, 224)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = "Imports System" & Microsoft.VisualBasic.ChrW(10) & "Imports System.Drawing" & Microsoft.VisualBasic.ChrW(10) & "Imports System.Collections" & Microsoft.VisualBasic.ChrW(10) & "Imports System.C" & _
        "omponentModel" & Microsoft.VisualBasic.ChrW(10) & "Imports System.Windows.Forms" & Microsoft.VisualBasic.ChrW(10) & "Imports Tao.Cg" & Microsoft.VisualBasic.ChrW(10) & "Imports Tao.DevIl" & Microsoft.VisualBasic.ChrW(10) & "Impo" & _
        "rts Tao.FreeGlut" & Microsoft.VisualBasic.ChrW(10) & "Imports Tao.Glfw" & Microsoft.VisualBasic.ChrW(10) & "Imports Tao.Ode" & Microsoft.VisualBasic.ChrW(10) & "Imports Tao.Sdl" & Microsoft.VisualBasic.ChrW(10) & "Imports Tao.Op" & _
        "enGl" & Microsoft.VisualBasic.ChrW(10) & "Imports Tao.Platform.Windows" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "Public Class MainClass" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Public Function main" & _
        "()" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "MessageBox.Show(""Компиляция выполнена!"")" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "End Function" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "End Class"
        Me.RichTextBox1.WordWrap = False
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem12, Me.MenuItem13, Me.MenuItem22, Me.MenuItem14, Me.MenuItem68, Me.MenuItem69, Me.MenuItem15, Me.MenuItem4, Me.MenuItem1, Me.MenuItem16, Me.MenuItem20, Me.MenuItem17, Me.MenuItem18, Me.MenuItem19, Me.MenuItem2})
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 0
        Me.MenuItem5.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem7, Me.MenuItem24, Me.MenuItem30, Me.MenuItem39, Me.MenuItem48, Me.MenuItem51, Me.MenuItem70, Me.MenuItem75, Me.MenuItem76, Me.MenuItem140})
        Me.MenuItem5.Text = "Вставить ШАБЛОН Visual Basic:"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 0
        Me.MenuItem7.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem8, Me.MenuItem44, Me.MenuItem9, Me.MenuItem10, Me.MenuItem21, Me.MenuItem23, Me.MenuItem42, Me.MenuItem43, Me.MenuItem45, Me.MenuItem46, Me.MenuItem47, Me.MenuItem60, Me.MenuItem61, Me.MenuItem62})
        Me.MenuItem7.Text = "Объявление переменных:"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 0
        Me.MenuItem8.Text = "Dim [Имя] As Integer"
        '
        'MenuItem44
        '
        Me.MenuItem44.Index = 1
        Me.MenuItem44.Text = "Dim [Имя] As Char"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 2
        Me.MenuItem9.Text = "Dim [Имя] As String"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 3
        Me.MenuItem10.Text = "Dim [Имя] As Double"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 4
        Me.MenuItem21.Text = "Dim [Имя] As Float"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 5
        Me.MenuItem23.Text = "Dim [Имя] As Single"
        '
        'MenuItem42
        '
        Me.MenuItem42.Index = 6
        Me.MenuItem42.Text = "-"
        '
        'MenuItem43
        '
        Me.MenuItem43.Index = 7
        Me.MenuItem43.Text = "Dim [Имя](10) As [Тип]"
        '
        'MenuItem45
        '
        Me.MenuItem45.Index = 8
        Me.MenuItem45.Text = "Dim [Имя2x2](20, 20) As [Тип]"
        '
        'MenuItem46
        '
        Me.MenuItem46.Index = 9
        Me.MenuItem46.Text = "Dim [Имя3x3](30, 30, 30) As [Тип]"
        '
        'MenuItem47
        '
        Me.MenuItem47.Index = 10
        Me.MenuItem47.Text = "Dim [Имя2x2]( , ) As [Тип]"
        '
        'MenuItem60
        '
        Me.MenuItem60.Index = 11
        Me.MenuItem60.Text = "-"
        '
        'MenuItem61
        '
        Me.MenuItem61.Index = 12
        Me.MenuItem61.Text = "Public [Имя] As [Тип]"
        '
        'MenuItem62
        '
        Me.MenuItem62.Index = 13
        Me.MenuItem62.Text = "Private [Имя] As [Тип]"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 1
        Me.MenuItem24.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem25, Me.MenuItem26, Me.MenuItem27, Me.MenuItem28, Me.MenuItem29})
        Me.MenuItem24.Text = "Условие:"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 0
        Me.MenuItem25.Text = "If ([Перем] = [Знач]) Then"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 1
        Me.MenuItem26.Text = "If ([Перем] = [Знач]) And ([Перем] = [Знач]) Or ([Перем] = [Знач]) Xor ([Перем] =" & _
        " [Знач]) Then"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 2
        Me.MenuItem27.Text = "ElseIf ([Перем] = [Знач]) Then"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 3
        Me.MenuItem28.Text = "Else"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 4
        Me.MenuItem29.Text = "End If"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 2
        Me.MenuItem30.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem31, Me.MenuItem32, Me.MenuItem33, Me.MenuItem34, Me.MenuItem35, Me.MenuItem36, Me.MenuItem37, Me.MenuItem38})
        Me.MenuItem30.Text = "Циклы:"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 0
        Me.MenuItem31.Text = "For [Перем] As Integer = [НачЗнач] To [КонЗнач]"
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 1
        Me.MenuItem32.Text = "Next"
        '
        'MenuItem33
        '
        Me.MenuItem33.Index = 2
        Me.MenuItem33.Text = "-"
        '
        'MenuItem34
        '
        Me.MenuItem34.Index = 3
        Me.MenuItem34.Text = "Do While [Выражение]"
        '
        'MenuItem35
        '
        Me.MenuItem35.Index = 4
        Me.MenuItem35.Text = "Loop"
        '
        'MenuItem36
        '
        Me.MenuItem36.Index = 5
        Me.MenuItem36.Text = "-"
        '
        'MenuItem37
        '
        Me.MenuItem37.Index = 6
        Me.MenuItem37.Text = "While [Выражение]"
        '
        'MenuItem38
        '
        Me.MenuItem38.Index = 7
        Me.MenuItem38.Text = "End While"
        '
        'MenuItem39
        '
        Me.MenuItem39.Index = 3
        Me.MenuItem39.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem40, Me.MenuItem41, Me.MenuItem67, Me.MenuItem65, Me.MenuItem66})
        Me.MenuItem39.Text = "Структура:"
        '
        'MenuItem40
        '
        Me.MenuItem40.Index = 0
        Me.MenuItem40.Text = "Public Structure [Имя]"
        '
        'MenuItem41
        '
        Me.MenuItem41.Index = 1
        Me.MenuItem41.Text = "End Structure"
        '
        'MenuItem67
        '
        Me.MenuItem67.Index = 2
        Me.MenuItem67.Text = "-"
        '
        'MenuItem65
        '
        Me.MenuItem65.Index = 3
        Me.MenuItem65.Text = "Private Structure [Имя]"
        '
        'MenuItem66
        '
        Me.MenuItem66.Index = 4
        Me.MenuItem66.Text = "End Structure"
        '
        'MenuItem48
        '
        Me.MenuItem48.Index = 4
        Me.MenuItem48.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem49, Me.MenuItem50, Me.MenuItem63, Me.MenuItem58, Me.MenuItem59})
        Me.MenuItem48.Text = "Классы:"
        '
        'MenuItem49
        '
        Me.MenuItem49.Index = 0
        Me.MenuItem49.Text = "Public Class [Имя]"
        '
        'MenuItem50
        '
        Me.MenuItem50.Index = 1
        Me.MenuItem50.Text = "End Class"
        '
        'MenuItem63
        '
        Me.MenuItem63.Index = 2
        Me.MenuItem63.Text = "-"
        '
        'MenuItem58
        '
        Me.MenuItem58.Index = 3
        Me.MenuItem58.Text = "Private Class [Имя]"
        '
        'MenuItem59
        '
        Me.MenuItem59.Index = 4
        Me.MenuItem59.Text = "End Class"
        '
        'MenuItem51
        '
        Me.MenuItem51.Index = 5
        Me.MenuItem51.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem52, Me.MenuItem53, Me.MenuItem56, Me.MenuItem64, Me.MenuItem54, Me.MenuItem55, Me.MenuItem57})
        Me.MenuItem51.Text = "Процедуры:"
        '
        'MenuItem52
        '
        Me.MenuItem52.Index = 0
        Me.MenuItem52.Text = "Public Sub [Имя](ByVal [ИмяПерем] As [Тип])"
        '
        'MenuItem53
        '
        Me.MenuItem53.Index = 1
        Me.MenuItem53.Text = "Public Sub [Имя](ByRaf [ИмяПерем] As [Тип])"
        '
        'MenuItem56
        '
        Me.MenuItem56.Index = 2
        Me.MenuItem56.Text = "End Sub"
        '
        'MenuItem64
        '
        Me.MenuItem64.Index = 3
        Me.MenuItem64.Text = "-"
        '
        'MenuItem54
        '
        Me.MenuItem54.Index = 4
        Me.MenuItem54.Text = "Private Sub [Имя](ByVal [ИмяПерем] As [Тип])"
        '
        'MenuItem55
        '
        Me.MenuItem55.Index = 5
        Me.MenuItem55.Text = "Private Sub [Имя](ByRaf [ИмяПерем] As [Тип])"
        '
        'MenuItem57
        '
        Me.MenuItem57.Index = 6
        Me.MenuItem57.Text = "End Sub"
        '
        'MenuItem70
        '
        Me.MenuItem70.Index = 6
        Me.MenuItem70.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem3, Me.MenuItem71, Me.MenuItem72, Me.MenuItem73, Me.MenuItem74})
        Me.MenuItem70.Text = "Функции:"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 0
        Me.MenuItem3.Text = "Public Function [Имя](ByVal [ИмяПерем] As [Тип], Optional ByVal [ИмяПерем] As Boo" & _
        "lean = True) As [ТипФункции]"
        '
        'MenuItem71
        '
        Me.MenuItem71.Index = 1
        Me.MenuItem71.Text = "End Function"
        '
        'MenuItem72
        '
        Me.MenuItem72.Index = 2
        Me.MenuItem72.Text = "-"
        '
        'MenuItem73
        '
        Me.MenuItem73.Index = 3
        Me.MenuItem73.Text = "Private Function [Имя](ByVal [ИмяПерем] As [Тип], Optional ByVal [ИмяПерем] As Bo" & _
        "olean = True) As [ТипФункции]"
        '
        'MenuItem74
        '
        Me.MenuItem74.Index = 4
        Me.MenuItem74.Text = "End Function"
        '
        'MenuItem75
        '
        Me.MenuItem75.Index = 7
        Me.MenuItem75.Text = "-"
        '
        'MenuItem76
        '
        Me.MenuItem76.Index = 8
        Me.MenuItem76.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem77, Me.MenuItem78, Me.MenuItem79, Me.MenuItem80, Me.MenuItem81, Me.MenuItem82, Me.MenuItem83, Me.MenuItem84, Me.MenuItem85, Me.MenuItem86, Me.MenuItem87, Me.MenuItem88, Me.MenuItem89, Me.MenuItem90, Me.MenuItem91, Me.MenuItem92, Me.MenuItem93, Me.MenuItem94, Me.MenuItem95, Me.MenuItem96, Me.MenuItem97, Me.MenuItem98, Me.MenuItem99, Me.MenuItem100, Me.MenuItem101, Me.MenuItem102, Me.MenuItem103, Me.MenuItem104, Me.MenuItem105, Me.MenuItem106, Me.MenuItem107, Me.MenuItem108, Me.MenuItem109, Me.MenuItem110, Me.MenuItem111, Me.MenuItem112, Me.MenuItem113, Me.MenuItem114, Me.MenuItem115, Me.MenuItem116, Me.MenuItem117, Me.MenuItem118, Me.MenuItem119, Me.MenuItem120, Me.MenuItem121, Me.MenuItem122, Me.MenuItem123, Me.MenuItem124, Me.MenuItem125, Me.MenuItem126, Me.MenuItem127, Me.MenuItem128, Me.MenuItem129, Me.MenuItem130, Me.MenuItem131, Me.MenuItem132, Me.MenuItem133, Me.MenuItem134, Me.MenuItem135, Me.MenuItem136, Me.MenuItem137, Me.MenuItem138, Me.MenuItem139})
        Me.MenuItem76.Text = "Окно (Форма) Свойства:"
        '
        'MenuItem77
        '
        Me.MenuItem77.Index = 0
        Me.MenuItem77.Text = "AcceptButton"
        '
        'MenuItem78
        '
        Me.MenuItem78.Index = 1
        Me.MenuItem78.Text = "AccessibleDescription"
        '
        'MenuItem79
        '
        Me.MenuItem79.Index = 2
        Me.MenuItem79.Text = "AccessibleName"
        '
        'MenuItem80
        '
        Me.MenuItem80.Index = 3
        Me.MenuItem80.Text = "AccessibleRole"
        '
        'MenuItem81
        '
        Me.MenuItem81.Index = 4
        Me.MenuItem81.Text = "Activate"
        '
        'MenuItem82
        '
        Me.MenuItem82.Index = 5
        Me.MenuItem82.Text = "ActivateMdiChild"
        '
        'MenuItem83
        '
        Me.MenuItem83.Index = 6
        Me.MenuItem83.Text = "ActiveControl"
        '
        'MenuItem84
        '
        Me.MenuItem84.Index = 7
        Me.MenuItem84.Text = "ActiveForm"
        '
        'MenuItem85
        '
        Me.MenuItem85.Index = 8
        Me.MenuItem85.Text = "ActiveMdiChild"
        '
        'MenuItem86
        '
        Me.MenuItem86.Index = 9
        Me.MenuItem86.Text = "AddOwnedForm"
        '
        'MenuItem87
        '
        Me.MenuItem87.Index = 10
        Me.MenuItem87.Text = "-"
        '
        'MenuItem88
        '
        Me.MenuItem88.Index = 11
        Me.MenuItem88.Text = "BackColor"
        '
        'MenuItem89
        '
        Me.MenuItem89.Index = 12
        Me.MenuItem89.Text = "BackgroundImage"
        '
        'MenuItem90
        '
        Me.MenuItem90.Index = 13
        Me.MenuItem90.Text = "-"
        '
        'MenuItem91
        '
        Me.MenuItem91.Index = 14
        Me.MenuItem91.Text = "CancelButton"
        '
        'MenuItem92
        '
        Me.MenuItem92.Index = 15
        Me.MenuItem92.Text = "ContextMenu"
        '
        'MenuItem93
        '
        Me.MenuItem93.Index = 16
        Me.MenuItem93.Text = "ControlBox"
        '
        'MenuItem94
        '
        Me.MenuItem94.Index = 17
        Me.MenuItem94.Text = "Controls"
        '
        'MenuItem95
        '
        Me.MenuItem95.Index = 18
        Me.MenuItem95.Text = "Cursor"
        '
        'MenuItem96
        '
        Me.MenuItem96.Index = 19
        Me.MenuItem96.Text = "-"
        '
        'MenuItem97
        '
        Me.MenuItem97.Index = 20
        Me.MenuItem97.Text = "Dock"
        '
        'MenuItem98
        '
        Me.MenuItem98.Index = 21
        Me.MenuItem98.Text = "Enabled"
        '
        'MenuItem99
        '
        Me.MenuItem99.Index = 22
        Me.MenuItem99.Text = "-"
        '
        'MenuItem100
        '
        Me.MenuItem100.Index = 23
        Me.MenuItem100.Text = "Font"
        '
        'MenuItem101
        '
        Me.MenuItem101.Index = 24
        Me.MenuItem101.Text = "FontHeight"
        '
        'MenuItem102
        '
        Me.MenuItem102.Index = 25
        Me.MenuItem102.Text = "ForeColor"
        '
        'MenuItem103
        '
        Me.MenuItem103.Index = 26
        Me.MenuItem103.Text = "FormBorderStyle"
        '
        'MenuItem104
        '
        Me.MenuItem104.Index = 27
        Me.MenuItem104.Text = "-"
        '
        'MenuItem105
        '
        Me.MenuItem105.Index = 28
        Me.MenuItem105.Text = "Handle"
        '
        'MenuItem106
        '
        Me.MenuItem106.Index = 29
        Me.MenuItem106.Text = "Height"
        '
        'MenuItem107
        '
        Me.MenuItem107.Index = 30
        Me.MenuItem107.Text = "HelpButton"
        '
        'MenuItem108
        '
        Me.MenuItem108.Index = 31
        Me.MenuItem108.Text = "HScroll"
        '
        'MenuItem109
        '
        Me.MenuItem109.Index = 32
        Me.MenuItem109.Text = "-"
        '
        'MenuItem110
        '
        Me.MenuItem110.Index = 33
        Me.MenuItem110.Text = "Icon"
        '
        'MenuItem111
        '
        Me.MenuItem111.Index = 34
        Me.MenuItem111.Text = "ImeMode"
        '
        'MenuItem112
        '
        Me.MenuItem112.Index = 35
        Me.MenuItem112.Text = "IsMdiContainer"
        '
        'MenuItem113
        '
        Me.MenuItem113.Index = 36
        Me.MenuItem113.Text = "-"
        '
        'MenuItem114
        '
        Me.MenuItem114.Index = 37
        Me.MenuItem114.Text = "KeyPreview"
        '
        'MenuItem115
        '
        Me.MenuItem115.Index = 38
        Me.MenuItem115.Text = "Left"
        '
        'MenuItem116
        '
        Me.MenuItem116.Index = 39
        Me.MenuItem116.Text = "Location"
        '
        'MenuItem117
        '
        Me.MenuItem117.Index = 40
        Me.MenuItem117.Text = "-"
        '
        'MenuItem118
        '
        Me.MenuItem118.Index = 41
        Me.MenuItem118.Text = "MaximizeBox"
        '
        'MenuItem119
        '
        Me.MenuItem119.Index = 42
        Me.MenuItem119.Text = "MdiChildren"
        '
        'MenuItem120
        '
        Me.MenuItem120.Index = 43
        Me.MenuItem120.Text = "MdiParent"
        '
        'MenuItem121
        '
        Me.MenuItem121.Index = 44
        Me.MenuItem121.Text = "Menu"
        '
        'MenuItem122
        '
        Me.MenuItem122.Index = 45
        Me.MenuItem122.Text = "MinimizeBox"
        '
        'MenuItem123
        '
        Me.MenuItem123.Index = 46
        Me.MenuItem123.Text = "-"
        '
        'MenuItem124
        '
        Me.MenuItem124.Index = 47
        Me.MenuItem124.Text = "Name"
        '
        'MenuItem125
        '
        Me.MenuItem125.Index = 48
        Me.MenuItem125.Text = "Opacity"
        '
        'MenuItem126
        '
        Me.MenuItem126.Index = 49
        Me.MenuItem126.Text = "ResizeRedraw"
        '
        'MenuItem127
        '
        Me.MenuItem127.Index = 50
        Me.MenuItem127.Text = "-"
        '
        'MenuItem128
        '
        Me.MenuItem128.Index = 51
        Me.MenuItem128.Text = "ShowInTaskbar"
        '
        'MenuItem129
        '
        Me.MenuItem129.Index = 52
        Me.MenuItem129.Text = "Size"
        '
        'MenuItem130
        '
        Me.MenuItem130.Index = 53
        Me.MenuItem130.Text = "Show()"
        '
        'MenuItem131
        '
        Me.MenuItem131.Index = 54
        Me.MenuItem131.Text = "-"
        '
        'MenuItem132
        '
        Me.MenuItem132.Index = 55
        Me.MenuItem132.Text = "Text"
        '
        'MenuItem133
        '
        Me.MenuItem133.Index = 56
        Me.MenuItem133.Text = "Top"
        '
        'MenuItem134
        '
        Me.MenuItem134.Index = 57
        Me.MenuItem134.Text = "TopMost"
        '
        'MenuItem135
        '
        Me.MenuItem135.Index = 58
        Me.MenuItem135.Text = "-"
        '
        'MenuItem136
        '
        Me.MenuItem136.Index = 59
        Me.MenuItem136.Text = "Visible"
        '
        'MenuItem137
        '
        Me.MenuItem137.Index = 60
        Me.MenuItem137.Text = "VScroll"
        '
        'MenuItem138
        '
        Me.MenuItem138.Index = 61
        Me.MenuItem138.Text = "Width"
        '
        'MenuItem139
        '
        Me.MenuItem139.Index = 62
        Me.MenuItem139.Text = "WindowState"
        '
        'MenuItem140
        '
        Me.MenuItem140.Index = 9
        Me.MenuItem140.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem141, Me.MenuItem151, Me.MenuItem142, Me.MenuItem143, Me.MenuItem144, Me.MenuItem145, Me.MenuItem146, Me.MenuItem161, Me.MenuItem148, Me.MenuItem160, Me.MenuItem149, Me.MenuItem155, Me.MenuItem162, Me.MenuItem150, Me.MenuItem152, Me.MenuItem153, Me.MenuItem147, Me.MenuItem154, Me.MenuItem156, Me.MenuItem157, Me.MenuItem158, Me.MenuItem159, Me.MenuItem163, Me.MenuItem164})
        Me.MenuItem140.Text = "Окно (Форма) Основные свойства"
        '
        'MenuItem141
        '
        Me.MenuItem141.Index = 0
        Me.MenuItem141.Text = "BackColor"
        '
        'MenuItem151
        '
        Me.MenuItem151.Index = 1
        Me.MenuItem151.Text = "Menu"
        '
        'MenuItem142
        '
        Me.MenuItem142.Index = 2
        Me.MenuItem142.Text = "ContextMenu"
        '
        'MenuItem143
        '
        Me.MenuItem143.Index = 3
        Me.MenuItem143.Text = "Cursor"
        '
        'MenuItem144
        '
        Me.MenuItem144.Index = 4
        Me.MenuItem144.Text = "Enabled"
        '
        'MenuItem145
        '
        Me.MenuItem145.Index = 5
        Me.MenuItem145.Text = "Font"
        '
        'MenuItem146
        '
        Me.MenuItem146.Index = 6
        Me.MenuItem146.Text = "FormBorderStyle"
        '
        'MenuItem161
        '
        Me.MenuItem161.Index = 7
        Me.MenuItem161.Text = "-"
        '
        'MenuItem148
        '
        Me.MenuItem148.Index = 8
        Me.MenuItem148.Text = "Height"
        '
        'MenuItem160
        '
        Me.MenuItem160.Index = 9
        Me.MenuItem160.Text = "Width"
        '
        'MenuItem149
        '
        Me.MenuItem149.Index = 10
        Me.MenuItem149.Text = "Left"
        '
        'MenuItem155
        '
        Me.MenuItem155.Index = 11
        Me.MenuItem155.Text = "Top"
        '
        'MenuItem162
        '
        Me.MenuItem162.Index = 12
        Me.MenuItem162.Text = "-"
        '
        'MenuItem150
        '
        Me.MenuItem150.Index = 13
        Me.MenuItem150.Text = "MaximizeBox"
        '
        'MenuItem152
        '
        Me.MenuItem152.Index = 14
        Me.MenuItem152.Text = "MinimizeBox"
        '
        'MenuItem153
        '
        Me.MenuItem153.Index = 15
        Me.MenuItem153.Text = "-"
        '
        'MenuItem147
        '
        Me.MenuItem147.Index = 16
        Me.MenuItem147.Text = "Handle"
        '
        'MenuItem154
        '
        Me.MenuItem154.Index = 17
        Me.MenuItem154.Text = "Name"
        '
        'MenuItem156
        '
        Me.MenuItem156.Index = 18
        Me.MenuItem156.Text = "Text"
        '
        'MenuItem157
        '
        Me.MenuItem157.Index = 19
        Me.MenuItem157.Text = "-"
        '
        'MenuItem158
        '
        Me.MenuItem158.Index = 20
        Me.MenuItem158.Text = "TopMost"
        '
        'MenuItem159
        '
        Me.MenuItem159.Index = 21
        Me.MenuItem159.Text = "Visible"
        '
        'MenuItem163
        '
        Me.MenuItem163.Index = 22
        Me.MenuItem163.Text = "-"
        '
        'MenuItem164
        '
        Me.MenuItem164.Index = 23
        Me.MenuItem164.Text = "Show()"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 1
        Me.MenuItem6.Text = "-"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 2
        Me.MenuItem11.Text = "Вставить                         Ctrl+V"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 3
        Me.MenuItem12.Text = "Копировать                    Ctrl+C"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 4
        Me.MenuItem13.Text = "Вырезать                        Ctrl+X"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 5
        Me.MenuItem22.Text = "Отменить                        Ctrl+Z"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 6
        Me.MenuItem14.Text = "-"
        '
        'MenuItem68
        '
        Me.MenuItem68.Index = 7
        Me.MenuItem68.Text = "Форматировать блок."
        '
        'MenuItem69
        '
        Me.MenuItem69.Index = 8
        Me.MenuItem69.Text = "-"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 9
        Me.MenuItem15.Text = "Настройка                       F4"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 10
        Me.MenuItem4.Text = "Окно поиска                    F3"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 11
        Me.MenuItem1.Text = "Окно сообщений             F12"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 12
        Me.MenuItem16.Text = "-"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 13
        Me.MenuItem20.Text = "Сохранить всё  в базу данных"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 14
        Me.MenuItem17.Text = "Сохранить файл как..."
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 15
        Me.MenuItem18.Text = "Открыть файл как..."
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 16
        Me.MenuItem19.Text = "-"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 17
        Me.MenuItem2.Text = "Выполнить."
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(0, 56)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(656, 400)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Controls.Add(Me.PanelMessageError)
        Me.TabPage1.Controls.Add(Me.RichTextBox1)
        Me.TabPage1.Controls.Add(Me.ModuleCompile)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(648, 371)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Программный модуль."
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(648, 368)
        Me.Panel3.TabIndex = 5
        Me.Panel3.Visible = False
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Label12.Location = New System.Drawing.Point(272, 168)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(232, 23)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Пожалуйста подождите..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(228, 168)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Label11.Location = New System.Drawing.Point(272, 192)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(360, 23)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "идет обработка строк:"
        '
        'PanelMessageError
        '
        Me.PanelMessageError.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelMessageError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelMessageError.Controls.Add(Me.GroupBox1)
        Me.PanelMessageError.Controls.Add(Me.ListBox1)
        Me.PanelMessageError.Controls.Add(Me.Panel4)
        Me.PanelMessageError.Controls.Add(Me.Button1)
        Me.PanelMessageError.Location = New System.Drawing.Point(0, 224)
        Me.PanelMessageError.Name = "PanelMessageError"
        Me.PanelMessageError.Size = New System.Drawing.Size(648, 144)
        Me.PanelMessageError.TabIndex = 3
        Me.PanelMessageError.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(645, 112)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Поиск по модулю:"
        Me.GroupBox1.Visible = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(560, 80)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Поиск"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Location = New System.Drawing.Point(8, 80)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(552, 20)
        Me.TextBox2.TabIndex = 0
        Me.TextBox2.Text = ""
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.BackColor = System.Drawing.Color.SeaShell
        Me.ListBox1.Location = New System.Drawing.Point(0, 24)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(648, 108)
        Me.ListBox1.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(568, 24)
        Me.Panel4.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(0, -5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 32)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Окно сообщений:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(568, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Закрыть."
        '
        'ModuleCompile
        '
        Me.ModuleCompile.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ModuleCompile.BackColor = System.Drawing.SystemColors.Info
        Me.ModuleCompile.Location = New System.Drawing.Point(264, 16)
        Me.ModuleCompile.Multiline = True
        Me.ModuleCompile.Name = "ModuleCompile"
        Me.ModuleCompile.Size = New System.Drawing.Size(328, 176)
        Me.ModuleCompile.TabIndex = 4
        Me.ModuleCompile.Text = ""
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.RichTextBox2)
        Me.TabPage2.Controls.Add(Me.CheckedListBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(648, 371)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Подключение внешних модулей."
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox2.BackColor = System.Drawing.Color.White
        Me.RichTextBox2.Location = New System.Drawing.Point(288, 0)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ReadOnly = True
        Me.RichTextBox2.Size = New System.Drawing.Size(352, 368)
        Me.RichTextBox2.TabIndex = 1
        Me.RichTextBox2.Text = ""
        Me.RichTextBox2.WordWrap = False
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckedListBox1.Location = New System.Drawing.Point(8, 0)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(280, 349)
        Me.CheckedListBox1.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TextBox1)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Folder)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.RichTextBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(648, 371)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Описание."
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(48, 8)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(544, 20)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = "Модуль"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 16)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Имя:"
        '
        'Folder
        '
        Me.Folder.Location = New System.Drawing.Point(48, 32)
        Me.Folder.Name = "Folder"
        Me.Folder.Size = New System.Drawing.Size(544, 21)
        Me.Folder.TabIndex = 2
        Me.Folder.Text = "..."
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 16)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Папка:"
        '
        'RichTextBox3
        '
        Me.RichTextBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox3.BackColor = System.Drawing.Color.White
        Me.RichTextBox3.Location = New System.Drawing.Point(8, 56)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.Size = New System.Drawing.Size(632, 312)
        Me.RichTextBox3.TabIndex = 0
        Me.RichTextBox3.Text = ""
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT Группа, Идентификатор, Модуль, Описание, СвязьСВнешнимиМодулями, Строка, Т" & _
        "ип FROM Модули"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Jet OLEDB:Database Password=;Data Source=""C:\Программирование\VB N" & _
        "ET\Cube Designer\Cube DesignerGL\Base\storage.mdb"";Password=;Jet OLEDB:Engine Ty" & _
        "pe=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet" & _
        " OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=ReadWrite;" & _
        "Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLED" & _
        "B:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=Fa" & _
        "lse;User ID=Admin;Jet OLEDB:Encrypt Database=False"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO Модули(Группа, Идентификатор, Модуль, Описание, СвязьСВнешнимиМодулям" & _
        "и, Тип) VALUES (?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Группа", System.Data.OleDb.OleDbType.VarWChar, 255, "Группа"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Идентификатор", System.Data.OleDb.OleDbType.VarWChar, 255, "Идентификатор"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Модуль", System.Data.OleDb.OleDbType.VarWChar, 0, "Модуль"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Описание", System.Data.OleDb.OleDbType.VarWChar, 0, "Описание"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("СвязьСВнешнимиМодулями", System.Data.OleDb.OleDbType.VarWChar, 0, "СвязьСВнешнимиМодулями"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Тип", System.Data.OleDb.OleDbType.VarWChar, 255, "Тип"))
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE Модули SET Группа = ?, Идентификатор = ?, Модуль = ?, Описание = ?, СвязьС" & _
        "ВнешнимиМодулями = ?, Тип = ? WHERE (Строка = ?) AND (Группа = ? OR ? IS NULL AN" & _
        "D Группа IS NULL) AND (Идентификатор = ? OR ? IS NULL AND Идентификатор IS NULL)" & _
        " AND (Тип = ? OR ? IS NULL AND Тип IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Группа", System.Data.OleDb.OleDbType.VarWChar, 255, "Группа"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Идентификатор", System.Data.OleDb.OleDbType.VarWChar, 255, "Идентификатор"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Модуль", System.Data.OleDb.OleDbType.VarWChar, 0, "Модуль"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Описание", System.Data.OleDb.OleDbType.VarWChar, 0, "Описание"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("СвязьСВнешнимиМодулями", System.Data.OleDb.OleDbType.VarWChar, 0, "СвязьСВнешнимиМодулями"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Тип", System.Data.OleDb.OleDbType.VarWChar, 255, "Тип"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Строка", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Строка", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Группа", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Группа", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Группа1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Группа", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Идентификатор", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Идентификатор", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Идентификатор1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Идентификатор", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Тип", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Тип", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Тип1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Тип", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM Модули WHERE (Строка = ?) AND (Группа = ? OR ? IS NULL AND Группа IS " & _
        "NULL) AND (Идентификатор = ? OR ? IS NULL AND Идентификатор IS NULL) AND (Тип = " & _
        "? OR ? IS NULL AND Тип IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Строка", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Строка", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Группа", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Группа", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Группа1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Группа", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Идентификатор", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Идентификатор", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Идентификатор1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Идентификатор", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Тип", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Тип", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Тип1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Тип", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Модули", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Группа", "Группа"), New System.Data.Common.DataColumnMapping("Идентификатор", "Идентификатор"), New System.Data.Common.DataColumnMapping("Модуль", "Модуль"), New System.Data.Common.DataColumnMapping("Описание", "Описание"), New System.Data.Common.DataColumnMapping("СвязьСВнешнимиМодулями", "СвязьСВнешнимиМодулями"), New System.Data.Common.DataColumnMapping("Строка", "Строка"), New System.Data.Common.DataColumnMapping("Тип", "Тип")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'DataSet31
        '
        Me.DataSet31.DataSetName = "DataSet3"
        Me.DataSet31.Locale = New System.Globalization.CultureInfo("ru-RU")
        '
        'DataSet41
        '
        Me.DataSet41.DataSetName = "DataSet4"
        Me.DataSet41.Locale = New System.Globalization.CultureInfo("ru-RU")
        '
        'ProcessModule
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(656, 478)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ProcessModule"
        Me.Text = "Модуль OpenGL:"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.PanelMessageError.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DataSet31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet41, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim ExtraClose As Boolean = False
    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Try
            ModuleCube.LoadFProcess()
            ModuleCube.FormProcess.MeShow = True
            'ModuleCube.FormProcess.MdiParent = ModuleCube.DesignerCube
            ModuleCube.FormProcess.Show()
            ModuleCube.FormProcess.Update()

            ModuleCompile.Text = ""
            For iRTB As Integer = 0 To RichTextBox1.Lines.Length - 1
                If (RichTextBox1.Lines.GetValue(iRTB) <> "End Class") Then
                    ModuleCompile.Text = ModuleCompile.Text + RichTextBox1.Lines.GetValue(iRTB) + System.Environment.NewLine
                Else
                    ModuleCube.FormProcess.Panel2.Width = 40
                    ModuleCube.FormProcess.Update()
                    'Загружаем внемние модули без классов
                    For iCh As Integer = 0 To CheckedListBox1.Items.Count - 1
                        If (CheckedListBox1.GetItemChecked(iCh) = True) Then
                            For iBase As Integer = 0 To DataSet41.Модули.Count - 1
                                If (DataSet41.Модули.Item(iBase)("Идентификатор") = CheckedListBox1.Items.Item(iCh)) Then
                                    RichTextBox2.Text = DataSet41.Модули.Item(iBase)("Модуль")
                                    Exit For
                                End If
                            Next
                            If (TestClass(RichTextBox2) = False) Then
                                ModuleCompile.Text = ModuleCompile.Text + "'/////// M O D U L E \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\" + System.Environment.NewLine
                                ModuleCompile.Text = ModuleCompile.Text + RichTextBox2.Text + System.Environment.NewLine
                            End If
                        End If
                        RichTextBox2.Clear()
                    Next
                End If
            Next

            ModuleCompile.Text = ModuleCompile.Text + "End Class" + System.Environment.NewLine

            ModuleCube.FormProcess.Panel2.Width = 80
            ModuleCube.FormProcess.Update()

            For iCh2 As Integer = 0 To CheckedListBox1.Items.Count - 1
                If (CheckedListBox1.GetItemChecked(iCh2) = True) Then
                    For iBase2 As Integer = 0 To DataSet41.Модули.Count - 1
                        If (DataSet41.Модули.Item(iBase2)("Идентификатор") = CheckedListBox1.Items.Item(iCh2)) Then
                            RichTextBox2.Text = DataSet41.Модули.Item(iBase2)("Модуль")
                            Exit For
                        End If
                    Next
                    If (TestClass(RichTextBox2) = True) Then
                        ModuleCompile.Text = ModuleCompile.Text + RichTextBox2.Text + System.Environment.NewLine
                    End If
                End If
                RichTextBox2.Clear()
            Next

            ModuleCube.FormProcess.Panel2.Width = 150
            ModuleCube.FormProcess.Update()

            Dim objCodeCompiler As System.CodeDom.Compiler.ICodeCompiler = New VBCodeProvider().CreateCompiler
            Dim objCompilerParameters As New System.CodeDom.Compiler.CompilerParameters
            objCompilerParameters.ReferencedAssemblies.Add("System.dll")
            objCompilerParameters.ReferencedAssemblies.Add("System.Windows.Forms.dll")
            objCompilerParameters.ReferencedAssemblies.Add("Microsoft.VisualBasic.dll")
            objCompilerParameters.ReferencedAssemblies.Add("Tao.OpenGl.dll")
            objCompilerParameters.ReferencedAssemblies.Add("Tao.Platform.Windows.dll")
            objCompilerParameters.ReferencedAssemblies.Add("Tao.FreeGlut.dll")
            objCompilerParameters.ReferencedAssemblies.Add("Tao.Cg.dll")
            objCompilerParameters.ReferencedAssemblies.Add("Tao.DevIl.dll")
            objCompilerParameters.ReferencedAssemblies.Add("Tao.Glfw.dll")
            objCompilerParameters.ReferencedAssemblies.Add("Tao.Ode.dll")
            objCompilerParameters.ReferencedAssemblies.Add("Tao.OpenAl.dll")
            objCompilerParameters.ReferencedAssemblies.Add("Tao.OpenGl.ExtensionLoader.dll")
            'objCompilerParameters.ReferencedAssemblies.Add("Tao.OpenGl.Glu.dll")
            objCompilerParameters.ReferencedAssemblies.Add("Tao.Sdl.dll")

            objCompilerParameters.GenerateInMemory = True

            Dim strCode As String = ModuleCompile.Text

            Dim objCompileResult As System.CodeDom.Compiler.CompilerResults = objCodeCompiler.CompileAssemblyFromSource(objCompilerParameters, strCode)

            'Обработка ошибок выполнения
            If (objCompileResult.Errors.HasErrors) Then
                ModuleCube.FormProcess.Close()
                GroupBox1.Visible = False
                PanelMessageError.Visible = True
                RichTextBox1.Height = TabControl1.Size.Height - PanelMessageError.Size.Height - 30
                ListBox1.Items.Clear()
                For iError As Integer = 0 To objCompileResult.Errors.Count - 1
                    ListBox1.Items.Add("Ошибка: строка> " + objCompileResult.Errors(iError).Line.ToString + " ; " + objCompileResult.Errors(iError).ErrorText)
                Next
                Dim ErrorSHOW As New ErrorModule
                ErrorSHOW.MdiParent = ModuleCube.DesignerCube
                ErrorSHOW.RichTextBox1.Text = ModuleCompile.Text
                ErrorSHOW.Show()
                ModuleCompile.Text = ""
                Exit Sub
            End If

            ModuleCube.FormProcess.Panel2.Width = 200
            ModuleCube.FormProcess.Update()

            Dim objAssembly As System.Reflection.Assembly = objCompileResult.CompiledAssembly
            Dim objTheClass As Object = objAssembly.CreateInstance("MainClass")
            If (objTheClass Is Nothing) Then
                ModuleCube.FormProcess.Close()
                GroupBox1.Visible = False
                PanelMessageError.Visible = True
                RichTextBox1.Height = TabControl1.Size.Height - PanelMessageError.Size.Height - 30
                ListBox1.Items.Clear()
                ListBox1.Items.Add("Ошибка: в теле главного модуля не обнаружен класс MainClass!!!")
                ModuleCompile.Text = ""
                Exit Sub
            End If

            ModuleCube.FormProcess.Panel2.Width = 230
            ModuleCube.FormProcess.Update()

            Try
                ModuleCube.FormProcess.Close()
                objTheClass.GetType.InvokeMember("main", Reflection.BindingFlags.InvokeMethod, Nothing, objTheClass, Nothing)
            Catch ex As Exception
                ModuleCube.FormProcess.Close()
                GroupBox1.Visible = False
                PanelMessageError.Visible = True
                RichTextBox1.Height = TabControl1.Size.Height - PanelMessageError.Size.Height - 30
                ListBox1.Items.Clear()
                ListBox1.Items.Add("Ошибка: в теле главного модуля не обнаружена функция CodeBegin!!!")
                ModuleCompile.Text = ""
            End Try

            objCodeCompiler = Nothing
            objCompilerParameters = Nothing
            strCode = Nothing
            objCompileResult = Nothing
            objAssembly = Nothing
            objTheClass = Nothing
            ModuleCompile.Text = ""
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Public ActionModuleName As String
    Public ActionID As Integer
    Private Sub ProcessModule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Загрузка информации из базы данных
        Try
            OleDbConnection1.ConnectionString = ModuleBase.StringConnection1 + ModuleBase.PathBase + ModuleBase.StringConnection2 + ModuleBase.StringConnection3 + ModuleBase.StringConnection4
            OleDbConnection1.Open()
            Dim FolderAction As String
            If (Me.Text = "Модуль OpenGL: Новый модуль.") Then
                OleDbDataAdapter1.Fill(DataSet31, "Модули")
                OleDbDataAdapter1.Fill(DataSet41, "Модули")
                CheckedListBox1.Items.Clear()
                For i As Integer = 0 To DataSet31.Модули.Count - 1
                    If (DataSet31.Модули.Item(i)("Тип") = "Группа") Then
                        Folder.Items.Add(DataSet31.Модули.Item(i)("Идентификатор"))
                        FolderAction = DataSet31.Модули.Item(i)("Идентификатор")
                    Else
                        For iEl As Integer = 0 To DataSet41.Модули.Count - 1
                            If (DataSet41.Модули.Item(iEl)("Тип") = "Элемент") And (DataSet41.Модули.Item(iEl)("Группа") = FolderAction) Then
                                CheckedListBox1.Items.Add(DataSet41.Модули.Item(iEl)("Идентификатор"))
                            End If
                        Next
                        FolderAction = ""
                    End If
                Next
            End If
            If (Me.Text = "Модуль OpenGL: Редактировать.") Then
                Dim SQLComand As String
                OleDbDataAdapter1.Fill(DataSet31, "Модули")
                OleDbDataAdapter1.Fill(DataSet41, "Модули")
                CheckedListBox1.Items.Clear()
                For i As Integer = 0 To DataSet31.Модули.Count - 1
                    If (DataSet31.Модули.Item(i)("Тип") = "Группа") Then
                        Folder.Items.Add(DataSet31.Модули.Item(i)("Идентификатор"))
                        FolderAction = DataSet31.Модули.Item(i)("Идентификатор")
                    Else
                        For iEl As Integer = 0 To DataSet41.Модули.Count - 1
                            If (DataSet41.Модули.Item(iEl)("Тип") = "Элемент") And (DataSet41.Модули.Item(iEl)("Группа") = FolderAction) Then
                                CheckedListBox1.Items.Add(DataSet41.Модули.Item(iEl)("Идентификатор"))
                            End If
                        Next
                        FolderAction = ""
                    End If
                Next
                DataSet31.Clear()
                'DataSet41.Clear()
                SQLComand = "SELECT Группа, Идентификатор, Модуль, Описание, СвязьСВнешнимиМодулями, Строка, Тип FROM Модули WHERE (Идентификатор = '" + ActionModuleName + "')"
                OleDbDataAdapter1.SelectCommand.CommandText = SQLComand
                OleDbDataAdapter1.Fill(DataSet31, "Модули")
                'OleDbDataAdapter1.Fill(DataSet41, "Модули")
                If (DataSet31.Модули.Item(0)("Тип") = "Элемент") Then
                    RichTextBox1.Text = DataSet31.Модули.Item(0)("Модуль")
                    TextBox1.Text = DataSet31.Модули.Item(0)("Идентификатор")
                    Folder.Text = DataSet31.Модули.Item(0)("Группа")
                    RichTextBox3.Text = DataSet31.Модули.Item(0)("Описание")
                    RichTextBox2.Text = DataSet31.Модули.Item(0)("СвязьСВнешнимиМодулями")
                    For iLink As Integer = 0 To RichTextBox2.Lines.Length - 1
                        For iActionLink As Integer = 0 To CheckedListBox1.Items.Count - 1
                            If (RichTextBox2.Lines.GetValue(iLink) = CheckedListBox1.Items.Item(iActionLink)) Then
                                CheckedListBox1.SetItemChecked(iActionLink, True)
                            End If
                        Next
                    Next
                    RichTextBox2.Clear()
                    ActionID = DataSet31.Модули.Item(0)("Строка")
                Else
                    MsgBox("Ошибка!!! " + "[" + ActionModuleName + "] не является модулем!", MsgBoxStyle.OKOnly, "Сообщение:")
                    ExtraClose = True
                End If
            End If
            OleDbConnection1.Close()
            RichTextBox1.Height = TabControl1.Size.Height - 30
            RichTextBox1.Font = ModuleCube.FontModule
            If (ModuleCube.ActionModuleFormat = True) Then
                Panel3.Visible = True
            End If
            'Departs("Public")
            'Departs("Private")
            'Departs("End")
            'Departs("Class")
            'Departs("Function")
            'Departs("Sub")
            'Departs("Dim")
            'Departs("If")
            'Departs("As")
            'Departs("Then")
            'Departs("Integer")
            'Departs("String")
            'Departs("Boolean")
            'Departs("For")
            'Departs("Do")
            'Departs("Loop")
            'Panel3.Visible = False
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Function TestClass(ByVal ModuleCode As RichTextBox) As Boolean
        Try
            Dim FindClass As Boolean = False
            If (ModuleCode.Find("Public Class", RichTextBoxFinds.MatchCase) > 0) Then
                FindClass = True
            Else
                FindClass = False
            End If
            If (FindClass = False) Then
                If (ModuleCode.Find("Private Class", RichTextBoxFinds.MatchCase) > 0) Then
                    FindClass = True
                Else
                    FindClass = False
                End If
            End If
            ModuleCode.SelectionStart = 0
            ModuleCode.SelectionLength = 0
            Return FindClass
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Function

    Private Sub Departs()
        Panel3.Visible = True
        Panel3.Update()
        Me.Update()
        Dim Coment As Boolean = False
        Dim StringLine As String
        Dim Operator As String
        Dim CharIndexStart As Integer = 0
        Dim CharIndexEnd As Integer = 0
        For iLine As Integer = 0 To RichTextBox1.Lines.Length - 1 'Строки
            Label11.Text = "идет обработка строк: " + iLine.ToString
            Label11.Update()
            Coment = False
            StringLine = RichTextBox1.Lines.GetValue(iLine)
            For iChar As Integer = 0 To StringLine.Length - 1 'Символы
                CharIndexEnd = CharIndexEnd + 1
                If (StringLine.Chars(iChar) = "'") Then
                    Coment = True
                    RichTextBox1.SelectionStart = CharIndexEnd - 1
                    RichTextBox1.SelectionLength = StringLine.Length - iChar
                    RichTextBox1.SelectionColor = Color.Green
                End If
                If (Coment = False) Then
                    Dim KayTAB As System.Windows.Forms.KeyEventArgs
                    If (StringLine.Chars(iChar) = " ") Or (Asc(StringLine.Chars(iChar)) = KayTAB.KeyData.Tab) Then
                        If (Operator = "Imports") Or (Operator = "imports") Then
                            RichTextBox1.SelectionStart = CharIndexStart
                            RichTextBox1.SelectionLength = 7
                            RichTextBox1.SelectionColor = Color.Blue
                        End If
                        If (Operator = "New") Or (Operator = "new") Then
                            RichTextBox1.SelectionStart = CharIndexStart
                            RichTextBox1.SelectionLength = 3
                            RichTextBox1.SelectionColor = Color.Blue
                        End If
                        If (Operator = "Dim") Or (Operator = "dim") Then
                            RichTextBox1.SelectionStart = CharIndexStart
                            RichTextBox1.SelectionLength = 3
                            RichTextBox1.SelectionColor = Color.Blue
                        End If
                        If (Operator = "As") Or (Operator = "as") Then
                            RichTextBox1.SelectionStart = CharIndexStart
                            RichTextBox1.SelectionLength = 2
                            RichTextBox1.SelectionColor = Color.Blue
                        End If
                        If (Operator = "If") Or (Operator = "if") Or (Operator = "IF") Then
                            RichTextBox1.SelectionStart = CharIndexStart
                            RichTextBox1.SelectionLength = 2
                            RichTextBox1.SelectionColor = Color.Blue
                        End If
                        If (Operator = "Then") Or (Operator = "then") Then
                            RichTextBox1.SelectionStart = CharIndexStart
                            RichTextBox1.SelectionLength = 4
                            RichTextBox1.SelectionColor = Color.Blue
                        End If
                        If (Operator = "End") Or (Operator = "end") Then
                            RichTextBox1.SelectionStart = CharIndexStart
                            RichTextBox1.SelectionLength = 3
                            RichTextBox1.SelectionColor = Color.Blue
                        End If
                        If (Operator = "Private") Or (Operator = "private") Then
                            RichTextBox1.SelectionStart = CharIndexStart
                            RichTextBox1.SelectionLength = 7
                            RichTextBox1.SelectionColor = Color.Blue
                        End If
                        If (Operator = "Public") Or (Operator = "public") Then
                            RichTextBox1.SelectionStart = CharIndexStart
                            RichTextBox1.SelectionLength = 6
                            RichTextBox1.SelectionColor = Color.Blue
                        End If
                        If (Operator = "Sub") Or (Operator = "sub") Then
                            RichTextBox1.SelectionStart = CharIndexStart
                            RichTextBox1.SelectionLength = 3
                            RichTextBox1.SelectionColor = Color.Blue
                        End If
                        If (Operator = "Function") Or (Operator = "function") Then
                            RichTextBox1.SelectionStart = CharIndexStart
                            RichTextBox1.SelectionLength = 8
                            RichTextBox1.SelectionColor = Color.Blue
                        End If
                        If (Operator = "And") Or (Operator = "and") Then
                            RichTextBox1.SelectionStart = CharIndexStart
                            RichTextBox1.SelectionLength = 3
                            RichTextBox1.SelectionColor = Color.Blue
                        End If
                        If (Operator = "Or") Or (Operator = "or") Then
                            RichTextBox1.SelectionStart = CharIndexStart
                            RichTextBox1.SelectionLength = 2
                            RichTextBox1.SelectionColor = Color.Blue
                        End If
                        If (Operator = "Xor") Or (Operator = "xor") Then
                            RichTextBox1.SelectionStart = CharIndexStart
                            RichTextBox1.SelectionLength = 3
                            RichTextBox1.SelectionColor = Color.Blue
                        End If
                        If (Operator = "True") Or (Operator = "true") Then
                            RichTextBox1.SelectionStart = CharIndexStart
                            RichTextBox1.SelectionLength = 4
                            RichTextBox1.SelectionColor = Color.Blue
                        End If
                        If (Operator = "False") Or (Operator = "false") Then
                            RichTextBox1.SelectionStart = CharIndexStart
                            RichTextBox1.SelectionLength = 5
                            RichTextBox1.SelectionColor = Color.Blue
                        End If
                        If (Operator = "String") Or (Operator = "string") Then
                            RichTextBox1.SelectionStart = CharIndexStart
                            RichTextBox1.SelectionLength = 6
                            RichTextBox1.SelectionColor = Color.Blue
                        End If
                        If (Operator = "Integer") Or (Operator = "integer") Then
                            RichTextBox1.SelectionStart = CharIndexStart
                            RichTextBox1.SelectionLength = 7
                            RichTextBox1.SelectionColor = Color.Blue
                        End If
                        If (Operator = "Boolean") Or (Operator = "boolean") Then
                            RichTextBox1.SelectionStart = CharIndexStart
                            RichTextBox1.SelectionLength = 7
                            RichTextBox1.SelectionColor = Color.Blue
                        End If
                        If (Operator = "For") Or (Operator = "for") Then
                            RichTextBox1.SelectionStart = CharIndexStart
                            RichTextBox1.SelectionLength = 3
                            RichTextBox1.SelectionColor = Color.Blue
                        End If
                        If (Operator = "Next") Or (Operator = "next") Then
                            RichTextBox1.SelectionStart = CharIndexStart
                            RichTextBox1.SelectionLength = 4
                            RichTextBox1.SelectionColor = Color.Blue
                        End If
                        If (Operator = "While") Or (Operator = "while") Then
                            RichTextBox1.SelectionStart = CharIndexStart
                            RichTextBox1.SelectionLength = 5
                            RichTextBox1.SelectionColor = Color.Blue
                        End If
                        If (Operator = "Do") Or (Operator = "do") Then
                            RichTextBox1.SelectionStart = CharIndexStart
                            RichTextBox1.SelectionLength = 2
                            RichTextBox1.SelectionColor = Color.Blue
                        End If
                        If (Operator = "To") Or (Operator = "to") Then
                            RichTextBox1.SelectionStart = CharIndexStart
                            RichTextBox1.SelectionLength = 2
                            RichTextBox1.SelectionColor = Color.Blue
                        End If
                        If (Operator = "Loop") Or (Operator = "loop") Then
                            RichTextBox1.SelectionStart = CharIndexStart
                            RichTextBox1.SelectionLength = 4
                            RichTextBox1.SelectionColor = Color.Blue
                        End If
                        If (Operator = "Structure") Or (Operator = "structure") Then
                            RichTextBox1.SelectionStart = CharIndexStart
                            RichTextBox1.SelectionLength = 9
                            RichTextBox1.SelectionColor = Color.Blue
                        End If
                        If (Operator = "Class") Or (Operator = "class") Then
                            RichTextBox1.SelectionStart = CharIndexStart
                            RichTextBox1.SelectionLength = 5
                            RichTextBox1.SelectionColor = Color.Blue
                        End If
                        Operator = ""
                        CharIndexStart = CharIndexEnd
                    Else
                        Operator = Operator + StringLine.Chars(iChar)
                    End If
                End If
            Next
            CharIndexEnd = CharIndexEnd + 1
            If (Coment = False) Then
                If (Operator = "Imports") Or (Operator = "imports") Then
                    RichTextBox1.SelectionStart = CharIndexStart
                    RichTextBox1.SelectionLength = 7
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (Operator = "New") Or (Operator = "new") Then
                    RichTextBox1.SelectionStart = CharIndexStart
                    RichTextBox1.SelectionLength = 3
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (Operator = "Dim") Or (Operator = "dim") Then
                    RichTextBox1.SelectionStart = CharIndexStart
                    RichTextBox1.SelectionLength = 3
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (Operator = "As") Or (Operator = "as") Then
                    RichTextBox1.SelectionStart = CharIndexStart
                    RichTextBox1.SelectionLength = 2
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (Operator = "If") Or (Operator = "if") Or (Operator = "IF") Then
                    RichTextBox1.SelectionStart = CharIndexStart
                    RichTextBox1.SelectionLength = 2
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (Operator = "Then") Or (Operator = "then") Then
                    RichTextBox1.SelectionStart = CharIndexStart
                    RichTextBox1.SelectionLength = 4
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (Operator = "End") Or (Operator = "end") Then
                    RichTextBox1.SelectionStart = CharIndexStart
                    RichTextBox1.SelectionLength = 3
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (Operator = "Private") Or (Operator = "private") Then
                    RichTextBox1.SelectionStart = CharIndexStart
                    RichTextBox1.SelectionLength = 7
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (Operator = "Public") Or (Operator = "public") Then
                    RichTextBox1.SelectionStart = CharIndexStart
                    RichTextBox1.SelectionLength = 6
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (Operator = "Sub") Or (Operator = "sub") Then
                    RichTextBox1.SelectionStart = CharIndexStart
                    RichTextBox1.SelectionLength = 3
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (Operator = "Function") Or (Operator = "function") Then
                    RichTextBox1.SelectionStart = CharIndexStart
                    RichTextBox1.SelectionLength = 8
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (Operator = "And") Or (Operator = "and") Then
                    RichTextBox1.SelectionStart = CharIndexStart
                    RichTextBox1.SelectionLength = 3
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (Operator = "Or") Or (Operator = "or") Then
                    RichTextBox1.SelectionStart = CharIndexStart
                    RichTextBox1.SelectionLength = 2
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (Operator = "Xor") Or (Operator = "xor") Then
                    RichTextBox1.SelectionStart = CharIndexStart
                    RichTextBox1.SelectionLength = 3
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (Operator = "True") Or (Operator = "true") Then
                    RichTextBox1.SelectionStart = CharIndexStart
                    RichTextBox1.SelectionLength = 4
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (Operator = "False") Or (Operator = "false") Then
                    RichTextBox1.SelectionStart = CharIndexStart
                    RichTextBox1.SelectionLength = 5
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (Operator = "String") Or (Operator = "string") Then
                    RichTextBox1.SelectionStart = CharIndexStart
                    RichTextBox1.SelectionLength = 6
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (Operator = "Integer") Or (Operator = "integer") Then
                    RichTextBox1.SelectionStart = CharIndexStart
                    RichTextBox1.SelectionLength = 7
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (Operator = "Boolean") Or (Operator = "boolean") Then
                    RichTextBox1.SelectionStart = CharIndexStart
                    RichTextBox1.SelectionLength = 7
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (Operator = "For") Or (Operator = "for") Then
                    RichTextBox1.SelectionStart = CharIndexStart
                    RichTextBox1.SelectionLength = 3
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (Operator = "Next") Or (Operator = "next") Then
                    RichTextBox1.SelectionStart = CharIndexStart
                    RichTextBox1.SelectionLength = 4
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (Operator = "While") Or (Operator = "while") Then
                    RichTextBox1.SelectionStart = CharIndexStart
                    RichTextBox1.SelectionLength = 5
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (Operator = "Do") Or (Operator = "do") Then
                    RichTextBox1.SelectionStart = CharIndexStart
                    RichTextBox1.SelectionLength = 2
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (Operator = "To") Or (Operator = "to") Then
                    RichTextBox1.SelectionStart = CharIndexStart
                    RichTextBox1.SelectionLength = 2
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (Operator = "Loop") Or (Operator = "loop") Then
                    RichTextBox1.SelectionStart = CharIndexStart
                    RichTextBox1.SelectionLength = 4
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (Operator = "Structure") Or (Operator = "structure") Then
                    RichTextBox1.SelectionStart = CharIndexStart
                    RichTextBox1.SelectionLength = 9
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (Operator = "Class") Or (Operator = "class") Then
                    RichTextBox1.SelectionStart = CharIndexStart
                    RichTextBox1.SelectionLength = 5
                    RichTextBox1.SelectionColor = Color.Blue
                End If
            End If
            Operator = ""
            CharIndexStart = CharIndexEnd
        Next
        RichTextBox1.SelectionStart = 0
        RichTextBox1.SelectionLength = 0
        RichTextBox1.SelectionColor = Color.Black
        Me.Update()
        Panel3.Update()
        Panel3.Visible = False
    End Sub

    Private Sub DepartsFail(ByVal DepartWord As String)
        Try
            Dim LastMyFind As Long = 0
            Dim IndexFind As Long = 0

            While LastMyFind > -1
                If (RichTextBox1.Find(DepartWord, IndexFind, RichTextBox1.TextLength - 1, RichTextBoxFinds.WholeWord)) Then
                    RichTextBox1.Select()
                    RichTextBox1.SelectionColor = Color.Blue
                    IndexFind = RichTextBox1.SelectionStart + RichTextBox1.SelectionLength
                    If (LastMyFind = RichTextBox1.SelectionStart) Then
                        IndexFind = 0
                        LastMyFind = -1
                        RichTextBox1.SelectionStart = 0
                        RichTextBox1.SelectionLength = 0
                        Exit Sub
                    Else
                        If (LastMyFind < RichTextBox1.SelectionStart) Then
                            LastMyFind = RichTextBox1.SelectionStart
                        Else
                            IndexFind = 0
                            LastMyFind = -1
                            RichTextBox1.SelectionStart = 0
                            RichTextBox1.SelectionLength = 0
                            Exit Sub
                        End If
                    End If
                End If
            End While
            RichTextBox1.SelectionStart = 0
            RichTextBox1.SelectionLength = 0
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        Try
            For i As Integer = 0 To DataSet41.Модули.Count - 1
                If (DataSet41.Модули.Item(i)("Идентификатор") = CheckedListBox1.Items.Item(CheckedListBox1.SelectedIndex)) Then
                    RichTextBox2.Text = DataSet41.Модули.Item(i)("Модуль")
                End If
            Next
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Try
            If (Me.Text = "Модуль OpenGL: Новый модуль.") Then
                Dim FolderFind As Boolean = False
                Dim NameModul As String
                Dim ModulePolitic As Boolean = True
                For iFolder As Integer = 0 To Folder.Items.Count - 1
                    If (Folder.Text = Folder.Items.Item(iFolder)) Then FolderFind = True
                Next
                If (FolderFind = True) Then
                    If (TextBox1.Text = "Модуль") Or (TextBox1.Text = "") Then
                        NameModul = InputBox("Введите имя модуля.", "Новый модуль:", "")
                    Else
                        NameModul = TextBox1.Text
                    End If
                    If (NameModul <> "") Then
                        For i As Integer = 0 To DataSet31.Модули.Count - 1
                            If (DataSet31.Модули.Item(i)("Идентификатор") = NameModul) Then
                                ModulePolitic = False
                                MsgBox("Ошибка: модуль с таким именем уже существует!!!.", MsgBoxStyle.OKOnly, "Сообщение:")
                                Label2.BorderStyle = BorderStyle.None
                            End If
                        Next
                    Else
                        ModulePolitic = False
                        Label2.BorderStyle = BorderStyle.None
                    End If
                    'Сохраняем данные
                    If (ModulePolitic = True) Then
                        OleDbConnection1.Open()
                        Dim DT As DataTable = DataSet31.Модули
                        Dim row As DataRow
                        row = DT.NewRow
                        row("Тип") = "Элемент"
                        If (Folder.Text <> "") Then
                            row("Группа") = Folder.Text
                        Else
                            MsgBox("Вы не выбрали папку в которую нужно сохранить модуль.", MsgBoxStyle.OKOnly, "Сообщение:")
                            Exit Sub
                        End If
                        row("Идентификатор") = NameModul
                        row("Модуль") = RichTextBox1.Text
                        RichTextBox2.Clear()
                        RichTextBox2.Text = "Подключенные модули:"
                        For iCh As Integer = 0 To CheckedListBox1.Items.Count - 1
                            If (CheckedListBox1.GetItemChecked(iCh) = True) Then
                                RichTextBox2.Text = RichTextBox2.Text + System.Environment.NewLine + CheckedListBox1.Items.Item(iCh)
                            End If
                        Next
                        row("СвязьСВнешнимиМодулями") = RichTextBox2.Text
                        RichTextBox2.Clear()
                        row("Описание") = RichTextBox3.Text
                        DT.Rows.Add(row)
                        OleDbDataAdapter1.Update(DataSet31, "Модули")
                        OleDbConnection1.Close()
                        ModuleCube.DesignerCube.TREE_UPDATE()
                        MsgBox("Сохранение прошло успешно." + System.Environment.NewLine + "Модуль будет автоматически закрыт.", MsgBoxStyle.OKOnly, "Сообщение:")
                        Close()
                    End If
                Else
                    MsgBox("Папка не найдена! Проверте имя папки в которую нужно сохранить модуль.", MsgBoxStyle.OKOnly, "Сообщение:")
                    Label2.BorderStyle = BorderStyle.None
                End If
            End If
            If (Me.Text = "Модуль OpenGL: Редактировать.") Then
                Dim FolderFind As Boolean = False
                Dim NameModul As String
                Dim ModulePolitic As Boolean = True
                For iFolder As Integer = 0 To Folder.Items.Count - 1
                    If (Folder.Text = Folder.Items.Item(iFolder)) Then FolderFind = True
                Next
                If (FolderFind = True) Then
                    If (TextBox1.Text = "Модуль") Or (TextBox1.Text = "") Then
                        NameModul = InputBox("Введите имя модуля.", "Новый модуль:", "")
                    Else
                        NameModul = TextBox1.Text
                    End If
                    If (NameModul <> "") Then 'проверка уникальности имени модуля
                        For i As Integer = 0 To DataSet41.Модули.Count - 1
                            If (DataSet41.Модули.Item(i)("Идентификатор") = NameModul) And (DataSet41.Модули.Item(i)("Строка") <> ActionID) Then
                                ModulePolitic = False
                                MsgBox("Ошибка: модуль с таким именем уже существует!!!.", MsgBoxStyle.OKOnly, "Сообщение:")
                                Label2.BorderStyle = BorderStyle.None
                            End If
                        Next
                    Else
                        ModulePolitic = False
                        Label2.BorderStyle = BorderStyle.None
                    End If
                    'Сохраняем данные
                    If (ModulePolitic = True) Then
                        OleDbConnection1.Open()

                        DataSet31.Модули.Item(0)("Модуль") = RichTextBox1.Text
                        DataSet31.Модули.Item(0)("Идентификатор") = NameModul
                        If (Folder.Text <> "") Then
                            DataSet31.Модули.Item(0)("Группа") = Folder.Text
                        Else
                            MsgBox("Вы не выбрали папку в которую нужно сохранить модуль.", MsgBoxStyle.OKOnly, "Сообщение:")
                            Exit Sub
                        End If
                        DataSet31.Модули.Item(0)("Описание") = RichTextBox3.Text
                        RichTextBox2.Clear()
                        RichTextBox2.Text = "Подключенные модули:"
                        For iCh As Integer = 0 To CheckedListBox1.Items.Count - 1
                            If (CheckedListBox1.GetItemChecked(iCh) = True) Then
                                RichTextBox2.Text = RichTextBox2.Text + System.Environment.NewLine + CheckedListBox1.Items.Item(iCh)
                            End If
                        Next
                        DataSet31.Модули.Item(0)("СвязьСВнешнимиМодулями") = RichTextBox2.Text
                        RichTextBox2.Clear()

                        OleDbDataAdapter1.Update(DataSet31, "Модули")
                        OleDbConnection1.Close()
                        ModuleCube.DesignerCube.TREE_UPDATE()
                        MsgBox("Сохранение прошло успешно.", MsgBoxStyle.OKOnly, "Сообщение:")
                    End If

                Else
                    MsgBox("Папка не найдена! Проверте имя папки в которую нужно сохранить модуль.", MsgBoxStyle.OKOnly, "Сообщение:")
                    Label2.BorderStyle = BorderStyle.None
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
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

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Try
            Dim OpenFile As New FileManager
            OpenFile.Text = "Открыть файл как..."
            OpenFile.Button1.Text = "Открыть."
            OpenFile.MdiParent = ModuleCube.DesignerCube.ActiveForm
            OpenFile.Show()
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
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
            Dim SaveFile As New FileManager
            SaveFile.Text = "Сохранить файл как..."
            SaveFile.Button1.Text = "Сохранить."
            SaveFile.MdiParent = ModuleCube.DesignerCube.ActiveForm
            SaveFile.Show()
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub Label4_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label4.MouseMove
        Try
            Label4.BorderStyle = BorderStyle.FixedSingle
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub Label4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label4.MouseLeave
        Try
            Label4.BorderStyle = BorderStyle.None
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            PanelMessageError.Visible = False
            RichTextBox1.Height = TabControl1.Size.Height - 30
            GroupBox1.Visible = False
            FindIndex = 0
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub TabControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TabControl1.KeyDown
        Try
            If (e.KeyData = Keys.F1) Then

            End If
            If (e.KeyData = Keys.F3) Then
                Panel4.Text = "Окно поиска:"
                If (PanelMessageError.Visible = False) Then
                    GroupBox1.Visible = True
                    PanelMessageError.Visible = True
                    RichTextBox1.Height = TabControl1.Size.Height - PanelMessageError.Size.Height - 30
                    FindIndex = 0
                Else
                    GroupBox1.Visible = False
                    PanelMessageError.Visible = False
                    RichTextBox1.Height = TabControl1.Size.Height - 30
                    FindIndex = 0
                End If
            End If
            If (e.KeyData = Keys.F4) Then
                If (FontDialog1.ShowDialog = DialogResult.OK) Then
                    RichTextBox1.Font = FontDialog1.Font
                End If
            End If
            If (e.KeyData = Keys.F8) Then
                'Clipboard.SetDataObject("     ")
                'RichTextBox1.Paste()
            End If
            If (e.KeyData = Keys.F12) Then
                Panel4.Text = "Окно сообщений:"
                If (PanelMessageError.Visible = False) Then
                    GroupBox1.Visible = False
                    PanelMessageError.Visible = True
                    RichTextBox1.Height = TabControl1.Size.Height - PanelMessageError.Size.Height - 30
                Else
                    PanelMessageError.Visible = False
                    GroupBox1.Visible = False
                    RichTextBox1.Height = TabControl1.Size.Height - 30
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub ProcessModule_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Try
            OleDbConnection1.Close()
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged
        Try
            Dim nStr, nChar As Integer
            nStr = RichTextBox1.GetLineFromCharIndex(RichTextBox1.SelectionStart) + 1
            Label6.Text = "Строка : " + nStr.ToString

        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub RichTextBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RichTextBox1.MouseMove
        Try
            Dim nStr, nChar As Integer
            nStr = RichTextBox1.GetLineFromCharIndex(RichTextBox1.SelectionStart) + 1
            Label6.Text = "Строка : " + nStr.ToString
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub RichTextBox1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox1.KeyUp
        Try
            Dim nStr, nChar As Integer
            nStr = RichTextBox1.GetLineFromCharIndex(RichTextBox1.SelectionStart) + 1
            Label6.Text = "Строка : " + nStr.ToString
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub RichTextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RichTextBox1.KeyPress
        Try
            If (e.KeyChar.GetHashCode = 851981) Then
                Dim nStr, nChar As Integer
                nStr = RichTextBox1.GetLineFromCharIndex(RichTextBox1.SelectionStart) + 1
                Label6.Text = "Строка : " + nStr.ToString
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        Try
            RichTextBox1.Paste()
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        Try
            RichTextBox1.Copy()
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        Try
            RichTextBox1.Cut()
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        Try
            RichTextBox1.Undo()
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Dim FindIndex As Integer = 0
    Dim FindText As String
    Dim FindLast As Integer = 0
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If (FindText <> TextBox2.Text) Then
                FindIndex = 0
                FindLast = 0
                FindText = TextBox2.Text
            End If
            If (RichTextBox1.Find(TextBox2.Text, FindIndex, RichTextBox1.TextLength - 1, RichTextBoxFinds.None)) Then
                RichTextBox1.Select()
                FindIndex = RichTextBox1.SelectionStart + RichTextBox1.SelectionLength
                If (FindLast = RichTextBox1.SelectionStart) Then
                    MsgBox("Поиск завершен.", MsgBoxStyle.OKOnly, "Сообщение:")
                    FindIndex = 0
                    FindLast = 0
                    FindText = TextBox2.Text
                Else
                    FindLast = RichTextBox1.SelectionStart
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        Try
            If (e.KeyData = Keys.Enter) Then
                If (FindText <> TextBox2.Text) Then
                    FindIndex = 0
                    FindLast = 0
                    FindText = TextBox2.Text
                End If
                If (RichTextBox1.Find(TextBox2.Text, FindIndex, RichTextBox1.TextLength - 1, RichTextBoxFinds.None)) Then
                    RichTextBox1.Select()
                    FindIndex = RichTextBox1.SelectionStart + RichTextBox1.SelectionLength
                    If (FindLast = RichTextBox1.SelectionStart) Then
                        MsgBox("Поиск завершен.", MsgBoxStyle.OKOnly, "Сообщение:")
                        FindIndex = 0
                        FindLast = 0
                        FindText = TextBox2.Text
                    Else
                        FindLast = RichTextBox1.SelectionStart
                    End If
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        Try
            Dim OpenFile As New FileManager
            OpenFile.Text = "Открыть файл как..."
            OpenFile.Button1.Text = "Открыть."
            OpenFile.MdiParent = ModuleCube.DesignerCube.ActiveForm
            OpenFile.Show()
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    '--ИНТЕРАКТИВНОЕ ВЫДИЛЕНИЕ СЛОВ------------------------------------------------------
    Dim BeginOperator, EndOperator As Integer
    Dim InputOperator As Boolean = True
    Dim ComentOperator As Boolean = False
    Private Sub DepartsModule()
        Try
            EndOperator = RichTextBox1.SelectionStart
            RichTextBox1.SelectionStart = BeginOperator
            Dim LengthOperator As Integer
            LengthOperator = EndOperator - BeginOperator
            If (LengthOperator > 0) Then
                RichTextBox1.SelectionLength = LengthOperator
                If (RichTextBox1.SelectedText = "Imports") Or (RichTextBox1.SelectedText = "imports") Then
                    RichTextBox1.SelectionStart = BeginOperator
                    RichTextBox1.SelectionLength = EndOperator - BeginOperator
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (RichTextBox1.SelectedText = "New") Or (RichTextBox1.SelectedText = "new") Then
                    RichTextBox1.SelectionStart = BeginOperator
                    RichTextBox1.SelectionLength = EndOperator - BeginOperator
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (RichTextBox1.SelectedText = "Dim") Or (RichTextBox1.SelectedText = "dim") Then
                    RichTextBox1.SelectionStart = BeginOperator
                    RichTextBox1.SelectionLength = EndOperator - BeginOperator
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (RichTextBox1.SelectedText = "As") Or (RichTextBox1.SelectedText = "as") Then
                    RichTextBox1.SelectionStart = BeginOperator
                    RichTextBox1.SelectionLength = EndOperator - BeginOperator
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (RichTextBox1.SelectedText = "If") Or (RichTextBox1.SelectedText = "if") Or (RichTextBox1.SelectedText = "IF") Then
                    RichTextBox1.SelectionStart = BeginOperator
                    RichTextBox1.SelectionLength = EndOperator - BeginOperator
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (RichTextBox1.SelectedText = "Then") Or (RichTextBox1.SelectedText = "then") Then
                    RichTextBox1.SelectionStart = BeginOperator
                    RichTextBox1.SelectionLength = EndOperator - BeginOperator
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (RichTextBox1.SelectedText = "End") Or (RichTextBox1.SelectedText = "end") Then
                    RichTextBox1.SelectionStart = BeginOperator
                    RichTextBox1.SelectionLength = EndOperator - BeginOperator
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (RichTextBox1.SelectedText = "Private") Or (RichTextBox1.SelectedText = "private") Then
                    RichTextBox1.SelectionStart = BeginOperator
                    RichTextBox1.SelectionLength = EndOperator - BeginOperator
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (RichTextBox1.SelectedText = "Public") Or (RichTextBox1.SelectedText = "public") Then
                    RichTextBox1.SelectionStart = BeginOperator
                    RichTextBox1.SelectionLength = EndOperator - BeginOperator
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (RichTextBox1.SelectedText = "Sub") Or (RichTextBox1.SelectedText = "sub") Then
                    RichTextBox1.SelectionStart = BeginOperator
                    RichTextBox1.SelectionLength = EndOperator - BeginOperator
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (RichTextBox1.SelectedText = "Function") Or (RichTextBox1.SelectedText = "function") Then
                    RichTextBox1.SelectionStart = BeginOperator
                    RichTextBox1.SelectionLength = EndOperator - BeginOperator
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (RichTextBox1.SelectedText = "And") Or (RichTextBox1.SelectedText = "and") Then
                    RichTextBox1.SelectionStart = BeginOperator
                    RichTextBox1.SelectionLength = EndOperator - BeginOperator
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (RichTextBox1.SelectedText = "Or") Or (RichTextBox1.SelectedText = "or") Then
                    RichTextBox1.SelectionStart = BeginOperator
                    RichTextBox1.SelectionLength = EndOperator - BeginOperator
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (RichTextBox1.SelectedText = "Xor") Or (RichTextBox1.SelectedText = "xor") Then
                    RichTextBox1.SelectionStart = BeginOperator
                    RichTextBox1.SelectionLength = EndOperator - BeginOperator
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (RichTextBox1.SelectedText = "True") Or (RichTextBox1.SelectedText = "true") Then
                    RichTextBox1.SelectionStart = BeginOperator
                    RichTextBox1.SelectionLength = EndOperator - BeginOperator
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (RichTextBox1.SelectedText = "False") Or (RichTextBox1.SelectedText = "false") Then
                    RichTextBox1.SelectionStart = BeginOperator
                    RichTextBox1.SelectionLength = EndOperator - BeginOperator
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (RichTextBox1.SelectedText = "String") Or (RichTextBox1.SelectedText = "string") Then
                    RichTextBox1.SelectionStart = BeginOperator
                    RichTextBox1.SelectionLength = EndOperator - BeginOperator
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (RichTextBox1.SelectedText = "Integer") Or (RichTextBox1.SelectedText = "integer") Then
                    RichTextBox1.SelectionStart = BeginOperator
                    RichTextBox1.SelectionLength = EndOperator - BeginOperator
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (RichTextBox1.SelectedText = "Boolean") Or (RichTextBox1.SelectedText = "boolean") Then
                    RichTextBox1.SelectionStart = BeginOperator
                    RichTextBox1.SelectionLength = EndOperator - BeginOperator
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (RichTextBox1.SelectedText = "For") Or (RichTextBox1.SelectedText = "for") Then
                    RichTextBox1.SelectionStart = BeginOperator
                    RichTextBox1.SelectionLength = EndOperator - BeginOperator
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (RichTextBox1.SelectedText = "Next") Or (RichTextBox1.SelectedText = "next") Then
                    RichTextBox1.SelectionStart = BeginOperator
                    RichTextBox1.SelectionLength = EndOperator - BeginOperator
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (RichTextBox1.SelectedText = "While") Or (RichTextBox1.SelectedText = "while") Then
                    RichTextBox1.SelectionStart = BeginOperator
                    RichTextBox1.SelectionLength = EndOperator - BeginOperator
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (RichTextBox1.SelectedText = "Do") Or (RichTextBox1.SelectedText = "do") Then
                    RichTextBox1.SelectionStart = BeginOperator
                    RichTextBox1.SelectionLength = EndOperator - BeginOperator
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (RichTextBox1.SelectedText = "To") Or (RichTextBox1.SelectedText = "to") Then
                    RichTextBox1.SelectionStart = BeginOperator
                    RichTextBox1.SelectionLength = EndOperator - BeginOperator
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (RichTextBox1.SelectedText = "Loop") Or (RichTextBox1.SelectedText = "loop") Then
                    RichTextBox1.SelectionStart = BeginOperator
                    RichTextBox1.SelectionLength = EndOperator - BeginOperator
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (RichTextBox1.SelectedText = "Structure") Or (RichTextBox1.SelectedText = "structure") Then
                    RichTextBox1.SelectionStart = BeginOperator
                    RichTextBox1.SelectionLength = EndOperator - BeginOperator
                    RichTextBox1.SelectionColor = Color.Blue
                End If
                If (RichTextBox1.SelectedText = "Class") Or (RichTextBox1.SelectedText = "class") Then
                    RichTextBox1.SelectionStart = BeginOperator
                    RichTextBox1.SelectionLength = EndOperator - BeginOperator
                    RichTextBox1.SelectionColor = Color.Blue
                End If

                RichTextBox1.SelectionStart = EndOperator
                RichTextBox1.SelectionLength = 0
                RichTextBox1.SelectionColor = Color.Black
            Else
                RichTextBox1.SelectionStart = EndOperator
                RichTextBox1.SelectionLength = 0
                RichTextBox1.SelectionColor = Color.Black
            End If
            InputOperator = True
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub RichTextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox1.KeyDown
        Try
            RichTextBox1.SelectionColor = Color.Black
            If (InputOperator = True) Then
                BeginOperator = RichTextBox1.SelectionStart
                InputOperator = False
            End If
            If (e.KeyData = Keys.Enter) Or (e.KeyData = Keys.Up) Or (e.KeyData = Keys.Down) Then
                ComentOperator = False 'коментарий окончен
                RichTextBox1.SelectionColor = Color.Black
            End If

            If (e.KeyData = Keys.Space) Or (e.KeyData = Keys.Enter) Or (e.KeyData = Keys.Tab) And (ComentOperator = False) Then
                DepartsModule()
            ElseIf (e.KeyData = Keys.OemQuotes) Or (ComentOperator = True) Then
                ComentOperator = True 'коментарий начался
                RichTextBox1.SelectionColor = Color.Green
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub
    '----------------------------------------------------------------

    Private Sub ProcessModule_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        Try
            If (ExtraClose = True) Then
                Me.Close()
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Try
            Panel4.Text = "Окно поиска:"
            If (PanelMessageError.Visible = False) Then
                GroupBox1.Visible = True
                PanelMessageError.Visible = True
                RichTextBox1.Height = TabControl1.Size.Height - PanelMessageError.Size.Height - 30
                FindIndex = 0
            Else
                GroupBox1.Visible = False
                PanelMessageError.Visible = False
                RichTextBox1.Height = TabControl1.Size.Height - 30
                FindIndex = 0
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Try
            Panel4.Text = "Окно сообщений:"
            If (PanelMessageError.Visible = False) Then
                GroupBox1.Visible = False
                PanelMessageError.Visible = True
                RichTextBox1.Height = TabControl1.Size.Height - PanelMessageError.Size.Height - 30
            Else
                PanelMessageError.Visible = False
                GroupBox1.Visible = False
                RichTextBox1.Height = TabControl1.Size.Height - 30
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        Try
            If (FontDialog1.ShowDialog = DialogResult.OK) Then
                RichTextBox1.Font = FontDialog1.Font
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        Try
            If (Me.Text = "Модуль OpenGL: Новый модуль.") Then
                Dim FolderFind As Boolean = False
                Dim NameModul As String
                Dim ModulePolitic As Boolean = True
                For iFolder As Integer = 0 To Folder.Items.Count - 1
                    If (Folder.Text = Folder.Items.Item(iFolder)) Then FolderFind = True
                Next
                If (FolderFind = True) Then
                    If (TextBox1.Text = "Модуль") Or (TextBox1.Text = "") Then
                        NameModul = InputBox("Введите имя модуля.", "Новый модуль:", "")
                    Else
                        NameModul = TextBox1.Text
                    End If
                    If (NameModul <> "") Then
                        For i As Integer = 0 To DataSet31.Модули.Count - 1
                            If (DataSet31.Модули.Item(i)("Идентификатор") = NameModul) Then
                                ModulePolitic = False
                                MsgBox("Ошибка: модуль с таким именем уже существует!!!.", MsgBoxStyle.OKOnly, "Сообщение:")
                                Label2.BorderStyle = BorderStyle.None
                            End If
                        Next
                    Else
                        ModulePolitic = False
                        Label2.BorderStyle = BorderStyle.None
                    End If
                    'Сохраняем данные
                    If (ModulePolitic = True) Then
                        OleDbConnection1.Open()
                        Dim DT As DataTable = DataSet31.Модули
                        Dim row As DataRow
                        row = DT.NewRow
                        row("Тип") = "Элемент"
                        If (Folder.Text <> "") Then
                            row("Группа") = Folder.Text
                        Else
                            MsgBox("Вы не выбрали папку в которую нужно сохранить модуль.", MsgBoxStyle.OKOnly, "Сообщение:")
                            Exit Sub
                        End If
                        row("Идентификатор") = NameModul
                        row("Модуль") = RichTextBox1.Text
                        RichTextBox2.Clear()
                        RichTextBox2.Text = "Подключенные модули:"
                        For iCh As Integer = 0 To CheckedListBox1.Items.Count - 1
                            If (CheckedListBox1.GetItemChecked(iCh) = True) Then
                                RichTextBox2.Text = RichTextBox2.Text + System.Environment.NewLine + CheckedListBox1.Items.Item(iCh)
                            End If
                        Next
                        row("СвязьСВнешнимиМодулями") = RichTextBox2.Text
                        RichTextBox2.Clear()
                        row("Описание") = RichTextBox3.Text
                        DT.Rows.Add(row)
                        OleDbDataAdapter1.Update(DataSet31, "Модули")
                        OleDbConnection1.Close()
                        ModuleCube.DesignerCube.TREE_UPDATE()
                        MsgBox("Сохранение прошло успешно.", MsgBoxStyle.OKOnly, "Сообщение:")
                    End If
                Else
                    MsgBox("Папка не найдена! Проверте имя папки в которую нужно сохранить модуль.", MsgBoxStyle.OKOnly, "Сообщение:")
                    Label2.BorderStyle = BorderStyle.None
                End If
            End If
            If (Me.Text = "Модуль OpenGL: Редактировать.") Then
                Dim FolderFind As Boolean = False
                Dim NameModul As String
                Dim ModulePolitic As Boolean = True
                For iFolder As Integer = 0 To Folder.Items.Count - 1
                    If (Folder.Text = Folder.Items.Item(iFolder)) Then FolderFind = True
                Next
                If (FolderFind = True) Then
                    If (TextBox1.Text = "Модуль") Or (TextBox1.Text = "") Then
                        NameModul = InputBox("Введите имя модуля.", "Новый модуль:", "")
                    Else
                        NameModul = TextBox1.Text
                    End If
                    If (NameModul <> "") Then 'проверка уникальности имени модуля
                        For i As Integer = 0 To DataSet41.Модули.Count - 1
                            If (DataSet41.Модули.Item(i)("Идентификатор") = NameModul) And (DataSet41.Модули.Item(i)("Строка") <> ActionID) Then
                                ModulePolitic = False
                                MsgBox("Ошибка: модуль с таким именем уже существует!!!.", MsgBoxStyle.OKOnly, "Сообщение:")
                                Label2.BorderStyle = BorderStyle.None
                            End If
                        Next
                    Else
                        ModulePolitic = False
                        Label2.BorderStyle = BorderStyle.None
                    End If
                    'Сохраняем данные
                    If (ModulePolitic = True) Then
                        OleDbConnection1.Open()

                        DataSet31.Модули.Item(0)("Модуль") = RichTextBox1.Text
                        DataSet31.Модули.Item(0)("Идентификатор") = NameModul
                        DataSet31.Модули.Item(0)("Группа") = Folder.Text
                        DataSet31.Модули.Item(0)("Описание") = RichTextBox3.Text
                        RichTextBox2.Clear()
                        RichTextBox2.Text = "Подключенные модули:"
                        For iCh As Integer = 0 To CheckedListBox1.Items.Count - 1
                            If (CheckedListBox1.GetItemChecked(iCh) = True) Then
                                RichTextBox2.Text = RichTextBox2.Text + System.Environment.NewLine + CheckedListBox1.Items.Item(iCh)
                            End If
                        Next
                        DataSet31.Модули.Item(0)("СвязьСВнешнимиМодулями") = RichTextBox2.Text
                        RichTextBox2.Clear()

                        OleDbDataAdapter1.Update(DataSet31, "Модули")
                        OleDbConnection1.Close()
                        ModuleCube.DesignerCube.TREE_UPDATE()
                        MsgBox("Сохранение прошло успешно.", MsgBoxStyle.OKOnly, "Сообщение:")
                    End If

                Else
                    MsgBox("Папка не найдена! Проверте имя папки в которую нужно сохранить модуль.", MsgBoxStyle.OKOnly, "Сообщение:")
                    Label2.BorderStyle = BorderStyle.None
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        Try
            Dim SaveFile As New FileManager
            SaveFile.Text = "Сохранить файл как..."
            SaveFile.Button1.Text = "Сохранить."
            SaveFile.MdiParent = ModuleCube.DesignerCube.ActiveForm
            SaveFile.Show()
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Try
            ModuleCube.LoadFProcess()
            ModuleCube.FormProcess.MeShow = True
            'ModuleCube.FormProcess.MdiParent = ModuleCube.DesignerCube
            ModuleCube.FormProcess.Show()
            ModuleCube.FormProcess.Update()

            ModuleCompile.Text = ""
            For iRTB As Integer = 0 To RichTextBox1.Lines.Length - 1
                If (RichTextBox1.Lines.GetValue(iRTB) <> "End Class") Then
                    ModuleCompile.Text = ModuleCompile.Text + RichTextBox1.Lines.GetValue(iRTB) + System.Environment.NewLine
                End If
            Next

            ModuleCube.FormProcess.Panel2.Width = 40
            ModuleCube.FormProcess.Update()

            For iCh As Integer = 0 To CheckedListBox1.Items.Count - 1
                If (CheckedListBox1.GetItemChecked(iCh) = True) Then
                    For iBase As Integer = 0 To DataSet41.Модули.Count - 1
                        If (DataSet41.Модули.Item(iBase)("Идентификатор") = CheckedListBox1.Items.Item(iCh)) Then
                            RichTextBox2.Text = DataSet41.Модули.Item(iBase)("Модуль")
                        End If
                    Next
                    ModuleCompile.Text = ModuleCompile.Text + RichTextBox2.Text + System.Environment.NewLine
                End If
                RichTextBox2.Clear()
            Next
            ModuleCompile.Text = ModuleCompile.Text + "End Class" + System.Environment.NewLine

            ModuleCube.FormProcess.Panel2.Width = 110
            ModuleCube.FormProcess.Update()

            Dim objCodeCompiler As System.CodeDom.Compiler.ICodeCompiler = New VBCodeProvider().CreateCompiler
            Dim objCompilerParameters As New System.CodeDom.Compiler.CompilerParameters
            objCompilerParameters.ReferencedAssemblies.Add("System.dll")
            objCompilerParameters.ReferencedAssemblies.Add("System.Windows.Forms.dll")
            objCompilerParameters.ReferencedAssemblies.Add("Microsoft.VisualBasic.dll")
            objCompilerParameters.ReferencedAssemblies.Add("Tao.OpenGl.dll")
            objCompilerParameters.ReferencedAssemblies.Add("Tao.Platform.Windows.dll")

            objCompilerParameters.GenerateInMemory = True

            Dim strCode As String = ModuleCompile.Text

            Dim objCompileResult As System.CodeDom.Compiler.CompilerResults = objCodeCompiler.CompileAssemblyFromSource(objCompilerParameters, strCode)

            'Обработка ошибок выполнения
            If (objCompileResult.Errors.HasErrors) Then
                ModuleCube.FormProcess.Close()
                GroupBox1.Visible = False
                PanelMessageError.Visible = True
                RichTextBox1.Height = TabControl1.Size.Height - PanelMessageError.Size.Height - 30
                ListBox1.Items.Clear()
                For iError As Integer = 0 To objCompileResult.Errors.Count - 1
                    ListBox1.Items.Add("Ошибка: строка> " + objCompileResult.Errors(iError).Line.ToString + " ; " + objCompileResult.Errors(iError).ErrorText)
                Next
                ModuleCompile.Text = ""
                Exit Sub
            End If

            ModuleCube.FormProcess.Panel2.Width = 180
            ModuleCube.FormProcess.Update()

            Dim objAssembly As System.Reflection.Assembly = objCompileResult.CompiledAssembly
            Dim objTheClass As Object = objAssembly.CreateInstance("MainClass")
            If (objTheClass Is Nothing) Then
                ModuleCube.FormProcess.Close()
                GroupBox1.Visible = False
                PanelMessageError.Visible = True
                RichTextBox1.Height = TabControl1.Size.Height - PanelMessageError.Size.Height - 30
                ListBox1.Items.Clear()
                ListBox1.Items.Add("Ошибка: в теле главного модуля не обнаружен класс MainClass!!!")
                ModuleCompile.Text = ""
                Exit Sub
            End If

            ModuleCube.FormProcess.Panel2.Width = 230
            ModuleCube.FormProcess.Update()

            Try
                ModuleCube.FormProcess.Close()
                objTheClass.GetType.InvokeMember("CodeBegin", Reflection.BindingFlags.InvokeMethod, Nothing, objTheClass, Nothing)
            Catch ex As Exception
                ModuleCube.FormProcess.Close()
                GroupBox1.Visible = False
                PanelMessageError.Visible = True
                RichTextBox1.Height = TabControl1.Size.Height - PanelMessageError.Size.Height - 30
                ListBox1.Items.Clear()
                ListBox1.Items.Add("Ошибка: в теле главного модуля не обнаружена функция CodeBegin!!!")
                ModuleCompile.Text = ""
            End Try

            objCodeCompiler = Nothing
            objCompilerParameters = Nothing
            strCode = Nothing
            objCompileResult = Nothing
            objAssembly = Nothing
            objTheClass = Nothing
            ModuleCompile.Text = ""
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Произошла ошибка!")
        End Try
    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        'Вставить шаблон Dim [Имя] As Integer
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("Dim ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Имя]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject(" As Integer")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem44.Click
        'Вставить шаблон Dim [Имя] As Char
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("Dim ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Имя]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject(" As Char")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        'Вставить шаблон Dim [Имя] As String
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("Dim ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Имя]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject(" As String")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        'Вставить шаблон Dim [Имя] As Double
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("Dim ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Имя]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject(" As Double")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        'Вставить шаблон Dim [Имя] As Float
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("Dim ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Имя]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject(" As Float")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        'Вставить шаблон Dim [Имя] As Single
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("Dim ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Имя]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject(" As Single")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem43.Click
        'Вставить шаблон Dim [Имя](10) As [Тип]
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("Dim ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Имя]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject("(10)")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject(" As ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Тип]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem45.Click
        'Вставить шаблон Dim [Имя2x2](20, 20) As [Тип]
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("Dim ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Имя2x2]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject("(20, 20)")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject(" As ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Тип]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem46.Click
        'Вставить шаблон Dim [Имя3x3](30, 30, 30) As [Тип]
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("Dim ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Имя3x3]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject("(30, 30, 30)")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject(" As ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Тип]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem47.Click
        'Вставить шаблон Dim [Имя2x2]( , ) As [Тип]
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("Dim ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Имя2x2]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject("( , )")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject(" As ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Тип]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem61.Click
        'Вставить шаблон Public [Имя] As [Тип]
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("Public ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Имя]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject(" As ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Тип]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem62.Click
        'Вставить шаблон Private [Имя] As [Тип]]
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("Private ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Имя]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject(" As ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Тип]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        'Вставить шаблон If ([Перем] = [Знач]) Then
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("If ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject("(")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Перем]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(" = ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Знач]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(")")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject(" Then")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem68.Click
        'Departs() 'при перерисовке панели срабатывает форматирование
        Panel3.Visible = True
    End Sub

    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        'Вставить шаблон If ([Перем] = [Знач]) And ([Перем] = [Знач]) Or ([Перем] = [Знач]) Xor ([Перем] = [Знач]) Then
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("If ")
        RichTextBox1.Paste()

        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject("(")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Перем]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(" = ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Знач]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(")")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject(" And ")
        RichTextBox1.Paste()

        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject("(")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Перем]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(" = ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Знач]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(")")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject(" Or ")
        RichTextBox1.Paste()

        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject("(")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Перем]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(" = ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Знач]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(")")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject(" Xor ")
        RichTextBox1.Paste()

        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject("(")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Перем]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(" = ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Знач]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(")")
        RichTextBox1.Paste()

        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject(" Then")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        'Вставить шаблон ElseIf ([Перем] = [Знач]) Then
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("ElseIf ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject("(")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Перем]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(" = ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Знач]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(")")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject(" Then")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        'Вставить шаблон Else
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("Else")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem29.Click
        'Вставить шаблон End If
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("End If")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem31.Click
        'Вставить шаблон For [Перем] As Integer = [НачЗнач] To [КонЗнач]
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("For ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Перем]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject(" As Integer")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(" = ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[НачЗнач]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject(" To ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[КонЗнач]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        'Вставить шаблон Next
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("Next")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem34.Click
        'Вставить шаблон Do While [Выражение]
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("Do While ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Выражение]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem35.Click
        'Вставить шаблон Do While [Выражение]
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("Loop")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem37.Click
        'Вставить шаблон While [Выражение]
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("While ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Выражение]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem38.Click
        'Вставить шаблон End While
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("End While")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem40.Click
        'Вставить шаблон Public Structure [Имя]
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("Public Structure ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Имя]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem41.Click
        'Вставить шаблон End Structure
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("End Structure")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem65.Click
        'Вставить шаблон Private Structure [Имя]
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("Private Structure ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Имя]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem66.Click
        'Вставить шаблон End Structure [Имя]
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("End Structure")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem49.Click
        'Вставить шаблон Public Class [Имя]
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("Public Class ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Имя]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem50.Click
        'Вставить шаблон End Class
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("End Class")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem58.Click
        'Вставить шаблон Private Class [Имя]
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("Private Class ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Имя]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem59.Click
        'Вставить шаблон End Class
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("End Class")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem52.Click
        'Вставить шаблон Public Sub [Имя](ByVal [ИмяПерем] As [Тип])
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("Public Sub ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Имя]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject("(")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("ByVal ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяПерем]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject(" As ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Тип]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(")")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem53.Click
        'Вставить шаблон Public Sub [Имя](ByRaf [ИмяПерем] As [Тип])
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("Public Sub ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Имя]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject("(")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("ByRaf ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяПерем]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject(" As ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Тип]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(")")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem56.Click
        'Вставить шаблон End Sub
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("End Sub")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem54.Click
        'Вставить шаблон Private Sub [Имя](ByVal [ИмяПерем] As [Тип])
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("Private Sub ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Имя]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject("(")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("ByVal ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяПерем]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject(" As ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Тип]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(")")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem55.Click
        'Вставить шаблон Private Sub [Имя](ByRaf [ИмяПерем] As [Тип])
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("Private Sub ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Имя]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject("(")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("ByRaf ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяПерем]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject(" As ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Тип]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(")")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem57.Click
        'Вставить шаблон End Sub
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("End Sub")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint
        Departs()
    End Sub

    Private Sub RichTextBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RichTextBox1.MouseDown
        ComentOperator = False
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        'Вставить шаблон Public Function [Имя](ByVal [ИмяПерем] As [Тип], Optional ByVal [ИмяПерем] As Boolean = True) As [ТипФункции]
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("Public Function ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Имя]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject("(")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("ByVal ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяПерем]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject(" As ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Тип]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(",")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject(" Optional ByVal ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяПерем]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject(" As Boolean ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject("=")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject(" True")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(")")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject(" As ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ТипФункции]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem73_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem73.Click
        'Вставить шаблон Private Function [Имя](ByVal [ИмяПерем] As [Тип], Optional ByVal [ИмяПерем] As Boolean = True) As [ТипФункции]
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("Private Function ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Имя]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject("(")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("ByVal ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяПерем]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject(" As ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[Тип]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(",")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject(" Optional ByVal ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяПерем]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject(" As Boolean ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject("=")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject(" True")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(")")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject(" As ")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ТипФункции]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem71.Click
        'Вставить шаблон End Function
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("End Function")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem74_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem74.Click
        'Вставить шаблон End Function
        RichTextBox1.SelectionColor = Color.Blue
        Clipboard.SetDataObject("End Function")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem77_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem77.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".AcceptButton")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem78_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem78.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".AccessibleDescription")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem79_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem79.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".AccessibleName")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem80_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem80.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".AccessibleRole")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem81_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem81.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".Activate")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem82_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem82.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".ActivateMdiChild")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem83_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem83.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".ActiveControl")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem84_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem84.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".ActiveForm")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem85_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem85.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".ActiveMdiChild")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem86_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem86.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".AddOwnedForm")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem88_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem88.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".BackColor")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem89_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem89.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".BackgroundImage")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem91_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem91.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".CancelButton")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem92_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem92.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".ContextMenu")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem93_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem93.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".ControlBox")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem94_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem94.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".Controls")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem95_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem95.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".Cursor")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem97_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem97.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".Dock")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem98_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem98.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".Enabled")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem100.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".Font")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem101_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem101.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".FontHeight")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem102_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem102.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".ForeColor")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem103_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem103.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".FormBorderStyle")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem105_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem105.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".Handle")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem106_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem106.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".Height")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem107_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem107.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".HelpButton")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem108_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem108.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".HScroll")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem110_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem110.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".Icon")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem111_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem111.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".ImeMode")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem112_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem112.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".IsMdiContainer")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem114_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem114.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".KeyPreview")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem115_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem115.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".Left")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem116_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem116.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".Location")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem118_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem118.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".MaximizeBox")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem119_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem119.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".MdiChildren")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem120_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem120.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".MdiParent")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem121_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem121.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".Menu")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem122_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem122.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".MinimizeBox")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem124_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem124.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".Name")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem125_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem125.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".Opacity")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem126_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem126.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".ResizeRedraw")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem128_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem128.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".ShowInTaskbar")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem129_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem129.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".Size")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem130_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem130.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".Show()")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem132_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem132.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".Text")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem133_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem133.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".Top")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem134_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem134.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".TopMost")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem136_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem136.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".Visible")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem137_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem137.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".VScroll")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem138_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem138.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".Width")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem139_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem139.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".WindowState")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem141_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem141.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".BackColor")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem151_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem151.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".Menu")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem142_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem142.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".ContextMenu")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem143_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem143.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".Cursor")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem144_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem144.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".Enabled")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem145_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem145.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".Font")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem146_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem146.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".FormBorderStyle")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem148_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem148.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".Height")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem160_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem160.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".Width")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem149_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem149.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".Left")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem155_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem155.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".Top")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem150_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem150.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".MaximizeBox")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem152_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem152.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".MinimizeBox")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem147_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem147.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".Handle")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem154_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem154.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".Name")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem156_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem156.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".Text")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem158_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem158.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".TopMost")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem159_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem159.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".Visible")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub

    Private Sub MenuItem164_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem164.Click
        'Вставить шаблон
        RichTextBox1.SelectionColor = Color.Gray
        Clipboard.SetDataObject("[ИмяФормы]")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
        Clipboard.SetDataObject(".Show()")
        RichTextBox1.Paste()
        RichTextBox1.SelectionColor = Color.Black
    End Sub
End Class
