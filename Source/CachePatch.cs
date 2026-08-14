using System.Collections.Generic;
using HarmonyLib;
using RimTalk.Data;
using RimWorld;
using Verse;

namespace RimTalkForeignInitiatorControl
{
    [HarmonyPatch(typeof(Cache), nameof(Cache.GetRandomWeightedPawn))]
    internal static class CachePatch
    {
        private static void Prefix(List<Pawn> pawns)
        {
            if (pawns == null || Mod.Settings == null || !Mod.Settings.ForeignFactionsCanOnlyRespond)
                return;

            pawns.RemoveAll(pawn => pawn != null && pawn.Faction != Faction.OfPlayer);
        }
    }
}
