using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Renderer))]
public class AgarObject : MonoBehaviour
{
    [SerializeField]
    [Tooltip("The speed that the player will move.")]
    float speed = 0f;

    [SerializeField]
    [Tooltip("Multiplier for the scaling of the player.")]
    float scale = 0f;

    //21-04-2023
    //GameObject player;
    //private Player _player;

    Vector3 movePosition;

    //21-04-2023
    //private Animator _animator;
    //private Player _player;

    void Awake()
    {
        movePosition = transform.position;

        //21-04-2023
        //_animator = GetComponent<Animator>();
        //_player = GetComponent<Player>();
        // player = GameObject.FindWithTag("Player");
        //_player = player.GetComponent<Player>();

    }

    void Update()
    {
        if (speed != 0f)
            transform.position = Vector3.MoveTowards(transform.position, movePosition, speed * Time.deltaTime);
    }

    internal void SetColor(Color32 color)
    {
        Renderer renderer = GetComponent<Renderer>();

        renderer.material.color = color;
    }

    internal void SetRadius(float radius)
    {
        transform.localScale = new Vector3(radius * scale, radius * scale, 1);
    }

    //21-04-2023
    //internal void SetAnimation(int AnimIDJump, bool AnimationBlend) {

    //    Debug.Log("SetAnimation 1" + "=" + AnimIDJump + "," + AnimationBlend);

    //    _animator.SetBool(AnimIDJump, AnimationBlend);

    //    if (_player == null)
    //    {
    //        _player = GetComponent<Player>();
    //    }

    //    _player.SetAnimation2(AnimIDJump, AnimationBlend);
    //}

    //21-04-2023
    //internal void SetAnimation(int AnimID, float Grounded)
    //{
    //    //Debug.Log("SetAnimation 2" + "=" + AnimID + "," + Grounded);

    //    _animator.SetFloat(AnimID, Grounded);
    //    if (_player != null)
    //        _player.SetAnimation2(AnimID, Grounded);
    //}

    internal void SetMovePosition(Vector3 newPosition)
    {
        movePosition = newPosition;
    }
}
