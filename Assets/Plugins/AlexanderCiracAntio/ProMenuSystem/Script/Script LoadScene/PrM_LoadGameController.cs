using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.ComponentModel;

namespace AlexanderCA.ProMenu.LoadBar
{
    using AlexanderCA.ProMenu.Enum;
  using System.Collections;

  public class PrM_LoadGameController : PrM_Behaviour
    {
        #region Attribute
        LoadBarEnmu _loadBarEnum; // TODO hacer que el boton de cargar nivel si tiene de cargar nivel lo que cargara sera la pantalla de load level
        int _iDMainLoadBar;
        int _loadLevelInt;
        //Aviso
        AudioSource _audioAvisoBar;
        CanvasRenderer _panelAvisoBar;
        //avance
        bool _isInternalBar = false;
        Slider _scrollLoadBar;
        //ending 
        bool _isEndInternalBar = false;
        bool _isEndbuttonBar = false;
        Button _buttonEndBar;
        KeyCode _keyCodeEndBar;
        joystick _joystickEndBar;
        #endregion      
      
        #region Unit yCalls
        void Start() => Init();
        #endregion      
    
        #region custom public methods
        public void SetFunctionLoadBar(LoadBarEnmu _loadBarEnum = LoadBarEnmu.none, int _iDMainLoadBar = 0)
        {
            this._loadBarEnum = _loadBarEnum;
            this._iDMainLoadBar = _iDMainLoadBar;
        }      
        public void SetAdLoadBar(AudioSource _audioAvisoBar, CanvasRenderer _panelAvisoBar)
        {
            this._audioAvisoBar = _audioAvisoBar;
            this._panelAvisoBar = _panelAvisoBar;
        }      
        public void SetSeeLoadBar(bool _isInternalBar, Slider _scrollLoadBar)
        {
            this._isInternalBar = _isInternalBar;
            this._scrollLoadBar = _scrollLoadBar;
        }      
        public void SetEndedLoadBar(bool _isEndInternalBar, Button _buttonEndBar, KeyCode _keyCodeEndBar, joystick _joystickEndBar)
        {
            this._isEndInternalBar = _isEndInternalBar;
            this._buttonEndBar = _buttonEndBar;
            this._keyCodeEndBar = _keyCodeEndBar;
            this._joystickEndBar = _joystickEndBar;
        }

        public void NewLevelLoadingBar(int _idLevel)
        {
              _dataPersiten._idLoadLevel = _idLevel;
              SceneManager.LoadScene (_iDMainLoadBar);
        }
        #endregion      
    
        #region custom private methods
        void Init()
        {
            _iDMainLoadBar = _iDMainLoadBar == 0 ? _iDMainLoadBar: -1;
            if(_audioAvisoBar)
               _audioAvisoBar.gameObject.SetActive( false);          
            if(_panelAvisoBar)
               _panelAvisoBar.gameObject.SetActive(false);            
            if(_buttonEndBar)
               _buttonEndBar.gameObject.SetActive(false);

            if (_scrollLoadBar)
            {
                _scrollLoadBar.value = 0;
            }

            _buttonEndBar?.onClick.AddListener(() => _isEndbuttonBar = true);

            if(_loadBarEnum == LoadBarEnmu.CreateLoadBar)
            {
                Time.timeScale = 1;
                Invoke(nameof(readLevel),0.9f);

            }
        }      
        void readLevel()
        {
              _loadLevelInt = _dataPersiten._idLoadLevel;
              StartCoroutine (ControllLoadBar());
        }
        IEnumerator ControllLoadBar()
        {
              UnityEngine.AsyncOperation m_gamelevel = SceneManager.LoadSceneAsync(_loadLevelInt);
              m_gamelevel.allowSceneActivation = false;
              while (!m_gamelevel.isDone)
              {
                  float progress = Mathf.Clamp01(m_gamelevel.progress / 0.9f);
                  if (_isAutomaticNot && m_gamelevel.progress <= 0.9f)
                  {
                       _scrollLoadBar.value = progress;
                  }                
                  if((m_gamelevel.progress >= 0.88f))
                  {    
                       if(_audioAvisoBar)
                          _audioAvisoBar.mute = false;

                       if(_panelAvisoBar)
                          _panelAvisoBar.gameObject.SetActive(true);

                       if(_buttonEndBar)
                          _buttonEndBar.gameObject.SetActive(true);

                       if(_isAutomaticNot)
                          _scrollLoadBar.value = 1;

                        if (_isEndingLoadBar )
                        {
                          m_gamelevel.allowSceneActivation = true;
                        }
                  }
                  yield return null;
              }
        }
     
        static string GetPrettyName(System.Enum e)
        {
          var nm = e.ToString();
          var tp = e.GetType();
          var field = tp.GetField(nm);
          var attrib = System.Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;

          if (attrib != null)
            return attrib.Description;
          else
            return nm;
        } 

        bool _isEndingLoadBar
        {
            get => (_keyCodeEndBar != KeyCode.None && Input.GetKeyDown(_keyCodeEndBar) || (_joystickEndBar != joystick.None && Input.GetKeyDown(GetPrettyName(_joystickEndBar))) || _isEndInternalBar == true || _isEndbuttonBar == true);
        }

        bool _isAutomaticNot
          {
              get => (!_isInternalBar && _scrollLoadBar);
          }
        #endregion
    }
}
