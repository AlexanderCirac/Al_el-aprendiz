using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AL.Tools.Enums
{

    public enum eButtonAction
    {
        ButtonJump,
        ButtonMoveRight,
        ButtonMoveLeft
    }      
    public enum eObstacle
    {   
        BlockDamage,
        BlockFlipFlop,
        BlockGravityEnabled,
        BlockGravityDesabled
    }    
    
    public enum Animations
    {
        none,
        movement,
        jump
    }
}