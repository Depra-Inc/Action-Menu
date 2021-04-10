using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace FD.UI.Extensions
{
    [AddComponentMenu("UI/Extensions/Selectable Scaler")]
    [RequireComponent(typeof(UnityEngine.UI.Button))]
    [DisallowMultipleComponent]
    public class SelectableScaler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        [SerializeField] AnimationCurve animCurve;
        [Tooltip("Animation speed multiplier")]
        [SerializeField] float speed = 1;
        [SerializeField] Transform target;

        public Selectable Target
        {
            get
            {
                if (selectable == null)
                    selectable = GetComponent<Selectable>();

                return selectable;
            }
        }
        private Selectable selectable;

        private Vector3 initScale;

        // Use this for initialization
        private void Awake()
        {
            if (target == null)
                target = transform;

            initScale = target.localScale;
        }

        private void OnEnable()
        {
            target.localScale = initScale;
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            if (Target != null && !Target.interactable)
                return;

            StopCoroutine(ScaleOUT());
            StartCoroutine(ScaleIN());
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            if (Target != null && !Target.interactable)
                return;

            StopCoroutine(ScaleIN());
            StartCoroutine(ScaleOUT());
        }

        private IEnumerator ScaleIN()
        {
            if (animCurve.keys.Length > 0)
            {
                target.localScale = initScale;
                float t = 0;
                float maxT = animCurve.keys[animCurve.length - 1].time;

                while (t < maxT)
                {
                    t += speed * Time.unscaledDeltaTime;
                    target.localScale = Vector3.one * animCurve.Evaluate(t);

                    yield return null;
                }
            }
        }

        private IEnumerator ScaleOUT()
        {
            if (animCurve.keys.Length > 0)
            {
                //target.localScale = initScale;
                float t = 0;
                float maxT = animCurve.keys[animCurve.length - 1].time;

                while (t < maxT)
                {
                    t += speed * Time.unscaledDeltaTime;
                    target.localScale = Vector3.one * animCurve.Evaluate(maxT - t);
                    yield return null;
                }

                transform.localScale = initScale;
            }
        }
    }
}
