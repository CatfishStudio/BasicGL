Public Class License
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
        Me.RichTextBox1.Text = "ОСНОВНЫЕ ПУНКТЫ ЛИЦЕНЗИИ FREEWARE." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "Воспользовавшись данным программным средством" & _
        " вы тем самым принимаете условия данной лицензией." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "ЛИЦЕНЗИОННОЕ СОГЛАШЕНИЕ." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "1." & _
        " Эта программа защищена национальными законами и международными соглашениями об " & _
        "авторском праве. Исключительные права на использование этой программой принадлеж" & _
        "ат ее автору." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "2. Программой и ее компонентами можно пользоваться бесплатно, нео" & _
        "граниченное время." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "3. Использование компонентов данного программного обеспечени" & _
        "я в других программах запрещено без разрешения правообладателей/авторов этих ком" & _
        "понентов." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "Запрещено коммерческое распространение программы. (За распространение" & _
        " программы запрещено брать деньги)." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "4. Программа поставляется ""как есть"". " & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "5. " & _
        "Программа может включаться в состав платных сборников, помещаться на сайтах, отл" & _
        "ичных от сайта правообладателя только с разрешения правообладателя." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "ОГРАНИЧЕНИ" & _
        "Е ГАРАНТИЙНЫХ ОБЯЗАТЕЛЬСТВ." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "1. Программа может содержать ошибки. Правообладател" & _
        "ь не несет ответственность за возможные ошибки программы." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "2. Правообладатель не" & _
        " гарантирует, что функции, содержащиеся в программе, будут удовлетворять заявлен" & _
        "ным требованиям или что работа программы не прервется из-за ошибки." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "3. Правообл" & _
        "адатель намеренно отказывается от всех письменно заявленных и предполагаемых по-" & _
        "умолчанию гарантийных обязательств, включая ограничения в применении гарантийных" & _
        " обязательств после определенного срока и годности продукта к продаже." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "4. Ни пр" & _
        "и каких обстоятельствах правообладатель не несет обязательств перед пользователе" & _
        "м за любой вред, физический или коммерческий, нанесенный данной программой, вклю" & _
        "чая упущенную прибыль, потерю данных, ущерб репутации или другой побочный или ко" & _
        "свенный вред, произошедший из-за использования или неспособности использования д" & _
        "анной программы. Также не принимаются иски на любые другие имущественные требова" & _
        "ния пользователя программы." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "COPYRIGHT" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "1. Все исключительные авторские права н" & _
        "а программу принадлежат правообладателю." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "2. Программу нельзя дизассемблировать," & _
        " менять что-либо в ней и дополнять ее новыми функциями." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "3. При распространении " & _
        "программы обязательно указывается имя правообладателя, его контактная информация" & _
        " и сайт правообладателя." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "КОНТРОЛЬ НАД СОБЛЮДЕНИЕМ ОБЯЗАТЕЛЬСТВ." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "1. Это лиценз" & _
        "ионное соглашение соответствует национальным законам об авторском праве. Данное " & _
        "соглашение основано на новой редакции этих законов, что отменяет все остальные д" & _
        "оговоренности и соглашения, ранее применяемые по отношению к данному продукту." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & _
        "2. Все спорные вопросы решаются по взаимной договоренности сторон, а если соглаш" & _
        "ения не было достигнуто, то в судах общей юрисдикции." & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "КОНТАКТНАЯ ИНФОРМАЦИЯ" & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(10) & "А" & _
        "втор: Сомов Евгений Павлович" & Microsoft.VisualBasic.ChrW(10) & "Адрес: Украина, г. Луганск" & Microsoft.VisualBasic.ChrW(10) & "Email: info@catfish.ltd." & _
        "ua" & Microsoft.VisualBasic.ChrW(10) & "Сайт: catfish.ltd.ua"
        '
        'License
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(504, 422)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "License"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Лицензионное соглашение."
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
