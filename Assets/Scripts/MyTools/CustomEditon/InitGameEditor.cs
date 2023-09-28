using UnityEditor;
using UnityEngine;
using UnityEngine.UI;


namespace Al.Tools.Edits
{
    using Al.UIGame;
    using System.IO;

    [CustomEditor(typeof(InitGameUIController))]
    [CanEditMultipleObjects]
    public class InitGameEditor : Editor
    {
        #region Attributes
        Texture2D _image;
        bool _isFlipFlop;
        #endregion

        #region Editor Calls
        public override void OnInspectorGUI()
        {
            //base.OnInspectorGUI();
            string folderPath = "Assets/Image/Menu/Pergaminao_03.png";
            _image = AssetDatabase.LoadAssetAtPath<Texture2D>(folderPath);


            EditorGUILayout.BeginHorizontal();
            //Presentacion
            GUIStyle helpBoxStyle = new GUIStyle(EditorStyles.helpBox);
            helpBoxStyle.fontSize = 16; // Tamaño de fuente personalizado
            Rect helpBoxRect = GUILayoutUtility.GetRect(GUIContent.none, helpBoxStyle, GUILayout.Height(50));
            GUI.Box(helpBoxRect , "Bienvenido a mi edicion profesional" , helpBoxStyle);
            //forma rapida de coger referencia
            if ( GUILayout.Button(new GUIContent("Explication" , _image) , GUILayout.Height(50) , GUILayout.Width(100)) )
            {
                _isFlipFlop = !_isFlipFlop;
            }
            EditorGUILayout.EndHorizontal();
            EditorGUILayout.BeginVertical();
            if ( GUILayout.Button("Opten Scritp: InitGameUIController") )
            {
                MonoScript script1 = MonoScript.FromMonoBehaviour(target as MonoBehaviour);
                AssetDatabase.OpenAsset(script1);

            }
            if ( GUILayout.Button("Opten Scritp: InitGameEditor") )
            {

                string editorScriptPath = AssetDatabase.GetAssetPath(MonoScript.FromScriptableObject(this));
                string fullPath = Path.GetFullPath(editorScriptPath);
                EditorUtility.OpenWithDefaultApp(fullPath);
            }
            EditorGUILayout.EndVertical();
            if ( _isFlipFlop )
            {
                EditorGUILayout.HelpBox("Pasa cual sera el animator y despues la duracion de la animacion para que pueda cargar el nivel" , MessageType.Info);
            }
            InitGameUIController script = target as InitGameUIController;

            script._animatior = EditorGUILayout.ObjectField("Animator" , script._animatior , typeof(Animator) , true) as Animator;

            if ( script._animatior != null )
            {
                EditorGUILayout.HelpBox("Indica el tiempo de la animacion ya que sera la espera para poder cargar el nivel" , MessageType.None);
                script._timeAnimation = EditorGUILayout.FloatField("Time Animation" , script._timeAnimation);
            }
            if ( script._timeAnimation != 0 )
            {
                EditorGUILayout.HelpBox("Indica Cual ser el nivel que quieres cargar" , MessageType.None);
                script._level = EditorGUILayout.IntField("ID leveal to Loaded" , script._level);
            }
            if ( script._level != -1 && script._timeAnimation != 0 )
            {
                EditorGUILayout.HelpBox("Indica Cual ser el botton que cargara el nivel" , MessageType.None);
                script._animationButton = EditorGUILayout.ObjectField("Button To Loaded" , script._animationButton , typeof(Button) , true) as Button;
            } 
        }
        #endregion

        #region custom privat method
        #endregion
    }
}
