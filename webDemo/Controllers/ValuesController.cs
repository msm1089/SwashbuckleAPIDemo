﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace webDemo.Controllers
{
    public class ValuesController : ApiController
    {
        private string[] lista
        {
            get
            {
                if (System.Web.HttpContext.Current.Application["lista"] == null)
                {
                    System.Web.HttpContext.Current.Application["lista"] =
                        new string[] { "value1", "value2" };
                }
                return
                    (string[])System.Web.HttpContext.Current.Application["lista"];
            }
        }
        /// <summary>
        /// Retrieves the list of values
        /// </summary>
        public IEnumerable<string> Get()
        {
            return lista;
        }
        /// <summary>
        /// Retrieves one value from the list of values
        /// </summary>
        /// <param name="id">The id of the item to be retrieved</param>
        public string Get(int id)
        {
            return lista[id];
        }
        /// <summary>
        /// Insert a new value in the list
        /// </summary>
        /// <param name="value">New value to be inserted</param>
        public void Post([FromBody]string value)
        {
        }
        /// <summary>
        /// Change a single value in the list
        /// </summary>
        /// <param name="id">The id of the value to be changed</param>
        /// <param name="value">The new value</param>
        public void Put(int id, [FromBody]string value)
        {
            lista[id] = value;
        }
        /// <summary>
        /// Delete an item from the list
        /// </summary>
        /// <param name="id">id of the item to be deleted</param>
        public void Delete(int id)
        {
        }
    }
}
