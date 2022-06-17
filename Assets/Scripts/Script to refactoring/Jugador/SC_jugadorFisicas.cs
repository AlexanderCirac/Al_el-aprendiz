using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AL.Player;

public class SC_jugadorFisicas : MonoBehaviour
{

  //esta script es para controlar la fisicas del jugador



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    controlfisicas();
    }

  public SC_JumpController SC_CA;
  public PhysicMaterial m_PM;
  void controlfisicas()
  {
    if (SC_CA._isJumping == false)
    {
      m_PM.dynamicFriction = 0.1f;
    }
    else
    {
      m_PM.dynamicFriction = 1;
    }
  }
}
