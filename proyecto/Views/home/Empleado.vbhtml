
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>
@Imports System.Web.Optimization

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Empleado</title>
       @Styles.Render("~/Content/css2")
</head>
<body>
    @Html.ActionLink("INICIO", "Index")

    <section class="banner">

        <section class="wrap">

            <article>

                <h1>REGISTRAR EMPLEADO</h1>

                <form action="/home/ingresar_Empleado" method="POST" class="formulario">


                    <label>Nombre<input type="text" name="nombre" id="nombre"></label>
                    <label>Direccion<input type="text" name="direccion" id="direccion"></label>
                    <label>Email<input type="text" name="email" id="email"></label>
                    <label>Puesto<input type="text" name="puesto" id="puesto"></label>
                    <label>Telefono<input type="text" name="telefono" id="telefono"></label>

                    <input type="submit" value="Registrar" name="registro" id="boton">

                </form>

            </article>

        </section>
    </section>


</body>
</html>
