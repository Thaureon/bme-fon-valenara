using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementScript : MonoBehaviour
{
    public GameObject Player;
    public Camera Camera;

    public WorldBuilder WorldManager;

    private InputAction _moveAction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _moveAction = InputSystem.actions.FindAction("Move");
        _moveAction.performed += Move;
    }

    // Update is called once per frame
    void Update()
    {
        //var triggered = _moveAction.;
        //if()
    }

    public void MovePlayer(Vector2 newPosition)
    {
        var translation = newPosition - (Vector2)Player.transform.position;

        Player.transform.Translate(translation);
        Camera.transform.Translate(translation);
    }

    private void Move(InputAction.CallbackContext context)
    {
        var movement = (Vector2)context.ReadValueAsObject();

        var translation = movement;
        translation.x = Mathf.Round(translation.x);
        translation.y = Mathf.Round(translation.y);

        Player.transform.Translate(translation);
        Camera.transform.Translate(translation);

        WorldManager.GenerateWorld(Player.transform.position);
    }
}
