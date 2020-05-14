using System;
using System.Collections;
using Microsoft.AspNetCore.Mvc;

namespace FaultyApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        ArrayList objectList = new ArrayList();
        private Array SaveObjects(int objectId)
        {
            int numbers = objectId / 8;
            int[]arr = new int[numbers];

            for (int i = 0; i < numbers; i++)
            {
                arr[i] = i;
            }

            return arr;
        }

        [HttpGet]
        public String Get()
        {
            var id = 400000 * 1024;
            var objectId = SaveObjects(id);
            objectList.AddRange(objectId);
            return "Command Executed";
        }
    }
}