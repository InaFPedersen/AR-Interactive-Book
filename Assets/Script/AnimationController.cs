using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationController : MonoBehaviour
{
    //Variables:
    public Animator animator;
    public Transform girlModel;
    public Transform pauseButton;

    // Start is called before the first frame update
    void Start()
    {
        animator = girlModel.GetComponent<Animator>();
    }

    public void PlayGreetingAnim()
    {
        animator.Play("Greeting");
    }

    public void PlayWalkingAnim()
    {
        animator.Play("Walking");
    }

    public void PlayJumpingAnim()
    {
        animator.Play("Jumping");
    }

    public void PlayLayingAnim()
    {
        animator.Play("Laying");
    }

    public void PlaySwimmingAnim()
    {
        animator.Play("Swimming");
    }

    public void PlayClimbingAnim()
    {
        animator.Play("Climbing");
    }

    public void PlaySingingAnim()
    {
        animator.Play("Singing");
    }

    public void PlayBowingAnim()
    {
        animator.Play("Bowing");
    }


    public void PauseAnimation()
    {
        animator.speed = 0;
        Button btn = pauseButton.GetComponent<Button>();
        btn.onClick.AddListener(ResumeAnimation);
    }

    void ResumeAnimation()
    {
        animator.speed = 1;
        Button btn = pauseButton.GetComponent<Button>();
        btn.onClick.AddListener(PauseAnimation);
    }
}
