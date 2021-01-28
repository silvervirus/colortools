using System;
using HarmonyLib;
using UnityEngine;

namespace ColorTools
{
	// Token: 0x02000007 RID: 7
	[HarmonyPatch(typeof(HeatBlade))]
	[HarmonyPatch("OnDraw")]
	internal class hotknife_Color_Patch
	{
		// Token: 0x0600000C RID: 12 RVA: 0x00002334 File Offset: 0x00000534
		public static bool Prefix(HeatBlade __instance)
		{
			MeshRenderer[] allComponentsInChildren = __instance.GetAllComponentsInChildren<MeshRenderer>();
			foreach (MeshRenderer meshRenderer in allComponentsInChildren)
			{
				bool flag = meshRenderer.name.Contains("knife_01_hot");
				if (flag)
				{
					meshRenderer.material.color = new Color32(Convert.ToByte(MainPatch.config.Hknifevalue), Convert.ToByte(MainPatch.config.Hknifegvalue), Convert.ToByte(MainPatch.config.Hknifebvalue), 1);
				}
			}
			return true;
		}
	}
}
