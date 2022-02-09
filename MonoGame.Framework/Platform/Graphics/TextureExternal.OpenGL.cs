// MonoGame - Copyright (C) The MonoGame Team
// This file is subject to the terms and conditions defined in
// file 'LICENSE.txt', which is part of this source code package.

using System;
using System.IO;
using System.Runtime.InteropServices;
using MonoGame.Framework.Utilities;

#if IOS
using UIKit;
using CoreGraphics;
using Foundation;
using System.Drawing;
#endif

#if OPENGL
using MonoGame.OpenGL;
using GLPixelFormat = MonoGame.OpenGL.PixelFormat;
using PixelFormat = MonoGame.OpenGL.PixelFormat;

#if ANDROID
using Android.Graphics;
#endif
#endif // OPENGL

namespace Microsoft.Xna.Framework.Graphics
{
    public partial class TextureExternal : Texture
    {
        private void PlatformConstruct()
        {
            this.glTarget = (TextureTarget)0x8d65;

            Threading.BlockOnUIThread(() =>
            {
                GenerateGLTextureIfRequired();
            });
        }

        public int GetGlHandle()
        {
            return this.glTexture;
        }

        private void GenerateGLTextureIfRequired()
        {
            if (this.glTexture < 0)
            {
                GL.GenTextures(1, out this.glTexture);
                GraphicsExtensions.CheckGLError();

                //GL.BindTexture(this.glTarget, this.glTexture);
                //GraphicsExtensions.CheckGLError();
            }
        }
    }
}