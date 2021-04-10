using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace FD.UI
{
    [AddComponentMenu("UI/Extensions/Hightlighted Text")]
    [RequireComponent(typeof(TMP_Text))]
    [DisallowMultipleComponent]
    public class HighlightedText : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        [SerializeField] Color accentColor = Color.red;

        private Color defaultTextColor;

        private TMP_Text textComponent;

        private void Awake()
        {
            if (TryGetComponent(out textComponent) == false)
                Destroy(gameObject);

            defaultTextColor = textComponent.color;
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            SetAccentColor();
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            SetDefaultColor();
        }

        private void SetAccentColor()
        {
            textComponent.color = accentColor;
        }

        private void SetDefaultColor()
        {
            textComponent.color = defaultTextColor;
        }
    }
}