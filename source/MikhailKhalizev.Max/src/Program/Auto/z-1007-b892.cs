using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_b892-cefb1570")]
        public void Method_1007_b892()
        {
            ii(0x1007_b892, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1007_b897, 5); calld(Definitions.sys_check_available_stack_size, 0xe_a4b6); /* call 0x10165d52 */
            ii(0x1007_b89c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_b89d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_b89e, 1); pushd(esi);                             /* push esi */
            ii(0x1007_b89f, 1); pushd(edi);                             /* push edi */
            ii(0x1007_b8a0, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_b8a1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_b8a3, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_b8a9, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_b8ac, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_b8af, 5); calld(0x1008_a4dc, 0xec28);             /* call 0x1008a4dc */
            ii(0x1007_b8b4, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1007_b8b6, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1007_b8b8, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1007_b8bb, 3); add(edx, 0x2d);                         /* add edx, 0x2d */
            ii(0x1007_b8be, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_b8c1, 5); calld(0x100b_8505, 0x3_cc3f);           /* call 0x100b8505 */
            ii(0x1007_b8c6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_b8c9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_b8cb, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_b8cc, 1); popd(edi);                              /* pop edi */
            ii(0x1007_b8cd, 1); popd(esi);                              /* pop esi */
            ii(0x1007_b8ce, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_b8cf, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_b8d0, 1); retd();                                 /* ret */
        }
    }
}
