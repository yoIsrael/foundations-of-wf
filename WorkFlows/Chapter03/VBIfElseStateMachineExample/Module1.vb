Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Threading
Imports System.Workflow.Runtime
Imports System.Workflow.Runtime.Hosting

'NOTE: When changing the namespace; please update XmlnsDefinitionAttribute in AssemblyInfo.vb
Module Module1
    Class Program
        Shared WaitHandle As New AutoResetEvent(False)

        Shared Sub Main()
            Dim workflowRuntime As New WorkflowRuntime()

            AddHandler workflowRuntime.WorkflowCompleted, AddressOf OnWorkflowCompleted
            AddHandler workflowRuntime.WorkflowTerminated, AddressOf OnWorkflowTerminated

            Dim workflowInstance As WorkflowInstance
            Dim parms As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            Console.WriteLine("Input value: ")
            parms.Add("InputValue", CInt(Console.ReadLine()))
            workflowInstance = workflowRuntime.CreateWorkflow(GetType(Workflow1), parms)
            workflowInstance.Start()

            WaitHandle.WaitOne()
        End Sub

        Shared Sub OnWorkflowCompleted(ByVal sender As Object, ByVal e As WorkflowCompletedEventArgs)
            WaitHandle.Set()
        End Sub

        Shared Sub OnWorkflowTerminated(ByVal sender As Object, ByVal e As WorkflowTerminatedEventArgs)
            Console.WriteLine(e.Exception.Message)
            WaitHandle.Set()
        End Sub

    End Class
End Module

