using System.IO;
using System.Reflection;
using ModSettings;
using UnityEngine;
using MelonLoader;

namespace JumpMod
{
    public class JumpModInputsMain : MelonMod
    {
        public static CharacterController controller;
        public static Vector3 playerVelocity;
        public static bool groundedPlayer;
        public static float playerSpeed = 2.0f;
        public static float jumpHeight = 1.0f;
        public static float gravityValue = -9.81f;

        public static void JumpModInputsUpdate()
        {
            if (InputManager.GetKeyDown(InputManager.m_CurrentContext, Settings.GetInputKeyFromString(Settings.options.buttonJump)) && Settings.options.settingJumpEnable == true)
            {
                MelonLogger.Log("Jump!");
                
                groundedPlayer = controller.isGrounded;
                if (groundedPlayer && playerVelocity.y < 0)
                {
                    playerVelocity.y = 0f;
                }


                playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
            

                playerVelocity.y += gravityValue * Time.deltaTime;
                controller.Move(playerVelocity * Time.deltaTime);
            }      
        }
    }
}