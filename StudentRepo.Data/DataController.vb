Imports System.Web.Http
Imports Microsoft.AspNetCore.Mvc
Imports Microsoft.Extensions.Logging
Imports Newtonsoft.Json

Namespace StudentRepo.Controllers
    <ApiController>
    <Route("[controller]")>
    Public Class DataController
        Inherits ControllerBase

        Private ReadOnly _logger As ILogger(Of DataController)

        Public Sub New(ByVal logger As ILogger(Of DataController))
            _logger = logger
        End Sub

        <HttpPost>
        Public Function [Get]() As StudentsVM
            Dim students = "{
    'students': [
        {
            'name': 'Alice',
            'age': 20,
            'hobbies': ['reading', 'swimming', 'coding']
        },
        {
            'name': 'Bob',
            'age': 22,
            'hobbies': ['painting', 'dancing', 'singing']
        },
{
            'name': 'james',
            'age': 22,
            'hobbies': ['painting', 'dancing', 'singing']
        },
        {
            'name': 'alex',
            'age': 26,
            'hobbies': ['painting', 'singing']
        }
,
        {
            'name': 'rob',
            'age': 36,
            'hobbies': ['singing', 'dancing']
        }
,
        {
            'name': 'ajay',
            'age': 38,
            'hobbies': ['painting', 'dancing']
        }
    ]
}"
            Return JsonConvert.DeserializeObject(Of StudentsVM)(students)
        End Function
    End Class

    Public Class StudentsVM
        Public Property Students As Student()
    End Class

    Public Class Student
        Public Property Name As String
        Public Property Age As Integer
        Public Property Hobbies As String()
    End Class

End Namespace
