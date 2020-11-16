using System;
using MelonLoader;
using Harmony;
using UnityEngine;
using System.Reflection;
using System.Xml.XPath;
using System.Globalization;
using UnhollowerRuntimeLib;
using ModSettings;

namespace JumpMod
{
    public class JumpModMain : MelonMod
    {
        public static Transform playerTransform;
        public static bool levelLoaded;

        public override void OnApplicationStart()
        {  
            MelonLogger.Log("Jump mod succesfully loaded");

            // Settings menu
            JumpMod.Settings.OnLoad();
        }

        public override void OnLevelWasInitialized(int level)
        {
            if (level >= 6)
            {
                JumpModInputsMain.controller = GameManager.GetVpFPSPlayer().Controller.m_Controller;
                playerTransform = GameManager.GetPlayerTransform();
                levelLoaded = true;
            }
            else
            {
                levelLoaded = false;
            }
        }

        public override void OnUpdate()
        {
            if (levelLoaded == true)
            {
                JumpModInputsMain.JumpModInputsUpdate();
            }
        }

        public override void OnFixedUpdate()
        {

        }
    }
}