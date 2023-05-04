using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestMehdi.Business;
using TestMehdi.Entity;

namespace TestMehdi.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        //private List<string> _values = new List<string>();
        public ValuesController()
        {
            //_values.Add("1");
            //_values.Add("2");
            //_values.Add("3");
        }


        [HttpGet]
        public List<Employee> GetValues()
        {
            var emp = new EmployeeBusiness();
           var xx = emp.Employees();
            return xx;
        }
        //[HttpPost]
        //public List<string> SetValues(List<string> values)
        //{
        //    _values.AddRange(values);
        //    return _values;
        //}
    }
}
