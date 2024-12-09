using UnrealBuildTool;

public class TheUnwakingDreamEditorTarget : TargetRules
{
	public TheUnwakingDreamEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("TheUnwakingDream");
	}
}
