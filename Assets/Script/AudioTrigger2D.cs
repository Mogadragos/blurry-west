using UnityEngine;

public class AudioTrigger2D : MonoBehaviour
{
    public string audioNameEnter;
    public string audioNameLeave;

    public AudioManager manager;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player")
            return;
        if(audioNameLeave != "")
            manager.Stop(audioNameLeave);
        if (audioNameEnter != "")
            manager.Play(audioNameEnter);
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag != "Player")
            return;
        if (audioNameEnter != "")
            manager.Stop(audioNameEnter);
        if (audioNameLeave != "")
            manager.Play(audioNameLeave);
    }
}
