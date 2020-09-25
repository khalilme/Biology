Public Class Coins

    Friend Shared MaxPicNo As Integer = GetSetting("Pictures100", "Settings", "MaxPicNo", 0)
    Friend Shared PicNo As Integer = GetSetting("Pictures100", "Settings", "PicNo", 0)
    Friend Shared Trials As Decimal = GetSetting("Pictures100", "Settings", "Trials", 0)
    Friend Shared TotalTime As TimeSpan = TimeSpan.FromSeconds(GetSetting("Pictures100", "Settings", "TotalTime", 0))
    Friend Shared StopLoop As Boolean
    Friend Shared ElapsedTime As TimeSpan = TotalTime
    Friend Shared PicsInfo As New Dictionary(Of Integer, PictureInfo)

    Shared Sub ThrowCoins()

        Dim StartTime = Now

        Dim R As New Random
        Do
            Trials += 1
            Dim I = R.Next()
            If I Mod 2 = 0 Then ' صورة
                PicNo += 1                
            Else ' كتابة
                ' سنحفظ عدد الصور السابقة
                If PicsInfo.ContainsKey(PicNo) Then
                    PicsInfo(PicNo).Times += 1
                ElseIf PicNo > 0 Then
                    PicsInfo.Add(PicNo, New PictureInfo(PicNo, Trials))
                    If PicNo > MaxPicNo Then MaxPicNo = PicNo
                End If

                ' تصفير المتغير لنبدأ عد الصور من البداية
                PicNo = 0
            End If

            ElapsedTime = TotalTime + Now.Subtract(StartTime)

            If StopLoop Then
                StopLoop = False
                TotalTime = ElapsedTime
                SaveSetting("Pictures100", "Settings", "MaxPicNo", MaxPicNo)
                SaveSetting("Pictures100", "Settings", "PicNo", PicNo)
                SaveSetting("Pictures100", "Settings", "Trials", Trials)
                SaveSetting("Pictures100", "Settings", "TotalTime", TotalTime.TotalSeconds)
                Exit Do
            End If
        Loop
    End Sub

    Shared Sub Reset(Started As Boolean)
        If Started Then
            StopLoop = True
            While StopLoop
                ' الانتظار حتى التأكد من إنهاء البرنامج الفرعي 
            End While
        End If
        MaxPicNo = 0
        PicNo = 0
        Trials = 0
        TotalTime = TimeSpan.FromSeconds(1)
        ElapsedTime = TotalTime
        PicsInfo.Clear()
        SaveSetting("Pictures100", "Settings", "MaxPicNo", MaxPicNo)
        SaveSetting("Pictures100", "Settings", "PicNo", PicNo)
        SaveSetting("Pictures100", "Settings", "Trials", Trials)
        SaveSetting("Pictures100", "Settings", "TotalTime", TotalTime.TotalSeconds)
    End Sub

    Shared Sub ComputePercentage()
        Dim Sum As Decimal = 0
        For Each Info In PicsInfo
            Sum += Info.Value.Times
        Next

        For Each Info In PicsInfo
            Dim P = 100 * Info.Value.Times / Sum
            Dim X = 0D
            For N = 3 To 15
                X = Math.Round(P, N)
                If X > 0 Then Exit For
            Next
            Info.Value.Percentage = "%" & X
        Next
    End Sub

End Class

<Serializable>
Class PictureInfo

    Dim _PictureNo As Integer
    Public Property PictureNo As Integer
        Get
            Return _PictureNo
        End Get
        Set(value As Integer)
            _PictureNo = value
            _ExpectedTrialsNo = 2 ^ _PictureNo
        End Set
    End Property

    Public Property TrialsNo As Decimal
    Public Property ExpectedTrialsNo As Decimal
    Public Property Times As Decimal
    Public Property Percentage As String

    Sub New(PictureNo As Integer, TrialsNo As Decimal)
        Me.PictureNo = PictureNo
        Me.TrialsNo = TrialsNo
        Me.Times = 1
    End Sub
End Class