using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace J3_N01018195.Controllers
{
    // J3 problem of 2019
    public class ColdCompressController : ApiController
    {
        [HttpGet]
        [Route("api/ColdCompress/MyCharacter/{word}")]
        // get a word from the user 

        public string MyCharacter(string word)
        {
            // want to convert the word into an array
            // tried using char[] and .ToCharArray() function
            // want to create a for loop to get 1st character in the array 
            // want to get 2nd for loop to get the next character and compared each other 
            // if match find go to next character and update the counter .
            // want to take the output of count of similar type.
            

            
            






        }

    }
}
