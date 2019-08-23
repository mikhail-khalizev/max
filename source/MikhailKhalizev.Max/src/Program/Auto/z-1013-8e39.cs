using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_8e39-3705d6ca")]
        public void Method_1013_8e39()
        {
            ii(0x1013_8e39, 5); push(0x24);                             /* push 0x24 */
            ii(0x1013_8e3e, 5); call(Definitions.sys_check_available_stack_size, 0x2_cf0f); /* call 0x10165d52 */
            ii(0x1013_8e43, 1); push(ebx);                              /* push ebx */
            ii(0x1013_8e44, 1); push(ecx);                              /* push ecx */
            ii(0x1013_8e45, 1); push(esi);                              /* push esi */
            ii(0x1013_8e46, 1); push(edi);                              /* push edi */
            ii(0x1013_8e47, 1); push(ebp);                              /* push ebp */
            ii(0x1013_8e48, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_8e4a, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_8e50, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_8e53, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_8e56, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_8e59, 5); call(0x1007_6338, -0xc_2b26);           /* call 0x10076338 */
            ii(0x1013_8e5e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_8e60, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1013_8e63, 5); call(0x1007_64b8, -0xc_29b0);           /* call 0x100764b8 */
            ii(0x1013_8e68, 2); jmp(0x1013_8e72, 0x8); goto l_0x1013_8e72; /* jmp 0x10138e72 */
        l_0x1013_8e6a:
            ii(0x1013_8e6a, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1013_8e6d, 5); call(0x1007_6bf8, -0xc_227a);           /* call 0x10076bf8 */
        l_0x1013_8e72:
            ii(0x1013_8e72, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_8e74, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1013_8e77, 5); call(0x1013_ad71, 0x1ef5);              /* call 0x1013ad71 */
            ii(0x1013_8e7c, 2); test(al, al);                           /* test al, al */
            ii(0x1013_8e7e, 2); if(jz(0x1013_8ea4, 0x24)) goto l_0x1013_8ea4; /* jz 0x10138ea4 */
            ii(0x1013_8e80, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1013_8e83, 5); call(0x1007_63a0, -0xc_2ae8);           /* call 0x100763a0 */
            ii(0x1013_8e88, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_8e8a, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x1013_8e8d, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_8e91, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1013_8e93, 2); if(jnz(0x1013_8ea2, 0xd)) goto l_0x1013_8ea2; /* jnz 0x10138ea2 */
            ii(0x1013_8e95, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1013_8e98, 5); call(0x1007_6408, -0xc_2a95);           /* call 0x10076408 */
            ii(0x1013_8e9d, 5); call(0x1015_f2cc, 0x2_642a);            /* call 0x1015f2cc */
        l_0x1013_8ea2:
            ii(0x1013_8ea2, 2); jmp(0x1013_8e6a, -0x3a); goto l_0x1013_8e6a; /* jmp 0x10138e6a */
        l_0x1013_8ea4:
            ii(0x1013_8ea4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_8ea6, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1013_8ea9, 5); call(0x1007_5f6c, -0xc_2f42);           /* call 0x10075f6c */
            ii(0x1013_8eae, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_8eb0, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_8eb1, 1); pop(edi);                               /* pop edi */
            ii(0x1013_8eb2, 1); pop(esi);                               /* pop esi */
            ii(0x1013_8eb3, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_8eb4, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_8eb5, 1); ret();                                  /* ret */
        }
    }
}
