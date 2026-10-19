using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Movimento : MonoBehaviour
{
    [Header("Movimento")]
    public float velocidade = 5f;
    public float velocidadeGiro = 720f;

    [Header("pulo Gravidade")]
    public float alturaPulo = 1.5f;
    public float gravidade = -20f;

    private CharacterController controller;
    private float velocidadeY = 0;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 direcao = new Vector3(h, 0, v);

        if (direcao.magnitude > 1f)
        {
            direcao.Normalize();
        }

        // Movimento horizontal e rotação
        if (direcao != Vector3.zero)
        {
            Quaternion rotacaoAlvo = Quaternion.LookRotation(direcao);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, rotacaoAlvo, velocidadeGiro * Time.deltaTime);
        }

        // Checa se está no chão e trata pulo
        if (controller.isGrounded)
        {
            if (velocidadeY < 0)
            {
                velocidadeY = -2f;
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                velocidadeY = Mathf.Sqrt(alturaPulo * -2f * gravidade);
            }
        }

        // Gravidade e movimento final
        velocidadeY += gravidade * Time.deltaTime;
        Vector3 movimento = direcao * velocidade;
        movimento.y = velocidadeY;
        controller.Move(movimento * Time.deltaTime);
    }
}


