using Microsoft.AspNetCore.Mvc;

namespace ApiCalculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClaculatorController : ControllerBase
    {

        [HttpGet("Add/{num1}/{num2}")]
    
        public double Add(double num1, double num2)
        {
            double sum  = num1 + num2;
            return sum;
        }

        [HttpGet("Subtract/{num1}/{num2}")]

        public double Subtract(double num1, double num2)
        {
            double sum = (num1 - num2);
            return sum;
        }

        [HttpGet("Multiplicate/{num1}/{num2}")]

        public double Multiplicate(double num1, double num2)
        {
            double sum = (num1 * num2);
            return sum;
        }

        [HttpGet("Divide/{num1}/{num2}")]

        public double Divide(double num1, double num2)
        {
            if (num2== 0)
            {
                throw DivideByZeroException("Cannot Divide by Zero");
            }
            double sum = (num1 / num2);
            return sum;
        }

        private Exception DivideByZeroException(string v)
        {
            throw new DivideByZeroException ();
        }
    }
}