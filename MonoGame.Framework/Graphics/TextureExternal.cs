// MonoGame - Copyright (C) The MonoGame Team
// This file is subject to the terms and conditions defined in
// file 'LICENSE.txt', which is part of this source code package.

using System;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework.Graphics.PackedVector;
using MonoGame.Framework.Utilities;

namespace Microsoft.Xna.Framework.Graphics
{
    public partial class TextureExternal : Texture
    {
		
		public int Width { get; set; }
		public int Height { get; set; }

        public TextureExternal(GraphicsDevice graphicsDevice)
		{
            if (graphicsDevice == null)
                throw new ArgumentNullException("graphicsDevice", FrameworkResources.ResourceCreationWhenDeviceIsNull);

            this.GraphicsDevice = graphicsDevice;

            PlatformConstruct();
        }
    }
}