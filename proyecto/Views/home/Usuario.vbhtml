
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>
@Imports System.Web.Optimization
<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>usuario</title>
    @Styles.Render("~/Content/css2")
</head>
<body>



    <section class="banner">

        <section class="wrap">

            <article>

                <h1>REGISTRAR USUARIO</h1>

                <form action="/home/Ingresar_Usuario" method="POST" class="formulario">


                    <label>Nombre<input type="text" name="nombre" id="nombre"></label>
                    <label>Clave<input type="text" name="clave" id="direccion"></label>
                    <input type="submit" value="Registrar" name="registro" id="boton">

                </form>

            </article>

        </section>
    </section>


</body>
</html>