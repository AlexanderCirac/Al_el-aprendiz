using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_teletransortador : MonoBehaviour
{

  //esto es para ir probando
  public GameObject m_sitio;
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
      coll.transform.position = new Vector3(m_sitio.transform.position.x, m_sitio.transform.position.y, m_sitio.transform.position.z);
    }
  }
}
