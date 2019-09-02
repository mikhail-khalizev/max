using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_da86-22c64ac3")]
        public void Method_1011_da86()
        {
            ii(0x1011_da86, 5); push(0x28);                             /* push 0x28 */
            ii(0x1011_da8b, 5); call(Definitions.sys_check_available_stack_size, 0x4_82c2); /* call 0x10165d52 */
            ii(0x1011_da90, 1); push(ecx);                              /* push ecx */
            ii(0x1011_da91, 1); push(esi);                              /* push esi */
            ii(0x1011_da92, 1); push(edi);                              /* push edi */
            ii(0x1011_da93, 1); push(ebp);                              /* push ebp */
            ii(0x1011_da94, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_da96, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1011_da9c, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1011_da9f, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1011_daa2, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x1011_daa5, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_daa8, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x1011_daab, 3); shl(edx, 2);                            /* shl edx, 0x2 */
            ii(0x1011_daae, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1011_dab1, 3); mov(eax, memd[ds, eax + 39]);           /* mov eax, [eax+0x27] */
            ii(0x1011_dab4, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_dab6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_dab9, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1011_dabb, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_dabe, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x1011_dac0, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_dac2, 3); mov(memd[ss, ebp - 16], edx);           /* mov [ebp-0x10], edx */
        l_0x1011_dac5:
            ii(0x1011_dac5, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_dac8, 4); mov(ax, memw[ds, eax + 2]);             /* mov ax, [eax+0x2] */
            ii(0x1011_dacc, 4); cmp(ax, memw[ss, ebp - 4]);             /* cmp ax, [ebp-0x4] */
            ii(0x1011_dad0, 2); if(jge(0x1011_dada, 8)) goto l_0x1011_dada; /* jge 0x1011dada */
            ii(0x1011_dad2, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1011_dad5, 3); test(memb[ds, eax], 0x1f);              /* test byte [eax], 0x1f */
            ii(0x1011_dad8, 2); if(jnz(0x1011_dadc, 2)) goto l_0x1011_dadc; /* jnz 0x1011dadc */
        l_0x1011_dada:
            ii(0x1011_dada, 2); jmp(0x1011_dae4, 8); goto l_0x1011_dae4; /* jmp 0x1011dae4 */
        l_0x1011_dadc:
            ii(0x1011_dadc, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1011_dadf, 3); test(memb[ds, eax], 0x20);              /* test byte [eax], 0x20 */
            ii(0x1011_dae2, 2); if(jz(0x1011_dae6, 2)) goto l_0x1011_dae6; /* jz 0x1011dae6 */
        l_0x1011_dae4:
            ii(0x1011_dae4, 2); jmp(0x1011_daf5, 0xf); goto l_0x1011_daf5; /* jmp 0x1011daf5 */
        l_0x1011_dae6:
            ii(0x1011_dae6, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1011_dae9, 3); inc(memd[ss, ebp - 16]);                /* inc dword [ebp-0x10] */
            ii(0x1011_daec, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_daef, 4); inc(memw[ds, eax + 2]);                 /* inc word [eax+0x2] */
            ii(0x1011_daf3, 2); jmp(0x1011_dac5, -0x30); goto l_0x1011_dac5; /* jmp 0x1011dac5 */
        l_0x1011_daf5:
            ii(0x1011_daf5, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_daf8, 4); mov(ax, memw[ds, eax + 2]);             /* mov ax, [eax+0x2] */
            ii(0x1011_dafc, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1011_daff, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1011_db02, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_db04, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_db05, 1); pop(edi);                               /* pop edi */
            ii(0x1011_db06, 1); pop(esi);                               /* pop esi */
            ii(0x1011_db07, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_db08, 1); ret();                                  /* ret */
        }
    }
}
