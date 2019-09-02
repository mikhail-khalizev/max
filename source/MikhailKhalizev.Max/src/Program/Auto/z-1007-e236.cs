using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_e236-5c48a989")]
        public void Method_1007_e236()
        {
            ii(0x1007_e236, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1007_e23b, 5); call(Definitions.sys_check_available_stack_size, 0xe_7b12); /* call 0x10165d52 */
            ii(0x1007_e240, 1); push(ebx);                              /* push ebx */
            ii(0x1007_e241, 1); push(ecx);                              /* push ecx */
            ii(0x1007_e242, 1); push(edx);                              /* push edx */
            ii(0x1007_e243, 1); push(esi);                              /* push esi */
            ii(0x1007_e244, 1); push(edi);                              /* push edi */
            ii(0x1007_e245, 1); push(ebp);                              /* push ebp */
            ii(0x1007_e246, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_e248, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1007_e24e, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1007_e251, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_e254, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1007_e257, 5); call(0x1013_a794, 0xb_c538);            /* call 0x1013a794 */
            ii(0x1007_e25c, 3); sub(eax, 6);                            /* sub eax, 0x6 */
            ii(0x1007_e25f, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1007_e262, 7); mov(memd[ss, ebp - 8], 0);              /* mov dword [ebp-0x8], 0x0 */
            ii(0x1007_e269, 2); jmp(0x1007_e271, 6); goto l_0x1007_e271; /* jmp 0x1007e271 */
        l_0x1007_e26b:
            ii(0x1007_e26b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_e26e, 3); inc(memd[ss, ebp - 8]);                 /* inc dword [ebp-0x8] */
        l_0x1007_e271:
            ii(0x1007_e271, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1007_e275, 3); cmp(eax, 8);                            /* cmp eax, 0x8 */
            ii(0x1007_e278, 2); if(jge(0x1007_e296, 0x1c)) goto l_0x1007_e296; /* jge 0x1007e296 */
            ii(0x1007_e27a, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1007_e27e, 3); imul(edx, eax, 0x16);                   /* imul edx, eax, 0x16 */
            ii(0x1007_e281, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_e284, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1007_e287, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_e289, 5); call(0x1007_d972, -0x91c);              /* call 0x1007d972 */
            ii(0x1007_e28e, 3); sub(eax, 0x16);                         /* sub eax, 0x16 */
            ii(0x1007_e291, 3); add(memd[ss, ebp - 0xc], eax);          /* add [ebp-0xc], eax */
            ii(0x1007_e294, 2); jmp(0x1007_e26b, -0x2b); goto l_0x1007_e26b; /* jmp 0x1007e26b */
        l_0x1007_e296:
            ii(0x1007_e296, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_e299, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_e29c, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_e29f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_e2a1, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_e2a2, 1); pop(edi);                               /* pop edi */
            ii(0x1007_e2a3, 1); pop(esi);                               /* pop esi */
            ii(0x1007_e2a4, 1); pop(edx);                               /* pop edx */
            ii(0x1007_e2a5, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_e2a6, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_e2a7, 1); ret();                                  /* ret */
        }
    }
}
