using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5a7a7b63-1c6d-448f-bf4f-11a671b0a41b")]
        public void /* sys */ Method_1019_b165()
        {
            ii(0x1019_b165, 5); mov(eax, 0x101b_3744);                  /* mov eax, 0x101b3744 */ /* "TZ" */
            ii(0x1019_b16a, 5); calld(/* sys */ 0x1019_54bf, -0x5cb0);  /* call 0x101954bf */
            ii(0x1019_b16f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1019_b171, 2); jzd_func(0x1019_b14d, -0x26);           /* jz 0x1019b14d */
            ii(0x1019_b173, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_b174, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_b175, 1); pushd(edx);                             /* push edx */
            ii(0x1019_b176, 1); pushd(esi);                             /* push esi */
            ii(0x1019_b177, 1); pushd(edi);                             /* push edi */
            ii(0x1019_b178, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_b179, 3); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1019_b17c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1019_b17e, 5); mov(ebx, 0x101c_1ca0);                  /* mov ebx, 0x101c1ca0 */
            ii(0x1019_b183, 6); mov(memd_a32[ds, 0x101c_1ca8], edx);    /* mov [0x101c1ca8], edx */
            ii(0x1019_b189, 5); mov(edx, 0x101c_1cac);                  /* mov edx, 0x101c1cac */
            ii(0x1019_b18e, 5); calld(/* sys */ 0x1019_b1ce, 0x3b);     /* call 0x1019b1ce */
            ii(0x1019_b193, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_b195, 2); mov(ah, memb_a32[ds, eax]);             /* mov ah, [eax] */
            ii(0x1019_b197, 2); test(ah, ah);                           /* test ah, ah */
            ii(0x1019_b199, 6); jnzd_func(0x1019_b3fb, 0x25c);          /* jnz 0x1019b3fb */
            ii(0x1019_b19f, 6); mov(memb_a32[ds, 0x101c_1ccb], ah);     /* mov [0x101c1ccb], ah */
            ii(0x1019_b1a5, 5); jmpd_func(0x1019_b4bf, 0x315); return;  /* jmp 0x1019b4bf */
        }
    }
}
