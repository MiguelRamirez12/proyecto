Imports System.Web.Mvc

Namespace Controllers
    Public Class UsersController
        Inherits Controller

        ' GET: Users
        Function Users() As ActionResult
            Dim obj As New UsersDatos()

            Return View(obj.UserDatos)
        End Function
    End Class
End Namespace