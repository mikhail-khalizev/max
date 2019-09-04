using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_3a46-d05014c4")]
        public void Method_100b_3a46()
        {
            ii(0x100b_3a46, 5); push(0x24);                             /* push 0x24 */
            ii(0x100b_3a4b, 5); call(Definitions.sys_check_available_stack_size, 0xb_2302); /* call 0x10165d52 */
            ii(0x100b_3a50, 1); push(ebx);                              /* push ebx */
            ii(0x100b_3a51, 1); push(ecx);                              /* push ecx */
            ii(0x100b_3a52, 1); push(esi);                              /* push esi */
            ii(0x100b_3a53, 1); push(edi);                              /* push edi */
            ii(0x100b_3a54, 1); push(ebp);                              /* push ebp */
            ii(0x100b_3a55, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_3a57, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_3a5d, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100b_3a60, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100b_3a63, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_3a65, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_3a68, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_3a6b, 5); call(0x1013_ad11, 0x8_72a1);            /* call 0x1013ad11 */
            ii(0x100b_3a70, 2); test(al, al);                           /* test al, al */
            ii(0x100b_3a72, 2); if(jz(0x100b_3a7c, 8)) goto l_0x100b_3a7c; /* jz 0x100b3a7c */
            ii(0x100b_3a74, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_3a77, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100b_3a7a, 2); jmp(0x100b_3ac3, 0x47); goto l_0x100b_3ac3; /* jmp 0x100b3ac3 */
        l_0x100b_3a7c:
            ii(0x100b_3a7c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_3a7f, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_3a82, 5); call(0x1007_6574, -0x3_d513);           /* call 0x10076574 */
            ii(0x100b_3a87, 5); call(0x1007_611c, -0x3_d970);           /* call 0x1007611c */
            ii(0x100b_3a8c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_3a8e, 2); if(jz(0x100b_3aaa, 0x1a)) goto l_0x100b_3aaa; /* jz 0x100b3aaa */
            ii(0x100b_3a90, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100b_3a93, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_3a96, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_3a99, 5); call(0x1007_6574, -0x3_d52a);           /* call 0x10076574 */
            ii(0x100b_3a9e, 5); call(0x1007_611c, -0x3_d987);           /* call 0x1007611c */
            ii(0x100b_3aa3, 5); call(0x1015_2532, 0x9_ea8a);            /* call 0x10152532 */
            ii(0x100b_3aa8, 2); jmp(0x100b_3abd, 0x13); goto l_0x100b_3abd; /* jmp 0x100b3abd */
        l_0x100b_3aaa:
            ii(0x100b_3aaa, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100b_3aad, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_3ab0, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_3ab3, 5); call(0x1007_6574, -0x3_d544);           /* call 0x10076574 */
            ii(0x100b_3ab8, 5); call(0x1015_2532, 0x9_ea75);            /* call 0x10152532 */
        l_0x100b_3abd:
            ii(0x100b_3abd, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_3ac0, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
        l_0x100b_3ac3:
            ii(0x100b_3ac3, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100b_3ac6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_3ac8, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_3ac9, 1); pop(edi);                               /* pop edi */
            ii(0x100b_3aca, 1); pop(esi);                               /* pop esi */
            ii(0x100b_3acb, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_3acc, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_3acd, 1); ret();                                  /* ret */
        }
    }
}
