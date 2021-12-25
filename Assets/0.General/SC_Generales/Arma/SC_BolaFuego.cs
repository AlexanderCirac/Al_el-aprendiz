using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_BolaFuego : MonoBehaviour
{
  public float m_velocidad;
  public Rigidbody m_rg;
  public float m_tiempo;
  public GameObject m_yo;

  // Update is called once per frame
  void Update()
  {
    irPalante();
    desaparecer();
  }

  void irPalante()
  {

    m_yo.transform.position = new Vector3(m_yo.transform.position.x + m_velocidad * Time.deltaTime, m_yo.transform.position.y, m_yo.transform.position.z);
  }

  void desaparecer()
  {
    m_tiempo += 1 * Time.deltaTime;

    if (m_tiempo > 2)
    {
      Destroy(m_yo);
    }
  }
}
