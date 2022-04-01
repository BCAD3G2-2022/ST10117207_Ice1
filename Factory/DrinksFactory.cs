using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerAPI {

public class DrinksFactory 
{

    public IDrinks returnInstance;

    public IDrinks getDrinks(string flavourType)
    {
       switch(flavourType)
       {
           case("Drinks"):
           returnInstance = new Softdrinks();
           break;
       }

       return returnInstance;

    }
}
}