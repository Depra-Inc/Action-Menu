using UnityEngine;

namespace FD.UI
{
    [RequireComponent(typeof(CanvasGroup))]
    [DisallowMultipleComponent]
    public class Pulsable : MonoBehaviour
    {
        [SerializeField] int bpm = 66;

        private float timer;

        private CanvasGroup canvasGroup;

        private void Awake()
        {
            canvasGroup = GetComponent<CanvasGroup>();
        }

        private void Update()
        {
            timer += Time.deltaTime * (bpm / 60f);

            canvasGroup.alpha = timer;

            if (timer < 1.0f)
                return;

            SetDefaults();
        }

        public void Enable()
        {
            enabled = true;

            SetDefaults();
        }

        public void Disable()
        {
            enabled = false;

            SetDefaults();
        }

        private void SetDefaults()
        {
            canvasGroup.alpha = 1f;
            timer = 0.0f;
        }
    }
}