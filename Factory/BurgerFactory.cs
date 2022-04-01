using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerAPI {

public class BurgerFactory 
{

    public IBurger returnInstance ;

    public IBurger getBurger(string burgerType)
    {
       switch(burgerType)
       {
           case("chicken"):
           returnInstance = new ChickenBurger();
           break;
           case("veg"):
           returnInstance = new VeggieBurger();
           break;
           case("plain"):
           returnInstance = new PlainBurger();
           break;
           case("cheese"):
           returnInstance = new CheeseBurger();
           break;

       }

       return returnInstance;
        
       /* BurgerFactory factory = new BurgerFactory();
        string selectedBurger = JOptionPane.showInputDialog(null, "Enter your choice of Burger");
        IBurger selectedBurgerType = factory.getBurger(selectedBurger);
        return selectedBurger();*/
    }
    
}

}