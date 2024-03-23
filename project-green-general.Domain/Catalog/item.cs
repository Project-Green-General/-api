using System;
using Microsoft.AspNetCore.Mvc;
using project.green.general.Domain.Catalog;
namespace project.green.general.Api.Controllers
{
[ApiController]
[Route("controller")]


public class CatalogController : ControllerBase
{

}

   
}



namespace project.green.general.Domain.Catalog
{
    public class Item {

    
    public int Id { get; set;}
    public string Name { get; set;}
    public string Desription { get; set; }
    public string Brand { get; set; }
    public decimal Price { get; set; }
    public List<Rating> Ratings { get; set; } = new List<Rating>();

   

        public Item(string name, string description, string brand, decimal price)
        {
        
            if(string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(name);
            }

            if(string.IsNullOrEmpty(Desription))
            {
                throw new ArgumentNullException(Desription);
            }

            if(string.IsNullOrEmpty(brand))
            {
                throw new ArgumentNullException(brand);
            }

            if(price < 0.00m)
            {
                throw new ArgumentException("Price must be greater than zero.");
            }
            Name = name;
            Desription = description;
            Brand = brand;
            Price = price; 

        }
        public void AddRating( Rating rating)
      {
        this.Ratings.Add(rating);
      }
      [HttpGet]
    public IActionResult GetItems()
{
    return Ok("hello world.");
}
      
    }
}

       

    

     namespace project.green.general.Domain.Catalog
     {
            public class Rating
        {
   
   
            public int Stars { get; set;}
            public string UserName { get; set;}
            public string Review { get; set;}
         

            public Rating(int stars, string userName, string review, List<Rating> rating)
            {
                if(stars < 1 || stars > 5)
                {
                    throw new ArgumentException("Star rating must be an integer of: 1, 2, 3, 4, 5.");
                }
                if(string.IsNullOrEmpty(userName))
                {
                    throw new ArgumentException("UserName cannot be null.");
                }
                this.Stars =stars;
                this.UserName = userName;
                this.Review = review;

            }
             
    
        }
     
      
     }
      

        

    
    
    

