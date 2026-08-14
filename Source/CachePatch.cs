using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using HarmonyLib;
using RimWorld;
using Verse;

namespace RimTalkForeignInitiatorControl
{
    [HarmonyPatch]
    internal static class CachePatch
    {
        private static MethodBase TargetMethod()
        {
            var cacheType = AccessTools.TypeByName("RimTalk.Data.Cache");
            return AccessTools.Method(cacheType, "GetRandomWeightedPawn");
        }

        private static void Prefix(ref IEnumerable<Pawn> pawns)
        {
            if (pawns == null || Mod.Settings == null || !Mod.Settings.ForeignFactionsCanOnlyRespond)
                return;

            List<Pawn> pawnList = pawns.ToList();
            bool hasPlayerPawn = pawnList.Any(p => p != null && p.Faction == Faction.OfPlayer);

            if (hasPlayerPawn)
            {
                pawns = pawnList.Where(p => p != null && p.Faction == Faction.OfPlayer);
            }
        }
    }
}