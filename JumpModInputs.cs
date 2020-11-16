using System.IO;
using System.Reflection;
using ModSettings;
using UnityEngine;
using MelonLoader;

namespace JumpMod
{
    public class JumpModInputsMain : MelonMod
    {  
        public static void JumpModInputsUpdate()
        {
            if (InputManager.GetKeyDown(InputManager.m_CurrentContext, Settings.GetInputKeyFromString(Settings.options.buttonJump)) && Settings.options.settingJumpEnable == true)
            {
                MelonLogger.Log("Jump!");
            }      
        }
    }
}