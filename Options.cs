﻿using Newtonsoft.Json;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Lain
{
    public class SettingsJson
    {
        public Theme Color { get; set; }
        public bool Authorize { get; set; }
        public bool AutoStart { get; set; }
        public bool AutoLock { get; set; }
        public bool HidePasswords { get; set; }
        public int Minutes { get; set; }
        public int FontSize { get; set; }
        public Size WindowSize { get; set; }
        public Point? WindowLocation { get; set; }
        public FormWindowState WindowState { get; set; }
    }

    internal static class Options
    {
        internal static Color ForegroundColor = Color.MediumOrchid;
        internal static Color ForegroundAccentColor = Color.DarkOrchid;
        internal static Color BackgroundColor = Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));

        internal readonly static string ThemeFlag = "themeable";
        readonly static string _settingsFile = Required.DataFolder + "Lain.json";

        internal static SettingsJson CurrentOptions = new SettingsJson();

        internal static void ApplyTheme(Form f)
        {
            switch (CurrentOptions.Color)
            {
                case Theme.Caramel:
                    SetTheme(f, Color.DarkOrange, Color.Chocolate);
                    break;
                case Theme.Lime:
                    SetTheme(f, Color.LimeGreen, Color.ForestGreen);
                    break;
                case Theme.Magma:
                    SetTheme(f, Color.Tomato, Color.Red);
                    break;
                case Theme.Minimal:
                    SetTheme(f, Color.Gray, Color.DimGray);
                    break;
                case Theme.Ocean:
                    SetTheme(f, Color.DodgerBlue, Color.RoyalBlue);
                    break;
                case Theme.Zerg:
                    SetTheme(f, Color.MediumOrchid, Color.DarkOrchid);
                    break;
            }
        }

        private static void SetTheme(Form f, Color c1, Color c2)
        {
            ForegroundColor = c1;
            ForegroundAccentColor = c2;

            Utilities.GetSelfAndChildrenRecursive(f).OfType<Button>().ToList().ForEach(b => b.BackColor = c1);
            Utilities.GetSelfAndChildrenRecursive(f).OfType<Button>().ToList().ForEach(b => b.FlatAppearance.BorderColor = c1);
            Utilities.GetSelfAndChildrenRecursive(f).OfType<Button>().ToList().ForEach(b => b.FlatAppearance.MouseDownBackColor = c2);
            Utilities.GetSelfAndChildrenRecursive(f).OfType<Button>().ToList().ForEach(b => b.FlatAppearance.MouseOverBackColor = c2);

            foreach (Label tmp in Utilities.GetSelfAndChildrenRecursive(f).OfType<Label>().ToList())
            {
                if ((string)tmp.Tag == ThemeFlag)
                {
                    tmp.ForeColor = c1;
                }
            }
            foreach (LinkLabel tmp in Utilities.GetSelfAndChildrenRecursive(f).OfType<LinkLabel>().ToList())
            {
                if ((string)tmp.Tag == ThemeFlag)
                {
                    tmp.LinkColor = c1;
                    tmp.VisitedLinkColor = c1;
                    tmp.ActiveLinkColor = c2;
                }
            }
            foreach (CheckBox tmp in Utilities.GetSelfAndChildrenRecursive(f).OfType<CheckBox>().ToList())
            {
                if ((string)tmp.Tag == ThemeFlag)
                {
                    tmp.ForeColor = c1;
                }
            }
            foreach (RadioButton tmp in Utilities.GetSelfAndChildrenRecursive(f).OfType<RadioButton>().ToList())
            {
                if ((string)tmp.Tag == ThemeFlag)
                {
                    tmp.ForeColor = c1;
                }
            }
        }

        internal static void SaveSettings()
        {
            if (File.Exists(_settingsFile))
            {
                File.WriteAllText(_settingsFile, string.Empty);

                using (FileStream fs = File.Open(_settingsFile, FileMode.OpenOrCreate))
                using (StreamWriter sw = new StreamWriter(fs))
                using (JsonWriter jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;

                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(jw, CurrentOptions);
                }
            }
        }

        internal static void LoadSettings()
        {
            if (!File.Exists(_settingsFile))
            {
                CurrentOptions.Color = Theme.Zerg;
                CurrentOptions.Authorize = true;
                CurrentOptions.AutoLock = false;
                CurrentOptions.HidePasswords = false;
                CurrentOptions.Minutes = 2;
                CurrentOptions.AutoStart = false;
                CurrentOptions.WindowLocation = null;
                CurrentOptions.WindowSize = new Size(907, 681);
                CurrentOptions.FontSize = 1;
                CurrentOptions.WindowState = FormWindowState.Normal;

                using (FileStream fs = File.Open(_settingsFile, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(fs))
                using (JsonWriter jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;

                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(jw, CurrentOptions);
                }
            }
            else
            {
                CurrentOptions = JsonConvert.DeserializeObject<SettingsJson>(File.ReadAllText(_settingsFile));

                if (CurrentOptions.WindowSize.IsEmpty)
                {
                    CurrentOptions.WindowSize = new Size(907, 681);
                    SaveSettings();
                }
            }
        }
    }
}
