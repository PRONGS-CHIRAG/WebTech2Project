#pragma checksum "C:\Users\chira\source\repos\Grocer\Views\Home\Display.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c1e592efd46c0b68d4034b2eda2fcb5872972fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Display), @"mvc.1.0.view", @"/Views/Home/Display.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Display.cshtml", typeof(AspNetCore.Views_Home_Display))]
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
#line 1 "C:\Users\chira\source\repos\Grocer\Views\_ViewImports.cshtml"
using Grocer;

#line default
#line hidden
#line 2 "C:\Users\chira\source\repos\Grocer\Views\_ViewImports.cshtml"
using Grocer.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c1e592efd46c0b68d4034b2eda2fcb5872972fa", @"/Views/Home/Display.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3def315058c8a71d98e1b4f74e2f0929dfbd5f36", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Display : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Grocer.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\chira\source\repos\Grocer\Views\Home\Display.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(72, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(101, 2131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d1a95872466415899a984409f925456", async() => {
                BeginContext(107, 2118, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>AddCart</title>
    <link rel=""stylesheet"" type=""text/css"" href=""signup.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-sweetalert/1.0.1/sweetalert.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-sweetalert/1.0.1/sweetalert.js"">
    <link rel=""stylesheet"" type=""text/css"" href=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-sweetalert/1.0.1/sweetalert.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-sweetalert/1.0.1/sweetalert.min.css.map"">
    <link rel=""stylesheet"" type=""text/css"" href=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-sweetalert/1.0.1/sweetalert.min.js"">
    <style>
        * {
            font-family: sans-serif;
        }

        body {
            background-image: linear-gradient(rgba(0, 0, 0, 0.23),rgba(0, 0, 0, 0.24)),url('https://");
                WriteLiteral(@"bia.lighting/wp-content/uploads/2016/04/Sign-Up-Background.png');
            background-size: cover;
        }


        h1 {
            text-align: center;
            color: orange;
            font-weight: 50px;
            font-family: sans-serif;
        }

            h1:hover {
                color: white;
            }

        .form {
            max-width: 400px;
            background: rgba(0, 0, 0, .57);
            border-radius: 20px;
            box-sizing: border-box;
            padding: 40px;
            margin: auto;
            color: white;
            margin-top: 100px;
            margin-bottom: 50px;
        }

        .table {
            width: 100%;
            border-radius: 10px;
            box-sizing: border-box;
            background: red;
            border: none;
            font-weight: 500;
            font-size: 16px;
            outline: none;
            border-bottom: 1px solid white;
            margin: 6px;
            color:");
                WriteLiteral(" black;\r\n            padding: 12px 5px;\r\n        }\r\n    </style>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2232, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(2238, 1764, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f97441a86cd44c8896bf2828e5c8140", async() => {
                BeginContext(2244, 27, true);
                WriteLiteral("\r\n        <p>\r\n            ");
                EndContext();
                BeginContext(2271, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82c2225fbb0447c286d671aaaa0f5016", async() => {
                    BeginContext(2294, 10, true);
                    WriteLiteral("Create New");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2308, 140, true);
                WriteLiteral("\r\n        </p>\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(2449, 45, false);
#line 77 "C:\Users\chira\source\repos\Grocer\Views\Home\Display.cshtml"
                   Write(Html.DisplayNameFor(model => model.ProductId));

#line default
#line hidden
                EndContext();
                BeginContext(2494, 79, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(2574, 47, false);
#line 80 "C:\Users\chira\source\repos\Grocer\Views\Home\Display.cshtml"
                   Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
                EndContext();
                BeginContext(2621, 79, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(2701, 44, false);
#line 83 "C:\Users\chira\source\repos\Grocer\Views\Home\Display.cshtml"
                   Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
                EndContext();
                BeginContext(2745, 79, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(2825, 41, false);
#line 86 "C:\Users\chira\source\repos\Grocer\Views\Home\Display.cshtml"
                   Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
                EndContext();
                BeginContext(2866, 79, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(2946, 54, false);
#line 89 "C:\Users\chira\source\repos\Grocer\Views\Home\Display.cshtml"
                   Write(Html.DisplayNameFor(model => model.ProductDescription));

#line default
#line hidden
                EndContext();
                BeginContext(3000, 126, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
                EndContext();
#line 95 "C:\Users\chira\source\repos\Grocer\Views\Home\Display.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
                BeginContext(3191, 84, true);
                WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(3276, 44, false);
#line 99 "C:\Users\chira\source\repos\Grocer\Views\Home\Display.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ProductId));

#line default
#line hidden
                EndContext();
                BeginContext(3320, 91, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(3412, 46, false);
#line 102 "C:\Users\chira\source\repos\Grocer\Views\Home\Display.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
                EndContext();
                BeginContext(3458, 91, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(3550, 43, false);
#line 105 "C:\Users\chira\source\repos\Grocer\Views\Home\Display.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Category));

#line default
#line hidden
                EndContext();
                BeginContext(3593, 91, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(3685, 40, false);
#line 108 "C:\Users\chira\source\repos\Grocer\Views\Home\Display.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
                EndContext();
                BeginContext(3725, 91, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(3817, 53, false);
#line 111 "C:\Users\chira\source\repos\Grocer\Views\Home\Display.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ProductDescription));

#line default
#line hidden
                EndContext();
                BeginContext(3870, 62, true);
                WriteLiteral("\r\n                        </td>\r\n\r\n                    </tr>\r\n");
                EndContext();
#line 115 "C:\Users\chira\source\repos\Grocer\Views\Home\Display.cshtml"
                }

#line default
#line hidden
                BeginContext(3951, 44, true);
                WriteLiteral("            </tbody>\r\n        </table>\r\n    ");
                EndContext();
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
            EndContext();
            BeginContext(4002, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Grocer.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
