using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotar : MonoBehaviour
{

    private Vector3 mOffset;
    private float mZCoord;

    public Camera Camara;
   
    public float sensitivity = 2f;
    public float speed=0.09f ;
   

    Vector2 moseDelta = Vector2.zero;
    Vector2 amount = Vector2.zero;
    private Renderer renderer1;

    Color Color_Original = new Color(0.9063317f, 0.9063317f, 0.9063317f, 1f);
    Color Color_Cambio = new Color(0f, 1f, 0.6477106f, 1f);

    float t = 0;

    private void Start()
    {
        renderer1 = GetComponent<Renderer>();
    }

    void OnMouseDown()
    {
        mZCoord = Camara.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
    }
    private Vector3 GetMouseAsWorldPoint()
    {
        // Pixel coordinates of mouse (x,y)
        Vector3 mousePoint = Input.mousePosition;
        // z coordinate of game object on screen
        mousePoint.z = mZCoord;
        // Convert it to world points
        return Camara.ScreenToWorldPoint(mousePoint);
    }


    void OnMouseDrag()
    {
      Rotara();   
    }
    private void OnMouseEnter()
    {
        renderer1.material.color = Color_Cambio;
    }
    private void OnMouseExit()
    {
        renderer1.material.color = Color_Original;
    }
    public void Rotara()
    {     
        if (Input.GetButton("Fire1"))
        {
            moseDelta = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
            amount += moseDelta * sensitivity;
            transform.rotation = Quaternion.AngleAxis(amount.x, Vector3.down) * Quaternion.AngleAxis(-amount.y, Vector3.right);
            t = 0;
        }        
    }

    private void Update()
    {
        if (Input.GetButton("Fire1") == false)
        {
            t += Time.deltaTime;
            Debug.Log(t);
        }

        if (t > 3)
        {
            transform.Rotate(0, speed, 0, Space.World);
        }
    }
}
