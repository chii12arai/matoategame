using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quizz1 : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Input.GetKeyUp�̓L�[����x�����ꂽ��A���ꂪ�����ꂽ����True��Ԃ�
        // KeyCode.Space�̓X�y�[�X�L�[��\��
        if (Input.GetKeyUp(KeyCode.Space))
        {
            // �͂�����������͕ϐ�force��Vector3�^�Œ�`
            // Vector3 force = new Vector3(x���ւ̗�,y���ւ̗�,z���ւ̗�)
            Vector3 force = new Vector3(0.0f, 6.5f, 5.0f);

            // Sphere�I�u�W�F�N�g��Rigidbody�R���|�[�l���g�ւ̎Q�Ƃ��擾
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();

            // �͂������郁�\�b�h
            // �͂̉�������ForceMode����I�ׂ�
            // ForceMode.Impulse�͌���
            rb.AddForce(force, ForceMode.Impulse);
        }

    }
}
