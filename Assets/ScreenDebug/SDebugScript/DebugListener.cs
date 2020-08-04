using System.Collections.Generic;
using UnityEngine;

public class DebugListener : MonoBehaviour {

    public static List<LogEntry> logs = new List<LogEntry>();

    private void OnEnable() {
        Application.logMessageReceived += HandleLog;
    }

    private void OnDisable() {
        Application.logMessageReceived -= HandleLog;
    }

    private void HandleLog(string logString, string stackTrace, LogType type) {
        LogEntry logItem = new LogEntry(logString, stackTrace, type);
        logs.Add(logItem);
        SDebug.Log(logItem.GetSLog());
    }
}

[System.Serializable]
public class LogEntry {
    public string Message;
    public string StackTrace;
    public LogType Type;

    // default constructor is required for serialization
    public LogEntry() { }

    public LogEntry(string message, string stackTrace, LogType type) {
        Message = message;
        StackTrace = stackTrace;
        Type = type;
    }

    public string GetSLog() {
        if (Type == LogType.Error) {
            return "Error: " + Message;
        } else {
            return Message;
        }
    }
}