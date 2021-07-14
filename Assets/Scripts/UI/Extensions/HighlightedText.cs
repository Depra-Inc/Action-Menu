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
        [SerializeField] Color _accentColor = Color.white;

        private Color _defaultTextColor;
        private TMP_Text _textComponent;

        private void Awake()
        {
            if (TryGetComponent(out _textComponent) == false)
                Destroy(gameObject);

            _defaultTextColor = _textComponent.color;
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
            _textComponent.color = _accentColor;
        }

        private void SetDefaultColor()
        {
            _textComponent.color = _defaultTextColor;
        }
    }
}