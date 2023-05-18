using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Pinchos : MonoBehaviour
{

  //esta script es para controlar el movimiento de los pinchos

    public float m_velocidad;
    public Transform m_arriba;
    public Transform m_abajo;
    public bool m_cambio;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      SubirPinchos();
    
    }

    void SubirPinchos()
    {

      if (m_cambio == false)
      {
        if (transform.position.y <= m_arriba.position.y - 0.2f)
        {
          transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, m_arriba.position.y, transform.position.z), m_velocidad * Time.deltaTime);
        }
        else
        {
          m_cambio = true;
        }
      }
      else
      {
        if (transform.position.y >= m_abajo.position.y + 0.2f)
        {
          transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, m_abajo.position.y, transform.position.z), m_velocidad * Time.deltaTime);
        }
        else
        {
          m_cambio = false;
        }
      }
  }

 
}
