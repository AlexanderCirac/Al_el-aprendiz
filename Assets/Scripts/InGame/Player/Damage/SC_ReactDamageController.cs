using UnityEngine;

namespace AL.Player
{
    public class SC_ReactDamageController : MonoBehaviour
    {

      #region Attribute
          //esto activara en que lado tiene que ser empujado el jugador
      bool _isEndabledEffects;
          //esto empujara al jugador
      private float m_tiempo;
      private Rigidbody m_rg;
      //esto ara que parpade todo el rato cuando el jugador reciva daño
      public GameObject m_raizAnimacionesObj;
      public Animator m_raizAnimacionesAnim;
      #endregion

      #region  UnityCalls
      void Start() => m_rg = this.GetComponent<Rigidbody>();
      private void OnTriggerEnter(Collider coll)
      {
        if(coll.gameObject.layer == 9 )
          EmpujarJugador(-20,0);

        if(coll.gameObject.layer == 8)
          EmpujarJugador(20,0);

        if(coll.gameObject.layer == 10)
          EmpujarJugador(0,20);
      }
      #endregion

      #region custom private methods
      void EmpujarJugador(float _forceX, float _forceY)
      {
         m_rg.MovePosition(new Vector3(this.transform.position.x + _forceX, this.transform.position.y + _forceY, this.transform.position.z));
         parpadeo();
      }

    void parpadeo()
    {
      if (m_tiempo < 0.8f)
      {
       
          m_raizAnimacionesAnim.enabled = true;
          m_tiempo += 1 * Time.deltaTime;
        _isEndabledEffects = true;
      }
      else
      {
        _isEndabledEffects = false;
        m_raizAnimacionesAnim.enabled = false;
        m_raizAnimacionesObj.SetActive(true);
        m_tiempo = 0;
      }
    }
  #endregion
  }
}
