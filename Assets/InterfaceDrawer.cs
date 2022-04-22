using UnityEditor;
using UnityEngine;

public class SerializeInterface : PropertyAttribute, ISerializationCallbackReceiver
{
    public void OnBeforeSerialize()
    {
        Debug.Log("a");
    }

    public void OnAfterDeserialize()
    {
        Debug.Log("b");
    }
}

[CustomPropertyDrawer(typeof(SerializeInterface))]
public class InterfaceDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        var serializeInterface = attribute as SerializeInterface;
        EditorGUI.BeginProperty(position, label, property);
        var obj = EditorGUI.ObjectField(position, label.text, property.exposedReferenceValue, fieldInfo.FieldType, true);
        fieldInfo.SetValue(property.serializedObject.targetObject, obj);
        EditorGUI.EndProperty(); 
    }
}
