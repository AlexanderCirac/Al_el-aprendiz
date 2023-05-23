using UnityEngine;
using UnityEngine.UI;

namespace AlexanderCA.ProMenu.Opciones
{

  [ExecuteInEditMode]
  public class PrM_CameraContrAndBright : PrM_Behaviour
  {
    #region Attribute
    internal Material MenuProShaderProces;
    [SerializeField]internal float Brightness;
    [SerializeField]internal float Contrast;
    internal float VignetteIntensity = 0;
    [SerializeField] internal Scrollbar _contrastScroball;
    [SerializeField] internal Scrollbar _brightnessScroball;
    #endregion

    #region UnityCalls
    void Start() => StartUp();
    #endregion   
    
    #region custom public methods
    public void OnRenderImage(RenderTexture src, RenderTexture dest)
    {
        if (MenuProShaderProces != null)
        {
            MenuProShaderProces.SetFloat("_Brightness", Brightness);
            MenuProShaderProces.SetFloat("_Contrast", Contrast);
            MenuProShaderProces.SetFloat("_VignetteIntensity", VignetteIntensity);

            Graphics.Blit(src, dest, MenuProShaderProces);
        }
    }
    public void SetCameraContrAndBright (float Brightness, float Contrast, Scrollbar _contrastScroball, Scrollbar _brightnessScroball)
    {
        this.Brightness = (Brightness + 1);
        this.Contrast = (Contrast + 1);
        this._contrastScroball = _contrastScroball;
        this._brightnessScroball = _brightnessScroball;
    }
    #endregion

    #region custom private method
    void StartUp()
    {

      if (_contrastScroball)
      {
        _contrastScroball.value = _optionsManager._contrastFloat;
        _contrastScroball.onValueChanged.AddListener (ToChangeContrast);

      }
      if (_brightnessScroball)
      {
        _brightnessScroball.value = _optionsManager._brightFloat;
        _brightnessScroball.onValueChanged.AddListener (ToChangeBright);

      }

      if (!MenuProShaderProces)
      {
        Material mat = new Material(Shader.Find("MenuProShader/MenuProShaderProces"));
        MenuProShaderProces = mat;
      }


      Brightness = _dataPersiten._brightFloat == _optionsManager._brightFloat ? (_optionsManager._brightFloat + 1) : (_dataPersiten._brightFloat + 1);
      Contrast = _dataPersiten._contrastFloat == _optionsManager._contrastFloat ? (_optionsManager._contrastFloat + 1) : (_dataPersiten._contrastFloat + 1);

    }    
    void ToChangeContrast(float value)
    {
        _optionsManager._contrastFloat = _contrastScroball.value;
        Contrast = _contrastScroball.value + 1;
    }    
    void ToChangeBright(float value)
    {
        _optionsManager._brightFloat = _brightnessScroball.value;
        Brightness = _brightnessScroball.value + 1;
    }
    #endregion
  }
}
