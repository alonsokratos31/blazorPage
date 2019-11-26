
//Para invocar un metodo c# desde javascript 
function pruebaPuntoNetStatic() {
    DotNet.invokeMethodAsync("BlazorApp1.Client", "ObtenerCurrentCount")
        .then(resultado => {
            console.log("conteo desde javascript " + resultado);
        });
}

function pruebaPuntoNETInstancia(dotnetHelper) {
    dotnetHelper.invokeMethodAsync("IncrementCount");
}