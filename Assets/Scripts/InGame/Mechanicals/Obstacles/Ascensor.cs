using System.Collections;
using UnityEditor;
using UnityEngine;


namespace Al.InGame.Obstacles
{

    public class Ascensor : MonoBehaviour
    {
        #region Attributes
        [SerializeField] bool _isHorizontal = false;
        Vector3 _initPosition;
        public VariablesAscenor _variablesAscenor;

        [System.Serializable]
        public struct VariablesAscenor
        {
            public float _distance;
            public float _speed;

#if UNITY_EDITOR
            [CustomPropertyDrawer(typeof(VariablesAscenor))]
            public class SelectLanguageDrawer : PropertyDrawer
            {
                public override float GetPropertyHeight(SerializedProperty property , GUIContent label)
                {
                    SerializedProperty showStruct = property.FindPropertyRelative("_distance");

                    // Determina la altura necesaria en función del valor de showStruct
                    float height = EditorGUIUtility.singleLineHeight;

                    if (showStruct.floatValue != 0)
                    {
                        height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("_speed") , GUIContent.none);
                    }

                    return height;
                }
                public override void OnGUI(Rect position , SerializedProperty property , GUIContent label)
                {
                    EditorGUI.BeginProperty(position , label , property);
                    SerializedProperty showStruct = property.FindPropertyRelative("_distance");
                    Rect showStructPosition = new Rect(position.x, position.y, position.width, EditorGUIUtility.singleLineHeight);
                    EditorGUI.PropertyField(showStructPosition , showStruct , true);

                    if (showStruct.floatValue != 0)
                    {
                        float previousLabelWidth = EditorGUIUtility.labelWidth;
                        EditorGUIUtility.labelWidth = 0;

                        SerializedProperty showStruct2 = property.FindPropertyRelative("_speed");
                        Rect mySubStruct2Position = new Rect(position.x, position.y + EditorGUIUtility.singleLineHeight, position.width, EditorGUI.GetPropertyHeight(showStruct2, GUIContent.none));
                        EditorGUI.PropertyField(mySubStruct2Position , showStruct2 , true);
                    }


                    EditorGUI.EndProperty();
                }
            }
#endif
        }

        #endregion


        #region UnityCalls
        void Start()
        {
            _initPosition = transform.position;
            StartCoroutine(Movement());
        }
        #endregion

        #region privat custom method
        IEnumerator Movement()
        {
            while (true)
            {
                transform.position = _isHorizontal ? new Vector3(Mathf.PingPong(Time.time * _variablesAscenor._speed , _initPosition.x + _variablesAscenor._distance) , transform.position.y , transform.position.z) : new Vector3(_initPosition.x , Mathf.PingPong(Time.time * _variablesAscenor._speed , _initPosition.y + _variablesAscenor._distance) , _initPosition.z);

                yield return null;
            }


        }
        #endregion


    }
}
