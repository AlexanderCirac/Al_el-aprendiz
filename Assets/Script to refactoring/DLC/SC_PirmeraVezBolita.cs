using UnityEngine;
using AL.Data;
public class SC_PirmeraVezBolita : MonoBehaviour
{
  //public SC_SettingsDataPersisten SC_DJ;
  //esta script es para que salga solo 1 vez el anuncio 



  // Update is called once per frame
  void Update()
  {
    ActivarAnuncio();
  }

  public GameObject m_anuncio;
  void ActivarAnuncio()
  {
    //if (SC_DJ != null)
    //{
    //  if (!SC_DJ._firstDLC)
    //  {
    //    m_anuncio.SetActive(true);
    //  }
    //  else
    //  {
    //    m_anuncio.SetActive(false);
    //  }
    //}
    //else
    //{
    //  SC_DJ = FindObjectOfType<SC_SettingsDataPersisten>();
    //}
  }

  public void DesactivarAnuncio()
  {
    //SC_DJ._firstDLC = true;
  }
}
