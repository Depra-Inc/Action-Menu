using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace FD.UI.Extensions
{
    [AddComponentMenu("UI/Extensions/Selectable Scaler")]
    [RequireComponent(typeof(Button))]
    [DisallowMultipleComponent]
    public class SelectableScaler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        [SerializeField] private AnimationCurve _animCurve;
        [Tooltip("Animation speed multiplier")]
        [SerializeField] private float _speed = 1;
        [SerializeField] private Transform _target;

        public Selectable Target
        {
            get
            {
                if (_selectable == null)
                    _selectable = GetComponent<Selectable>();

                return _selectable;
            }
        }
        private Selectable _selectable;

        private Vector3 _initScale;

        private void Awake()
        {
            if (_target == null)
                _target = transform;

            _initScale = _target.localScale;
        }

        private void OnEnable()
        {
            _target.localScale = _initScale;
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            if (Target != null && !Target.interactable)
                return;

            StopCoroutine(ScaleOut());
            StartCoroutine(ScaleIn());
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            if (Target != null && !Target.interactable)
                return;

            StopCoroutine(ScaleIn());
            StartCoroutine(ScaleOut());
        }

        private IEnumerator ScaleIn()
        {
            if (_animCurve.keys.Length > 0)
            {
                _target.localScale = _initScale;
                float t = 0;
                float maxT = _animCurve.keys[_animCurve.length - 1].time;

                while (t < maxT)
                {
                    t += _speed * Time.unscaledDeltaTime;
                    _target.localScale = Vector3.one * _animCurve.Evaluate(t);

                    yield return null;
                }
            }
        }

        private IEnumerator ScaleOut()
        {
            if (_animCurve.keys.Length > 0)
            {
                //target.localScale = initScale;
                float t = 0;
                float maxT = _animCurve.keys[_animCurve.length - 1].time;

                while (t < maxT)
                {
                    t += _speed * Time.unscaledDeltaTime;
                    _target.localScale = Vector3.one * _animCurve.Evaluate(maxT - t);
                    yield return null;
                }

                transform.localScale = _initScale;
            }
        }
    }
}
