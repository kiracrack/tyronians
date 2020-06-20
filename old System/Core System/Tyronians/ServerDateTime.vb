Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Data

Class ServerDateTime
    Inherits System.Windows.Forms.Form
    Dim globaltime As String
    Dim tTimer As System.Timers.Timer
    Public Delegate Sub IncrementTextBoxDelegate()

    Public Sub startime()
        tTimer = New System.Timers.Timer
        tTimer.Interval = 1000
        AddHandler tTimer.Elapsed, AddressOf TimerFired
        tTimer.Enabled = True
    End Sub

    Public Sub TimerEventProcessor()
        com.CommandText = "select CURRENT_TIMESTAMP"
        rst = com.ExecuteReader()
        While rst.Read
            globaltime = rst(0).ToString
        End While
    End Sub
    Private Sub TimerFired(ByVal sender As Object, ByVal e As System.Timers.ElapsedEventArgs)
        If Me.InvokeRequired Then
            Dim incrementTextBoxDelegate As New IncrementTextBoxDelegate(AddressOf TimerEventProcessor)
            Me.BeginInvoke(incrementTextBoxDelegate)
        Else
            TimerEventProcessor()
        End If
    End Sub

    Private Sub ServerDateTime_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'ServerDateTime
        '
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Name = "ServerDateTime"
        Me.ResumeLayout(False)

    End Sub
End Class
