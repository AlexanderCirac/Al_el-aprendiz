using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace AlexanderCA.ProMenu.LoadBar
{
    using AlexanderCA.ProMenu.Enum;
    using AlexanderCA.ProMenu.ToolsInspector;

    public class PrM_LoadGameManger : MonoBehaviour
    {
        #region Attribute
        public PrM_LoadGameInfo _explication;   
        public Contenido _content;   
        #endregion
 
        #region LoadBar Content
        [System.Serializable]
        public class Contenido
        {
          [Header("Español:¿Qué uso quieres darle a este nivel?", order = 0)]
          [Space(-10, order = 1)]
          [Header("English:What use do you want to give this level?", order = 2)]
          [Space(5, order = 3)]
          public UsoPantallCarga _use;
          [Header("Español:personalizador de la pantalla de carga", order = 4)]
          [Space(-10, order = 5)]
          [Header("English:loading screen customizer", order = 6)]
          [Space(5, order = 7)]
          public PersonalizarPantallaCarga _customization;
        }
        [System.Serializable]
        public class PersonalizarPantallaCarga
        {
          [Header("Español:¿Cómo quieres que se visualice el", order = 0)]
          [Space(-10, order = 1)]
          [Header("avance de la pantalla de carga?", order = 2)]
          [Space(-10, order = 3)]
          [Header("English:How do you want the loading screen", order = 4)]
          [Space(-10, order = 5)]
          [Header("preview?", order = 6)]
          [Space(5, order = 7)]
          public AvancePantallaCarga _advancing;
          [Header("Español:¿Quieres algún tipo de aviso al jugador", order = 8)]
          [Space(-10, order = 9)]
          [Header("ccuando termine la pantalla de carga?", order = 10)]
          [Space(-10, order = 11)]
          [Header("English:Do you want some kind of notice to the player", order = 12)]
          [Space(-10, order = 13)]
          [Header("when the loading screen ends?", order = 14)]
          [Space(5, order = 15)]
          public AvisoPantallaCarga _warning;
          [Header("Español:¿Como quieres que actúe la pantalla", order = 16)]
          [Space(-10, order = 17)]
          [Header("de carga cuando termine?", order = 18)]
          [Space(-10, order = 19)]
          [Header("English:How do you want the screen to act", order = 20)]
          [Space(-10, order = 21)]
          [Header("charging when finished?", order = 22)]
          [Space(5, order = 23)]
          public TerminarPantallaCarga _ending;
        }
        [System.Serializable]
        public class UsoPantallCarga
        {

          [Header("Español:Indica cual sera el nivel que contiene", order = 16)]
          [Space(-10, order = 17)]
          [Header("pantalla de carga", order = 18)]
          [Space(-10, order = 19)]
          [Header("English:Indicates what level it contains", order = 20)]
          [Space(-10, order = 21)]
          [Header("charging screen", order = 22)]
          [Space(5, order = 23)]
          public int m_nivel;
          [Header("Español: Que funcion quieres que tenga en este ", order = 24)]
          [Space(-10, order = 25)]
          [Header(" nivel la pantalla de carga", order = 26)]
          [Space(-10, order = 27)]
          [Header("English:Indicates what level it contains", order = 28)]
          [Space(-10, order = 29)]
          [Header("charging screen", order = 30)]
          [Space(5, order = 31)]
          public LoadBarEnmu _typeLoadBar;
        }

        [System.Serializable]
        public class AvancePantallaCarga
        {
          [Header("Español:¿Quieres que el avance sea interno  ", order = 0)]
          [Space(-10, order = 1)]
          [Header("y automático?", order = 2)]
          [Space(-10, order = 3)]
          [Header("English:Do you want the advance to be internal", order = 4)]
          [Space(-10, order = 5)]
          [Header("and automatic?", order = 6)]
          [Space(5, order = 7)]
          public bool _isLoadingAutomatic;
          [Header("Español:¿Quieres que el avance  se visualice", order = 8)]
          [Space(-10, order = 9)]
          [Header("en el progreso con una barra?", order = 10)]
          [Space(-10, order = 11)]
          [Header("English:Do you want the trailer to be displayed", order = 12)]
          [Space(-10, order = 13)]
          [Header("in progress with a bar?", order = 14)]
          [Space(5, order = 15)]
          public Slider _sliderOption;
        }
        [System.Serializable]
        public class TerminarPantallaCarga
        {
          [Header("Español:¿Quieres que se quite de forma automática?", order = 0)]
          [Space(-10, order = 1)]
          [Header("English:Do you want it to be removed automatically?", order = 3)]
          [Space(5, order = 4)]
          public bool _isQuitAutomatic;
          [Header("Español:Que se quite cuando pulses un boton?", order = 5)]
          [Space(-10, order = 6)]
          [Header("English:Do you want it to come off when you press a button?", order = 7)]
          [Space(5, order = 8)]
          public Button _quitButton;
          [Header("Español:¿Quieres que se quite cuando pulses una tecla?", order = 9)]
          [Space(-10, order = 10)]
          [Header("English:Do you want it to be removed when you press a key?", order = 11)]
          [Space(5, order = 12)]
          public KeyCode _quitKey;
          [Header("Español:¿Quieres que se quite cuando pulses un Joystick?", order = 13)]
          [Space(-10, order = 14)]
          [Header("English:Do you want it to come off when you press a Joystick?", order = 15)]
          [Space(5, order = 16)]
          public joystick _quitJoystick;
        }
        [System.Serializable]
        public class AvisoPantallaCarga
        {
          [Header("Español:¿Quieres que se active un <panel> para avisar", order = 0)]
          [Space(-10, order = 1)]
          [Header("que se ha cargado el nivel?", order = 2)]
          [Space(-10, order = 3)]
          [Header("English:Do you want a <panel> to be activated to warn", order = 4)]
          [Space(-10, order = 5)]
          [Header("that has the level been loaded?", order = 6)]
          [Space(5, order = 7)]
          public CanvasRenderer _warningPanel;    
          [Header("Español:¿Quieres que se active un sonido para avisar que", order = 8)]
          [Space(-10, order = 9)]
          [Header("se ha cargado el nivel?", order = 10)]
          [Space(-10, order = 11)]
          [Header("English:Do you want a sound to be activated to warn that", order = 12)]
          [Space(-10, order = 13)]
          [Header("has the level been loaded?", order = 14)]
          [Space(5, order = 15)]
          public AudioSource _warningSound;
        }
        #endregion

        #region Unity Calls  
        void Start() => Init();
        #endregion          
    
        #region custom private methods   
        void Init()
        {
              GameObject m_recordatorio = new GameObject();
              m_recordatorio.name = "LoadBarController";
                if (!_isAllAdvancing && !_isAllEnding)
                {
                      m_recordatorio.AddComponent<PrM_LoadGameController>();
                    m_recordatorio.GetComponent<PrM_LoadGameController>().SetFunctionLoadBar(_content._use._typeLoadBar, _content._use.m_nivel);
                    m_recordatorio.GetComponent<PrM_LoadGameController>().SetAdLoadBar(_content._customization._warning._warningSound, _content._customization._warning._warningPanel);
                    m_recordatorio.GetComponent<PrM_LoadGameController>().SetSeeLoadBar(_content._customization._advancing._isLoadingAutomatic, _content._customization._advancing._sliderOption);
                    m_recordatorio.GetComponent<PrM_LoadGameController>().SetEndedLoadBar(_content._customization._ending._isQuitAutomatic, _content._customization._ending._quitButton, _content._customization._ending._quitKey, _content._customization._ending._quitJoystick);

                }
                else
                  GetErrorLoadBar();
        }
        #endregion      
       #region LoadBar Error
        /// <summary>
        /// This is to said when there will be an error
        /// </summary>        
          public void GetErrorLoadBar()
          {

              if( _isAllEnding)
                  Debug.LogWarning(SceneManager.GetActiveScene().name + " (PrM_LoadGameManager)-----> Ending: Español:No puedes mezclar formas de activación, se cancela la carga de pantalla" + "\n" + "English:You cannot mix element activation ways, screen loading is canceled");              
              if(_isAllAdvancing)
                  Debug.LogWarning(SceneManager.GetActiveScene().name + " (PrM_LoadGameManager)-----> Advancing: Español:No puedes mezclar formas de activación, se cancela la carga de pantalla" + "\n" + "English:You cannot mix element activation ways,screen loading is canceled");          

          }

        
          bool _isAllAdvancing
          {
              get => (_content._customization._advancing._sliderOption  && _content._customization._advancing._isLoadingAutomatic);
          }      
          bool _isAllEnding
          {
              get => (_content._customization._ending._isQuitAutomatic && (_content._customization._ending._quitButton || _content._customization._ending._quitKey != KeyCode.None || _content._customization._ending._quitJoystick != joystick.None));
          }
          #endregion      
    }
}
