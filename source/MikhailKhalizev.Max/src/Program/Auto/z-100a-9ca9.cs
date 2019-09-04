using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_9ca9-c8961c7")]
        public void Method_100a_9ca9()
        {
            ii(0x100a_9ca9, 5); push(0x24);                             /* push 0x24 */
            ii(0x100a_9cae, 5); call(Definitions.sys_check_available_stack_size, 0xb_c09f); /* call 0x10165d52 */
            ii(0x100a_9cb3, 1); push(ebx);                              /* push ebx */
            ii(0x100a_9cb4, 1); push(ecx);                              /* push ecx */
            ii(0x100a_9cb5, 1); push(edx);                              /* push edx */
            ii(0x100a_9cb6, 1); push(esi);                              /* push esi */
            ii(0x100a_9cb7, 1); push(edi);                              /* push edi */
            ii(0x100a_9cb8, 1); push(ebp);                              /* push ebp */
            ii(0x100a_9cb9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_9cbb, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100a_9cc1, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100a_9cc4, 7); mov(memd[ss, ebp - 8], 0);              /* mov dword [ebp-0x8], 0x0 */
            ii(0x100a_9ccb, 2); jmp(0x100a_9cd3, 6); goto l_0x100a_9cd3; /* jmp 0x100a9cd3 */
        l_0x100a_9ccd:
            ii(0x100a_9ccd, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_9cd0, 3); inc(memd[ss, ebp - 8]);                 /* inc dword [ebp-0x8] */
        l_0x100a_9cd3:
            ii(0x100a_9cd3, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100a_9cd7, 3); cmp(eax, 4);                            /* cmp eax, 0x4 */
            ii(0x100a_9cda, 2); if(jge(0x100a_9d11, 0x35)) goto l_0x100a_9d11; /* jge 0x100a9d11 */
            ii(0x100a_9cdc, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100a_9ce0, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100a_9ce6, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x100a_9cec, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_9cf1, 3); cmp(eax, 2);                            /* cmp eax, 0x2 */
            ii(0x100a_9cf4, 2); if(jnz(0x100a_9d0f, 0x19)) goto l_0x100a_9d0f; /* jnz 0x100a9d0f */
            ii(0x100a_9cf6, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_9cf9, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100a_9cfd, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x100a_9d03, 5); mov(ebx, 0x101c_31c4);                  /* mov ebx, 0x101c31c4 */
            ii(0x100a_9d08, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100a_9d0a, 5); call(0x100c_5ed9, 0x1_c1ca);            /* call 0x100c5ed9 */
        l_0x100a_9d0f:
            ii(0x100a_9d0f, 2); jmp(0x100a_9ccd, -0x44); goto l_0x100a_9ccd; /* jmp 0x100a9ccd */
        l_0x100a_9d11:
            ii(0x100a_9d11, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_9d13, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_9d14, 1); pop(edi);                               /* pop edi */
            ii(0x100a_9d15, 1); pop(esi);                               /* pop esi */
            ii(0x100a_9d16, 1); pop(edx);                               /* pop edx */
            ii(0x100a_9d17, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_9d18, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_9d19, 1); ret();                                  /* ret */
        }
    }
}
