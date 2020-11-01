using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchPhaseDisplay : MonoBehaviour
{
    [SerializeField] private Material materialObject;
    [SerializeField] private Texture[] images;
    private int count = 1;
    // Update is called once per frame
    void Update()
    {
        
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                switch (count)
                {
                    case 0:
                        materialObject.mainTexture = images[count];
                        count++;
                        break;
                    case 1:
                        materialObject.mainTexture = images[count];
                        count++;
                        break;
                    default:
                        materialObject.mainTexture = images[count];
                        count = 0;
                        break;
                }
            }
        }
    }
}
