using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace FD.UI
{
    internal class InteractiveZone : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        [SerializeField] protected UnityEvent onPointerEnter = new UnityEvent();
        [SerializeField] protected UnityEvent onPointerExit = new UnityEvent();

        public virtual void OnPointerEnter(PointerEventData eventData)
        {
            onPointerEnter?.Invoke();
        }

        public virtual void OnPointerExit(PointerEventData eventData)
        {
            onPointerExit?.Invoke();
        }
    }
}
