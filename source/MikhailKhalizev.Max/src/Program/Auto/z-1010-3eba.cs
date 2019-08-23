using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_3eba-71f77887")]
        public void Method_1010_3eba()
        {
            ii(0x1010_3eba, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1010_3ebf, 5); call(Definitions.sys_check_available_stack_size, 0x6_1e8e); /* call 0x10165d52 */
            ii(0x1010_3ec4, 1); push(ebx);                              /* push ebx */
            ii(0x1010_3ec5, 1); push(ecx);                              /* push ecx */
            ii(0x1010_3ec6, 1); push(esi);                              /* push esi */
            ii(0x1010_3ec7, 1); push(edi);                              /* push edi */
            ii(0x1010_3ec8, 1); push(ebp);                              /* push ebp */
            ii(0x1010_3ec9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_3ecb, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1010_3ed1, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_3ed4, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1010_3ed7, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_3eda, 3); movsx(ebx, memw[ds, eax]);              /* movsx ebx, word [eax] */
            ii(0x1010_3edd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_3edf, 4); mov(dx, memw[ss, ebp - 0x4]);           /* mov dx, [ebp-0x4] */
            ii(0x1010_3ee3, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1010_3ee5, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1010_3ee8, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1010_3eea, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1010_3eed, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1010_3ef1, 3); imul(ebx, eax, 0xa);                    /* imul ebx, eax, 0xa */
            ii(0x1010_3ef4, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1010_3ef7, 3); mov(eax, memd[ds, edx + 0x2]);          /* mov eax, [edx+0x2] */
            ii(0x1010_3efa, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1010_3efc, 5); call(0x1007_6338, -0x8_dbc9);           /* call 0x10076338 */
            ii(0x1010_3f01, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_3f03, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1010_3f06, 5); call(0x1007_64b8, -0x8_da53);           /* call 0x100764b8 */
        l_0x1010_3f0b:
            ii(0x1010_3f0b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_3f0d, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1010_3f10, 5); call(0x1013_ad71, 0x3_6e5c);            /* call 0x1013ad71 */
            ii(0x1010_3f15, 2); test(al, al);                           /* test al, al */
            ii(0x1010_3f17, 2); if(jz(0x1010_3f4d, 0x34)) goto l_0x1010_3f4d; /* jz 0x10103f4d */
            ii(0x1010_3f19, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1010_3f1c, 5); call(0x1007_63a0, -0x8_db81);           /* call 0x100763a0 */
            ii(0x1010_3f21, 5); call(0x1007_6154, -0x8_ddd2);           /* call 0x10076154 */
            ii(0x1010_3f26, 4); cmp(ax, memw[ss, ebp - 0x4]);           /* cmp ax, [ebp-0x4] */
            ii(0x1010_3f2a, 2); if(jnz(0x1010_3f43, 0x17)) goto l_0x1010_3f43; /* jnz 0x10103f43 */
            ii(0x1010_3f2c, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1010_3f2f, 5); call(0x1007_6408, -0x8_db2c);           /* call 0x10076408 */
            ii(0x1010_3f34, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1010_3f37, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_3f39, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1010_3f3c, 5); call(0x1007_5f6c, -0x8_dfd5);           /* call 0x10075f6c */
            ii(0x1010_3f41, 2); jmp(0x1010_3f6a, 0x27); goto l_0x1010_3f6a; /* jmp 0x10103f6a */
        l_0x1010_3f43:
            ii(0x1010_3f43, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1010_3f46, 5); call(0x1007_6bf8, -0x8_d353);           /* call 0x10076bf8 */
            ii(0x1010_3f4b, 2); jmp(0x1010_3f0b, -0x42); goto l_0x1010_3f0b; /* jmp 0x10103f0b */
        l_0x1010_3f4d:
            ii(0x1010_3f4d, 7); mov(memd[ss, ebp - 0x14], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x1010_3f54, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_3f56, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1010_3f59, 5); call(0x1007_5f6c, -0x8_dff2);           /* call 0x10075f6c */
            ii(0x1010_3f5e, 2); jmp(0x1010_3f6a, 0xa); goto l_0x1010_3f6a; /* jmp 0x10103f6a */
        //  ii(0x1010_3f60, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1010_3f62, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
        //  ii(0x1010_3f65, 5); call(0x1007_5f6c, -0x8_dffe);           /* call 0x10075f6c */
        l_0x1010_3f6a:
            ii(0x1010_3f6a, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1010_3f6d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_3f6f, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_3f70, 1); pop(edi);                               /* pop edi */
            ii(0x1010_3f71, 1); pop(esi);                               /* pop esi */
            ii(0x1010_3f72, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_3f73, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_3f74, 1); ret();                                  /* ret */
        }
    }
}
