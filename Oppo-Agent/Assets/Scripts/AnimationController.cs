using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AudioVisualizer;
public class AnimationController : MonoBehaviour
{
    [SerializeField] private AudioEventListener detectionListener;
    private float beat;
    Animator m_Animator;
    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        beat = detectionListener.beatThreshold;
        if(beat < 2f)
        {
            m_Animator.SetTrigger("LookAround");
        }
        
    }
}
