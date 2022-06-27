using UnityEngine;


namespace AL.Camara
{

    public class SC_CamaraPlayerController : MonoBehaviour
    {

        #region Attributes
        public GameObject _camera;
        public float _velocity;
        #endregion

        #region UnityCall
        private void OnTriggerEnter(Collider coll)
        {
          if (coll.CompareTag("Suelo2"))
            ZoomOut();

          if (coll.CompareTag("Suelo1"))
            ZoomIn();
        }
        #endregion

        #region custom private methods
        void ZoomIn()
        {
          while( _camera.GetComponent<Camera>().fieldOfView >= 35)
            _camera.GetComponent<Camera>().fieldOfView -= _velocity * Time.deltaTime;
        }
        void ZoomOut()
        {
            while(_camera.GetComponent<Camera>().fieldOfView <= 50)
                _camera.GetComponent<Camera>().fieldOfView += _velocity * Time.deltaTime;
        }
        #endregion



    }
}

