using UnityEngine;

namespace AL.Options
{

  public class SC_ModelDistanceController : MonoBehaviour
  {

    //Idea; Esta script es para que cambie la aprencia del modelo segun la distancia del jugador.

    #region Attribute
    SC_ModelDistanceManager _modelDistanceManager => FindObjectOfType<SC_ModelDistanceManager>();
    [System.Serializable]
    public class c_Mallas
    {

      public Sprite m_Malla_Baja;
      public Sprite m_Malla_Alta;
    }
    public c_Mallas _malla = new c_Mallas();
    #endregion


    #region UnityCalls
    void Update() => ToCheckDistance();
    #endregion

    #region custom private methods
    void ToCheckDistance()
    {
      //if (_modelDistanceManager.m_Jugador.transform.position.y < _modelDistanceManager.m_Distancia_ParaMallaAlta)
      //{
      //  this.gameObject.SetActive(false);
      //}
      //else
      //{
      //  this.gameObject.SetActive(true);
      //  if (_modelDistanceManager.m_Jugador.transform.position.y > _modelDistanceManager.m_Distancia_ParaMallaBaja && _modelDistanceManager.m_Jugador.transform.position.y < _modelDistanceManager.m_Distancia_ParaMallaAlta)
      //      if(_malla.m_Malla_Baja)
      //          this.gameObject.GetComponent<SpriteRenderer>().sprite = _malla.m_Malla_Baja;
      //  else
      //      if(_malla.m_Malla_Alta)
      //          this.gameObject.GetComponent<SpriteRenderer>().sprite = _malla.m_Malla_Alta;

      //}
    }
    #endregion
  }
}
