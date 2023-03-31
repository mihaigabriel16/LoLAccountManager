Imports System.IO
Imports System.Management
Imports System.Net
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports HtmlAgilityPack
Public Class accountForm
    Dim passVisible = False
    Public data = ""
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

    Private Sub ScrapeOpGG(ByVal name, ByVal region)
        Dim playerProfileUrl As String = "https://" & region & ".op.gg/summoner/userName=" & name

        Dim web As New HtmlWeb()
        Dim doc As HtmlDocument = web.Load(playerProfileUrl)

        Dim divisionNode As HtmlNode = doc.DocumentNode.SelectSingleNode("//div[@class='tier']")
        Dim lpNode As HtmlNode = doc.DocumentNode.SelectSingleNode("//div[@class='lp']")
        Dim winrateNode As HtmlNode = doc.DocumentNode.SelectSingleNode("//div[@class='ratio']")
        Dim division As String = divisionNode.InnerText.Trim()
        Dim lp As String = lpNode.InnerText.Trim()
        Dim winrate As String = winrateNode.InnerText.Trim()
        winrate = GetWinrateFromString(winrate)

        Label2.Text = division & " (" & lp & ") - " & winrate
    End Sub

    Private Function GetWinrateFromString(ByVal text)
        Dim pattern As String = "[\d%]+"
        Dim match = Regex.Match(text, pattern)
        Dim outputString As String = match.Value
        Return outputString
    End Function

    Public Sub loadData()
        Dim str = data
        Dim splitString() As String = str.Split({"|"}, StringSplitOptions.None)
        Label1.Text = splitString(0)
        TextBox1.Text = splitString(1)
        MaskedTextBox1.Text = splitString(2)
        Dim username = splitString(3)

        Dim riot As New RiotAPI(My.Settings.APIKey, 4)
        If My.Settings.LocalAPI = True Then
            GetSummonerInfo(riot, username, Label1.Text)
        Else
            ScrapeOpGG(username, Label1.Text)
        End If
    End Sub

    Private Sub GetSummonerInfo(ByRef riot, ByVal name, ByVal region)
        Dim summoner As SummonerDTO = riot.GetSummonerByName(name, TranslateRegion(region))
        Dim summoner_league As New List(Of LeagueEntryDTO)
        summoner_league = riot.GetLeagueBySummonerID(summoner.id, TranslateRegion(region))
        For Each item In summoner_league
            If item.queueType = "RANKED_SOLO_5x5" Then
                Label2.Text = item.tier & " " & item.rank & " (" & item.leaguePoints & " LP) - " & CalculateWinrate(item.wins, item.losses)
            End If
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

    Private Sub StartGame()
        Dim vbsFilePath As String = "script.vbs"

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
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If String.IsNullOrEmpty(My.Settings.LoLPath) Then
            MsgBox("League of Legends Path is empty. Please set it in the Settings.", MsgBoxStyle.OkOnly)
            settingsForm.ShowDialog()
        Else
            Dim myProcess As New Process()
            myProcess.StartInfo.FileName = My.Settings.LoLPath & "\LeagueClient.exe"
            myProcess.Start()
            myProcess.WaitForInputIdle()
            Thread.Sleep(1000)
            SendKeys.Send(TextBox1.Text)
            SendKeys.Send("{TAB}")
            SendKeys.Send(MaskedTextBox1.Text)
            SendKeys.Send("{ENTER}")
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub accountForm_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim edit As New editAccount
        edit.loadData(data)
        edit.ShowDialog()
    End Sub
End Class