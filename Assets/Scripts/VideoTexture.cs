using UnityEngine;
using UnityEngine.UI;

public class VideoTexture : MonoBehaviour 
{
    public string VideoName;
    protected MovieTexture SourceMovieTexture;
    protected Material TargetMaterial;

    void Start()
    {
        TargetMaterial = gameObject.GetComponent<Renderer>().material;
        StartStream(VideoName);
    }

    protected void StartStream(string filename)
    {
        SourceMovieTexture = (MovieTexture)Resources.Load(filename, typeof(MovieTexture));

        TargetMaterial.mainTexture = SourceMovieTexture;
        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = SourceMovieTexture.audioClip;
        SourceMovieTexture.Play();
        audioSource.Play();
    }

}
