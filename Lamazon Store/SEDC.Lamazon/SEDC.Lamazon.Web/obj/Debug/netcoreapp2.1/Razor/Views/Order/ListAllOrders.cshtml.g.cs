#pragma checksum "C:\Users\hrist\Desktop\SEDC 2019-2020\09_Practical ASP.NET apps development\Proekt\SEDC.Lamazon.Web\Practical-ASP.NET-apps-development\SEDC.Lamazon\SEDC.Lamazon.Web\Views\Order\ListAllOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f2d2c22c203429ecf01c1a68e183b7a15f4e03c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_ListAllOrders), @"mvc.1.0.view", @"/Views/Order/ListAllOrders.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/ListAllOrders.cshtml", typeof(AspNetCore.Views_Order_ListAllOrders))]
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
#line 1 "C:\Users\hrist\Desktop\SEDC 2019-2020\09_Practical ASP.NET apps development\Proekt\SEDC.Lamazon.Web\Practical-ASP.NET-apps-development\SEDC.Lamazon\SEDC.Lamazon.Web\Views\_ViewImports.cshtml"
using SEDC.Lamazon.Web;

#line default
#line hidden
#line 2 "C:\Users\hrist\Desktop\SEDC 2019-2020\09_Practical ASP.NET apps development\Proekt\SEDC.Lamazon.Web\Practical-ASP.NET-apps-development\SEDC.Lamazon\SEDC.Lamazon.Web\Views\_ViewImports.cshtml"
using SEDC.Lamazon.Web.Models;

#line default
#line hidden
#line 3 "C:\Users\hrist\Desktop\SEDC 2019-2020\09_Practical ASP.NET apps development\Proekt\SEDC.Lamazon.Web\Practical-ASP.NET-apps-development\SEDC.Lamazon\SEDC.Lamazon.Web\Views\_ViewImports.cshtml"
using SEDC.Lamazon.WebModels.ViewModels;

#line default
#line hidden
#line 4 "C:\Users\hrist\Desktop\SEDC 2019-2020\09_Practical ASP.NET apps development\Proekt\SEDC.Lamazon.Web\Practical-ASP.NET-apps-development\SEDC.Lamazon\SEDC.Lamazon.Web\Views\_ViewImports.cshtml"
using SEDC.Lamazon.WebModels.Enum;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f2d2c22c203429ecf01c1a68e183b7a15f4e03c", @"/Views/Order/ListAllOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aabb48ca81533bb05570240dc00adb6e47ee8bd4", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_ListAllOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "approveorder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "declineorder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\hrist\Desktop\SEDC 2019-2020\09_Practical ASP.NET apps development\Proekt\SEDC.Lamazon.Web\Practical-ASP.NET-apps-development\SEDC.Lamazon\SEDC.Lamazon.Web\Views\Order\ListAllOrders.cshtml"
  
    ViewData["Title"] = "ListAllOrders";

#line default
#line hidden
            BeginContext(78, 375, true);
            WriteLiteral(@"
<h2>All users' orders</h2>

<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Status</th>
            <th scope=""col"">Price</th>
            <th scope=""col"">User full name</th>
            <th scope=""col"">Products</th>
            <th scope=""col"">Actions</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 20 "C:\Users\hrist\Desktop\SEDC 2019-2020\09_Practical ASP.NET apps development\Proekt\SEDC.Lamazon.Web\Practical-ASP.NET-apps-development\SEDC.Lamazon\SEDC.Lamazon.Web\Views\Order\ListAllOrders.cshtml"
         foreach (var order in Model)
        {

#line default
#line hidden
            BeginContext(503, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(542, 8, false);
#line 23 "C:\Users\hrist\Desktop\SEDC 2019-2020\09_Practical ASP.NET apps development\Proekt\SEDC.Lamazon.Web\Practical-ASP.NET-apps-development\SEDC.Lamazon\SEDC.Lamazon.Web\Views\Order\ListAllOrders.cshtml"
               Write(order.Id);

#line default
#line hidden
            EndContext();
            BeginContext(550, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(578, 12, false);
#line 24 "C:\Users\hrist\Desktop\SEDC 2019-2020\09_Practical ASP.NET apps development\Proekt\SEDC.Lamazon.Web\Practical-ASP.NET-apps-development\SEDC.Lamazon\SEDC.Lamazon.Web\Views\Order\ListAllOrders.cshtml"
               Write(order.Status);

#line default
#line hidden
            EndContext();
            BeginContext(590, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(618, 11, false);
#line 25 "C:\Users\hrist\Desktop\SEDC 2019-2020\09_Practical ASP.NET apps development\Proekt\SEDC.Lamazon.Web\Practical-ASP.NET-apps-development\SEDC.Lamazon\SEDC.Lamazon.Web\Views\Order\ListAllOrders.cshtml"
               Write(order.Price);

#line default
#line hidden
            EndContext();
            BeginContext(629, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(657, 19, false);
#line 26 "C:\Users\hrist\Desktop\SEDC 2019-2020\09_Practical ASP.NET apps development\Proekt\SEDC.Lamazon.Web\Practical-ASP.NET-apps-development\SEDC.Lamazon\SEDC.Lamazon.Web\Views\Order\ListAllOrders.cshtml"
               Write(order.User.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(676, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 27 "C:\Users\hrist\Desktop\SEDC 2019-2020\09_Practical ASP.NET apps development\Proekt\SEDC.Lamazon.Web\Practical-ASP.NET-apps-development\SEDC.Lamazon\SEDC.Lamazon.Web\Views\Order\ListAllOrders.cshtml"
                  
                    int i = 0;
                

#line default
#line hidden
            BeginContext(754, 22, true);
            WriteLiteral("                <td>\r\n");
            EndContext();
#line 31 "C:\Users\hrist\Desktop\SEDC 2019-2020\09_Practical ASP.NET apps development\Proekt\SEDC.Lamazon.Web\Practical-ASP.NET-apps-development\SEDC.Lamazon\SEDC.Lamazon.Web\Views\Order\ListAllOrders.cshtml"
                     foreach (var product in order.Products)
                    {
                        i++;
                        if (order.Products.Count() == i)
                        {

#line default
#line hidden
            BeginContext(976, 34, true);
            WriteLiteral("                            <span>");
            EndContext();
            BeginContext(1011, 12, false);
#line 36 "C:\Users\hrist\Desktop\SEDC 2019-2020\09_Practical ASP.NET apps development\Proekt\SEDC.Lamazon.Web\Practical-ASP.NET-apps-development\SEDC.Lamazon\SEDC.Lamazon.Web\Views\Order\ListAllOrders.cshtml"
                             Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1023, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 37 "C:\Users\hrist\Desktop\SEDC 2019-2020\09_Practical ASP.NET apps development\Proekt\SEDC.Lamazon.Web\Practical-ASP.NET-apps-development\SEDC.Lamazon\SEDC.Lamazon.Web\Views\Order\ListAllOrders.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1116, 34, true);
            WriteLiteral("                            <span>");
            EndContext();
            BeginContext(1151, 12, false);
#line 40 "C:\Users\hrist\Desktop\SEDC 2019-2020\09_Practical ASP.NET apps development\Proekt\SEDC.Lamazon.Web\Practical-ASP.NET-apps-development\SEDC.Lamazon\SEDC.Lamazon.Web\Views\Order\ListAllOrders.cshtml"
                             Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1163, 10, true);
            WriteLiteral(",</span>\r\n");
            EndContext();
#line 41 "C:\Users\hrist\Desktop\SEDC 2019-2020\09_Practical ASP.NET apps development\Proekt\SEDC.Lamazon.Web\Practical-ASP.NET-apps-development\SEDC.Lamazon\SEDC.Lamazon.Web\Views\Order\ListAllOrders.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(1223, 23, true);
            WriteLiteral("                </td>\r\n");
            EndContext();
#line 44 "C:\Users\hrist\Desktop\SEDC 2019-2020\09_Practical ASP.NET apps development\Proekt\SEDC.Lamazon.Web\Practical-ASP.NET-apps-development\SEDC.Lamazon\SEDC.Lamazon.Web\Views\Order\ListAllOrders.cshtml"
                 if (order.Status == StatusTypeViewModel.Pending)
                {

#line default
#line hidden
            BeginContext(1332, 50, true);
            WriteLiteral("                    <td>\r\n                        ");
            EndContext();
            BeginContext(1382, 117, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b67a7c015e3045c9b9503fc7720662d1", async() => {
                BeginContext(1488, 7, true);
                WriteLiteral("Approve");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-orderId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "C:\Users\hrist\Desktop\SEDC 2019-2020\09_Practical ASP.NET apps development\Proekt\SEDC.Lamazon.Web\Practical-ASP.NET-apps-development\SEDC.Lamazon\SEDC.Lamazon.Web\Views\Order\ListAllOrders.cshtml"
                                                                                   WriteLiteral(order.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-orderId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1499, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1525, 117, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cb68ab50376457da11245cfdb213a89", async() => {
                BeginContext(1631, 7, true);
                WriteLiteral("Decline");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-orderId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "C:\Users\hrist\Desktop\SEDC 2019-2020\09_Practical ASP.NET apps development\Proekt\SEDC.Lamazon.Web\Practical-ASP.NET-apps-development\SEDC.Lamazon\SEDC.Lamazon.Web\Views\Order\ListAllOrders.cshtml"
                                                                                   WriteLiteral(order.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-orderId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1642, 29, true);
            WriteLiteral("\r\n                    </td>\r\n");
            EndContext();
#line 50 "C:\Users\hrist\Desktop\SEDC 2019-2020\09_Practical ASP.NET apps development\Proekt\SEDC.Lamazon.Web\Practical-ASP.NET-apps-development\SEDC.Lamazon\SEDC.Lamazon.Web\Views\Order\ListAllOrders.cshtml"
                }
                else if (order.Status == StatusTypeViewModel.Confirmed)
                {

#line default
#line hidden
            BeginContext(1782, 55, true);
            WriteLiteral("                    <td>Waiting to be delivered!</td>\r\n");
            EndContext();
#line 54 "C:\Users\hrist\Desktop\SEDC 2019-2020\09_Practical ASP.NET apps development\Proekt\SEDC.Lamazon.Web\Practical-ASP.NET-apps-development\SEDC.Lamazon\SEDC.Lamazon.Web\Views\Order\ListAllOrders.cshtml"
                }
                else if (order.Status == StatusTypeViewModel.Declined)
                {

#line default
#line hidden
            BeginContext(1947, 73, true);
            WriteLiteral("                    <td>You have successfully declined this order!</td>\r\n");
            EndContext();
#line 58 "C:\Users\hrist\Desktop\SEDC 2019-2020\09_Practical ASP.NET apps development\Proekt\SEDC.Lamazon.Web\Practical-ASP.NET-apps-development\SEDC.Lamazon\SEDC.Lamazon.Web\Views\Order\ListAllOrders.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(2080, 52, true);
            WriteLiteral("                    <td>Waiting for customer!</td>\r\n");
            EndContext();
#line 62 "C:\Users\hrist\Desktop\SEDC 2019-2020\09_Practical ASP.NET apps development\Proekt\SEDC.Lamazon.Web\Practical-ASP.NET-apps-development\SEDC.Lamazon\SEDC.Lamazon.Web\Views\Order\ListAllOrders.cshtml"
                }

#line default
#line hidden
            BeginContext(2151, 19, true);
            WriteLiteral("            </tr>\r\n");
            EndContext();
#line 64 "C:\Users\hrist\Desktop\SEDC 2019-2020\09_Practical ASP.NET apps development\Proekt\SEDC.Lamazon.Web\Practical-ASP.NET-apps-development\SEDC.Lamazon\SEDC.Lamazon.Web\Views\Order\ListAllOrders.cshtml"
        }

#line default
#line hidden
            BeginContext(2181, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrderViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
