Imports System.Data
Imports System.Data.Odbc
Imports System
Imports System.IO
Imports System.Net.NetworkInformation
Module ModKoneksi
    Public Koneksi As New OdbcConnection
    Dim KonString As String
    Public kodeOperator As String = "OP0001"
    Public namaOperator As String = "Admin"
    Public Company As String = "BAKUNG UBUD RESORT & VILLAS "
    Public Alamat As String = "Jalan sri Wedari, Tegalantang, Ubud, Gianyar Bali"
    Public NPWP As String = "XXX/XXX/XXX/XXX"
    Public SPVmode As Boolean
    Public kodeSPV As String
    Public namaSPV As String
    Public Head1 As String = "Batang Hari - Denpasar"
    Public Head2 As String = ""
    Public Jabatan As String
    Public IDCabang As String = "4"
    Public Cabang As String = "Ayu Convenience Store"

    Public nilaiKontrak As String
    Public Tanggal As String
    Dim Service As String
    Public isBukaKas As Boolean
    Public idKartuKredit() As String
    Public KartuKredit() As String
    Public Chrg() As Double
    Public idKartuDebet() As String
    Public KartuDebet() As String

    
    Sub BukaKoneksi()
        'Baca()
        'Dim myController As New System.ServiceProcess.ServiceController(Service)
        'If myController.CanStop = False Then
        'myController.Start()
        'End If
        Koneksi.Close()
        KonString = "DSN=ruby;UID=;PWD=;"

        Koneksi.ConnectionString = KonString

        Try

            If Koneksi.State = ConnectionState.Open Then
                Koneksi.Close()
            End If
            Koneksi.Open()
        Catch ex As Exception
            MsgBox("Pesan Error : " & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Peringatan !")
        End Try
    End Sub

    Sub TutupKoneksi()
        Try
            Koneksi.Close()
        Catch ex As Exception
            MsgBox("Pesan Error : " & vbCrLf & "Tidak Ada Koneksi Yang Terbuka ! ", MsgBoxStyle.Critical, "Peringatan !")
        End Try
    End Sub

    Function getMacAddress()
        Dim nics() As NetworkInterface = _
              NetworkInterface.GetAllNetworkInterfaces
        Return nics(0).GetPhysicalAddress.ToString
    End Function
End Module
