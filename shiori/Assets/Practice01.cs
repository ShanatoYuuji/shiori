using UnityEngine;
using System.Collections;
using System;

public class Practice01 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        print("Hello World!!");
        int n;
        n = Hoge(1,2);
        print(n);
        Console.Write("こんにちは！");
    }
    int Hoge(int a,int b)
    {
        return a+b;
    }
	// Update is called once per frame
	void Update () {
	
	}
}
