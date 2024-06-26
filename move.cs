using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float rotationSpeed = 100.0f; // 회전 속도
    public float moveSpeed = 5.0f; // 이동 속도

    private Animator animator; // 애니메이터 컴포넌트

    // Start is called before the first frame update
    void Start()
    {
        // 애니메이터 컴포넌트 가져오기
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // 회전
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
            animator.SetBool("IsRotating", true); // 회전 애니메이션 재생
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
            animator.SetBool("IsRotating", true); // 회전 애니메이션 재생
        }
        else
        {
            animator.SetBool("IsRotating", false); // 회전 애니메이션 정지
        }

        // 이동
        // 카메라 시점에서 위쪽방향키 누르면 후진해서 서로 바꿈
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
            animator.SetBool("IsMoving", true); // 이동 애니메이션 재생
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            animator.SetBool("IsMoving", true); // 이동 애니메이션 재생
        }
        else
        {
            animator.SetBool("IsMoving", false); // 이동 애니메이션 정지
        }
    }
}
