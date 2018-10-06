Public Class UsersDatos

    Dim userDC As New UsersDataDataContext
    Function UserDatos() As List(Of UsersDatosModel)

        Dim list As List(Of UsersDatosModel) = New List(Of UsersDatosModel)
        Dim query = From u In userDC.empleado


        Dim listData = query.ToList()
        For Each datos In listData
            list.Add(New UsersDatosModel() With {
            .nombre = datos.nombre,
            .direccion = datos.direccion,
            .email = datos.email,
            .puesto = datos.puesto,
            .telefono = datos.telefono
            })
        Next
        Return list
    End Function


End Class


Public Class UsersDatosModel

    Public Property nombre As String
    Public Property direccion As String
    Public Property email As String
    Public Property puesto As String
    Public Property telefono As Integer


End Class