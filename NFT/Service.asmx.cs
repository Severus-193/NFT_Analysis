﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using Newtonsoft.Json;

namespace Crypto
{
    /// <summary>
    /// Summary description for Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class Service : System.Web.Services.WebService
    {


        [WebMethod(EnableSession = true)]
        public string LoadGrid()
        {
            string result = "";
            DataSet ds = NFTGrid.LoadGrid();
            result = JsonConvert.SerializeObject(ds, Formatting.Indented);
            return result;
        }
    }
}
