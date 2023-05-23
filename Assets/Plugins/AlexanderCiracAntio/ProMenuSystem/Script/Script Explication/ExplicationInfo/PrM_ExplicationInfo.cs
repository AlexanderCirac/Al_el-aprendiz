using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AlexanderCA.ProMenu
{
  using AlexanderCA.ProMenu.ToolsInspector;
  using AlexanderCA.ProMenu.Enum;
  [System.Serializable]
  public class PrM_ExplicationInfo
  {
      #region General Explanation
      [System.Serializable]
      public class Explicacion
      {
        public ExplicacionEspañol Español;
        public ExplicacionEnglish English;
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
          [PrM_BoxInspector("Esta script será solo explicativa.Lo primero que verás son tres scripts importantes \n \n 1)SC_MenuProPanelesUI \n 2)SC_MenuProOpciones \n 3)SC_MenuProPantallCarga \n\n Te permitirán personalizar tu menú a tu gusto y necesidad a nivel de programación. Lo que no hace es diseñar, ni reescalar, ni reorganizar, ni animar. Eso ya es tarea del propio usuario. Lo que si te permitirá es asignar elementos de animación y añadir nuevos sprites.\n Todas las scripts contienen una explicación y un contenido. \n\n <Explicación general>  <Uso> <Advertencia> \n <Explicación general> describe cual es el propósito de ese apartado \n <Uso> indica como tienes que utilizarlo y qué hacer con ese apartado \n <Advertencia> aclara puntos importantes y avisa al usuario de restricciones o facilita como acceder  a ciertas variables. \n\n El contenido es donde se hallarán todas las opciones que ofrece el sistema, basándose en preguntar al usuario que es lo que quiere hacer. Se ha dividido en 3 scripts para diferenciar cual serán los botones para menús, cuales serán específicos para la parte de las opciones y cuál lo será para la opción de pantalla de carga \n 1)SC_MenuProPanelesUI: servirá para colocar los botones del menú principal o el de pausa. \n 2)SC_MenuBasicoOpciones: servirá para asignar los botones que harán la función de Opciones Ej: a nivel gráfico, brillo, sombras... \n 3)SC_MenuProPantallCarga: servirá para facilitar una pantalla de carga, en la cual podrás asignar su aparición o que sea el nivel para personaliza dicha pantalla En el caso de que esté interesado en obtener variable para guardar o reasignar mediante vuestros propios scripts, se les facilitara cómo acceder a esas variables en el apartado <Advertencia> aunque esas variables no estarán visibles en el inspector, porque de esta forma se consigue que la zona de trabajo del usuario este lo más limpia posible \n\n USO; Cada sección o apartado funciona como un desplegable seleccionable del cual saldrá su contenido Recuerde que el en <contenido> verá diferentes preguntas en el cual facilitara al usuario que utilidad quiere dar a ese botón en especifico, solo tiene que selecionar la pregunta y rellenar los huecos, algunos pueden contener más preguntas por si quiere hacer algo más extra. \n\n ADVERTENCIA: Las script no diseñan, no retocan, no animan. Solo dan utilidades a los botones. Lo todo recuerden que si no sabe qué es lo que hace eseapartado, tiene la explicación.", UnityEditor.MessageType.Info)]
          public bool _a;
    #endif
        }
        [System.Serializable]
        public class ExplicacionUsoEspañol
        {
    #if UNITY_EDITOR
          [PrM_BoxInspector("USO; Cada sección o apartado funciona como un desplegable seleccionable del cual saldrá su contenido.Recuerde que el en <contenido> verá diferentes preguntas en el cual facilitara al usuario que utilidad quiere dar a ese botón en especifico, solo tiene que selecionar la pregunta y rellenar los huecos, algunos pueden contener más preguntas por si quiere hacer algo más extra.", UnityEditor.MessageType.Warning)]
          public bool _a;
    #endif
        }
        [System.Serializable]
        public class ExplicacionAdvertenciaEspañol
        {
    #if UNITY_EDITOR
          [PrM_BoxInspector("ADVERTENCIA: Las script no diseñan, no retocan, no animan. Solo dan utilidades a los botones. Lo todo recuerden que si no sabe qué es lo que hace ese apartado, tiene la explicación.", UnityEditor.MessageType.Error)]
          public bool _a;
    #endif
        }
        #endregion

        #region English
        [System.Serializable]
        public class ExplicacionEnglish
        {
          public ExplicacionTotalIngles Explanation;
          public ExplicacionUsoIngles Use;
          public ExplicacionAdvertenciaIngles Warning;
        }
        [System.Serializable]
        public class ExplicacionTotalIngles
        {
    #if UNITY_EDITOR
          [PrM_BoxInspector("This script will be explanatory only.The first thing you will see are three important scripts \n\n 1)SC_MenuProPanelesUI \n2)SC_MenuProOpciones\n 3)SC_MenuProPantallCarga. \n\n They will allow you to customize your menu to your taste and need at the programming level. What it doesn't do is design, or rescale, or rearrange, or animate. That is already the task of the user himself. What it will allow you is to assign animation elements and add new sprites. \n All scripts contain an explanation and content. In the explanation it is said what this section does, dividing it into three sub-sections \n\n<General explanation> <Use> <Warning>\n <General explanation> describes the purpose of this section \n <Use> indicates how you have to use it and what to do with that section \n<Warning> clarifies important points and warns the user of restrictions or facilitates how to access certain variables.\n\n The content is where all the options offered by the system will be found, based on asking the user what they want to do. It has been divided into 3 scripts to differentiate which will be the buttons for menus, which will be specific for the options part and which will be for the loading screen option. \n 1)SC_MenuProPanelesUI: will be used to place the buttons of the main menu or the pause menu \n 2)SC_MenuBasicoOpciones: will be used to assign the buttons that will function as Options. Ex: graphically, brightness, shadows ... \n 3)SC_MenuProPantallCarga: will serve to facilitate a screen of load, in which you can assign its appearance or that is the level to customize said screen. In the event that you are interested in obtaining a variable to save or reassign through your own scripts, you will be provided with how to access these variables in the <Warning> section, although these variables will not be visible in the inspector, because in this way it is achieved that the user's work area is as clean as possible.\n\n USE: Each section or section works as a selectable drop-down from which its content will appear. Remember that the <content> will see different questions in which it will facilitate the user what utility he wants to give to that specific button, he only has to select the question and fill in the slots, some may contain more questions in case he wants to do something else extra.\n\n WARNING: Scripts do not design, they do not retouch, they do not animate. They only give utilities to the buttons. What they do allow is to integrate animation and designs, and above all remember that if you do not know what that section does, you have the explanation.", UnityEditor.MessageType.Info)]
          public bool _a;
    #endif
        }
        [System.Serializable]
        public class ExplicacionUsoIngles
        {
    #if UNITY_EDITOR
          [PrM_BoxInspector("USE: Each section or section works as a selectable drop - down from which its content will appear. Remember that the <content> will see different questions in which it will facilitate the user what utility he wants to give to that specific button, he only has to select the question and fill in the slots, some may contain more questions in case he wants to do something else extra.", UnityEditor.MessageType.Warning)]
          public bool _a;
    #endif
        }
        [System.Serializable]
        public class ExplicacionAdvertenciaIngles
        {
    #if UNITY_EDITOR
          [PrM_BoxInspector("WARNING: Scripts do not design, they do not retouch, they do not animate. They only give utilities to the buttons. What they do allow is to integrate animation and designs, and above all remember that if you do not know what that section does, you have the explanation.", UnityEditor.MessageType.Error)]
          public bool _a;
    #endif
        }
        #endregion

      #endregion
  }
}
