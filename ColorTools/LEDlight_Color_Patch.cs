using System;
using HarmonyLib;
using UnityEngine;

namespace ColorTools
{
	// Token: 0x02000009 RID: 9
	[HarmonyPatch(typeof(LEDLight))]
	[HarmonyPatch("Update")]
	internal class LEDlight_Color_Patch
	{
		// Token: 0x06000010 RID: 16 RVA: 0x0000244C File Offset: 0x0000064C
		public static bool Prefix(LEDLight __instance)
		{
			MeshRenderer[] allComponentsInChildren = __instance.GetAllComponentsInChildren<MeshRenderer>();
			MeshRenderer[] allComponentsInChildren2 = __instance.GetAllComponentsInChildren<MeshRenderer>();
			SkinnedMeshRenderer[] allComponentsInChildren3 = __instance.GetAllComponentsInChildren<SkinnedMeshRenderer>();
			foreach (MeshRenderer meshRenderer in allComponentsInChildren)
			{
				bool flag = meshRenderer.name.Contains("LED_light");
				if (flag)
				{
					meshRenderer.material.color = new Color32(Convert.ToByte(MainPatch.config.ledvalue), Convert.ToByte(MainPatch.config.ledgvalue), Convert.ToByte(MainPatch.config.ledbvalue), 1);
				}
			}
			foreach (MeshRenderer meshRenderer2 in allComponentsInChildren2)
			{
				bool flag2 = meshRenderer2.name.Contains("LED_Light");
				if (flag2)
				{
					meshRenderer2.material.color = new Color32(Convert.ToByte(MainPatch.config.ledvalue), Convert.ToByte(MainPatch.config.ledgvalue), Convert.ToByte(MainPatch.config.ledbvalue), 1);
				}
			}
			foreach (SkinnedMeshRenderer skinnedMeshRenderer in allComponentsInChildren3)
			{
				bool flag3 = skinnedMeshRenderer.name.Contains("LED_Light_01");
				if (flag3)
				{
					skinnedMeshRenderer.material.color = new Color32(Convert.ToByte(MainPatch.config.ledvalue), Convert.ToByte(MainPatch.config.ledgvalue), Convert.ToByte(MainPatch.config.ledbvalue), 1);
				}
			}
			return true;
		}
	}
}
