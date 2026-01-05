

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sport.Models;

public class Product{
    public long? ProductId{get; set;}
    public string Name{get;set;} = string.Empty;
    public string Description {get;set;} = string.Empty;
    [Column(TypeName="decimal(8,2)")]
    public decimal Price {get;set;} = 0;
    public string Category {get;set;}=string.Empty;
}