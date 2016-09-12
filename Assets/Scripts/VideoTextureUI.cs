using UnityEngine;
using UnityEngine.UI;

public class VideoTextureUI : MonoBehaviour 
{
    public string VideoName;
    protected MovieTexture SourceMovieTexture;
    protected Texture TargetTexture;

    void Start()
    {
        TargetTexture = gameObject.GetComponent<Image>().material.mainTexture;
        StartStream(VideoName);
    }

    protected void StartStream(string filename)
    {
        SourceMovieTexture = (MovieTexture)Resources.Load(filename, typeof(MovieTexture));

        TargetTexture = SourceMovieTexture;
        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = SourceMovieTexture.audioClip;
        SourceMovieTexture.Play();
        audioSource.Play();
    }

}
