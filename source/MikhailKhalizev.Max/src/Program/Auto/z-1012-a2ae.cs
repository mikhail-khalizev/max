using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_a2ae-64e6356d")]
        public void Method_1012_a2ae()
        {
            ii(0x1012_a2ae, 5); push(0x84);                             /* push 0x84 */
            ii(0x1012_a2b3, 5); call(Definitions.sys_check_available_stack_size, 0x3_ba9a); /* call 0x10165d52 */
            ii(0x1012_a2b8, 1); push(esi);                              /* push esi */
            ii(0x1012_a2b9, 1); push(edi);                              /* push edi */
            ii(0x1012_a2ba, 1); push(ebp);                              /* push ebp */
            ii(0x1012_a2bb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_a2bd, 6); sub(esp, 0x64);                         /* sub esp, 0x64 */
            ii(0x1012_a2c3, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1012_a2c6, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1012_a2c9, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1012_a2cc, 3); mov(memd[ss, ebp - 0xc], ecx);          /* mov [ebp-0xc], ecx */
            ii(0x1012_a2cf, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_a2d2, 4); cmp(ax, memw[ss, ebp - 0x8]);           /* cmp ax, [ebp-0x8] */
            ii(0x1012_a2d6, 2); if(jz(0x1012_a303, 0x2b)) goto l_0x1012_a303; /* jz 0x1012a303 */
            ii(0x1012_a2d8, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1012_a2dc, 1); push(eax);                              /* push eax */
            ii(0x1012_a2dd, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1012_a2e1, 1); push(eax);                              /* push eax */
            ii(0x1012_a2e2, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_a2e5, 1); push(eax);                              /* push eax */
            ii(0x1012_a2e6, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1012_a2e9, 1); push(eax);                              /* push eax */
            ii(0x1012_a2ea, 5); call(Definitions.sys_sprintf, 0x3_bc12); /* call 0x10165f01 */
            ii(0x1012_a2ef, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1012_a2f2, 3); lea(edx, ebp - 0x64);                   /* lea edx, [ebp-0x64] */
            ii(0x1012_a2f5, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_a2f8, 5); call(Definitions.sys_strcat, 0x3_bc34); /* call 0x10165f31 */
            ii(0x1012_a2fd, 4); mov(memb[ss, ebp - 0x14], 0x1);         /* mov byte [ebp-0x14], 0x1 */
            ii(0x1012_a301, 2); jmp(0x1012_a307, 0x4); goto l_0x1012_a307; /* jmp 0x1012a307 */
        l_0x1012_a303:
            ii(0x1012_a303, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
        l_0x1012_a307:
            ii(0x1012_a307, 3); mov(al, memb[ss, ebp - 0x14]);          /* mov al, [ebp-0x14] */
            ii(0x1012_a30a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_a30c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_a30d, 1); pop(edi);                               /* pop edi */
            ii(0x1012_a30e, 1); pop(esi);                               /* pop esi */
            ii(0x1012_a30f, 1); ret();                                  /* ret */
        }
    }
}
