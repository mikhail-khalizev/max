using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_3e9c-c8857e02")]
        public void Method_100a_3e9c()
        {
            ii(0x100a_3e9c, 5); push(0x38);                             /* push 0x38 */
            ii(0x100a_3ea1, 5); call(Definitions.sys_check_available_stack_size, 0xc_1eac); /* call 0x10165d52 */
            ii(0x100a_3ea6, 1); push(ebx);                              /* push ebx */
            ii(0x100a_3ea7, 1); push(ecx);                              /* push ecx */
            ii(0x100a_3ea8, 1); push(edx);                              /* push edx */
            ii(0x100a_3ea9, 1); push(esi);                              /* push esi */
            ii(0x100a_3eaa, 1); push(edi);                              /* push edi */
            ii(0x100a_3eab, 1); push(ebp);                              /* push ebp */
            ii(0x100a_3eac, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_3eae, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100a_3eb4, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_3eb7, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_3eba, 5); call(0x1009_ca70, -0x744f);             /* call 0x1009ca70 */
            ii(0x100a_3ebf, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_3ec2, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100a_3ec5, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100a_3ec8, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_3ecb, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x100a_3ece, 5); call(0x100a_b0e0, 0x720d);              /* call 0x100ab0e0 */
            ii(0x100a_3ed3, 3); sub(eax, 0xa);                          /* sub eax, 0xa */
            ii(0x100a_3ed6, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_3ed9, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100a_3edc, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100a_3edf, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_3ee2, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x100a_3ee5, 5); call(0x100a_ad54, 0x6e6a);              /* call 0x100aad54 */
            ii(0x100a_3eea, 3); sub(eax, 0x14);                         /* sub eax, 0x14 */
            ii(0x100a_3eed, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_3ef0, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100a_3ef3, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_3ef6, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_3ef9, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100a_3efc, 5); call(0x100a_ad54, 0x6e53);              /* call 0x100aad54 */
            ii(0x100a_3f01, 3); sub(eax, 0x1e);                         /* sub eax, 0x1e */
            ii(0x100a_3f04, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_3f07, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100a_3f0a, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_3f0d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_3f10, 3); add(eax, 0x28);                         /* add eax, 0x28 */
            ii(0x100a_3f13, 5); call(Definitions.my_ctor_0x101b_56fc, -0x1_b29c); /* call 0x10088c7c */
            ii(0x100a_3f18, 3); sub(eax, 0x28);                         /* sub eax, 0x28 */
            ii(0x100a_3f1b, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_3f1e, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100a_3f21, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_3f24, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_3f27, 6); mov(memw[ds, eax + 0x32], 0);           /* mov word [eax+0x32], 0x0 */
            ii(0x100a_3f2d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_3f30, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100a_3f33, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100a_3f36, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_3f38, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_3f39, 1); pop(edi);                               /* pop edi */
            ii(0x100a_3f3a, 1); pop(esi);                               /* pop esi */
            ii(0x100a_3f3b, 1); pop(edx);                               /* pop edx */
            ii(0x100a_3f3c, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_3f3d, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_3f3e, 1); ret();                                  /* ret */
        }
    }
}
