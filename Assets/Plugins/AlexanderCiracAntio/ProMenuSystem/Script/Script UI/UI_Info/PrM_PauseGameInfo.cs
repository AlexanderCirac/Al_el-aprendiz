using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace AlexanderCA.ProMenu.UI
{
    using AlexanderCA.ProMenu.ToolsInspector;
    using AlexanderCA.ProMenu.Enum;
    [System.Serializable]
    public class PrM_PauseGameInfo
    {

        #region PauseGame explication
        public ExplicacionBotonPausaJuego _explicati�n;
        public BotonPausaJuegoContenido _content;

        [System.Serializable]
        public class ExplicacionBotonPausaJuego
        {
          public ExplicacionBotonPausaJuegoEspa�ol Espa�ol;
          public ExplicacionBotonPausaJuegoIngles English;
        }

          #region Espa�ol
          [System.Serializable]
          public class ExplicacionBotonPausaJuegoEspa�ol
          {
            public BotonPausaJuegoTotalEspa�ol Explicaci�n;
            public BotonPausaJuegoUsoEspa�ol Uso;
            public BotonPausaJuegoAdvertenciaEspa�ol Advertencia;
          }

          [System.Serializable]
          public class BotonPausaJuegoTotalEspa�ol
          {
              #if UNITY_EDITOR
              [PrM_BoxInspector("Este apartado es para facilitar la ejecuci�n de un men� pausa, en el cual el contenido del men� lo pon�is vosotros. Se dar� la funci�n al bot�n que abrir�/cerrar� el <panel> del men� pausa y al ser el sistema pro se ofrece la posibilidad de parar todo el juego cuando el men� est� abierto, y de asignar formas diferente de poder abrirlo, tecla/joystick (se puede mezclar todas las opciones)\n\n Uso: Arrastrar el objeto <Panel> del canvas que contiene el men� pausa y elegir c�mo quieres que se active/desactive.\n\n Advertencia: Puedes mezclar las diferentes opciones rellenando los huecos para poder abrir/cerrar men�s de pausa. El fragmento de la variable para controlar el poder, pausar con la tecla y yoistick, es hacer referencia a estascript ( �script� AEI) < AEI.contenido.m_Opcion2.m_Contenido.m_Opcion2. m_Activar_Active = True/False; seg�n lo que quieras", UnityEditor.MessageType.Info)]
              public bool _a;
              #endif
          }

          [System.Serializable]
          public class BotonPausaJuegoUsoEspa�ol
          {
              #if UNITY_EDITOR
              [PrM_BoxInspector("Uso: Arrastrar el objeto < Panel > del canvas que contiene el men� pausa y elegir c�mo quieres que se active/desactive", UnityEditor.MessageType.Warning)]
              public bool _a;
              #endif
          }

          [System.Serializable]
          public class BotonPausaJuegoAdvertenciaEspa�ol
          {
              #if UNITY_EDITOR
              [PrM_BoxInspector("Advertencia: Puedes mezclar las diferentes opciones rellenando los huecos para poder abrir/cerrar men�s de pausa El fragmento de la variable para controlar el poder pausar con la tecla y yoistick, es hacer referencia a esta script( �script� AEI) > AEI.contenido.m_Opcion2.m_Contenido.m_Opcion2. m_Activar_Active = True/False; seg�n lo que quieras", UnityEditor.MessageType.Error)]
              public bool _a;
              #endif
          }
          #endregion

          #region English
          [System.Serializable]
          public class ExplicacionBotonPausaJuegoIngles
          {
            public BotonPausaJuegoTotalIngles Explanation;
            public BotonPausaJuegoUsoIngles Use;
            public BotonPausaJuegoAdverteciaIngles Warning;
          }
          [System.Serializable]
          public class BotonPausaJuegoTotalIngles
          {
              #if UNITY_EDITOR
              [PrM_BoxInspector("This section is to facilitate the execution of a pause menu, in which the content of the menu is put by you. The function will be given to the button that will open / close the <panel> of the pause menu and as the pro system offers the possibility of stopping the entire game when the menu is open, and of assigning different ways to open it, key/joystick (you can mix all the options) \n\n Use: Drag the <Panel> object from the canvas that contains the pause menu and choose how you want it to be activated/deactivated \n\n Warning: You can mix the different options by filling in the slots to be able to open / close pause menus The fragment of the variable to control the allow pause with the key and yoistick, is to reference to this script ( �script� AEI) > AEI.contenido.m_Opcion2.m_Contenido.m_Opcion2.m_Activar_Active = True / False; according to what you want", UnityEditor.MessageType.Info)]
              public bool _a;
              #endif
          }

          [System.Serializable]
          public class BotonPausaJuegoUsoIngles
          {
              #if UNITY_EDITOR
              [PrM_BoxInspector("Use: Drag the < Panel > object from the canvas that contains the pause menu and choose how you want it to be activated/deactivated", UnityEditor.MessageType.Warning)]
              public bool _a;
              #endif
          }
          [System.Serializable]
          public class BotonPausaJuegoAdverteciaIngles
          {
              #if UNITY_EDITOR
              [PrM_BoxInspector("Warning: You can mix the different options by filling in the slots to be able to open / close pause menus The fragment of the variable to control the allow pause with the key and yoistick, is to reference to this script ( �script� AEI) > AEI.contenido.m_Opcion2.m_Contenido.m_Opcion2.m_Activar_Active = True / False; according to what you want", UnityEditor.MessageType.Warning)]
              public bool _a;
              #endif
          }
          #endregion

       #endregion

        #region  PauseGame Content
        [System.Serializable]
        public class BotonPausaJuegoContenido
        {
          [Header("Espa�ol:�Cu�l ser� el panel que contendr� el", order = 0)]
          [Space(-10, order = 1)]
          [Header("men� pausa de tu juego?", order = 2)]
          [Space(-10, order = 3)]
          [Header("English:What will be the panel that will contain the", order = 4)]
          [Space(-10, order = 5)]
          [Header("pause menu of your game?", order = 6)]
          [Space(5, order = 7)]
          public CanvasRenderer m_PanelMenu;
          [Header("Espa�ol:�Quieres activar el pausa con", order = 8)]
          [Space(-10, order = 9)]
          [Header("con una bot�n?", order = 10)]
          [Space(-10, order = 11)]
          [Header("English:Do you want to activate the pause with", order = 12)]
          [Space(-10, order = 13)]
          [Header("with a button?", order = 14)]
          [Space(5, order = 15)]
          public BotonPausaJuegoConBoton _buttonOptions;
          [Header("Espa�ol:�Quieres activar la pausa con", order = 15)]
          [Space(-10, order = 16)]
          [Header("una tecla o joystick?", order = 17)]
          [Space(-10, order = 18)]
          [Header("English:Do you want to activate the pause with", order = 19)]
          [Space(-10, order = 20)]
          [Header("a key or joystick?", order = 21)]
          [Space(5, order = 22)]
          public BotonPausaJuegoConTecla _keyOptions;
          [Header("Espa�ol:�Cuando le des al menu, quieres parar", order = 23)]
          [Space(-10, order = 24)]
          [Header("todo el juego?", order = 25)]
          [Space(-10, order = 26)]
          [Header("English:When you click on the menu, do you want to stop", order = 27)]
          [Space(-10, order = 28)]
          [Header("whole set?", order = 29)]
          [Space(5, order = 30)]
          public bool _isPauseGame;
        }
        [System.Serializable]
        public class BotonPausaJuegoConBoton
        {
          [Header("Espa�ol:�Cu�l ser� el bot�n para abrirlo?", order = 0)]
          [Space(-10, order = 1)]
          [Header("English:What will be the button to open it?", order = 2)]
          [Space(5, order = 3)]
          public Button _showButton;
          [Header("Espa�ol:�Cu�l ser� el bot�n para cerrarlo?", order = 4)]
          [Space(-10, order = 5)]
          [Header("English:What will be the button to close it?", order = 6)]
          [Space(5, order = 7)]
          public Button _hiddeButton;
        }
        [System.Serializable]
        public class BotonPausaJuegoConTecla
        {

          [Header("Espa�ol:�Quieres activarlo con una tecla?", order = 8)]
          [Space(-10, order = 9)]
          [Header("English:Do you want to activate it with a key?", order = 10)]
          [Space(5, order = 11)]
          public KeyCode _key;
          [Header("Espa�ol:�Quieres activarlo con un Joystick?", order = 12)]
          [Space(-10, order = 13)]
          [Header("English:Do you want to activate it with a Joystick?", order = 14)]
          [Space(5, order = 15)]
          public joystick _joystick;
          [Header("Espa�ol:�Cu�l ser� la tecla personalizada de ", order = 16)]
          [Space(-10, order = 17)]
          [Header("acci�n r�pida para salir del juego?", order = 18)]
          [Space(-10, order = 19)]
          [Header("English:What will be the quick action own button for", order = 20)]
          [Space(-10, order = 21)]
          [Header("exit game?", order = 22)]
          [Space(5, order = 23)]
          public string _ownButton;
        }
        #endregion

        #region PauseGame Error
        public void GetPauseGameError()
        {
            BotonPausaJuegoConBoton _quitContent = _content._buttonOptions;
            if (_quitContent._showButton == null)
            {
                Debug.LogWarning(SceneManager.GetActiveScene().name + " (SC_MenuProPanelesUI)-----> Opcion 3: Espa�ol:Te falta a�adir el bot�n para activar la pregunta salir" + "\n" + "English:You need to add the button to activate the question exit");
            }
            //Hidden Panel
            if (_quitContent._hiddeButton == null)
            {
                Debug.LogWarning(SceneManager.GetActiveScene().name + " (SC_MenuProPanelesUI)-----> Opcion 3: Espa�ol:Te falta a�adir el bot�n para desactivar la pregunta salir" + "\n" + "English:You need to add the button to deactivate  the question exit");
            }
            //error buttons
            if (_quitContent._showButton == _quitContent._hiddeButton)
            {
               Debug.LogError(SceneManager.GetActiveScene().name + " (SC_MenuBasicoPanelesUI)---->Opcion 3:Espa�ol: No puedes usar el mismo bot�n en el otro lado" + "\n" + "English:You can't use the same button on the other side");
            }
        }
        #endregion

    }
}
