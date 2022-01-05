using UnityEngine;
using AL.Data;
public class SC_Anuncio : MonoBehaviour
{
  public SC_DataPlayerPersisten SC_DJ;
  //esta script es para que salga solo 1 vez el anuncio 

  private void Awake()
  {
    m_anuncio.SetActive(false);
  }
  // Start is called before the first frame update
  void Start()
    {
    m_anuncio.SetActive(false);
  }

    // Update is called once per frame
    void Update()
    {
    ActivarAnuncio();
    }

  public GameObject m_anuncio;
  void ActivarAnuncio()
  {
    if (SC_DJ != null)
    {
      if (!SC_DJ.m_Anuncio)
      {
        m_anuncio.SetActive(true);
      }
      else
      {
        m_anuncio.SetActive(false);
      }
    }
    else
    {
      SC_DJ = FindObjectOfType<SC_DataPlayerPersisten>();
    }
  }

  public void DesactivarAnuncio()
  {
    SC_DJ.m_Anuncio = true;
  }
}
