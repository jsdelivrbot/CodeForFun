﻿// Imports
using Nancy;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System;

public class ResourceModule : NancyModule
{
	public ResourceModule() : base("/products")
	{
        // Faz a requisição em 'host/products/list' 
        Get["/list"] = parameters =>
        {
            return "Lista de produtos";
        };
	}
}
