using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Cambiar_gravedad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    m_fuerzanormal = this.GetComponent<ConstantForce>().force.y;
    if (SC_J != null)
    {

    m_velocidadestandar = SC_J.m_velocidadMovimiento;
    }
    }

  private void Update()
  {
    gravedad();
  }
  //Update is called once per frame
  //public float m_gravedad;
  //public bool m_gravedad1;
  //public SC_JugadorMovimiento SC_J;
  //public float m_velocidadMovimiento;

  //  public GameObject m_jugador;

  private float m_velocidadestandar;
  private bool m_gravedad;
  //private bool m_desgravedad;
  public SC_JugadorMovimiento SC_J;
  //public SC_jugadorEfectoDaño SC_JED;
  private float m_velocidadNormal;
  public float m_massa;
  public float m_fuerza;
  private float m_fuerzanormal;
  void gravedad()
  {
    if (m_gravedad)
    {

      this.GetComponent<Rigidbody>().mass = m_massa;
      this.GetComponent<ConstantForce>().force = new Vector3(0, m_fuerza, 0);
      //if (!SC_JED.m_empujarArriba1)
      //{
      //  Time.timeScale = 0.5f;
      //}
      //else
      //{
      //  Time.timeScale = 1f;
      //}
      //m_desgravedad = true;
     // SC_J.m_velocidadMovimiento = m_velocidadestandar + 0.7f;
    }
    else
    {
      this.GetComponent<Rigidbody>().mass = 1;
     this.GetComponent<ConstantForce>().force = new Vector3(0, m_fuerzanormal, 0);
      //if (!m_desgravedad)
      //{
      //  Time.timeScale = 1f;
      //  m_desgravedad = true;
      //}
      //SC_J.m_velocidadMovimiento = m_velocidadestandar;
    }
  }
  private void OnTriggerEnter(Collider coll)
  {

    if (coll.CompareTag("Caida"))
    {
      m_gravedad = true;
    }
    if (coll.CompareTag("caida1"))
    {

      m_gravedad = false;
    }
    //////////////
    //if (coll.CompareTag("Player"))
    //{
    //  if (m_gravedad1)
    //  {

    //    SC_J.m_velocidadMovimiento = m_velocidadMovimiento;
    //    Physics.gravity = new Vector3(0, 7.8f, 0);
    //    coll.GetComponent<ConstantForce>().force = new Vector3(0, m_gravedad, 0);
    ///////////////////////////////////////
    ///otra froma de hacerlo es mediante con el Time.timescale
    //  }
    //  else
    //  {
    //    SC_J.m_velocidadMovimiento = m_velocidadMovimiento * 2;
    //    Physics.gravity = new Vector3(0, -9.81f, 0);
    //    coll.GetComponent<ConstantForce>().force = new Vector3(0, m_gravedad, 0);
    
    //  }
    //}
  }
}
