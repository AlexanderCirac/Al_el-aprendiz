using UnityEngine;
using UnityEngine.SceneManagement;


namespace AL.Camara
{

    public class SC_CamaraPlayerController : MonoBehaviour
    {

        #region Attributes
        [SerializeField] float _velocityZoom;
        [SerializeField] float _velocityMovement;
        [SerializeField] GameObject _player;
        [SerializeField] GameObject _ancleCamera;
        #endregion

        #region UnityCall
        void Awake() => Init();
        void OnTriggerEnter(Collider coll)
        {
          //if (coll.CompareTag("Suelo2"))
          //  ZoomOut();

          if (coll.CompareTag("Suelo1"))
            ZoomIn();
        }
        #endregion

        #region custom private methods
        void Init()
        {
         //   transform.position = _ancleCamera.transform.position;
            CameraFolwPlayer();
        }
        void ZoomIn()
        {
          //  while( GetComponent<Camera>().fieldOfView >= 35)
          //    GetComponent<Camera>().fieldOfView -= _velocityZoom * Time.deltaTime;
        }
        void ZoomOut()
        {
              while(GetComponent<Camera>().fieldOfView <= 50)
                  GetComponent<Camera>().fieldOfView += _velocityZoom * Time.deltaTime;
        }
        //Camara se anclara al jugador para seguirle
        void CameraFolwPlayer()
        {
              while (SceneManager.GetActiveScene().isLoaded)
              {
                transform.position = Vector3.Lerp(transform.position, new Vector3 (transform.position.x, (_ancleCamera.transform.position.y),transform.position.z),
                ((_velocityMovement * 50) - 2));
              }

        }
        #endregion



    }
}

