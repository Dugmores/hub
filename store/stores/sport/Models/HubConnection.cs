

using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using stores.sport.Models;

namespace stores.sport.Models;

public class HubConnection:IHubConnection{
    private HubContext context;

    public HubConnection(HubContext con){
        context = con;
    }

    public IQueryable<Product>Products => context.Products;
}