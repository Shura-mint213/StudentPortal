#pragma checksum "C:\Users\иван\Desktop\MyCompany\MyCompany\Views\Shared\MetatagsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fa24a940a49d2b1e3f7f1daad73824f2e26ddb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MetatagsPartial), @"mvc.1.0.view", @"/Views/Shared/MetatagsPartial.cshtml")]
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
#line 2 "C:\Users\иван\Desktop\MyCompany\MyCompany\Views\_ViewImports.cshtml"
using MyCompany.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\иван\Desktop\MyCompany\MyCompany\Views\_ViewImports.cshtml"
using MyCompany.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\иван\Desktop\MyCompany\MyCompany\Views\_ViewImports.cshtml"
using MyCompany.Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\иван\Desktop\MyCompany\MyCompany\Views\_ViewImports.cshtml"
using MyCompany.Models.ViewComponents;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fa24a940a49d2b1e3f7f1daad73824f2e26ddb8", @"/Views/Shared/MetatagsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c98feb9e1a0657b22553d465a169b966cb06b16d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_MetatagsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<meta charset=\"utf-8\" />\r\n<meta name=\"viewport\" content=\"width=device-width, initial-scale=1, user-scalable=no\" />\r\n");
#nullable restore
#line 3 "C:\Users\иван\Desktop\MyCompany\MyCompany\Views\Shared\MetatagsPartial.cshtml"
 if (ViewBag.Title != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <title>");
#nullable restore
#line 5 "C:\Users\иван\Desktop\MyCompany\MyCompany\Views\Shared\MetatagsPartial.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n");
#nullable restore
#line 6 "C:\Users\иван\Desktop\MyCompany\MyCompany\Views\Shared\MetatagsPartial.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <title>");
#nullable restore
#line 9 "C:\Users\иван\Desktop\MyCompany\MyCompany\Views\Shared\MetatagsPartial.cshtml"
      Write(Config.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n");
#nullable restore
#line 10 "C:\Users\иван\Desktop\MyCompany\MyCompany\Views\Shared\MetatagsPartial.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\иван\Desktop\MyCompany\MyCompany\Views\Shared\MetatagsPartial.cshtml"
 if (ViewBag.Description != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <meta name=\"description\"");
            BeginWriteAttribute("content", " content=\"", 304, "\"", 334, 1);
#nullable restore
#line 13 "C:\Users\иван\Desktop\MyCompany\MyCompany\Views\Shared\MetatagsPartial.cshtml"
WriteAttributeValue("", 314, ViewBag.Description, 314, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 14 "C:\Users\иван\Desktop\MyCompany\MyCompany\Views\Shared\MetatagsPartial.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\иван\Desktop\MyCompany\MyCompany\Views\Shared\MetatagsPartial.cshtml"
 if (ViewBag.Keywords != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <meta name=\"keywords\"");
            BeginWriteAttribute("content", " content=\"", 403, "\"", 430, 1);
#nullable restore
#line 17 "C:\Users\иван\Desktop\MyCompany\MyCompany\Views\Shared\MetatagsPartial.cshtml"
WriteAttributeValue("", 413, ViewBag.Keywords, 413, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 18 "C:\Users\иван\Desktop\MyCompany\MyCompany\Views\Shared\MetatagsPartial.cshtml"
}

#line default
#line hidden
#nullable disable
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
