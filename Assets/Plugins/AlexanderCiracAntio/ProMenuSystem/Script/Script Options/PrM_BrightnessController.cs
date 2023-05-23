using UnityEngine;
using UnityEngine.UI;

namespace AlexanderCA.ProMenu.Opciones
{
    public class PrM_BrightnessController : MonoBehaviour
    {
    
        #region Attributes
        Camera[] _brightnessCamera;
        Scrollbar _brightnessScroball;
        float _brightnessValue;
        float _brightnessValueSave;
        Camera[] _contrastCamera;
        Scrollbar _contrastScroball;
        float _contrastValue;
        float _contrastValueSave;
        #endregion

        #region UnityCalls
         void Start() => Init();

        void Update() => UpdateUp();
        #endregion

        #region custom public Methods
        public void SetBrightnessCamera(Camera[] _brightnessCamera, Scrollbar _brightnessScroball)
        {
            this._brightnessCamera = _brightnessCamera;
            this._brightnessScroball = _brightnessScroball;
        }        
        public void SetContrastCamera(Camera[] _contrastCamera, Scrollbar _contrastScroball)
        {
      
            this._contrastCamera = _contrastCamera;
            this._contrastScroball = _contrastScroball;
        }
        #endregion

        #region custom private Methods
        void UpdateUp()
        {
            BrightnessControll();
            ContrastControll();
        }
        void BrightnessControll()
        {
            if (_brightnessValue != _brightnessValueSave)
            {
                for (int i = 0; i < _brightnessCamera.Length; i++)
                {
                    //_brightnessCamera[i].gameObject.GetComponent<PrM_CameraContrAndBright>().Brightness = _brightnessValue;
                }
                //else
                //   _brightnessValueSave = _brightnessValue;
            }
        }        
        void ContrastControll()
        {
            if (_contrastValue != _contrastValueSave)
            {
                for (int i = 0; i < _contrastCamera.Length; i++)
                {
                    //_contrastCamera[i].gameObject.GetComponent<PrM_CameraContrAndBright>().Contrast = _contrastValue;
                }
                //else
                //   _contrastValueSave = _contrastValue;
            }
        }
        void Init()
        {
            AddBrightnessControll();
            AddContrastControll();
        }
        void AddBrightnessControll()
        {
            for (int i = 0; i < _brightnessCamera.Length; i++)
            {
                  _brightnessCamera[i].gameObject.AddComponent<PrM_CameraContrAndBright>();
                  //_brightnessCamera[i].gameObject.GetComponent<PrM_CameraContrAndBright>().Brightness = _brightnessValue; 
            }
            _brightnessScroball.value = _brightnessValue;
        }        
        void AddContrastControll()
        {
            for (int i = 0; i < _brightnessCamera.Length; i++)
            {
                  //_contrastCamera[i].gameObject.AddComponent<PrM_CameraContrAndBright>();
                  //_contrastCamera[i].gameObject.GetComponent<PrM_CameraContrAndBright>().Contrast = _contrastValue; 
            }
            _contrastScroball.value = _contrastValue;
        }
        #endregion
  }
}
