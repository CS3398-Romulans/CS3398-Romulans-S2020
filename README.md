# Frisbee
> Frisbee is a cross-platform mobile camera app which allows users to create easy gif animations from a series of pictures taken from the users native phone camera.

## Table of contents
* [General info](#general-info)
* [Screenshots](#screenshots)
* [Technologies](#technologies)
* [Setup](#setup)
* [Features](#features)
* [Status](#status)
* [Inspiration](#inspiration)
* [Contact](#contact)

## General info
The purpose of this project is to create and share awesome gif images made by **you** with people across all sharing platforms, such as:
 * Facebook
 * Twitter
 * Instagram

## Screenshots
![Example screenshot](./img/screenshot.png)

## Technologies
* Native camera support using Xamarin API - version 0.1
* Multiplatform Deployment with UI in Android or IOS using native interface buttons - version 0.2
* Tech 3 - version 3.0

## Setup
**Releases Coming Soon, Stay Tuned!**

## Code Examples
* Tyler - Using Xamarin Camera API, created a camera reference :
```
   private async void CameraButtonClicked(object sender, EventArgs e)
        {
            try
            {
                var photo = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions() { });
            }
            catch(Exception w)
            {
                throw new Exception(w.Message);
            }
        }
```

## Features
List of features ready and TODOs for future development
* Tyler - Ability to Log in and Take pictures with the native phone camera
* Page navigation
* Page Layout


To-do list:
* Allow users to save pictures 
* Set up Camera to take multiple pictures in succession and concatenate them together
* share created gifs across sharing services

## Status
Project is: _in progress_

## Inspiration
This project is inspired by Boomerang, a popular Instagram extension with a similar theme.

## Contact
Created by [Irene Marmelejo](), [Gisele D'Abreu](), [Mario Gomez](), and [Tyler Carroll]() - Contact us for questions or support
