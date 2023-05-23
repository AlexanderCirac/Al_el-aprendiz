using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AlexanderCA.ProMenu.Opciones
{
    public class PrM_ZurdoController : PrM_Behaviour
  {

        #region Attributes
        Toggle _zurdoToggle;
        //bool _zurdoBool = false;
        GameObject _zurdoGameObject;
        GameObject _diestroGameObject;
        #endregion

        #region Unity Calls
        void Start() => Init();
        #endregion

        #region  custom public method
        public void SetOptionZurdo(Toggle _zurdoToggle, GameObject _zurdoGameObject, GameObject _diestroGameObject)
        {
              this._zurdoToggle = _zurdoToggle;
              this._zurdoGameObject = _zurdoGameObject;
              this._diestroGameObject = _diestroGameObject;
        }
        #endregion 
    
        #region  custom private method
        void Init()
        {
            if (_zurdoToggle)
            {
                _zurdoToggle.isOn = _optionsManager._isLeftHand;
                _zurdoToggle.onValueChanged.AddListener(delegate { Change(_zurdoToggle); });
                _zurdoGameObject.SetActive(_optionsManager._isLeftHand);
                _diestroGameObject.SetActive(!_optionsManager._isLeftHand);
            }else
            {
                _zurdoGameObject.SetActive(_optionsManager._isLeftHand);
                _diestroGameObject.SetActive(!_optionsManager._isLeftHand);
            }

        }
          
        void Change(Toggle _b)
        {
            if (_b.isOn)
            {
                _zurdoGameObject.SetActive(true);
                _diestroGameObject.SetActive(false);                
            }
            else
            {
                _zurdoGameObject.SetActive(false);
                _diestroGameObject.SetActive(true);
            }

            _optionsManager._isLeftHand = _b.isOn;
        }
        #endregion 
    }
}
