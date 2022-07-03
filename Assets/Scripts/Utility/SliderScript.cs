using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    [SerializeField]
    private Slider _slider;

    [SerializeField]
    private Text _sliderText;
    // Start is called before the first frame update
    void Start()
    {
        _slider.onValueChanged.AddListener((v) => _sliderText.text = v.ToString());
        _slider.onValueChanged.Invoke(_slider.value);
    }
}
