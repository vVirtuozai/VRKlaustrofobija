using UnrealBuildTool;

public class KlaustrofobijaTarget : TargetRules
{
	public KlaustrofobijaTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Klaustrofobija");
	}
}
