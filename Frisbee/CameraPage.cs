﻿using System;

using Xamarin.Forms;

namespace Frisbee
{
    public class CameraPage : ContentPage
    {
        public CameraPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

