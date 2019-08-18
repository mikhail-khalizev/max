using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9b7cf5fe-38f7-4833-ace5-b8cca626508b")]
        public void Method_100b_375b()
        {
            ii(0x100b_375b, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100b_3760, 5); calld(Definitions.sys_check_available_stack_size, 0xb_25ed); /* call 0x10165d52 */
            ii(0x100b_3765, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_3766, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_3767, 1); pushd(edx);                             /* push edx */
            ii(0x100b_3768, 1); pushd(esi);                             /* push esi */
            ii(0x100b_3769, 1); pushd(edi);                             /* push edi */
            ii(0x100b_376a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_376b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_376d, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100b_3773, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_3776, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_3778, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_377b, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_377e, 5); calld(0x1013_ad71, 0x8_75ee);           /* call 0x1013ad71 */
            ii(0x100b_3783, 2); test(al, al);                           /* test al, al */
            ii(0x100b_3785, 2); if(jzd(0x100b_37c3, 0x3c)) goto l_0x100b_37c3; /* jz 0x100b37c3 */
            ii(0x100b_3787, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_3789, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_378c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_378f, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_3792, 5); calld(0x1007_6574, -0x3_d223);          /* call 0x10076574 */
            ii(0x100b_3797, 5); calld(0x1015_2962, 0x9_f1c6);           /* call 0x10152962 */
            ii(0x100b_379c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_379e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_37a1, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_37a4, 5); calld(0x1007_6630, -0x3_d179);          /* call 0x10076630 */
            ii(0x100b_37a9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_37ab, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_37ae, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100b_37b1, 5); calld(0x1008_afe4, -0x2_87d2);          /* call 0x1008afe4 */
            ii(0x100b_37b6, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_37b9, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_37be, 5); calld(0x100a_5e27, -0xd99c);            /* call 0x100a5e27 */
        l_0x100b_37c3:
            ii(0x100b_37c3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_37c5, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_37c6, 1); popd(edi);                              /* pop edi */
            ii(0x100b_37c7, 1); popd(esi);                              /* pop esi */
            ii(0x100b_37c8, 1); popd(edx);                              /* pop edx */
            ii(0x100b_37c9, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_37ca, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_37cb, 1); retd(); return;                         /* ret */
        }
    }
}
