using UnityEngine;
using UnityEngine.UI;

namespace AlexanderCA.ProMenu.Opciones
{
  public class PrM_GeneralBrightnessCroller : PrM_Behaviour
  {
          #region Attributes
          Scrollbar _brightnesScrollBar ;
          float _saveValue;
          float _brightnessInt;
          #endregion

          #region Unity Calls
          void Start() => StarUp();
          #endregion

          #region custom public Methods
          /// <summary>
          /// Set ScrollBar for control Brightness effects
          /// </summary>
          public void SetDateOption0(Scrollbar _brightnesScrollBar, float _brightnessInt) {
             this._brightnesScrollBar = _brightnesScrollBar; 
             this._brightnessInt = _brightnessInt;
              

          }
          #endregion

          #region custom private Methods
          /// <summary>
          /// Control Brightness effects
          /// </summary>
          void ToBrightness(float val)
          {

                  if (_saveValue != _brightnesScrollBar.value && val > 0.05f && val < 0.95f)
                  {
                      this.GetComponent<Image>().color = new Color(0,0,0, val);
                      _saveValue = val;
                        _optionsManager._overallBrightnessFloat = val;
                      
                  }
                  if (_optionsManager._overallBrightnessFloat != val)
                      _brightnesScrollBar.value = _optionsManager._overallBrightnessFloat;

  

          }
          /// <summary>
          /// Create new panel to show Brightness effects
          /// </summary>
          void StarUp()
          {

              this.gameObject?.AddComponent<Image>();

              //Rescaling 
              GetComponent<Image>().raycastTarget = false;
              GetComponent<RectTransform>().anchorMin = new Vector2(0, 0);
              GetComponent<RectTransform>().anchorMax = new Vector2(1, 1);
              GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);

            //Add value _brightnes ScrollBar
            if(_brightnesScrollBar != null)
            {
              _brightnesScrollBar.value = _brightnessInt;
              _saveValue = _brightnessInt;
             this.gameObject.GetComponent<Image>().color = new Color(0, 0, 0, _brightnessInt);

              _brightnesScrollBar.onValueChanged.AddListener(ToBrightness);
            }
            else
             this.gameObject.GetComponent<Image>().color = new Color(0, 0, 0, _brightnessInt);
          }
          #endregion

  }
}
