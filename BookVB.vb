Public Class BookVB
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
        Me.Label1.Text = "Справочник"
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
        Me.TabPage1.Text = "Язык VB"
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
        Me.RichTextBox1.Text = "Криткий справочник языка программирования Visual Basic .Net 2003" & Microsoft.VisualBasic.ChrW(10) & "________________" & _
        "___________________________________________________" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "1)Объявление переменных." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "D" & _
        "im c as String 'тип строка" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim i as Integer 'тип целое число" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim b as Byte 'ти" & _
        "п байт" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim l as Long 'тип длинное целое число" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim s as Single 'тип число с пла" & _
        "вующей запятой" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim d as double 'тип число с плавующей запятой" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim o as Boolean" & _
        " 'тип логический" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim default 'произвольный тип" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "-------------------------------" & _
        "------------------------------------" & Microsoft.VisualBasic.ChrW(10) & "2)Создание структур.    (структура может со" & _
        "держать переменные и процедуры)" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Private Structure IntegerArray" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "Public x, y, z" & _
        " as Integer" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "End Structure" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "'Применение созданной структуры при обявлении переме" & _
        "нной" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim Points(2) as IntegerArray 'Объявлен как массив" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Points(0).x = 10" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Poin" & _
        "ts(0).y = 10" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Points(0).z = 10" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Private Structure Matrix3x3" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "Public Matrix(,)" & _
        " As Single 'многомерный массив" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "End Structure" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "'Применение созданной структуры п" & _
        "ри обявлении переменной" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim M1 as Matrix3x3" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "M1.Matrix(0, 0) = 10.0" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "M1.Matrix(" & _
        "0, 1) = 0.0" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Private Structure Matrix4x4" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "Public Matrix As Single 'матрица" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & _
        "End Structure" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "'Применение созданной структуры при обявлении переменной" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim mat" & _
        "Composite(4, 4) As Matrix4x4" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "matComposite(0, 0).Matrix = 1 " & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "matComposite(0, 1)" & _
        ".Matrix = 0" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "-------------------------------------------------------------------" & _
        "" & Microsoft.VisualBasic.ChrW(10) & "3)Создание классов." & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "(класс может содержать переменные и процедуры)" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Public Cla" & _
        "ss Points" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "Public x, y, z as Integer" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "End Class" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "'Применение созданной класса " & _
        "при обявлении переменной" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim pXYZ as New Points" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "pXYZ.x = 10" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "pXYZ.y = 10" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "pXYZ" & _
        ".z = 10" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "-------------------------------------------------------------------" & Microsoft.VisualBasic.ChrW(10) & "4)У" & _
        "словия." & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "(применяемые знаки:  =,<,>,<=,>=,<>)" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "If [объект] = [значение] Then" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & _
        "[действие]" & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "else" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "[действие]" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "End If" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "----------------------------------------" & _
        "---------------------------" & Microsoft.VisualBasic.ChrW(10) & "5)Циклы." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "for i as integer = 0 To 10" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "[действие]" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "N" & _
        "ext" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "For Each MyObject As Object In MyCollection " & Microsoft.VisualBasic.ChrW(10) & "   " & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "[действие]" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Next" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "'Выпо" & _
        "лняет блок операторов с повторяющимися ссылками для объекта или структуры." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "With" & _
        " MyLabel" & Microsoft.VisualBasic.ChrW(10) & "   " & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & ".Height = 2000" & Microsoft.VisualBasic.ChrW(10) & "   " & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & ".Width = 2000" & Microsoft.VisualBasic.ChrW(10) & "   " & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & ".Text = ""This is MyLabel""" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & _
        "End With" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "'задает повторяющееся выполнение блока операторов, окончание которого" & _
        " определяется значением условия, имеющим тип Boolean." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim Number As Integer = 1" & _
        "0" & Microsoft.VisualBasic.ChrW(10) & "   " & Microsoft.VisualBasic.ChrW(9) & "While Number > 6" & Microsoft.VisualBasic.ChrW(10) & "      " & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "Number = Number - 1" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "End While" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "'задает повторя" & _
        "ющееся выполнение блока операторов, окончание которого определяется значением ус" & _
        "ловия, имеющим тип Boolean." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim Number As Integer = 10" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Do While Number > 6" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "N" & _
        "umber = Number - 1" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Loop" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "'или бесконечный цикл" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Do" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "[действие]" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Loop" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "-------" & _
        "------------------------------------------------------------" & Microsoft.VisualBasic.ChrW(10) & "6)Остановка ввыполн" & _
        "ения циклов и процедур." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Exit For" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Exit Sub" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "----------------------------------" & _
        "---------------------------------" & Microsoft.VisualBasic.ChrW(10) & "7)Массивы." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim i1(10) as integer 'Одномерный " & _
        "массив." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim i2x2(10, 10) as integer 'Много мерный массив." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "i1(0) = 25" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "i2x2(0, " & _
        "0) = 25" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Private Structure Matrix3x3" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & Microsoft.VisualBasic.ChrW(9) & "Public Matrix(,) As Single 'многомерный " & _
        "массив" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "End Structure" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "'Применение созданной структуры при обявлении переменной" & Microsoft.VisualBasic.ChrW(10) & _
        "" & Microsoft.VisualBasic.ChrW(9) & "Dim M1 as Matrix3x3" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "M1.Matrix(0, 0) = 10.0" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "M1.Matrix(0, 1) = 0.0" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "-----------" & _
        "--------------------------------------------------------" & Microsoft.VisualBasic.ChrW(10) & "8)Алгебраические функци" & _
        "и." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim Theta as double" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Cos = Math.Cos(Theta)" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Sin = Math.Sin(Theta)" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "---------" & _
        "----------------------------------------------------------" & Microsoft.VisualBasic.ChrW(10) & "9)Создание процедур." & Microsoft.VisualBasic.ChrW(10) & _
        "" & Microsoft.VisualBasic.ChrW(9) & "Private Sub [имя_процедуры](ByVal [имя_переменной] as [тип])" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "..." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "End Sub" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Pu" & _
        "blic Sub [имя_процедуры](ByVal [имя_переменной] as [тип])" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "..." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "End Sub" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "-------" & _
        "------------------------------------------------------------" & Microsoft.VisualBasic.ChrW(10) & "10)Указать пустое з" & _
        "начение.  Nothing" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim s as string" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "s = Nothing" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "-------------------------------" & _
        "------------------------------------" & Microsoft.VisualBasic.ChrW(10) & "11)Определение битов." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim bitShape As Byte" & _
        "() = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11}" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Dim bitShape As Byte() = {&H1C, &H0" & _
        ", &H1C, &H0, &H1C, &H0, &H1C, &H0, &H1C, &H0, &HFF, &H80, &H7F, &H0, &H3E, &H0, " & _
        "&H1C, &H0, &H8, &H0}" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Private Shared hexDigits As Char() =  {""0""c, ""1""c, ""2""c, """ & _
        "3""c, ""4""c, ""5""c, ""6""c, ""7""c, ""8""c, ""9""c, ""A""c, ""B""c, ""C""c, ""D""c, ""E""c, ""F""c}" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "--" & _
        "-----------------------------------------------------------------" & Microsoft.VisualBasic.ChrW(10) & "12)подключение" & _
        " процедур и функций из внешних файлов dll" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Public Declare Sub glClear Lib ""openg" & _
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
        Me.RichTextBox2.Text = "Криткий справочник по OpenGL" & Microsoft.VisualBasic.ChrW(10) & "____________________________________________________" & _
        "____________________________________________________________" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "Gl.glClearColor(0." & _
        "0, 0.0, 0.0, 0.0) 'Задаем цвет окна на экране." & Microsoft.VisualBasic.ChrW(10) & "Gl.glMatrixMode(Gl.GL_PROJECTION)" & _
        " 'Задается режим построения ПРОЕКЦИОННОЙ геометрической матрицы преобразования." & Microsoft.VisualBasic.ChrW(10) & _
        "Gl.glMatrixMode(Gl.GL_MODELVIEW) 'Задается режим построения МОДЕЛЬНОЙ геометриче" & _
        "ской матрицы преобразования." & Microsoft.VisualBasic.ChrW(10) & "Gl.glClear(Gl.GL_COLOR_BUFFER_BIT) 'Очишается окно." & _
        "" & Microsoft.VisualBasic.ChrW(10) & "Gl.glColor3f(0.0, 0.0, 0.0) 'Цвет закраски объекта." & Microsoft.VisualBasic.ChrW(10) & "Gl.glColor4fv(ColorV) 'масс" & _
        "ив цветов RGBA." & Microsoft.VisualBasic.ChrW(10) & "                                                    'цвет RGBA о" & _
        "тличается от цвета RGB только параметром смешивания alfa которое применимо для о" & _
        "пределения степени прозрачности объекта " & Microsoft.VisualBasic.ChrW(10) & "Gl.glViewport(0, 0, 0, 0) 'Задается пол" & _
        "е просмотра." & Microsoft.VisualBasic.ChrW(10) & "Gl.glBegin(Gl.GL_LINES) 'рисует линию." & Microsoft.VisualBasic.ChrW(10) & "Gl.glBegin(Gl.GL_TRIANGLES) " & _
        "'рисует отдельные закрашенные треугольники." & Microsoft.VisualBasic.ChrW(10) & "Gl.glBegin(Gl.GL_POLYGON) 'рисует за" & _
        "крашенный многоугольник." & Microsoft.VisualBasic.ChrW(10) & "Gl.glBegin(Gl.GL_QNADS) 'рисует закрашенный многоугольн" & _
        "ик." & Microsoft.VisualBasic.ChrW(10) & "Gl.glEnd() 'окночание сцены" & Microsoft.VisualBasic.ChrW(10) & "Gl.glVertex2f(0, 0, 0) 'Выбор координат изобража" & _
        "емого 2D объекта" & Microsoft.VisualBasic.ChrW(10) & "Gl.glVertex3f(0, 0, 0) 'Выбор координат изображаемого 3D объект" & _
        "а" & Microsoft.VisualBasic.ChrW(10) & "Gl.glFlush() 'процедура ускаряющая прорисовку объектов" & Microsoft.VisualBasic.ChrW(10) & "Gl.glOrtho(-100.0, 100." & _
        "0, -100.0, 100.0, -100, 100) 'Ортогональная 3D проекция (x_left, x_right, y_butt" & _
        "on, y_top, z_near, z_far)" & Microsoft.VisualBasic.ChrW(10) & "                                                    'x" & _
        "_left, x_right - координаты отсечения плоскости слева(left) на право(right) (ось" & _
        "Х)" & Microsoft.VisualBasic.ChrW(10) & "                                                    'y_button, y_top - коорди" & _
        "наты отсечения плоскости снизу(button) в вверх(top) (осьY)" & Microsoft.VisualBasic.ChrW(10) & "                     " & _
        "                               'z_near, z_far - координаты отсечения плоскости о" & _
        "т близко(near) по далеко(far) (осьZ)" & Microsoft.VisualBasic.ChrW(10) & "Gl.glFrustum(-40.0, 40.0, -60.0, 60.0, 25.0" & _
        ", 125.0) 'Произвольная перспективная проекция (left, right, bottom, top, znear, " & _
        "zfar)" & Microsoft.VisualBasic.ChrW(10) & "                                                    'x_left, x_right - коо" & _
        "рдинаты отсечения плоскости слева(left) на право(right) (осьХ)" & Microsoft.VisualBasic.ChrW(10) & "                 " & _
        "                                   'y_button, y_top - координаты отсечения плоск" & _
        "ости снизу(button) в вверх(top) (осьY)" & Microsoft.VisualBasic.ChrW(10) & "                                         " & _
        "           'z_near, z_far - координаты отсечения плоскости от близко(near) по да" & _
        "леко(far) (осьZ)" & Microsoft.VisualBasic.ChrW(10) & "Gl.glTranslatef(10.0, 0.0, 0.0) 'Трансляция (перемещение) по ос" & _
        "ям (Х, Y, Z)" & Microsoft.VisualBasic.ChrW(10) & "Gl.glRotatef(10, 0.0, 0.0, 1.0) 'Поворот (Угол, X, Y, Z)" & Microsoft.VisualBasic.ChrW(10) & "Gl.glScale" & _
        "f(0.9, 0.9, 0.9) 'Изменение масштаба. (X, Y, Z). Увеличение масштаба 1.1 а умень" & _
        "шение масштаба 0.9" & Microsoft.VisualBasic.ChrW(10) & "Gl.glRectf(-20, -20, 20, 20) 'рисует закрашенный квадрат в 2D" & _
        " координатах" & Microsoft.VisualBasic.ChrW(10) & "Gl.glEnableClientState(Gl.GL_VERTEX_ARRAY) - активизирует возможнос" & _
        "ть создавать массив вершин." & Microsoft.VisualBasic.ChrW(10) & "Gl.glVertexPointer(3, Gl.GL_INT, 0, pt) - задается м" & _
        "ассив координатных значений." & Microsoft.VisualBasic.ChrW(10) & "Gl.glDrawElements(Gl.GL_QUADS, 23, Gl.GL_UNSIGNED_B" & _
        "YTE, verts) - изображается заданный тип примитива из массива данных" & Microsoft.VisualBasic.ChrW(10) & "Gl.glPixelSt" & _
        "orei(Gl.GL_UNPACK_ALIGNMENT, 1) 'Устанавливаем режим хранения пикселей." & Microsoft.VisualBasic.ChrW(10) & "Gl.glRas" & _
        "terPos2i(0, 0) 'задаем координаты расположения данного битового изображения" & Microsoft.VisualBasic.ChrW(10) & "Gl.g" & _
        "lBitmap(9, 10, 0.0, 0.0, 20.0, 15.0, bitShape) 'отображаем битовое изображение" & Microsoft.VisualBasic.ChrW(10) & "G" & _
        "l.glGenLists(1) 'Таблице отображений присваивается идентификатор." & Microsoft.VisualBasic.ChrW(10) & "Gl.glNewList(r" & _
        "egHex, Gl.GL_COMPILE) 'Создается таблица отображений." & Microsoft.VisualBasic.ChrW(10) & "Gl.glEndList() 'окончание " & _
        "таблицы отображений." & Microsoft.VisualBasic.ChrW(10) & "Gl.glCallList(regHex) 'Реализация таблицы отображений." & Microsoft.VisualBasic.ChrW(10) & "Gl.g" & _
        "lIsList(listID) 'определяет используется ли данное целое число в качестве имени " & _
        "таблицы." & Microsoft.VisualBasic.ChrW(10) & "Gl.glListBase(0) 'Задается значение смещения для массива идентификаторо" & _
        "в таблиц отображений." & Microsoft.VisualBasic.ChrW(10) & "Gl.glDeleteLists(startID, nLists) 'Удаляет набор следующих" & _
        " друг за другом таблиц отображений." & Microsoft.VisualBasic.ChrW(10) & "Gl.glPointSize(50.0) 'настройка размера точк" & _
        "и." & Microsoft.VisualBasic.ChrW(10) & "Gl.glLineWidth(10.0) 'настройка ширины линии." & Microsoft.VisualBasic.ChrW(10) & "Gl.glLineStipple(1, 5) 'настрой" & _
        "ка стиля линии." & Microsoft.VisualBasic.ChrW(10) & "Gl.glIndexi(196) 'Индексный цвет заполнения." & Microsoft.VisualBasic.ChrW(10) & "Gl.glShadeModel(Gl." & _
        "GL_SMOOTH) 'отрезок изображения переменного цвета" & Microsoft.VisualBasic.ChrW(10) & "Gl.glShadeModel(Gl.GL_FLAT) 'о" & _
        "трезок изображения одного цвета" & Microsoft.VisualBasic.ChrW(10) & "Gl.glPolygonStipple(fillPattern) 'задает маску т" & _
        "екущего шаблона узора." & Microsoft.VisualBasic.ChrW(10) & "Gl.glEnable(Gl.GL_POLYGON_STIPPLE) 'вызываем процедуру за" & _
        "крашивания" & Microsoft.VisualBasic.ChrW(10) & "Gl.glShadeModel(Gl.GL_SMOOTH) 'интерполяционное закрашивание. если ис" & _
        "пользовать GL_FLAT -объект будет закрашен одним последним цветом." & Microsoft.VisualBasic.ChrW(10) & "Gl.glEnable(Gl" & _
        ".GL_LINE_SMOOTH) 'Активизация процедуры устранения неровности GL_POINT_SMOOTH, G" & _
        "L_LINE_SMOOTH, GL_POLYGON_SMOOTH" & Microsoft.VisualBasic.ChrW(10) & "Gl.glEnable(Gl.GL_BLEND) 'если режим цвета RGBA" & _
        " нужно активизировать операции смешивания цветов." & Microsoft.VisualBasic.ChrW(10) & "Gl.glBlendFunc(Gl.GL_SRC_ALPHA" & _
        ", Gl.GL_ONE_MINUS_SRC_ALPHA) 'применяется метод смешивания цветов." & Microsoft.VisualBasic.ChrW(10) & "Gl.glGetFloat" & _
        "v(Gl.GL_RED_BITS, GetR_Bitas) 'определяет текущее значение атрибута" & Microsoft.VisualBasic.ChrW(10) & "Gl.glGetInte" & _
        "gerv(Gl.GL_MAX_MODELVIEW_STACK_DEPTH, StackSize) 'Определить число позиций, допу" & _
        "стимых в стеке модельных проекций." & Microsoft.VisualBasic.ChrW(10) & "Gl.glGetIntegerv(Gl.GL_MODELVIEW_STACK_DEPTH," & _
        " numMatrix) 'Определить сколько матриц в настоящий момент находится в стеке." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "Gl" & _
        ".glPushAttrib(Gl.GL_POINT_BIT And Gl.GL_LIST_BIT And Gl.GL_POLYGON_BIT) 'сохраня" & _
        "ет параметры из нескальких групп." & Microsoft.VisualBasic.ChrW(10) & "Gl.glPopAttrib() 'восстанавливает все значения" & _
        " из стека атрибутов." & Microsoft.VisualBasic.ChrW(10) & "Gl.glPushMatrix() 'копирует верхнюю матрицу стека и записыв" & _
        "ает копию во второй позиции стека" & Microsoft.VisualBasic.ChrW(10) & "Gl.glPopMatrix() 'Удаляет верхнюю матрицу стек" & _
        "а и помещает вторую матрицу в верх стека." & Microsoft.VisualBasic.ChrW(10) & "Gl.glClipPlane(Gl.GL_CLIP_PLANE0, plan" & _
        "e0_Parameters) 'Вводим дополнительную плоскость отсечения." & Microsoft.VisualBasic.ChrW(10) & "Gl.glEnable(Gl.GL_CLI" & _
        "P_PLANE0) 'Активизируем дополнительную плоскость отсечения." & Microsoft.VisualBasic.ChrW(10) & "Gl.glMap1f(Gl.GL_MAP" & _
        "1_VERTEX_3, 0.0, 1.0, 3, 4, ctrlPts) 'Задает параметры отображения, кодов цыетов" & _
        " и тому подобного кривой Безье" & Microsoft.VisualBasic.ChrW(10) & "Gl.glEnable(Gl.GL_MAP1_VERTEX_3) 'Активизация glM" & _
        "ap1f" & Microsoft.VisualBasic.ChrW(10) & "Gl.glEvalCoord1f(LFor / 50.0) 'Вычисляет координаты точки на кривой Безье." & Microsoft.VisualBasic.ChrW(10) & _
        "Gl.glMapGrid1f(50, 0.0, 1.0) 'Задает число равномерно расположенных делений межд" & _
        "у двумя параметрами кривой Безье." & Microsoft.VisualBasic.ChrW(10) & "Gl.glEvalMesh1(Gl.GL_LINE, 0, 50) 'Задает режи" & _
        "м отображения и целочисленный диапазон изображения кривой Безье." & Microsoft.VisualBasic.ChrW(10) & "Gl.glMap2f(Gl.G" & _
        "L_MAP2_VERTEX_3, 0.0, 1.0, 3, 4, 0.0, 1.0, 12, 4, ctrlPts) 'Задает параметры ото" & _
        "бражения, кодов цвета и тому подобного привой Безье." & Microsoft.VisualBasic.ChrW(10) & "Gl.glEnable(Gl.GL_MAP2_VERT" & _
        "EX_3) 'Активизация glMap2f." & Microsoft.VisualBasic.ChrW(10) & "Gl.glEvalCoord2f(j / 39.0, k / 7.0) 'Рассчитывает ко" & _
        "ординаты точки на поверхности Безье." & Microsoft.VisualBasic.ChrW(10) & "Gl.glMapGrid2f(40, 0.0, 1.0, 40, 0.0, 1.0) " & _
        "'Задает двухмерную сетку равномерно расположенных делений на поверхности Безье." & Microsoft.VisualBasic.ChrW(10) & _
        "Gl.glEvalMesh2(Gl.GL_LINE, 0, 40, 0, 40) 'Задает режим отображения и целочисленн" & _
        "ый диапазон для двухмерной сетки на поверхности Безье." & Microsoft.VisualBasic.ChrW(10) & "Gl.glClear(Gl.GL_COLOR_BU" & _
        "FFER_BIT Or Gl.GL_DEPTH_BUFFER_BIT) 'Очишается окно с использованием буфера глуб" & _
        "ины." & Microsoft.VisualBasic.ChrW(10) & "Gl.glCullFace(Gl.GL_FRONT) 'Указывает какие плоскости многоугольников будут" & _
        " задействованы в операциях отбора (GL_FRONT - передние, GL_BACK - задние)." & Microsoft.VisualBasic.ChrW(10) & "Gl.gl" & _
        "Enable(Gl.GL_CULL_FACE) 'Активизация glCullFace." & Microsoft.VisualBasic.ChrW(10) & "Gl.glClearDepth(Gl.GL_DEPTH_BUF" & _
        "FER_BIT) 'Задает исходное значение буфера глубины." & Microsoft.VisualBasic.ChrW(10) & "Gl.glDepthRange(0.0, 1.0) 'За" & _
        "дает диапазон нормированных значений глубины." & Microsoft.VisualBasic.ChrW(10) & "Gl.glDepthFunc(Gl.GL_LESS) 'Задает" & _
        " условие проверок глубины." & Microsoft.VisualBasic.ChrW(10) & "Gl.glDepthMask(Gl.GL_TRUE) 'Устанавливает статус запи" & _
        "си для буфера глубины (GL_TRUE - чтение и запись, GL_FALSE - только чтение)." & Microsoft.VisualBasic.ChrW(10) & "Gl." & _
        "glEnable(Gl.GL_DEPTH_TEST) 'Активизирует иследование видимых поверхностей" & Microsoft.VisualBasic.ChrW(10) & "Gl.glP" & _
        "olygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_LINE) 'выбираем способ растеризации полиг" & _
        "она." & Microsoft.VisualBasic.ChrW(10) & "Gl.glEnable(Gl.GL_POLYGON_OFFSET_FILL) 'Активизирует glPolygonOffset." & Microsoft.VisualBasic.ChrW(10) & "Gl.gl" & _
        "PolygonOffset(1.0, 1.0) 'Задает смешивание, чтобы устранить скрытые линии на кар" & _
        "касном изображении при применении заполнения цветов фона." & Microsoft.VisualBasic.ChrW(10) & "Gl.glEnable(Gl.GL_FOG)" & _
        " 'Активизирует GlFog - затухание с глубиной." & Microsoft.VisualBasic.ChrW(10) & "Gl.glFogi(Gl.GL_FOG_MODE, Gl.GL_LIN" & _
        "EAR) 'Меняет яркость объекта используя расстояние от точки наблюдения. (Туман)" & Microsoft.VisualBasic.ChrW(10) & "G" & _
        "l.glLightfv(Gl.GL_LIGHT0, Gl.GL_POSITION, LightValue) 'Задает значение свойств и" & _
        "сточника света   'POSITION - положение источника света." & Microsoft.VisualBasic.ChrW(10) & "Gl.glEnable(Gl.GL_LIGHT0" & _
        ") 'Активизирует источник света." & Microsoft.VisualBasic.ChrW(10) & "Gl.glEnable(Gl.GL_LIGHTING) 'Активизация  всех с" & _
        "озданных источников света." & Microsoft.VisualBasic.ChrW(10) & "Gl.glDisable(Gl.GL_LIGHT0) 'Отключает источник света." & _
        "" & Microsoft.VisualBasic.ChrW(10) & "Gl.glLightModelfv(Gl.GL_LIGHT_MODEL_AMBIENT, globalAmbient) 'Задается общее фон" & _
        "овое освещение." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "--------------------------------------------------------------" & _
        "--------------------------------------------------------------------------------" & _
        "----------------------------------------------------------------------" & Microsoft.VisualBasic.ChrW(10) & "Glu.gluOr" & _
        "tho2D(-100.0, 100.0, -100.0, 100.0) 'Ортогональная 2D проекция. (x_left, x_right" & _
        ", y_button, y_top)" & Microsoft.VisualBasic.ChrW(10) & "                                                    'x_left, " & _
        "x_right - координаты отсечения плоскости слева(left) на право(right) (осьХ)" & Microsoft.VisualBasic.ChrW(10) & "    " & _
        "                                                'y_button, y_top - координаты от" & _
        "сечения плоскости снизу(button) в вверх(top) (осьY)" & Microsoft.VisualBasic.ChrW(10) & "Glu.gluLookAt(5.0, 5.0, -5.0" & _
        ", 0.0, 0.0, 0.0, 0.0, 0.0, 1.0) 'функция определяюшая точку наблюдения" & Microsoft.VisualBasic.ChrW(10) & "         " & _
        "                                           'eyeX, eyeY, eyeZ - позиция точки осм" & _
        "отра." & Microsoft.VisualBasic.ChrW(10) & "                                                    'centerX, centerY, cen" & _
        "terZ  - позиция опорной точки. (Точка взгляда)" & Microsoft.VisualBasic.ChrW(10) & "                                 " & _
        "                   'upX, upY, upZ - направление вектора вверх." & Microsoft.VisualBasic.ChrW(10) & "                 " & _
        "                                   'по умолчанию gluLookAt(0,0,0,0,0,-1,0,1,0)" & Microsoft.VisualBasic.ChrW(10) & "G" & _
        "lu.gluPerspective(80.0, gluP_Aspect, 2.0, 100.0) 'Симметричная перспективнаяпрое" & _
        "кция (fovy, aspect, zNear, zFar)" & Microsoft.VisualBasic.ChrW(10) & "                                               " & _
        "     'fovy - угол поля обзора, в степенях, в направлении по оси Y. " & Microsoft.VisualBasic.ChrW(10) & "            " & _
        "                                        'aspec - Отсекающее окно, которое опреде" & _
        "ляет поле обзора в направлении по оси х. Отсекающее окно - отношение(коэффициент" & _
        ") X (ширины) к Y (высоте)." & Microsoft.VisualBasic.ChrW(10) & "                                                    '" & _
        "zNear - Расстояние от точки просмотра до ближней плоскости отсечения (всегда поз" & _
        "итивное значение)" & Microsoft.VisualBasic.ChrW(10) & "                                                    'zFar - Ра" & _
        "сстояние от точки просмотра до дальней плоскости отсечения (всегда позитивное зн" & _
        "ачение)" & Microsoft.VisualBasic.ChrW(10) & "Glu.gluNewQuadric() 'Активизирует процедуру квадратичной визуализации GL" & _
        "U объекта." & Microsoft.VisualBasic.ChrW(10) & "Glu.gluQuadricDrawStyle(Object3D, Glu.GLU_LINE) 'Выбирает режим отобр" & _
        "ажения для предопределенного имени объекта GLU." & Microsoft.VisualBasic.ChrW(10) & "Glu.gluSphere(Object3D, 20.0, 5," & _
        " 5) 'отображается сфера GLU." & Microsoft.VisualBasic.ChrW(10) & "Glu.gluCylinder(Object3D, 30.0, 15.0, 10.0, 10.0, 1" & _
        "0.0) 'Отображает конус, цилиндр или конический цилиндр GLU." & Microsoft.VisualBasic.ChrW(10) & "Glu.gluDisk(Object3D" & _
        ", 20.0, 30.0, 15, 15) 'Отображает плоское круговое кольцо или объемный диск GLU." & _
        "" & Microsoft.VisualBasic.ChrW(10) & "Glu.gluPartialDisk(Object3D, 10.0, 30.0, 20, 20, 0, 90) 'Отображает участок пло" & _
        "ского кругового кольца или объемного диска GLU." & Microsoft.VisualBasic.ChrW(10) & "Glu.gluDeleteQuadric(Object3D) '" & _
        "Удаляет GLU объект второго порядка." & Microsoft.VisualBasic.ChrW(10) & "Glu.gluQuadricOrientation(Object3D, Glu.GLU_" & _
        "INSIDE) 'Определяет направление поверхности внутреннюю и внешнюю ориентацию GLU " & _
        "объекта. " & Microsoft.VisualBasic.ChrW(10) & "Glu.gluQuadricNormals(Object3D, Glu.GLU_FLAT) 'генерация векторов норм" & _
        "али к поверхности." & Microsoft.VisualBasic.ChrW(10) & "Glu.gluQuadricCallback(Object3D, Glu.GLU_ERROR, function) 'За" & _
        "дает функцию обратного вызова при ошибке генерации GLU объекта." & Microsoft.VisualBasic.ChrW(10) & "Glu.gluNewNurbsR" & _
        "enderer() 'Активизирует процедуру визуализации GLU би-сплайна для объекта, имя к" & _
        "оторого тут определено." & Microsoft.VisualBasic.ChrW(10) & "Glu.gluBeginCurve(cubicBezCurve) 'Начинает присвоение зн" & _
        "ачений параметров для заданной би-сплайновой кривой с одним или несколькими учас" & _
        "тками." & Microsoft.VisualBasic.ChrW(10) & "Glu.gluNurbsCurve(cubicBezCurve, 8, knotVector, 3, ctrlPts, 4, Gl.GL_MAP1" & _
        "_VERTEX_3) 'Задает значения параметров именованного участка би-сплайновой кривой" & _
        "." & Microsoft.VisualBasic.ChrW(10) & "Glu.gluEndCurve(cubicBezCurve) 'Указывает конец задания параметров би-сплайнов" & _
        "ой кривой." & Microsoft.VisualBasic.ChrW(10) & "Glu.gluDeleteNurbsRenderer(cubicBezCurve) 'Удаляет заданную би-сплайн" & _
        "овую кривую." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "----------------------------------------------------------------" & _
        "--------------------------------------------------------------------------------" & _
        "--------------------------------------------------------------------" & Microsoft.VisualBasic.ChrW(10) & "Gdi.PIXELFO" & _
        "RMATDESCRIPTOR 'Структура описывает формат пикселя графической поверхности" & Microsoft.VisualBasic.ChrW(10) & "Gdi.S" & _
        "etPixelFormat(ghDC, PixelFormat, pfd) Then 'Устанавливаем пиксельный формат." & Microsoft.VisualBasic.ChrW(10) & "Gdi" & _
        ".SwapBuffers(ghDC) 'Буфер перестановок используется при двойной буферизации (син" & _
        "хронизация кадров)" & Microsoft.VisualBasic.ChrW(10) & "Gdi.PFD_DRAW_TO_WINDOW 'флаг: Отображать в окне" & Microsoft.VisualBasic.ChrW(10) & "Gdi.PFD_SUPPO" & _
        "RT_OPENGL 'флаг: Графика OpenGL" & Microsoft.VisualBasic.ChrW(10) & "Gdi.PFD_DOUBLEBUFFER 'флаг: Двойная буферизация" & Microsoft.VisualBasic.ChrW(10) & _
        "Gdi.PFD_DEPTH_DONTCARE 'флаг: Использавание Глубины." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "----------------------" & _
        "--------------------------------------------------------------------------------" & _
        "--------------------------------------------------------------------------------" & _
        "------------------------------" & Microsoft.VisualBasic.ChrW(10) & "Wgl.wglCreateContext(ghDC) 'Создаем контекст испо" & _
        "лнения." & Microsoft.VisualBasic.ChrW(10) & "Wgl.wglMakeCurrent(ghDC, hRC) Then 'Создать поток." & Microsoft.VisualBasic.ChrW(10) & "Wgl.wglMakeCurrent(In" & _
        "tPtr.Zero, IntPtr.Zero) 'Удаляем поток." & Microsoft.VisualBasic.ChrW(10) & "Wgl.wglDeleteContext(ghDC)  'Удаляем исп" & _
        "олняющий контекст." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10)
        Me.RichTextBox2.WordWrap = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.RichTextBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(456, 235)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Математические формулы"
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
        Me.RichTextBox3.Text = "2D Трансляция:" & Microsoft.VisualBasic.ChrW(10) & "x' = x + tx" & Microsoft.VisualBasic.ChrW(10) & "y' = y + ty" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "2D Поворот:" & Microsoft.VisualBasic.ChrW(10) & "x' = Xr + (x - Xr) * cos(Угла" & _
        ") - (y - yr) * sin(Угла)" & Microsoft.VisualBasic.ChrW(10) & "y' = Yr + (x - Xr) * sin(Угла) + (y - Yr) * cos(Угла)" & Microsoft.VisualBasic.ChrW(10) & "г" & _
        "де Xr и Yr - это центр поворота." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "2D Масштаб:" & Microsoft.VisualBasic.ChrW(10) & "x' = x * Sx + Xf(1 - Sx)" & Microsoft.VisualBasic.ChrW(10) & "y' = y * " & _
        "Sy + Yf(1 - Sy)" & Microsoft.VisualBasic.ChrW(10) & "где Xf и Yf - масштабирование относительно выбранной фиксированн" & _
        "ой точки" & Microsoft.VisualBasic.ChrW(10) & "-----------------------------------------------------------------------" & _
        "-----------------------------" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "3D Трансляция: ----------------------------------" & _
        "---------------------------------------------" & Microsoft.VisualBasic.ChrW(10) & "x' = x + tx" & Microsoft.VisualBasic.ChrW(10) & "y' = y + ty" & Microsoft.VisualBasic.ChrW(10) & "z' = z + t" & _
        "z" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Матрица 4 на 4" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "[x'] = [1 0 0 tx] * [x]" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "[y'] = [0 1 0 ty] * [y]" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "[z'] = [0 0" & _
        " 1 tz] * [z]" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "[1] = [0 0 0 1] * [1]" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "3D Поворот: -------------------------------" & _
        "-----------------------------------------------------" & Microsoft.VisualBasic.ChrW(10) & "x' = x cos(угла) - y sin(у" & _
        "гла)" & Microsoft.VisualBasic.ChrW(10) & "y' = x sin(угла) + y cos(угла)" & Microsoft.VisualBasic.ChrW(10) & "z' = z" & Microsoft.VisualBasic.ChrW(10) & "y' = y cos(угла) - z sin(угла)" & Microsoft.VisualBasic.ChrW(10) & "z' = y" & _
        " sin(угла) + z cos(угла)" & Microsoft.VisualBasic.ChrW(10) & "x' = x" & Microsoft.VisualBasic.ChrW(10) & "z' = z cos(угла) - x sin(угла)" & Microsoft.VisualBasic.ChrW(10) & "x' = z sin(угла) " & _
        "+ x cos(угла)" & Microsoft.VisualBasic.ChrW(10) & "y' = y" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "Кватернионная матрица 4 на 4:" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "[ux * ux(1 - cos(угла)) + c" & _
        "os(угла)]            [ux * uy(1 - cos(угла)) - uz * sin(угла)]      [ux * uz(1 -" & _
        " cos(угла)) + uy * sin(угла)]" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "[uу * ux(1 - cos(угла)) + uz * sin(угла)]     [uy" & _
        " * uy(1 - cos(угла)) + cos(угла)]            [uy * uz(1 - cos(угла)) - ux * sin(" & _
        "угла)]" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(9) & "[uz * ux(1 - cos(угла)) - uy * sin(угла)]      [uz * uy(1 - cos(угла)) +" & _
        " ux * sin(угла)]     [uz * uz(1 - cos(угла)) + cos(угла)]" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "3D Масштаб: ---------" & _
        "-------------------------------------------------------------------------" & Microsoft.VisualBasic.ChrW(10) & "x' = x" & _
        " * Sx + Xf(1 - Sx)" & Microsoft.VisualBasic.ChrW(10) & "y' = y * Sy + Yf(1 - Sy)" & Microsoft.VisualBasic.ChrW(10) & "z' = z * Sz + Zf(1 - Sz)" & Microsoft.VisualBasic.ChrW(10) & "где Xf и Yf" & _
        " и Zf - масштабирование относительно выбранной фиксированной точки" & Microsoft.VisualBasic.ChrW(10) & "_____________" & _
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
        Me.TabPage4.Text = "Типы OpenGL"
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
        Me.RichTextBox4.Text = " Тип OpenGL      |        Тип VB     " & Microsoft.VisualBasic.ChrW(10) & "-------------------------------------------" & _
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
        Me.TabPage5.Text = "Шестнадцатеричные цифры"
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
        Me.RichTextBox5.Text = "Обозначение   |    Знач    |    Знач    |    Знач" & Microsoft.VisualBasic.ChrW(10) & "-------------------------------" & _
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
        "------------" & Microsoft.VisualBasic.ChrW(10) & "0x3E = 3 (это 0011) и E (это 1110) = 00111110" & Microsoft.VisualBasic.ChrW(10) & "0x3E = &H3E,   0x08 =" & _
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
        Me.Text = "Краткий справочник по языку VB и OpenGL"
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
