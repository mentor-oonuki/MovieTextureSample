using UnityEngine;
using UnityEngine.UI;


public class VideoTexture : MonoBehaviour 
{
    public string VideoName;    // 再生する動画ファイルの名前(拡張子は不要)
    private MovieTexture SourceMovieTexture;  // 動画再生元のテクスチャ
    private AudioSource audioSource;
    private bool isVideoPlaying;

    public bool isPlaying {
        get { return isVideoPlaying; }
        private set { isVideoPlaying = value;  }
    }

    void Start()
    {
        isPlaying = false;
        StartStream(VideoName);
    }

    // 動画ファイルの読み込み
    protected void StartStream(string filename)
    {
        // 動画ファイルの読み込み
        SourceMovieTexture = (MovieTexture)Resources.Load(filename, typeof(MovieTexture));
        SourceMovieTexture.loop = true;

        // 動画再生先のテクスチャにMovieTextureを設定
        gameObject.GetComponent<Renderer>().materials[0].SetTexture("_MainTex", SourceMovieTexture);

        // 音声再生用のコンポーネントを追加
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = SourceMovieTexture.audioClip;
    }

    // 動画を再生する
    public void StartVideo()
    {
        isPlaying = true;

        // 動画再生
        SourceMovieTexture.Play();
        // 音声再生
        audioSource.Play();
    }

    // 動画を一時停止する
    public void PauseVideo()
    {
        isPlaying = false;

        // 動画再生
        SourceMovieTexture.Pause();
        // 音声再生
        audioSource.Pause();
    }

}
