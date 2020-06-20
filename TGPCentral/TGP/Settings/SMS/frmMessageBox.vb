Imports System.Net
Imports System.Windows.Forms
Imports System.Xml
Imports System.IO
Imports System.Reflection
Imports System.Data.SqlClient

Public Class frmMessageBox

    Private Sub frmMessageBox_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmMessageBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CheckBox1.Checked = True Then
            ckWriteNumber.Enabled = False
            txtSendTo.ReadOnly = True
            txtUsherName.Visible = False
            txtContent.TabIndex = 0
            txtContent.Focus()
        Else
            ckWriteNumber.Enabled = True
            txtSendTo.ReadOnly = False
            txtUsherName.Visible = True
            LoadGateway()
        End If
        LoadToComboBoxDB("select * from tblusheraccounts order by fullname asc", "fullname", "id", txtUsherName)
    End Sub
    Private Sub txtUsherName_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtUsherName.SelectedValueChanged
        If txtUsherName.Text <> "" Then
            usherid.Text = DirectCast(txtUsherName.SelectedItem, ComboBoxItem).HiddenValue()
            txtContent.Focus()
        End If
    End Sub

    Public Sub LoadGateway()
        LoadToComboBoxDB("select * from tblgateway order by gatewayname asc", "gatewayname", "id", txtGatewayName)
    End Sub
    Private Sub txtGatewayName_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtGatewayName.SelectedValueChanged
        If txtGatewayName.Text <> "" Then
            gatewayid.Text = DirectCast(txtGatewayName.SelectedItem, ComboBoxItem).HiddenValue()
            txtGatewayNumber.Text = qrysingledata("cellnumber", "cellnumber", "tblgateway where id='" & gatewayid.Text & "'")
            txtSendTo.Focus()
        End If

    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        If ckWriteNumber.Checked = True And txtSendTo.Text = "" Then
            MessageBox.Show("Please enter number", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSendTo.Focus()
            Exit Sub
        ElseIf ckWriteNumber.Checked = True And txtGatewayName.Text = "" Then
            MessageBox.Show("Please select gateway", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSendTo.Focus()
            Exit Sub
        ElseIf CheckBox1.Checked = False And ckWriteNumber.Checked = False And txtUsherName.Text = "" Then
            MessageBox.Show("Please select usher name", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSendTo.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to continue this action?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If ckWriteNumber.Checked = True Then
                SendMessageGateway(txtSendTo.Text, txtGatewayNumber.Text, txtContent.Text, txtGatewayName.Text, False)
                MessageBox.Show("Message successfully posted", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                If CheckBox1.Checked = True Then
                    Me.Close()
                End If
            Else
                'SendIndividualMessage(usherid.Text, txtContent.Text, False)
                MessageBox.Show("Message successfully posted", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub ckWriteNumber_CheckedChanged(sender As Object, e As EventArgs) Handles ckWriteNumber.CheckedChanged
        If ckWriteNumber.Checked = True Then
            txtUsherName.Visible = False
            txtGatewayName.Enabled = True
            txtSendTo.Focus()
        Else
            txtUsherName.Visible = True
            txtGatewayName.Enabled = False
            txtGatewayName.SelectedIndex = -1

        End If
    End Sub
End Class
