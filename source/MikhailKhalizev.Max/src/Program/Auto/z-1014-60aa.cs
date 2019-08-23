using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_60aa-14530c7b")]
        public void Method_1014_60aa()
        {
            ii(0x1014_60aa, 5); push(0x28);                             /* push 0x28 */
            ii(0x1014_60af, 5); call(Definitions.sys_check_available_stack_size, 0x1_fc9e); /* call 0x10165d52 */
            ii(0x1014_60b4, 1); push(ebx);                              /* push ebx */
            ii(0x1014_60b5, 1); push(ecx);                              /* push ecx */
            ii(0x1014_60b6, 1); push(esi);                              /* push esi */
            ii(0x1014_60b7, 1); push(edi);                              /* push edi */
            ii(0x1014_60b8, 1); push(ebp);                              /* push ebp */
            ii(0x1014_60b9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_60bb, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1014_60c1, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_60c4, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_60c7, 3); lea(ebx, ebp - 0xc);                    /* lea ebx, [ebp-0xc] */
            ii(0x1014_60ca, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1014_60cd, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_60d0, 5); call(0x1014_5cbc, -0x419);              /* call 0x10145cbc */
            ii(0x1014_60d5, 2); test(al, al);                           /* test al, al */
            ii(0x1014_60d7, 2); if(jnz(0x1014_60e2, 0x9)) goto l_0x1014_60e2; /* jnz 0x101460e2 */
            ii(0x1014_60d9, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1014_60e0, 2); jmp(0x1014_60e8, 0x6); goto l_0x1014_60e8; /* jmp 0x101460e8 */
        l_0x1014_60e2:
            ii(0x1014_60e2, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_60e5, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
        l_0x1014_60e8:
            ii(0x1014_60e8, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_60eb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_60ed, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_60ee, 1); pop(edi);                               /* pop edi */
            ii(0x1014_60ef, 1); pop(esi);                               /* pop esi */
            ii(0x1014_60f0, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_60f1, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_60f2, 1); ret();                                  /* ret */
        }
    }
}
