#pragma checksum "D:\项目构建\CEManager\Src\CEManager\EvaluationWeb\Views\Home\EvalCenter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "138d5aed02fd3b0a7a7607d38059711ec8cc925a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EvalCenter), @"mvc.1.0.view", @"/Views/Home/EvalCenter.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/EvalCenter.cshtml", typeof(AspNetCore.Views_Home_EvalCenter))]
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
#line 1 "D:\项目构建\CEManager\Src\CEManager\EvaluationWeb\Views\_ViewImports.cshtml"
using EvaluationWeb;

#line default
#line hidden
#line 2 "D:\项目构建\CEManager\Src\CEManager\EvaluationWeb\Views\_ViewImports.cshtml"
using EvaluationWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"138d5aed02fd3b0a7a7607d38059711ec8cc925a", @"/Views/Home/EvalCenter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e1a0037731271e70fa209d42f8718895ed31497", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_EvalCenter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\项目构建\CEManager\Src\CEManager\EvaluationWeb\Views\Home\EvalCenter.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(27, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(52, 3221, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "298b4ce8947044789e78111d6788080c", async() => {
                BeginContext(58, 3208, true);
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://cdn.bootcss.com/weui/1.1.3/style/weui.min.css"">
    <link rel=""stylesheet"" href=""https://cdn.bootcss.com/jquery-weui/1.2.1/css/jquery-weui.min.css"">
    <style>
        .head-title {
            font-family: 'Arial Negreta', 'Arial';
            font-weight: 700;
            font-style: normal;
            font-size: 20px;
            color: #FFFFFF;
            white-space: nowrap;
            height: 100%;
            width: 93%;
            display: flex;
            justify-content: center;
            align-items: Center;
        }

        .demos-header {
            padding: 10px 0;
            background: url(""/images/usercenter/u113.png"") no-repeat;
            height: 62px;
            width: 100%;
            overflow: hidden;
            background-size: cover;
            display: flex;
            align-items: Center;
        }

        .box {
            height: 159px;
            background: inherit;
            backgrou");
                WriteLiteral(@"nd-color: rgba(248, 248, 248, 1);
            box-sizing: border-box;
            border-width: 1px;
            border-style: solid;
            border-color: rgba(234, 234, 234, 1);
            border-radius: 0px;
            -moz-box-shadow: none;
            -webkit-box-shadow: none;
            box-shadow: none;
        }

        .font {
            font-family: 'Microsoft YaHei Regular', 'Microsoft YaHei';
            font-weight: 400;
            font-style: normal;
            font-size: 16px;
            color: #006666;
            line-height: 50px;
        }
        .table{
            border:solid 1px #333333;
            width:100%;
            padding:0px;
            text-align: center;
            margin:0px;
             
        }
        .th{
            background-color: rgba(153, 255, 255, 1);
            margin:0px;
            padding:0px;
        }
        .u327{
                font-family: 'Arial Negreta', 'Arial';
                font-weight: 700;");
                WriteLiteral(@"
                font-style: normal;
                font-size: 16px;
        }
        .box{
            width:100%;
            height:245px;
            font-family: 'Arial Normal', 'Arial';
            font-weight: 400;
            font-style: normal;
            font-size: 13px;
            color: #333333;
            line-height: normal;
            border:solid 1px #333333;
        }
         .btn{
            margin-top:10px;            
            background-color: #66CCFF;
            width:30%;
            position: relative;
            display: block;
            margin-left: auto;
            padding-left: 14px;
            padding-right: 14px;
            box-sizing: border-box;
            font-size: 18px;
            text-align: center;
            text-decoration: none;
            color: #fff;
            line-height: 2.55555556;
            border-radius: 5px;
            -webkit-tap-highlight-color: rgba(0,0,0,0);
            overflow: hidden;
        }
 ");
                WriteLiteral("        .lineimg{\r\n             width:100%;\r\n             margin-top:30px;\r\n             margin-bottom:20px;\r\n         }\r\n    </style>\r\n");
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
            BeginContext(3273, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3275, 3966, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d4f76d01c8746878fc20b6ee5a54bdd", async() => {
                BeginContext(3281, 3953, true);
                WriteLiteral(@"
    <div class=""weui-panel"">
        <div class=""demos-header"">
            <img id=""u220_img"" class=""img "" src=""/images/usercenter/u220.png"" tabindex=""0"">
            <div class=""head-title"">评测中心</div>
            <img id=""u117_img"" class=""img "" src=""/images/usercenter/u117.png"" tabindex=""0"">
        </div>
    </div>
    
    <div class=""weui-panel weui-panel_access"" style=""height:100%;"">
        <div class=""weui-panel__bd"" style=""height:100%"">
            <a href=""javascript:void(0);"" class=""weui-media-box weui-media-box_appmsg"" style=""height:100%"">
                <div class=""weui-media-box__bd"" style=""width: 70%;height:100%"">
                    <h4 class=""weui-media-box__desc font"" style=""width:100%;text-align:right"">2019年10月10日&nbsp;星期四</h4>
                    <h4 class=""weui-media-box__desc font"">XXX&nbsp;你好</h4>
                    <h4 class=""weui-media-box__desc font"">&nbsp;当前评测计划</h4>
                    <table class=""table"" border=""1"" cellspacing=""0"">
                        <tr");
                WriteLiteral(@">
                            <th class=""th"">评测计划编号</th>
                            <th class=""th"">评测计划名称</th>
                            <th class=""th"">计划开始时间</th>
                            <th class=""th"">完成度</th>
                            <th class=""th"">计划状态</th>
                        </tr>
                        <tr>
                            <td>CNPC-1901</td>
                            <td>交易心理情绪力</td>
                            <td></td>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>CNPC-1902</td>
                            <td>交易人格</td>
                            <td></td>
                            <td></td>
                            <td></td>
                        </tr>
                    </table>
                    <div>&nbsp;</div>
                    <div>&nbsp;</div>
                    <h4 class=""weui-media-box__title u327"">CNPC190");
                WriteLiteral(@"1&nbsp;交易心理情绪力</h4>
                    <div class=""box"">
                        <span>
                            该评测计划是
                        </span>
                        <div style=""height:150px;width:100%"">

                        </div>
                        <span>
                            通过
                        </span>
                        <div style=""height:30px;width:100%"">

                        </div>
                        <span>
                            最终
                        </span>
                    </div>
                    <div style=""width:100%;text-align:right;margin:0px;"">
                        <span class=""btn"" style=""width:20%;"">进入计划</span>
                    </div>
                    <img id=""u329_img"" class=""lineimg "" src=""/images/evalcenter/u329.png"">
                    <h4 class=""weui-media-box__title u327"">CNPC1902&nbsp;交易人格</h4>
                    <div class=""box"">
                        <span>
                        ");
                WriteLiteral(@"    该评测计划是
                        </span>
                        <div style=""height:150px;width:100%"">

                        </div>
                        <span>
                            通过
                        </span>
                        <div style=""height:30px;width:100%"">

                        </div>
                        <span>
                            最终
                        </span>
                    </div>
                    <div style=""width:100%;text-align:right;margin:0px;"">
                        <span class=""btn"" style=""width:20%;"">进入计划</span>
                    </div>
                </div>
            </a>
        </div>
    </div>
    <script src=""https://cdn.bootcss.com/jquery/1.11.0/jquery.min.js""></script>
    <script src=""https://cdn.bootcss.com/jquery-weui/1.2.1/js/jquery-weui.min.js""></script>
");
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
            BeginContext(7241, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
