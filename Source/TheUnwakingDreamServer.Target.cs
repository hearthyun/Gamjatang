using UnrealBuildTool;

public class TheUnwakingDreamServerTarget : TargetRules
{
	public TheUnwakingDreamServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("TheUnwakingDream");
	}
}
