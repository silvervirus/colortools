using System;
using HarmonyLib;
using UnityEngine;

namespace ColorTools
{
	// Token: 0x02000004 RID: 4
	[HarmonyPatch(typeof(FireExtinguisher))]
	[HarmonyPatch("Update")]
	internal class FireE_Color_Patch
	{
		// Token: 0x06000006 RID: 6 RVA: 0x00002118 File Offset: 0x00000318
		public static bool Prefix(FireExtinguisher __instance)
		{
			SkinnedMeshRenderer[] allComponentsInChildren = __instance.GetAllComponentsInChildren<SkinnedMeshRenderer>();
			foreach (SkinnedMeshRenderer skinnedMeshRenderer in allComponentsInChildren)
			{
				bool flag = skinnedMeshRenderer.name.Contains("fire_extinguisher_tube_01_fp");
				if (flag)
				{
					skinnedMeshRenderer.material.color = new Color32(Convert.ToByte(MainPatch.config.Fireexvalue), Convert.ToByte(MainPatch.config.Fireexgvalue), Convert.ToByte(MainPatch.config.Fireexbbvalue), 1);
				}
				bool flag2 = skinnedMeshRenderer.name.Contains("fire_extinguisher_handle_01_fp");
				if (flag2)
				{
					skinnedMeshRenderer.material.color = new Color32(Convert.ToByte(MainPatch.config.Fireexvalue), Convert.ToByte(MainPatch.config.Fireexgvalue), Convert.ToByte(MainPatch.config.Fireexbbvalue), 1);
				}
			}
			return true;
		}
	}
}
