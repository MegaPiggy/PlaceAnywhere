using HarmonyLib;
using Winch.Core;

namespace PlaceAnywhere.Patches.Dynamic
{
    [HarmonyPatch(typeof(SpatialItemData))]
    internal class SpatialItemData_Patch
    {
        [HarmonyPostfix]
        [HarmonyPatch(nameof(SpatialItemData.GetCanBeMoved))]
        public static void GetCanBeMoved_Postfix(ref bool __result)
        {
            __result = true;
        }
    }
}
