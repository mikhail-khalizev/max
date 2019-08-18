using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b8eb0145-65ce-470d-80cd-a45ad8a84273")]
        public void Method_1013_b8e1()
        {
            ii(0x1013_b8e1, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1013_b8e6, 5); calld(Definitions.sys_check_available_stack_size, 0x2_a467); /* call 0x10165d52 */
            ii(0x1013_b8eb, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_b8ec, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_b8ed, 1); pushd(edx);                             /* push edx */
            ii(0x1013_b8ee, 1); pushd(esi);                             /* push esi */
            ii(0x1013_b8ef, 1); pushd(edi);                             /* push edi */
            ii(0x1013_b8f0, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_b8f1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_b8f3, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_b8f9, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_b8fc, 5); calld(0x1013_c6d0, 0xdcf);              /* call 0x1013c6d0 */
            ii(0x1013_b901, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1013_b904, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_b907, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1013_b90a, 5); calld(0x1013_c668, 0xd59);              /* call 0x1013c668 */
            ii(0x1013_b90f, 3); sub(eax, 0x4);                          /* sub eax, 0x4 */
            ii(0x1013_b912, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_b915, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1013_b918, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_b91b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_b91e, 6); mov(memd_a32[ds, eax], 0);              /* mov dword [eax], 0x0 */
            ii(0x1013_b924, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_b927, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_b92a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_b92d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_b92f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_b930, 1); popd(edi);                              /* pop edi */
            ii(0x1013_b931, 1); popd(esi);                              /* pop esi */
            ii(0x1013_b932, 1); popd(edx);                              /* pop edx */
            ii(0x1013_b933, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_b934, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_b935, 1); retd(); return;                         /* ret */
        }
    }
}
