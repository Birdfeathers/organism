using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManagerBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public List<ButtonBehavior2> buttons;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OffButtons()
    {
        for(int i = 0; i < buttons.Count; i++)
        {
            buttons[i].on = false;
        }
    }

}
