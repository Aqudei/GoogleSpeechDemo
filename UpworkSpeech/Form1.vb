Option Strict On
Imports System.IO
Imports System.Threading
Imports Google.Cloud.Speech.V1
Imports Google.Cloud.TextToSpeech.V1
Imports NAudio.Wave

Public Class Form1

    Private Async Function StreamingMicRecognizeAsync(ByVal seconds As Integer) As Task(Of Integer)
        If NAudio.Wave.WaveIn.DeviceCount < 1 Then
            Debug.WriteLine("No microphone!")
            Return -1
        End If

        Debug.WriteLine($"Capturing {seconds} seconds for speech-to-text...")

        Dim speech = SpeechClient.Create()
        Dim streamingCall = speech.StreamingRecognize()
        Await streamingCall.WriteAsync(New StreamingRecognizeRequest() With {
            .StreamingConfig = New StreamingRecognitionConfig() With {
                .Config = New RecognitionConfig() With {
                    .Encoding = RecognitionConfig.Types.AudioEncoding.Linear16,
                    .SampleRateHertz = 16000,
                    .LanguageCode = "en"
                },
                .InterimResults = True
            }
        })

        Dim printResponses As Task = Task.Run(Async Function()
                                                  While Await streamingCall.ResponseStream.MoveNext()
                                                      For Each result In streamingCall.ResponseStream.Current.Results
                                                          For Each alternative In result.Alternatives
                                                              Debug.WriteLine(alternative.Transcript)
                                                              SetResult(alternative.Transcript)
                                                          Next
                                                      Next
                                                  End While
                                              End Function)

        Dim writeLock As Object = New Object()
        Dim writeMore As Boolean = True

        Dim waveIn = New NAudio.Wave.WaveInEvent()

        Using waveIn
            waveIn.DeviceNumber = 0
            waveIn.WaveFormat = New NAudio.Wave.WaveFormat(16000, 1)
            AddHandler waveIn.DataAvailable, Sub(ByVal sender As Object, ByVal args As NAudio.Wave.WaveInEventArgs)
                                                 SyncLock writeLock
                                                     If Not writeMore Then Return
                                                     streamingCall.WriteAsync(New StreamingRecognizeRequest() With {
                                                    .AudioContent = Google.Protobuf.ByteString.CopyFrom(args.Buffer, 0, args.BytesRecorded)}).Wait()
                                                 End SyncLock
                                             End Sub

            waveIn.StartRecording()
            Debug.WriteLine("Speak now.")
            SetInfo("Speak Now!")
            Await Task.Delay(TimeSpan.FromSeconds(seconds))
            waveIn.StopRecording()

            SyncLock writeLock
                writeMore = False
            End SyncLock

            Await streamingCall.WriteCompleteAsync()
            Await printResponses
        End Using
        Return 0
    End Function

    Private Sub SetInfo(v As String)
        Label1.Invoke(New Action(Sub()
                                     Label1.Text = v
                                 End Sub))
    End Sub


    Private Sub SetResult(v As String)
        Label1.Invoke(New Action(Sub()
                                     ResultTextBox.Text = v
                                 End Sub))
    End Sub


    Private Async Sub SpeechToTextButton_Click(sender As Object, e As EventArgs) Handles SpeechToTextButton.Click

        Dim result As Integer = Nothing

        ' parse number of seconds to capture audio from microphone

        If Not Integer.TryParse(NumSecondsTextBox.Text, result) Then
            ' If not successfull, default to 5 seconds
            result = 5
        End If

        Label1.Text = "Please wait..."

        Await StreamingMicRecognizeAsync(5)
        Label1.Text = "Done."
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Async Sub SaveAsMP3Button_Click(sender As Object, e As EventArgs) Handles SaveAsMP3Button.Click
        Dim rslt = SaveFileDialog1.ShowDialog
        If rslt <> DialogResult.OK Then
            Return
        End If
        Dim destination = SaveFileDialog1.FileName

        ProgressBar1.Visible = True
        Dim temp_mp3_file = Await RunTextToSpeech()
        If String.IsNullOrWhiteSpace(temp_mp3_file) Or Not File.Exists(temp_mp3_file) Then
            ProgressBar1.Visible = False
            Return
        End If

        File.Copy(temp_mp3_file, destination, True)
        ProgressBar1.Visible = False
    End Sub

    Private Function RunTextToSpeech() As Task(Of String)

        Return Task.Run(Function()
                            Dim temp = Path.GetTempFileName()

                            If String.IsNullOrWhiteSpace(InputTextBox.Text) Then
                                Return String.Empty
                            End If

                            Dim client As TextToSpeechClient = TextToSpeechClient.Create()
                            Dim input As SynthesisInput = New SynthesisInput With {
                                .Text = InputTextBox.Text
                            }
                            Dim voice As VoiceSelectionParams = New VoiceSelectionParams With {
                                .LanguageCode = "en-US",
                                .SsmlGender = SsmlVoiceGender.Neutral
                            }
                            Dim config As AudioConfig = New AudioConfig With {
                                .AudioEncoding = AudioEncoding.Mp3
                            }
                            Dim response = client.SynthesizeSpeech(New SynthesizeSpeechRequest With {
                                .Input = input,
                                .Voice = voice,
                                .AudioConfig = config
                            })

                            Using output As Stream = File.Create(temp)
                                response.AudioContent.WriteTo(output)
                                Debug.WriteLine($"Audio content written to file '{temp}'")
                                Return temp
                            End Using
                        End Function)
    End Function

    Private Async Sub PlayImmediatelyButton_Click(sender As Object, e As EventArgs) Handles PlayImmediatelyButton.Click
        ProgressBar1.Visible = True
        Dim temp_mp3_file = Await RunTextToSpeech()

        If String.IsNullOrWhiteSpace(temp_mp3_file) Or Not File.Exists(temp_mp3_file) Then
            ProgressBar1.Visible = False
            Return
        End If

        Dim _waveOut = New WaveOutEvent()
        Dim _mp3Reader = New Mp3FileReader(temp_mp3_file)

        Using _waveOut
            Using _mp3Reader
                _waveOut.Init(_mp3Reader)
                Debug.WriteLine("Now playing...")
                _waveOut.Play()

                While _waveOut.PlaybackState <> PlaybackState.Stopped
                    Thread.Sleep(16)
                    Application.DoEvents()
                End While


                Debug.WriteLine("Done playing.")
            End Using


            ProgressBar1.Visible = False
        End Using
    End Sub
End Class
