Module GenericFunctMod
    Public con As New OleDb.OleDbConnection
    Public sqlstr As String

    Public Sub createConnection()
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\CricketScoreboard_DB.accdb"
        con.Open()
    End Sub

    Private Sub checkConnection()
        If con.State <> ConnectionState.Open Then
            createConnection()
        End If
    End Sub

    Public Function getDataReader(ByVal strsql As String) As OleDb.OleDbDataReader
        checkConnection()
        Dim cmd As New OleDb.OleDbCommand(strsql, con)
        Dim dr As OleDb.OleDbDataReader
        dr = cmd.ExecuteReader
        Return dr
    End Function

    Public Function getDataTable(ByVal strsql As String) As DataTable
        con.Close()
        checkConnection()
        Dim cmd As New OleDb.OleDbCommand(strsql, con)
        Dim table As New DataTable
        Dim da As New OleDb.OleDbDataAdapter(cmd)
        da.Fill(table)
        Return table
    End Function

    Public Function getDataSet(ByVal strsql As String, ByVal tableName As String) As DataSet
        checkConnection()
        Dim ds As New DataSet
        Dim cmd As New OleDb.OleDbCommand(strsql, con)
        Dim da As New OleDb.OleDbDataAdapter(cmd)
        da.Fill(ds, tableName)
        Return ds
    End Function

    Public Function makeConnection() As OleDb.OleDbConnection
        con.Close()
        checkConnection()
        makeConnection = con
    End Function

    Public Function getMaxIDValues(ByVal dt As DataTable) As String
        Dim max As String = dt.Rows.Count
        Dim no As Integer = CInt(max)
        Dim x As Integer
        If no = 0 Then
            x = 1
        Else
            x = no + 1
        End If
        getMaxIDValues = CStr(x)
    End Function

    Public Function saveDialog() As Boolean
        Dim reply As DialogResult
        Dim mult As Integer = 0
        Do
            reply = MessageBox.Show("Do you wish to Save?", "Save Status", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            Call Reset()
            mult += 1
        Loop While (reply > vbNo)
        If reply = vbYes Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function saveProceedDialog() As Boolean
        Dim reply As DialogResult
        Dim mult As Integer = 0
        Do
            reply = MessageBox.Show("Do you wish to save and proceed to the next innings?", "Save and Proceed Status", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            Call Reset()
            mult += 1
        Loop While (reply > vbNo)
        If reply = vbYes Then
            Return True
        Else
            Return False
        End If

    End Function


    Public Function updateDialog() As Boolean
        Dim reply As DialogResult
        Dim mult As Integer = 0
        Do
            reply = MessageBox.Show("Do you wish to Update?", "Update Status", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            Call Reset()
            mult += 1
        Loop While (reply > vbNo)
        If reply = vbYes Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function exitForm() As Boolean
        Dim reply As DialogResult
        Dim mult As Integer = 0
        Do
            reply = MessageBox.Show("Do you wish to exit?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            Call Reset()
            mult += 1
        Loop While (reply > vbNo)
        If reply = vbYes Then
            Return True
        Else
            Return False
        End If
    End Function
End Module
