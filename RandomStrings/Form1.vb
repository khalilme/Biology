'هذا المثال كتبه: محمد حمدي غانم.
'وهو أحد أمثلة كتاب: 
' من الصفر إلى الاحتراف، برمجة إطار العمل في فيجيوال بيزيك دوت نت 2008
'الناشر: مكتبة دار المعرفة، 4 شارع السرايات ـ
' أمام هندسة عين شمس ـ بالقرب من ميدان عبده باشا ـ العباسية ـ القاهرة، 
' هاتف 26844043 
' بريد إلكتروني: dar_elmaarefa@yahoo.com

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim R As New Random()
        Dim B() As Byte
        TextBox1.Text = ""
        For I = 0 To 99
            B = New Byte(R.Next(2, 29)) {}
            R.NextBytes(B)
            TextBox1.AppendText(System.Text.Encoding.Default.GetString(B) & vbCrLf)
        Next
    End Sub
End Class
