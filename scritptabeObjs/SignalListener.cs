using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SignalListener : MonoBehaviour
{
    public SignalUI signal;
    public UnityEvent signalEvent;
    public void onSignalRaise() 
    {
        signalEvent.Invoke();
    }
    private void OnEnable()
    { signal.RegisterListener(this); }
    private void OnDisable()
    { signal.DeRegisterListener(this); }
}
