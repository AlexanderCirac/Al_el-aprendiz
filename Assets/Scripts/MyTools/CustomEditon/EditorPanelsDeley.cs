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

    [CustomEditor(typeof(ChangePanelsDeley) , true)]
    [CanEditMultipleObjects]
    public class EditorPanelsDeley : Editor
    {
        #region Attributes
        [HideInInspector] private SerializedProperty _variablesDeley;
        bool _isFlipFlop;
        bool showArray = false;
        Texture2D _image;
        private bool[] foldouts;
        public bool _isAnimationCorrutine;
        public bool _doOnce;




        #endregion

        #region Editor Calls
        private void OnEnable()
        {

            _variablesDeley = serializedObject.FindProperty("_configurePanelDeley");
        }

        public override void OnInspectorGUI()
        {

            ChangePanelsDeley script = target as ChangePanelsDeley;

            if (!_doOnce)
            {
                string folderPath = "Assets/Image/Menu/Pergaminao_01.png";
                _image = AssetDatabase.LoadAssetAtPath<Texture2D>(folderPath);
                _doOnce = true;
            }

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
            if (GUILayout.Button("Opten Scritp: ChangePanelsDeley "))
            {
                MonoScript script1 = MonoScript.FromMonoBehaviour(target as MonoBehaviour);
                AssetDatabase.OpenAsset(script1);

            }
            if (GUILayout.Button("Opten Scritp: EditorPanelsDeley "))
            {

                string editorScriptPath = AssetDatabase.GetAssetPath(MonoScript.FromScriptableObject(this));
                string fullPath = Path.GetFullPath(editorScriptPath);
                EditorUtility.OpenWithDefaultApp(fullPath);
            }
            EditorGUILayout.EndVertical();
            if (_isFlipFlop)
            {
                EditorGUILayout.HelpBox("Pasa cual sera el animator y despues la duracion de la animacion para que pueda cargar el nivel" , MessageType.Info);
                if (!_isAnimationCorrutine)
                {
                    EditorApplication.update += ProcessDownload;
                    currentDownload = IEAnimationScroll();
                    _isAnimationCorrutine = true;
                }
            }
            else
            {
                if (_isAnimationCorrutine)
                {

                    EditorApplication.update += ProcessDownload;
                    currentDownload = IEAnimationScroll();
                    _isAnimationCorrutine = false;
                }

            }
            serializedObject.Update();
            script._animationUp = EditorGUILayout.ObjectField("Animation Up" , script._animationUp , typeof(GameObject) , true) as GameObject;
            script._animationDown = EditorGUILayout.ObjectField("Animation Down" , script._animationDown , typeof(GameObject) , true) as GameObject;
            showArray = EditorGUILayout.Foldout(showArray , "Array of Structs");
            if (showArray)
            {
                EditorGUI.indentLevel++;
                EditorGUILayout.PropertyField(_variablesDeley , true);

                if (_variablesDeley.isExpanded)
                {
                    EditorGUI.indentLevel++;

                    if (foldouts == null || foldouts.Length != _variablesDeley.arraySize)
                    {
                        foldouts = new bool[_variablesDeley.arraySize];
                    }
                    EditorGUI.indentLevel++;


                    for (int i = 0 ; i < _variablesDeley.arraySize ; i++)
                    {
                        SerializedProperty element = _variablesDeley.GetArrayElementAtIndex(i);
                        SerializedProperty nameElement = element.FindPropertyRelative("_nameElement");
                        SerializedProperty delay = element.FindPropertyRelative("_delay");
                        SerializedProperty _isUp = element.FindPropertyRelative("_isUp");

                        foldouts[i] = EditorGUILayout.Foldout(foldouts[i] , nameElement.stringValue);

                        if (foldouts[i])
                        {
                            EditorGUI.indentLevel++;
                            EditorGUILayout.PropertyField(nameElement , new GUIContent("_nameElement") , true);
                            EditorGUILayout.HelpBox("Cual sera el boton que activara esta opcion" , MessageType.None);
                            //  EditorGUILayout.PropertyField(button , new GUIContent("Value") , true);
                            script._configurePanelDeley[i]._buttonPanel = EditorGUILayout.ObjectField("Button To enable panel" , script._configurePanelDeley[i]._buttonPanel , typeof(Button) , true) as Button;
                            EditorGUI.indentLevel++;
                            if (script._configurePanelDeley[i]._buttonPanel)
                            {
                                EditorGUILayout.HelpBox("Cual sera el panel que se cerrara antes de la carga?" , MessageType.None);
                                script._configurePanelDeley[i]._panelDesable = EditorGUILayout.ObjectField("Desable Panel" , script._configurePanelDeley[i]._panelDesable , typeof(GameObject) , true) as GameObject;
                                EditorGUI.indentLevel++;

                                if (script._configurePanelDeley[i]._panelDesable)
                                {

                                    EditorGUILayout.HelpBox("Cual sera el panel que mostrara despues de la carga ?" , MessageType.None);
                                    script._configurePanelDeley[i]._panelEnabled = EditorGUILayout.ObjectField("Enable Panel" , script._configurePanelDeley[i]._panelEnabled , typeof(GameObject) , true) as GameObject;
                                    EditorGUI.indentLevel++;
                                    if (script._configurePanelDeley[i]._panelEnabled)
                                    {
                                        EditorGUILayout.HelpBox("Cuanto tiempo le pondras de espera antes de mostrar el panel?" , MessageType.None);
                                        EditorGUILayout.PropertyField(delay , new GUIContent("time deley") , true);
                                        script._configurePanelDeley[i]._delay = delay.floatValue;
                                        EditorGUI.indentLevel++;
                                        if (script._configurePanelDeley[i]._delay != 0)
                                        {
                                            EditorGUILayout.HelpBox("Quieres activar la animacion Up?" , MessageType.None);
                                            EditorGUILayout.PropertyField(_isUp , new GUIContent("Animation Up") , true);
                                            script._configurePanelDeley[i]._isUp = _isUp.boolValue;
                                            EditorGUI.indentLevel--;
                                        }
                                        EditorGUI.indentLevel--;
                                    }
                                    EditorGUI.indentLevel--;
                                }
                                EditorGUI.indentLevel--;
                            }

                            EditorGUI.indentLevel--;
                        }
                    }

                    EditorGUI.indentLevel--;
                }
            }

            serializedObject.ApplyModifiedProperties();
        }
        #endregion

        #region custom privat method
        private IEnumerator currentDownload;
        private void ProcessDownload()
        {
            currentDownload?.MoveNext();
        }
        public IEnumerator IEAnimationScroll()
        {
            string folderPath;
            if (_isFlipFlop)
            {

                folderPath = "Assets/Image/Menu/Pergaminao_01.png";
                _image = AssetDatabase.LoadAssetAtPath<Texture2D>(folderPath);
                yield return new WaitForSeconds(0.0001f);
                folderPath = "Assets/Image/Menu/Pergaminao_02.png";
                _image = AssetDatabase.LoadAssetAtPath<Texture2D>(folderPath);
                yield return new WaitForSeconds(0.0001f);
                folderPath = "Assets/Image/Menu/Pergaminao_03.png";
                _image = AssetDatabase.LoadAssetAtPath<Texture2D>(folderPath);
                EditorApplication.update -= ProcessDownload;
            }
            else
            {
                folderPath = "Assets/Image/Menu/Pergaminao_03.png";
                _image = AssetDatabase.LoadAssetAtPath<Texture2D>(folderPath);
                yield return new WaitForSeconds(0.0001f);
                folderPath = "Assets/Image/Menu/Pergaminao_02.png";
                _image = AssetDatabase.LoadAssetAtPath<Texture2D>(folderPath);
                yield return new WaitForSeconds(0.0001f);
                folderPath = "Assets/Image/Menu/Pergaminao_01.png";
                _image = AssetDatabase.LoadAssetAtPath<Texture2D>(folderPath);
                EditorApplication.update -= ProcessDownload;
            }
        }
        #endregion
    }
}
