Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmChartOfAccount
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    
    Private Sub frmChartOfAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ConnectVerify() = True Then
            treeview()
        End If
    End Sub
    Public Sub treeview()
        TreeView1.Nodes.Clear()
        'Create Group
        com.CommandText = "select * from tblglitem where glgroup=1 order by groupcode asc" : rst = com.ExecuteReader()
        While rst.Read
            Dim mainNode As New TreeNode()
            mainNode.Name = rst("groupcode").ToString
            mainNode.Text = rst("groupcode").ToString & " - " & rst("itemname").ToString
            Me.TreeView1.Nodes.Add(mainNode)
        End While
        rst.Close()

        'create gl list
        com.CommandText = "select * from tblglitem where level>0 order by level,itemcode asc" : rst = com.ExecuteReader()
        While rst.Read
            InsertTree(rst("itemcode").ToString, rst("itemcode").ToString & " - " & rst("itemname").ToString, rst("parent").ToString)
        End While
        rst.Close()

    End Sub
    Public Sub InsertTree(ByVal itemcode As String, ByVal itemname As String, ByVal parent As String)
        Dim mainNode As New TreeNode()
        mainNode.Name = itemcode
        mainNode.Text = itemname

        Dim MyNode() As TreeNode
        MyNode = TreeView1.Nodes.Find(parent, True)
        MyNode(0).Nodes.Add(mainNode)

    End Sub
 
    Private Sub ExpandGroupsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExpandGroupsToolStripMenuItem.Click
        TreeView1.ExpandAll()
    End Sub

    Private Sub CollapseGroupsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CollapseGroupsToolStripMenuItem.Click
        TreeView1.CollapseAll()
    End Sub
 
End Class
