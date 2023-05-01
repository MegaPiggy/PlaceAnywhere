using HarmonyLib;
using System.Reflection;

namespace PlaceAnywhere
{
    public class PlaceAnywhere
    {
        public static void Init()
        {
            Harmony harmony = new Harmony("com.dredge.PlaceAnywhere");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
