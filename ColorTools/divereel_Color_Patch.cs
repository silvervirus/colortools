using System;
using HarmonyLib;
using UnityEngine;

namespace ColorTools
{
	// Token: 0x02000008 RID: 8
	[HarmonyPatch(typeof(DiveReel))]
	[HarmonyPatch("Update")]
	internal class divereel_Color_Patch
	{
		// Token: 0x0600000E RID: 14 RVA: 0x000023C0 File Offset: 0x000005C0
		public static bool Prefix(DiveReel __instance)
		{
			SkinnedMeshRenderer[] allComponentsInChildren = __instance.GetAllComponentsInChildren<SkinnedMeshRenderer>();
			foreach (SkinnedMeshRenderer skinnedMeshRenderer in allComponentsInChildren)
			{
				bool flag = skinnedMeshRenderer.name.Contains("dive_reel_geo");
				if (flag)
				{
					skinnedMeshRenderer.material.color = new Color32(Convert.ToByte(MainPatch.config.divevalue), Convert.ToByte(MainPatch.config.divegvalue), Convert.ToByte(MainPatch.config.divebvalue), 1);
				}
			}
			return true;
		}
	}
}
