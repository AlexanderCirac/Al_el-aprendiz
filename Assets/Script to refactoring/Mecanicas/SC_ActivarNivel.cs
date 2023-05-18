using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_ActivarNivel : MonoBehaviour
{

  public GameObject m_botonNivel;

  void OnTriggerEnter(Collider coll)
  {
    if (coll.CompareTag("Player"))
    {
      m_botonNivel.SetActive(true);
    }
  }
}
