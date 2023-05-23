using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AlexanderCA.ProMenu.Data
{
  using AlexanderCA.ProMenu.Enum;
  public class PrM_DataPersistent : PrM_Behaviour
  {
      #region Attribute
      internal int _idLoadLevel;
      internal float _overallBrightnessFloat;
      internal float _brightFloat;
      internal float _contrastFloat;
      internal bool _isVsync;
      internal e_calidadSombras _shadowCurrent;
      internal e_CalidadGrafica _graficCurrent;
      internal e_Antialasing _antialasingCurrent;
      internal e_FPS _fpsCurrent;
      internal bool _isLeftHand;
      internal int _currentResolutionIndex;
      internal int _defoultResolutionIndex;
      public List<float> _soundFloat;
      internal bool _windowsMode;
      ////singlenton
      [HideInInspector]public static PrM_DataPersistent _instance;
      internal bool _isInstantiate = false;
      #endregion

    #region Unity Calls
    void Awake() => Init();
    void Start() => Invoke(nameof(ToCheck), 0.01f);
      void Update() => PersistenLoad();
    #endregion

    #region custom public methods
    #endregion

    #region custom private methods
        void Init()
        {
            //Persistencia
            if (_instance != null)
                Destroy(gameObject);
            else
            {
                _instance = this;
            }
            DontDestroyOnLoad(this.transform.gameObject); 
        }         
    
        void PersistenLoad()
        {

            if (_optionsManager._isloadData)
            {
              //bright general
              _overallBrightnessFloat = _optionsManager._overallBrightnessFloat != _overallBrightnessFloat ? _optionsManager._overallBrightnessFloat : _overallBrightnessFloat;

              //bright camera
              _brightFloat = _optionsManager._brightFloat != _brightFloat ? _optionsManager._brightFloat : _brightFloat;

              //contrast camera
              _contrastFloat = _optionsManager._contrastFloat != _contrastFloat ? _optionsManager._contrastFloat : _contrastFloat;

              //leftHanded
              _isLeftHand = _optionsManager._isLeftHand != _isLeftHand ? _optionsManager._isLeftHand : _isLeftHand;

              //Sound
              _soundFloat = _optionsManager._soundFloat != _soundFloat ? _optionsManager._soundFloat : _soundFloat;

               //Vsync 
               _isVsync = _isVsync != _optionsManager._isVsync ? _optionsManager._isVsync : _isVsync;                          
        
                //Shadow 
               _shadowCurrent = _shadowCurrent != _optionsManager._shadowCurrent ? _optionsManager._shadowCurrent : _shadowCurrent;                
                
                //Resolution
               _currentResolutionIndex = _currentResolutionIndex != _optionsManager._currentResolutionIndex ? _optionsManager._currentResolutionIndex : _currentResolutionIndex;

              //windows 
               _windowsMode = _windowsMode != _optionsManager._windowsMode ? _optionsManager._windowsMode : _windowsMode;  
        
                //Grafics 
               _graficCurrent = _graficCurrent != _optionsManager._graficCurrent ? _optionsManager._graficCurrent : _graficCurrent;                
        
              //Antialasing 
               _antialasingCurrent = _antialasingCurrent != _optionsManager._antialasingCurrent ? _optionsManager._antialasingCurrent : _antialasingCurrent;              
        
                //FPS 
               _fpsCurrent = _fpsCurrent != _optionsManager._fpsCurrent ? _optionsManager._fpsCurrent : _fpsCurrent;

            }
        }
        void ToCheck()
        {
            _isInstantiate = true;
        } 
    #endregion
  }
}
