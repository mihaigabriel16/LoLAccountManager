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
        WScript.Sleep {{username}}{{password}}
    Loop Until oExec.Status = {{username}}
    script.AppActivate "Riot Client"
    WScript.Sleep 5{{password}}{{password}}{{password}}
    script.sendkeys "{{username}}"
    script.sendkeys "{TAB}"
    script.sendkeys "{{password}}"
    script.sendkeys "{ENTER}"
End Function
