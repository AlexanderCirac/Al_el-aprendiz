using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_AcitvarParedInvisible : MonoBehaviour
{
  //esta script es para activar la pared invisble y evitar que el jugador salte a zonas no deseables XD

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  public GameObject m_pared;
  private void OnTriggerEnter(Collider coll)
  {
    if (coll.CompareTag("Player"))
    {
      m_pared.SetActive(true);
    }
  }

  private void OnTriggerExit(Collider coll)
  {
    if (coll.CompareTag("Player"))
    {
      m_pared.SetActive(false);
    }
  }
}
