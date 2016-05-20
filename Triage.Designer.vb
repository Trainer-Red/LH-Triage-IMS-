<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class triageWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(triageWindow))
        Me.queryPg = New System.Windows.Forms.TabPage()
        Me.rSave = New System.Windows.Forms.Button()
        Me.cmdExport = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.rDatagrid = New System.Windows.Forms.DataGridView()
        Me.cmdQuery = New System.Windows.Forms.Button()
        Me.txtQuery = New System.Windows.Forms.TextBox()
        Me.triagePg = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.attentionChk = New System.Windows.Forms.CheckBox()
        Me.mobo = New System.Windows.Forms.CheckBox()
        Me.LabelProblem = New System.Windows.Forms.Label()
        Me.pwr = New System.Windows.Forms.CheckBox()
        Me.audio = New System.Windows.Forms.CheckBox()
        Me.fan = New System.Windows.Forms.CheckBox()
        Me.wifi = New System.Windows.Forms.CheckBox()
        Me.fDigi = New System.Windows.Forms.CheckBox()
        Me.ssd = New System.Windows.Forms.CheckBox()
        Me.dLCD = New System.Windows.Forms.CheckBox()
        Me.cLCD = New System.Windows.Forms.CheckBox()
        Me.other = New System.Windows.Forms.TextBox()
        Me.labelTrack = New System.Windows.Forms.Label()
        Me.trackingNo = New System.Windows.Forms.TextBox()
        Me.statLabel = New System.Windows.Forms.Label()
        Me.status = New System.Windows.Forms.ComboBox()
        Me.Execute = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelSN = New System.Windows.Forms.Label()
        Me.sNa = New System.Windows.Forms.TextBox()
        Me.Sn = New System.Windows.Forms.TextBox()
        Me.Notes = New System.Windows.Forms.TextBox()
        Me.caseID = New System.Windows.Forms.TextBox()
        Me.LabelSNo = New System.Windows.Forms.Label()
        Me.LabelcID = New System.Windows.Forms.Label()
        Me.Tabs = New System.Windows.Forms.TabControl()
        Me.updatePg = New System.Windows.Forms.TabPage()
        Me.gUpdateasgmt = New System.Windows.Forms.GroupBox()
        Me.Labelunotes = New System.Windows.Forms.Label()
        Me.uNotes = New System.Windows.Forms.TextBox()
        Me.uCreatecheck = New System.Windows.Forms.RadioButton()
        Me.uTermcheck = New System.Windows.Forms.RadioButton()
        Me.uReplacecheck = New System.Windows.Forms.RadioButton()
        Me.uAsgmtExecute = New System.Windows.Forms.Button()
        Me.LabeluDateStart = New System.Windows.Forms.Label()
        Me.LabeluDateEnd = New System.Windows.Forms.Label()
        Me.uDateStart = New System.Windows.Forms.DateTimePicker()
        Me.uDateEnd = New System.Windows.Forms.DateTimePicker()
        Me.LabelNewSerial = New System.Windows.Forms.Label()
        Me.LabelOldSerial = New System.Windows.Forms.Label()
        Me.uNewSn = New System.Windows.Forms.TextBox()
        Me.uOldSn = New System.Windows.Forms.TextBox()
        Me.LabelsNa = New System.Windows.Forms.Label()
        Me.uAsgmtNa = New System.Windows.Forms.TextBox()
        Me.cUpdategrp = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.updateVal = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.uExcecute = New System.Windows.Forms.Button()
        Me.updateID = New System.Windows.Forms.TextBox()
        Me.searchPg = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.sAsgtExec = New System.Windows.Forms.Button()
        Me.LabelSNaAsgt = New System.Windows.Forms.Label()
        Me.sSNAsgt = New System.Windows.Forms.TextBox()
        Me.sALLSearchGroupBox = New System.Windows.Forms.GroupBox()
        Me.sALLDepotExec = New System.Windows.Forms.Button()
        Me.sALLPoExec = New System.Windows.Forms.Button()
        Me.sAtnChk = New System.Windows.Forms.CheckBox()
        Me.svExecute = New System.Windows.Forms.Button()
        Me.sExport = New System.Windows.Forms.Button()
        Me.sClear = New System.Windows.Forms.Button()
        Me.radioYears = New System.Windows.Forms.RadioButton()
        Me.radioDays = New System.Windows.Forms.RadioButton()
        Me.sDate = New System.Windows.Forms.TextBox()
        Me.dateSearch = New System.Windows.Forms.Button()
        Me.labelField = New System.Windows.Forms.Label()
        Me.sField = New System.Windows.Forms.ComboBox()
        Me.sSelection = New System.Windows.Forms.TextBox()
        Me.sExecute = New System.Windows.Forms.Button()
        Me.labelSelect = New System.Windows.Forms.Label()
        Me.labelTables = New System.Windows.Forms.Label()
        Me.sTables = New System.Windows.Forms.ComboBox()
        Me.sDatagrid = New System.Windows.Forms.DataGridView()
        Me.managerPg = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.mSysDelExec = New System.Windows.Forms.Button()
        Me.mSysExec = New System.Windows.Forms.Button()
        Me.mModelLabel = New System.Windows.Forms.Label()
        Me.mMACLabel = New System.Windows.Forms.Label()
        Me.mSysSNLabel = New System.Windows.Forms.Label()
        Me.mSysModel = New System.Windows.Forms.ComboBox()
        Me.mSysMac = New System.Windows.Forms.TextBox()
        Me.mSysSN = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mDkNoteLabel = New System.Windows.Forms.Label()
        Me.mDkNotes = New System.Windows.Forms.TextBox()
        Me.mDockExec = New System.Windows.Forms.Button()
        Me.mDkDateS = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mDkTno = New System.Windows.Forms.TextBox()
        Me.mDkSN = New System.Windows.Forms.TextBox()
        Me.mStuGrp = New System.Windows.Forms.GroupBox()
        Me.mStuDelExec = New System.Windows.Forms.Button()
        Me.mNewStuExec = New System.Windows.Forms.Button()
        Me.mGradeLabel = New System.Windows.Forms.Label()
        Me.mGradeCombo = New System.Windows.Forms.ComboBox()
        Me.mHnaLabel = New System.Windows.Forms.Label()
        Me.mNewSnaLabel = New System.Windows.Forms.Label()
        Me.mHostna = New System.Windows.Forms.TextBox()
        Me.mStuNa = New System.Windows.Forms.TextBox()
        Me.mBulkGroup = New System.Windows.Forms.GroupBox()
        Me.mBinsertExec = New System.Windows.Forms.Button()
        Me.mLabelCombo = New System.Windows.Forms.Label()
        Me.mCombo = New System.Windows.Forms.ComboBox()
        Me.LabelFileLoc = New System.Windows.Forms.Label()
        Me.mFileLoc = New System.Windows.Forms.TextBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.queryPg.SuspendLayout()
        CType(Me.rDatagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.triagePg.SuspendLayout()
        Me.Tabs.SuspendLayout()
        Me.updatePg.SuspendLayout()
        Me.gUpdateasgmt.SuspendLayout()
        Me.cUpdategrp.SuspendLayout()
        Me.searchPg.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.sALLSearchGroupBox.SuspendLayout()
        CType(Me.sDatagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.managerPg.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.mStuGrp.SuspendLayout()
        Me.mBulkGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'queryPg
        '
        Me.queryPg.Controls.Add(Me.rSave)
        Me.queryPg.Controls.Add(Me.cmdExport)
        Me.queryPg.Controls.Add(Me.cmdClear)
        Me.queryPg.Controls.Add(Me.rDatagrid)
        Me.queryPg.Controls.Add(Me.cmdQuery)
        Me.queryPg.Controls.Add(Me.txtQuery)
        Me.queryPg.Location = New System.Drawing.Point(4, 22)
        Me.queryPg.Name = "queryPg"
        Me.queryPg.Padding = New System.Windows.Forms.Padding(3)
        Me.queryPg.Size = New System.Drawing.Size(1304, 603)
        Me.queryPg.TabIndex = 1
        Me.queryPg.Text = "Run Query"
        Me.queryPg.UseVisualStyleBackColor = True
        '
        'rSave
        '
        Me.rSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rSave.Enabled = False
        Me.rSave.Location = New System.Drawing.Point(1158, 535)
        Me.rSave.Name = "rSave"
        Me.rSave.Size = New System.Drawing.Size(75, 23)
        Me.rSave.TabIndex = 5
        Me.rSave.Text = "Save"
        Me.rSave.UseVisualStyleBackColor = True
        '
        'cmdExport
        '
        Me.cmdExport.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdExport.Location = New System.Drawing.Point(581, 565)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(85, 23)
        Me.cmdExport.TabIndex = 4
        Me.cmdExport.Text = "Export"
        Me.cmdExport.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdClear.Location = New System.Drawing.Point(581, 535)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(85, 24)
        Me.cmdClear.TabIndex = 3
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'rDatagrid
        '
        Me.rDatagrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.rDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.rDatagrid.Location = New System.Drawing.Point(7, 120)
        Me.rDatagrid.Name = "rDatagrid"
        Me.rDatagrid.Size = New System.Drawing.Size(1226, 409)
        Me.rDatagrid.TabIndex = 2
        '
        'cmdQuery
        '
        Me.cmdQuery.Location = New System.Drawing.Point(240, 24)
        Me.cmdQuery.Name = "cmdQuery"
        Me.cmdQuery.Size = New System.Drawing.Size(85, 27)
        Me.cmdQuery.TabIndex = 1
        Me.cmdQuery.Text = "Run Query"
        Me.cmdQuery.UseVisualStyleBackColor = True
        '
        'txtQuery
        '
        Me.txtQuery.Location = New System.Drawing.Point(7, 24)
        Me.txtQuery.Multiline = True
        Me.txtQuery.Name = "txtQuery"
        Me.txtQuery.Size = New System.Drawing.Size(224, 90)
        Me.txtQuery.TabIndex = 0
        '
        'triagePg
        '
        Me.triagePg.Controls.Add(Me.Label8)
        Me.triagePg.Controls.Add(Me.attentionChk)
        Me.triagePg.Controls.Add(Me.mobo)
        Me.triagePg.Controls.Add(Me.LabelProblem)
        Me.triagePg.Controls.Add(Me.pwr)
        Me.triagePg.Controls.Add(Me.audio)
        Me.triagePg.Controls.Add(Me.fan)
        Me.triagePg.Controls.Add(Me.wifi)
        Me.triagePg.Controls.Add(Me.fDigi)
        Me.triagePg.Controls.Add(Me.ssd)
        Me.triagePg.Controls.Add(Me.dLCD)
        Me.triagePg.Controls.Add(Me.cLCD)
        Me.triagePg.Controls.Add(Me.other)
        Me.triagePg.Controls.Add(Me.labelTrack)
        Me.triagePg.Controls.Add(Me.trackingNo)
        Me.triagePg.Controls.Add(Me.statLabel)
        Me.triagePg.Controls.Add(Me.status)
        Me.triagePg.Controls.Add(Me.Execute)
        Me.triagePg.Controls.Add(Me.Label6)
        Me.triagePg.Controls.Add(Me.LabelSN)
        Me.triagePg.Controls.Add(Me.sNa)
        Me.triagePg.Controls.Add(Me.Sn)
        Me.triagePg.Controls.Add(Me.Notes)
        Me.triagePg.Controls.Add(Me.caseID)
        Me.triagePg.Controls.Add(Me.LabelSNo)
        Me.triagePg.Controls.Add(Me.LabelcID)
        Me.triagePg.Location = New System.Drawing.Point(4, 22)
        Me.triagePg.Name = "triagePg"
        Me.triagePg.Padding = New System.Windows.Forms.Padding(3)
        Me.triagePg.Size = New System.Drawing.Size(1304, 603)
        Me.triagePg.TabIndex = 0
        Me.triagePg.Text = "Triage"
        Me.triagePg.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(649, 212)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Other"
        '
        'attentionChk
        '
        Me.attentionChk.Appearance = System.Windows.Forms.Appearance.Button
        Me.attentionChk.AutoSize = True
        Me.attentionChk.Location = New System.Drawing.Point(721, 212)
        Me.attentionChk.Name = "attentionChk"
        Me.attentionChk.Size = New System.Drawing.Size(59, 23)
        Me.attentionChk.TabIndex = 60
        Me.attentionChk.Text = "Attention"
        Me.attentionChk.UseVisualStyleBackColor = True
        '
        'mobo
        '
        Me.mobo.AutoSize = True
        Me.mobo.Location = New System.Drawing.Point(338, 254)
        Me.mobo.Name = "mobo"
        Me.mobo.Size = New System.Drawing.Size(115, 17)
        Me.mobo.TabIndex = 15
        Me.mobo.Text = "Motherboard/RAM"
        Me.mobo.UseVisualStyleBackColor = True
        '
        'LabelProblem
        '
        Me.LabelProblem.AutoSize = True
        Me.LabelProblem.Location = New System.Drawing.Point(11, 276)
        Me.LabelProblem.Name = "LabelProblem"
        Me.LabelProblem.Size = New System.Drawing.Size(50, 13)
        Me.LabelProblem.TabIndex = 58
        Me.LabelProblem.Text = "Problems"
        '
        'pwr
        '
        Me.pwr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pwr.AutoSize = True
        Me.pwr.Location = New System.Drawing.Point(338, 231)
        Me.pwr.Name = "pwr"
        Me.pwr.Size = New System.Drawing.Size(73, 17)
        Me.pwr.TabIndex = 13
        Me.pwr.Text = "No Power"
        Me.pwr.UseVisualStyleBackColor = True
        '
        'audio
        '
        Me.audio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.audio.AutoSize = True
        Me.audio.Location = New System.Drawing.Point(190, 254)
        Me.audio.Name = "audio"
        Me.audio.Size = New System.Drawing.Size(133, 17)
        Me.audio.TabIndex = 11
        Me.audio.Text = "Audio Cable/Speakers"
        Me.audio.UseVisualStyleBackColor = True
        '
        'fan
        '
        Me.fan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fan.AutoSize = True
        Me.fan.Location = New System.Drawing.Point(338, 207)
        Me.fan.Name = "fan"
        Me.fan.Size = New System.Drawing.Size(69, 17)
        Me.fan.TabIndex = 12
        Me.fan.Text = "Fan Error"
        Me.fan.UseVisualStyleBackColor = True
        '
        'wifi
        '
        Me.wifi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.wifi.AutoSize = True
        Me.wifi.Location = New System.Drawing.Point(190, 231)
        Me.wifi.Name = "wifi"
        Me.wifi.Size = New System.Drawing.Size(118, 17)
        Me.wifi.TabIndex = 10
        Me.wifi.Text = "Defective Wifi Card"
        Me.wifi.UseVisualStyleBackColor = True
        '
        'fDigi
        '
        Me.fDigi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fDigi.AutoSize = True
        Me.fDigi.Location = New System.Drawing.Point(190, 208)
        Me.fDigi.Name = "fDigi"
        Me.fDigi.Size = New System.Drawing.Size(139, 17)
        Me.fDigi.TabIndex = 9
        Me.fDigi.Text = "Defective Digitizer/ESD"
        Me.fDigi.UseVisualStyleBackColor = True
        '
        'ssd
        '
        Me.ssd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ssd.AutoSize = True
        Me.ssd.Location = New System.Drawing.Point(14, 256)
        Me.ssd.Name = "ssd"
        Me.ssd.Size = New System.Drawing.Size(97, 17)
        Me.ssd.TabIndex = 8
        Me.ssd.Text = "Defective SSD"
        Me.ssd.UseVisualStyleBackColor = True
        '
        'dLCD
        '
        Me.dLCD.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dLCD.AutoSize = True
        Me.dLCD.Location = New System.Drawing.Point(14, 232)
        Me.dLCD.Name = "dLCD"
        Me.dLCD.Size = New System.Drawing.Size(128, 17)
        Me.dLCD.TabIndex = 7
        Me.dLCD.Text = "Defective LCD/Cable"
        Me.dLCD.UseVisualStyleBackColor = True
        '
        'cLCD
        '
        Me.cLCD.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cLCD.AutoSize = True
        Me.cLCD.Location = New System.Drawing.Point(14, 208)
        Me.cLCD.Name = "cLCD"
        Me.cLCD.Size = New System.Drawing.Size(177, 17)
        Me.cLCD.TabIndex = 6
        Me.cLCD.Text = "Cracked LCD/Physical Damage"
        Me.cLCD.UseVisualStyleBackColor = True
        '
        'other
        '
        Me.other.Location = New System.Drawing.Point(466, 208)
        Me.other.Name = "other"
        Me.other.Size = New System.Drawing.Size(177, 20)
        Me.other.TabIndex = 14
        '
        'labelTrack
        '
        Me.labelTrack.AutoSize = True
        Me.labelTrack.Location = New System.Drawing.Point(718, 144)
        Me.labelTrack.Name = "labelTrack"
        Me.labelTrack.Size = New System.Drawing.Size(89, 13)
        Me.labelTrack.TabIndex = 48
        Me.labelTrack.Text = "Tracking Number"
        '
        'trackingNo
        '
        Me.trackingNo.Location = New System.Drawing.Point(721, 28)
        Me.trackingNo.Multiline = True
        Me.trackingNo.Name = "trackingNo"
        Me.trackingNo.Size = New System.Drawing.Size(178, 113)
        Me.trackingNo.TabIndex = 5
        '
        'statLabel
        '
        Me.statLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.statLabel.AutoSize = True
        Me.statLabel.Location = New System.Drawing.Point(575, 52)
        Me.statLabel.Name = "statLabel"
        Me.statLabel.Size = New System.Drawing.Size(37, 13)
        Me.statLabel.TabIndex = 45
        Me.statLabel.Text = "Status"
        '
        'status
        '
        Me.status.FormattingEnabled = True
        Me.status.Items.AddRange(New Object() {"Depot", "Completed", "Part Ordered", "Never Came In", "Engineering", "Back Ordered ", "Replacement", "HOLD"})
        Me.status.Location = New System.Drawing.Point(578, 28)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(125, 21)
        Me.status.TabIndex = 3
        '
        'Execute
        '
        Me.Execute.Location = New System.Drawing.Point(578, 361)
        Me.Execute.Name = "Execute"
        Me.Execute.Size = New System.Drawing.Size(181, 51)
        Me.Execute.TabIndex = 20
        Me.Execute.Text = "Submit Entry"
        Me.Execute.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 415)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Notes"
        '
        'LabelSN
        '
        Me.LabelSN.AutoSize = True
        Me.LabelSN.Location = New System.Drawing.Point(389, 141)
        Me.LabelSN.Name = "LabelSN"
        Me.LabelSN.Size = New System.Drawing.Size(75, 13)
        Me.LabelSN.TabIndex = 24
        Me.LabelSN.Text = "Student Name"
        '
        'sNa
        '
        Me.sNa.Location = New System.Drawing.Point(392, 28)
        Me.sNa.Multiline = True
        Me.sNa.Name = "sNa"
        Me.sNa.Size = New System.Drawing.Size(169, 113)
        Me.sNa.TabIndex = 2
        '
        'Sn
        '
        Me.Sn.Location = New System.Drawing.Point(196, 28)
        Me.Sn.Multiline = True
        Me.Sn.Name = "Sn"
        Me.Sn.Size = New System.Drawing.Size(178, 113)
        Me.Sn.TabIndex = 1
        '
        'Notes
        '
        Me.Notes.Location = New System.Drawing.Point(14, 324)
        Me.Notes.Multiline = True
        Me.Notes.Name = "Notes"
        Me.Notes.Size = New System.Drawing.Size(547, 88)
        Me.Notes.TabIndex = 17
        '
        'caseID
        '
        Me.caseID.Location = New System.Drawing.Point(14, 28)
        Me.caseID.Multiline = True
        Me.caseID.Name = "caseID"
        Me.caseID.Size = New System.Drawing.Size(169, 113)
        Me.caseID.TabIndex = 0
        '
        'LabelSNo
        '
        Me.LabelSNo.AutoSize = True
        Me.LabelSNo.Location = New System.Drawing.Point(199, 141)
        Me.LabelSNo.Name = "LabelSNo"
        Me.LabelSNo.Size = New System.Drawing.Size(73, 13)
        Me.LabelSNo.TabIndex = 20
        Me.LabelSNo.Text = "Serial Number"
        '
        'LabelcID
        '
        Me.LabelcID.AutoSize = True
        Me.LabelcID.Location = New System.Drawing.Point(11, 141)
        Me.LabelcID.Name = "LabelcID"
        Me.LabelcID.Size = New System.Drawing.Size(45, 13)
        Me.LabelcID.TabIndex = 19
        Me.LabelcID.Text = "Case ID"
        '
        'Tabs
        '
        Me.Tabs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tabs.Controls.Add(Me.triagePg)
        Me.Tabs.Controls.Add(Me.updatePg)
        Me.Tabs.Controls.Add(Me.searchPg)
        Me.Tabs.Controls.Add(Me.managerPg)
        Me.Tabs.Controls.Add(Me.queryPg)
        Me.Tabs.Location = New System.Drawing.Point(12, 19)
        Me.Tabs.Name = "Tabs"
        Me.Tabs.SelectedIndex = 0
        Me.Tabs.Size = New System.Drawing.Size(1312, 629)
        Me.Tabs.TabIndex = 15
        '
        'updatePg
        '
        Me.updatePg.Controls.Add(Me.gUpdateasgmt)
        Me.updatePg.Controls.Add(Me.cUpdategrp)
        Me.updatePg.Location = New System.Drawing.Point(4, 22)
        Me.updatePg.Name = "updatePg"
        Me.updatePg.Size = New System.Drawing.Size(1304, 603)
        Me.updatePg.TabIndex = 2
        Me.updatePg.Text = "Update"
        Me.updatePg.UseVisualStyleBackColor = True
        '
        'gUpdateasgmt
        '
        Me.gUpdateasgmt.Controls.Add(Me.Labelunotes)
        Me.gUpdateasgmt.Controls.Add(Me.uNotes)
        Me.gUpdateasgmt.Controls.Add(Me.uCreatecheck)
        Me.gUpdateasgmt.Controls.Add(Me.uTermcheck)
        Me.gUpdateasgmt.Controls.Add(Me.uReplacecheck)
        Me.gUpdateasgmt.Controls.Add(Me.uAsgmtExecute)
        Me.gUpdateasgmt.Controls.Add(Me.LabeluDateStart)
        Me.gUpdateasgmt.Controls.Add(Me.LabeluDateEnd)
        Me.gUpdateasgmt.Controls.Add(Me.uDateStart)
        Me.gUpdateasgmt.Controls.Add(Me.uDateEnd)
        Me.gUpdateasgmt.Controls.Add(Me.LabelNewSerial)
        Me.gUpdateasgmt.Controls.Add(Me.LabelOldSerial)
        Me.gUpdateasgmt.Controls.Add(Me.uNewSn)
        Me.gUpdateasgmt.Controls.Add(Me.uOldSn)
        Me.gUpdateasgmt.Controls.Add(Me.LabelsNa)
        Me.gUpdateasgmt.Controls.Add(Me.uAsgmtNa)
        Me.gUpdateasgmt.Location = New System.Drawing.Point(14, 110)
        Me.gUpdateasgmt.Name = "gUpdateasgmt"
        Me.gUpdateasgmt.Size = New System.Drawing.Size(545, 229)
        Me.gUpdateasgmt.TabIndex = 8
        Me.gUpdateasgmt.TabStop = False
        Me.gUpdateasgmt.Text = "Update Assignment"
        '
        'Labelunotes
        '
        Me.Labelunotes.AutoSize = True
        Me.Labelunotes.Location = New System.Drawing.Point(10, 165)
        Me.Labelunotes.Name = "Labelunotes"
        Me.Labelunotes.Size = New System.Drawing.Size(35, 13)
        Me.Labelunotes.TabIndex = 13
        Me.Labelunotes.Text = "Notes"
        '
        'uNotes
        '
        Me.uNotes.Location = New System.Drawing.Point(7, 142)
        Me.uNotes.Name = "uNotes"
        Me.uNotes.Size = New System.Drawing.Size(404, 20)
        Me.uNotes.TabIndex = 11
        '
        'uCreatecheck
        '
        Me.uCreatecheck.AutoSize = True
        Me.uCreatecheck.Location = New System.Drawing.Point(404, 31)
        Me.uCreatecheck.Name = "uCreatecheck"
        Me.uCreatecheck.Size = New System.Drawing.Size(113, 17)
        Me.uCreatecheck.TabIndex = 5
        Me.uCreatecheck.TabStop = True
        Me.uCreatecheck.Text = "Create Assignment"
        Me.uCreatecheck.UseVisualStyleBackColor = True
        '
        'uTermcheck
        '
        Me.uTermcheck.AutoSize = True
        Me.uTermcheck.Location = New System.Drawing.Point(205, 31)
        Me.uTermcheck.Name = "uTermcheck"
        Me.uTermcheck.Size = New System.Drawing.Size(129, 17)
        Me.uTermcheck.TabIndex = 4
        Me.uTermcheck.TabStop = True
        Me.uTermcheck.Text = "Terminate Assignment"
        Me.uTermcheck.UseVisualStyleBackColor = True
        '
        'uReplacecheck
        '
        Me.uReplacecheck.AutoSize = True
        Me.uReplacecheck.Location = New System.Drawing.Point(9, 31)
        Me.uReplacecheck.Name = "uReplacecheck"
        Me.uReplacecheck.Size = New System.Drawing.Size(122, 17)
        Me.uReplacecheck.TabIndex = 3
        Me.uReplacecheck.TabStop = True
        Me.uReplacecheck.Text = "Replace Assignment"
        Me.uReplacecheck.UseVisualStyleBackColor = True
        '
        'uAsgmtExecute
        '
        Me.uAsgmtExecute.Location = New System.Drawing.Point(422, 191)
        Me.uAsgmtExecute.Name = "uAsgmtExecute"
        Me.uAsgmtExecute.Size = New System.Drawing.Size(109, 23)
        Me.uAsgmtExecute.TabIndex = 12
        Me.uAsgmtExecute.Text = "Submit Update"
        Me.uAsgmtExecute.UseVisualStyleBackColor = True
        '
        'LabeluDateStart
        '
        Me.LabeluDateStart.AutoSize = True
        Me.LabeluDateStart.Location = New System.Drawing.Point(416, 126)
        Me.LabeluDateStart.Name = "LabeluDateStart"
        Me.LabeluDateStart.Size = New System.Drawing.Size(55, 13)
        Me.LabeluDateStart.TabIndex = 10
        Me.LabeluDateStart.Text = "Date Start"
        '
        'LabeluDateEnd
        '
        Me.LabeluDateEnd.AutoSize = True
        Me.LabeluDateEnd.Location = New System.Drawing.Point(154, 126)
        Me.LabeluDateEnd.Name = "LabeluDateEnd"
        Me.LabeluDateEnd.Size = New System.Drawing.Size(52, 13)
        Me.LabeluDateEnd.TabIndex = 9
        Me.LabeluDateEnd.Text = "Date End"
        '
        'uDateStart
        '
        Me.uDateStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.uDateStart.Location = New System.Drawing.Point(419, 103)
        Me.uDateStart.Name = "uDateStart"
        Me.uDateStart.Size = New System.Drawing.Size(98, 20)
        Me.uDateStart.TabIndex = 10
        Me.uDateStart.Value = New Date(2015, 7, 22, 17, 5, 21, 0)
        '
        'uDateEnd
        '
        Me.uDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.uDateEnd.Location = New System.Drawing.Point(157, 103)
        Me.uDateEnd.Name = "uDateEnd"
        Me.uDateEnd.Size = New System.Drawing.Size(99, 20)
        Me.uDateEnd.TabIndex = 8
        Me.uDateEnd.Value = New Date(2015, 7, 22, 17, 1, 27, 0)
        '
        'LabelNewSerial
        '
        Me.LabelNewSerial.AutoSize = True
        Me.LabelNewSerial.Location = New System.Drawing.Point(272, 126)
        Me.LabelNewSerial.Name = "LabelNewSerial"
        Me.LabelNewSerial.Size = New System.Drawing.Size(98, 13)
        Me.LabelNewSerial.TabIndex = 6
        Me.LabelNewSerial.Text = "New Serial Number"
        '
        'LabelOldSerial
        '
        Me.LabelOldSerial.AutoSize = True
        Me.LabelOldSerial.Location = New System.Drawing.Point(10, 126)
        Me.LabelOldSerial.Name = "LabelOldSerial"
        Me.LabelOldSerial.Size = New System.Drawing.Size(92, 13)
        Me.LabelOldSerial.TabIndex = 5
        Me.LabelOldSerial.Text = "Old Serial Number"
        '
        'uNewSn
        '
        Me.uNewSn.Location = New System.Drawing.Point(271, 103)
        Me.uNewSn.Name = "uNewSn"
        Me.uNewSn.Size = New System.Drawing.Size(142, 20)
        Me.uNewSn.TabIndex = 9
        '
        'uOldSn
        '
        Me.uOldSn.Location = New System.Drawing.Point(9, 103)
        Me.uOldSn.Name = "uOldSn"
        Me.uOldSn.Size = New System.Drawing.Size(142, 20)
        Me.uOldSn.TabIndex = 7
        '
        'LabelsNa
        '
        Me.LabelsNa.AutoSize = True
        Me.LabelsNa.Location = New System.Drawing.Point(9, 87)
        Me.LabelsNa.Name = "LabelsNa"
        Me.LabelsNa.Size = New System.Drawing.Size(75, 13)
        Me.LabelsNa.TabIndex = 2
        Me.LabelsNa.Text = "Student Name"
        '
        'uAsgmtNa
        '
        Me.uAsgmtNa.Location = New System.Drawing.Point(9, 64)
        Me.uAsgmtNa.Name = "uAsgmtNa"
        Me.uAsgmtNa.Size = New System.Drawing.Size(247, 20)
        Me.uAsgmtNa.TabIndex = 6
        '
        'cUpdategrp
        '
        Me.cUpdategrp.Controls.Add(Me.Label2)
        Me.cUpdategrp.Controls.Add(Me.updateVal)
        Me.cUpdategrp.Controls.Add(Me.Label1)
        Me.cUpdategrp.Controls.Add(Me.uExcecute)
        Me.cUpdategrp.Controls.Add(Me.updateID)
        Me.cUpdategrp.Location = New System.Drawing.Point(12, 18)
        Me.cUpdategrp.Name = "cUpdategrp"
        Me.cUpdategrp.Size = New System.Drawing.Size(533, 66)
        Me.cUpdategrp.TabIndex = 7
        Me.cUpdategrp.TabStop = False
        Me.cUpdategrp.Text = "Update Claim"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(155, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Status"
        '
        'updateVal
        '
        Me.updateVal.FormattingEnabled = True
        Me.updateVal.Items.AddRange(New Object() {"Depot", "Completed", "Part Ordered", "Never Came In", "Engineering", "Back Ordered ", "Replacement", "HOLD"})
        Me.updateVal.Location = New System.Drawing.Point(154, 18)
        Me.updateVal.Name = "updateVal"
        Me.updateVal.Size = New System.Drawing.Size(142, 21)
        Me.updateVal.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Claim ID"
        '
        'uExcecute
        '
        Me.uExcecute.Location = New System.Drawing.Point(418, 16)
        Me.uExcecute.Name = "uExcecute"
        Me.uExcecute.Size = New System.Drawing.Size(109, 23)
        Me.uExcecute.TabIndex = 2
        Me.uExcecute.Text = "Submit Update"
        Me.uExcecute.UseVisualStyleBackColor = True
        '
        'updateID
        '
        Me.updateID.Location = New System.Drawing.Point(6, 19)
        Me.updateID.Name = "updateID"
        Me.updateID.Size = New System.Drawing.Size(142, 20)
        Me.updateID.TabIndex = 0
        '
        'searchPg
        '
        Me.searchPg.Controls.Add(Me.GroupBox2)
        Me.searchPg.Controls.Add(Me.sALLSearchGroupBox)
        Me.searchPg.Controls.Add(Me.sAtnChk)
        Me.searchPg.Controls.Add(Me.svExecute)
        Me.searchPg.Controls.Add(Me.sExport)
        Me.searchPg.Controls.Add(Me.sClear)
        Me.searchPg.Controls.Add(Me.radioYears)
        Me.searchPg.Controls.Add(Me.radioDays)
        Me.searchPg.Controls.Add(Me.sDate)
        Me.searchPg.Controls.Add(Me.dateSearch)
        Me.searchPg.Controls.Add(Me.labelField)
        Me.searchPg.Controls.Add(Me.sField)
        Me.searchPg.Controls.Add(Me.sSelection)
        Me.searchPg.Controls.Add(Me.sExecute)
        Me.searchPg.Controls.Add(Me.labelSelect)
        Me.searchPg.Controls.Add(Me.labelTables)
        Me.searchPg.Controls.Add(Me.sTables)
        Me.searchPg.Controls.Add(Me.sDatagrid)
        Me.searchPg.Location = New System.Drawing.Point(4, 22)
        Me.searchPg.Name = "searchPg"
        Me.searchPg.Size = New System.Drawing.Size(1304, 603)
        Me.searchPg.TabIndex = 3
        Me.searchPg.Text = "Search"
        Me.searchPg.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.sAsgtExec)
        Me.GroupBox2.Controls.Add(Me.LabelSNaAsgt)
        Me.GroupBox2.Controls.Add(Me.sSNAsgt)
        Me.GroupBox2.Location = New System.Drawing.Point(1023, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(197, 101)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Assignment Search"
        '
        'sAsgtExec
        '
        Me.sAsgtExec.Location = New System.Drawing.Point(116, 64)
        Me.sAsgtExec.Name = "sAsgtExec"
        Me.sAsgtExec.Size = New System.Drawing.Size(75, 23)
        Me.sAsgtExec.TabIndex = 2
        Me.sAsgtExec.Text = "Search"
        Me.sAsgtExec.UseVisualStyleBackColor = True
        '
        'LabelSNaAsgt
        '
        Me.LabelSNaAsgt.AutoSize = True
        Me.LabelSNaAsgt.Location = New System.Drawing.Point(6, 40)
        Me.LabelSNaAsgt.Name = "LabelSNaAsgt"
        Me.LabelSNaAsgt.Size = New System.Drawing.Size(75, 13)
        Me.LabelSNaAsgt.TabIndex = 1
        Me.LabelSNaAsgt.Text = "Student Name"
        '
        'sSNAsgt
        '
        Me.sSNAsgt.Location = New System.Drawing.Point(6, 17)
        Me.sSNAsgt.Name = "sSNAsgt"
        Me.sSNAsgt.Size = New System.Drawing.Size(185, 20)
        Me.sSNAsgt.TabIndex = 0
        '
        'sALLSearchGroupBox
        '
        Me.sALLSearchGroupBox.Controls.Add(Me.sALLDepotExec)
        Me.sALLSearchGroupBox.Controls.Add(Me.sALLPoExec)
        Me.sALLSearchGroupBox.Location = New System.Drawing.Point(847, 15)
        Me.sALLSearchGroupBox.Name = "sALLSearchGroupBox"
        Me.sALLSearchGroupBox.Size = New System.Drawing.Size(170, 101)
        Me.sALLSearchGroupBox.TabIndex = 21
        Me.sALLSearchGroupBox.TabStop = False
        Me.sALLSearchGroupBox.Text = "Search All"
        '
        'sALLDepotExec
        '
        Me.sALLDepotExec.Location = New System.Drawing.Point(6, 17)
        Me.sALLDepotExec.Name = "sALLDepotExec"
        Me.sALLDepotExec.Size = New System.Drawing.Size(75, 23)
        Me.sALLDepotExec.TabIndex = 19
        Me.sALLDepotExec.Text = "Depot"
        Me.sALLDepotExec.UseVisualStyleBackColor = True
        '
        'sALLPoExec
        '
        Me.sALLPoExec.Location = New System.Drawing.Point(89, 17)
        Me.sALLPoExec.Name = "sALLPoExec"
        Me.sALLPoExec.Size = New System.Drawing.Size(75, 23)
        Me.sALLPoExec.TabIndex = 20
        Me.sALLPoExec.Text = "Part Ordered"
        Me.sALLPoExec.UseVisualStyleBackColor = True
        '
        'sAtnChk
        '
        Me.sAtnChk.AutoSize = True
        Me.sAtnChk.Enabled = False
        Me.sAtnChk.Location = New System.Drawing.Point(443, 23)
        Me.sAtnChk.Name = "sAtnChk"
        Me.sAtnChk.Size = New System.Drawing.Size(71, 17)
        Me.sAtnChk.TabIndex = 18
        Me.sAtnChk.Text = "Attention "
        Me.sAtnChk.UseVisualStyleBackColor = True
        '
        'svExecute
        '
        Me.svExecute.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.svExecute.Location = New System.Drawing.Point(1145, 541)
        Me.svExecute.Name = "svExecute"
        Me.svExecute.Size = New System.Drawing.Size(75, 23)
        Me.svExecute.TabIndex = 17
        Me.svExecute.Text = "Save"
        Me.svExecute.UseVisualStyleBackColor = True
        '
        'sExport
        '
        Me.sExport.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.sExport.Location = New System.Drawing.Point(596, 570)
        Me.sExport.Name = "sExport"
        Me.sExport.Size = New System.Drawing.Size(75, 23)
        Me.sExport.TabIndex = 16
        Me.sExport.Text = "Export"
        Me.sExport.UseVisualStyleBackColor = True
        '
        'sClear
        '
        Me.sClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.sClear.Location = New System.Drawing.Point(596, 541)
        Me.sClear.Name = "sClear"
        Me.sClear.Size = New System.Drawing.Size(75, 23)
        Me.sClear.TabIndex = 15
        Me.sClear.Text = "Clear Grid"
        Me.sClear.UseVisualStyleBackColor = True
        '
        'radioYears
        '
        Me.radioYears.AutoSize = True
        Me.radioYears.Location = New System.Drawing.Point(443, 103)
        Me.radioYears.Name = "radioYears"
        Me.radioYears.Size = New System.Drawing.Size(52, 17)
        Me.radioYears.TabIndex = 14
        Me.radioYears.TabStop = True
        Me.radioYears.Text = "Years"
        Me.radioYears.UseVisualStyleBackColor = True
        '
        'radioDays
        '
        Me.radioDays.AutoSize = True
        Me.radioDays.Location = New System.Drawing.Point(443, 80)
        Me.radioDays.Name = "radioDays"
        Me.radioDays.Size = New System.Drawing.Size(49, 17)
        Me.radioDays.TabIndex = 5
        Me.radioDays.TabStop = True
        Me.radioDays.Text = "Days"
        Me.radioDays.UseVisualStyleBackColor = True
        '
        'sDate
        '
        Me.sDate.Location = New System.Drawing.Point(305, 82)
        Me.sDate.MaxLength = 3
        Me.sDate.Name = "sDate"
        Me.sDate.Size = New System.Drawing.Size(104, 20)
        Me.sDate.TabIndex = 4
        '
        'dateSearch
        '
        Me.dateSearch.Location = New System.Drawing.Point(535, 80)
        Me.dateSearch.Name = "dateSearch"
        Me.dateSearch.Size = New System.Drawing.Size(75, 23)
        Me.dateSearch.TabIndex = 6
        Me.dateSearch.Text = "Check"
        Me.dateSearch.UseVisualStyleBackColor = True
        '
        'labelField
        '
        Me.labelField.AutoSize = True
        Me.labelField.Location = New System.Drawing.Point(159, 47)
        Me.labelField.Name = "labelField"
        Me.labelField.Size = New System.Drawing.Size(29, 13)
        Me.labelField.TabIndex = 10
        Me.labelField.Text = "Field"
        '
        'sField
        '
        Me.sField.Enabled = False
        Me.sField.FormattingEnabled = True
        Me.sField.Location = New System.Drawing.Point(162, 19)
        Me.sField.Name = "sField"
        Me.sField.Size = New System.Drawing.Size(121, 21)
        Me.sField.TabIndex = 1
        '
        'sSelection
        '
        Me.sSelection.Location = New System.Drawing.Point(305, 20)
        Me.sSelection.Name = "sSelection"
        Me.sSelection.Size = New System.Drawing.Size(104, 20)
        Me.sSelection.TabIndex = 2
        '
        'sExecute
        '
        Me.sExecute.Location = New System.Drawing.Point(535, 16)
        Me.sExecute.Name = "sExecute"
        Me.sExecute.Size = New System.Drawing.Size(80, 23)
        Me.sExecute.TabIndex = 3
        Me.sExecute.Text = "Search"
        Me.sExecute.UseVisualStyleBackColor = True
        '
        'labelSelect
        '
        Me.labelSelect.AutoSize = True
        Me.labelSelect.Location = New System.Drawing.Point(302, 43)
        Me.labelSelect.Name = "labelSelect"
        Me.labelSelect.Size = New System.Drawing.Size(51, 13)
        Me.labelSelect.TabIndex = 6
        Me.labelSelect.Text = "Selection"
        '
        'labelTables
        '
        Me.labelTables.AutoSize = True
        Me.labelTables.Location = New System.Drawing.Point(19, 47)
        Me.labelTables.Name = "labelTables"
        Me.labelTables.Size = New System.Drawing.Size(34, 13)
        Me.labelTables.TabIndex = 5
        Me.labelTables.Text = "Table"
        '
        'sTables
        '
        Me.sTables.FormattingEnabled = True
        Me.sTables.Items.AddRange(New Object() {"Claims", "Students$", "Systems$", "Assignments$", "Docks"})
        Me.sTables.Location = New System.Drawing.Point(19, 19)
        Me.sTables.Name = "sTables"
        Me.sTables.Size = New System.Drawing.Size(121, 21)
        Me.sTables.TabIndex = 0
        '
        'sDatagrid
        '
        Me.sDatagrid.AllowUserToAddRows = False
        Me.sDatagrid.AllowUserToDeleteRows = False
        Me.sDatagrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.sDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.sDatagrid.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.sDatagrid.Location = New System.Drawing.Point(19, 143)
        Me.sDatagrid.Name = "sDatagrid"
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.sDatagrid.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.sDatagrid.Size = New System.Drawing.Size(1201, 385)
        Me.sDatagrid.TabIndex = 3
        '
        'managerPg
        '
        Me.managerPg.Controls.Add(Me.GroupBox3)
        Me.managerPg.Controls.Add(Me.GroupBox1)
        Me.managerPg.Controls.Add(Me.mStuGrp)
        Me.managerPg.Controls.Add(Me.mBulkGroup)
        Me.managerPg.Location = New System.Drawing.Point(4, 22)
        Me.managerPg.Name = "managerPg"
        Me.managerPg.Padding = New System.Windows.Forms.Padding(3)
        Me.managerPg.Size = New System.Drawing.Size(1304, 603)
        Me.managerPg.TabIndex = 4
        Me.managerPg.Text = "Manager"
        Me.managerPg.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.mSysDelExec)
        Me.GroupBox3.Controls.Add(Me.mSysExec)
        Me.GroupBox3.Controls.Add(Me.mModelLabel)
        Me.GroupBox3.Controls.Add(Me.mMACLabel)
        Me.GroupBox3.Controls.Add(Me.mSysSNLabel)
        Me.GroupBox3.Controls.Add(Me.mSysModel)
        Me.GroupBox3.Controls.Add(Me.mSysMac)
        Me.GroupBox3.Controls.Add(Me.mSysSN)
        Me.GroupBox3.Location = New System.Drawing.Point(932, 27)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(359, 145)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "System Manager"
        '
        'mSysDelExec
        '
        Me.mSysDelExec.Location = New System.Drawing.Point(275, 116)
        Me.mSysDelExec.Name = "mSysDelExec"
        Me.mSysDelExec.Size = New System.Drawing.Size(75, 23)
        Me.mSysDelExec.TabIndex = 7
        Me.mSysDelExec.Text = "Delete"
        Me.mSysDelExec.UseVisualStyleBackColor = True
        '
        'mSysExec
        '
        Me.mSysExec.Location = New System.Drawing.Point(275, 87)
        Me.mSysExec.Name = "mSysExec"
        Me.mSysExec.Size = New System.Drawing.Size(75, 23)
        Me.mSysExec.TabIndex = 6
        Me.mSysExec.Text = "Submit"
        Me.mSysExec.UseVisualStyleBackColor = True
        '
        'mModelLabel
        '
        Me.mModelLabel.AutoSize = True
        Me.mModelLabel.Location = New System.Drawing.Point(275, 61)
        Me.mModelLabel.Name = "mModelLabel"
        Me.mModelLabel.Size = New System.Drawing.Size(36, 13)
        Me.mModelLabel.TabIndex = 5
        Me.mModelLabel.Text = "Model"
        '
        'mMACLabel
        '
        Me.mMACLabel.AutoSize = True
        Me.mMACLabel.Location = New System.Drawing.Point(168, 61)
        Me.mMACLabel.Name = "mMACLabel"
        Me.mMACLabel.Size = New System.Drawing.Size(71, 13)
        Me.mMACLabel.TabIndex = 4
        Me.mMACLabel.Text = "MAC Address"
        '
        'mSysSNLabel
        '
        Me.mSysSNLabel.AutoSize = True
        Me.mSysSNLabel.Location = New System.Drawing.Point(7, 61)
        Me.mSysSNLabel.Name = "mSysSNLabel"
        Me.mSysSNLabel.Size = New System.Drawing.Size(73, 13)
        Me.mSysSNLabel.TabIndex = 3
        Me.mSysSNLabel.Text = "Serial Number"
        '
        'mSysModel
        '
        Me.mSysModel.FormattingEnabled = True
        Me.mSysModel.Items.AddRange(New Object() {"Q702", "Yoga S1", "Yoga 12"})
        Me.mSysModel.Location = New System.Drawing.Point(275, 33)
        Me.mSysModel.Name = "mSysModel"
        Me.mSysModel.Size = New System.Drawing.Size(75, 21)
        Me.mSysModel.TabIndex = 2
        '
        'mSysMac
        '
        Me.mSysMac.Location = New System.Drawing.Point(168, 33)
        Me.mSysMac.Name = "mSysMac"
        Me.mSysMac.Size = New System.Drawing.Size(100, 20)
        Me.mSysMac.TabIndex = 1
        '
        'mSysSN
        '
        Me.mSysSN.Location = New System.Drawing.Point(7, 33)
        Me.mSysSN.Name = "mSysSN"
        Me.mSysSN.Size = New System.Drawing.Size(154, 20)
        Me.mSysSN.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mDkNoteLabel)
        Me.GroupBox1.Controls.Add(Me.mDkNotes)
        Me.GroupBox1.Controls.Add(Me.mDockExec)
        Me.GroupBox1.Controls.Add(Me.mDkDateS)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.mDkTno)
        Me.GroupBox1.Controls.Add(Me.mDkSN)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 192)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(910, 234)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dock Manager"
        '
        'mDkNoteLabel
        '
        Me.mDkNoteLabel.AutoSize = True
        Me.mDkNoteLabel.Location = New System.Drawing.Point(599, 61)
        Me.mDkNoteLabel.Name = "mDkNoteLabel"
        Me.mDkNoteLabel.Size = New System.Drawing.Size(35, 13)
        Me.mDkNoteLabel.TabIndex = 21
        Me.mDkNoteLabel.Text = "Notes"
        '
        'mDkNotes
        '
        Me.mDkNotes.Location = New System.Drawing.Point(599, 34)
        Me.mDkNotes.Name = "mDkNotes"
        Me.mDkNotes.Size = New System.Drawing.Size(220, 20)
        Me.mDkNotes.TabIndex = 12
        '
        'mDockExec
        '
        Me.mDockExec.Location = New System.Drawing.Point(837, 30)
        Me.mDockExec.Name = "mDockExec"
        Me.mDockExec.Size = New System.Drawing.Size(67, 23)
        Me.mDockExec.TabIndex = 19
        Me.mDockExec.Text = "Submit"
        Me.mDockExec.UseVisualStyleBackColor = True
        '
        'mDkDateS
        '
        Me.mDkDateS.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.mDkDateS.Location = New System.Drawing.Point(460, 34)
        Me.mDkDateS.Name = "mDkDateS"
        Me.mDkDateS.Size = New System.Drawing.Size(102, 20)
        Me.mDkDateS.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(457, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Date Shipped"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(303, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(227, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Tracking Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Dock Serial"
        '
        'mDkTno
        '
        Me.mDkTno.Location = New System.Drawing.Point(230, 33)
        Me.mDkTno.Name = "mDkTno"
        Me.mDkTno.Size = New System.Drawing.Size(192, 20)
        Me.mDkTno.TabIndex = 10
        '
        'mDkSN
        '
        Me.mDkSN.Location = New System.Drawing.Point(6, 30)
        Me.mDkSN.Multiline = True
        Me.mDkSN.Name = "mDkSN"
        Me.mDkSN.Size = New System.Drawing.Size(195, 165)
        Me.mDkSN.TabIndex = 9
        '
        'mStuGrp
        '
        Me.mStuGrp.Controls.Add(Me.mStuDelExec)
        Me.mStuGrp.Controls.Add(Me.mNewStuExec)
        Me.mStuGrp.Controls.Add(Me.mGradeLabel)
        Me.mStuGrp.Controls.Add(Me.mGradeCombo)
        Me.mStuGrp.Controls.Add(Me.mHnaLabel)
        Me.mStuGrp.Controls.Add(Me.mNewSnaLabel)
        Me.mStuGrp.Controls.Add(Me.mHostna)
        Me.mStuGrp.Controls.Add(Me.mStuNa)
        Me.mStuGrp.Location = New System.Drawing.Point(476, 27)
        Me.mStuGrp.Name = "mStuGrp"
        Me.mStuGrp.Size = New System.Drawing.Size(450, 145)
        Me.mStuGrp.TabIndex = 1
        Me.mStuGrp.TabStop = False
        Me.mStuGrp.Text = "Student Manager"
        '
        'mStuDelExec
        '
        Me.mStuDelExec.Location = New System.Drawing.Point(376, 116)
        Me.mStuDelExec.Name = "mStuDelExec"
        Me.mStuDelExec.Size = New System.Drawing.Size(67, 23)
        Me.mStuDelExec.TabIndex = 8
        Me.mStuDelExec.Text = "Delete"
        Me.mStuDelExec.UseVisualStyleBackColor = True
        '
        'mNewStuExec
        '
        Me.mNewStuExec.Location = New System.Drawing.Point(377, 87)
        Me.mNewStuExec.Name = "mNewStuExec"
        Me.mNewStuExec.Size = New System.Drawing.Size(67, 23)
        Me.mNewStuExec.TabIndex = 7
        Me.mNewStuExec.Text = "Submit "
        Me.mNewStuExec.UseVisualStyleBackColor = True
        '
        'mGradeLabel
        '
        Me.mGradeLabel.AutoSize = True
        Me.mGradeLabel.Location = New System.Drawing.Point(376, 61)
        Me.mGradeLabel.Name = "mGradeLabel"
        Me.mGradeLabel.Size = New System.Drawing.Size(36, 13)
        Me.mGradeLabel.TabIndex = 6
        Me.mGradeLabel.Text = "Grade"
        '
        'mGradeCombo
        '
        Me.mGradeCombo.FormattingEnabled = True
        Me.mGradeCombo.Items.AddRange(New Object() {"6", "7", "8"})
        Me.mGradeCombo.Location = New System.Drawing.Point(376, 33)
        Me.mGradeCombo.Name = "mGradeCombo"
        Me.mGradeCombo.Size = New System.Drawing.Size(67, 21)
        Me.mGradeCombo.TabIndex = 5
        '
        'mHnaLabel
        '
        Me.mHnaLabel.AutoSize = True
        Me.mHnaLabel.Location = New System.Drawing.Point(192, 60)
        Me.mHnaLabel.Name = "mHnaLabel"
        Me.mHnaLabel.Size = New System.Drawing.Size(60, 13)
        Me.mHnaLabel.TabIndex = 4
        Me.mHnaLabel.Text = "Host Name"
        '
        'mNewSnaLabel
        '
        Me.mNewSnaLabel.AutoSize = True
        Me.mNewSnaLabel.Location = New System.Drawing.Point(7, 60)
        Me.mNewSnaLabel.Name = "mNewSnaLabel"
        Me.mNewSnaLabel.Size = New System.Drawing.Size(75, 13)
        Me.mNewSnaLabel.TabIndex = 3
        Me.mNewSnaLabel.Text = "Student Name"
        '
        'mHostna
        '
        Me.mHostna.Location = New System.Drawing.Point(192, 33)
        Me.mHostna.Name = "mHostna"
        Me.mHostna.Size = New System.Drawing.Size(167, 20)
        Me.mHostna.TabIndex = 1
        '
        'mStuNa
        '
        Me.mStuNa.Location = New System.Drawing.Point(6, 33)
        Me.mStuNa.Name = "mStuNa"
        Me.mStuNa.Size = New System.Drawing.Size(167, 20)
        Me.mStuNa.TabIndex = 0
        '
        'mBulkGroup
        '
        Me.mBulkGroup.Controls.Add(Me.mBinsertExec)
        Me.mBulkGroup.Controls.Add(Me.mLabelCombo)
        Me.mBulkGroup.Controls.Add(Me.mCombo)
        Me.mBulkGroup.Controls.Add(Me.LabelFileLoc)
        Me.mBulkGroup.Controls.Add(Me.mFileLoc)
        Me.mBulkGroup.Location = New System.Drawing.Point(16, 27)
        Me.mBulkGroup.Name = "mBulkGroup"
        Me.mBulkGroup.Size = New System.Drawing.Size(432, 145)
        Me.mBulkGroup.TabIndex = 0
        Me.mBulkGroup.TabStop = False
        Me.mBulkGroup.Text = "Bulk Insert"
        '
        'mBinsertExec
        '
        Me.mBinsertExec.Location = New System.Drawing.Point(326, 93)
        Me.mBinsertExec.Name = "mBinsertExec"
        Me.mBinsertExec.Size = New System.Drawing.Size(96, 23)
        Me.mBinsertExec.TabIndex = 2
        Me.mBinsertExec.Text = "Submit Insert"
        Me.mBinsertExec.UseVisualStyleBackColor = True
        '
        'mLabelCombo
        '
        Me.mLabelCombo.AutoSize = True
        Me.mLabelCombo.Location = New System.Drawing.Point(6, 121)
        Me.mLabelCombo.Name = "mLabelCombo"
        Me.mLabelCombo.Size = New System.Drawing.Size(34, 13)
        Me.mLabelCombo.TabIndex = 3
        Me.mLabelCombo.Text = "Table"
        '
        'mCombo
        '
        Me.mCombo.FormattingEnabled = True
        Me.mCombo.Items.AddRange(New Object() {"Students$", "Systems$", "Assignments$", "Claims"})
        Me.mCombo.Location = New System.Drawing.Point(6, 93)
        Me.mCombo.Name = "mCombo"
        Me.mCombo.Size = New System.Drawing.Size(121, 21)
        Me.mCombo.TabIndex = 1
        '
        'LabelFileLoc
        '
        Me.LabelFileLoc.AutoSize = True
        Me.LabelFileLoc.Location = New System.Drawing.Point(7, 60)
        Me.LabelFileLoc.Name = "LabelFileLoc"
        Me.LabelFileLoc.Size = New System.Drawing.Size(67, 13)
        Me.LabelFileLoc.TabIndex = 1
        Me.LabelFileLoc.Text = "File Location"
        '
        'mFileLoc
        '
        Me.mFileLoc.Location = New System.Drawing.Point(7, 33)
        Me.mFileLoc.Name = "mFileLoc"
        Me.mFileLoc.Size = New System.Drawing.Size(415, 20)
        Me.mFileLoc.TabIndex = 0
        Me.ToolTip.SetToolTip(Me.mFileLoc, "This is set up for CSV files.")
        '
        'triageWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1336, 666)
        Me.Controls.Add(Me.Tabs)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "triageWindow"
        Me.Text = "Laptop Hospital Triage"
        Me.queryPg.ResumeLayout(False)
        Me.queryPg.PerformLayout()
        CType(Me.rDatagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.triagePg.ResumeLayout(False)
        Me.triagePg.PerformLayout()
        Me.Tabs.ResumeLayout(False)
        Me.updatePg.ResumeLayout(False)
        Me.gUpdateasgmt.ResumeLayout(False)
        Me.gUpdateasgmt.PerformLayout()
        Me.cUpdategrp.ResumeLayout(False)
        Me.cUpdategrp.PerformLayout()
        Me.searchPg.ResumeLayout(False)
        Me.searchPg.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.sALLSearchGroupBox.ResumeLayout(False)
        CType(Me.sDatagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.managerPg.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.mStuGrp.ResumeLayout(False)
        Me.mStuGrp.PerformLayout()
        Me.mBulkGroup.ResumeLayout(False)
        Me.mBulkGroup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents queryPg As System.Windows.Forms.TabPage
    Friend WithEvents rDatagrid As System.Windows.Forms.DataGridView
    Friend WithEvents cmdQuery As System.Windows.Forms.Button
    Friend WithEvents txtQuery As System.Windows.Forms.TextBox
    Friend WithEvents triagePg As System.Windows.Forms.TabPage
    Friend WithEvents statLabel As System.Windows.Forms.Label
    Friend WithEvents status As System.Windows.Forms.ComboBox
    Friend WithEvents Execute As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LabelSN As System.Windows.Forms.Label
    Friend WithEvents sNa As System.Windows.Forms.TextBox
    Friend WithEvents Sn As System.Windows.Forms.TextBox
    Friend WithEvents Notes As System.Windows.Forms.TextBox
    Friend WithEvents caseID As System.Windows.Forms.TextBox
    Friend WithEvents LabelSNo As System.Windows.Forms.Label
    Friend WithEvents LabelcID As System.Windows.Forms.Label
    Friend WithEvents Tabs As System.Windows.Forms.TabControl
    Friend WithEvents updatePg As System.Windows.Forms.TabPage
    Friend WithEvents searchPg As System.Windows.Forms.TabPage
    Friend WithEvents uExcecute As System.Windows.Forms.Button
    Friend WithEvents updateID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents updateVal As System.Windows.Forms.ComboBox
    Friend WithEvents sField As System.Windows.Forms.ComboBox
    Friend WithEvents sSelection As System.Windows.Forms.TextBox
    Friend WithEvents sExecute As System.Windows.Forms.Button
    Friend WithEvents labelSelect As System.Windows.Forms.Label
    Friend WithEvents labelTables As System.Windows.Forms.Label
    Friend WithEvents sTables As System.Windows.Forms.ComboBox
    Friend WithEvents sDatagrid As System.Windows.Forms.DataGridView
    Friend WithEvents labelField As System.Windows.Forms.Label
    Friend WithEvents labelTrack As System.Windows.Forms.Label
    Friend WithEvents trackingNo As System.Windows.Forms.TextBox
    Friend WithEvents sDate As System.Windows.Forms.TextBox
    Friend WithEvents dateSearch As System.Windows.Forms.Button
    Friend WithEvents radioYears As System.Windows.Forms.RadioButton
    Friend WithEvents radioDays As System.Windows.Forms.RadioButton
    Friend WithEvents sClear As System.Windows.Forms.Button
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents sExport As System.Windows.Forms.Button
    Friend WithEvents cmdExport As System.Windows.Forms.Button
    Friend WithEvents cUpdategrp As System.Windows.Forms.GroupBox
    Friend WithEvents gUpdateasgmt As System.Windows.Forms.GroupBox
    Friend WithEvents uAsgmtExecute As System.Windows.Forms.Button
    Friend WithEvents LabeluDateStart As System.Windows.Forms.Label
    Friend WithEvents LabeluDateEnd As System.Windows.Forms.Label
    Friend WithEvents uDateStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents uDateEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelNewSerial As System.Windows.Forms.Label
    Friend WithEvents LabelOldSerial As System.Windows.Forms.Label
    Friend WithEvents uNewSn As System.Windows.Forms.TextBox
    Friend WithEvents uOldSn As System.Windows.Forms.TextBox
    Friend WithEvents LabelsNa As System.Windows.Forms.Label
    Friend WithEvents uAsgmtNa As System.Windows.Forms.TextBox
    Friend WithEvents svExecute As Button
    Friend WithEvents uCreatecheck As RadioButton
    Friend WithEvents uTermcheck As RadioButton
    Friend WithEvents uReplacecheck As RadioButton
    Friend WithEvents Labelunotes As Label
    Friend WithEvents uNotes As TextBox
    Friend WithEvents managerPg As TabPage
    Friend WithEvents mBulkGroup As GroupBox
    Friend WithEvents LabelFileLoc As Label
    Friend WithEvents mFileLoc As TextBox
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents mCombo As ComboBox
    Friend WithEvents mLabelCombo As Label
    Friend WithEvents mBinsertExec As Button
    Friend WithEvents LabelProblem As Label
    Friend WithEvents pwr As CheckBox
    Friend WithEvents audio As CheckBox
    Friend WithEvents fan As CheckBox
    Friend WithEvents wifi As CheckBox
    Friend WithEvents fDigi As CheckBox
    Friend WithEvents ssd As CheckBox
    Friend WithEvents dLCD As CheckBox
    Friend WithEvents cLCD As CheckBox
    Friend WithEvents other As TextBox
    Friend WithEvents mStuGrp As GroupBox
    Friend WithEvents mHnaLabel As Label
    Friend WithEvents mNewSnaLabel As Label
    Friend WithEvents mHostna As TextBox
    Friend WithEvents mStuNa As TextBox
    Friend WithEvents mNewStuExec As Button
    Friend WithEvents mGradeLabel As Label
    Friend WithEvents mGradeCombo As ComboBox
    Friend WithEvents sAtnChk As CheckBox
    Friend WithEvents mStuDelExec As Button
    Friend WithEvents mobo As CheckBox
    Friend WithEvents attentionChk As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents mDockExec As Button
    Friend WithEvents mDkDateS As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents mDkTno As TextBox
    Friend WithEvents mDkSN As TextBox
    Friend WithEvents mDkNoteLabel As Label
    Friend WithEvents mDkNotes As TextBox
    Friend WithEvents sALLSearchGroupBox As GroupBox
    Friend WithEvents sALLDepotExec As Button
    Friend WithEvents sALLPoExec As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents sAsgtExec As Button
    Friend WithEvents LabelSNaAsgt As Label
    Friend WithEvents sSNAsgt As TextBox
    Friend WithEvents rSave As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents mSysModel As ComboBox
    Friend WithEvents mSysMac As TextBox
    Friend WithEvents mSysSN As TextBox
    Friend WithEvents mSysDelExec As Button
    Friend WithEvents mSysExec As Button
    Friend WithEvents mModelLabel As Label
    Friend WithEvents mMACLabel As Label
    Friend WithEvents mSysSNLabel As Label
End Class
