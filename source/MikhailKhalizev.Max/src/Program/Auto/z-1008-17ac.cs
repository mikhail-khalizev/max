using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_17ac-836c9e59")]
        public void Method_1008_17ac()
        {
            ii(0x1008_17ac, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_17b1, 5); calld(Definitions.sys_check_available_stack_size, 0xe_459c); /* call 0x10165d52 */
            ii(0x1008_17b6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_17b7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_17b8, 1); pushd(edx);                             /* push edx */
            ii(0x1008_17b9, 1); pushd(esi);                             /* push esi */
            ii(0x1008_17ba, 1); pushd(edi);                             /* push edi */
            ii(0x1008_17bb, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_17bc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_17be, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_17c4, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_17c7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_17ca, 3); add(eax, 0x16);                         /* add eax, 0x16 */
            ii(0x1008_17cd, 5); calld(0x1013_a794, 0xb_8fc2);           /* call 0x1013a794 */
            ii(0x1008_17d2, 3); lea(edx, eax - 0x6);                    /* lea edx, [eax-0x6] */
            ii(0x1008_17d5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_17d8, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1008_17db, 5); calld(0x1013_a794, 0xb_8fb4);           /* call 0x1013a794 */
            ii(0x1008_17e0, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1008_17e2, 3); sub(eax, 0xa);                          /* sub eax, 0xa */
            ii(0x1008_17e5, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_17e8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_17eb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_17ed, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_17ee, 1); popd(edi);                              /* pop edi */
            ii(0x1008_17ef, 1); popd(esi);                              /* pop esi */
            ii(0x1008_17f0, 1); popd(edx);                              /* pop edx */
            ii(0x1008_17f1, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_17f2, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_17f3, 1); retd();                                 /* ret */
        }
    }
}
