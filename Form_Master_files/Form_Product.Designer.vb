﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Product
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Product))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextSearch = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ComboCategory = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextDetail = New System.Windows.Forms.TextBox()
        Me.TextStock = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextPrice = New System.Windows.Forms.TextBox()
        Me.TextName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.ButtonOK)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.TextSearch)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1008, 109)
        Me.Panel1.TabIndex = 117
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.Image = Global.ProjectRK.My.Resources.Resources.Bhome
        Me.Button1.Location = New System.Drawing.Point(52, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 79)
        Me.Button1.TabIndex = 142
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Brown
        Me.Label12.Location = New System.Drawing.Point(186, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(214, 37)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "จัดการ วัตถุมงคล"
        '
        'ButtonOK
        '
        Me.ButtonOK.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonOK.Location = New System.Drawing.Point(896, 43)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(76, 36)
        Me.ButtonOK.TabIndex = 22
        Me.ButtonOK.Text = "ตกลง"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(551, 43)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 24)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "ค้นหา (ชื่อ)"
        '
        'TextSearch
        '
        Me.TextSearch.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextSearch.Location = New System.Drawing.Point(681, 43)
        Me.TextSearch.Name = "TextSearch"
        Me.TextSearch.Size = New System.Drawing.Size(209, 29)
        Me.TextSearch.TabIndex = 21
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(761, 377)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(89, 26)
        Me.LinkLabel1.TabIndex = 116
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "เลือกภาพ"
        '
        'ComboCategory
        '
        Me.ComboCategory.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ComboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboCategory.FormattingEnabled = True
        Me.ComboCategory.Location = New System.Drawing.Point(364, 148)
        Me.ComboCategory.Name = "ComboCategory"
        Me.ComboCategory.Size = New System.Drawing.Size(195, 34)
        Me.ComboCategory.TabIndex = 114
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(228, 148)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 26)
        Me.Label9.TabIndex = 113
        Me.Label9.Text = "หมวดหมู่"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(652, 151)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(198, 223)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 112
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(130, 394)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(185, 26)
        Me.Label7.TabIndex = 111
        Me.Label7.Text = "รายละเอียดวัตถุมงคล"
        '
        'TextDetail
        '
        Me.TextDetail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextDetail.Location = New System.Drawing.Point(364, 394)
        Me.TextDetail.Multiline = True
        Me.TextDetail.Name = "TextDetail"
        Me.TextDetail.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextDetail.Size = New System.Drawing.Size(265, 99)
        Me.TextDetail.TabIndex = 110
        '
        'TextStock
        '
        Me.TextStock.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextStock.Location = New System.Drawing.Point(364, 345)
        Me.TextStock.Name = "TextStock"
        Me.TextStock.Size = New System.Drawing.Size(195, 32)
        Me.TextStock.TabIndex = 109
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(242, 348)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 26)
        Me.Label6.TabIndex = 108
        Me.Label6.Text = "คงเหลือ"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(264, 298)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 26)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "ราคา"
        '
        'TextPrice
        '
        Me.TextPrice.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextPrice.Location = New System.Drawing.Point(364, 298)
        Me.TextPrice.Name = "TextPrice"
        Me.TextPrice.Size = New System.Drawing.Size(195, 32)
        Me.TextPrice.TabIndex = 106
        '
        'TextName
        '
        Me.TextName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextName.Location = New System.Drawing.Point(364, 249)
        Me.TextName.Name = "TextName"
        Me.TextName.Size = New System.Drawing.Size(195, 32)
        Me.TextName.TabIndex = 105
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(201, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 26)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "ชื่อวัตถุมงคล"
        '
        'TextID
        '
        Me.TextID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextID.Location = New System.Drawing.Point(364, 200)
        Me.TextID.Name = "TextID"
        Me.TextID.ReadOnly = True
        Me.TextID.Size = New System.Drawing.Size(195, 32)
        Me.TextID.TabIndex = 103
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(269, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 26)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "รหัส"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(364, 511)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(265, 32)
        Me.DateTimePicker1.TabIndex = 121
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(135, 511)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(180, 26)
        Me.Label4.TabIndex = 111
        Me.Label4.Text = "วันที่นำเข้าวัตถุมงคล"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.ToolStripButton1
        Me.BindingNavigator1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BindingNavigator1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BindingNavigator1.CountItem = Me.ToolStripLabel1
        Me.BindingNavigator1.CountItemFormat = "จาก    {0}"
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripButton8, Me.ToolStripButton7})
        Me.BindingNavigator1.Location = New System.Drawing.Point(275, 569)
        Me.BindingNavigator1.MoveFirstItem = Me.ToolStripButton3
        Me.BindingNavigator1.MoveLastItem = Me.ToolStripButton6
        Me.BindingNavigator1.MoveNextItem = Me.ToolStripButton5
        Me.BindingNavigator1.MovePreviousItem = Me.ToolStripButton4
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.ToolStripTextBox1
        Me.BindingNavigator1.Size = New System.Drawing.Size(491, 47)
        Me.BindingNavigator1.TabIndex = 139
        Me.BindingNavigator1.Text = "BindingNavigator2"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(44, 44)
        Me.ToolStripButton1.Text = "Add new"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(79, 44)
        Me.ToolStripLabel1.Text = "จาก    {0}"
        Me.ToolStripLabel1.ToolTipText = "Total number of items"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.ProjectRK.My.Resources.Resources.mfirst
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(44, 44)
        Me.ToolStripButton3.Text = "Move first"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = Global.ProjectRK.My.Resources.Resources.mprevious
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(44, 44)
        Me.ToolStripButton4.Text = "Move previous"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 47)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Position"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 40)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolStripTextBox1.ToolTipText = "Current position"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 47)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = Global.ProjectRK.My.Resources.Resources.mnext
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(44, 44)
        Me.ToolStripButton5.Text = "Move next"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = Global.ProjectRK.My.Resources.Resources.mlast
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(44, 44)
        Me.ToolStripButton6.Text = "Move last"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 47)
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = Global.ProjectRK.My.Resources.Resources.bin
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(44, 44)
        Me.ToolStripButton8.Text = "ToolStripButton8"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = Global.ProjectRK.My.Resources.Resources.save
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(44, 44)
        Me.ToolStripButton7.Text = "&Save"
        '
        'Form_Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.ComboCategory)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextDetail)
        Me.Controls.Add(Me.TextStock)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextPrice)
        Me.Controls.Add(Me.TextName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextID)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form_Product"
        Me.Text = "Form_Product"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents ButtonOK As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents TextSearch As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents ComboCategory As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextDetail As TextBox
    Friend WithEvents TextStock As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextPrice As TextBox
    Friend WithEvents TextName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents Button1 As Button
    Friend WithEvents ToolStripButton8 As ToolStripButton
End Class
