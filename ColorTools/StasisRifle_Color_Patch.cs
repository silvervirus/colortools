using System;
using HarmonyLib;
using UnityEngine;

namespace ColorTools
{
	// Token: 0x02000015 RID: 21
	[HarmonyPatch(typeof(StasisRifle))]
	[HarmonyPatch("Awake")]
	internal class StasisRifle_Color_Patch
	{
		// Token: 0x0600002B RID: 43 RVA: 0x00003098 File Offset: 0x00001298
		public static bool Prefix(StasisRifle __instance)
		{
			SkinnedMeshRenderer[] allComponentsInChildren = __instance.GetAllComponentsInChildren<SkinnedMeshRenderer>();
			foreach (SkinnedMeshRenderer skinnedMeshRenderer in allComponentsInChildren)
			{
				bool flag = skinnedMeshRenderer.name.Contains("stasis_rifle_geo");
				if (flag)
				{
					skinnedMeshRenderer.material.color = new Color32(Convert.ToByte(MainPatch.config.SRiflevalue), Convert.ToByte(MainPatch.config.SRiflegvalue), Convert.ToByte(MainPatch.config.SRiflebvalue), 1);
				}
			}
			return true;
		}
	}
}
