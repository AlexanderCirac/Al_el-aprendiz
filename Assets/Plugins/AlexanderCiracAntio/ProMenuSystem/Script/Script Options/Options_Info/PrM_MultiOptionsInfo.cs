using UnityEngine;
using UnityEngine.UI;

namespace AlexanderCA.ProMenu.Opciones
{
    using AlexanderCA.ProMenu.ToolsInspector;
    using AlexanderCA.ProMenu.Enum;
    [System.Serializable]
    public class PrM_MultiOptionsInfo
    {
        [System.Serializable]
        public class ExplicacionMultiOpciones
        {
          public ExplicacionMultiOpcionesEspañol Español;
          public ExplicacionMultiOpcionesIngles English;
        }
        public ExplicacionMultiOpciones m_Explicación;
        public MultiOpcionesContenido1 m_Contenido;

        #region MultiOptions Explanation

          #region Spanish
          [System.Serializable]
          public class ExplicacionMultiOpcionesEspañol
          {
            public ExplicacionMultiOpcionesTotalEspañol Explicación;
            public ExplicacionMultiOpcionesUsoEspañol Uso;
            public ExplicacionMultiOpcionesAdvertenciaEspañol Advertencia;
          }
          [System.Serializable]
          public class ExplicacionMultiOpcionesTotalEspañol
          {
            #if UNITY_EDITOR
            [PrM_BoxInspector("Este apartado será para controlar la opción gráfica de forma general o específica de algunos aspectos. \nLas opciones que te permite controlar este sistema son sombras, resolución, antialiasing, texturas... Indica como quieres que estos cambios se realicen,si lo quieres de forma automática o con botón de <Aplicar cambios> y si quieres también hay botón de resetear valores. En cada apartado  puedes asignar cuáles son sus valores predeterminados.\n\n Uso: Cada apartado despliegas y arrastras los diferentes botones, triggers y Dropdown para que tengan la función que el usuario quiera. Luego define cuál será la opción predefinida que empezará antes de que el jugador lo pueda  modificar. Estas opciones pueden ser de diferentes tipos: si es un <Bool> seleccionas quieres que empiece en True/False y si es el caso de una lista, seleccionas y en el desplegable escoges el valor que quieres. Tendrás que indicar cómo quieres que los cambio se reflejen desplegando su apartado y escogiendo la ranura que más te interese ( no se puede mezclar)\n\n Advertencia: En el caso de que se quiera acceder a las variables para guardar informaciones y reeditaciones mediante vuestros script, encontrarás en cada apartado una sección extra que pondrá variables y si es el caso de una lista, seleccionas y en el desplegable escoges el valor que quieres. Si se queré ver las variables, para controlar su funcionamiento, abrid este scritp y comentar con < // >; en la parte de arriba de la variable deseada que tenga <[HideInInspector]>", UnityEditor.MessageType.Info)]
            public bool _a;
            #endif
          }
          [System.Serializable]
          public class ExplicacionMultiOpcionesUsoEspañol
          {
            #if UNITY_EDITOR
            [PrM_BoxInspector("Uso: Cada apartado despliegas y arrastras los diferentes botones, triggers y Dropdown para que tengan la función que el usuario quiera. Luego define cuál será la opción predefinida que empezará antes de que el jugador lo pueda  modificar. Estas opciones pueden ser de diferentes tipos: si es un <Bool> seleccionas quieres que empiece en True/False y si es el caso de una lista, seleccionas y en el desplegable escoges el valor que quieres. Tendrás que indicar cómo quieres que los cambio se reflejen desplegando su apartado y escogiendo la ranura que más te interese ( no se puede mezclar)", UnityEditor.MessageType.Warning)]
            public bool _a;
            #endif
          }
          [System.Serializable]
          public class ExplicacionMultiOpcionesAdvertenciaEspañol
          {
            #if UNITY_EDITOR
            [PrM_BoxInspector("Advertencia: En el caso de que se quiera acceder a las variables para guardar informaciones y reeditaciones mediante vuestros script, encontrarás en cada apartado una sección extra que pondrá variables y si es el caso de una lista, seleccionas y en el desplegable escoges el valor que quieres. Si se queré ver las variables, para controlar su funcionamiento, abrid este scritp y comentar con < // >; en la parte de arriba de la variable deseada que tenga <[HideInInspector]>", UnityEditor.MessageType.Error)]
            public bool _a;
            #endif
          }
          #endregion

          #region English
          [System.Serializable]
          public class ExplicacionMultiOpcionesIngles
          {
            public ExplicacionMultiOpcionesTotalIngles Explanation;
            public ExplicacionMultiOpcionesUsoIngles Use;
            public ExplicacionMultiOpcionesAdvertenciIngles Warning;
          }
          [System.Serializable]
          public class ExplicacionMultiOpcionesTotalIngles
          {
            #if UNITY_EDITOR
            [PrM_BoxInspector("This section will be to control the graphic option in a general or specific way of some aspects. \nThe options that allow you to control this system are shadows, resolution, antialiasing, textures ... Indicate how you want these changes to be made, if you want it automatically or with the <Apply changes> button and if you want there is also a reset button values. In each section you can assign what their default values ​​are.\n\n Use: Each section you display and drag the different buttons, triggers and Dropdown so that they have the function that the user wants. Then define what will be the predefined option that will start before the player can modify it. These options can be of different types: if it is a <Bool> you select you want it to start in True / False and if it is the case of a list, you select and in the drop-down you choose the value how you want the changes to be reflected by displaying its section and choosing the slot that interests you the most (it cannot be mixed).\n\n Warning: In the event that you want to access the variables to save information and reissues through your script, you will find in each section an extra section that will put variables. If you want to see the variables, to control their operation, open this script and comment with <//>; at the top of the desired variable that has <[HideInInspector]>", UnityEditor.MessageType.Info)]
            public bool _a;
            #endif
          }
          [System.Serializable]
          public class ExplicacionMultiOpcionesUsoIngles
          {
            #if UNITY_EDITOR
            [PrM_BoxInspector("Use: Each section you display and drag the different buttons, triggers and Dropdown so that they have the function that the user wants. Then define what will be the predefined option that will start before the player can modify it. These options can be of different types: if it is a <Bool> you select you want it to start in True / False and if it is the case of a list, you select and in the drop-down you choose the value how you want the changes to be reflected by displaying its section and choosing the slot that interests you the most (it cannot be mixed)", UnityEditor.MessageType.Warning)]
            public bool _a;
            #endif
          }
          [System.Serializable]
          public class ExplicacionMultiOpcionesAdvertenciIngles
          {
            #if UNITY_EDITOR
            [PrM_BoxInspector("Warning: In the event that you want to access the variables to save information and reissues through your script, you will find in each section an extra section that will put variables. If you want to see the variables, to control their operation, open this script and comment with <//>; at the top of the desired variable that has <[HideInInspector]>", UnityEditor.MessageType.Error)]
            public bool _a;
            #endif
          }
        #endregion

        #endregion

        #region MultiOptions Content
        [System.Serializable]
        public class MultiOpcionesContenido1
        {
          [Header("Español:¿Cómo quieres que se efectúen estos cambios?", order = 0)]
          [Space(-10, order = 1)]
          [Header("English:How do you want these changes to take place?", order = 2)]
          [Space(5, order = 3)]
          public OpcionCambios _howApplyChanges;
          [Header("Español:¿Quieres una opción de  Vsync?", order = 4)]
          [Space(-10, order = 5)]
          [Header("English:Do you want a Vsync option?", order = 6)]
          [Space(5, order = 7)]
          public OpcionVsync _vsync;
          [Header("Español:¿Quieres una opción para controlar la calidad de", order = 8)]
          [Space(-10, order = 9)]
          [Header("las sombras?", order = 10)]
          [Space(-10, order = 11)]
          [Header("English:Do you want an option to control the quality of", order = 12)]
          [Space(-10, order = 13)]
          [Header("the shadows?", order = 14)]
          [Space(5, order = 15)]
          public OpcionCalidadSombras _shadowQuality;
          [Header("Español:¿Quieres una opción para controlar la resolución", order = 16)]
          [Space(-10, order = 17)]
          [Header("de la pantalla?", order = 19)]
          [Space(-10, order = 20)]
          [Header("English:Do you want an option to control the resolution", order = 21)]
          [Space(-10, order = 22)]
          [Header("from the screen?", order = 23)]
          [Space(5, order = 24)]
          public OpcionResolucionPantalla _screenResolution;
          [Header("Español:¿Quieres una opción para controlar el modo pantalla", order = 25)]
          [Space(-10, order = 26)]
          [Header("completo?", order = 27)]
          [Space(-10, order = 28)]
          [Header("English:Do you want an option to control the screen mode", order = 29)]
          [Space(-10, order = 30)]
          [Header("full?", order = 31)]
          [Space(5, order = 32)]
          public OpcionModoPantalla _windowsMode;
          [Header("Español:¿Quieres una opción para controlar el modo gráfico?", order = 33)]
          [Space(-10, order = 34)]
          [Header("English:Do you want an option to control the graphics mode?", order = 35)]
          [Space(5, order = 36)]
          public OpcionModoGrafico _grafics;
          [Header("Español:¿Quieres una opción para controlar el antialiasing?", order = 37)]
          [Space(-10, order = 38)]
          [Header("English:Do you want an option to control antialiasing?", order = 39)]
          [Space(5, order = 40)]
          public OpcionAntialasing _antialasing;
          [Header("Español:¿Quieres una opción para indicar cuál será el FPS?", order = 41)]
          [Space(-10, order = 42)]
          [Header("English:Do you want an option to indicate what the FPS will be?", order = 43)]
          [Space(5, order = 44)]
          public OpcionFPS _fps;
        }
        [System.Serializable]
        public class OpcionCambios
        {
          [Header("Español:¿Quieres un botón para aplicar los cambios?", order = 0)]
          [Space(-10, order = 1)]
          [Header("English:Do you want a button to apply the changes?", order = 2)]
          [Space(5, order = 3)]
          public Button _changeBotton;
          [Header("Español:¿Quieres un botón para resetear los cambios?", order = 4)]
          [Space(-10, order = 5)]
          [Header("English:Do you want a button to reset the changes?", order = 6)]
          [Space(5, order = 7)]
          public Button _resetBotton;
          [Header("Español:¿Prefieres que los cambios se apliquen automáticamente?", order = 8)]
          [Space(-10, order = 9)]
          [Header("English:Do you prefer the changes to be applied automatically?", order = 10)]
          [Space(5, order = 11)]
          public bool _automatic;
        }

        [System.Serializable]
        public class OpcionVsync
        {
          [Header("Español:¿Cuál será el <Toggle> del Vsync?", order = 0)]
          [Space(-10, order = 1)]
          [Header("English:What will be the <Toggle> of Vsync?", order = 2)]
          [Space(5, order = 3)]
          public Toggle _vsyncToggle;
          [Header("Español:¿Cuál será el valor predeterminado del Vsync?", order = 4)]
          [Space(-10, order = 5)]
          [Header("English:What will be the default value of Vsync?", order = 6)]
          [Space(5, order = 7)]
          public bool _vsyncDefoult;
        }
        [System.Serializable]
        public class OpcionCalidadSombras
        {
          [Header("Español:¿Cuál será el <Dropdown> para controlar la calidad", order = 0)]
          [Space(-10, order = 1)]
          [Header("de las sombras?", order = 2)]
          [Space(-10, order = 3)]
          [Header("English:What will be the <Dropdown> to control the quality", order = 4)]
          [Space(-10, order = 5)]
          [Header("from the shadows?", order = 6)]
          [Space(5, order = 7)]
          public Dropdown _shadowDropdown;
          [Header("Español:¿Cuál será el valor predeterminado de la calidad", order = 8)]
          [Space(-10, order = 9)]
          [Header("de las sombras?", order = 10)]
          [Space(-10, order = 11)]
          [Header("English:What will be the default value of the quality", order = 12)]
          [Space(-10, order = 13)]
          [Header("from the shadows?", order = 14)]
          [Space(5, order = 15)]
          public e_calidadSombras _shadowDefoult;
        }
        [System.Serializable]
        public class OpcionResolucionPantalla
        {
          [Header("Español:¿Cuál será el <Dropdown> para controlar la resolución", order = 0)]
          [Space(-10, order = 1)]
          [Header("de la pantalla?", order = 2)]
          [Space(-10, order = 3)]
          [Header("English:What will be the <Dropdown> to control the resolution", order = 4)]
          [Space(-10, order = 5)]
          [Header("from the screen?", order = 6)]
          [Space(5, order = 7)]
          public Dropdown _screenResolDropwdown;
        }

        [System.Serializable]
        public class OpcionModoPantalla
        {
          [Header("Español:¿Cuál será el <Toggle> para el modo pantalla?", order = 0)]
          [Space(-10, order = 1)]
          [Header("English:What will be the <Toggle> for screen mode?", order = 2)]
          [Space(5, order = 3)]
          public Toggle _windowsToggle;
          [Header("Español:¿Cuál será el valor predeterminado para el modo pantalla?", order = 4)]
          [Space(-10, order = 5)]
          [Header("English:What will be the default value for screen mode?", order = 6)]
          [Space(5, order = 7)]
          public bool _windowsDefoult;
        }

        [System.Serializable]
        public class OpcionModoGrafico
        {
          [Header("Español:¿Cuál será el <Dropdown>para controlar el modo ", order = 0)]
          [Space(-10, order = 1)]
          [Header("gráfico?", order = 2)]
          [Space(-10, order = 3)]
          [Header("English:What will be the <Dropdown> to control the mode", order = 4)]
          [Space(-10, order = 5)]
          [Header("graphic?", order = 6)]
          [Space(5, order = 7)]
          public Dropdown _graficDropdown;
          [Header("Español:¿Cuál será el valor predeterminado controlar", order = 8)]
          [Space(-10, order = 9)]
          [Header("el modo gráfico?", order = 10)]
          [Space(-10, order = 11)]
          [Header("English:What will be the default value to control", order = 12)]
          [Space(-10, order = 13)]
          [Header("graphics mode?", order = 14)]
          [Space(5, order = 15)]
          public e_CalidadGrafica _graficDefoult;
        }
        [System.Serializable]
        public class OpcionAntialasing
        {
          [Header("Español:¿Cuál será el <Dropdown>para controlar el", order = 0)]
          [Space(-10, order = 1)]
          [Header("antialiasing?", order = 2)]
          [Space(-10, order = 3)]
          [Header("English:What will be the <Dropdown> to control the", order = 4)]
          [Space(-10, order = 5)]
          [Header("antialiasing?", order = 6)]
          [Space(5, order = 7)]
          public Dropdown _antialasingDropdown;
          [Header("Español:¿Cuál será el valor predeterminado controlar", order = 8)]
          [Space(-10, order = 9)]
          [Header("el antialiasing?", order = 10)]
          [Space(-10, order = 11)]
          [Header("English:What will be the default value to control", order = 12)]
          [Space(-10, order = 13)]
          [Header("antialiasing?", order = 14)]
          [Space(5, order = 15)]
          public e_Antialasing _antialasingDefoult;
        }

        [System.Serializable]
        public class OpcionFPS
        {
          [Header("Español:¿Cuál será el <Dropdown> para indicar cual", order = 0)]
          [Space(-10, order = 1)]
          [Header("será el FPS?", order = 2)]
          [Space(-10, order = 3)]
          [Header("English:What will be the <Dropdown> to indicate which", order = 4)]
          [Space(-10, order = 5)]
          [Header("will it be the FPS?", order = 6)]
          [Space(5, order = 7)]
          public Dropdown _fpsDropdown;
          [Header("Español:¿Cuál será el valor predeterminado para", order = 8)]
          [Space(-10, order = 9)]
          [Header("indicar cuál será el FPS?", order = 10)]
          [Space(-10, order = 11)]
          [Header("English: What will be the default value for", order = 12)]
          [Space(-10, order = 13)]
          [Header("indicate what the FPS will be?", order = 14)]
          [Space(5, order = 15)]
          public e_FPS _fpsDefoult;
        }
        #endregion

        #region MultiOptions Error
        /// <summary>
        /// This is to said when there will be an error
        /// </summary>        
        public void GetErrorMultiOptions(int _i)
        {

        }
        #endregion

    }
}
