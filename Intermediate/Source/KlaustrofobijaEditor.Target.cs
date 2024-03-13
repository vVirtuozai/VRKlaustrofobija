using UnrealBuildTool;

public class KlaustrofobijaEditorTarget : TargetRules
{
	public KlaustrofobijaEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Klaustrofobija");
	}
}
