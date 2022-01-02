using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Ascensor : MonoBehaviour
{

  //esto script es para hacer que un objeto se desplace hacia arriba y abajo

  
    // Update is called once per frame
    void Update()
    {

    if (m_Lado)
    {
      LadoDeLado();
    }
      else{
        SubirPinchos();
      }
    
    }

  public SC_JugadorMovimiento SC_JM;
  private void OnTriggerStay(Collider Coll)
  {
    if (Coll.CompareTag("Player"))
    {
      // transform.IsChildOf(Coll.transform);
      Coll.transform.SetParent(transform);
      SC_JM.m_ascensor = true;
     // Coll.GetComponent<CapsuleCollider>().radius = 0;
    }
  }

  private void OnTriggerExit(Collider Coll)
  {
    if (Coll.CompareTag("Player"))
    {
     Coll.transform.parent = null;
      SC_JM.m_ascensor = false;
      //Coll.GetComponent<CapsuleCollider>().radius = 0.5f;

    }
  }

  public bool m_cambio;
  public float m_velocidad;
  public Transform m_arriba_Der;
  public Transform m_abajo_Izq;
  void SubirPinchos()
  {

    if (m_cambio == false)
    {
      if(transform.position.y <= m_arriba_Der.position.y - 0.2f)
      {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, m_arriba_Der.position.y, transform.position.z), m_velocidad * Time.deltaTime);
      }
      else
      {
        m_cambio = true;
      }
    }
    else
    {
      if (transform.position.y >= m_abajo_Izq.position.y + 0.2f)
      {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, m_abajo_Izq.position.y, transform.position.z), m_velocidad * Time.deltaTime);
      }
      else
      {
        m_cambio = false;
      }
    }
  }

  public bool m_Lado;
  void LadoDeLado()
  {

    if (m_cambio == false)
    {
      /*if (transform.position.x == m_arriba_Der.position.x) */if (transform.position.x <= m_arriba_Der.position.x - 0.1f)
      {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(m_arriba_Der.position.x, transform.position.y, transform.position.z), m_velocidad * Time.deltaTime);
      }
      else
      {
        m_cambio = true;
      }
    }
    else
    {
      if (transform.position.x >= m_abajo_Izq.position.x + 0.2f)
     
      {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(m_abajo_Izq.position.x, transform.position.y, transform.position.z), m_velocidad * Time.deltaTime);
      }
      else
      {
        m_cambio = false;
      }
    }
  }
}
