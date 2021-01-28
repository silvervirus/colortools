using System;
using HarmonyLib;
using UnityEngine;

namespace ColorTools
{
	// Token: 0x0200000B RID: 11
	[HarmonyPatch(typeof(global::Flare))]
	[HarmonyPatch("Update")]
	internal class Flare_Color_Patch
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00002658 File Offset: 0x00000858
		public static bool Prefix(global::Flare __instance)
		{
			MeshRenderer[] allComponentsInChildren = __instance.GetAllComponentsInChildren<MeshRenderer>();
			MeshRenderer[] allComponentsInChildren2 = __instance.GetAllComponentsInChildren<MeshRenderer>();
			foreach (MeshRenderer meshRenderer in allComponentsInChildren)
			{
				bool flag = meshRenderer.name.Contains("flare");
				if (flag)
				{
					meshRenderer.material.color = new Color32(Convert.ToByte(MainPatch.config.Flarevalue), Convert.ToByte(MainPatch.config.Flaregvalue), Convert.ToByte(MainPatch.config.Flarebvalue), 1);
				}
			}
			foreach (MeshRenderer meshRenderer2 in allComponentsInChildren2)
			{
				bool flag2 = meshRenderer2.name.Contains("flare_cap");
				if (flag2)
				{
					meshRenderer2.material.color = new Color32(Convert.ToByte(MainPatch.config.Flarevalue), Convert.ToByte(MainPatch.config.Flaregvalue), Convert.ToByte(MainPatch.config.Flarebvalue), 1);
				}
			}
			return true;
		}
	}
}
