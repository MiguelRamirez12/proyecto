Imports System.Web.Mvc

Namespace Controllers
    Public Class homeController
        Inherits Controller

        ' GET: home
        Function Index() As ActionResult
            Return View()
        End Function
        Function Empleado() As ActionResult
            Return View()

        End Function

        Function ingresar_Empleado() As ActionResult
            Dim NOMBRE, DIRECCION, EMAIL, PUESTO, TELEFONO As String
            NOMBRE = Request.Form("nombre").ToString()
            DIRECCION = Request.Form("direccion").ToString()
            EMAIL = Request.Form("email").ToString()
            PUESTO = Request.Form("puesto").ToString()
            TELEFONO = Request.Form("telefono").ToString()
            Dim obj As New Datos
            obj.ingresar_Empleado(NOMBRE, DIRECCION, EMAIL, PUESTO, TELEFONO)
            Return View()


        End Function
        Function Ingresar_Usuario() As ActionResult
            Dim NOMBRE_USER, CLAVE As String
            NOMBRE_USER = Request.Form("nombre").ToString()
            CLAVE = Request.Form("clave").ToString()
            Dim obj1 As New Datos
            obj1.ingresar_Usuario(NOMBRE_USER, CLAVE)
            Return View()

        End Function
        Function Usuario() As ActionResult
            Return View()

        End Function
        Function LOGIN() As ActionResult
            Return View()
        End Function

    End Class
End Namespace