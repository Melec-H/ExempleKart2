using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerOnKey : MonoBehaviour
{

    [SerializeField] KeyCode key;
    [SerializeField] UnityEvent unityEvent;


    // Start is called before the first frame update
    void Start()
    {
        
    }
        
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(key))
        {
            unityEvent.Invoke();
        }
    }

}
