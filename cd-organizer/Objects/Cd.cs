using System.Collections.Generic;

namespace CDOrganizer.Objects
{

  class Cd
  {
    private string _title;
    private string _artist;
    private int _price;
    private static List<Cd> _instances = new List<Cd> {};

    public Cd(string title, string artist, int price) {
      _title = title;
      _artist = artist;
      _price = price;
      _instances.Add(this);
    }

    public void SetTitle(string newTitle)
    {
      _title = newTitle;
    }
    public string GetTitle()
    {
      return _title;
    }

    public void SetArtist(string newArtist)
    {
      _artist = newArtist;
    }
    public string GetArtist()
    {
      return _artist;
    }

    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }
    public int GetPrice()
    {
      return _price;
    }

    public static List<Cd> GetAllCds() {
      return _instances;
    }

    public static List<Cd> SearchByArtist(string searchTerm) {
      List<Cd> searchResults = new List<Cd> {};
      foreach(Cd cd in _instances) {
        if (cd._artist.Contains(searchTerm) && !searchResults.Contains(cd)) searchResults.Add(cd);
      }
      return searchResults;
    }
  }
}
