using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RX
{
    public static class LogManager
    {
        public static void Log(System.Object sender, string message) =>
            Debug.Log($"<color={GetColorID(sender)}>{GetName(sender)}</color>: {message}");

        public static void LogWarning(System.Object sender, string message) =>
            Debug.Log($"<color={GetColorID(sender)}>{GetName(sender)}</color>: {message}");

        public static void LogError(System.Object sender, string message) =>
            Debug.LogError($"<color={GetColorID(sender)}>{GetName(sender)}</color>: {message}");

        static string GetColorID(System.Object o)
        {
            if (o is RXObject rxo)
                return rxo.LogColorID;

            return "gray";
        }

        static string GetName(System.Object o)
        {
            if (o is GameObject go)
                return go.name;

            return o.ToString();
        }
    }
}
