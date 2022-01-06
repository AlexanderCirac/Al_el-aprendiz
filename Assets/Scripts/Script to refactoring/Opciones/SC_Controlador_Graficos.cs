using UnityEngine;
using AL.Data;
public class SC_Controlador_Graficos : MonoBehaviour
{
  [HideInInspector]
  public SC_SettingsDataPersisten SC_D;

 
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     LectorScript();
    }

  void LectorScript()
  {

    if (SC_D == null)
    {

      SC_D = FindObjectOfType<SC_SettingsDataPersisten>();
    }
  }

  //public void bajo()
  //{
  //  SC_D.m_ID_Grafico = 0;
  //}

  //public void Normal()
  //{
  //  SC_D.m_ID_Grafico = 2;
  //}

  
}
