Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmAccountTitleLedger
    Dim showSerach As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function
    Private Sub em_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Em.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.Em.CurrentCell = Me.Em.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub
     
    Private Sub frmItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtdatetrn.Value = Format(Now.AddDays(-1))
        FilterLedger()
    End Sub

    Public Sub FilterLedger()
        Try
            If ConnectVerify() = True Then
                Em.Rows.Clear()
                Em.ColumnCount = 8
                Em.ColumnHeadersVisible = True

                Em.Columns(0).Name = "id"
                Em.Columns(1).Name = "Date"
                Em.Columns(2).Name = "Account Title"
                Em.Columns(3).Name = "Reference No"
                Em.Columns(4).Name = "Description"
                Em.Columns(5).Name = "Debit"
                Em.Columns(6).Name = "Credit"
                Em.Columns(7).Name = "Balance"

                Dim cnt As Integer = 0 : Dim currbalance As Double = 0
                com.CommandText = "SELECT *,(SELECT debit FROM tblglgroup where groupcode=a.groupcode) as 'normaldebit' FROM tblglpostingitem as a inner join tblglpostinggroup as b on a.trnno=b.trnno where a.itemcode='" & itemcode.Text & "' order by b.dateposting,a.id asc"
                rst = com.ExecuteReader
                While rst.Read
                    If cnt = 0 Then
                        If CBool(rst("normaldebit")) = True Then
                            If Val(rst("debit")) = 0 Then
                                currbalance = Val(rst("credit"))
                            Else
                                currbalance = Val(rst("debit"))
                            End If
                        Else
                            If Val(rst("credit")) = 0 Then
                                currbalance = Val(rst("debit"))
                            Else
                                currbalance = Val(rst("credit"))
                            End If
                        End If


                        If CDate(rst("dateposting").ToString) >= CDate(txtdatetrn.Value.ToShortDateString) Then
                            Em.Rows.Add(rst("id").ToString, rst("dateposting").ToString, rst("itemname").ToString, rst("reference").ToString, rst("details").ToString, rst("debit"), rst("credit"), currbalance)
                        End If
                    Else
                        If CBool(rst("normaldebit")) = True Then
                            currbalance = Val(currbalance - rst("credit")) - rst("debit")
                        Else
                            currbalance = Val(currbalance - rst("debit")) + rst("credit")
                        End If

                        If CDate(rst("dateposting").ToString) >= CDate(txtdatetrn.Value.ToShortDateString) Then
                            Em.Rows.Add(rst("id").ToString, rst("dateposting").ToString, rst("itemname").ToString, rst("reference").ToString, rst("details").ToString, rst("debit"), rst("credit"), currbalance)
                        End If
                    End If
                    cnt = cnt + 1
                End While
                rst.Close()

                GridHideColumn(Em, {"id"})
                GridColumnAlignment(Em, {"Date"}, DataGridViewContentAlignment.MiddleCenter)
                GridColumnAlignment(Em, {"Debit", "Credit", "Balance"}, DataGridViewContentAlignment.MiddleRight)
                GridCurrencyColumn(Em, {"Credit", "Debit", "Balance"})

            End If

        Catch errMYSQL As MySqlException
            MessageBox.Show("Form:" & Me.Name & vbCrLf _
                            & "Module:" & "form_load" & vbCrLf _
                            & "Message:" & errMYSQL.Message & vbCrLf _
                            & "Details:" & errMYSQL.StackTrace, _
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch errMS As Exception
            MessageBox.Show("Form:" & Me.Name & vbCrLf _
                            & "Module:" & "form_load" & vbCrLf _
                            & "Message:" & errMS.Message & vbCrLf _
                            & "Details:" & errMS.StackTrace, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub txtdatetrn_ValueChanged(sender As Object, e As EventArgs) Handles txtdatetrn.ValueChanged
        FilterLedger()
    End Sub
End Class
