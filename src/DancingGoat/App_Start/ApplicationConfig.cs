﻿using Kentico.Web.Mvc;

namespace DancingGoat
{
    public class ApplicationConfig
    {
        public static void RegisterFeatures(ApplicationBuilder builder)
        {
            builder.UsePreview();
            builder.UseDataAnnotationsLocalization();
            builder.UseNotFoundHandler();
        }
    }
}