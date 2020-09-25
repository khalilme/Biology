Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

Public Class Form1


    Dim CoinsThread As Threading.Thread

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        Timer1.Enabled = True
        BtnStart.Enabled = False
        BtnStop.Enabled = True
        Coins.StopLoop = False
        lblPictures.Text = Coins.MaxPicNo
        CoinsThread = New Threading.Thread(AddressOf Coins.ThrowCoins)
        CoinsThread.Start()
    End Sub

    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles BtnStop.Click
        Coins.StopLoop = True
        Timer1.Enabled = False
        BtnStart.Enabled = True
        BtnStop.Enabled = False
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Try
            Dim Bf As New BinaryFormatter
            Dim MyFile As FileStream = File.Open("CoinsPictures.txt", FileMode.Create)
            Bf.Serialize(MyFile, Coins.PicsInfo)
            MyFile.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Coins.StopLoop = True
        Timer1.Enabled = False
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        Coins.Reset(Not BtnStart.Enabled)
        BtnStop.PerformClick()
        DataGridView1.DataSource = Nothing
        lblPictures.Text = "0"
        lblTrials.Text = "0"
        lblTime.Text = "0 يوم و 0 ساعة و 0 دقيقة و 0 ثانية"
        lblSpeed.Text = "0"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblPictures.Text = Coins.MaxPicNo
        lblTrials.Text = Coins.Trials.ToString("N0")
        lblTime.Text = Coins.ElapsedTime.ToString()
        lblSpeed.Text = Coins.Trials \ Coins.ElapsedTime.TotalSeconds & " محاولة في الثانية"

        If DataGridView1.RowCount < Coins.PicsInfo.Count Then
            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = Coins.PicsInfo
            Try
                DataGridView1.CurrentCell = DataGridView1.Rows(DataGridView1.RowCount - 1).Cells(0)
            Catch
            End Try
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPictures.Text = Coins.MaxPicNo
        lblTrials.Text = Coins.Trials.ToString("N0")
        lblTime.Text = Coins.ElapsedTime.ToString()
        If Coins.ElapsedTime.TotalSeconds > 0 Then
            lblSpeed.Text = Coins.Trials \ Coins.ElapsedTime.TotalSeconds & " محاولة في الثانية"
        End If

        Dim Lst As New List(Of PictureInfo)
        Try
            Dim Bf As New BinaryFormatter
            Dim MyFile As FileStream = File.Open("CoinsPictures.txt", FileMode.Open)
            Lst = Bf.Deserialize(MyFile)
            MyFile.Close()
        Catch
        End Try

        If Lst IsNot Nothing Then
            Coins.PicsInfo = Lst
            DataGridView1.DataSource = Lst
        End If
    End Sub
End Class
