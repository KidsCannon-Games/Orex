using System;
using System.Collections.Generic;

namespace Orex
{
  public class JsonUtilityHelper
  {
    public static List<T> ListFromJson<T>(string json)
    {
      var wrappedJson = @"{""items"": " + json + "}";
      Wrapped<T> wrapped = UnityEngine.JsonUtility.FromJson<Wrapped<T>>(wrappedJson);
      return wrapped.items;
    }

    [Serializable]
    class Wrapped<T>
    {
      public List<T> items = null;
    }
  }
}
