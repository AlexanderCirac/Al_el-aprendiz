using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_CajasDestruibles : MonoBehaviour
{

  //esta script es para  romper las cajas cuando pase por encima

  public bool m_romper;
  public GameObject m_particula;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


  private void OnTriggerEnter(Collider coll)
  {
    if (coll.CompareTag("Player"))
    {
      Funcionalidad();
    }
  }


  void Funcionalidad()
  {
    if (m_romper)
    {
      m_particula.SetActive(true);
      this.gameObject.GetComponent<MeshRenderer>().enabled = false;
      Invoke("Autodestruir",2f);
    }

    
  }

 void Autodestruir()
  {
    Destroy(this.gameObject);
  }
}
