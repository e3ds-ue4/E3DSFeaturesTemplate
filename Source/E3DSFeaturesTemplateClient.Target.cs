// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class E3DSFeaturesTemplateClientTarget : TargetRules
{
	public E3DSFeaturesTemplateClientTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Client;
		DefaultBuildSettings = BuildSettingsVersion.V2;
	
		ExtraModuleNames.Add("E3DSFeaturesTemplate");
	}
}
