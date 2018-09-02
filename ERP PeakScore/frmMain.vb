Public Class frmMain
    Public datamatrix0 As String(,) 'temp data matrix
    Public datamatrix As String(,)

    Public optTrimElectrodes As Boolean = False 'Removes last column if true
    Public optTrimTimepoints As Boolean = True 'Removes last row if true
    Public optOutputFormat As String = "short" 'Output CSV may be formatted as 'short' or 'long'

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click

        Dim row As Integer = -1
        Dim col As Integer = -1
        Dim colnames As String()

        If dialogOpen.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            'Try
            listElectrodes.Items.Clear()

            Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(dialogOpen.FileName.ToString)
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters(vbTab)
                Dim alldata = MyReader.ReadToEnd().Split(vbLf)
                colnames = alldata(0).Split(vbTab)
                ReDim datamatrix0(colnames.GetUpperBound(0), alldata.GetUpperBound(0))
            End Using
            Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(dialogOpen.FileName.ToString)
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters(vbTab)
                Dim currentRow As String()
                While Not MyReader.EndOfData
                    Try
                        currentRow = MyReader.ReadFields()
                        row = row + 1
                        Dim currentField As String
                        For Each currentField In currentRow
                            If col = colnames.GetUpperBound(0) Then col = -1
                            col = col + 1
                            datamatrix0(col, row) = currentField
                            'MsgBox(currentField)
                        Next
                    Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                        MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
                    End Try
                End While
            End Using

            'Catch Ex As Exception
            '    MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            'End Try
            'End If

            Dim elec As Integer
            Dim timep As Integer
            If optTrimElectrodes = True Then
                elec = datamatrix0.GetUpperBound(0) - 1
            Else
                elec = datamatrix0.GetUpperBound(0)
            End If
            If optTrimTimepoints = True Then
                timep = datamatrix0.GetUpperBound(1) - 1
            Else
                timep = datamatrix0.GetUpperBound(1)
            End If

            ReDim datamatrix(elec, timep)

            For i = 0 To elec
                For j = 0 To timep
                    datamatrix(i, j) = datamatrix0(i, j)
                Next j
            Next i

            textFile.Text = dialogOpen.FileName.ToString

            For i = 0 To datamatrix.GetUpperBound(0)
                listElectrodes.Items.Add(datamatrix(i, 0))
            Next i

            labelElectrodes.Text = "Electrodes (" + listElectrodes.Items.Count.ToString + "):"

            textTimepoints.Text = CStr(datamatrix.GetLength(1)) - 1

            If textFile.Text <> "" And textSamplingRate.Text <> "" Then
                textEpochDuration.Text = CStr(CDbl(datamatrix.GetUpperBound(1)) / CDbl(textSamplingRate.Text)) * 1000
            ElseIf textSamplingRate.Text = "" Then
                textEpochDuration.Text = "Not available"
            End If

        End If
    End Sub

    Private Sub textSamplingRate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textSamplingRate.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub textBaseline_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBaseline.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub textLatencyLower_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textLatencyLower.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub textLatencyUpper_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textLatencyUpper.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "ERP PeakScore (version " + My.Application.Info.Version.ToString + ")"

        ToolTip.SetToolTip(Me.btnOpenFile, "Click to select a file to open")

        ToolTip.SetToolTip(Me.labelElectrodes, "List of electrode names in the file -- updated whenever a file if opened.")
        ToolTip.SetToolTip(Me.listElectrodes, "List of electrode names in the file -- updated whenever a file if opened.")
        ToolTip.SetToolTip(Me.labelTimepoints, "Number of EEG data timepoints -- updated whenever a file if opened.")
        ToolTip.SetToolTip(Me.textTimepoints, "Number of EEG data timepoints -- updated whenever a file if opened.")
        ToolTip.SetToolTip(Me.labelEpochDuration, "Duration of the whole EEG/ERP epoch (make sure you have defined the correct sampling rate)" + Environment.NewLine + " -- updated whenever a file if opened OR sampling rate is changed.")
        ToolTip.SetToolTip(Me.textEpochDuration, "Duration of the whole EEG/ERP epoch (make sure you have defined the correct sampling rate)" + Environment.NewLine + " -- updated whenever a file if opened OR sampling rate is changed.")

        ToolTip.SetToolTip(Me.labelSamplingRate, "Define the sampling rate of the ERP file in Hz." + Environment.NewLine + "Input numerical characters only.")
        ToolTip.SetToolTip(Me.textSamplingRate, "Define the sampling rate of the ERP file in Hz." + Environment.NewLine + "Input numerical characters only.")
        ToolTip.SetToolTip(Me.labelComponent, "Define the name of the component to measure" + Environment.NewLine + "Input a-z, A-Z, or numerical characters only.")
        ToolTip.SetToolTip(Me.textComponent, "Define the name of the component to measure" + Environment.NewLine + "Input a-z, A-Z, or numerical characters only.")
        ToolTip.SetToolTip(Me.labelBaseline, "Indicate the duration of the ERP baseline (if any) in ms." + Environment.NewLine + "Note that you should indicate the absolute duration of the baseline (e.g., 100 ms)" + Environment.NewLine + " and NOT the value of the baseline in relation to the event onset (e.g., do not input -100 ms)." + Environment.NewLine + "Input numerical characters only.")
        ToolTip.SetToolTip(Me.textBaseline, "Indicate the duration of the ERP baseline (if any) in ms." + Environment.NewLine + "Note that you should indicate the absolute duration of the baseline (e.g., 100 ms)" + Environment.NewLine + " and NOT the value of the baseline in relation to the event onset (e.g., do not input -100 ms)." + Environment.NewLine + "Input numerical characters only.")
        ToolTip.SetToolTip(Me.labelLatencyWindow, "Define the lower and upper limits of the latency window (in ms) where the component will be measured." + Environment.NewLine + "Indicate the post-event onsent latency (i.e., assume the event ocurred at time 0 ms)." + Environment.NewLine + "Input numerical characters only.")
        ToolTip.SetToolTip(Me.textLatencyLower, "Define the lower and upper limits of the latency window (in ms) where the component will be measured." + Environment.NewLine + "Indicate the post-event onsent latency (i.e., assume the event ocurred at time 0 ms)." + Environment.NewLine + "Input numerical characters only.")
        ToolTip.SetToolTip(Me.labelTo, "Define the lower and upper limits of the latency window (in ms) where the component will be measured." + Environment.NewLine + "Indicate the post-event onsent latency (i.e., assume the event ocurred at time 0 ms)." + Environment.NewLine + "Input numerical characters only.")
        ToolTip.SetToolTip(Me.textLatencyUpper, "Define the lower and upper limits of the latency window (in ms) where the component will be measured." + Environment.NewLine + "Indicate the post-event onsent latency (i.e., assume the event ocurred at time 0 ms)." + Environment.NewLine + "Input numerical characters only.")

        ToolTip.SetToolTip(Me.checkMinAmp, "Minimum amplitude in the latency window.")
        ToolTip.SetToolTip(Me.checkMaxAmp, "Maximum amplitude in the latency window.")
        ToolTip.SetToolTip(Me.checkMeanAmp, "Mean amplitude in the latency window.")
        ToolTip.SetToolTip(Me.checkMinLat, "Latency of the minimum amplitude point.")
        ToolTip.SetToolTip(Me.checkMaxLat, "Latency of the maximum amplitude point.")
        ToolTip.SetToolTip(Me.checkMeanLat, "Latency where the amplitude area within the latency window reaches a given percentage of the total area.")
        ToolTip.SetToolTip(Me.textMeanLat, "Define the area percent for which latency will be measured." + Environment.NewLine + "Input a number between 1 and 100.")

        ToolTip.SetToolTip(Me.btnScorePeakSave, "Click to score ERP peaks and save the output file." + Environment.NewLine + Environment.NewLine + "If there are errors, a message box will appear and you will have to go back and correct the error." + Environment.NewLine + "Otherwise, select a name for the output file." + Environment.NewLine + "This will be a ASCII comma-separated value (CSV) file," + Environment.NewLine + "which can be conveniently opened in a spreadsheet program.")

        ToolTip.SetToolTip(Me.picLabNPF, "Click to visit the website of the Laboratory of Neuropsychophysiology" + Environment.NewLine + "(http://www.fpce.up.pt/labpsi).")
        ToolTip.SetToolTip(Me.picLicense, " This work is licensed under the Creative Commons Attribution 3.0 Unported License." + Environment.NewLine + "Click to view a copy of the license online (http://creativecommons.org/licenses/by/3.0/).")

        labelEMail.Links.Add(0, labelEMail.Text.Length, "mailto:frsantos@fpce.up.pt")

    End Sub

    Private Sub textComponent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textComponent.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers
        If Asc(e.KeyChar) <> 8 Then
            e.Handled = True
            If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Then
                e.Handled = False
            End If
        End If
    End Sub

    Private Sub textSamplingRate_TextChanged(sender As Object, e As EventArgs) Handles textSamplingRate.TextChanged
        If textFile.Text <> "" And textSamplingRate.Text <> "" Then
            textEpochDuration.Text = CStr(CDbl(datamatrix.GetUpperBound(1)) / CDbl(textSamplingRate.Text)) * 1000
        ElseIf textSamplingRate.Text = "" Then
            textEpochDuration.Text = "Not available"
        End If
    End Sub

    Private Sub btnScorePeakSave_Click(sender As Object, e As EventArgs) Handles btnScorePeakSave.Click
        '(1) Check for errors (e.g., baseline>epoch; lat_window>epoch; baseline + latwindow>epoch
        If textFile.Text = "" Then
            MsgBox("No file selected.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If checkMinAmp.Checked = False And checkMaxAmp.Checked = False And checkMeanAmp.Checked = False And checkMinLat.Checked = False And checkMaxLat.Checked = False And checkMeanLat.Checked = False Then
            MsgBox("Setting not defined: No output peak measures were selected.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If textSamplingRate.Text = "" Then
            MsgBox("Setting not defined: Sampling Rate.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If textComponent.Text = "" Then
            MsgBox("Setting not defined: Component Name.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If textBaseline.Text = "" Then
            MsgBox("Setting not defined: Baseline (if there is no baseline, set to 0 ms).", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If textLatencyLower.Text = "" Then
            MsgBox("Setting not defined: Lower end of latency window.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If textLatencyUpper.Text = "" Then
            MsgBox("Setting not defined: Upper end of latency window.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If CDbl(textLatencyLower.Text) >= CDbl(textLatencyUpper.Text) Then
            MsgBox("Settings error: Upper end of latency window is smaller or equal to the lower end. The upper end of the latency window must be larger than the lower end.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If textMeanLat.Text = "" Then
            MsgBox("Setting not defined: Percent of area latency (must be a value between 1 and 100)." + vbLf + vbLf + "Due to programmer laziness, the code will not work unless you specify this, even if this measure in not checked (sorry! If you are unsure about what to do, just input the default value of 50).", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf textMeanLat.Text <> "" Then
            If (CDbl(textMeanLat.Text) < 1 Or CDbl(textMeanLat.Text) > 100) Then
                MsgBox("Settings error: Percent of area latency to measure must be a value between 1 and 100.", MsgBoxStyle.Critical)
                Exit Sub
            End If
        End If

        '(2)Define CSV output file to save:
        If dialogSave.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            Dim file = My.Computer.FileSystem.OpenTextFileWriter(dialogSave.FileName, False)
            file.WriteLine("component,measure,electrode,value")

            '(3)Calculate peak measures:
            Dim ampMax, ampMin, ampSum, ampSumAbs, ampMean, latMax, latMin, latArea, sumArea, fractionalArea, latMaxMS, latMinMS, latAreaMS As Double
            Dim baseline As Double = Math.Round(CDbl(textBaseline.Text) * CDbl(textSamplingRate.Text) / 1000)
            Dim lat_lower As Double = Math.Round(CDbl(textLatencyLower.Text) * CDbl(textSamplingRate.Text) / 1000)
            Dim lat_upper As Double = Math.Round(CDbl(textLatencyUpper.Text) * CDbl(textSamplingRate.Text) / 1000)

            For elec = 0 To datamatrix.GetUpperBound(0)
                'initialize ampMax, ampMin, latMax, latMin to first value of latency window
                ampMax = CDbl(datamatrix(elec, baseline + lat_lower))
                latMax = baseline + lat_lower
                ampMin = CDbl(datamatrix(elec, baseline + lat_lower))
                latMin = baseline + lat_lower
                ampSum = 0
                ampSumAbs = 0
                sumArea = 0

                For i = (baseline + lat_lower) To (baseline + lat_upper)
                    If CDbl(datamatrix(elec, i)) > ampMax Then
                        ampMax = Math.Max(ampMax, CDbl(datamatrix(elec, i)))
                        latMax = i
                    ElseIf CDbl(datamatrix(elec, i)) < ampMin Then
                        ampMin = Math.Min(ampMin, CDbl(datamatrix(elec, i)))
                        latMin = i
                    End If
                    ampSum = ampSum + CDbl(datamatrix(elec, i))
                    ampSumAbs = ampSumAbs + Math.Abs(CDbl(datamatrix(elec, i)))
                Next i

                ampMean = ampSum / ((baseline + lat_upper) - (baseline + lat_lower) + 1)

                'Fractional area info: http://erpinfo.org/erplab/erplab-documentation/manual/ERP_Measurement_Tool.html
                fractionalArea = ampSumAbs * (CDbl(textMeanLat.Text) / 100)
                For j = (baseline + lat_lower) To (baseline + lat_upper)
                    sumArea = sumArea + Math.Abs(CDbl(datamatrix(elec, j)))
                    If sumArea >= fractionalArea Then
                        latArea = j
                        Exit For
                    End If
                Next j

                'convert latency_timepoints to latency_ms
                latMaxMS = (latMax * 1000 / CDbl(textSamplingRate.Text)) - CDbl(textBaseline.Text)
                latMinMS = (latMin * 1000 / CDbl(textSamplingRate.Text)) - CDbl(textBaseline.Text)
                latAreaMS = (latArea * 1000 / CDbl(textSamplingRate.Text)) - CDbl(textBaseline.Text)

                '(4)save measures for electrode 'elec' and move to next electrode
                If checkMinAmp.Checked = True Then
                    file.WriteLine(textComponent.Text + "," + "MinAmp," + datamatrix(elec, 0) + "," + CStr(ampMin))
                End If

                If checkMaxAmp.Checked = True Then
                    file.WriteLine(textComponent.Text + "," + "MaxAmp," + datamatrix(elec, 0) + "," + CStr(ampMax))
                End If

                If checkMeanAmp.Checked = True Then
                    file.WriteLine(textComponent.Text + "," + "MeanAmp," + datamatrix(elec, 0) + "," + CStr(ampMean))
                End If

                If checkMinLat.Checked = True Then
                    file.WriteLine(textComponent.Text + "," + "MinLat," + datamatrix(elec, 0) + "," + CStr(latMinMS))
                End If

                If checkMaxLat.Checked = True Then
                    file.WriteLine(textComponent.Text + "," + "MaxLat," + datamatrix(elec, 0) + "," + CStr(latMaxMS))
                End If

                If checkMeanLat.Checked = True Then
                    file.WriteLine(textComponent.Text + "," + "AreaLat," + datamatrix(elec, 0) + "," + CStr(latAreaMS))
                End If
            Next elec

            file.Close()
        End If
    End Sub

    Private Sub labelEMail_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles labelEMail.LinkClicked
        Dim target As String = CType(e.Link.LinkData, String)

        ' If the value looks like a URL, navigate to it. 
        If (target IsNot Nothing) Then
            System.Diagnostics.Process.Start(target)
        End If

    End Sub

    Private Sub picLabNPF_Click(sender As Object, e As EventArgs) Handles picLabNPF.Click
        System.Diagnostics.Process.Start("www.fpce.up.pt/labpsi/?lang=en")
    End Sub

    Private Sub textMeanLat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textMeanLat.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub menuFileExit_Click(sender As Object, e As EventArgs) Handles menuFileExit.Click
        End
    End Sub

    Private Sub menuHelpDocumentation_Click(sender As Object, e As EventArgs) Handles menuHelpDocumentation.Click
        Try
            System.Diagnostics.Process.Start(My.Application.Info.DirectoryPath + "\Readme.txt")
        Catch ex As Exception
            MsgBox("Error: " + ex.Message.ToString)
        End Try
    End Sub

    Private Sub menuHelpTooltips_CheckedChanged(sender As Object, e As EventArgs) Handles menuHelpTooltips.CheckedChanged
        ToolTip.Active = menuHelpTooltips.Checked
    End Sub

    Private Sub menuHelpUpdates_Click(sender As Object, e As EventArgs) Handles menuHelpUpdates.Click
        System.Diagnostics.Process.Start("www.fpce.up.pt/labpsi/index.php?page=13&level=2&lang=en")
    End Sub


    Private Sub picLicense_Click(sender As Object, e As EventArgs) Handles picLicense.Click
        System.Diagnostics.Process.Start("http://creativecommons.org/licenses/by/3.0/")
    End Sub

    Private Sub menuHelpLicense_Click(sender As Object, e As EventArgs) Handles menuHelpLicense.Click
        If MsgBox("This work is licensed under the Creative Commons Attribution 3.0 Unported License. To view a copy of this license, visit http://creativecommons.org/licenses/by/3.0/ or send a letter to Creative Commons, 171 Second Street, Suite 300, San Francisco, California 94105, USA." + Environment.NewLine + Environment.NewLine + "Would you like to see the license on your web browser now?", vbYesNo) = vbYes Then
            System.Diagnostics.Process.Start("http://creativecommons.org/licenses/by/3.0/")
        End If
    End Sub

    Private Sub menuFileOpen_Click(sender As Object, e As EventArgs) Handles menuFileOpen.Click
        btnOpenFile_Click(Me, EventArgs.Empty)
    End Sub

    Private Sub menuHelpInstructions_Click(sender As Object, e As EventArgs) Handles menuHelpInstructions.Click
        Try
            System.Diagnostics.Process.Start(My.Application.Info.DirectoryPath + "\Instructions.txt")
        Catch ex As Exception
            MsgBox("Error: " + ex.Message.ToString)
        End Try
    End Sub

    Private Sub menuHelpCitation_Click(sender As Object, e As EventArgs) Handles menuHelpCitation.Click
        Try
            System.Diagnostics.Process.Start(My.Application.Info.DirectoryPath + "\Citation.txt")
        Catch ex As Exception
            MsgBox("Error: " + ex.Message.ToString)
        End Try
    End Sub
End Class
