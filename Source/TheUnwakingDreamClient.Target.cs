using UnrealBuildTool;

public class TheUnwakingDreamClientTarget : TargetRules
{
	public TheUnwakingDreamClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("TheUnwakingDream");
	}
}
