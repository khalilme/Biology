'هذا المثال كتبه: محمد حمدي غانم.
'وهو أحد أمثلة كتاب: 
' من الصفر إلى الاحتراف، برمجة نماذج الويندوز في فيجيوال بيزيك دوت نت 2008
'الناشر: مكتبة دار المعرفة، 4 شارع السرايات ـ
' أمام هندسة عين شمس ـ بالقرب من ميدان عبده باشا ـ العباسية ـ القاهرة، 
' هاتف 26844043، 
' بريد إلكتروني: dar_elmaarefa@yahoo.com


Public Class Form1
    Const MazeWidth = 20, MazeHeight = 20
    Const CellWidth = 20, CellHeight = 19
    Dim L(MazeWidth, MazeHeight) As Label
    Dim Path As New Stack()

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Row = 0 To MazeWidth - 1
            For Col = 0 To MazeHeight - 1
                L(Row, Col) = New Label
                L(Row, Col).BackColor = Color.White
                L(Row, Col).Size = New Size(CellWidth, CellHeight)
                L(Row, Col).BorderStyle = BorderStyle.FixedSingle
                L(Row, Col).Margin = New Padding(0)
                PnlMaze.Controls.Add(L(Row, Col))
                AddHandler L(Row, Col).Click, AddressOf L_Click
                AddHandler L(Row, Col).MouseEnter, AddressOf L_MouseEnter
            Next
            PnlMaze.Size = New Size(CellWidth * MazeWidth, CellHeight * MazeHeight)
        Next
        L(0, 0).BackColor = Color.Yellow
        L(MazeWidth - 1, MazeHeight - 1).Text = "E"

        '.maz فتح الملف  الذي ضغطه المستخدم إذا كان امتداده
        Dim Files() As String = Environment.GetCommandLineArgs()
        'For Each V As DictionaryEntry In Environment.GetEnvironmentVariables()
        '    MsgBox(V.Key + ": " + V.Value)
        'Next

        If Files.Length > 2 Then
            If Files(1).EndsWith(".maz") Then LoadMazFile(Files(1))
            ChSetup.Checked = (Files(2) = "edit")
        End If
    End Sub

    Private Sub L_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not ChSetup.Checked Then Return
        Dim Cell = CType(sender, Label)
        If Cell Is L(0, 0) OrElse Cell Is L(MazeWidth - 1, MazeHeight - 1) Then
            Beep()
            Return
        End If

        If Cell.BackColor <> Color.Black Then
            Cell.BackColor = Color.Black
        Else
            Cell.BackColor = Color.White
        End If
    End Sub

    Private Sub L_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        If (Control.ModifierKeys And Keys.Control) > 0 Then
            L_Click(sender, e)
        End If

    End Sub


    Enum Direction
        [New] = 0
        Right = 1
        Down = 2
        Left = 3
        Top = 4
        Done = 5
    End Enum
    Structure State
        Dim Row As Integer
        Dim Col As Integer
        Dim Dir As Direction
    End Structure
    Sub ClearPath()
        Path.Clear()
        For Row = 0 To MazeWidth - 1
            For Col = 0 To MazeHeight - 1
                If L(Row, Col).BackColor = Color.Yellow Then L(Row, Col).BackColor = Color.White
                L(Row, Col).Tag = 0
            Next
        Next
        L(0, 0).BackColor = Color.Yellow
    End Sub
    Private Sub BtSolve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtSolve.Click
        ChSetup.Checked = False
        ClearPath()
        ' الإنسان الآلي في الخانة الأولى
        Dim Pos As New State With {.Row = 0, .Col = 0, .Dir = Direction.New}
        Path.Push(Pos) ' حفظ موضع الإنسان الآلي في الرصة
        L(0, 0).Tag = 1
        Dim Cell As Label
        Do
            Pos.Dir += 1
            Path.Pop() ' سنحذف الخانة الحالية من الرصة
            Path.Push(Pos) ' ونضيفها من جديد لحفظ هذا التعديل في الرصة
            Select Case Pos.Dir
                Case Direction.Right
                    If Pos.Col = MazeHeight - 1 Then
                        ' لا يمكن التحرك خارج اللوحة
                        ' لهذا أهمل باقي الكود في هذه اللفة
                        Continue Do
                    End If
                    Cell = L(Pos.Row, Pos.Col + 1)
                    If Cell.Tag = 0 AndAlso Cell.BackColor = Color.White Then
                        Pos.Col += 1 ' الانتقال إلى العمود التالي
                        Pos.Dir = Direction.New
                        Cell.BackColor = Color.Yellow
                        Cell.Tag = 1 ' لقد مررت بهذه الخانة من قبل
                        Path.Push(Pos)
                        Me.Refresh()
                    End If
                Case Direction.Down
                    If Pos.Row = MazeWidth - 1 Then Continue Do
                    Cell = L(Pos.Row + 1, Pos.Col)
                    If Cell.Tag = 0 AndAlso Cell.BackColor = Color.White Then
                        Pos.Row += 1 ' الانتقال إلى الصف التالي
                        Pos.Dir = Direction.New
                        Cell.BackColor = Color.Yellow
                        Cell.Tag = 1
                        Path.Push(Pos)
                        Me.Refresh()
                    End If
                Case Direction.Left
                    If Pos.Col = 0 Then Continue Do
                    Cell = L(Pos.Row, Pos.Col - 1)
                    If Cell.Tag = 0 AndAlso Cell.BackColor = Color.White Then
                        Pos.Col -= 1 ' الانتقال إلى العمود السابق
                        Pos.Dir = Direction.New
                        Cell.BackColor = Color.Yellow
                        Cell.Tag = 1
                        Path.Push(Pos)
                        Me.Refresh()
                    End If
                Case Direction.Top
                    If Pos.Row = 0 Then Continue Do
                    Cell = L(Pos.Row - 1, Pos.Col)
                    If Cell.Tag = 0 AndAlso Cell.BackColor = Color.White Then
                        Pos.Row -= 1 ' الانتقال إلى الصف السابق
                        Pos.Dir = Direction.New
                        Cell.BackColor = Color.Yellow
                        Cell.Tag = 1
                        Path.Push(Pos)
                        Me.Refresh()
                    End If
                Case Direction.Done
                    ' تمت تجربة كل الاتجاهات ولم توصلنا إلى حل
                    If Pos.Row = 0 And Pos.Col = 0 Then
                        ' العودة إلى الخانة الأولى تعني أنه لا يوجد حل
                        MsgBox("لا يوجد حل للمتاهة")
                        Return
                    End If
                    ' قبل التراجع عن الخانة الحالية أعد لونها إلى الأبيض
                    L(Pos.Row, Pos.Col).BackColor = Color.White
                    Path.Pop() ' تخلص منن الخانة الحالية بإخراجها من قمة الرصة 
                    ' صارت الخانة السابقة على قمة الرصة.. اقرأها لتصير هعي الخانة الحالية
                    Pos = Path.Peek
                    Me.Refresh()
            End Select
            ' إذا كانت الخانة الحالية هي الخانة الأخيرة فقد أنهينا المتاهة
            If Pos.Row = MazeWidth - 1 AndAlso Pos.Col = MazeHeight - 1 Then
                MsgBox("تم حل المتاهة")
                Return
            End If
        Loop

    End Sub

    Private Sub BtOptimizePath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtOptimizePath.Click
        If Path.Count = 0 Then Return
        Dim OptPath As New ArrayList(Path)
        Dim I = 0
        Do While I < OptPath.Count - 2 ' لا لزوم لفحص آخر خانتين في المسار
            Dim J = I + 2
            Do While J < OptPath.Count
                Select Case OptPath(I).Col
                    Case OptPath(J).Col
                        Select Case OptPath(I).Row
                            Case OptPath(J).Row, OptPath(J).Row - 1, OptPath(J).Row + 1
                                ' حذف المسار البيني
                                For K = J - 1 To I + 1 Step -1
                                    OptPath.RemoveAt(K)
                                Next
                        End Select
                    Case OptPath(J).Col + 1, OptPath(J).Col - 1
                        If OptPath(J).Row = OptPath(I).Row Then
                            ' حذف المسار البيني
                            For K = J - 1 To I + 1 Step -1
                                OptPath.RemoveAt(K)
                            Next
                        End If
                End Select
                J += 1
            Loop
            I += 1
        Loop
        ClearPath()
        OptPath.Reverse()
        For Each CellState In OptPath
            L(CellState.Row, CellState.Col).BackColor = Color.Yellow
            Me.Refresh()
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ChSetup.Checked = False
        Path.Clear()
        For Row = 0 To MazeWidth - 1
            For Col = 0 To MazeHeight - 1
                L(Row, Col).BackColor = Color.White
                L(Row, Col).Tag = 0
            Next
        Next
        L(0, 0).BackColor = Color.Yellow
    End Sub

    Private Sub BtSaveMaze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtSaveMaze.Click
        SvFD.Filter = "Maze Files|*.maz|Bitmap Files|*.bmp"
        If SvFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim FileName = SvFD.FileName.ToLower
            If FileName.EndsWith(".maz") Then
                SaveMazFile(FileName)
            ElseIf FileName.EndsWith(".bmp") Then
                SaveBmpFile(FileName)
            End If
        End If
    End Sub

    Sub SaveMazFile(ByVal FileName As String)
        Dim FS As IO.FileStream
        Try
            FS = New IO.FileStream(FileName, IO.FileMode.Create)
            For Row = 0 To MazeWidth - 1
                For Col = 0 To MazeHeight - 1
                    If L(Row, Col).BackColor = Color.Black Then
                        FS.WriteByte(1)
                    Else
                        FS.WriteByte(0)
                    End If
                Next
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If FS IsNot Nothing Then FS.Close()
        End Try
    End Sub

    Sub SaveBmpFile(ByVal FileName As String)
        Dim Bmp As New Bitmap(20, 20)
        For Row = 0 To MazeWidth - 1
            For Col = 0 To MazeHeight - 1
                Bmp.SetPixel(Col, Row, L(Row, Col).BackColor)
            Next
        Next
        Bmp.Save(FileName)
    End Sub

    Private Sub BtOpenMaze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtOpenMaze.Click
        OpFD.Filter = "Maze Files|*.maz|Bitmap Files|*.bmp"
        If OpFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim FileName = OpFD.FileName.ToLower
            If FileName.EndsWith(".maz") Then
                LoadMazFile(FileName)
            ElseIf FileName.EndsWith(".bmp") Then
                LoadBmpFile(FileName)
            End If
            L(0, 0).BackColor = Color.Yellow
        End If
    End Sub

    Sub LoadMazFile(ByVal FileName As String)
        Dim FS As IO.FileStream
        Try
            FS = New IO.FileStream(FileName, IO.FileMode.Open)
            For Row = 0 To MazeWidth - 1
                For Col = 0 To MazeHeight - 1
                    If FS.ReadByte > 0 Then
                        L(Row, Col).BackColor = Color.Black
                    Else
                        L(Row, Col).BackColor = Color.White
                    End If
                Next
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If FS IsNot Nothing Then FS.Close()
        End Try
    End Sub

    Sub LoadBmpFile(ByVal FileName As String)
        Try
            Dim Bmp As New Bitmap(FileName)
            Dim White = Color.White.ToArgb
            Dim Black = Color.Black.ToArgb

            For Row = 0 To MazeWidth - 1
                For Col = 0 To MazeHeight - 1
                    Dim Clr = Bmp.GetPixel(Col, Row).ToArgb
                    If Clr = Black Then
                        L(Row, Col).BackColor = Color.Black
                    ElseIf Clr = White Then
                        L(Row, Col).BackColor = Color.White
                    End If
                Next
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtRandom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtRandom.Click
        Dim R As New Random
        For Row = 0 To MazeWidth - 1
            For Col = 0 To MazeHeight - 1
                If (Row = 0 AndAlso Col = 0) OrElse (Row = MazeWidth - 1 AndAlso Col = MazeHeight - 1) Then Continue For

                If R.Next(0, 10) < 7 Then
                    L(Row, Col).BackColor = Color.White
                Else
                    L(Row, Col).BackColor = Color.Black
                End If
            Next
        Next
    End Sub
End Class
