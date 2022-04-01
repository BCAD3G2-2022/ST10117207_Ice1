using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DrinksController : ControllerBase
    { 
    
    [HttpGet]
    public List<Drinks> Get(string flavourType = "plain")
    {
        DrinksFactory drinksFactory = new DrinksFactory();
        IDrinks drinks = drinksFactory.getDrinks(flavourType);
        List<Drinks> returnedDrinks = new List<Drinks>();
        returnedDrinks.Add(new Drinks{flavour = drinks.getFlavour(), diet = drinks.getDiet()});

        return returnedDrinks;
    }     
    }
}