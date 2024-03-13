using UnrealBuildTool;

public class KlaustrofobijaClientTarget : TargetRules
{
	public KlaustrofobijaClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Klaustrofobija");
	}
}
