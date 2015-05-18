Imports System.ComponentModel
Imports System.Text
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars.Helpers


Public Class Form1
    Sub New()
        InitSkins()
        InitializeComponent()
        Me.InitSkinGallery()
        Me.InitGrid()

    End Sub
    Sub InitSkins()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        UserLookAndFeel.Default.SetSkinStyle("Office 2013")

    End Sub
    Private Sub InitSkinGallery()
        SkinHelper.InitSkinGallery(rgbiSkins, True)
    End Sub
    Dim gridDataList As New BindingList(Of Person)
    Private Sub InitGrid()
        gridDataList.Add(New Person("John", "Smith"))
        gridDataList.Add(New Person("Gabriel", "Smith"))
        gridDataList.Add(New Person("Ashley", "Smith", "some comment"))
        gridDataList.Add(New Person("Adrian", "Smith", "some comment"))
        gridDataList.Add(New Person("Gabriella", "Smith", "some comment"))
        Me.gridControl.DataSource = gridDataList
    End Sub

End Class
