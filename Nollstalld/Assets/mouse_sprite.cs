//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class mouse_sprite : MonoBehaviour
//{
//    private Camera cam;
//    Rigidbody2D rigid;


//    void Start()
//    {
//        cam = Camera.main;
//        rigid = GetComponent<Rigidbody2D> ()
//    }
//    void Update ()
//    {
//        float mouseX = Input.mousePosition.x;
//        float mouseY = Input.mousePosition.y;
//        Vector2 followthecursor = new Vector2(mouseX, mouseY);
//        rigid.MovePosition((Vector2)transform.position + (Vector2)followthecursor);

//    }

//    void OnGUI()
//    {
//        Vector3 point = new Vector3();
//        Event currentEvent = Event.current;
//        Vector2 mousePos = new Vector2();

//        // Get the mouse position from Event.
//        // Note that the y position from Event is inverted.
//        mousePos.x = currentEvent.mousePosition.x;
//        mousePos.y = cam.pixelHeight - currentEvent.mousePosition.y;

//        point = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, cam.nearClipPlane));

//        GUILayout.BeginArea(new Rect(20, 20, 250, 120));
//        GUILayout.Label("Screen pixels: " + cam.pixelWidth + ":" + cam.pixelHeight);
//        GUILayout.Label("Mouse position: " + mousePos);
//        GUILayout.Label("World position: " + point.ToString("F3"));
//        GUILayout.EndArea();
//    }
//}
