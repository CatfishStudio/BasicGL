Public Class License
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
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(License))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(504, 420)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = "�������� ������ �������� FREEWARE." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "���������������� ������ ����������� ���������" & _
        " �� ��� ����� ���������� ������� ������ ���������." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "������������ ����������." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "1." & _
        " ��� ��������� �������� ������������� �������� � �������������� ������������ �� " & _
        "��������� �����. �������������� ����� �� ������������� ���� ���������� ���������" & _
        "�� �� ������." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "2. ���������� � �� ������������ ����� ������������ ���������, ���" & _
        "����������� �����." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "3. ������������� ����������� ������� ������������ ����������" & _
        "� � ������ ���������� ��������� ��� ���������� ����������������/������� ���� ���" & _
        "��������." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "��������� ������������ ��������������� ���������. (�� ���������������" & _
        " ��������� ��������� ����� ������)." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "4. ��������� ������������ ""��� ����"". " & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "5. " & _
        "��������� ����� ���������� � ������ ������� ���������, ���������� �� ������, ���" & _
        "����� �� ����� ��������������� ������ � ���������� ���������������." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "����������" & _
        "� ����������� ������������." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "1. ��������� ����� ��������� ������. ��������������" & _
        "� �� ����� ��������������� �� ��������� ������ ���������." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "2. ��������������� ��" & _
        " �����������, ��� �������, ������������ � ���������, ����� ������������� �������" & _
        "��� ����������� ��� ��� ������ ��������� �� ��������� ��-�� ������." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "3. ��������" & _
        "������� ��������� ������������ �� ���� ��������� ���������� � �������������� ��-" & _
        "��������� ����������� ������������, ������� ����������� � ���������� �����������" & _
        " ������������ ����� ������������� ����� � �������� �������� � �������." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "4. �� ��" & _
        "� ����� ��������������� ��������������� �� ����� ������������ ����� ������������" & _
        "� �� ����� ����, ���������� ��� ������������, ���������� ������ ����������, ����" & _
        "��� ��������� �������, ������ ������, ����� ��������� ��� ������ �������� ��� ��" & _
        "������� ����, ������������ ��-�� ������������� ��� ������������� ������������� �" & _
        "����� ���������. ����� �� ����������� ���� �� ����� ������ ������������� �������" & _
        "��� ������������ ���������." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "COPYRIGHT" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "1. ��� �������������� ��������� ����� �" & _
        "� ��������� ����������� ���������������." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "2. ��������� ������ �����������������," & _
        " ������ ���-���� � ��� � ��������� �� ������ ���������." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "3. ��� ��������������� " & _
        "��������� ����������� ����������� ��� ���������������, ��� ���������� ����������" & _
        " � ���� ���������������." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "�������� ��� ����������� ������������." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "1. ��� ������" & _
        "������ ���������� ������������� ������������ ������� �� ��������� �����. ������ " & _
        "���������� �������� �� ����� �������� ���� �������, ��� �������� ��� ��������� �" & _
        "������������� � ����������, ����� ����������� �� ��������� � ������� ��������." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & _
        "2. ��� ������� ������� �������� �� �������� �������������� ������, � ���� ������" & _
        "���� �� ���� ����������, �� � ����� ����� ����������." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "���������� ����������" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "�" & _
        "����: ����� ������� ��������" & Microsoft.VisualBasic.ChrW(10) & "�����: �������, �. �������" & Microsoft.VisualBasic.ChrW(10) & "Email: info@catfish.ltd." & _
        "ua" & Microsoft.VisualBasic.ChrW(10) & "����: catfish.ltd.ua"
        '
        'License
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(504, 422)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "License"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "������������ ����������."
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub License_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ModuleCube.LicenseShow = True
    End Sub

    Private Sub License_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        ModuleCube.LicenseShow = False
    End Sub
End Class
