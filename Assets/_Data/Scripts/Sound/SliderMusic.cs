using UnityEngine;
using UnityEngine.UI;

public class SliderMusic : MonoBehaviour
{
    [SerializeField] protected Slider sliderTheme;
    [SerializeField] protected Slider sliderVFX;
    private static float savedSliderThemeValue = 1f;
    private static float savedSliderVFXValue = 1f;
    private void Start()
    {
        sliderTheme.value = savedSliderThemeValue;
        sliderVFX.value = savedSliderVFXValue;
    }

    private void OnDestroy()
    {
  
        savedSliderThemeValue = sliderTheme.value;
        savedSliderVFXValue = sliderVFX.value;
    }

    private void Update()
    {
        
        SoundManager.Instance.themeSource.volume = sliderTheme.value;
        SoundManager.Instance.vfxSource.volume = sliderVFX.value;
    }


}
