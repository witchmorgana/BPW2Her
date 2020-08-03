

using UnityEngine;

public class activate : MonoBehaviour
{

    public Animator animator; 
    public Animator animator1;
    public Animator animator2;
    public Animator animator3;
    private void OnCollisionEnter(Collision CollisionInfo)
    {

        if (CollisionInfo.collider.tag == "Player")
        {
            animator.SetBool("collided", true);
            animator1.SetBool("collided", true);
            animator2.SetBool("collided", true);
            animator3.SetBool("collided", true);
        }
  

    }
    private void OnCollisionExit(Collision CollisionInfo)
    {

        if (CollisionInfo.collider.tag == "Player")
        {
            animator.SetBool("collided", false);
            animator1.SetBool("collided", false);
            animator2.SetBool("collided", false);
            animator3.SetBool("collided", false);
        }

    }
}