using UnityEngine;

namespace Demo.Colisiones
{
    [RequireComponent(typeof(CharacterController))]
    public class Platformer3D : MonoBehaviour
    {
        private CharacterController controller;
        private Vector3 playerVelocity;
        private bool groundedPlayer;

        [SerializeField]
        private float playerSpeed = 6.0f;

        [SerializeField]
        private float jumpHeight = 1.5f;

        [SerializeField]
        private float gravityValue = -20f;

        private void Start()
        {
            controller = GetComponent<CharacterController>();
        }

        void Update()
        {
            groundedPlayer = controller.isGrounded;
            if (groundedPlayer && playerVelocity.y < 0)
            {
                playerVelocity.y = -1f;
            }

            Vector3 move = new(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            controller.Move(playerSpeed * Time.deltaTime * move);

            if (move != Vector3.zero)
            {
                transform.forward = move;
            }

            if (Input.GetButtonDown("Jump") && groundedPlayer)
            {
                playerVelocity.y += Mathf.Sqrt(jumpHeight * -2.0f * gravityValue);
            }

            playerVelocity.y += gravityValue * Time.deltaTime;
            controller.Move(playerVelocity * Time.deltaTime);
        }
    }
}