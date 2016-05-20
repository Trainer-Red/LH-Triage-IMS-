'Edited by Robert 4/29 - fixed null exception in export
Imports Excel = Microsoft.Office.Interop.Excel

Public Class triageWindow
    Dim SQL As New SQL_Control
    Dim problem As String
    Dim substr As String()
    Dim maxlines As Integer = 20

    Private Sub triage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            caseID.Select()
            status.SelectedIndex = 0
            'Array.Resize(caseID.Lines, 20)
            'Array.Resize(Sn.Lines, 20)
            'Array.Resize(sNa.Lines, 20)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'SETS INITIAL FOCUS 
    Private Sub Tabs_SelectedIndexChanged(sender As Object, e As EventArgs) _
     Handles Tabs.SelectedIndexChanged
        If Tabs.SelectedTab Is triagePg Then
            caseID.Select()
            status.SelectedIndex = 0
        End If
        If Tabs.SelectedTab Is updatePg Then
            updateID.Select()
            updateVal.SelectedIndex = 1
        End If
        If Tabs.SelectedTab Is searchPg Then
            svExecute.Enabled = False
        End If

    End Sub
    'TEXTBOX SIZE CONTROL LIMITED TO 20 LINES
    Private Sub caseID_TextChanged(sender As Object, e As EventArgs) Handles caseID.TextChanged
        Try
            If (caseID.Lines.Length > maxlines) Then
                caseID.Undo()
                caseID.ClearUndo()
                MessageBox.Show("Only " & maxlines & " lines are allowed.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Sn_TextChanged(sender As Object, e As EventArgs) Handles Sn.TextChanged
        Try
            If (Sn.Lines.Length > maxlines) Then
                Sn.Undo()
                Sn.ClearUndo()
                MessageBox.Show("Only " & maxlines & " lines are allowed.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub sNa_TextChanged(sender As Object, e As EventArgs) Handles sNa.TextChanged
        Try
            If (sNa.Lines.Length > maxlines) Then
                sNa.Undo()
                sNa.ClearUndo()
                MessageBox.Show("Only " & maxlines & " lines are allowed.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '   FORM RESET COMMANDS
    '   clear all text boxes within a specified tab
    Public Sub clearTextBox(parent As Control)

        For Each child As Control In parent.Controls
            clearTextBox(child)
        Next
        ' trycast will cast the control object as a textbox, if it cannot it will return NULL
        If TryCast(parent, TextBox) IsNot Nothing Then
            TryCast(parent, TextBox).Text = [String].Empty
        End If

    End Sub

    '   CLEAR BUTTONS AND FIELDS
    Private Sub clearCheckBox(parent As Control)

        For Each child As Control In parent.Controls
            clearCheckBox(child)
        Next
        If TryCast(parent, CheckBox) IsNot Nothing Then
            TryCast(parent, CheckBox).Checked = False
        End If

    End Sub

    Private Sub clearRadio(parent As Control)

        For Each child As Control In parent.Controls
            clearRadio(child)
        Next
        If TryCast(parent, RadioButton) IsNot Nothing Then
            TryCast(parent, RadioButton).Checked = False
        End If
    End Sub

    Private Sub clearCombo(parent As Control)
        For Each child As Control In parent.Controls
            clearCombo(child)
        Next
        If TryCast(parent, ComboBox) IsNot Nothing Then
            TryCast(parent, ComboBox).Text = String.Empty
        End If
    End Sub

    'CONCATINATES SELECTED PROBLEMS INTO SINGLE STRING
    Public Sub sumProblem(parent As Control)

        For Each child As Control In parent.Controls
            sumProblem(child)
        Next
        ' trycast will cast the control object as a textbox, if it cannot it will return NULL
        If TryCast(parent, CheckBox) IsNot Nothing Then
            If TryCast(parent, CheckBox).Checked = True Then
                If TryCast(parent, CheckBox).Text <> "Attention" Then
                    problem = problem & TryCast(parent, CheckBox).Text & ". "
                End If
            End If
        End If

    End Sub

    'PRINT ROW NUMBERS ON DATAGRID
    Private Sub sDatagrid_RowPostPaint(ByVal sender As Object, ByVal e As DataGridViewRowPostPaintEventArgs) Handles sDatagrid.RowPostPaint

        Using b As SolidBrush = New SolidBrush(sDatagrid.RowHeadersDefaultCellStyle.ForeColor)
            e.Graphics.DrawString(e.RowIndex + 1.ToString(System.Globalization.CultureInfo.CurrentUICulture),
                                  sDatagrid.DefaultCellStyle.Font,
                                  b,
                                  e.RowBounds.Location.X + 20,
                                  e.RowBounds.Location.Y + 4)
        End Using
    End Sub

    Private Sub rDatagrid_RowPostPaint(ByVal sender As Object, ByVal e As DataGridViewRowPostPaintEventArgs) Handles rDatagrid.RowPostPaint

        Using b As SolidBrush = New SolidBrush(rDatagrid.RowHeadersDefaultCellStyle.ForeColor)
            e.Graphics.DrawString(e.RowIndex + 1.ToString(System.Globalization.CultureInfo.CurrentUICulture),
                                  rDatagrid.DefaultCellStyle.Font,
                                  b,
                                  e.RowBounds.Location.X + 20,
                                  e.RowBounds.Location.Y + 4)
        End Using
    End Sub

    'TRIAGE EXECUTION COMMAND 
    Private Sub Execute_click(sender As Object, e As EventArgs) Handles Execute.Click
        Dim triageCK As Boolean
        Dim tReturn As String
        'change to vector - 6/3
        Dim entries As Integer = 19
        Dim values As Integer = 3

        Dim bidarray(entries, values) As String

        If String.IsNullOrEmpty(Sn.Text) = True And String.IsNullOrEmpty(sNa.Text) = True Then
            MsgBox("You attempted to insert an empty ID. Please supply the querey with at least one ID.")
            'INSERT SELECTION FOR MISSING VALUE LOOKUP 8/13
        Else

            Dim scase As String() = bSplit(caseID.Text)
            Dim ssn As String() = bSplit(Sn.Text)
            Dim ssna As String() = bSplit(sNa.Text)
            Dim tno As String() = bSplit(trackingNo.Text)
            Try
                If String.IsNullOrWhiteSpace(sNa.Text) = True Then
                    For i As Integer = 0 To ssn.Length() - 1
                        tReturn = SQL.tSearch(ssn(i), True, False)
                        ssna(i) = tReturn
                        If tReturn = Nothing Then
                            MsgBox("Could not find a matching Student Name for the provided serial.")
                            Exit Sub
                        End If
                        MsgBox(tReturn)
                    Next
                ElseIf String.IsNullOrWhiteSpace(Sn.Text) = True Then
                    For i As Integer = 0 To ssna.Length() - 1
                        tReturn = SQL.tSearch(ssna(i), False, True)
                        ssn(i) = tReturn
                        If tReturn = Nothing Then
                            MsgBox("Could not find a matching Serial for the provided name.")
                            Exit Sub
                        End If
                        MsgBox(tReturn)
                    Next
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            'If scase.Length = ssn.Length And ssn.Length = tno.Length Then
            Try
                Dim inc As Integer = 0
                For i As Integer = 0 To ssn.Length() - 1
                    'MAX NUMBER OF VALUES IN ARRAY = 20 
                    bidarray(i, 0) = scase(i)
                    bidarray(i, 1) = ssn(i)
                    bidarray(i, 2) = ssna(i)
                    bidarray(i, 3) = tno(i)
                Next
                sumProblem(triagePg)
                If other.Text <> Nothing Then
                    problem = problem & other.Text
                End If
                Dim curdate As Date = Date.Now()
                curdate = curdate.ToString("d")

                For iteration As Integer = 0 To entries
                    If bidarray(iteration, 0) Is Nothing Then
                        Exit For
                    Else
                        triageCK = SQL.AddTriage(bidarray(iteration, 0), bidarray(iteration, 1), bidarray(iteration, 2), curdate, status.Text, problem, bidarray(iteration, 3), Notes.Text, attentionChk.CheckState)
                    End If
                Next
                If triageCK = True Then
                    MsgBox("You have successfully Triaged the selected claims.")
                    clearCheckBox(triagePg)
                    clearTextBox(triagePg)
                    problem = Nothing
                Else
                    MsgBox("The number of inputs do not match, Please double check your data.")
                End If
                ' End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    '   SPLIT TEXTBOX STRING INTO ARRAY OF STRINGS, DELIMIT ON NEWLINE 
    Private Function bSplit(batch As String)
        Dim substr As String() = Nothing
        Try
            substr = batch.Split(New String() {Environment.NewLine},
                   StringSplitOptions.None)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return substr
    End Function

    'OPTION SELECT CONTROLS FOR UPDATING ASSIGNMENTS
    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        clearTextBox(queryPg)
        clearCombo(queryPg)
        rDatagrid.DataSource = Nothing
    End Sub

    Private Sub uReplacecheck_CheckedChanged(sender As Object, e As EventArgs) Handles uReplacecheck.CheckedChanged
        uOldSn.Enabled = True
        uNewSn.Enabled = True
    End Sub

    Private Sub uTermcheck_CheckedChanged(sender As Object, e As EventArgs) Handles uTermcheck.CheckedChanged
        uOldSn.Enabled = True
        uNewSn.Enabled = False
    End Sub

    Private Sub uCreatecheck_CheckedChanged(sender As Object, e As EventArgs) Handles uCreatecheck.CheckedChanged
        uOldSn.Enabled = False
        uNewSn.Enabled = True
    End Sub

    Private Sub uExcecute_Click(sender As Object, e As EventArgs) Handles uExcecute.Click
        Dim uCheck As Boolean
        If updateID.Text <> "" Then
            If updateVal.Text <> "" Then
                Dim curdate As Date = Date.Now()
                curdate = curdate.ToString("d")
                uCheck = SQL.Update(updateID.Text, updateVal.Text, curdate)
            Else
                MsgBox("Please select a value to update.")
            End If
        Else
            MsgBox("Please provide a claim to update.")
        End If
        If uCheck = True Then
            'IF SUCCESSFUL UPDATE, CLEAN TEXTBOXES
            clearTextBox(updatePg)
        End If
    End Sub

    'USER ASSIGNMENT SUBMIT BUTTON
    Private Sub uAsgmtExecute_Click(sender As Object, e As EventArgs) Handles uAsgmtExecute.Click
        Dim check As Boolean
        If uAsgmtNa.Text <> "" Then
            If uReplacecheck.Checked = True Then
                If uOldSn.Text <> "" Then
                    If uNewSn.Text <> "" Then
                        check = SQL.Assignment(uAsgmtNa.Text, uOldSn.Text, uNewSn.Text, uDateEnd.Value, uDateStart.Value, uNotes.Text, True, False, False)
                    Else
                        MsgBox("Please provide the new serial number to replace.")
                    End If
                Else
                    MsgBox("Please Provide the old serial number to be replaced.")
                End If

            ElseIf uTermcheck.Checked = True Then
                If uOldSn.Text <> "" Then
                    check = SQL.Assignment(uAsgmtNa.Text, uOldSn.Text, uNewSn.Text, uDateEnd.Value, uDateStart.Value, uNotes.Text, False, True, False)
                Else
                    MsgBox("Please provide the old serial number.")
                End If
            ElseIf uCreatecheck.Checked = True Then
                If uNewSn.Text <> "" Then
                    check = SQL.Assignment(uAsgmtNa.Text, uOldSn.Text, uNewSn.Text, uDateEnd.Value, uDateStart.Value, uNotes.Text, False, False, True)
                Else
                    MsgBox("Please provide the new serial number.")
                End If
            Else
                MsgBox("Please select a assignment option.")
            End If
        Else
            MsgBox("Please provide a student name.")
        End If
        If check = True Then
            ' CLEAN VALUES
            clearTextBox(updatePg)
            clearRadio(updatePg)
        End If
    End Sub

    'DYNAMIC COMBO BOX OPTIONS
    Private Sub sTables_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sTables.SelectedIndexChanged
        If sTables.SelectedIndex = 0 Then
            sField.Enabled = True
            sField.Items.Clear()
            sField.Items.Add("[Claim Id]")
            sField.Items.Add("[Serial Number]")
            sField.Items.Add("[Student Name]")
            sField.Items.Add("[Date Filed]")
            sField.Items.Add("Status")
            sField.Items.Add("[Date Updated]")
            sField.Items.Add("Problem")
            sField.Items.Add("TrackingNo")
            sAtnChk.Enabled = True
        ElseIf sTables.SelectedIndex = 1 Then
            sField.Enabled = True
            sField.Items.Clear()
            sField.Items.Add("[Student Name]")
            sField.Items.Add("Hostname")
            sField.Items.Add("Grade")
        ElseIf sTables.SelectedIndex = 2 Then
            sField.Enabled = True
            sField.Items.Clear()
            sField.Items.Add("[Serial Number]")
            sField.Items.Add("[MAC Address]")
            sField.Items.Add("Model")
        ElseIf sTables.SelectedIndex = 3 Then
            sField.Enabled = True
            sField.Items.Clear()
            sField.Items.Add("[Student Name]")
            sField.Items.Add("[Serial Number]")
            sField.Items.Add("[Date Start]")
            sField.Items.Add("[Date End]")
            sField.Items.Add("Notes")
        ElseIf sTables.SelectedIndex = 4 Then
            sField.Enabled = True
            sField.Items.Clear()
            sField.Items.Add("[Dock Serial]")
            sField.Items.Add("[Date Shipped]")
            sField.Items.Add("TrackingNo")
            sField.Items.Add("Notes")
        End If
    End Sub

    'SEARCH FUNCTION
    Private Sub sExecute_Click(sender As Object, e As EventArgs) Handles sExecute.Click
        sDatagrid.DataSource = Nothing
        Dim sCheck As Boolean
        If sTables.Text <> "" Then
            If sField.Text <> "" Then
                If sSelection.Text <> "" Then
                    sCheck = SQL.Search(sField.Text, sTables.Text, sSelection.Text, sAtnChk.CheckState, False)
                    If SQL.SQLDataset.Tables.Count > 0 Then
                        sDatagrid.DataSource = SQL.SQLDataset.Tables(0)
                    End If
                Else
                    MsgBox("Please provide a value to search for.")
                End If
            Else
                MsgBox("Please select a field to search.")
            End If
        Else
            MsgBox("Please select a table to search within.")
        End If
        'If sCheck = True Then
        'CLEAN VALUES
        'clearTextBox(searchPg)
        If sTables.Text <> "Claims" Then
            Try
                'AUTO GENERATOR 
                SQL.SQLDA.UpdateCommand = New SqlClient.SqlCommandBuilder(SQL.SQLDA).GetUpdateCommand
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        'End If
    End Sub

    'EXECUTE A SEARCH OF ALL CLAIMS THAT ARE EITHER DEPOT OR PARTS ORDERD. 
    Private Sub sALLDepotExec_Click(sender As Object, e As EventArgs) Handles sALLDepotExec.Click

        sDatagrid.DataSource = Nothing
        Dim scheck As Boolean
        scheck = SQL.Search("Status", "Claims", "Depot", False, True)
        sTables.Text = "Claims"
        sField.Text = "Status"
        Try
            If SQL.SQLDataset.Tables.Count > 0 Then
                sDatagrid.DataSource = SQL.SQLDataset.Tables(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub sALLPoExec_Click(sender As Object, e As EventArgs) Handles sALLPoExec.Click

        sDatagrid.DataSource = Nothing
        Dim scheck As Boolean
        scheck = SQL.Search("Status", "Claims", "Part Ordered", False, True)
        sTables.Text = "Claims"
        sField.Text = "Status"
        Try
            If SQL.SQLDataset.Tables.Count > 0 Then
                sDatagrid.DataSource = SQL.SQLDataset.Tables(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub svExecute_Click(sender As Object, e As EventArgs) Handles svExecute.Click

        Dim saveChk As Boolean = False
        'CUSTOM QUEREY BECAUSE GLENN IS DUMB AND WANTS TO MERGE TABLES AND JUNK 8/18
        If sDatagrid.Columns(0).HeaderText = "Auto ID" Then
            'ONLY USE THIS IF ON TABLE CLAIMS -> CLAIMS IS JOINED WITH SYSTEM SO YOU CAN SEARCH MODELS.
            saveChk = SQL.paramSearch(sTables.Text, sField.Text, sSelection.Text)
            SQL.cellPos = 0
        Else
            'SAVE UPDATES FROM DATAVIEW GRID
            saveChk = SQL.SQLDA.Update(SQL.SQLDataset)
        End If

        'REFRESH GRID DATA
        sLoadGrid()

        If saveChk = True Then
            'DISABLE SAVE BUTTON
            svExecute.Enabled = False
        End If

    End Sub

    Private Sub sLoadGrid()
        If SQL.SQLDataset.Tables.Count > 0 Then
            sDatagrid.DataSource = SQL.SQLDataset.Tables(0)
        End If
    End Sub

    Private Sub sDatagrid_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles sDatagrid.CellValueChanged

        svExecute.Enabled = True
        Try
            SQL.changedCells(SQL.cellPos) = sDatagrid.Columns(sDatagrid.CurrentCell.ColumnIndex).HeaderText
            SQL.cellPos = SQL.cellPos + 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub dateSearch_Click(sender As Object, e As EventArgs) Handles dateSearch.Click

        Dim conDate As Integer = Convert.ToInt32(sDate.Text)
        If sDate.Text <> "" Then
            If radioDays.Checked = False And radioYears.Checked = False Then
                MsgBox("Please specify either Day or Year")
            Else
                If radioDays.Checked = True Then
                    SQL.checkDuration(conDate, radioDays.Text)
                Else
                    SQL.checkDuration(conDate, radioYears.Text)
                End If
            End If
        Else
            MsgBox("Please specify a length of time")
        End If
        If SQL.SQLDataset.Tables.Count > 0 Then
            sDatagrid.DataSource = SQL.SQLDataset.Tables(0)
        End If
    End Sub

    'EXPORT SEARCH DATAGRID TO EXCEL FILE
    Private Sub sExport_Click(sender As Object, ByVal e As EventArgs) Handles sExport.Click

        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")

        Try
            For i = 0 To sDatagrid.RowCount - 2
                For j = 0 To sDatagrid.ColumnCount - 1
                    For k As Integer = 1 To sDatagrid.Columns.Count
                        xlWorkSheet.Cells(1, k) = sDatagrid.Columns(k - 1).HeaderText
                        xlWorkSheet.Cells(i + 2, j + 1) = sDatagrid(j, i).Value.ToString()
                    Next
                Next
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            xlWorkSheet.SaveAs("\\chaminet.net\MIS$\#Laptop Hospital\VB_Exports\search_vbexcel.xlsx")
            xlWorkBook.Close()
            xlApp.Quit()

            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)

            MsgBox("You can find the file \\chaminet.net\MIS$\#Laptop Hospital\VB_Exports\search_vbexcel.xlsx")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub sClear_Click(sender As Object, e As EventArgs) Handles sClear.Click
        clearTextBox(searchPg)
        clearRadio(searchPg)
        clearCombo(searchPg)
        sDatagrid.DataSource = Nothing
    End Sub

    'EXPORT MANUAL QUERY DATAGRID TO EXCEL FILE
    Private Sub cmdExport_Click(sender As Object, e As EventArgs) Handles cmdExport.Click
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")

        Try
            For i = 0 To rDatagrid.RowCount - 2
                For j = 0 To rDatagrid.ColumnCount - 1
                    For k As Integer = 1 To rDatagrid.Columns.Count
                        xlWorkSheet.Cells(1, k) = rDatagrid.Columns(k - 1).HeaderText
                        xlWorkSheet.Cells(i + 2, j + 1) = rDatagrid(j, i).Value.ToString()
                    Next
                Next
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            xlWorkSheet.SaveAs("\\chaminet.net\MIS$\#Laptop Hospital\VB_Exports\search_vbexcel.xlsx")
            xlWorkBook.Close()
            xlApp.Quit()

            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        MsgBox("You can find the file \\chaminet.net\MIS$\#Laptop Hospital\VB_Exports\search_vbexcel.xlsx")
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub sField_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sField.SelectedIndexChanged
        If sTables.Text = "Claims" Then
            'VARIABLE OPTIONS FOR TABLE SELECTION IN COMBOBOX
        End If
    End Sub

    'MANUAL QUERY EXECUTE
    Private Sub cmdQuery_Click(sender As Object, e As EventArgs) Handles cmdQuery.Click
        If SQL.HasConnection = True Then
            SQL.RunQuery(txtQuery.Text)

            If SQL.SQLDataset.Tables.Count > 0 Then
                Try
                    rDatagrid.DataSource = SQL.SQLDataset.Tables(0)
                    SQL.SQLDA.UpdateCommand = New SqlClient.SqlCommandBuilder(SQL.SQLDA).GetUpdateCommand
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub rSave_Click(sender As Object, e As EventArgs) Handles rSave.Click
        Dim saveChk As Boolean = False
        Try
            saveChk = SQL.SQLDA.Update(SQL.SQLDataset)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If saveChk = True Then
            rSave.Enabled = False
        End If
    End Sub

    Private Sub rDatagrid_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles rDatagrid.CellValueChanged
        rSave.Enabled = True
    End Sub

    Private Sub mBinsertExec_Click(sender As Object, e As EventArgs) Handles mBinsertExec.Click
        Dim check As Boolean = False
        If mFileLoc.Text <> "" Then
            If mCombo.Text <> "" Then
                check = SQL.bulkInsert(mFileLoc.Text, mCombo.Text)
            End If
            If check = True Then
                clearTextBox(managerPg)
                clearCombo(managerPg)
            End If
        End If
    End Sub

    Private Sub mNewStuExec_Click(sender As Object, e As EventArgs) Handles mNewStuExec.Click
        Dim mcheck As Boolean = False
        If mStuNa.Text <> "" Then
            If mHostna.Text <> "" Then
                mcheck = SQL.mInsert(mStuNa.Text, mHostna.Text, mGradeCombo.Text)
                If mcheck = True Then
                    clearTextBox(managerPg)
                    clearCombo(managerPg)
                End If
            Else
                MsgBox("Please provide a hostname.")
            End If
        Else
            MsgBox("Please provide a student name.")
        End If
    End Sub

    Private Sub mStuDelExec_Click(sender As Object, e As EventArgs) Handles mStuDelExec.Click
        Dim mcheck As Boolean = False
        If mStuNa.Text <> "" Then
            If mHostna.Text <> "" Then
                Dim style = MsgBoxStyle.YesNo
                Dim response = MsgBox("Are you sure you want to delete this student?", style, "WAIT!")
                If response = MsgBoxResult.Yes Then
                    mcheck = SQL.mDelete(mStuNa.Text, mHostna.Text, mGradeCombo.Text)
                End If
                If mcheck = True Then
                    clearTextBox(managerPg)
                    clearCombo(managerPg)
                End If
            Else
                MsgBox("Please provide a hostname.")
            End If
        Else
            MsgBox("Please provide a student name.")
        End If

    End Sub

    Private Sub mDockExec_Click(sender As Object, e As EventArgs) Handles mDockExec.Click
        Dim mcheck As Boolean = False

        If mDkSN.Text <> "" Then
            If mDkTno.Text <> "" Then
                Dim dockstr() As String = bSplit(mDkSN.Text)
                For i As Integer = 0 To dockstr.Length - 1
                    If dockstr(i) <> "" Then
                        mcheck = SQL.mDkInsert(dockstr(i), mDkTno.Text, mDkDateS.Value, mDkNotes.Text)
                    Else
                        Exit For
                    End If
                Next
                If mcheck = True Then
                    MsgBox("You have successfully triaged a new Dock.")
                    clearTextBox(managerPg)
                    clearCheckBox(managerPg)
                End If
            Else
                MsgBox("Please provide a tracking number.")
            End If
        Else
            MsgBox("Please provide a dock serial.")
        End If

    End Sub

    Private Sub sAsgtExec_Click(sender As Object, e As EventArgs) Handles sAsgtExec.Click
        sDatagrid.DataSource = Nothing
        Dim mcheck As Boolean = False
        If sSNAsgt.Text <> "" Then
            SQL.RunQuery("SELECT Assignments$.[Student Name], [Hostname], Assignments$.[Serial Number] FROM Assignments$ INNER JOIN Students$ ON Assignments$.[Student Name] = Students$.[Student Name] WHERE Assignments$.[Student Name] LIKE '%" & sSNAsgt.Text & "%'")
        End If
        If SQL.SQLDataset.Tables.Count > 0 Then
            sDatagrid.DataSource = SQL.SQLDataset.Tables(0)
        End If
    End Sub

    Private Sub mSysExec_Click(sender As Object, e As EventArgs) Handles mSysExec.Click
        Dim mcheck As Boolean = False
        If mSysSN.Text <> "" Then
            If mSysModel.Text <> "" Then
                mcheck = SQL.mSysInsert(mSysSN.Text, mSysMac.Text, mSysModel.Text)
                If mcheck = True Then
                    clearTextBox(managerPg)
                    clearCombo(managerPg)
                End If
            Else
                MsgBox("Please provide a System Model.")
            End If
        Else
            MsgBox("Please provide a Serial Number.")
        End If
    End Sub

    Private Sub mSysDelExec_Click(sender As Object, e As EventArgs) Handles mSysDelExec.Click
        Dim mcheck As Boolean = False
        If mSysSN.Text <> "" Then
            If mSysModel.Text <> "" Then
                mcheck = SQL.mSysDelete(mSysSN.Text, mSysModel.Text)
                If mcheck = True Then
                    clearTextBox(managerPg)
                    clearCombo(managerPg)
                End If
            Else
                MsgBox("Please provide a System Model.")
            End If
        Else
            MsgBox("Please provide a Serial Number.")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        SQL.HasConnection()
    End Sub
End Class
