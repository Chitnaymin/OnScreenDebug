using UnityEngine;

public static class SDebug {
    public static void Log(string debugText) {
        //  string debugText = ObjStr.ToString();
        SDebugController.Instance().CreateLog(debugText);
    }

}
