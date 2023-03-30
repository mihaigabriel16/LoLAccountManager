Imports System.IO
Imports System.Net
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class accountForm
    Dim passVisible = False
    Public data = ""
    Dim VBSScript As String = "
        dim script, account
        set script = wscript.CreateObject('WScript.Shell')

        set service = GetObject ('winmgmts:')
        For Each Process In Service.InstancesOf('Win32_Process')
            If Process.Name = 'RiotClientServices.exe' Then
                MsgBox('League seems to be currently open, plz close it and try again')
                WScript.Quit
            End If
        Next

        Eval(Main)

        Function Main()                                                    
            set oExec = script.Exec('D:\Games\Riot Games\League of Legends\LeagueClient.exe')
            Do
                WScript.Sleep 10
            Loop Until oExec.Status = 1
            script.AppActivate 'Riot Client'
            WScript.Sleep 5000
            script.sendkeys '{{username}}'
            script.sendkeys '{TAB}'
            script.sendkeys '{{password}}'
            script.sendkeys '{ENTER}'
        End Function
    "
    Private Sub accountForm_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If passVisible = False Then
            MaskedTextBox1.UseSystemPasswordChar = False
            passVisible = True
        Else
            MaskedTextBox1.UseSystemPasswordChar = True
            passVisible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Public Sub loadData()
        Dim str = data
        Dim splitString() As String = str.Split({"/|\"}, StringSplitOptions.None)
        Label1.Text = splitString(0)
        TextBox1.Text = splitString(1)
        MaskedTextBox1.Text = splitString(2)
        Dim username = splitString(3)

        Dim riot As New RiotAPI("RGAPI-8049eadb-47d6-4962-b7f8-b7862ab1b142", 4)
        GetSummonerInfo(riot, username, Label1.Text)
    End Sub

    Private Sub GetSummonerInfo(ByRef riot, ByVal name, ByVal region)
        Dim summoner As SummonerDTO = riot.GetSummonerByName(name, TranslateRegion(region))
        Dim summoner_league As New List(Of LeagueEntryDTO)
        summoner_league = riot.GetLeagueBySummonerID(summoner.id, TranslateRegion(region))
        For Each item In summoner_league
            Dim rankSolo As String = ""
            If item.queueType = "RANKED_SOLO_5x5" Then
                rankSolo = item.tier & " " & item.rank & " (" & item.leaguePoints & " LP) - " & CalculateWinrate(item.wins, item.losses)
            End If
            Label2.Text = rankSolo
        Next

    End Sub

    Private Function CalculateWinrate(w, l) As String
        Dim wins As Integer = w
        Dim losses As Integer = l
        Dim winRate As Double = wins / CDbl(wins + losses)
        Return ((winRate * 100).ToString("F2") & "%.")
    End Function

    Private Function TranslateRegion(reg As String) As String
        Dim translated As String = ""
        If reg = "EUNE" Then
            translated = "eun1"
        ElseIf reg = "EUW" Then
            translated = "euw1"
        ElseIf reg = "BR" Then
            translated = "br1"
        ElseIf reg = "JP" Then
            translated = "jp1"
        ElseIf reg = "KR" Then
            translated = "kr"
        ElseIf reg = "LAN" Then
            translated = "la1"
        ElseIf reg = "LAS" Then
            translated = "la2"
        ElseIf reg = "NA" Then
            translated = "na1"
        ElseIf reg = "OCE" Then
            translated = "oc1"
        ElseIf reg = "TR" Then
            translated = "tr1"
        ElseIf reg = "RU" Then
            translated = "ru1"
        ElseIf reg = "PBE" Then
            translated = "pbe1"
        End If
        Return translated
    End Function

    Private Sub accountForm_Load_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub createFile()
        Dim vbs = VBSScript
        vbs = vbs.Replace("{{username}}", TextBox1.Text)
        vbs = vbs.Replace("{{password}}", MaskedTextBox1.Text)
        File.WriteAllText("script.vbs", vbs)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

        Dim vbsFilePath As String = "script.vbs"

        Dim fileContents As String = File.ReadAllText(vbsFilePath)
        fileContents = fileContents.Replace("{{username}}", TextBox1.Text)
        fileContents = fileContents.Replace("{{password}}", MaskedTextBox1.Text)
        File.WriteAllText(vbsFilePath, fileContents)


        Dim args As String = "//NoLogo """ & vbsFilePath & """"
        Dim process As New Process()
        process.StartInfo.FileName = "cscript.exe" ' or "wscript.exe"
        process.StartInfo.Arguments = args
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.CreateNoWindow = True
        process.Start()
        Dim output As String = process.StandardOutput.ReadToEnd()
        process.WaitForExit()
        Debug.Print(output)

        fileContents = fileContents.Replace(TextBox1.Text, "{{username}}")
        fileContents = fileContents.Replace(MaskedTextBox1.Text, "{{password}}")
        File.WriteAllText(vbsFilePath, fileContents)

    End Sub
End Class