using System.Collections.Generic;
using UnityEngine.UI;

namespace AlexanderCA.ProMenu.Opciones
{
    using AlexanderCA.ProMenu.Enum;
    public class PrM_OptionsDropdown : PrM_Behaviour
    {
          #region Attribute
          MultiOptions _multiOptionsEnmu;
          int _valueActualDropDawn;
          int _valueSabeDropDawn;
          Dropdown _dropdown;
          #endregion          
    
          #region Unity Calls
          void Start()=> Init();
          #endregion
    
          #region custom public methods
          public void SetOptionsDropdown(MultiOptions _multiOptionsEnmu, Dropdown _dropdown, int _valueActualDropDawn)
          {
                this._multiOptionsEnmu = _multiOptionsEnmu;
                this._dropdown = _dropdown;
                this._valueActualDropDawn = _valueActualDropDawn;
          }          
          #endregion          
    
          #region custom private methods
          void Init()
          {
              switch (_multiOptionsEnmu)
              {
                  case MultiOptions.e_calidadSombras:
                  List<string> m_DropOptionsShadow = new List<string> { "No", "low", "medium", "high", "veryHigh" };
                  this.gameObject.GetComponent<Dropdown>().ClearOptions();
                  this.gameObject.GetComponent<Dropdown>().AddOptions(m_DropOptionsShadow);
                  //if (SC_MBO.m_actualValortCalidadSombras == 0)
                  //{
                  //  this.gameObject.GetComponent<Dropdown>().value = 0;
                  //  _valueActualDropDawn = 0;
                  //    _valueSabeDropDawn = 0;
                  //}
                  //if (SC_MBO.m_actualValortCalidadSombras == 1)
                  //{
                  //  this.gameObject.GetComponent<Dropdown>().value = 1;
                  //}
                  //if (SC_MBO.m_actualValortCalidadSombras == 2)
                  //{
                  //  this.gameObject.GetComponent<Dropdown>().value = 2;
                  //}
                  //if (SC_MBO.m_actualValortCalidadSombras == 3)
                  //{
                  //  this.gameObject.GetComponent<Dropdown>().value = 3;
                  //}
                  //if (SC_MBO.m_actualValortCalidadSombras == 4)
                  //{
                  //  this.gameObject.GetComponent<Dropdown>().value = 4;
                  //}
                  break; 
          
                  case MultiOptions.e_FPS:
                  List<string> m_DropOptionsFPS = new List<string> { "Infinito", "FPS180", "FPS60", "FPS30" };
                  this.gameObject.GetComponent<Dropdown>().ClearOptions();
                  this.gameObject.GetComponent<Dropdown>().AddOptions(m_DropOptionsFPS);
                  //if (SC_MBO.m_actualValortFPS == 0)
                  //{
                  //  this.gameObject.GetComponent<Dropdown>().value = 0;
                  //}
                  //if (SC_MBO.m_actualValortFPS == 1)
                  //{
                  //  this.gameObject.GetComponent<Dropdown>().value = 1;
                  //}
                  //if (SC_MBO.m_actualValortFPS == 2)
                  //{
                  //  this.gameObject.GetComponent<Dropdown>().value = 2;
                  //}
                  //if (SC_MBO.m_actualValortFPS == 3)
                  //{
                  //  this.gameObject.GetComponent<Dropdown>().value = 3;
                  //}
                  break;    
          
                  case MultiOptions.e_CalidadGrafica:
                    List<string> m_DropOptionsGrafic = new List<string> { "low", "normal", "hige", "VeryHige"};
                    this.gameObject.GetComponent<Dropdown>().ClearOptions();
                    this.gameObject.GetComponent<Dropdown>().AddOptions(m_DropOptionsGrafic);
                    //if (SC_MBO.m_actualValortCalidadoGrafico == 0)
                    //{
                    //  this.gameObject.GetComponent<Dropdown>().value = 0;
                    //}
                    //if (SC_MBO.m_actualValortCalidadoGrafico == 1)
                    //{
                    //  this.gameObject.GetComponent<Dropdown>().value = 1;
                    //}
                    //if (SC_MBO.m_actualValortCalidadoGrafico == 2)
                    //{
                    //  this.gameObject.GetComponent<Dropdown>().value = 2;
                    //}
                    //if (SC_MBO.m_actualValortCalidadoGrafico == 3)
                    //{
                    //  this.gameObject.GetComponent<Dropdown>().value = 3;
                    //}
                  break;    
          
                  case MultiOptions.e_Antialasing:
                  List<string> m_DropOptionsAntialasing = new List<string> { "Disable", "MultiSampling2X", "MultiSampling4X", "MultiSampling8X" };
                    this.gameObject.GetComponent<Dropdown>().ClearOptions();
                    this.gameObject.GetComponent<Dropdown>().AddOptions(m_DropOptionsAntialasing);
                    //if (SC_MBO.m_actualValortAntialasing == 0)
                    //{
                    //  this.gameObject.GetComponent<Dropdown>().value = 0;
                    //}
                    //if (SC_MBO.m_actualValortAntialasing == 1)
                    //{
                    //  this.gameObject.GetComponent<Dropdown>().value = 1;
                    //}
                    //if (SC_MBO.m_actualValortAntialasing == 2)
                    //{
                    //  this.gameObject.GetComponent<Dropdown>().value = 2;
                    //}
                    //if (SC_MBO.m_actualValortAntialasing == 3)
                    //{
                    //  this.gameObject.GetComponent<Dropdown>().value = 3;
                    //}
                  break;
                  
                  default:
                  case MultiOptions.None:
                  break;
              }
          }

          void ToChangeOptions()
          {
               if(_valueActualDropDawn != _valueSabeDropDawn)
                   switch (_multiOptionsEnmu)
                   {
                      case MultiOptions.e_calidadSombras:
                          //If(Automatica)
                          //If(button.Aplicar)
                          //If(button.Reset)

                      break; 
          
                      case MultiOptions.e_FPS:
                     
                      break;    
          
                      case MultiOptions.e_CalidadGrafica:

                      break;    
          
                      case MultiOptions.e_Antialasing:

                      break;
                  
                      default:
                      case MultiOptions.None:
                      break;
                   }
          }
          #endregion
            

    }
}
