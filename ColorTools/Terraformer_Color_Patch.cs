using System;
using HarmonyLib;
using UnityEngine;

namespace ColorTools
{
	// Token: 0x0200000A RID: 10
	[HarmonyPatch(typeof(Terraformer))]
	[HarmonyPatch("Update")]
	internal class Terraformer_Color_Patch
	{
		// Token: 0x06000012 RID: 18 RVA: 0x000025CC File Offset: 0x000007CC
		public static bool Prefix(Terraformer __instance)
		{
			
			SkinnedMeshRenderer[] allComponentsInChildren = __instance.GetAllComponentsInChildren<SkinnedMeshRenderer>();
			foreach (SkinnedMeshRenderer skinnedMeshRenderer in allComponentsInChildren)
			{
				bool flag = skinnedMeshRenderer.name.Contains("Terraformer_body");
				if (flag)
				{
					skinnedMeshRenderer.material.color = new Color32(Convert.ToByte(MainPatch.config.Terrafvalue), Convert.ToByte(MainPatch.config.Terrafgvalue), Convert.ToByte(MainPatch.config.Terrabvalue), 1);
				}
				bool flag2 = skinnedMeshRenderer.name.Contains("Terraformer_front_01_02");
				if (flag2)
				{
					skinnedMeshRenderer.material.color = new Color32(Convert.ToByte(MainPatch.config.Terrafvalue), Convert.ToByte(MainPatch.config.Terrafgvalue), Convert.ToByte(MainPatch.config.Terrabvalue), 1);
				}
				bool flag3 = skinnedMeshRenderer.name.Contains("Terraformer_front_02_02");
				if (flag3)
				{
					skinnedMeshRenderer.material.color = new Color32(Convert.ToByte(MainPatch.config.Terrafvalue), Convert.ToByte(MainPatch.config.Terrafgvalue), Convert.ToByte(MainPatch.config.Terrabvalue), 1);
				}
				bool flag4 = skinnedMeshRenderer.name.Contains("Terraformer_front");
				if (flag4)
				{
					skinnedMeshRenderer.material.color = new Color32(Convert.ToByte(MainPatch.config.Terrafvalue), Convert.ToByte(MainPatch.config.Terrafgvalue), Convert.ToByte(MainPatch.config.Terrabvalue), 1);
				}


			}

			return true;
		}
	}
}
