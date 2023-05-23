using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace AlexanderCA.ProMenu.UI
{
    using AlexanderCA.ProMenu.ToolsInspector;
    using AlexanderCA.ProMenu.Enum;
  [System.Serializable]
  public class PrM_VideoInfo
  {
    #region Attribute
    BotonAnimacionConteido1 _contentVideo;
    #endregion

    #region Video Explanation
    public ExplicacionBotonAnimacion _explication;
    public BotonAnimacionConteido _content;
    [System.Serializable]
    public class ExplicacionBotonAnimacion
    {
      public ExplicacionBotonAnimacionEspañol Español;
      public ExplicacionBotonAnimacionIngles English;
    }

    #region Spanish
    [System.Serializable]
    public class ExplicacionBotonAnimacionEspañol
    {
      public BotonAnimacionTotalEspañol Explicación;
      public BotonAnimacionUsoEspañol Uso;
      public BotonAnimacionAdvertenciaEspañol Advertencia;
    }
    [System.Serializable]
    public class BotonAnimacionTotalEspañol
    {
#if UNITY_EDITOR
      [PrM_BoxInspector("En este apartado se ofrece la posibilidad de insertar un vídeo o varios en un <panel> del canvas o en un objeto 2D, 3D o solo una parte de las diferentes mallas que compone el modelo 3D. También puedes indicar si lo activarás al pasar por x sitio, por botón o de forma automática.\n Los formatos admitidos en un 100% (respecto a lo que se) son mp3, mp4 y avi. \nTambién se puede dar funciones a X botones para pausar ,darle al play, quitar el vídeo y también mezclarlo con una tecla o joystick como botones de acción rápida para quitar el vídeo. También puedes renombrar el elemento del video para una mayor identificación en vez de que salga <elemento 0>\n\n Uso: Indica cuantos vídeos quieres en tu nivel, arrastra el vídeo y escoge cuál será su proyector arrastrando el objeto 2D o 3D o una parte de la malla del conjunto del modelo o el objeto <Panel> a sus respectivos huecos. También debes asignar como se va a reproducir, si será automático o cuando cliques un botón o al pasar por  X sitio dentro de tu escena. Este último se divide en  cuál será esa X zona y quién será el que se tenga que  chocar ( no necesitas colocar ni rigidbody ni colides solo arrastrar la caja o sprite). También podrás indicar si ese vídeo lo quieres controlar con botones de play, pausa o quitarlo. Este último también puedes manejarlo mediante una tecla/joystick/temporizador que tendrá \n\n Advertencia: Si quieres que ese trigger o el <Canvas> solo se active en ciertas condiciones, eso no lo realiza el sistema, lo tendréis que programar vosotros. Este apartado solo facilita el poner el vídeo en el <Panel> o en el objeto 2D o 3D o partes de mallas( no puedes mezclar) y estos últimos dan  la posibilidad de activar el vídeo con un trigger, pero el cuándo estará disponible este trigger es programación vuestra, como también el cuándo desactivar el vídeo que está en objetos 2D, 3D. Otro cosa \n\nIMPORTANTE, la opción de activar el vídeo mediante un botón debe hacerse con diferentes botones", UnityEditor.MessageType.Info)]
      public bool _a;
#endif
    }

    [System.Serializable]
    public class BotonAnimacionUsoEspañol
    {
#if UNITY_EDITOR
      [PrM_BoxInspector("Uso: Indica cuantos vídeos quieres en tu nivel, arrastra el vídeo y escoge cuál será su proyector arrastrando el objeto 2D o 3D o una parte de la malla del conjunto del modelo o el objeto <Panel> a sus respectivos huecos. También debes asignar como se va a reproducir, si será automático o cuando cliques un botón o al pasar por  X sitio dentro de tu escena. Este último se divide en  cuál será esa X zona y quién será el que se tenga que  chocar ( no necesitas colocar ni rigidbody ni colides solo arrastrar la caja o sprite). También podrás indicar si ese vídeo lo quieres controlar con botones de play, pausa o quitarlo. Este último también puedes manejarlo mediante una tecla/joystick/temporizador que tendrá", UnityEditor.MessageType.Warning)]
      public bool _a;
#endif
    }
    [System.Serializable]
    public class BotonAnimacionAdvertenciaEspañol
    {
#if UNITY_EDITOR
      [PrM_BoxInspector("Advertencia: Si quieres que ese trigger o el < Canvas > solo se active en ciertas condiciones, eso no lo realiza el sistema, lo tendréis que programar vosotros. Este apartado solo facilita el poner el vídeo en el <Panel> o en el objeto 2D o 3D o partes de mallas( no puedes mezclar) y estos últimos dan  la posibilidad de activar el vídeo con un trigger, pero el cuándo estará disponible este trigger es programación vuestra, como también el cuándo desactivar el vídeo que está en objetos 2D, 3D. Otro cosa IMPORTANTE, la opción de activar el vídeo mediante un botón debe hacerse con diferentes botones", UnityEditor.MessageType.Error)]
      public bool _a;
#endif
    }
    #endregion

    #region English
    [System.Serializable]
    public class ExplicacionBotonAnimacionIngles
    {
      public BotonAnimacionTotalIngles Explanation;
      public BotonAnimacionUsoIngles Use;
      public BotonAnimacionAdverteciaIngles Warning;
    }
    [System.Serializable]
    public class BotonAnimacionTotalIngles
    {
#if UNITY_EDITOR
      [PrM_BoxInspector("This section offers the possibility of inserting a video or several in a <panel> of the canvas or in a 2D, 3D object or just a part of the different meshes that make up the 3D model. You can also indicate if you will activate it when passing through x site, by button or automatically.\n The formats supported 100% (compared to what I know) are mp3, mp4 and avi. \nYou can also give functions to X buttons to pause, to play, remove the video and also mix it with a key or joystick as quick action buttons to remove the video. You can too rename video element for better identification instead of <element 0> output. en vez de que salga <elemento 0> \n\n Use: Indicate how many videos you want in your level, drag  the video and choose which will be your projector by dragging the 2D or 3D object or a part of the mesh of the whole model or the <Panel> object to their respective slots. You must also assign how it is going to be played, if it will be automatic or when you click a button or when passing through X site within your scene. The latter is divided into what that X zone will be and who will be the one that has to crash (you don't need to place a rigidbody or collide, just drag the box or sprite). You can also indicate if that video you want to control with play, pause or remove buttons. The latter can also be controlled by a key / joystick / timer that will have to synchronize it with the duration of the video \n\n Warning: If you want that trigger or the <Canvas> to only activate under certain conditions, that is not done by the system, you will have to program it yourself. This section only facilitates putting the video in the <Panel> or in the 2D or 3D object or mesh parts (you cannot mix) and the latter give the possibility of activating the video with a trigger, but when this trigger will be available it's your programming, as well as when to deactivate the video that is in 2D, 3D objects Another \n\nIMPORTANT thing, the option to activate the video by means of a button must be done with different buttons.", UnityEditor.MessageType.Info)]
      public bool _a;
#endif
    }

    [System.Serializable]
    public class BotonAnimacionUsoIngles
    {
#if UNITY_EDITOR
      [PrM_BoxInspector("Use: Indicate how many videos you want in your level, drag  the video and choose which will be your projector by dragging the 2D or 3D object or a part of the mesh of the whole model or the <Panel> object to their respective slots. You must also assign how it is going to be played, if it will be automatic or when you click a button or when passing through X site within your scene. The latter is divided into what that X zone will be and who will be the one that has to crash (you don't need to place a rigidbody or collide, just drag the box or sprite). You can also indicate if that video you want to control with play, pause or remove buttons. The latter can also be controlled by a key / joystick / timer that will have to synchronize it with the duration of the video", UnityEditor.MessageType.Warning)]
      public bool _a;
#endif
    }
    [System.Serializable]
    public class BotonAnimacionAdverteciaIngles
    {
#if UNITY_EDITOR
      [PrM_BoxInspector("Warning: If you want that trigger or the < Canvas > to only activate under certain conditions, that is not done by the system, you will have to program it yourself. This section only facilitates putting the video in the <Panel> or in the 2D or 3D object or mesh parts (you cannot mix) and the latter give the possibility of activating the video with a trigger, but when this trigger will be available it's your programming, as well as when to deactivate the video that is in 2D, 3D objects. Another IMPORTANT thing, the option to activate the video by means of a button must be done with different buttons.", UnityEditor.MessageType.Warning)]
      public bool _a;
#endif
    }
    #endregion

    #endregion

    #region Video Content
    [System.Serializable]
    public class BotonAnimacionConteido
    {
      [Header("Español:¿Cuántos videos quieres poner?", order = 0)]
      [Space(-10, order = 1)]
      [Header("English:How many videos do you want to put?", order = 2)]
      [Space(5, order = 3)]
      public BotonAnimacionConteido1[] _arrayVideo;
    }
    [System.Serializable]
    public class BotonAnimacionConteido1
    {
      [Header("Español:¿Quieres poner un nombre ", order = 0)]
      [Space(-10, order = 1)]
      [Header("identificativo a este elemento?", order = 2)]
      [Space(-10, order = 3)]
      [Header("English:Do you want to put an", order = 4)]
      [Space(-10, order = 5)]
      [Header("identifying name to this element?", order = 6)]
      [Space(5, order = 7)]
      public string _elementName;
      [Header("Español:¿Qué vídeo será?", order = 8)]
      [Space(-10, order = 9)]
      [Header("English:What video will it be?", order = 10)]
      [Space(5, order = 11)]
      public VideoClip _clip;      
      [Header("Español:¿Dónde se proyectará el video?", order = 15)]
      [Space(-10, order = 16)]
      [Header("English:Where will the video be screened?", order = 17)]
      [Space(5, order = 18)]
      public BotonProyeccion _howSee;
      [Header("Español:¿Cómo quieres que se active el vídeo?", order = 19)]
      [Space(-10, order = 20)]
      [Header("English:How do you want the video to be activated?", order = 21)]
      [Space(5, order = 22)]
      public BotonActivacionVideo _activateMode;
      [Header("Español:¿Quieres colocar botones para controlar", order = 23)]
      [Space(-10, order = 24)]
      [Header("el vídeo?", order = 25)]
      [Space(-10, order = 26)]
      [Header("English:Do you want to place buttons to control", order = 27)]
      [Space(-10, order = 28)]
      [Header("the video?", order = 29)]
      [Space(5, order = 30)]
      public BotonInteacionVideo _controllersVideo;
      [Header("Español:¿Cómo quieres que se termine el vídeo?", order = 31)]
      [Space(-10, order = 32)]
      [Header("English:How do you want the video to be ended?", order = 33)]
      [Space(5, order = 34)]
      public FinalizarVideo _finishingMode;
      [HideInInspector]
      public bool m_SituacionAnimacion;
    }
    [System.Serializable]
    public class BotonProyeccion
    {
      [Header("Español:¿Se verá el video en un objeto 3D? Eje: Tele", order = 0)]
      [Space(-10, order = 1)]
      [Header("3D (pero solo la  pantalla de la tele)", order = 2)]
      [Space(-10, order = 3)]
      [Header("English:Will the video be seen in a 3D object? Shaft: 3D TV, ", order = 4)]
      [Space(-10, order = 5)]
      [Header("but only the screen", order = 6)]
      [Space(5, order = 7)]
      public GameObject _3D;
      [Header("Español:¿Se verá el video en un objeto 2D? Eje: tele", order = 8)]
      [Space(-10, order = 9)]
      [Header("2D( pero solo la pantalla de la tele)", order = 10)]
      [Space(-10, order = 11)]
      [Header("English:Will the video be seen in a 2D object? Shaft: 2D TV,", order = 12)]
      [Space(-10, order = 13)]
      [Header("but only the screen", order = 14)]
      [Space(5, order = 15)]
      public GameObject _2D;
      [Header("Español:¿Se verá el video en un <panel> del canvas?", order = 16)]
      [Space(-10, order = 17)]
      [Header("English:Will the video be seen in a <panel> of the canvas?", order = 18)]
      [Space(5, order = 19)]
      public GameObject _panel;
    }
    [System.Serializable]
    public class BotonInteacionVideo
    {
      [Header("Español:¿Cuál será el botón de pausar?", order = 0)]
      [Space(-10, order = 1)]
      [Header("English:What will the pause button be?", order = 2)]
      [Space(5, order = 3)]
      public Button _pauseButton;
      [Header("Español:¿Cuál será el botón de play?", order = 4)]
      [Space(-10, order = 5)]
      [Header("English:What will the play button be?", order = 6)]
      [Space(5, order = 7)]
      public Button _playButton;
      [Header("Español:¿Cuál será el botón para quitar el vídeo?", order = 8)]
      [Space(-10, order = 9)]
      [Header("English:What will be the button to remove the video?", order = 10)]
      [Space(5, order = 11)]
      public Button _quitButton;
    }
    [System.Serializable]
    public class BotonActivacionVideo
    {
      [Header("Español:¿Quieres activarlo de forma automática?", order = 0)]
      [Space(-10, order = 1)]
      [Header("English:Do you want to activate it automatically?", order = 2)]
      [Space(5, order = 3)]
      public bool _automaticMode;
      [Header("Español:¿Quieres activarlo con un botón?", order = 8)]
      [Space(-10, order = 9)]
      [Header("English:Do you want to activate it with a button?", order = 10)]
      [Space(5, order = 11)]
      public Button _buttonMode;
      [Header("Español:(Juego 2D)¿Quieres activarlo cuando", order = 12)]
      [Space(-10, order = 13)]
      [Header("pase por X zona?¿Cuál será esa zona?", order = 14)]
      [Space(-10, order = 15)]
      [Header("English:(2D game) Do you want to activate it when", order = 16)]
      [Space(-10, order = 17)]
      [Header("pass through X zone ? What will that area be ?", order = 18)]
      [Space(5, order = 19)]
      public GameObject _trigger2DMode;
      [Header("Español:(Juego 3D)¿Quieres activarlo cuando", order = 20)]
      [Space(-10, order = 21)]
      [Header("pase por X zona?¿Cuál será esa zona?", order = 22)]
      [Space(-10, order = 23)]
      [Header("English:(3D game) Do you want to activate it when", order = 24)]
      [Space(-10, order = 25)]
      [Header("pass through X zone? What will that area be?", order = 26)]
      [Space(5, order = 27)]
      public GameObject _trigger3DMode;
      [Header("Español:Cual sera el Tag?", order = 28)]
      [Space(-10, order = 29)]
      [Header("English:What will be the tag?", order = 32)]
      [Space(5, order = 35)]
      public string _nameTagTrigger;
    }
    [System.Serializable]
    public class FinalizarVideo
    {
      [Header("Español:¿Quieres colocar un temporizador para ", order = 0)]
      [Space(-10, order = 1)]
      [Header("quitar el vídeo automáticamente?", order = 2)]
      [Space(-10, order = 3)]
      [Header("English:Do you want to set a timer to remove ", order = 4)]
      [Space(-10, order = 5)]
      [Header("video automatically?", order = 6)]
      [Space(5, order = 7)]
      public bool _stopVideo;
      [Header("Español:¿Quieres colocar un temporizador para ", order = 8)]
      [Space(-10, order = 9)]
      [Header("quitar el vídeo automáticamente?", order = 10)]
      [Space(-10, order = 11)]
      [Header("English:Do you want to set a timer to remove ", order = 12)]
      [Space(-10, order = 13)]
      [Header("video automatically?", order = 14)]
      [Space(5, order = 15)]
      public bool _stopAll;
      [Header("Español:¿Quieres que se vea el vídeo en bucle?", order = 8)]
      [Space(-10, order = 9)]
      [Header("English:Do you want the video to loop?", order = 10)]
      [Space(5, order = 11)]
      public bool _loopMode;
    }
    #endregion

    #region Video Error
    /// <summary>
    /// This is to said when there will be an error
    /// </summary>        
    public void GetErrorVideo(int _i)
    {
      _contentVideo = this._content._arrayVideo[_i];
   
      string _element = _contentVideo._elementName != "" ? _contentVideo._elementName : ("Element_" + _i);
      if (_isSameHowSee)
      {
        Debug.LogWarning(SceneManager.GetActiveScene().name + " (PrM_UIManager)-----> Option 4:Español: No puedes mezclar <How See> en el  " + _element + "\n" + "English:You can't mix <How See> in the " + _element);
      }      
      if (_isSameActiveMode)
      {
        Debug.LogWarning(SceneManager.GetActiveScene().name + " (PrM_UIManager)-----> Option 4:Español: No puedes mezclar <Active Mode> en el  " + _element + "\n" + "English:You can't mix <Active Mode> in the " + _element);
      }      
      if (_isSameFinishinMode)
      {
        Debug.LogWarning(SceneManager.GetActiveScene().name + " (PrM_UIManager)-----> Option 4:Español: No puedes mezclar <Finish Mode> en el  " + _element + "\n" + "English:You can't mix <Finish Mode> in the " + _element);
      }

      if (!_contentVideo._clip)
      {
        Debug.LogWarning(SceneManager.GetActiveScene().name + " (PrM_UIManager)-----> Option 4:Español: Esta vacio el  " + _element + "\n" + "English:It is empty the " + _element);
      }

    }
    #endregion
      public bool _isSameHowSee{ get => (
          _contentVideo._howSee._panel && _contentVideo._howSee._2D 
          || _contentVideo._howSee._panel && _contentVideo._howSee._3D 
          || _contentVideo._howSee._2D && _contentVideo._howSee._3D);
      }

      public bool _isSameActiveMode { get => (
           _contentVideo._activateMode._automaticMode && _contentVideo._activateMode._buttonMode
        || _contentVideo._activateMode._automaticMode && _contentVideo._activateMode._buttonMode && _contentVideo._activateMode._trigger2DMode
        || _contentVideo._activateMode._automaticMode && _contentVideo._activateMode._buttonMode && _contentVideo._activateMode._trigger2DMode && _contentVideo._activateMode._trigger3DMode
        || _contentVideo._activateMode._automaticMode && _contentVideo._activateMode._trigger2DMode
        || _contentVideo._activateMode._automaticMode && _contentVideo._activateMode._trigger3DMode 
        || _contentVideo._activateMode._buttonMode && _contentVideo._activateMode._trigger2DMode
        || _contentVideo._activateMode._buttonMode && _contentVideo._activateMode._trigger3DMode
        || _contentVideo._activateMode._buttonMode && _contentVideo._activateMode._trigger2DMode && _contentVideo._activateMode._trigger3DMode
        || _contentVideo._activateMode._trigger2DMode && _contentVideo._activateMode._trigger3DMode);
      }    
    
      public bool _isSameFinishinMode { get => (
           _contentVideo._finishingMode._loopMode && _contentVideo._finishingMode._stopAll
          || _contentVideo._finishingMode._loopMode && _contentVideo._finishingMode._stopVideo 
          || _contentVideo._finishingMode._loopMode && _contentVideo._finishingMode._stopAll && _contentVideo._finishingMode._stopVideo 
          || _contentVideo._finishingMode._stopAll && _contentVideo._finishingMode._stopVideo );
      }
    }
}
