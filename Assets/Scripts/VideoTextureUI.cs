using UnityEngine;
using UnityEngine.UI;

public class VideoTextureUI : MonoBehaviour 
{
    public string VideoName;    // 再生する動画ファイルの名前(拡張子は不要)
    protected MovieTexture SourceMovieTexture;  // 動画再生元のテクスチャ

    void Start()
    {
        StartStream(VideoName);
    }

    // 動画ファイルの再生
    protected void StartStream(string filename)
    {
        // 動画ファイルの読み込み
        SourceMovieTexture = (MovieTexture)Resources.Load(filename, typeof(MovieTexture));
        SourceMovieTexture.loop = true;

        // 動画再生先のテクスチャにMovieTextureを設定
        gameObject.GetComponent<Image>().material.SetTexture("_MainTex", SourceMovieTexture);

        // 音声再生用のコンポーネントを追加
        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = SourceMovieTexture.audioClip;

        // 動画再生
        SourceMovieTexture.Play();
        // 音声再生
        audioSource.Play();
    }

}
