Imports System
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Collections
Imports System.Drawing
Imports System.Workflow.ComponentModel.Compiler
Imports System.Workflow.ComponentModel.Serialization
Imports System.Workflow.ComponentModel
Imports System.Workflow.ComponentModel.Design
Imports System.Workflow.Runtime
Imports System.Workflow.Activities
Imports System.Workflow.Activities.Rules

'NOTE: When changing the namespace; please update XmlnsDefinitionAttribute in AssemblyInfo.vb
Partial Public class Workflow1
    Inherits SequentialWorkflowActivity
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Private Sub codeActivity1_ExecuteCode(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("sequence 1")
    End Sub

    Private Sub codeActivity2_ExecuteCode(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("sequence 2")
    End Sub

    Private Sub codeActivity3_ExecuteCode(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("parallel left")
    End Sub

    Private Sub codeActivity4_ExecuteCode(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("parallel right")
    End Sub
End Class
