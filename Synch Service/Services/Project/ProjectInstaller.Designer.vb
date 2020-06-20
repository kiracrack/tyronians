Imports System.ServiceProcess

<System.ComponentModel.RunInstaller(True)> Partial Class ProjectInstaller
    Inherits System.Configuration.Install.Installer
    Private serviceInstaller As ServiceInstaller
    Private processInstaller As ServiceProcessInstaller

    Public Sub New()
        ' Instantiate installers for process and services.
        processInstaller = New ServiceProcessInstaller()
        serviceInstaller = New ServiceInstaller()

        ' The services run under the system account.
        processInstaller.Account = ServiceAccount.LocalSystem

        ' The services are started manually.
        serviceInstaller.StartType = ServiceStartMode.Automatic

        ' ServiceName must equal those on ServiceBase derived classes.
        serviceInstaller.ServiceName = "TGPService"
        serviceInstaller.DisplayName = "TGP Sync Service"
        serviceInstaller.Description = "Powerfull Member synch service for Tyro Gyn Phi Fraternity"

        ' Add installers to collection. Order is not important.
        Installers.Add(serviceInstaller)
        Installers.Add(processInstaller)
    End Sub

End Class
