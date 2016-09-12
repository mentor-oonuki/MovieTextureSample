using UnityEngine;
using UnityEngine.UI;

public class VideoTextureUI : MonoBehaviour 
{
    public string VideoName;    // 再生する動画ファイルの名前(拡張子は不要)
    protected MovieTexture SourceMovieTexture;  // 動画再生元のテクスチャ
    protected Texture TargetTexture;            // 動画再生先のテクスチャ

    void Start()
    {
        // 再生対象のテクスチャ
        TargetTexture = gameObject.GetComponent<Image>().material.mainTexture;
        StartStream(VideoName);
    }

    // 動画ファイルの再生
    protected void StartStream(string filename)
    {
        // 動画ファイルの読み込み
        SourceMovieTexture = (MovieTexture)Resources.Load(filename, typeof(MovieTexture));

        // 動画再生先のテクスチャにMovieTextureを設定
        TargetTexture = SourceMovieTexture;
        // 音声再生用のコンポーネントを追加
        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = SourceMovieTexture.audioClip;

        // 動画再生
        SourceMovieTexture.Play();
        // 音声再生
        audioSource.Play();
    }

}
