using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace prj_CsWebApiTDD.Models
{
  public class tModel
  {
    public List<string> m_oListOfStr = null;


    public tModel( string[] aoStr )
    {
      this.m_oListOfStr = new List<string>();
      this.m_oListOfStr.AddRange( aoStr );  
    }


  } // class

} // ns