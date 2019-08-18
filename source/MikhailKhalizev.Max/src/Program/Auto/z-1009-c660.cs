using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9f667f96-eb20-4472-9f7b-655dc6c9f3ed")]
        public void Method_1009_c660()
        {
            ii(0x1009_c660, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_c665, 5); calld(Definitions.sys_check_available_stack_size, 0xc_96e8); /* call 0x10165d52 */
            ii(0x1009_c66a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_c66b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_c66c, 1); pushd(esi);                             /* push esi */
            ii(0x1009_c66d, 1); pushd(edi);                             /* push edi */
            ii(0x1009_c66e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_c66f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_c671, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_c677, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_c67a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_c67d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_c680, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_c683, 5); calld(0x1013_a66b, 0x9_dfe3);           /* call 0x1013a66b */
            ii(0x1009_c688, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x1009_c68b, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1009_c68e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_c690, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_c691, 1); popd(edi);                              /* pop edi */
            ii(0x1009_c692, 1); popd(esi);                              /* pop esi */
            ii(0x1009_c693, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_c694, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_c695, 1); retd(); return;                         /* ret */
        }
    }
}
