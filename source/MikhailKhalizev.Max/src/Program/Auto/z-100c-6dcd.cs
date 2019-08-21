using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_6dcd-430b4a4f")]
        public void Method_100c_6dcd()
        {
            ii(0x100c_6dcd, 5); mov(ebx, 0x7);                          /* mov ebx, 0x7 */
            ii(0x100c_6dd2, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x100c_6dd7, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_6dda, 5); calld(0x100c_64f5, -0x8ea);             /* call 0x100c64f5 */
            ii(0x100c_6ddf, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100c_6de4, 5); mov(edx, 0x34);                         /* mov edx, 0x34 */
            ii(0x100c_6de9, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_6dec, 5); calld(0x100c_64f5, -0x8fc);             /* call 0x100c64f5 */
            ii(0x100c_6df1, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x100c_6df6, 5); mov(edx, 0x34);                         /* mov edx, 0x34 */
            ii(0x100c_6dfb, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_6dfe, 5); calld(0x100c_64f5, -0x90e);             /* call 0x100c64f5 */
            ii(0x100c_6e03, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x100c_6e08, 5); mov(edx, 0x34);                         /* mov edx, 0x34 */
            ii(0x100c_6e0d, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_6e10, 5); calld(0x100c_64f5, -0x920);             /* call 0x100c64f5 */
            ii(0x100c_6e15, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100c_6e19, 6); if(jnzd(0x100c_6f63, 0x144)) goto l_0x100c_6f63; /* jnz 0x100c6f63 */
            ii(0x100c_6e1f, 5); mov(ebx, 0x8);                          /* mov ebx, 0x8 */
            ii(0x100c_6e24, 5); mov(edx, 0x34);                         /* mov edx, 0x34 */
            ii(0x100c_6e29, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_6e2c, 5); calld(0x100c_64f5, -0x93c);             /* call 0x100c64f5 */
            ii(0x100c_6e31, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100c_6e36, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x100c_6e3b, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_6e3e, 5); calld(0x100c_64f5, -0x94e);             /* call 0x100c64f5 */
            ii(0x100c_6e43, 5); mov(ebx, 0x8);                          /* mov ebx, 0x8 */
            ii(0x100c_6e48, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x100c_6e4d, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_6e50, 5); calld(0x100c_64f5, -0x960);             /* call 0x100c64f5 */
            ii(0x100c_6e55, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100c_6e5a, 5); mov(edx, 0x37);                         /* mov edx, 0x37 */
            ii(0x100c_6e5f, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_6e62, 5); calld(0x100c_64f5, -0x972);             /* call 0x100c64f5 */
            ii(0x100c_6e67, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x100c_6e6c, 5); mov(edx, 0x37);                         /* mov edx, 0x37 */
            ii(0x100c_6e71, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_6e74, 5); calld(0x100c_64f5, -0x984);             /* call 0x100c64f5 */
            ii(0x100c_6e79, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x100c_6e7e, 5); mov(edx, 0x37);                         /* mov edx, 0x37 */
            ii(0x100c_6e83, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_6e86, 5); calld(0x100c_64f5, -0x996);             /* call 0x100c64f5 */
            ii(0x100c_6e8b, 5); mov(ebx, 0x8);                          /* mov ebx, 0x8 */
            ii(0x100c_6e90, 5); mov(edx, 0x37);                         /* mov edx, 0x37 */
            ii(0x100c_6e95, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_6e98, 5); calld(0x100c_64f5, -0x9a8);             /* call 0x100c64f5 */
            ii(0x100c_6e9d, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100c_6ea2, 5); mov(edx, 0x4d);                         /* mov edx, 0x4d */
            ii(0x100c_6ea7, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_6eaa, 5); calld(0x100c_64f5, -0x9ba);             /* call 0x100c64f5 */
            ii(0x100c_6eaf, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100c_6eb4, 5); mov(edx, 0x44);                         /* mov edx, 0x44 */
            ii(0x100c_6eb9, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_6ebc, 5); calld(0x100c_64f5, -0x9cc);             /* call 0x100c64f5 */
            ii(0x100c_6ec1, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x100c_6ec6, 5); mov(edx, 0x44);                         /* mov edx, 0x44 */
            ii(0x100c_6ecb, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_6ece, 5); calld(0x100c_64f5, -0x9de);             /* call 0x100c64f5 */
            ii(0x100c_6ed3, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x100c_6ed8, 5); mov(edx, 0x44);                         /* mov edx, 0x44 */
            ii(0x100c_6edd, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_6ee0, 5); calld(0x100c_64f5, -0x9f0);             /* call 0x100c64f5 */
            ii(0x100c_6ee5, 5); mov(ebx, 0x8);                          /* mov ebx, 0x8 */
            ii(0x100c_6eea, 5); mov(edx, 0x44);                         /* mov edx, 0x44 */
            ii(0x100c_6eef, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_6ef2, 5); calld(0x100c_64f5, -0xa02);             /* call 0x100c64f5 */
            ii(0x100c_6ef7, 5); mov(ebx, 0x7);                          /* mov ebx, 0x7 */
            ii(0x100c_6efc, 5); mov(edx, 0x44);                         /* mov edx, 0x44 */
            ii(0x100c_6f01, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_6f04, 5); calld(0x100c_64f5, -0xa14);             /* call 0x100c64f5 */
            ii(0x100c_6f09, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x100c_6f0e, 5); mov(edx, 0x45);                         /* mov edx, 0x45 */
            ii(0x100c_6f13, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_6f16, 5); calld(0x100c_64f5, -0xa26);             /* call 0x100c64f5 */
            ii(0x100c_6f1b, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x100c_6f20, 5); mov(edx, 0x45);                         /* mov edx, 0x45 */
            ii(0x100c_6f25, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_6f28, 5); calld(0x100c_64f5, -0xa38);             /* call 0x100c64f5 */
            ii(0x100c_6f2d, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100c_6f32, 5); mov(edx, 0x45);                         /* mov edx, 0x45 */
            ii(0x100c_6f37, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_6f3a, 5); calld(0x100c_64f5, -0xa4a);             /* call 0x100c64f5 */
            ii(0x100c_6f3f, 5); mov(ebx, 0x8);                          /* mov ebx, 0x8 */
            ii(0x100c_6f44, 5); mov(edx, 0x45);                         /* mov edx, 0x45 */
            ii(0x100c_6f49, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_6f4c, 5); calld(0x100c_64f5, -0xa5c);             /* call 0x100c64f5 */
            ii(0x100c_6f51, 5); mov(ebx, 0x7);                          /* mov ebx, 0x7 */
            ii(0x100c_6f56, 5); mov(edx, 0x45);                         /* mov edx, 0x45 */
            ii(0x100c_6f5b, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_6f5e, 5); calld(0x100c_64f5, -0xa6e);             /* call 0x100c64f5 */
        l_0x100c_6f63:
            ii(0x100c_6f63, 5); if(jmpd_func(0x100c_7115, 0x1ad)) return; /* jmp 0x100c7115 */
        }
    }
}
