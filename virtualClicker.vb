Sub VirtualClicker()

Dim x As Integer
Dim addNum As Integer
addNum = Range("D1").Value


x = Range("A1").Value
Range("A1").Value = x + 1

If Range("D1").Value <> 0 Then
    Cells(1, 1).Value = x + addNum
    Range("D1").Value = 0
'this loop adds the value you input in d1 to A1 if you
'click and then resets d1. need to click to add it
    
End If


If Range("A1").Value = 301 Then
    MsgBox ("Goal")
ElseIf Range("A1").Value = 100 Then
    MsgBox ("Good Start")
ElseIf Range("A1").Value = 200 Then
     MsgBox ("Getting there")
     
End If


    
    
    
End Sub
