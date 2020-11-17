using System.IO;
using System.Reflection;
using ModSettings;
using UnityEngine;
using MelonLoader;

namespace JumpMod
{
    public class JumpModActionMain : MelonMod
    {
        public static CharacterController controller;
        public static Vector3 playerVelocity;
        public static float jumpHeight = 0.5f;
        public static float gravityValue = -9.81f;
        public static float jumpTimer = 0f;
        public static float jumpTimerEnd;

        public static void JumpModActionUpdate()
        {
            if (JumpModInputsMain.isJumping == true)
            {
                if (jumpTimer <= jumpTimerEnd)
                {
                    //GameManager.GetHungerComponent().RemoveReserveCalories(50f);

                    playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);

                    playerVelocity.y += gravityValue * Time.deltaTime;
                    controller.Move(playerVelocity * Time.deltaTime);

                    jumpTimer += Time.deltaTime;                    
                }
                else
                {
                   playerVelocity.y = 0f;
                   jumpTimer = 0;
                   JumpModInputsMain.isJumping = false;
                }
            }
        }
    }
}