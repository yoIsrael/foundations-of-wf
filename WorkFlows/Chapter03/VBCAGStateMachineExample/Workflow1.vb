Imports System
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Collections
Imports System.Drawing
Imports System.Workflow.ComponentModel
Imports System.Workflow.ComponentModel.Design
Imports System.Workflow.Runtime
Imports System.Workflow.Activities
Imports System.Workflow.Activities.Rules

'NOTE: When changing the namespace; please update XmlnsDefinitionAttribute in AssemblyInfo.vb
Partial Public class Workflow1
    Inherits StateMachineWorkflowActivity
    Private IntCounter As Integer
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Private Sub Code1_ExecuteCode(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Code1: Counter=" & IntCounter)
    End Sub
    Private Sub Code1WhileCondition(ByVal sender As Object, ByVal e As ConditionalEventArgs)
        e.Result = IntCounter < 4
        IntCounter = IntCounter + 1
    End Sub
    Private Sub Code2WhileCondition(ByVal sender As Object, ByVal e As ConditionalEventArgs)
        e.Result = IntCounter > 4
    End Sub
    Private Sub UntilCondition(ByVal sender As Object, ByVal e As ConditionalEventArgs)
        e.Result = IntCounter = 8
    End Sub

    Private Sub codeActivity1_ExecuteCode(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Code 2: Counter=" & IntCounter)
    End Sub
End Class
