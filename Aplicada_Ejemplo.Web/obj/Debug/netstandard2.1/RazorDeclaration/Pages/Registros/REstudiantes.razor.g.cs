#pragma checksum "C:\Users\AnthonyB\source\repos\Aplicada_Ejemplo\Aplicada_Ejemplo.Web\Pages\Registros\REstudiantes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1764f141f411ca17825b394098be4e776a490937"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Aplicada_Ejemplo.Web.Pages.Registros
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\AnthonyB\source\repos\Aplicada_Ejemplo\Aplicada_Ejemplo.Web\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AnthonyB\source\repos\Aplicada_Ejemplo\Aplicada_Ejemplo.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AnthonyB\source\repos\Aplicada_Ejemplo\Aplicada_Ejemplo.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\AnthonyB\source\repos\Aplicada_Ejemplo\Aplicada_Ejemplo.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\AnthonyB\source\repos\Aplicada_Ejemplo\Aplicada_Ejemplo.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\AnthonyB\source\repos\Aplicada_Ejemplo\Aplicada_Ejemplo.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\AnthonyB\source\repos\Aplicada_Ejemplo\Aplicada_Ejemplo.Web\_Imports.razor"
using Aplicada_Ejemplo.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\AnthonyB\source\repos\Aplicada_Ejemplo\Aplicada_Ejemplo.Web\_Imports.razor"
using Aplicada_Ejemplo.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\AnthonyB\source\repos\Aplicada_Ejemplo\Aplicada_Ejemplo.Web\_Imports.razor"
using Aplicada_Ejemplo.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AnthonyB\source\repos\Aplicada_Ejemplo\Aplicada_Ejemplo.Web\Pages\Registros\REstudiantes.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Estudiantes")]
    public partial class REstudiantes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Users\AnthonyB\source\repos\Aplicada_Ejemplo\Aplicada_Ejemplo.Web\Pages\Registros\REstudiantes.razor"
       

    private Estudiantes estudiante = new Estudiantes();

    private void Nuevo()
    {
        estudiante = new Estudiantes();
    }

    private async Task Guardar()
    {
        await Http.PostAsJsonAsync("http://localhost:8081/Api/Estudiantes", estudiante);
    }

    public void Eliminar()
    {

    }

    private async Task Buscar()
    {
        estudiante = await Http.GetFromJsonAsync<Estudiantes>($"http://localhost:8081/Api/Estudiantes/{estudiante.Id}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
