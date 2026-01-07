


using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace sport.Models;

public interface IHubConnection
{
    IQueryable<Product>Products{get;}
}