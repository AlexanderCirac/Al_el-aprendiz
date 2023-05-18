using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_eventoAniAgacho : MonoBehaviour
{

  public GameObject m_Desagachargeneral;
  public GameObject m_agachar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  void activarNormalidad()
  {
    m_Desagachargeneral.SetActive(true);
    m_agachar.SetActive(false);
  }
}
