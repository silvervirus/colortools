using System;
using HarmonyLib;
using UnityEngine;

namespace ColorTools
{
	// Token: 0x02000006 RID: 6
	[HarmonyPatch(typeof(PlayerTool))]
	[HarmonyPatch("OnHolster")]
	internal class knife_Color_Patch
	{
		// Token: 0x0600000A RID: 10 RVA: 0x000022A8 File Offset: 0x000004A8
		public static bool Prefix(PlayerTool __instance)
		{
			MeshRenderer[] allComponentsInChildren = __instance.GetAllComponentsInChildren<MeshRenderer>();
			foreach (MeshRenderer meshRenderer in allComponentsInChildren)
			{
				bool flag = meshRenderer.name.Contains("knife_01");
				if (flag)
				{
					meshRenderer.material.color = new Color32(Convert.ToByte(MainPatch.config.knifevalue), Convert.ToByte(MainPatch.config.knifegvalue), Convert.ToByte(MainPatch.config.knifebvalue), 1);
				}
			}
			return true;
		}
	}
}
