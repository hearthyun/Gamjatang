using UnrealBuildTool;

public class TheUnwakingDreamTarget : TargetRules
{
	public TheUnwakingDreamTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("TheUnwakingDream");
	}
}
