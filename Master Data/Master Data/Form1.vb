Imports System.ComponentModel
Imports System.Text


Partial Public Class Form1
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Shared Sub New()
        '   DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub
End Class
