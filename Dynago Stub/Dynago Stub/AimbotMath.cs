namespace /*rnd*/DynagoStub/*rnd*/ {

    static class /*rnd*/cl_AimbotMath/*rnd*/  {

        /*order-start*/
        /*junk_method*/

        /*order-*/
        public struct /*rnd*/str_Vector3/*rnd*/  {
            /*order-start*/
            /*order-*/public float /*rnd*/var_Xc/*rnd*/;/*order-*/
            /*order-*/public float /*rnd*/var_Yc/*rnd*/;/*order-*/
            /*order-*/public float /*rnd*/var_Zc/*rnd*/;/*order-*/
            /*order-end*/
        }
        /*order-*/

        /*order-*/
        public struct /*rnd*/str_Vector2/*rnd*/ {
            /*order-start*/
            /*order-*/public float /*rnd*/var_Xc/*rnd*/;/*order-*/
            /*order-*/public float /*rnd*/var_Yc/*rnd*/;/*order-*/
            /*order-end*/
        }
        /*order-*/

        /*junk_method*/
        /*order-*/
        public static /*rnd*/str_Vector3/*rnd*/ /*rnd*/met_GetBonePos/*rnd*/(int /*rnd*/var_TargetEntity/*rnd*/, int /*rnd*/var_BoneID/*rnd*/) {
            int /*rnd*/var_BoneMatrix/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<int>(/*rnd*/var_TargetEntity/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_BoneMatrix/*rnd*/);
            /*rnd*/str_Vector3/*rnd*/ /*rnd*/var_Vector/*rnd*/ = new /*rnd*/str_Vector3/*rnd*/();
            /*order-start*/
            /*order-*//*rnd*/var_Vector/*rnd*/./*rnd*/var_Xc/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<float>(/*rnd*/var_BoneMatrix/*rnd*/ + (0x30 */*rnd*/var_BoneID/*rnd*/) + 0xC);/*order-*/
            /*order-*//*rnd*/var_Vector/*rnd*/./*rnd*/var_Yc/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<float>(/*rnd*/var_BoneMatrix/*rnd*/ + (0x30 * /*rnd*/var_BoneID/*rnd*/) + 0x1C);/*order-*/
            /*order-*//*rnd*/var_Vector/*rnd*/./*rnd*/var_Zc/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<float>(/*rnd*/var_BoneMatrix/*rnd*/ + (0x30 * /*rnd*/var_BoneID/*rnd*/) + 0x2C);/*order-*/
            /*order-end*/
            return /*rnd*/var_Vector/*rnd*/;
        }
        /*order-*/
        /*junk_method*/
        /*order-*/
        public static float met_VectorDistance(/*rnd*/str_Vector3/*rnd*/  /*rnd*/var_VectorA/*rnd*/, /*rnd*/str_Vector3/*rnd*/ /*rnd*/var_VectorB/*rnd*/) {
            /*rnd*/str_Vector3/*rnd*/  /*rnd*/var_VectorC/*rnd*/ = new /*rnd*/str_Vector3/*rnd*/ ();
            /*order-start*/
            /*order-*//*rnd*/var_VectorC/*rnd*/./*rnd*/var_Xc/*rnd*/ = /*rnd*/var_VectorA/*rnd*/./*rnd*/var_Xc/*rnd*/ - /*rnd*/var_VectorB/*rnd*/./*rnd*/var_Xc/*rnd*/;/*order-*/
            /*order-*//*rnd*/var_VectorC/*rnd*/./*rnd*/var_Yc/*rnd*/ = /*rnd*/var_VectorA/*rnd*/./*rnd*/var_Yc/*rnd*/ - /*rnd*/var_VectorB/*rnd*/./*rnd*/var_Yc/*rnd*/;/*order-*/
            /*order-*//*rnd*/var_VectorC/*rnd*/./*rnd*/var_Zc/*rnd*/ = /*rnd*/var_VectorA/*rnd*/./*rnd*/var_Zc/*rnd*/ - /*rnd*/var_VectorB/*rnd*/./*rnd*/var_Zc/*rnd*/;/*order-*/
            /*order-end*/
            return (float)System.Math.Sqrt((/*rnd*/var_VectorC/*rnd*/./*rnd*/var_Xc/*rnd*/ * /*rnd*/var_VectorC/*rnd*/./*rnd*/var_Xc/*rnd*/) + (/*rnd*/var_VectorC/*rnd*/./*rnd*/var_Yc/*rnd*/ * /*rnd*/var_VectorC/*rnd*/./*rnd*/var_Yc/*rnd*/) + (/*rnd*/var_VectorC/*rnd*/./*rnd*/var_Zc/*rnd*/ * /*rnd*/var_VectorC/*rnd*/./*rnd*/var_Zc/*rnd*/));
        }
        /*order-*/
        /*junk_method*/
        /*order-*/
        static float /*rnd*/met_Rad2Deg/*rnd*/(float /*rnd*/var_Radical/*rnd*/) {
            var /*rnd*/var_ToDegree/*rnd*/ = (float)(180f / System.Math.PI);
            return /*rnd*/var_Radical/*rnd*/ * /*rnd*/var_ToDegree/*rnd*/;
        }
        /*order-*/
        /*junk_method*/
        /*order-*/
        static double /*rnd*/met_Deg2Rad/*rnd*/(double /*rnd*/var_Degree/*rnd*/) {
            var /*rnd*/var_ToRadical/*rnd*/ = System.Math.PI / 180;
            return /*rnd*/var_Degree/*rnd*/ * /*rnd*/var_ToRadical/*rnd*/;
        }
        /*order-*/
        /*junk_method*/
        /*order-*/
        public static float /*rnd*/met_CalculateFOV/*rnd*/(/*rnd*/str_Vector3/*rnd*/ /*rnd*/var_ViewAngle/*rnd*/, /*rnd*/str_Vector3/*rnd*/  /*rnd*/var_Destination/*rnd*/, float /*rnd*/var_Distance/*rnd*/) {
            /*order-start*/
            /*order-*/float /*rnd*/var_Pitch/*rnd*/ = (float)(System.Math.Sin(/*rnd*/met_Deg2Rad/*rnd*/(/*rnd*/var_ViewAngle/*rnd*/./*rnd*/var_Xc/*rnd*/ - /*rnd*/var_Destination/*rnd*/./*rnd*/var_Xc/*rnd*/)) * /*rnd*/var_Distance/*rnd*/);/*order-*/
            /*order-*/float /*rnd*/var_Yaw/*rnd*/ = (float)(System.Math.Sin(/*rnd*/met_Deg2Rad/*rnd*/(/*rnd*/var_ViewAngle/*rnd*/./*rnd*/var_Yc/*rnd*/ - /*rnd*/var_Destination/*rnd*/./*rnd*/var_Yc/*rnd*/)) * /*rnd*/var_Distance/*rnd*/);/*order-*/
            /*order-end*/
            return (float)System.Math.Sqrt(System.Math.Pow(/*rnd*/var_Pitch/*rnd*/, 2) + System.Math.Pow(/*rnd*/var_Yaw/*rnd*/, 2));
        }
        /*order-*/
        /*junk_method*/
        /*order-*/
        public static /*rnd*/str_Vector3/*rnd*/ /*rnd*/met_CalculateAngle/*rnd*/(/*rnd*/str_Vector3/*rnd*/ /*rnd*/var_Source/*rnd*/, /*rnd*/str_Vector3/*rnd*/ /*rnd*/var_Destination/*rnd*/, bool /*rnd*/var_RCS/*rnd*/ = false) {
            /*order-start*/
            /*order-*//*rnd*/str_Vector3/*rnd*/ /*rnd*/var_Return/*rnd*/ = new /*rnd*/str_Vector3/*rnd*/ ();/*order-*/
            /*order-*//*rnd*/str_Vector3/*rnd*/ /*rnd*/var_Delta/*rnd*/ = new /*rnd*/str_Vector3/*rnd*/ ();/*order-*/
            /*order-end*/
            /*order-start*/
            /*order-*//*rnd*/var_Delta/*rnd*/./*rnd*/var_Xc/*rnd*/ = /*rnd*/var_Source/*rnd*/./*rnd*/var_Xc/*rnd*/ - /*rnd*/var_Destination/*rnd*/./*rnd*/var_Xc/*rnd*/;/*order-*/
            /*order-*//*rnd*/var_Delta/*rnd*/./*rnd*/var_Yc/*rnd*/ = /*rnd*/var_Source/*rnd*/./*rnd*/var_Yc/*rnd*/ - /*rnd*/var_Destination/*rnd*/./*rnd*/var_Yc/*rnd*/;/*order-*/
            /*order-*//*rnd*/var_Delta/*rnd*/./*rnd*/var_Zc/*rnd*/ = /*rnd*/var_Source/*rnd*/./*rnd*/var_Zc/*rnd*/ - /*rnd*/var_Destination/*rnd*/./*rnd*/var_Zc/*rnd*/;/*order-*/
            /*order-end*/
            float /*rnd*/var_Hypotenuse/*rnd*/ = (float)System.Math.Sqrt(System.Math.Pow(/*rnd*/var_Delta/*rnd*/./*rnd*/var_Xc/*rnd*/, 2) + System.Math.Pow(/*rnd*/var_Delta/*rnd*/./*rnd*/var_Yc/*rnd*/, 2));
            /*order-start*/
            /*order-*//*rnd*/var_Return/*rnd*/./*rnd*/var_Xc/*rnd*/ = /*rnd*/met_Rad2Deg/*rnd*/((float)System.Math.Atan(/*rnd*/var_Delta/*rnd*/./*rnd*/var_Zc/*rnd*/ / /*rnd*/var_Hypotenuse/*rnd*/));/*order-*/
            /*order-*//*rnd*/var_Return/*rnd*/./*rnd*/var_Yc/*rnd*/ = /*rnd*/met_Rad2Deg/*rnd*/((float)System.Math.Atan(/*rnd*/var_Delta/*rnd*/./*rnd*/var_Yc/*rnd*/ / /*rnd*/var_Delta/*rnd*/./*rnd*/var_Xc/*rnd*/));/*order-*/
            /*order-end*/

            if (/*rnd*/var_Delta/*rnd*/./*rnd*/var_Xc/*rnd*/ >= 0.0f)
                /*rnd*/var_Return/*rnd*/./*rnd*/var_Yc/*rnd*/ += 180.0f;

            if (/*rnd*/var_RCS/*rnd*/) {
                int /*rnd*/var_ShotsFired/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<int>(Program./*rnd*/var_LocalPlayer/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_ShotsFired/*rnd*/);
                if (/*rnd*/var_ShotsFired/*rnd*/ > 1) {
                    /*rnd*/str_Vector2/*rnd*/ /*rnd*/var_VectorPunch/*rnd*/ = new /*rnd*/str_Vector2/*rnd*/();
                    /*order-start*/
                    /*order-*//*rnd*/var_VectorPunch/*rnd*/./*rnd*/var_Xc/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<float>(Program./*rnd*/var_LocalPlayer/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_AimPunch/*rnd*/);/*order-*/
                    /*order-*//*rnd*/var_VectorPunch/*rnd*/./*rnd*/var_Yc/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<float>(Program./*rnd*/var_LocalPlayer/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_AimPunch/*rnd*/ + 4);/*order-*/
                    /*order-end*/
                    /*order-start*/
                    /*order-*/float /*rnd*/var_VectorPunchX/*rnd*/ = /*rnd*/var_VectorPunch/*rnd*/./*rnd*/var_Xc/*rnd*/ * 2.0f;/*order-*/
                    /*order-*/float /*rnd*/var_VectorPunchY/*rnd*/ = /*rnd*/var_VectorPunch/*rnd*/./*rnd*/var_Yc/*rnd*/ * 2.0f;/*order-*/
                    /*order-end*/
                    /*order-start*/
                    /*order-*//*rnd*/var_Return/*rnd*/./*rnd*/var_Xc/*rnd*/ -= /*rnd*/var_VectorPunchX/*rnd*/;/*order-*/
                    /*order-*//*rnd*/var_Return/*rnd*/./*rnd*/var_Yc/*rnd*/ -= /*rnd*/var_VectorPunchY/*rnd*/;/*order-*/
                    /*order-end*/
                }
            }

            return /*rnd*/var_Return/*rnd*/;
        }
        /*order-*/
        /*junk_method*/
        /*order-*/
        public static /*rnd*/str_Vector3/*rnd*/ /*rnd*/met_NormalizeDelta/*rnd*/(/*rnd*/str_Vector3/*rnd*/ /*rnd*/var_Delta/*rnd*/) {
            /*order-start*/
            /*order-*/
            if (/*rnd*/var_Delta/*rnd*/./*rnd*/var_Xc/*rnd*/ > 89.0f && /*rnd*/var_Delta/*rnd*/./*rnd*/var_Xc/*rnd*/ <= 180.0f)
                /*rnd*/var_Delta/*rnd*/./*rnd*/var_Xc/*rnd*/ = 89.0f;
            while (/*rnd*/var_Delta/*rnd*/./*rnd*/var_Xc/*rnd*/ > 180.0f)
                /*rnd*/var_Delta/*rnd*/./*rnd*/var_Xc/*rnd*/ -= 360.0f;
            while (/*rnd*/var_Delta/*rnd*/./*rnd*/var_Xc/*rnd*/ < -89.0f)
                /*rnd*/var_Delta/*rnd*/./*rnd*/var_Xc/*rnd*/ = -89.0f;
            /*order-*/
            /*order-*/
            while (/*rnd*/var_Delta/*rnd*/./*rnd*/var_Yc/*rnd*/ > 180.0f)
                /*rnd*/var_Delta/*rnd*/./*rnd*/var_Yc/*rnd*/ -= 360.0f;
            while (/*rnd*/var_Delta/*rnd*/./*rnd*/var_Yc/*rnd*/ < -180.0f)
                /*rnd*/var_Delta/*rnd*/./*rnd*/var_Yc/*rnd*/ += 360.0f;
            /*order-*/
            /*order-*//*rnd*/var_Delta/*rnd*/./*rnd*/var_Zc/*rnd*/ = 0;/*order-*/
            /*order-end*/
            return /*rnd*/var_Delta/*rnd*/;
        }
        /*order-*/
        /*junk_method*/
        /*order-end*/
    }

}
