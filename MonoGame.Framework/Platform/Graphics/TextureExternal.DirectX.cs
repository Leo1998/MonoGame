// MonoGame - Copyright (C) The MonoGame Team
// This file is subject to the terms and conditions defined in
// file 'LICENSE.txt', which is part of this source code package.

using System;
using System.IO;
using System.Runtime.InteropServices;
using MonoGame.Framework.Utilities;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;
using MapFlags = SharpDX.Direct3D11.MapFlags;
using Resource = SharpDX.Direct3D11.Resource;

#if WINDOWS_UAP
using Windows.Graphics.Imaging;
using Windows.Storage.Streams;
using System.Threading.Tasks;
#endif

namespace Microsoft.Xna.Framework.Graphics
{
    public partial class TextureExternal : Texture
    {

        private void PlatformConstruct()
        {
            // unsupported
        }

        public int GetGlHandle()
        {
            return -1;
        }

        internal override Resource CreateTexture()
        {
            // unsupported
            return null;
        }
    }
}
