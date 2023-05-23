using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace AlexanderCA.ProMenu.UI
{
    using AlexanderCA.ProMenu.ToolsInspector;
    [System.Serializable]
    public class PrM_URLInfo
    {
       #region URL Explanation

        public ExplicacionBotonURL _explication;
        public BotonURL1 _content;

        [System.Serializable]
        public class ExplicacionBotonURL
        {
            public ExplicacionBotonURLEspañol Español;
            public ExplicacionBotonURLIngles English;
        }

          #region Spanish
          [System.Serializable]
          public class ExplicacionBotonURLEspañol
          {
              public BotonURLTotalEspañol Explicación;
              public BotonURLUsoEspañol Uso;
          }
          [System.Serializable]
          public class BotonURLTotalEspañol
          {
              #if UNITY_EDITOR
              [PrM_BoxInspector("Este apartado es para facilitar la opción de abrir una URL del navegador de internet. Siempre se abrirá el que se tenga asignado como su navegador predeterminado. \n Puedes abrir pagina web, youtube, redes sociales, etc. En el inspector tenéis la opción de colocar un nombre a la URL para encontrarlo más fácilmente \n\n Uso: Arrastrar el botón que activará la url y en el hueco de URL escribir o pegar el link que se desee enseñar.En el desplegable de la ranura <nombre> podrás renombrar ese elemento para que no salga <elemento 0> y te sea más fácil encontrarlo", UnityEditor.MessageType.Info)]
              public bool _a;
              #endif
          }

          [System.Serializable]
          public class BotonURLUsoEspañol
          {
              #if UNITY_EDITOR
              [PrM_BoxInspector("Uso: Arrastrar el botón que activará la url y en el hueco de URL escribir o pegar el link que se desee enseñar.En el desplegable de la ranura <nombre> podrás renombrar ese elemento para que no salga <elemento 0> y te sea más fácil encontrarlo", UnityEditor.MessageType.Warning)]
              public bool _a;
              #endif
          }        
          #endregion

          #region English
          [System.Serializable]
          public class ExplicacionBotonURLIngles
          {
            public BotonURLTotalIngles Explanation;
            public BotonURLUsoIngles Use;
          }
          [System.Serializable]
          public class BotonURLTotalIngles
          {
              #if UNITY_EDITOR
              [PrM_BoxInspector("This section is to facilitate the option of opening a URL from the internet browser. The one assigned as your default browser will always open. \nYou can open website, youtube, social networks, etc. In the inspector you have the option to put a name to the URL to find it more easily \n\n Use: Drag the button that will activate the url and in the URL slot write or paste the link that you want to teach. In the drop-down of the slot <name> you can rename that element so that it does not appear <element 0> and it is easier for you to find it.", UnityEditor.MessageType.Info)]
              public bool _a;
              #endif
          }
          [System.Serializable]
          public class BotonURLUsoIngles
          {
              #if UNITY_EDITOR
              [PrM_BoxInspector("Use: Drag the button that will activate the url and in the URL slot write or paste the link that you want to teach. In the drop-down of the slot <name> you can rename that element so that it does not appear <element 0> and it is easier for you to find it.", UnityEditor.MessageType.Warning)]
              public bool _a;
              #endif
          }          
          #endregion

        #endregion

        #region URL Content
        [System.Serializable]
        public class BotonURL1
        {
            [Header("Español:¿Cuántos botones quieres tener del tipo URL?", order = 0)]
            [Space(-10, order = 1)]
            [Header("English:How many buttons do you want to have of the URL type?", order = 2)]
            [Space(5, order = 3)]
            public BotonURLContenido[] _arrayURL;
        }
        [System.Serializable]
        public class BotonURLContenido
        {
            [Header("Español:¿Quieres poner un nombre para identificar", order = 0)]
            [Space(-10, order = 1)]
            [Header("este elemento?", order = 2)]
            [Space(-10, order = 3)]
            [Header("English:Do you want to put a name to identify", order = 4)]
            [Space(-10, order = 5)]
            [Header("this item?", order = 6)]
            [Space(5, order = 7)]
            public string _nameElementURL;
            [Header("Español:¿Qué URL pondrás?", order = 8)]
            [Space(-10, order = 9)]
            [Header("English:What URL will you put?", order = 10)]
            [Space(5, order = 11)]
            public string _uRLString;
            [Header("Español:¿Cuál será el botón para abrir la URL?", order = 12)]
            [Space(-10, order = 13)]
            [Header("English:What will be the button to open the URL?", order = 14)]
            [Space(5, order = 15)]
            public Button _uRLButton;
        }      
        #endregion

        #region URL Error
        /// <summary>
        /// This is to said when there will be an error
        /// </summary>        
        public void GetURLError(int _i)
        {
            string _element = _content._arrayURL[_i]._nameElementURL != "" ? _content._arrayURL[_i]._nameElementURL : ("Element_" + _i);
            if (_content._arrayURL[_i]._uRLString == null)
            { 
              Debug.LogWarning(SceneManager.GetActiveScene().name + " (PrM_UIManager)-----> Option 3: Español:Te falta asignar el link " + _element + "\n" + "English:You need to assign the URL " + _element);
            }            
            if (!_content._arrayURL[_i]._uRLButton)
            { 
              Debug.LogWarning(SceneManager.GetActiveScene().name + " (PrM_UIManager)-----> Option 3: Español:Te falta asignar el boton " + _element + "\n" + "English:You need to assign the button " + _element);
            }
        }
        #endregion
    }
}
