using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class texto1 : MonoBehaviour
{
  //public SC_LectorDatos SC_LD;
  public Suscriptable1 m_objetoPersistente;
  public Text m_1;
  public Text m_2;
  public Text m_3;
  public Text m_4;
  public Text m_5;
  //public Text m_6;

    // Start is called before the first frame update
    void Start()
    {
        m_5.text = Application.persistentDataPath.ToString();
    
    }

    // Update is called once per frame
    void Update()
    {
    //m_6.text = SC_LD.m_1.ToString() + "1" + "/" + SC_LD.m_2.ToString()+"2";
    m_1.text = m_objetoPersistente.m_valorInt.ToString();
    m_2.text = m_objetoPersistente.posX.ToString();
    m_3.text = m_objetoPersistente.posY.ToString();
    m_4.text = m_objetoPersistente.posZ.ToString();
  }
}
