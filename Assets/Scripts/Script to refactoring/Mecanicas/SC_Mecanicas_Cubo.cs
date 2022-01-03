using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Mecanicas_Cubo : MonoBehaviour
{
  //esta script es para  romper las cajas cuando pase por encima
  // Start is called before the first frame update
  public int m_id_Caja;
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    Parpadear();
  }


  private void OnTriggerEnter(Collider coll)
  {
    if (coll.CompareTag("Player"))
    {
      Funcionalidad();
    }
  }

  //cuando se rompe el cubo

  void Funcionalidad()
  {
    romper();
  }

 
  public GameObject m_particula;
  public Collider m_coldider;
  void romper()
  {
    if (m_id_Caja == 1)//solo romper
    {
      m_particula.SetActive(true);
      this.gameObject.GetComponent<MeshRenderer>().enabled = false;
      m_coldider.enabled = false;
      Invoke("Autodestruir", 1.5f);
    }
    if (m_id_Caja == 2)//quitar vida y romperse
    {
      this.gameObject.GetComponent<MeshRenderer>().enabled = false;
      m_coldider.enabled = false;
      Invoke("Autodestruir", 0.5f);
    }
  }
  void Autodestruir()
  {
    Destroy(m_cubo);
  }

  //parpadeo del cubo
  public GameObject m_cubo;
  private float m_tiempo;
  public float m_tiempoMax;
  private int m_cambio;
  public float m_deley; 
  void Parpadear()
  {
    if (m_id_Caja == 3)
    {
      m_tiempo += (m_tiempoMax/2) * Time.deltaTime;

      if (m_tiempo < (m_tiempoMax+ (-m_deley)) && m_cambio == 0)
      {
        m_cambio = 0;
      }
      if (m_tiempo > (m_tiempoMax+0.1f+ (-m_deley)) && m_cambio == 0)
      {
        m_cambio = 1;
      }
      if (m_tiempo > (m_tiempoMax*2+ (-m_deley)) && m_cambio == 1)
      {
        m_tiempo = 0;
        m_cambio = 0;
      }

      if(m_cambio == 0)
      {
        m_cubo.SetActive(true);
      }
      else
      {
        m_cubo.SetActive(false);
      }

    }
  }
}
