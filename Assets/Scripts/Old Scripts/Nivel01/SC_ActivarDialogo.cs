using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_ActivarDialogo : MonoBehaviour
{

  //activar el dialogo 

  public SC_ControladorDialogos SC_CD;

  public bool m_carta2;
  public bool m_carta3;

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
      if (m_carta2)
      {
        SC_CD.m_dialogos02 = true;
      }
      if (m_carta3)
      {
        SC_CD.m_dialogos03 = true;
      }
      SC_CD.m_vacio = false;
      Destroy(this.gameObject);
    }
  }
}
