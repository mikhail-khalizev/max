using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_f471-5953efdb")]
        public void Method_1009_f471()
        {
            ii(0x1009_f471, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1009_f476, 5); calld(Definitions.sys_check_available_stack_size, 0xc_68d7); /* call 0x10165d52 */
            ii(0x1009_f47b, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_f47c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_f47d, 1); pushd(edx);                             /* push edx */
            ii(0x1009_f47e, 1); pushd(esi);                             /* push esi */
            ii(0x1009_f47f, 1); pushd(edi);                             /* push edi */
            ii(0x1009_f480, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_f481, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_f483, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1009_f489, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_f48c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_f48e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_f491, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_f494, 5); calld(0x1013_ad71, 0x9_b8d8);           /* call 0x1013ad71 */
            ii(0x1009_f499, 2); test(al, al);                           /* test al, al */
            ii(0x1009_f49b, 2); if(jzd(0x1009_f4ad, 0x10)) goto l_0x1009_f4ad; /* jz 0x1009f4ad */
            ii(0x1009_f49d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_f4a0, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_f4a3, 5); calld(0x1007_6574, -0x2_8f34);          /* call 0x10076574 */
            ii(0x1009_f4a8, 5); calld(0x1015_287d, 0xb_33d0);           /* call 0x1015287d */
        l_0x1009_f4ad:
            ii(0x1009_f4ad, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_f4af, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_f4b2, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_f4b5, 5); calld(0x1007_6630, -0x2_8e8a);          /* call 0x10076630 */
            ii(0x1009_f4ba, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_f4bc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_f4bf, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1009_f4c2, 5); calld(0x1008_afe4, -0x1_44e3);          /* call 0x1008afe4 */
            ii(0x1009_f4c7, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_f4ca, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_f4cf, 5); calld(0x100a_5e27, 0x6953);             /* call 0x100a5e27 */
            ii(0x1009_f4d4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_f4d6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_f4d7, 1); popd(edi);                              /* pop edi */
            ii(0x1009_f4d8, 1); popd(esi);                              /* pop esi */
            ii(0x1009_f4d9, 1); popd(edx);                              /* pop edx */
            ii(0x1009_f4da, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_f4db, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_f4dc, 1); retd();                                 /* ret */
        }
    }
}
