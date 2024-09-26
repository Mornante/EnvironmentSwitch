Imports System.Configuration.Assemblies
Imports System.IO

Public Class Form1
    Dim light As Integer = 0
    Public Class L
        Public Shared p9 As Integer = 73 - 500
        Public Shared p10 As Integer = 124 - 500
        Public Shared p11 As Integer = 143 - 500
        Public Shared p12 As Integer = 171 - 500
        Public Shared p13 As Integer = 233 - 500
        Public Shared p14 As Integer = 204 - 500
        Public Shared p15 As Integer = 291 - 500

        Public Shared p16 As Integer = 94 + 500
        Public Shared p17 As Integer = 68 + 500
        Public Shared p18 As Integer = 115 + 500
        Public Shared p19 As Integer = 165 + 500
        Public Shared p20 As Integer = 253 + 500
        Public Shared p21 As Integer = 225 + 500
        Public Shared p22 As Integer = 143 + 500
        Public Shared p23 As Integer = 204 + 500
        Public Shared p24 As Integer = 281 + 500

        Public Shared p1 As Integer = 93
        Public Shared p2 As Integer = 120
        Public Shared p3 As Integer = 266
        Public Shared p4 As Integer = 143
        Public Shared p5 As Integer = 169
        Public Shared p6 As Integer = 204
        Public Shared p7 As Integer = 235
        Public Shared p8 As Integer = 298
    End Class
    Public Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 466
        Me.Height = 739
        My.Computer.Audio.Stop()
        Call startingPoints()
    End Sub

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Public Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("Click the cloud to activate the Event" & vbNewLine & vbNewLine & "Created by Mornante' Basson")
    End Sub

    Public Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        My.Computer.Audio.Stop()
        If Timer1.Enabled = True Then
            Timer1.Stop()
        Else
            Timer1.Start()
        End If
        Try
            Dim AssemblyPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString()
            Dim exactPath = AssemblyPath + "\Media\Rain.wav"
            My.Computer.Audio.Play(exactPath, AudioPlayMode.BackgroundLoop)
        Catch ex As Exception
            MsgBox("Audio not located")
        End Try
        If PictureBox3.Visible = True Then
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            PictureBox8.Visible = False
        Else
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            PictureBox5.Visible = True
            PictureBox6.Visible = True
            PictureBox7.Visible = True
            PictureBox8.Visible = True
        End If
    End Sub

    Public Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Raining code starts'
        light = light + 100
        If light = 6000 Then
            Me.BackColor = Color.DarkGray
        ElseIf light = 6100 Then
            Me.BackColor = Color.Black
        ElseIf light = 6200 Then
            Me.BackColor = Color.DarkGray
        ElseIf light = 6300 Then
            Me.BackColor = Color.Black
        ElseIf light = 8000 Then
            light = 0
        End If

        PictureBox3.Location = New Point(PictureBox3.Location.X, PictureBox3.Location.Y + 25)
        PictureBox4.Location = New Point(PictureBox4.Location.X, PictureBox4.Location.Y + 45)
        PictureBox5.Location = New Point(PictureBox5.Location.X, PictureBox5.Location.Y + 29)
        PictureBox6.Location = New Point(PictureBox6.Location.X, PictureBox6.Location.Y + 19)
        PictureBox7.Location = New Point(PictureBox7.Location.X, PictureBox7.Location.Y + 32)
        PictureBox8.Location = New Point(PictureBox8.Location.X, PictureBox8.Location.Y + 40)

        If PictureBox3.Location.Y > 459 Then
            PictureBox3.Location = New Point(PictureBox3.Location.X, 221)
        End If
        If PictureBox4.Location.Y > 459 Then
            PictureBox4.Location = New Point(PictureBox4.Location.X, 221)
        End If
        If PictureBox5.Location.Y > 459 Then
            PictureBox5.Location = New Point(PictureBox5.Location.X, 221)
        End If
        If PictureBox6.Location.Y > 459 Then
            PictureBox6.Location = New Point(PictureBox6.Location.X, 221)
        End If
        If PictureBox7.Location.Y > 459 Then
            PictureBox7.Location = New Point(PictureBox7.Location.X, 221)
        End If
        If PictureBox8.Location.Y > 459 Then
            PictureBox8.Location = New Point(PictureBox8.Location.X, 221)
        End If
        'Raining code ends'
    End Sub

    Public Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        My.Computer.Audio.Stop()
        If Timer2.Enabled = True Then
            Timer2.Stop()
        Else
            Timer2.Start()
        End If
        Try
            Dim AssemblyPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString()
            Dim exactPath = AssemblyPath + "\Media\Snow.wav"
            My.Computer.Audio.Play(exactPath, AudioPlayMode.BackgroundLoop)
        Catch ex As Exception
            MsgBox("Audio not located")
        End Try
        If PictureBox11.Visible = True Then
            PictureBox11.Visible = False
            PictureBox12.Visible = False
            PictureBox13.Visible = False
            PictureBox14.Visible = False
            PictureBox15.Visible = False
        Else
            PictureBox11.Visible = True
            PictureBox12.Visible = True
            PictureBox13.Visible = True
            PictureBox14.Visible = True
            PictureBox15.Visible = True
        End If
    End Sub

    Public Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        PictureBox11.Location = New Point(PictureBox11.Location.X, PictureBox11.Location.Y + 19)
        PictureBox12.Location = New Point(PictureBox12.Location.X, PictureBox12.Location.Y + 5)
        PictureBox13.Location = New Point(PictureBox13.Location.X, PictureBox13.Location.Y + 17)
        PictureBox14.Location = New Point(PictureBox14.Location.X, PictureBox14.Location.Y + 9)
        PictureBox15.Location = New Point(PictureBox15.Location.X, PictureBox15.Location.Y + 13)

        If PictureBox11.Location.Y > 371 Then
            PictureBox11.Location = New Point(PictureBox11.Location.X, 197)
        End If
        If PictureBox12.Location.Y > 371 Then
            PictureBox12.Location = New Point(PictureBox12.Location.X, 197)
        End If
        If PictureBox13.Location.Y > 371 Then
            PictureBox13.Location = New Point(PictureBox13.Location.X, 197)
        End If
        If PictureBox14.Location.Y > 371 Then
            PictureBox14.Location = New Point(PictureBox14.Location.X, 197)
        End If
        If PictureBox15.Location.Y > 371 Then
            PictureBox15.Location = New Point(PictureBox15.Location.X, 197)
        End If
    End Sub

    Public Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        My.Computer.Audio.Stop()
        Try
            Dim AssemblyPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString()
            Dim exactPath = AssemblyPath + "\Media\Hale.wav"
            My.Computer.Audio.Play(exactPath, AudioPlayMode.BackgroundLoop)
        Catch ex As Exception
            MsgBox("Audio not located")
        End Try
        If PictureBox19.Visible = True Then
            PictureBox19.Visible = False
            PictureBox20.Visible = False
            PictureBox21.Visible = False
            PictureBox22.Visible = False
            PictureBox23.Visible = False
            PictureBox24.Visible = False
        Else
            PictureBox19.Visible = True
            PictureBox20.Visible = True
            PictureBox21.Visible = True
            PictureBox22.Visible = True
            PictureBox23.Visible = True
            PictureBox24.Visible = True
        End If
        If Timer3.Enabled = True Then
            Timer3.Stop()
        Else
            Timer3.Start()
        End If
    End Sub

    Public Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        light = light + 100
        If light = 6000 Then
            Me.BackColor = Color.DarkGray
        ElseIf light = 6100 Then
            Me.BackColor = Color.Black
        ElseIf light = 6200 Then
            Me.BackColor = Color.DarkGray
        ElseIf light = 6300 Then
            Me.BackColor = Color.Black
        ElseIf light = 8000 Then
            light = 0
        End If

        PictureBox18.Location = New Point(PictureBox18.Location.X, PictureBox18.Location.Y + 80)
        PictureBox19.Location = New Point(PictureBox19.Location.X, PictureBox19.Location.Y + 28)
        PictureBox20.Location = New Point(PictureBox20.Location.X, PictureBox20.Location.Y + 54)
        PictureBox21.Location = New Point(PictureBox21.Location.X, PictureBox21.Location.Y + 61)
        PictureBox22.Location = New Point(PictureBox22.Location.X, PictureBox22.Location.Y + 72)
        PictureBox23.Location = New Point(PictureBox23.Location.X, PictureBox23.Location.Y + 29)
        PictureBox24.Location = New Point(PictureBox24.Location.X, PictureBox24.Location.Y + 19)

        If PictureBox18.Location.Y > 467 Then
            PictureBox18.Location = New Point(PictureBox18.Location.X, 176)
        End If
        If PictureBox19.Location.Y > 467 Then
            PictureBox19.Location = New Point(PictureBox19.Location.X, 176)
        End If
        If PictureBox20.Location.Y > 467 Then
            PictureBox20.Location = New Point(PictureBox20.Location.X, 176)
        End If
        If PictureBox21.Location.Y > 467 Then
            PictureBox21.Location = New Point(PictureBox21.Location.X, 176)
        End If
        If PictureBox22.Location.Y > 467 Then
            PictureBox22.Location = New Point(PictureBox22.Location.X, 176)
        End If
        If PictureBox23.Location.Y > 467 Then
            PictureBox23.Location = New Point(PictureBox23.Location.X, 176)
        End If
        If PictureBox24.Location.Y > 467 Then
            PictureBox24.Location = New Point(PictureBox24.Location.X, 176)
        End If
    End Sub

    Public Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Rain location move to main page
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        My.Computer.Audio.Stop()

        L.p1 = L.p1 + 500
        L.p2 = L.p2 + 500
        L.p3 = L.p3 + 500
        L.p4 = L.p4 + 500
        L.p5 = L.p5 + 500
        L.p6 = L.p6 + 500
        L.p7 = L.p7 + 500
        L.p8 = L.p8 + 500
        L.p9 = L.p9 + 500

        L.p10 = L.p10 + 500
        L.p11 = L.p11 + 500
        L.p12 = L.p12 + 500
        L.p13 = L.p13 + 500
        L.p14 = L.p14 + 500
        L.p15 = L.p15 + 500

        L.p16 = L.p16 + 500
        L.p17 = L.p17 + 500
        L.p18 = L.p18 + 500
        L.p19 = L.p19 + 500
        L.p20 = L.p20 + 500
        L.p21 = L.p21 + 500
        L.p22 = L.p22 + 500
        L.p23 = L.p23 + 500
        L.p24 = L.p24 + 500


        PictureBox9.Location = New Point(L.p9, 380)
        PictureBox10.Location = New Point(L.p10, 87)
        PictureBox11.Location = New Point(L.p11, 197)
        PictureBox12.Location = New Point(L.p12, 233)
        PictureBox13.Location = New Point(L.p13, 326)
        PictureBox14.Location = New Point(L.p14, 283)
        PictureBox15.Location = New Point(L.p15, 233)
        PictureBox11.Visible = False
        PictureBox12.Visible = False
        PictureBox13.Visible = False
        PictureBox14.Visible = False
        PictureBox15.Visible = False

        PictureBox2.Location = New Point(L.p2, 124)
        PictureBox4.Location = New Point(L.p4, 221)
        PictureBox5.Location = New Point(L.p5, 266)
        PictureBox6.Location = New Point(L.p6, 360)
        PictureBox7.Location = New Point(L.p7, 342)
        PictureBox3.Location = New Point(L.p3, 297)
        PictureBox8.Location = New Point(L.p8, 342)
        PictureBox1.Location = New Point(L.p1, 459)
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        PictureBox7.Visible = False
        PictureBox8.Visible = False

        PictureBox16.Location = New Point(L.p16, 101)
        PictureBox17.Location = New Point(L.p17, 491)
        PictureBox18.Location = New Point(L.p18, 179)
        PictureBox19.Location = New Point(L.p19, 231)
        PictureBox20.Location = New Point(L.p20, 260)
        PictureBox21.Location = New Point(L.p21, 314)
        PictureBox22.Location = New Point(L.p22, 285)
        PictureBox23.Location = New Point(L.p23, 398)
        PictureBox24.Location = New Point(L.p24, 368)
        PictureBox18.Visible = False
        PictureBox19.Visible = False
        PictureBox20.Visible = False
        PictureBox21.Visible = False
        PictureBox22.Visible = False
        PictureBox22.Visible = False
        PictureBox23.Visible = False
        PictureBox24.Visible = False
        'snow location move to main page
    End Sub

    Private Sub startingPoints()
        PictureBox9.Location = New Point(L.p9 - 500, 380)
        PictureBox10.Location = New Point(L.p10 - 500, 87)
        PictureBox11.Location = New Point(L.p11 - 500, 197)
        PictureBox12.Location = New Point(L.p12 - 500, 233)
        PictureBox13.Location = New Point(L.p13 - 500, 326)
        PictureBox14.Location = New Point(L.p14 - 500, 283)
        PictureBox15.Location = New Point(L.p15 - 500, 233)
        PictureBox11.Visible = False
        PictureBox12.Visible = False
        PictureBox13.Visible = False
        PictureBox14.Visible = False
        PictureBox15.Visible = False

        PictureBox2.Location = New Point(L.p2, 124)
        PictureBox4.Location = New Point(L.p4, 221)
        PictureBox5.Location = New Point(L.p5, 266)
        PictureBox6.Location = New Point(L.p6, 360)
        PictureBox7.Location = New Point(L.p7, 342)
        PictureBox3.Location = New Point(L.p3, 297)
        PictureBox8.Location = New Point(L.p8, 342)
        PictureBox1.Location = New Point(L.p1, 459)
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        PictureBox7.Visible = False
        PictureBox8.Visible = False

        PictureBox16.Location = New Point(L.p16 + 500, 101)
        PictureBox17.Location = New Point(L.p17 + 500, 491)
        PictureBox18.Location = New Point(L.p18 + 500, 179)
        PictureBox19.Location = New Point(L.p19 + 500, 231)
        PictureBox20.Location = New Point(L.p20 + 500, 260)
        PictureBox21.Location = New Point(L.p21 + 500, 314)
        PictureBox22.Location = New Point(L.p22 + 500, 285)
        PictureBox23.Location = New Point(L.p23 + 500, 398)
        PictureBox24.Location = New Point(L.p24 + 500, 368)
        PictureBox18.Visible = False
        PictureBox19.Visible = False
        PictureBox20.Visible = False
        PictureBox21.Visible = False
        PictureBox22.Visible = False
        PictureBox22.Visible = False
        PictureBox23.Visible = False
        PictureBox24.Visible = False
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        'Rain location move to main page
        Button3.Enabled = True
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        My.Computer.Audio.Stop()

        L.p1 = L.p1 - 500
        L.p2 = L.p2 - 500
        L.p3 = L.p3 - 500
        L.p4 = L.p4 - 500
        L.p5 = L.p5 - 500
        L.p6 = L.p6 - 500
        L.p7 = L.p7 - 500
        L.p8 = L.p8 - 500

        L.p9 = L.p9 - 500
        L.p10 = L.p10 - 500
        L.p11 = L.p11 - 500
        L.p12 = L.p12 - 500
        L.p13 = L.p13 - 500
        L.p14 = L.p14 - 500
        L.p15 = L.p15 - 500

        L.p16 = L.p16 - 500
        L.p17 = L.p17 - 500
        L.p18 = L.p18 - 500
        L.p19 = L.p19 - 500
        L.p20 = L.p20 - 500
        L.p21 = L.p21 - 500
        L.p22 = L.p22 - 500
        L.p23 = L.p23 - 500
        L.p24 = L.p24 - 500

        PictureBox9.Location = New Point(L.p9, 380)
        PictureBox10.Location = New Point(L.p10, 87)
        PictureBox11.Location = New Point(L.p11, 197)
        PictureBox12.Location = New Point(L.p12, 233)
        PictureBox13.Location = New Point(L.p13, 326)
        PictureBox14.Location = New Point(L.p14, 283)
        PictureBox15.Location = New Point(L.p15, 233)
        PictureBox11.Visible = False
        PictureBox12.Visible = False
        PictureBox13.Visible = False
        PictureBox14.Visible = False
        PictureBox15.Visible = False

        PictureBox2.Location = New Point(L.p2, 124)
        PictureBox4.Location = New Point(L.p4, 221)
        PictureBox5.Location = New Point(L.p5, 266)
        PictureBox6.Location = New Point(L.p6, 360)
        PictureBox7.Location = New Point(L.p7, 342)
        PictureBox3.Location = New Point(L.p3, 297)
        PictureBox8.Location = New Point(L.p8, 342)
        PictureBox1.Location = New Point(L.p1, 459)
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        PictureBox7.Visible = False
        PictureBox8.Visible = False

        PictureBox16.Location = New Point(L.p16, 101)
        PictureBox17.Location = New Point(L.p17, 491)
        PictureBox18.Location = New Point(L.p18, 179)
        PictureBox19.Location = New Point(L.p19, 231)
        PictureBox20.Location = New Point(L.p20, 260)
        PictureBox21.Location = New Point(L.p21, 314)
        PictureBox22.Location = New Point(L.p22, 285)
        PictureBox23.Location = New Point(L.p23, 398)
        PictureBox24.Location = New Point(L.p24, 368)
        PictureBox18.Visible = False
        PictureBox19.Visible = False
        PictureBox20.Visible = False
        PictureBox21.Visible = False
        PictureBox22.Visible = False
        PictureBox22.Visible = False
        PictureBox23.Visible = False
        PictureBox24.Visible = False
        'snow location move to main page
    End Sub
End Class
