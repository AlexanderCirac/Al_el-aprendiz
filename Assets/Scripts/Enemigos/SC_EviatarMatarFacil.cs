using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_EviatarMatarFacil : MonoBehaviour
{

  //estas script es para evitar que el cangrejo muera de forma accidental por atravesar
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  public GameObject m_muerte;


  private void OnTriggerEnter(Collider coll)
  {
    if (coll.CompareTag("Player"))
    {
      m_muerte.SetActive(false);
    }
  }

  private void OnTriggerExit(Collider coll)
  {
    if (coll.CompareTag("Player"))
    {
      m_muerte.SetActive(true);
    }
  }
}
