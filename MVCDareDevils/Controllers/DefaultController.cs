using MVCDareDevils.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Net.Sockets;
using System.Web;
using System.Web.Mvc;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MVCDareDevils.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default 
        public ActionResult Index()
        {
            Test();
            return RedirectToAction("Test");
        }

        public async Task<ActionResult> Test()
        {
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                var clientHandler = new HttpClientHandler

                {

                    UseCookies = false,

                };

                var client = new HttpClient(clientHandler);

                var request = new HttpRequestMessage

                {

                    Method = HttpMethod.Post,

                    RequestUri = new Uri("https://uatcheckout.thawani.om/api/v1/checkout/session"),
                    Headers = { { "cookie", "XSRF-TOKEN-PROTECTION=CfDJ8HyE1bI1EPVOhc-EXalHBBG6vumyzS9mqwmymJJP_naIlK5mS-E_PMv1yb8q7UIeCWF--8JChlLdLj-Dao0mCqdztjljKv-TH5SZcqu7XvYKZZF1VOdonUeIp5fZMHaJk_OJNeSo1QtqZNLIqLs_qao; XSRF-TOKEN=CfDJ8AOYu0UCK-hBrYBC7Y9ctpfrg9OgBkXcKTmJeg6P4t0MGgeFizOMXHsDCrdcKP7JiTw0cU1LNvaju1BHME5NndwXbaJyQMQcDpm2Zv-A1R8mEXFLHyKCq1hrdJfv0v5rlHePEF5zG3FkxxuGukopFmNojV2d4U1Xr8taREc8sanTgM1Rlin510RHwnjNBy4zEg" },{ "thawani-api-key", "GcenMXLpDJg96YY4pzkN4AjRXIszuv" },

    },

                    Content = new StringContent("{\n\t\"client_reference_id\": \"1234\",\n\t\"customer_id\": \"cus_edtYJU1Oz3NqruBL\",\n\t\"products\": [\n\t\t{\n\t\t\t\"name\": \"test\",\n\t\t\t\"unit_amount\": 100,\n\t\t\t\"quantity\": 1\n\t\t}\n\t],\n\t\"success_url\": \\https://www.google.com\\,\n\t\"cancel_url\": \\https://thw.om/cancel\\,\n\t\"metadata\": {\n\t\t\"customer name\": \"em\",\n\t\t\"customer mobile\": \"9828282\",\n\t\t\"customer email\": \"yawarali17@gmail.com\"\n\t}\n}")

                    {

                        Headers = { ContentType = new MediaTypeHeaderValue("application/json") }
                    }
                };


                using (var response = await client.SendAsync(request))

                {

                    response.EnsureSuccessStatusCode();

                    var body = await response.Content.ReadAsStringAsync();

                    Console.WriteLine(body);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return View();
        }
    }
}