using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

    // Use this for initialization
    int x = 5;
    Vector3 m_pos;
    void Start () {
        Debug.Log("hello world->"+x);
        m_pos = transform.localPosition;
    }
   
	// Update is called once per frame
	void Update () {
        //移动方法1
        //transform.localPosition = m_pos;
        //m_pos.z += 0.1f;

        //移动方法2
        // Vector3 susumi =new  Vector3(0.1f, 0, 0.1f);
        //  transform.localPosition += susumi;

        //移动方法3
        // transform.Translate(0, 0, 0.1f);
        if (Input.GetButtonUp("Jump"))
        {
            Debug.Log("jumped!");
        }
        float shi = Input.GetAxis("Horizontal");
        transform.Translate(shi * 0.2f, 0, 0);
    }
    void OnCollisionEnter(Collision obj)
    {
        if(obj.gameObject.name== "RightWall")
        {
            Debug.Log("Hit R!");
        }
        else if (obj.gameObject.name == "LeftWall")
        {
            Debug.Log("Hit L!");
        }
    
    }
}
