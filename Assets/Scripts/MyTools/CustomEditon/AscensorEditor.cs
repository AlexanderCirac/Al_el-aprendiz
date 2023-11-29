using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace Al.Tools.Edits
{
    using Al.InGame.Controller;
    using Al.InGame.Obstacles;
    using System.IO;
    using static UnityEngine.GraphicsBuffer;

    [CustomEditor(typeof(Ascensor))]
    [CanEditMultipleObjects]

    public class AscensorEditor : Editor
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
            helpBoxStyle.fontSize = 16; // Tama�o de fuente personalizado
            Rect helpBoxRect = GUILayoutUtility.GetRect(GUIContent.none, helpBoxStyle, GUILayout.Height(50));
            GUI.Box(helpBoxRect , "Bienvenido a mi edicion profesional para poder configurar un ascensor" , helpBoxStyle);
            //forma rapida de coger referencia
            if (GUILayout.Button(new GUIContent("Explication" , _image) , GUILayout.Height(50) , GUILayout.Width(100)))
            {
                _isFlipFlop = !_isFlipFlop;
            }
            EditorGUILayout.EndHorizontal();

            EditorGUILayout.BeginVertical();
            if (GUILayout.Button("Open Scritp: Ascensor"))
            {
                MonoScript script1 = MonoScript.FromMonoBehaviour(target as MonoBehaviour);
                AssetDatabase.OpenAsset(script1);

            }
            if (GUILayout.Button("Open Scritp: AscensorEditor"))
            {

                string editorScriptPath = AssetDatabase.GetAssetPath(MonoScript.FromScriptableObject(this));
                string fullPath = Path.GetFullPath(editorScriptPath);
                EditorUtility.OpenWithDefaultApp(fullPath);
            }
            if (_isFlipFlop)
            {
                GUILayout.Box( $@"Para mover el ascensor necesitas inidicar:
IsHorizontal -> selecionalo para moverlo en Horizontal, deseleccionalo para que se mueva vetical
Distance -> Para decir la distancia que ha de recorrer
Speed -> Indicar cuanta velocidad quieres" , helpBoxStyle);
            }
            EditorGUILayout.EndVertical();
           
            base.OnInspectorGUI();

        }
        #endregion
    }
}
