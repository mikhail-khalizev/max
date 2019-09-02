using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_ed71-7016baff")]
        public void Method_100f_ed71()
        {
            ii(0x100f_ed71, 5); push(0x24);                             /* push 0x24 */
            ii(0x100f_ed76, 5); call(Definitions.sys_check_available_stack_size, 0x6_6fd7); /* call 0x10165d52 */
            ii(0x100f_ed7b, 1); push(ebx);                              /* push ebx */
            ii(0x100f_ed7c, 1); push(ecx);                              /* push ecx */
            ii(0x100f_ed7d, 1); push(esi);                              /* push esi */
            ii(0x100f_ed7e, 1); push(edi);                              /* push edi */
            ii(0x100f_ed7f, 1); push(ebp);                              /* push ebp */
            ii(0x100f_ed80, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_ed82, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100f_ed88, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100f_ed8b, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x100f_ed8e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100f_ed91, 5); call(0x1007_6338, -0x8_8a5e);           /* call 0x10076338 */
            ii(0x100f_ed96, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_ed98, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100f_ed9b, 5); call(0x1007_64b8, -0x8_88e8);           /* call 0x100764b8 */
        l_0x100f_eda0:
            ii(0x100f_eda0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_eda2, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100f_eda5, 5); call(0x1013_ad71, 0x3_bfc7);            /* call 0x1013ad71 */
            ii(0x100f_edaa, 2); test(al, al);                           /* test al, al */
            ii(0x100f_edac, 2); if(jz(0x100f_edea, 0x3c)) goto l_0x100f_edea; /* jz 0x100fedea */
            ii(0x100f_edae, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100f_edb1, 5); call(0x1007_63a0, -0x8_8a16);           /* call 0x100763a0 */
            ii(0x100f_edb6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_edb8, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x100f_edbb, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100f_edbf, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_edc1, 2); if(jnz(0x100f_edd1, 0xe)) goto l_0x100f_edd1; /* jnz 0x100fedd1 */
            ii(0x100f_edc3, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100f_edc6, 5); call(0x1007_63a0, -0x8_8a2b);           /* call 0x100763a0 */
            ii(0x100f_edcb, 4); cmp(memb[ds, eax + 0x3d], 0x1a);        /* cmp byte [eax+0x3d], 0x1a */
            ii(0x100f_edcf, 2); if(jnz(0x100f_edd3, 2)) goto l_0x100f_edd3; /* jnz 0x100fedd3 */
        l_0x100f_edd1:
            ii(0x100f_edd1, 2); jmp(0x100f_ede0, 0xd); goto l_0x100f_ede0; /* jmp 0x100fede0 */
        l_0x100f_edd3:
            ii(0x100f_edd3, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100f_edd6, 5); call(0x1007_63a0, -0x8_8a3b);           /* call 0x100763a0 */
            ii(0x100f_eddb, 5); call(0x1015_02a0, 0x5_14c0);            /* call 0x101502a0 */
        l_0x100f_ede0:
            ii(0x100f_ede0, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100f_ede3, 5); call(0x1007_6bf8, -0x8_81f0);           /* call 0x10076bf8 */
            ii(0x100f_ede8, 2); jmp(0x100f_eda0, -0x4a); goto l_0x100f_eda0; /* jmp 0x100feda0 */
        l_0x100f_edea:
            ii(0x100f_edea, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_edec, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x100f_edef, 5); call(0x1007_5f6c, -0x8_8e88);           /* call 0x10075f6c */
            ii(0x100f_edf4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_edf6, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_edf7, 1); pop(edi);                               /* pop edi */
            ii(0x100f_edf8, 1); pop(esi);                               /* pop esi */
            ii(0x100f_edf9, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_edfa, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_edfb, 1); ret();                                  /* ret */
        }
    }
}
