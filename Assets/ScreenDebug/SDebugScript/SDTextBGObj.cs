using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SDTextBGObj : MonoBehaviour {
    public Text debugText;
    void Start() {
        Destroy(gameObject, SDebugCONTSTANT.TIMEOUT);
    }

    public void setText(string text) {
        debugText.text = text;
    }
}

