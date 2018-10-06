Public Class Datos
    Dim DB As New UsersDataDataContext
    Dim em As New empleado
    Dim user As New usuario
    Public Function ingresar_Empleado(NOMBRE As String, DIRECCION As String, EMAIL As String, PUESTO As String, TELEFONO As String)
        em.nombre = NOMBRE
        em.direccion = DIRECCION
        em.email = EMAIL
        em.puesto = PUESTO
        em.telefono = TELEFONO

        DB.empleado.InsertOnSubmit(em)
        DB.SubmitChanges()

    End Function

    Public Function Ingresar_Usuario(NOMBRE_USER As String, CLAVE As String)
        user.nombre_user = NOMBRE_USER
        user.clave = CLAVE

        DB.usuario.InsertOnSubmit(user)
        DB.SubmitChanges()

    End Function

End Class
