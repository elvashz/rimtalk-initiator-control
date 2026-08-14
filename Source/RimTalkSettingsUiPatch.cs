using System;
using HarmonyLib;
using RimTalk;
using Verse;

namespace RimTalkForeignInitiatorControl
{
    [HarmonyPatch]
    internal static class RimTalkSettingsUiPatch
    {
        private static System.Reflection.MethodBase TargetMethod()
        {
            var type = AccessTools.TypeByName("RimTalk.Settings");
            return AccessTools.Method(type, "DrawBasicSettings");
        }

        private static void Postfix(object __instance, object listingStandard)
        {
            // Intentionally empty in 0.2.0: settings are exposed through this mod's own Mod Options.
            // Kept as a separate patch point for future UI integration after runtime verification.
        }
    }
}
