# Tobii Eye Grid Drawing
Grid Drawing application for the Tobii EyeX/4c

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

## Creating your own data streams from the Tobii API

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
