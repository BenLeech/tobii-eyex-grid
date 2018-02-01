# Tobii Eye Grid Drawing
State-based Grid Drawing application for the Tobii EyeX/4c

## Table of Contents
1. [Setting up the 4c](#setting-up-the-4c)
2. [Getting started](#getting-started)
3. [Creating your own data streams from the Tobii API](#creating-your-own-data-streams-from-the-tobii-api)
4. [Documentation and References](#documentation-and-references)
5. [Smoothing Algorithm](#smoothing-algorithm)
6. [Known Issues](#known-issues)
7. [Operating System Support and Language Bindings](#operating-system-support-and-language-bindings)
8. [Tobii License Information](#tobii-license-information)

## Setting up the 4c
1. Position the eye tracker below your screen, angled slightly up.
2. Plug the eye tracker into your computer's USB slot
3. Download the [Tobii Eye Tracking Core Software](https://tobiigaming.com/getstarted/)
4. Open and follow the on-screen instructions to install.
5. Click the Tobii Eye Tracking menu from the bottom right of the Window's taskbar
6. Set-up a profile for each user (for most accurate results) and calibrate

## Getting started
To open or run this application locally, first clone/download/fork this repository.

[Cloning a repository](https://help.github.com/articles/cloning-a-repository/)

[Forking a repository](https://help.github.com/articles/fork-a-repo/)

Run the application from ./TobiiEyeXGrid/TobiiEyexGridApplication.cs, the main class.

## Using Tobii SDK in your own projects
If you start a project from scratch, you will need to add the Tobii Core SDK into your project first. Here is a method to reference the SDK using NuGet Package Manager. The installation guides from Tobii's development website are outdated, so following this guide is recommended.

#### Use Nuget Package Installation
1. Open Visual Studio
2. Ensure that Nuget Package Manager is installed by clicking the Tools menu and looking for 'Nuget Package Manager'.
   - If it is not there, go to 'Tools -> Get Tools and Features', search for NuGet Package Manager, and install.
3. Expand the Tool menu and click the Options
4. Expand the NuGet Package Manager from the left tree view
5. Choose the Package Sources
6. If nuget.org https://api.nuget.org/v3/index.json isn't listed as a package source:
   - Type org in the name field
   - Type https://api.nuget.org/v3/index.json repository URL in the source field
   - Click on Update
   - Restart Visual Studio
7. Ensure that you have the nuget package source from the above step. Close NuGet Package Manager options if you have it open.
8. Expand your project in the Solution Explorer
9. Right click on the References
10. Choose Manage Nuget Packages… from the menu
12. Click Browse
13. Choose the org package source to the right
14. Search for Tobii
15. Choose package Tobii.Interaction
16. Click the latest stable version (I am using v0.73)
17. Click Install

## Creating your own data streams from the Tobii SDK

## Documentation and References
[Tobii Handbook](https://tobii.github.io/CoreSDK/articles/intro.html) (Helpful tutorials, slightly outdated)

[Tobii API Documentation](https://tobii.github.io/CoreSDK/api/index.html) (Unfinished, slightly outdated)

[Tobii Developer Forums](http://developer.tobii.com/community-forums/)

[Implementation Samples](https://github.com/Tobii/CoreSDK/tree/master/samples)

## Smoothing Algorithm
This application contains basic live data smoothing techniques and algorithms to help smooth the noise of the eye tracking data stream.

If you are interested in possibling improving performance, Professor Manu Kumar from Stanford University has published a paper 
containing pseudocode for the implementation of a smoothing algorithm specifically for eye tracking.

It can be found here:
http://hci.stanford.edu/cstr/reports/2007-03.pdf

## Known Issues

## Operating System Support and Language Bindings
Operating Systems Supported: Windows7, Windows8, Windows10

Language Bindings: C#

## Tobii License Information
