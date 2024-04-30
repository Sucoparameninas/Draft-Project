using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // Velocidade do personagem
    private CharacterController controller; // Refer�ncia ao componente CharacterController

    void Start()
    {
        controller = GetComponent<CharacterController>(); // Obtendo a refer�ncia ao componente CharacterController
    }

    void Update()
    {
        // Movimenta��o do personagem
        float horizontalInput = Input.GetAxis("Horizontal"); // Input horizontal (A/D ou Setas Esquerda/Direita)
        float verticalInput = Input.GetAxis("Vertical"); // Input vertical (W/S ou Setas Cima/Baixo)

        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput); // Dire��o do movimento
        moveDirection = transform.TransformDirection(moveDirection); // Convertendo a dire��o local para global
        moveDirection *= speed; // Aplicando a velocidade

        controller.Move(moveDirection * Time.deltaTime); // Movendo o personagem
    }
}
