
using System;
using UnityEngine;

namespace Gameplay {

    [SelectionBase]
    [DisallowMultipleComponent]
    [RequireComponent(typeof(CharacterController))]
    public class PlayerController : MonoBehaviour
    {
        public CharacterController characterController { get; private set; }
        public PlayerCharacter playerCharacter { get; private set; }

        public FirstPersonCamera playerCamera;

        protected void Awake()
        {
            characterController = GetComponent<CharacterController>();
            playerCharacter = GetComponent<PlayerCharacter>();
        }

        protected void Update()
        {
            var transform = this.transform;

            PlayerInput input;
            PlayerInput.Update(out input);

            if (input.move.y < 0f)
                input.look.y = -input.look.y;

            if (playerCharacter)
                playerCharacter.Simulate(characterController, input);

        }

        protected void LateUpdate()
        {
            var firstPersonCamera = playerCamera as FirstPersonCamera;

            if (firstPersonCamera && playerCharacter)
            {
                float pitch, yaw;
                playerCharacter.GetLookPitchAndYaw(out pitch, out yaw);
                firstPersonCamera.pitch = pitch;
                firstPersonCamera.yaw = yaw;
            }

            var transform = this.transform;
            var position = transform.localPosition;
            var rotation = transform.localEulerAngles;
            float deltaTime = Time.deltaTime;

            playerCamera.Simulate(position, rotation, deltaTime);
        }
    }
}


