using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_AnimacionControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      SaltoAnimacionCaida();
    }

  public GameObject m_animacionSalto;
 [HideInInspector]
  public bool m_boolanimacion;
  private bool m_boolsalto;
  [HideInInspector]
  public bool m_boolsalto1;
  [HideInInspector]
  public bool m_boolagachar;

  void OnTriggerEnter(Collider coll)
  {
    if (coll.CompareTag("Suelo"))
    {
      m_animacionSalto.SetActive(false);
      m_boolsalto1 = false;
    }

    if (m_boolsalto && coll.CompareTag("Suelo"))
    {
      m_boolagachar = true;
    }
  } 

  void OnTriggerExit(Collider coll)
  {
    if (coll.CompareTag("Suelo"))
    {
      m_animacionSalto.SetActive(true);
      m_boolanimacion = true;
      m_boolsalto1 = true;
    }
  }
  public void ActivarSalto()
  {
    m_boolsalto = true;
    
  }

  private float m_tiempo;
  public GameObject m_caida;
  void SaltoAnimacionCaida()
  {
    if (m_boolagachar)
    {
      m_tiempo += 1 * Time.deltaTime;

      if (m_tiempo < 0.3f)
      {
        m_caida.SetActive(true);
      }      
      else
      {
        m_caida.SetActive(false);
        m_boolanimacion = false;
        m_boolagachar = false;
        
      }
    }
    else
    {
      m_tiempo = 0;
    }
  }
  
  
}
