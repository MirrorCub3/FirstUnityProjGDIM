using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerAnimScript : MonoBehaviour
{
    [SerializeField] private string trigger;
    [SerializeField] private float animLength;
    [SerializeField] private string detectTag;

    [SerializeField] private Animator anim;
    [SerializeField] private UnityEvent useFunction;
    void Start()
    {
        if(anim == null)
            anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals(detectTag))
        {
            if(trigger != null)
                anim.SetTrigger(trigger);
            StartCoroutine(Finish(animLength));
        }
    }
    private IEnumerator Finish(float Seconds)
    {
        yield return new WaitForSeconds(Seconds);
        if (useFunction != null)
            useFunction.Invoke();
    }
}
