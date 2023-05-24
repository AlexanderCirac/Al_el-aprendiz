using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_CORRINCORR : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         Respuesta();
    }

  public GameObject m_botonCorrecto;
  public GameObject m_botonIncorrecto;
  public int m_id;
  public bool m_respuesta;
  public GameObject m_obje1Co;
  public GameObject m_obje2In;
  public GameObject m_obje3In;
  void Respuesta()
  {
    if (m_tocado)
    {
      if (m_respuesta)
      {
        m_botonCorrecto.SetActive(true);
        m_botonIncorrecto.SetActive(false);

      }
      else
      { 
        m_botonCorrecto.SetActive(false);
        m_botonIncorrecto.SetActive(true);

      }
    }
  }
  [HideInInspector]
  public bool m_tocado;

  private void OnTriggerEnter(Collider coll)
  {
    if(coll.CompareTag("Player")){
      m_tocado = true;

      if (m_id == 3)
      {
        m_obje1Co.SetActive(true);
        m_obje2In.SetActive(false);
        m_obje3In.SetActive(false);
      }

      if (m_id == 1)
      {
        m_obje1Co.SetActive(false);
        m_obje2In.SetActive(true);
        m_obje3In.SetActive(false);
      }
      if (m_id == 2)
      {
        m_obje1Co.SetActive(false);
        m_obje2In.SetActive(false);
        m_obje3In.SetActive(true);
      }
    }
  }
}
