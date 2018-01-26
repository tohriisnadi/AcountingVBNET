Imports System.Data.Odbc
Public Class ClassStokOpname
    Dim Command As New OdbcCommand
    Dim oDataAdapter As New OdbcDataAdapter
    Dim dbTrans As OdbcTransaction

    Public Sub AddStokOpname(ByVal OData As DataTable)
        Dim KodeSO As String
        ModKoneksi.BukaKoneksi()
        dbTrans = ModKoneksi.Koneksi.BeginTransaction
        Command.Connection = ModKoneksi.Koneksi
        Command.Transaction = dbTrans
        Command.CommandType = CommandType.StoredProcedure
        Command.CommandText = "{call addMasterSO (?,?,?,?)}"
        Try
            Command.Parameters.Add("@kodeOperator", OdbcType.VarChar, 10, ParameterDirection.Input).Value = ModKoneksi.kodeOperator
            Command.Parameters.Add("@NamaOperator", OdbcType.VarChar, 100, ParameterDirection.Input).Value = ModKoneksi.namaOperator
            Command.Parameters.Add("@NoTxn", OdbcType.VarChar, 50, ParameterDirection.Input).Value = Guid.NewGuid.ToString

            Command.Parameters.Add("@IDStokOpname", OdbcType.VarChar, 20)
            Command.Parameters("@IDStokOpname").Direction = ParameterDirection.Output

            Command.ExecuteNonQuery()
            KodeSO = Command.Parameters("@IDStokOpname").Value

            Dim SelisishStok As Integer
            For i As Integer = 0 To OData.Rows.Count - 1
                SelisishStok = 0
                SelisishStok = CLng(OData.Rows(i).Item(3)) - CLng(OData.Rows(i).Item(5))
                Command.CommandText = " exec addDetilSO'" & Guid.NewGuid.ToString & "','" & KodeSO & "','" & OData.Rows(i).Item(0) & "','" & OData.Rows(i).Item(1) & "','" & OData.Rows(i).Item(2) & "','" & OData.Rows(i).Item(3) & "','" & OData.Rows(i).Item(5) & "','" & OData.Rows(i).Item(4) & "','" & SelisishStok & "'"
                Command.ExecuteNonQuery()
                If SelisishStok > 0 Then
                    Dim kodeStore As String
                    Command.CommandType = CommandType.StoredProcedure
                    Command.CommandText = "{call addMasterStore (?,?,?,?,?,?,?)}"
                    Try
                        Command.Parameters.Add("@Keterangan", OdbcType.VarChar, 100, ParameterDirection.Input).Value = "Penyesuaian Stok"
                        Command.Parameters.Add("@Total", OdbcType.BigInt, 20, ParameterDirection.Input).Value = OData.Rows(0).Item(4)
                        Command.Parameters.Add("@KodeDepartemen", OdbcType.VarChar, 10, ParameterDirection.Input).Value = "-"
                        Command.Parameters.Add("@kodeOperator", OdbcType.VarChar, 10, ParameterDirection.Input).Value = ModKoneksi.kodeOperator
                        Command.Parameters.Add("@NamaOperator", OdbcType.VarChar, 100, ParameterDirection.Input).Value = ModKoneksi.namaOperator
                        Command.Parameters.Add("@NoTxn", OdbcType.VarChar, 50, ParameterDirection.Input).Value = Guid.NewGuid.ToString

                        Command.Parameters.Add("@KodeTrx", OdbcType.VarChar, 20)
                        Command.Parameters("@KodeTrx").Direction = ParameterDirection.Output

                        Command.ExecuteNonQuery()
                        kodeStore = Command.Parameters("@KodeTrx").Value

                        For j As Integer = 0 To OData.Rows.Count - 1
                            Dim subTotal As Long
                            subTotal = CLng(OData.Rows(i).Item(4)) * CLng(SelisishStok)

                            Command.CommandText = " exec addDetilStore'" & Guid.NewGuid.ToString & "','" & kodeStore & "','" & OData.Rows(i).Item(0) & "','" & OData.Rows(i).Item(1) & "','" & OData.Rows(i).Item(2) & "','" & OData.Rows(i).Item(4) & "','" & SelisishStok & "','" & subTotal & "','" & OData.Rows(i).Item(3) & "'"
                            Command.ExecuteNonQuery()
                        Next

                        Command.Parameters.Clear()
                        dbTrans.Commit()
                    Catch ex As Exception
                        'dbTrans.Rollback()
                    End Try
                ElseIf SelisishStok < 0 Then
                    Dim KodeMasterRO As String
                    Dim selisihmin As Integer
                    Dim Subtotalmin As Long

                    Selisihmin = SelisishStok * -1
                    Subtotalmin = CLng(selisihmin * OData.Rows(0).Item(4))
                    Command.CommandType = CommandType.StoredProcedure
                    Command.CommandText = "{call addMasterRO (?,?,?,?,?,?,?,?,?,?,?,?)}"
                    Try
                        Command.Parameters.Add("@KodePO", OdbcType.VarChar, 15, ParameterDirection.Input).Value = ""
                        Command.Parameters.Add("@KodeSuplier", OdbcType.VarChar, 10, ParameterDirection.Input).Value = ""
                        Command.Parameters.Add("@kodeOperator", OdbcType.VarChar, 10, ParameterDirection.Input).Value = ModKoneksi.kodeOperator
                        Command.Parameters.Add("@tglNota", OdbcType.VarChar, 20, ParameterDirection.Input).Value = Format(Now, "MM/dd/yyyy")
                        Command.Parameters.Add("@statusPembayaran", OdbcType.Char, 1, ParameterDirection.Input).Value = "1"
                        Command.Parameters.Add("@total", OdbcType.BigInt, 20, ParameterDirection.Input).Value = Subtotalmin
                        Command.Parameters.Add("@diskon", OdbcType.BigInt, 20, ParameterDirection.Input).Value = 0
                        Command.Parameters.Add("@total2", OdbcType.BigInt, 20, ParameterDirection.Input).Value = Subtotalmin
                        Command.Parameters.Add("@Keterangan", OdbcType.VarChar, 255, ParameterDirection.Input).Value = "Penyesuan Stok"
                        Command.Parameters.Add("@NamaOperator", OdbcType.VarChar, 100, ParameterDirection.Input).Value = ModKoneksi.namaOperator
                        Command.Parameters.Add("@NoTxn", OdbcType.VarChar, 50, ParameterDirection.Input).Value = Guid.NewGuid.ToString

                        Command.Parameters.Add("@KodeRO", OdbcType.VarChar, 20)
                        Command.Parameters("@kodeRO").Direction = ParameterDirection.Output

                        Command.ExecuteNonQuery()
                        kodeMasterRO = Command.Parameters("@KodeRO").Value

                        For k As Integer = 0 To OData.Rows.Count - 1
                            Command.CommandText = " exec addDetilRO '" & Guid.NewGuid.ToString & "','" & KodeMasterRO & "','" & OData.Rows(i).Item(0) & "','" & OData.Rows(i).Item(1) & "','" & OData.Rows(i).Item(2) & "','" & OData.Rows(i).Item(4) & "','0','" & OData.Rows(i).Item(4) & "','" & 0 & "','" & selisihmin & "','" & Subtotalmin & "','Penyeseuaian Stok'"
                            Command.ExecuteNonQuery()
                        Next

                        Command.Parameters.Clear()
                        dbTrans.Commit()
                        ' 
                    Catch ex As Exception
                        'dbTrans.Rollback()
                        ' 
                    End Try
                End If
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
