Imports System.Data.Odbc
Public Class ClassPenerimaan
    Dim Command As New OdbcCommand
    Dim oDataAdapter As New OdbcDataAdapter
    Dim dbTrans As OdbcTransaction

    Function selectDataPO()
        Dim oDataTabel As New DataTable
        oDataTabel.Clear()
        ModKoneksi.BukaKoneksi()
        Command.Connection = ModKoneksi.Koneksi
        Command.CommandType = CommandType.Text
        Command.CommandText = "exec selectDataPO "
        oDataAdapter.SelectCommand = Command
        oDataAdapter.Fill(oDataTabel)
        ModKoneksi.TutupKoneksi()
        Return oDataTabel
    End Function

    Function SelectDEtilPObyKodePO(ByVal kodePO As String)
        Dim oDataTabel As New DataTable
        oDataTabel.Clear()
        ModKoneksi.BukaKoneksi()
        Command.Connection = ModKoneksi.Koneksi
        Command.CommandType = CommandType.Text
        Command.CommandText = "exec selectDetilPO '" & kodePO & "'"
        oDataAdapter.SelectCommand = Command
        oDataAdapter.Fill(oDataTabel)
        ModKoneksi.TutupKoneksi()
        Return oDataTabel
    End Function

    Public Sub AddPenerimaanBarang(ByVal KodePO As String, ByVal KodeSuplier As String, ByVal tglNota As String, ByVal StatusBayar As String, ByVal Total As Long, ByVal Diskon As Long, ByVal Total2 As Long, ByVal Keterangan As String, ByVal OData As DataTable)
        Dim kodeMasterRO As String
        ModKoneksi.BukaKoneksi()
        dbTrans = ModKoneksi.Koneksi.BeginTransaction
        Command.Connection = ModKoneksi.Koneksi
        Command.Transaction = dbTrans
        Command.CommandType = CommandType.StoredProcedure
        Command.CommandText = "{call addMasterRO (?,?,?,?,?,?,?,?,?,?,?,?)}"
        Try
            Command.Parameters.Add("@KodePO", OdbcType.VarChar, 15, ParameterDirection.Input).Value = KodePO
            Command.Parameters.Add("@KodeSuplier", OdbcType.VarChar, 10, ParameterDirection.Input).Value = KodeSuplier
            Command.Parameters.Add("@kodeOperator", OdbcType.VarChar, 10, ParameterDirection.Input).Value = ModKoneksi.kodeOperator
            Command.Parameters.Add("@tglNota", OdbcType.VarChar, 20, ParameterDirection.Input).Value = tglNota
            Command.Parameters.Add("@statusPembayaran", OdbcType.Char, 1, ParameterDirection.Input).Value = StatusBayar
            Command.Parameters.Add("@total", OdbcType.BigInt, 20, ParameterDirection.Input).Value = Total
            Command.Parameters.Add("@diskon", OdbcType.BigInt, 20, ParameterDirection.Input).Value = Diskon
            Command.Parameters.Add("@total2", OdbcType.BigInt, 20, ParameterDirection.Input).Value = Total2
            Command.Parameters.Add("@Keterangan", OdbcType.VarChar, 255, ParameterDirection.Input).Value = Keterangan
            Command.Parameters.Add("@NamaOperator", OdbcType.VarChar, 100, ParameterDirection.Input).Value = ModKoneksi.namaOperator
            Command.Parameters.Add("@NoTxn", OdbcType.VarChar, 50, ParameterDirection.Input).Value = Guid.NewGuid.ToString

            Command.Parameters.Add("@KodeRO", OdbcType.VarChar, 20)
            Command.Parameters("@kodeRO").Direction = ParameterDirection.Output

            Command.ExecuteNonQuery()
            kodeMasterRO = Command.Parameters("@KodeRO").Value

            For i As Integer = 0 To OData.Rows.Count - 1
                Command.CommandText = " exec addDetilRO '" & Guid.NewGuid.ToString & "','" & kodeMasterRO & "','" & OData.Rows(i).Item(0) & "','" & OData.Rows(i).Item(1) & "','" & OData.Rows(i).Item(6) & "','" & OData.Rows(i).Item(2) & "','" & OData.Rows(i).Item(3) & "','" & OData.Rows(i).Item(4) & "','" & OData.Rows(i).Item(5) & "','" & OData.Rows(i).Item(7) & "','" & OData.Rows(i).Item(9) & "','" & OData.Rows(i).Item(10) & "'"
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

    Function selectRObyDate(ByVal tglAwal As Date, ByVal tglAkhir As Date)
        Dim oDataTabel As New DataTable
        oDataTabel.Clear()
        ModKoneksi.BukaKoneksi()
        Command.Connection = ModKoneksi.Koneksi
        Command.CommandType = CommandType.Text
        Command.CommandText = "exec selectRObyDate '" & tglAwal & "','" & tglAkhir & "'"
        oDataAdapter.SelectCommand = Command
        oDataAdapter.Fill(oDataTabel)
        ModKoneksi.TutupKoneksi()
        Return oDataTabel
    End Function

    Function selectDetilRO(ByVal kodeRo As String)
        Dim oDataTabel As New DataTable
        oDataTabel.Clear()
        ModKoneksi.BukaKoneksi()
        Command.Connection = ModKoneksi.Koneksi
        Command.CommandType = CommandType.Text
        Command.CommandText = "exec selectDetilRO '" & kodeRo & "'"
        oDataAdapter.SelectCommand = Command
        oDataAdapter.Fill(oDataTabel)
        ModKoneksi.TutupKoneksi()
        Return oDataTabel
    End Function
End Class
