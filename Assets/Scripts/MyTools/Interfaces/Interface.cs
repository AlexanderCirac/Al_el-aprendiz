using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
namespace AL.Tools.Interface
{

    public interface IInputs
    {
        public float GetJump();
        public float GetHorizontal();
        public float GetVertical();
    }

    public interface IButtonHandle
    {
        public bool IsDown { get; set; }
        public bool IsOnClick { get; set; }
        public bool IsUp { get; set; }
    }

    public interface IEventsMovement
    {
        public delegate void MydelegateMovement();
        public MydelegateMovement _delegateInputsMovement { get; set; }

        public delegate void MydelegateRotate();
        public MydelegateRotate _delegateInputsRotate { get; set; }

        public delegate void MydelegateJump();
        public MydelegateJump _delegateInputsJump { get; set; }
    }
}
