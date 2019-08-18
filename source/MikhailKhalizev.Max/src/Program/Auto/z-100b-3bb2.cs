using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("06478620-4f48-4f93-92c7-d1d67d5a6687")]
        public void Method_100b_3bb2()
        {
            ii(0x100b_3bb2, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_3bb7, 5); calld(Definitions.sys_check_available_stack_size, 0xb_2196); /* call 0x10165d52 */
            ii(0x100b_3bbc, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_3bbd, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_3bbe, 1); pushd(edx);                             /* push edx */
            ii(0x100b_3bbf, 1); pushd(esi);                             /* push esi */
            ii(0x100b_3bc0, 1); pushd(edi);                             /* push edi */
            ii(0x100b_3bc1, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_3bc2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_3bc4, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_3bca, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_3bcd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_3bcf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_3bd2, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_3bd5, 5); calld(0x1013_ad71, 0x8_7197);           /* call 0x1013ad71 */
            ii(0x100b_3bda, 2); test(al, al);                           /* test al, al */
            ii(0x100b_3bdc, 2); if(jzd(0x100b_3bfd, 0x1f)) goto l_0x100b_3bfd; /* jz 0x100b3bfd */
            ii(0x100b_3bde, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_3be1, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_3be4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_3be7, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x100b_3bea, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_3bed, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_3bf0, 5); calld(0x1007_65d0, -0x3_d625);          /* call 0x100765d0 */
            ii(0x100b_3bf5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_3bf7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_3bfa, 3); calld_abs(memd_a32[ds, ebx + 0x44]);    /* call dword [ebx+0x44] */
        l_0x100b_3bfd:
            ii(0x100b_3bfd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_3bff, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_3c00, 1); popd(edi);                              /* pop edi */
            ii(0x100b_3c01, 1); popd(esi);                              /* pop esi */
            ii(0x100b_3c02, 1); popd(edx);                              /* pop edx */
            ii(0x100b_3c03, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_3c04, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_3c05, 1); retd(); return;                         /* ret */
        }
    }
}
