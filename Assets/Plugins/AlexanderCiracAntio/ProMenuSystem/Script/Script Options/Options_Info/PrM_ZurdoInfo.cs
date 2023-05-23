using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace AlexanderCA.ProMenu.Opciones
{
    using AlexanderCA.ProMenu.ToolsInspector;
    [System.Serializable]
    public class PrM_ZurdoInfo
    {

        #region Explication
        public ExplicacionZurdo m_Explicación;
        public ZurdoContenido1 m_Contenido;

        [System.Serializable]
        public class ExplicacionZurdo
        {
          public ExplicacionZurdoEspañol Español;
          public ExplicacionZurdoIngles English;
        }

          #region Spanish
          [System.Serializable]
          public class ExplicacionZurdoEspañol
          {
            public ExplicacionZurdoTotalEspañol Explicación;
            public ExplicacionZurdoUsoEspañol Uso;
            public ExplicacionZurdoAdvertenciaEspañol Advertencia;
          }
          [System.Serializable]
          public class ExplicacionZurdoTotalEspañol
          {
            #if UNITY_EDITOR
            [PrM_BoxInspector("Este apartado está pensado para uso de móvil, aunque se puede utilizar también en PC. La idea básica de esto es facilitar para los del móvil la posibilidad de poder utilizar dos interfaces de controles, una con las posiciones para zurdos y otra interfaz con las posiciones de diestros. De esta forma, este apartado te facilita que interfaz se habilita según la opción escogida.\n\n Uso: Crea dos interfaces, una para zurdos y otra para diestros, y arrastralas a los huecos. Coloca un objeto <Toggle> \n\n Advertencia: Este uso está pensado para movil mas que para pc, pero si encuentras alguna utilidad para pc eres libre de usarlo.Los paneles zurdo y diestro colocados en los huecos estarán permanentemente activados/desactivados según la opción que esté habilitada. En el caso de que se quieran desactivar los paneles sin que entre conflicto con el sistema, solo tendrás que hacer que esos paneles sean hijos de algún otro panel y ese panel poder desactivarlo también, ya que desactivarán a sus hijos sin entrar en conflicto con el sistema", UnityEditor.MessageType.Info)]
            public bool _a;
            #endif
          }
          [System.Serializable]
          public class ExplicacionZurdoUsoEspañol
          {
            #if UNITY_EDITOR
            [PrM_BoxInspector("Uso: Crea dos interfaces, una para zurdos y otra para diestros, y arrastralas a los huecos. Coloca un objeto <Toggle>", UnityEditor.MessageType.Warning)]
            public bool _a;
            #endif
          }
          [System.Serializable]
          public class ExplicacionZurdoAdvertenciaEspañol
          {
            #if UNITY_EDITOR
            [PrM_BoxInspector("Advertencia: Este uso está pensado para movil mas que para pc, pero si encuentras alguna utilidad para pc eres libre de usarlo.Los paneles zurdo y diestro colocados en los huecos estarán permanentemente activados/desactivados según la opción que esté habilitada. En el caso de que se quieran desactivar los paneles sin que entre conflicto con el sistema, solo tendrás que hacer que esos paneles sean hijos de algún otro panel y ese panel poder desactivarlo también, ya que desactivarán a sus hijos sin entrar en conflicto con el sistema", UnityEditor.MessageType.Error)]
            public bool _a;
            #endif
          }
          #endregion

          #region English
          [System.Serializable]
          public class ExplicacionZurdoIngles
          {
            public ExplicacionZurdoTotalIngles Explanation;
            public ExplicacionZurdoUsoIngles Use;
            public ExplicacionZurdoAdvertenciIngles Warning;
          }

          [System.Serializable]
          public class ExplicacionZurdoTotalIngles
          {
            #if UNITY_EDITOR
            [PrM_BoxInspector("This section is intended for mobile use, although it can also be used on PC. The basic idea of ​​this is to facilitate for mobile phones the possibility of being able to use two control interfaces, one with the left-handed positions and another interface with the right-handed positions. In this way, this section provides you with which interface is enabled according to the chosen option.\n\n Use: Create two interfaces, one for left-handed and one for right-handed, and drag them into the slots. Place a <Toggle> object \n\n Warning: This use is intended for mobile rather than for pc, but if you find any utility for pc you are free to use it. The left and right handed panels placed in the slots will be permanently activated / deactivated depending on the option that is enabled. In the event that you want to deactivate the panels without conflict with the system, you will  only have to make those panels children of some other panel and that panel can also deactivate it, since they will deactivate their children without conflicting with the system.", UnityEditor.MessageType.Info)]
            public bool _a;
            #endif
          }
          [System.Serializable]
          public class ExplicacionZurdoUsoIngles
          {
            #if UNITY_EDITOR
            [PrM_BoxInspector("Use: Create two interfaces, one for left - handed and one for right-handed, and drag them into the slots. Place a <Toggle> object", UnityEditor.MessageType.Warning)]
            public bool _a;
            #endif
          }
          [System.Serializable]
          public class ExplicacionZurdoAdvertenciIngles
          {
            #if UNITY_EDITOR
            [PrM_BoxInspector("Warning: This use is intended for mobile rather than for pc, but if you find any utility for pc you are free to use it. The left and right handed panels placed in the slots will be permanently activated / deactivated depending on the option that is enabled. In the event that you want to deactivate the panels without conflict with the system, you will  only have to make those panels children of some other panel and that panel can also deactivate it, since they will deactivate their children without conflicting with the system.", UnityEditor.MessageType.Error)]
            public bool _a;
            #endif
          }
          #endregion

        #endregion

        #region  Zurdo Content
        [System.Serializable]
        public class ZurdoContenido1
        {
          [Header("Español:¿Cuál será el objeto <Toggle>", order = 0)]
          [Space(-10, order = 1)]
          [Header("para la opción Zurdo?", order = 2)]
          [Space(-10, order = 3)]
          [Header("English:What will the <Toggle> object", order = 4)]
          [Space(-10, order = 5)]
          [Header("be for the Left-handed option?", order = 6)]
          [Space(5, order = 7)]
          public Toggle _leftHandedToggle;
          [Header("Español:¿Cuál será el objeto <panel> para la interfaz", order = 8)]
          [Space(-10, order = 9)]
          [Header("para Zurdo?", order = 10)]
          [Space(-10, order = 11)]
          [Header("English: What will be the <panel> object for the interface", order = 12)]
          [Space(-10, order = 13)]
          [Header("for Left-handed?", order = 14)]
          [Space(5, order = 15)]
          public GameObject _leftHandedPanel;
          [Header("Español:¿Cuál será el objeto <panel> para la interfaz", order = 16)]
          [Space(-10, order = 17)]
          [Header("para Diestro?", order = 18)]
          [Space(-10, order = 19)]
          [Header("English:What will be the <panel> object for the interface", order = 20)]
          [Space(-10, order = 21)]
          [Header("for Right-handed?", order = 22)]
          [Space(5, order = 23)]
          public GameObject _rightHandedPanel;
        }
        #endregion

        #region Zurdo Errro
        public void GetErrorZurdo()
        {
              if(m_Contenido._leftHandedToggle)
                  Debug.LogWarning(SceneManager.GetActiveScene().name + " (PrM_OptGameManager)---- > Option 4: Español: Necestas colocar los paneles para zurdo y diestro" + "\n" + "English:You need to add left-hand Panel and right-hand panel");
                  //Debug.LogWarning(SceneManager.GetActiveScene().name + " (SC_MenuProOpciones)---- > Opcion 6: Español: El objeto puesto en <Panel> no es el correcto" + "\n" + "English:The object put in <Panel> is not correct");
        }
        #endregion

    }
}
