﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Rpt_LabelBarcodePrice13
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
        Dim EaN13Generator1 As DevExpress.XtraPrinting.BarCode.EAN13Generator = New DevExpress.XtraPrinting.BarCode.EAN13Generator()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode()
        Me.DataSet_Report1 = New Master_Data.DataSet_Report()
        Me.Sp_MDInventory_PrintBarcodeListLabelTableAdapter = New Master_Data.DataSet_ReportTableAdapters.sp_MDInventory_PrintBarcodeListLabelTableAdapter()
        CType(Me.DataSet_Report1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 254.0!
        Me.TopMargin.HeightF = 0!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 254.0!
        Me.BottomMargin.HeightF = 0!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2, Me.XrLabel1, Me.XrBarCode1})
        Me.Detail.Dpi = 254.0!
        Me.Detail.DrillDownExpanded = False
        Me.Detail.HeightF = 180.0!
        Me.Detail.MultiColumn.ColumnCount = 4
        Me.Detail.MultiColumn.ColumnSpacing = 30.0!
        Me.Detail.MultiColumn.ColumnWidth = 330.0!
        Me.Detail.MultiColumn.Layout = DevExpress.XtraPrinting.ColumnLayout.AcrossThenDown
        Me.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnWidth
        Me.Detail.Name = "Detail"
        '
        'XrLabel2
        '
        Me.XrLabel2.Dpi = 254.0!
        Me.XrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Price]")})
        Me.XrLabel2.Font = New System.Drawing.Font("Bahnschrift", 7.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(153.4625!, 113.8167!)
        Me.XrLabel2.Multiline = True
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(151.5375!, 30.07917!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "XrLabel1"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight
        Me.XrLabel2.TextFormatString = "Rp {0:n0}"
        '
        'XrLabel1
        '
        Me.XrLabel1.Dpi = 254.0!
        Me.XrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[InventoryNo]")})
        Me.XrLabel1.Font = New System.Drawing.Font("Bahnschrift", 7.0!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(13.00001!, 81.47918!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(292.0!, 73.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "XrLabel1"
        '
        'XrBarCode1
        '
        Me.XrBarCode1.AutoModule = True
        Me.XrBarCode1.Dpi = 254.0!
        Me.XrBarCode1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Barcode]")})
        Me.XrBarCode1.Font = New System.Drawing.Font("Arial", 6.0!)
        Me.XrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(13.00001!, 20.00001!)
        Me.XrBarCode1.Module = 2.08!
        Me.XrBarCode1.Name = "XrBarCode1"
        Me.XrBarCode1.SizeF = New System.Drawing.SizeF(292.0!, 61.47917!)
        Me.XrBarCode1.StylePriority.UseFont = False
        Me.XrBarCode1.Symbology = EaN13Generator1
        '
        'DataSet_Report1
        '
        Me.DataSet_Report1.DataSetName = "DataSet_Report"
        Me.DataSet_Report1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sp_MDInventory_PrintBarcodeListLabelTableAdapter
        '
        Me.Sp_MDInventory_PrintBarcodeListLabelTableAdapter.ClearBeforeFill = True
        '
        'Rpt_LabelBarcodePrice
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.DataSet_Report1})
        Me.DataAdapter = Me.Sp_MDInventory_PrintBarcodeListLabelTableAdapter
        Me.DataMember = "sp_MDInventory_PrintBarcodeListLabel"
        Me.DataSource = Me.DataSet_Report1
        Me.Dpi = 254.0!
        Me.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Margins = New System.Drawing.Printing.Margins(10, 20, 0, 0)
        Me.PageHeight = 508
        Me.PageWidth = 1080
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.PaperName = "User defined"
        Me.PrinterName = "ZDesigner GT800 (EPL)"
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.RollPaper = True
        Me.SnapGridSize = 25.0!
        Me.Version = "18.2"
        CType(Me.DataSet_Report1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents DataSet_Report1 As DataSet_Report
    Friend WithEvents Sp_MDInventory_PrintBarcodeListLabelTableAdapter As DataSet_ReportTableAdapters.sp_MDInventory_PrintBarcodeListLabelTableAdapter
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrBarCode1 As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
End Class
