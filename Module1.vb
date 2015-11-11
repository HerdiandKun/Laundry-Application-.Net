Imports System.Data.OleDb
Public Module Module1
    Public Conn As OleDbConnection
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public lokasidb As String
    Public strreportname As String
    Public strsql As String
    Public cmd As OleDbCommand
    Public rd As OleDbDataReader
    Sub koneksi()
        'lokasidb = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DBLoundry.accdb"
        lokasidb = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=dbLaundry.mdb"
        Conn = New OleDbConnection(lokasidb)
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub
End Module
