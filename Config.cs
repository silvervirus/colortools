using System;
using SMLHelper.V2.Json;
using SMLHelper.V2.Options.Attributes;
using SMLHelper.V2.Utility;
using UnityEngine;

namespace ColorTools
{
	[Menu("ColorTool")]
	public class Config : ConfigFile
	{
		// Token: 0x06000018 RID: 24 RVA: 0x00002860 File Offset: 0x00000A60
		

		// Token: 0x04000001 RID: 1
		public  SerializableColor ToolColor = new Color(0.016f, 1f, 1f);

		// Token: 0x04000002 RID: 2
		public  float rValue;

		// Token: 0x04000003 RID: 3
		public  float gValue;

		// Token: 0x04000004 RID: 4
		public  float bValue;

		// Token: 0x04000005 RID: 5
		public  float toolValue;

		// Token: 0x04000006 RID: 6
		public  float toolgValue;

		// Token: 0x04000007 RID: 7
		public float toolbValue;

		// Token: 0x04000008 RID: 8
		[Slider("Rifle Red", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float Riflevalue;
		[Slider("Rifle Green", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float Riflegvalue;
		[Slider("Rifle Blue", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float Riflebvalue;
		[Slider("Gun Red", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float Gunvalue;
		[Slider("Gun Green", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float Gungvalue;
		[Slider("Gun Blue", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float Gunbvalue;
		[Slider("Terrabuilder Red", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float Terrabuildervalue;
		[Slider("Terrabuilder Green", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float Terrabuildergvalue;
		[Slider("Terrabuilder Blue", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float Terrabuilderbvalue;
		[Slider("Air Red", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float Airvalue;
		[Slider("Air Green", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float Airgvalue;
		[Slider("Air Blue", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float Airbvalue;
		[Slider("builder Red", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float buildervalue;
		[Slider("builder Green", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float buildergvalue;
		[Slider("builder Blue", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float builderbvalue;
		[Slider("Dive Red", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float divevalue;
		[Slider("Dive Green", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float divegvalue;
		[Slider("Bive Blue", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float divebvalue;
		[Slider("Fireex Red", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float Fireexvalue;
		[Slider("Fireex Green", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float Fireexgvalue;
		[Slider("Fireex Blue", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float Fireexbbvalue;
		[Slider("Flare Red", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float Flarevalue;
		[Slider("Flare Green", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float Flaregvalue;
		[Slider("Flare Blue", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float Flarebvalue;
		[Slider("Flashlight Red", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float Flightvalue;
		[Slider("Flashlight Green", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float Flightgvalue;
		[Slider("Flashlight Blue", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float Flightbvalue;
		[Slider("HotKnife Red", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float Hknifevalue;
		[Slider("HotKnife Green", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float Hknifegvalue;
		[Slider("HotKnife Blue", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float Hknifebvalue;
		[Slider("Knife Red", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float knifevalue;
		[Slider("Knife Green", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float knifegvalue;
		[Slider("Knife Blue", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float knifebvalue;
		[Slider("Laser Red", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float laservalue;
		[Slider("Laser Green", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float lasergvalue;
		[Slider("Laser Blue", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float laserbvalue;
		[Slider("LED Red", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float ledvalue;
		[Slider("LED Green", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float ledgvalue;
		[Slider("LED Blue", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float ledbvalue;
		[Slider("Propulsion Cannon Red", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float Propulsionvalue;
		[Slider("Propulsion Cannon Green", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float Propulsiongvalue;
		[Slider("Propulsion Cannon Blue", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float Propulsionbvalue;
		[Slider("Scanner Red", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float Scannervalue;
		[Slider("Scanner Green", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float Scannergvalue;
		[Slider("Scanner Blue", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float Scannerbvalue;
		[Slider("Static Rifle Red", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float SRiflevalue;
		[Slider("Static Rifle Green", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float SRiflegvalue;
		[Slider("Static Rifle Blue", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float SRiflebvalue;
		[Slider("TerraF Red", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float Terrafvalue;
		[Slider("TerraF Green", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float Terrafgvalue;
		[Slider("TerraF Blue", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float Terrabvalue;
		[Slider("Welder Red", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float weldervalue;
		[Slider("Welder Green", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float weldergvalue;
		[Slider("Welder Blue", 1f, 255f, DefaultValue = 1F, Format = "{0:R0}")]
		public float welderbvalue;

	}
}
