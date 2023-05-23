using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

namespace AlexanderCA.ProMenu.UI
{
  using AlexanderCA.ProMenu.Enum;
  public class PrM_UIManager : PrM_Behaviour
    {

        #region Attributes
        GameObject _uIController;
        internal bool _isQuitDesabled = false;
        internal bool _isPauseGameDesabled = false;
        internal bool _isPanelDesabled = false;
        internal bool _isIconMouseActive = false;
        #endregion

        #region Explication
        public PrM_UInfo _explication;
        public Contenido _contenido;
   
        public static string GetPrettyName(System.Enum e)
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

        [System.Serializable]
        public class Contenido
        {
          [Header("Español:¿Quieres asignar en este nivel un botón", order = 0)]
          [Space(-10, order = 1)]
          [Header("de salir del juego?", order = 2)]
          [Space(-10, order = 3)]
          [Header("English:Do you want to assign a button at this level", order = 4)]
          [Space(-10, order = 5)]
          [Header("to exit the game?", order = 6)]
          [Space(5, order = 7)]
          public PrM_QuitInfo _option0;

          [Header("Español:¿Quieres colocar botones para cargar un nivel?", order = 8)]
          [Space(-10, order = 9)]
          [Header("English:Do you want to place buttons to load a level?", order = 10)]
          [Space(5, order = 11)]
          public PrM_LoadGameInfo _Option1;

          [Header("Español:Quieres asingar en este nivel un menu pausa?", order = 12)]
          [Space(-10, order = 13)]
          [Header("English:Do you want to assign a pause menu at this level?", order = 14)]
          [Space(5, order = 15)]
          public PrM_PauseGameInfo _Option2;

          [Header("Español: ¿Quieres asignar un botón para mostrar una", order = 16)]
          [Space(-10, order = 17)]
          [Header("URL(pagina web, youtube, redes sociales...)?", order = 18)]
          [Space(-10, order = 19)]
          [Header("English:Do you want to assign a button to show a", order = 20)]
          [Space(-10, order = 21)]
          [Header("URL (website, youtube, social networks ...)?", order = 22)]
          [Space(5, order = 23)]
          public PrM_URLInfo _Option3;

          [Header("Español:Quieres mostrar video?", order = 24)]
          [Space(-10, order = 25)]
          [Header("English:Do you want to show videos?", order = 26)]
          [Space(5, order = 27)]
          public PrM_VideoInfo _Option4;

          [Header("Español:¿Quieres activar/desactivar objetos <Panel> del", order = 28)]
          [Space(-10, order = 29)]
          [Header("canvas?", order = 30)]
          [Space(-10, order = 31)]
          [Header("English:Do you want to enable / disable <Panel> objects from the", order = 32)]
          [Space(-10, order = 33)]
          [Header("canvas?", order = 34)]
          [Space(5, order = 35)]
          public PrM_PanelInfo _Option5;

          [Header("Español:Quieres personalizar tus botones?", order = 36)]
          [Space(-10, order = 37)]
          [Header("English:Do you want to customize your buttons?", order = 38)]
          [Space(5, order = 39)]
          public PrM_CustomButtonsInfo _Option6;

          [Header("Español:Quieres colocar Iconos para tu raton?", order = 40)]
          [Space(-10, order = 41)]
          [Header("Egnlish:Do you want to place Icons for your mouse?", order = 42)]
          [Space(5, order = 43)]
          public PrM_MouseIconInfo m_Opcion7;
        }
        #endregion

        #region UnityCalls
        void Awake() => Init();
        #endregion

        #region Costum private Methods
        private void Init()
        {
            //Create empy object where we fine All UI Controllers
            if (!_uIController)
            {
              GameObject _uIController = new GameObject();
              _uIController.name = "PrM_UIController";
              this._uIController = _uIController;
            }
            ToAddQuitButton();
            ToAddLoadGameButton();
            ToAddPauseGameButton();
            ToAddURLButton();
            ToAddVideo();
            AddPanelsControl();
            AddCustomButtons();
            AddIconoMouse();
        }

        /// <summary>
        /// Adding function exit to button
        /// </summary>
        void ToAddQuitButton()
        {
            PrM_QuitInfo.SalirContenido _quitContent = _contenido._option0._content;
            PrM_QuitInfo.PreguntaSalir _quitPanel = _quitContent._quitQuestion;
            if (_quitContent._quitButton)
            {
                GameObject _quitButton = _quitContent._quitButton.gameObject;
                _quitButton.AddComponent<PrM_QuitButton>();
                _quitButton.GetComponent<PrM_QuitButton>().ToQuitClick(QuitEnum.Quit);

                if (_contenido._option0._isNotEmpty)
                {
                    _quitPanel._showPanelButton?.gameObject.AddComponent<PrM_QuitButton>();
                    _quitPanel._showPanelButton?.GetComponent<PrM_QuitButton>().ToQuitClick(QuitEnum.ShowPanel, _quitPanel._questionPanel.gameObject);
          
                    _quitPanel._hiddenPanelButton?.gameObject.AddComponent<PrM_QuitButton>();
                    _quitPanel._hiddenPanelButton?.GetComponent<PrM_QuitButton>().ToQuitClick(QuitEnum.HiddenPanel, _quitPanel._questionPanel.gameObject);

                    _contenido._option0.GetErrorQuit();
                }
            }
            if (_contenido._option0._isKey)
            {
              GameObject _quitController = new GameObject();
              _quitController.name = "PrM_QuitController";
              _quitController.transform.parent = _uIController.transform;
              _quitController.AddComponent<PrM_QuitController>();
              _quitController.GetComponent<PrM_QuitController>().SetKey(GetPrettyName(_quitContent._quitKey._joystickButton), _quitContent._quitKey._keyButton, _quitContent._quitKey._ownButton);
              if(_quitPanel._questionPanel)
              _quitController.GetComponent<PrM_QuitController>().SetPanel(_quitPanel._questionPanel.gameObject);
              _contenido._option0.GetErrorQuit();
            }
        }

        /// <summary>
        /// Adding function to load  levels buttons
        /// </summary>
        void ToAddLoadGameButton()
        {
          int _lenghLoading = _contenido._Option1._content._buttonsArray.Length;
          PrM_LoadGameInfo.BotonCargarNivelPreContenido _content = _contenido._Option1._content;
          for (int i = 0; i < _lenghLoading; i++)
          {
            if (_content._buttonsArray[i]._loadButton != null)
            {
              GameObject _loadButton = _content._buttonsArray[i]._loadButton.gameObject;
              _loadButton.AddComponent<PrM_LoadGameButton>();
              _loadButton.GetComponent<PrM_LoadGameButton>().ToLoadClick(_content._buttonsArray[i]._iDLevel);
              //add panel
              if (_content._buttonsArray[i]._loadQuestion._panelQuestion != null)
              {
                //Show Panel
                _content._buttonsArray[i]._loadQuestion._showButton?.gameObject.AddComponent<PrM_LoadGameButton>();
                _content._buttonsArray[i]._loadQuestion._showButton?.GetComponent<PrM_LoadGameButton>().ToLoadClick(LoadGameEnum.ShowPanel, _content._buttonsArray[i]._loadQuestion._panelQuestion.gameObject);
                //Hidden Panel
                _content._buttonsArray[i]._loadQuestion._hiddenButton?.gameObject.AddComponent<PrM_LoadGameButton>();
                _content._buttonsArray[i]._loadQuestion._hiddenButton?.GetComponent<PrM_LoadGameButton>().ToLoadClick(LoadGameEnum.HiddenPanel, _content._buttonsArray[i]._loadQuestion._panelQuestion.gameObject);
                //error
              }
              _contenido._Option1.GetErrorLoadLevel(i);
              }
              else
              _contenido._Option1.GetErrorLoadLevel(i);
              
          }
        }

        /// <summary>
        /// Adding function pause game to button
        /// </summary>
        void ToAddPauseGameButton()
        {
          PrM_PauseGameInfo.BotonPausaJuegoContenido _pauseGameContent = _contenido._Option2._content;

          if (_pauseGameContent.m_PanelMenu)
          {
            //Hidden Panel
            _pauseGameContent._buttonOptions._hiddeButton?.gameObject.AddComponent<PrM_PauseButton>();
            _pauseGameContent._buttonOptions._hiddeButton?.gameObject.GetComponent<PrM_PauseButton>().ToPauseClick(GamePauseEnum.HiddenPanel, _pauseGameContent.m_PanelMenu.gameObject);

            //Show Panel
            _pauseGameContent._buttonOptions._showButton?.gameObject.AddComponent<PrM_PauseButton>();
            _pauseGameContent._buttonOptions._showButton?.gameObject.GetComponent<PrM_PauseButton>().ToPauseClick(GamePauseEnum.ShowPanel, _pauseGameContent.m_PanelMenu.gameObject);

            //active panel with keys
            if (_pauseGameContent._keyOptions._key != KeyCode.None || _pauseGameContent._keyOptions._joystick != Enum.joystick.None || _pauseGameContent._keyOptions._ownButton != null)
            {
              GameObject _pauseController = new GameObject();
              _pauseController.name = "PrM_PauseGameController";
              _pauseController.transform.parent = _uIController.transform;
              _pauseController.AddComponent<PrM_PauseController>();
              _pauseController.GetComponent<PrM_PauseController>().SetKey(GetPrettyName(_pauseGameContent._keyOptions._joystick), _pauseGameContent._keyOptions._key, _pauseGameContent._keyOptions._ownButton);
              _pauseController.GetComponent<PrM_PauseController>().SetPanel(_pauseGameContent.m_PanelMenu.gameObject);
              _pauseController.GetComponent<PrM_PauseController>().SetPauseGame(_pauseGameContent._isPauseGame);
            }
            _contenido._Option2.GetPauseGameError();
          }
        }

        /// <summary>
        /// Adding function URL to button
        /// </summary>
        void ToAddURLButton()
        {
          PrM_URLInfo.BotonURL1 _contentURL = _contenido._Option3._content;
          for (int i = 0; i < _contentURL._arrayURL.Length; i++)
          {
            PrM_URLInfo.BotonURLContenido _url = _contentURL._arrayURL[i];
            _url._uRLButton?.onClick.AddListener(() => Application.OpenURL(_url._uRLString));
            _contenido._Option3.GetURLError(i);
          }
        }

        /// <summary>
        /// Adding function Video
        /// </summary>
        void ToAddVideo()
        {
            PrM_VideoInfo.BotonAnimacionConteido _contentVideo = _contenido._Option4._content;
            PrM_VideoInfo _option4 = _contenido._Option4;
            for (int i = 0; i < _contentVideo._arrayVideo.Length; i++)
            {
                PrM_VideoInfo.BotonAnimacionConteido1 _video = _contentVideo._arrayVideo[i];
                if (_video._clip)
                {

                    //shay error
                    _contenido._Option4.GetErrorVideo(i);
                    if (!_option4._isSameHowSee && !_option4._isSameActiveMode && !_option4._isSameFinishinMode)
                    {
                        //Create controller video
                        GameObject _videoController = new GameObject();
                        _videoController.name = "PrM_CinematicController" + _video._elementName + " " + i;
                        _videoController.transform.parent = _uIController.transform;
                        _videoController.AddComponent<PrM_VideoController>();
                        //if was panel
                        PrM_VideoController _controller = _videoController.GetComponent<PrM_VideoController>();
       
                           
                      if (_video._howSee._panel && !_video._howSee._2D || !_video._howSee._3D)
                      {
                        StartCoroutine( _controller.AddVideo(_video._howSee._panel, _video._clip, _video._activateMode._automaticMode, _video._finishingMode._loopMode));
                      }
                      //if was Object 2D
                      if (_video._howSee._2D && !_video._howSee._panel || !_video._howSee._3D)
                        StartCoroutine(_controller.AddVideo(_video._howSee._2D, _video._clip, _video._activateMode._automaticMode, _video._finishingMode._loopMode));
                      //if was Object 3D
                      if (_video._howSee._3D && !_video._howSee._2D || !_video._howSee._panel)
                        StartCoroutine(_controller.AddVideo(_video._howSee._3D, _video._clip, _video._activateMode._automaticMode, _video._finishingMode._loopMode));
                        
                        _controller.AddEndingMode( _video._finishingMode._stopVideo, _video._finishingMode._stopAll);
                      //Add activate modde
                        StartCoroutine(_controller.AddVideoActivate(_video._activateMode._buttonMode, _video._activateMode._trigger2DMode, _video._activateMode._trigger3DMode, _video._activateMode._nameTagTrigger));                
                      //add controlers videos
                        _controller.AddVideoButtonsController(_video._controllersVideo._playButton, _video._controllersVideo._pauseButton, _video._controllersVideo._quitButton);
                        

                    }
                }
                else
                  //say error
                  _contenido._Option4.GetErrorVideo(i);
            }
        }

        /// <summary>
        /// Adding function to control abled and desable panels
        /// </summary>
        void AddPanelsControl()
        {
          int _arryPanel = _contenido._Option5._content.m_Panel.Length;
          for (int i = 0; i < _arryPanel; i++)
          {
            PrM_PanelInfo _panela = _contenido._Option5;
            PrM_PanelInfo.PanelActivarDesactivarContenido1 _panelArray = _contenido._Option5._content.m_Panel[i];

            if (_panelArray._newButton)
            {
              _panelArray._newButton.gameObject.AddComponent<PrM_PanelsButton>();
              _panelArray._newButton.gameObject.GetComponent<PrM_PanelsButton>().ToPanelClick(PanelEnum.ShowPanel);
              _panelArray._newButton.gameObject.GetComponent<PrM_PanelsButton>().SetListPanel(_panelArray._oldPanel, _panelArray._newPanel);
            }
            if (_panelArray._backButton)
            {
              _panelArray._backButton.gameObject.AddComponent<PrM_PanelsButton>();
              _panelArray._backButton.gameObject.GetComponent<PrM_PanelsButton>().ToPanelClick(PanelEnum.HiddenPanel);
              _panelArray._backButton.gameObject.GetComponent<PrM_PanelsButton>().SetListPanel(_panelArray._oldPanel, _panelArray._newPanel);
            }
            if (_panelArray._keyOptions._keyButton != KeyCode.None || _panelArray._keyOptions._joystickButton != Enum.joystick.None || _panelArray._keyOptions._ownButton != null)
            {
              GameObject _panelController = new GameObject();
              _panelController.name =  "PrM_MenusController_"+ i.ToString();
              _panelController.transform.parent = _uIController.transform;
              _panelController.AddComponent<PrM_MenuController>();
              _panelController.GetComponent<PrM_MenuController>().SetPanelsControllers(GetPrettyName(_panelArray._keyOptions._joystickButton), _panelArray._keyOptions._keyButton, _panelArray._keyOptions._ownButton, _panelArray._oldPanel, _panelArray._newPanel);
            }

            //error buttons
            _panela.GetErrorPanel(i);
          }
        }

        /// <summary>
        /// Adding function to custom buttons 
        /// </summary>
        void AddCustomButtons()
        {
          int _arrayCustom = _contenido._Option6._content._customButtons.Length;
          PrM_CustomButtonsInfo _custom = _contenido._Option6;
          for (int i = 0; i < _arrayCustom; i++)
          {
       
              PrM_CustomButtonsInfo.BotonesPersonalizar _buttonCustom = _contenido._Option6._content._customButtons[i];
              if (_buttonCustom._button)
              {
                  if (!_buttonCustom._isOwnCusttom)
                  {
                      _buttonCustom._button.gameObject.AddComponent<PrM_CustomButton>();
                      PrM_CustomButtonsInfo.PersonalizarGeneruci _genericCustom = _contenido._Option6._content._customDefault[_buttonCustom._intGeneric];
                      if (_genericCustom._onDefoultImage != null)
                        _buttonCustom._button.gameObject.GetComponent<PrM_CustomButton>().SetImageButton(_genericCustom._onDefoultImage, _genericCustom._onClickImage, _genericCustom._onEnterImage);

                      if (_genericCustom._animatorController)
                        _buttonCustom._button.gameObject.GetComponent<PrM_CustomButton>().SetVideoButton(_genericCustom._animatorController, _genericCustom._onDefoultVideo, _genericCustom._onEnterVideo, _genericCustom._onClickVideo);

                      if (_genericCustom._audioSource)
                        _buttonCustom._button.gameObject.GetComponent<PrM_CustomButton>().SetSoundButton(_genericCustom._audioSource, _genericCustom._onEnterSound, _genericCustom._onClickSoundo, _genericCustom.m_loop);                

                        _custom.GetErrorGeneric(_buttonCustom._intGeneric);
                  }
                  else
                  {
                      PrM_CustomButtonsInfo.PersonalizarGeneruci _personalizeCustom = _contenido._Option6._content._customButtons[i]._ownCustum;
                      _buttonCustom._button.gameObject.AddComponent<PrM_CustomButton>();
                      if (_personalizeCustom._onDefoultImage != null)
                        _buttonCustom._button.gameObject.GetComponent<PrM_CustomButton>().SetImageButton(_personalizeCustom._onDefoultImage, _personalizeCustom._onClickImage, _personalizeCustom._onEnterImage);

                      if (_personalizeCustom._animatorController)
                        _buttonCustom._button.gameObject.GetComponent<PrM_CustomButton>().SetVideoButton(_personalizeCustom._animatorController, _personalizeCustom._onDefoultVideo, _personalizeCustom._onEnterVideo, _personalizeCustom._onClickVideo);

                       if (_personalizeCustom._audioSource)
                        _buttonCustom._button.gameObject.GetComponent<PrM_CustomButton>().SetSoundButton(_personalizeCustom._audioSource, _personalizeCustom._onEnterSound, _personalizeCustom._onClickSoundo, _personalizeCustom.m_loop);    

                        _custom.GetErrorOwn(i);
                  }
              }
              else
                _custom.GetError(i);
          }
        }

        /// <summary>
        /// Adding function to create icon mouse
        /// </summary>
        void AddIconoMouse()
        {
          if (_contenido.m_Opcion7._content._panelIconVisualicer)
          {
            GameObject m_Icono = new GameObject();
            Image m_ImageIcono = m_Icono.AddComponent<Image>();
            m_Icono.name = "PrM_MouseIconController";
            _isIconMouseActive = _contenido.m_Opcion7._content._onFunction;
            //m_Icono.transform.parent = _uIController.transform;
            m_Icono.transform.parent = _contenido.m_Opcion7._content._panelIconVisualicer.gameObject.transform;
            m_Icono.gameObject.AddComponent<PrM_MouseIcon>();
            m_Icono.gameObject.GetComponent<PrM_MouseIcon>().SetAnimIcono(_contenido.m_Opcion7._content._animatorController, _contenido.m_Opcion7._content._onClickAnim, _contenido.m_Opcion7._content._onDefoultAnim);
            m_Icono.gameObject.GetComponent<PrM_MouseIcon>().SetImagIcono (_contenido.m_Opcion7._content.m_posIcono, _contenido.m_Opcion7._content._onClickImage, _contenido.m_Opcion7._content._defoultImage);
            m_Icono.gameObject.GetComponent<PrM_MouseIcon>().SetControlIcono(GetPrettyName(_contenido.m_Opcion7._content._yoistickBotton));
            _contenido.m_Opcion7.GetMouseIconoError();
          }
          else
          {
                if(!Cursor.visible)
                Cursor.visible = true;
          }
        }
        #endregion

    }
}