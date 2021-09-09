using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public string nameEnter;
    public string nameLeave;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log(other.tag);
    }
}
