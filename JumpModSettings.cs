using System.IO;
using System.Reflection;
using UnityEngine;
using ModSettings;

namespace JumpMod
{
    internal class JumpModSettingsMain : JsonModSettings
    {
        [Section("General settings")]

        [Name("Enable / disable mod")]
        [Description("Enable mod")]
        public bool settingJumpEnable = true;

        [Section("Controls")]

        [Name("Jump")]
        [Description("Well ... jump!")]
        [Choice("Space", "Alt", "Ctrl", "Shift", "H", "I", "J", "K", "L", "M", "N", "O", "P", "R", "T", "U", "V", "X", "Y", "Z", "Insert", "Home", "End", "PageUp", "PageDown", "Pause", "Clear", "B", "C", "F", "G")]
        public int buttonJump = 0;        

        protected override void OnChange(FieldInfo field, object oldValue, object newValue)
        {

        }
        protected override void OnConfirm()
        {
            

            base.OnConfirm();
        }
    }

    internal static class Settings
    {
        public static JumpModSettingsMain options;
        public static KeyCode returnKeyValue;

        public static void OnLoad()
        {
            options = new JumpModSettingsMain();
            ///options.RefreshFields();
            options.AddToModSettings("Jump Settings");
        }

        public static KeyCode GetInputKeyFromString(int keyStringInt)
        {
            switch(keyStringInt)
            {
                case 0:
                    returnKeyValue = KeyCode.Space;
                    break;
                case 1:
                    returnKeyValue = KeyCode.LeftAlt;
                    break;
                case 2:
                    returnKeyValue = KeyCode.LeftControl;
                    break;
                case 3:
                    returnKeyValue = KeyCode.LeftShift;
                    break;
                case 4:
                    returnKeyValue = KeyCode.H;
                    break;
                case 5:
                    returnKeyValue = KeyCode.I;
                    break;
                case 6:
                    returnKeyValue = KeyCode.K;
                    break;
                case 7:
                    returnKeyValue = KeyCode.K;
                    break;
                case 8:
                    returnKeyValue = KeyCode.L;
                    break;
                case 9:
                    returnKeyValue = KeyCode.M;
                    break;
                case 10:
                    returnKeyValue = KeyCode.N;
                    break;
                case 11:
                    returnKeyValue = KeyCode.O;
                    break;
                case 12:
                    returnKeyValue = KeyCode.P;
                    break;
                case 13:
                    returnKeyValue = KeyCode.R;
                    break;
                case 14:
                    returnKeyValue = KeyCode.T;
                    break;
                case 15:
                    returnKeyValue = KeyCode.U;
                    break;
                case 16:
                    returnKeyValue = KeyCode.V;
                    break;
                case 17:
                    returnKeyValue = KeyCode.X;
                    break;
                case 18:
                    returnKeyValue = KeyCode.Y;
                    break;
                case 19:
                    returnKeyValue = KeyCode.Z;
                    break;
                case 20:
                    returnKeyValue = KeyCode.Insert;
                    break;
                case 21:
                    returnKeyValue = KeyCode.Home;
                    break;
                case 22:
                    returnKeyValue = KeyCode.End;
                    break;
                case 23:
                    returnKeyValue = KeyCode.PageUp;
                    break;
                case 24:
                    returnKeyValue = KeyCode.PageDown;
                    break;
                case 25:
                    returnKeyValue = KeyCode.Pause;
                    break;
                case 26:
                    returnKeyValue = KeyCode.Clear;
                    break;
                case 27:
                    returnKeyValue = KeyCode.B;
                    break;
                case 28:
                    returnKeyValue = KeyCode.C;
                    break;
                case 29:
                    returnKeyValue = KeyCode.F;
                    break;
                case 30:
                    returnKeyValue = KeyCode.G;
                    break;
            }

            return returnKeyValue;
        }

    }
}
