using UnityEngine;

namespace FD.Misc
{
    public class Rotatable : MonoBehaviour
    {
        [SerializeField] float speed = 20f;
        [SerializeField] float maxSpeed = 100f;
        [SerializeField] float minSpeed = 1f;
        [SerializeField] bool randomSpeed = false;
        [SerializeField] bool randomDirection = false;

        private Vector3 direction;

        private void Awake()
        {
            if (randomDirection)
                direction = GetRandomDirection();
            else
                direction = Vector3.up;

            if (randomSpeed)
                speed = Random.Range(minSpeed, maxSpeed);
        }

        private void FixedUpdate()
        {
            transform.Rotate(direction * speed * Time.fixedDeltaTime);
        }

        private Vector3 GetRandomDirection()
        {
            var random = Random.Range(0, 2);

            Vector3 direction;
            if (random == 0)
                direction = Vector3.up;
            else
                direction = Vector3.down;

            return direction;
        }
    }
}