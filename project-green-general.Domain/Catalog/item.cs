using System;
using Microsoft.AspNetCore.Mvc;
using project.green.general.Domain.Catalog;

namespace project.green.general.Api.Controllers
{
[ApiController]
[Route("controller")]


public class CatalogController : ControllerBase
{

[HttpGet]
    public IActionResult GetItems()
{
    var items = new List<Item>()
    {
        new Item("Shirt", "Ohio State shirt.", "Nike", 29.99m),
        new Item("Shorts", "Ohio State shorts.", "Nike", 49.99m)
    };
    return Ok("hello world.");
}
[HttpGet("{id:int}")]
public IActionResult GetItem(int id)
{
    var item = new Item("Shirt", "Ohio State shirt.", "Nike", 29.99m);
    item.Id = id;

    return Ok(item);
}

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

 [HttpGet("{id:int}")]   
 public IActionResult GetItem(int id)
 {
    var item = new Item("Shirt", "Ohio State shirt.", "Nike", 29.99m);
    item.Id = id;

    return Ok(item);
 }
      

        

    
    
    

