
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>
@Imports System.Web.Optimization

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/jqueryval")
    @Scripts.Render("~/bundles/jqueryvalunobtrusive")
    @Styles.Render("~/Content/css")
</head>
<body>
    <header>
        <div class="wrap">
            <section class="logo">
                <h1 class="tienda">Activos</h1>
                <h1>Fijos</h1>
            </section>

            <nav class="menu">
                <a href="index.php?accion=menu">Inicio</a>
                <a href="">@Html.ActionLink("Mostrar Empleado", "Users", "Users")</a>
                <a href="index.php?accion=inventario">Bajas de Activos</a>
                <a href="">Altas de Activos</a>

            </nav>

        </div>
    </header>





    <div id="header">

        <ul class="nav">
            <li>
                <a href="">Usuaio</a>
                <ul>
                    <li><a href="index.php?accion=buscarUsu">Buscar Usuario</a></li>
                    <li>@Html.ActionLink("crear usuario", "Usuario")</li>
                </ul>
            </li>

            <li>
                <a href="">Productos</a>

                <ul>
                    <li><a href="index.php?accion=buscarPro">Bucar producto</a></li>
                    <li><a href="index.php?accion=producto">Crear Producto</a></li>
                </ul>
            </li>


            <li>
                <a href="">Empleado</a>

                <ul>
                    <li>@Html.ActionLink("crear empleado", "Empleado")</li>
                    <li></li>
                </ul>
            </li>
            <li>
                <a href="">activos fijos</a>

                <ul>
                    <li><a href="index.php?accion=buscar_activo">Buscar activos</a></li>
                    <li><a href="index.php?accion=crear_activo">crear activos</a></li>
                </ul>
            </li>
        </ul>

    </div>

</body>
</html>
