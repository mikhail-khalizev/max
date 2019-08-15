using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c06a389f-ba23-4132-901d-f5525694e800")]
        public void Method_1014_585e()
        {
            ii(0x1014_585e, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_5863, 5); calld(Definitions.sys_check_available_stack_size, 0x2_04ea); /* call 0x10165d52 */
            ii(0x1014_5868, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_5869, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_586a, 1); pushd(esi);                             /* push esi */
            ii(0x1014_586b, 1); pushd(edi);                             /* push edi */
            ii(0x1014_586c, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_586d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_586f, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_5875, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_5878, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_587b, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_587e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_5881, 5); calld(0x1013_b518, -0xa36e);            /* call 0x1013b518 */
            ii(0x1014_5886, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_5889, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_588c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_588e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_588f, 1); popd(edi);                              /* pop edi */
            ii(0x1014_5890, 1); popd(esi);                              /* pop esi */
            ii(0x1014_5891, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_5892, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_5893, 1); retd(); return;                         /* ret */
        }
    }
}
