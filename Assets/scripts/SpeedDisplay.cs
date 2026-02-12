using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpeedController : MonoBehaviour
{
    public Slider speedSlider;
    public TMP_Text speedText;

   
    float currentSpeed = 0;

    void Update()
    {
        currentSpeed = Mathf.Lerp(currentSpeed, speedSlider.value, Time.deltaTime * 5f);
        speedText.text = Mathf.RoundToInt(currentSpeed).ToString();
    }
}