using Godot;
using System;

public class Player : KinematicBody2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    [Export] private float movementSpeed = 1;
    private Sprite sprite;
    private Vector2 velocity;

    public override void _Ready()
    {
        sprite = (Sprite)GetNode("Sprite");
    }
    public override void _PhysicsProcess(float delta)
    {
        var inputXY = getPlayerMovementInput();
        velocity = MoveAndSlide(inputXY * movementSpeed);
        setFlipDirection(velocity);
        
    }

    public Vector2 getPlayerMovementInput(){
        Vector2 inputVector = new Vector2(
            Input.GetActionStrength("right") - Input.GetActionStrength("left"), // x
            Input.GetActionStrength("down") - Input.GetActionStrength("up")     // y
        );
        return inputVector;
    }

    public void setFlipDirection(Vector2 velocity) {
        if (velocity.x > 0) {
            sprite.FlipH = false;
        } else if (velocity.x < 0) {
            sprite.FlipH = true;
        }
    } 
    // Called when the node enters the scene tree for the first time.


//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
