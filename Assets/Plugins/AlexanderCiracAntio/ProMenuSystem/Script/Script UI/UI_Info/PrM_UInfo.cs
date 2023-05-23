namespace AlexanderCA.ProMenu.UI
{
    using AlexanderCA.ProMenu.ToolsInspector;
    [System.Serializable]
    public class PrM_UInfo
    {
        #region General Explanation
        [System.Serializable]
        public class Explicacion
        {
          public ExplicacionEspañol Español;
          public ExplicacionIngles  English;
        }
        public Explicacion _language;  
  
          #region Spanish
        [System.Serializable]
        public class ExplicacionEspañol
        {
          public ExplicacionTotalEspañol        Explicación;
          public ExplicacionUsoEspañol          Uso;
          public ExplicacionAdvertenciaEspañol  Advertencia;
        }

        [System.Serializable]
        public class ExplicacionTotalEspañol
        {
            #if UNITY_EDITOR
            [PrM_BoxInspector("Esta script está pensada para poder crear una interfaz al gusto del usuario, dotando de utilidades a las  necesidades del Usuari para que sea más completo y útil. \n Algunas de las opciones qué aporta este apartado son:  al clicar o pasar el ratón por encima puedes hacer que cambien de imágenes, emitan un sonido o reproduzcan una animación.\nTambién te da la posibilidad de dar funciones a los botones para que oculten paneles para repreguntar si el jugador quiere hacer X cosa, \n Colocar URLs y videos que te permitan poder mostrarlos en un entorno 2D o 3D.\n\n USO: Cada pregunta tiene un desplegable que contiene una explicación de que  es lo que hace y también su contenido, para colocar  y arrastrar los objetos deseados en los huecos. Podéis rellenar aquellos que os interesen y en el caso de que os  falte un parámetro importante, el sistema os avisará. \n\n ADVERTENCIA: Recordad que el contenido de textos, la parte gráfica; no lo crea el script. Solo facilita el manejo. Ej: el control de los paneles a la hora de que mostrar y qué paneles ocultar, no referente a parte gráfica ni contenido, sino el global/contenedor", UnityEditor.MessageType.Info)]
            public bool _a;
            #endif
        }

        [System.Serializable]
        public class ExplicacionUsoEspañol
        {
            #if UNITY_EDITOR
            [PrM_BoxInspector("USO: Cada pregunta tiene un desplegable que contiene una explicación de que  es lo que hace y también su contenido, para colocar  y arrastrar los objetos deseados en los huecos. Podéis rellenar aquellos que os interesen y en el caso de que os  falte un parámetro importante, el sistema os avisará.", UnityEditor.MessageType.Warning)]
            public bool _a;
            #endif
        }

        [System.Serializable]
        public class ExplicacionAdvertenciaEspañol
        {
            #if UNITY_EDITOR
            [PrM_BoxInspector("ADVERTENCIA: Recordad que el contenido de textos, la parte gráfica; no lo crea el script. Solo facilita el manejo. Ej: el control de los paneles a la hora de que mostrar y qué paneles ocultar, no referente a parte gráfica ni contenido, sino el global/contenedor", UnityEditor.MessageType.Error)]
            public bool _a;
            #endif
        }
        #endregion
        
          #region English
        [System.Serializable]
        public class ExplicacionIngles
        {

          public ExplicacionTotalIngles      Explanation;
          public ExplicacionUsoIngles        Use;
          public ExplicacionAdverteciaIngles Warning;
    

        }
        [System.Serializable]
        public class ExplicacionTotalIngles
        {
            #if UNITY_EDITOR
            [PrM_BoxInspector("This script is designed to create an interface to suit the user, providing utilities to the needs of the User to make it more complete and useful. \n Some of the options that this section provides are: by clicking or hovering over it you can make them change images, make a sound or play an animation.\n  It also gives you the possibility of giving functions to the buttons to hide panels, to cross-examine if the player wants to do X things, \n URLs and videos that allow you to display them in a 2D or 3D environment.\n\n USE: Each question has a drop-down that contains an explanation  of what it does and also its content to place and drag the desired  objects in the slots. You can fill in those that interest you and in the event that you are missing an important parameter, the system will notify you. \n\n WARNING: Remember that the content of texts, the graphic part; it is not created by the script. It just makes handling easier. Ex: the control of the panels at the time of what to show and which panels to hide, not referring to the graphic part or content, but the global / container.", UnityEditor.MessageType.Info)]
            public bool _a;
            #endif
        } 
  
        [System.Serializable]
        public class ExplicacionUsoIngles
        {
            #if UNITY_EDITOR
            [PrM_BoxInspector("USE: Each question has a drop - down that contains an explanation of what it does and also its content to place and drag the desired objects in the slots. You can fill in those that interest you and in the event that you are missing an important parameter, the system will notify you.", UnityEditor.MessageType.Warning)]
            public bool _a;
            #endif
        }
        [System.Serializable]
        public class ExplicacionAdverteciaIngles
        {
            #if UNITY_EDITOR
            [PrM_BoxInspector("WARNING: Remember that the content of texts, the graphic part; it is not created by the script. It just makes handling easier. Ex: the control of the panels at the time of what to show and which panels to hide, not referring to the graphic part or content, but the global / container.", UnityEditor.MessageType.Error)]
            public bool _a;
            #endif
        }
          #endregion

        #endregion
    }
}
