using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SeasonProject.Controllers
{
    [Route("api/season/getseason/{temperature}")]
    public class SeasonController : ApiController
    {
        public string GetSeason(int temperature)
        {
            string season = "";
            if (temperature > 20)
            {
                season = "summer";
            }
            else if (temperature >= 15)
            {
                season = "fall";
            }
            else if (temperature > 10)
            {
                season = "spring";
            }
            else
            {
                season = "winter";
            }

            string message = "The season is " + season + "!";
            return message;
        }
    }
}
