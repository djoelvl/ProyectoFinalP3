#pragma checksum "C:\Users\JOEL\Desktop\Final-main\final\Pages\Addservicio.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ea36f1feb5d1cdecd28939cfb706482c0877506"
// <auto-generated/>
#pragma warning disable 1591
namespace Final.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\JOEL\Desktop\Final-main\final\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JOEL\Desktop\Final-main\final\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\JOEL\Desktop\Final-main\final\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\JOEL\Desktop\Final-main\final\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\JOEL\Desktop\Final-main\final\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\JOEL\Desktop\Final-main\final\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\JOEL\Desktop\Final-main\final\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\JOEL\Desktop\Final-main\final\_Imports.razor"
using Final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\JOEL\Desktop\Final-main\final\_Imports.razor"
using Final.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JOEL\Desktop\Final-main\final\Pages\Addservicio.razor"
using Final.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Addservicio")]
    public partial class Addservicio : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Agregar Producto</h2>\n<hr>\n\n");
            __builder.OpenElement(1, "form");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "form-group col-md-4");
            __builder.AddMarkupContent(6, "<label for=\"Nombre\">Nombre del del Servicio</label>\n            ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "text");
            __builder.AddAttribute(9, "class", "form-control");
            __builder.AddAttribute(10, "placeholder", "Nombre del Servicio");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\JOEL\Desktop\Final-main\final\Pages\Addservicio.razor"
                                                                                               servicio.Nombre_Servicio

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => servicio.Nombre_Servicio = __value, servicio.Nombre_Servicio));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "form-group col-md-4");
            __builder.AddMarkupContent(16, "<label for=\"inputcantidad\">Presio del Servicio</label>\n            ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "type", "text");
            __builder.AddAttribute(19, "class", "form-control");
            __builder.AddAttribute(20, "id", "cantidad");
            __builder.AddAttribute(21, "placeholder", "Precio del Servicio");
            __builder.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\JOEL\Desktop\Final-main\final\Pages\Addservicio.razor"
                                                                                                            servicio.Precio_servicio

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => servicio.Precio_servicio = __value, servicio.Precio_servicio));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n        ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "form-group col-md-4");
            __builder.AddMarkupContent(27, "<label for=\"fecha\">Fecha</label>\n            ");
            __builder.OpenElement(28, "input");
            __builder.AddAttribute(29, "type", "date");
            __builder.AddAttribute(30, "class", "form-control");
            __builder.AddAttribute(31, "id", "fecha");
            __builder.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\JOEL\Desktop\Final-main\final\Pages\Addservicio.razor"
                                                                       servicio.Fecha

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => servicio.Fecha = __value, servicio.Fecha, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n        ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "form-group");
            __builder.AddMarkupContent(37, "<label for=\"Descripcion\">Descripcion</label>\n            ");
            __builder.OpenElement(38, "input");
            __builder.AddAttribute(39, "type", "text");
            __builder.AddAttribute(40, "class", "form-control");
            __builder.AddAttribute(41, "id", "Descripcion");
            __builder.AddAttribute(42, "placeholder", "Descripcion");
            __builder.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\JOEL\Desktop\Final-main\final\Pages\Addservicio.razor"
                                                                                                       servicio.Descripcion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => servicio.Descripcion = __value, servicio.Descripcion));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n    ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "row");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "col-md-4");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "form-group");
            __builder.OpenElement(52, "input");
            __builder.AddAttribute(53, "type", "button");
            __builder.AddAttribute(54, "class", "btn btn-primary");
            __builder.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\JOEL\Desktop\Final-main\final\Pages\Addservicio.razor"
                                                                        CreateServicio

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "value", "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\n                ");
            __builder.OpenElement(58, "input");
            __builder.AddAttribute(59, "type", "button");
            __builder.AddAttribute(60, "class", "btn btn-danger");
            __builder.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\JOEL\Desktop\Final-main\final\Pages\Addservicio.razor"
                                                                       Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "value", "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\JOEL\Desktop\Final-main\final\Pages\Addservicio.razor"
       

    Servicio servicio = new Servicio();

    protected void CreateServicio()
    {
        Service.Create(servicio);
        NavigationManager.NavigateTo("servicioInfo");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("servicioInfo");

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProductoServicio2 Service { get; set; }
    }
}
#pragma warning restore 1591
