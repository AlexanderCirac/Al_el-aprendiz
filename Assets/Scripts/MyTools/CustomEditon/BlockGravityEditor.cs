using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEditorInternal;

namespace Al.Tools.Edits
{
    using Al.UIGame;
    using System.Collections;
    using System.IO;
    using System.Linq;
    using System;
    using Al.InGame.Obstacles;

    [CustomEditor(typeof(BlockGravity) , true)]
    [CanEditMultipleObjects]

    public class BlockGravityEditor : Editor
    {
        #region Attributes
        bool _isFlipFlop;
        Texture2D _image;
        #endregion

        #region Editor Calls
        public override void OnInspectorGUI()
        {
            EditorGUILayout.BeginHorizontal();
            //Presentacion
            string folderPath = "Assets/Image/Menu/Pergaminao_01.png";
            _image = AssetDatabase.LoadAssetAtPath<Texture2D>(folderPath);
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
            if (GUILayout.Button("Opten Scritp: BlockGravity "))
            {
                MonoScript script1 = MonoScript.FromMonoBehaviour(target as MonoBehaviour);
                AssetDatabase.OpenAsset(script1);

            }
            if (GUILayout.Button("Opten Scritp: BlockGravityEditor "))
            {

                string editorScriptPath = AssetDatabase.GetAssetPath(MonoScript.FromScriptableObject(this));
                string fullPath = Path.GetFullPath(editorScriptPath);
                EditorUtility.OpenWithDefaultApp(fullPath);
            }
            EditorGUILayout.EndVertical();
            if (_isFlipFlop)
            {
                EditorGUILayout.HelpBox("Tendras que inidicar cual sera el tipo de bloque que adoptara " , MessageType.Info);

            }
            else
            {


            }
            serializedObject.Update();
            base.OnInspectorGUI();
            serializedObject.ApplyModifiedProperties();
        }
        #endregion

        #region custom privat method

        #endregion
    }
}
