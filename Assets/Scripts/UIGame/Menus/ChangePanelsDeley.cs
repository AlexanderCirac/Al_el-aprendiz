using UnityEditor;
using UnityEngine;
using UnityEngine.UI;


namespace Al.UIGame
{
    using Al.UIGame;
    using System.Collections;

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

        #region Unity Calls
        private void Awake()
        {
            for ( int i = 0 ; i < _configurePanelDeley.Length ; i++ )
            {
                int _id = i;
                _configurePanelDeley[i]._buttonPanel.onClick.AddListener(() => StartCoroutine(IEDeleyPanel(_id , _configurePanelDeley[_id]._isUp)));
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
