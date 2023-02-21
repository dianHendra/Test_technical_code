using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_technical_code.Model;

namespace Test_technical_code.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public IActionResult GenerateSegitiga(int param)
        {
            var result = new BaseResult();
            try
            {
                return Ok(result);
            }
            catch(Exception)
            {
                result.Message = "Error";
                result.Success = false;
                return Ok(result);
            }
        }


        public IActionResult GenerateGanjilMax(int param)
        {
            var result = new BaseResult();
            try
            {
                return Ok(result);
            }
            catch (Exception)
            {
                result.Message = "Error";
                result.Success = false;
                return Ok(result);
            }
        }

        public IActionResult GeneratePrimaMax(int param)
        {
            var result = new BaseResult();
            try
            {
                return Ok(result);
            }
            catch (Exception)
            {
                result.Message = "Error";
                result.Success = false;
                return Ok(result);
            }
        }
    }
}
