using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_ActivarPrimeraAgachado : MonoBehaviour
{
  //esta script es para activar el boton de agachado y asi poner una ñapa sobre un bugg

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  public GameObject m_B1;
  public GameObject m_B2;
  public GameObject m_B3;
  public GameObject m_B5;
  public bool m_B4;
  private void OnTriggerEnter(Collider coll)
  {
    if (coll.CompareTag("Player"))
    {
      m_B1.SetActive(true);
      m_B2.SetActive(true);
      if (m_B4)
      {
        m_B3.SetActive(true);
        m_B5.SetActive(true);
      }
    }
  }
}
