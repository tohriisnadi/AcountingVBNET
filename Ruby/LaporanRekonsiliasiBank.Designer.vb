<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class LaporanRekonsiliasiBank
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ReportHeading = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.TxtJudul = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TxtTanggal = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TxtJumlah = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TxtSubtotal = New DevExpress.XtraReports.UI.XRTableCell()
        Me.OddStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.EvenStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.GroupHeader = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.TableHeader = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.LbTgl = New DevExpress.XtraReports.UI.XRLabel()
        Me.lbNamaBank = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'ReportHeading
        '
        Me.ReportHeading.Font = New System.Drawing.Font("Bernard MT Condensed", 36.0!, System.Drawing.FontStyle.Bold)
        Me.ReportHeading.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.ReportHeading.Name = "ReportHeading"
        Me.ReportHeading.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.Detail.HeightF = 25.0!
        Me.Detail.KeepTogetherWithDetailReports = True
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable1
        '
        Me.XrTable1.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(650.0!, 25.0!)
        Me.XrTable1.StylePriority.UseFont = False
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.TxtJudul, Me.TxtTanggal, Me.TxtJumlah, Me.TxtSubtotal})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'TxtJudul
        '
        Me.TxtJudul.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TxtJudul.Name = "TxtJudul"
        Me.TxtJudul.StylePriority.UseFont = False
        Me.TxtJudul.Text = "TxtJudul"
        Me.TxtJudul.Weight = 2.2395837151883677R
        '
        'TxtTanggal
        '
        Me.TxtTanggal.Name = "TxtTanggal"
        Me.TxtTanggal.Text = "TxtTanggal"
        Me.TxtTanggal.Weight = 1.781250100087632R
        '
        'TxtJumlah
        '
        Me.TxtJumlah.Name = "TxtJumlah"
        Me.TxtJumlah.Text = "TxtJumlah"
        Me.TxtJumlah.Weight = 1.2708327910876216R
        '
        'TxtSubtotal
        '
        Me.TxtSubtotal.Name = "TxtSubtotal"
        Me.TxtSubtotal.Text = "TxtSubtotal"
        Me.TxtSubtotal.Weight = 1.2083331531948551R
        '
        'OddStyle
        '
        Me.OddStyle.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.OddStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.OddStyle.Name = "OddStyle"
        Me.OddStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 20.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'EvenStyle
        '
        Me.EvenStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.EvenStyle.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.EvenStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EvenStyle.Name = "EvenStyle"
        Me.EvenStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        '
        'GroupHeader
        '
        Me.GroupHeader.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!)
        Me.GroupHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.GroupHeader.Name = "GroupHeader"
        '
        'TableHeader
        '
        Me.TableHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.TableHeader.Font = New System.Drawing.Font("Bernard MT Condensed", 20.25!)
        Me.TableHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.TableHeader.Name = "TableHeader"
        Me.TableHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.LbTgl, Me.lbNamaBank, Me.XrLabel1})
        Me.ReportHeader.HeightF = 73.16666!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'LbTgl
        '
        Me.LbTgl.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTgl.LocationFloat = New DevExpress.Utils.PointFloat(195.8335!, 23.0!)
        Me.LbTgl.Name = "LbTgl"
        Me.LbTgl.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.LbTgl.SizeF = New System.Drawing.SizeF(189.5833!, 23.0!)
        Me.LbTgl.StylePriority.UseFont = False
        Me.LbTgl.StylePriority.UseTextAlignment = False
        Me.LbTgl.Text = "dd/mm/yyy"
        Me.LbTgl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lbNamaBank
        '
        Me.lbNamaBank.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNamaBank.LocationFloat = New DevExpress.Utils.PointFloat(295.8333!, 0.0!)
        Me.lbNamaBank.Name = "lbNamaBank"
        Me.lbNamaBank.Padding = New DevExpress.XtraPrinting.PaddingInfo(3, 3, 0, 0, 100.0!)
        Me.lbNamaBank.SizeF = New System.Drawing.SizeF(159.375!, 23.0!)
        Me.lbNamaBank.StylePriority.UseFont = False
        Me.lbNamaBank.StylePriority.UsePadding = False
        Me.lbNamaBank.StylePriority.UseTextAlignment = False
        Me.lbNamaBank.Text = "BCA"
        Me.lbNamaBank.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(106.25!, 0.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 4, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(189.5833!, 23.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UsePadding = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "REKONSILIASI "
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'PageFooter
        '
        Me.PageFooter.HeightF = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'LaporanRekonsiliasiBank
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageFooter})
        Me.DataMember = "Categories"
        Me.Margins = New System.Drawing.Printing.Margins(100, 99, 20, 100)
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.GroupHeader, Me.ReportHeading, Me.TableHeader, Me.EvenStyle, Me.OddStyle})
        Me.Version = "13.1"
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents ReportHeading As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents OddStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents EvenStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents GroupHeader As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents TableHeader As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents TxtJudul As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TxtSubtotal As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents LbTgl As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lbNamaBank As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents TxtTanggal As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TxtJumlah As DevExpress.XtraReports.UI.XRTableCell
End Class
