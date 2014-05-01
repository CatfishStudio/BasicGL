Imports System.IO
Public Class Designer
    Inherits System.Windows.Forms.Form

#Region " ���, ������������� ��������� ������������� ���� Windows "

    Public Sub New()
        MyBase.New()

        '���� ����� ��������� ������������� ���� Windows.
        InitializeComponent()

        '�������� ��� ������������� ����� ������ InitializeComponent()

    End Sub

    '����� �������������� ����� Dispose ��� ������� ������ �����������.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    '��������� ������������� ���� Windows
    Private components As System.ComponentModel.IContainer

    '����������: ��������� ��������� ��������� ��� ������������ ���� Windows.
    '�� ����� �������� � ������������ ���� Windows.  
    '�� ��������� �� � ��������� ��������� ������.
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DataSet11 As BasicGL.DataSet1
    Friend WithEvents DataSet21 As BasicGL.DataSet2
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButton3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton5 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton6 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton7 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton8 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton9 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton10 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton11 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton12 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton13 As System.Windows.Forms.ToolBarButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents RichTextBox3 As System.Windows.Forms.RichTextBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents RichTextBox4 As System.Windows.Forms.RichTextBox
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents RichTextBox5 As System.Windows.Forms.RichTextBox
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Designer))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem24 = New System.Windows.Forms.MenuItem
        Me.MenuItem25 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem28 = New System.Windows.Forms.MenuItem
        Me.MenuItem26 = New System.Windows.Forms.MenuItem
        Me.MenuItem27 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton9 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton13 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton10 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton3 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton4 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton5 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton6 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton7 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton8 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton11 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton12 = New System.Windows.Forms.ToolBarButton
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.DataSet11 = New BasicGL.DataSet1
        Me.DataSet21 = New BasicGL.DataSet2
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.RichTextBox4 = New System.Windows.Forms.RichTextBox
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.RichTextBox5 = New System.Windows.Forms.RichTextBox
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Splitter2 = New System.Windows.Forms.Splitter
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem14, Me.MenuItem2, Me.MenuItem3})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem7, Me.MenuItem4})
        Me.MenuItem1.Text = "&����."
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 0
        Me.MenuItem7.Text = "������� ���� � ������."
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 1
        Me.MenuItem4.Text = "����� �� ���������."
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 1
        Me.MenuItem14.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem15})
        Me.MenuItem14.Text = "&���."
        '
        'MenuItem15
        '
        Me.MenuItem15.Checked = True
        Me.MenuItem15.Index = 0
        Me.MenuItem15.Text = "��������� �������."
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 2
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem6, Me.MenuItem8, Me.MenuItem13, Me.MenuItem12, Me.MenuItem9, Me.MenuItem10, Me.MenuItem11, Me.MenuItem24, Me.MenuItem25})
        Me.MenuItem2.Text = "&�����������."
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 0
        Me.MenuItem6.Text = "������� ����� ������."
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 1
        Me.MenuItem8.Text = "������� ��������� ������."
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 2
        Me.MenuItem13.Text = "������� ��������� ������."
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 3
        Me.MenuItem12.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 4
        Me.MenuItem9.Text = "������� ����� ������."
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 5
        Me.MenuItem10.Text = "�������� ��� ������."
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 6
        Me.MenuItem11.Text = "������� ������."
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 7
        Me.MenuItem24.Text = "-"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 8
        Me.MenuItem25.Text = "���������."
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 3
        Me.MenuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem28, Me.MenuItem26, Me.MenuItem27, Me.MenuItem16, Me.MenuItem5})
        Me.MenuItem3.Text = "&�������."
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 0
        Me.MenuItem28.Text = "������."
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 1
        Me.MenuItem26.Text = "���������� �� ����� VB � OpenGL"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 2
        Me.MenuItem27.Text = "-"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 3
        Me.MenuItem16.Text = "�������� freeware"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 4
        Me.MenuItem5.Text = "� ���������."
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 529)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel2})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(792, 16)
        Me.StatusBar1.TabIndex = 1
        Me.StatusBar1.Text = "StatusBar1"
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.StatusBarPanel1.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.Raised
        Me.StatusBarPanel1.Text = "Copyright � 2012 Somov Evgen."
        Me.StatusBarPanel1.Width = 179
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.Text = "..."
        Me.StatusBarPanel2.Width = 800
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton1, Me.ToolBarButton9, Me.ToolBarButton13, Me.ToolBarButton10, Me.ToolBarButton2, Me.ToolBarButton3, Me.ToolBarButton4, Me.ToolBarButton5, Me.ToolBarButton6, Me.ToolBarButton7, Me.ToolBarButton8, Me.ToolBarButton11, Me.ToolBarButton12})
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList2
        Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(792, 32)
        Me.ToolBar1.TabIndex = 2
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton9
        '
        Me.ToolBarButton9.ImageIndex = 0
        '
        'ToolBarButton13
        '
        Me.ToolBarButton13.ImageIndex = 8
        '
        'ToolBarButton10
        '
        Me.ToolBarButton10.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.ImageIndex = 1
        '
        'ToolBarButton3
        '
        Me.ToolBarButton3.ImageIndex = 2
        '
        'ToolBarButton4
        '
        Me.ToolBarButton4.ImageIndex = 3
        '
        'ToolBarButton5
        '
        Me.ToolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton6
        '
        Me.ToolBarButton6.ImageIndex = 4
        '
        'ToolBarButton7
        '
        Me.ToolBarButton7.ImageIndex = 5
        '
        'ToolBarButton8
        '
        Me.ToolBarButton8.ImageIndex = 6
        '
        'ToolBarButton11
        '
        Me.ToolBarButton11.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton12
        '
        Me.ToolBarButton12.ImageIndex = 7
        '
        'ImageList2
        '
        Me.ImageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList2.ImageSize = New System.Drawing.Size(24, 20)
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.TreeView1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(216, 497)
        Me.Panel1.TabIndex = 3
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.ContextMenu = Me.ContextMenu1
        Me.TreeView1.ImageIndex = 2
        Me.TreeView1.ImageList = Me.ImageList1
        Me.TreeView1.Indent = 27
        Me.TreeView1.ItemHeight = 20
        Me.TreeView1.Location = New System.Drawing.Point(0, 24)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("�������", 0, 1, New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("�����������", 2, 2)})})
        Me.TreeView1.Size = New System.Drawing.Size(211, 472)
        Me.TreeView1.TabIndex = 1
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem18, Me.MenuItem17, Me.MenuItem19, Me.MenuItem20, Me.MenuItem21, Me.MenuItem22, Me.MenuItem23})
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 0
        Me.MenuItem18.Text = "������� ������."
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 1
        Me.MenuItem17.Text = "������� ������."
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 2
        Me.MenuItem19.Text = "������� ������."
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 3
        Me.MenuItem20.Text = "-"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 4
        Me.MenuItem21.Text = "������� ����� ������."
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 5
        Me.MenuItem22.Text = "�������� ��� ������."
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 6
        Me.MenuItem23.Text = "������� ������."
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(24, 20)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(216, 24)
        Me.Panel2.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Location = New System.Drawing.Point(192, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "�"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, -6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "��������� �������:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(216, 32)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(2, 497)
        Me.Splitter1.TabIndex = 4
        Me.Splitter1.TabStop = False
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT ������, �������������, ������, ��������, ����������������������, ������, �" & _
        "�� FROM ������"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Data Source=""C:\����������������\VB NET\Cube Designer\Cube Designe" & _
        "rGL\Base\storage.mdb"";Jet OLEDB:Engine Type=5;Provider=""Microsoft.Jet.OLEDB.4.0""" & _
        ";Jet OLEDB:System database=;Jet OLEDB:SFP=False;persist security info=False;Exte" & _
        "nded Properties=;Mode=ReadWrite;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Creat" & _
        "e System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:C" & _
        "ompact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Global Bulk Transact" & _
        "ions=1"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO ������(������, �������������, ������, ��������, ���������������������" & _
        "�, ���) VALUES (?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("������", System.Data.OleDb.OleDbType.VarWChar, 255, "������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("�������������", System.Data.OleDb.OleDbType.VarWChar, 255, "�������������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("������", System.Data.OleDb.OleDbType.VarWChar, 0, "������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("��������", System.Data.OleDb.OleDbType.VarWChar, 0, "��������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("����������������������", System.Data.OleDb.OleDbType.VarWChar, 0, "����������������������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("���", System.Data.OleDb.OleDbType.VarWChar, 255, "���"))
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE ������ SET ������ = ?, ������������� = ?, ������ = ?, �������� = ?, ������" & _
        "���������������� = ?, ��� = ? WHERE (������ = ?) AND (������ = ? OR ? IS NULL AN" & _
        "D ������ IS NULL) AND (������������� = ? OR ? IS NULL AND ������������� IS NULL)" & _
        " AND (��� = ? OR ? IS NULL AND ��� IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("������", System.Data.OleDb.OleDbType.VarWChar, 255, "������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("�������������", System.Data.OleDb.OleDbType.VarWChar, 255, "�������������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("������", System.Data.OleDb.OleDbType.VarWChar, 0, "������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("��������", System.Data.OleDb.OleDbType.VarWChar, 0, "��������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("����������������������", System.Data.OleDb.OleDbType.VarWChar, 0, "����������������������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("���", System.Data.OleDb.OleDbType.VarWChar, 255, "���"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_������", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_������", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_������1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�������������", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�������������1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM ������ WHERE (������ = ?) AND (������ = ? OR ? IS NULL AND ������ IS " & _
        "NULL) AND (������������� = ? OR ? IS NULL AND ������������� IS NULL) AND (��� = " & _
        "? OR ? IS NULL AND ��� IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_������", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_������", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_������1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�������������", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_�������������1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "������", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("������", "������"), New System.Data.Common.DataColumnMapping("�������������", "�������������"), New System.Data.Common.DataColumnMapping("������", "������"), New System.Data.Common.DataColumnMapping("��������", "��������"), New System.Data.Common.DataColumnMapping("����������������������", "����������������������"), New System.Data.Common.DataColumnMapping("������", "������"), New System.Data.Common.DataColumnMapping("���", "���")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.Locale = New System.Globalization.CultureInfo("ru-RU")
        '
        'DataSet21
        '
        Me.DataSet21.DataSetName = "DataSet2"
        Me.DataSet21.Locale = New System.Globalization.CultureInfo("ru-RU")
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "���� visual basic|*.vb|��������� ����|*.txt"
        Me.OpenFileDialog1.Title = "������� ���..."
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.TabControl1)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(576, 32)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(216, 497)
        Me.Panel3.TabIndex = 6
        Me.Panel3.Visible = False
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
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(0, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(216, 472)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.RichTextBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(208, 443)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "���� VB"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.AcceptsTab = True
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.RichTextBox1.Size = New System.Drawing.Size(208, 442)
        Me.RichTextBox1.TabIndex = 4
        Me.RichTextBox1.Text = "������� ���������� ����� ���������������� Visual Basic .Net 2003" & Microsoft.VisualBasic.ChrW(10) & "________________" & _
        "___________________________________________________" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "1)���������� ����������." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "D" & _
        "im c as String '��� ������" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim i as Integer '��� ����� �����" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim b as Byte '��" & _
        "� ����" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim l as Long '��� ������� ����� �����" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim s as Single '��� ����� � ���" & _
        "������ �������" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim d as double '��� ����� � ��������� �������" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim o as Boolean" & _
        " '��� ����������" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim default '������������ ���" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "-------------------------------" & _
        "------------------------------------" & Microsoft.VisualBasic.ChrW(10) & "2)�������� ��������.    (��������� ����� ��" & _
        "������� ���������� � ���������)" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Private Structure IntegerArray" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "Public x, y, z" & _
        " as Integer" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "End Structure" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "'���������� ��������� ��������� ��� ��������� ������" & _
        "����" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim Points(2) as IntegerArray '�������� ��� ������" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Points(0).x = 10" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Poin" & _
        "ts(0).y = 10" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Points(0).z = 10" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Private Structure Matrix3x3" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "Public Matrix(,)" & _
        " As Single '����������� ������" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "End Structure" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "'���������� ��������� ��������� �" & _
        "�� ��������� ����������" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim M1 as Matrix3x3" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "M1.Matrix(0, 0) = 10.0" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "M1.Matrix(" & _
        "0, 1) = 0.0" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Private Structure Matrix4x4" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "Public Matrix As Single '�������" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & _
        "End Structure" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "'���������� ��������� ��������� ��� ��������� ����������" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim mat" & _
        "Composite(4, 4) As Matrix4x4" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "matComposite(0, 0).Matrix = 1 " & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "matComposite(0, 1)" & _
        ".Matrix = 0" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "-------------------------------------------------------------------" & _
        "" & Microsoft.VisualBasic.ChrW(10) & "3)�������� �������." & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "(����� ����� ��������� ���������� � ���������)" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Public Cla" & _
        "ss Points" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "Public x, y, z as Integer" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "End Class" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "'���������� ��������� ������ " & _
        "��� ��������� ����������" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim pXYZ as New Points" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "pXYZ.x = 10" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "pXYZ.y = 10" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "pXYZ" & _
        ".z = 10" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "-------------------------------------------------------------------" & Microsoft.VisualBasic.ChrW(10) & "4)�" & _
        "������." & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "(����������� �����:  =,<,>,<=,>=,<>)" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "If [������] = [��������] Then" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & _
        "[��������]" & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "else" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "[��������]" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "End If" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "----------------------------------------" & _
        "---------------------------" & Microsoft.VisualBasic.ChrW(10) & "5)�����." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "for i as integer = 0 To 10" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "[��������]" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "N" & _
        "ext" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "For Each MyObject As Object In MyCollection " & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "[��������]" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Next" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "'�������" & _
        "�� ���� ���������� � �������������� �������� ��� ������� ��� ���������." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "With My" & _
        "Label" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & ".Height = 2000" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & ".Width = 2000" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & ".Text = ""This is MyLabel""" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "End With" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "'" & _
        "������ ������������� ���������� ����� ����������, ��������� �������� �����������" & _
        "� ��������� �������, ������� ��� Boolean." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim Number As Integer = 10" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "While Num" & _
        "ber > 6" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "Number = Number - 1" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "End While" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "'������ ������������� ���������� ���" & _
        "�� ����������, ��������� �������� ������������ ��������� �������, ������� ��� Bo" & _
        "olean." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim Number As Integer = 10" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Do While Number > 6" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "Number = Number - 1" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "L" & _
        "oop" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "'��� ����������� ����" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Do" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "[��������]" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Loop" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "----------------------------" & _
        "---------------------------------------" & Microsoft.VisualBasic.ChrW(10) & "6)��������� ����������� ������ � �������" & _
        "�." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Exit For" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Exit Sub" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "-------------------------------------------------------" & _
        "------------" & Microsoft.VisualBasic.ChrW(10) & "7)�������." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim i1(10) as integer '���������� ������." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim i2x2(10," & _
        " 10) as integer '����� ������ ������." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "i1(0) = 25" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "i2x2(0, 0) = 25" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Private Str" & _
        "ucture Matrix3x3" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "Public Matrix(,) As Single '����������� ������" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "End Structure" & _
        "" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "'���������� ��������� ��������� ��� ��������� ����������" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim M1 as Matrix3x3" & Microsoft.VisualBasic.ChrW(10) & _
        "" & Microsoft.VisualBasic.ChrW(9) & "M1.Matrix(0, 0) = 10.0" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "M1.Matrix(0, 1) = 0.0" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "--------------------------------" & _
        "-----------------------------------" & Microsoft.VisualBasic.ChrW(10) & "8)�������������� �������." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim Theta as doub" & _
        "le" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Cos = Math.Cos(Theta)" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Sin = Math.Sin(Theta)" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "------------------------------" & _
        "-------------------------------------" & Microsoft.VisualBasic.ChrW(10) & "9)�������� ��������." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Private Sub [���_���" & _
        "������](ByVal [���_����������] as [���])" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "..." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "End Sub" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Public Sub [���_�������" & _
        "��](ByVal [���_����������] as [���])" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "..." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "End Sub" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "----------------------------" & _
        "---------------------------------------" & Microsoft.VisualBasic.ChrW(10) & "10)������� ������ ��������.  Nothing" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Di" & _
        "m s as string" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "s = Nothing" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "----------------------------------------------------" & _
        "---------------" & Microsoft.VisualBasic.ChrW(10) & "11)����������� �����." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim bitShape As Byte() = {0, 1, 2, 3, 4, " & _
        "5, 6, 7, 8, 9, 10, 11}" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim bitShape As Byte() = {&H1C, &H0, &H1C, &H0, &H1C, &H" & _
        "0, &H1C, &H0, &H1C, &H0, &HFF, &H80, &H7F, &H0, &H3E, &H0, &H1C, &H0, &H8, &H0}" & Microsoft.VisualBasic.ChrW(10) & _
        "" & Microsoft.VisualBasic.ChrW(9) & "Private Shared hexDigits As Char() =  {""0""c, ""1""c, ""2""c, ""3""c, ""4""c, ""5""c, ""6""c" & _
        ", ""7""c, ""8""c, ""9""c, ""A""c, ""B""c, ""C""c, ""D""c, ""E""c, ""F""c}" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "-----------------------" & _
        "--------------------------------------------" & Microsoft.VisualBasic.ChrW(10) & "12)����������� �������� � ������� �" & _
        "� ������� ������ dll" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Public Declare Sub glClear Lib ""opengl32.dll"" Alias ""glCle" & _
        "ar"" (ByVal bufferMasks As Integer)" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Public Declare Function wglCreateContext Lib" & _
        " ""opengl32.dll"" Alias ""wglCreateContext"" (ByVal deviceContext As System.IntPtr) " & _
        "As System.IntPtr"
        Me.RichTextBox1.WordWrap = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.RichTextBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(208, 443)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "OpenGL"
        Me.TabPage2.Visible = False
        '
        'RichTextBox2
        '
        Me.RichTextBox2.AcceptsTab = True
        Me.RichTextBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ReadOnly = True
        Me.RichTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.RichTextBox2.Size = New System.Drawing.Size(208, 442)
        Me.RichTextBox2.TabIndex = 5
        Me.RichTextBox2.Text = "������� ���������� �� OpenGL" & Microsoft.VisualBasic.ChrW(10) & "____________________________________________________" & _
        "____________________________________________________________" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "Gl.glClearColor(0." & _
        "0, 0.0, 0.0, 0.0) '������ ���� ���� �� ������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glMatrixMode(Gl.GL_PROJECTION)" & _
        " '�������� ����� ���������� ������������ �������������� ������� ��������������." & Microsoft.VisualBasic.ChrW(10) & _
        "Gl.glMatrixMode(Gl.GL_MODELVIEW) '�������� ����� ���������� ��������� ����������" & _
        "���� ������� ��������������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glClear(Gl.GL_COLOR_BUFFER_BIT) '��������� ����." & _
        "" & Microsoft.VisualBasic.ChrW(10) & "Gl.glColor3f(0.0, 0.0, 0.0) '���� �������� �������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glColor4fv(ColorV) '����" & _
        "�� ������ RGBA." & Microsoft.VisualBasic.ChrW(10) & "                                                    '���� RGBA �" & _
        "��������� �� ����� RGB ������ ���������� ���������� alfa ������� ��������� ��� �" & _
        "���������� ������� ������������ ������� " & Microsoft.VisualBasic.ChrW(10) & "Gl.glViewport(0, 0, 0, 0) '�������� ���" & _
        "� ���������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glBegin(Gl.GL_LINES) '������ �����." & Microsoft.VisualBasic.ChrW(10) & "Gl.glBegin(Gl.GL_TRIANGLES) " & _
        "'������ ��������� ����������� ������������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glBegin(Gl.GL_POLYGON) '������ ��" & _
        "��������� �������������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glBegin(Gl.GL_QNADS) '������ ����������� �����������" & _
        "��." & Microsoft.VisualBasic.ChrW(10) & "Gl.glEnd() '��������� �����" & Microsoft.VisualBasic.ChrW(10) & "Gl.glVertex2f(0, 0, 0) '����� ��������� ��������" & _
        "����� 2D �������" & Microsoft.VisualBasic.ChrW(10) & "Gl.glVertex3f(0, 0, 0) '����� ��������� ������������� 3D ������" & _
        "�" & Microsoft.VisualBasic.ChrW(10) & "Gl.glFlush() '��������� ���������� ���������� ��������" & Microsoft.VisualBasic.ChrW(10) & "Gl.glOrtho(-100.0, 100." & _
        "0, -100.0, 100.0, -100, 100) '������������� 3D �������� (x_left, x_right, y_butt" & _
        "on, y_top, z_near, z_far)" & Microsoft.VisualBasic.ChrW(10) & "                                                    'x" & _
        "_left, x_right - ���������� ��������� ��������� �����(left) �� �����(right) (���" & _
        "�)" & Microsoft.VisualBasic.ChrW(10) & "                                                    'y_button, y_top - ������" & _
        "���� ��������� ��������� �����(button) � �����(top) (���Y)" & Microsoft.VisualBasic.ChrW(10) & "                     " & _
        "          'z_near, z_far - ���������� ��������� ��������� �� ������(near) �� ���" & _
        "���(far) (���Z)" & Microsoft.VisualBasic.ChrW(10) & "Gl.glFrustum(-40.0, 40.0, -60.0, 60.0, 25.0, 125.0) '�����������" & _
        "� ������������� �������� (left, right, bottom, top, znear, zfar)" & Microsoft.VisualBasic.ChrW(10) & "               " & _
        "                                     'x_left, x_right - ���������� ��������� ���" & _
        "������ �����(left) �� �����(right) (����)" & Microsoft.VisualBasic.ChrW(10) & "                                   'y_" & _
        "button, y_top - ���������� ��������� ��������� �����(button) � �����(top) (���Y)" & _
        "" & Microsoft.VisualBasic.ChrW(10) & "           'z_near, z_far - ���������� ��������� ��������� �� ������(near) �� �" & _
        "�����(far) (���Z)" & Microsoft.VisualBasic.ChrW(10) & "Gl.glTranslatef(10.0, 0.0, 0.0) '���������� (�����������) �� �" & _
        "��� (�, Y, Z)" & Microsoft.VisualBasic.ChrW(10) & "Gl.glRotatef(10, 0.0, 0.0, 1.0) '������� (����, X, Y, Z)" & Microsoft.VisualBasic.ChrW(10) & "Gl.glScal" & _
        "ef(0.9, 0.9, 0.9) '��������� ��������. (X, Y, Z). ���������� �������� 1.1 � ����" & _
        "������ �������� 0.9" & Microsoft.VisualBasic.ChrW(10) & "Gl.glRectf(-20, -20, 20, 20) '������ ����������� ������� � 2" & _
        "D �����������" & Microsoft.VisualBasic.ChrW(10) & "Gl.glEnableClientState(Gl.GL_VERTEX_ARRAY) - ������������ ��������" & _
        "��� ��������� ������ ������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glVertexPointer(3, Gl.GL_INT, 0, pt) - �������� " & _
        "������ ������������ ��������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glDrawElements(Gl.GL_QUADS, 23, Gl.GL_UNSIGNED_" & _
        "BYTE, verts) - ������������ �������� ��� ��������� �� ������� ������" & Microsoft.VisualBasic.ChrW(10) & "Gl.glPixelS" & _
        "torei(Gl.GL_UNPACK_ALIGNMENT, 1) '������������� ����� �������� ��������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glRa" & _
        "sterPos2i(0, 0) '������ ���������� ������������ ������� �������� �����������" & Microsoft.VisualBasic.ChrW(10) & "Gl." & _
        "glBitmap(9, 10, 0.0, 0.0, 20.0, 15.0, bitShape) '���������� ������� �����������" & Microsoft.VisualBasic.ChrW(10) & _
        "Gl.glGenLists(1) '������� ����������� ������������� �������������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glNewList(" & _
        "regHex, Gl.GL_COMPILE) '��������� ������� �����������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glEndList() '���������" & _
        " ������� �����������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glCallList(regHex) '���������� ������� �����������." & Microsoft.VisualBasic.ChrW(10) & "Gl." & _
        "glIsList(listID) '���������� ������������ �� ������ ����� ����� � �������� �����" & _
        " �������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glListBase(0) '�������� �������� �������� ��� ������� �������������" & _
        "�� ������ �����������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glDeleteLists(startID, nLists) '������� ����� ��������" & _
        "� ���� �� ������ ������ �����������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glPointSize(50.0) '��������� ������� ���" & _
        "��." & Microsoft.VisualBasic.ChrW(10) & "Gl.glLineWidth(10.0) '��������� ������ �����." & Microsoft.VisualBasic.ChrW(10) & "Gl.glLineStipple(1, 5) '������" & _
        "��� ����� �����." & Microsoft.VisualBasic.ChrW(10) & "Gl.glIndexi(196) '��������� ���� ����������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glShadeModel(Gl" & _
        ".GL_SMOOTH) '������� ����������� ����������� �����" & Microsoft.VisualBasic.ChrW(10) & "Gl.glShadeModel(Gl.GL_FLAT) '" & _
        "������� ����������� ������ �����" & Microsoft.VisualBasic.ChrW(10) & "Gl.glPolygonStipple(fillPattern) '������ ����� " & _
        "�������� ������� �����." & Microsoft.VisualBasic.ChrW(10) & "Gl.glEnable(Gl.GL_POLYGON_STIPPLE) '�������� ��������� �" & _
        "�����������" & Microsoft.VisualBasic.ChrW(10) & "Gl.glShadeModel(Gl.GL_SMOOTH) '���������������� ������������. ���� �" & _
        "����������� GL_FLAT -������ ����� �������� ����� ��������� ������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glEnable(G" & _
        "l.GL_LINE_SMOOTH) '����������� ��������� ���������� ���������� GL_POINT_SMOOTH, " & _
        "GL_LINE_SMOOTH, GL_POLYGON_SMOOTH" & Microsoft.VisualBasic.ChrW(10) & "Gl.glEnable(Gl.GL_BLEND) '���� ����� ����� RGB" & _
        "A ����� �������������� �������� ���������� ������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glBlendFunc(Gl.GL_SRC_ALPH" & _
        "A, Gl.GL_ONE_MINUS_SRC_ALPHA) '����������� ����� ���������� ������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glGetFloa" & _
        "tv(Gl.GL_RED_BITS, GetR_Bitas) '���������� ������� �������� ��������" & Microsoft.VisualBasic.ChrW(10) & "Gl.glGetInt" & _
        "egerv(Gl.GL_MAX_MODELVIEW_STACK_DEPTH, StackSize) '���������� ����� �������, ���" & _
        "������� � ����� ��������� ��������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glGetIntegerv(Gl.GL_MODELVIEW_STACK_DEPTH" & _
        ", numMatrix) '���������� ������� ������ � ��������� ������ ��������� � �����." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "G" & _
        "l.glPushAttrib(Gl.GL_POINT_BIT And Gl.GL_LIST_BIT And Gl.GL_POLYGON_BIT) '������" & _
        "��� ��������� �� ���������� �����." & Microsoft.VisualBasic.ChrW(10) & "Gl.glPopAttrib() '��������������� ��� �������" & _
        "� �� ����� ���������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glPushMatrix() '�������� ������� ������� ����� � ������" & _
        "���� ����� �� ������ ������� �����" & Microsoft.VisualBasic.ChrW(10) & "Gl.glPopMatrix() '������� ������� ������� ���" & _
        "�� � �������� ������ ������� � ���� �����." & Microsoft.VisualBasic.ChrW(10) & "Gl.glClipPlane(Gl.GL_CLIP_PLANE0, pla" & _
        "ne0_Parameters) '������ �������������� ��������� ���������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glEnable(Gl.GL_CL" & _
        "IP_PLANE0) '������������ �������������� ��������� ���������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glMap1f(Gl.GL_MA" & _
        "P1_VERTEX_3, 0.0, 1.0, 3, 4, ctrlPts) '������ ��������� �����������, ����� �����" & _
        "� � ���� ��������� ������ �����" & Microsoft.VisualBasic.ChrW(10) & "Gl.glEnable(Gl.GL_MAP1_VERTEX_3) '����������� gl" & _
        "Map1f" & Microsoft.VisualBasic.ChrW(10) & "Gl.glEvalCoord1f(LFor / 50.0) '��������� ���������� ����� �� ������ �����." & _
        "" & Microsoft.VisualBasic.ChrW(10) & "Gl.glMapGrid1f(50, 0.0, 1.0) '������ ����� ���������� ������������� ������� ���" & _
        "�� ����� ����������� ������ �����." & Microsoft.VisualBasic.ChrW(10) & "Gl.glEvalMesh1(Gl.GL_LINE, 0, 50) '������ ���" & _
        "�� ����������� � ������������� �������� ����������� ������ �����." & Microsoft.VisualBasic.ChrW(10) & "Gl.glMap2f(Gl." & _
        "GL_MAP2_VERTEX_3, 0.0, 1.0, 3, 4, 0.0, 1.0, 12, 4, ctrlPts) '������ ��������� ��" & _
        "���������, ����� ����� � ���� ��������� ������ �����." & Microsoft.VisualBasic.ChrW(10) & "Gl.glEnable(Gl.GL_MAP2_VER" & _
        "TEX_3) '����������� glMap2f." & Microsoft.VisualBasic.ChrW(10) & "Gl.glEvalCoord2f(j / 39.0, k / 7.0) '������������ �" & _
        "��������� ����� �� ����������� �����." & Microsoft.VisualBasic.ChrW(10) & "Gl.glMapGrid2f(40, 0.0, 1.0, 40, 0.0, 1.0)" & _
        " '������ ���������� ����� ���������� ������������� ������� �� ����������� �����." & _
        "" & Microsoft.VisualBasic.ChrW(10) & "Gl.glEvalMesh2(Gl.GL_LINE, 0, 40, 0, 40) '������ ����� ����������� � ����������" & _
        "��� �������� ��� ���������� ����� �� ����������� �����." & Microsoft.VisualBasic.ChrW(10) & "Gl.glClear(Gl.GL_COLOR_B" & _
        "UFFER_BIT Or Gl.GL_DEPTH_BUFFER_BIT) '��������� ���� � �������������� ������ ���" & _
        "����." & Microsoft.VisualBasic.ChrW(10) & "Gl.glCullFace(Gl.GL_FRONT) '��������� ����� ��������� ��������������� ����" & _
        "� ������������� � ��������� ������ (GL_FRONT - ��������, GL_BACK - ������)." & Microsoft.VisualBasic.ChrW(10) & "Gl.g" & _
        "lEnable(Gl.GL_CULL_FACE) '����������� glCullFace." & Microsoft.VisualBasic.ChrW(10) & "Gl.glClearDepth(Gl.GL_DEPTH_BU" & _
        "FFER_BIT) '������ �������� �������� ������ �������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glDepthRange(0.0, 1.0) '�" & _
        "����� �������� ������������� �������� �������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glDepthFunc(Gl.GL_LESS) '�����" & _
        "� ������� �������� �������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glDepthMask(Gl.GL_TRUE) '������������� ������ ���" & _
        "��� ��� ������ ������� (GL_TRUE - ������ � ������, GL_FALSE - ������ ������)." & Microsoft.VisualBasic.ChrW(10) & "Gl" & _
        ".glEnable(Gl.GL_DEPTH_TEST) '������������ ����������� ������� ������������" & Microsoft.VisualBasic.ChrW(10) & "Gl.gl" & _
        "PolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_LINE) '�������� ������ ������������ ����" & _
        "����." & Microsoft.VisualBasic.ChrW(10) & "Gl.glEnable(Gl.GL_POLYGON_OFFSET_FILL) '������������ glPolygonOffset." & Microsoft.VisualBasic.ChrW(10) & "Gl.g" & _
        "lPolygonOffset(1.0, 1.0) '������ ����������, ����� ��������� ������� ����� �� ��" & _
        "������� ����������� ��� ���������� ���������� ������ ����." & Microsoft.VisualBasic.ChrW(10) & "Gl.glEnable(Gl.GL_FOG" & _
        ") '������������ GlFog - ��������� � ��������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glFogi(Gl.GL_FOG_MODE, Gl.GL_LI" & _
        "NEAR) '������ ������� ������� ��������� ���������� �� ����� ����������. (�����)" & Microsoft.VisualBasic.ChrW(10) & _
        "Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_POSITION, LightValue) '������ �������� ������� " & _
        "��������� �����   'POSITION - ��������� ��������� �����." & Microsoft.VisualBasic.ChrW(10) & "Gl.glEnable(Gl.GL_LIGHT" & _
        "0) '������������ �������� �����." & Microsoft.VisualBasic.ChrW(10) & "Gl.glEnable(Gl.GL_LIGHTING) '�����������  ���� " & _
        "��������� ���������� �����." & Microsoft.VisualBasic.ChrW(10) & "Gl.glDisable(Gl.GL_LIGHT0) '��������� �������� �����" & _
        "." & Microsoft.VisualBasic.ChrW(10) & "Gl.glLightModelfv(Gl.GL_LIGHT_MODEL_AMBIENT, globalAmbient) '�������� ����� ��" & _
        "����� ���������." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "-------------------------------------------------------------" & _
        "--------------------------------------------------------------------------------" & _
        "-----------------------------------------------------------------------" & Microsoft.VisualBasic.ChrW(10) & "Glu.gluO" & _
        "rtho2D(-100.0, 100.0, -100.0, 100.0) '������������� 2D ��������. (x_left, x_righ" & _
        "t, y_button, y_top)" & Microsoft.VisualBasic.ChrW(10) & "                                                    'x_left," & _
        " x_right - ���������� ��������� ��������� �����(left) �� �����(right) (����)" & Microsoft.VisualBasic.ChrW(10) & "   " & _
        "                                             'y_button, y_top - ���������� �����" & _
        "���� ��������� �����(button) � �����(top) (���Y)" & Microsoft.VisualBasic.ChrW(10) & "Glu.gluLookAt(5.0, 5.0, -5.0, 0" & _
        ".0, 0.0, 0.0, 0.0, 0.0, 1.0) '������� ������������ ����� ����������" & Microsoft.VisualBasic.ChrW(10) & "            " & _
        "                               'eyeX, eyeY, eyeZ - ������� ����� �������." & Microsoft.VisualBasic.ChrW(10) & "      " & _
        "                                              'centerX, centerY, centerZ  - ����" & _
        "��� ������� �����. (����� �������)" & Microsoft.VisualBasic.ChrW(10) & "                   'upX, upY, upZ - ���������" & _
        "�� ������� �����." & Microsoft.VisualBasic.ChrW(10) & "                                   '�� ��������� gluLookAt(0,0" & _
        ",0,0,0,-1,0,1,0)" & Microsoft.VisualBasic.ChrW(10) & "Glu.gluPerspective(80.0, gluP_Aspect, 2.0, 100.0) '������������" & _
        " ��������������������� (fovy, aspect, zNear, zFar)" & Microsoft.VisualBasic.ChrW(10) & "     'fovy - ���� ���� ������" & _
        ", � ��������, � ����������� �� ��� Y. " & Microsoft.VisualBasic.ChrW(10) & "                                        '" & _
        "aspec - ���������� ����, ������� ���������� ���� ������ � ����������� �� ��� �. " & _
        "���������� ���� - ���������(�����������) X (������) � Y (������)." & Microsoft.VisualBasic.ChrW(10) & "              " & _
        "                                      'zNear - ���������� �� ����� ��������� �� " & _
        "������� ��������� ��������� (������ ���������� ��������)" & Microsoft.VisualBasic.ChrW(10) & "                       " & _
        "                             'zFar - ���������� �� ����� ��������� �� ������� ��" & _
        "������� ��������� (������ ���������� ��������)" & Microsoft.VisualBasic.ChrW(10) & "Glu.gluNewQuadric() '������������" & _
        " ��������� ������������ ������������ GLU �������." & Microsoft.VisualBasic.ChrW(10) & "Glu.gluQuadricDrawStyle(Object" & _
        "3D, Glu.GLU_LINE) '�������� ����� ����������� ��� ����������������� ����� ������" & _
        "� GLU." & Microsoft.VisualBasic.ChrW(10) & "Glu.gluSphere(Object3D, 20.0, 5, 5) '������������ ����� GLU." & Microsoft.VisualBasic.ChrW(10) & "Glu.gluCylin" & _
        "der(Object3D, 30.0, 15.0, 10.0, 10.0, 10.0) '���������� �����, ������� ��� �����" & _
        "����� ������� GLU." & Microsoft.VisualBasic.ChrW(10) & "Glu.gluDisk(Object3D, 20.0, 30.0, 15, 15) '���������� �������" & _
        " �������� ������ ��� �������� ���� GLU." & Microsoft.VisualBasic.ChrW(10) & "Glu.gluPartialDisk(Object3D, 10.0, 30.0," & _
        " 20, 20, 0, 90) '���������� ������� �������� ��������� ������ ��� ��������� ����" & _
        "� GLU." & Microsoft.VisualBasic.ChrW(10) & "Glu.gluDeleteQuadric(Object3D) '������� GLU ������ ������� �������." & Microsoft.VisualBasic.ChrW(10) & "Glu.g" & _
        "luQuadricOrientation(Object3D, Glu.GLU_INSIDE) '���������� ����������� ���������" & _
        "�� ���������� � ������� ���������� GLU �������. " & Microsoft.VisualBasic.ChrW(10) & "Glu.gluQuadricNormals(Object3D," & _
        " Glu.GLU_FLAT) '��������� �������� ������� � �����������." & Microsoft.VisualBasic.ChrW(10) & "Glu.gluQuadricCallback" & _
        "(Object3D, Glu.GLU_ERROR, function) '������ ������� ��������� ������ ��� ������ " & _
        "��������� GLU �������." & Microsoft.VisualBasic.ChrW(10) & "Glu.gluNewNurbsRenderer() '������������ ��������� �������" & _
        "����� GLU ��-������� ��� �������, ��� �������� ��� ����������." & Microsoft.VisualBasic.ChrW(10) & "Glu.gluBeginCurve" & _
        "(cubicBezCurve) '�������� ���������� �������� ���������� ��� �������� ��-�������" & _
        "��� ������ � ����� ��� ����������� ���������." & Microsoft.VisualBasic.ChrW(10) & "Glu.gluNurbsCurve(cubicBezCurve, 8" & _
        ", knotVector, 3, ctrlPts, 4, Gl.GL_MAP1_VERTEX_3) '������ �������� ���������� ��" & _
        "���������� ������� ��-���������� ������." & Microsoft.VisualBasic.ChrW(10) & "Glu.gluEndCurve(cubicBezCurve) '�������" & _
        "�� ����� ������� ���������� ��-���������� ������." & Microsoft.VisualBasic.ChrW(10) & "Glu.gluDeleteNurbsRenderer(cub" & _
        "icBezCurve) '������� �������� ��-���������� ������." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "-------------------------" & _
        "--------------------------------------------------------------------------------" & _
        "--------------------------------------------------------------------------------" & _
        "---------------------------" & Microsoft.VisualBasic.ChrW(10) & "Gdi.PIXELFORMATDESCRIPTOR '��������� ��������� �����" & _
        "� ������� ����������� �����������" & Microsoft.VisualBasic.ChrW(10) & "Gdi.SetPixelFormat(ghDC, PixelFormat, pfd) The" & _
        "n '������������� ���������� ������." & Microsoft.VisualBasic.ChrW(10) & "Gdi.SwapBuffers(ghDC) '����� ������������ ��" & _
        "���������� ��� ������� ����������� (������������� ������)" & Microsoft.VisualBasic.ChrW(10) & "Gdi.PFD_DRAW_TO_WINDOW" & _
        " '����: ���������� � ����" & Microsoft.VisualBasic.ChrW(10) & "Gdi.PFD_SUPPORT_OPENGL '����: ������� OpenGL" & Microsoft.VisualBasic.ChrW(10) & "Gdi.PFD_D" & _
        "OUBLEBUFFER '����: ������� �����������" & Microsoft.VisualBasic.ChrW(10) & "Gdi.PFD_DEPTH_DONTCARE '����: �����������" & _
        "�� �������." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "---------------------------------------------------------------" & _
        "--------------------------------------------------------------------------------" & _
        "---------------------------------------------------------------------" & Microsoft.VisualBasic.ChrW(10) & "Wgl.wglCre" & _
        "ateContext(ghDC) '������� �������� ����������." & Microsoft.VisualBasic.ChrW(10) & "Wgl.wglMakeCurrent(ghDC, hRC) The" & _
        "n '������� �����." & Microsoft.VisualBasic.ChrW(10) & "Wgl.wglMakeCurrent(IntPtr.Zero, IntPtr.Zero) '������� �����." & Microsoft.VisualBasic.ChrW(10) & "W" & _
        "gl.wglDeleteContext(ghDC)  '������� ����������� ��������." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10)
        Me.RichTextBox2.WordWrap = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.RichTextBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(208, 443)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "�������������� �������"
        Me.TabPage3.Visible = False
        '
        'RichTextBox3
        '
        Me.RichTextBox3.AcceptsTab = True
        Me.RichTextBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RichTextBox3.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.ReadOnly = True
        Me.RichTextBox3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.RichTextBox3.Size = New System.Drawing.Size(208, 442)
        Me.RichTextBox3.TabIndex = 6
        Me.RichTextBox3.Text = "2D ����������:" & Microsoft.VisualBasic.ChrW(10) & "x' = x + tx" & Microsoft.VisualBasic.ChrW(10) & "y' = y + ty" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "2D �������:" & Microsoft.VisualBasic.ChrW(10) & "x' = Xr + (x - Xr) * cos(����" & _
        ") - (y - yr) * sin(����)" & Microsoft.VisualBasic.ChrW(10) & "y' = Yr + (x - Xr) * sin(����) + (y - Yr) * cos(����)" & Microsoft.VisualBasic.ChrW(10) & "�" & _
        "�� Xr � Yr - ��� ����� ��������." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "2D �������:" & Microsoft.VisualBasic.ChrW(10) & "x' = x * Sx + Xf(1 - Sx)" & Microsoft.VisualBasic.ChrW(10) & "y' = y * " & _
        "Sy + Yf(1 - Sy)" & Microsoft.VisualBasic.ChrW(10) & "��� Xf � Yf - ��������������� ������������ ��������� �����������" & _
        "�� �����" & Microsoft.VisualBasic.ChrW(10) & "-----------------------------------------------------------------------" & _
        "-----------------------------" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "3D ����������: ----------------------------------" & _
        "---------------------------------------------" & Microsoft.VisualBasic.ChrW(10) & "x' = x + tx" & Microsoft.VisualBasic.ChrW(10) & "y' = y + ty" & Microsoft.VisualBasic.ChrW(10) & "z' = z + t" & _
        "z" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "������� 4 �� 4" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "[x'] = [1 0 0 tx] * [x]" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "[y'] = [0 1 0 ty] * [y]" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "[z'] = [0 0" & _
        " 1 tz] * [z]" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "[1] = [0 0 0 1] * [1]" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "3D �������: -------------------------------" & _
        "-----------------------------------------------------" & Microsoft.VisualBasic.ChrW(10) & "x' = x cos(����) - y sin(�" & _
        "���)" & Microsoft.VisualBasic.ChrW(10) & "y' = x sin(����) + y cos(����)" & Microsoft.VisualBasic.ChrW(10) & "z' = z" & Microsoft.VisualBasic.ChrW(10) & "y' = y cos(����) - z sin(����)" & Microsoft.VisualBasic.ChrW(10) & "z' = y" & _
        " sin(����) + z cos(����)" & Microsoft.VisualBasic.ChrW(10) & "x' = x" & Microsoft.VisualBasic.ChrW(10) & "z' = z cos(����) - x sin(����)" & Microsoft.VisualBasic.ChrW(10) & "x' = z sin(����) " & _
        "+ x cos(����)" & Microsoft.VisualBasic.ChrW(10) & "y' = y" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "������������� ������� 4 �� 4:" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "[ux * ux(1 - cos(����)) + c" & _
        "os(����)]            [ux * uy(1 - cos(����)) - uz * sin(����)]      [ux * uz(1 -" & _
        " cos(����)) + uy * sin(����)]" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "[u� * ux(1 - cos(����)) + uz * sin(����)]     [uy" & _
        " * uy(1 - cos(����)) + cos(����)]            [uy * uz(1 - cos(����)) - ux * sin(" & _
        "����)]" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "[uz * ux(1 - cos(����)) - uy * sin(����)]      [uz * uy(1 - cos(����)) +" & _
        " ux * sin(����)]     [uz * uz(1 - cos(����)) + cos(����)]" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "3D �������: ---------" & _
        "-------------------------------------------------------------------------" & Microsoft.VisualBasic.ChrW(10) & "x' = x" & _
        " * Sx + Xf(1 - Sx)" & Microsoft.VisualBasic.ChrW(10) & "y' = y * Sy + Yf(1 - Sy)" & Microsoft.VisualBasic.ChrW(10) & "z' = z * Sz + Zf(1 - Sz)" & Microsoft.VisualBasic.ChrW(10) & "��� Xf � Yf" & _
        " � Zf - ��������������� ������������ ��������� ������������� �����" & Microsoft.VisualBasic.ChrW(10) & "_____________" & _
        "___________________________________________________________"
        Me.RichTextBox3.WordWrap = False
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.RichTextBox4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(208, 443)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "���� OpenGL"
        Me.TabPage4.Visible = False
        '
        'RichTextBox4
        '
        Me.RichTextBox4.AcceptsTab = True
        Me.RichTextBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RichTextBox4.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox4.Name = "RichTextBox4"
        Me.RichTextBox4.ReadOnly = True
        Me.RichTextBox4.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.RichTextBox4.Size = New System.Drawing.Size(208, 442)
        Me.RichTextBox4.TabIndex = 7
        Me.RichTextBox4.Text = " ��� OpenGL      |        ��� VB     " & Microsoft.VisualBasic.ChrW(10) & "-------------------------------------------" & _
        "- " & Microsoft.VisualBasic.ChrW(10) & "  GLenum" & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "Long   " & Microsoft.VisualBasic.ChrW(10) & "  GLboolean" & Microsoft.VisualBasic.ChrW(9) & "Byte      " & Microsoft.VisualBasic.ChrW(10) & "  GLbyte" & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "Byte    " & Microsoft.VisualBasic.ChrW(10) & "  GLshort" & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "Intege" & _
        "r      " & Microsoft.VisualBasic.ChrW(10) & "  GLint" & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "Long      " & Microsoft.VisualBasic.ChrW(10) & "  GLsizei" & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "Long      " & Microsoft.VisualBasic.ChrW(10) & "  GLUbyte" & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "=Byte      " & Microsoft.VisualBasic.ChrW(10) & "  GLUsh" & _
        "ort" & Microsoft.VisualBasic.ChrW(9) & "=Integer      " & Microsoft.VisualBasic.ChrW(10) & "  GLUint" & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "=Long      " & Microsoft.VisualBasic.ChrW(10) & "  GLfloat" & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "Single      " & Microsoft.VisualBasic.ChrW(10) & "  GLclampf" & Microsoft.VisualBasic.ChrW(9) & "Sing" & _
        "le      " & Microsoft.VisualBasic.ChrW(10) & "  GLdouble" & Microsoft.VisualBasic.ChrW(9) & "Double      " & Microsoft.VisualBasic.ChrW(10) & "  GLclampd" & Microsoft.VisualBasic.ChrW(9) & "Double      " & Microsoft.VisualBasic.ChrW(10) & "  GLvoid" & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "=>Interface V" & _
        "oidPointer"
        Me.RichTextBox4.WordWrap = False
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.RichTextBox5)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(208, 443)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "����������������� �����"
        Me.TabPage5.Visible = False
        '
        'RichTextBox5
        '
        Me.RichTextBox5.AcceptsTab = True
        Me.RichTextBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RichTextBox5.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox5.Name = "RichTextBox5"
        Me.RichTextBox5.ReadOnly = True
        Me.RichTextBox5.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.RichTextBox5.Size = New System.Drawing.Size(208, 442)
        Me.RichTextBox5.TabIndex = 8
        Me.RichTextBox5.Text = "�����������   |    ����    |    ����    |    ����" & Microsoft.VisualBasic.ChrW(10) & "-------------------------------" & _
        "------------------------------------------" & Microsoft.VisualBasic.ChrW(10) & "0                                0000" & _
        "               0x0                    &H0" & Microsoft.VisualBasic.ChrW(10) & "1                                0001 " & _
        "              0x1                    &H1" & Microsoft.VisualBasic.ChrW(10) & "2                                0010  " & _
        "             0x2                    &H2" & Microsoft.VisualBasic.ChrW(10) & "3                                0011   " & _
        "            0x3                    &H3" & Microsoft.VisualBasic.ChrW(10) & "4                                0100    " & _
        "           0x4                    &H4" & Microsoft.VisualBasic.ChrW(10) & "5                                0101     " & _
        "          0x5                    &H5" & Microsoft.VisualBasic.ChrW(10) & "6                                0110      " & _
        "         0x6                    &H6" & Microsoft.VisualBasic.ChrW(10) & "7                                0111       " & _
        "        0x7                    &H7" & Microsoft.VisualBasic.ChrW(10) & "8                                1000        " & _
        "       0x8                    &H8" & Microsoft.VisualBasic.ChrW(10) & "9                                1001         " & _
        "      0x9                    &H9" & Microsoft.VisualBasic.ChrW(10) & "A, a                           1010            " & _
        "   0xA                    &HA" & Microsoft.VisualBasic.ChrW(10) & "B, b                            1011              " & _
        " 0xB                    &HB" & Microsoft.VisualBasic.ChrW(10) & "C, c                            1100               0" & _
        "xC                    &HC" & Microsoft.VisualBasic.ChrW(10) & "D, d                            1101               0xD" & _
        "                    &HD" & Microsoft.VisualBasic.ChrW(10) & "E, e                            1110               0xE  " & _
        "                  &HE" & Microsoft.VisualBasic.ChrW(10) & "F, f                             1111               0xF   " & _
        "                 &HF" & Microsoft.VisualBasic.ChrW(10) & "10                             10000              0x10     " & _
        "              &H10" & Microsoft.VisualBasic.ChrW(10) & "-------------------------------------------------------------" & _
        "------------" & Microsoft.VisualBasic.ChrW(10) & "0x3E = 3 (��� 0011) � E (��� 1110) = 00111110" & Microsoft.VisualBasic.ChrW(10) & "0x3E = &H3E,   0x08 =" & _
        " &H8,   0x80 = &H80,   0xff = &HFF"
        Me.RichTextBox5.WordWrap = False
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(216, 24)
        Me.Panel4.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Location = New System.Drawing.Point(192, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "�"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(0, -6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 32)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "�������:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Splitter2
        '
        Me.Splitter2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Splitter2.Location = New System.Drawing.Point(574, 32)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(2, 497)
        Me.Splitter2.TabIndex = 7
        Me.Splitter2.TabStop = False
        '
        'Designer
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(792, 545)
        Me.Controls.Add(Me.Splitter2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.StatusBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu1
        Me.Name = "Designer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BasicGL"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Try
            Close()
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "��������� ������!")
        End Try
    End Sub

    Private Sub Designer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            TREE_UPDATE()
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "��������� ������!")
        End Try
    End Sub

    Private Sub Designer_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        End
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        Try
            ModuleCube.LoadPModule()
            ModuleCube.PModule.MdiParent = ModuleCube.DesignerCube.ActiveForm
            ModuleCube.PModule.Folder.Text = StatusBarPanel2.Text
            ModuleCube.PModule.Text = "������ OpenGL: ����� ������."
            ModuleCube.PModule.Show()
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "��������� ������!")
        End Try
    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        Try
            StatusBarPanel2.Text = TreeView1.SelectedNode.Text
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "��������� ������!")
        End Try
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Try
            MenuItem15.Checked = False
            Panel1.Visible = False
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "��������� ������!")
        End Try
    End Sub

    Public Sub TREE_UPDATE()
        Try
            OleDbConnection1.ConnectionString = ModuleBase.StringConnection1 + ModuleBase.PathBase + ModuleBase.StringConnection2 + ModuleBase.StringConnection3 + ModuleBase.StringConnection4
            OleDbConnection1.Open()
            DataSet11.Clear()
            DataSet21.Clear()
            OleDbDataAdapter1.Fill(DataSet11, "������")
            OleDbDataAdapter1.Fill(DataSet21, "������")
            '�������� ������
            Dim NameGr As String
            Dim ActionGr, ActionEl As Integer
            Dim NextGr As Boolean = False
            TreeView1.Nodes.Clear()
            For i As Integer = 0 To DataSet11.������.Rows.Count - 1
                If (DataSet11.������.Item(i)("���") = "������") Then
                    NameGr = DataSet11.������.Item(i)("������")
                    TreeView1.Nodes.Add(NameGr)
                    TreeView1.Nodes.Item(ActionGr).ImageIndex = 0
                    TreeView1.Nodes.Item(ActionGr).SelectedImageIndex = 1
                    ActionGr = ActionGr + 1
                    NextGr = True
                End If

                If (NextGr = True) Then
                    ActionEl = 0
                    For iEl As Integer = 0 To DataSet21.������.Rows.Count - 1
                        If (DataSet21.������.Item(iEl)("������") = NameGr) And (DataSet21.������.Item(iEl)("���") = "�������") Then
                            TreeView1.Nodes.Item(ActionGr - 1).Nodes.Add(DataSet21.������.Item(iEl)("�������������"))
                            TreeView1.Nodes.Item(ActionGr - 1).Nodes.Item(ActionEl).ImageIndex = 2
                            TreeView1.Nodes.Item(ActionGr - 1).Nodes.Item(ActionEl).SelectedImageIndex = 2
                            ActionEl = ActionEl + 1
                        End If
                    Next
                    NextGr = False
                End If
            Next
            OleDbConnection1.Close()
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "��������� ������!")
        End Try
    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        Try
            Dim NewFolder As String
            Dim PoliticNewFolder As Boolean = False
            NewFolder = InputBox("������� ��� ����� �����.", "����� �����", "")
            If NewFolder <> "" Then
                '�������� ������������ ����� �����
                For i As Integer = 0 To DataSet11.������.Count - 1
                    If (DataSet11.������.Item(i)("�������������") = NewFolder) Then
                        PoliticNewFolder = True
                        MsgBox("��� ����� �� ���������!!! ������� ������ ��� �����.", MsgBoxStyle.OKOnly, "���������:")
                    End If
                Next
                If (PoliticNewFolder = False) Then
                    OleDbConnection1.Open()
                    Dim DT As DataTable = DataSet11.������
                    Dim row As DataRow
                    row = DT.NewRow
                    row("���") = "������"
                    row("������") = NewFolder.ToString
                    row("�������������") = NewFolder.ToString
                    row("������") = ""
                    row("����������������������") = ""
                    row("��������") = ""
                    DT.Rows.Add(row)
                    OleDbDataAdapter1.Update(DataSet11, "������")
                    OleDbConnection1.Close()
                    TREE_UPDATE()
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "��������� ������!")
        End Try
    End Sub

    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        Try
            If (MenuItem15.Checked = True) Then
                MenuItem15.Checked = False
                Panel1.Visible = False
            Else
                MenuItem15.Checked = True
                Panel1.Visible = True
                TREE_UPDATE()
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "��������� ������!")
        End Try
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        Try
            If (ModuleCube.AboutShow = False) Then
                Dim Ab As New About
                Ab.MdiParent = ModuleCube.DesignerCube
                Ab.Show()
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "��������� ������!")
        End Try
    End Sub

    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        Try
            For iTest As Integer = 0 To DataSet11.������.Count - 1
                If (DataSet11.������.Item(iTest)("�������������") = StatusBarPanel2.Text) Then
                    If (DataSet11.������.Item(iTest)("���") = "������") Then
                        Dim NewFolder As String
                        Dim EditFolder As String
                        Dim PoliticNewFolder As Boolean = False
                        Dim FindEditFolder As Boolean = False
                        EditFolder = TreeView1.SelectedNode.Text
                        NewFolder = InputBox("������� ����� ��� �����.", "������������� ����� : [" + EditFolder + "]", EditFolder)
                        If NewFolder <> "" Then
                            '�������� ������������ ����� �����
                            For i As Integer = 0 To DataSet11.������.Count - 1
                                If (DataSet11.������.Item(i)("�������������") = NewFolder) Then
                                    PoliticNewFolder = True
                                    MsgBox("��� ����� �� ���������!!! ������� ������ ��� �����.", MsgBoxStyle.OKOnly, "���������:")
                                End If
                                If (DataSet11.������.Item(i)("���") = "������") And (DataSet11.������.Item(i)("�������������") = EditFolder) Then
                                    FindEditFolder = True
                                End If
                            Next
                            If (PoliticNewFolder = False) Then
                                If (FindEditFolder = True) Then
                                    OleDbConnection1.Open()
                                    For iEdit As Integer = 0 To DataSet11.������.Count - 1
                                        If (DataSet11.������.Item(iEdit)("���") = "������") And (DataSet11.������.Item(iEdit)("�������������") = EditFolder) Then
                                            DataSet11.������.Item(iEdit)("�������������") = NewFolder
                                            DataSet11.������.Item(iEdit)("������") = NewFolder
                                        End If
                                        If (DataSet11.������.Item(iEdit)("���") = "�������") And (DataSet11.������.Item(iEdit)("������") = EditFolder) Then
                                            DataSet11.������.Item(iEdit)("������") = NewFolder
                                        End If
                                    Next
                                    OleDbDataAdapter1.Update(DataSet11, "������")
                                    OleDbConnection1.Close()
                                    TREE_UPDATE()
                                    MsgBox("����� ������� ��������������.", MsgBoxStyle.OKOnly, "���������:")
                                Else
                                    MsgBox("������!!! " + "[" + EditFolder + "] �� �������� ������!", MsgBoxStyle.OKOnly, "���������:")
                                End If
                            End If
                        End If
                        Exit For
                    End If
                End If
            Next

        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "��������� ������!")
        End Try
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Try
            Select Case ToolBar1.Buttons.IndexOf(e.Button)
                Case 0

                Case 1
                    If (MenuItem15.Checked = True) Then
                        MenuItem15.Checked = False
                        Panel1.Visible = False
                    Else
                        MenuItem15.Checked = True
                        Panel1.Visible = True
                        TREE_UPDATE()
                    End If
                Case 2
                    Dim OpenFile As New FileManager
                    OpenFile.Text = "������� ���� � ������."
                    OpenFile.Button1.Text = "�������."
                    OpenFile.MdiParent = ModuleCube.DesignerCube.ActiveForm
                    OpenFile.Show()
                Case 3
                    '..........................
                Case 4
                    '����� �����
                    Dim NewFolder As String
                    Dim PoliticNewFolder As Boolean = False
                    NewFolder = InputBox("������� ��� ����� �����.", "����� �����", "")
                    If NewFolder <> "" Then
                        '�������� ������������ ����� �����
                        For i As Integer = 0 To DataSet11.������.Count - 1
                            If (DataSet11.������.Item(i)("�������������") = NewFolder) Then
                                PoliticNewFolder = True
                                MsgBox("��� ����� �� ���������!!! ������� ������ ��� �����.", MsgBoxStyle.OKOnly, "���������:")
                            End If
                        Next
                        If (PoliticNewFolder = False) Then
                            OleDbConnection1.Open()
                            Dim DT As DataTable = DataSet11.������
                            Dim row As DataRow
                            row = DT.NewRow
                            row("���") = "������"
                            row("������") = NewFolder.ToString
                            row("�������������") = NewFolder.ToString
                            row("������") = ""
                            row("����������������������") = ""
                            row("��������") = ""
                            DT.Rows.Add(row)
                            OleDbDataAdapter1.Update(DataSet11, "������")
                            OleDbConnection1.Close()
                            TREE_UPDATE()
                        End If
                    End If
                Case 5
                    '��������������
                        For iTest As Integer = 0 To DataSet11.������.Count - 1
                            If (DataSet11.������.Item(iTest)("�������������") = StatusBarPanel2.Text) Then
                                If (DataSet11.������.Item(iTest)("���") = "������") Then
                                    Dim NewFolder As String
                                    Dim EditFolder As String
                                    Dim PoliticNewFolder As Boolean = False
                                    Dim FindEditFolder As Boolean = False
                                    EditFolder = TreeView1.SelectedNode.Text
                                    NewFolder = InputBox("������� ����� ��� �����.", "������������� ����� : [" + EditFolder + "]", EditFolder)
                                    If NewFolder <> "" Then
                                        '�������� ������������ ����� �����
                                        For i As Integer = 0 To DataSet11.������.Count - 1
                                            If (DataSet11.������.Item(i)("�������������") = NewFolder) Then
                                                PoliticNewFolder = True
                                                MsgBox("��� ����� �� ���������!!! ������� ������ ��� �����.", MsgBoxStyle.OKOnly, "���������:")
                                            End If
                                            If (DataSet11.������.Item(i)("���") = "������") And (DataSet11.������.Item(i)("�������������") = EditFolder) Then
                                                FindEditFolder = True
                                            End If
                                        Next
                                        If (PoliticNewFolder = False) Then
                                            If (FindEditFolder = True) Then
                                                OleDbConnection1.Open()
                                                For iEdit As Integer = 0 To DataSet11.������.Count - 1
                                                    If (DataSet11.������.Item(iEdit)("���") = "������") And (DataSet11.������.Item(iEdit)("�������������") = EditFolder) Then
                                                        DataSet11.������.Item(iEdit)("�������������") = NewFolder
                                                        DataSet11.������.Item(iEdit)("������") = NewFolder
                                                    End If
                                                    If (DataSet11.������.Item(iEdit)("���") = "�������") And (DataSet11.������.Item(iEdit)("������") = EditFolder) Then
                                                        DataSet11.������.Item(iEdit)("������") = NewFolder
                                                    End If
                                                Next
                                                OleDbDataAdapter1.Update(DataSet11, "������")
                                                OleDbConnection1.Close()
                                                TREE_UPDATE()
                                                MsgBox("����� ������� ��������������.", MsgBoxStyle.OKOnly, "���������:")
                                            Else
                                                MsgBox("������!!! " + "[" + EditFolder + "] �� �������� ������!", MsgBoxStyle.OKOnly, "���������:")
                                            End If
                                        End If
                                    End If
                                    Exit For
                                End If
                            End If
                        Next
                Case 6
                    '��������
                    Dim DelFolder As String
                    Dim FindEditFolder As Boolean = False
                    DelFolder = TreeView1.SelectedNode.Text
                    If (MsgBox("�� ������� ��� ������ ������� ����� [" + DelFolder + "] � � ����������?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes) Then
                        For i As Integer = 0 To DataSet11.������.Count - 1
                            If (DataSet11.������.Item(i)("���") = "������") And (DataSet11.������.Item(i)("�������������") = DelFolder) Then
                                FindEditFolder = True
                            End If
                        Next
                        If (FindEditFolder = True) Then
                            OleDbConnection1.Open()
                            For iDelEl As Integer = 0 To DataSet11.������.Count - 1
                                If (DataSet11.������.Item(iDelEl)("���") = "�������") And (DataSet11.������.Item(iDelEl)("������") = DelFolder) Then
                                    DataSet11.������.Item(iDelEl).Delete()
                                End If
                            Next
                            For iDelFolder As Integer = 0 To DataSet21.������.Count - 1
                                If (DataSet21.������.Item(iDelFolder)("���") = "������") And (DataSet21.������.Item(iDelFolder)("�������������") = DelFolder) Then
                                    DataSet21.������.Item(iDelFolder).Delete()
                                End If
                            Next
                            OleDbDataAdapter1.Update(DataSet11, "������")
                            OleDbDataAdapter1.Update(DataSet21, "������")
                            OleDbConnection1.Close()
                            TREE_UPDATE()
                            MsgBox("�������� ������ �������.", MsgBoxStyle.OKOnly, "���������:")
                        Else
                            MsgBox("������!!! " + "[" + DelFolder + "] �� �������� ������!", MsgBoxStyle.OKOnly, "���������:")
                        End If
                    End If
                Case 7
                    '.......
                Case 8
                    ModuleCube.LoadPModule()
                    ModuleCube.PModule.MdiParent = ModuleCube.DesignerCube.ActiveForm
                    ModuleCube.PModule.Folder.Text = StatusBarPanel2.Text
                    ModuleCube.PModule.Text = "������ OpenGL: ����� ������."
                    ModuleCube.PModule.Show()
                Case 9
                    For i As Integer = 0 To DataSet11.������.Count - 1
                        If (DataSet11.������.Item(i)("�������������") = StatusBarPanel2.Text) Then
                            If (DataSet11.������.Item(i)("���") = "�������") Then
                                ModuleCube.LoadPModule()
                                ModuleCube.PModule.MdiParent = ModuleCube.DesignerCube.ActiveForm
                                ModuleCube.PModule.ActionModuleName = StatusBarPanel2.Text
                                ModuleCube.PModule.Text = "������ OpenGL: �������������."
                                ModuleCube.PModule.Show()
                                Exit For
                            End If
                        End If
                    Next
                Case 10
                    '������� ������
                    Dim DelModule As Boolean = False
                    If (MsgBox("�� ������� ��� ������ ������� ������ [" + StatusBarPanel2.Text + "]?", MsgBoxStyle.YesNo, "������: ") = MsgBoxResult.Yes) Then
                        For i As Integer = 0 To DataSet11.������.Count - 1
                            If (DataSet11.������.Item(i)("���") = "�������") And (DataSet11.������.Item(i)("�������������") = StatusBarPanel2.Text) Then
                                OleDbConnection1.Open()
                                DataSet11.������.Item(i).Delete()
                                OleDbDataAdapter1.Update(DataSet11, "������")
                                OleDbConnection1.Close()
                                DelModule = True
                                Exit For
                            End If
                        Next
                        If (DelModule = True) Then
                            TREE_UPDATE()
                            MsgBox("�������� ������ �������.", MsgBoxStyle.OKOnly, "���������:")
                        Else
                            MsgBox("������!!! " + "[" + StatusBarPanel2.Text + "] �� �������� �������!", MsgBoxStyle.OKOnly, "���������:")
                        End If
                    End If
                Case 11
                    '...
                Case 12
                    If (ModuleCube.AboutShow = False) Then
                        Dim Ab As New About
                        Ab.MdiParent = ModuleCube.DesignerCube
                        Ab.Show()
                    End If
            End Select
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "��������� ������!")
        End Try
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        Try
            Dim OpenFile As New FileManager
            OpenFile.Text = "������� ���� � ������."
            OpenFile.Button1.Text = "�������."
            OpenFile.MdiParent = ModuleCube.DesignerCube.ActiveForm
            OpenFile.Show()
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "��������� ������!")
        End Try
    End Sub

    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        '��������
        Try
            Dim DelFolder As String
            Dim FindEditFolder As Boolean = False
            DelFolder = TreeView1.SelectedNode.Text
            If (MsgBox("�� ������� ��� ������ ������� ����� [" + DelFolder + "] � � ����������?", MsgBoxStyle.YesNo, "������: ") = MsgBoxResult.Yes) Then
                For i As Integer = 0 To DataSet11.������.Count - 1
                    If (DataSet11.������.Item(i)("���") = "������") And (DataSet11.������.Item(i)("�������������") = DelFolder) Then
                        FindEditFolder = True
                    End If
                Next
                If (FindEditFolder = True) Then
                    OleDbConnection1.Open()
                    For iDelEl As Integer = 0 To DataSet11.������.Count - 1
                        If (DataSet11.������.Item(iDelEl)("���") = "�������") And (DataSet11.������.Item(iDelEl)("������") = DelFolder) Then
                            DataSet11.������.Item(iDelEl).Delete()
                        End If
                    Next
                    For iDelFolder As Integer = 0 To DataSet21.������.Count - 1
                        If (DataSet21.������.Item(iDelFolder)("���") = "������") And (DataSet21.������.Item(iDelFolder)("�������������") = DelFolder) Then
                            DataSet21.������.Item(iDelFolder).Delete()
                        End If
                    Next
                    OleDbDataAdapter1.Update(DataSet11, "������")
                    OleDbDataAdapter1.Update(DataSet21, "������")
                    OleDbConnection1.Close()
                    TREE_UPDATE()
                    MsgBox("�������� ������ �������.", MsgBoxStyle.OKOnly, "���������:")
                Else
                    MsgBox("������!!! " + "[" + DelFolder + "] �� �������� ������!", MsgBoxStyle.OKOnly, "���������:")
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "��������� ������!")
        End Try
    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        Try
            For i As Integer = 0 To DataSet11.������.Count - 1
                If (DataSet11.������.Item(i)("�������������") = StatusBarPanel2.Text) Then
                    If (DataSet11.������.Item(i)("���") = "�������") Then
                        ModuleCube.LoadPModule()
                        ModuleCube.PModule.MdiParent = ModuleCube.DesignerCube.ActiveForm
                        ModuleCube.PModule.ActionModuleName = StatusBarPanel2.Text
                        ModuleCube.PModule.Text = "������ OpenGL: �������������."
                        ModuleCube.PModule.Show()
                        Exit For
                    End If
                End If
            Next
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "��������� ������!")
        End Try
    End Sub

    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        '������� ������
        Try
            Dim DelModule As Boolean = False
            If (MsgBox("�� ������� ��� ������ ������� ������ [" + StatusBarPanel2.Text + "]?", MsgBoxStyle.YesNo, "������: ") = MsgBoxResult.Yes) Then
                For i As Integer = 0 To DataSet11.������.Count - 1
                    If (DataSet11.������.Item(i)("���") = "�������") And (DataSet11.������.Item(i)("�������������") = StatusBarPanel2.Text) Then
                        OleDbConnection1.Open()
                        DataSet11.������.Item(i).Delete()
                        OleDbDataAdapter1.Update(DataSet11, "������")
                        OleDbConnection1.Close()
                        DelModule = True
                        Exit For
                    End If
                Next
                If (DelModule = True) Then
                    TREE_UPDATE()
                    MsgBox("�������� ������ �������.", MsgBoxStyle.OKOnly, "���������:")
                Else
                    MsgBox("������!!! " + "[" + StatusBarPanel2.Text + "] �� �������� �������!", MsgBoxStyle.OKOnly, "���������:")
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "��������� ������!")
        End Try
    End Sub

    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        Try
            ModuleCube.LoadPModule()
            ModuleCube.PModule.MdiParent = ModuleCube.DesignerCube.ActiveForm
            ModuleCube.PModule.Folder.Text = StatusBarPanel2.Text
            ModuleCube.PModule.Text = "������ OpenGL: ����� ������."
            ModuleCube.PModule.Show()
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "��������� ������!")
        End Try
    End Sub

    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        Try
            For i As Integer = 0 To DataSet11.������.Count - 1
                If (DataSet11.������.Item(i)("�������������") = StatusBarPanel2.Text) Then
                    If (DataSet11.������.Item(i)("���") = "�������") Then
                        ModuleCube.LoadPModule()
                        ModuleCube.PModule.MdiParent = ModuleCube.DesignerCube.ActiveForm
                        ModuleCube.PModule.ActionModuleName = StatusBarPanel2.Text
                        ModuleCube.PModule.Text = "������ OpenGL: �������������."
                        ModuleCube.PModule.Show()
                        Exit For
                    End If
                End If
            Next
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "��������� ������!")
        End Try
    End Sub

    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        '������� ������
        Try
            Dim DelModule As Boolean = False
            If (MsgBox("�� ������� ��� ������ ������� ������ [" + StatusBarPanel2.Text + "]?", MsgBoxStyle.YesNo, "������: ") = MsgBoxResult.Yes) Then
                For i As Integer = 0 To DataSet11.������.Count - 1
                    If (DataSet11.������.Item(i)("���") = "�������") And (DataSet11.������.Item(i)("�������������") = StatusBarPanel2.Text) Then
                        OleDbConnection1.Open()
                        DataSet11.������.Item(i).Delete()
                        OleDbDataAdapter1.Update(DataSet11, "������")
                        OleDbConnection1.Close()
                        DelModule = True
                        Exit For
                    End If
                Next
                If (DelModule = True) Then
                    TREE_UPDATE()
                    MsgBox("�������� ������ �������.", MsgBoxStyle.OKOnly, "���������:")
                Else
                    MsgBox("������!!! " + "[" + StatusBarPanel2.Text + "] �� �������� �������!", MsgBoxStyle.OKOnly, "���������:")
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "��������� ������!")
        End Try
    End Sub

    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        Try
            Dim NewFolder As String
            Dim PoliticNewFolder As Boolean = False
            NewFolder = InputBox("������� ��� ����� �����.", "����� �����", "")
            If NewFolder <> "" Then
                '�������� ������������ ����� �����
                For i As Integer = 0 To DataSet11.������.Count - 1
                    If (DataSet11.������.Item(i)("�������������") = NewFolder) Then
                        PoliticNewFolder = True
                        MsgBox("��� ����� �� ���������!!! ������� ������ ��� �����.", MsgBoxStyle.OKOnly, "���������:")
                    End If
                Next
                If (PoliticNewFolder = False) Then
                    OleDbConnection1.Open()
                    Dim DT As DataTable = DataSet11.������
                    Dim row As DataRow
                    row = DT.NewRow
                    row("���") = "������"
                    row("������") = NewFolder.ToString
                    row("�������������") = NewFolder.ToString
                    row("������") = ""
                    row("����������������������") = ""
                    row("��������") = ""
                    DT.Rows.Add(row)
                    OleDbDataAdapter1.Update(DataSet11, "������")
                    OleDbConnection1.Close()
                    TREE_UPDATE()
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "��������� ������!")
        End Try
    End Sub

    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        Try
            For iTest As Integer = 0 To DataSet11.������.Count - 1
                If (DataSet11.������.Item(iTest)("�������������") = StatusBarPanel2.Text) Then
                    If (DataSet11.������.Item(iTest)("���") = "������") Then
                        Dim NewFolder As String
                        Dim EditFolder As String
                        Dim PoliticNewFolder As Boolean = False
                        Dim FindEditFolder As Boolean = False
                        EditFolder = TreeView1.SelectedNode.Text
                        NewFolder = InputBox("������� ����� ��� �����.", "������������� ����� : [" + EditFolder + "]", EditFolder)
                        If NewFolder <> "" Then
                            '�������� ������������ ����� �����
                            For i As Integer = 0 To DataSet11.������.Count - 1
                                If (DataSet11.������.Item(i)("�������������") = NewFolder) Then
                                    PoliticNewFolder = True
                                    MsgBox("��� ����� �� ���������!!! ������� ������ ��� �����.", MsgBoxStyle.OKOnly, "���������:")
                                End If
                                If (DataSet11.������.Item(i)("���") = "������") And (DataSet11.������.Item(i)("�������������") = EditFolder) Then
                                    FindEditFolder = True
                                End If
                            Next
                            If (PoliticNewFolder = False) Then
                                If (FindEditFolder = True) Then
                                    OleDbConnection1.Open()
                                    For iEdit As Integer = 0 To DataSet11.������.Count - 1
                                        If (DataSet11.������.Item(iEdit)("���") = "������") And (DataSet11.������.Item(iEdit)("�������������") = EditFolder) Then
                                            DataSet11.������.Item(iEdit)("�������������") = NewFolder
                                            DataSet11.������.Item(iEdit)("������") = NewFolder
                                        End If
                                        If (DataSet11.������.Item(iEdit)("���") = "�������") And (DataSet11.������.Item(iEdit)("������") = EditFolder) Then
                                            DataSet11.������.Item(iEdit)("������") = NewFolder
                                        End If
                                    Next
                                    OleDbDataAdapter1.Update(DataSet11, "������")
                                    OleDbConnection1.Close()
                                    TREE_UPDATE()
                                    MsgBox("����� ������� ��������������.", MsgBoxStyle.OKOnly, "���������:")
                                Else
                                    MsgBox("������!!! " + "[" + EditFolder + "] �� �������� ������!", MsgBoxStyle.OKOnly, "���������:")
                                End If
                            End If
                        End If
                        Exit For
                    End If
                End If
            Next

        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "��������� ������!")
        End Try
    End Sub

    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        '��������
        Try
            Dim DelFolder As String
            Dim FindEditFolder As Boolean = False
            DelFolder = TreeView1.SelectedNode.Text
            If (MsgBox("�� ������� ��� ������ ������� ����� [" + DelFolder + "] � � ����������?", MsgBoxStyle.YesNo, "������: ") = MsgBoxResult.Yes) Then
                For i As Integer = 0 To DataSet11.������.Count - 1
                    If (DataSet11.������.Item(i)("���") = "������") And (DataSet11.������.Item(i)("�������������") = DelFolder) Then
                        FindEditFolder = True
                    End If
                Next
                If (FindEditFolder = True) Then
                    OleDbConnection1.Open()
                    For iDelEl As Integer = 0 To DataSet11.������.Count - 1
                        If (DataSet11.������.Item(iDelEl)("���") = "�������") And (DataSet11.������.Item(iDelEl)("������") = DelFolder) Then
                            DataSet11.������.Item(iDelEl).Delete()
                        End If
                    Next
                    For iDelFolder As Integer = 0 To DataSet21.������.Count - 1
                        If (DataSet21.������.Item(iDelFolder)("���") = "������") And (DataSet21.������.Item(iDelFolder)("�������������") = DelFolder) Then
                            DataSet21.������.Item(iDelFolder).Delete()
                        End If
                    Next
                    OleDbDataAdapter1.Update(DataSet11, "������")
                    OleDbDataAdapter1.Update(DataSet21, "������")
                    OleDbConnection1.Close()
                    TREE_UPDATE()
                    MsgBox("�������� ������ �������.", MsgBoxStyle.OKOnly, "���������:")
                Else
                    MsgBox("������!!! " + "[" + DelFolder + "] �� �������� ������!", MsgBoxStyle.OKOnly, "���������:")
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "��������� ������!")
        End Try
    End Sub

    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        Dim LProgramm As New License
        If (ModuleCube.LicenseShow = False) Then
            LProgramm.MdiParent = ModuleCube.DesignerCube
            LProgramm.Show()
        End If
    End Sub

    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        If (ModuleCube.SettingsShow = False) Then
            Dim SettingProg As New Settings
            SettingProg.MdiParent = ModuleCube.DesignerCube
            SettingProg.Show()
        End If
    End Sub

    Private Sub TreeView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeView1.DoubleClick
        Try
            For i As Integer = 0 To DataSet11.������.Count - 1
                If (DataSet11.������.Item(i)("�������������") = StatusBarPanel2.Text) Then
                    If (DataSet11.������.Item(i)("���") = "�������") Then
                        ModuleCube.LoadPModule()
                        ModuleCube.PModule.MdiParent = ModuleCube.DesignerCube.ActiveForm
                        ModuleCube.PModule.ActionModuleName = StatusBarPanel2.Text
                        ModuleCube.PModule.Text = "������ OpenGL: �������������."
                        ModuleCube.PModule.Show()
                        Exit For
                    End If
                End If
            Next
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "��������� ������!")
        End Try
    End Sub

    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        Dim Book As New BookVB
        Book.MdiParent = ModuleCube.DesignerCube
        Book.Show()
    End Sub

    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        If (Panel3.Visible = False) Then
            Panel3.Visible = True
        Else
            Panel3.Visible = False
        End If
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Try
            Panel3.Visible = False
        Catch ex As Exception
            'MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "��������� ������!")
        End Try
    End Sub
End Class
