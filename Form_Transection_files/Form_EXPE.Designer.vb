﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_EXPE
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
        Me.txtOrderDID = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblNet = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboCatE = New System.Windows.Forms.ComboBox()
        Me.txtDetail = New System.Windows.Forms.TextBox()
        Me.lsvProductList = New System.Windows.Forms.ListView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtOrderDID
        '
        Me.txtOrderDID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtOrderDID.Location = New System.Drawing.Point(518, 23)
        Me.txtOrderDID.Name = "txtOrderDID"
        Me.txtOrderDID.ReadOnly = True
        Me.txtOrderDID.Size = New System.Drawing.Size(127, 29)
        Me.txtOrderDID.TabIndex = 32
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(372, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(140, 24)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "เลขที่ใบค่าใช้จ่าย :"
        '
        'lblNet
        '
        Me.lblNet.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNet.BackColor = System.Drawing.Color.Black
        Me.lblNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNet.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblNet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNet.Location = New System.Drawing.Point(423, 147)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(205, 53)
        Me.lblNet.TabIndex = 34
        Me.lblNet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(296, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 24)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "รวมเป็นเงิน :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.Controls.Add(Me.cboCatE)
        Me.GroupBox2.Controls.Add(Me.txtDetail)
        Me.GroupBox2.Controls.Add(Me.lsvProductList)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtPrice)
        Me.GroupBox2.Location = New System.Drawing.Point(82, 203)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(735, 311)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "รายการค่าใช้จ่าย"
        '
        'cboCatE
        '
        Me.cboCatE.FormattingEnabled = True
        Me.cboCatE.Location = New System.Drawing.Point(67, 71)
        Me.cboCatE.Name = "cboCatE"
        Me.cboCatE.Size = New System.Drawing.Size(174, 32)
        Me.cboCatE.TabIndex = 39
        '
        'txtDetail
        '
        Me.txtDetail.Location = New System.Drawing.Point(280, 71)
        Me.txtDetail.Name = "txtDetail"
        Me.txtDetail.Size = New System.Drawing.Size(280, 29)
        Me.txtDetail.TabIndex = 11
        '
        'lsvProductList
        '
        Me.lsvProductList.Location = New System.Drawing.Point(6, 109)
        Me.lsvProductList.Name = "lsvProductList"
        Me.lsvProductList.Size = New System.Drawing.Size(686, 170)
        Me.lsvProductList.TabIndex = 10
        Me.lsvProductList.TabStop = False
        Me.lsvProductList.UseCompatibleStateImageBehavior = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(577, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 24)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "จำนวนเงิน :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(276, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 24)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "ชื่อรายการค่าใช้จ่าย :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(93, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 24)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ประเภทค่าใช้จ่าย"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(581, 71)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(85, 29)
        Me.txtPrice.TabIndex = 0
        '
        'cmdClear
        '
        Me.cmdClear.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmdClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdClear.Location = New System.Drawing.Point(858, 297)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(97, 34)
        Me.cmdClear.TabIndex = 37
        Me.cmdClear.Text = "ล้าง"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmdAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAdd.Location = New System.Drawing.Point(858, 239)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(97, 34)
        Me.cmdAdd.TabIndex = 36
        Me.cmdAdd.Text = "เพิ่มรายการ"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSave.Location = New System.Drawing.Point(858, 378)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(97, 32)
        Me.cmdSave.TabIndex = 38
        Me.cmdSave.Text = "บันทึก"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.Image = Global.ProjectRK.My.Resources.Resources._028_home1
        Me.Button1.Location = New System.Drawing.Point(82, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 79)
        Me.Button1.TabIndex = 141
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form_EXPE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.lblNet)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtOrderDID)
        Me.Controls.Add(Me.Label10)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form_EXPE"
        Me.Text = "Form_EXPE"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOrderDID As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblNet As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lsvProductList As ListView
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdAdd As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents cboCatE As ComboBox
    Friend WithEvents txtDetail As TextBox
    Friend WithEvents Button1 As Button
End Class
