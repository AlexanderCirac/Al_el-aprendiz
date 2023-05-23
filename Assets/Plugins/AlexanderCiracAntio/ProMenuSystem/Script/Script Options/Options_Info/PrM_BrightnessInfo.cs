using UnityEngine;
using UnityEngine.UI;

namespace AlexanderCA.ProMenu.Opciones
{
    using AlexanderCA.ProMenu.ToolsInspector;
    [System.Serializable]
    public class PrM_BrightnessInfo
    {

        #region Brightness Explanation
        [System.Serializable]
        public class ExplicacionBrilloEscena
        {
          public ExplicacionBrilloEscenaEspa�ol Espa�ol;
          public ExplicacionBrilloEscenaIngles English;
        }
        public ExplicacionBrilloEscena m_Explicaci�n;
        public BrilloEscenaContenido1 m_Contenido;

          #region Spanish
          [System.Serializable]
          public class ExplicacionBrilloEscenaEspa�ol
          {
            public ExplicacionBrilloEscenaTotalEspa�ol Explicaci�n;
            public ExplicacionBrilloEscenaUsoEspa�ol Uso;
            public ExplicacionBrilloEscenaAdvertenciaEspa�ol Advertencia;
          }
          [System.Serializable]
          public class ExplicacionBrilloEscenaTotalEspa�ol
          {
                #if UNITY_EDITOR
                [PrM_BoxInspector("Este apartado ser� para controlar el brillo que solo afectar� exclusivamente al nivel y no incluye la interfaz del juego.\n\n Uso: Arrastra la barra que tiene que ser un objeto <Scrollbar> que controlar� y coloca las diferentes c�maras que el jugador ver� a trav�s de ella. En el caso de que X nivel no tenga men� de opciones, solo con que le pases las variables( que te facilitar�) y rellenes las de las c�maras, tendr�a que funcionar todo bien. \n\n Advertencia: Recuerda que si el nivel actual no tiene opciones para que siga afectando el controlador del contraste, solo tienes que colocar las c�maras en la ranura para que efect�e el contraste. Para poder coger las variables solo se necesita poner m_floatBrilloEscena", UnityEditor.MessageType.Info)]
                public bool _a;
                #endif
          }
          [System.Serializable]
          public class ExplicacionBrilloEscenaUsoEspa�ol
          {
              #if UNITY_EDITOR
              [PrM_BoxInspector("Uso: Arrastra la barra que tiene que ser un objeto <Scrollbar> que controlar� y coloca las diferentes c�maras que el jugador ver� a trav�s de ella. En el caso de que X nivel no tenga men� de opciones, solo con que le pases las variables( que te facilitar�) y rellenes las de las c�maras, tendr�a que funcionar todo bien.", UnityEditor.MessageType.Warning)]
              public bool _a;
              #endif
          }
          [System.Serializable]
          public class ExplicacionBrilloEscenaAdvertenciaEspa�ol
          {
              #if UNITY_EDITOR
              [PrM_BoxInspector("Advertencia: Recuerda que si el nivel actual no tiene opciones para que siga afectando el controlador del contraste, solo tienes que colocar las c�maras en la ranura para que efect�e el contraste. Para poder coger las variables solo se necesita poner m_floatBrilloEscena", UnityEditor.MessageType.Error)]
              public bool _a;
              #endif
          }
          #endregion

          #region English
          [System.Serializable]
          public class ExplicacionBrilloEscenaIngles
          {
            public ExplicacionBrilloEscenaTotalIngles Explanation;
            public ExplicacionBrilloEscenaUsoIngles Use;
            public ExplicacionBrilloEscenaAdvertenciIngles Warning;
          }
          [System.Serializable]
          public class ExplicacionBrilloEscenaTotalIngles
          {
              #if UNITY_EDITOR
              [PrM_BoxInspector("This section will be to control the brightness that will only affect the level exclusively and does not include the game interface. \n\n Use: Drag the bar that has to be a <Scrollbar> object that will control and place the different cameras that the player will see through it. In the event that X level does not have a menu of options, only if you pass the variables (which I will provide you) and fill in those of the cameras, everything should work fine.\n\n Warning: Remember that if the current level does to continue affecting the contrast controller, you only have to place the cameras in the slot for it to effect the contrast. To be able to get the variables, you only need to put m_floatBrilloEscena", UnityEditor.MessageType.Info)]
              public bool _a;
              #endif
          }
          [System.Serializable]
          public class ExplicacionBrilloEscenaUsoIngles
          {
              #if UNITY_EDITOR
              [PrM_BoxInspector("Use: Drag the bar that has to be a < Scrollbar > object that will control and place the different cameras that the player will see through it. In the event that X level does not have a menu of options, only if you pass the variables (which I will provide you) and fill in those of the cameras, everything should work fine.", UnityEditor.MessageType.Warning)]
              public bool _a;
              #endif
          }
          [System.Serializable]
          public class ExplicacionBrilloEscenaAdvertenciIngles
          {
              #if UNITY_EDITOR
              [PrM_BoxInspector("Warning: Remember that if the current level does to continue affecting the contrast controller, you only have to place the cameras in the slot for it to effect the contrast. To be able to get the variables, you only need to put m_floatBrilloEscena", UnityEditor.MessageType.Error)]
              public bool _a;
              #endif
          }
          #endregion

        #endregion

        #region Brightness Content
        [System.Serializable]
        public class BrilloEscenaContenido1
        {
          [Header("Espa�ol:�Cu�les y cu�ntas c�maras ser�n?", order = 0)]
          [Space(-10, order = 1)]
          [Header("English:Which and how many cameras will there be?", order = 2)]
          [Space(5, order = 3)]
          public Camera[] m_CamaraBrilloEscena;
          [Header("Espa�ol:�Cu�l ser� la barra que controlar� el", order = 4)]
          [Space(-10, order = 5)]
          [Header("brillo de la escena?", order = 6)]
          [Space(-10, order = 7)]
          [Header("English:What will be the bar that will control the", order = 8)]
          [Space(-10, order = 9)]
          [Header("brightness of the scene?", order = 10)]
          [Space(5, order = 11)]
          public Scrollbar m_scrollbarBrilloEscena;
          [Header("Espa�ol:�Cu�l ser� el valor que tendr�a de base", order = 12)]
          [Space(-10, order = 13)]
          [Header("el brillo de la escena?", order = 14)]
          [Space(-10, order = 15)]
          [Header("English:What will be the base value the", order = 16)]
          [Space(-10, order = 17)]
          [Header("brightness of the scene?", order = 18)]
          [Space(5, order = 19)]
          public float m_valorBrilloEscena;
        }
        #endregion

        #region Brightness Error
        /// <summary>
        /// This is to said when there will be an error
        /// </summary>        
        public void GetErrorBrighness(int _i)
        {
      //Debug.LogWarning(SceneManager.GetActiveScene().name + " (SC_MenuProOpciones)---->Opcion 4 : Te falta colocar una objeto en elemento" + m_opc4Array + "\n" + "English:You need to place an  object to element " + m_opc4Array);
      ////            m_opc4Array++;
    }
    #endregion

  }
}
