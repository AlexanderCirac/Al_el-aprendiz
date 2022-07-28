using UnityEngine;
using AL.Player;

namespace AL.Player
{

    public class SC_GravetyPlayerController : MonoBehaviour
    {
        #region Attributes
        bool m_gravedad;
        [SerializeField] SC_PlayerController SC_J;
        [SerializeField] float m_massa;
        [SerializeField] float m_fuerza;
        float m_fuerzanormal;
        #endregion   
    
        #region UnityCalls
        // Start is called before the first frame update
        void Start()=> Init();
        private void OnTriggerEnter(Collider coll)
        {

          if (coll.CompareTag("Caida"))
            gravedad(true);
          if (coll.CompareTag("caida1"))
            gravedad(false);
        }
    #endregion

    #region custom private methods
    void Init()
    {
      m_fuerzanormal = this.GetComponent<ConstantForce>().force.y;
    }
    void gravedad(bool _state)
    {

      if (m_gravedad)
      {
        while (m_gravedad)
        {
            this.GetComponent<Rigidbody>().mass = m_massa;
            this.GetComponent<ConstantForce>().force = new Vector3(0, m_fuerza, 0);
        }
      }
      else
      {
        this.GetComponent<Rigidbody>().mass = 1;
        this.GetComponent<ConstantForce>().force = new Vector3(0, m_fuerzanormal, 0);

      }
    }
    #endregion
  }
}
