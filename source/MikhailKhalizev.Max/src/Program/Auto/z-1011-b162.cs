using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_b162-6bb4bf3c")]
        public void Method_1011_b162()
        {
            ii(0x1011_b162, 5); push(0x24);                             /* push 0x24 */
            ii(0x1011_b167, 5); call(Definitions.sys_check_available_stack_size, 0x4_abe6); /* call 0x10165d52 */
            ii(0x1011_b16c, 1); push(ebx);                              /* push ebx */
            ii(0x1011_b16d, 1); push(ecx);                              /* push ecx */
            ii(0x1011_b16e, 1); push(esi);                              /* push esi */
            ii(0x1011_b16f, 1); push(edi);                              /* push edi */
            ii(0x1011_b170, 1); push(ebp);                              /* push ebp */
            ii(0x1011_b171, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_b173, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1011_b179, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_b17c, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1011_b17f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_b182, 3); mov(edx, memd[ds, eax + 0x6]);          /* mov edx, [eax+0x6] */
            ii(0x1011_b185, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_b188, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_b18b, 5); call(0x1013_c0fa, 0x2_0f6a);            /* call 0x1013c0fa */
            ii(0x1011_b190, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_b193, 3); mov(edx, memd[ds, eax + 0x8]);          /* mov edx, [eax+0x8] */
            ii(0x1011_b196, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_b199, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_b19c, 5); call(0x1013_c0fa, 0x2_0f59);            /* call 0x1013c0fa */
            ii(0x1011_b1a1, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_b1a4, 3); mov(edx, memd[ds, eax + 0x14]);         /* mov edx, [eax+0x14] */
            ii(0x1011_b1a7, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_b1aa, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_b1ad, 5); call(0x1013_c0fa, 0x2_0f48);            /* call 0x1013c0fa */
            ii(0x1011_b1b2, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_b1b5, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1011_b1b8, 5); call(0x100b_82bc, -0x6_2f01);           /* call 0x100b82bc */
            ii(0x1011_b1bd, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_b1c0, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_b1c3, 5); call(0x1013_c0fa, 0x2_0f32);            /* call 0x1013c0fa */
            ii(0x1011_b1c8, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x1011_b1cf, 2); jmp(0x1011_b1d7, 0x6); goto l_0x1011_b1d7; /* jmp 0x1011b1d7 */
        l_0x1011_b1d1:
            ii(0x1011_b1d1, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_b1d4, 3); inc(memd[ss, ebp - 0xc]);               /* inc dword [ebp-0xc] */
        l_0x1011_b1d7:
            ii(0x1011_b1d7, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_b1da, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1011_b1dd, 5); call(0x100b_82bc, -0x6_2f26);           /* call 0x100b82bc */
            ii(0x1011_b1e2, 4); cmp(ax, memw[ss, ebp - 0xc]);           /* cmp ax, [ebp-0xc] */
            ii(0x1011_b1e6, 2); if(jle(0x1011_b208, 0x20)) goto l_0x1011_b208; /* jle 0x1011b208 */
            ii(0x1011_b1e8, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x1011_b1ed, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1011_b1f1, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_b1f4, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1011_b1f7, 5); call(0x100b_827c, -0x6_2f80);           /* call 0x100b827c */
            ii(0x1011_b1fc, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_b1fe, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_b201, 5); call(0x1013_c055, 0x2_0e4f);            /* call 0x1013c055 */
            ii(0x1011_b206, 2); jmp(0x1011_b1d1, -0x37); goto l_0x1011_b1d1; /* jmp 0x1011b1d1 */
        l_0x1011_b208:
            ii(0x1011_b208, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_b20a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_b20b, 1); pop(edi);                               /* pop edi */
            ii(0x1011_b20c, 1); pop(esi);                               /* pop esi */
            ii(0x1011_b20d, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_b20e, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_b20f, 1); ret();                                  /* ret */
        }
    }
}
