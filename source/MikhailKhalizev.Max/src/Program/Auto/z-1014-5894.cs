using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f288669d-0fbd-4944-a134-597be1706b91")]
        public void Method_1014_5894()
        {
            ii(0x1014_5894, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1014_5899, 5); calld(Definitions.sys_check_available_stack_size, 0x2_04b4); /* call 0x10165d52 */
            ii(0x1014_589e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_589f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_58a0, 1); pushd(esi);                             /* push esi */
            ii(0x1014_58a1, 1); pushd(edi);                             /* push edi */
            ii(0x1014_58a2, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_58a3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_58a5, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1014_58ab, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_58ae, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_58b1, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1014_58b5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_58b8, 5); calld(0x1014_56a5, -0x218);             /* call 0x101456a5 */
            ii(0x1014_58bd, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_58c0, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1014_58c3, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_58c6, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1014_58ca, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_58cd, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1014_58d0, 5); calld(0x1014_579c, -0x139);             /* call 0x1014579c */
            ii(0x1014_58d5, 3); sub(eax, 0xe);                          /* sub eax, 0xe */
            ii(0x1014_58d8, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_58db, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1014_58de, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_58e1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_58e4, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1014_58e7, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1014_58ea, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_58ec, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_58ed, 1); popd(edi);                              /* pop edi */
            ii(0x1014_58ee, 1); popd(esi);                              /* pop esi */
            ii(0x1014_58ef, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_58f0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_58f1, 1); retd(); return;                         /* ret */
        }
    }
}
