using System;
using HarmonyLib;
using UnityEngine;

namespace ColorTools
{
	// Token: 0x0200000C RID: 12
	[HarmonyPatch(typeof(RepulsionCannon))]
	[HarmonyPatch("Update")]
	internal class RepulsionCannon_Color_Patch
	{
		// Token: 0x06000016 RID: 22 RVA: 0x0000275C File Offset: 0x0000095C
		public static bool Prefix(RepulsionCannon __instance)
		{
			SkinnedMeshRenderer[] allComponentsInChildren = __instance.GetAllComponentsInChildren<SkinnedMeshRenderer>();
			MeshRenderer[] allComponentsInChildren2 = __instance.GetAllComponentsInChildren<MeshRenderer>();
			foreach (SkinnedMeshRenderer skinnedMeshRenderer in allComponentsInChildren)
			{
				bool flag = skinnedMeshRenderer.name.Contains("Propulsion_Cannon_geo");
				if (flag)
				{
					skinnedMeshRenderer.material.color = new Color32(Convert.ToByte(MainPatch.config.Propulsionvalue), Convert.ToByte(MainPatch.config.Propulsiongvalue), Convert.ToByte(MainPatch.config.Propulsionbvalue), 1);
				}
			}
			foreach (MeshRenderer meshRenderer in allComponentsInChildren2)
			{
				bool flag2 = meshRenderer.name.Contains("Propulsion_Cannon");
				if (flag2)
				{
					meshRenderer.material.color = new Color32(Convert.ToByte(MainPatch.config.Propulsionvalue), Convert.ToByte(MainPatch.config.Propulsiongvalue), Convert.ToByte(MainPatch.config.Propulsionbvalue), 1);
				}
			}
			return true;
		}
	}
}
