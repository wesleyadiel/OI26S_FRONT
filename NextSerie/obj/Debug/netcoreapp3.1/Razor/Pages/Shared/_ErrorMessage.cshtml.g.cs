#pragma checksum "C:\Users\wesle\OneDrive\Documentos\UTFPR\Oficina 2\Front\OI26S_FRONT\NextSerie\Pages\Shared\_ErrorMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74e76cb593bc8307d113caa93567b30dd75ee7dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Shared__ErrorMessage), @"mvc.1.0.view", @"/Pages/Shared/_ErrorMessage.cshtml")]
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
#line 1 "C:\Users\wesle\OneDrive\Documentos\UTFPR\Oficina 2\Front\OI26S_FRONT\NextSerie\Pages\_ViewImports.cshtml"
using NextSerie;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wesle\OneDrive\Documentos\UTFPR\Oficina 2\Front\OI26S_FRONT\NextSerie\Pages\_ViewImports.cshtml"
using NextSerie.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74e76cb593bc8307d113caa93567b30dd75ee7dd", @"/Pages/Shared/_ErrorMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"911f57656842f62c373bfe73d23b75198e7bd4b1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__ErrorMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<script>\r\n    window.setTimeout(function () {\r\n        $(\".alert\").fadeTo(500, 0).slideUp(3000, function () {\r\n            $(this).remove();\r\n        });\r\n    }, 2000);\r\n</script>\r\n\r\n<div class=\"alert alert-danger\" role=\"alert\">\r\n    ");
#nullable restore
#line 12 "C:\Users\wesle\OneDrive\Documentos\UTFPR\Oficina 2\Front\OI26S_FRONT\NextSerie\Pages\Shared\_ErrorMessage.cshtml"
Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
