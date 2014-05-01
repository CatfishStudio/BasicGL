Module ModuleCube

    Public AboutShow As Boolean
    Public LicenseShow As Boolean
    Public SettingsShow As Boolean
    Public FontModule As Font
    Public ActionModuleFormat As Boolean

    Public DesignerCube As Designer
    Public Sub LoadDesigner()
        DesignerCube = New Designer
    End Sub

    Public PModule As ProcessModule
    Public Sub LoadPModule()
        PModule = New ProcessModule
    End Sub

    Public FormProcess As Processed
    Public Sub LoadFProcess()
        FormProcess = New Processed
    End Sub
End Module
