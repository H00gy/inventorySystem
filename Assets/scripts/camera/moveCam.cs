using UnityEngine;

public class moveCam : MonoBehaviour
{
    /// <summary>
    /// this script simply moves the camera to a different position when the inventory button is clicked
    /// </summary>
    Camera cam;
    
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
        cam.transform.position = new Vector3(0f, 0f, -8.337676f);
    }

    
}
