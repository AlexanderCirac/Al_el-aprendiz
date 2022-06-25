using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_QuitarVida : MonoBehaviour
{
  //esta scritp al chocar contra el jugador le restara un punto de vida

  //public SC_LifeController SC_V;
  public int m_quitarVida;


  private void Update()
  {
    DesactivarDañoMomentaniamente();
  }
  private void OnTriggerEnter(Collider col)
  {
   
    if (col.CompareTag("Player"))
    {
      //if (SC_V.m_vida > 0)
      //{
      //  SC_V.m_vida = SC_V.m_vida - m_quitarVida;
      //}
      m_activarContador = true;
    }
  }

  //esto es para que no aga tantos tick de daño y acemos que el colisionador parpade
  public float m_timepoContador;
  public bool m_activarContador;
  public bool m_enemigosmoviles;
  
  void DesactivarDañoMomentaniamente()
  {

    if (m_activarContador)
    {
      m_timepoContador += 1 * Time.deltaTime;
      if (m_timepoContador < 0.6f)
      {
        this.GetComponent<BoxCollider>().enabled = false;
      }
      else
      {
        m_activarContador = false; 
      }
    }
    else
    {
      m_timepoContador = 0;
      this.GetComponent<BoxCollider>().enabled = true;
      if (m_enemigosmoviles == true)
      {
      this.GetComponent<SC_EviatarMatarFacil>().m_muerte.SetActive ( true);
      }
    }
  }


}
