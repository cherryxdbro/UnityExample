using UnityEngine;

namespace Assets.Core
{
    public class Player : MonoBehaviour
    {
        [SerializeField]
        private float m_look_speed;
        [SerializeField]
        private float m_move_speed;

        [SerializeField]
        private Transform m_player_camera_root;

        private Vector2 m_move_direction;
        private Vector2 m_look_direction;

        private Rigidbody m_rigidbody;

        private void Awake()
        {
            m_rigidbody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            Move();
            Look();
        }

        internal void SetMoveDirection(Vector2 direction)
        {
            m_move_direction = direction;
        }

        internal void SetLookDirection(Vector2 direction)
        {
            m_look_direction = direction;
        }

        private void Move()
        {
            Vector3 move_direction = new(m_move_direction.x, 0, m_move_direction.y);
            move_direction.Normalize();
            m_rigidbody.velocity = move_direction * m_move_speed;
        }

        private void Look()
        {
            m_camera_yaw = m_look_direction.x;
            m_camera_pitch = -m_look_direction.y;
        }

    }
}
