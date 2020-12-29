using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawlimiter : MonoBehaviour
{
    public float DrawerLimit;
    public GameObject Drawer;
    public float DrawPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DrawPosition = Drawer.transform.position.y;

        if (Drawer.transform.position.y > DrawerLimit)
            {
            Drawer.transform.position = new Vector3( 0, DrawerLimit, 0 );

        
        }
    }
}
