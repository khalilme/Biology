Public Class Coins

    Friend Shared MaxPicNo As Integer = GetSetting("Pictures100", "Settings", "MaxPicNo", 0)
    Friend Shared PicNo As Integer = GetSetting("Pictures100", "Settings", "PicNo", 0)
    Friend Shared Trials As Decimal = GetSetting("Pictures100", "Settings", "Trials", 0)
    Friend Shared TotalTime As TimeSpan = TimeSpan.FromSeconds(GetSetting("Pictures100", "Settings", "TotalTime", 0))
    Friend Shared StopLoop As Boolean
    Friend Shared ElapsedTime As TimeSpan = TotalTime
    Friend Shared PicsInfo As New List(Of PictureInfo)

    Shared Sub ThrowCoins()

        Dim StartTime = Now

        Dim R As New Random
        Do
            Trials += 1
            Dim I = R.Next()
            If I Mod 2 = 0 Then ' صورة
                PicNo += 1
                If PicNo > MaxPicNo Then
                    MaxPicNo = PicNo
                    Dim Prev = PicsInfo.Count - 1
                    Dim Trials2 As Decimal
                    If Prev > -1 Then
                        ' قد تحدث قفزة في النتائج.. مثلا: إذا كانت آخر نتيجة 15 صورة متتالية
                        ' ثم حدثت النتيجة 20 صورة متتالية.. 
                        ' ستؤدي هذه النتيجة إلى تسجيل النتائج 16، 17، 18، 19 و20 على التوالي
                        ' وهذا غير دقيق.. لهذا سنحذف النتائج البينية، 
                        ' بحذف النتيجة السابقة إن كانت قد حدثت في الرمية السابقة مباشرة
                        If PicsInfo(Prev).TrialsNo = Trials - 1 Then
                            PicsInfo.RemoveAt(Prev)
                            Prev -= 1
                            If Prev = -1 Then GoTo LineElse
                        End If
                        Trials2 = Trials - PicsInfo(Prev).TrialsNo
                    Else
LineElse:
                        Trials2 = Trials
                    End If
                    PicsInfo.Add(New PictureInfo(PicNo, Trials, Trials2))
                End If

            Else ' كتابة
                ' تصفير المتغير لنبدأ عد الصور من البداية
                PicNo = 0
            End If

            If Trials Mod 1000000 = 0 Then
                ElapsedTime = TotalTime + Now.Subtract(StartTime)               
            End If

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
    Public Property TrialsNo2 As Decimal
    Public Property ExpectedTrialsNo As Decimal

    Sub New(PictureNo As Integer, TrialsNo As Decimal, TrialsNo2 As Decimal)
        Me.PictureNo = PictureNo
        Me.TrialsNo = TrialsNo
        Me.TrialsNo2 = TrialsNo2
    End Sub
End Class