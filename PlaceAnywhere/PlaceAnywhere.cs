using HarmonyLib;
using System.Reflection;

namespace PlaceAnywhere
{
    public class PlaceAnywhere
    {
        public static void Init()
        {
            new Harmony("sp00ktober.PlaceAnywhere").PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
