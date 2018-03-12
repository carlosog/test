Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Data.SqlClient   'Para usar SQL
Imports Twilio
Imports Twilio.Rest.Api.V2010.Account
Imports Twilio.Types
Imports System.IO
Imports System.Net
Imports System.Configuration



Public Class Form1

  Private FechaActual As String




  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FechaActual = FechaHoy()
        'RefreshList()

        If RefreshList() Then

        End If

        timer1.Enabled = True
        timer2.Enabled = True


    End Sub

    Private Function RefreshList() As Boolean
        Try


            DgvTasks.Rows.Clear()
            DgvTasks.Refresh()
            Dim Dt As DataTable = New DataTable()
            Dim objservice As BDZSentinel.Sentinel = New BDZSentinel.Sentinel()


            Dim Ds As DataSet = New DataSet()
            Ds = objservice.GetList(1302018, 1, Me.FechaActual)
            Dt = Ds.Tables("Table")
            DgvEvents.AutoGenerateColumns = False
            DgvEvents.DataSource = Dt
            Dim numberOfRecords As Integer = Dt.Rows.Count
            TabPage3.Text = "Events (" & numberOfRecords.ToString() & ")"




            Dim DtT As DataTable = New DataTable()
            Dim objserviceT As BDZSentinel.Sentinel = New BDZSentinel.Sentinel()
            Dim DsT As DataSet = New DataSet()
            DsT = objserviceT.GetList(1302018, 2, Me.FechaActual)
            DtT = DsT.Tables("Table")
            DgvTasks.AutoGenerateColumns = False

            Dim nl As String = System.Environment.NewLine

            For Each Dr As DataRow In DtT.Rows
                Dim Inicio As String = Convert.ToDateTime(Dr("ShStarting")).ToString("MM/dd-hh:mm tt") & nl + Convert.ToDateTime(Dr("ShEnd")).ToString("MM/dd-hh:mm tt")
                DgvTasks.Rows.Add(Dr("ShStarting"), Dr("ShEnd"), Inicio, Dr("ShEnd"), Dr("EventIDLabel") & nl + Dr("EventName"), Dr("EventName"), Dr("Service"), Dr("Notes"), Dr("Leads"), Dr("Crew"), Dr("StProgress"), Dr("TaskID"))
            Next

            numberOfRecords = DtT.Rows.Count
            tabPage2.Text = "Task (" & numberOfRecords.ToString() & ")"

            Dim TaskID As Integer = 0
            Dim StProgress As Integer = 0
            Dim StringFecha As String = ""
            Dim MyStartTime As DateTime
            Dim ahorita As DateTime
            Dim MyMessage As String = ""

            For Each row As DataGridViewRow In DgvTasks.Rows

                'Dim StProgress As Integer = row.Cells(10).Value
                'StProgress = row.Cells(10).Value
                'If StProgress = 10 Then
                '    row.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#b30000")
                '    row.DefaultCellStyle.ForeColor = Color.White
                'End If
                'StProgress = row.Cells(10).Value
                'If StProgress = 3 Then
                '    row.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffd700")
                '    row.DefaultCellStyle.ForeColor = Color.White
                'End If
                'StProgress = row.Cells(10).Value
                'If StProgress = 1 Then
                '    row.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#00cc00")
                '    row.DefaultCellStyle.ForeColor = Color.White
                'End If

                'StProgress = row.Cells(10).Value
                'If StProgress = 10 Then
                '    row.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#b30000")
                '    row.DefaultCellStyle.ForeColor = Color.White
                'ElseIf StProgress = 3 Then
                '    row.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffd700")
                '    row.DefaultCellStyle.ForeColor = Color.White
                'ElseIf StProgress = 1 Then
                '    row.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#00cc00")
                '    row.DefaultCellStyle.ForeColor = Color.White
                'End If



                '' comentar next
                'If DateFecha < ahorita Then
                '    row.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#b30000")
                '    row.DefaultCellStyle.ForeColor = Color.White
                'End If

                TaskID = row.Cells(11).Value
                StProgress = row.Cells(10).Value
                StringFecha = row.Cells(0).Value.ToString()
                MyStartTime = DateTime.Parse(StringFecha)
                ahorita = DateTime.Now



                Select Case StProgress
                    Case 10
                        If MyStartTime < ahorita Then
                            objservice.SetTP(1302018, TaskID, 9)
                        End If

                    Case 9
                        row.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#b30000")
                        row.DefaultCellStyle.ForeColor = Color.White
                        If MyStartTime.AddMinutes(10) < ahorita Then
                            objservice.SetTP(1302018, TaskID, 8)
                            MyMessage = "You are 10 min late for the task: " & row.Cells(6).Value.ToString() & " of " & row.Cells(4).Value.ToString()
                            Enviador("7256663595", MyMessage) 'Lead Only
                        End If



                    Case 8
                        row.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#b30000")
                        row.DefaultCellStyle.ForeColor = Color.White
                        If MyStartTime.AddMinutes(20) < ahorita Then
                            objservice.SetTP(1302018, TaskID, 7)
                            MyMessage = "Task 20 Min Late: " & row.Cells(6).Value.ToString() & " FOR " & row.Cells(4).Value.ToString()
                            Enviador("7027738813", MyMessage) 'Nancy
                            Enviador("7027738813", MyMessage) 'Adrian
                        End If

                    Case 7
                        row.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#b30000")
                        row.DefaultCellStyle.ForeColor = Color.White
                        If MyStartTime.AddMinutes(30) < ahorita Then
                            objservice.SetTP(1302018, TaskID, 6)
                            MyMessage = "Task 30 Min Late: " & row.Cells(6).Value.ToString() & " FOR " & row.Cells(4).Value.ToString()
                            Enviador("7025427417", MyMessage) 'Management(Kevin)
                        End If

                    Case 6
                        row.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#b30000")
                        row.DefaultCellStyle.ForeColor = Color.White

                    Case 5
                        row.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#b30000")
                        row.DefaultCellStyle.ForeColor = Color.White
                    Case 4
                        row.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#b30000")
                        row.DefaultCellStyle.ForeColor = Color.White

                    Case 3
                        row.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffd700")
                        row.DefaultCellStyle.ForeColor = Color.White
                    Case 1
                        row.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#00cc00")
                        row.DefaultCellStyle.ForeColor = Color.White
                    Case Else
                        row.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#ff00ff")
                        row.DefaultCellStyle.ForeColor = Color.White
                End Select




            Next


        Catch ex As Exception
            RefreshList = False
        End Try
    End Function





    Private Function FechaHoy() As String

    Dim Hoy2 As DateTime = DateTime.Now
    Dim Hoy3 As String = Hoy2.ToString("yyyyMMdd")
    Return Hoy3

  End Function

    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick

        'MessageBox.Show("hello3")
        Me.FechaActual = FechaHoy()
        If RefreshList() Then
        End If
    End Sub

    Private Sub timer2_Tick(sender As Object, e As EventArgs) Handles timer2.Tick
        Try



            'Label1.Text = DgvTasks.FirstDisplayedScrollingRowIndex

            'MessageBox.Show("hello2")
            Dim rVisible As Integer = DgvTasks.DisplayedRowCount(False)
            If DgvTasks.FirstDisplayedScrollingRowIndex + rVisible < DgvTasks.Rows.Count Then


                'If Label1.Text = DgvTasks.FirstDisplayedScrollingRowIndex Then
                DgvTasks.FirstDisplayedScrollingRowIndex += 1
                'End If

            Else

                'If Label1.Text = DgvTasks.FirstDisplayedScrollingRowIndex Then
                DgvTasks.FirstDisplayedScrollingRowIndex = 0
                'End If


            End If



            'MessageBox.Show(DgvTask.FirstDisplayedScrollingRowIndex)
        Catch ex As Exception
            'Dim x As Long
            'x = 0
        End Try
    End Sub

    Private Sub DgvTasks_Scroll(sender As Object, e As ScrollEventArgs) Handles DgvTasks.Scroll
        Try

            ''MessageBox.Show("pisando")

            'If Label1.Text + 1 = DgvTasks.FirstDisplayedScrollingRowIndex Then
            'Else
            '    'MessageBox.Show("distinto")
            'End If


        Catch ex As Exception
        End Try
    End Sub



    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click

        'Dim objservice As BDZSentinel.Sentinel = New BDZSentinel.Sentinel()
        'Dim Ds As DataSet = New DataSet()
        'Ds = objservice.GetList(1302018, 1, Me.FechaActual)
        'Enviador("gvgh")

    End Sub

    Private Sub BtSend_Click(sender As Object, e As EventArgs) Handles BtSend.Click

        If RefreshList() Then
        End If

    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click

        'Enviador("Mensaje 2")


        Enviador("7256663595", "ghjj")
        Enviador("7027738813", "Hi")


    End Sub

    Private Function Enviador(SendTo As String, Mensaje As String)
        Try


            'If SendTo <> "" And Mensaje <> "" Then

            '    SendTo = "+1" & SendTo
            '    Dim accountSid = "ACf47eeeb0a94270ce46402a428ab1347a"
            '    Dim authToken = "54b3c84836a3c6745620a0cf2c011878"
            '    TwilioClient.Init(accountSid, authToken)
            '    Dim message = MessageResource.Create([to]:=New PhoneNumber(SendTo), from:=New PhoneNumber("+17023816171"), body:=Mensaje)

            'End If
        Catch ex As Exception
        End Try
    End Function

    Private Sub DgvTasks_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DgvTasks.CellEnter
        'MessageBox.Show("soltando")
        ' timer2.Stop()
    End Sub
    Private Sub DgvTasks_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DgvTasks.CellLeave
    End Sub

    Private Sub DgvTasks_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DgvTasks.CellMouseEnter

    End Sub

    Private Sub DgvTasks_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DgvTasks.CellMouseLeave
        'MessageBox.Show("soltando")
    End Sub

    Private Sub DgvTasks_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvTasks.CellMouseClick

    End Sub

    Private Sub DgvTasks_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvTasks.CellMouseDown

    End Sub

    Private Sub DgvTasks_DragEnter(sender As Object, e As DragEventArgs) Handles DgvTasks.DragEnter

    End Sub



    'Private Sub DgvTasks_Scroll(sender As Object, e As ScrollEventArgs) Handles DgvTasks.Scroll

    '    'MessageBox.Show("hello")


    '    timer2.Stop()



    'End Sub

    Private Sub DgvTasks_MouseMove(sender As Object, e As MouseEventArgs) Handles DgvTasks.MouseMove
        'MessageBox.Show("hello")
    End Sub


End Class
