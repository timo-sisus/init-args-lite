# Init(args) Lite

## What is Init(args) Lite?
Init(args) Lite is a free version of the [Init(args) dependency injection framework](https://assetstore.unity.com/packages/tools/utilities/init-args-200530).
It extends the MonoBehaviour class with the ability to receive arguments during initialization.

You'll be able to continue using all the same commands you're used to - AddComponent and Instantiate - just with the added ability to pass arguments as well.

This small but significant change means that your components are no longer closed islands. Things that used to be pretty much impossible to do, like writing unit tests for them, are suddenly easy and frictionless.

The arguments will be received by components before the Awake and OnEnable events, so you don't have to avoid using them, or clutter them with null-checking.

## Reflection-Free
Init(args) Lite works using pure dependency injection, without any reflection; generic methods and interfaces are used to provide strongly typed pipelines through which dependencies can be delivered.

This approach has various benefits, such as solid performance compared to reflection-based dependency injection solutions, and errors being caught as early as possible at compile-time.

## Features
* `Instantiate` with upto twelve arguments.
* `AddComponent` with upto twelve arguments.
* `x != Null` - easily test if an interface type variable contains a null or destroyed reference.

# Links
* [Asset Store](https://assetstore.unity.com/packages/slug/280938)
* [Full Version](https://assetstore.unity.com/packages/tools/utilities/init-args-200530)
* [Forum](https://forum.unity.com/threads/init-args-the-practical-di-framework.1215084/)