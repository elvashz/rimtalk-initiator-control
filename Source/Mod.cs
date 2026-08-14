using HarmonyLib;
using Verse;

namespace RimTalkForeignInitiatorControl
{
    public class Mod : Verse.Mod
    {
        public static Mod Instance { get; private set; }
        public static ForeignInitiatorSettings Settings { get; private set; }

        public Mod(ModContentPack content) : base(content)
        {
            Instance = this;
            Settings = GetSettings<ForeignInitiatorSettings>();
        }

        public override string SettingsCategory() => "RimTalk - Foreign Initiator Control";

        public override void DoSettingsWindowContents(UnityEngine.Rect inRect)
        {
            Settings.DoWindowContents(inRect);
        }
    }

    [StaticConstructorOnStartup]
    public static class Bootstrap
    {
        static Bootstrap()
        {
            new Harmony("vash.rimtalk.foreigninitiatorcontrol").PatchAll();
        }
    }
}
