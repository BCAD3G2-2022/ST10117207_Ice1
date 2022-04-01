using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

public class VeggieBurger : IBurger
{
    public string getBun()
    {
        return "Rye";
    }

    public string getPatty()
    {
        return "veg";
    }

    public string getCheese()
    {
        return "cheese";
    }
}
