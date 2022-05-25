# RobOS Key Generator
A generator for RobOS Keys.

## Info
You need the correct activation key number to generate the correct keys. You also need the RobOS Activation key gamepass. If you don't own the gamepass, then you won't be able to activate.

## How to use
The activation key tells the program how to check for keys. Depending on the number, you will get different results.

You can show keys that were generated but not correct.

It can beep when it generates a key. It will make a low pitch beeping noise if the key is not correct, and it will make a high pitch if the key is correct depending on the activation key number.

Multi-Threading is a way of using more of your cpu to generate keys faster.

The alternate generator uses the System.Random instead of the default StrongRandom. If StrongRandom is slower or crashes, then try using the alternate generator.

StrongRandom is a NuGet Package: https://www.nuget.org/packages/StrongRandom/
