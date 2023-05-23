using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace AlexanderCA.ProMenu.UI
{
    using AlexanderCA.ProMenu.ToolsInspector;
    using AlexanderCA.ProMenu.Enum;
    [System.Serializable]
    public class PrM_PanelInfo 
    {

        #region Panels Explanation
        public ExplicacionPanelActivarDesactivar  _explication;
        public PanelActivarDesactivarContenido    _content;
        [System.Serializable]
        public class ExplicacionPanelActivarDesactivar
        {
            public ExplicacionPanelActivarDesactivarEspañol Español;
            public ExplicacionPanelActivarDesactivarIngles English;
        }

          #region Spanish
          [System.Serializable]
          public class ExplicacionPanelActivarDesactivarEspañol
          {
              public PanelActivarDesactivarTotalEspañol Explicación;
              public PanelActivarDesactivarUsoEspañol Uso;
              public PanelActivarDesactivarAdvertenciaEspañol Advertencia;
          }
          [System.Serializable]
          public class PanelActivarDesactivarTotalEspañol
          {
              #if UNITY_EDITOR
              [PrM_BoxInspector("Este apartado es para controlar que < panel > quiere ocultar o enseñar el jugador al clicar un botón o una tecla. Eje: si tienes un menú principal con 3 botones (jugar, opciones, créditos), cada botón debería abrir un panel diferente y desactivar otro. Al panel que se active puedes colocarle un botón de regreso para que vuelva al estado anterior. Puedes controlar y crear diferentes menús, paneles de armas o el inventario. También tienes acceso para poder hacer las mismas funciones con las teclas o joystick para diferentes menús de juego o si es para mando, la opción se puede desactivar en cualquier momento por si la trama del juego te impide abrir el menú inventario o el de las armas\n\n Uso: Arrastrar los botones y paneles en los huecos indicados. Indica en el nivel si quieres habilitar la opción de abrir el panel con tecla o puedes coger la variable y controlarlo a tu gusto mediante tus scripts. \n\n Advertencia: Recuerda tomarlo como si fueran capas, qué capas quieres que se desactiven y cuales quieres activar. La activación de los objetos <Panel> pueden mezclar botones y teclas por si lo quieres hacer para móvil, pc o mando creando un menú de armas o de inventario que normalmente no suele tener botón para abrirse. El fragmento de la variable sería hacer referencia a esta script ( “script” AEI) < AEI.contenido.m_Opcion5. m_Contenido.m_Panel[NumeroDelPanelQueQuieresControlar]. m_OpcionFuncionTecla  = True/False; según lo que quieras", UnityEditor.MessageType.Info)]
                public bool _a;
               #endif
          }
          [System.Serializable]
          public class PanelActivarDesactivarUsoEspañol
          {
              #if UNITY_EDITOR
              [PrM_BoxInspector("Uso: Arrastrar los botones y paneles en los huecos indicados.Indica en el nivel si quieres habilitar la opción de abrir el panel con tecla o puedes coger la variable y controlarlo a tu gusto mediante tus scripts.", UnityEditor.MessageType.Warning)]
                public bool _a;
              #endif
          }
          [System.Serializable]
          public class PanelActivarDesactivarAdvertenciaEspañol
          {
              #if UNITY_EDITOR
              [PrM_BoxInspector("Advertencia: Recuerda tomarlo como si fueran capas, qué capas quieres que se desactiven y cuales quieres activar. La activación de los objetos <Panel> pueden mezclar botones y teclas por si lo quieres hacer para móvil, pc o mando creando un menú de armas o de inventario que normalmente no suele tener botón para abrirse. El fragmento de la variable sería hacer referencia a esta script ( “script” AEI) < AEI.contenido.m_Opcion5.m_Contenido.m_Panel[NumeroDelPanelQueQuieresControlar].m_OpcionFuncionTecla  = True/False; según lo que quieras", UnityEditor.MessageType.Error)]
                public bool _a;
              #endif
          }
          #endregion

          #region English
          [System.Serializable]
          public class ExplicacionPanelActivarDesactivarIngles
          {
              public PanelActivarDesactivarTotalIngles Explanation;
              public PanelActivarDesactivarUsoIngles Use;
              public PanelActivarDesactivarAdverteciaIngles Warning;
          }
          [System.Serializable]
          public class PanelActivarDesactivarTotalIngles
          {
              #if UNITY_EDITOR
              [PrM_BoxInspector("This section is to control which < panel > wants to hide or show the player when clicking a button or a key. Hub: If you have a main menu with 3 buttons (play, options, credits), each button should open a different panel and deactivate another. To the panel that is activated you can place a return button to return it to the previous state. You can control and create different menus, weapons panels or the inventory. You also have access to be able to perform the same functions with the keys or joystick for different game menus, or if it is for a controller, the option can be deactivated at any time in case the plot of the game prevents you from opening theinventory menu or that of the weapons. \n\n Use: Drag the buttons and panels into the slots indicated. Indicate in the level if you want to enable the option to open the panel with a key or you can take the variable and control it to your liking through your scripts. \n\n Warning: Remember to take it as if they were layers, which layers you want to deactivate and which you want to activate. The activation of <Panel> objects can mix buttons and keys in case you want to do it for mobile, pc or controller creating a weapons or inventory menu that normally does not usually have a button to open. The fragment of the variable would refer to this script (“AEI script”) <AEI.contents.m_Opcion5.m_Content.m_Panel[NumberofthePanelYouWanttoControl].m_OpcionFuncionTecla True / False; according to what you want", UnityEditor.MessageType.Info)]
                public bool _a;
              #endif
          }
          [System.Serializable]
          public class PanelActivarDesactivarUsoIngles
          {
              #if UNITY_EDITOR
              [PrM_BoxInspector("Use: Drag the buttons and panels into the slots indicated. Indicate in the level if you want to enable the option to open the panel with a key or you can take the variable and control it to your liking through your scripts.", UnityEditor.MessageType.Warning)]
                public bool _a;
              #endif
          }
          [System.Serializable]
          public class PanelActivarDesactivarAdverteciaIngles
          {
              #if UNITY_EDITOR
              [PrM_BoxInspector("Warning: Remember to take it as if they were layers, which layers you want to deactivate and which you want to activate. The activation of <Panel> objects can mix buttons and keys in case you want to do it for mobile, pc or controller creating a weapons or inventory menu that normally does not usually have a button to open. The fragment of the variable would refer to this script (“AEI script”) <AEI.contents.m_Opcion5.m_Content.m_Panel[NumberofthePanelYouWanttoControl].m_OpcionFuncionTecla = True / False; according to what you want", UnityEditor.MessageType.Error)]
                public bool _a;
              #endif
          }
          #endregion

        #endregion

        #region Panels Content
        [System.Serializable]
        public class PanelActivarDesactivarContenido
        {
            [Header("Español:¿Cuántos objetos <panel> quieres ", order = 0)]
            [Space(-10, order = 1)]
            [Header("activar/desactivar?", order = 2)]
            [Space(10, order = 3)]
            [Header("English:How many <panel> objects do you want", order = 4)]
            [Space(-10, order = 5)]
            [Header("enable / disable?", order = 6)]
            [Space(5, order = 7)]
            public PanelActivarDesactivarContenido1[] m_Panel;
        }
        [System.Serializable]
        public class PanelActivarDesactivarContenido1
        {
            [Header("Español:¿Cual sera le nombre de este elemento?", order = 0)]
            [Space(-10, order = 1)]
            [Header("English:What will be tha name of this element?", order = 2)]
            [Space(5, order = 3)]
            public string _NameElement;
            [Header("Español:¿Cuáles serán los objetos del _showPanel?", order = 4)]
            [Space(-10, order = 5)]
            [Header("English:What will be the objects of _showPanel?", order = 6)]
            [Space(5, order = 7)]
            public CanvasRenderer[] _oldPanel;
            [Header("Español:¿Cuáles serán los objetos del _newPanel?", order = 8)]
            [Space(-10, order = 9)]
            [Header("English:What will be the objects of _newPanel?", order = 10)]
            [Space(5, order = 11)]
            public CanvasRenderer[] _newPanel;
            [Header("Español:¿Qué botón activará _newPanel y desactivará", order = 12)]
            [Space(-10, order = 13)]
            [Header("_oldPanel?", order = 14)]
            [Space(-10, order = 15)]
            [Header("English:Which button will activate _newPanel and deactivate", order = 16)]
            [Space(-10, order = 17)]
            [Header("_oldPanel?", order = 18)]
            [Space(5, order = 19)]
            public Button _newButton;
            [Header("Español:¿Quá botón desactivará _newPanel y activará", order = 20)]
            [Space(-10, order = 21)]
            [Header("_oldPanel?", order = 22)]
            [Space(-10, order = 23)]
            [Header("English:Which button will disable _newPanel and enable", order = 24)]
            [Space(-10, order = 25)]
            [Header("_oldPanel?", order = 26)]
            [Space(5, order = 27)]
            public Button _backButton;
            [Header("Español:¿Quieres activar/desactivar objetos <Panel> con", order = 28)]
            [Space(-10, order = 29)]
            [Header("tecla o joystick ?", order = 30)]
            [Space(-10, order = 31)]
            [Header("English:Do you want to activate / deactivate <Panel> objects", order = 32)]
            [Space(-10, order = 33)]
            [Header("with key or joystick?", order = 34)]
            [Space(5, order = 35)]
            public PanelActivarTecla _keyOptions;
            //// [HideInInspector]
            //public bool m_m1;
        }

        [System.Serializable]
        public class PanelActivarTecla
        {

            [Header("Español:¿Cuál será la tecla que controlara este", order = 0)]
            [Space(-10, order = 1)]
            [Header("panel?", order = 2)]
            [Space(-10, order = 3)]
            [Header("English:What will be the key that will control this", order = 4)]
            [Space(-10, order = 5)]
            [Header("panel?", order = 6)]
            [Space(5, order = 7)]
            public KeyCode _keyButton;
            [Header("Español:¿Cuál será la joystick que controlará este", order = 8)]
            [Space(-10, order = 9)]
            [Header("panel?", order = 10)]
            [Space(-10, order = 11)]
            [Header("English: What will be the joystick that will control this", order = 12)]
            [Space(-10, order = 13)]
            [Header("panel?", order = 14)]
            [Space(5, order = 15)]
            public joystick _joystickButton;            
            [Header("Español:¿Cuál será la joystick que controlará este", order = 16)]
            [Space(-10, order = 17)]
            [Header("panel?", order = 18)]
            [Space(-10, order = 19)]
            [Header("English: What will be the joystick that will control this", order = 20)]
            [Space(-10, order = 21)]
            [Header("panel?", order = 22)]
            [Space(5, order = 23)]
            public string _ownButton;
        }
        #endregion

        #region Panels Error
        /// <summary>
        /// This is to said when there will be an error
        /// </summary>        
        public void GetErrorPanel(int _i)
        {
            PanelActivarDesactivarContenido1 _panel = _content.m_Panel[_i];
            string _element = _content.m_Panel[_i]._NameElement != "" ? _content.m_Panel[_i]._NameElement : ("Element_" + _i);
            if (_panel._newButton != null && _panel._backButton != null && _panel._backButton == _panel._newButton)
            {
                  Debug.LogError(SceneManager.GetActiveScene().name + " (PrM_UIManager)---->Option 5:Español: No puedes usar el mismo botón en el otro lado" + "\n" + "English:You can't use the same button on the other side");
            }            

        }
        #endregion

    }
}
