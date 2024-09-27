![init-args-lite](https://github.com/SisusCo/init-args-lite/assets/45103521/b21ffc42-5f2e-4144-b7a4-99c486d51b48)

## What is Init(args) Lite?
Init(args) Lite extends the MonoBehaviour class with the ability to receive arguments during initialization.

You'll be able to continue using all the same commands you're used to - AddComponent and Instantiate - just with the added ability to pass arguments as well.

The arguments will be received by components before the code in their Awake and OnEnable methods are executed, making sure that NullReferenceExceptions or bugs won't occur.

This makes it trivial to write unit tests for the components.

## Reflection-Free
Init(args) Lite doesn't use any reflection; generic methods and interfaces are used to provide strongly typed pipelines through which the dependencies can be delivered with optimal efficiency and safety.

## Features
* `Instantiate` with upto twelve arguments.
* `AddComponent` with upto twelve arguments.
* `x != Null` - easily test if an interface type variable contains a null value, or a reference to a destroyed or unassigned [Object](https://docs.unity3d.com/ScriptReference/Object.html).

## Example Component
```C#
public class TextDisplayer : MonoBehaviour<StringEvent, Text> // <- list dependencies as generic type arguments
{
    [SerializeField] StringEvent stringEvent;
    [SerializeField] Text text;
 
    protected override void Init(StringEvent stringEvent, Text text) // <- dependencies received here
    {
        this.stringEvent = stringEvent;
        this.text = text;
    }
 
    void OnEnable() => stringEvent.AddListener(OnEventRaised); // <- it's safe to use dependencies during OnEnable!
    void OnDisable() => stringEvent.RemoveListener(OnEventRaised);
    void OnEventRaised(string value) => text.text = value;
}
```

## Example Test
```C#
[Test]
public void Raising_StringEvent_Updates_Text_To_Match_Event_Argument()
{
    // Arrange
    var gameObject = new GameObject();
    var stringEvent = new StringEvent();
    var text = gameObject.AddComponent<Text>();
    gameObject.AddComponent(out textDisplayer, stringEvent, text);  // <- inject dependencies

    // Act
    stringEvent.Raise("Test");

    // Assert
    Assert.AreEqual("Test", text.text);
}
```

## Links
* [Asset Store](https://assetstore.unity.com/packages/slug/280938)
* [Full Version](https://assetstore.unity.com/packages/tools/utilities/init-args-200530)
* [Forum](https://forum.unity.com/threads/init-args-the-practical-di-framework.1215084/)
