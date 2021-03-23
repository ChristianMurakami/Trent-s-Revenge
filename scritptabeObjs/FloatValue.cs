using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatValue : ScriptableObject, ISerializationCallbackReceiver
{
    public float startingValue;

    [HideInInspector]
    public float CurrentValue;
    public void OnBeforeSerialize() 
    {}
    public void OnAfterDeserialize()
    {}
}
