#pragma checksum "C:\Users\hrist\Desktop\SEDC 2019-2020\07_MVC\Vezbi i proekti\MVCTasksAndExercises\Class07_RefactorPizzaApp\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Order\OrderMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "182434d3614a8699379dd27caf6cb83588a2cdb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_OrderMenu), @"mvc.1.0.view", @"/Views/Order/OrderMenu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/OrderMenu.cshtml", typeof(AspNetCore.Views_Order_OrderMenu))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"182434d3614a8699379dd27caf6cb83588a2cdb7", @"/Views/Order/OrderMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9163d0ba15980c2e0e494b041707288d93e7801", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_OrderMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderPizzaVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 36, true);
            WriteLiteral("\r\n\r\n\r\n<h2>OrderMenu</h2>\r\n \r\n<div>\r\n");
            EndContext();
#line 8 "C:\Users\hrist\Desktop\SEDC 2019-2020\07_MVC\Vezbi i proekti\MVCTasksAndExercises\Class07_RefactorPizzaApp\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Order\OrderMenu.cshtml"
     foreach (var item in Model)
    {
        string delivered = item.Delivered ? "DELIVERED" : "NOT DELEVERED YET";

#line default
#line hidden
            BeginContext(184, 61, true);
            WriteLiteral("        <div>\r\n            <div>\r\n                Delivered: ");
            EndContext();
            BeginContext(246, 9, false);
#line 13 "C:\Users\hrist\Desktop\SEDC 2019-2020\07_MVC\Vezbi i proekti\MVCTasksAndExercises\Class07_RefactorPizzaApp\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Order\OrderMenu.cshtml"
                      Write(delivered);

#line default
#line hidden
            EndContext();
            BeginContext(255, 68, true);
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                User Name: ");
            EndContext();
            BeginContext(325, 46, false);
#line 16 "C:\Users\hrist\Desktop\SEDC 2019-2020\07_MVC\Vezbi i proekti\MVCTasksAndExercises\Class07_RefactorPizzaApp\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Order\OrderMenu.cshtml"
                       Write(item.User.FirstName + " " + item.User.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(372, 32, true);
            WriteLiteral("\r\n                User Address: ");
            EndContext();
            BeginContext(405, 17, false);
#line 17 "C:\Users\hrist\Desktop\SEDC 2019-2020\07_MVC\Vezbi i proekti\MVCTasksAndExercises\Class07_RefactorPizzaApp\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Order\OrderMenu.cshtml"
                         Write(item.User.Address);

#line default
#line hidden
            EndContext();
            BeginContext(422, 32, true);
            WriteLiteral("\r\n                Phone Number: ");
            EndContext();
            BeginContext(455, 15, false);
#line 18 "C:\Users\hrist\Desktop\SEDC 2019-2020\07_MVC\Vezbi i proekti\MVCTasksAndExercises\Class07_RefactorPizzaApp\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Order\OrderMenu.cshtml"
                         Write(item.User.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(470, 64, true);
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                Pizza: ");
            EndContext();
            BeginContext(535, 15, false);
#line 21 "C:\Users\hrist\Desktop\SEDC 2019-2020\07_MVC\Vezbi i proekti\MVCTasksAndExercises\Class07_RefactorPizzaApp\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Order\OrderMenu.cshtml"
                  Write(item.Pizza.Name);

#line default
#line hidden
            EndContext();
            BeginContext(550, 24, true);
            WriteLiteral("\r\n                Size: ");
            EndContext();
            BeginContext(575, 15, false);
#line 22 "C:\Users\hrist\Desktop\SEDC 2019-2020\07_MVC\Vezbi i proekti\MVCTasksAndExercises\Class07_RefactorPizzaApp\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Order\OrderMenu.cshtml"
                 Write(item.Pizza.Size);

#line default
#line hidden
            EndContext();
            BeginContext(590, 25, true);
            WriteLiteral("\r\n                Price: ");
            EndContext();
            BeginContext(616, 16, false);
#line 23 "C:\Users\hrist\Desktop\SEDC 2019-2020\07_MVC\Vezbi i proekti\MVCTasksAndExercises\Class07_RefactorPizzaApp\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Order\OrderMenu.cshtml"
                  Write(item.Pizza.Price);

#line default
#line hidden
            EndContext();
            BeginContext(632, 38, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 26 "C:\Users\hrist\Desktop\SEDC 2019-2020\07_MVC\Vezbi i proekti\MVCTasksAndExercises\Class07_RefactorPizzaApp\SEDC.WebApp.ModelDemo\SEDC.WebApp.ModelDemo\Views\Order\OrderMenu.cshtml"
    }

#line default
#line hidden
            BeginContext(677, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrderPizzaVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
