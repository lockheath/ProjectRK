﻿Imports System.Data
Imports System.Data.SqlClient

Public Class Form_CategoryD
    Private Sub Form_CategoryD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        BindingData()
    End Sub
    'แปะข้อมูล
    Private Sub BindingData(Optional cmd As SqlCommand = Nothing)
        For Each tbx As TextBox In Me.Controls.OfType(Of TextBox)
            tbx.DataBindings.Clear()
            tbx.Text = ""
        Next

        If cmd Is Nothing Then
            command.CommandText = "SELECT * FROM CategoriesD"
        Else
            command = cmd
        End If

        adapter = New SqlDataAdapter(command)
        dataSt = New DataSet()
        adapter.Fill(dataSt, "CategoriesD")

        bindingSrc = New BindingSource(dataSt, "CategoriesD")

        TextID.DataBindings.Add("Text", bindingSrc, "CategoryDID")
        TextName.DataBindings.Add("Text", bindingSrc, "CategoryDName")
        TextDetail.DataBindings.Add("Text", bindingSrc, "Description")

        BindingNavigator1.BindingSource = bindingSrc
        CreateAutoComplete()
    End Sub


    Private Sub InsertData()
        sql = "INSERT INTO CategoriesD(CategoryDName, Description) 
               VALUES(@n, @d)"

        command.CommandText = sql
        command.Parameters.Clear()
        command.Parameters.AddWithValue("n", TextName.Text)
        command.Parameters.AddWithValue("d", TextDetail.Text)

        Dim r As Integer = command.ExecuteNonQuery()
        If r = -1 Then
            MessageBox.Show("เกิดข้อผิดพลาด ไม่สามารถเพิ่มข้อมูลได้")
        Else
            MessageBox.Show("บันทึกข้อมูลแล้ว")
            BindingData()
        End If
    End Sub

    Private Sub UpdateData()
        sql = "UPDATE CategoriesD SET CategoryDName = @n, Description = @d 
               WHERE CategoryDID = @i"

        command.CommandText = sql
        command.Parameters.Clear()
        command.Parameters.AddWithValue("n", TextName.Text)
        command.Parameters.AddWithValue("d", TextDetail.Text)
        command.Parameters.AddWithValue("i", TextID.Text)

        Dim r As Integer = command.ExecuteNonQuery()
        If r = -1 Then
            MessageBox.Show("เกิดข้อผิดพลาด ไม่สามารถแก้ไขข้อมูลได้")
        Else
            MessageBox.Show("ข้อมูลได้รับการแก้ไขแล้ว")
            BindingData()
        End If
    End Sub

    Private Sub CreateAutoComplete()
        sql = "SELECT CategoryDName FROM CategoriesD"
        command.CommandText = sql
        reader = command.ExecuteReader()
        Dim autoComp As New AutoCompleteStringCollection()
        While reader.Read()
            autoComp.Add(reader("CategoryDName"))
        End While
        reader.Close()
        TextSearch.AutoCompleteMode = AutoCompleteMode.Suggest
        TextSearch.AutoCompleteSource = AutoCompleteSource.CustomSource
        TextSearch.AutoCompleteCustomSource = autoComp
    End Sub
    'ปุ่มค้นหา
    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        If String.IsNullOrEmpty(TextSearch.Text) Then
            BindingData()
            Exit Sub
        End If

        sql = "SELECT * FROM CategoriesD WHERE CategoryDName LIKE '%' + @n + '%'"
        command.CommandText = sql
        command.Parameters.Clear()
        command.Parameters.AddWithValue("n", TextSearch.Text)
        BindingData(command)
    End Sub

    'ปุ่มบันทึก
    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        If TextID.Text = "" Then
            InsertData()
        Else
            UpdateData()
        End If
    End Sub

    'ปุ่มกลับบ้าน
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        MF.Show()
    End Sub
    'ปุ่มลบ
    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        Dim result As DialogResult =
        MessageBox.Show("ท่านต้องการลบข้อมูลนี้จริงหรือไม่", "ยืนยันการลบ",
                         MessageBoxButtons.OKCancel)

        If result = DialogResult.OK Then
            sql = "DELETE FROM CategoriesD WHERE CategoryDID = @id"
            command.CommandText = sql
            command.Parameters.Clear()
            command.Parameters.AddWithValue("id", TextID.Text)

            Dim r As Integer = command.ExecuteNonQuery()
            If r = -1 Then
                MessageBox.Show("เกิดข้อผิดพลาด ไม่สามารถลบข้อมูลได้")
            Else
                MessageBox.Show("ข้อมูลถูกลบแล้ว")
                BindingData()
            End If
        Else
            BindingData()
        End If

    End Sub
End Class