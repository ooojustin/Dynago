namespace /*rnd*/DynagoStub/*rnd*/
{

    using System;
    using System.Diagnostics;
    using System.Runtime.InteropServices;

    class /*rnd*/cl_Memory/*rnd*/
    {
        /*order-start*/
        /*junk_method*/
        /*order-*/
        public static Process /*rnd*/met_InitializeCSGO/*rnd*/()
        {
            /*junk_line*/
            Process /*rnd*/var_Process/*rnd*/;
            if (Process.GetProcessesByName("csgo").Length > 0) /*rnd*/var_Process/*rnd*/ = Process.GetProcessesByName("csgo")[0]; else return null;
            /*junk_line*/
            foreach (ProcessModule /*rnd*/var_Module/*rnd*/ in /*rnd*/var_Process/*rnd*/.Modules)
            {
                /*junk_line*/
                string /*rnd*/var_ModuleName/*rnd*/ = /*rnd*/var_Module/*rnd*/.ModuleName;
                /*junk_line*/
                switch (/*rnd*/var_ModuleName/*rnd*/)
                {
                    /*order-start*/
                    /*order-*/case "client_panorama.dll": /*rnd*/var_ClientAddress/*rnd*/  = (int) /*rnd*/var_Module/*rnd*/.BaseAddress; break;/*order-*/
                    /*order-*/case "engine.dll": /*rnd*/var_EngineAddress/*rnd*/ = (int) /*rnd*/var_Module/*rnd*/.BaseAddress; break;/*order-*/
                    /*order-*/default:
                    /*junk_line*/
                    break;/*order-*/
                    /*order-end*/
                }
                /*junk_line*/
            }
            /*junk_line*/
            /*rnd*/var_ProcessHandle/*rnd*/ = (int) OpenProcess(0x8 | 0x10 | 0x20, false, /*rnd*/var_Process/*rnd*/.Id);
            /*junk_line*/
            if (/*rnd*/var_ProcessHandle/*rnd*/ > 0 &&  /*rnd*/var_ClientAddress/*rnd*/  > 0 && /*rnd*/var_EngineAddress/*rnd*/ > 0)
                return /*rnd*/var_Process/*rnd*/;
            else return null;
        }
        /*order-*/

        /*junk_method*/

        /*order-*/public static int /*rnd*/var_ProcessHandle/*rnd*/ = 0;/*order-*/
        /*order-*/public static int /*rnd*/var_ClientAddress/*rnd*/  = 0;/*order-*/
        /*order-*/public static int /*rnd*/var_EngineAddress/*rnd*/ = 0;/*order-*/
        /*junk_method*/
        /*order-*/private static int /*rnd*/var_BytesWritten/*rnd*/ = 0;/*order-*/
        /*order-*/private static int /*rnd*/var_BytesRead/*rnd*/ = 0;/*order-*/

        /*order-*/
        [DllImport("kernel32.dll")]
        private static extern bool ReadProcessMemory(int /*rnd*/var_Process/*rnd*/, int /*rnd*/var_Address/*rnd*/, byte[] /*rnd*/var_Buffer/*rnd*/, int /*rnd*/var_BufferSize/*rnd*/, ref int /*rnd*/var_ByteCount/*rnd*/);
        /*order-*/
        /*junk_method*/
        /*order-*/
        [DllImport("kernel32.dll")]
        private static extern bool WriteProcessMemory(int /*rnd*/var_Process/*rnd*/, int /*rnd*/var_Address/*rnd*/, byte[] /*rnd*/var_Buffer/*rnd*/, int /*rnd*/var_BufferSize/*rnd*/, out int /*rnd*/var_ByteCount/*rnd*/);
        /*order-*/

        /*order-*/
        [DllImport("kernel32.dll")]
        private static extern IntPtr OpenProcess(int /*rnd*/var_DesiredAccess/*rnd*/, bool /*rnd*/var_InheritHandle/*rnd*/, int /*rnd*/var_ProcessID/*rnd*/);
        /*order-*/

        /*order-*/
        public static T /*rnd*/met_ReadMemory/*rnd*/<T>(int /*rnd*/var_Address/*rnd*/) where T : struct
        {
            int /*rnd*/var_ByteSize/*rnd*/ = Marshal.SizeOf(typeof(T));
            byte[] /*rnd*/var_Buffer/*rnd*/ = new byte[/*rnd*/var_ByteSize/*rnd*/];
            ReadProcessMemory(/*rnd*/var_ProcessHandle/*rnd*/, /*rnd*/var_Address/*rnd*/, /*rnd*/var_Buffer/*rnd*/, /*rnd*/var_Buffer/*rnd*/.Length, ref /*rnd*/var_BytesRead/*rnd*/);
            return /*rnd*/met_ByteArrayToStructure/*rnd*/<T>(/*rnd*/var_Buffer/*rnd*/);
        }
        /*order-*/
        /*junk_method*/
        /*order-*/
        public static void /*rnd*/met_WriteMemory/*rnd*/<T>(int /*rnd*/var_Address/*rnd*/, object /*rnd*/var_Value/*rnd*/) where T : struct
        {
            byte[] /*rnd*/var_Buffer/*rnd*/ = /*rnd*/met_StructureToByteArray/*rnd*/(/*rnd*/var_Value/*rnd*/);
            WriteProcessMemory(/*rnd*/var_ProcessHandle/*rnd*/, /*rnd*/var_Address/*rnd*/, /*rnd*/var_Buffer/*rnd*/, /*rnd*/var_Buffer/*rnd*/.Length, out /*rnd*/var_BytesWritten/*rnd*/);
        }
        /*order-*/

        /*order-*/
        private static T /*rnd*/met_ByteArrayToStructure/*rnd*/<T>(byte[] /*rnd*/var_Bytes/*rnd*/) where T : struct
        {
            GCHandle /*rnd*/var_Handle/*rnd*/ = GCHandle.Alloc(/*rnd*/var_Bytes/*rnd*/, GCHandleType.Pinned);
            try { return (T)Marshal.PtrToStructure(/*rnd*/var_Handle/*rnd*/.AddrOfPinnedObject(), typeof(T)); }
            finally { /*rnd*/var_Handle/*rnd*/.Free(); }
        }
        /*order-*/

        /*order-*/
        private static byte[] /*rnd*/met_StructureToByteArray/*rnd*/(object /*rnd*/var_Object/*rnd*/) {
            int /*rnd*/var_Length/*rnd*/ = Marshal.SizeOf(/*rnd*/var_Object/*rnd*/);
            byte[] /*rnd*/var_Array/*rnd*/ =  new byte[/*rnd*/var_Length/*rnd*/];
            IntPtr /*rnd*/var_Pointer/*rnd*/ = 
                Marshal.AllocHGlobal(/*rnd*/var_Length/*rnd*/);
            Marshal.StructureToPtr(/*rnd*/var_Object/*rnd*/, /*rnd*/var_Pointer/*rnd*/, true);
            Marshal.Copy(/*rnd*/var_Pointer/*rnd*/, /*rnd*/var_Array/*rnd*/, 0, /*rnd*/var_Length/*rnd*/);
            Marshal.FreeHGlobal(/*rnd*/var_Pointer/*rnd*/);
            return /*rnd*/var_Array/*rnd*/;
        }
        /*order-*/
        /*junk_method*/
        /*order-end*/
    }
}