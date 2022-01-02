using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_CamaraSubir : MonoBehaviour
{

  //esta script es para controlarEl movimiento de la camara cuando suba un plataforma

  public GameObject m_camara;
  public float m_velocidad;

  private bool m_zoomIn;
  private bool m_zoomOut;
  private void Update()
  {
    ZoomIn();
    ZoomOut();
  }
  private void OnTriggerEnter(Collider coll)
  {

    if (coll.CompareTag("Suelo2"))
    {
      //if (m_camara.GetComponent<Camera>().orthographicSize <= 8) 
      //m_camara.GetComponent<Camera>().orthographicSize += m_velocidad* Time.deltaTime;
      //m_camara.GetComponent<Camera>().orthographicSize = 8;
      //StartCoroutine("ZoomOut");
      m_zoomIn = false;
      m_zoomOut = true;
    }

    if (coll.CompareTag("Suelo1"))
    {
      //if (m_camara.GetComponent<Camera>().orthographicSize >= 5)
      //  m_camara.GetComponent<Camera>().orthographicSize -= m_velocidad * Time.deltaTime;
      //m_camara.GetComponent<Camera>().orthographicSize = 5;
      //StartCoroutine("ZoomIn");
      m_zoomIn = true;
      m_zoomOut = false;
    }
  }


  void ZoomIn()
  {
    if (m_zoomIn == true && m_camara.GetComponent<Camera>().fieldOfView >= 35)
    {
      m_camara.GetComponent<Camera>().fieldOfView -= m_velocidad * Time.deltaTime;
    }
    
  }
  void ZoomOut()
  {
    if (m_zoomOut == true && m_camara.GetComponent<Camera>().fieldOfView <= 50)
    {
      m_camara.GetComponent<Camera>().fieldOfView += m_velocidad * Time.deltaTime;
    }
  }
}
