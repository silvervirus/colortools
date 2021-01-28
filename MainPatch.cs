using System;
using System.Reflection;
using HarmonyLib;
using QModManager.API.ModLoading;
using SMLHelper.V2.Handlers;

namespace ColorTools
{
	// Token: 0x02000002 RID: 2
	[QModCore]
	public class MainPatch
	{
		internal static Config config { get; } = OptionsPanelHandler.Main.RegisterModOptions<Config>();
		[QModPatch]
		public static void Patch()
		{
			
			
			MainPatch.SecondStart();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000206A File Offset: 0x0000026A
		public static void SecondStart()
		{
			new Harmony("ColorTools.mod").PatchAll(Assembly.GetExecutingAssembly());
		}
	}
}
