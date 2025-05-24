using UnityEngine;

public class MusicManager : MonoBehaviour
{
    // 靜態實例，用於單例模式
    public static MusicManager Instance { get; private set; }

    private AudioSource audioSource;

    private void Awake()
    {
        // 確保只有一個 MusicManager 實例
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // 防止物件在場景切換時被銷毀
        }
        else
        {
            Destroy(gameObject); // 如果已經有 MusicManager，銷毀多餘的實例
        }

        // 獲取 AudioSource 組件
        audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        // 設置音樂循環播放
        audioSource.loop = true;
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}