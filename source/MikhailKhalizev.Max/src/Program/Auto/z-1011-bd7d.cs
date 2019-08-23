using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_bd7d-20f732b")]
        public void Method_1011_bd7d()
        {
            ii(0x1011_bd7d, 5); push(0x30);                             /* push 0x30 */
            ii(0x1011_bd82, 5); call(Definitions.sys_check_available_stack_size, 0x4_9fcb); /* call 0x10165d52 */
            ii(0x1011_bd87, 1); push(ebx);                              /* push ebx */
            ii(0x1011_bd88, 1); push(ecx);                              /* push ecx */
            ii(0x1011_bd89, 1); push(edx);                              /* push edx */
            ii(0x1011_bd8a, 1); push(esi);                              /* push esi */
            ii(0x1011_bd8b, 1); push(edi);                              /* push edi */
            ii(0x1011_bd8c, 1); push(ebp);                              /* push ebp */
            ii(0x1011_bd8d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_bd8f, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1011_bd95, 5); mov(eax, 0x1a);                         /* mov eax, 0x1a */
            ii(0x1011_bd9a, 5); call(Definitions.sys_new, 0x4_a061);    /* call 0x10165e00 */
            ii(0x1011_bd9f, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_bda2, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_bda5, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1011_bda8, 4); cmp(memd[ss, ebp - 0xc], 0);            /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1011_bdac, 2); if(jz(0x1011_bdc1, 0x13)) goto l_0x1011_bdc1; /* jz 0x1011bdc1 */
            ii(0x1011_bdae, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_bdb1, 5); call(0x1011_ba3d, -0x379);              /* call 0x1011ba3d */
            ii(0x1011_bdb6, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_bdb9, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_bdbc, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_bdbf, 2); jmp(0x1011_bdc7, 0x6); goto l_0x1011_bdc7; /* jmp 0x1011bdc7 */
        l_0x1011_bdc1:
            ii(0x1011_bdc1, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_bdc4, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
        l_0x1011_bdc7:
            ii(0x1011_bdc7, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_bdca, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1011_bdcd, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1011_bdd0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_bdd2, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_bdd3, 1); pop(edi);                               /* pop edi */
            ii(0x1011_bdd4, 1); pop(esi);                               /* pop esi */
            ii(0x1011_bdd5, 1); pop(edx);                               /* pop edx */
            ii(0x1011_bdd6, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_bdd7, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_bdd8, 1); ret();                                  /* ret */
        }
    }
}
