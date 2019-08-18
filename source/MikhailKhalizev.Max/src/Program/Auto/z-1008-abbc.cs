using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_abbc-dffc5515")]
        public void Method_1008_abbc()
        {
            ii(0x1008_abbc, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1008_abc1, 5); calld(Definitions.sys_check_available_stack_size, 0xd_b18c); /* call 0x10165d52 */
            ii(0x1008_abc6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_abc7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_abc8, 1); pushd(edx);                             /* push edx */
            ii(0x1008_abc9, 1); pushd(esi);                             /* push esi */
            ii(0x1008_abca, 1); pushd(edi);                             /* push edi */
            ii(0x1008_abcb, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_abcc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_abce, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_abd4, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_abd7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_abda, 3); cmp(memd_a32[ds, eax], 0);              /* cmp dword [eax], 0x0 */
            ii(0x1008_abdd, 2); if(jzd(0x1008_abe8, 0x9)) goto l_0x1008_abe8; /* jz 0x1008abe8 */
            ii(0x1008_abdf, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1008_abe6, 2); jmpd(0x1008_ac01, 0x19); goto l_0x1008_ac01; /* jmp 0x1008ac01 */
        l_0x1008_abe8:
            ii(0x1008_abe8, 5); mov(ecx, 0xa7);                         /* mov ecx, 0xa7 */
            ii(0x1008_abed, 5); mov(ebx, StringDefinitions.SmartptrH11); /* mov ebx, 0x101a0094 */
            ii(0x1008_abf2, 5); mov(edx, StringDefinitions.PtrNotEqual011); /* mov edx, 0x101a009f */
            ii(0x1008_abf7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1008_abf9, 5); calld(Definitions.sys_assert, 0xd_b194); /* call 0x10165d92 */
            ii(0x1008_abfe, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x1008_ac01:
            ii(0x1008_ac01, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_ac04, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1008_ac06, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_ac09, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_ac0c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_ac0e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_ac0f, 1); popd(edi);                              /* pop edi */
            ii(0x1008_ac10, 1); popd(esi);                              /* pop esi */
            ii(0x1008_ac11, 1); popd(edx);                              /* pop edx */
            ii(0x1008_ac12, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_ac13, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_ac14, 1); retd(); return;                         /* ret */
        }
    }
}
