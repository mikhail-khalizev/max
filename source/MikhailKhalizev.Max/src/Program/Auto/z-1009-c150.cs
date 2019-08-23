using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_c150-91b18cae")]
        public void Method_1009_c150()
        {
            ii(0x1009_c150, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_c155, 5); calld(Definitions.sys_check_available_stack_size, 0xc_9bf8); /* call 0x10165d52 */
            ii(0x1009_c15a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_c15b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_c15c, 1); pushd(esi);                             /* push esi */
            ii(0x1009_c15d, 1); pushd(edi);                             /* push edi */
            ii(0x1009_c15e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_c15f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_c161, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_c167, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_c16a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_c16d, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1009_c171, 3); imul(edx, eax, 0x6);                    /* imul edx, eax, 0x6 */
            ii(0x1009_c174, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_c177, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x1009_c17a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_c17c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_c17f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_c182, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_c184, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_c185, 1); popd(edi);                              /* pop edi */
            ii(0x1009_c186, 1); popd(esi);                              /* pop esi */
            ii(0x1009_c187, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_c188, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_c189, 1); retd();                                 /* ret */
        }
    }
}
