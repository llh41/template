#pragma checksum "/Users/lorenzoash/Desktop/emailTemplate/Views/Home/Email.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8393a26c7a8db547b04d8c231c775cb5be2844b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Email), @"mvc.1.0.view", @"/Views/Home/Email.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Email.cshtml", typeof(AspNetCore.Views_Home_Email))]
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
#line 1 "/Users/lorenzoash/Desktop/emailTemplate/Views/_ViewImports.cshtml"
using emailTemplate;

#line default
#line hidden
#line 2 "/Users/lorenzoash/Desktop/emailTemplate/Views/_ViewImports.cshtml"
using emailTemplate.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8393a26c7a8db547b04d8c231c775cb5be2844b4", @"/Views/Home/Email.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca25b1175474e5c3c3a8bb13546eacfcd2cd4eb0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Email : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 1, true);
            WriteLiteral(" ");
            EndContext();
#line 1 "/Users/lorenzoash/Desktop/emailTemplate/Views/Home/Email.cshtml"
   
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(46, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(50, 8035, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8393a26c7a8db547b04d8c231c775cb5be2844b43468", async() => {
                BeginContext(56, 8022, true);
                WriteLiteral(@"
    <style type=""text/css"">
        body {
            Margin: 0 !important;
            padding: 15px;
            background-color: #FFF;
        }

        .wrapper {
            width: 100%;
            table-layout: fixed;
        }

        .wrapper-inner {
            width: 100%;
            background-color: #eee;
            max-width: 670px;
            Margin: 0 auto;
        }

        table {
            border-spacing: 0;
            font-family: sans-serif;
            color: #727f80;
        }

        .outer-table {
            width: 100%;
            max-width: 670px;
            margin: 0 auto;
            background-color: #FFF;
        }

        td {
            padding: 0;
        }

        .header {
            background-color: #C2C1C1;
            border-bottom: 3px solid #81B9C3;
        }

        p {
            Margin: 0;
        }

        .header p {
            text-align: center;
            padding: 1%;
            font-we");
                WriteLiteral(@"ight: 500;
            font-size: 11px;
            text-transform: uppercase;
        }

        a {
            color: #F1F1F1;
            text-decoration: none;
        }

        /*--- End Outer Table 1 --*/

        .main-table-first {
            width: 100%;
            max-width: 610px;
            Margin: 0 auto;
            background-color: #FFF;
            border-radius: 6px;
            margin-top: 25px;
        }

        /*--- Start Two Column Sections --*/

        .two-column {
            text-align: center;
            font-size: 0;
            padding: 5px 0 10px 0;
        }

        .two-column .section {
            width: 100%;
            max-width: 300px;
            display: inline-block;
            vertical-align: top;
        }

        .two-column .content {
            font-size: 16px;
            line-height: 20px;
            text-align: justify;
        }

        .content {
            width: 100%;
            padding-top: 20px;");
                WriteLiteral(@"
        }

        .center {
            display: table;
            Margin: 0 auto;
        }

        img {
            border: 0;
        }

        img.logo {
            
            max-width: 900px !important;
        }

        #callout {
            float: right;
            Margin: 4% 5% 2% 0;
            height: auto;
            overflow: hidden;
        }

        #callout img {
            max-width: 20px;
        }

        .social {
            list-style-type: none;
            Margin-top: 1%;
            padding: 0;
        }

        .social li {
            display: inline-block;
        }

        .social li img {
            max-width: 15px;
            Margin-bottom: 0;
            padding-bottom: 0;
        }

        /*--- Start Outer Table Banner Image, Text & Button --*/

        .image img {
            width: 100%;
            max-width: 670px;
            height: auto;
        }

        .main-table {
            width: 100%;");
                WriteLiteral(@"
            max-width: 610px;
            margin: 0 auto;
            background-color: #FFF;
            border-radius: 6px;
        }

        .one-column .inner-td {
            font-size: 16px;
            line-height: 20px;
            text-align: justify;
        }

        .inner-td {
            padding: 10px;
        }

        .h2 {
            text-align: center;
            font-size: 23px;
            font-weight: 600;
            line-height: 45px;
            Margin: 12px;
            color: #4A4A4A;
        }

        p.center {
            text-align: center;
            max-width: 580px;
            line-height: 24px;
        }

        .button-holder-center {
            text-align: center;
            Margin: 5% 2% 3% 0;
        }

        .button-holder {
            float: right;
            Margin: 5% 0 3% 0;
        }

        .btn {
            font-size: 15px;
            font-weight: 600;
            background: #81BAC6;
            colo");
                WriteLiteral(@"r: #FFF;
            text-decoration: none;
            padding: 9px 16px;
            border-radius: 28px;
        }

        /*--- Start Two Column Image & Text Sections --*/

        .two-column img {
            width: 100%;
            max-width: 280px;
            height: auto;
        }

        .two-column .text {
            padding: 10px 0;
        }

        /*--- Start 3 Column Image & Text Section --*/

        .outer-table-2 {
            width: 100%;
            max-width: 670px;
            margin: 22px auto;
            background-color: #C2C1C1;
            border-bottom: 3px solid #81B9C3;
            border-top: 3px solid #81B9C3;
        }

        .three-column {
            text-align: center;
            font-size: 0;
            padding: 10px 0 30px 0;
        }

        .three-column .section {
            width: 100%;
            max-width: 200px;
            display: inline-block;
            vertical-align: top;
        }

        .three-c");
                WriteLiteral(@"olumn .content {
            font-size: 16px;
            line-height: 20px;
        }

        .three-column img {
            width: 100%;
            max-width: 125px;
            height: auto;
        }

        .outer-table-2 p {
            margin-top: 6px;
            color: #FFF;
            font-size: 18px;
            font-weight: 500;
            line-height: 23px;
        }

        /*--- Start Two Column Article Section --*/

        .outer-table-3 {
            width: 100%;
            max-width: 670px;
            margin: 22px auto;
            background-color: #C2C1C1;
            border-top: 3px solid #81B9C3;
        }

        .h3 {
            text-align: center;
            font-size: 21px;
            font-weight: 600;
            Margin-bottom: 8px;
            color: #4A4A4A;
        }

        /*--- Start Bottom One Column Section --*/

        .inner-bottom {
            padding: 22px;
        }

        .h1 {
            text-align: cente");
                WriteLiteral(@"r !important;
            font-size: 25px !important;
            font-weight: 600;
            line-height: 45px;
            Margin: 12px 0 20px 0;
            color: #4A4A4A;
        }

        .inner-bottom p {
            font-size: 16px;
            line-height: 24px;
            text-align: justify;
        }

        /*--- Start Footer Section --*/

        .footer {
            width: 100%;
            background-color: #C2C1C1;
            Margin: 0 auto;
            color: #FFF;
        }

        .footer img {
            max-width: 135px;
            Margin: 0 auto;
            display: block;
            padding: 4% 0 1% 0;
        }

        p.footer {
            text-align: center;
            color: #FFF !important;
            line-height: 30px;
            padding-bottom: 4%;
            text-transform: uppercase;
        }

        

            #callout {
                float: none !important;
                margin: 0% 0% 0% 0;
               ");
                WriteLiteral(@" height: auto;
                text-align: center;
                overflow: hidden;
            }
            #callout img {
                max-width: 26px !important;
            }
            .two-column .section {
                width: 100% !important;
                max-width: 100% !important;
                display: inline-block;
                vertical-align: top;
            }

            .two-column img {
                width: 100% !important;
                height: auto !important;
            }
            img.img-responsive {
                width: 100% !important;
                height: auto !important;
                max-width: 100% !important;
            }
            .content {
                width: 100%;
                padding-top: 0px !important;
            }
        }
    </style>
");
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
            BeginContext(8085, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(8087, 13105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8393a26c7a8db547b04d8c231c775cb5be2844b412901", async() => {
                BeginContext(8093, 1736, true);
                WriteLiteral(@"
    <div class=""wrapper"">
    	<div class=""wrapper-inner"">
    		<table class=""outer-table"">
    			<tr>
    				<td class=""header"">
    					<p><a href=""index.html#"">Click to view this email in your browser</a></p>
    				</td>
    			</tr> <!--- End Header -->
            </table> <!--- End Outer Table -->
            <table class=""main-table-first"">
                <tr>
                    <td class=""two-column"">
                        <div class=""section"">
                            <table width=""100%"">
                                <tr>
                                    <td class=""inner-td"">
                                        <table class=""content"">
                                            <tr>
                                                <td align =""center"">
                                                    <img src=""https://files.pitchbook.com/images/MuleSoft_Banner_TsK.png"" class=""logo"">
                                                </td>
                  ");
                WriteLiteral(@"                          </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </div> <!--- End First Column of Two Columns -->
                        <div class=""section"">
                            <table width=""100%"">
                                <tr>
                                    <td class=""inner-td"">
                                        <table class=""content"">
                                            <tr>
                                                <td>
                                                    <div id=""callout"">
");
                EndContext();
                BeginContext(10661, 627, true);
                WriteLiteral(@"                                                    </div>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </div> <!--- End Second Column of Two Columns -->
                    </td>
                </tr> <!--- End Two Column Section -->
                </table> <!--- End Main Table -->
            <table class=""outer-table"">
    			<tr>
    				<td class=""image"">
");
                EndContext();
                BeginContext(11337, 9848, true);
                WriteLiteral(@"    				</td>
    			</tr> <!--- End Banner -->
            </table> <!--- End Outer Table -->
            <table class=""main-table"">
    			<tr>
    				<td class=""one-column"">
    					<table width=""100%"">
    						<tr>
    							<td class=""inner-td"">
    								<p class=""h2"">MuleSoft Migration 1</p>
    								<p class=""center"">This week we'll learn how to use HTML and CSS to create really awesome newsletters for our websites! We're going to use HTML tables in order to give the email layouts it's responsiveness and mobile-friendly version as well as have cross-email-client compatilibility.</p>
    								<p class=""button-holder-center"">
    								</p>
    							</td>
    						</tr>
    					</table>
    				</td>
    			</tr> <!--- End Heading, Paragraph & Button Section -->
    			<tr>
    				<td class=""two-column"">
    					<div class=""section"">
    						<table width=""100%"">
    							<tr>
    								<td class=""inner-td"">
    									<table class=""content"">
    				");
                WriteLiteral(@"						<tr>
    											<td>
    												<img src=""search.png"" class=""img-responsive"">
    											</td>
    										</tr>
    										<tr>
    											<td class=""text"">
    												<p>Make your emails stand-out in the crowd of other messages in the inbox your readers search through with a compelling design!</p>
    											</td>
    										</tr>
    									</table>
    								</td>
    							</tr>
    						</table>
    					</div> <!--- End First Column of Two Columns -->
    					<div class=""section"">
    						<table width=""100%"">
    							<tr>
    								<td class=""inner-td"">
    									<table class=""content"">
    										<tr>
    											<td>
    												<img src=""chat.png"" class=""img-responsive"">
    											</td>
    										</tr>
    										<tr>
    											<td class=""text"">
    												<p>Get the conversation started with your readers and respond to their messages for the better email open-rates when engaging your ");
                WriteLiteral(@"list.</p>
                                                    <a class=""btn"" href=""#"">Learn more</a>
    											</td>
    										</tr>
    									</table>
    								</td>
    							</tr>
    						</table>
    					</div> <!--- End Second Column of Two Columns -->
    				</td>
    			</tr> <!--- End Two Column Section -->
            </table> <!--- End Main Table -->
            <table class=""outer-table-2"" style=""background-color: #C2C1C1;"">
    			<tr>
    				<td class=""three-column"">
    					<div class=""section"">
    						<table width=""100%"">
    							<tr>
    								<td class=""inner-td"">
    									<table class=""content"">
    										<tr>
    											<td>
    												<img src=""mouse.png"">
    											</td>
    										</tr>
    										<tr>
    											<td class=""text"">
    												<p>View emails on your mobile phone or tablet device.</p>
    											</td>
    										</tr>
    									</table>
    								</td>
    							<");
                WriteLiteral(@"/tr>
    						</table>
    					</div> <!--- End First Column of Three Columns -->
    					<div class=""section"">
    						<table width=""100%"">
    							<tr>
    								<td class=""inner-td"">
    									<table class=""content"">
    										<tr>
    											<td>
    												<img src=""mac.png"">
    											</td>
    										</tr>
    										<tr>
    											<td class=""text"">
    												<p>View emails on your mobile phone or tablet device.</p>
    											</td>
    										</tr>
    									</table>
    								</td>
    							</tr>
    						</table>
    					</div> <!--- End Second Column of Three Columns -->
    					<div class=""section"">
    						<table width=""100%"">
    							<tr>
    								<td class=""inner-td"">
    									<table class=""content"">
    										<tr>
    											<td>
    												<img src=""phone.png"">
    											</td>
    										</tr>
    										<tr>
    											<td class=""text"">
    												<");
                WriteLiteral(@"p>View emails on your mobile phone or tablet device.</p>
    											</td>
    										</tr>
    									</table>
    								</td>
    							</tr>
    						</table>
    					</div> <!--- End Third Column of Three Columns -->
    				</td>
    			</tr> <!--- End Three Column Section -->
            </table> <!--- End Outer Table 2 -->
            <table class=""main-table"">
                <tr>
                    <td class=""two-column"">
                        <div class=""section"">
                            <table width=""100%"">
                                <tr>
                                    <td class=""inner-td"">
                                        <table class=""content"">
                                            <tr>
                                                <td>
                                                    <img src=""pie-chart.png"" class=""img-responsive"">
                                                </td>
                                         ");
                WriteLiteral(@"   </tr>
                                            <tr>
                                                <td class=""text"">
                                                    <p class=""h3"">Article Content</p>
                                                    <p>Get the conversation started with your readers and respond to their messages for the better email open-rates when engaging your list.</p>
                                                    <br>
                                                    <p>Get the conversation started with your readers and respond to their messages for the better email open-rates when engaging your list.</p>
                                                    <br>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </div>");
                WriteLiteral(@" <!--- End First Column of Two Columns -->
                        <!--[if (gte mso 9)|(IE)]>
                        </td><td width=""50%"" valign=""top"">
                        <![endif]-->
                        <div class=""section"">
                            <table width=""100%"">
                                <tr>
                                    <td class=""inner-td"">
                                        <table class=""content"">
                                            <tr>
                                                <td class=""text"">
                                                    <p class=""h3"">Article Content</p>
                                                    <p>Get the conversation started with your readers and respond to their messages for the better email open-rates when engaging your list.</p>
                                                    <br>
                                                    <p>Get the conversation started with your readers and respond t");
                WriteLiteral(@"o their messages for the better email open-rates when engaging your list.</p>
                                                    <br>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <img src=""users.png"" class=""img-responsive"">
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </div> <!--- End Second Column of Two Columns -->
                    </td>
                </tr> <!--- End Two Column Section -->
                <tr>
                    <td class=""one-column"">
                        <table width=""100%"">
                            <tr>");
                WriteLiteral(@"
                                <td class=""inner-bottom"">
                                    <p class=""h1"">The Real Story</p>
                                    <p>Email marketing is the act of sending a commercial message, typically to a group of people, using email. In its broadest sense, every email sent to a potential or current customer could be considered email marketing.  Email marketing is the act of sending a commercial message, typically to a group of people, using email. In its broadest sense, every email sent to a potential or current customer could be considered email marketing</p>
                                    <br>
                                    <p>Email marketing is the act of sending a commercial message, typically to a group of people, using email. In its broadest sense, every email sent to a potential or current customer could be considered email marketing</p>
                                    <div class=""button-holder"">
                                        <a class");
                WriteLiteral(@"=""btn"" href=""#"">Learn more</a>
                                    </div>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr> <!--- End Heading, Text & Button Section -->
            </table> <!--- End Main Table -->
            <table class=""outer-table-3"">
    			<tr>
    				<td class=""one-column"">
    					<table width=""100%"">
    						
    					</table>
    				</td>
    			</tr>
    		</table> <!--- End Main Table -->
    	</div> <!--- End Wrapper Inner -->
    </div> <!--- End Wrapper -->
    <br>
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
            BeginContext(21192, 12, true);
            WriteLiteral("\r\n</html> \r\n");
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
