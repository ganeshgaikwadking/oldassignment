#pragma checksum "C:\Users\Ganesh Gaikwad\source\repos\MvcDemo\MvcDemo\Views\Home\contactus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63944352df4707c541d05d8c11c2266eec62974e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_contactus), @"mvc.1.0.view", @"/Views/Home/contactus.cshtml")]
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
#line 1 "C:\Users\Ganesh Gaikwad\source\repos\MvcDemo\MvcDemo\Views\_ViewImports.cshtml"
using MvcDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ganesh Gaikwad\source\repos\MvcDemo\MvcDemo\Views\_ViewImports.cshtml"
using MvcDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63944352df4707c541d05d8c11c2266eec62974e", @"/Views/Home/contactus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf7b598472d8473bbbb5c5b0b44298edc81dd481", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_contactus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    
            <div class=""row"">

         
                <div class=""col-md-6"">
                    <div class=""md-form mb-0"">
                        <input type=""text"" id=""name"" name=""name"" class=""form-control"">
                        <label for=""name""");
            BeginWriteAttribute("class", " class=\"", 399, "\"", 407, 0);
            EndWriteAttribute();
            WriteLiteral(@">Your name</label>
                    </div>
                </div>
            
                <div class=""col-md-6"">
                    <div class=""md-form mb-0"">
                        <input type=""text"" id=""email"" name=""email"" class=""form-control"">
                        <label for=""email""");
            BeginWriteAttribute("class", " class=\"", 714, "\"", 722, 0);
            EndWriteAttribute();
            WriteLiteral(@">Your email</label>
                    </div>
                </div>
           

            </div>
        
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""md-form mb-0"">
                        <input type=""text"" id=""subject"" name=""subject"" class=""form-control"">
                        <label for=""subject""");
            BeginWriteAttribute("class", " class=\"", 1099, "\"", 1107, 0);
            EndWriteAttribute();
            WriteLiteral(@">Subject</label>
                    </div>
                </div>
            </div>
           
            <div class=""row"">


                <div class=""col-md-12"">

                    <div class=""md-form"">
                        <textarea type=""text"" id=""message"" name=""message"" rows=""2"" class=""form-control md-textarea""></textarea>
                        <label for=""message"">Your message</label>
                    </div>
                </div>
            </div>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591