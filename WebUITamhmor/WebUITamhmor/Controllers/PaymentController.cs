using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using WebUITamhmor.Models;

namespace WebUITamhmor.Controllers
{
    public class PaymentController : Controller
    {
        string Baseurl = "https://localhost:44305";

        public async Task<ActionResult> Payment(String Dprice)
        {
            //ScriptManager.RegisterStartupScript(this, GetType(), "checkLogin", "checkLogin()", true);

            List<DoctorModel> DoctorInfo = new List<DoctorModel>();
            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("/api/v1/Doctor/GetDoctor");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var DoctorResponse = Res.Content.ReadAsStringAsync().Result;
                    Debug.WriteLine(DoctorResponse);
                    Debug.WriteLine("====================");

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    var tempData = JsonConvert.DeserializeObject<List<DoctorModel>>(DoctorResponse);
                    // check Dsex map value
                    Debug.WriteLine(DoctorInfo);

                    DoctorInfo.Add(tempData.Find(x => x.Dprice == Dprice));


                }

                return View(DoctorInfo);
            }
        }
    }
}
