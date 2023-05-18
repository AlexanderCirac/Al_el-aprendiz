using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_EV1Ganar : MonoBehaviour
{

  //esta script es para que se produzca algo caundo el pj se choque o llege en este caso a la meta
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      Chocar();
    }


  public SC_ControlEvento1 SC_CE1;
  private bool m_m1;

  private void OnTriggerEnter(Collider col)
  {
    if (col.CompareTag("Bolita"))
    {
      m_m1 = true;
    }
  }


  void Chocar()
  {
    if (m_m1)
    {
      SC_CE1.m_velocidad = 0;
      Invoke("SacarCartel",0.3f);
    }
  }

  public GameObject m_canvas;
  private bool m_m2;
  void SacarCartel()
  {
    if (!m_m2)
    {
      m_canvas.SetActive(true);
      m_m2 = true;
    }
  }
  
}
