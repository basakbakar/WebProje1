#pragma checksum "C:\Users\BasakPc\Desktop\a\WebProje1-master\Views\Iletisim\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a38547b71e4f47bbb18175ab42f4da5200ca4b7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Iletisim_Index), @"mvc.1.0.view", @"/Views/Iletisim/Index.cshtml")]
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
#line 1 "C:\Users\BasakPc\Desktop\a\WebProje1-master\Views\_ViewImports.cshtml"
using WebProje1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BasakPc\Desktop\a\WebProje1-master\Views\_ViewImports.cshtml"
using WebProje1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a38547b71e4f47bbb18175ab42f4da5200ca4b7a", @"/Views/Iletisim/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41aad9726acb633bc6c8da07f69c5b6c7ddaa677", @"/Views/_ViewImports.cshtml")]
    public class Views_Iletisim_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a38547b71e4f47bbb18175ab42f4da5200ca4b7a3022", async() => {
                WriteLiteral("\n    <h3>Contact</h3>\n");
#nullable restore
#line 3 "C:\Users\BasakPc\Desktop\a\WebProje1-master\Views\Iletisim\Index.cshtml"
     using (Html.BeginForm("UyeOl", "Home", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("<div class=\"form-horizontal\">\n    <div class=\"form-group\">\n        <label for=\"Enter Your Name\" class=\"control-label col-md-3\">Your Name:</label>\n        <div class=\"col-md-9\">\n            ");
#nullable restore
#line 9 "C:\Users\BasakPc\Desktop\a\WebProje1-master\Views\Iletisim\Index.cshtml"
       Write(Html.TextBox("Your Name", null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </div>\n    </div>\n    <div class=\"form-group\">\n        <label for=\"Enter Your Surname\" class=\"control-label col-md-3\">Your Surname:</label>\n        <div class=\"col-md-9\">\n            ");
#nullable restore
#line 15 "C:\Users\BasakPc\Desktop\a\WebProje1-master\Views\Iletisim\Index.cshtml"
       Write(Html.TextBox("Your Surname", null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </div>\n    </div>\n    <div class=\"form-group\">\n        <label for=\"Your thoughts and advices:\" class=\"control-label col-md-3\">You can share your thoughts and advices with us! </label>\n        <div class=\"col-md-9\">\n            ");
#nullable restore
#line 21 "C:\Users\BasakPc\Desktop\a\WebProje1-master\Views\Iletisim\Index.cshtml"
       Write(Html.TextBox("Your comments:", null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </div>\n    </div>\n    <div class=\"form-group\">\n        <div class=\"col-sm-offset-3 col-sm-9\">\n            <button type=\"submit\" class=\"btn btn-primary\">Save</button>\n        </div>\n    </div>\n</div>");
#nullable restore
#line 29 "C:\Users\BasakPc\Desktop\a\WebProje1-master\Views\Iletisim\Index.cshtml"
      }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <h4>Bize Ulasin!</h4>
    <div class=""form-horizontal"">
        <div class=""form-group"">
            <label for=""."" class=""control-label col-md-3"">basak.bakar@ogr.sakaraya.edu.tr</label>
        </div>
        <div class=""form-group"">
            <label for=""."" class=""control-label col-md-3"">hilal.yildiz6@ogr.sakaraya.edu.tr</label>
        </div>

    </div>

    <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d344229.03782885417!2d-122.3492773872096!3d47.62050630322261!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x5490102c93e83355%3A0x102565466944d59a!2sSeattle%2C%20Washington%2C%20Amerika%20Birle%C5%9Fik%20Devletleri!5e0!3m2!1str!2str!4v1609621415528!5m2!1str!2str""
            width=""600"" height=""450"" frameborder=""0"" style=""border:0;""");
                BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 1901, "\"", 1919, 0);
                EndWriteAttribute();
                WriteLiteral(" aria-hidden=\"false\" tabindex=\"0\"></iframe>\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
