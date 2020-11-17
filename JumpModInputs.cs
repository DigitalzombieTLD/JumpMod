using System.IO;
using System.Reflection;
using ModSettings;
using UnityEngine;
using MelonLoader;

namespace JumpMod
{
    public class JumpModInputsMain : MelonMod
    {

        public static bool isJumping = false;

        public static void JumpModInputsUpdate()
        {
            if (InputManager.GetKeyDown(InputManager.m_CurrentContext, Settings.GetInputKeyFromString(Settings.options.buttonJump)) && Settings.options.settingJumpEnable == true)
            {
                MelonLogger.Log("Jump!");

                if (isJumping == false && GameManager.GetVpFPSPlayer().Controller.m_Controller.isGrounded)
                {
                    if (GameManager.GetInventoryComponent().GetTotalWeightKG() >= 30f)
                    {
                        JumpModActionMain.jumpTimerEnd = 0;
                    }
                    else if (GameManager.GetInventoryComponent().GetTotalWeightKG() >= 20f)
                    {
                        JumpModActionMain.jumpTimerEnd = 0.02f;
                    }
                    else if (GameManager.GetInventoryComponent().GetTotalWeightKG() >= 10f)
                    {
                        JumpModActionMain.jumpTimerEnd = 0.04f;
                    }
                    else if (GameManager.GetInventoryComponent().GetTotalWeightKG() >= 0f)
                    {
                        JumpModActionMain.jumpTimerEnd = 0.08f;
                    }
                    else
                    {
                        JumpModActionMain.jumpTimerEnd = 0.00f;
                    }

                    if (GameManager.GetSprainedAnkleComponent().HasSprainedAnkle() == false && GameManager.GetPlayerManagerComponent().PlayerIsCrouched() == false)
                    {
                        if (GameManager.GetHungerComponent().GetCalorieReserves() >= 350f && GameManager.GetInventoryComponent().GetTotalWeightKG() < 30f)
                        {
                            isJumping = true;
                            GameManager.GetHungerComponent().RemoveReserveCalories(15f);
                            JumpModActionMain.jumpTimer = 0f;
                        }
                    }
                }
            }      
        }
    }
}