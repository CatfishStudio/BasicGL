Imports System.IO
Public Class Start
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
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DataSet61 As BasicGL.DataSet6
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Start))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.DataSet61 = New BasicGL.DataSet6
        CType(Me.DataSet61, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
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
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(296, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "� Somov Evgen, 2012 "
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(336, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Portions Copyright � Microsoft Corporation. All Rights Reserved."
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(304, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Portions Copyright � Tao. All Rights Reserved."
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT ���������, ������������, ������, �������������������� FROM ���������"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO ���������(���������, ������������, ��������������������) VALUES (?, ?" & _
        ", ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("���������", System.Data.OleDb.OleDbType.VarWChar, 255, "���������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("������������", System.Data.OleDb.OleDbType.VarWChar, 255, "������������"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("��������������������", System.Data.OleDb.OleDbType.Integer, 0, "��������������������"))
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE ��������� SET ��������� = ?, ������������ = ?, �������������������� = ? WH" & _
        "ERE (������ = ?) AND (��������� = ? OR ? IS NULL AND ��������� IS NULL) AND (���" & _
        "��������� = ? OR ? IS NULL AND ������������ IS NULL) AND (�������������������� =" & _
        " ? OR ? IS NULL AND �������������������� IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("���������", System.Data.OleDb.OleDbType.VarWChar, 255, "���������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("������������", System.Data.OleDb.OleDbType.VarWChar, 255, "������������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("��������������������", System.Data.OleDb.OleDbType.Integer, 0, "��������������������"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_������", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���������", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���������1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_������������", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_������������1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_��������������������", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "��������������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_��������������������1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "��������������������", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM ��������� WHERE (������ = ?) AND (��������� = ? OR ? IS NULL AND ����" & _
        "����� IS NULL) AND (������������ = ? OR ? IS NULL AND ������������ IS NULL) AND " & _
        "(�������������������� = ? OR ? IS NULL AND �������������������� IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_������", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���������", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_���������1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_������������", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_������������1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_��������������������", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "��������������������", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_��������������������1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "��������������������", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "���������", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("���������", "���������"), New System.Data.Common.DataColumnMapping("������������", "������������"), New System.Data.Common.DataColumnMapping("������", "������"), New System.Data.Common.DataColumnMapping("��������������������", "��������������������")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'DataSet61
        '
        Me.DataSet61.DataSetName = "DataSet6"
        Me.DataSet61.Locale = New System.Globalization.CultureInfo("ru-RU")
        '
        'Start
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(352, 246)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Start"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BasicGL"
        CType(Me.DataSet61, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            Timer1.Stop()
            Me.Visible = False
            ModuleCube.LoadDesigner()
            ModuleCube.DesignerCube.Show()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "��������� ������!")
        End Try
    End Sub

    Private Sub Start_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim INFO As DirectoryInfo = New DirectoryInfo("resource") '�������� ����� ���������
            ''Dim MyProgramDirectory As String
            Dim strName As String
            Dim nDel As Integer
            strName = INFO.FullName.ToString
            nDel = strName.Length - 8   '�������� ������ ������� TASM
            ModuleBase.MyProgramDirectory = strName.Remove(nDel, 8) '������� �������

            Me.Update()
            ModuleBase.StringConnection1 = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=" + """"
            ModuleBase.PathBase = ModuleBase.MyProgramDirectory + "resource\storage.mdb"
            ModuleBase.StringConnection2 = """" + ";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=" + """"
            ModuleBase.StringConnection3 = "Microsoft.Jet.OLEDB.4.0" + """"
            ModuleBase.StringConnection4 = ";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=ReadWrite;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False"
            OleDbConnection1.ConnectionString = ModuleBase.StringConnection1 + ModuleBase.PathBase + ModuleBase.StringConnection2 + ModuleBase.StringConnection3 + ModuleBase.StringConnection4
            OleDbConnection1.Open()
            OleDbDataAdapter1.Fill(DataSet61, "���������")
            Dim NameF As String = DataSet61.���������.Item(0)("���������")
            Dim SizeF As Integer = DataSet61.���������.Item(0)("������������")
            ModuleCube.FontModule = New Font(NameF, SizeF, FontStyle.Regular)
            If (DataSet61.���������.Item(0)("��������������������") = 1) Then
                ModuleCube.ActionModuleFormat = True
            Else
                ModuleCube.ActionModuleFormat = False
            End If
            '...
            OleDbConnection1.Close()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "��������� ������!")
        End Try
        Timer1.Start()
    End Sub
End Class
