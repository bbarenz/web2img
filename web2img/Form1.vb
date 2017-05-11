' web2img Written by Ben Barenz 
' Created May 10, 2017 
' Last updated: 
' The purpose of this program is to take a screenshot of a webbrower control and save it as a PNG file to the hard drive. 
' The user may set the interval at which the image is updated in miliseconds and the interval the webbrower updates in minutes

Imports System.ComponentModel

Public Class Form1

    Private Declare Function PrintWindow Lib "user32.dll" (ByVal hwnd As IntPtr, ByVal hdcBlt As IntPtr, ByVal nFlags As UInt32) As Boolean
    Private ShowErrors As Boolean = False


#Region "Form & Control Events"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '---------------------------------------------------------------------------
        ' Reload the app.config settings
        My.Settings.Reload()
        '---------------------------------------------------------------------------
        ' Initialize the timer intervals
        tmr_BrowserUpdate.Interval = My.Settings.BrowserUpdateIntervalSave * 60000 ' Brower in minutes, 1000ms = 1sec * 60 = 60,000
        nud_BrowserUpdateInterval.Value = My.Settings.BrowserUpdateIntervalSave

        tmr_ImageUpdate.Interval = My.Settings.UpdateIntervalSave
        nud_ImageupdateInterval.Value = My.Settings.UpdateIntervalSave
        '---------------------------------------------------------------------------
        ' Load the saved form size
        If My.Settings.MeHeight <> 0 Then Me.Height = My.Settings.MeHeight
        If My.Settings.MeWidth <> 0 Then Me.Width = My.Settings.MeWidth
        '---------------------------------------------------------------------------
        '---------------------------------------------------------------------------
        '---------------------------------------------------------------------------
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        '---------------------------------------------------------------------------
        ' save the form size at closing
        My.Settings.MeHeight = Me.Height
        My.Settings.MeWidth = Me.Width
        My.Settings.Save()
        '---------------------------------------------------------------------------
    End Sub
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        '---------------------------------------------------------------------------
        ' Cancel the minimize event and call the custom hide sub
        If WindowState = FormWindowState.Minimized Then
            WindowState = FormWindowState.Normal
            HideMe()
        End If
        '---------------------------------------------------------------------------
    End Sub
    Private Sub WebBrowser1_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs) Handles WebBrowser1.Navigated
        '---------------------------------------------------------------------------
        ' Enable the refresh enable checkbox once the webpage loads 
        chk_EnableBrowerUpdateTimer.Enabled = True
        '---------------------------------------------------------------------------
    End Sub

#End Region
#Region "Buttons"
    Private Sub btn_Go_Click(sender As Object, e As EventArgs) Handles btn_Go.Click
        '---------------------------------------------------------------------------
        ' Save the URL text, suppress script errors in the webbrowser and load navigate
        My.Settings.urlSave = txt_url.Text
        WebBrowser1.ScriptErrorsSuppressed = True

        If txt_url.Text <> "" Then WebBrowser1.Navigate(txt_url.Text) Else MsgBox("You must enter a URL first")
        '---------------------------------------------------------------------------
    End Sub

    Private Sub btn_BrowseFile_Click(sender As Object, e As EventArgs) Handles btn_BrowseFile.Click
        '---------------------------------------------------------------------------
        ' File browser dialog to the save location of the image file 
        Dim fb As New FolderBrowserDialog
        ' Default to the desktop
        If txt_SaveDirectory.Text = "" Then fb.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) Else fb.SelectedPath = txt_SaveDirectory.Text

        If fb.ShowDialog = DialogResult.OK Then txt_SaveDirectory.Text = fb.SelectedPath
        '---------------------------------------------------------------------------
    End Sub

#End Region

#Region "Tool Stip Menus/Context Menus"

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Written by Ben Barenz Copyright 2017")
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        MsgBox("This program will take screenshots of a webpage at an interval set by the user. The saved image size will be equal to the size of the webpage in the program. " &
               "Resize the window to change the size of the saved image. Once the page is selected the program can be hidden to the system tray. ")
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        ShowMe()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        HideMe()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Me.Close()
    End Sub

    Private Sub HideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideToolStripMenuItem.Click
        HideMe()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub UpdateImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateImageToolStripMenuItem.Click
        SaveImage()
    End Sub
    Private Sub RefreshBrowserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshBrowserToolStripMenuItem.Click
        If WebBrowser1.Url IsNot Nothing Then WebBrowser1.Refresh()
    End Sub

#End Region

#Region "Checkboxes"

    Private Sub chk_EnableTimer_CheckedChanged(sender As Object, e As EventArgs) Handles chk_EnableImageTimer.CheckedChanged
        '---------------------------------------------------------------------------
        ' Save the update interval and push the checkbox state to the timer enable property
        tmr_ImageUpdate.Interval = CInt(nud_ImageupdateInterval.Value)
        tmr_ImageUpdate.Enabled = chk_EnableImageTimer.Checked
        '---------------------------------------------------------------------------
    End Sub
    Private Sub chk_EnableBrowerUpdateTimer_CheckedChanged(sender As Object, e As EventArgs) Handles chk_EnableBrowerUpdateTimer.CheckedChanged
        '---------------------------------------------------------------------------
        ' Save the update interval and push the checkbox state to the timer enable property
        tmr_BrowserUpdate.Interval = CInt(nud_BrowserUpdateInterval.Value * 60000)
        tmr_BrowserUpdate.Enabled = chk_EnableBrowerUpdateTimer.Checked
        '---------------------------------------------------------------------------
    End Sub

#End Region

#Region "Timers"

    Private Sub tmr_main_Tick(sender As Object, e As EventArgs) Handles tmr_ImageUpdate.Tick
        '---------------------------------------------------------------------------
        ' load the interval value incase it changed since the last event
        tmr_ImageUpdate.Interval = CInt(nud_ImageupdateInterval.Value)
        ' Only update the image if the webbrower is not reloading
        ' This will prevent unpredictable images from showing while reloading 
        If WebBrowser1.IsBusy = False Then SaveImage()
        '---------------------------------------------------------------------------
    End Sub
    Private Sub tmr_BrowserUpdate_Tick(sender As Object, e As EventArgs) Handles tmr_BrowserUpdate.Tick
        '---------------------------------------------------------------------------
        ' Reload the interval, only refresh if the URL is loaded
        tmr_BrowserUpdate.Interval = CInt(nud_BrowserUpdateInterval.Value * 60000)
        If WebBrowser1.Url IsNot Nothing Then WebBrowser1.Refresh()
        '---------------------------------------------------------------------------
    End Sub

#End Region

#Region "Custom Subs"

    Private Sub SaveImage()
        '---------------------------------------------------------------------------
        ' Saves a screenshot of the screen bounds of the webbrowser control 
        ' Code References: https://code.msdn.microsoft.com/windowsapps/Fun-Tool-Aero-Look-Alike-89ab6170
        '---------------------------------------------------------------------------
        Try

            If txt_SaveDirectory.Text <> "" Then ' make sure the path is not empty 

                Dim screenshot As New Bitmap(WebBrowser1.Bounds.Width, WebBrowser1.Bounds.Height)

                Dim gfxBmp As Graphics = Graphics.FromImage(screenshot)
                Dim hdcBitmap As IntPtr = gfxBmp.GetHdc

                PrintWindow(WebBrowser1.Handle, hdcBitmap, 0)

                Application.DoEvents()

                gfxBmp.ReleaseHdc(hdcBitmap)
                gfxBmp.Dispose()

                screenshot.Save(txt_SaveDirectory.Text & "\web2img.png", Imaging.ImageFormat.Png) ' Change the image format here 
            End If
        Catch ex As Exception
            If ShowErrors = True Then MsgBox(ex.ToString)
        End Try
        '---------------------------------------------------------------------------
        '---------------------------------------------------------------------------
    End Sub
    Private Sub HideMe()
        '---------------------------------------------------------------------------
        ' Custom hide sub. Change the opacity to 0 , hide the taskbar icon and send to back
        Me.Opacity = 0
        Me.ShowInTaskbar = False
        Me.SendToBack()
        '---------------------------------------------------------------------------
    End Sub

    Private Sub ShowMe()
        '---------------------------------------------------------------------------
        ' Custom Show sub. Change the opacity to 100, show the taskbar icon and bring to front
        Me.Opacity = 100
        Me.ShowInTaskbar = True
        Me.BringToFront()
        '---------------------------------------------------------------------------
    End Sub

#End Region




End Class
