# **Game Objectives:**
- Navigate the track.
- Execute forward and backward rotations.
- Accelerate when necessary.
- Trigger particle effects only when in contact with the ground.

## **Game Design Aims:**
- Deliver a seamless and soothing experience.

## **Core Gameplay Mechanic:**
- Avoid collisions at all costs.

## **Game Progression:**
- Successfully conquer all three stages.

# **Project Title: Frost Glides** 
## Project Log.

## 1. **Creating the Snowy Environment:**

   - In Unity, I created a closed shape using Sprite Shape under 2D objects.
   - I created a 2D sprite shape profile named "Snow Profile" and attached it to the Sprite Shape Controller, renaming it to "Level sprite shape."
   - I added snowy tile assets to "Snow Profile Sprites" and gave them a blue fill color to create an icy look.
   - I used the "Edit Spline" function in the Sprite Shape Controller to shape the icy terrain.

## 2. **Adding Physics to the Scene:**

   - I introduced a dynamic 2D object to serve as the ball rolling on the icy terrain.
   - Adjusted the collider offset of the "Level sprite shape" to make the ball appear closer to the icy terrain.

## 3. **Implementing Camera Control:**

   - I integrated the Cinemachine package and set up a virtual camera to follow the ball's movement.
   - The virtual camera tracked the ball by adjusting the screen X value to .25 for a better perspective.

## 4. **Creating the Player Character:**

   - Added a dynamic sprite for the player character and set up colliders for the skis and head.

## 5. **Adding Gameplay Elements:**

   - Utilized Surface Effectors 2D on the "Level sprite shape" to control the player's movement.
   - By checking "Used by Effector" in Edge Collider 2D, I adjusted the speed as needed.

## 6. **Player Control Script:**

   - Created a C# script for player control using torque.
   - I used if statements to detect left and right arrow key inputs.
   - Incorporated Rigidbody2D components and applied torque for rotation.
   - Defined a torque amount with a serialized field variable.

## 7. **Implementing Game Logic:**

   - Implemented a finish line and a crash scene script.
   - The finish line was set as a trigger to determine the game's outcome.
   - Created tags for triggering events.
   - The crash script handled collisions when the player's head hit the ground.
   - Added gravity scale adjustments for faster falls upon keypress.

## 8. **Scene Management:**

   - Created a separate scene for the finish line event.
   - Utilized the SceneManager from UnityEngine.SceneManagement to load scenes.

## 9. **Particle Effects:**

   - Integrated particle effects in the hierarchy for events when the player reached the finish line and when the player crashed.
   - Ensured that "Play on Awake" was unchecked to control particle triggering.
   - Used serialized fields in the crash and finish scripts for particle systems.

## 10. **Environment Design:**

    - Setup all sprite environment designs to complete the visual aspect of the game.

## 11. **Adding Boost Mechanism:**

    - Enhanced the player controller with a booster feature.
    - Revised the code and added two new methods for gravity and speed boosting.
    - Incorporated serialized fields for boost speed, base speed, and SurfaceEffectors2D.
    - Utilized SurfaceEffectors2D for terrain interaction.

## 12. **Particle Effects for Board Landings:**

    - Implemented OnCollision2D and OnCollisionExit2D to generate particle effects when the board lands on the ground and stops when in the air.

## 13. **Modifying Player Controls:**

    - Utilized public access modifiers for cross-class access.
    - Introduced a boolean variable "canMove" and used it in the PlayerController class's Update method.
    - Created a public method "DisableControls" to set "canMove" to false, which was called from the OnTrigger2D event.

## 14. **Preventing Repetition:**

    - Set boolean flags in the crash and finish scripts to prevent repetitive particle effects.

## 15. **Game Loop and Audio:**

    - Designed a start menu and game over loop.
    - Added background music to enhance the game's atmosphere.

