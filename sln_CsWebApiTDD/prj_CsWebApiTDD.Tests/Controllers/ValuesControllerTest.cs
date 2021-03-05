using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using prj_CsWebApiTDD;
using prj_CsWebApiTDD.Controllers;


namespace prj_CsWebApiTDD.Tests.Controllers
{
  [TestClass]
  public class ValuesControllerTest
  {
    [TestMethod]
    public void Get()
    {
      // simulate request

      string[]            aoStr      = new string[] { "val1", "val2", "val3", "val4", "val5" };
      ValuesController    controller = new ValuesController( aoStr );  // dependency injection
      IEnumerable<string> result     = controller.Get();

      // test result

      Assert.IsNotNull( result );
      Assert.AreEqual( 5, result.Count() );
      Assert.AreEqual( "val1", result.ElementAt( 0 ) );
      Assert.AreEqual( "val5", result.ElementAt( 4 ) );
    }


    [TestMethod]
    public void GetById()
    {
      // simulate request

      string[]         aoStr      = new string[] { "val1", "val2", "val3", "val4", "val5" };
      ValuesController controller = new ValuesController( aoStr );  // dependency injection
      string           result     = controller.Get( id: 5 );

      // test result

      Assert.AreEqual( "val5", result );
    }


    [TestMethod]
    public void Post()
    {
      // simulate request

      string[]         aoStr       = new string[] { "val1", "val2", "val3", "val4", "val5" };
      ValuesController controller1 = new ValuesController( aoStr );  // dependency injection
      controller1.Post( "val6" );

      // simulate request

      ValuesController    controller2 = new ValuesController();
      IEnumerable<string> result      = controller2.Get();

      // test result

      Assert.IsNotNull( result );
      Assert.AreEqual( 6, result.Count() );
      Assert.AreEqual( "val1", result.ElementAt( 0 ) );
      Assert.AreEqual( "val6", result.ElementAt( 5 ) );
    }


    [TestMethod]
    public void Put()
    {
      // simulate request

      string[]         aoStr       = new string[] { "val1", "val2", "val3", "val4", "val5" };
      ValuesController controller1 = new ValuesController( aoStr );  // dependency injection
      controller1.Put( 5, "val555" );

      // simulate request

      ValuesController controller2 = new ValuesController();
      string           result      = controller2.Get( 5 );

      // test result

      Assert.AreEqual( "val555", result );
    }


    [TestMethod]
    public void Delete()
    {
      // simulate request

      string[]         aoStr       = new string[] { "val1", "val2", "val3", "val4", "val5" };
      ValuesController controller1 = new ValuesController( aoStr );  // dependency injection
      controller1.Delete( 5 );

      // simulate request

      ValuesController    controller2 = new ValuesController();
      IEnumerable<string> result      = controller2.Get();

      // test result

      Assert.IsNotNull( result );
      Assert.AreEqual( 4, result.Count() );
      Assert.AreEqual( "val1", result.ElementAt( 0 ) );
      Assert.AreEqual( "val4", result.ElementAt( 3 ) );
    }


  } // class

} // ns
