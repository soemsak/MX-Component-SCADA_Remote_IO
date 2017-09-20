Option Explicit On
Option Strict On

Public Class Form1
#Region "Initial"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblOpen.Text = ""
        lblClose.Text = ""
        lblOn1.Text = ""
        lblOff1.Text = ""
        lblOn2.Text = ""
        lblOff2.Text = ""
        lblOn3.Text = ""
        lblOff3.Text = ""
        lblOn4.Text = ""
        lblOff4.Text = ""
        picDisplay1.BackColor = Color.Red
        picDisplay2.BackColor = Color.Red
        picDisplay3.BackColor = Color.Red
        picDisplay4.BackColor = Color.Red
        Me.Text = "ทดสอบโปรแกรม SCADA ต่อร่วมกับ PLC Mitsubishi และระบบ CC-Link"
    End Sub
#End Region

#Region "Port Connection"
    Private Sub cmdOpen_Click(sender As Object, e As EventArgs) Handles cmdOpen.Click

        Dim iRet As Long = 0
        Dim iLogicalStationNumber As Integer = 0
        AxActUtlType1.ActLogicalStationNumber = iLogicalStationNumber
        iRet = AxActUtlType1.Open()
        lblOpen.Text = iRet.ToString
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click

        Dim iRet As Long = 0
        iRet = AxActUtlType1.Close()
        lblClose.Text = iRet.ToString
    End Sub

#End Region

#Region "SCADA Control"
    Private Sub cmdOn1_Click(sender As Object, e As EventArgs) Handles cmdOn1.Click

        Dim iRet As Integer = 0
        iRet = AxActUtlType1.SetDevice("M10", 1)
        lblOn1.Text = iRet.ToString
        If iRet = 0 Then
            picDisplay1.BackColor = Color.Green
        Else
            picDisplay1.BackColor = Color.Red
        End If
    End Sub

    Private Sub cmdOff1_Click(sender As Object, e As EventArgs) Handles cmdOff1.Click

        Dim iRet As Integer = 0
        iRet = AxActUtlType1.SetDevice("M10", 0)
        lblOff1.Text = iRet.ToString
        picDisplay1.BackColor = Color.Red
    End Sub

    Private Sub cmdOn2_Click(sender As Object, e As EventArgs) Handles cmdOn2.Click

        Dim iRet As Integer = 0
        iRet = AxActUtlType1.SetDevice("M11", 1)
        lblOn2.Text = iRet.ToString
        If iRet = 0 Then
            picDisplay2.BackColor = Color.Green
        Else
            picDisplay2.BackColor = Color.Red
        End If
    End Sub

    Private Sub cmdOff2_Click(sender As Object, e As EventArgs) Handles cmdOff2.Click

        Dim iRet As Integer = 0
        iRet = AxActUtlType1.SetDevice("M11", 0)
        lblOff2.Text = iRet.ToString
        picDisplay2.BackColor = Color.Red
    End Sub

    Private Sub cmdOn3_Click(sender As Object, e As EventArgs) Handles cmdOn3.Click

        Dim iRet As Integer = 0
        iRet = AxActUtlType1.SetDevice("M12", 1)
        lblOn3.Text = iRet.ToString
        If iRet = 0 Then
            picDisplay3.BackColor = Color.Green
        Else
            picDisplay3.BackColor = Color.Red
        End If
    End Sub

    Private Sub cmdOff3_Click(sender As Object, e As EventArgs) Handles cmdOff3.Click

        Dim iRet As Integer = 0
        iRet = AxActUtlType1.SetDevice("M12", 0)
        lblOff3.Text = iRet.ToString
        picDisplay3.BackColor = Color.Red
    End Sub

    Private Sub cmdOn4_Click(sender As Object, e As EventArgs) Handles cmdOn4.Click

        Dim iRet As Integer = 0
        iRet = AxActUtlType1.SetDevice("M13", 1)
        lblOn4.Text = iRet.ToString
        If iRet = 0 Then
            picDisplay4.BackColor = Color.Green
        Else
            picDisplay4.BackColor = Color.Red
        End If
    End Sub

    Private Sub cmdOff4_Click(sender As Object, e As EventArgs) Handles cmdOff4.Click

        Dim iRet As Integer = 0
        iRet = AxActUtlType1.SetDevice("M13", 0)
        lblOff4.Text = iRet.ToString
        picDisplay4.BackColor = Color.Red
    End Sub
#End Region
End Class
