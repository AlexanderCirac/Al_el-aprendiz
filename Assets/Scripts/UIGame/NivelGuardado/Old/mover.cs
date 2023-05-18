using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
  public GameObject m_1;
  public GameObject m_2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  public void mover1()
  {
    m_1.transform.position = m_2.transform.position;
  }
}
