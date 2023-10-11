using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace Al.Tools.Edits
{
    using AL.InGame.Character;
    using AL.InGame.Inputs;
    using System.IO;

    [CustomEditor(typeof(EnemyCharacter))]
    [CanEditMultipleObjects]
    public class EnemyEditor : Editor
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
            if (GUILayout.Button(new GUIContent("Explication" , _image) , GUILayout.Height(50) , GUILayout.Width(100)))
            {
                _isFlipFlop = !_isFlipFlop;
            }
            EditorGUILayout.EndHorizontal();

            EditorGUILayout.BeginVertical();
            if (GUILayout.Button("Open Scritp: EnemyCharacter"))
            {
                MonoScript script1 = MonoScript.FromMonoBehaviour(target as MonoBehaviour);
                AssetDatabase.OpenAsset(script1);

            }
            if (GUILayout.Button("Open Scritp: EnemyEditor"))
            {

                string editorScriptPath = AssetDatabase.GetAssetPath(MonoScript.FromScriptableObject(this));
                string fullPath = Path.GetFullPath(editorScriptPath);
                EditorUtility.OpenWithDefaultApp(fullPath);
            }
            EditorGUILayout.EndVertical();
            base.OnInspectorGUI();

        }
        #endregion
    }
}
