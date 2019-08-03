using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d907f614-5517-4a14-b947-e5e68421a7dc")]
        public void Method_100a_ad94()
        {
            ii(0x100a_ad94, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100a_ad99, 5); calld(Definitions.sys_check_available_stack_size, 0xbafb4); /* call 0x10165d52 */
            ii(0x100a_ad9e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_ad9f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_ada0, 1); pushd(edx);                             /* push edx */
            ii(0x100a_ada1, 1); pushd(esi);                             /* push esi */
            ii(0x100a_ada2, 1); pushd(edi);                             /* push edi */
            ii(0x100a_ada3, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_ada4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_ada6, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_adac, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_adaf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_adb2, 3); cmp(memd_a32[ds, eax], 0);              /* cmp dword [eax], 0x0 */
            ii(0x100a_adb5, 2); if(jzd(0x100a_adc0, 0x9)) goto l_0x100a_adc0; /* jz 0x100aadc0 */
            ii(0x100a_adb7, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x100a_adbe, 2); jmpd(0x100a_add9, 0x19); goto l_0x100a_add9; /* jmp 0x100aadd9 */
        l_0x100a_adc0:
            ii(0x100a_adc0, 5); mov(ecx, 0xae);                         /* mov ecx, 0xae */
            ii(0x100a_adc5, 5); mov(ebx, 0x101a_0850);                  /* mov ebx, 0x101a0850 */ /* "smartptr.h" */
            ii(0x100a_adca, 5); mov(edx, 0x101a_085b);                  /* mov edx, 0x101a085b */ /* "ptr != 0" */
            ii(0x100a_adcf, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_add1, 5); calld(Definitions.sys_assert, 0xbafbc); /* call 0x10165d92 */
            ii(0x100a_add6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x100a_add9:
            ii(0x100a_add9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_addc, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100a_adde, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_ade1, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_ade4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_ade6, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_ade7, 1); popd(edi);                              /* pop edi */
            ii(0x100a_ade8, 1); popd(esi);                              /* pop esi */
            ii(0x100a_ade9, 1); popd(edx);                              /* pop edx */
            ii(0x100a_adea, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_adeb, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_adec, 1); retd(); return;                         /* ret */
        }
    }
}