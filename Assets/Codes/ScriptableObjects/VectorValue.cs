using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Scriptable cannot be attached to anything in the scene, can live outside the scenes and assign values that can be read  in multiple scenes
[CreateAssetMenu]
public class VectorValue : ScriptableObject, ISerializationCallbackReceiver
{
    public Vector2 initialValue;
    public Vector2 staticValue;

    public void OnAfterDeserialize() { initialValue = staticValue; }

    public void OnBeforeSerialize() { }
}
