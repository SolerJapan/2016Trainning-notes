using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using SIO = System.IO;         // Path, File
using SR  = System.Reflection; // Assembly
using prj_CsWebApiTDD.Models;  // tModel


namespace prj_CsWebApiTDD.Controllers
{
  public class ValuesController : ApiController
  {

#region supports data storage
        
    // fields
    private tModel m_oModel = null;


    // ctor (default)
    public ValuesController()
    {
      this.vModelLoad();
    }


    // utility method
    private string oStrGetDataPath()
    {
      SR.Assembly oAsm         = SR.Assembly.GetExecutingAssembly();
    //string      oStrPathExe  = oAsm.Location;
      Uri         oUri         = new Uri( oAsm.CodeBase );
      string      oStrPathExe  = oUri.LocalPath;
      string      oStrDirExe   = SIO.Path.GetDirectoryName( oStrPathExe );
      string      oStrPathData = SIO.Path.Combine( oStrDirExe, "app_data", "data.txt" );
      return      oStrPathData;
    }


    // utility method
    private void vModelLoad()
    {
      string oStrPathData = this.oStrGetDataPath();
      string oStrData     = SIO.File.ReadAllText( oStrPathData );
      oStrData            = oStrData.Trim();
      string[] aoStr      = oStrData.Split( new char[] { '|' } );
      this.m_oModel       = new tModel( aoStr );
    }


    // utility method
    private void vModelSave()
    {
      string[] aoStr        = this.m_oModel.m_oListOfStr.ToArray();
      string   oStrData     = String.Join( "|", aoStr );
      string   oStrPathData = this.oStrGetDataPath();
      System.IO.File.WriteAllText( oStrPathData, oStrData );
    }

#endregion


#region supports unit testing

    // ctor (only used for dependency injection during unit testing)
    public ValuesController( string[] aoStr )
    {
      this.m_oModel = new tModel( aoStr );
    }

#endregion


#region supports webapi

    // GET api/values
    public IEnumerable<string> Get()
    {
      return this.m_oModel.m_oListOfStr.ToArray();
    }


    // GET api/values/5
    public string Get( int id )
    {
      return this.m_oModel.m_oListOfStr[ id - 1 ];
    }


    // POST api/values
    public int Post( [FromBody()] string value )
    {
      this.m_oModel.m_oListOfStr.Add( value );
      this.vModelSave();
      return this.m_oModel.m_oListOfStr.Count;
    }


    // PUT api/values/5
    public void Put( int id, [FromBody()] string value )
    {
      this.m_oModel.m_oListOfStr[ id - 1 ] = value;
      this.vModelSave();
    }


    // DELETE api/values/5
    public void Delete( int id )
    {
      this.m_oModel.m_oListOfStr.RemoveAt( id - 1 );
      this.vModelSave();
    }

#endregion


  } // class

} // ns
