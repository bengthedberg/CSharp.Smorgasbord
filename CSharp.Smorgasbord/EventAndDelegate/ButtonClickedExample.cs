namespace CSharp.Smorgasbord.EventAndDelegate;

// Events are a special type of delegate that can be used to notify other classes when something happens.

// Why use events?
// - To decouple classes. The class that raises the event does not need to know anything about the class that handles the event.

// How to use events?
// - Define a delegate type for the event.
// - Define an event based on the delegate type.
// - Raise the event.

// Example:
// - A class that raises an event when a button is clicked.


public class ButtonClickedExample
{
    // Example
    // A class that raises an event when a button is clicked.
    public class Button
    {
        // Define a delegate type for the event.
        public delegate void ClickHandler(object sender, EventArgs args);
        // Define an event based on the delegate type.
        public event ClickHandler Click;
        // Raise the event.
        public void OnClick()
        {
            Click?.Invoke(this, EventArgs.Empty);
        }
    }

    // A class that handles the event.
    public class ButtonClickHandler
    {
        public void OnClick(object sender, EventArgs args)
        {
            Console.WriteLine("Button clicked");
        }
    }

    // Implement the event.
    public static void Run()
    {
        Console.WriteLine(typeof(ButtonClickedExample));

        Button button = new Button();
        ButtonClickHandler handler = new ButtonClickHandler();
        button.Click += handler.OnClick;
        button.OnClick();
    }

}