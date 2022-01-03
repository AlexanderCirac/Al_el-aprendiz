using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SC_ChisteRandom : MonoBehaviour
{

  public string[] m_Chistes;
 


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    IDChistesAleatoria();
    Texto();
    }

  //hacemos que elija de forma random el chiste
  private bool m_unavez;
  private int m_IdTexto;
 
  void IDChistesAleatoria()
  {
    if (!m_unavez)
    {
      m_IdTexto = Random.Range(0, m_Chistes.Length);
      m_unavez = true;
    }
  }

  //ponemos el texto en el cual saldra el chiste
  public Text m_texto;
  void Texto()
  {
    m_texto.text = m_Chistes[m_IdTexto];
  }
}
