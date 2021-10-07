using System;

namespace WildSandbox
{
  class Program
  {
    static void Main(string[] args)
    {
      var authServer = new Auth.AuthServer(23115);
      authServer.Start();
      Logs.Log("AuthServer started.");

      var realmServer = new Realm.RealmServer(24000);
      realmServer.Start();
      Logs.Log("RealmServer started.");

      while (true)
        Console.ReadLine();
    }
  }
}
