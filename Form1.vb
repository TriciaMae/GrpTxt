Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'connecting database values to combobox
        Dim MySqlConn As MySqlConnection
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=; database=csas"
        Dim command As New MySqlCommand
        Dim reader As MySqlDataReader
        Try
            'open database connection
            MySqlConn.Open()

            'query to get all values in send table
            Dim Query As String = "select * from csas.grp"

            'transfer query to mysql command 'command'
            command = New MySqlCommand(Query, MySqlConn)

            'run mysql command
            reader = command.ExecuteReader

            'populating combobox with the database values of selected table
            While reader.Read
                'connecting the data in the school column to the combobox
                Dim skl = reader.GetString("school")
                Dim ide = reader.GetString("id")
                sklCombo.Items.Add(skl)
                idCombo.Items.Add(ide)
            End While

            'close database connection
            MySqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub sklCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sklCombo.SelectedIndexChanged
        'linking the values from the combobox to the textbox
        Dim MySqlConn As MySqlConnection
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=; database=csas"
        Dim command As New MySqlCommand
        Dim reader As MySqlDataReader

        Try
            'open database connection
            MySqlConn.Open()

            'query for getting the data selected in the combobox
            Dim Query As String = "select * from csas.grp where school = '" & sklCombo.Text & "'
            and id = '" & idCombo.Text & "' "

            'transfer query to mysql command 'command'
            command = New MySqlCommand(Query, MySqlConn)

            'run mysql command
            reader = command.ExecuteReader

            'populating combobox with the database values of selected table
            While reader.Read
                'linking selected data in the combobox to the textbox
                txtLvl.Text = reader.GetString("skl_lvl") 'getint32 if the data to be displayed is num

            End While

            'close database connection
            MySqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Function GrpTxt()
        'grp msg function
        For i = 0 To 1
            Using client As New Net.WebClient
                Dim MySqlConn As MySqlConnection
                MySqlConn = New MySqlConnection
                MySqlConn.ConnectionString = "server=localhost; userid=root; password=; database=csas"

                Dim command As New MySqlCommand
                Dim reader As MySqlDataReader

                Dim parameter As New Specialized.NameValueCollection
                Dim url As String = "https://www.itexmo.com/php_api/api.php"

                Dim api As String
                api = "TR-SUSPE267289_1WEHI"

                Dim school As String = sklCombo.Text
                Dim lvl As String = txtLvl.Text
                Dim dat As String = dateTime.Text

                Dim msg As String
                msg = "Classes are suspended in " + lvl + " in " + school + " on " + dat + " due to Eng. Week Day."

                Try
                    'open database connection
                    MySqlConn.Open()

                    'query for getting the data selected in the combobox
                    Dim Query As String = "select cp_num from csas.grp where school = '" & sklCombo.Text & "'and id = '" & idCombo.Text & "'"

                    'transfer query to mysql command 'command'
                    command = New MySqlCommand(Query, MySqlConn)

                    'run mysql command
                    reader = command.ExecuteReader

                    'populating combobox with the database values of selected table
                    While reader.Read
                        parameter.Add("1", reader.GetString("cp_num"))
                        parameter.Add("2", msg)
                        parameter.Add("3", api)
                        Dim rpb = client.UploadValues(url, "POST", parameter)
                        GrpTxt = (New System.Text.UTF8Encoding).GetString(rpb)
                    End While

                    'close database connection
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            End Using
        Next
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'send btn
        Dim result = GrpTxt()
        If result = 0 Then
            MsgBox("Message Sent!")
        Else
            MsgBox("Error number " & result & " was encountered")
        End If
    End Sub
End Class
