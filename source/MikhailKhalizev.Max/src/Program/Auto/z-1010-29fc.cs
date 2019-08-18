using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_29fc-9debaa38")]
        public void Method_1010_29fc()
        {
            ii(0x1010_29fc, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1010_2a01, 5); calld(Definitions.sys_check_available_stack_size, 0x6_334c); /* call 0x10165d52 */
            ii(0x1010_2a06, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_2a07, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_2a08, 1); pushd(esi);                             /* push esi */
            ii(0x1010_2a09, 1); pushd(edi);                             /* push edi */
            ii(0x1010_2a0a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_2a0b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_2a0d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1010_2a13, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_2a16, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1010_2a19, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_2a1c, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1010_2a1e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_2a21, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x1010_2a23, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_2a26, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_2a29, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_2a2c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_2a2e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_2a2f, 1); popd(edi);                              /* pop edi */
            ii(0x1010_2a30, 1); popd(esi);                              /* pop esi */
            ii(0x1010_2a31, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_2a32, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_2a33, 1); retd(); return;                         /* ret */
        }
    }
}
