﻿using UnityEngine;
using AL.Data;

public class SC_ActivarPortal : MonoBehaviour
{
  public SC_DataPlayerPersisten SC_DJ;
    // Start is called before the first frame update
    void Start()
    {
    SC_DJ = FindObjectOfType<SC_DataPlayerPersisten>();
  }

    // Update is called once per frame
    void Update()
    {
      activar();
    }


  public GameObject m_portal;
  public GameObject m_trigerPrueba;
  public int m_id;
  void activar()
  {
    if (SC_DJ.m_retorno1 == true && m_id == 1)
    {
      m_portal.SetActive(true);
      if (m_trigerPrueba != null)
      {

     m_trigerPrueba.SetActive(false);
      }
    }    
    if (SC_DJ.m_retorno2 == true && m_id == 2)
    {
      m_portal.SetActive(true);
      m_trigerPrueba.SetActive(false);
    }   
    if (SC_DJ.m_retorno3 == true && m_id == 3)
    {
      m_portal.SetActive(true);
      if (m_trigerPrueba != null)
      {

      m_trigerPrueba.SetActive(false);
      }
    }
  }
}
