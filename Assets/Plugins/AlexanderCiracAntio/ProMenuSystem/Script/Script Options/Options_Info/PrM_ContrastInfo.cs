using UnityEngine;
using UnityEngine.UI;

namespace AlexanderCA.ProMenu.Opciones
{
    using AlexanderCA.ProMenu.ToolsInspector;
    [System.Serializable]
    public class PrM_ContrastInfo
    {

        #region Contrast Explanation
          public ExplicacionContraste _explication;
          public ContrasteContenido1 _content;
          [System.Serializable]
          public class ExplicacionContraste
          {
            public ExplicacionContrasteEspa�ol Espa�ol;
            public ExplicacionContrasteIngles English;
          }

          #region Spanish
          [System.Serializable]
          public class ExplicacionContrasteEspa�ol
          {
            public ExplicacionContrasteTotalEspa�ol Explicaci�n;
            public ExplicacionContrasteUsoEspa�ol Uso;
            public ExplicacionContrasteAdvertenciaEspa�ol Advertencia;
          }
          [System.Serializable]
          public class ExplicacionContrasteTotalEspa�ol
          {
                #if UNITY_EDITOR
                [PrM_BoxInspector("Este apartado ser� para controlar el contraste del juego. \n\n Uso: Arrastra la barra que tiene que ser un objeto <Scrollbar>  y coloca las diferentes c�maras que el jugador ver� a trav�s de ella. En el caso de que X nivel no tenga men� de opciones, solo con que le pases la variable ( que te facilitar�) y rellenes las c�maras, tendr�a que funcionar todo bien. \n\n Advertencia: Recuerda que si el nivel actual no tiene opciones para que siga afectando al controlador del contraste solo tienes que colocar las c�maras en la ranura para que efect�e el contraste. Para poder coger las variables solo se necesita poner m_intContraste", UnityEditor.MessageType.Info)]
                public bool _a;
                #endif
          }

          [System.Serializable]
          public class ExplicacionContrasteUsoEspa�ol
          {
                #if UNITY_EDITOR
                [PrM_BoxInspector("Uso: Arrastra la barra que tiene que ser un objeto <Scrollbar>  y coloca las diferentes c�maras que el jugador ver� a trav�s de ella. En el caso de que X nivel no tenga men� de opciones, solo con que le pases la variable ( que te facilitar�) y rellenes las c�maras, tendr�a que funcionar todo bien.", UnityEditor.MessageType.Warning)]
                public bool _a;
                #endif
          }
          [System.Serializable]
          public class ExplicacionContrasteAdvertenciaEspa�ol
          {
                #if UNITY_EDITOR
                [PrM_BoxInspector("Advertencia: Recuerda que si el nivel actual no tiene opciones para que siga afectando al controlador del contraste solo tienes que colocar las c�maras en la ranura para que efect�e el contraste. Para poder coger las variables solo se necesita poner m_intContraste", UnityEditor.MessageType.Error)]
                public bool _a;
                #endif
          }
          #endregion

          #region English

          [System.Serializable]
          public class ExplicacionContrasteIngles
          {
            public ExplicacionContrasteTotalIngles Explanation;
            public ExplicacionContrasteUsoIngles Use;
            public ExplicacionContrasteAdvertenciIngles Warning;
          }

          [System.Serializable]
          public class ExplicacionContrasteTotalIngles
          {
                #if UNITY_EDITOR
                [PrM_BoxInspector("This section will be to control the contrast. of the game. \n\n Use: Drag the bar that has to be a <Scrollbar> object and place the different cameras that the player will see through it. In the event that X level does not have a menu of options, only if you pass the variable to it (which I will provide you) and fill in the chambers, everything should work fine. \n\n Warning: Remember that if the current level does not have options to continue affecting the contrast controller, you only have to place the cameras in the slot to make the contrast. To be able to take the variables you only need to put m_int Contrast", UnityEditor.MessageType.Info)]
                public bool _a;
                #endif
          }
          [System.Serializable]
          public class ExplicacionContrasteUsoIngles
          {
                #if UNITY_EDITOR
                [PrM_BoxInspector("Use: Drag the bar that has to be a < Scrollbar >  object and place the different cameras that the player will see through it. In the event that X level does not have a menu of options, only if you pass the variable to it (which I will provide you) and fill in the chambers, everything should work fine.", UnityEditor.MessageType.Warning)]
                public bool _a;
                #endif
          }
          [System.Serializable]
          public class ExplicacionContrasteAdvertenciIngles
          {
                #if UNITY_EDITOR
                [PrM_BoxInspector("Warning: Remember that if the current level does not have options to continue affecting the contrast controller, you only have to place the cameras in the slot to make the contrast. To be able to take the variables you only need to put m_int Contrast", UnityEditor.MessageType.Error)]
                public bool _a;
                #endif
          }
          #endregion

        #endregion

        #region Contrast Content
        [System.Serializable]
        public class ContrasteContenido1
        {
          [Header("Espa�ol:�Cuales y cuantas camaras ser�n?", order = 0)]
          [Space(-10, order = 1)]
          [Header("English:What and how many cameras will", order = 2)]
          [Space(-10, order = 3)]
          [Header("there be?", order = 4)]
          [Space(5, order = 5)]
          public Camera[] _camera;
          [Header("Espa�ol:�Cu�l ser� el <Scrollbar> que", order = 6)]
          [Space(-10, order = 7)]
          [Header("controlar� el contraste?", order = 8)]
          [Space(-10, order = 9)]
          [Header("English:What will be the <Scrollbar> that", order = 10)]
          [Space(-10, order = 11)]
          [Header("will control the contrast?", order = 12)]
          [Space(5, order = 13)]
          public Scrollbar _contrastScrollbar;
          [Header("Espa�ol:�Cu�l ser� la barra que controlar� el", order = 4)]
          [Space(-10, order = 5)]
          [Header("brillo de la escena?", order = 6)]
          [Space(-10, order = 7)]
          [Header("English:What will be the bar that will control the", order = 8)]
          [Space(-10, order = 9)]
          [Header("brightness of the scene?", order = 10)]
          [Space(5, order = 11)]
          public Scrollbar _brightScrollbar;
          [Header("Espa�ol: �Cu�l ser� el valor que tendr� de base", order = 14)]
          [Space(-10, order = 15)]
          [Header("la opci�n Contraste?", order = 16)]
          [Space(-10, order = 17)]
          [Header("English:What will be the base value the Contrast option?", order = 18)]
          [Space(5, order = 19)]
          [Range(0,1)]
          public float _contrastFloat;
          [Header("Espa�ol:�Cu�l ser� el valor que tendr�a de base", order = 12)]
          [Space(-10, order = 13)]
          [Header("el brillo de la escena?", order = 14)]
          [Space(-10, order = 15)]
          [Header("English:What will be the base value the", order = 16)]
          [Space(-10, order = 17)]
          [Header("brightness of the scene?", order = 18)]
          [Space(5, order = 19)]
          [Range(0,1)]
          public float _brightFloat;
    }
        #endregion

        #region contrast Error
        /// <summary>
        /// This is to said when there will be an error
        /// </summary>        
        public void GetErrorContrast(int _i)
        {
          //Debug.LogWarning(SceneManager.GetActiveScene().name + " (SC_MenuProOpciones)---->Opcion 4 : Te falta colocar una objeto en elemento" + m_opc4Array + "\n" + "English:You need to place an  object to element " + m_opc4Array);
          ////            m_opc4Array++;
        }
        #endregion

    }
}
