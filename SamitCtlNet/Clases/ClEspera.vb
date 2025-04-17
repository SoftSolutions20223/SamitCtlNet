Imports DevExpress.XtraWaitForm
Imports DevExpress.XtraSplashScreen

Public Class ClEspera
    'Private Espera As New SplashScreenManager
    Private RRR As New SplashFormProperties
    Private Espera As New SplashScreenManager(GetType(WaitForm1), RRR)


    'Me.SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.PruebaDll.WaitForm1), True, True)
    Private _Titulo As String = "SAMIT SQL - Por Favor Esperar"
    Private _Descripcion As String = "Cargando Información"
    Public Sub Mostrar(Optional Titulo As String = "", Optional Descripcion As String = "")

        'Espera.ActiveSplashFormTypeInfo = New TypeInfo("WaitForm1.vb", Mode.WaitForm)
        Espera.ShowWaitForm()
        If Titulo.Trim <> "" Then
            _Titulo = Titulo
        End If
        If Descripcion.Trim <> "" Then
            _Descripcion = Descripcion
        End If
        Espera.SetWaitFormCaption(_Titulo)
        Espera.SetWaitFormDescription(_Descripcion)

    End Sub
    Public Sub Terminar()
        On Error Resume Next
        Espera.CloseWaitForm()
    End Sub
    Public Property Descripcion As String
        Get
            Descripcion = _Descripcion
        End Get
        Set(value As String)
            _Descripcion = value
            Espera.SetWaitFormDescription(_Descripcion)
        End Set
    End Property
End Class
