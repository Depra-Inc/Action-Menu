using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace FD.UI.TabSystem
{
    [RequireComponent(typeof(Image))]
    [DisallowMultipleComponent]
    public class TabButton : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
    {
        [SerializeField] UnityEvent onTabEnter = null;
        [SerializeField] UnityEvent onTabExit = null;
        [SerializeField] UnityEvent onTabSelected = null;
        [SerializeField] UnityEvent onTabDeselected = null;

        public int Index { get; private set; }

        private Image background = null;
        private bool isSelected = false;

        private TabGroup tabGroup;

        private void Awake()
        {
            background = GetComponent<Image>();
        }

        public void Init(TabGroup tabGroup, int index)
        {
            this.tabGroup = tabGroup;
            Index = index;
        }

        public void SetColor(Color color)
        {
            background.color = color;
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            onTabEnter.Invoke();
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            if (isSelected == false)
                onTabExit.Invoke();
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            tabGroup.OnTabSelected(this);
        }

        public void Select()
        {
            isSelected = true;
            onTabSelected.Invoke();
        }

        public void Deselect()
        {
            isSelected = false;
            onTabDeselected.Invoke();
        }
    }
}