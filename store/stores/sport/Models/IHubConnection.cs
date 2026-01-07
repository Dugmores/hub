


using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using stores.sport.Models;

namespace stores.sport.Models;

public interface IHubConnection
{
    IQueryable<Product>Products{get;}
}