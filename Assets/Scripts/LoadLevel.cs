using UnityEngine;

public class LoadLevel : MonoBehaviour
{
    public FrameWork phoenix;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)){
            phoenix.LoadSceneByName();
        }
    }
}
