using System;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace AlexanderCA.ProMenu.ToolsInspector
{
    [AttributeUsage(AttributeTargets.Field, Inherited = true)]
    public class PrM_BoxInspector : PropertyAttribute
    {
        public readonly string text;
        public readonly MessageType type;

        //reference in other scritps
        public PrM_BoxInspector(string text, MessageType type = MessageType.Info)
        {
            this.text = text;
            this.type = type;
        }
    }


    #if UNITY_EDITOR
    [CustomPropertyDrawer(typeof(PrM_BoxInspector))]
    public class HelpDrawer : PropertyDrawer
    {
        const int paddingHeight = 8;

        const int marginHeight = 2;

        float baseHeight = 0;

        float addedHeight = 0;

       
        PrM_BoxInspector helpAttribute { get { return (PrM_BoxInspector)attribute; } }

        //tools attribute
        RangeAttribute rangeAttribute
        {
            get
            {
                var attributes = fieldInfo.GetCustomAttributes(typeof(RangeAttribute), true);
                return attributes != null && attributes.Length > 0 ? (RangeAttribute)attributes[0] : null;
            }
        }
        //tools text
        MultilineAttribute multilineAttribute
        {
            get
            {
                var attributes = fieldInfo.GetCustomAttributes(typeof(MultilineAttribute), true);
                return attributes != null && attributes.Length > 0 ? (MultilineAttribute)attributes[0] : null;
            }
        }

        //Tools position Inspector
        public override float GetPropertyHeight(SerializedProperty prop, GUIContent label)
        {
            baseHeight = base.GetPropertyHeight(prop, label);

            float minHeight = paddingHeight * 5;


            var content = new GUIContent(helpAttribute.text);
            var style = GUI.skin.GetStyle("helpbox");

            var height = style.CalcHeight(content, EditorGUIUtility.currentViewWidth + 80);


            height += marginHeight * 2;


            if (multilineAttribute != null && prop.propertyType == SerializedPropertyType.String)
            {
                addedHeight = 48f;
            }


            return height > minHeight ? height + baseHeight + addedHeight : minHeight + baseHeight + addedHeight;
        }

        //core 
        public override void OnGUI(Rect position, SerializedProperty prop, GUIContent label)
        {

            var multiline = multilineAttribute;

            EditorGUI.BeginProperty(position, label, prop);

            var helpPos = position;

            helpPos.height -= baseHeight + marginHeight;


            if (multiline != null)
            {
                helpPos.height -= addedHeight;
            }

            EditorGUI.HelpBox(helpPos, helpAttribute.text, helpAttribute.type);

            position.y += helpPos.height + marginHeight;
            position.height = baseHeight;



            var range = rangeAttribute;

            if (range != null)
            {
                if (prop.propertyType == SerializedPropertyType.Float)
                {
                    EditorGUI.Slider(position, prop, range.min, range.max, label);
                }
                else if (prop.propertyType == SerializedPropertyType.Integer)
                {
                    EditorGUI.IntSlider(position, prop, (int)range.min, (int)range.max, label);
                }
                else
                {

                    EditorGUI.PropertyField(position, prop, label);
                }
            }
            else if (multiline != null)
            {

                if (prop.propertyType == SerializedPropertyType.String)
                {
                    var style = GUI.skin.label;
                    var size = style.CalcHeight(label, EditorGUIUtility.currentViewWidth);

                    EditorGUI.LabelField(position, label);

                    position.y += size;
                    position.height += addedHeight - size;

                    prop.stringValue = EditorGUI.TextArea(position, prop.stringValue);
                }
                else
                {
                    EditorGUI.PropertyField(position, prop, label);
                }
            }
            else
            {
                EditorGUI.PropertyField(position, prop, label);
            }

            EditorGUI.EndProperty();
        }
    }
  #else
      public enum MessageType
      {
          None,
          Info,
          Warning,
          Error,
      }
      #endif
}
