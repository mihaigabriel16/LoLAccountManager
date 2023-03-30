dim script, account
set script = wscript.CreateObject("WScript.Shell")

set service = GetObject ("winmgmts:")
For Each Process In Service.InstancesOf("Win32_Process")
    If Process.Name = "RiotClientServices.exe" Then
        MsgBox("League seems to be currently open, plz close it and try again")
        'WScript.Echo "League client running"
        WScript.Quit
    End If
Next


Eval(Main)


Function Main()                                                         'Change for main account
    set oExec = script.Exec("D:\Games\Riot Games\League of Legends\LeagueClient.exe")
    Do
        WScript.Sleep 10
    Loop Until oExec.Status = 1
    script.AppActivate "Riot Client"
    WScript.Sleep 5000
    script.sendkeys "mihaigabriel1608"
    script.sendkeys "{TAB}"
    script.sendkeys "Pd6maen6x2cwe!"
    script.sendkeys "{ENTER}"
End Function
