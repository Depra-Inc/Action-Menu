using UnityEngine;

namespace FD.Misc
{
    public class Rotatable : MonoBehaviour
    {
        [SerializeField] private float _speed = 20f;
        [SerializeField] private float _maxSpeed = 100f;
        [SerializeField] private float _minSpeed = 1f;
        [SerializeField] private bool _randomSpeed = false;
        [SerializeField] private bool _randomDirection = false;

        private Vector3 _direction;

        private void Awake()
        {
            if (_randomDirection)
                _direction = GetRandomDirection();
            else
                _direction = Vector3.up;

            if (_randomSpeed)
                _speed = Random.Range(_minSpeed, _maxSpeed);
        }

        private void FixedUpdate()
        {
            transform.Rotate(_direction * _speed * Time.fixedDeltaTime);
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