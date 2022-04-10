using Godot;
using System;

public class Player : KinematicBody2D
{
    [Export] private float movementSpeed = 100;
    private Sprite sprite;
    private AnimationTree animationTree;
    private AnimationNodeStateMachinePlayback stateMachine;

    private enum playerState {
        MOVE,
        ROLL,
        ATTACK
    }

    private playerState state = playerState.MOVE;
    public override void _Ready()
    {
        sprite = (Sprite)GetNode("Sprite");
        animationTree = (AnimationTree)GetNode("AnimationTree");
        stateMachine = (AnimationNodeStateMachinePlayback)animationTree.Get("parameters/playback");
        animationTree.Active = true;
    }
    public override void _PhysicsProcess(float delta)
    {
        switch(state) {
            case playerState.MOVE:
                moveState();
            break;
            case playerState.ROLL:

            break;
            case playerState.ATTACK:
                attackState();
            break;
        }
        


    }

    private void moveState(){
        var inputXY = getPlayerMovementInput();
        Vector2 velocity = MoveAndSlide(inputXY * movementSpeed);
        
        if (inputXY != Vector2.Zero) {
            animationTree.Set("parameters/idle/blend_position", inputXY);
            animationTree.Set("parameters/run/blend_position", inputXY);
            animationTree.Set("parameters/attack/blend_position", inputXY);
            stateMachine.Travel("run");
        } else {
            stateMachine.Travel("idle");
        }

        if (Input.IsActionJustPressed("attack")) {
            state = playerState.ATTACK;
        }
    }

    private void attackState(){
        stateMachine.Travel("attack");
    }
    public Vector2 getPlayerMovementInput(){
        Vector2 inputVector = new Vector2(
            Input.GetActionStrength("right") - Input.GetActionStrength("left"), // x
            Input.GetActionStrength("down") - Input.GetActionStrength("up")     // y
        );
        return inputVector;
    }

    public void attackAnimationFinished(){
        state = playerState.MOVE;
    }
//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
