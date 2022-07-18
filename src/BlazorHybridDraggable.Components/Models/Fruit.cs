namespace BlazorHybridDraggable.Components.Models;

/// <summary>
/// Represents a fruit.
/// </summary>
public class Fruit
{
    /// <summary>
    /// Gets or sets the fruit's name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the fruit's description.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets a url of the fruit's image.
    /// </summary>
    public string ImageUrl { get; set; }

    /// <summary>
    /// Gets or sets the fruit's state.
    /// </summary>
    public FruitStatus Status { get; set; }
}

/// <summary>
/// States a <see cref="Fruit"/> can be in.
/// </summary>
public enum FruitStatus
{
    Store,
    Cart
}