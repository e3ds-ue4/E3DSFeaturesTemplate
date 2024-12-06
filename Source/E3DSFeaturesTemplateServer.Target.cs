// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class E3DSFeaturesTemplateServerTarget : TargetRules
{
	public E3DSFeaturesTemplateServerTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Server;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		
		ExtraModuleNames.Add("E3DSFeaturesTemplate");
	}
}
