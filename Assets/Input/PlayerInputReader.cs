using Assets.Core;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Assets.Input
{
    public class PlayerInputReader : MonoBehaviour
    {
        [SerializeField]
        private Player m_player;

        public void OnMovement(InputAction.CallbackContext context)
        {
            Vector2 direction = context.ReadValue<Vector2>();
            m_player.SetMoveDirection(direction);
        }

        public void OnLook(InputAction.CallbackContext context)
        {
            Vector2 direction = context.ReadValue<Vector2>();
            m_player.SetLookDirection(direction);
        }
    }
}
