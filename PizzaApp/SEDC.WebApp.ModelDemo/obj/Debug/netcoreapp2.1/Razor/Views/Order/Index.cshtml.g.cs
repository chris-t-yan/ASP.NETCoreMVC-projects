#pragma checksum "C:\Users\hrist\Desktop\SEDC 2019-2020\07_MVC\Vezbi i proekti\MVCTasksAndExercises\Class07_RefactorPizzaApp\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2ee86a10eb7d5987f4c749b35241c708a214b14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Index.cshtml", typeof(AspNetCore.Views_Order_Index))]
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
#line 1 "C:\Users\hrist\Desktop\SEDC 2019-2020\07_MVC\Vezbi i proekti\MVCTasksAndExercises\Class07_RefactorPizzaApp\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\_ViewImports.cshtml"
using SEDC.WebApp.ModelDemo;

#line default
#line hidden
#line 2 "C:\Users\hrist\Desktop\SEDC 2019-2020\07_MVC\Vezbi i proekti\MVCTasksAndExercises\Class07_RefactorPizzaApp\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\_ViewImports.cshtml"
using SEDC.WebApp.ModelDemo.Models;

#line default
#line hidden
#line 3 "C:\Users\hrist\Desktop\SEDC 2019-2020\07_MVC\Vezbi i proekti\MVCTasksAndExercises\Class07_RefactorPizzaApp\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\_ViewImports.cshtml"
using SEDC.WebApp.ModelDemo.DataAccess.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2ee86a10eb7d5987f4c749b35241c708a214b14", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9163d0ba15980c2e0e494b041707288d93e7801", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderPizzaVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\hrist\Desktop\SEDC 2019-2020\07_MVC\Vezbi i proekti\MVCTasksAndExercises\Class07_RefactorPizzaApp\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Order\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(62, 47, true);
            WriteLiteral("\r\n<h2>Order Pizza</h2>\r\n<h3 style=\"color:red\"> ");
            EndContext();
            BeginContext(110, 13, false);
#line 7 "C:\Users\hrist\Desktop\SEDC 2019-2020\07_MVC\Vezbi i proekti\MVCTasksAndExercises\Class07_RefactorPizzaApp\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Order\Index.cshtml"
                  Write(ViewBag.Error);

#line default
#line hidden
            EndContext();
            BeginContext(123, 7, true);
            WriteLiteral("</h3>\r\n");
            EndContext();
            BeginContext(130, 574, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6be9974d91f24865a55cfe03c3ac0a74", async() => {
                BeginContext(192, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(199, 31, false);
#line 9 "C:\Users\hrist\Desktop\SEDC 2019-2020\07_MVC\Vezbi i proekti\MVCTasksAndExercises\Class07_RefactorPizzaApp\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Order\Index.cshtml"
Write(Html.HiddenFor(x => x.Pizza.Id));

#line default
#line hidden
                EndContext();
                BeginContext(230, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(237, 44, false);
#line 10 "C:\Users\hrist\Desktop\SEDC 2019-2020\07_MVC\Vezbi i proekti\MVCTasksAndExercises\Class07_RefactorPizzaApp\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Order\Index.cshtml"
Write(Html.LabelFor(order => order.User.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(281, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(287, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ca55cb105f8e461bbb5c954f89f495c8", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 11 "C:\Users\hrist\Desktop\SEDC 2019-2020\07_MVC\Vezbi i proekti\MVCTasksAndExercises\Class07_RefactorPizzaApp\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Order\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.User.FirstName);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(326, 18, true);
                WriteLiteral("\r\n    <hr />\r\n    ");
                EndContext();
                BeginContext(345, 43, false);
#line 13 "C:\Users\hrist\Desktop\SEDC 2019-2020\07_MVC\Vezbi i proekti\MVCTasksAndExercises\Class07_RefactorPizzaApp\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Order\Index.cshtml"
Write(Html.LabelFor(order => order.User.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(388, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(394, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a25d046ca373498897e60175aa10e370", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 14 "C:\Users\hrist\Desktop\SEDC 2019-2020\07_MVC\Vezbi i proekti\MVCTasksAndExercises\Class07_RefactorPizzaApp\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Order\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.User.LastName);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(432, 18, true);
                WriteLiteral("\r\n    <hr />\r\n    ");
                EndContext();
                BeginContext(451, 42, false);
#line 16 "C:\Users\hrist\Desktop\SEDC 2019-2020\07_MVC\Vezbi i proekti\MVCTasksAndExercises\Class07_RefactorPizzaApp\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Order\Index.cshtml"
Write(Html.LabelFor(order => order.User.Address));

#line default
#line hidden
                EndContext();
                BeginContext(493, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(499, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "86f07514a93a438e8a7da0016277e31e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 17 "C:\Users\hrist\Desktop\SEDC 2019-2020\07_MVC\Vezbi i proekti\MVCTasksAndExercises\Class07_RefactorPizzaApp\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Order\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.User.Address);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(536, 18, true);
                WriteLiteral("\r\n    <hr />\r\n    ");
                EndContext();
                BeginContext(555, 40, false);
#line 19 "C:\Users\hrist\Desktop\SEDC 2019-2020\07_MVC\Vezbi i proekti\MVCTasksAndExercises\Class07_RefactorPizzaApp\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Order\Index.cshtml"
Write(Html.LabelFor(order => order.User.Phone));

#line default
#line hidden
                EndContext();
                BeginContext(595, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(601, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8ea456d46eef4fdc8cf2e1fd55c8593b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 20 "C:\Users\hrist\Desktop\SEDC 2019-2020\07_MVC\Vezbi i proekti\MVCTasksAndExercises\Class07_RefactorPizzaApp\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Order\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.User.Phone);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(636, 61, true);
                WriteLiteral("\r\n    <hr />\r\n    <button type=\"submit\">Make Order</button>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(704, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderPizzaVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
