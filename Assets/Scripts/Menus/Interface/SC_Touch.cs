using UnityEngine.Events;
using UnityEngine;
using UnityEngine.EventSystems;

namespace AL.UI.Interface
{
    public class SC_Touch : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
  {
          #region Attributes
          [SerializeField] public bool _isTouch;
          [HideInInspector]public UnityEvent OnHold;
          [HideInInspector]public UnityEvent OnRealise;
          #endregion
          #region UnityCalls
        void Update()
        {
          if (_isTouch)
          {
              OnHold.Invoke();
          }
          else
          {
              OnRealise.Invoke();
          }
        }
        #endregion

          #region Methods
          public void OnPointerDown(PointerEventData eventData)
          {
             _isTouch = true;
          }
     
         public void OnPointerUp(PointerEventData eventData)
         {
             _isTouch = false;
         }
          #endregion
    }

}
