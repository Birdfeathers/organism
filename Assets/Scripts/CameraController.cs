using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private const float SCROLL_SCALE = 1.5f;
    private Camera thisCamera;
    private Vector2 lastMouse;
    public SpeedSlider slider;

    // Start is called before the first frame update
    void Start()
    {
        thisCamera = GetComponent<Camera>();
        lastMouse = new Vector2();
    }

    // Update is called once per frame
    void Update()
    {
        bool mouseIsInBounds =
            !(
            Input.mousePosition.x <= 0 ||
            Input.mousePosition.y <= 0 ||
            Input.mousePosition.x >= Screen.width ||
            Input.mousePosition.y >= Screen.height
            );
        if (mouseIsInBounds)
        {
            thisCamera.orthographicSize -= SCROLL_SCALE * Input.GetAxis("Mouse ScrollWheel") * thisCamera.orthographicSize;
        }
        Vector2 newMouse = thisCamera.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetButton("LeftClick") && slider.okay)
        {
            transform.Translate(lastMouse - newMouse);
            newMouse = thisCamera.ScreenToWorldPoint(Input.mousePosition);
        }
        lastMouse = newMouse;
    }
}
