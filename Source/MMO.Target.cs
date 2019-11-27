// CodeSpartan

using UnrealBuildTool;
using System.Collections.Generic;

public class MMOTarget : TargetRules
{
	public MMOTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.AddRange( new string[] { "MMO" } );
	}
}
