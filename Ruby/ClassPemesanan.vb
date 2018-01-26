Imports System.Data.Odbc
Public Class ClassPemesanan
    Dim Command As New OdbcCommand
    Dim oDataAdapter As New OdbcDataAdapter
    Dim dbTrans As OdbcTransaction

    Function selectDataPemesanan()
        Dim oDataTabel As New DataTable
        oDataTabel.Clear()
        ModKoneksi.BukaKoneksi()
        Command.Connection = ModKoneksi.Koneksi
        Command.CommandType = CommandType.Text
        Command.CommandText = "exec SelectDataPemesanan "
        oDataAdapter.SelectCommand = Command
        oDataAdapter.Fill(oDataTabel)
        ModKoneksi.TutupKoneksi()
        Return oDataTabel
    End Function

    Function selectDataPemesananByDate(ByVal tglAwal As Date, ByVal tglAkhir As Date)
        Dim oDataTabel As New DataTable
        oDataTabel.Clear()
        ModKoneksi.BukaKoneksi()
        Command.Connection = ModKoneksi.Koneksi
        Command.CommandType = CommandType.Text
        Command.CommandText = "exec selectDataPemesananByDate '" & tglAwal & "','" & tglAkhir & "'"
        oDataAdapter.SelectCommand = Command
        oDataAdapter.Fill(oDataTabel)
        ModKoneksi.TutupKoneksi()
        Return oDataTabel
    End Function

    Function SelectBarangBySuplier(ByVal kodeSuplier As String)
        Dim oDataTabel As New DataTable
        oDataTabel.Clear()
        ModKoneksi.BukaKoneksi()
        Command.Connection = ModKoneksi.Koneksi
        Command.CommandType = CommandType.Text
        Command.CommandText = "exec SelectBarangBySuplier '" & kodeSuplier & "'"
        oDataAdapter.SelectCommand = Command
        oDataAdapter.Fill(oDataTabel)
        ModKoneksi.TutupKoneksi()
        Return oDataTabel
    End Function

    Function SelectSuplier()
        Dim oDataTabel As New DataTable
        oDataTabel.Clear()
        ModKoneksi.BukaKoneksi()
        Command.Connection = ModKoneksi.Koneksi
        Command.CommandType = CommandType.Text
        Command.CommandText = "exec SelectSuplier"
        oDataAdapter.SelectCommand = Command
        oDataAdapter.Fill(oDataTabel)
        ModKoneksi.TutupKoneksi()
        Return oDataTabel
    End Function

    Function selectDetilPO(ByVal KodeMasterPO As String)
        Dim oDataTabel As New DataTable
        oDataTabel.Clear()
        ModKoneksi.BukaKoneksi()
        Command.Connection = ModKoneksi.Koneksi
        Command.CommandType = CommandType.Text
        Command.CommandText = "exec selectDetilPO '" & KodeMasterPO & "'"
        oDataAdapter.SelectCommand = Command
        oDataAdapter.Fill(oDataTabel)
        ModKoneksi.TutupKoneksi()
        Return oDataTabel
    End Function

    Public Sub AddDetilBarangSuplier(ByVal kodeSuplier As String, ByVal KodeBarang As String, ByVal HargaBeli As Long)
        ModKoneksi.BukaKoneksi()
        dbTrans = ModKoneksi.Koneksi.BeginTransaction
        Command.Connection = ModKoneksi.Koneksi
        Command.Transaction = dbTrans
        Command.CommandType = CommandType.Text
        Command.CommandText = " exec addDetilBarangSuplier '" & kodeSuplier & "','" & KodeBarang & "','" & HargaBeli & "','" & ModKoneksi.kodeOperator & "','" & ModKoneksi.namaOperator & "','" & Guid.NewGuid.ToString & "'"
        Try
            Command.ExecuteNonQuery()
            dbTrans.Commit()
            MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information, "Informasi")
        Catch ex As Exception
            dbTrans.Rollback()
            MsgBox("Pesan Error : " + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        ModKoneksi.TutupKoneksi()
    End Sub

    Public Sub AddPemesananBarang(ByVal kodeSuplier As String, ByVal tglKirim As String, ByVal keterangan As String, ByVal total As Long, ByVal OData As DataTable)
        Dim kodeMasterPO As String
        ModKoneksi.BukaKoneksi()
        dbTrans = ModKoneksi.Koneksi.BeginTransaction
        Command.Connection = ModKoneksi.Koneksi
        Command.Transaction = dbTrans
        Command.CommandType = CommandType.StoredProcedure
        Command.CommandText = "{call addMasterPO (?,?,?,?,?,?,?,?)}"
        Try
            Command.Parameters.Add("@KodeSuplier", OdbcType.VarChar, 10, ParameterDirection.Input).Value = kodeSuplier
            Command.Parameters.Add("@tglKirim", OdbcType.VarChar, 50, ParameterDirection.Input).Value = tglKirim
            Command.Parameters.Add("@keterangan", OdbcType.VarChar, 255, ParameterDirection.Input).Value = keterangan
            Command.Parameters.Add("@total", OdbcType.BigInt, 20, ParameterDirection.Input).Value = total
            Command.Parameters.Add("@KodeOperator", OdbcType.VarChar, 10, ParameterDirection.Input).Value = ModKoneksi.kodeOperator
            Command.Parameters.Add("@NamaOperator", OdbcType.VarChar, 50, ParameterDirection.Input).Value = ModKoneksi.namaOperator
            Command.Parameters.Add("@NoTxn", OdbcType.VarChar, 50, ParameterDirection.Input).Value = Guid.NewGuid.ToString

            Command.Parameters.Add("@KodePO", OdbcType.VarChar, 20)
            Command.Parameters("@kodePO").Direction = ParameterDirection.Output

            Command.ExecuteNonQuery()
            kodeMasterPO = Command.Parameters("@KodePO").Value

            For i As Integer = 0 To OData.Rows.Count - 1
                Command.CommandText = " exec addDetilPO '" & Guid.NewGuid.ToString & "','" & kodeMasterPO & "','" & OData.Rows(i).Item(0) & "','" & OData.Rows(i).Item(1) & "','" & OData.Rows(i).Item(2) & "','" & OData.Rows(i).Item(3) & "','" & OData.Rows(i).Item(4) & "','" & OData.Rows(i).Item(5) & "','" & OData.Rows(i).Item(6) & "'"
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

    Public Sub EditPemesananBarang(ByVal kodeMasterPO As String, ByVal kodeSuplier As String, ByVal tglKirim As String, ByVal keterangan As String, ByVal total As Long, ByVal odata As DataTable)
        ModKoneksi.BukaKoneksi()
        dbTrans = ModKoneksi.Koneksi.BeginTransaction
        Command.Connection = ModKoneksi.Koneksi
        Command.Transaction = dbTrans
        Command.CommandType = CommandType.Text
        Command.CommandText = " exec EditMasterPO '" & kodeMasterPO & "','" & kodeSuplier & "','" & tglKirim & "','" & keterangan & "','" & total & "','" & ModKoneksi.kodeOperator & "','" & ModKoneksi.namaOperator & "','" & Guid.NewGuid.ToString & "'"

        Try
            For i As Integer = 0 To odata.Rows.Count - 1
                Command.CommandText = " exec addDetilPO '" & Guid.NewGuid.ToString & "','" & kodeMasterPO & "','" & odata.Rows(i).Item(0) & "','" & odata.Rows(i).Item(1) & "','" & odata.Rows(i).Item(2) & "','" & odata.Rows(i).Item(3) & "','" & odata.Rows(i).Item(4) & "','" & odata.Rows(i).Item(5) & "','" & odata.Rows(i).Item(6) & "'"
                Command.ExecuteNonQuery()
            Next

            Command.ExecuteNonQuery()
            dbTrans.Commit()
            MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information, "Informasi")
        Catch ex As Exception
            dbTrans.Rollback()
            MsgBox("Pesan Error : " + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        ModKoneksi.TutupKoneksi()
    End Sub
End Class
