using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_ControlSalto : MonoBehaviour
{

  //[HideInInspector]
  public bool m_boolSalto;

  [HideInInspector]
  public bool m_boolAgachar;

  private void Update()
  {
    parar();
    
  }

  private void OnTriggerStay(Collider col )
  {
    
    if (col.CompareTag("Suelo"))
    {
      Desbloquear();
      m_boolSalto = true;
      
    }
    if (col.CompareTag("Agachado"))
    {
      m_boolAgachar = true;
    }
  }
  private void OnTriggerExit(Collider col)
  {

    if (col.CompareTag("Suelo"))
    {
      m_boolSalto = false;
      bloquear();
      m_contador = 0;
    }
    if (col.CompareTag("Agachado"))
    {
      m_boolAgachar = false;
    }
  }

  public int m_contador;
  public void contador()
  {
    if (m_boolSalto)
    {
      m_contador++;
    }
  }

  void parar()
  {
    if (m_contador > 0)
    {
      m_boolSalto = false;
      m_contador = 0;
    }
  }


  public GameObject m_bloqAtaq1;
  public GameObject m_bloqAtaq1Izq;
  public GameObject m_agacharder1;
  public GameObject m_agacharizq1;
  void bloquear()
  {
    if (m_bloqAtaq1Izq != null)
    {
      m_bloqAtaq1.SetActive(true);
      m_bloqAtaq1Izq.SetActive(true);

    }
    m_agacharder1.SetActive(true);
    m_agacharizq1.SetActive(true);
  }


  void Desbloquear()
  {
    m_agacharder1.SetActive(false);
    if (m_bloqAtaq1Izq != null)
    {
      m_bloqAtaq1.SetActive(false);
      m_bloqAtaq1Izq.SetActive(false);
    }
    m_agacharizq1.SetActive(false);
  }

}
