using Verse;

namespace RimTalkForeignInitiatorControl
{
    public class ForeignInitiatorSettings : ModSettings
    {
        public bool ForeignFactionsCanOnlyRespond = false;

        public override void ExposeData()
        {
            Scribe_Values.Look(ref ForeignFactionsCanOnlyRespond, "foreignFactionsCanOnlyRespond", false);
            base.ExposeData();
        }

        public void DoWindowContents(UnityEngine.Rect rect)
        {
            var listing = new Listing_Standard();
            listing.Begin(rect);
            listing.CheckboxLabeled(
                "Foreign faction pawns can only respond",
                ref ForeignFactionsCanOnlyRespond,
                "When enabled, pawns whose faction is not the player's faction cannot be selected as automatic RimTalk conversation initiators. They can still participate/respond when another pawn initiates.");
            listing.GapLine();
            listing.Label("Player-faction pawns include colonists, slaves, prisoners, and other pawns belonging to the player's faction.");
            listing.End();
        }
    }
}
