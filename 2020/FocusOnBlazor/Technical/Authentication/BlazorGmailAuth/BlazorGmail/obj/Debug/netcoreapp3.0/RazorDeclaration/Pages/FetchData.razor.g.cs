#pragma checksum "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06c80de8f2c6259515c102c35c70e750a8534f94"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorGmail.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 4 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 5 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 6 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 7 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 8 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\_Imports.razor"
using BlazorGmail;

#line default
#line hidden
#line 9 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\_Imports.razor"
using BlazorGmail.Shared;

#line default
#line hidden
#line 2 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\Pages\FetchData.razor"
using BlazorGmail.Services;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 38 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\Pages\FetchData.razor"
       
    WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591