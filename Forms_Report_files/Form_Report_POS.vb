﻿Imports CrystalDecisions.CrystalReports.Engine
'เพิ่มการใช้งาน CrystalReport
Imports System.Data.SqlClient 'บอกว่าใช้งาน SQL server
Public Class Form_Report_POS

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click

        Dim rpt As New ReportDocument
        Dim directory As String = My.Application.Info.DirectoryPath
        rpt.Load("C:\MYPROJECT\ProjectRK\Forms_Report_files\CR_POS.rpt") 'ที่อยู่ของไฟล์ Report
        rpt.SetParameterValue("ORDERID", Me.txtSearch.Text) 'ให้เอาค่าจาก txtSearch มา 
        'ORDERID ให้ไปใส่ใน Parametter ORDERID ที่เราสร้างไว้ใน Cystalreport
        Me.CrystalReportViewer1.ReportSource = rpt
        Me.CrystalReportViewer1.Refresh()

    End Sub
End Class