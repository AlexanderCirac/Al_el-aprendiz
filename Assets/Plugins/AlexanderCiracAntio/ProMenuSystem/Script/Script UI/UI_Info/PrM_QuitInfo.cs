using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace AlexanderCA.ProMenu.UI
{
    using AlexanderCA.ProMenu.ToolsInspector;
    using AlexanderCA.ProMenu.Enum;
    [System.Serializable]
    public class PrM_QuitInfo 
    {
        #region Quit Explanation
        public ExplicacionSalir _explication;
        public SalirContenido _content;

        [System.Serializable]
        public class ExplicacionSalir
        {
          public ExplicacionSalirEspañol Español;
          public ExplicacionSalirIngles English;
        }
          #region Spanish
          [System.Serializable]
          public class ExplicacionSalirEspañol
          {
            public SalirTotalEspañol Explicación;
            public SalirUsoEspañol Uso;
            public SalirAdvertenciaEspañol Advertencia;
          }
          [System.Serializable]
          public class SalirTotalEspañol
          {
            #if UNITY_EDITOR
            [PrM_BoxInspector("Este apartado, es para asignar qué botón se utilizará para salir del juego.También se ofrece la opción de preguntar al jugador si realmente quiere salir del juego.\n Al asignar el <panel> pregunta, deberéis crear vosotros los elementos gráficos de interfaz, con la pregunta y los botones de respuesta.\n La script otorga funcionalidad a estos botones para activar y desactivar panel y el botón para que salga del juego. \nTambién tenéis como opción extra asignar esta función a un tecla o joystick como una opción rápida para salir del juego.\n\n Uso: En el caso que sólo queráis poner un botón sin la pregunta solo tenéis que arrastrar ese objeto en la ranura de función salir juego. En el caso de que queráis poner una pregunta el botón de salir tendrá que ser el que active la  pregunta, y la respuesta <SI>, la poneis con la función <salir juego> y la respuesta <NO>, será la que desactive la preguntar. En el caso de la acción rápida solo tenéis que clicar. Saldrá un desplegable y seleccionáis el botón que deseéis.\n\n Advertencia: la parte gráfica, la pregunta y colocar los botones en su sitio lo tendréis que hacer vosotros. Yo solo os facilito abrir/cerrar panel. Sobre la tecla/joystick tiene en cuenta que si no hay panel pregunta ejecutará automáticamente la función salir del juego", UnityEditor.MessageType.Info)]
            public bool _a;
            #endif
          }
          [System.Serializable]
          public class SalirUsoEspañol
          {
            #if UNITY_EDITOR
            [PrM_BoxInspector("Uso: En el caso que sólo queráis poner un botón sin la pregunta solo tenéis que arrastrar ese objeto en la ranura de función salir juego. En el caso de que queráis poner una pregunta el botón de salir tendrá que ser el que active la  pregunta, y la respuesta <SI>, la poneis con la función <salir juego> y la respuesta <NO>, será la que desactive la pregunta. En el caso de la acción rápida solo tenéis que clicar. Saldrá un desplegable y seleccionáis el botón que deseéis.", UnityEditor.MessageType.Warning)]
            public bool _a;
            #endif
          }
          [System.Serializable]
          public class SalirAdvertenciaEspañol
          {
            #if UNITY_EDITOR
            [PrM_BoxInspector("Advertencia: la parte gráfica, la pregunta y colocar los botones en su sitio lo tendréis que hacer vosotros. Yo solo os facilito abrir/cerrar panel. Sobre la tecla/joystick tiene en cuenta que si no hay panel pregunta ejecutará automáticamente la función salir del juego", UnityEditor.MessageType.Error)]
            public bool _a;
            #endif
          }
          #endregion

          #region English
          [System.Serializable]
          public class ExplicacionSalirIngles
          {
              public SalirTotalIngles Explanation;
              public SalirUsoIngles Use;
              public SalirAdverteciaIngles Warning;
          }
          [System.Serializable]
          public class SalirTotalIngles
          {
            #if UNITY_EDITOR
              [PrM_BoxInspector("This section is to assign which button will be used to exit the game. There is also the option to ask the player if he really wants to get out of the game. \n When assigning the question <panel>, you must create the graphical interface elements, with the question and the answer buttons. The script gives functionality to these buttons to activate and deactivate panel and the button to get out of the game. \nYou also have an extra option to assign this function to a key or joystick as a quick option to exit the game.\n\n Use: In the case that you only want to put a button without the question, you only have to drag that object into the exit game function slot. In the event that you want to put a question, the exit button will have to be the one that activates the question, and you put the answer <YES> with the <exit game> function and the answer will <NO> be the one that deactivates the question. In the case of fast action, you just have to click. A drop-down will appear and you select the button you want. \n\n Warning: the graphic part, the question and placing the buttons in con la función <salir juego> y la respuesta their place will be up to you. I only facilitate you to open / close the panel. On the key / joystick keep in mind that if there is no question panel, it will automatically execute the function exit the game.", UnityEditor.MessageType.Info)]
              public bool _a;
            #endif
          }

          [System.Serializable]
          public class SalirUsoIngles
          {

            #if UNITY_EDITOR
              [PrM_BoxInspector("Use: In the case that you only want to put a button without the question, you only have to drag that object into the exit game function slot. In the event that you want to put a question, the exit button will have to be the one that activates the question, and you put the answer <YES> with the <exit game> function and the answer will <NO> be the one that deactivates the question. In the case of fast action, you just have to click. A drop-down will appear and you select the button you want.", UnityEditor.MessageType.Warning)]
              public bool _a;
            #endif
          }
          [System.Serializable]
          public class SalirAdverteciaIngles
          {
            #if UNITY_EDITOR
              [PrM_BoxInspector("Warning: the graphic part, the question and placing the buttons in con la función <salir juego> y la respuesta their place will be up to you. I only facilitate you to open / close the panel. On the key / joystick keep in mind that if there is no question panel, it will automatically execute the function exit the game.", UnityEditor.MessageType.Error)]
              public bool _a;
            #endif
          }
          #endregion

        #endregion

        #region Quit Content
        [System.Serializable]
        public class SalirContenido
        {
          [Header("Español:¿Cuál será el botón para salir del juego?", order = 0)]
          [Space(-10, order = 1)]
          [Header("English:What will be the button to exit the game?", order = 2)]
          [Space(5, order = 3)]
          public Button _quitButton;
          [Header("Español:¿Quieres activar un panel de pregunta", order = 4)]
          [Space(-10, order = 5)]
          [Header("antes de salir?", order = 6)]
          [Space(-10, order = 7)]
          [Header("English:Do you want to activate a question panel", order = 8)]
          [Space(-10, order = 9)]
          [Header("before leaving?", order = 10)]
          [Space(5, order = 11)]
          public PreguntaSalir _quitQuestion;
          [Header("Español:¿Cuál será la tecla de acción rápida para", order = 12)]
          [Space(-10, order = 13)]
          [Header("salir del juego?", order = 14)]
          [Space(5, order = 15)]
          [Header("English: What will be the quick action key for", order = 16)]
          [Space(-10, order = 17)]
          [Header("exit game?", order = 18)]
          [Space(5, order = 19)]
          public AccionRapido _quitKey;
        }
        [System.Serializable]
        public class PreguntaSalir
        {
          [Header("Español:¿Cuál será el <panel> que contendrá la", order = 0)]
          [Space(-10, order = 1)]
          [Header("pregunta y los botones?", order = 2)]
          [Space(-10, order = 3)]
          [Header("English:What will be the <panel> that will contain the", order = 4)]
          [Space(-10, order = 5)]
          [Header("question and buttons?", order = 6)]
          [Space(5, order = 7)]
          public CanvasRenderer _questionPanel;
          [Header("Español:¿Cuál será el botón para abrir el panel", order = 8)]
          [Space(-10, order = 9)]
          [Header("pregunta?", order = 10)]
          [Space(-10, order = 11)]
          [Header("English:What will be the button to open the panel", order = 12)]
          [Space(-10, order = 13)]
          [Header("question?", order = 14)]
          [Space(5, order = 15)]
          public Button _showPanelButton;
          [Header("Español:¿Cuál será el botón para cerrar el panel", order = 16)]
          [Space(-10, order = 17)]
          [Header("pregunta?", order = 18)]
          [Space(-10, order = 19)]
          [Header("English:What will be the button to close the panel", order = 20)]
          [Space(-10, order = 21)]
          [Header("question?", order = 22)]
          [Space(5, order = 23)]
          public Button _hiddenPanelButton;
        }

        [System.Serializable]
        public class AccionRapido
        {
          [Header("Español:¿Cuál será el joystick de acción rápida para", order = 0)]
          [Space(-10, order = 1)]
          [Header("salir del juego?", order = 2)]
          [Space(-10, order = 3)]
          [Header("English:What will be the fast action joystick for", order = 4)]
          [Space(-10, order = 5)]
          [Header("exit game?", order = 6)]
          [Space(5, order = 7)]
          public joystick _joystickButton;
          [Header("Español:¿Cuál será la tecla de acción rápida para", order = 8)]
          [Space(-10, order = 9)]
          [Header("salir del juego?", order = 10)]
          [Space(-10, order = 11)]
          [Header("English:What will be the quick action key for", order = 12)]
          [Space(-10, order = 13)]
          [Header("exit game?", order = 14)]
          [Space(5, order = 15)]
          public KeyCode _keyButton;          
          [Header("Español:¿Cuál será la tecla personalizada de ", order = 16)]
          [Space(-10, order = 17)]
          [Header("acción rápida para salir del juego?", order = 18)]
          [Space(-10, order = 19)]
          [Header("English:What will be the quick action own button for", order = 20)]
          [Space(-10, order = 21)]
          [Header("exit game?", order = 22)]
          [Space(5, order = 23)]
          public string _ownButton;
        }
        #endregion

        #region Quit Error
        /// <summary>
        /// This is to said when there will be an error
        /// </summary>        
        public void GetErrorQuit()
        {
             if (_content._quitButton && _content._quitQuestion._questionPanel)
             {
                  PreguntaSalir _quitContent = _content._quitQuestion;

                  if (_quitContent._showPanelButton == null)
                  {
                  Debug.LogWarning(SceneManager.GetActiveScene().name + " (PrM_UIManger)-----> Option 0: Español:Te falta añadir el botón para activar la pregunta salir" + "\n" + "English:You need to add the button to activate the question exit");
                  }
                  //Hidden Panel
                  if (_quitContent._hiddenPanelButton == null)
                  {
                  Debug.LogWarning(SceneManager.GetActiveScene().name + " (PrM_UIManger)-----> Option 0: Español:Te falta añadir el botón para desactivar la pregunta salir" + "\n" + "English:You need to add the button to deactivate  the question exit");
                  }
                  //error buttons
                  if (_isSameButton)
                  {
                    Debug.LogError(SceneManager.GetActiveScene().name + " (PrM_UIManger)---->Option 0:Español: No puedes usar el mismo botón en el otro lado" + "\n" + "English:You can't use the same button on the other side");
                  }
             }
        }
        /// <summary>
        /// This is to chech it is same buttons
        /// </summary>             
        bool _isSameButton
        {
            get => (_content._quitButton == _content._quitQuestion._showPanelButton || _content._quitButton == _content._quitQuestion._hiddenPanelButton || _content._quitQuestion._hiddenPanelButton == _content._quitQuestion._showPanelButton);
        }
        /// <summary>
        /// This is to chech it is  buttons not empty
        /// </summary>     
        public bool _isNotEmpty
        {
            get =>(_content._quitQuestion._questionPanel != null && _content._quitQuestion._showPanelButton != null && _content._quitQuestion._hiddenPanelButton);
        }
        /// <summary>
        /// This is to chech it is key not empty
        /// </summary>     
        public bool _isKey
        {
            get => (_content._quitKey._keyButton != KeyCode.None || _content._quitKey._joystickButton != Enum.joystick.None || _content._quitKey._ownButton != "");
        }
        #endregion
    }
}
