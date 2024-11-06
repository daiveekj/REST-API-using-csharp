using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreWebAPI.Controllers
{
    [Route("api/[controller]")]  //attribute routing 
    [ApiController] //it enables few features including attribute routing requirement , automatic model validation and binding source parameter infetence 

    //  ControllerBase class is a class that handles HTTP request and generete HTTP response  
    public class FruitsAPIController : ControllerBase
    {

        public List<string> fruits = new List<string>()
        {
           "Apple",
           "Banana",
           "Mango",
           "Cherry",
           "Grapes"
        };

        [HttpGet] // here it is get method to list the fruits 
        public List<string> GetFruits() // here it creatig s method and returning the list  
        {
            return fruits;
        }

        [HttpGet("{id}")] // here it is get method to list the specific fruits by id 
        public string GetFruitsByIndex(int id) // here it creatig s method and returning the list
        {
            return fruits.ElementAt(id);
        }

        [HttpPost] //here it will add new fruits 
        public List<string> AddFruit([FromBody] string fruit)
        {
            fruits.Add(fruit);
            return fruits;
        }
        [HttpPut("{id}")] 
        public List<string> UpdateFruit(int id, [FromBody] string newFruit)
        {
            
                fruits[id] = newFruit;
            
            return fruits;
        }

        [HttpDelete("{id}")]
        public List<string> DeleteFruits(int id)
        {
            fruits.RemoveAt(id);
            return fruits;
        }
    }
}
