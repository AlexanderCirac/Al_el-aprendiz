using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace AlexanderCA.ProMenu.Opciones
{
    using AlexanderCA.ProMenu.ToolsInspector;
    [System.Serializable]
    public class PrM_GeneralBrightnessInfo
    {
        #region Brightness Explanation

          public ExplicacionOcpion1 _explication;
          public ContenidoOpc1 m_Contenido;

        [System.Serializable]
        public class ExplicacionOcpion1
        {


          public ExplicacionOcpion1Espa�ol Espa�ol;
          public ExplicacionOcpion1Ingles English;

        }

          #region Spanish
          [System.Serializable]
            public class ExplicacionOcpion1Espa�ol
            {
              public ExplicacionOcpion1TotalEspa�ol Explicaci�n;
              public ExplicacionOcpion1UsoEspa�ol Uso;
              public ExplicacionOcpion1AdvertenciaEspa�ol Advertencia;
            }
            [System.Serializable]
            public class ExplicacionOcpion1TotalEspa�ol
            {
              #if UNITY_EDITOR
              [PrM_BoxInspector("Este apartado ser� para controlar la iluminaci�n del juego tanto en el apartado gr�fico como en tus escenas \n\n Uso:Arrastrar la barra que tiene que ser un objeto <Scrollbar> que controlar�, y el canvas de la UI (es ese objeto padre donde estar�n los diferentes paneles, botones y otros elementos de la UI). En el caso de que X nivel no tenga men� de opciones, solo con que le pases las variables( que te facilitar�) y rellenes el hueco del objeto <Canvas>, deber�a funcionar todo bien\n\n Advertencia:Recuerda que si en el nivel actual no tienes opciones para que sigan afectando al controlador de brillo, solo tienes que colocar el objeto <Canvas> en la ranura para que efect�e el brillo general. Para poder coger las variables solo se necesita poner m_intBrillo", UnityEditor.MessageType.Info)]
              public bool _a;
              #endif
            }

            [System.Serializable]
            public class ExplicacionOcpion1UsoEspa�ol
            {
              #if UNITY_EDITOR
              [PrM_BoxInspector("Uso: Arrastrar la barra que tiene que ser un objeto < Scrollbar > que controlar�, y el canvas de la UI (es ese objeto padre donde estar�n los diferentes paneles, botones y otros elementos de la UI). En el caso de que X nivel no tenga men� de opciones, solo con que le pases las variables( que te facilitar�) y rellenes el hueco del objeto <Canvas>, deber�a funcionar todo bien", UnityEditor.MessageType.Warning)]
              public bool _a;
              #endif
            }
            [System.Serializable]
            public class ExplicacionOcpion1AdvertenciaEspa�ol
            {
              #if UNITY_EDITOR
              [PrM_BoxInspector("Advertencia: Recuerda que si en el nivel actual no tienes opciones para que sigan afectando al controlador de brillo, solo tienes que colocar el objeto <Canvas> en la ranura para que efect�e el brillo general. Para poder coger las variables solo se necesita poner m_intBrillo", UnityEditor.MessageType.Error)]
              public bool _a;
              #endif
            }
          #endregion

          #region English
          [System.Serializable]
          public class ExplicacionOcpion1Ingles
          {
            public ExplicacionOcpion1TotalIngles Explanation;
            public ExplicacionOcpion1UsoIngles Use;
            public ExplicacionOcpion1AdvertenciIngles Warning;
          }
          [System.Serializable]
          public class ExplicacionOcpion1TotalIngles
          {
              #if UNITY_EDITOR
              [PrM_BoxInspector("This section will be to control the lighting of the game both in the graphic section and in your scenes \n\n Use: Drag the bar that has to be a <Scrollbar> object that will control, and the UI canvas (it is that parent object where the different panels, buttons and other UI elements will be). In the event that X level does not have a menu of options, only if you pass the variables to it (which I will provide you) and fill in the slot of the <Canvas> object, everything should work fine. \n\n Warning: Remember that if at the current level you have no options to continue affecting the brightness controller, you just have to place the <Canvas> object in the slot to effect the general brightness. To be able to take the variables you only need to put m_intBrillo", UnityEditor.MessageType.Info)]
              public bool _a;
              #endif
          }
          [System.Serializable]
          public class ExplicacionOcpion1UsoIngles
          {
              #if UNITY_EDITOR
              [PrM_BoxInspector("Use: Drag the bar that has to be a < Scrollbar > object that will control, and the UI canvas (it is that parent object where the different panels, buttons and other UI elements will be). In the event that X level does not have a menu of options, only if you pass the variables to it (which I will provide you) and fill in the slot of the <Canvas> object, everything should work fine.", UnityEditor.MessageType.Warning)]
              public bool _a;
              #endif
          }
          [System.Serializable]
          public class ExplicacionOcpion1AdvertenciIngles
          {
              #if UNITY_EDITOR
              [PrM_BoxInspector("Warning: Remember that if at the current level you have no options to continue affecting the brightness controller, you just have to place the <Canvas> object in the slot to effect the general brightness. To be able to take the variables you only need to put m_intBrillo", UnityEditor.MessageType.Error)]
              public bool _a;
              #endif
          }
          #endregion

        #endregion

        #region Brightness Content
        [System.Serializable]
        public class ContenidoOpc1
        {
          [Header("Espa�ol:�Cu�l ser� el objeto <Canvas>?", order = 0)]
          [Space(-10, order = 1)]    
          [Header("English:What will the <Canvas> object be?", order = 2)]
          [Space(5, order = 3)]
          public CanvasRenderer _brightnessPanel;
          [Header("Espa�ol:�Cu�l ser� el objeto <Scrollbar> que controlar� ", order = 4)]
          [Space(-10, order = 5)]       
          [Header("el brillo general?", order = 6)]
          [Space(-10, order = 7)]      
          [Header("Espa�ol:What will be the <Scrollbar> object that will handle ", order = 8)]
          [Space(-10, order = 9)]       
          [Header("the overall brightness?", order = 10)]
          [Space(5, order = 11)]    
          public Scrollbar _brightnesScrollbar;             
          [Header("Espa�ol:�Cu�l ser� la intensidad incial", order = 4)]
          [Space(-10, order = 5)]       
          [Header("del brillo general?", order = 6)]
          [Space(-10, order = 7)]      
          [Header("Espa�ol:What will be the intensiti", order = 8)]
          [Space(-10, order = 9)]       
          [Header("the overall brightness?", order = 10)]
          [Space(5, order = 11)] 
          [Range(0.09f,1)]
          public float _brightnesInt;    
        }

        #endregion

    }
}
