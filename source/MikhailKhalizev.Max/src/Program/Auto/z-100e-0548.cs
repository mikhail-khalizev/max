using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a6904387-3001-49b5-aedd-597a9c5b9563")]
        public void Method_100e_0548()
        {
            ii(0x100e_0548, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_054d, 5); calld(Definitions.sys_check_available_stack_size, 0x85800); /* call 0x10165d52 */
            ii(0x100e_0552, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_0553, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_0554, 1); pushd(esi);                             /* push esi */
            ii(0x100e_0555, 1); pushd(edi);                             /* push edi */
            ii(0x100e_0556, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_0557, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_0559, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_055f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_0562, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_0565, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100e_0568, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_056b, 5); calld(0x1007_6c98, -0x698d8);           /* call 0x10076c98 */
            ii(0x100e_0570, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_0573, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_0576, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_0578, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_0579, 1); popd(edi);                              /* pop edi */
            ii(0x100e_057a, 1); popd(esi);                              /* pop esi */
            ii(0x100e_057b, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_057c, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_057d, 1); retd(); return;                         /* ret */
        }
    }
}
