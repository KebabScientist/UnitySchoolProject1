using System;
using UnityEngine;
//_________________________________________ //
// |Hej Olle här är den efterlängatde koden|//
// |du har velat ha hela den här terminen. |//
// |3 klasser med arv                      |//
// |Precis som du ville ha det             |//
// |OBS! Kommenterat av gpt, inte mig      |//
// |_______________________________________|//

/// Base class for all game objects. Provides common properties and methods for game objects.
public class GameObjectBase
{
    public int ID { get; set; }
    public Vector3 Position { get; set; }
    public Quaternion Rotation { get; set; }

    // Initialize the game object
    public virtual void Initialize()
    {
        // Initialization logic here
    }

    // Update the game object each frame
    public virtual void Update()
    {
        // Update logic here
    }

    // Destroy the game object
    public virtual void Destroy()
    {
        // Cleanup logic here
    }
}

/// Base class for all vehicles. Extends GameObjectBase with properties and methods specific to vehicles.

public class VehicleBase : GameObjectBase
{
    public float Speed { get; set; }
    public int Health { get; set; }

    // Move the vehicle
    public virtual void Move()
    {
        // Movement logic here
    }

    // Inflict damage to the vehicle
    public virtual void TakeDamage(int damage)
    {
        // Damage logic here
    }

    // Repair the vehicle
    public virtual void Repair(int amount)
    {
        // Repair logic here
    }
}

/// Base class for all power-ups. Extends GameObjectBase with properties and methods specific to power-ups.

public class PowerUpBase : GameObjectBase
{
    public float EffectDuration { get; set; }

    // Apply the power-up effect
    public virtual void ApplyEffect()
    {
        // Effect application logic here
    }

    // Remove the power-up effect
    public virtual void RemoveEffect()
    {
        // Effect removal logic here
    }
}
/// <summary>
/// Base class for all cars. Extends VehicleBase with properties and methods specific to cars.
/// </summary>
public class CarBase : VehicleBase
{
    public int NumberOfWheels { get; set; }
    public float EnginePower { get; set; }

    // Accelerate the car
    public virtual void Accelerate()
    {
        // Acceleration logic here
    }

    // Brake the car
    public virtual void Brake()
    {
        // Braking logic here
    }

    // Steer the car
    public virtual void Steer(float direction)
    {
        // Steering logic here
    }
}

/// Power-up that boosts health. Extends PowerUpBase with health-specific properties and methods.

public class HealthPowerUp : PowerUpBase
{
    public int HealthBoostAmount { get; set; }

    // Apply the health boost
    public override void ApplyEffect()
    {
        // Health boost logic here
    }

    // Remove the health boost
    public override void RemoveEffect()
    {
        // Health boost removal logic here
    }
}

/// Power-up that boosts speed. Extends PowerUpBase with speed-specific properties and methods.

public class SpeedBoostPowerUp : PowerUpBase
{
    public float SpeedBoostAmount { get; set; }

    // Apply the speed boost
    public override void ApplyEffect()
    {
        // Speed boost logic here
    }

    // Remove the speed boost
    public override void RemoveEffect()
    {
        // Speed boost removal logic here
    }
}

/// A sports car with a nitro boost. Extends CarBase with properties and methods specific to sports cars.
public class SportsCar : CarBase
{
    public float NitroBoost { get; set; }

    // Use the nitro boost
    public void UseNitroBoost()
    {
        // Nitro boost logic here
    }
}

/// A truck with cargo capacity. Extends CarBase with properties and methods specific to trucks.
public class Truck : CarBase
{
    public float CargoCapacity { get; set; }

    // Load cargo onto the truck
    public void LoadCargo()
    {
        // Load cargo logic here
    }

    // Unload cargo from the truck
    public void UnloadCargo()
    {
        // Unload cargo logic here
    }
}

/// Basic health power-up. Extends HealthPowerUp with basic health-specific properties and methods.
public class BasicHealthPowerUp : HealthPowerUp
{
    public int BasicHealthBoostAmount { get; set; }

    // Apply the basic health boost
    public override void ApplyEffect()
    {
        HealthBoostAmount = BasicHealthBoostAmount;
        base.ApplyEffect();
    }
}

/// Advanced speed boost power-up. Extends SpeedBoostPowerUp with advanced speed-specific properties and methods.
public class AdvancedSpeedBoostPowerUp : SpeedBoostPowerUp
{
    public float AdvancedSpeedBoostAmount { get; set; }

    // Apply the advanced speed boost
    public override void ApplyEffect()
    {
        SpeedBoostAmount = AdvancedSpeedBoostAmount;
        base.ApplyEffect();
    }
}
