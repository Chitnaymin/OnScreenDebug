using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingScript : MonoBehaviour {
    // drag and drop DebugCanvas to Hierarchy 
    // Use SDebug instant of Debug but string only
    void Start() {
        SDebug.Log("abc");


        Debug.Log("ahhah");
    }
}
