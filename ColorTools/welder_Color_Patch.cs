using System;
using HarmonyLib;
using UnityEngine;

namespace ColorTools
{
	// Token: 0x02000014 RID: 20
	[HarmonyPatch(typeof(Welder))]
	[HarmonyPatch("Update")]
	internal class welder_Color_Patch
	{
		// Token: 0x06000029 RID: 41 RVA: 0x0000300C File Offset: 0x0000120C
		public static bool Prefix(Welder __instance)
		{
			SkinnedMeshRenderer[] allComponentsInChildren = __instance.GetAllComponentsInChildren<SkinnedMeshRenderer>();
			foreach (SkinnedMeshRenderer skinnedMeshRenderer in allComponentsInChildren)
			{
				bool flag = skinnedMeshRenderer.name.Contains("welder_geos");
				if (flag)
				{
					skinnedMeshRenderer.material.color = new Color32(Convert.ToByte(MainPatch.config.weldervalue), Convert.ToByte(MainPatch.config.weldergvalue), Convert.ToByte(MainPatch.config.welderbvalue), 1);
				}
			}
			return true;
		}
	}
}
