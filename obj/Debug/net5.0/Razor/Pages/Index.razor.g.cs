#pragma checksum "/Users/user/Desktop/Coding Project/dassproject/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48b8b6fcdc5f865d1cc14e73e3b872158723e251"
// <auto-generated/>
#pragma warning disable 1591
namespace dassProjectBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/user/Desktop/Coding Project/dassproject/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/user/Desktop/Coding Project/dassproject/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/user/Desktop/Coding Project/dassproject/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/user/Desktop/Coding Project/dassproject/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/user/Desktop/Coding Project/dassproject/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/user/Desktop/Coding Project/dassproject/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/user/Desktop/Coding Project/dassproject/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/user/Desktop/Coding Project/dassproject/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/user/Desktop/Coding Project/dassproject/_Imports.razor"
using dassProjectBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/user/Desktop/Coding Project/dassproject/_Imports.razor"
using dassProjectBlazor.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<!doctype html>\r\n");
            __builder.OpenElement(1, "html");
            __builder.AddAttribute(2, "lang", "en");
            __builder.AddMarkupContent(3, "<head><title>Kaji Selidik DASS</title></head>\r\n\r\n");
            __builder.OpenElement(4, "body");
            __builder.AddMarkupContent(5, "<style>\r\n    .custom-form{\r\n      background-color: E4D6D2;\r\n    }\r\n  </style>\r\n\r\n  ");
            __builder.AddMarkupContent(6, @"<div class=""text-center p-5"" style=""background-color: #E4D6D2;""><h1>Soal Selidik DASS</h1>
    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Earum, at rem ut quaerat ipsam praesentium ab. Quas aut cupiditate impedit molestias, quis veritatis perspiciatis voluptatem libero ipsam praesentium ipsa enim.</p></div>
  
  ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "container-fluid h-100 d-flex flex-column");
            __builder.OpenElement(9, "form");
            __builder.AddAttribute(10, "class", "custom-form bg-light p-3");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "row justify-content-center flex-grow-1");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col-sm-4 p-3");
            __builder.AddMarkupContent(15, "<h4>Jantina</h4>\r\n              ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "form-group");
            __builder.OpenElement(18, "select");
            __builder.AddAttribute(19, "required");
            __builder.AddAttribute(20, "class", "form-control");
            __builder.AddAttribute(21, "id", "gender");
            __builder.AddAttribute(22, "name", "gender");
            __builder.OpenElement(23, "option");
            __builder.AddAttribute(24, "disabled");
            __builder.AddAttribute(25, "selected");
            __builder.AddAttribute(26, "value");
            __builder.AddContent(27, " -- sila pilih -- ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                  ");
            __builder.OpenElement(29, "option");
            __builder.AddAttribute(30, "value", "malay");
            __builder.AddContent(31, "Lelaki");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                  ");
            __builder.OpenElement(33, "option");
            __builder.AddAttribute(34, "value", "chinese");
            __builder.AddContent(35, "Perempuan");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "col-sm-4 p-3");
            __builder.AddMarkupContent(39, "<h4>Umur</h4>\r\n                ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "form-group");
            __builder.OpenElement(42, "select");
            __builder.AddAttribute(43, "required");
            __builder.AddAttribute(44, "class", "form-control");
            __builder.AddAttribute(45, "id", "age");
            __builder.AddAttribute(46, "name", "age");
            __builder.OpenElement(47, "option");
            __builder.AddAttribute(48, "value", "under 12");
            __builder.AddContent(49, "Bawah 12");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                    ");
            __builder.OpenElement(51, "option");
            __builder.AddAttribute(52, "value", "12-17");
            __builder.AddContent(53, "12 hingga 17");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                    ");
            __builder.OpenElement(55, "option");
            __builder.AddAttribute(56, "value", "18-24");
            __builder.AddContent(57, "18 hingga 24");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                    ");
            __builder.OpenElement(59, "option");
            __builder.AddAttribute(60, "value", "25-34");
            __builder.AddAttribute(61, "selected");
            __builder.AddContent(62, "25 hingga 34");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                    ");
            __builder.OpenElement(64, "option");
            __builder.AddAttribute(65, "value", "35-44");
            __builder.AddContent(66, "35 hingga 44");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                    ");
            __builder.OpenElement(68, "option");
            __builder.AddAttribute(69, "value", "45-54");
            __builder.AddContent(70, "45 hingga 54");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                    ");
            __builder.OpenElement(72, "option");
            __builder.AddAttribute(73, "value", "55-64");
            __builder.AddContent(74, "55 hingga 64");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                    ");
            __builder.OpenElement(76, "option");
            __builder.AddAttribute(77, "value", "65-74");
            __builder.AddContent(78, "65 hingga 74");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                    ");
            __builder.OpenElement(80, "option");
            __builder.AddAttribute(81, "value", "over 75");
            __builder.AddContent(82, "Lebih 75");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n        ");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "row justify-content-center");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "col-sm-4 p-3");
            __builder.AddMarkupContent(88, "<h4>Bangsa</h4>\r\n                ");
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "class", "form-group");
            __builder.OpenElement(91, "select");
            __builder.AddAttribute(92, "required");
            __builder.AddAttribute(93, "class", "form-control");
            __builder.AddAttribute(94, "id", "race");
            __builder.AddAttribute(95, "name", "race");
            __builder.OpenElement(96, "option");
            __builder.AddAttribute(97, "disabled");
            __builder.AddAttribute(98, "selected");
            __builder.AddAttribute(99, "value");
            __builder.AddContent(100, " -- sila pilih -- ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n                    ");
            __builder.OpenElement(102, "option");
            __builder.AddAttribute(103, "value", "malay");
            __builder.AddContent(104, "Melayu");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n                    ");
            __builder.OpenElement(106, "option");
            __builder.AddAttribute(107, "value", "chinese");
            __builder.AddContent(108, "Cina");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n                    ");
            __builder.OpenElement(110, "option");
            __builder.AddAttribute(111, "value", "indian");
            __builder.AddContent(112, "India");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n                    ");
            __builder.OpenElement(114, "option");
            __builder.AddAttribute(115, "value", "other");
            __builder.AddContent(116, "Lain-Lain");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n            ");
            __builder.OpenElement(118, "div");
            __builder.AddAttribute(119, "class", "col-sm-4 p-3");
            __builder.AddMarkupContent(120, "<h4>Status Perkahwinan</h4>\r\n                ");
            __builder.OpenElement(121, "div");
            __builder.AddAttribute(122, "class", "form-group");
            __builder.OpenElement(123, "select");
            __builder.AddAttribute(124, "required");
            __builder.AddAttribute(125, "class", "form-control");
            __builder.AddAttribute(126, "id", "marital");
            __builder.AddAttribute(127, "name", "marital");
            __builder.OpenElement(128, "option");
            __builder.AddAttribute(129, "value", "single");
            __builder.AddContent(130, "Bujang");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n                    ");
            __builder.OpenElement(132, "option");
            __builder.AddAttribute(133, "value", "married");
            __builder.AddContent(134, "Berkahwin");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n                    ");
            __builder.OpenElement(136, "option");
            __builder.AddAttribute(137, "value", "divorced/widowed");
            __builder.AddContent(138, "Janda/Duda");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n        ");
            __builder.OpenElement(140, "div");
            __builder.AddAttribute(141, "class", "row justify-content-center");
            __builder.OpenElement(142, "div");
            __builder.AddAttribute(143, "class", "col-sm-4 p-3");
            __builder.AddMarkupContent(144, "<h4></h4>\r\n                ");
            __builder.OpenElement(145, "div");
            __builder.AddAttribute(146, "class", "form-group");
            __builder.OpenElement(147, "select");
            __builder.AddAttribute(148, "required");
            __builder.AddAttribute(149, "class", "form-control");
            __builder.AddAttribute(150, "id", "education");
            __builder.AddAttribute(151, "name", "education");
            __builder.OpenElement(152, "option");
            __builder.AddAttribute(153, "value", "primary");
            __builder.AddContent(154, "Sekolah Rendah");
            __builder.CloseElement();
            __builder.AddMarkupContent(155, "\r\n                    ");
            __builder.OpenElement(156, "option");
            __builder.AddAttribute(157, "value", "secondary");
            __builder.AddContent(158, "Sekolah Menengah");
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "\r\n                    ");
            __builder.OpenElement(160, "option");
            __builder.AddAttribute(161, "value", "college/university");
            __builder.AddAttribute(162, "selected");
            __builder.AddContent(163, "Kolej/Universiti");
            __builder.CloseElement();
            __builder.AddMarkupContent(164, "\r\n                    ");
            __builder.OpenElement(165, "option");
            __builder.AddAttribute(166, "value", "none");
            __builder.AddContent(167, "Tiada");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(168, "\r\n            ");
            __builder.OpenElement(169, "div");
            __builder.AddAttribute(170, "class", "col-sm-4 p-3");
            __builder.AddMarkupContent(171, "<h4>Pekerjaan</h4>\r\n                ");
            __builder.OpenElement(172, "div");
            __builder.AddAttribute(173, "class", "form-group");
            __builder.OpenElement(174, "select");
            __builder.AddAttribute(175, "required");
            __builder.AddAttribute(176, "class", "form-control");
            __builder.AddAttribute(177, "id", "occupation");
            __builder.AddAttribute(178, "name", "occupation");
            __builder.OpenElement(179, "option");
            __builder.AddAttribute(180, "value", "professional");
            __builder.AddContent(181, "Professional");
            __builder.CloseElement();
            __builder.AddMarkupContent(182, "\r\n                    ");
            __builder.OpenElement(183, "option");
            __builder.AddAttribute(184, "value", "skilled");
            __builder.AddContent(185, "Skilled");
            __builder.CloseElement();
            __builder.AddMarkupContent(186, "\r\n                    ");
            __builder.OpenElement(187, "option");
            __builder.AddAttribute(188, "value", "semi-skilled");
            __builder.AddContent(189, "Semi-skilled");
            __builder.CloseElement();
            __builder.AddMarkupContent(190, "\r\n                    ");
            __builder.OpenElement(191, "option");
            __builder.AddAttribute(192, "value", "student");
            __builder.AddContent(193, "Pelajar");
            __builder.CloseElement();
            __builder.AddMarkupContent(194, "\r\n                    ");
            __builder.OpenElement(195, "option");
            __builder.AddAttribute(196, "value", "unemployed");
            __builder.AddContent(197, "Penganggur");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(198, "\r\n        \r\n        ");
            __builder.AddMarkupContent(199, "<a type=\"button\" class=\"btn btn-block btn-lg btn-more\" href=\"/question\"><i class=\"fa fa-pencil fa-pulse border-0\">Mula</i></a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 116 "/Users/user/Desktop/Coding Project/dassproject/Pages/Index.razor"
 
  private void startAnswering(){
    NavigationManager.NavigateTo("Question");
  }
  

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
