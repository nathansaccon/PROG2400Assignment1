#pragma checksum "C:\Users\natha\Documents\PROG2400 - Software Quality and Usability\Assignment 2\PROG2400Assignment1\PROG2400A1NathanSaccon\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "113c79b16d7556fa1b39d433ed2eb513ac75b04a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\natha\Documents\PROG2400 - Software Quality and Usability\Assignment 2\PROG2400Assignment1\PROG2400A1NathanSaccon\Views\_ViewImports.cshtml"
using PROG2400A1NathanSaccon;

#line default
#line hidden
#line 2 "C:\Users\natha\Documents\PROG2400 - Software Quality and Usability\Assignment 2\PROG2400Assignment1\PROG2400A1NathanSaccon\Views\_ViewImports.cshtml"
using PROG2400A1NathanSaccon.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"113c79b16d7556fa1b39d433ed2eb513ac75b04a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c04f063373a07401aadb90075d92a823837068ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InputData>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\natha\Documents\PROG2400 - Software Quality and Usability\Assignment 2\PROG2400Assignment1\PROG2400A1NathanSaccon\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(64, 46, true);
            WriteLiteral("\r\n\r\n<h3>Alien Text Modifier</h3>\r\n\r\n<br />\r\n\r\n");
            EndContext();
#line 11 "C:\Users\natha\Documents\PROG2400 - Software Quality and Usability\Assignment 2\PROG2400Assignment1\PROG2400A1NathanSaccon\Views\Home\Index.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(145, 30, false);
#line 13 "C:\Users\natha\Documents\PROG2400 - Software Quality and Usability\Assignment 2\PROG2400Assignment1\PROG2400A1NathanSaccon\Views\Home\Index.cshtml"
Write(Html.Label("Enter Text Here:"));

#line default
#line hidden
            EndContext();
            BeginContext(182, 45, false);
#line 14 "C:\Users\natha\Documents\PROG2400 - Software Quality and Usability\Assignment 2\PROG2400Assignment1\PROG2400A1NathanSaccon\Views\Home\Index.cshtml"
Write(Html.TextArea("inputArea", null, 3, 40, null));

#line default
#line hidden
            EndContext();
            BeginContext(227, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
            BeginContext(237, 42, true);
            WriteLiteral("    <div class=\"green boxInput\">\r\n        ");
            EndContext();
            BeginContext(280, 19, false);
#line 17 "C:\Users\natha\Documents\PROG2400 - Software Quality and Usability\Assignment 2\PROG2400Assignment1\PROG2400A1NathanSaccon\Views\Home\Index.cshtml"
   Write(Html.Label("Green"));

#line default
#line hidden
            EndContext();
            BeginContext(299, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(310, 47, false);
#line 18 "C:\Users\natha\Documents\PROG2400 - Software Quality and Usability\Assignment 2\PROG2400Assignment1\PROG2400A1NathanSaccon\Views\Home\Index.cshtml"
   Write(Html.RadioButton("modificationOption", "green"));

#line default
#line hidden
            EndContext();
            BeginContext(357, 56, true);
            WriteLiteral("\r\n    </div><br />\r\n    <div class=\"boxInput\">\r\n        ");
            EndContext();
            BeginContext(414, 21, false);
#line 21 "C:\Users\natha\Documents\PROG2400 - Software Quality and Usability\Assignment 2\PROG2400Assignment1\PROG2400A1NathanSaccon\Views\Home\Index.cshtml"
   Write(Html.Label("Reverse"));

#line default
#line hidden
            EndContext();
            BeginContext(435, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(446, 49, false);
#line 22 "C:\Users\natha\Documents\PROG2400 - Software Quality and Usability\Assignment 2\PROG2400Assignment1\PROG2400A1NathanSaccon\Views\Home\Index.cshtml"
   Write(Html.RadioButton("modificationOption", "reverse"));

#line default
#line hidden
            EndContext();
            BeginContext(495, 61, true);
            WriteLiteral("\r\n    </div><br />\r\n    <div class=\"bold boxInput\">\r\n        ");
            EndContext();
            BeginContext(557, 18, false);
#line 25 "C:\Users\natha\Documents\PROG2400 - Software Quality and Usability\Assignment 2\PROG2400Assignment1\PROG2400A1NathanSaccon\Views\Home\Index.cshtml"
   Write(Html.Label("Bold"));

#line default
#line hidden
            EndContext();
            BeginContext(575, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(586, 46, false);
#line 26 "C:\Users\natha\Documents\PROG2400 - Software Quality and Usability\Assignment 2\PROG2400Assignment1\PROG2400A1NathanSaccon\Views\Home\Index.cshtml"
   Write(Html.RadioButton("modificationOption", "bold"));

#line default
#line hidden
            EndContext();
            BeginContext(632, 63, true);
            WriteLiteral("\r\n    </div><br />\r\n    <div class=\"italic boxInput\">\r\n        ");
            EndContext();
            BeginContext(696, 20, false);
#line 29 "C:\Users\natha\Documents\PROG2400 - Software Quality and Usability\Assignment 2\PROG2400Assignment1\PROG2400A1NathanSaccon\Views\Home\Index.cshtml"
   Write(Html.Label("Italic"));

#line default
#line hidden
            EndContext();
            BeginContext(716, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(727, 48, false);
#line 30 "C:\Users\natha\Documents\PROG2400 - Software Quality and Usability\Assignment 2\PROG2400Assignment1\PROG2400A1NathanSaccon\Views\Home\Index.cshtml"
   Write(Html.RadioButton("modificationOption", "italic"));

#line default
#line hidden
            EndContext();
            BeginContext(775, 56, true);
            WriteLiteral("\r\n    </div><br />\r\n    <div class=\"boxInput\">\r\n        ");
            EndContext();
            BeginContext(832, 17, false);
#line 33 "C:\Users\natha\Documents\PROG2400 - Software Quality and Usability\Assignment 2\PROG2400Assignment1\PROG2400A1NathanSaccon\Views\Home\Index.cshtml"
   Write(Html.Label("D2B"));

#line default
#line hidden
            EndContext();
            BeginContext(849, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(860, 45, false);
#line 34 "C:\Users\natha\Documents\PROG2400 - Software Quality and Usability\Assignment 2\PROG2400Assignment1\PROG2400A1NathanSaccon\Views\Home\Index.cshtml"
   Write(Html.RadioButton("modificationOption", "D2B"));

#line default
#line hidden
            EndContext();
            BeginContext(905, 56, true);
            WriteLiteral("\r\n    </div><br />\r\n    <div class=\"boxInput\">\r\n        ");
            EndContext();
            BeginContext(962, 17, false);
#line 37 "C:\Users\natha\Documents\PROG2400 - Software Quality and Usability\Assignment 2\PROG2400Assignment1\PROG2400A1NathanSaccon\Views\Home\Index.cshtml"
   Write(Html.Label("D2B"));

#line default
#line hidden
            EndContext();
            BeginContext(979, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(990, 45, false);
#line 38 "C:\Users\natha\Documents\PROG2400 - Software Quality and Usability\Assignment 2\PROG2400Assignment1\PROG2400A1NathanSaccon\Views\Home\Index.cshtml"
   Write(Html.RadioButton("modificationOption", "B2D"));

#line default
#line hidden
            EndContext();
            BeginContext(1035, 20, true);
            WriteLiteral("\r\n    </div><br />\r\n");
            EndContext();
            BeginContext(1057, 87, true);
            WriteLiteral("    <input type=\"submit\" value=\"Display Text\" tabindex=\"6\" name=\"modificationOption\">\r\n");
            EndContext();
#line 42 "C:\Users\natha\Documents\PROG2400 - Software Quality and Usability\Assignment 2\PROG2400Assignment1\PROG2400A1NathanSaccon\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1147, 24, true);
            WriteLiteral("\r\n<br /><br /><br />\r\n\r\n");
            EndContext();
#line 46 "C:\Users\natha\Documents\PROG2400 - Software Quality and Usability\Assignment 2\PROG2400Assignment1\PROG2400A1NathanSaccon\Views\Home\Index.cshtml"
  
    try
    {
        

#line default
#line hidden
            BeginContext(1200, 21, false);
#line 49 "C:\Users\natha\Documents\PROG2400 - Software Quality and Usability\Assignment 2\PROG2400Assignment1\PROG2400A1NathanSaccon\Views\Home\Index.cshtml"
   Write(Html.Raw(Model.Input));

#line default
#line hidden
            EndContext();
#line 49 "C:\Users\natha\Documents\PROG2400 - Software Quality and Usability\Assignment 2\PROG2400Assignment1\PROG2400A1NathanSaccon\Views\Home\Index.cshtml"
                              
    }
    catch (Exception)
    {
    }

#line default
#line hidden
            BeginContext(1270, 10, true);
            WriteLiteral("\r\n<br />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InputData> Html { get; private set; }
    }
}
#pragma warning restore 1591