#pragma checksum "D:\ChatApp\Views\Home\Chat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3006ed41af6a5e5a14767584aaeb1c5d9e5d7fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ChatApp.Home.Views_Home_Chat), @"mvc.1.0.view", @"/Views/Home/Chat.cshtml")]
namespace ChatApp.Home
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
#line 2 "D:\ChatApp\Views\_ViewImports.cshtml"
using ChatApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3006ed41af6a5e5a14767584aaeb1c5d9e5d7fd", @"/Views/Home/Chat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1e55c8cf965a1e7fe720b9848516f6a30cad054", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Chat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Chat>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("sendMessage(event)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("chat-input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"chat-body\">\r\n");
#nullable restore
#line 3 "D:\ChatApp\Views\Home\Chat.cshtml"
     foreach( var message in Model.Messages){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"message\">\r\n            <header>");
#nullable restore
#line 5 "D:\ChatApp\Views\Home\Chat.cshtml"
               Write(message.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</header>\r\n            <p>");
#nullable restore
#line 6 "D:\ChatApp\Views\Home\Chat.cshtml"
          Write(message.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <footer>");
#nullable restore
#line 7 "D:\ChatApp\Views\Home\Chat.cshtml"
               Write(message.Timestamp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</footer>\r\n        </div>\r\n");
#nullable restore
#line 9 "D:\ChatApp\Views\Home\Chat.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3006ed41af6a5e5a14767584aaeb1c5d9e5d7fd5848", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"roomId\"");
                BeginWriteAttribute("value", " value=\"", 427, "\"", 444, 1);
#nullable restore
#line 12 "D:\ChatApp\Views\Home\Chat.cshtml"
WriteAttributeValue("", 435, Model.Id, 435, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        <input type=\"hidden\" name=\"roomName\"");
                BeginWriteAttribute("value", " value=\"", 492, "\"", 511, 1);
#nullable restore
#line 13 "D:\ChatApp\Views\Home\Chat.cshtml"
WriteAttributeValue("", 500, Model.Name, 500, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        <input type=\"text\" name=\"message\" id=\"message-input\">\r\n        <button type=\"submit\">Send</button> \r\n    ");
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3006ed41af6a5e5a14767584aaeb1c5d9e5d7fd8633", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        <script src=""https://unpkg.com/axios/dist/axios.min.js""></script>

        <script>
            var connection = new signalR.HubConnectionBuilder().withUrl(""/chatHub"").build();
            var _connectionId = '';
            connection.on(""RecieveMessage"", function (data){
                console.log(data);
                var message = document.createElement(""div"");
                message.classList.add('message');

                var header = document.createElement(""header"");
                header.appendChild(document.createTextNode(data.name + "":""));

                var p = document.createElement(""p"");
                p.appendChild(document.createTextNode(data.text));

                var footer = document.createElement(""footer"");
                footer.appendChild(document.createTextNode(data.timestamp));

                message.appendChild(header);
                message.appendChild(p);
                message.appendChild(footer);

                document.querySelec");
                WriteLiteral("tor(\'.chat-body\').append(message);\r\n            });\r\n\r\n            var joinRoom = function() {\r\n                var url = \'/Chat/JoinRoom/\'+ _connectionId + \'/");
#nullable restore
#line 47 "D:\ChatApp\Views\Home\Chat.cshtml"
                                                          Write(Model.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
                axios.post(url, null)
                    .then(res => {
                        console.log(""Room joined!"", res);
                    }).catch(err => {
                        console.log(""Failed to join Room"", err);
                    })
            }

            connection.start().then(function(){
                connection.invoke('getConnectionId')
                .then(function(connectionId){
                    _connectionId = connectionId;
                    joinRoom();
                })
            }).catch(function(err){
                console.log(err);
            });

            var form = null;

            var sendMessage = function (event) {
                event.preventDefault();
                form = event.target;

                var data = new FormData(event.target);
                document.getElementById('message-input').value = '';
                axios.post(""/Chat/SendMessage"", data).then(res => {
                    console.log(""Mess");
                WriteLiteral("age Sent!\");\r\n                }).catch(err => {\r\n                    console.log(\"Failed to send message!\");\r\n                })\r\n            }\r\n        </script>\r\n    ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Chat> Html { get; private set; }
    }
}
#pragma warning restore 1591
