


using System;
using System.Collections;
using Microsoft.EntityFrameworkCore;

namespace sport.Models;

public interface IHubConnection
{
    IQueryable<Product>Products{get;}
}