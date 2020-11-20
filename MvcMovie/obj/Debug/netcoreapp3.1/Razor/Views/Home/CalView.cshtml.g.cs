#pragma checksum "C:\Users\Trackz\source\repos\MvcMovie\MvcMovie\Views\Home\CalView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60391e89e74e323902723065d7f1e17df2c76583"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CalView), @"mvc.1.0.view", @"/Views/Home/CalView.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Trackz\source\repos\MvcMovie\MvcMovie\Views\_ViewImports.cshtml"
using MvcMovie;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Trackz\source\repos\MvcMovie\MvcMovie\Views\_ViewImports.cshtml"
using MvcMovie.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Trackz\source\repos\MvcMovie\MvcMovie\Views\Home\CalView.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60391e89e74e323902723065d7f1e17df2c76583", @"/Views/Home/CalView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"686ad2e38abb871af45be971520cc6c3156da389", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CalView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcMovie.Models.CalViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Trackz\source\repos\MvcMovie\MvcMovie\Views\Home\CalView.cshtml"
  
    ViewData["Title"] = "Welcome";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Calendar View</h2>

<div class=""row"">
    <div class=""col-6"">
        <div style=""font-size:large; text-align: center; background-color: black; color:white"">November 2020</div>
        <div id=""app-calendar1"" style=""font-size:large; text-align: center""></div>
    </div>
    <div class=""col-6"">
        <div style=""font-size:large; text-align: center; background-color: black; color:white"">December 2020</div>
        <div id=""app-calendar2"" style=""font-size:large; text-align: center""></div>
    </div>
</div>

<div class=""row"">
    <div class=""col-6"">
        <div class=""row"">
            <div class=""col-3"" style=""background-color: lightslategrey"">4040 Challenge Day</div>
            <div class=""col-3"" style=""background-color:lightgrey"">Not 4040 Challenge Day</div>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-6"">
        <div class=""row"">
            <div class=""col-3"" style=""color:lawngreen"">Activity Recorded</div>
            <div class=""col-3"" style=""col");
            WriteLiteral("or:red\">No Activity Recorded</div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n<script>\r\n    var dayinNov =  ");
#nullable restore
#line 40 "C:\Users\Trackz\source\repos\MvcMovie\MvcMovie\Views\Home\CalView.cshtml"
               Write(Html.Raw(JsonConvert.SerializeObject(ViewBag.dayNov)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    var resultNov =  ");
#nullable restore
#line 41 "C:\Users\Trackz\source\repos\MvcMovie\MvcMovie\Views\Home\CalView.cshtml"
                Write(Html.Raw(JsonConvert.SerializeObject(ViewBag.resNov)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

    const myRow = document.getElementById(""app-calendar1"");
    console.log(myRow);

    for (i = 16; i <= 30; i++) {

        let newTD = document.createElement(""td"");

        newTD.textContent = i;

        if (dayinNov[i - 16] == ""day-in"") {
            if (resultNov[i - 16] == ""true"") {
                newTD.setAttribute('class', ""day-in day-true"");
            } else {
                newTD.setAttribute('class', ""day-in day-false"");
            }
        } else {
            newTD.setAttribute('class', ""day-out"");
        }
        myRow.appendChild(newTD);
    }

</script>

<script>
    var dayinDec =  ");
#nullable restore
#line 67 "C:\Users\Trackz\source\repos\MvcMovie\MvcMovie\Views\Home\CalView.cshtml"
               Write(Html.Raw(JsonConvert.SerializeObject(ViewBag.dayDec)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    console.log(dayinDec);\r\n    var resultDec =  ");
#nullable restore
#line 69 "C:\Users\Trackz\source\repos\MvcMovie\MvcMovie\Views\Home\CalView.cshtml"
                Write(Html.Raw(JsonConvert.SerializeObject(ViewBag.resDec)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
    console.log(resultDec);

    const myRow2 = document.getElementById(""app-calendar2"");
    console.log(myRow2);

    let newTD2 = document.createElement(""td"");
    newTD2.setAttribute('class', ""day-out"");
    myRow2.appendChild(newTD2);

    for (i = 1; i <= 31; i++) {

        let newTD2 = document.createElement(""td"");

        newTD2.textContent = i;

        if (dayinDec[i - 1] == ""day-in"") {
            if (resultDec[i - 1] == ""true"") {
                newTD2.setAttribute('class', ""day-in day-true"");
            } else {
                newTD2.setAttribute('class', ""day-in day-false"");
            }
        } else {
            newTD2.setAttribute('class', ""day-out"");
        }
        myRow2.appendChild(newTD2);
    }
</script>

");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MvcMovie.Models.CalViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
