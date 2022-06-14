using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AL.Player;

public class SC_Camera_Seguir_jugador : MonoBehaviour
{
  // esta script es para seguir al jugador cuando este se desplace
  // esta script es para seguir al jugador cuando este se desplace
  public SC_PlayerController SC_J;

  //variables para seguir jugador
  public GameObject m_camara; // la camara se anclara al objeto o al jugador
  public GameObject m_abajoGO;

 
  // Start is called before the first frame update
  void Start()
    {
   
  }

    // Update is called once per frame
    void Update()
    {
      SeguirJugador();
      Transicion();

    }

  //Seguira la jugador de forma normal,cuando no este muy arriba
  void SeguirJugadorNormal()
  {
    //this.transform.position = new Vector3 (m_jugador.transform.position.x, this.transform.position.y, this.transform.position.z);
    //transform.position =  Vector3.Lerp(new Vector3(transform.position.x, transform.position.y, -2),
    // m_jugador.transform.position, 3f * Time.deltaTime);
    if (m_arriba == false)
    {
      m_camara.transform.position = m_abajoGO.transform.position;
    }
  }

  //seguira el anclador al jugador solo en X pero no en Y o Z
  void SeguirJugador()
  {
    //this.transform.position = new Vector3 (m_jugador.transform.position.x, this.transform.position.y, this.transform.position.z);
    //transform.position =  Vector3.Lerp(new Vector3(transform.position.x, transform.position.y, -2),
    // m_jugador.transform.position, 3f * Time.deltaTime);
      m_abajoGO.transform.position = Vector3.Lerp(m_abajoGO.transform.position,
        new Vector3(transform.position.x, m_abajoGO.transform.position.y, m_abajoGO.transform.position.z),
       ((SC_J.m_velocidadMovimiento * 50) - 2));
  

  }


  //Camara se anclara al jugador para seguirle
  void SeguirJugadorArriba()
  {
    if (m_arriba == true)
    {
      m_camara.transform.position = Vector3.Lerp(m_camara.transform.position,
        new Vector3(transform.position.x, (transform.position.y), m_camara.transform.position.z),
       ((SC_J.m_velocidadMovimiento * 50) - 2));
    }

  }

  //esto es la opcion para activar un tipo de seguimiento de camara

  //variables para activar una cosa u otra
  public bool m_arriba;
  private void OnTriggerEnter(Collider coll)
  {

    if (coll.CompareTag("CajaSubir"))
    {
      m_arriba = true;
    }
    if (coll.CompareTag("CajaBajar"))
    {
      m_arriba = false;
    }
  }

  private float m_tiempotransicion;
  private int m_numero;
  private int m_numero1;
  
void Transicion()
  {
    //transicion abajo
    if (m_arriba == false && m_tiempotransicion < 1 && m_numero==0)
    {
      m_tiempotransicion += 1 * Time.deltaTime;
      m_camara.transform.position = Vector3.Lerp(m_camara.transform.position,
        new Vector3(m_abajoGO.transform.position.x, m_abajoGO.transform.position.y, m_camara.transform.position.z),
       10*Time.deltaTime);
      if (m_tiempotransicion > 0.8f)
      {
        m_numero =1;
      }
    }
    if (m_numero == 1 && m_arriba == false)
    {
      SeguirJugadorNormal();
      m_tiempotransicion = 0;
      m_numero1 = 0;
    }

    //transicion arriba
    if (m_arriba == true && m_tiempotransicion <1 && m_numero1 == 0)
    {
      m_tiempotransicion += 1 * Time.deltaTime;
      m_camara.transform.position = Vector3.Lerp(m_camara.transform.position,
        new Vector3(transform.position.x, transform.position.y, m_camara.transform.position.z),
       10 * Time.deltaTime);
      if (m_tiempotransicion > 0.8f)
      {
        m_numero1 = 1;
      }
    }
    if (m_numero1 == 1 && m_arriba == true)
    {
      SeguirJugadorArriba();
      m_tiempotransicion = 0;
      m_numero = 0;
    }
  }

}
