#pragma checksum "D:\Etude\2-annee\Session3\Asp.net\LabraryMVC\LabraryMVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "421120b5f22672df0c4257ab4c5a761246061cb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Etude\2-annee\Session3\Asp.net\LabraryMVC\LabraryMVC\Views\_ViewImports.cshtml"
using LabraryMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Etude\2-annee\Session3\Asp.net\LabraryMVC\LabraryMVC\Views\_ViewImports.cshtml"
using LabraryMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"421120b5f22672df0c4257ab4c5a761246061cb8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c3e68960adf52051486e3fb33e9b6f64e263eba", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Etude\2-annee\Session3\Asp.net\LabraryMVC\LabraryMVC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"">
        <!-- Indicators -->
        <ol class=""carousel-indicators"">
            <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
            <li data-target=""#myCarousel"" data-slide-to=""1""></li>
            <li data-target=""#myCarousel"" data-slide-to=""2""></li>
        </ol>

        <!-- Wrapper for slides -->
        <div class=""carousel-inner"">
            <div class=""item active"">
                <img src=""https://foodtank.com/wp-content/uploads/2021/07/alfons-morales-YLSwjSy7stw-unsplash-768x461.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 683, "\"", 689, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%;height:520px\">\r\n            </div>\r\n\r\n            <div class=\"item\">\r\n                <img src=\"https://www.incimages.com/uploaded_files/image/1920x1080/getty_655998316_2000149920009280219_363765.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 909, "\"", 915, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%;height:520px\">\r\n            </div>\r\n\r\n            <div class=\"item\">\r\n                <img src=\"https://www.metsoc.org/wp-content/uploads/2014/09/Books.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1091, "\"", 1097, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""width:100%;height:520px"">
            </div>
        </div>

        <!-- Left and right controls -->
        <a class=""left carousel-control"" href=""#myCarousel"" data-slide=""prev"">
            <span class=""glyphicon glyphicon-chevron-left""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""right carousel-control"" href=""#myCarousel"" data-slide=""next"">
            <span class=""glyphicon glyphicon-chevron-right""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
