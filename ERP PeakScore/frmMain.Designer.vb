﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.dialogOpen = New System.Windows.Forms.OpenFileDialog()
        Me.textFile = New System.Windows.Forms.TextBox()
        Me.listElectrodes = New System.Windows.Forms.ListBox()
        Me.labelElectrodes = New System.Windows.Forms.Label()
        Me.boxDefineSettings = New System.Windows.Forms.GroupBox()
        Me.textBaseline = New System.Windows.Forms.TextBox()
        Me.labelBaseline = New System.Windows.Forms.Label()
        Me.labelTo = New System.Windows.Forms.Label()
        Me.textLatencyUpper = New System.Windows.Forms.TextBox()
        Me.textLatencyLower = New System.Windows.Forms.TextBox()
        Me.textComponent = New System.Windows.Forms.TextBox()
        Me.textSamplingRate = New System.Windows.Forms.TextBox()
        Me.labelSamplingRate = New System.Windows.Forms.Label()
        Me.labelLatencyWindow = New System.Windows.Forms.Label()
        Me.labelComponent = New System.Windows.Forms.Label()
        Me.btnScorePeakSave = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.labelEpochDuration = New System.Windows.Forms.Label()
        Me.textEpochDuration = New System.Windows.Forms.TextBox()
        Me.boxDefineMeasures = New System.Windows.Forms.GroupBox()
        Me.textMeanLat = New System.Windows.Forms.TextBox()
        Me.checkMeanLat = New System.Windows.Forms.CheckBox()
        Me.checkMaxLat = New System.Windows.Forms.CheckBox()
        Me.checkMinLat = New System.Windows.Forms.CheckBox()
        Me.checkMeanAmp = New System.Windows.Forms.CheckBox()
        Me.checkMaxAmp = New System.Windows.Forms.CheckBox()
        Me.checkMinAmp = New System.Windows.Forms.CheckBox()
        Me.dialogSave = New System.Windows.Forms.SaveFileDialog()
        Me.textTimepoints = New System.Windows.Forms.TextBox()
        Me.labelTimepoints = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.labelEMail = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picLabNPF = New System.Windows.Forms.PictureBox()
        Me.labelFFS = New System.Windows.Forms.Label()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.menuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHelpTooltips = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHelpDocumentation = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHelpLicense = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuHelpInstructions = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHelpCitation = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuHelpUpdates = New System.Windows.Forms.ToolStripMenuItem()
        Me.picLicense = New System.Windows.Forms.PictureBox()
        Me.boxDefineSettings.SuspendLayout()
        Me.boxDefineMeasures.SuspendLayout()
        CType(Me.picLabNPF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        CType(Me.picLicense, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Location = New System.Drawing.Point(12, 44)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(164, 34)
        Me.btnOpenFile.TabIndex = 0
        Me.btnOpenFile.Text = "&Open ERP File"
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'dialogOpen
        '
        Me.dialogOpen.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        '
        'textFile
        '
        Me.textFile.Location = New System.Drawing.Point(182, 44)
        Me.textFile.Multiline = True
        Me.textFile.Name = "textFile"
        Me.textFile.ReadOnly = True
        Me.textFile.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.textFile.Size = New System.Drawing.Size(522, 33)
        Me.textFile.TabIndex = 1
        '
        'listElectrodes
        '
        Me.listElectrodes.FormattingEnabled = True
        Me.listElectrodes.ItemHeight = 20
        Me.listElectrodes.Location = New System.Drawing.Point(531, 117)
        Me.listElectrodes.Name = "listElectrodes"
        Me.listElectrodes.Size = New System.Drawing.Size(172, 84)
        Me.listElectrodes.TabIndex = 3
        '
        'labelElectrodes
        '
        Me.labelElectrodes.AutoSize = True
        Me.labelElectrodes.Location = New System.Drawing.Point(526, 94)
        Me.labelElectrodes.Name = "labelElectrodes"
        Me.labelElectrodes.Size = New System.Drawing.Size(85, 20)
        Me.labelElectrodes.TabIndex = 4
        Me.labelElectrodes.Text = "Electrodes"
        '
        'boxDefineSettings
        '
        Me.boxDefineSettings.Controls.Add(Me.textBaseline)
        Me.boxDefineSettings.Controls.Add(Me.labelBaseline)
        Me.boxDefineSettings.Controls.Add(Me.labelTo)
        Me.boxDefineSettings.Controls.Add(Me.textLatencyUpper)
        Me.boxDefineSettings.Controls.Add(Me.textLatencyLower)
        Me.boxDefineSettings.Controls.Add(Me.textComponent)
        Me.boxDefineSettings.Controls.Add(Me.textSamplingRate)
        Me.boxDefineSettings.Controls.Add(Me.labelSamplingRate)
        Me.boxDefineSettings.Controls.Add(Me.labelLatencyWindow)
        Me.boxDefineSettings.Controls.Add(Me.labelComponent)
        Me.boxDefineSettings.Location = New System.Drawing.Point(20, 87)
        Me.boxDefineSettings.Name = "boxDefineSettings"
        Me.boxDefineSettings.Size = New System.Drawing.Size(494, 188)
        Me.boxDefineSettings.TabIndex = 6
        Me.boxDefineSettings.TabStop = False
        Me.boxDefineSettings.Text = "Define Settings:"
        '
        'textBaseline
        '
        Me.textBaseline.Location = New System.Drawing.Point(336, 99)
        Me.textBaseline.Name = "textBaseline"
        Me.textBaseline.Size = New System.Drawing.Size(133, 26)
        Me.textBaseline.TabIndex = 9
        Me.textBaseline.Text = "200"
        Me.textBaseline.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labelBaseline
        '
        Me.labelBaseline.AutoSize = True
        Me.labelBaseline.Location = New System.Drawing.Point(82, 102)
        Me.labelBaseline.Name = "labelBaseline"
        Me.labelBaseline.Size = New System.Drawing.Size(248, 20)
        Me.labelBaseline.TabIndex = 8
        Me.labelBaseline.Text = "Baseline duration in ms (0 if none)"
        '
        'labelTo
        '
        Me.labelTo.AutoSize = True
        Me.labelTo.Location = New System.Drawing.Point(388, 137)
        Me.labelTo.Name = "labelTo"
        Me.labelTo.Size = New System.Drawing.Size(23, 20)
        Me.labelTo.TabIndex = 7
        Me.labelTo.Text = "to"
        '
        'textLatencyUpper
        '
        Me.textLatencyUpper.Location = New System.Drawing.Point(423, 134)
        Me.textLatencyUpper.Name = "textLatencyUpper"
        Me.textLatencyUpper.Size = New System.Drawing.Size(46, 26)
        Me.textLatencyUpper.TabIndex = 6
        Me.textLatencyUpper.Text = "200"
        Me.textLatencyUpper.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textLatencyLower
        '
        Me.textLatencyLower.Location = New System.Drawing.Point(336, 134)
        Me.textLatencyLower.Name = "textLatencyLower"
        Me.textLatencyLower.Size = New System.Drawing.Size(46, 26)
        Me.textLatencyLower.TabIndex = 5
        Me.textLatencyLower.Text = "100"
        Me.textLatencyLower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textComponent
        '
        Me.textComponent.Location = New System.Drawing.Point(336, 64)
        Me.textComponent.Name = "textComponent"
        Me.textComponent.Size = New System.Drawing.Size(133, 26)
        Me.textComponent.TabIndex = 4
        Me.textComponent.Text = "N1"
        Me.textComponent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textSamplingRate
        '
        Me.textSamplingRate.Location = New System.Drawing.Point(336, 28)
        Me.textSamplingRate.Name = "textSamplingRate"
        Me.textSamplingRate.Size = New System.Drawing.Size(133, 26)
        Me.textSamplingRate.TabIndex = 3
        Me.textSamplingRate.Text = "256"
        Me.textSamplingRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labelSamplingRate
        '
        Me.labelSamplingRate.AutoSize = True
        Me.labelSamplingRate.Location = New System.Drawing.Point(176, 31)
        Me.labelSamplingRate.Name = "labelSamplingRate"
        Me.labelSamplingRate.Size = New System.Drawing.Size(154, 20)
        Me.labelSamplingRate.TabIndex = 2
        Me.labelSamplingRate.Text = "Sampling Rate in Hz"
        '
        'labelLatencyWindow
        '
        Me.labelLatencyWindow.AutoSize = True
        Me.labelLatencyWindow.Location = New System.Drawing.Point(15, 137)
        Me.labelLatencyWindow.Name = "labelLatencyWindow"
        Me.labelLatencyWindow.Size = New System.Drawing.Size(315, 20)
        Me.labelLatencyWindow.TabIndex = 1
        Me.labelLatencyWindow.Text = "Latency Window in ms (e.g., 120 to 220 ms)"
        '
        'labelComponent
        '
        Me.labelComponent.AutoSize = True
        Me.labelComponent.Location = New System.Drawing.Point(106, 64)
        Me.labelComponent.Name = "labelComponent"
        Me.labelComponent.Size = New System.Drawing.Size(224, 20)
        Me.labelComponent.TabIndex = 0
        Me.labelComponent.Text = "Component Name (e.g., N170)"
        '
        'btnScorePeakSave
        '
        Me.btnScorePeakSave.Location = New System.Drawing.Point(531, 353)
        Me.btnScorePeakSave.Name = "btnScorePeakSave"
        Me.btnScorePeakSave.Size = New System.Drawing.Size(172, 71)
        Me.btnScorePeakSave.TabIndex = 2
        Me.btnScorePeakSave.Text = "&Score Peaks and Save"
        Me.btnScorePeakSave.UseVisualStyleBackColor = True
        '
        'ToolTip
        '
        Me.ToolTip.AutomaticDelay = 0
        Me.ToolTip.AutoPopDelay = 5000000
        Me.ToolTip.InitialDelay = 1
        Me.ToolTip.ReshowDelay = 0
        Me.ToolTip.ShowAlways = True
        Me.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip.ToolTipTitle = "Help:"
        Me.ToolTip.UseAnimation = False
        Me.ToolTip.UseFading = False
        '
        'labelEpochDuration
        '
        Me.labelEpochDuration.AutoSize = True
        Me.labelEpochDuration.Location = New System.Drawing.Point(526, 282)
        Me.labelEpochDuration.Name = "labelEpochDuration"
        Me.labelEpochDuration.Size = New System.Drawing.Size(156, 20)
        Me.labelEpochDuration.TabIndex = 7
        Me.labelEpochDuration.Text = "Epoch duration (ms):"
        '
        'textEpochDuration
        '
        Me.textEpochDuration.Location = New System.Drawing.Point(531, 305)
        Me.textEpochDuration.Name = "textEpochDuration"
        Me.textEpochDuration.ReadOnly = True
        Me.textEpochDuration.Size = New System.Drawing.Size(172, 26)
        Me.textEpochDuration.TabIndex = 8
        Me.textEpochDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'boxDefineMeasures
        '
        Me.boxDefineMeasures.Controls.Add(Me.textMeanLat)
        Me.boxDefineMeasures.Controls.Add(Me.checkMeanLat)
        Me.boxDefineMeasures.Controls.Add(Me.checkMaxLat)
        Me.boxDefineMeasures.Controls.Add(Me.checkMinLat)
        Me.boxDefineMeasures.Controls.Add(Me.checkMeanAmp)
        Me.boxDefineMeasures.Controls.Add(Me.checkMaxAmp)
        Me.boxDefineMeasures.Controls.Add(Me.checkMinAmp)
        Me.boxDefineMeasures.Location = New System.Drawing.Point(20, 285)
        Me.boxDefineMeasures.Name = "boxDefineMeasures"
        Me.boxDefineMeasures.Size = New System.Drawing.Size(494, 145)
        Me.boxDefineMeasures.TabIndex = 9
        Me.boxDefineMeasures.TabStop = False
        Me.boxDefineMeasures.Text = "Define Peak Measures:"
        '
        'textMeanLat
        '
        Me.textMeanLat.Location = New System.Drawing.Point(262, 97)
        Me.textMeanLat.Name = "textMeanLat"
        Me.textMeanLat.Size = New System.Drawing.Size(46, 26)
        Me.textMeanLat.TabIndex = 6
        Me.textMeanLat.Text = "50"
        Me.textMeanLat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'checkMeanLat
        '
        Me.checkMeanLat.AutoSize = True
        Me.checkMeanLat.Checked = True
        Me.checkMeanLat.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkMeanLat.Location = New System.Drawing.Point(316, 99)
        Me.checkMeanLat.Name = "checkMeanLat"
        Me.checkMeanLat.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.checkMeanLat.Size = New System.Drawing.Size(147, 24)
        Me.checkMeanLat.TabIndex = 5
        Me.checkMeanLat.Text = "Area Latency %"
        Me.checkMeanLat.UseVisualStyleBackColor = True
        '
        'checkMaxLat
        '
        Me.checkMaxLat.AutoSize = True
        Me.checkMaxLat.Checked = True
        Me.checkMaxLat.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkMaxLat.Location = New System.Drawing.Point(290, 65)
        Me.checkMaxLat.Name = "checkMaxLat"
        Me.checkMaxLat.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.checkMaxLat.Size = New System.Drawing.Size(168, 24)
        Me.checkMaxLat.TabIndex = 4
        Me.checkMaxLat.Text = "Max. Peak Latency"
        Me.checkMaxLat.UseVisualStyleBackColor = True
        '
        'checkMinLat
        '
        Me.checkMinLat.AutoSize = True
        Me.checkMinLat.Checked = True
        Me.checkMinLat.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkMinLat.Location = New System.Drawing.Point(294, 33)
        Me.checkMinLat.Name = "checkMinLat"
        Me.checkMinLat.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.checkMinLat.Size = New System.Drawing.Size(164, 24)
        Me.checkMinLat.TabIndex = 3
        Me.checkMinLat.Text = "Min. Peak Latency"
        Me.checkMinLat.UseVisualStyleBackColor = True
        '
        'checkMeanAmp
        '
        Me.checkMeanAmp.AutoSize = True
        Me.checkMeanAmp.Checked = True
        Me.checkMeanAmp.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkMeanAmp.Location = New System.Drawing.Point(66, 99)
        Me.checkMeanAmp.Name = "checkMeanAmp"
        Me.checkMeanAmp.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.checkMeanAmp.Size = New System.Drawing.Size(150, 24)
        Me.checkMeanAmp.TabIndex = 2
        Me.checkMeanAmp.Text = "Mean Amplitude"
        Me.checkMeanAmp.UseVisualStyleBackColor = True
        '
        'checkMaxAmp
        '
        Me.checkMaxAmp.AutoSize = True
        Me.checkMaxAmp.Checked = True
        Me.checkMaxAmp.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkMaxAmp.Location = New System.Drawing.Point(30, 65)
        Me.checkMaxAmp.Name = "checkMaxAmp"
        Me.checkMaxAmp.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.checkMaxAmp.Size = New System.Drawing.Size(183, 24)
        Me.checkMaxAmp.TabIndex = 1
        Me.checkMaxAmp.Text = "Max. Peak Amplitude"
        Me.checkMaxAmp.UseVisualStyleBackColor = True
        '
        'checkMinAmp
        '
        Me.checkMinAmp.AutoSize = True
        Me.checkMinAmp.Checked = True
        Me.checkMinAmp.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkMinAmp.Location = New System.Drawing.Point(34, 33)
        Me.checkMinAmp.Name = "checkMinAmp"
        Me.checkMinAmp.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.checkMinAmp.Size = New System.Drawing.Size(179, 24)
        Me.checkMinAmp.TabIndex = 0
        Me.checkMinAmp.Text = "Min. Peak Amplitude"
        Me.checkMinAmp.UseVisualStyleBackColor = True
        '
        'dialogSave
        '
        Me.dialogSave.DefaultExt = "*.csv"
        Me.dialogSave.FileName = "ERP PeakScore Output"
        Me.dialogSave.Filter = "Comma-separated values files (*.csv)|*.csv|All files (*.*)|*.*"
        '
        'textTimepoints
        '
        Me.textTimepoints.Location = New System.Drawing.Point(531, 239)
        Me.textTimepoints.Name = "textTimepoints"
        Me.textTimepoints.ReadOnly = True
        Me.textTimepoints.Size = New System.Drawing.Size(172, 26)
        Me.textTimepoints.TabIndex = 11
        Me.textTimepoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labelTimepoints
        '
        Me.labelTimepoints.AutoSize = True
        Me.labelTimepoints.Location = New System.Drawing.Point(526, 216)
        Me.labelTimepoints.Name = "labelTimepoints"
        Me.labelTimepoints.Size = New System.Drawing.Size(168, 20)
        Me.labelTimepoints.TabIndex = 10
        Me.labelTimepoints.Text = "Number of time points:"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(716, 550)
        Me.ShapeContainer1.TabIndex = 13
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.Color.White
        Me.RectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape2.BorderColor = System.Drawing.Color.White
        Me.RectangleShape2.Location = New System.Drawing.Point(0, 292)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(475, 64)
        '
        'labelEMail
        '
        Me.labelEMail.ActiveLinkColor = System.Drawing.Color.Orange
        Me.labelEMail.AutoSize = True
        Me.labelEMail.BackColor = System.Drawing.Color.White
        Me.labelEMail.ForeColor = System.Drawing.Color.Transparent
        Me.labelEMail.LinkColor = System.Drawing.Color.DimGray
        Me.labelEMail.Location = New System.Drawing.Point(549, 514)
        Me.labelEMail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelEMail.Name = "labelEMail"
        Me.labelEMail.Size = New System.Drawing.Size(154, 20)
        Me.labelEMail.TabIndex = 18
        Me.labelEMail.TabStop = True
        Me.labelEMail.Text = "frsantos@fpce.up.pt"
        Me.labelEMail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(657, 462)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "2013"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'picLabNPF
        '
        Me.picLabNPF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picLabNPF.Image = CType(resources.GetObject("picLabNPF.Image"), System.Drawing.Image)
        Me.picLabNPF.Location = New System.Drawing.Point(16, 460)
        Me.picLabNPF.Name = "picLabNPF"
        Me.picLabNPF.Size = New System.Drawing.Size(326, 80)
        Me.picLabNPF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLabNPF.TabIndex = 16
        Me.picLabNPF.TabStop = False
        '
        'labelFFS
        '
        Me.labelFFS.AutoSize = True
        Me.labelFFS.BackColor = System.Drawing.Color.White
        Me.labelFFS.Location = New System.Drawing.Point(516, 488)
        Me.labelFFS.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelFFS.Name = "labelFFS"
        Me.labelFFS.Size = New System.Drawing.Size(193, 20)
        Me.labelFFS.TabIndex = 19
        Me.labelFFS.Text = "Fernando Ferreira-Santos"
        Me.labelFFS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuFile, Me.menuHelp})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(716, 33)
        Me.MenuStrip.TabIndex = 22
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'menuFile
        '
        Me.menuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuFileOpen, Me.ToolStripSeparator1, Me.menuFileExit})
        Me.menuFile.Name = "menuFile"
        Me.menuFile.Size = New System.Drawing.Size(50, 29)
        Me.menuFile.Text = "&File"
        '
        'menuFileOpen
        '
        Me.menuFileOpen.Name = "menuFileOpen"
        Me.menuFileOpen.Size = New System.Drawing.Size(373, 30)
        Me.menuFileOpen.Text = "&Open ERP File (EEGLAB ASCII export)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(370, 6)
        '
        'menuFileExit
        '
        Me.menuFileExit.Name = "menuFileExit"
        Me.menuFileExit.Size = New System.Drawing.Size(373, 30)
        Me.menuFileExit.Text = "E&xit"
        '
        'menuHelp
        '
        Me.menuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuHelpTooltips, Me.menuHelpDocumentation, Me.menuHelpLicense, Me.ToolStripSeparator2, Me.menuHelpInstructions, Me.menuHelpCitation, Me.ToolStripMenuItem1, Me.menuHelpUpdates})
        Me.menuHelp.Name = "menuHelp"
        Me.menuHelp.Size = New System.Drawing.Size(61, 29)
        Me.menuHelp.Text = "&Help"
        '
        'menuHelpTooltips
        '
        Me.menuHelpTooltips.Checked = True
        Me.menuHelpTooltips.CheckOnClick = True
        Me.menuHelpTooltips.CheckState = System.Windows.Forms.CheckState.Checked
        Me.menuHelpTooltips.Name = "menuHelpTooltips"
        Me.menuHelpTooltips.Size = New System.Drawing.Size(347, 30)
        Me.menuHelpTooltips.Text = "Help &tooltips"
        '
        'menuHelpDocumentation
        '
        Me.menuHelpDocumentation.Name = "menuHelpDocumentation"
        Me.menuHelpDocumentation.Size = New System.Drawing.Size(347, 30)
        Me.menuHelpDocumentation.Text = "&Documentation"
        '
        'menuHelpLicense
        '
        Me.menuHelpLicense.Name = "menuHelpLicense"
        Me.menuHelpLicense.Size = New System.Drawing.Size(347, 30)
        Me.menuHelpLicense.Text = "&License (CC-BY-3.0)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(344, 6)
        '
        'menuHelpInstructions
        '
        Me.menuHelpInstructions.Name = "menuHelpInstructions"
        Me.menuHelpInstructions.Size = New System.Drawing.Size(347, 30)
        Me.menuHelpInstructions.Text = "How to use (&instructions)"
        '
        'menuHelpCitation
        '
        Me.menuHelpCitation.Name = "menuHelpCitation"
        Me.menuHelpCitation.Size = New System.Drawing.Size(347, 30)
        Me.menuHelpCitation.Text = "How to cite (&citation)"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(344, 6)
        '
        'menuHelpUpdates
        '
        Me.menuHelpUpdates.Name = "menuHelpUpdates"
        Me.menuHelpUpdates.Size = New System.Drawing.Size(347, 30)
        Me.menuHelpUpdates.Text = "&Updates? (go to LabNPF website)"
        '
        'picLicense
        '
        Me.picLicense.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picLicense.Image = CType(resources.GetObject("picLicense.Image"), System.Drawing.Image)
        Me.picLicense.Location = New System.Drawing.Point(365, 486)
        Me.picLicense.Name = "picLicense"
        Me.picLicense.Size = New System.Drawing.Size(133, 50)
        Me.picLicense.TabIndex = 23
        Me.picLicense.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 550)
        Me.Controls.Add(Me.picLicense)
        Me.Controls.Add(Me.labelFFS)
        Me.Controls.Add(Me.labelEMail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picLabNPF)
        Me.Controls.Add(Me.textTimepoints)
        Me.Controls.Add(Me.labelTimepoints)
        Me.Controls.Add(Me.boxDefineMeasures)
        Me.Controls.Add(Me.textEpochDuration)
        Me.Controls.Add(Me.labelEpochDuration)
        Me.Controls.Add(Me.boxDefineSettings)
        Me.Controls.Add(Me.labelElectrodes)
        Me.Controls.Add(Me.listElectrodes)
        Me.Controls.Add(Me.btnScorePeakSave)
        Me.Controls.Add(Me.textFile)
        Me.Controls.Add(Me.btnOpenFile)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "ERP PeakScore"
        Me.boxDefineSettings.ResumeLayout(False)
        Me.boxDefineSettings.PerformLayout()
        Me.boxDefineMeasures.ResumeLayout(False)
        Me.boxDefineMeasures.PerformLayout()
        CType(Me.picLabNPF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.picLicense, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOpenFile As System.Windows.Forms.Button
    Friend WithEvents dialogOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents textFile As System.Windows.Forms.TextBox
    Friend WithEvents listElectrodes As System.Windows.Forms.ListBox
    Friend WithEvents labelElectrodes As System.Windows.Forms.Label
    Friend WithEvents boxDefineSettings As System.Windows.Forms.GroupBox
    Friend WithEvents labelSamplingRate As System.Windows.Forms.Label
    Friend WithEvents labelLatencyWindow As System.Windows.Forms.Label
    Friend WithEvents labelComponent As System.Windows.Forms.Label
    Friend WithEvents labelTo As System.Windows.Forms.Label
    Friend WithEvents textLatencyUpper As System.Windows.Forms.TextBox
    Friend WithEvents textLatencyLower As System.Windows.Forms.TextBox
    Friend WithEvents textComponent As System.Windows.Forms.TextBox
    Friend WithEvents textSamplingRate As System.Windows.Forms.TextBox
    Friend WithEvents btnScorePeakSave As System.Windows.Forms.Button
    Friend WithEvents textBaseline As System.Windows.Forms.TextBox
    Friend WithEvents labelBaseline As System.Windows.Forms.Label
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents labelEpochDuration As System.Windows.Forms.Label
    Friend WithEvents textEpochDuration As System.Windows.Forms.TextBox
    Friend WithEvents boxDefineMeasures As System.Windows.Forms.GroupBox
    Friend WithEvents textMeanLat As System.Windows.Forms.TextBox
    Friend WithEvents checkMeanLat As System.Windows.Forms.CheckBox
    Friend WithEvents checkMaxLat As System.Windows.Forms.CheckBox
    Friend WithEvents checkMinLat As System.Windows.Forms.CheckBox
    Friend WithEvents checkMeanAmp As System.Windows.Forms.CheckBox
    Friend WithEvents checkMaxAmp As System.Windows.Forms.CheckBox
    Friend WithEvents checkMinAmp As System.Windows.Forms.CheckBox
    Friend WithEvents dialogSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents textTimepoints As System.Windows.Forms.TextBox
    Friend WithEvents labelTimepoints As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents labelEMail As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picLabNPF As System.Windows.Forms.PictureBox
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents labelFFS As System.Windows.Forms.Label
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents menuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuFileOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuHelpTooltips As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuHelpDocumentation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuHelpInstructions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuHelpCitation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuHelpUpdates As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuHelpLicense As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents picLicense As System.Windows.Forms.PictureBox

End Class
