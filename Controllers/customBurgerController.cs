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
    public class customBurgerController : ControllerBase
    { 
    
    [HttpGet]
    public string Get(bool Tomato, bool Cheese, bool Bun, bool Patty, bool Lettuce)
    {
        IComponent burgerBun = new Bun();
        IComponent burgerPatty = new Patty();
        IComponent burgerLettuce = new Lettuce();
        IComponent burgerTomato = new Tomato();
        IComponent burgerCheese = new Cheese();


        Composite BaseBurger = new Composite();
        BaseBurger.addPart(burgerBun);
        BaseBurger.addPart( burgerPatty);
        BaseBurger.addPart( burgerLettuce);
        BaseBurger.addPart( burgerTomato);
        BaseBurger.addPart( burgerCheese);

        if(Tomato)
        {
            BaseBurger.removePart(burgerTomato);
        }

        if(Cheese)
        {
            BaseBurger.removePart(burgerCheese);
        }

        if(Lettuce)
        {
            BaseBurger.removePart(burgerLettuce);
        }

        if(Patty)
        {
            BaseBurger.removePart(burgerPatty);
        }

        if(Bun)
        {
            BaseBurger.removePart(burgerBun);
        }

        return BaseBurger.getBurgerPart();

    }     
    }
}