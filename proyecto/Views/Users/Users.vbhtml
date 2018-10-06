@ModelType IEnumerable(Of proyecto.UsersDatosModel)

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Users</title>
</head>
<body>
    <p>
        @Html.ActionLink("Create New", "Create")
        @Html.ActionLink("INICIO", "../Home")
    </p>
    <table class="table">
        <tr>
            <th>
                @Html.DisplayNameFor(Function(model) model.nombre)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.direccion)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.email)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.puesto)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.telefono)
            </th>
            <th></th>
        </tr>
    
    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.nombre)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.direccion)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.email)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.puesto)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.telefono)
            </td>
            <td>
                @*@Html.ActionLink("Edit", "Edit", New With {.id = item.PrimaryKey}) |
                @Html.ActionLink("Details", "Details", New With {.id = item.PrimaryKey}) |
                @Html.ActionLink("Delete", "Delete", New With {.id = item.PrimaryKey})*@
            </td>
        </tr>
    Next
    
    </table>
</body>
</html>
