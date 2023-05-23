namespace AlexanderCA.ProMenu.Opciones
{

    using AlexanderCA.ProMenu.ToolsInspector;
     [System.Serializable]
    public class PrM_OptionsInfo
    {
         #region Opciones Explanation
          [System.Serializable]
          public class Explicacion
          {
            public ExplicacionEspañol Español;
            public ExplicacionIngles English;
          }
          public Explicacion _language;

          #region Spanish
          [System.Serializable]
          public class ExplicacionEspañol
          {
            public ExplicacionTotalEspañol Explicación;
            public ExplicacionUsoEspañol Uso;
            public ExplicacionAdvertenciaEspañol Advertencia;
          }
          [System.Serializable]
          public class ExplicacionTotalEspañol
          {
            #if UNITY_EDITOR
            [PrM_BoxInspector("Este script sirve para poder controlar y añadir opciones para que el jugador pueda modular y asignar diferentes opciones para que su ordenador pueda rendir de la mejor manera, o de disfrutar de la máxima calidad que pueda ofrecer el usuario, asignando diferentes opciones que permitan y faciliten un mayor control.\n Las opciones que puede escoger al usuario y añadirle son de su propia elección. Puede ofrecer brillo general, control de sonido, control de brillo y contraste sólo en escenas, control de calidad de sombras, calidad de texturas, tipos de anti aliasing, opción de Vsync, resolución de pantalla, modo de pantalla y FPS\n\n Uso: Desplegar el apartado que interese. Cada opción tiene su explicación y el contenido para colocar o arrastrar los objetos en las ranuras indicadas para la opción que quieras utilizar \n\n Advertencia: La información de las variables de cada opción podéis  manipularlas de forma externa o guardar las variables para poder ponerlas en un sistema de guardado. Comentaré cada apartado por separado en la sección de Advertencias, para saber como acceder a esas variables. \nEl propio sistema se encarga de que en cada nivel, los valores de las opciones se recuerden y actualicen en el caso de que sea diferente a las opciones predeterminadas ( eso no quita o exime de que cada nivel se tenga que configurar y colocar todas las cosas y sus valores predeterminados , de esta forma el usuario no tiene que preocuparse de que en cada nivel que se carga deba recordar las variables de sus opciones de forma propia Si se queré ver las variables, para controlar su funcionamiento, abrid este scritp y comentar con < // >; en la parte de arriba de la variable deseada que tenga <[HideInInspector]>", UnityEditor.MessageType.Info)]
            public bool _a;
            #endif
          }
          [System.Serializable]
          public class ExplicacionUsoEspañol
          {
            #if UNITY_EDITOR
            [PrM_BoxInspector("Uso: Desplegar el apartado que interese.Cada opción tiene su explicación y el contenido para colocar o arrastrar los objetos en las ranuras indicadas para la opción que quieras utilizar", UnityEditor.MessageType.Warning)]
            public bool _a;
            #endif
          }
          [System.Serializable]
          public class ExplicacionAdvertenciaEspañol
          {
            #if UNITY_EDITOR
            [PrM_BoxInspector("Advertencia: La información de las variables de cada opción podéis  manipularlas de forma externa o guardar las variables para poder ponerlas en un sistema de guardado. Comentaré cada apartado por separado en la sección de Advertencias, para saber como acceder a esas variables. El propio sistema se encarga de que en cada nivel, los valores de las opciones se recuerden y actualicen en el caso de que sea diferente a las opciones predeterminadas ( eso no quita o exime de que cada nivel se tenga que configurar y colocar todas las cosas y sus valores predeterminados , de esta forma el usuario no tiene que preocuparse de que en cada nivel que se carga deba recordar las variables de sus opciones de forma propia Si se queré ver las variables, para controlar su funcionamiento abrid este scritp y comentar con < // >; en la parte de arriba de la variable deseada que tenga <[HideInInspector]>", UnityEditor.MessageType.Error)]
            public bool _a;
            #endif
          }
          #endregion

          #region English
          [System.Serializable]
          public class ExplicacionIngles
          {
            public ExplicacionTotalIngles Explanation;
            public ExplicacionUsoIngles Use;
            public ExplicacionAdvertenciIngles Warning;
          }
          [System.Serializable]
          public class ExplicacionTotalIngles
          {
            #if UNITY_EDITOR
            [PrM_BoxInspector("This script is used to control and add options so that the player can modulate and assign in the best way, or to enjoy the highest quality that the user can offer, assigning different options that allow and facilitate greater control. \n The options that the user can choose and add to him are of his own choice. It can offer general brightness, sound control, scene-only brightness and contrast control, shadow quality control, texture quality, anti-aliasing types, Vsync option, screen resolution, screen mode and FPS.\n\n Use: Display the section that interests you. Each option has its explanation and the content to place or drag the objects in the slots indicated for the option you want to use. \n\n Warning: The information of the variables of each option can be manipulated externally or save the variables to be able to put them in a saving system. I will comment on each section separately in the Warnings section, to know how to access these variables.\n The system itself ensures that at each level, the option values ​​are remembered and updated in the event that it is different from the default options (this does not remove or exempt each level from having to configure and place all the things and their default values, in this way the user does not have to worry that in each level that is loaded they must remember the variables of their options in their own way. If you want to see the variables, to control their operation, open this script and comment with <//>; at the top of the desired variable that has <[HideInInspector]>", UnityEditor.MessageType.Info)]
            public bool _a;
            #endif
          }
          [System.Serializable]
          public class ExplicacionUsoIngles
          {
            #if UNITY_EDITOR
            [PrM_BoxInspector("Use: Display the section that interests you. Each option has its explanation and the content to place or drag the objects in the slots indicated for the option you want to use.", UnityEditor.MessageType.Info)]
            public bool _a;
            #endif
          } 
          [System.Serializable]
          public class ExplicacionAdvertenciIngles
          {
            #if UNITY_EDITOR
            [PrM_BoxInspector("Warning: The information of the variables of each option can be manipulated externally or save the variables to be able to put them in a saving system. I will comment on each section separately in the Warnings section, to know how to access these variables. The system itself ensures that at each level, the option values ​​are remembered and updated in the event that it is different from the default options (this does not remove or exempt each level from having to configure and place all the things and their default values, in this way the user does not have to worry that in each level that is loaded they must remember the variables of their options in their own way. If you want to see the variables, to control their operation, open this script and comment with <//>; at the top of the desired variable that has <[HideInInspector]>", UnityEditor.MessageType.Error)]
            public bool _a;
            #endif
          }
          #endregion

         #endregion

    }
}
