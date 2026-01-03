using UnityEngine;

public class moveCam : MonoBehaviour
{
    Camera cam;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = Camera.main;
    }
    public void toInv()
    {
        cam.transform.position = new Vector3(0f, -3.62f, -8.337676f);
    }
    public void toMain()
    {
        Debug.Log("clicked");
        cam.transform.position = new Vector3(0f, -3.62f, -8.337676f);
    }

    
}
