using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC_EF_Start.Models
{
  public class Company
  {
    [Key]
    public string symbol { get; set; }
    public string name { get; set; }
    public string date { get; set; }
    public bool isEnabled { get; set; }
    public string type { get; set; }
    public string iexId { get; set; }
    public List<Quote> Quotes { get; set; }
  }

  public class Quote
  {
    public int QuoteId { get; set; }
    public string date { get; set; }
    public float open { get; set; }
    public float high { get; set; }
    public float low { get; set; }
    public float close { get; set; }
    public int volume { get; set; }
    public int unadjustedVolume { get; set; }
    public float change { get; set; }
    public float changePercent { get; set; }
    public float vwap { get; set; }
    public string label { get; set; }
    public float changeOverTime { get; set; }
    public string symbol { get; set; }
  }
  public class Recipe
    {
     public int recipeId { get; set; }
     public string recipeName { get; set; }
     public List<Preparation> preparations { get; set; }
    }
  public class Ingredient
    {
     public int ingredientId { get; set; }
     public string Name { get; set; }
     public List<Preparation> preparations { get; set; }
    }
  public class Preparation
    {
     public int preparationId { get; set; }
     public string Name { get; set; }
     public Recipe recipe { get; set; }
     public Ingredient ingredient { get; set; }
     public string menu { get; set; }
    }

    public class ChartRoot
  {
    public Quote[] chart { get; set; }
  }
}