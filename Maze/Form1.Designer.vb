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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PnlMaze = New System.Windows.Forms.FlowLayoutPanel()
        Me.ChSetup = New System.Windows.Forms.CheckBox()
        Me.BtSolve = New System.Windows.Forms.Button()
        Me.BtOptimizePath = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtSaveMaze = New System.Windows.Forms.Button()
        Me.BtOpenMaze = New System.Windows.Forms.Button()
        Me.OpFD = New System.Windows.Forms.OpenFileDialog()
        Me.SvFD = New System.Windows.Forms.SaveFileDialog()
        Me.BtRandom = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PnlMaze
        '
        Me.PnlMaze.Location = New System.Drawing.Point(16, 15)
        Me.PnlMaze.Margin = New System.Windows.Forms.Padding(4)
        Me.PnlMaze.Name = "PnlMaze"
        Me.PnlMaze.Size = New System.Drawing.Size(400, 400)
        Me.PnlMaze.TabIndex = 0
        '
        'ChSetup
        '
        Me.ChSetup.Appearance = System.Windows.Forms.Appearance.Button
        Me.ChSetup.Location = New System.Drawing.Point(426, 22)
        Me.ChSetup.Margin = New System.Windows.Forms.Padding(4)
        Me.ChSetup.Name = "ChSetup"
        Me.ChSetup.Size = New System.Drawing.Size(110, 40)
        Me.ChSetup.TabIndex = 0
        Me.ChSetup.Text = "رسم المتاهة"
        Me.ChSetup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChSetup.UseVisualStyleBackColor = True
        '
        'BtSolve
        '
        Me.BtSolve.Location = New System.Drawing.Point(426, 288)
        Me.BtSolve.Name = "BtSolve"
        Me.BtSolve.Size = New System.Drawing.Size(110, 40)
        Me.BtSolve.TabIndex = 1
        Me.BtSolve.Text = "حل المتاهة"
        Me.BtSolve.UseVisualStyleBackColor = True
        '
        'BtOptimizePath
        '
        Me.BtOptimizePath.Location = New System.Drawing.Point(426, 334)
        Me.BtOptimizePath.Name = "BtOptimizePath"
        Me.BtOptimizePath.Size = New System.Drawing.Size(110, 40)
        Me.BtOptimizePath.TabIndex = 1
        Me.BtOptimizePath.Text = "تحسين المسار"
        Me.BtOptimizePath.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(426, 118)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 40)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "حذف المتاهة"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtSaveMaze
        '
        Me.BtSaveMaze.Location = New System.Drawing.Point(426, 181)
        Me.BtSaveMaze.Name = "BtSaveMaze"
        Me.BtSaveMaze.Size = New System.Drawing.Size(110, 40)
        Me.BtSaveMaze.TabIndex = 1
        Me.BtSaveMaze.Text = "حفظ المتاهة"
        Me.BtSaveMaze.UseVisualStyleBackColor = True
        '
        'BtOpenMaze
        '
        Me.BtOpenMaze.Location = New System.Drawing.Point(426, 227)
        Me.BtOpenMaze.Name = "BtOpenMaze"
        Me.BtOpenMaze.Size = New System.Drawing.Size(110, 40)
        Me.BtOpenMaze.TabIndex = 1
        Me.BtOpenMaze.Text = "تحميل متاهة"
        Me.BtOpenMaze.UseVisualStyleBackColor = True
        '
        'OpFD
        '
        Me.OpFD.FileName = "OpenFileDialog1"
        '
        'BtRandom
        '
        Me.BtRandom.Location = New System.Drawing.Point(426, 69)
        Me.BtRandom.Name = "BtRandom"
        Me.BtRandom.Size = New System.Drawing.Size(110, 40)
        Me.BtRandom.TabIndex = 1
        Me.BtRandom.Text = "متاهة عشوائية"
        Me.BtRandom.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 422)
        Me.Controls.Add(Me.BtOptimizePath)
        Me.Controls.Add(Me.BtSaveMaze)
        Me.Controls.Add(Me.BtOpenMaze)
        Me.Controls.Add(Me.BtRandom)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtSolve)
        Me.Controls.Add(Me.ChSetup)
        Me.Controls.Add(Me.PnlMaze)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "المتاهة"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlMaze As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ChSetup As System.Windows.Forms.CheckBox
    Friend WithEvents BtSolve As System.Windows.Forms.Button
    Friend WithEvents BtOptimizePath As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtSaveMaze As System.Windows.Forms.Button
    Friend WithEvents BtOpenMaze As System.Windows.Forms.Button
    Friend WithEvents OpFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SvFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents BtRandom As System.Windows.Forms.Button

End Class
