using UnrealBuildTool;

public class KlaustrofobijaServerTarget : TargetRules
{
	public KlaustrofobijaServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Klaustrofobija");
	}
}
