using System;
using HarmonyLib;
using UnityEngine;

namespace ColorTools
{
	// Token: 0x02000005 RID: 5
	[HarmonyPatch(typeof(BuilderTool))]
	[HarmonyPatch("Update")]
	internal class builder_Color_Patch
	{
		// Token: 0x06000008 RID: 8 RVA: 0x000021A4 File Offset: 0x000003A4
		public static bool Prefix(BuilderTool __instance)
		{
			SkinnedMeshRenderer[] allComponentsInChildren = __instance.GetAllComponentsInChildren<SkinnedMeshRenderer>();
			MeshRenderer[] allComponentsInChildren2 = __instance.GetAllComponentsInChildren<MeshRenderer>();
			foreach (SkinnedMeshRenderer skinnedMeshRenderer in allComponentsInChildren)
			{
				bool flag = skinnedMeshRenderer.name.Contains("builder_geo");
				if (flag)
				{
					skinnedMeshRenderer.material.color = new Color32(Convert.ToByte(MainPatch.config.buildervalue), Convert.ToByte(MainPatch.config.buildergvalue), Convert.ToByte(MainPatch.config.builderbvalue), 1);
				}
			}
			foreach (MeshRenderer meshRenderer in allComponentsInChildren2)
			{
				bool flag2 = meshRenderer.name.Contains("builder");
				if (flag2)
				{
					meshRenderer.material.color = new Color32(Convert.ToByte(MainPatch.config.buildervalue), Convert.ToByte(MainPatch.config.buildergvalue), Convert.ToByte(MainPatch.config.builderbvalue), 1);
				}
			}
			return true;
		}
	}
}
