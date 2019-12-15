using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx.Async;

public class GameManager : MonoBehaviour
{

    [SerializeField] private string word;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameObject);
        var audioSource = gameObject.GetComponent<AudioSource>();
        Destroy(audioSource);
        var rididbody = gameObject.AddComponent<Rigidbody>();
        rididbody.useGravity=false;
        Timer();
    }

    
    // Update is called once per frame
    void Update()
    {
        // Debug.Log(word);
    }

    async UniTask Timer()
    {
        Debug.Log("hogehoge");
        await UniTask.Delay(3000);
        Debug.Log(word);
        Timer();
    }
}



