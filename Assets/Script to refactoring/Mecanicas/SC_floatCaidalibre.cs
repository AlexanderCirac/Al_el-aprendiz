using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_floatCaidalibre : MonoBehaviour
{

  //esta script es para que el jugador este con la animacion de flotar cuando se tire
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  public bool m_caida;
  public GameObject m_caidaConsta;
  public GameObject m_caidaConjunto;
  private void OnTriggerEnter(Collider coll)
  {
    if (coll.CompareTag("Player"))
    {
      if (!m_caida)
      {
      Debug.Log("hola");
        m_caidaConsta.SetActive(true);
        m_caidaConjunto.SetActive(false);
      }    
      if (m_caida)
      {
      Debug.Log("Adios");
        m_caidaConsta.SetActive(false);
        m_caidaConjunto.SetActive(true);
      }
    }
  }

  public void SuspendIz()
  {
    m_caidaConsta.GetComponent<SpriteRenderer>().flipX = true;
  } 
  public void SuspendDer()
  {
    m_caidaConsta.GetComponent<SpriteRenderer>().flipX = false;
  }
}
