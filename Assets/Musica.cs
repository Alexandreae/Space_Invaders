using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musica: MonoBehaviour
{
      private static Musica instance = null;
      private AudioSource as_audio;

      private void Awake()
      {
          if (instance == null)
          { 
               instance = this;
               DontDestroyOnLoad(gameObject);
               return;
          }
          if (instance == this) return; 
          Destroy(gameObject);
      }

      void Start()
      {
         as_audio = GetComponent<AudioSource>();
         as_audio.Play();
      }
}
