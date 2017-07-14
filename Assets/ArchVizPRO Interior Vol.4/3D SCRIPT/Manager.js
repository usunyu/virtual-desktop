#pragma strict

// This script turn on/off the fake camera at Start. This is to avoid a bug in the lightshaft.cs script

var CameraFake : GameObject;

function Start () {
CameraOFF();
}

function Update () {
}

function CameraOFF (){
yield WaitForSeconds (0.1);
CameraFake.active = false;
}
