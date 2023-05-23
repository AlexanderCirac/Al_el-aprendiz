using UnityEngine.UI;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;


namespace AlexanderCA.ProMenu.Opciones
{
    using AlexanderCA.ProMenu.Enum;
    using AlexanderCA.ProMenu.Data;
    public class PrM_MultiOptionsController : PrM_Behaviour
    {
          #region Attributes
          //Vsync
          Toggle _vsyncToggle;
          bool _vsyncCurrent;
          bool _vsyncDefoult;
          //shadow
          Dropdown _shadowDropdown;
          int _shadowDefoult;
          int _shadowCurrent;
          //Resolution
          Dropdown _reslutionDropdown;
          int _currentResolutionIndex;
          int _currentDefoult;          
          //Grafics
          Dropdown _graficDropdown;
          int _currentGraficsIndex;
          int _graficsDefoult;          
          //Antialasing
          Dropdown _antialasingDropdown;
          int _currentAntialasingIndex;
          int _antialasingDefoult;          
          //Fps
          Dropdown _fpsDropdown;
          int _currentFpsIndex;
          int _fpsDefoult;
          //windowsMode
          Toggle _windowsToggle;
          bool _windowsCurrent;
          bool _windowsDefoult;
          // To apply change
          Button _resetButton; 
          public Button _aplicaionButton;
          bool   _isAutomatic;
    #endregion

          #region UnityCalls
          void Start() => Init();
          void Update() => UpadteUp();
          #endregion

          #region custom public Method     
          public void SetOptionsButtons(Button _resetButton, Button _aplicaionButton, bool _isAutomatic)
          {
                this._resetButton = _resetButton;
                this._aplicaionButton = _aplicaionButton;
                this._isAutomatic = _isAutomatic;
          }
          public void SetVsync(Toggle _vsyncToggle, bool _vsyncCurrent, bool _vsyncDefoult)
          {
              this._vsyncToggle = _vsyncToggle;
               PrM_DataPersistent _data = FindObjectOfType<PrM_DataPersistent>();
              if (this._vsyncToggle)
              {
                  this._vsyncToggle.isOn = _vsyncCurrent;
                  this._vsyncCurrent = _vsyncCurrent;
              }

              this._vsyncDefoult = _vsyncDefoult;

              if(_isAutomatic)
              this._vsyncToggle.onValueChanged.AddListener(ChangeOptionsToggle);

                
          }          
          public void SetWindowsMode(Toggle _windowsToggle, bool _windowsCurrent , bool _windowsDefoult)
          {
              this._windowsToggle = _windowsToggle;
               PrM_DataPersistent _data = FindObjectOfType<PrM_DataPersistent>();
            
              if (this._windowsToggle)
              {
                  this._windowsToggle.isOn = _windowsCurrent;
                  this._windowsCurrent = _windowsCurrent;
                  _optionsManager._windowsMode = _windowsCurrent;

              }

              this._windowsDefoult = _windowsDefoult;

              if(_isAutomatic)
                this._windowsToggle.onValueChanged.AddListener(ChangeOptionsToggle);
          }
          public void SetResolution(Dropdown _reslutionDropdown)
          {
               this._reslutionDropdown = _reslutionDropdown;
                if (this._reslutionDropdown)
                {
                      this._reslutionDropdown.ClearOptions();
                      List<string> _resolutionString = new List<string>();
                      for (int i = 0; i < Screen.resolutions.Length -1 ; i++)
                      {
                          string _resolution = Screen.resolutions[i].width + " x " + Screen.resolutions[i].height;
                          _resolutionString.Add(_resolution);
                          if(Screen.resolutions[i].width == Screen.width && Screen.resolutions[i].height == Screen.height)
                           {
                               _currentResolutionIndex = i;
                           }
                      }
                          Debug.Log("total de resoluciones" + _currentResolutionIndex);
                      this._reslutionDropdown.GetComponent<Dropdown>().AddOptions(_resolutionString);
                      PrM_DataPersistent _data = FindObjectOfType<PrM_DataPersistent>();
                      if(_data._isInstantiate && _data._currentResolutionIndex != 0 || _optionsManager._currentResolutionIndex != _data._currentResolutionIndex)
                      {

                      this._reslutionDropdown.value = _optionsManager._currentResolutionIndex;
                      _currentDefoult = _optionsManager._defoultResolutionIndex;
                      _currentResolutionIndex = _optionsManager._currentResolutionIndex;

                      }
                      else
                      {
                           this._reslutionDropdown.value = _currentResolutionIndex;
                          _currentDefoult = _currentResolutionIndex;
                          _optionsManager._currentResolutionIndex = _currentResolutionIndex;
                          _optionsManager._defoultResolutionIndex = _currentResolutionIndex;
                          _data._defoultResolutionIndex = _currentResolutionIndex;
                      }
                      this._reslutionDropdown.RefreshShownValue();

                      if(_isAutomatic)
                      this._reslutionDropdown.onValueChanged.AddListener(ChangeOptionsDropdown);
                }

          }
          public void SetCalidadSombras(Dropdown _shadowDropdown, e_calidadSombras _shadowCurrent, e_calidadSombras _shadowDefoult)
          {
              this._shadowDropdown = _shadowDropdown;
              if (this._shadowDropdown)
              {

                  List<string> m_DropOptions = new List<string> { "None", "low", "medium", "high", "veryHigh" };
                  this._shadowDropdown.GetComponent<Dropdown>().ClearOptions();
                  this._shadowDropdown.GetComponent<Dropdown>().AddOptions(m_DropOptions);
                  switch (_shadowCurrent)
                    {
                        case e_calidadSombras.None:
                          QualitySettings.shadows = ShadowQuality.Disable;
                          this._shadowDropdown.value = 0;
                          this._shadowCurrent = 0;
                          _optionsManager._shadowCurrent = e_calidadSombras.None;
                          break;
                        case e_calidadSombras.low:
                          QualitySettings.shadows = ShadowQuality.HardOnly;
                          this._shadowDropdown.value = 1;
                          this._shadowCurrent = 1;
                          _optionsManager._shadowCurrent = e_calidadSombras.low;
                          break;
                        case e_calidadSombras.medium:
                          QualitySettings.shadows = ShadowQuality.HardOnly;
                          this._shadowDropdown.value = 2;
                          this._shadowCurrent = 2;
                          _optionsManager._shadowCurrent = e_calidadSombras.medium;
                          break;
                        case e_calidadSombras.high:
                          QualitySettings.shadows = ShadowQuality.All;
                          this._shadowDropdown.value = 3;
                          this._shadowCurrent = 3;
                          _optionsManager._shadowCurrent = e_calidadSombras.high;
                          break;
                        case e_calidadSombras.veryHigh:
                          QualitySettings.shadows = ShadowQuality.All;
                          this._shadowDropdown.value = 4;
                          this._shadowCurrent = 4;
                          _optionsManager._shadowCurrent = e_calidadSombras.veryHigh;
                          break;
                  }                  
                  switch (_shadowDefoult)
                    {
                        case e_calidadSombras.None:
                          this._shadowDefoult = 0;
                          break;
                        case e_calidadSombras.low:
                          this._shadowDefoult = 1;
                          break;
                        case e_calidadSombras.medium:
                          this._shadowDefoult = 2;
                          break;
                        case e_calidadSombras.high:
                          this._shadowDefoult = 3;
                          break;
                        case e_calidadSombras.veryHigh:
                          this._shadowDefoult = 4;
                          break;
                  }
 
                  if(_isAutomatic)
                    this._shadowDropdown.onValueChanged.AddListener(ChangeOptionsDropdown);
              }
              
          }                 
          public void SetGrafics(Dropdown _graficDropdown, e_CalidadGrafica _graficCurrent, e_CalidadGrafica _graficDefoult)
          {
              this._graficDropdown = _graficDropdown;
              if (this._graficDropdown)
              {

                  List<string> m_DropOptions = new List<string> { "low", "medium", "high", "veryHigh "};
                  this._graficDropdown.GetComponent<Dropdown>().ClearOptions();
                  this._graficDropdown.GetComponent<Dropdown>().AddOptions(m_DropOptions);
                  switch (_graficCurrent)
                    {
                        case e_CalidadGrafica.low:
                          QualitySettings.SetQualityLevel (0);
                          this._graficDropdown.value = 0;
                          _currentGraficsIndex = 0;
                          _optionsManager._graficCurrent = e_CalidadGrafica.low;
                          break;
                        case e_CalidadGrafica.medium:
                          QualitySettings.SetQualityLevel (1);
                          this._graficDropdown.value = 1;
                          _currentGraficsIndex = 1;
                          _optionsManager._graficCurrent = e_CalidadGrafica.medium;
                          break;
                        case e_CalidadGrafica.high:
                          QualitySettings.SetQualityLevel (2);
                          this._graficDropdown.value = 2;
                          _currentGraficsIndex = 2;
                          _optionsManager._graficCurrent = e_CalidadGrafica.high;
                          break;
                        case e_CalidadGrafica.veryHigh:
                          QualitySettings.SetQualityLevel (3);
                          this._graficDropdown.value = 3;
                          _currentGraficsIndex = 3;
                          _optionsManager._graficCurrent = e_CalidadGrafica.veryHigh;
                          break;
                  }                  
                  switch (_graficDefoult)
                    {
                        case e_CalidadGrafica.low:
                          this._graficsDefoult = 0;
                          break;
                        case e_CalidadGrafica.medium:
                          this._graficsDefoult = 1;
                          break;
                        case e_CalidadGrafica.high:
                          this._graficsDefoult = 2;
                          break;
                        case e_CalidadGrafica.veryHigh:
                          this._graficsDefoult = 3;
                          break;
                  }
                 
                  if(_isAutomatic)
                    this._graficDropdown.onValueChanged.AddListener(ChangeOptionsDropdown);
              }

          }        
          public void SetAntialsaing(Dropdown _antialasingDropdown, e_Antialasing _antialasingCurrent, e_Antialasing _antialasingDefoult)
          {
              this._antialasingDropdown = _antialasingDropdown;
              if (this._antialasingDropdown)
              {

                  List<string> m_DropOptions = new List<string> { "Disable", "MultiSampling2X"," MultiSampling4X", "MultiSampling8X" };
                  this._antialasingDropdown.GetComponent<Dropdown>().ClearOptions();
                  this._antialasingDropdown.GetComponent<Dropdown>().AddOptions(m_DropOptions);
                  switch (_antialasingCurrent)
                    {
                        case e_Antialasing.Disable:
                          QualitySettings.antiAliasing = 0;
                          this._antialasingDropdown.value = 0;
                          _currentAntialasingIndex = 0;
                          _optionsManager._antialasingCurrent =  e_Antialasing.Disable;
                          break;
                        case e_Antialasing.MultiSampling2X:
                          QualitySettings.antiAliasing = 2;
                          this._antialasingDropdown.value = 1;
                          _currentAntialasingIndex = 1;
                          _optionsManager._antialasingCurrent =  e_Antialasing.MultiSampling2X;
                          break;
                        case e_Antialasing.MultiSampling4X:
                          QualitySettings.antiAliasing = 4;
                          this._antialasingDropdown.value = 2;
                          _currentAntialasingIndex = 2;
                          _optionsManager._antialasingCurrent =  e_Antialasing.MultiSampling4X;
                          break;
                        case e_Antialasing.MultiSampling8X:
                          QualitySettings.antiAliasing = 8;
                          this._antialasingDropdown.value = 3;
                          _currentAntialasingIndex = 3;
                          _optionsManager._antialasingCurrent =  e_Antialasing.MultiSampling8X;
                          break;
                  }                
                  switch (_antialasingDefoult)
                  {
                        case e_Antialasing.Disable:
                          this._antialasingDefoult = 0;
                          break;
                        case e_Antialasing.MultiSampling2X:
                          this._antialasingDefoult = 1;
                          break;
                        case e_Antialasing.MultiSampling4X:
                          this._antialasingDefoult = 2;
                          break;
                        case e_Antialasing.MultiSampling8X:
                          this._antialasingDefoult = 3;
                          break;
                  }
                 
                  if(_isAutomatic)
                    this._antialasingDropdown.onValueChanged.AddListener(ChangeOptionsDropdown);
              }

          }              
          public void SetFPS(Dropdown _fpsDropdown, e_FPS _fpsCurrent, e_FPS _fpsDefoult)
          {
              this._fpsDropdown = _fpsDropdown;
              if (this._fpsDropdown)
              {

                  List<string> m_DropOptions = new List<string> { "FPS30", "FPS60", "FPS180", "infinito" };
                  this._fpsDropdown.GetComponent<Dropdown>().ClearOptions();
                  this._fpsDropdown.GetComponent<Dropdown>().AddOptions(m_DropOptions);
                  switch (_fpsCurrent)
                    {
                        case e_FPS.FPS30:
                          Application.targetFrameRate = 30;
                          this._fpsDropdown.value = 0;
                          _currentFpsIndex = 0;
                          _optionsManager._fpsCurrent = e_FPS.FPS30;
                          break;
                        case e_FPS.FPS60:
                          Application.targetFrameRate = 60;
                          this._fpsDropdown.value = 1;
                          _currentFpsIndex = 1;
                          _optionsManager._fpsCurrent = e_FPS.FPS60;
                          break;
                        case e_FPS.FPS180:
                          Application.targetFrameRate = 180;
                          this._fpsDropdown.value = 2;
                          _currentFpsIndex = 2;
                          _optionsManager._fpsCurrent = e_FPS.FPS180;
                          break;
                        case e_FPS.infinito:
                          Application.targetFrameRate = 300;
                          this._fpsDropdown.value = 3;
                          _currentFpsIndex = 3;
                          _optionsManager._fpsCurrent = e_FPS.infinito;
                          break;
                  }                  
                  switch (_fpsDefoult)
                  {
                        case e_FPS.FPS30:
                          this._fpsDefoult = 0;
                          break;
                        case e_FPS.FPS60:
                          this._fpsDefoult = 1;
                          break;
                        case e_FPS.FPS180:
                          this._fpsDefoult = 2;
                          break;
                        case e_FPS.infinito:
                          this._fpsDefoult = 3;
                          break;
                  }

                  if(_isAutomatic)
                    this._fpsDropdown.onValueChanged.AddListener(ChangeOptionsDropdown);
              }
          }     
          #endregion

          #region custom private Method
          void Init()
          {
                if(_isApplyButton)
                   _aplicaionButton.onClick.AddListener(ChangeOptions);

                if(_resetButton)
                    _resetButton.onClick.AddListener(ResetOptions);

          }
          void UpadteUp()
          {
                AutoReset();
          }
          void ResetOptions()
          {
                if (_isAutomatic)
                {
                    //vsync
                    if (_vsyncToggle && _vsyncCurrent != _vsyncDefoult)
                    {
                          if(_vsyncToggle.isOn == true)
                             QualitySettings.vSyncCount = 1;

                          if(_vsyncToggle.isOn == false)
                             QualitySettings.vSyncCount = 0;
                      

                          _vsyncToggle.isOn = _vsyncDefoult;
                          _optionsManager._isVsync = _vsyncDefoult;
                          _vsyncCurrent = _vsyncDefoult;
                    }
                
                    //windows
                    if (_windowsToggle && _windowsCurrent != _windowsDefoult)
                    {
                          if(_windowsToggle.isOn == true)
                             Screen.fullScreen = true;

                          if(_windowsToggle.isOn == false)
                             Screen.fullScreen = false;
                      

                          _windowsToggle.isOn = _windowsDefoult;
                          _optionsManager._windowsMode = _windowsDefoult;
                          _windowsCurrent = _windowsDefoult;
                    }

                    //shadow
                    if(_shadowDropdown && _shadowCurrent != _shadowDefoult)
                    {
                            switch (_shadowDefoult)
                            {
                              case 0:
                                QualitySettings.shadows = ShadowQuality.Disable;
                                _shadowDropdown.value = 0;
                                _shadowCurrent  = 0;
                                _optionsManager._shadowCurrent = e_calidadSombras.None;
                                break;
                              case 1:
                                QualitySettings.shadows = ShadowQuality.HardOnly;
                                _shadowDropdown.value = 1;
                                _shadowCurrent  = 1;
                                _optionsManager._shadowCurrent = e_calidadSombras.low;
                                break;
                              case 2:
                                QualitySettings.shadows = ShadowQuality.HardOnly;
                                _shadowDropdown.value = 2;
                                _shadowCurrent  = 2;
                                _optionsManager._shadowCurrent = e_calidadSombras.medium;
                                break;
                              case 3:
                                QualitySettings.shadows = ShadowQuality.All;
                                _shadowDropdown.value = 3;
                                _shadowCurrent  = 3;
                                _optionsManager._shadowCurrent = e_calidadSombras.high;
                                break;
                              case 4:
                                QualitySettings.shadows = ShadowQuality.All;
                                _shadowDropdown.value = 4;
                                _shadowCurrent  = 4;
                                _optionsManager._shadowCurrent = e_calidadSombras.veryHigh;
                                break;                          
                            }
                    }

                    //resolution
                    if (_reslutionDropdown)
                    {
                        if(!_windowsCurrent)
                        Screen.SetResolution(Screen.resolutions[_currentDefoult].width, Screen.resolutions[_currentDefoult].height,true);                
                        else
                        Screen.SetResolution(Screen.resolutions[_currentDefoult].width, Screen.resolutions[_currentDefoult].height,false);
                        _currentResolutionIndex = _currentDefoult;
                        _optionsManager._currentResolutionIndex = _currentDefoult;
                         this._reslutionDropdown.value = _currentDefoult;

                    }

                    //Grafics
                     if(_graficDropdown && _currentGraficsIndex != _graficsDefoult)
                    {
                            switch (_graficsDefoult)
                            {
                              case 0:
                                QualitySettings.SetQualityLevel (0);
                                _graficDropdown.value = 0;
                                _currentGraficsIndex  = 0;
                                _optionsManager._graficCurrent = e_CalidadGrafica.low;
                                break;
                              case 1:
                                QualitySettings.SetQualityLevel (1);
                                _graficDropdown.value = 1;
                                _currentGraficsIndex  = 1;
                                _optionsManager._graficCurrent = e_CalidadGrafica.medium;
                                break;
                              case 2:
                                QualitySettings.SetQualityLevel (2);
                                _graficDropdown.value = 2;
                                _currentGraficsIndex  = 2;
                                _optionsManager._graficCurrent = e_CalidadGrafica.high;
                                break;
                              case 3:
                                QualitySettings.SetQualityLevel (3);
                                _graficDropdown.value = 3;
                                _currentGraficsIndex  = 3;
                                _optionsManager._graficCurrent = e_CalidadGrafica.veryHigh;
                                break;
                        
                            }
                    }

                     //Antialsing
                     if(_antialasingDropdown && _currentAntialasingIndex != _antialasingDefoult)
                    {
                            switch (_antialasingDefoult)
                            {
                              case 0:
                                QualitySettings.antiAliasing = 0;
                                _antialasingDropdown.value = 0;
                                _currentAntialasingIndex  = 0;
                                _optionsManager._antialasingCurrent = e_Antialasing.Disable;
                                break;
                              case 1:
                                QualitySettings.antiAliasing = 2;
                                _antialasingDropdown.value = 1;
                                _currentAntialasingIndex  = 1;
                                _optionsManager._antialasingCurrent = e_Antialasing.MultiSampling2X;
                                break;
                              case 2:
                                QualitySettings.antiAliasing = 4;
                                _antialasingDropdown.value = 2;
                                _currentAntialasingIndex  = 2;
                                _optionsManager._antialasingCurrent = e_Antialasing.MultiSampling4X;
                                break;
                              case 3:
                                QualitySettings.antiAliasing = 8;
                                _antialasingDropdown.value = 3;
                                _currentAntialasingIndex  = 3;
                                _optionsManager._antialasingCurrent = e_Antialasing.MultiSampling8X;
                                break;
                        
                            }
                    } 
                 
                     //FPS
                     if(_fpsDropdown && _currentFpsIndex != _fpsDefoult)
                      {
                              switch (_fpsDefoult)
                              {
                                case 0:
                                  Application.targetFrameRate = 30;
                                  _fpsDropdown.value = 0;
                                  _currentFpsIndex  = 0;
                                  _optionsManager._fpsCurrent = e_FPS.FPS30;
                                  break;
                                case 1:
                            
                                  Application.targetFrameRate = 60;
                                  _fpsDropdown.value = 1;
                                  _currentFpsIndex  = 1;
                                  _optionsManager._fpsCurrent = e_FPS.FPS60;
                                  break;
                                case 2:
                            
                                  Application.targetFrameRate = 180;
                                  _fpsDropdown.value = 2;
                                  _currentFpsIndex  = 2;
                                  _optionsManager._fpsCurrent = e_FPS.FPS180;
                                  break;
                                case 3:
                            
                                  Application.targetFrameRate = 300;
                                  _fpsDropdown.value = 3;
                                  _currentFpsIndex  = 3;
                                  _optionsManager._fpsCurrent = e_FPS.infinito;
                                  break;
                        
                              }
                      }
                }
                else
                {
                    //vsync
                    if (_vsyncToggle && _vsyncCurrent != _vsyncDefoult)
                          _vsyncToggle.isOn = _vsyncDefoult;
                
                    //windows
                    if (_windowsToggle && _windowsCurrent != _windowsDefoult)
                          _windowsToggle.isOn = _windowsDefoult;

                    //shadow
                    if(_shadowDropdown && _shadowCurrent != _shadowDefoult)
                        switch (_shadowDefoult)
                        {
                          case 0:
                            _shadowDropdown.value = 0;
                            break;
                          case 1:
                            _shadowDropdown.value = 1;
                            break;
                          case 2:
                            _shadowDropdown.value = 2;
                            break;
                          case 3:
                            _shadowDropdown.value = 3;
                            break;
                          case 4:
                            _shadowDropdown.value = 4;
                            break;                          
                        }

                    //resolution
                    if (_reslutionDropdown)
                          this._reslutionDropdown.value = _currentDefoult;


                    //Grafics
                      if(_graficDropdown && _currentGraficsIndex != _graficsDefoult)
                          switch (_graficsDefoult)
                          {
                            case 0:
                              _graficDropdown.value = 0;
                              break;
                            case 1:
                              _graficDropdown.value = 1;
                              break;
                            case 2:
                              _graficDropdown.value = 2;
                              break;
                            case 3:
                              _graficDropdown.value = 3;
                              break;
                          }

                      //Antialsing
                      if(_antialasingDropdown && _currentAntialasingIndex != _antialasingDefoult)
                          switch (_antialasingDefoult)
                          {
                            case 0:
                              _antialasingDropdown.value = 0;
                              break;
                            case 1:
                              _antialasingDropdown.value = 1;
                              break;
                            case 2:
                              _antialasingDropdown.value = 2;
                              break;
                            case 3:
                              _antialasingDropdown.value = 3;
                              break;
                        
                          }

                      //FPS
                      if(_fpsDropdown && _currentFpsIndex != _fpsDefoult)
                          switch (_fpsDefoult)
                          {
                            case 0:
                              _fpsDropdown.value = 0;
                              break;
                            case 1:
                              _fpsDropdown.value = 1;
                              break;
                            case 2:
                              _fpsDropdown.value = 2;
                              break;
                            case 3:
                              _fpsDropdown.value = 3;
                              break;
                        
                          }
                }

          }

          void ChangeOptions( )
          {
     
                //vsync
                if(_vsyncToggle && _vsyncCurrent != _vsyncToggle.isOn)
                {
                      if(_vsyncToggle.isOn == true)
                          QualitySettings.vSyncCount = 1;

                      if(_vsyncToggle.isOn == false)
                          QualitySettings.vSyncCount = 0;

                    
                      _optionsManager._isVsync = _vsyncToggle.isOn;
                      _vsyncCurrent = _vsyncToggle.isOn;
                }    
                
                //Windows
                if(_windowsToggle && _windowsCurrent != _windowsToggle.isOn)
                {
                      if(_windowsToggle.isOn == true)
                          Screen.fullScreen = true;

                      if(_windowsToggle.isOn == false)
                          Screen.fullScreen = false;


                    
                      _optionsManager._windowsMode = _windowsToggle.isOn;
                      _windowsCurrent = _windowsToggle.isOn;
                }

                //shadow
                if(_shadowDropdown && _shadowCurrent != _shadowDropdown.value)
                {
                        switch (_shadowDropdown.value)
                        {
                          case 0:
                            QualitySettings.shadows = ShadowQuality.Disable;
                            _shadowDropdown.value = 0;
                            _shadowCurrent  = 0;
                            _optionsManager._shadowCurrent = e_calidadSombras.None;
                            break;
                          case 1:
                            QualitySettings.shadows = ShadowQuality.HardOnly;
                            _shadowDropdown.value = 1;
                            _shadowCurrent  = 1;
                            _optionsManager._shadowCurrent = e_calidadSombras.low;
                            break;
                          case 2:
                            QualitySettings.shadows = ShadowQuality.HardOnly;
                            _shadowDropdown.value = 2;
                            _shadowCurrent  = 2;
                            _optionsManager._shadowCurrent = e_calidadSombras.medium;
                            break;
                          case 3:
                            QualitySettings.shadows = ShadowQuality.All;
                            _shadowDropdown.value = 3;
                            _shadowCurrent  = 3;
                            _optionsManager._shadowCurrent = e_calidadSombras.high;
                            break;
                          case 4:
                            QualitySettings.shadows = ShadowQuality.All;
                            _shadowDropdown.value = 4;
                            _shadowCurrent  = 4;
                            _optionsManager._shadowCurrent = e_calidadSombras.veryHigh;
                            break;
                        }
                }

                //resolution
                if (_reslutionDropdown)
                {
                    if(!_windowsCurrent)
                    Screen.SetResolution(Screen.resolutions[_currentDefoult].width, Screen.resolutions[_currentDefoult].height,true);                
                    else
                    Screen.SetResolution(Screen.resolutions[_currentDefoult].width, Screen.resolutions[_currentDefoult].height,false);
                    _currentResolutionIndex = this._reslutionDropdown.value;
                    _optionsManager._currentResolutionIndex = this._reslutionDropdown.value;
                }

                //Grafics
                if(_graficDropdown && _currentGraficsIndex != _graficDropdown.value)
                {
                        switch (_graficDropdown.value)
                        {
                          case 0:
                            QualitySettings.SetQualityLevel (0);
                            _graficDropdown.value = 0;
                            _currentGraficsIndex  = 0;
                            _optionsManager._graficCurrent = e_CalidadGrafica.low;
                            break;
                          case 1:
                              QualitySettings.SetQualityLevel (1);
                            _graficDropdown.value = 1;
                            _currentGraficsIndex  = 1;
                            _optionsManager._graficCurrent = e_CalidadGrafica.medium;
                            break;
                          case 2:
                            QualitySettings.SetQualityLevel (2);
                            _graficDropdown.value = 2;
                            _currentGraficsIndex  = 2;
                            _optionsManager._graficCurrent = e_CalidadGrafica.high;
                            break;
                          case 3:
                            QualitySettings.SetQualityLevel (3);
                            _graficDropdown.value = 3;
                            _currentGraficsIndex  = 3;
                            _optionsManager._graficCurrent = e_CalidadGrafica.veryHigh;
                            break;
                        }
                } 
                
                //Antialasing
                if(_antialasingDropdown && _currentAntialasingIndex != _antialasingDropdown.value)
                {
                        switch (_antialasingDropdown.value)
                        {
                          case 0:
                            QualitySettings.antiAliasing = 0;
                            _antialasingDropdown.value = 0;
                            _currentAntialasingIndex  = 0;
                            _optionsManager._antialasingCurrent = e_Antialasing.Disable;
                            break;
                          case 1:
                            QualitySettings.antiAliasing = 2;
                            _antialasingDropdown.value = 1;
                            _currentAntialasingIndex  = 1;
                            _optionsManager._antialasingCurrent = e_Antialasing.MultiSampling2X;
                            break;
                          case 2:
                            QualitySettings.antiAliasing = 4;
                            _antialasingDropdown.value = 2;
                            _currentAntialasingIndex  = 2;
                            _optionsManager._antialasingCurrent = e_Antialasing.MultiSampling4X;
                            break;
                          case 3:
                            QualitySettings.antiAliasing = 8;
                            _antialasingDropdown.value = 3;
                            _currentAntialasingIndex  = 3;
                            _optionsManager._antialasingCurrent = e_Antialasing.MultiSampling8X;
                            break;
                        }
                }               
                
                //FPS
                if(_fpsDropdown && _currentFpsIndex != _fpsDropdown.value)
                {
                        switch (_fpsDropdown.value)
                        {
                          case 0:
                            
                            _fpsDropdown.value = 0;
                            _currentFpsIndex  = 0;
                            _optionsManager._fpsCurrent = e_FPS.FPS30;
                            break;
                          case 1:
                            
                            _fpsDropdown.value = 1;
                            _currentFpsIndex  = 1;
                            _optionsManager._fpsCurrent = e_FPS.FPS60;
                            break;
                          case 2:
                            
                            _fpsDropdown.value = 2;
                            _currentFpsIndex  = 2;
                            _optionsManager._fpsCurrent = e_FPS.FPS180;
                            break;
                          case 3:
                            
                            _fpsDropdown.value = 3;
                            _currentFpsIndex  = 3;
                            _optionsManager._fpsCurrent = e_FPS.infinito;
                            break;
                        }
                }
          } 
          void ChangeOptionsToggle(bool val)
          {
     
                //vsync
                if(_vsyncToggle && _vsyncCurrent != _vsyncToggle.isOn)
                {
                      if(_vsyncToggle.isOn == true)
                          QualitySettings.vSyncCount = 1;

                      if(_vsyncToggle.isOn == false)
                          QualitySettings.vSyncCount = 0;

                    
                      _optionsManager._isVsync = _vsyncToggle.isOn;
                      _vsyncCurrent = _vsyncToggle.isOn;
                }    
                
                //Windows
                if(_windowsToggle && _windowsCurrent != _windowsToggle.isOn)
                {
                      if(_windowsToggle.isOn == true)
                          Screen.fullScreen = true;

                      if(_windowsToggle.isOn == false)
                          Screen.fullScreen = false;


                    
                      _optionsManager._windowsMode = _windowsToggle.isOn;
                      _windowsCurrent = _windowsToggle.isOn;
                }
          }
          void ChangeOptionsDropdown(int val)
          {
                //shadow
                if(_shadowDropdown && _shadowCurrent != _shadowDropdown.value)
                {
                        switch (_shadowDropdown.value)
                        {
                          case 0:
                            QualitySettings.shadows = ShadowQuality.Disable;
                            _shadowDropdown.value = 0;
                            _shadowCurrent  = 0;
                            _optionsManager._shadowCurrent = e_calidadSombras.None;
                            break;
                          case 1:
                            QualitySettings.shadows = ShadowQuality.HardOnly;
                            _shadowDropdown.value = 1;
                            _shadowCurrent  = 1;
                            _optionsManager._shadowCurrent = e_calidadSombras.low;
                            break;
                          case 2:
                            QualitySettings.shadows = ShadowQuality.HardOnly;
                            _shadowDropdown.value = 2;
                            _shadowCurrent  = 2;
                            _optionsManager._shadowCurrent = e_calidadSombras.medium;
                            break;
                          case 3:
                            QualitySettings.shadows = ShadowQuality.All;
                            _shadowDropdown.value = 3;
                            _shadowCurrent  = 3;
                            _optionsManager._shadowCurrent = e_calidadSombras.high;
                            break;
                          case 4:
                            QualitySettings.shadows = ShadowQuality.All;
                            _shadowDropdown.value = 4;
                            _shadowCurrent  = 4;
                            _optionsManager._shadowCurrent = e_calidadSombras.veryHigh;
                            break;
                        }
                }

                //resolution
                if (_reslutionDropdown)
                {
                    if(!_windowsCurrent)
                    Screen.SetResolution(Screen.resolutions[_currentDefoult].width, Screen.resolutions[_currentDefoult].height,true);                
                    else
                    Screen.SetResolution(Screen.resolutions[_currentDefoult].width, Screen.resolutions[_currentDefoult].height,false);
                    _currentResolutionIndex = this._reslutionDropdown.value;
                    _optionsManager._currentResolutionIndex = this._reslutionDropdown.value;
                }

                //Grafics
                if(_graficDropdown && _currentGraficsIndex != _graficDropdown.value)
                {
                        switch (_graficDropdown.value)
                        {
                          case 0:
                            QualitySettings.SetQualityLevel (0);
                            _graficDropdown.value = 0;
                            _currentGraficsIndex  = 0;
                            _optionsManager._graficCurrent = e_CalidadGrafica.low;
                            break;
                          case 1:
                              QualitySettings.SetQualityLevel (1);
                            _graficDropdown.value = 1;
                            _currentGraficsIndex  = 1;
                            _optionsManager._graficCurrent = e_CalidadGrafica.medium;
                            break;
                          case 2:
                            QualitySettings.SetQualityLevel (2);
                            _graficDropdown.value = 2;
                            _currentGraficsIndex  = 2;
                            _optionsManager._graficCurrent = e_CalidadGrafica.high;
                            break;
                          case 3:
                            QualitySettings.SetQualityLevel (3);
                            _graficDropdown.value = 3;
                            _currentGraficsIndex  = 3;
                            _optionsManager._graficCurrent = e_CalidadGrafica.veryHigh;
                            break;
                        }
                } 
                
                //Antialasing
                if(_antialasingDropdown && _currentAntialasingIndex != _antialasingDropdown.value)
                {
                        switch (_antialasingDropdown.value)
                        {
                          case 0:
                            QualitySettings.antiAliasing = 0;
                            _antialasingDropdown.value = 0;
                            _currentAntialasingIndex  = 0;
                            _optionsManager._antialasingCurrent = e_Antialasing.Disable;
                            break;
                          case 1:
                            QualitySettings.antiAliasing = 2;
                            _antialasingDropdown.value = 1;
                            _currentAntialasingIndex  = 1;
                            _optionsManager._antialasingCurrent = e_Antialasing.MultiSampling2X;
                            break;
                          case 2:
                            QualitySettings.antiAliasing = 4;
                            _antialasingDropdown.value = 2;
                            _currentAntialasingIndex  = 2;
                            _optionsManager._antialasingCurrent = e_Antialasing.MultiSampling4X;
                            break;
                          case 3:
                            QualitySettings.antiAliasing = 8;
                            _antialasingDropdown.value = 3;
                            _currentAntialasingIndex  = 3;
                            _optionsManager._antialasingCurrent = e_Antialasing.MultiSampling8X;
                            break;
                        }
                }               
                
                //FPS
                if(_fpsDropdown && _currentFpsIndex != _fpsDropdown.value)
                {
                        switch (_fpsDropdown.value)
                        {
                          case 0:
                            
                            _fpsDropdown.value = 0;
                            _currentFpsIndex  = 0;
                            _optionsManager._fpsCurrent = e_FPS.FPS30;
                            break;
                          case 1:
                            
                            _fpsDropdown.value = 1;
                            _currentFpsIndex  = 1;
                            _optionsManager._fpsCurrent = e_FPS.FPS60;
                            break;
                          case 2:
                            
                            _fpsDropdown.value = 2;
                            _currentFpsIndex  = 2;
                            _optionsManager._fpsCurrent = e_FPS.FPS180;
                            break;
                          case 3:
                            
                            _fpsDropdown.value = 3;
                            _currentFpsIndex  = 3;
                            _optionsManager._fpsCurrent = e_FPS.infinito;
                            break;
                        }
                }
          }
          
          void AutoReset()
          {
              if (_isActiveSelf)
              {
                    if(_fpsDropdown && _fpsDropdown.value != _currentFpsIndex)
                        _fpsDropdown.value = _currentFpsIndex;
                    if(_antialasingDropdown && _antialasingDropdown.value != _currentAntialasingIndex)
                        _antialasingDropdown.value = _currentAntialasingIndex;
                    if(_graficDropdown && _graficDropdown.value != _currentGraficsIndex)
                        _graficDropdown.value = _currentGraficsIndex;
                    if(this._reslutionDropdown && this._reslutionDropdown.value != _currentResolutionIndex)
                        this._reslutionDropdown.value = _currentResolutionIndex;
                    if(_shadowDropdown && _shadowDropdown.value != _shadowCurrent)
                        _shadowDropdown.value = _shadowCurrent;
                    if(this._windowsToggle && this._windowsToggle.isOn != _windowsCurrent)
                        this._windowsToggle.isOn = _windowsCurrent;
                    if(_vsyncToggle && _vsyncToggle.isOn != _vsyncCurrent)
                        _vsyncToggle.isOn = _vsyncCurrent;
              }
          }
          bool _isApplyButton { get => (_aplicaionButton && !_isAutomatic); }
          bool _isActiveSelf { get => ((_fpsDropdown &&  !_fpsDropdown.gameObject.activeSelf)
                                    || (_antialasingDropdown && !_antialasingDropdown.gameObject.activeInHierarchy) 
                                    || (_graficDropdown &&  !_graficDropdown.gameObject.activeInHierarchy) 
                                    || (_reslutionDropdown &&  !_reslutionDropdown.gameObject.activeInHierarchy) 
                                    || (_shadowDropdown &&  !_shadowDropdown.gameObject.activeInHierarchy) 
                                    || (_windowsToggle && !_windowsToggle.gameObject.activeInHierarchy) 
                                    || (_vsyncToggle &&  !_vsyncToggle.gameObject.activeInHierarchy)); }
          #endregion


    }
}
