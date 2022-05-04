' Designed by Sridevi
Imports System.Data.Odbc 'It is a namespace (library, module)

Public Class DBAccess

    Private ConnectionString As String = "Driver={MySQL ODBC 8.0 ANSI Driver}; server=141.209.241.47; database=sp2022bis698fc1g1; user=sp2022bis698fc1g1; password=Omicron"
    Private DBConnection As New OdbcConnection(ConnectionString)
    Private DBcommand As OdbcCommand 'A command is a query, like "SELECT * FROM customer"
    Public Params As New List(Of OdbcParameter) 'Parameters are conditions, such as "WHERE last_name LIKE Luke%"
    Public DBDataAdapater As OdbcDataAdapter 'the agent that carries out a query command.
    Public DBDataTable As DataTable 'for database retrieval results
    Public RecordCount As Integer
    Public DBException As String
    Public Sub ExecuteQuery(QueryString As String)

        RecordCount = 0
        DBException = String.Empty

        Try
            DBConnection.Open() 'open the database
            DBcommand = New OdbcCommand(QueryString, DBConnection)
            For Each p As OdbcParameter In Params
                DBcommand.Parameters.Add(p)
            Next
            Params.Clear()
            DBDataTable = New DataTable
            DBDataAdapater = New OdbcDataAdapter(DBcommand)
            RecordCount = DBDataAdapater.Fill(DBDataTable)
        Catch ex As Exception
            DBException = ex.Message
        End Try

        If DBConnection.State = ConnectionState.Open Then
            DBConnection.Close()
        End If

    End Sub

    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New OdbcParameter(Name, Value)
        Params.Add(NewParam)
    End Sub

End Class



