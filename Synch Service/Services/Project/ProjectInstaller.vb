Imports System.ComponentModel
Imports System.Configuration.Install
Imports System.ServiceProcess


Public Class ProjectInstaller
    Shared Sub Main(ByVal cmdArgs() As String)
        Dim ServicesToRun() As System.ServiceProcess.ServiceBase
        ServicesToRun = New System.ServiceProcess.ServiceBase() {New MonitoringService()}
        System.ServiceProcess.ServiceBase.Run(ServicesToRun)
    End Sub
End Class
