using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public string nameEnter;
    public string nameLeave;

    void OnTriggerEnter(collider other)
    {
        Debug.Log(other.tag)
    }

    void OnTriggerExit(collider other)
    {
        Debug.Log(other.tag)
    }
}
