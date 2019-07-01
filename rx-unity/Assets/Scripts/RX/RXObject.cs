using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RX
{
    public class RXObject : MonoBehaviour
    {
        [HideInInspector]
        public string LogColorID = "grey";

        void Start() => StartFunctions();

        protected virtual void StartFunctions() => GetComponents();

        protected virtual void GetComponents() { }

        void Update() => UpdateFunctions();

        protected virtual void UpdateFunctions() { }
    }
}
