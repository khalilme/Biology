<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.BtnStop = New System.Windows.Forms.Button()
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTrials = New System.Windows.Forms.Label()
        Me.lblPictures = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PictureNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrialsNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrialsNo2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpectedTrialsNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblSpeed = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnStart
        '
        Me.BtnStart.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnStart.Location = New System.Drawing.Point(558, 193)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(122, 44)
        Me.BtnStart.TabIndex = 1
        Me.BtnStart.Text = "تشغيل"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'BtnStop
        '
        Me.BtnStop.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnStop.Location = New System.Drawing.Point(392, 193)
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Size = New System.Drawing.Size(122, 44)
        Me.BtnStop.TabIndex = 2
        Me.BtnStop.Text = "إيقاف"
        Me.BtnStop.UseVisualStyleBackColor = True
        '
        'Lbl1
        '
        Me.Lbl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl1.AutoSize = True
        Me.Lbl1.ForeColor = System.Drawing.Color.Blue
        Me.Lbl1.Location = New System.Drawing.Point(664, 18)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(273, 34)
        Me.Lbl1.TabIndex = 3
        Me.Lbl1.Text = "عدد مرات إلقاء العملة:"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(400, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(578, 34)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "أكبر عدد من الصور المتتالية تم تحقيقه حتى الآن:"
        '
        'lblTrials
        '
        Me.lblTrials.Location = New System.Drawing.Point(12, 18)
        Me.lblTrials.Name = "lblTrials"
        Me.lblTrials.Size = New System.Drawing.Size(387, 29)
        Me.lblTrials.TabIndex = 3
        Me.lblTrials.Text = "0"
        Me.lblTrials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPictures
        '
        Me.lblPictures.Location = New System.Drawing.Point(12, 63)
        Me.lblPictures.Name = "lblPictures"
        Me.lblPictures.Size = New System.Drawing.Size(382, 29)
        Me.lblPictures.TabIndex = 3
        Me.lblPictures.Text = "0"
        Me.lblPictures.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(722, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 34)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "الوقت المنقضي:"
        '
        'lblTime
        '
        Me.lblTime.Location = New System.Drawing.Point(12, 107)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(438, 29)
        Me.lblTime.TabIndex = 3
        Me.lblTime.Text = "0 يوم و 0 ساعة و 0 دقيقة و 0 ثانية"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnReset
        '
        Me.BtnReset.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnReset.Location = New System.Drawing.Point(228, 193)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(122, 44)
        Me.BtnReset.TabIndex = 2
        Me.BtnReset.Text = "تصفير"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 14.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PictureNoDataGridViewTextBoxColumn, Me.TrialsNoDataGridViewTextBoxColumn, Me.TrialsNo2, Me.ExpectedTrialsNo})
        Me.DataGridView1.DataSource = Me.PictureInfoBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 14.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Location = New System.Drawing.Point(12, 257)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 50
        Me.DataGridView1.Size = New System.Drawing.Size(880, 356)
        Me.DataGridView1.TabIndex = 5
        '
        'PictureNoDataGridViewTextBoxColumn
        '
        Me.PictureNoDataGridViewTextBoxColumn.DataPropertyName = "PictureNo"
        Me.PictureNoDataGridViewTextBoxColumn.HeaderText = "الصور المتتالية"
        Me.PictureNoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PictureNoDataGridViewTextBoxColumn.Name = "PictureNoDataGridViewTextBoxColumn"
        Me.PictureNoDataGridViewTextBoxColumn.Width = 150
        '
        'TrialsNoDataGridViewTextBoxColumn
        '
        Me.TrialsNoDataGridViewTextBoxColumn.DataPropertyName = "TrialsNo"
        DataGridViewCellStyle2.Format = "N0"
        Me.TrialsNoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.TrialsNoDataGridViewTextBoxColumn.HeaderText = "عدد المحاولات الكلي"
        Me.TrialsNoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TrialsNoDataGridViewTextBoxColumn.Name = "TrialsNoDataGridViewTextBoxColumn"
        Me.TrialsNoDataGridViewTextBoxColumn.Width = 220
        '
        'TrialsNo2
        '
        Me.TrialsNo2.DataPropertyName = "TrialsNo2"
        DataGridViewCellStyle3.Format = "N0"
        Me.TrialsNo2.DefaultCellStyle = DataGridViewCellStyle3
        Me.TrialsNo2.HeaderText = "عدد المحاولات بعد آخر نتيجة"
        Me.TrialsNo2.MinimumWidth = 8
        Me.TrialsNo2.Name = "TrialsNo2"
        Me.TrialsNo2.Width = 220
        '
        'ExpectedTrialsNo
        '
        Me.ExpectedTrialsNo.DataPropertyName = "ExpectedTrialsNo"
        DataGridViewCellStyle4.Format = "N0"
        Me.ExpectedTrialsNo.DefaultCellStyle = DataGridViewCellStyle4
        Me.ExpectedTrialsNo.HeaderText = "عدد المحاولات المتوقع"
        Me.ExpectedTrialsNo.MinimumWidth = 8
        Me.ExpectedTrialsNo.Name = "ExpectedTrialsNo"
        Me.ExpectedTrialsNo.Width = 220
        '
        'PictureInfoBindingSource
        '
        Me.PictureInfoBindingSource.DataSource = GetType(Coin100Pictures.PictureInfo)
        '
        'lblSpeed
        '
        Me.lblSpeed.Location = New System.Drawing.Point(12, 151)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.Size = New System.Drawing.Size(377, 29)
        Me.lblSpeed.TabIndex = 3
        Me.lblSpeed.Text = "0"
        Me.lblSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(808, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 34)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "السرعة"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 34.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 628)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblSpeed)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTrials)
        Me.Controls.Add(Me.Lbl1)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnStop)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.lblPictures)
        Me.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "حاسبة الاحتمالات"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnStart As System.Windows.Forms.Button
    Friend WithEvents BtnStop As System.Windows.Forms.Button
    Friend WithEvents Lbl1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTrials As System.Windows.Forms.Label
    Friend WithEvents lblPictures As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents BtnReset As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PictureInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents lblSpeed As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrialsNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrialsNo2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExpectedTrialsNo As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
