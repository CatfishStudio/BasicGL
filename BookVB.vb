Public Class BookVB
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents RichTextBox3 As System.Windows.Forms.RichTextBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents RichTextBox4 As System.Windows.Forms.RichTextBox
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents RichTextBox5 As System.Windows.Forms.RichTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(BookVB))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.RichTextBox4 = New System.Windows.Forms.RichTextBox
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.RichTextBox5 = New System.Windows.Forms.RichTextBox
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(544, 48)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(360, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "����������"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.TabControl1.Location = New System.Drawing.Point(0, 48)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(544, 296)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.RichTextBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(456, 235)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "���� VB"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.RichTextBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(456, 235)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "OpenGL"
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
        Me.RichTextBox1.Size = New System.Drawing.Size(456, 234)
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
        "ext" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "For Each MyObject As Object In MyCollection " & Microsoft.VisualBasic.ChrW(10) & "   " & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "[��������]" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Next" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "'����" & _
        "����� ���� ���������� � �������������� �������� ��� ������� ��� ���������." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "With" & _
        " MyLabel" & Microsoft.VisualBasic.ChrW(10) & "   " & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & ".Height = 2000" & Microsoft.VisualBasic.ChrW(10) & "   " & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & ".Width = 2000" & Microsoft.VisualBasic.ChrW(10) & "   " & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & ".Text = ""This is MyLabel""" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & _
        "End With" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "'������ ������������� ���������� ����� ����������, ��������� ��������" & _
        " ������������ ��������� �������, ������� ��� Boolean." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim Number As Integer = 1" & _
        "0" & Microsoft.VisualBasic.ChrW(10) & "   " & Microsoft.VisualBasic.ChrW(9) & "While Number > 6" & Microsoft.VisualBasic.ChrW(10) & "      " & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "Number = Number - 1" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "End While" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "'������ �������" & _
        "������ ���������� ����� ����������, ��������� �������� ������������ ��������� ��" & _
        "�����, ������� ��� Boolean." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim Number As Integer = 10" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Do While Number > 6" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "N" & _
        "umber = Number - 1" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Loop" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "'��� ����������� ����" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Do" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "[��������]" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Loop" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "-------" & _
        "------------------------------------------------------------" & Microsoft.VisualBasic.ChrW(10) & "6)��������� �������" & _
        "���� ������ � ��������." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Exit For" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Exit Sub" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "----------------------------------" & _
        "---------------------------------" & Microsoft.VisualBasic.ChrW(10) & "7)�������." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim i1(10) as integer '���������� " & _
        "������." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim i2x2(10, 10) as integer '����� ������ ������." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "i1(0) = 25" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "i2x2(0, " & _
        "0) = 25" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Private Structure Matrix3x3" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "Public Matrix(,) As Single '����������� " & _
        "������" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "End Structure" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "'���������� ��������� ��������� ��� ��������� ����������" & Microsoft.VisualBasic.ChrW(10) & _
        "" & Microsoft.VisualBasic.ChrW(9) & "Dim M1 as Matrix3x3" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "M1.Matrix(0, 0) = 10.0" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "M1.Matrix(0, 1) = 0.0" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "-----------" & _
        "--------------------------------------------------------" & Microsoft.VisualBasic.ChrW(10) & "8)�������������� ������" & _
        "�." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim Theta as double" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Cos = Math.Cos(Theta)" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Sin = Math.Sin(Theta)" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "---------" & _
        "----------------------------------------------------------" & Microsoft.VisualBasic.ChrW(10) & "9)�������� ��������." & Microsoft.VisualBasic.ChrW(10) & _
        "" & Microsoft.VisualBasic.ChrW(9) & "Private Sub [���_���������](ByVal [���_����������] as [���])" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "..." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "End Sub" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Pu" & _
        "blic Sub [���_���������](ByVal [���_����������] as [���])" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "..." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "End Sub" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "-------" & _
        "------------------------------------------------------------" & Microsoft.VisualBasic.ChrW(10) & "10)������� ������ �" & _
        "�������.  Nothing" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim s as string" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "s = Nothing" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "-------------------------------" & _
        "------------------------------------" & Microsoft.VisualBasic.ChrW(10) & "11)����������� �����." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim bitShape As Byte" & _
        "() = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11}" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim bitShape As Byte() = {&H1C, &H0" & _
        ", &H1C, &H0, &H1C, &H0, &H1C, &H0, &H1C, &H0, &HFF, &H80, &H7F, &H0, &H3E, &H0, " & _
        "&H1C, &H0, &H8, &H0}" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Private Shared hexDigits As Char() =  {""0""c, ""1""c, ""2""c, """ & _
        "3""c, ""4""c, ""5""c, ""6""c, ""7""c, ""8""c, ""9""c, ""A""c, ""B""c, ""C""c, ""D""c, ""E""c, ""F""c}" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "--" & _
        "-----------------------------------------------------------------" & Microsoft.VisualBasic.ChrW(10) & "12)�����������" & _
        " �������� � ������� �� ������� ������ dll" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Public Declare Sub glClear Lib ""openg" & _
        "l32.dll"" Alias ""glClear"" (ByVal bufferMasks As Integer)" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Public Declare Function" & _
        " wglCreateContext Lib ""opengl32.dll"" Alias ""wglCreateContext"" (ByVal deviceConte" & _
        "xt As System.IntPtr) As System.IntPtr"
        Me.RichTextBox1.WordWrap = False
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
        Me.RichTextBox2.Size = New System.Drawing.Size(456, 234)
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
        "                               'z_near, z_far - ���������� ��������� ��������� �" & _
        "� ������(near) �� ������(far) (���Z)" & Microsoft.VisualBasic.ChrW(10) & "Gl.glFrustum(-40.0, 40.0, -60.0, 60.0, 25.0" & _
        ", 125.0) '������������ ������������� �������� (left, right, bottom, top, znear, " & _
        "zfar)" & Microsoft.VisualBasic.ChrW(10) & "                                                    'x_left, x_right - ���" & _
        "������� ��������� ��������� �����(left) �� �����(right) (����)" & Microsoft.VisualBasic.ChrW(10) & "                 " & _
        "                                   'y_button, y_top - ���������� ��������� �����" & _
        "���� �����(button) � �����(top) (���Y)" & Microsoft.VisualBasic.ChrW(10) & "                                         " & _
        "           'z_near, z_far - ���������� ��������� ��������� �� ������(near) �� ��" & _
        "����(far) (���Z)" & Microsoft.VisualBasic.ChrW(10) & "Gl.glTranslatef(10.0, 0.0, 0.0) '���������� (�����������) �� ��" & _
        "�� (�, Y, Z)" & Microsoft.VisualBasic.ChrW(10) & "Gl.glRotatef(10, 0.0, 0.0, 1.0) '������� (����, X, Y, Z)" & Microsoft.VisualBasic.ChrW(10) & "Gl.glScale" & _
        "f(0.9, 0.9, 0.9) '��������� ��������. (X, Y, Z). ���������� �������� 1.1 � �����" & _
        "����� �������� 0.9" & Microsoft.VisualBasic.ChrW(10) & "Gl.glRectf(-20, -20, 20, 20) '������ ����������� ������� � 2D" & _
        " �����������" & Microsoft.VisualBasic.ChrW(10) & "Gl.glEnableClientState(Gl.GL_VERTEX_ARRAY) - ������������ ���������" & _
        "�� ��������� ������ ������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glVertexPointer(3, Gl.GL_INT, 0, pt) - �������� �" & _
        "����� ������������ ��������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glDrawElements(Gl.GL_QUADS, 23, Gl.GL_UNSIGNED_B" & _
        "YTE, verts) - ������������ �������� ��� ��������� �� ������� ������" & Microsoft.VisualBasic.ChrW(10) & "Gl.glPixelSt" & _
        "orei(Gl.GL_UNPACK_ALIGNMENT, 1) '������������� ����� �������� ��������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glRas" & _
        "terPos2i(0, 0) '������ ���������� ������������ ������� �������� �����������" & Microsoft.VisualBasic.ChrW(10) & "Gl.g" & _
        "lBitmap(9, 10, 0.0, 0.0, 20.0, 15.0, bitShape) '���������� ������� �����������" & Microsoft.VisualBasic.ChrW(10) & "G" & _
        "l.glGenLists(1) '������� ����������� ������������� �������������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glNewList(r" & _
        "egHex, Gl.GL_COMPILE) '��������� ������� �����������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glEndList() '��������� " & _
        "������� �����������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glCallList(regHex) '���������� ������� �����������." & Microsoft.VisualBasic.ChrW(10) & "Gl.g" & _
        "lIsList(listID) '���������� ������������ �� ������ ����� ����� � �������� ����� " & _
        "�������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glListBase(0) '�������� �������� �������� ��� ������� ��������������" & _
        "� ������ �����������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glDeleteLists(startID, nLists) '������� ����� ���������" & _
        " ���� �� ������ ������ �����������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glPointSize(50.0) '��������� ������� ����" & _
        "�." & Microsoft.VisualBasic.ChrW(10) & "Gl.glLineWidth(10.0) '��������� ������ �����." & Microsoft.VisualBasic.ChrW(10) & "Gl.glLineStipple(1, 5) '�������" & _
        "�� ����� �����." & Microsoft.VisualBasic.ChrW(10) & "Gl.glIndexi(196) '��������� ���� ����������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glShadeModel(Gl." & _
        "GL_SMOOTH) '������� ����������� ����������� �����" & Microsoft.VisualBasic.ChrW(10) & "Gl.glShadeModel(Gl.GL_FLAT) '�" & _
        "������ ����������� ������ �����" & Microsoft.VisualBasic.ChrW(10) & "Gl.glPolygonStipple(fillPattern) '������ ����� �" & _
        "������� ������� �����." & Microsoft.VisualBasic.ChrW(10) & "Gl.glEnable(Gl.GL_POLYGON_STIPPLE) '�������� ��������� ��" & _
        "����������" & Microsoft.VisualBasic.ChrW(10) & "Gl.glShadeModel(Gl.GL_SMOOTH) '���������������� ������������. ���� ��" & _
        "���������� GL_FLAT -������ ����� �������� ����� ��������� ������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glEnable(Gl" & _
        ".GL_LINE_SMOOTH) '����������� ��������� ���������� ���������� GL_POINT_SMOOTH, G" & _
        "L_LINE_SMOOTH, GL_POLYGON_SMOOTH" & Microsoft.VisualBasic.ChrW(10) & "Gl.glEnable(Gl.GL_BLEND) '���� ����� ����� RGBA" & _
        " ����� �������������� �������� ���������� ������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glBlendFunc(Gl.GL_SRC_ALPHA" & _
        ", Gl.GL_ONE_MINUS_SRC_ALPHA) '����������� ����� ���������� ������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glGetFloat" & _
        "v(Gl.GL_RED_BITS, GetR_Bitas) '���������� ������� �������� ��������" & Microsoft.VisualBasic.ChrW(10) & "Gl.glGetInte" & _
        "gerv(Gl.GL_MAX_MODELVIEW_STACK_DEPTH, StackSize) '���������� ����� �������, ����" & _
        "������ � ����� ��������� ��������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glGetIntegerv(Gl.GL_MODELVIEW_STACK_DEPTH," & _
        " numMatrix) '���������� ������� ������ � ��������� ������ ��������� � �����." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "Gl" & _
        ".glPushAttrib(Gl.GL_POINT_BIT And Gl.GL_LIST_BIT And Gl.GL_POLYGON_BIT) '�������" & _
        "�� ��������� �� ���������� �����." & Microsoft.VisualBasic.ChrW(10) & "Gl.glPopAttrib() '��������������� ��� ��������" & _
        " �� ����� ���������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glPushMatrix() '�������� ������� ������� ����� � �������" & _
        "��� ����� �� ������ ������� �����" & Microsoft.VisualBasic.ChrW(10) & "Gl.glPopMatrix() '������� ������� ������� ����" & _
        "� � �������� ������ ������� � ���� �����." & Microsoft.VisualBasic.ChrW(10) & "Gl.glClipPlane(Gl.GL_CLIP_PLANE0, plan" & _
        "e0_Parameters) '������ �������������� ��������� ���������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glEnable(Gl.GL_CLI" & _
        "P_PLANE0) '������������ �������������� ��������� ���������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glMap1f(Gl.GL_MAP" & _
        "1_VERTEX_3, 0.0, 1.0, 3, 4, ctrlPts) '������ ��������� �����������, ����� ������" & _
        " � ���� ��������� ������ �����" & Microsoft.VisualBasic.ChrW(10) & "Gl.glEnable(Gl.GL_MAP1_VERTEX_3) '����������� glM" & _
        "ap1f" & Microsoft.VisualBasic.ChrW(10) & "Gl.glEvalCoord1f(LFor / 50.0) '��������� ���������� ����� �� ������ �����." & Microsoft.VisualBasic.ChrW(10) & _
        "Gl.glMapGrid1f(50, 0.0, 1.0) '������ ����� ���������� ������������� ������� ����" & _
        "� ����� ����������� ������ �����." & Microsoft.VisualBasic.ChrW(10) & "Gl.glEvalMesh1(Gl.GL_LINE, 0, 50) '������ ����" & _
        "� ����������� � ������������� �������� ����������� ������ �����." & Microsoft.VisualBasic.ChrW(10) & "Gl.glMap2f(Gl.G" & _
        "L_MAP2_VERTEX_3, 0.0, 1.0, 3, 4, 0.0, 1.0, 12, 4, ctrlPts) '������ ��������� ���" & _
        "��������, ����� ����� � ���� ��������� ������ �����." & Microsoft.VisualBasic.ChrW(10) & "Gl.glEnable(Gl.GL_MAP2_VERT" & _
        "EX_3) '����������� glMap2f." & Microsoft.VisualBasic.ChrW(10) & "Gl.glEvalCoord2f(j / 39.0, k / 7.0) '������������ ��" & _
        "�������� ����� �� ����������� �����." & Microsoft.VisualBasic.ChrW(10) & "Gl.glMapGrid2f(40, 0.0, 1.0, 40, 0.0, 1.0) " & _
        "'������ ���������� ����� ���������� ������������� ������� �� ����������� �����." & Microsoft.VisualBasic.ChrW(10) & _
        "Gl.glEvalMesh2(Gl.GL_LINE, 0, 40, 0, 40) '������ ����� ����������� � �����������" & _
        "�� �������� ��� ���������� ����� �� ����������� �����." & Microsoft.VisualBasic.ChrW(10) & "Gl.glClear(Gl.GL_COLOR_BU" & _
        "FFER_BIT Or Gl.GL_DEPTH_BUFFER_BIT) '��������� ���� � �������������� ������ ����" & _
        "���." & Microsoft.VisualBasic.ChrW(10) & "Gl.glCullFace(Gl.GL_FRONT) '��������� ����� ��������� ��������������� �����" & _
        " ������������� � ��������� ������ (GL_FRONT - ��������, GL_BACK - ������)." & Microsoft.VisualBasic.ChrW(10) & "Gl.gl" & _
        "Enable(Gl.GL_CULL_FACE) '����������� glCullFace." & Microsoft.VisualBasic.ChrW(10) & "Gl.glClearDepth(Gl.GL_DEPTH_BUF" & _
        "FER_BIT) '������ �������� �������� ������ �������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glDepthRange(0.0, 1.0) '��" & _
        "���� �������� ������������� �������� �������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glDepthFunc(Gl.GL_LESS) '������" & _
        " ������� �������� �������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glDepthMask(Gl.GL_TRUE) '������������� ������ ����" & _
        "�� ��� ������ ������� (GL_TRUE - ������ � ������, GL_FALSE - ������ ������)." & Microsoft.VisualBasic.ChrW(10) & "Gl." & _
        "glEnable(Gl.GL_DEPTH_TEST) '������������ ����������� ������� ������������" & Microsoft.VisualBasic.ChrW(10) & "Gl.glP" & _
        "olygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_LINE) '�������� ������ ������������ �����" & _
        "���." & Microsoft.VisualBasic.ChrW(10) & "Gl.glEnable(Gl.GL_POLYGON_OFFSET_FILL) '������������ glPolygonOffset." & Microsoft.VisualBasic.ChrW(10) & "Gl.gl" & _
        "PolygonOffset(1.0, 1.0) '������ ����������, ����� ��������� ������� ����� �� ���" & _
        "������ ����������� ��� ���������� ���������� ������ ����." & Microsoft.VisualBasic.ChrW(10) & "Gl.glEnable(Gl.GL_FOG)" & _
        " '������������ GlFog - ��������� � ��������." & Microsoft.VisualBasic.ChrW(10) & "Gl.glFogi(Gl.GL_FOG_MODE, Gl.GL_LIN" & _
        "EAR) '������ ������� ������� ��������� ���������� �� ����� ����������. (�����)" & Microsoft.VisualBasic.ChrW(10) & "G" & _
        "l.glLightfv(Gl.GL_LIGHT0, Gl.GL_POSITION, LightValue) '������ �������� ������� �" & _
        "�������� �����   'POSITION - ��������� ��������� �����." & Microsoft.VisualBasic.ChrW(10) & "Gl.glEnable(Gl.GL_LIGHT0" & _
        ") '������������ �������� �����." & Microsoft.VisualBasic.ChrW(10) & "Gl.glEnable(Gl.GL_LIGHTING) '�����������  ���� �" & _
        "�������� ���������� �����." & Microsoft.VisualBasic.ChrW(10) & "Gl.glDisable(Gl.GL_LIGHT0) '��������� �������� �����." & _
        "" & Microsoft.VisualBasic.ChrW(10) & "Gl.glLightModelfv(Gl.GL_LIGHT_MODEL_AMBIENT, globalAmbient) '�������� ����� ���" & _
        "���� ���������." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "--------------------------------------------------------------" & _
        "--------------------------------------------------------------------------------" & _
        "----------------------------------------------------------------------" & Microsoft.VisualBasic.ChrW(10) & "Glu.gluOr" & _
        "tho2D(-100.0, 100.0, -100.0, 100.0) '������������� 2D ��������. (x_left, x_right" & _
        ", y_button, y_top)" & Microsoft.VisualBasic.ChrW(10) & "                                                    'x_left, " & _
        "x_right - ���������� ��������� ��������� �����(left) �� �����(right) (����)" & Microsoft.VisualBasic.ChrW(10) & "    " & _
        "                                                'y_button, y_top - ���������� ��" & _
        "������� ��������� �����(button) � �����(top) (���Y)" & Microsoft.VisualBasic.ChrW(10) & "Glu.gluLookAt(5.0, 5.0, -5.0" & _
        ", 0.0, 0.0, 0.0, 0.0, 0.0, 1.0) '������� ������������ ����� ����������" & Microsoft.VisualBasic.ChrW(10) & "         " & _
        "                                           'eyeX, eyeY, eyeZ - ������� ����� ���" & _
        "����." & Microsoft.VisualBasic.ChrW(10) & "                                                    'centerX, centerY, cen" & _
        "terZ  - ������� ������� �����. (����� �������)" & Microsoft.VisualBasic.ChrW(10) & "                                 " & _
        "                   'upX, upY, upZ - ����������� ������� �����." & Microsoft.VisualBasic.ChrW(10) & "                 " & _
        "                                   '�� ��������� gluLookAt(0,0,0,0,0,-1,0,1,0)" & Microsoft.VisualBasic.ChrW(10) & "G" & _
        "lu.gluPerspective(80.0, gluP_Aspect, 2.0, 100.0) '������������ �����������������" & _
        "���� (fovy, aspect, zNear, zFar)" & Microsoft.VisualBasic.ChrW(10) & "                                               " & _
        "     'fovy - ���� ���� ������, � ��������, � ����������� �� ��� Y. " & Microsoft.VisualBasic.ChrW(10) & "            " & _
        "                                        'aspec - ���������� ����, ������� ������" & _
        "���� ���� ������ � ����������� �� ��� �. ���������� ���� - ���������(�����������" & _
        ") X (������) � Y (������)." & Microsoft.VisualBasic.ChrW(10) & "                                                    '" & _
        "zNear - ���������� �� ����� ��������� �� ������� ��������� ��������� (������ ���" & _
        "������� ��������)" & Microsoft.VisualBasic.ChrW(10) & "                                                    'zFar - ��" & _
        "�������� �� ����� ��������� �� ������� ��������� ��������� (������ ���������� ��" & _
        "������)" & Microsoft.VisualBasic.ChrW(10) & "Glu.gluNewQuadric() '������������ ��������� ������������ ������������ GL" & _
        "U �������." & Microsoft.VisualBasic.ChrW(10) & "Glu.gluQuadricDrawStyle(Object3D, Glu.GLU_LINE) '�������� ����� �����" & _
        "������ ��� ����������������� ����� ������� GLU." & Microsoft.VisualBasic.ChrW(10) & "Glu.gluSphere(Object3D, 20.0, 5," & _
        " 5) '������������ ����� GLU." & Microsoft.VisualBasic.ChrW(10) & "Glu.gluCylinder(Object3D, 30.0, 15.0, 10.0, 10.0, 1" & _
        "0.0) '���������� �����, ������� ��� ���������� ������� GLU." & Microsoft.VisualBasic.ChrW(10) & "Glu.gluDisk(Object3D" & _
        ", 20.0, 30.0, 15, 15) '���������� ������� �������� ������ ��� �������� ���� GLU." & _
        "" & Microsoft.VisualBasic.ChrW(10) & "Glu.gluPartialDisk(Object3D, 10.0, 30.0, 20, 20, 0, 90) '���������� ������� ���" & _
        "����� ��������� ������ ��� ��������� ����� GLU." & Microsoft.VisualBasic.ChrW(10) & "Glu.gluDeleteQuadric(Object3D) '" & _
        "������� GLU ������ ������� �������." & Microsoft.VisualBasic.ChrW(10) & "Glu.gluQuadricOrientation(Object3D, Glu.GLU_" & _
        "INSIDE) '���������� ����������� ����������� ���������� � ������� ���������� GLU " & _
        "�������. " & Microsoft.VisualBasic.ChrW(10) & "Glu.gluQuadricNormals(Object3D, Glu.GLU_FLAT) '��������� �������� ����" & _
        "��� � �����������." & Microsoft.VisualBasic.ChrW(10) & "Glu.gluQuadricCallback(Object3D, Glu.GLU_ERROR, function) '��" & _
        "���� ������� ��������� ������ ��� ������ ��������� GLU �������." & Microsoft.VisualBasic.ChrW(10) & "Glu.gluNewNurbsR" & _
        "enderer() '������������ ��������� ������������ GLU ��-������� ��� �������, ��� �" & _
        "������� ��� ����������." & Microsoft.VisualBasic.ChrW(10) & "Glu.gluBeginCurve(cubicBezCurve) '�������� ���������� ��" & _
        "������ ���������� ��� �������� ��-���������� ������ � ����� ��� ����������� ����" & _
        "�����." & Microsoft.VisualBasic.ChrW(10) & "Glu.gluNurbsCurve(cubicBezCurve, 8, knotVector, 3, ctrlPts, 4, Gl.GL_MAP1" & _
        "_VERTEX_3) '������ �������� ���������� ������������ ������� ��-���������� ������" & _
        "." & Microsoft.VisualBasic.ChrW(10) & "Glu.gluEndCurve(cubicBezCurve) '��������� ����� ������� ���������� ��-��������" & _
        "�� ������." & Microsoft.VisualBasic.ChrW(10) & "Glu.gluDeleteNurbsRenderer(cubicBezCurve) '������� �������� ��-������" & _
        "���� ������." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "----------------------------------------------------------------" & _
        "--------------------------------------------------------------------------------" & _
        "--------------------------------------------------------------------" & Microsoft.VisualBasic.ChrW(10) & "Gdi.PIXELFO" & _
        "RMATDESCRIPTOR '��������� ��������� ������ ������� ����������� �����������" & Microsoft.VisualBasic.ChrW(10) & "Gdi.S" & _
        "etPixelFormat(ghDC, PixelFormat, pfd) Then '������������� ���������� ������." & Microsoft.VisualBasic.ChrW(10) & "Gdi" & _
        ".SwapBuffers(ghDC) '����� ������������ ������������ ��� ������� ����������� (���" & _
        "���������� ������)" & Microsoft.VisualBasic.ChrW(10) & "Gdi.PFD_DRAW_TO_WINDOW '����: ���������� � ����" & Microsoft.VisualBasic.ChrW(10) & "Gdi.PFD_SUPPO" & _
        "RT_OPENGL '����: ������� OpenGL" & Microsoft.VisualBasic.ChrW(10) & "Gdi.PFD_DOUBLEBUFFER '����: ������� �����������" & Microsoft.VisualBasic.ChrW(10) & _
        "Gdi.PFD_DEPTH_DONTCARE '����: ������������� �������." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "----------------------" & _
        "--------------------------------------------------------------------------------" & _
        "--------------------------------------------------------------------------------" & _
        "------------------------------" & Microsoft.VisualBasic.ChrW(10) & "Wgl.wglCreateContext(ghDC) '������� �������� ����" & _
        "������." & Microsoft.VisualBasic.ChrW(10) & "Wgl.wglMakeCurrent(ghDC, hRC) Then '������� �����." & Microsoft.VisualBasic.ChrW(10) & "Wgl.wglMakeCurrent(In" & _
        "tPtr.Zero, IntPtr.Zero) '������� �����." & Microsoft.VisualBasic.ChrW(10) & "Wgl.wglDeleteContext(ghDC)  '������� ���" & _
        "�������� ��������." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10)
        Me.RichTextBox2.WordWrap = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.RichTextBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(456, 235)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "�������������� �������"
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
        Me.RichTextBox3.Size = New System.Drawing.Size(456, 234)
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
        Me.TabPage4.Size = New System.Drawing.Size(536, 267)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "���� OpenGL"
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
        Me.RichTextBox4.Size = New System.Drawing.Size(536, 266)
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
        Me.TabPage5.Size = New System.Drawing.Size(536, 267)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "����������������� �����"
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
        Me.RichTextBox5.Size = New System.Drawing.Size(536, 266)
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
        'BookVB
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(544, 342)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BookVB"
        Me.Text = "������� ���������� �� ����� VB � OpenGL"
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
