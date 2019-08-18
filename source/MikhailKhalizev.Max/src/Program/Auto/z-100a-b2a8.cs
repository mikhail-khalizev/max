using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("03733b0a-6030-492d-a650-edecd72c20cf")]
        public void Method_100a_b2a8()
        {
            ii(0x100a_b2a8, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_b2ad, 5); calld(Definitions.sys_check_available_stack_size, 0xb_aaa0); /* call 0x10165d52 */
            ii(0x100a_b2b2, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_b2b3, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_b2b4, 1); pushd(esi);                             /* push esi */
            ii(0x100a_b2b5, 1); pushd(edi);                             /* push edi */
            ii(0x100a_b2b6, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_b2b7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_b2b9, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_b2bf, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_b2c2, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_b2c5, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_b2c8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_b2cb, 5); calld(0x1013_ac7d, 0x8_f9ad);           /* call 0x1013ac7d */
            ii(0x100a_b2d0, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_b2d3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_b2d6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_b2d8, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_b2d9, 1); popd(edi);                              /* pop edi */
            ii(0x100a_b2da, 1); popd(esi);                              /* pop esi */
            ii(0x100a_b2db, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_b2dc, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_b2dd, 1); retd(); return;                         /* ret */
        }
    }
}
