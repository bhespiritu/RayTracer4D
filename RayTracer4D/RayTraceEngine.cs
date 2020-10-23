using System;
using Veldrid;
using Veldrid.Sdl2;
using Veldrid.StartupUtilities;

namespace RayTracer4D
{
    internal unsafe class RayTraceEngine
    {
        private static GraphicsDevice _graphicsDevice;
        private static CommandList _commandList;
        private static DeviceBuffer _vertexBuffer;
        private static DeviceBuffer _indexBuffer;
        private static Shader[] _shaders;
        private static Pipeline _pipeline;

        static void Main(string[] args)
        {
            WindowCreateInfo windowCI = new WindowCreateInfo()
            {
                X = 100,
                Y = 100,
                WindowWidth = 960,
                WindowHeight = 540,
                WindowTitle = "Veldrid Tutorial"
            };
            Sdl2Window window = VeldridStartup.CreateWindow(ref windowCI);
            _graphicsDevice = VeldridStartup.CreateGraphicsDevice(window);
            while (window.Exists)
            {
                window.PumpEvents();
            }
        }
    }
}
