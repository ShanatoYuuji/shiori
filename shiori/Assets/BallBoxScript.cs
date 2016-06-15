using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BallBoxScript : MonoBehaviour {

   public Transform ball;
    int n = 0;

	// Update is called once per frame
	void Update () {
        if (Input.GetButtonUp("Jump"))
        {
            Instantiate(ball, transform.position, transform.rotation);
            n++;
            Debug.Log(n);
        }
        if (n > 10)
        {
            //过时
            // Application.LoadLevel("GameOver");
            //现在用
            Debug.Log(n);
            SceneManager.LoadScene("GameOver");
        }
    }
}
