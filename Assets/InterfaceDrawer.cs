using System;
using UnityEditor;
using UnityEngine;

public class SerializeInterface : PropertyAttribute, ISerializationCallbackReceiver
{
    public void OnBeforeSerialize()
    {
        throw new System.NotImplementedException();
    }

    public void OnAfterDeserialize()
    {
        throw new System.NotImplementedException();
    }
}

[CustomPropertyDrawer(typeof(SerializeInterface))]
public class InterfaceDrawer : PropertyDrawer
{
    public GameObject obj;
    
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        var serializeInterface = attribute as SerializeInterface;
        EditorGUI.BeginProperty(position, label, property);
        obj = (GameObject)EditorGUI.ObjectField(position, label.text, obj, fieldInfo.FieldType, true);
        EditorGUI.EndProperty(); 
    }
}
