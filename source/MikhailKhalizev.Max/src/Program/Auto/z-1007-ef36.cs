using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cec10e17-6926-485d-9feb-4d8718572d02")]
        public void Method_1007_ef36()
        {
            ii(0x1007_ef36, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1007_ef3b, 5); calld(Definitions.sys_check_available_stack_size, 0xe_6e12); /* call 0x10165d52 */
            ii(0x1007_ef40, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_ef41, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_ef42, 1); pushd(edx);                             /* push edx */
            ii(0x1007_ef43, 1); pushd(esi);                             /* push esi */
            ii(0x1007_ef44, 1); pushd(edi);                             /* push edi */
            ii(0x1007_ef45, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_ef46, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_ef48, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1007_ef4e, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_ef51, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_ef53, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_ef56, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1007_ef59, 5); calld(0x1013_ad71, 0xb_be13);           /* call 0x1013ad71 */
            ii(0x1007_ef5e, 2); test(al, al);                           /* test al, al */
            ii(0x1007_ef60, 2); if(jzd(0x1007_ef7e, 0x1c)) goto l_0x1007_ef7e; /* jz 0x1007ef7e */
            ii(0x1007_ef62, 5); calld(0x1008_ac50, 0xbce9);             /* call 0x1008ac50 */
            ii(0x1007_ef67, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1007_ef69, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1007_ef6b, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_ef6e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_ef71, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1007_ef74, 5); calld(0x1007_6574, -0x8a05);            /* call 0x10076574 */
            ii(0x1007_ef79, 5); calld(0x1015_2962, 0xd_39e4);           /* call 0x10152962 */
        l_0x1007_ef7e:
            ii(0x1007_ef7e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_ef80, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_ef83, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1007_ef86, 5); calld(0x1007_6630, -0x895b);            /* call 0x10076630 */
            ii(0x1007_ef8b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_ef8d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_ef90, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1007_ef93, 5); calld(0x1008_afe4, 0xc04c);             /* call 0x1008afe4 */
            ii(0x1007_ef98, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_ef9b, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1007_efa0, 5); calld(0x100a_5e27, 0x2_6e82);           /* call 0x100a5e27 */
            ii(0x1007_efa5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_efa7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_efa8, 1); popd(edi);                              /* pop edi */
            ii(0x1007_efa9, 1); popd(esi);                              /* pop esi */
            ii(0x1007_efaa, 1); popd(edx);                              /* pop edx */
            ii(0x1007_efab, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_efac, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_efad, 1); retd(); return;                         /* ret */
        }
    }
}
