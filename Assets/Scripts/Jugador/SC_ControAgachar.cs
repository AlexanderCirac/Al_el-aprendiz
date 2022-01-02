using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_ControAgachar : MonoBehaviour
{
  public SC_JugadorMovimiento SC_JM;
  // Start is called before the first frame update
  void Start()
    {
    m_normalX = this.transform.localScale.x;
    m_normalY = this.transform.localScale.y;
    m_normalZ = this.transform.localScale.z;
    m_SaltoPrimero = SC_JM.m_velocidadSaltar;
    }

    // Update is called once per frame
    void Update()
    {
      AnimacionAgachar();
    AgacharNormal();
    }


  public bool m_Boolagachar;
  private float m_tiempoAgachar;
  public void BottonAgachar()
  {
      m_Boolagachar =! m_Boolagachar;
  }

  public GameObject m_anAgachar;
  public GameObject m_anDesagachar;

  private bool m_1;
  void AnimacionAgachar()
  {

      if (m_Boolagachar && !m_1)
      {
        m_anAgachar.SetActive(true);
        m_anDesagachar.SetActive(false);
        m_1 = true;
      }
  
      if (!m_Boolagachar && m_1)
      {
        m_anAgachar.SetActive(true);
        m_anDesagachar.SetActive(false);
      m_1 = false;
      }
      
    
  }

  public void m_FlipIzquierda1()
  {
    m_anAgachar.GetComponent<SpriteRenderer>().flipX = true;
  }

  public void m_FlipDerecha1()

  {
    m_anAgachar.GetComponent<SpriteRenderer>().flipX = false;
  }




  //}
  ////Cuando el jugado se agache, reduciremos su caja para que pase por lo sitios
  private float m_normalX;
  private float m_normalY;
  private float m_normalZ;
  private float m_SaltoPrimero;


  void AgacharNormal()
  {
    if (m_Boolagachar)
    {
      this.transform.localScale = new Vector3((m_normalY / 3), (m_normalY / 3), (m_normalY / 3));
      SC_JM.m_velocidadSaltar = 0;
      bloquear();
    }
    else
    {
      this.transform.localScale = new Vector3(m_normalY, m_normalY, m_normalZ);
      SC_JM.m_velocidadSaltar = m_SaltoPrimero;
      Desbloquear();
    }

  }

  public GameObject m_bloqSalt;
  public GameObject m_bloqAtaq;
  public GameObject m_bloqSaltIzq;
  public GameObject m_bloqAtaqIzq;
  void bloquear()
  {
    if (m_bloqAtaqIzq != null)
    {
      m_bloqAtaq.SetActive(true);
      m_bloqAtaqIzq.SetActive(true);

    }
    m_bloqSalt.SetActive(true);
    m_bloqSaltIzq.SetActive(true);
  }


  void Desbloquear()
  {
    m_bloqSalt.SetActive(false);
    if (m_bloqAtaqIzq != null)
    {
      m_bloqAtaq.SetActive(false);
      m_bloqAtaqIzq.SetActive(false);
    }
    m_bloqSaltIzq.SetActive(false);
  }

  public GameObject m_agacharder;
  public GameObject m_agacharizq;

  private void OnTriggerEnter(Collider coll)
  {
    if (coll.CompareTag("Agachado"))
    {
      bloquear();
      m_agacharder.SetActive(true);
      m_agacharizq.SetActive(true);
    } 
  }


  private void OnTriggerExit(Collider coll)
  {
    if (coll.CompareTag("Agachado"))
    {
      Desbloquear();
      m_agacharder.SetActive(false);
      m_agacharizq.SetActive(false);
    }
  }
}
