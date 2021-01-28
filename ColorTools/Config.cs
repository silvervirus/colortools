using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using SMLHelper.V2.Options;
using SMLHelper.V2.Utility;
using UnityEngine;

namespace ColorTools
{
    public static class Config
    {
        public static SerializableColor ToolColor = new Color(0.016f, 1.0f, 1.0f);
        public static float rValue;
        public static float gValue;
        public static float bValue;
        public static float toolValue;
        public static float toolgValue;
        public static float toolbValue;


        public static bool toolColor;

        public static void Load()
        {

            rValue = PlayerPrefs.GetFloat("R", 0.016f);
            gValue = PlayerPrefs.GetFloat("G", 1.000f);
            bValue = PlayerPrefs.GetFloat("B", 1.000f);
            toolValue = PlayerPrefs.GetFloat("ToolR", 0.016f);
            toolgValue = PlayerPrefs.GetFloat("ToolG", 1.000f);
            toolValue = PlayerPrefs.GetFloat("ToolB", 1.000f);


            toolColor = PlayerPrefsExtra.GetBool("toolColor", true);
        }
    }

    public class Options : ModOptions
    {
        public Options() : base("Color tools Settings")
        {
            SliderChanged += Options_SliderChanged;

        }
        public void Options_ToggleChanged(object sender, ToggleChangedEventArgs e)
        {


            if (e.Id == "toolcolor")
            {
                Config.toolColor = e.Value;
                PlayerPrefsExtra.SetBool("toolColor", e.Value);
            }
        }

        public void Options_SliderChanged(object sender, SliderChangedEventArgs e)
        {
            if (e.Id == "r")
            {
                Config.rValue = e.Value;
                PlayerPrefs.SetFloat("R", e.Value);
            }
            else if (e.Id == "g")
            {
                Config.gValue = e.Value;
                PlayerPrefs.SetFloat("G", e.Value);
            }
            else if (e.Id == "b")
            {
                Config.bValue = e.Value;
                PlayerPrefs.SetFloat("B", e.Value);
            }

            if (e.Id == "toolr")
            {
                Config.toolValue = e.Value;
                PlayerPrefs.SetFloat("ToolR", e.Value);
            }
            else if (e.Id == "toolg")
            {
                Config.toolgValue = e.Value;
                PlayerPrefs.SetFloat("ToolG", e.Value);
            }
            else if (e.Id == "toolb")
            {
                Config.toolbValue = e.Value;
                PlayerPrefs.SetFloat("ToolB", e.Value);
            }
        }

        public override void BuildModOptions()
        {

            if (Config.toolColor == true)
            {
                AddToggleOption("toolcolor", "Color Tools Color Enabled", Config.toolColor);
                AddSliderOption("toolr", "tool Red", 0, 255, Config.toolValue);
                AddSliderOption("toolg", "tool Green", 0, 255, Config.toolgValue);
                AddSliderOption("toolb", "tool Blue", 0, 255, Config.toolbValue);

                Config.Load();
            }
            
            else
            {

                AddToggleOption("toolcolor", "Color Tools Color Enabled", Config.toolColor);

                Config.Load();
            }
        }
    }
}
