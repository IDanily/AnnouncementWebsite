#pragma checksum "C:\Users\Danil\Downloads\AnnouncementWebsite-main\AnnouncementWebsite-main\AnnouncementWebsite\Views\Home\_Delete.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "26baf225fdc2a29add3c32d4d004c3aab647202f437ca5def62882ca5393e4b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__Delete), @"mvc.1.0.view", @"/Views/Home/_Delete.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Danil\Downloads\AnnouncementWebsite-main\AnnouncementWebsite-main\AnnouncementWebsite\Views\_ViewImports.cshtml"
using AnnouncementWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Danil\Downloads\AnnouncementWebsite-main\AnnouncementWebsite-main\AnnouncementWebsite\Views\_ViewImports.cshtml"
using AnnouncementWebsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"26baf225fdc2a29add3c32d4d004c3aab647202f437ca5def62882ca5393e4b6", @"/Views/Home/_Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"38eaadd71a2f08ec96ccb15102e2d3c26e0c998933ffe41e0b83bb10902f57e8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home__Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AnnouncementWebsite.ViewModels.AnnouncementActionModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("actionForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Danil\Downloads\AnnouncementWebsite-main\AnnouncementWebsite-main\AnnouncementWebsite\Views\Home\_Delete.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""modal-content"">
        <div class=""modal-header"">
            <h5 class=""modal-title"">
                <span>
                    Удаление объявления
                </span>
            </h5>
            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                <span aria-hidden=""true"">&times;</span>
            </button>
        </div>
        <div class=""modal-body"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26baf225fdc2a29add3c32d4d004c3aab647202f437ca5def62882ca5393e4b64641", async() => {
                WriteLiteral("\n                <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 590, "\"", 607, 1);
#nullable restore
#line 18 "C:\Users\Danil\Downloads\AnnouncementWebsite-main\AnnouncementWebsite-main\AnnouncementWebsite\Views\Home\_Delete.cshtml"
WriteAttributeValue("", 598, Model.Id, 598, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <div class=""alert alert-danger"" role=""alert"">
                Вы уверены что хотите удалить объявление?
            </div>
        </div>
        <div class=""modal-footer"">
            <button id=""actionButton"" type=""button"" class=""btn btn-danger""><i class=""fas fa-trash-alt mr-1""></i> Удалить</button>
            <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal""><i class=""fas fa-times mr-1""></i> Закрыть</button>
        </div>
    </div>
");
#nullable restore
#line 29 "C:\Users\Danil\Downloads\AnnouncementWebsite-main\AnnouncementWebsite-main\AnnouncementWebsite\Views\Home\_Delete.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<script>\n    $(\"#actionButton\").click(function() {\n        $.ajax({\n            url: \'");
#nullable restore
#line 34 "C:\Users\Danil\Downloads\AnnouncementWebsite-main\AnnouncementWebsite-main\AnnouncementWebsite\Views\Home\_Delete.cshtml"
             Write(Url.Action("Delete", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            type: ""post"",
            data: $(""#actionForm"").serialize()
        }).done(function (response) {
            if (response.Success = true) {
                location.reload();
            } else {
                $("".errorDiv"").html(response.Message);
            }
        });
    });
</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AnnouncementWebsite.ViewModels.AnnouncementActionModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
