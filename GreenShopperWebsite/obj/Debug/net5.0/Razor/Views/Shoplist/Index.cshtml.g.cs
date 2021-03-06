#pragma checksum "C:\Users\Filipe\source\repos\GreenShopperWebsite\GreenShopperWebsite\Views\Shoplist\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ae140fb60f376f580cc20470fbf6c0cfb1587e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shoplist_Index), @"mvc.1.0.view", @"/Views/Shoplist/Index.cshtml")]
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
#line 1 "C:\Users\Filipe\source\repos\GreenShopperWebsite\GreenShopperWebsite\Views\_ViewImports.cshtml"
using GreenShopperWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Filipe\source\repos\GreenShopperWebsite\GreenShopperWebsite\Views\_ViewImports.cshtml"
using GreenShopperWebsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ae140fb60f376f580cc20470fbf6c0cfb1587e5", @"/Views/Shoplist/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0b30ef304e4ac52abc8c1537b40882daf4ada93", @"/Views/_ViewImports.cshtml")]
    public class Views_Shoplist_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetAPIGreenList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Filipe\source\repos\GreenShopperWebsite\GreenShopperWebsite\Views\Shoplist\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <h1>Help the environment by changing your shoplist!</h1>
    <p class=""p-2"">Add the products wich make your shopping list and choose a supermarket of your choice</p>
    <p class=""p-2"">The system will present you with available options wich are better for our Planet</p>

    <div class=""container"">
        <div class=""row"">
            <div class=""col"">
                <select id=""supermarket_select"" class=""form-control w-75"" onchange=""setProductsList()"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ae140fb60f376f580cc20470fbf6c0cfb1587e55261", async() => {
                WriteLiteral("--Choose a Supermarket--");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </select>\r\n            </div>\r\n            <div id=\"products_list_div\" class=\"col-8 invisible\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ae140fb60f376f580cc20470fbf6c0cfb1587e56998", async() => {
                WriteLiteral(@"
                    <input type=""hidden"" id=""supermarketSelected"" name=""supermarketSelected"" value=""none"">
                    <div id=""shoplistForm"">
                        <div class=""form-group"">
                            <div class=""row"">
                                <div class=""col"">
                                    <div class=""row"">
                                        <input id=""1"" name=""item_input"" class=""form-control"" type=""text"" placeholder=""Add new Item"" onkeyup=""getClosestProducts(this.id)"" />
                                    </div>
                                    <div id=""data_1"" class=""row invisible"">
                                        <select multiple class=""form-control invisible"" id=""sugestion_select_1""></select>
                                    </div>
                                </div>
                                <div class=""col-1"">
                                    <button type=""button"" onclick=""deleteInput(1)"" class=""btn btn-danger"">Delet");
                WriteLiteral(@"e</button>
                                </div>
                            </div>
                        </div>
                    </div>
                    <button class=""btn btn-success"" type=""submit"">
                        Get Green Shop List
                    </button>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
    </div>
    <button class=""btn btn-light"" onclick=""add_shoplist_input()"">Add new item</button>
</div>


<script>
    window.onload = getAllSupermarkets;

    function getAllSupermarkets() {
         $.ajax({
            type: ""GET"",
            url: '");
#nullable restore
#line 56 "C:\Users\Filipe\source\repos\GreenShopperWebsite\GreenShopperWebsite\Views\Shoplist\Index.cshtml"
             Write(Url.Action("GetAllSupermarkets"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            accepts: ""*/*"",
             success: function (data) {
                 for (var i = 0; i < data.length; i++){
                     var newOption = document.createElement(""option"");
                     newOption.value = data[i].name;
                     newOption.text = data[i].name;
                     document.getElementById(""supermarket_select"").appendChild(newOption);
                 }
                console.log(data);

            },
            failure: function (response) {
                console.log(response.responseText);
            },
        });
    }

    function add_shoplist_input() {
        var inputs = document.getElementsByName(""item_input"");
        var inputsAmount = inputs.length + 1;
        for (var inn = 0; inn < inputsAmount - 1; inn++) {
            inputs[inn].value = inputs[inn].value
        }
        document.getElementById(""shoplistForm"").innerHTML +=
            ""<div class='form-group'>"" +
            ""<div class='row'>"" +
    ");
            WriteLiteral(@"        ""<div class='col'>"" +
            ""<div class='row'>"" +
            ""<input id='"" + inputsAmount + ""' name='item_input' class='form-control' type='text' placeholder='Add new Item' onkeyup='getClosestProducts(this.id)' />"" +
            ""</div>"" +
            ""<div id='data_"" + inputsAmount + ""' class='row invisible'>"" +
            ""<select multiple class='form-control invisible' id='sugestion_select_"" + inputsAmount + ""'></select>"" +
            ""</div>"" +
            ""</div>"" +
            ""<div class='col-1'>"" +
            ""<button type='button' onclick='deleteInput("" + inputsAmount + "" )' class='btn btn-danger'>Delete</button>"" +
            ""</div>"" +
            ""</div>"" +
            ""</div>"";
    }

    function deleteInput(input_id) {
        event.srcElement.remove();
        console.log(input_id);
        var input_selected = document.getElementById(input_id);
        input_selected.remove();
    }

    function setProductsList() {
        var current_supermarket = d");
            WriteLiteral(@"ocument.getElementById(""supermarket_select"");
        document.getElementById(""supermarketSelected"").value = current_supermarket.value;
        console.log(current_supermarket.value);
        var inputs = document.getElementsByName(""item_input"");
        for (var inp = 0; inp < inputs.length; inp++) {
            inputs[inp].value = """";
        }

        document.getElementById(""products_list_div"").classList.remove(""invisible"");
    }

    function getClosestProducts(input_id) {
        console.log(input_id);
        var currentInput = document.getElementById(input_id).value;
        var current_supermarket = document.getElementById(""supermarket_select"").value;
        var sugestionList = document.getElementById(""sugestion_select_"" + input_id);
        sugestionList.innerHTML = """";
        var dataDiv = document.getElementById(""data_"" + input_id);
        if (currentInput == """") {
            dataDiv.classList.add(""invisible"");
            sugestionList.classList.add(""invisible"");
      ");
            WriteLiteral("  }\r\n        $.ajax({\r\n            type: \"GET\",\r\n            url: \'");
#nullable restore
#line 130 "C:\Users\Filipe\source\repos\GreenShopperWebsite\GreenShopperWebsite\Views\Shoplist\Index.cshtml"
             Write(Url.Action("GetProductsHints"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            accepts: ""*/*"",
            data: {
                input: currentInput,
                supermarket: current_supermarket
            },
            success: function (data) {
                if (data.length > 0) {
                    dataDiv.classList.remove(""invisible"");
                    sugestionList.classList.remove(""invisible"");
                } else if (data.length == 0 && currentInput.length > 0) {
                    var no_product = document.createElement(""option"");
                    no_product.text = ""There seems to be no products with that name in the choose Supermarket"";
                    no_product.selected = true;
                    no_product.disabled = true;
                }
                for (var options = 0; options < data.length; options++) {
                    var data_name = data[options].name;
                    var data_id = data[options].id;
                    var newDataOption = document.createElement(""option"");
                    new");
            WriteLiteral(@"DataOption.value = data_id;
                    newDataOption.text = data_name;
                    newDataOption.addEventListener(""click"", function (event) {
                        console.log(event.target.text);
                        $(currentInput).val(event.target.text);
                    });
                    sugestionList.appendChild(newDataOption);
                }
                console.log(data);

            },
            failure: function (response) {
                console.log(response.responseText);
            },
        });
        console.log(currentInput);
    }
</script>


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
