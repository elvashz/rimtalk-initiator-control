# RimTalk - Foreign Initiator Control 0.2.0

Standalone RimWorld 1.6 compatibility mod for RimTalk.

This version deliberately uses the mod's own Mod Options page first. It does not transpile RimTalk's `PawnSelector`.

Build:
`dotnet build -c Release`

The DLL is emitted to `1.6/Assemblies/`.

Behavior:
- OFF: RimTalk is unchanged.
- ON: automatic weighted pawn selection removes pawns whose faction is not `Faction.OfPlayer`.
- Player-faction slaves, prisoners, colonists, etc. remain eligible.
- User-created TalkRequests are not filtered by this patch because the patch only runs on the weighted-pawn selection method.

Note: 0.2.0 intentionally does not inject the checkbox into RimTalk's own settings window. The option appears under this mod's own Mod Options. Once the core runtime patch is verified, the UI can be integrated into RimTalk's page safely.
