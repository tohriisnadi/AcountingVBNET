Imports System.Data.Odbc
Public Class ClassStore
    Dim Command As New OdbcCommand
    Dim oDataAdapter As New OdbcDataAdapter
    Dim dbTrans As OdbcTransaction

    Public Sub AddStore(ByVal keterangan As String, ByVal Total As Long, ByVal KodeDepartemen As String, ByVal OData As DataTable)
        Dim kodeStore As String
        ModKoneksi.BukaKoneksi()
        dbTrans = ModKoneksi.Koneksi.BeginTransaction
        Command.Connection = ModKoneksi.Koneksi
        Command.Transaction = dbTrans
        Command.CommandType = CommandType.StoredProcedure
        Command.CommandText = "{call addMasterStore (?,?,?,?,?,?,?)}"
        Try
            Command.Parameters.Add("@Keterangan", OdbcType.VarChar, 100, ParameterDirection.Input).Value = keterangan
            Command.Parameters.Add("@Total", OdbcType.BigInt, 20, ParameterDirection.Input).Value = Total
            Command.Parameters.Add("@KodeDepartemen", OdbcType.VarChar, 10, ParameterDirection.Input).Value = KodeDepartemen
            Command.Parameters.Add("@kodeOperator", OdbcType.VarChar, 10, ParameterDirection.Input).Value = ModKoneksi.kodeOperator
            Command.Parameters.Add("@NamaOperator", OdbcType.VarChar, 100, ParameterDirection.Input).Value = ModKoneksi.namaOperator
            Command.Parameters.Add("@NoTxn", OdbcType.VarChar, 50, ParameterDirection.Input).Value = Guid.NewGuid.ToString

            Command.Parameters.Add("@KodeTrx", OdbcType.VarChar, 20)
            Command.Parameters("@KodeTrx").Direction = ParameterDirection.Output

            Command.ExecuteNonQuery()
            kodeStore = Command.Parameters("@KodeTrx").Value

            For i As Integer = 0 To OData.Rows.Count - 1
                Command.CommandText = " exec addDetilStore'" & Guid.NewGuid.ToString & "','" & kodeStore & "','" & OData.Rows(i).Item(0) & "','" & OData.Rows(i).Item(1) & "','" & OData.Rows(i).Item(2) & "','" & OData.Rows(i).Item(3) & "','" & OData.Rows(i).Item(4) & "','" & OData.Rows(i).Item(5) & "','" & OData.Rows(i).Item(6) & "'"
                Command.ExecuteNonQuery()
            Next

            Command.Parameters.Clear()
            dbTrans.Commit()
            MsgBox("Data has been saved", MsgBoxStyle.Information, "Information")
        Catch ex As Exception
            dbTrans.Rollback()
            MsgBox("Pesan Error : " + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        ModKoneksi.TutupKoneksi()
    End Sub

End Class
