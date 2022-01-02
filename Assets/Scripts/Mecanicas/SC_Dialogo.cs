using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Dialogo : MonoBehaviour
{
  //esta script es para activar dialogo
  public GameObject m_trigger;

  public bool m_s1;
  private void Start()
  {
    if (m_s1) {
      Time.timeScale = 1; 
    }
  }
  public void Desactivar()
  {
    m_canvasDialogo.SetActive(false);
    Destroy(m_trigger);
    Time.timeScale = 1;
  }

  public GameObject m_canvasDialogo;
  private void OnTriggerEnter(Collider coll)
  {
    if (coll.CompareTag("Player"))
    {
      m_canvasDialogo.SetActive(true);
      Time.timeScale = 0;
    }
  }
}
