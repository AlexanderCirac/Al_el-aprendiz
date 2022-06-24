using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_MorirCaida : MonoBehaviour
{
    //en esta scrip es para decir al jugado que pierde todas la vidas cuando uno se cae por el pricipicio

  private void OnTriggerEnter(Collider col)
  {
    if (col.CompareTag("Player"))
    {
      col.gameObject.GetComponent<SC_LifeController>().m_vida = 0;
    }
  }
}
