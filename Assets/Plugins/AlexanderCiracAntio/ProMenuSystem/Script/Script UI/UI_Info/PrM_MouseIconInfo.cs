using UnityEngine;
using UnityEngine.SceneManagement;

namespace AlexanderCA.ProMenu.UI
{
    using AlexanderCA.ProMenu.ToolsInspector;
    using AlexanderCA.ProMenu.Enum;
    [System.Serializable]
    public class PrM_MouseIconInfo
    {

        #region MouseIcon Explanation

        public ExplicacionIconoRaton _explication;
        public IconoRatonContenido _content;

        [System.Serializable]
        public class ExplicacionIconoRaton
        {
          public ExplicacionIconoRatonEspañol Español;
          public ExplicacionIconoRatonIngles English;
        }
        #region Spanish
        [System.Serializable]
        public class ExplicacionIconoRatonEspañol
        {
          public IconoRatonTotalEspañol Explicación;
          public IconoRatonUsoEspañol Uso;
          public IconoRatonAdvertenciaEspañol Advertencia;
        }
        [System.Serializable]
        public class IconoRatonTotalEspañol
        {
            #if UNITY_EDITOR
            [PrM_BoxInspector("Este apartado es para personalizar el icono de tu ratón dentro de tu juego. Se te permite poder controlar cuándo tener activada/desactivada esta función de forma externa.\n La personalización que se te ofrece es poder cambiar de imagen/animación cuando el ratón esté en acción de clicar y/o de reposo. \nEstas visualizaciones siempre estarán activas siempre y cuando el cursor esté visible. También el sistema te permite controlar cuándo tener el cursor visible al igual que la función de la personalización, por si queréis colocar personalizaciones extras. \n\nUso: Para poner la personalización con imágenes solo tenéis que arrastrarlos a los huecos, y si son con animaciones tenéis que tener un <Animator controller> con las animaciones del cursor y arrastrarlo en el hueco y arrastrar dichas animaciones a sus respectivos huecos. También tenéis  la opción de activar los ticks para que permita la función de este apartado la visibilidad del cursor.Para poder visualizar el icono del ratón se ha de pasar el objeto <Canvas> para que se puedan colocar los materiales. También podéis recolocar más o menos la posición del icono para ajustarlo, asignando valores numéricos teniendo en cuenta que el icono siempre estará centralizado en el cursor.\n\n Advertencia: Esta función permite mezclar las opciones de personalizacion pero no permite es que si tenéis la imagen de reposo y poneis una animación de reposo ambas opciones se anularán, pero si tenéis una imagen de reposo y no hay una imagen de clicar, pero sí de animación, entonces podéis mezclar en ese  sentido. Esta función no retoca la imagen ni reescala. Procurad que la medida sea exactamente igual para todos las opciones. Siempre que la ranura del objeto <Canvas> esté llena, se creará el Icono independientemente de si tienes activada la opción de función y la visibilidad del ratón, aunque no se ejecuten las cosas para no crear posibles interferencias. Variables:La variable para activar la visibilidad del cursor es sería hacer referencia a esta script ( public SC_MenuProPanelesUI AEI;) <AEI.contents.m_Opcion7.m_Content.m_visibleIcono = True / False; para activar la visibilidad del cursor", UnityEditor.MessageType.Info)]
              public bool _a;
              #endif
        }
        [System.Serializable]
        public class IconoRatonUsoEspañol
        {
            #if UNITY_EDITOR
            [PrM_BoxInspector("Uso: Para poner la personalización con imágenes solo tenéis que arrastrarlos a los huecos, y si son con animaciones tenéis que tener un <Animator controller> con las animaciones del cursor y arrastrarlo en el hueco y arrastrar dichas animaciones a sus respectivos huecos. También tenéis  la opción de activar los ticks para que permita la función de este apartado la visibilidad del cursor.Para poder visualizar el icono del ratón se ha de pasar el objeto <Canvas> para que se puedan colocar los materiales. También podéis recolocar más o menos la posición del icono para ajustarlo, asignando valores numéricos teniendo en cuenta que el icono siempre estará centralizado en el cursor.", UnityEditor.MessageType.Warning)]
              public bool _a;
              #endif
        }
        [System.Serializable]
        public class IconoRatonAdvertenciaEspañol
        {
            #if UNITY_EDITOR
            [PrM_BoxInspector("Advertencia: Esta función permite mezclar las opciones de personalizacion pero no permite es que si tenéis la imagen de reposo y poneis una animación de reposo ambas opciones se anularán, pero si tenéis una imagen de reposo y no hay una imagen de clicar, pero sí de animación, entonces podéis mezclar en ese  sentido. Esta función no retoca la imagen ni reescala. Procurad que la medida sea exactamente igual para todos las opciones. Siempre que la ranura del objeto <Canvas> esté llena, se creará el Icono independientemente de si tienes activada la opción de función y la visibilidad del ratón, aunque no se ejecuten las cosas para no crear posibles interferencias. Variables:La variable para activar la visibilidad del cursor es sería hacer referencia a esta script ( public SC_MenuProPanelesUI AEI;) <AEI.contents.m_Opcion7.m_Content.m_visibleIcono =  True / False; para activar la visibilidad del cursor", UnityEditor.MessageType.Error)]
              public bool _a;
              #endif
        }
        #endregion

        #region English
        [System.Serializable]
      public class ExplicacionIconoRatonIngles
      {
        public IconoRatonTotalIngles Explanation;
        public IconoRatonUsoIngles Use;
        public IconoRatonAdverteciaIngles Warning;
      }
      [System.Serializable]
      public class IconoRatonTotalIngles
      {
          #if UNITY_EDITOR
          [PrM_BoxInspector("This section is to customize your mouse icon within your game. You are allowed to control when to have this function activated/deactivated externally. The customization that is offered is to be able to change the image / animation when the mouse is in the action of clicking and / or resting. These visualizations will always be active as long as the cursor is visible. The system also allows you to control when to have the cursor visible as well as the customization function in case you want to place extra customizations. Use: To put the customization with images you only have to drag them to the slot, and if they are with animations you have to have an <Animator controller> with the cursor animations and drag it into the slot and drag said animations to their respective slot. You also have the option of activating the ticks so that the function of this section allows the visibility of the cursor. In order to visualize the mouse icon, you must pass the <Canvas> object so that the materials can be placed. You can also more or less reposition the position of the icon to adjust it, assigning numerical values ​​taking into account that the icon will always be centralized in the cursor. Warning: This function allows you to mix the customization options but it does not allow is that if you have the rest image and you put a rest animation, both options will be canceled, but if you havea rest image and there is no click image, but of animation, then you can mix in that sense. This function does not retouch the image or rescale. Make sure that the measurement is exactly the same for all the options. As long as the <Canvas> object slot is full, the Icon will be created regardless of whether you have enabled the function option and mouse visibility, even if things are not executed so as not to create possible interference. Variables: The fragment of the variable to control to activate the function , is to reference to this script ( public SC_MenuProPanelesUI AEI;)> AEI.contenido.m_Opcion7.m_Contenido.m_visibleIcono = True / False; The variable to control to activate", UnityEditor.MessageType.Info)]
            public bool _a;
            #endif
      }

      [System.Serializable]
      public class IconoRatonUsoIngles
      {
          #if UNITY_EDITOR
          [PrM_BoxInspector("Use: To put the customization with images you only have to drag them to the slot, and if they are with animations you have to have an <Animator controller> with the cursor animations and drag it into the slot and drag said animations to their respective slot. You also have the option of activating the ticks so that the function of this section allows the visibility of the cursor. In order to visualize the mouse icon, you must pass the <Canvas> object so that the materials can be placed. You can also more or less reposition the position of the icon to adjust it, assigning numerical values ​​taking into account that the icon will always be centralized in the cursor.", UnityEditor.MessageType.Warning)]
            public bool _a;
            #endif
      }
      [System.Serializable]
      public class IconoRatonAdverteciaIngles
      {
          #if UNITY_EDITOR
          [PrM_BoxInspector("Warning: This function allows you to mix the customization options but it does not allow is that if you have the rest image and you put a rest animation, both options will be canceled, but if you havea rest image and there is no click image, but of animation, then you can mix in that sense. This function does not retouch the image or rescale. Make sure that the measurement is exactly the same for all the options. As long as the <Canvas> object slot is full, the Icon will be created regardless of whether you have enabled the function option and mouse visibility, even if things are not executed so as not to create possible interference. Variables: The fragment of the variable to control to activate the function , is to reference to this script ( public SC_MenuProPanelesUI AEI;)> AEI.contenido.m_Opcion7.m_Contenido.m_visibleIcono = True / False; The variable to control to activate", UnityEditor.MessageType.Warning)]
            public bool _a;
            #endif
      }        
        #endregion

        #endregion

        #region MouseIcon Content
        [System.Serializable]
        public class IconoRatonContenido
        {
          [Header("Español:¿Queréis tener activa la función de icono?", order = 0)]
          [Space(-10, order = 1)]
          [Header("English:Do you want to have the icon function active?", order = 2)]
          [Space(5, order = 3)]
          public bool _onFunction;
          [Header("Español:¿Cuál será la imagen de Idle?", order = 4)]
          [Space(-10, order = 5)]
          [Header("English: What will be the image of Idle?", order = 6)]
          [Space(5, order = 7)]
          public Sprite _defoultImage;
          [Header("Español:¿Cuál será la imagen de Clicar?", order = 8)]
          [Space(-10, order = 9)]
          [Header("English:What will be the image of Click?", order = 10)]
          [Space(5, order = 11)]
          public Sprite _onClickImage;
          [Header("Español:¿Cuál será el objeto <canvas> donde se visualizará ", order = 12)]
          [Space(-10, order = 13)]
          [Header("el Icono del ratón?", order = 14)]
          [Space(-10, order = 15)]
          [Header("English:What will the <canvas> object be where it will be displayed", order = 16)]
          [Space(-10, order = 17)]
          [Header("the Mouse Icon?", order = 18)]
          [Space(5, order = 19)]
          public CanvasRenderer _panelIconVisualicer;
          [Header("Español:¿Cuál será el <Animeitor Controller> del", order = 20)]
          [Space(-10, order = 21)]
          [Header("Icono del ratón? ", order = 22)]
          [Space(-10, order = 23)]
          [Header("English:What will the <Animeitor Controller> of the", order = 24)]
          [Space(-10, order = 25)]
          [Header("the Mouse Icon?", order = 26)]
          [Space(5, order = 27)]
          public RuntimeAnimatorController _animatorController;
          [Header("Español:¿Cuál será la animación de Idle?", order = 28)]
          [Space(-10, order = 29)]
          [Header("English:What will the animation of Idle be?", order = 30)]
          [Space(5, order = 31)]
          public AnimationClip _onDefoultAnim;
          [Header("Español:¿Cuál será la animación de Clicar?", order = 32)]
          [Space(-10, order = 33)]
          [Header("English:What will Clicar's animation be?", order = 34)]
          [Space(5, order = 35)]
          public AnimationClip _onClickAnim;
          [Header("Español:¿Cuál será el ajuste de posición del icono?", order = 36)]
          [Space(-10, order = 37)]
          [Header("English:What will the icon position setting be?", order = 38)]
          [Space(5, order = 39)]
          public Vector2 m_posIcono;
          [Header("Español:¿Queréis controlar el icono del", order = 40)]
          [Space(-10, order = 41)]
          [Header("raton mediante el yoistick?", order = 42)]
          [Space(-10, order = 43)]
          [Header("English:Do you want to control the ", order = 44)]
          [Space(-10, order = 45)]
          [Header("icon using the yoistick?", order = 46)]
          [Space(5, order = 47)]
          public bool _isOnYoistick;
          [Header("Español:¿Cuál será el botón para el", order = 48)]
          [Space(-10, order = 49)]
          [Header("click del yoistick?", order = 50)]
          [Space(-10, order = 51)]
          [Header("English:What will be the button", order = 52)]
          [Space(-10, order = 53)]
          [Header("for the yoistick click?", order = 54)]
          [Space(5, order = 55)]
          public joystick _yoistickBotton;
        }
        #endregion

        #region MouseIcon Error
        /// <summary>
        /// This is to said when there will be an error
        /// </summary>        
        public void GetMouseIconoError()
        {
            if (_content._panelIconVisualicer == null && _content._onFunction )
            {
              Debug.LogWarning(SceneManager.GetActiveScene().name + " (SC_MenuProPanelesUI)-----> Opcion 7: Español:Te falta añadir el objeto <Canvas> para poner el icono" + "\n" + "English:You need to add the <Canvas> object to put the icon");
            }

        }
        #endregion
    }
}
