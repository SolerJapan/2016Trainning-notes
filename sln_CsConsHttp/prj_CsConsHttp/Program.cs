using System;                      // Uri
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;      // Task

using System.Net.Http;             // HttpClient, HttpResponseMessage, HttpRequestException
using System.Net.Http.Formatting;  // MediaTypeFormatter, JsonMediaTypeFormatter, XmlMediaTypeFormatter
using System.Net.Http.Headers;


namespace prj_CsConsHttp  // use this app to test the webapi app
{
  class Program
  {
    static void Main( string[] args )
    {
      // call async method which returns task
      // task is used to block thread (keep console app running) until task completes
      // HttpClient methods are async (perform network IO which takes time)
      // OK to block main (UI) thread in console app (not OK to block UI thread in GUI app) 

      Task oTask = Program.oTaskRunAsync();
      oTask.Wait();
    }


    // utility method
    private static async Task oTaskRunAsync()
    {
      string oStrVal = null;

      using( HttpClient oHClient = new HttpClient() )
      {
        // set base URI for HTTP requests
        oHClient.BaseAddress = new Uri( "http://localhost:49326/" );

        // set Accept header to application/json (tells server to send data in JSON format)
        oHClient.DefaultRequestHeaders.Accept.Clear();
        MediaTypeWithQualityHeaderValue oMt = new MediaTypeWithQualityHeaderValue( "application/json" );
        oHClient.DefaultRequestHeaders.Accept.Add( oMt );

        // show all values
        Task oTask = Program.oTaskGetAllValuesAsync( "starting values:", oHClient );
        oTask.Wait();


        // ====================
        // get a resource
        // ====================

        // send HTTP GET request for value 1
        // await suspends execution until async method completes
        // method returns HttpResponseMessage containing HTTP response

        HttpResponseMessage oResp = await oHClient.GetAsync( "api/values/1" );

        if( oResp.IsSuccessStatusCode )
        {
          // response body contains JSON representation of a string
          // read method deserializes JSON data to a string instance
          // method is async since response body can be large

          // if call read method with no params, uses default media type formatters to read response body
          // default formatters support JSON, XML, Form-url-encoded data
          // can specify list of formatters including a custom formatter

          oStrVal = await oResp.Content.ReadAsAsync<string>();
          Console.WriteLine( "value 1: {0}", oStrVal );
        }

        //try
        //{
        //  HttpResponseMessage resp = await client.GetAsync( "api/values/1" );
        //  resp.EnsureSuccessStatusCode();    // throw if not a success code
        //  var formatters = new List<MediaTypeFormatter>() { new MyFormatter(), new JsonMediaTypeFormatter(), new XmlMediaTypeFormatter() };
        //  resp.Content.ReadAsAsync<IEnumerable<string>>(formatters);
        //  ...
        //}
        //catch( HttpRequestException e )
        //{
        //  // handle exception
        //}

        // show all values
        oTask = Program.oTaskGetAllValuesAsync( "after get id 1:", oHClient );
        oTask.Wait();


        // ====================
        // create a resource
        // ====================

        int iNewId = 0;
        
        // send HTTP POST request to add a new value
        oStrVal = new string( 'W', 10 );
        
        // serialize object to JSON and send the JSON in POST request
        oResp = await oHClient.PostAsJsonAsync( "api/values", oStrVal );

        if( oResp.IsSuccessStatusCode )
        {
          // get new resource's id value (id is returned by POST action in controller)
          iNewId = await oResp.Content.ReadAsAsync<int>();

          Console.WriteLine( "new id: {0}", iNewId );
        }

        // to send JSON, use PostAsJsonAsync()
        // to send XML, use PostAsXmlAsync()
        // to send custom format, use PostAsync()
        //MediaTypeFormatter formatter = new MyFormatter();
        //resp = await client.PostAsync( "api/values", oStrVal, formatter );

        // show all values
        oTask = Program.oTaskGetAllValuesAsync( "after add new value:", oHClient );
        oTask.Wait();


        // ====================
        // update a resource
        // ====================

        if( iNewId > 0 )
        {
          // send HTTP PUT request to update a value
          oStrVal = "MMMMMMMMMM";
          oResp = await oHClient.PutAsJsonAsync( "api/values/" + iNewId.ToString(), oStrVal );

          if( oResp.IsSuccessStatusCode )
          {
            Console.WriteLine( "updated value id: {0}", iNewId );
          }
        }

        // show all values
        oTask = Program.oTaskGetAllValuesAsync( "after update value:", oHClient );
        oTask.Wait();

        
        // ====================
        // delete a resource
        // ====================

        if( iNewId > 0 )
        {
          // send HTTP DELETE request to delete a value
          // DELETE request has no request body (so don't need to specify JSON or XML format)
          oResp = await oHClient.DeleteAsync( "api/values/" + iNewId.ToString() );

          if( oResp.IsSuccessStatusCode )
          {
            Console.WriteLine( "deleted value id: {0}", iNewId );
          }
        }

        // show all values
        oTask = Program.oTaskGetAllValuesAsync( "after delete value:", oHClient );
        oTask.Wait();

      } // using()

    } // RunAsync()


    // utility method
    private static async Task oTaskGetAllValuesAsync( string oStrTitle, HttpClient oHClient )
    {
            Product oProd1 = new Product() { Name = "Prod1", Category = "cat1", Price = 1.00 };
            Product oProd2 = new Product() { Name = "Prod2", Category = "cat2", Price = 2.00 };
            Product oProd3 = new Product() { Name = "Prod3", Category = "cat3", Price = 3.00 };

            Product[] aoProd = new Product[] { oProd1, oProd2, oProd3 };

            List<Product> oListOfProd = new List<Product>();
            oListOfProd.AddRange(aoProd);
            foreach (Product p in oListOfProd)
            {
                Console.WriteLine(p.Name);
            }

            List<Product> oListOfObj = new List<Product>();
            oListOfProd.AddRange(aoProd);
            foreach (Product o in oListOfObj)
            {
                Console.WriteLine(((Product)o).Name);
            }



            HttpResponseMessage oHRespMsg = await oHClient.GetAsync( "api/values" );

      if( oHRespMsg.IsSuccessStatusCode )
      {
        //IEnumerable<string> oIEnubleOfStr = await oResp.Content.ReadAsAsync<IEnumerable<string>>();

        string[] aoStr = await oHRespMsg.Content.ReadAsAsync<string[]>();

        Console.WriteLine( oStrTitle );

        int iCount = aoStr.Count();

        for( int iNdx = 0; iNdx < iCount; iNdx++ )
        {
          Console.WriteLine( "  id: {0}  value: {1}", iNdx + 1, aoStr[ iNdx ] );
        }
      }
    }


  } // class
} // ns
