#pragma checksum "E:\Local\TechSquads\TechSquad.Application\Views\Shared\_AdminSideBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3ced25e303724fa9c591ada0355bbbe5df9d3b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AdminSideBar), @"mvc.1.0.view", @"/Views/Shared/_AdminSideBar.cshtml")]
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
#line 1 "E:\Local\TechSquads\TechSquad.Application\Views\_ViewImports.cshtml"
using TechSquad.Application;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Local\TechSquads\TechSquad.Application\Views\_ViewImports.cshtml"
using TechSquad.Application.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3ced25e303724fa9c591ada0355bbbe5df9d3b4", @"/Views/Shared/_AdminSideBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3998e98803a72ac2b7c44741c155d54a68d7a29", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__AdminSideBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetAllUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<nav class=""sidebar sidebar-offcanvas"" id=""sidebar"">
    <ul class=""nav"">
        <li class=""nav-item"">
            <a class=""nav-link"" href=""index.html"">
                <i class=""mdi mdi-grid-large menu-icon""></i>
                <span class=""menu-title"">Dashboard</span>
            </a>
        </li>
        <li class=""nav-item nav-category"">User Settings</li>
        <li class=""nav-item"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3ced25e303724fa9c591ada0355bbbe5df9d3b44535", async() => {
                WriteLiteral("\r\n                <i class=\"menu-icon mdi mdi-floor-plan\"></i>\r\n                <span class=\"menu-title\">User</span>\r\n               \r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
          
        </li>
        <li class=""nav-item nav-category"">Forms and Datas</li>
        <li class=""nav-item"">
            <a class=""nav-link"" data-bs-toggle=""collapse"" href=""#form-elements"" aria-expanded=""false"" aria-controls=""form-elements"">
                <i class=""menu-icon mdi mdi-card-text-outline""></i>
                <span class=""menu-title"">Form elements</span>
                <i class=""menu-arrow""></i>
            </a>
            <div class=""collapse"" id=""form-elements"">
                <ul class=""nav flex-column sub-menu"">
                    <li class=""nav-item""><a class=""nav-link"" href=""pages/forms/basic_elements.html"">Basic Elements</a></li>
                </ul>
            </div>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" data-bs-toggle=""collapse"" href=""#charts"" aria-expanded=""false"" aria-controls=""charts"">
                <i class=""menu-icon mdi mdi-chart-line""></i>
                <span class=""menu-title"">Charts</span>
          ");
            WriteLiteral(@"      <i class=""menu-arrow""></i>
            </a>
            <div class=""collapse"" id=""charts"">
                <ul class=""nav flex-column sub-menu"">
                    <li class=""nav-item""> <a class=""nav-link"" href=""pages/charts/chartjs.html"">ChartJs</a></li>
                </ul>
            </div>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" data-bs-toggle=""collapse"" href=""#tables"" aria-expanded=""false"" aria-controls=""tables"">
                <i class=""menu-icon mdi mdi-table""></i>
                <span class=""menu-title"">Tables</span>
                <i class=""menu-arrow""></i>
            </a>
            <div class=""collapse"" id=""tables"">
                <ul class=""nav flex-column sub-menu"">
                    <li class=""nav-item""> <a class=""nav-link"" href=""pages/tables/basic-table.html"">Basic table</a></li>
                </ul>
            </div>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" data-bs-toggle=""collapse"" h");
            WriteLiteral(@"ref=""#icons"" aria-expanded=""false"" aria-controls=""icons"">
                <i class=""menu-icon mdi mdi-layers-outline""></i>
                <span class=""menu-title"">Icons</span>
                <i class=""menu-arrow""></i>
            </a>
            <div class=""collapse"" id=""icons"">
                <ul class=""nav flex-column sub-menu"">
                    <li class=""nav-item""> <a class=""nav-link"" href=""pages/icons/mdi.html"">Mdi icons</a></li>
                </ul>
            </div>
        </li>
        <li class=""nav-item nav-category"">pages</li>
        <li class=""nav-item"">
            <a class=""nav-link"" data-bs-toggle=""collapse"" href=""#auth"" aria-expanded=""false"" aria-controls=""auth"">
                <i class=""menu-icon mdi mdi-account-circle-outline""></i>
                <span class=""menu-title"">User Pages</span>
                <i class=""menu-arrow""></i>
            </a>
            <div class=""collapse"" id=""auth"">
                <ul class=""nav flex-column sub-menu"">
              ");
            WriteLiteral(@"      <li class=""nav-item""> <a class=""nav-link"" href=""pages/samples/login.html""> Login </a></li>
                </ul>
            </div>
        </li>
        <li class=""nav-item nav-category"">help</li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""http://bootstrapdash.com/demo/star-admin2-free/docs/documentation.html"">
                <i class=""menu-icon mdi mdi-file-document""></i>
                <span class=""menu-title"">Documentation</span>
            </a>
        </li>
    </ul>
</nav>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
