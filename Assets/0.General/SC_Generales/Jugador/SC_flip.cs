using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_flip : MonoBehaviour
{

  //en esta script indicaremos que el sprite del personaje, que cambie de lado cada vez que el jugador cambie de direccion.

  public SpriteRenderer m_orientacionPersonaje;

 

    // Update is called once per frame
    void Update()
    {
        
    }

  public void DerechaFlip()
  {
    m_orientacionPersonaje.flipX = false;
  }

  public void IzquierdaFlip()
  {
    m_orientacionPersonaje.flipX = true;
  }
}
