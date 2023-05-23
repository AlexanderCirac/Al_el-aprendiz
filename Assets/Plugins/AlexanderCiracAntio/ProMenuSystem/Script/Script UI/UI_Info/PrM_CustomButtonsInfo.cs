using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace AlexanderCA.ProMenu.UI
{
    using AlexanderCA.ProMenu.ToolsInspector;
    [System.Serializable]
    public class PrM_CustomButtonsInfo 
    {

        #region CustomButtons Explanation
        public PersonalizarExplicacion _explication;
        public PersonalizarJuego _content;
        [System.Serializable]
        public class PersonalizarExplicacion
        {
          public PersonalizarEspa�ol Espa�ol;
          public PersonalizarIngles English;
        }

        #region Spanish
        [System.Serializable]
        public class PersonalizarEspa�ol
        {
          public PersonalizarTotalEspa�ol Explicaci�n;
          public PersonalizarUsoEspa�ol Uso;
          public PersonalizarAdvertenciaEspa�ol Advertencia;
        }
        [System.Serializable]
        public class PersonalizarTotalEspa�ol
        {
            #if UNITY_EDITOR
            [PrM_BoxInspector("Este apartado sirve para personalizar tus botones con diferentes elementos seg�n la interacci�n con el rat�n:, cuando pase por encima o cuando sea clicado. Los cambios que se pueden hacer seg�n la necesidad del usuario s�n: cambiar los <sprites> , ponerle un sonido  o hacer que se reproduzca una animaci�n. Tambi�n te permite crear en cada bot�n una personalizaci�n propia o gen�rica al cual poder adaptarse, adem�s no solo te permite hacer una sola personalizaci�n gen�rica, sino todas las que el usuario necesite. Podr�s renombrar los diferentes botones para una mayor identificaci�n en vez de poner solo un elemento. \n\nUso: Solo tienes que desplegar e indicar cu�ntos botones quieres personalizar. Arrastra cada elemento a su correspondiente hueco e indica cuantas personalizaciones quieres tener. Luego, arrastra sus elementos. Los elementos que se deben arrastra son <sprites> para cambiar la apariencia,  <AudioSorce> y <AudioClips> para que emitan un sonido y por �ltimo animaciones, que tendr�s que pasar al <Animation_Controller> en el cual estar�n las animaciones puestas. No es necesario que est�n linkeadas entre s�. Por �ltimo, pasad las animaciones hechas teniendo en cuenta que tendr�n que estar dentro del <Animation controller>. Si no lo est�n, haz doble click en el <Animation_Controller> y en el panel que se os despliegue arrastra tus animaciones. Luego, en el sistema, pasa ese <Animation_Controller> y sus animaciones cuando ocurra X evento \n\n Advertencia: No reescala ni repinta, con lo cual cuando hag�is los sprites procurad que tengan las mismas dimensiones. En cuanto a las animaciones, recordad que el <Animaton_Controller> tiene que tener las animaciones que quer�is que se controle <IDLE> es para referirnos a la animaci�n que tiene que reproducirse cuando el jugador no est� controlando ni haciendo ninguna acci�n. Yo lo extrapolare tanto para imagen, como para animaci�n y sonido.Tened en cuenta que el bot�n que sea personalizado, si se repite y se coloca el mismo bot�n en otra ranura, este no se personalizar�, ya que debe ser un bot�n �nico por ranura", UnityEditor.MessageType.Info)]
              public bool _a;
              #endif
        }
        [System.Serializable]
        public class PersonalizarUsoEspa�ol
        {
            #if UNITY_EDITOR
            [PrM_BoxInspector("Uso: Solo tienes que desplegar e indicar cu�ntos botones quieres personalizar. Arrastra cada elemento a su correspondiente hueco e indica cuantas personalizaciones quieres tener. Luego, arrastra sus elementos. Los elementos que se deben arrastra son <sprites> para cambiar la apariencia,  <AudioSorce> y <AudioClips> para que emitan un sonido y por �ltimo animaciones, que tendr�s que pasar al <Animation_Controller> en el cual estar�n las animaciones puestas. No es necesario que est�n linkeadas entre s�. Por �ltimo, pasad las animaciones hechas teniendo en cuenta que tendr�n que estar dentro del <Animation controller>. Si no lo est�n, haz doble click en el <Animation_Controller> y en el panel que se os despliegue arrastra tus animaciones. Luego, en el sistema, pasa ese <Animation_Controller> y sus animaciones cuando ocurra X evento", UnityEditor.MessageType.Warning)]
              public bool _a;
              #endif
        }
        [System.Serializable]
        public class PersonalizarAdvertenciaEspa�ol
        {
            #if UNITY_EDITOR
            [PrM_BoxInspector("Advertencia: No reescala ni repinta, con lo cual cuando hag�is los sprites procurad que tengan las mismas dimensiones. En cuanto a las animaciones, recordad que el <Animaton_Controller> tiene que tener las animaciones que quer�is que se controle <IDLE> es para referirnos a la animaci�n que tiene que reproducirse cuando el jugador no est� controlando ni haciendo ninguna acci�n. Yo lo extrapolare tanto para imagen, como para animaci�n y sonido.Tened en cuenta que el bot�n que sea personalizado, si se repite y se coloca el mismo bot�n en otra ranura, este no se personalizar�, ya que debe ser un bot�n �nico por ranura", UnityEditor.MessageType.Error)]
              public bool _a;
              #endif
        }

        #endregion

        #region English
        [System.Serializable]
        public class PersonalizarIngles
        {
          public PersonalizarTotalIngles Explanation;
          public PersonalizarUsoIngles Use;
          public PersonalizarAdvertenciaIngles Warning;
        }
        [System.Serializable]
        public class PersonalizarTotalIngles
        {
            #if UNITY_EDITOR
            [PrM_BoxInspector("This section is used to customize your buttons with different elements according to the interaction with the mouse, when it passes over it or when it is clicked. The changes that can be made according to the user's needs are: change the <sprites>, put a sound on it or make an animation play. It also allows you to create your own or generic customization for each button to which you can adapt, in addition it not only allows you to make a single generic customization, but all that the user needs. You can rename the different buttons for greater identification instead of just putting one element. \n\n Use: You just have to unfold and indicate how many buttons you want to customize. Drag each element to its corresponding slot and indicate how many customizations you want to have. Then drag its elements. The elements that must be dragged are <sprites> to change the appearance, <AudioSorce> and <AudioClips> so that they emit a sound and finally animations, which you will have to pass to the <Animation_Controller> in which the animations will be placed. They do not need to be linked to each other. Finally, pass the animations made keeping in mind that they will have to be inside the <Animation controller>. If they are not, double click on the <Animation_Controller> and in the panel that appears drag your animations. Then in the system, pass that <Animation_Controller> and its animations when X event occurs.\n\n Warning: Do not rescale or repaint, so when you make the sprites make sure they have the same dimensions. As for the animations, remember that the <Animaton_Controller> has to have the animations that you want to control. <IDLE> is to refer to the animation that has to be played when the player is not controlling or taking any action. I will extrapolate it for image, animation and sound. Keep in mind that the button that is customized, if it is repeated and the same button is placed in another slot, it will not be customized, since it must be a single button per slot.", UnityEditor.MessageType.Info)]
              public bool _a;
              #endif
        }
        [System.Serializable]
        public class PersonalizarUsoIngles
        {
            #if UNITY_EDITOR
            [PrM_BoxInspector("Use: You just have to unfold and indicate how many buttons you want to customize. Drag each element to its corresponding slot and indicate how many customizations you want to have. Then drag its elements. The elements that must be dragged are <sprites> to change the appearance, <AudioSorce> and <AudioClips> so that they emit a sound and finally animations, which you will have to pass to the <Animation_Controller> in which the animations will be placed. They do not need to be linked to each other. Finally, pass the animations made keeping in mind that they will have to be inside the <Animation controller>. If they are not, double click on the <Animation_Controller> and in the panel that appears drag your animations. Then in the system, pass that <Animation_Controller> and its animations when X event occurs.", UnityEditor.MessageType.Warning)]
              public bool _a;
              #endif
        }
        [System.Serializable]
        public class PersonalizarAdvertenciaIngles
        {
            #if UNITY_EDITOR
            [PrM_BoxInspector("Warning: Do not rescale or repaint, so when you make the sprites make sure they have the same dimensions. As for the animations, remember that the <Animaton_Controller> has to have the animations that you want to control. <IDLE> is to refer to the animation that has to be played when the player is not controlling or taking any action. I will extrapolate it for image, animation and sound. Keep in mind that the button that is customized, if it is repeated and the same button is placed in another slot, it will not be customized, since it must be a single button per slot.", UnityEditor.MessageType.Error)]
              public bool _a;
              #endif
        }
        #endregion

        #endregion

        #region CustomButtons Content
        [System.Serializable]
        public class PersonalizarJuego
        {
            [Header("Espa�ol:�Cu�ntas personalizaciones gen�ricas quieres tener?", order = 0)]
            [Space(-10, order = 1)]
            [Header("English:How many generic customizations do you want to have?", order = 2)]
            [Space(5, order = 3)]
            public PersonalizarGeneruci[] _customDefault;
            [Header("Espa�ol:�Cu�ntos botones quieres personalizar?", order = 4)]
            [Space(-10, order = 5)]
            [Header("Englsih:How many buttons do you want to customize?", order = 6)]
            [Space(5, order = 7)]
            public BotonesPersonalizar[] _customButtons;
        }
        [System.Serializable]
        public class PersonalizarGeneruci
        {
          [Header("Espa�ol:�Que sprite ser� la predeterminada?", order = 0)]
          [Space(-10, order = 1)]
          [Header("English:What sprite will be the default?", order = 2)]
          [Space(5, order = 3)]
          public Sprite _onDefoultImage;
          [Header("Espa�ol:�Quieres poner un sprite cu�ndo el bot�n", order = 4)]
          [Space(-10, order = 5)]
          [Header("sea clicado?", order = 6)]
          [Header("English:Do you want to put a sprite when the button", order = 7)]
          [Space(-10, order = 8)]
          [Header("be clicked?", order = 9)]
          [Space(5, order = 10)]
          public Sprite _onClickImage;
          [Header("Espa�ol:�Quieres poner un sprite cu�ndo el rat�n", order = 11)]
          [Space(-10, order = 12)]
          [Header("pase por el bot�n?", order = 13)]
          [Space(-10, order = 14)]
          [Header("English:Do you want to put a sprite when the mouse", order = 15)]
          [Space(-10, order = 16)]
          [Header("go through the button?", order = 17)]
          [Space(5, order = 18)]
          public Sprite _onEnterImage;
          [Header("Espa�ol:�Cu�l ser� el <Animeitor Controller> del", order = 19)]
          [Space(-10, order = 20)]
          [Header("bot�n?", order = 21)]
          [Space(-10, order = 22)]
          [Header("English:What will the <Animeitor Controller> of the", order = 23)]
          [Space(-10, order = 24)]
          [Header("button?", order = 25)]
          [Space(5, order = 26)]
          public RuntimeAnimatorController _animatorController;
          [Header("Espa�ol:�Qu� animaci�n ser� la del <Idle>?", order = 27)]
          [Space(-10, order = 28)]
          [Header("English:What animation will be the <Idle>?", order = 29)]
          [Space(5, order = 30)]
          public AnimationClip _onDefoultVideo;
          [Header("Espa�ol:�Quieres poner una animaci�n cuando el rat�n", order = 31)]
          [Space(-10, order = 32)]
          [Header("pase por el bot�n?", order = 33)]
          [Space(-10, order = 34)]
          [Header("English:Do you want to put an animation when the mouse", order = 35)]
          [Space(-10, order = 36)]
          [Header("go through the button?", order = 37)]
          [Space(5, order = 38)]
          public AnimationClip _onEnterVideo;
          [Header("Espa�ol:�Quieres poner una animaci�n, cuando el bot�n", order = 39)]
          [Space(-10, order = 40)]
          [Header("sea clicado?", order = 41)]
          [Space(-10, order = 42)]
          [Header("English:Do you want to put an animation, when the button", order = 43)]
          [Space(-10, order = 44)]
          [Header("be clicked?", order = 45)]
          [Space(5, order = 46)]
          public AnimationClip _onClickVideo;
          [Header("Espa�ol:�Cu�l ser� el audioSorce del bot�n?", order = 47)]
          [Space(-10, order = 48)]
          [Header("English:What will the button's audioSorce be?", order = 49)]
          [Space(5, order = 50)]
          public AudioSource _audioSource;
          [Header("Espa�ol:�Quieres poner un sonido cuando el bot�n", order = 51)]
          [Space(-10, order = 52)]
          [Header("pase por el bot�n?", order = 53)]
          [Space(-10, order = 54)]
          [Header("English:Do you want to put a sound when the mouse", order = 55)]
          [Space(-10, order = 56)]
          [Header("go through the button?", order = 57)]
          [Space(5, order = 58)]
          public AudioClip _onEnterSound;
          [Header("Espa�ol:�Quieres poner un sonido cuando el rat�n", order = 59)]
          [Space(-10, order = 60)]
          [Header(" sea clicado? ", order = 61)]
          [Space(-10, order = 62)]
          [Header("English: Do you want to put a sound when the button", order = 63)]
          [Space(-10, order = 64)]
          [Header("be clicked? ", order = 65)]
          [Space(5, order = 66)]
          public AudioClip _onClickSoundo;
          [Header("Espa�ol:�Quieres que el efecto del sonido este en bucle?", order = 67)]
          [Space(-10, order = 68)]
          [Header("English: Do you want the sound effect to be looped ? ", order = 69)]
          [Space(5, order = 70)]
          public bool m_loop;
        }
        [System.Serializable]
        public class BotonesPersonalizar
        {
          [Header("Espa�ol:�Cual sera el nombre de este elemento?", order = 0)]
          [Space(-10, order = 1)]
          [Header("English:What will be the name for this element?", order = 2)]
          [Space(5, order = 3)]
          public string _nameElement;          
          [Header("Espa�ol:�Cu�l ser� el bot�n que se personalizar�?", order = 4)]
          [Space(-10, order = 5)]
          [Header("English:What will be the button that will be customized?", order = 6)]
          [Space(5, order = 7)]
          public Button _button;
          [Header("Espa�ol:�Qu� personalizaci�n gen�rica quieres adoptar?", order = 8)]
          [Space(-10, order = 9)]
          [Header("English:What generic customization do you want to adopt?", order = 10)]
          [Space(5, order = 11)]
          public int _intGeneric;
          [Header("Espa�ol:�Quieres que la personalizacion sea la propia?", order = 12)]
          [Space(-10, order = 13)]
          [Header("English:Do you want to place your own personalization?", order = 14)]
          [Space(5, order = 15)]
          public bool _isOwnCusttom;
          [Header("Espa�ol:�Qu� personalizaci�n propia quieres adoptar?  ", order = 16)]
          [Space(-10, order = 17)]
          [Header("English:What personalization do you want to adopt ? ", order = 18)]
          [Space(5, order = 19)]
          public PersonalizarGeneruci _ownCustum;
        }
        #endregion

        #region CustomButtons Error
        /// <summary>
        /// This is to said when there will be an error on Generic
        /// </summary>
        /// <param name="i">Element of array</param>
        public void GetErrorGeneric(int i)
        {
            string _element = _content._customButtons[i]._nameElement != "" ? _content._customButtons[i]._nameElement : ("Element_" + i);
              
              if(!_content._customDefault[i]._audioSource && (_content._customDefault[i]._onClickSoundo || _content._customDefault[i]._onEnterSound ))
                  Debug.LogWarning(SceneManager.GetActiveScene().name + "(PrM_UIManager)---->Option 5:Espa�ol:Te falta colocar en tu personalizaci�n generarica el Audio Source del ." + _element + "\n" + "English:English:You need to place the Audio Source del " + _element);

              if (!_content._customDefault[i]._animatorController && (_content._customDefault[i]._onClickVideo || _content._customDefault[i]._onEnterVideo || _content._customDefault[i]._onDefoultVideo))
                Debug.LogWarning(SceneManager.GetActiveScene().name + "(PrM_UIManager)---->Option 5:Espa�ol:Te falta colocar en tu personalizaci�n generarica el animatorController del ." + _element + "\n" + "English:English:You need to place the animatorController del " + _element);

              if (!_content._customDefault[i]._onDefoultImage && (_content._customDefault[i]._onClickImage || _content._customDefault[i]._onEnterImage))
                Debug.LogWarning(SceneManager.GetActiveScene().name + "(PrM_UIManager)---->Option 5:Espa�ol:Te falta colocar en tu personalizaci�n generarica la imagenDefoult." + "Element: " + i.ToString()  + "\n" + "English:English:You need to place the Idle image in your imagenDefoult." + "Element: " + i.ToString());

        }
        /// <summary>
        /// This is to said when there will be an error on Own personalization
        /// </summary>
        /// <param name="i"> Element of array </param>
        public void GetErrorOwn(int i)
        {
                string _element = _content._customButtons[i]._nameElement != "" ? _content._customButtons[i]._nameElement : ("Element_" + i);

            if (!_content._customButtons[i]._ownCustum._audioSource && (_content._customButtons[i]._ownCustum._onClickSoundo || _content._customButtons[i]._ownCustum._onEnterSound))
              Debug.LogWarning(SceneManager.GetActiveScene().name + "(PrM_UIManager)---->Option 6:Espa�ol:Te falta colocar en tu personalizaci�n propia el Audio Source del ." + _element + "\n" + "English:English:You need to place at own custom the Audio Source  " + _element);

            if (!_content._customButtons[i]._ownCustum._animatorController && (_content._customButtons[i]._ownCustum._onClickVideo || _content._customButtons[i]._ownCustum._onEnterVideo || _content._customButtons[i]._ownCustum._onDefoultVideo))
              Debug.LogWarning(SceneManager.GetActiveScene().name + "(PrM_UIManager)---->Option 6:Espa�ol:Te falta colocar en tu personalizaci�n propia el animatorController del ." + _element + "\n" + "English:English:You need to place  at own custom the animatorController  " + _element);

            if (!_content._customButtons[i]._ownCustum._onDefoultImage && (_content._customButtons[i]._ownCustum._onClickImage || _content._customButtons[i]._ownCustum._onEnterImage))
              Debug.LogWarning(SceneManager.GetActiveScene().name + "(PrM_UIManager)---->Option 6:Espa�ol:Te falta colocar en tu personalizaci�n propia la imagenDefoult." + "Element: " + i.ToString() + "\n" + "English:English:You need to place  at own custom the Idle image in your imagenDefoult." + "Element: " + i.ToString());
        }           
        /// <summary>
        /// This is to said when there will be an error on General
        /// </summary>
        /// <param name="i"> Element of array </param>
        public void GetError(int i)
        {
                string _element = _content._customButtons[i]._nameElement != "" ? _content._customButtons[i]._nameElement : ("Element_" + i);

              Debug.LogWarning(SceneManager.GetActiveScene().name + "(PrM_UIManager)---->Option 6:Espa�ol: Te falta colocar el boton del <Custom Buttons el " + _element  + "\n" + "English:English: You need to place a button from the <Custom Buttons el" + _element);
        }    
        #endregion

    }
}
