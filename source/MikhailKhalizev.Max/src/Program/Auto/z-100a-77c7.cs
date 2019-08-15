using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f46c9c99-fbde-418c-aa49-e8a70a216061")]
        public void Method_100a_77c7()
        {
            ii(0x100a_77c7, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_77cc, 5); calld(Definitions.sys_check_available_stack_size, 0xb_e581); /* call 0x10165d52 */
            ii(0x100a_77d1, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_77d2, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_77d3, 1); pushd(edx);                             /* push edx */
            ii(0x100a_77d4, 1); pushd(esi);                             /* push esi */
            ii(0x100a_77d5, 1); pushd(edi);                             /* push edi */
            ii(0x100a_77d6, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_77d7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_77d9, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_77df, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_77e2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_77e5, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x100a_77e8, 5); calld(Definitions.my_1_get_count, 0x3ceb); /* call 0x100ab4d8 */
            ii(0x100a_77ed, 1); cwde();                                 /* cwde */
            ii(0x100a_77ee, 3); imul(edx, eax, 0x23);                   /* imul edx, eax, 0x23 */
            ii(0x100a_77f1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_77f4, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100a_77f7, 5); calld(Definitions.my_3_get_count, -0x1_c37c); /* call 0x1008b480 */
            ii(0x100a_77fc, 1); cwde();                                 /* cwde */
            ii(0x100a_77fd, 3); shl(eax, 0x3);                          /* shl eax, 0x3 */
            ii(0x100a_7800, 3); add(edx, 0x4);                          /* add edx, 0x4 */
            ii(0x100a_7803, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100a_7805, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_7808, 3); add(eax, 0x2e);                         /* add eax, 0x2e */
            ii(0x100a_780b, 5); calld(Definitions.my_3_get_count, -0x1_c390); /* call 0x1008b480 */
            ii(0x100a_7810, 1); cwde();                                 /* cwde */
            ii(0x100a_7811, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100a_7814, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100a_7816, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_7819, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x100a_781c, 5); calld(Definitions.my_3_get_count, -0x1_c3a1); /* call 0x1008b480 */
            ii(0x100a_7821, 1); cwde();                                 /* cwde */
            ii(0x100a_7822, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100a_7825, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100a_7827, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100a_782a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_782d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_782f, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_7830, 1); popd(edi);                              /* pop edi */
            ii(0x100a_7831, 1); popd(esi);                              /* pop esi */
            ii(0x100a_7832, 1); popd(edx);                              /* pop edx */
            ii(0x100a_7833, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_7834, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_7835, 1); retd(); return;                         /* ret */
        }
    }
}
