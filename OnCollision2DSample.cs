using UnityEngine;

public class OnCollision2DSample : MonoBehaviour
{
    [SerializeField]
    private Color           mycolor;
    private SpriteRenderer  spriterenderer;

    private void Awake()
    {
        spriterenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        spriterenderer.color = mycolor;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log($"{gameObject.name} : OnCollisionStay2D() 메소드 실행");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        spriterenderer.color = Color.white;
    }

}