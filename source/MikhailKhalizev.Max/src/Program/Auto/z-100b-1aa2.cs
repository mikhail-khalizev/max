using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_1aa2-8ea6a706")]
        public void Method_100b_1aa2()
        {
            ii(0x100b_1aa2, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_1aa7, 5); calld(Definitions.sys_check_available_stack_size, 0xb_42a6); /* call 0x10165d52 */
            ii(0x100b_1aac, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_1aad, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_1aae, 1); pushd(edx);                             /* push edx */
            ii(0x100b_1aaf, 1); pushd(esi);                             /* push esi */
            ii(0x100b_1ab0, 1); pushd(edi);                             /* push edi */
            ii(0x100b_1ab1, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_1ab2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_1ab4, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_1aba, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_1abd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_1abf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_1ac2, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_1ac5, 5); calld(0x1013_ad71, 0x8_92a7);           /* call 0x1013ad71 */
            ii(0x100b_1aca, 2); test(al, al);                           /* test al, al */
            ii(0x100b_1acc, 2); if(jzd(0x100b_1ae5, 0x17)) goto l_0x100b_1ae5; /* jz 0x100b1ae5 */
            ii(0x100b_1ace, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_1ad1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_1ad4, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_1ad7, 5); calld(0x1007_6574, -0x3_b568);          /* call 0x10076574 */
            ii(0x100b_1adc, 5); calld(0x1015_2a52, 0xa_0f71);           /* call 0x10152a52 */
            ii(0x100b_1ae1, 2); test(al, al);                           /* test al, al */
            ii(0x100b_1ae3, 2); if(jnzd(0x100b_1ae7, 0x2)) goto l_0x100b_1ae7; /* jnz 0x100b1ae7 */
        l_0x100b_1ae5:
            ii(0x100b_1ae5, 2); jmpd(0x100b_1b06, 0x1f); goto l_0x100b_1b06; /* jmp 0x100b1b06 */
        l_0x100b_1ae7:
            ii(0x100b_1ae7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_1aea, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_1aed, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_1af0, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x100b_1af3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_1af6, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_1af9, 5); calld(0x1007_65d0, -0x3_b52e);          /* call 0x100765d0 */
            ii(0x100b_1afe, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_1b00, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_1b03, 3); calld_abs(memd_a32[ds, ebx + 0x44]);    /* call dword [ebx+0x44] */
        l_0x100b_1b06:
            ii(0x100b_1b06, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_1b08, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_1b09, 1); popd(edi);                              /* pop edi */
            ii(0x100b_1b0a, 1); popd(esi);                              /* pop esi */
            ii(0x100b_1b0b, 1); popd(edx);                              /* pop edx */
            ii(0x100b_1b0c, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_1b0d, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_1b0e, 1); retd();                                 /* ret */
        }
    }
}
