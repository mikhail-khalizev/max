using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_2b78-f72bb6f1")]
        public void Method_1008_2b78()
        {
            ii(0x1008_2b78, 5); push(0x28);                             /* push 0x28 */
            ii(0x1008_2b7d, 5); call(Definitions.sys_check_available_stack_size, 0xe_31d0); /* call 0x10165d52 */
            ii(0x1008_2b82, 1); push(ebx);                              /* push ebx */
            ii(0x1008_2b83, 1); push(ecx);                              /* push ecx */
            ii(0x1008_2b84, 1); push(esi);                              /* push esi */
            ii(0x1008_2b85, 1); push(edi);                              /* push edi */
            ii(0x1008_2b86, 1); push(ebp);                              /* push ebp */
            ii(0x1008_2b87, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_2b89, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1008_2b8f, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_2b92, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1008_2b95, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_2b97, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_2b9a, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_2b9d, 5); call(0x1013_ad11, 0xb_816f);            /* call 0x1013ad11 */
            ii(0x1008_2ba2, 2); test(al, al);                           /* test al, al */
            ii(0x1008_2ba4, 2); if(jz(0x1008_2bb5, 0xf)) goto l_0x1008_2bb5; /* jz 0x10082bb5 */
            ii(0x1008_2ba6, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_2ba9, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_2bac, 5); call(0x1008_2abe, -0xf3);               /* call 0x10082abe */
            ii(0x1008_2bb1, 2); test(al, al);                           /* test al, al */
            ii(0x1008_2bb3, 2); if(jnz(0x1008_2bb7, 2)) goto l_0x1008_2bb7; /* jnz 0x10082bb7 */
        l_0x1008_2bb5:
            ii(0x1008_2bb5, 2); jmp(0x1008_2bbd, 6); goto l_0x1008_2bbd; /* jmp 0x10082bbd */
        l_0x1008_2bb7:
            ii(0x1008_2bb7, 4); mov(memb[ss, ebp - 0xc], 1);            /* mov byte [ebp-0xc], 0x1 */
            ii(0x1008_2bbb, 2); jmp(0x1008_2bc1, 4); goto l_0x1008_2bc1; /* jmp 0x10082bc1 */
        l_0x1008_2bbd:
            ii(0x1008_2bbd, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
        l_0x1008_2bc1:
            ii(0x1008_2bc1, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1008_2bc4, 3); mov(memb[ss, ebp - 0x10], al);          /* mov [ebp-0x10], al */
            ii(0x1008_2bc7, 3); mov(al, memb[ss, ebp - 0x10]);          /* mov al, [ebp-0x10] */
            ii(0x1008_2bca, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_2bcc, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_2bcd, 1); pop(edi);                               /* pop edi */
            ii(0x1008_2bce, 1); pop(esi);                               /* pop esi */
            ii(0x1008_2bcf, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_2bd0, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_2bd1, 1); ret();                                  /* ret */
        }
    }
}
