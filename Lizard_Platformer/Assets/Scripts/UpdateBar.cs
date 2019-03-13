using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class UpdateBar : MonoBehaviour
{
    public FloatData FillNumber;
    private Image BarImage;
    // Start is called before the first frame update
    void Start()
    {
        BarImage = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
 //       BarImage.fillAmount = FillNumber.Value;
    }
}
