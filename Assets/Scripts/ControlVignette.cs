using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class ControlVignette : MonoBehaviour
{
    public PostProcessVolume volumenEfectos;
    private Vignette vignette;
    // Start is called before the first frame update
    void Start()
    {
      volumenEfectos.profile.TryGetSettings(out vignette);
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.Alpha1))
      {
        CambiarIntensidadVignette(0.1f);
      } 

      if(Input.GetKeyDown(KeyCode.Alpha2))
      {
        CambiarIntensidadVignette(0.3f);
      }

      if(Input.GetKeyDown(KeyCode.Alpha3))
      {
        CambiarIntensidadVignette(0.45f);
      } 

      if(Input.GetKeyDown(KeyCode.Alpha4))
      {
        CambiarIntensidadVignette(0.65f);
      } 

      if(Input.GetKeyDown(KeyCode.Alpha5))
      {
        CambiarIntensidadVignette(1f);
      } 
    }

    public void CambiarIntensidadVignette(float nuevaIntensidad)
    {
      if(vignette != null)
      {
        vignette.intensity.overrideState = true;
        vignette.intensity.value = nuevaIntensidad;
      }
    }
}
