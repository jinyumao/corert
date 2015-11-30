// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Runtime.CompilerServices;

namespace System.Runtime
{
    internal static class BinderIntrinsics
    {
        // NOTE: We rely on the RID of DebugBreak, so it must be kept as the first method declared in this class.
        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        public static void DebugBreak()
        {
            // Ignore body of method, it will be generated by the binder.
        }

        // NOTE: We rely on the RID of GetReturnAddress, so it must be kept as the second method declared in this class.
        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        internal static IntPtr GetReturnAddress()
        {
            // Ignore body of method, it will be generated by the binder.
            return IntPtr.Zero;
        }

        // NOTE: We rely on the RID of TailCall_RhpThrowEx, so it must be kept as the third method declared in this class.
        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        internal static void TailCall_RhpThrowEx(Exception e)
        {
            // Ignore body of method, it will be generated by the binder.
        }
    }
}
