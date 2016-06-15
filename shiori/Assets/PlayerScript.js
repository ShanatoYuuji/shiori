#pragma strict

var x : int=5;

function Start () {
    Debug.Log("hello world->"+x);
}

function Update () {
    transform.position.z+=0.1;
}