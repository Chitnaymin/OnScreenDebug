using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SDebugController : SingletonBehaviour<SDebugController> {
    public GameObject SDTextBG;
    public GameObject container;

    private void Start() {
        DontDestroyOnLoad(this.gameObject);
    }

    public void CreateLog(string logText) {
        GameObject createdSDTextBG = Instantiate(SDTextBG);
        createdSDTextBG.transform.SetParent(container.transform, false);
        createdSDTextBG.GetComponent<SDTextBGObj>().setText(logText);
    }
}