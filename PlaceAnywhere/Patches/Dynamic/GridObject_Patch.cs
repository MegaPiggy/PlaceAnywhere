using HarmonyLib;
using Winch.Core;

namespace PlaceAnywhere.Patches.Dynamic
{
    [HarmonyPatch(typeof(GridObject))]
    internal class GridObject_Patch
    {
        [HarmonyPostfix]
        [HarmonyPatch(nameof(GridObject.GetPlacementResult))]
        public static void GetPlacementResult_Postfix(ref GridObjectPlacementResult __result)
        {
            __result.placementCellsAcceptObject = true;
            __result.placementCellsAreUndamaged = true;
        }
    }
}
