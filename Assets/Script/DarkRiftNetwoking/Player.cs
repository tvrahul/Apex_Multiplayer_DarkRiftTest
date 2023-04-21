using UnityEngine;
using System.Collections;
using DarkRift.Client.Unity;
using DarkRift;

public class Player : MonoBehaviour
{
    [SerializeField]
    [Tooltip("The distance we can move before we send a position update.")]
    float moveDistance = 0.05f;

    public UnityClient Client { get; set; }

    Vector3 lastPosition;

    //21-04-2023
    //private Animator _animator;

    //21-04-2023
    //private int animIDJump;
    //private bool animationBlend;
    //private int animID;
    //private float grounded;


    void Awake()
    {
        lastPosition = transform.position;
        //21-04-2023
        //_animator = GetComponent<Animator>();
    }

    //21-04-2023
    //internal void SetAnimation2(int AnimIDJump, bool AnimationBlend)
    //{
    //    //Debug.Log("SetAnimation 1" +"="+ AnimIDJump +","+ AnimationBlend);

    //    animIDJump = AnimIDJump;
    //    animationBlend = AnimationBlend;

    //    //_animator.SetBool(AnimIDJump, AnimationBlend);
    //}

    //21-04-2023
    //internal void SetAnimation2(int AnimID, float Grounded)
    //{
    //    //Debug.Log("SetAnimation 2" + "=" + AnimID + "," + Grounded);

    //    animID = AnimID;
    //    grounded = Grounded;

    //    //_animator.SetFloat(AnimID, Grounded);
    //}


    void Update()
    {
        if (Vector3.Distance(lastPosition, transform.position) > moveDistance)
        {
            using (DarkRiftWriter writer = DarkRiftWriter.Create())
            {
                writer.Write(transform.position.x);
                writer.Write(transform.position.y);
                writer.Write(transform.position.z);

                //21-04-2023
                //writer.Write(animIDJump);
                //writer.Write(animationBlend);
                //writer.Write(animID);
                //writer.Write(grounded);

                using (Message message = Message.Create(Tags.MovePlayerTag, writer))
                {
                    //Debug.Log(transform.position.x + "," + transform.position.y + "," + transform.position.z);
                    Client.SendMessage(message, SendMode.Unreliable);
                }
            }

            lastPosition = transform.position;
        }
    }
}
