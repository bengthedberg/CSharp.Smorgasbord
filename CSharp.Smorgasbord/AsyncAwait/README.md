# Async & Await Simple Explanation

## Simple Analogy

A person may wait for their morning train. This is all they are doing as this is their primary task that they are currently performing. (synchronous programming (what you normally do!))

Another person may await their morning train whilst they smoke a cigarette and then drink their coffee. (Asynchronous programming)

## What is asynchronous programming?

Asynchronous programming is where a programmer will choose to run some of his code on a separate thread from the main thread of execution and then notify the main thread on it's completion.

## What does the async keyword actually do?

Prefixing the async keyword to a method name like

`async void DoSomething(){ . . .`

allows the programmer to use the await keyword when calling asynchronous tasks. That's all it does.

## Why is this important?

In a lot of software systems the main thread is reserved for operations specifically relating to the User Interface. If I am running a very complex recursive algorithm that takes 5 seconds to complete on my computer, but I am running this on the Main Thread (UI thread) When the user tries to click on anything on my application, it will appear to be frozen as my main thread has queued and is currently processing far too many operations. As a result the main thread cannot process the mouse click to run the method from the button click.

## When do you use Async and Await?

Use the asynchronous keywords ideally when you are doing anything that doesn't involve the user interface.

So lets say you're writing a program that allows the user to sketch on their mobile phone but every 5 seconds it is going to be checking the weather on the internet.

We should be awaiting the call the polling calls every 5 seconds to the network to get the weather as the user of the application needs to keep interacting with the mobile touch screen to draw pretty pictures.