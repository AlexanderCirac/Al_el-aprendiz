using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

namespace AlexanderCA.ProMenu.Opciones
{
    using AlexanderCA.ProMenu.ToolsInspector;
    [System.Serializable]
    public class PrM_SoundInfo
    {
        #region Brightness Explanation

          public ExplicacionSonido m_Explicación;
          public Opcion2Sonido m_Contenido;
          [System.Serializable]
          public class ExplicacionSonido
          {
              public ExplicacionSonidoEspañol Español;
              public ExplicacionSonidoIngles English;
          }

          #region Spanish
            [System.Serializable]
            public class ExplicacionSonidoEspañol
            {
              public ExplicacionSonidoTotalEspañol Explicación;
              public ExplicacionSonidoUsoEspañol Uso;
              public ExplicacionSonidoAdvertenciaEspañol Advertencia;
            }
            [System.Serializable]
            public class ExplicacionSonidoTotalEspañol
            {
              #if UNITY_EDITOR
              [PrM_BoxInspector("Este apartado será para controlar el volumen de todos vuestros audios mediante una barra de control.Puedes crear tantas barras de controles para distintos tipos de de sonido como quieras.\n\n Uso: Solo tienes que arrastrar la barra, un objeto tipo <Scrollbar> que controlará el volumen e indicar cuantos audios <AudioSource> quieres que sean los controlados, y arrastrarlos a los huecos correspondientes. Por último puedes indicar si el volumen se iniciara con un valor de entre 0 y 1. Puedes renombrar los diferentes controladores para una mejor identificación \n\n Advertencia:Cada nivel que hay que controlar el audio, ha de tener este sistema puesto aunque aya una ausencia de la barra de control, tiene que haber la misma la cantidad de audios, aunque en esa escena no se controle ciertos audios de forma específica, pero para el correcto funcionamiento, el sistema ha de tener su hueco aunque no se utilice. Para poder coger la variable solo poner m_intSonido[NumeroDelElementoSonidoQueQuieresControlar]", UnityEditor.MessageType.Info)]
              public bool _a;
              #endif
            }
            [System.Serializable]
            public class ExplicacionSonidoUsoEspañol
            {
              #if UNITY_EDITOR
              [PrM_BoxInspector("Uso: Solo tienes que arrastrar la barra, un objeto  tipo <Scrollbar> que controlará el volumen e indicar cuantos audios <AudioSource> quieres que sean los controlados, y arrastrarlos a los huecos correspondientes. Por último puedes indicar si el volumen se iniciara con un valor de entre 0 y 1. Puedes renombrar los diferentes controladores para una mejor identificación", UnityEditor.MessageType.Warning)]
              public bool _a;
              #endif
            }
            [System.Serializable]
            public class ExplicacionSonidoAdvertenciaEspañol
            {
              #if UNITY_EDITOR
              [PrM_BoxInspector("Advertencia: Cada nivel que hay que controlar el audio, ha de tener este sistema puesto aunque aya una ausencia de la barra de control, tiene que haber la misma la cantidad de audios, aunque en esa escena no se controle ciertos audios de forma específica, pero para el correcto funcionamiento, el sistema ha de tener su hueco aunque no se utilice. Para poder coger la variable solo poner m_intSonido[NumeroDelElementoSonidoQueQuieresControlar]", UnityEditor.MessageType.Error)]
              public bool _a;
              #endif
            }
          #endregion

          #region English
            [System.Serializable]
            public class ExplicacionSonidoIngles
            {
              public ExplicacionSonidoTotalIngles Explanation;
              public ExplicacionSonidoUsoIngles Use;
              public ExplicacionSonidoAdvertenciIngles Warning;
            }
            [System.Serializable]
            public class ExplicacionSonidoTotalIngles
            {
              #if UNITY_EDITOR
              [PrM_BoxInspector("This section will be to control the volume of all your audios through a control bar. You can create as many control bars for different types of sound as you want. \n\n Use: You just have to drag the bar, an object type <Scrollbar> that will control the volume and indicate how many audios <AudioSource> you want to be controlled, and drag them to the corresponding slots. Finally you can indicate if the volume will start with a value between 0 and 1. You can rename the different controllers for a better identification.\n\n Warning: Each level that the audio must be controlled, must have this system set even though there is already an absence of the control bar, there must be the same amount of audios, although in that scene certain audios are not controlled in a specific way, but for the correct operation, the system must have its hole even if it is not used. In order to get the variable, you only need to put m_intSonido[Number of the element sound you want to control]", UnityEditor.MessageType.Info)]
              public bool _a;
              #endif
            }
            [System.Serializable]
            public class ExplicacionSonidoUsoIngles
            {
              #if UNITY_EDITOR
              [PrM_BoxInspector("Use: You just have to drag the bar, an object type < Scrollbar > that will control the volume and indicate how many audios <AudioSource> you want to be controlled, and drag them to the corresponding slots. Finally you can indicate if the volume will start with a value between 0 and 1. You can rename the different controllers for a better identification.", UnityEditor.MessageType.Warning)]
              public bool _a;
              #endif
            }
            [System.Serializable]
            public class ExplicacionSonidoAdvertenciIngles
            {
              #if UNITY_EDITOR
              [PrM_BoxInspector("Warning: Each level that the audio must be controlled, must have this system set even though there is already an absence of the control bar, there must be the same amount of audios, although in that scene certain audios are not controlled in a specific way, but for the correct operation, the system must have its hole even if it is not used. In order to get the variable, you only need to put m_intSonido[Number of the element sound you want to control]", UnityEditor.MessageType.Error)]
              public bool _a;
              #endif
            }
          #endregion

        #endregion

        #region Brightness Content
        /// </summary>
        [System.Serializable]
        public class Opcion2Sonido
        {
          [Header("Español:¿Cuántos controladores quieres tener?", order = 0)]
          [Space(-10, order = 1)]
          [Header("English:How many controllers do you want to have?", order = 2)]
          [Space(5, order = 3)]
          public Audioss[] m_Sonido;

        }

        [System.Serializable]
        public class Audioss
        {
          [Header("Español:¿Quieres poner un nombre para referirte a este controlador?", order = 0)]
          [Space(-10, order = 1)]
          [Header("English:Do you want to put a name to refer to this controller?", order = 2)]
          [Space(5, order = 3)]
          public string _nameElement;        
          [Header("Español:¿Cuántos audios quieres controlar?", order = 4)]
          [Space(-10, order = 5)]
          [Header("English:How many audios do you want to control?", order = 6)]
          [Space(5, order = 7)]
          public AudioSource[] _audioSource;
          [Header("Español:¿Cuál será la barra que controlará el audio?", order = 8)]
          [Space(-10, order = 9)]
          [Header("English:What will be the bar that will control the audio?", order = 10)]
          [Space(5, order = 11)]
          public Scrollbar _soundScrollbar;
          [Header("Español:¿Con qué volumen se iniciará este controlador?", order = 12)]
          [Space(-10, order = 13)]
          [Header("English:What will be the bar that will control the audio?", order = 14)]
          [Space(5, order = 15)]
          [Range(0.05f,1)]
          public float _soundFloat;  
        }
        #endregion

        #region Brightness Error
        /// <summary>
        /// This is to said when there will be an error
        /// </summary>        
        public void GetErrorSound(int _i)
        {
            string _element = m_Contenido.m_Sonido[_i]._nameElement != "" ? m_Contenido.m_Sonido[_i]._nameElement : ("Element_" + _i);
            if(m_Contenido.m_Sonido[_i]._audioSource.Length == 0)
              Debug.LogWarning(SceneManager.GetActiveScene().name + " (SC_MenuProOpciones)---->Opcion 2:Te falta añadir el objeto <AudiosSource> para poder controlar el volumen del " + _element + "\n" + "English:You need to add the < AudiosSource > object to be able to control the volume to " + _element);

      //if (/*m_Contenido.m_opcion2_Option2.m_Contenido.m_Sonido[m_intContador8].m_AudioSource == null*/)
      //{
      //  //Debug.LogWarning(SceneManager.GetActiveScene().name + " (SC_MenuProOpciones)---->Opcion 2:Te falta añadir el objeto <AudioSource> del elemento " + m_intContador8 + "\n" + "English:You need to add the < AudioSource > to element " + m_intContador8);
      //}
    }
    #endregion

  }
}