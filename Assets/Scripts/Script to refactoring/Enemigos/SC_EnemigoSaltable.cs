using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_EnemigoSaltable : MonoBehaviour
{

  //esta script es para controlar la vida del enemigo

  public GameObject m_enemigo;

  public Transform m_derecha;
  public Transform m_izquierda;
  public float m_velocidad;
 
  private bool m_cambio;

  // Start is called before the first frame update
  void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      patrulla();
    ladearFantasma();
    }

  void patrulla()
  {
    if (m_cambio == false)
    {
      if (m_enemigo.transform.position.x <= m_derecha.position.x - 0.2f)
      {
        m_enemigo.transform.position = Vector3.MoveTowards(m_enemigo.transform.position, new Vector3(m_derecha.position.x, m_enemigo.transform.position.y, m_enemigo.transform.position.z), m_velocidad * Time.deltaTime);
      }
      else
      {
        m_cambio = true;
      }
    }
    else
    {
      if (m_enemigo.transform.position.x >= m_izquierda.position.x + 0.2f)
      {
    
        m_enemigo.transform.position = Vector3.MoveTowards(m_enemigo.transform.position, new Vector3(m_izquierda.position.x, m_enemigo.transform.position.y, m_enemigo.transform.position.z), m_velocidad * Time.deltaTime);
      }
      else
      {
        m_cambio = false;
      }
    }
  }


  private void OnTriggerEnter(Collider coll)
  {
    
    if (coll.CompareTag("Player") && !m_fantasmaFlip)
    {
      Destroy(m_fantasma.gameObject);
    }

    if (m_fantasmaFlip && coll.CompareTag("Bala"))
    {
      Destroy(m_fantasma.gameObject);
    }
  }

  public bool m_fantasmaFlip;
  public SpriteRenderer m_fantasmaSpr;
  public GameObject m_fantasma;
  
  void ladearFantasma()
  {
    if (m_fantasmaFlip){

      if (!m_cambio)
      {
        m_fantasmaSpr.flipX = false;
      }
      else
      {
        m_fantasmaSpr.flipX = true;
      }
    }
  }
}
