using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_b9c2-838df3c6")]
        public void Method_1008_b9c2()
        {
            ii(0x1008_b9c2, 5); push(0x28);                             /* push 0x28 */
            ii(0x1008_b9c7, 5); call(Definitions.sys_check_available_stack_size, 0xd_a386); /* call 0x10165d52 */
            ii(0x1008_b9cc, 1); push(ecx);                              /* push ecx */
            ii(0x1008_b9cd, 1); push(esi);                              /* push esi */
            ii(0x1008_b9ce, 1); push(edi);                              /* push edi */
            ii(0x1008_b9cf, 1); push(ebp);                              /* push ebp */
            ii(0x1008_b9d0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_b9d2, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1008_b9d8, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_b9db, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1008_b9de, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x1008_b9e1, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_b9e4, 5); call(0x1007_6338, -0x1_56b1);           /* call 0x10076338 */
            ii(0x1008_b9e9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_b9eb, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1008_b9ee, 5); call(0x1007_64b8, -0x1_553b);           /* call 0x100764b8 */
            ii(0x1008_b9f3, 2); jmp(0x1008_b9fd, 8); goto l_0x1008_b9fd; /* jmp 0x1008b9fd */
        l_0x1008_b9f5:
            ii(0x1008_b9f5, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1008_b9f8, 5); call(0x1007_6bf8, -0x1_4e05);           /* call 0x10076bf8 */
        l_0x1008_b9fd:
            ii(0x1008_b9fd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_b9ff, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1008_ba02, 5); call(0x1013_ad71, 0xa_f36a);            /* call 0x1013ad71 */
            ii(0x1008_ba07, 2); test(al, al);                           /* test al, al */
            ii(0x1008_ba09, 2); if(jz(0x1008_ba46, 0x3b)) goto l_0x1008_ba46; /* jz 0x1008ba46 */
            ii(0x1008_ba0b, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1008_ba0e, 5); call(0x1007_63a0, -0x1_5673);           /* call 0x100763a0 */
            ii(0x1008_ba13, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_ba15, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x1008_ba18, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1008_ba1c, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1008_ba1e, 2); if(jnz(0x1008_ba32, 0x12)) goto l_0x1008_ba32; /* jnz 0x1008ba32 */
            ii(0x1008_ba20, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1008_ba23, 5); call(0x1007_63a0, -0x1_5688);           /* call 0x100763a0 */
            ii(0x1008_ba28, 4); mov(ax, memw[ds, eax + 8]);             /* mov ax, [eax+0x8] */
            ii(0x1008_ba2c, 4); cmp(ax, memw[ss, ebp - 4]);             /* cmp ax, [ebp-0x4] */
            ii(0x1008_ba30, 2); if(jz(0x1008_ba34, 2)) goto l_0x1008_ba34; /* jz 0x1008ba34 */
        l_0x1008_ba32:
            ii(0x1008_ba32, 2); jmp(0x1008_ba44, 0x10); goto l_0x1008_ba44; /* jmp 0x1008ba44 */
        l_0x1008_ba34:
            ii(0x1008_ba34, 4); mov(memb[ss, ebp - 0x10], 1);           /* mov byte [ebp-0x10], 0x1 */
            ii(0x1008_ba38, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_ba3a, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1008_ba3d, 5); call(0x1007_5f6c, -0x1_5ad6);           /* call 0x10075f6c */
            ii(0x1008_ba42, 2); jmp(0x1008_ba60, 0x1c); goto l_0x1008_ba60; /* jmp 0x1008ba60 */
        l_0x1008_ba44:
            ii(0x1008_ba44, 2); jmp(0x1008_b9f5, -0x51); goto l_0x1008_b9f5; /* jmp 0x1008b9f5 */
        l_0x1008_ba46:
            ii(0x1008_ba46, 4); mov(memb[ss, ebp - 0x10], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x1008_ba4a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_ba4c, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1008_ba4f, 5); call(0x1007_5f6c, -0x1_5ae8);           /* call 0x10075f6c */
            ii(0x1008_ba54, 2); jmp(0x1008_ba60, 0xa); goto l_0x1008_ba60; /* jmp 0x1008ba60 */
        //  ii(0x1008_ba56, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1008_ba58, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
        //  ii(0x1008_ba5b, 5); call(0x1007_5f6c, -0x1_5af4);           /* call 0x10075f6c */
        l_0x1008_ba60:
            ii(0x1008_ba60, 3); mov(al, memb[ss, ebp - 0x10]);          /* mov al, [ebp-0x10] */
            ii(0x1008_ba63, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_ba65, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_ba66, 1); pop(edi);                               /* pop edi */
            ii(0x1008_ba67, 1); pop(esi);                               /* pop esi */
            ii(0x1008_ba68, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_ba69, 1); ret();                                  /* ret */
        }
    }
}
