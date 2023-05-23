using System.Collections.Generic;
using UnityEngine;

namespace AlexanderCA.ProMenu.Opciones
{
    using AlexanderCA.ProMenu.Data;
    using AlexanderCA.ProMenu.Enum;
    using UnityEngine.SceneManagement;

    public class PrM_OptGameManager : PrM_Behaviour
    {

          #region Attributes 
          internal  float  _overallBrightnessFloat;
          /*[HideInInspector]*/ public List<float> _soundFloat;
          internal  float  _brightFloat ,_contrastFloat;
          internal  bool  _isLeftHand;
          internal  bool  _isloadData;
          internal  bool  _isVsync;
          internal  bool _windowsMode;
          internal  e_calidadSombras   _shadowCurrent;
          internal  e_CalidadGrafica   _graficCurrent;
          internal  e_Antialasing   _antialasingCurrent;
          internal  e_FPS   _fpsCurrent;
          internal  int _currentResolutionIndex;
          internal  int _defoultResolutionIndex;
        
          //Get Data
          internal PrM_DataPersistent _data;

        public PrM_OptionsInfo _explication;
        public Contenido contenido;
        GameObject _optionControlle;
        GameObject _DataOptionsPersisten;
        bool _isDataOptionsPersisten;
        #endregion

        #region Option Content

        [System.Serializable]
        public class Contenido
        {
          [Header("Español: ¿Quieres colocar un controlador de brillo general?", order = 0)]
          [Space(-10, order = 1)]
          [Header("English:Do you want to place a general brightness controller? ", order = 2)]
          [Space(5, order = 3)]
          public PrM_GeneralBrightnessInfo _option_0;
          [Header("Español:¿Quieres colocar un controlador para el volumen?", order = 4)]
          [Space(-10, order = 5)]
          [Header("English:Do you want to place a controller for the volume?", order = 6)]
          [Space(5, order = 7)]
          public PrM_SoundInfo _option_1;
          [Header("Español:¿Quieres colocar un controlador de contraste y brillo?", order = 8)]
          [Space(-10, order = 9)]
          [Header("English:Do you want to place a contrast and bright controller?", order = 10)]
          [Space(5, order = 11)]
          public PrM_ContrastInfo _option_2;
          [Header("Español:¿Quieres poner opciones gráficas?", order = 20)]
          [Space(-10, order = 21)]
          [Header("English:Do you want to put graphic options?", order = 22)]
          [Space(5, order = 24)]
          public PrM_MultiOptionsInfo _option_3;
          [Header("Español:¿Quieres colocar una opción para zurdos?", order = 25)]
          [Space(-10, order = 26)]
          [Header("English:Do you want to place a left-handed option?", order = 27)]
          [Space(5, order = 28)]
          public PrM_ZurdoInfo _option_4;
        }
        #endregion

        #region UnityCalls
        void Awake() => Init();
        void Start() => Invoke(nameof(AddMultiOptions), .001f);
        #endregion

        #region custom private methods
        void Init()
        {
            if (!_optionControlle)
            {
              GameObject _optionControlle = new GameObject();
              _optionControlle.name = "PrM_OptGameController";
              this._optionControlle = _optionControlle;
            }
            AddDataOptionsRecurrent();
            FirstLoadData();
            ToAddGeneralBrightness();
            ToAddSounds();
            ToAddContAndBright();
            AddZurdo();
        }

        /// <summary>
        /// Add controller overall brightness 
        /// </summary>
        void ToAddGeneralBrightness()
        {
          PrM_GeneralBrightnessInfo _brightness = contenido._option_0;
          if (_brightness.m_Contenido._brightnessPanel)
          {
              GameObject m_PanelBrillo = new GameObject();
              m_PanelBrillo.name = "PrM_OverallBrightnessController";
              m_PanelBrillo.transform.parent = _brightness.m_Contenido._brightnessPanel.gameObject.transform;
              m_PanelBrillo.AddComponent<PrM_GeneralBrightnessCroller>();
              if(_data._isInstantiate && _data._overallBrightnessFloat != _brightness.m_Contenido._brightnesInt || _overallBrightnessFloat != _data._overallBrightnessFloat)
                m_PanelBrillo.GetComponent<PrM_GeneralBrightnessCroller>().SetDateOption0(_brightness.m_Contenido._brightnesScrollbar, _overallBrightnessFloat);
              else
                m_PanelBrillo.GetComponent<PrM_GeneralBrightnessCroller>().SetDateOption0(_brightness.m_Contenido._brightnesScrollbar, _brightness.m_Contenido._brightnesInt);
          }
        }
          
        /// <summary>
        /// Add sould Controller
        /// </summary>
        void ToAddSounds()
        {
          PrM_SoundInfo.Opcion2Sonido _audio = contenido._option_1.m_Contenido;
          for (int i = 0; i <= _audio.m_Sonido.Length-1; i++)
          {
            PrM_SoundInfo.Audioss _arraySound = _audio.m_Sonido[i];
            //Add Sound option
            if (_arraySound._audioSource.Length != 0)
            { 
              GameObject m_audioControll = new GameObject();
              m_audioControll.name = _arraySound._nameElement != "" ? "PrM_SoundController_" + _arraySound._nameElement : "PrM_SoundController_" + i;
              m_audioControll.transform.parent = _optionControlle.transform;
              m_audioControll.AddComponent<PrM_AudioController>();
              if(_data._soundFloat == null)
              _soundFloat.Add ( _arraySound._soundFloat);
              m_audioControll.GetComponent<PrM_AudioController>().SetSoundController(_arraySound._audioSource, _arraySound._soundScrollbar, i, _soundFloat[i]);
            }
            else
              contenido._option_1.GetErrorSound(i);

          }
        }

        /// <summary>
        /// Add contrast and bright camera controller
        /// </summary>
        void ToAddContAndBright()
        {
            PrM_ContrastInfo _contrast = contenido._option_2;
            PrM_ContrastInfo.ContrasteContenido1 _content = contenido._option_2._content;
          
            if (_contrast._content._camera.Length != 0)
            {
                for (int i =0; i < _contrast._content._camera.Length; i++)
                {
                    _contrast._content._camera[i].gameObject.AddComponent<PrM_CameraContrAndBright>();
                    _contrast._content._camera[i].gameObject.GetComponent<PrM_CameraContrAndBright>().SetCameraContrAndBright(_content._brightFloat, _content._contrastFloat, _content._contrastScrollbar, _content._brightScrollbar);

                }
            }
        }

        /// <summary>
        /// Add different graphics drivers
        /// </summary>
        void AddMultiOptions()
        {

             GameObject _multiOptionsControll = new GameObject();
             _multiOptionsControll.name = "PrM_multiOptionsController";
             _multiOptionsControll.transform.parent = _optionControlle.transform;
             _multiOptionsControll.AddComponent<PrM_MultiOptionsController>();
            
             PrM_MultiOptionsInfo.MultiOpcionesContenido1 _contentMultiOptions = contenido._option_3.m_Contenido;
            if(_contentMultiOptions._howApplyChanges._changeBotton && _contentMultiOptions._howApplyChanges._automatic)
                   Debug.LogWarning(SceneManager.GetActiveScene().name + " (PrM_OptGameManger)-----> (How Apply Changes)Español: No puedes tener ambas opciones de activar los cambios de opciones " + "\n" + "English:You can't have both options to activate option changes");
                      
            else 
            {
               //_how apply changes
               _multiOptionsControll.GetComponent<PrM_MultiOptionsController>().SetOptionsButtons(_contentMultiOptions._howApplyChanges._resetBotton, _contentMultiOptions._howApplyChanges._changeBotton, _contentMultiOptions._howApplyChanges._automatic);
               //Vsync
               if(_data._isInstantiate && _data._isVsync != contenido._option_3.m_Contenido._vsync._vsyncDefoult || _isVsync != _data._isVsync)
               _multiOptionsControll.GetComponent<PrM_MultiOptionsController>().SetVsync(contenido._option_3.m_Contenido._vsync._vsyncToggle, _isVsync, contenido._option_3.m_Contenido._vsync._vsyncDefoult);  
               else
               _multiOptionsControll.GetComponent<PrM_MultiOptionsController>().SetVsync(contenido._option_3.m_Contenido._vsync._vsyncToggle, contenido._option_3.m_Contenido._vsync._vsyncDefoult, contenido._option_3.m_Contenido._vsync._vsyncDefoult);           
              // WindowsMode
              if(_data._isInstantiate && _data._windowsMode != contenido._option_3.m_Contenido._windowsMode._windowsDefoult || _windowsMode != _data._windowsMode)
                _multiOptionsControll.GetComponent<PrM_MultiOptionsController>().SetWindowsMode(contenido._option_3.m_Contenido._windowsMode._windowsToggle, _windowsMode, contenido._option_3.m_Contenido._windowsMode._windowsDefoult);
              else
                _multiOptionsControll.GetComponent<PrM_MultiOptionsController>().SetWindowsMode(contenido._option_3.m_Contenido._windowsMode._windowsToggle, contenido._option_3.m_Contenido._windowsMode._windowsDefoult, contenido._option_3.m_Contenido._windowsMode._windowsDefoult);

                  //Shadow
                  if(_data._isInstantiate && _data._shadowCurrent != contenido._option_3.m_Contenido._shadowQuality._shadowDefoult || _shadowCurrent != _data._shadowCurrent)
                  _multiOptionsControll.GetComponent<PrM_MultiOptionsController>().SetCalidadSombras(contenido._option_3.m_Contenido._shadowQuality._shadowDropdown,  _shadowCurrent, contenido._option_3.m_Contenido._shadowQuality._shadowDefoult);
                  else
                  _multiOptionsControll.GetComponent<PrM_MultiOptionsController>().SetCalidadSombras(contenido._option_3.m_Contenido._shadowQuality._shadowDropdown, contenido._option_3.m_Contenido._shadowQuality._shadowDefoult, contenido._option_3.m_Contenido._shadowQuality._shadowDefoult);
                  //Resolution
                    _multiOptionsControll.GetComponent<PrM_MultiOptionsController>().SetResolution(contenido._option_3.m_Contenido._screenResolution._screenResolDropwdown);
                  //Grafics
                    if(_data._isInstantiate && _data._graficCurrent != contenido._option_3.m_Contenido._grafics._graficDefoult || _graficCurrent !=  _data._graficCurrent) 
                    _multiOptionsControll.GetComponent<PrM_MultiOptionsController>().SetGrafics(contenido._option_3.m_Contenido._grafics._graficDropdown, _graficCurrent, contenido._option_3.m_Contenido._grafics._graficDefoult);
                    else
                    _multiOptionsControll.GetComponent<PrM_MultiOptionsController>().SetGrafics(contenido._option_3.m_Contenido._grafics._graficDropdown, contenido._option_3.m_Contenido._grafics._graficDefoult, contenido._option_3.m_Contenido._grafics._graficDefoult);            
                    //Antialasing
                    if(_data._isInstantiate && _data._antialasingCurrent != contenido._option_3.m_Contenido._antialasing._antialasingDefoult || _antialasingCurrent != _data._antialasingCurrent)
                    _multiOptionsControll.GetComponent<PrM_MultiOptionsController>().SetAntialsaing(contenido._option_3.m_Contenido._antialasing._antialasingDropdown, _antialasingCurrent, contenido._option_3.m_Contenido._antialasing._antialasingDefoult);         
                    else
                    _multiOptionsControll.GetComponent<PrM_MultiOptionsController>().SetAntialsaing(contenido._option_3.m_Contenido._antialasing._antialasingDropdown, contenido._option_3.m_Contenido._antialasing._antialasingDefoult, contenido._option_3.m_Contenido._antialasing._antialasingDefoult);
                    //FPS
                    if(_data._isInstantiate && _data._fpsCurrent != contenido._option_3.m_Contenido._fps._fpsDefoult || _fpsCurrent != _data._fpsCurrent)
                    _multiOptionsControll.GetComponent<PrM_MultiOptionsController>().SetFPS(contenido._option_3.m_Contenido._fps._fpsDropdown, _fpsCurrent, contenido._option_3.m_Contenido._fps._fpsDefoult);
                    else
                    _multiOptionsControll.GetComponent<PrM_MultiOptionsController>().SetFPS(contenido._option_3.m_Contenido._fps._fpsDropdown, contenido._option_3.m_Contenido._fps._fpsDefoult, contenido._option_3.m_Contenido._fps._fpsDefoult);
            }

        }

        /// <summary>
        /// Add left Handed option
        /// </summary>
        void AddZurdo()
        {
          PrM_ZurdoInfo.ZurdoContenido1 _content = contenido._option_4.m_Contenido;
          if (_content._rightHandedPanel && _content._leftHandedPanel)
          {
              GameObject _ZurdoController = new GameObject();
              _ZurdoController.name = "PrM_LeftHandController";
               _ZurdoController.transform.parent = _optionControlle.transform;  
              _ZurdoController.AddComponent<PrM_ZurdoController>();
              _ZurdoController.GetComponent<PrM_ZurdoController>().SetOptionZurdo(_content._leftHandedToggle, _content._rightHandedPanel, _content._leftHandedPanel);
          }
          else
          contenido._option_4.GetErrorZurdo();
        }

        /// <summary>
        /// Add Data persistent 
        /// </summary>
        void AddDataOptionsRecurrent()
        {
            while (_DataOptionsPersisten == null)
            {   //Shearch persisten data
              if (!_isDataOptionsPersisten)
              {
                _DataOptionsPersisten = GameObject.Find("PrM_DataPersistent");
                _isDataOptionsPersisten = true;
              }//Create Persisten Data
              else
              {
                GameObject m_recordatorio = new GameObject();
                m_recordatorio.name = "PrM_DataPersistent";
                m_recordatorio.AddComponent<PrM_DataPersistent>();
                _DataOptionsPersisten = m_recordatorio;
              }
            }
        }

        /// <summary>
        /// Load the data from the Data persistent for the first time
        /// </summary>
        void FirstLoadData()
        {
            if (!_isloadData)
            {

                //get Data persistern
                _data = FindObjectOfType<PrM_DataPersistent>();
                //Bright general
                _overallBrightnessFloat = _overallBrightnessFloat != _data._overallBrightnessFloat ? _data._overallBrightnessFloat : _overallBrightnessFloat;
                //bright camera
                _brightFloat = _brightFloat != _data._brightFloat ? _data._brightFloat : contenido._option_2._content._brightFloat;
                //contrast camera
                _contrastFloat = _contrastFloat != _data._contrastFloat ? _data._contrastFloat : contenido._option_2._content._contrastFloat;
                //LeftHanded
                 if(contenido._option_4.m_Contenido._leftHandedToggle)
                      _isLeftHand = _isLeftHand != _data._isLeftHand ?  contenido._option_4.m_Contenido._leftHandedToggle.isOn : _data._isLeftHand;
                 else
                      _isLeftHand = _isLeftHand != _data._isLeftHand ?  _data._isLeftHand : false ;
                 //Sound
                 if( _data._soundFloat != null && _soundFloat != _data._soundFloat)
                      if(_soundFloat != _data._soundFloat)
                          _soundFloat = _data._soundFloat;

                 //Vsync 
                 _isVsync = _isVsync != _data._isVsync ? _data._isVsync : _isVsync;              

                //shadow
                _shadowCurrent = _shadowCurrent != _data._shadowCurrent ? _data._shadowCurrent : _shadowCurrent;              

                //resolution
               _currentResolutionIndex = _currentResolutionIndex != _data._currentResolutionIndex ? _data._currentResolutionIndex : _currentResolutionIndex;

                //Windows 
                 _windowsMode = _windowsMode != _data._windowsMode ? _data._windowsMode : _windowsMode;

                //Grafics
                _graficCurrent = _graficCurrent != _data._graficCurrent ? _data._graficCurrent : _graficCurrent;              
        
                //Antialasing
                _antialasingCurrent = _antialasingCurrent != _data._antialasingCurrent ? _data._antialasingCurrent : _antialasingCurrent;              
        
                //FPS
                _fpsCurrent = _fpsCurrent != _data._fpsCurrent ?  _data._fpsCurrent : _fpsCurrent;


                 _isloadData = true;

            }
        }
        #endregion

      }
}
