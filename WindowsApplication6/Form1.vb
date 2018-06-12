Imports System.Data.SqlClient

Public Class DatabaseViewer

    Dim connectionString As String
    Dim sqlCommand As SqlCommand
    Dim commandString As String
    Dim maxPositionCommand As SqlCommand
    Dim connection As SqlConnection
    Dim dataReader As SqlDataReader
    Dim maxPositionReader As SqlDataReader
    Dim tablePosition As Int16 = 1
    Dim maxPosition As Int16

    Dim activityID As String
    Dim activityName As String
    Dim activityType As String
    Dim moduleID As String
    Dim day As String
    Dim time As String
    Dim roomID As String
    Dim red() As Char = {"r", "e", "d"}






    Private Sub connect_btn_Click(sender As Object, e As EventArgs) Handles connect_btn.Click
        connectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= |DataDirectory|\Test.mdf"
        connection = New SqlConnection(connectionString)

        If connection.State = ConnectionState.Closed Then
            Try
                connection.Open()
                MsgBox("Connection Open")
                connect_btn.Text = "Disconnect"
            Catch ex As Exception
                MsgBox("SQL Connection Failed" & ex.Message)
            End Try
            Sql_run()
        ElseIf connection.State = ConnectionState.Open Then
            connection.Close()
            MsgBox("Connection Closed")

        End If



    End Sub

    Private Sub Sql_run()
        If connection.State = ConnectionState.Open Then
            commandString = "SELECT TOP " & tablePosition & " * FROM tblActivity"
            sqlCommand = New SqlCommand(commandString, connection)
            dataReader = sqlCommand.ExecuteReader

            While dataReader.Read
                activityID = dataReader(0)
                activityName = dataReader(1)
                activityType = dataReader(2)
                moduleID = dataReader(3)
                day = dataReader(4).ToString
                time = dataReader(5).ToString
                roomID = dataReader(6)
            End While


            dataReader.Close()

            maxPositionCommand = New SqlCommand("SELECT COUNT(*) FROM tblActivity", connection)
            maxPositionReader = maxPositionCommand.ExecuteReader
            While maxPositionReader.Read
                maxPosition = maxPositionReader(0)
            End While
            maxPositionReader.Close()

            position_txtbox.Text = tablePosition
            activityID_txtbox.Text = activityID
            activityName_txtbox.Text = activityName
            activityType_cbox.Text = activityType
            moduleID_cbox.Text = moduleID
            day_cbox.Text = day
            time_cbox.Text = time
            roomID_cbox.Text = roomID
            Max_label.Text = maxPosition

            If tablePosition = maxPosition Then
                nextRecord_btn.Enabled = False
                lastRecord_btn.Enabled = False
                firstRecord_btn.Enabled = True
                previousRecord_btn.Enabled = True

            End If


        End If
    End Sub

    Private Sub Sql_amend()
        If activityName.StartsWith("red") Then
            activityName = activityName.TrimStart(red)
        End If
        If activityType.StartsWith("red") Then
            activityType = activityType.TrimStart(red)
        End If
        If moduleID.StartsWith("red") Then
            moduleID = moduleID.TrimStart(red)
        End If
        If day.StartsWith("red") Then
            day = day.TrimStart(red)
        End If
        If time.StartsWith("red") Then
            time = time.TrimStart(red)
        End If
        If roomID.StartsWith("red") Then
            roomID = roomID.TrimStart(red)
        End If


        If connection.State = ConnectionState.Open Then
            commandString = "UPDATE tblActivity SET " _
                & "Name = '" & activityName _
                & "', Type = '" & activityType _
                & "', ModuleID = '" & moduleID _
                & "', Day = '" & day _
                & "', Time = '" & time _
                & "', RoomID = '" & roomID _
                & "' WHERE ID = '" & activityID & "'"
            sqlCommand = New SqlCommand(commandString, connection)
            sqlCommand.ExecuteNonQuery()

            MsgBox("Record Amended")
            Sql_run()

        End If
    End Sub

    Private Sub sql_add()
        If connection.State = ConnectionState.Open Then

            commandString = "INSERT INTO tblActivity (ID, Name, Type, moduleID, day, time, roomID) VALUES ('" _
                & activityID & "', '" & activityName & "', '" & activityType & "', '" & moduleID & "'," & day & "," & time & ", '" & roomID & "')"
            sqlCommand = New SqlCommand(commandString, connection)
            sqlCommand.ExecuteNonQuery()

            MsgBox("Record Added")

            tablePosition = maxPosition + 1
            Sql_run()

        End If
    End Sub

    Private Sub Sql_delete()
        If connection.State = ConnectionState.Open Then
            commandString = "DELETE FROM tblActivity WHERE ID = '" & activityID & "'"
            sqlCommand = New SqlCommand(commandString, connection)
            sqlCommand.ExecuteNonQuery()

            MsgBox("Record Deleted")
            Sql_run()
        End If
    End Sub

    Private Sub firstRecord_btn_Click(sender As Object, e As EventArgs) Handles firstRecord_btn.Click

        tablePosition = 1

        firstRecord_btn.Enabled = False
        previousRecord_btn.Enabled = False
        nextRecord_btn.Enabled = True
        lastRecord_btn.Enabled = True

        Sql_run()
    End Sub

    Private Sub previousRecord_btn_Click(sender As Object, e As EventArgs) Handles previousRecord_btn.Click

        tablePosition -= 1

        nextRecord_btn.Enabled = True
        lastRecord_btn.Enabled = True

        If tablePosition = 1 Then
            previousRecord_btn.Enabled = False
            firstRecord_btn.Enabled = False
        End If

        Sql_run()

    End Sub

    Private Sub lastRecord_btn_Click(sender As Object, e As EventArgs) Handles lastRecord_btn.Click

        tablePosition = maxPosition

        nextRecord_btn.Enabled = False
        lastRecord_btn.Enabled = False

        firstRecord_btn.Enabled = True
        previousRecord_btn.Enabled = True

        Sql_run()




    End Sub

    Private Sub nextRecord_btn_Click(sender As Object, e As EventArgs) Handles nextRecord_btn.Click

        tablePosition += 1

        firstRecord_btn.Enabled = True
        previousRecord_btn.Enabled = True

        If tablePosition = maxPosition Then
            nextRecord_btn.Enabled = False
            lastRecord_btn.Enabled = False
        End If

        Sql_run()
    End Sub

    Private Sub position_txtbox_TextChanged(sender As Object, e As EventArgs) Handles position_txtbox.TextChanged

    End Sub

    Private Sub amend_btn_Click(sender As Object, e As EventArgs) Handles amend_btn.Click


        If activityName <> activityName_txtbox.Text Then
            activityName = "red" & activityName_txtbox.Text
        End If
        If activityType <> activityType_cbox.Text Then
            activityType = "red" & activityType_cbox.Text
        End If
        If moduleID <> moduleID_cbox.Text Then
            moduleID = "red" & moduleID_cbox.Text
        End If
        If day <> day_cbox.Text Then
            day = "red" & day_cbox.Text
        End If
        If time <> time_cbox.Text Then
            time = "red" & time_cbox.Text
        End If
        If roomID <> roomID_cbox.Text Then
            roomID = "red" & roomID_cbox.Text
        End If



        Dim confirmForm As New ConfirmAmendments(activityID, activityName, activityType, moduleID, day, time, roomID)

        If confirmForm.ShowDialog() = DialogResult.OK Then
            Sql_amend()
        End If


    End Sub

    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        Me.Enabled = False
        Dim NewEntryform As New NewEntry()
        If NewEntryform.ShowDialog() = DialogResult.OK Then
            activityID = NewEntryform.activityID_txtbox.Text
            activityName = NewEntryform.activityName_txtbox.Text
            activityType = NewEntryform.activityType_cbox.Text
            moduleID = NewEntryform.moduleID_cbox.Text
            day = NewEntryform.day_cbox.Text
            time = NewEntryform.time_cbox.Text
            roomID = NewEntryform.roomID_cbox.Text


            sql_add()
        End If

        Me.Enabled = True





    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        Me.Enabled = False
        Dim confirmDelete As New ConfirmDelete()
        If confirmDelete.ShowDialog() = DialogResult.OK Then
            Sql_delete()

        End If
        Me.Enabled = True
    End Sub

    Private Sub DatabaseViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\stfbc\OneDrive\Year 2\Database Apps\WindowsApplication6\WindowsApplication6\Test.mdf"
        connection = New SqlConnection(connectionString)


        Try
                connection.Open()
                MsgBox("Connection Open")

            Catch ex As Exception
                MsgBox("SQL Connection Failed" & ex.Message)
            End Try


            'TODO: This line of code loads data into the 'TestDataSet.tblModule' table. You can move, or remove it, as needed.
            Me.TblModuleTableAdapter.Fill(Me.TestDataSet.tblModule)
        'TODO: This line of code loads data into the 'TestDataSet.tblActivity' table. You can move, or remove it, as needed.
        Me.TblActivityTableAdapter.Fill(Me.TestDataSet.tblActivity)
        'TODO: This line of code loads data into the 'TestDataSet.tblRoom' table. You can move, or remove it, as needed.
        Me.TblRoomTableAdapter.Fill(Me.TestDataSet.tblRoom)

            Sql_run()

    End Sub

    Private Sub position_txtbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles position_txtbox.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            If CInt(position_txtbox.Text) > maxPosition Then
                MsgBox("Out of range")
                position_txtbox.Text = tablePosition
            Else
                tablePosition = position_txtbox.Text
                Sql_run()
            End If
        End If
    End Sub



End Class
