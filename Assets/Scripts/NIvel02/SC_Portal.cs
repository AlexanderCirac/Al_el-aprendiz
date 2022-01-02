using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Portal : MonoBehaviour
{

  //este script es transportar al jugador de una zona del mapa a otra

  public GameObject m_destino;
  public GameObject m_jugador;
  private void OnTriggerEnter(Collider col)
  {

    if (col.CompareTag("Player"))
    {
      m_jugador.transform.position = m_destino.transform.position;
    }
  }
}
