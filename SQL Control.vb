'Edited by Robert 4/29
Imports System.Data.Sql
Imports System.Data.SqlClient
'appconfig: save password in external config file
Imports System.Configuration
Imports System.Collections.Specialized

Public Class SQL_Control
    Public SQLCon As New SqlConnection With {}
    Public SQLCmd As SqlCommand
    Public SQLDA As SqlDataAdapter
    Public SQLDataset As DataSet
    Public tw As triageWindow
    Public changedCells(15) As String
    Public cellPos As Integer = 0



    Public Function HasConnection() As Boolean
        'TESTING CONNECTION TO DATABASE
        Try
            SQLCon.Open()
            SQLCon.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Sub RunQuery(Query As String)
        Try
            SQLCon.Open()
            SQLCmd = New SqlCommand(Query, SQLCon)
            ' LOAD SQL RECORD FOR DATA GRID
            SQLDA = New SqlDataAdapter(SQLCmd)
            SQLDataset = New DataSet
            SQLDA.Fill(SQLDataset)

            ' READ DIRECTLY FROM DATBASE

            'Dim R As SqlDataReader = SQLCmd.ExecuteReader

            'While R.Read
            'MsgBox(R.GetName(0) & ": " & R(0))
            'End While
            SQLCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

            If SQLCon.State = ConnectionState.Open Then
                SQLCon.Close()

            End If
        End Try
    End Sub

    Public Function tSearch(pkey As String, sNaNull As Boolean, sNoNull As Boolean)
        Dim strSearch As String = Nothing
        Dim returnStr As String = Nothing



        Try
            If sNoNull = True Then
                SQLCmd = New SqlCommand("SELECT [Serial Number] FROM Assignments$ WHERE [Student Name] =  @sNa ORDER BY [Date Start] DESC", SQLCon)

            ElseIf sNaNull = True Then
                SQLCmd = New SqlCommand("Select [Student Name] FROM Assignments$ WHERE [Serial Number] =  @sN ORDER BY [Date Start] DESC", SQLCon) 'AND [Date Start] = (SELECT MAX([Date Start]) FROM Claims) "

            End If

            SQLCmd.Parameters.AddWithValue("@sNa", pkey)
            SQLCmd.Parameters.AddWithValue("@sN", pkey)
            SQLCon.Open()

            returnStr = SQLCmd.ExecuteScalar()
            SQLCon.Close()
            Return returnStr

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If SQLCon.State = ConnectionState.Open Then
            SQLCon.Close()
            MsgBox("Connection was forcibly closed.")
        End If

        Return Nothing
    End Function

    Public Function AddTriage(claimID As String, serialNum As String, studentNa As String, curdate As String, status As String, problem As String, track As String, notes As String, attnChk As Boolean)
        Dim tcheck As Integer = 0
        Try
            SQLCmd = New SqlCommand("INSERT INTO Claims ([Claim ID],[Serial Number],[Student Name],[Date Filed],Status,Problem,TrackingNo, Notes, Attention) " &
                                      "VALUES (" &
                                      " @cID," &
                                      " @sN," &
                                      " @sNa," &
                                      " @date," &
                                      " @stat," &
                                      " @prob," &
                                      " @tNo," &
                                      " @notes," &
                                      " @aChk)", SQLCon)

            SQLCmd.Parameters.AddWithValue("@cID", claimID)
            SQLCmd.Parameters.AddWithValue("@sN", serialNum)
            SQLCmd.Parameters.AddWithValue("@sNa", studentNa)
            SQLCmd.Parameters.AddWithValue("@date", curdate)
            SQLCmd.Parameters.AddWithValue("@stat", status)
            SQLCmd.Parameters.AddWithValue("@prob", problem)
            SQLCmd.Parameters.AddWithValue("@tNo", track)
            SQLCmd.Parameters.AddWithValue("@notes", notes)
            SQLCmd.Parameters.AddWithValue("aChk", attnChk)

            'MsgBox(strInsert)

            SQLCon.Open()

            tcheck = SQLCmd.ExecuteNonQuery()
            SQLCon.Close()
            If tcheck > 0 Then
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If SQLCon.State = ConnectionState.Open Then
            SQLCon.Close()
            MsgBox("Connection was forcibly closed.")
        End If
        Return False
    End Function

    '   UPDATE QUERY
    Public Function Update(updateLoc As String, updateVal As String, curdate As String)
        'Dim ccheck As String = "SELECT * WHERE [claim ID]='" & updateLoc & "' AND [Date Updated] IS NOT NULL"
        'SQLCmd = New SqlCommand(ccheck, SQLCon)
        'Dim flag As Integer = SQLCmd.ExecuteNonQuery()
        'If flag > 1 Then
        '    Dim flagPrompt As DialogResult = MessageBox.Show("The Value has already been updated, do you wish to proceed?",
        '                                                     "STOP",
        '                                                     MessageBoxButtons.YesNo,
        '                                                     MessageBoxIcon.Warning)
        '    If flagPrompt = DialogResult.No Then
        '        Exit Sub
        '    End If

        'End If


        Try
            Dim strUpdate As String = "UPDATE Claims " &
                "SET Status ='" & updateVal & "'," &
                "[Date Updated] = '" & curdate & "' " &
                "WHERE [claim ID]='" & updateLoc & "'"


            'MsgBox(strUpdate)

            SQLCon.Open()
            SQLCmd = New SqlCommand(strUpdate, SQLCon)
            Dim check As Integer = SQLCmd.ExecuteNonQuery()
            SQLCon.Close()
            If check > 0 Then
                MsgBox("You have updated " & updateLoc & "'s status to " & updateVal & ".")
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If SQLCon.State = ConnectionState.Open Then
            SQLCon.Close()
            MsgBox("Connection was forcibly closed.")
        End If
        Return False
    End Function

    Public Function Assignment(stuNa As String, oldSN As String, newSN As String, dEnd As Date, dStart As Date, notes As String, replace As Boolean, terminate As Boolean, create As Boolean)
        'REPLACE, END, NEW
        If replace = True Then
            Try
                Dim strAsgtclose As String = "UPDATE Assignments$ " &
                    "SET [Date End] = '" & dEnd & "', " &
                    "Notes = '" & notes & "'" &
                    "WHERE [Student Name] = '" & stuNa & "' " &
                    "AND [Serial Number] = '" & oldSN & "'"

                Dim strAsgtopen As String = "INSERT INTO Assignments$ ([Student Name],[Serial Number],[Date Start],Notes) " &
                    "VALUES (" &
                    "'" & stuNa & "'," &
                    "'" & newSN & "'," &
                    "'" & dStart & "'," &
                    "'" & notes & "')"

                'MsgBox(strAsgtclose)
                'MsgBox(strAsgtopen)

                SQLCon.Open()
                SQLCmd = New SqlCommand(strAsgtclose, SQLCon)
                Dim closeCk As Integer = SQLCmd.ExecuteNonQuery()
                SQLCmd = New SqlCommand(strAsgtopen, SQLCon)
                Dim newCk As Integer = SQLCmd.ExecuteNonQuery()
                SQLCon.Close()
                ' TERMINATE OLD ASSIGNMENT BY ADDING END DATE 
                ' CREATE NEW ENTRY TO ASSIGNMENT WITH NEW START DATE
                If closeCk > 0 And newCk > 0 Then
                    MsgBox("You have successfully updated " & stuNa & "'s assignment fomr " & oldSN & " to " & newSN & ".")
                    Return True
                Else
                    MsgBox("You have failed to update the assignment.")
                    Return False
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf terminate = True Then
            Try
                Dim strAsgtclose As String = "UPDATE Assignments$ " &
                        "SET [Date End] = '" & dEnd & "', " &
                        "Notes = '" & notes & "'" &
                        "WHERE [Student Name] = '" & stuNa & "' " &
                        "AND [Serial Number] = '" & oldSN & "'"
                'MsgBox(strAsgtclose)

                SQLCon.Open()
                SQLCmd = New SqlCommand(strAsgtclose, SQLCon)
                Dim check As Integer = SQLCmd.ExecuteNonQuery()
                SQLCon.Close()
                If check > 0 Then
                    MsgBox("You have successfully terminated the assignment between " & stuNa & " and " & oldSN & ".")
                    Return True
                Else
                    MsgBox("You have failed to terminate the assignment.")
                    Return False
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf create = True Then
            Try
                Dim strAsgtopen As String = "INSERT INTO Assignments$ ([Student Name],[Serial Number],[Date Start],Notes) " &
                        "VALUES (" &
                        "'" & stuNa & "', " &
                        "'" & newSN & "', " &
                        "'" & dStart & "'," &
                        "'" & notes & "')"
                'MsgBox(strAsgtopen)

                SQLCon.Open()
                SQLCmd = New SqlCommand(strAsgtopen, SQLCon)
                Dim check As Integer = SQLCmd.ExecuteNonQuery()
                If check > 0 Then
                    MsgBox("You have successfully created the assignment between " & stuNa & " and " & newSN & ".")
                    Return True
                Else
                    MsgBox("You have failed to create the assignment.")
                    Return False
                End If
                SQLCon.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        If SQLCon.State = ConnectionState.Open Then
            SQLCon.Close()
            MsgBox("Connection was forcibly closed.")
            Return False
        End If
        Return False
    End Function

    Public Function Search(sField As String, sLoc As String, sVal As String, atnChk As Boolean, total As Boolean)

        Try
            SQLCon.Open()

            If sLoc = "Claims" And total = False Then
                SQLCmd = New SqlCommand("SELECT * " &
                "FROM Claims " &
                "INNER JOIN Systems$ ON Claims.[Serial Number] = Systems$.[Serial Number] " &
                "WHERE  Claims." & sField & " Like '%" & sVal & "%' " &
                "AND Attention = @atnChk", SQLCon)
            ElseIf sLoc = "Claims" And total = True Then
                SQLCmd = New SqlCommand("SELECT * " &
              "FROM Claims " &
              "INNER JOIN Systems$ ON Claims.[Serial Number] = Systems$.[Serial Number]" &
              "WHERE " & sField & " = @sVal", SQLCon)
            Else
                SQLCmd = New SqlCommand("SELECT * " &
               "FROM " & sLoc & " " &
               "WHERE " & sField & " LIKE '%" & sVal & "%' ", SQLCon)
            End If

            SQLCmd.Parameters.AddWithValue("@sLoc", sLoc)
            SQLCmd.Parameters.AddWithValue("@sVal", sVal)
            SQLCmd.Parameters.AddWithValue("@atnChk", atnChk)

            'MsgBox(strSearch)


            ' LOAD SQL RECORD FOR DATA GRID
            SQLDA = New SqlDataAdapter(SQLCmd)
            SQLDataset = New DataSet
            SQLDA.Fill(SQLDataset)
            SQLCon.Close()
            If SQLDA IsNot Nothing Then
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If SQLCon.State = ConnectionState.Open Then
            SQLCon.Close()
        End If
        Return False
    End Function

    '   CHECK DURTION OF TIME SINCE ENTRY
    Public Sub checkDuration(duration As Integer, metric As String)
        SQLCon.Open()
        Dim strdur As String = ""
        Dim curdate As Date = Date.Today()

        Try
            If metric = "Days" Then
                strdur = "SELECT * " &
                    "FROM claims " &
                    "WHERE DATEDIFF(day,[Date Filed], '" & curdate & "') >= '" & duration & "' " &
                    "ORDER BY [Date Filed] DESC "
            Else
                strdur = "SELECT * " &
                   "FROM claims " &
                   "WHERE DATEDIFF(year,[Date Filed], '" & curdate & "') >= '" & duration & "' " &
                   "ORDER BY [Date Filed] DESC "
            End If
            'MsgBox(strdur)
            SQLCmd = New SqlCommand(strdur, SQLCon)
            ' LOAD SQL RECORD FOR DATA GRID
            SQLDA = New SqlDataAdapter(SQLCmd)
            SQLDataset = New DataSet
            SQLDA.Fill(SQLDataset)

            SQLCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If SQLCon.State = ConnectionState.Open Then
            SQLCon.Close()
        End If
    End Sub

    'SEARCH FUNCTION TO FIND MISSING INFORMATION TO COMPLETE A TRIAGE
    Public Function paramSearch(sTab As String, sAttr As String, sVal As String)

        SQLCon.Open()
        Try
            Dim SQLkey As SqlCommand
            SQLkey = New SqlCommand("SELECT column_name as primarykeycolumn " &
                                            "From INFORMATION_SCHEMA.TABLE_CONSTRAINTS AS TC " &
                                            "INNER JOIN " &
                                            "INFORMATION_SCHEMA.KEY_COLUMN_USAGE AS KU " &
                                            "ON TC.CONSTRAINT_TYPE = 'PRIMARY KEY' AND " &
                                            "TC.CONSTRAINT_NAME = KU.CONSTRAINT_NAME " &
                                            "And ku.table_name='" & sTab & "' " &
                                            "ORDER BY KU.TABLE_NAME, KU.ORDINAL_POSITION ", SQLCon)

            Dim pkey As String = SQLkey.ExecuteScalar()

            SQLDA = New SqlDataAdapter("SELECT * FROM " & sTab & " WHERE " & sAttr & " = '" & sVal & "'", SQLCon)

            For i As Integer = 0 To changedCells.Length - 1
                Dim selection As String = changedCells(i)
                If selection = "" Then
                    Exit For
                End If
                Select Case selection
                    Case "Claim ID"
                        SQLCmd = New SqlCommand("UPDATE " & sTab & " SET [Claim Id] = @tCid WHERE [" & pkey & "] = @pid", SQLDA.SelectCommand.Connection)
                        SQLCmd.Parameters.Add(New SqlParameter("@tCid", SqlDbType.VarChar))
                        SQLCmd.Parameters("@tCid").SourceVersion = DataRowVersion.Current
                        SQLCmd.Parameters("@tCid").SourceColumn = "Claim Id"

                    Case "Serial Number"
                        SQLCmd = New SqlCommand("UPDATE " & sTab & " SET [Serial Number] = @sNo WHERE [" & pkey & "] = @pid", SQLDA.SelectCommand.Connection)

                    Case "Student Name"
                        SQLCmd = New SqlCommand("UPDATE " & sTab & " SET [Student Name] = @sNa WHERE [" & pkey & "] = @pid", SQLDA.SelectCommand.Connection)


                    Case "Date Filed"
                        SQLCmd = New SqlCommand("UPDATE " & sTab & " SET [Date Filed] = @tDatef WHERE [" & pkey & "] = @pid", SQLDA.SelectCommand.Connection)
                        SQLCmd.Parameters.Add(New SqlParameter("@tDatef", SqlDbType.Date))
                        SQLCmd.Parameters("@tDatef").SourceVersion = DataRowVersion.Current
                        SQLCmd.Parameters("@tDatef").SourceColumn = "Date Filed"

                    Case "Status"
                        SQLCmd = New SqlCommand("UPDATE " & sTab & " SET Status = @tStat WHERE [" & pkey & "] = @pid", SQLDA.SelectCommand.Connection)
                        SQLCmd.Parameters.Add(New SqlParameter("@tStat", SqlDbType.VarChar))
                        SQLCmd.Parameters("@tStat").SourceVersion = DataRowVersion.Current
                        SQLCmd.Parameters("@tStat").SourceColumn = "Status"

                    Case "Date Updated"
                        SQLCmd = New SqlCommand("UPDATE " & sTab & " SET [Date Updated] = @tDateu WHERE [" & pkey & "] = @pid", SQLDA.SelectCommand.Connection)
                        SQLCmd.Parameters.Add(New SqlParameter("@tDateu", SqlDbType.Date))
                        SQLCmd.Parameters("@tDateu").SourceVersion = DataRowVersion.Current
                        SQLCmd.Parameters("@tDateu").SourceColumn = "Date Updated"

                    Case "Problem"
                        SQLCmd = New SqlCommand("UPDATE " & sTab & " SET Problem = @tProb WHERE [" & pkey & "] = @pid", SQLDA.SelectCommand.Connection)
                        SQLCmd.Parameters.Add(New SqlParameter("@tProb", SqlDbType.NVarChar))
                        SQLCmd.Parameters("@tProb").SourceVersion = DataRowVersion.Current
                        SQLCmd.Parameters("@tProb").SourceColumn = "Problem"

                    Case "TrackingNo"
                        SQLCmd = New SqlCommand("UPDATE " & sTab & " SET TrackingNo = @tTo WHERE [" & pkey & "] = @pid", SQLDA.SelectCommand.Connection)
                        SQLCmd.Parameters.Add(New SqlParameter("@tTo", SqlDbType.NVarChar))
                        SQLCmd.Parameters("@tTo").SourceVersion = DataRowVersion.Current
                        SQLCmd.Parameters("@tTo").SourceColumn = "TrackingNo"

                    Case "Notes"
                        SQLCmd = New SqlCommand("UPDATE " & sTab & " SET Notes = @tNote WHERE [" & pkey & "] = @pid", SQLDA.SelectCommand.Connection)
                        SQLCmd.Parameters.Add(New SqlParameter("@tNote", SqlDbType.NVarChar))
                        SQLCmd.Parameters("@tNote").SourceVersion = DataRowVersion.Current
                        SQLCmd.Parameters("@tNote").SourceColumn = "Notes"

                    Case "Attention"
                        SQLCmd = New SqlCommand("UPDATE " & sTab & " SET Attention = @tAtn WHERE [" & pkey & "] = @pid", SQLDA.SelectCommand.Connection)
                        SQLCmd.Parameters.Add(New SqlParameter("@tAtn", SqlDbType.Bit))
                        SQLCmd.Parameters("@tAtn").SourceVersion = DataRowVersion.Current
                        SQLCmd.Parameters("@tAtn").SourceColumn = "Attention"

                    Case ""
                        Exit Select
                End Select

                SQLCmd.Parameters.Add(New SqlParameter("@pid", SqlDbType.VarChar))
                SQLCmd.Parameters("@pid").SourceVersion = DataRowVersion.Original
                SQLCmd.Parameters("@pid").SourceColumn = SQLDataset.Tables(0).Columns(0).ToString()

                SQLCmd.Parameters.Add(New SqlParameter("@sNa", SqlDbType.NVarChar))
                SQLCmd.Parameters("@sNa").SourceVersion = DataRowVersion.Current
                SQLCmd.Parameters("@sNa").SourceColumn = "Student Name"

                SQLCmd.Parameters.Add(New SqlParameter("@sNo", SqlDbType.NVarChar))
                SQLCmd.Parameters("@sNo").SourceVersion = DataRowVersion.Current
                SQLCmd.Parameters("@sNo").SourceColumn = "Serial Number"

                SQLDA.UpdateCommand = SQLCmd
                SQLDA.Fill(SQLDataset, sTab)

                Dim tblChanges As DataTable = SQLDataset.Tables(0).GetChanges()
                SQLDA.Update(tblChanges)
            Next
            'SQLCmd = New SqlCommand("UPDATE " & sTab & " SET " & sAttr & " = @nVal WHERE [" & pkey & "] = @aid", SQLDA.SelectCommand.Connection)

            ' EXTRA CODE FOR MANUAL UPDATE QUERIES IF YOU JOIN MULTIPLE TABLES 
            'SQLCmd.Parameters.Add(New SqlParameter("@dSt", SqlDbType.NVarChar))
            'SQLCmd.Parameters("@dSt").SourceVersion = DataRowVersion.Current
            'SQLCmd.Parameters("@dSt").SourceColumn = "Date Start"
            'SQLCmd.Parameters.Add(New SqlParameter("@dEd", SqlDbType.NVarChar))
            'SQLCmd.Parameters("@dEd").SourceVersion = DataRowVersion.Current
            'SQLCmd.Parameters("@dEd").SourceColumn = "Date End"
            'SQLCmd.Parameters.Add(New SqlParameter("@hNa", SqlDbType.NVarChar))
            'SQLCmd.Parameters("@hNa").SourceVersion = DataRowVersion.Current
            'SQLCmd.Parameters("@hNa").SourceColumn = "Hostname"
            'SQLCmd.Parameters.Add(New SqlParameter("@grade", SqlDbType.Float))
            'SQLCmd.Parameters("@grade").SourceVersion = DataRowVersion.Current
            'SQLCmd.Parameters("@grade").SourceColumn = "Grade"
            'SQLCmd.Parameters.Add(New SqlParameter("@mac", SqlDbType.NVarChar))
            'SQLCmd.Parameters("@mac").SourceVersion = DataRowVersion.Current
            'SQLCmd.Parameters("@mac").SourceColumn = "MAC Address"
            'SQLCmd.Parameters.Add(New SqlParameter("@mod", SqlDbType.VarChar))
            'SQLCmd.Parameters("@mod").SourceVersion = DataRowVersion.Current
            'SQLCmd.Parameters("@mod").SourceColumn = "Model"

            SQLCon.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If SQLCon.State = ConnectionState.Open Then
            SQLCon.Close()
            MsgBox("Connection was forcibly closed.")
        End If
        Return False
    End Function

    Public Function bulkInsert(mFileloc As String, mDestloc As String)
        Dim bInsertstr As String = ""

        Try
            bInsertstr = "BULK INSERT [dbo].[" & mDestloc & "] FROM '" & mFileloc & "' " & "WITH (FIELDTERMINATOR = ',', ROWTERMINATOR = '\n')"

            SQLCmd = New SqlCommand(bInsertstr, SQLCon)
            Dim check As Integer = SQLCmd.ExecuteNonQuery()
            If check > 0 Then
                MsgBox("You have successfully inserted data into " & mDestloc & " from the file " & mFileloc & ".")
                Return True
            Else
                MsgBox("You have unseccessfully inserted the data, Please check your parameters and try again.")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    'MANAGER CONTROLS FOR STUDENTS$ TABLES 
    Public Function mInsert(stuNa As String, hNa As String, grade As String)
        'SHOULD PARAMETERIZE 2/11
        Dim mcheck As Integer = 0
        Try
            Dim strInsert As String = "INSERT INTO Students$ ([Student Name],[Hostname],[grade]) " &
                                      "VALUES (" &
                                      "'" & stuNa & "'," &
                                      "'" & hNa & "'," &
                                      "'" & grade & "')"
            'MsgBox(strInsert)

            SQLCon.Open()
            SQLCmd = New SqlCommand(strInsert, SQLCon)
            mcheck = SQLCmd.ExecuteNonQuery()
            SQLCon.Close()
            If mcheck > 0 Then
                MsgBox("You have successfully created the new student.")
                Return True
            Else
                MsgBox("You were unable to inset the new student.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If SQLCon.State = ConnectionState.Open Then
            SQLCon.Close()
            MsgBox("Connection was forcibly closed.")
        End If
        Return False
    End Function

    Public Function mDelete(stuNa As String, hNa As String, grade As String)
        Dim mcheck As Integer = 0
        Try
            Dim strDelete As String = "DELETE FROM Students$ " &
                                      "WHERE [Student Name] = '" & stuNa & "'" &
                                      "AND [Hostname] = '" & hNa & "'" &
                                      "AND Grade = '" & grade & "'"

            MsgBox(strDelete)

            SQLCon.Open()
            SQLCmd = New SqlCommand(strDelete, SQLCon)
            mcheck = SQLCmd.ExecuteNonQuery()
            SQLCon.Close()
            If mcheck > 0 Then
                MsgBox("You have successfully deleted the Student.")
                Return True
            Else
                MsgBox("You were unable to delete the Student, please make sure the spelling is correct in all fields.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If SQLCon.State = ConnectionState.Open Then
            SQLCon.Close()
            MsgBox("Connection was forcibly closed.")
        End If
        Return False
    End Function

    'MANAGER CONTROLS FOR SYSTEMS$ TABLE 2/11
    Public Function mSysInsert(sn As String, mac As String, model As String)
        Dim mcheck As Integer = 0
        Try
            Dim strInsert As String = "INSERT INTO Systems$ ([Serial Number], [MAC Address], Model) VALUES (@sn, @mac, @model)"
            SQLCmd = New SqlCommand(strInsert, SQLCon)
            SQLCmd.Parameters.AddWithValue("@sn", sn)
            SQLCmd.Parameters.AddWithValue("@mac", mac)
            SQLCmd.Parameters.AddWithValue("@model", model)

            MsgBox(strInsert)

            SQLCon.Open()

            mcheck = SQLCmd.ExecuteNonQuery()
            SQLCon.Close()

            If mcheck > 0 Then
                MsgBox("You have successfully created the System.")
                Return True
            Else
                MsgBox("You were unable To create the System, please make sure the spelling is correct in all fields.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Public Function mSysDelete(sn As String, model As String)
        Dim mcheck As Integer = 0
        Try
            Dim strDelete As String = "DELETE FROM Systems$ " &
                                      "WHERE [Serial Number] = @sn " &
                                      "AND [Model] = @model"
            SQLCmd = New SqlCommand(strDelete, SQLCon)

            SQLCmd.Parameters.AddWithValue("@sn", sn)
            SQLCmd.Parameters.AddWithValue("@model", model)

            'MsgBox(strDelete)

            SQLCon.Open()
            mcheck = SQLCmd.ExecuteNonQuery()
            SQLCon.Close()
            If mcheck > 0 Then
                MsgBox("You have successfully deleted the System.")
                Return True
            Else
                MsgBox("You were unable to delete the System, please make sure the spelling is correct in all fields.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If SQLCon.State = ConnectionState.Open Then
            SQLCon.Close()
            MsgBox("Connection was forcibly closed.")
        End If
        Return False
    End Function

    'MANAGER CONTROLS FOR DOCKS$ TABLE
    Public Function mDkInsert(dSn As String, dTno As String, dShip As Date, sNt As String)
        Dim mcheck As Integer = 0
        Try
            Dim strInsert As String = "INSERT INTO Docks ([Dock Serial],TrackingNo,[Date Shipped], Notes) " &
                                      "VALUES (" &
                                      "'" & dSn & "'," &
                                      "'" & dTno & "'," &
                                      "'" & dShip & "'," &
                                      "'" & sNt & "')"
            'MsgBox(strInsert)

            SQLCon.Open()
            SQLCmd = New SqlCommand(strInsert, SQLCon)
            mcheck = SQLCmd.ExecuteNonQuery()
            SQLCon.Close()
            If mcheck > 0 Then
                Return True
            Else
                MsgBox("You were unable to triage the selected Dock.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If SQLCon.State = ConnectionState.Open Then
            SQLCon.Close()
            MsgBox("Connection was forcibly closed.")
        End If
        Return False
    End Function
End Class
