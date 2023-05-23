using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace AlexanderCA.ProMenu.UI
{
    using AlexanderCA.ProMenu.ToolsInspector;
    [System.Serializable]
    public class PrM_LoadGameInfo 
    {
        #region Loading explication

          public ExplicacionCargarNivel _explication;
          public BotonCargarNivelPreContenido _content;
          [System.Serializable]
          public class ExplicacionCargarNivel
          {
            public ExplicacionCargarNivelEspañol Español;
            public ExplicacionCargarNivelIngles English;
          }

          #region Español
          [System.Serializable]
          public class ExplicacionCargarNivelEspañol
          {
            public CargarNivelTotalEspañol Explicación;
            public CargarNivelUsoEspañol Uso;
            public CargarNivelAdvertenciaEspañol Advertencia;
          }
          [System.Serializable]
          public class CargarNivelTotalEspañol
          {
            #if UNITY_EDITOR
            [PrM_BoxInspector("Este apartado es para asignar al botón o botones la funcionalidad de cargar un nivel de tu juego. \nTambién tienes la posibilidad de preguntar al jugador si realmente quiere cargar ese nivel. Al asignar el <panel> pregunta, deberéis crear vosotros los elementos gráficos de interfaz, con la pregunta y los botones de respuesta. La script otorga funcionalidad a estos botones para activar y desactivar panel y el botón para que cargue el nivel\n\n Uso: En el caso que sólo queráis poner un botón sin la pregunta solo tenéis que arrastrar ese objeto a la ranura de función cargar nivel. En el caso de que queráis poner una pregunta, el botón de cargar nivel tendrá que ser el que active la  pregunta, y la respuesta SI la poneis con la función <cargar nivel> y la respuesta NO será la que desactive la pregunta. El nivel se asigna mediante una enumeración (siendo 0 una posibilidad) Hallaréis el número que acompaña al nivel en File>build settings> y debéis arrastrar el botón que activará el nive \n\n Advertencia: la parte gráfica, la pregunta y colocar los botones en su sitio lo tendréis que hacer vosotros.Yo solo os facilito abrir/cerrar panel", UnityEditor.MessageType.Info)]
            public bool _a;
            #endif
          }
          [System.Serializable]
          public class CargarNivelUsoEspañol
          {
            #if UNITY_EDITOR
            [PrM_BoxInspector("Uso: En el caso que sólo queráis poner un botón sin la pregunta solo tenéis que arrastrar ese objeto a la ranura de función cargar nivel. En el caso de que queráis poner una pregunta, el botón de cargar nivel tendrá que ser el que active la  pregunta, y la respuesta SI la poneis con la función <cargar nivel> y la respuesta NO será la que desactive la pregunta. El nivel se asigna mediante una enumeración (siendo 0 una posibilidad) Hallaréis el número que acompaña al nivel en File>build settings> y debéis arrastrar el botón que activará el nive", UnityEditor.MessageType.Warning)]
            public bool _a;
            #endif
          }
          [System.Serializable]
          public class CargarNivelAdvertenciaEspañol
          {
            #if UNITY_EDITOR
            [PrM_BoxInspector("Advertencia: la parte gráfica, la pregunta y colocar los botones en su sitio lo tendréis que hacer vosotros.Yo solo os facilito abrir/cerrar panel", UnityEditor.MessageType.Error)]
            public bool _a;
            #endif
          }
          #endregion

          #region English
          [System.Serializable]
          public class ExplicacionCargarNivelIngles
          {
            public CargarNivelTotalIngles Explanation;
            public CargarNivelUsoIngles Use;
            public CargarNivelAdverteciaIngles Warning;
          }
          [System.Serializable]
          public class CargarNivelTotalIngles
          {        
            #if UNITY_EDITOR
            [PrM_BoxInspector("This section is to assign to the button or buttons the functionality of loading a level of your game. \nYou also have the possibility to ask the player if he really wants to load that level. When assigning the question <panel>, you must create the graphical interface elements, with the question and the answer buttons. The script gives functionality to these buttons to activate and deactivate panel and the button to load the level\n\n Use: In the case that you only want to put a button without the question, you only have to drag that object to the load level function slot. In case you want to ask a question, the level load button will have to be the one that activates the question, and you put the answer YES with the <load level> function and the answer will NOT be the one that deactivates the question. The level is assigned by means of an enumeration (0 being a possibility) you will find the number that accompanies the level in File> build settings> and you must drag the button that will activate the level\n\n Warning: the graphic part, the question and placing the buttons in their place will have to be done by you. I only facilitate you to open / close the panel.", UnityEditor.MessageType.Info)]
            public bool _a;
            #endif
          }

          [System.Serializable]
          public class CargarNivelUsoIngles
          {
            #if UNITY_EDITOR
            [PrM_BoxInspector("Use: In the case that you only want to put a button without the question, you only have to drag that object to the load level function slot. In case you want to ask a question, the level load button will have to be the one that activates the question, and you put the answer YES with the <load level> function and the answer will NOT be the one that deactivates the question. The level is assigned by means of an enumeration (0 being a possibility) you will find the number that accompanies the level in File> build settings> and you must drag the button that will activate the level", UnityEditor.MessageType.Warning)]
            public bool _a;
            #endif
          }
          [System.Serializable]
          public class CargarNivelAdverteciaIngles
          {
            #if UNITY_EDITOR
            [PrM_BoxInspector("Warning: the graphic part, the question and placing the buttons in their place will have to be done by you. I only facilitate you to open / close the panel.", UnityEditor.MessageType.Error)]
            public bool _a;
            #endif
          }
        #endregion

        #endregion

        #region  Loading Content

        [System.Serializable]
        public class BotonCargarNivelPreContenido
        {
          [Header("Español:¿Cuántos botones quieres poner para cargar", order = 0)]
          [Space(-10, order = 1)]
          [Header("diferentes niveles?", order = 3)]
          [Space(-10, order = 4)]
          [Header("English:How many buttons do you want to put to load", order = 5)]
          [Space(-10, order = 6)]
          [Header("different levels?", order = 7)]
          [Space(3, order = 8)]
          public BotonCargarNivelContenido[] _buttonsArray;
        }    
        [System.Serializable]
        public class BotonCargarNivelContenido
        {
          [Header("Español:Quieres poner un nombre para", order = 0)]
          [Space(-10, order = 1)]
          [Header("este elemento?", order = 2)]
          [Space(-10, order = 3)]
          [Header("English:Do you want to put a ", order = 4)]
          [Space(-10, order = 5)]
          [Header("name for this element?", order = 6)]
          [Space(5, order = 7)]
          public string _nameButton;
          [Header("Español:¿Cuál será el nivel que quieres cargar?", order = 8)]
          [Space(-10, order = 9)]
          [Header("English:What will be the level you want to load?", order = 10)]
          [Space(5, order = 11)]
          public int _iDLevel;
          [Header("Español:¿Cuál será el botón para cargar el nivel?", order = 12)]
          [Space(-10, order = 13)]
          [Header("English:What will be the button to load the level?", order = 14)]
          [Space(5, order = 15)]
          public Button _loadButton;
          [Header("Español: ¿Quieres activar un panel de pregunta", order = 16)]
          [Space(-10, order = 17)]
          [Header("antes de cargar nivel?", order = 18)]
          [Space(-10, order = 19)]
          [Header("English: Do you want to activate a question panel", order = 20)]
          [Space(-10, order = 21)]
          [Header("before loading level?", order = 22)]
          [Space(5, order = 23)]
          public LoadingCuestion _loadQuestion;
        }
        [System.Serializable]
        public class LoadingCuestion
        {
          [Header("Español:¿Cuál será el <panel> que contendrá la", order = 0)]
          [Space(-10, order = 1)]
          [Header("pregunta y los botones?", order = 2)]
          [Space(-10, order = 3)]
          [Header("English:What will be the <panel> that will contain the", order = 4)]
          [Space(-10, order = 5)]
          [Header("question and buttons?", order = 6)]
          [Space(5, order = 7)]
          public CanvasRenderer _panelQuestion;
          [Header("Español:¿Cuál será el botón para abrir el panel", order = 8)]
          [Space(-10, order = 9)]
          [Header("pregunta?", order = 10)]
          [Space(-10, order = 11)]
          [Header("English:What will be the button to open the panel", order = 12)]
          [Space(-10, order = 13)]
          [Header("question?", order = 14)]
          [Space(5, order = 15)]
          public Button _showButton;
          [Header("Español:¿Cuál será el botón para cerrar el panel", order = 16)]
          [Space(-10, order = 17)]
          [Header("pregunta?", order = 18)]
          [Space(-10, order = 19)]
          [Header("English:What will be the button to close the panel", order = 20)]
          [Space(-10, order = 21)]
          [Header("question?", order = 22)]
          [Space(5, order = 23)]
          public Button _hiddenButton;
        }
        #endregion

        #region Loading Error
        /// <summary>
        /// This is to said when there will be an error
        /// </summary>
          public void GetErrorLoadLevel(int _i)
          {
                BotonCargarNivelContenido _contentError = _content._buttonsArray[_i];
                string _element = _contentError._nameButton != "" ? _contentError._nameButton : ("Element_" + _i);
                if (_contentError._loadButton != null && _contentError._loadQuestion._panelQuestion)
                {
                      LoadingCuestion _panel = _contentError._loadQuestion;
                      if (_panel._showButton == null)
                      {
                          Debug.LogWarning(SceneManager.GetActiveScene().name + " (PrM_UIManger)-----> Option 1: Español:Te falta añadir el botón para activar la pregunta Cargar un nivel,en el " + _element + "\n" + "English:You need to add the button to activate the question Load a level, the " + _element);
                      }
                      //Hidden Panel
                      if (_panel._hiddenButton == null)
                      {
                          Debug.LogWarning(SceneManager.GetActiveScene().name + " (PrM_UIManger)-----> Option 1: Español:Te falta añadir el botón para desactivar la pregunta Cargar un nivel,en el " + _element + "\n" + "English:You need to add the button to deactivate the question Load a level, the " + _element);
                      }
                      //error buttons
                      if ( (_contentError._loadButton != null && _contentError._loadButton == _panel._hiddenButton) || (_panel._hiddenButton != null && _contentError._loadButton == _panel._showButton )|| (_panel._showButton != null && _panel._hiddenButton == _panel._showButton))
                      {
                          Debug.LogWarning(SceneManager.GetActiveScene().name + " (PrM_UIManger)-----> Option 1: Español:No puedes poner el mismo objeto en diferentes ranuras, en el " + _element + "\n" + "English:You cannot put the same item in different slots, the " + _element);
                      }
                }
                else
                {
                    if(_contentError._loadButton == null)
                    Debug.LogWarning(SceneManager.GetActiveScene().name + " (PrM_UIManger)-----> Option 1: Español:Te falta añadir el botón , en el " + _element + "\n" + "English:You need to add the button, the " + _element);
                }
          }

        #endregion
    }
}
