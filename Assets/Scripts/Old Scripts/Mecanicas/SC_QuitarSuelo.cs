using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_QuitarSuelo : MonoBehaviour
{

  //esta script es para quitar el suelo y evitar que corte la animacion
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  public GameObject m_suelo;
 // public GameObject m_SueloCamara;
  private void OnTriggerEnter(Collider coll)
  {
    if (coll.CompareTag("Player"))
    {
      m_suelo.SetActive(false);
    //  m_SueloCamara.SetActive(false);
    }
  }

  private void OnTriggerExit(Collider coll)
  {
    if (coll.CompareTag("Player"))
    {
      m_suelo.SetActive(true);
    //  m_SueloCamara.SetActive(true);
    }
  }
}
