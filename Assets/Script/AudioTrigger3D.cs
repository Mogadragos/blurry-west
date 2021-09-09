using UnityEngine;
using UnityEngine.Audio;

[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(CapsuleCollider))]
public class AudioTrigger3D : MonoBehaviour
{
    public AudioSource source;
    public Collider collider;
    public bool unique = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player")
            return;
        if (source.isPlaying)
            return;

        source.Play();

        if(unique)
            collider.enabled = false;
    }
}
