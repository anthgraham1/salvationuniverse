// CodeSpartan

using UnrealBuildTool;
using System.Collections.Generic;

public class MMOEditorTarget : TargetRules
{
	public MMOEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		ExtraModuleNames.AddRange( new string[] { "MMO" } );
	}
}
