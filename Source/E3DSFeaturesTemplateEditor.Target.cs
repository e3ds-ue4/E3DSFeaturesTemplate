// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class E3DSFeaturesTemplateEditorTarget : TargetRules
{
	public E3DSFeaturesTemplateEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
        DefaultBuildSettings = BuildSettingsVersion.V2;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;// Unreal5_0;//EngineIncludeOrderVersion.Latest //EngineIncludeOrderVersion.Unreal5_2
        ExtraModuleNames.Add("E3DSFeaturesTemplate");
	}
}
