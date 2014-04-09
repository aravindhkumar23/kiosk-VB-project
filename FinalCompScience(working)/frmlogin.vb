Imports System.Data.OleDb
Imports System.Data

Public Class frmlogin
    Inherits System.Windows.Forms.Form
    Dim Conn As System.Data.OleDb.OleDbConnection
    Dim dbprovider, dbsource As String
    Dim ds As DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim sql As String


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        frmWelcome.Show()

    End Sub

    Private Sub frmlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GroupBox1.Hide()
        GroupBox2.Hide()

        Me.CenterToScreen()
        dbprovider = "Provider=Microsoft.ACE.OLEDB.12.0;"
        dbsource = "Data Source=C:\Users\Aravindh\Documents\kiosk.accdb"
        Conn.ConnectionString = dbprovider & dbsource
        Conn.Open()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        GroupBox2.Hide()
        GroupBox1.Show()



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        GroupBox2.Show()
        GroupBox1.Hide()


    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If TextBox2.Text = "" Or TextBox1.Text = "" Then
            MessageBox.Show("Please complete the required fields..", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim conn As New System.Data.OleDb.OleDbConnection()
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Aravindh\Documents\kiosk.accdb"

            Try
                Dim sql As String = "SELECT * FROM login WHERE username='" & TextBox1.Text & "' AND password = '" & TextBox2.Text & "'"
                Dim sqlCom As New System.Data.OleDb.OleDbCommand(sql)

                sqlCom.Connection = conn
                conn.Open()

                Dim sqlRead As System.Data.OleDb.OleDbDataReader = sqlCom.ExecuteReader()

                If sqlRead.Read() Then
                    frmWelcome.Show()
                    Me.Hide()

                Else
                  
                    MessageBox.Show("Username and Password do not match..", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


                    TextBox2.Text = ""
                    TextBox1.Text = ""


                    TextBox1.Focus()
                End If

            Catch ex As Exception
                MessageBox.Show("Failed to connect to Database..", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub






    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        End

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If TextBox4.Text = "" Or TextBox3.Text = "" Then
            MessageBox.Show("Please complete the required fields..", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim conn As New System.Data.OleDb.OleDbConnection()
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Aravindh\Documents\kiosk.accdb"

            Try
                Dim sql As String = "insert into login values('" & TextBox4.Text & "','" & TextBox3.Text & "')"
                Dim sqlCom As New System.Data.OleDb.OleDbCommand(sql)

                sqlCom.Connection = conn
                conn.Open()

                Dim sqlRead As System.Data.OleDb.OleDbDataReader = sqlCom.ExecuteReader()

                sqlRead.Read()
                MsgBox("New user added ...Login to continue")


                Me.Hide()
            Catch ex As Exception
                MessageBox.Show("Failed to connect to Database..", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
        Me.Show()
        Label3.Show()
        GroupBox2.Hide()
        GroupBox1.Show()

    End Sub
End Class