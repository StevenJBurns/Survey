using System;

namespace Survey.Model
  {
  class Planet
    {
    private String name;
    private Star parentStar;
    private PlanetType type;

    public String Name
      {
      get { return name;}
      set {name = value; }
      }
    
    public Star ParentStar
      {
      get;
      set;
      }
    
    public Planet(String n, Star s, PlanetType type)
      {
      this.name = n;
      }
    
    public override string ToString()
      {
      return Name;
      }
    }
  }
