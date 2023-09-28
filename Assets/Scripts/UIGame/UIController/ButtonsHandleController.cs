using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using AL.Tools.Interface;
using UnityEngine.EventSystems;

namespace Al.UIGame
{

    public class ButtonsHandleController : MonoBehaviour, IButtonHandle, IPointerDownHandler, IPointerUpHandler
    {
        #region Attributes
        public bool _isDonw;
        public bool IsDown { get { return _isDonw; } set => _isDonw = value; }
        private bool _isOnClick;
        public bool IsOnClick { get => _isOnClick; set => _isOnClick = value; }
        private bool _isUp;
        public bool IsUp { get => _isUp; set => _isUp = value; }
      



        #endregion


        #region custom privat method
        public void OnPointerDown(PointerEventData eventData)
        {
            _isDonw = true;
            StartCoroutine(ClickCorrutine());
            IsUp = false;
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            IsUp  = true;
            _isDonw = false;
        }
        IEnumerator ClickCorrutine()
        {
            _isOnClick = true;
            yield return new WaitForSeconds(0.001f);
            _isOnClick = false;

        }
        #endregion


    }
}
