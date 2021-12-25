using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SC_GuardadosYcargados : MonoBehaviour
{
  public GameObject m_1;

   void Start()
  {
    
  }

   void Update()
  {
    
  }

  public void Guardar()
  {
    PlayerPrefs.SetFloat("dato1", 1);
    PlayerPrefs.SetFloat("posicionX", m_1.transform.position.x);
    PlayerPrefs.SetFloat("posicionY", m_1.transform.position.y);
    PlayerPrefs.SetFloat("posicionZ", m_1.transform.position.z);
  }

  public void cargar()
  {
    if (PlayerPrefs.GetFloat("dato1") == 1 )
    {

    float posX = PlayerPrefs.GetFloat("posicionX");
    float posY = PlayerPrefs.GetFloat("posicionY");
    float posZ = PlayerPrefs.GetFloat("posicionZ");
    m_1.transform.position = new Vector3(posX, posY, posZ);
    }
  }


  public void borrar()
  {
    PlayerPrefs.DeleteAll();
  }

}
