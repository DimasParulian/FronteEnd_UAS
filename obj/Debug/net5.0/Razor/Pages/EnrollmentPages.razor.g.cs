#pragma checksum "C:\Users\Dimas\Front end\FrontEnd_TAS\Pages\EnrollmentPages.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa18449f3c95454bb56bf3938b64064a5397501f"
// <auto-generated/>
#pragma warning disable 1591
namespace FrontEnd_TAS.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Dimas\Front end\FrontEnd_TAS\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dimas\Front end\FrontEnd_TAS\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dimas\Front end\FrontEnd_TAS\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dimas\Front end\FrontEnd_TAS\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Dimas\Front end\FrontEnd_TAS\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Dimas\Front end\FrontEnd_TAS\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Dimas\Front end\FrontEnd_TAS\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Dimas\Front end\FrontEnd_TAS\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Dimas\Front end\FrontEnd_TAS\_Imports.razor"
using FrontEnd_TAS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Dimas\Front end\FrontEnd_TAS\_Imports.razor"
using FrontEnd_TAS.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/enrollmentpage")]
    public partial class EnrollmentPages : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Pendaftaran</h3>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-striped");
            __builder.AddMarkupContent(3, "<thead><tr><th>Course Id</th>\r\n            <th>Title</th>\r\n            <th>Credits</th>\r\n            <th></th></tr></thead>\r\n    ");
            __builder.OpenElement(4, "tbody");
#nullable restore
#line 15 "C:\Users\Dimas\Front end\FrontEnd_TAS\Pages\EnrollmentPages.razor"
         foreach(var enrol in Enrollment){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "td");
            __builder.AddContent(7, 
#nullable restore
#line 17 "C:\Users\Dimas\Front end\FrontEnd_TAS\Pages\EnrollmentPages.razor"
                     enrol.courserID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n                ");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 18 "C:\Users\Dimas\Front end\FrontEnd_TAS\Pages\EnrollmentPages.razor"
                     enrol.title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 19 "C:\Users\Dimas\Front end\FrontEnd_TAS\Pages\EnrollmentPages.razor"
                     enrol.credit

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Users\Dimas\Front end\FrontEnd_TAS\Pages\EnrollmentPages.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
