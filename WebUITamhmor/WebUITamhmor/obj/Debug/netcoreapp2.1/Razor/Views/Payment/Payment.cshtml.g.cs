#pragma checksum "C:\Users\admin\source\repos\WebUITamhmor\WebUITamhmor\Views\Payment\Payment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7def590e9db95823a346a1db8179984662297e91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payment_Payment), @"mvc.1.0.view", @"/Views/Payment/Payment.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Payment/Payment.cshtml", typeof(AspNetCore.Views_Payment_Payment))]
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
#line 1 "C:\Users\admin\source\repos\WebUITamhmor\WebUITamhmor\Views\_ViewImports.cshtml"
using WebUITamhmor;

#line default
#line hidden
#line 2 "C:\Users\admin\source\repos\WebUITamhmor\WebUITamhmor\Views\_ViewImports.cshtml"
using WebUITamhmor.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7def590e9db95823a346a1db8179984662297e91", @"/Views/Payment/Payment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba44f7ea8dcca69602519ab9f229c2683e108b7a", @"/Views/_ViewImports.cshtml")]
    public class Views_Payment_Payment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebUITamhmor.Models.DoctorModel>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\admin\source\repos\WebUITamhmor\WebUITamhmor\Views\Payment\Payment.cshtml"
  
    ViewData["Title"] = "Payment";

#line default
#line hidden
            BeginContext(96, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(102, 431, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f269a457e9a44fda14a19c7d96b9039", async() => {
                BeginContext(108, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 9 "C:\Users\admin\source\repos\WebUITamhmor\WebUITamhmor\Views\Payment\Payment.cshtml"
     foreach (var item in Model)
    {


#line default
#line hidden
                BeginContext(153, 228, true);
                WriteLiteral("        <div class=\"table-bordered \" style=\"margin:50px; padding:20px;\">\r\n            <div style=\"text-align: center;\">\r\n                <h1>Payment</h1>\r\n                <button type=\"button\" class=\"btn\" style=\"margin:20px; \"> ");
                EndContext();
                BeginContext(382, 41, false);
#line 15 "C:\Users\admin\source\repos\WebUITamhmor\WebUITamhmor\Views\Payment\Payment.cshtml"
                                                                    Write(Html.DisplayFor(ModelItem => item.Dprice));

#line default
#line hidden
                EndContext();
                BeginContext(423, 96, true);
                WriteLiteral(" Bath</button>\r\n                <div id=\"container\"></div>\r\n            </div>\r\n        </div>\r\n");
                EndContext();
#line 19 "C:\Users\admin\source\repos\WebUITamhmor\WebUITamhmor\Views\Payment\Payment.cshtml"
    }

#line default
#line hidden
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
            BeginContext(533, 4679, true);
            WriteLiteral(@"



<script async
        src=""https://pay.google.com/gp/p/js/pay.js""
        onload=""onGooglePayLoaded()""></script>



<script>
        const baseRequest = {
            apiVersion: 2,
            apiVersionMinor: 0
        };
        const allowedCardNetworks = [""AMEX"", ""DISCOVER"", ""INTERAC"", ""JCB"", ""MASTERCARD"", ""VISA""];
        const allowedCardAuthMethods = [""PAN_ONLY"", ""CRYPTOGRAM_3DS""];
        const tokenizationSpecification = {
            type: 'PAYMENT_GATEWAY',
            parameters: {
                'gateway': 'example',
                'gatewayMerchantId': 'exampleGatewayMerchantId'
            }
        };
        const baseCardPaymentMethod = {
            type: 'CARD',
            parameters: {
                allowedAuthMethods: allowedCardAuthMethods,
                allowedCardNetworks: allowedCardNetworks
            }
        };
        const cardPaymentMethod = Object.assign(
            {},
            baseCardPaymentMethod,
            {
          ");
            WriteLiteral(@"      tokenizationSpecification: tokenizationSpecification
            }
        );
        let paymentsClient = null;
        function getGoogleIsReadyToPayRequest() {
            return Object.assign(
                {},
                baseRequest,
                {
                    allowedPaymentMethods: [baseCardPaymentMethod]
                }
            );
        }
        function getGooglePaymentDataRequest() {
            const paymentDataRequest = Object.assign({}, baseRequest);
            paymentDataRequest.allowedPaymentMethods = [cardPaymentMethod];
            paymentDataRequest.transactionInfo = getGoogleTransactionInfo();
            paymentDataRequest.merchantInfo = {

                merchantName: 'Example Merchant'
            };
            return paymentDataRequest;
        }
        function getGooglePaymentsClient() {
            if (paymentsClient == null) {
                paymentsClient = new google.payments.api.PaymentsClient({ environment: 'TEST' });");
            WriteLiteral(@"
            }
            return paymentsClient;
        }
        function onGooglePayLoaded() {
            const paymentsClient = getGooglePaymentsClient();
            paymentsClient.isReadyToPay(getGoogleIsReadyToPayRequest())
                .then(function (response) {
                    if (response.result) {
                        addGooglePayButton();

                    }
                })
                .catch(function (err) {

                    console.error(err);
                });
        }
        function addGooglePayButton() {
            const paymentsClient = getGooglePaymentsClient();
            const button = paymentsClient.createButton({ onClick: onGooglePaymentButtonClicked });
            document.getElementById('container').appendChild(button);
            window.location.href = ""/Chat/Chatroom"";
            
    }
        
        function getGoogleTransactionInfo() {
            return {

                countryCode: 'US',
                curr");
            WriteLiteral(@"encyCode: 'USD',
                totalPriceStatus: 'FINAL',
                // set to cart total
                totalPrice: '10'
            };
    }

    


        function prefetchGooglePaymentData() {
            const paymentDataRequest = getGooglePaymentDataRequest();
            // transactionInfo must be set but does not affect cache
            paymentDataRequest.transactionInfo = {
                totalPriceStatus: 'NOT_CURRENTLY_KNOWN',
                currencyCode: 'US'
            };
            const paymentsClient = getGooglePaymentsClient();
            paymentsClient.prefetchPaymentData(paymentDataRequest);
    }

        function onGooglePaymentButtonClicked() {
            const paymentDataRequest = getGooglePaymentDataRequest();
            paymentDataRequest.transactionInfo = getGoogleTransactionInfo();
            const paymentsClient = getGooglePaymentsClient();
            paymentsClient.loadPaymentData(paymentDataRequest)
                .then(function (paym");
            WriteLiteral(@"entData) {
                    // handle the response
                    processPayment(paymentData);
                })
                .catch(function (err) {
                    // show error in developer console for debugging
                    console.error(err);
                });
    }

        
        function processPayment(paymentData) {
            // show returned data in developer console for debugging
            console.log(paymentData);

            paymentToken = paymentData.paymentMethodData.tokenizationData.token;
    }

</script>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebUITamhmor.Models.DoctorModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
