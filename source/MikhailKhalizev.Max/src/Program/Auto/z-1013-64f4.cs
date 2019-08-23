using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_64f4-12ffe004")]
        public void Method_1013_64f4()
        {
            ii(0x1013_64f4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_64f9, 5); calld(Definitions.sys_check_available_stack_size, 0x2_f854); /* call 0x10165d52 */
            ii(0x1013_64fe, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_64ff, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_6500, 1); pushd(esi);                             /* push esi */
            ii(0x1013_6501, 1); pushd(edi);                             /* push edi */
            ii(0x1013_6502, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_6503, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_6505, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_650b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_650e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_6511, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_6513, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_6516, 5); add(eax, 0x2f0);                        /* add eax, 0x2f0 */
            ii(0x1013_651b, 5); calld(0x100e_0198, -0x5_6388);          /* call 0x100e0198 */
            ii(0x1013_6520, 5); sub(eax, 0x2f0);                        /* sub eax, 0x2f0 */
            ii(0x1013_6525, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_6528, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_652a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_652d, 5); add(eax, 0x17c);                        /* add eax, 0x17c */
            ii(0x1013_6532, 5); calld(0x100e_0118, -0x5_641f);          /* call 0x100e0118 */
            ii(0x1013_6537, 5); sub(eax, 0x17c);                        /* sub eax, 0x17c */
            ii(0x1013_653c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_653f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_6541, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_6544, 3); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x1013_6547, 5); calld(0x100e_0118, -0x5_6434);          /* call 0x100e0118 */
            ii(0x1013_654c, 3); sub(eax, 0x8);                          /* sub eax, 0x8 */
            ii(0x1013_654f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_6552, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_6555, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_6558, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_655b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_655d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_655e, 1); popd(edi);                              /* pop edi */
            ii(0x1013_655f, 1); popd(esi);                              /* pop esi */
            ii(0x1013_6560, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_6561, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_6562, 1); retd();                                 /* ret */
        }
    }
}
