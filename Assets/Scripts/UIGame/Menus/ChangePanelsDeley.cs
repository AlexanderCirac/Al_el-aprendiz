using UnityEditor;
using UnityEngine;
using UnityEngine.UI;


namespace Al.UIGame
{
    using Al.UIGame;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography;

    public class ChangePanelsDeley : MonoBehaviour
    {
        #region Attributes
        [System.Serializable]
        public struct PanelDeley
        {
            public string _nameElement;
            public Button _buttonPanel;
            public GameObject _panelEnabled;
            public GameObject _panelDesable;
            public float _delay;
            public bool _isUp;

        }
        [HideInInspector]public PanelDeley[] _configurePanelDeley;

        public GameObject _animationUp;
        public GameObject _animationDown;

        #endregion
       public  int _id;

        #region Unity Calls
        private void Awake()
        {
            foreach (var item in _configurePanelDeley)
            {
                _id++;
                item._buttonPanel.onClick.AddListener(() => StartCoroutine(IEDeleyPanel(_id-1 , _configurePanelDeley[_id-1]._isUp)));
            }
        }
        #endregion

        #region custom privat method
        IEnumerator IEDeleyPanel(int _iD , bool _isUp)
        {
            _configurePanelDeley[_iD]._panelDesable.SetActive(false);
            _configurePanelDeley[_iD]._panelEnabled.SetActive(false);

            if ( _isUp )
            {
                _animationUp.SetActive(true);
            }
            else
            {
                _animationDown.SetActive(true);
            }

            yield return new WaitForSeconds(_configurePanelDeley[_iD]._delay);

            if ( _isUp )
            {
                _animationUp.SetActive(false);
            }
            else
            {
                _animationDown.SetActive(false);
            }

            _configurePanelDeley[_iD]._panelDesable.SetActive(false);
            _configurePanelDeley[_iD]._panelEnabled.SetActive(true);
        }
        #endregion
    }
}
