Imports System.IO
Imports Vosk
''scratched my previous work trying to utilize an open source set of controls.
''it was too difficult finding a working control within the set, much less one which properly inherited the behavior of it's original.
''it'll be ugly initially, but can be updated/prettied later.  winforms aren't really meant for "pretty" imo.
Public Class frmWinCtrls
    'Private spkModel As New SpkModel("vosk-model-spk-0.4")
    'Private vskModel As New Model("vosk-model-en-us-0.22")
    'Private vskRecog As New VoskRecognizer(model, 16000.0F)
    Private spkModel As SpkModel
    Private vskModel As Model
    Private vskRecog As VoskRecognizer
    Private Sub frmWinCtrls_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''could implement dynamic theming at-launch, or similar, later.
        'Using tmpKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Themes\Personalize")
        '    If tmpKey IsNot Nothing AndAlso DirectCast(tmpKey.GetValue("AppsUseLightTheme", 1), Integer) = 1 Then
        '        ''apply light theme here
        '        '
        '    Else
        '        ''apply dark theme here
        '        '
        '    End If
        'End Using 'end/dispose tmpKey
    End Sub
    Private Sub frmWinCtrls_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
    Private Sub btnSPKModel_Click(sender As Object, e As EventArgs) Handles btnSPKModel.Click, btnVoskModel.Click, btnWAVFile.Click, btnRun.Click
        Dim tstobj As Object = Nothing
        Dim btnCtrl As System.Windows.Forms.Button = DirectCast(sender, System.Windows.Forms.Button)
        ''determine what to do based on which control was clicked
        Select Case btnCtrl.Name
            ''first group contains those which select a single directory
            Case "btnSPKModel", "btnVoskModel"
                ''load the SPK model/Vosk model
                Using fldrBrwsrDlg As New FolderBrowserDialog() With {.Description = "Select " & btnCtrl.Name.Substring(3) & ":", .ShowNewFolderButton = False}
                    ''checking if the dialog result is OK
                    'Dim dlgrslt As DialogResult = fldrBrwsrDlg.ShowDialog()
                    If fldrBrwsrDlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
                        ''the below *could* be put into a "ternary" (looking at you c#), but historically-speaking, VB has a bad rep with them.
                        ''i like to manually switch-case for clear debugging (at least) and for further expansion in the future (at most).
                        ''set the folder path in the relevant textbox
                        Select Case btnCtrl.Name 'again, ugh, but there may be additional features added later, like grammar files, punctuation files, etc.
                                ''break group-case into solo-case for individual behaviors.
                            Case "btnSPKModel"
                                txtSPKModel.Text = fldrBrwsrDlg.SelectedPath 'reflect to user the file they selected
                                spkModel = New SpkModel(fldrBrwsrDlg.SelectedPath) 'load spk model
                            Case "btnVoskModel"
                                ''*should* be a Case Else, but to catch-all within a unique sub case, seems excessive.
                                ''will use Else when the "majority" of particular group will do the same thing, leaving the snowflakes in their own Cases
                                txtVoskModel.Text = fldrBrwsrDlg.SelectedPath 'reflect to user the file they selected
                                vskModel = New Model(fldrBrwsrDlg.SelectedPath) 'load vosk model
                        End Select 'end select for uniques
                        ''whichever btn it is, let's disable, forcing an application reload if another model desired (there's only the one SPK at present, iirc)
                        ''these models can get very large and eat up a lot of memory.
                        btnCtrl.Enabled = False 'never to re-enable again, to force clean (and avoid the logic needed to handle (re-)populating the vosk objs)
                        ''relabel using button's own name, this behavior would need to be moved into the below cases if ever translated from english.
                        btnCtrl.Text &= "ed" 'inform the user their models have loaded successfully.
                        ''regardless of button selected, check if both (or however many in the future) are satisfied and the buttons are disabled.
                        ''if all criteria met, proceed to populating the vosk recognizer
                        If btnSPKModel.Enabled = False AndAlso btnVoskModel.Enabled = False Then
                            ''assume this means both spk and vosk model have been selected successfully, to have made it this far
                            vskRecog = New VoskRecognizer(vskModel, 16000.0F)
                            vskRecog.SetSpkModel(spkModel)
                        End If
                    End If 'end check if OK
                End Using 'end/dispose fldrBrwsrDlg
            Case "btnWAVFile"
                ''select WAV file
                Using opnFiDlg As New OpenFileDialog() With {.DefaultExt = ".wav", .Filter = "WAV files (.wav)|*.wav", .Title = "Select " & btnCtrl.Name.Substring(3) & ":"}
                    If opnFiDlg.ShowDialog() = DialogResult.OK Then
                        txtWAVFile.Text = opnFiDlg.FileName
                        txtOutput.Text = String.Empty
                    End If 'end check if OK
                End Using 'end/dispose opnFiDlg
            Case "btnRun"
                ''i'm not 100% on how i want to disable/enable without being cumbersome to the user
                ''for now, just going to disable/reenable at the beginning/end.
                btnRun.Enabled = False
                ''confirm all necessary buttons selected and populated (and therefore disabled) before processing
                If btnSPKModel.Enabled = False AndAlso btnVoskModel.Enabled = False AndAlso IO.File.Exists(txtWAVFile.Text) Then
                    Dim updFiStr As String = txtWAVFile.Text & "-16000.16.1-PCM.wav"
                    cnvrtaudio(txtWAVFile.Text, updFiStr)
                    If IO.File.Exists(updFiStr) Then
                        DemoSpeaker(updFiStr)
                        IO.File.Delete(updFiStr) 'clean up after either converting/copying to a new file.
                    End If
                End If
                ''call process
                btnRun.Enabled = True
        End Select 'end select grouped actions.
        tstobj = Nothing
    End Sub
    ''below is the c# example from the vosk repo converted.  i'm sure there's a smarter/better way...
    Private Sub DemoSpeaker(ByVal srcFi As String)
        Using source As Stream = File.OpenRead(srcFi)
            Dim buffer As Byte() = New Byte(4095) {}
            Dim bytesRead As Integer
            While (CSharpImpl.__Assign(bytesRead, source.Read(buffer, 0, buffer.Length))) > 0
                If vskRecog.AcceptWaveform(buffer, bytesRead) Then
                    txtOutput.AppendText(vskRecog.Result())
                Else
                    ''do nothing if partials aren't desired.
                    If chkInclParts.Checked Then txtOutput.AppendText(vskRecog.PartialResult())
                End If
            End While
        End Using
        txtOutput.AppendText(vskRecog.FinalResult())
    End Sub
    Private Class CSharpImpl
        '<Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
        Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
            target = value
            Return value
        End Function
    End Class
    Private Sub cnvrtaudio(ByVal srcFi As String, ByVal destFi As String)
        Dim tstobj As Object = Nothing
        Using wvfirdr As New NAudio.Wave.WaveFileReader(srcFi)
            If wvfirdr.WaveFormat.SampleRate = 16000 AndAlso wvfirdr.WaveFormat.BitsPerSample = 16 AndAlso wvfirdr.WaveFormat.Channels = 1 Then
                'If file is sampled at 16000Hz, using a single channel, and reads 16 bits per sample.
                ''file already in proper format, copy over
                IO.File.Copy(srcFi, destFi, True)
            Else
                ''file not in correct format, get it
                Dim pcmfmt As New NAudio.Wave.WaveFormat(16000, 16, 1)
                Using pcmstrm As NAudio.Wave.WaveStream = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(wvfirdr)
                    Using upsmplr As New NAudio.Wave.WaveFormatConversionStream(pcmfmt, pcmstrm)
                        NAudio.Wave.WaveFileWriter.CreateWaveFile(destFi, upsmplr)
                    End Using
                End Using 'end/dispose pcm stream
            End If
        End Using 'end/dispose wav stream
    End Sub 'end cnvrtaudio
End Class