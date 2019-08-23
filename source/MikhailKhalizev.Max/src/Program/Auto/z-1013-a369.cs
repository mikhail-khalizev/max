using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_a369-85c29d60")]
        public void Method_1013_a369()
        {
            ii(0x1013_a369, 5); push(0x34);                             /* push 0x34 */
            ii(0x1013_a36e, 5); call(Definitions.sys_check_available_stack_size, 0x2_b9df); /* call 0x10165d52 */
            ii(0x1013_a373, 1); push(ebx);                              /* push ebx */
            ii(0x1013_a374, 1); push(ecx);                              /* push ecx */
            ii(0x1013_a375, 1); push(esi);                              /* push esi */
            ii(0x1013_a376, 1); push(edi);                              /* push edi */
            ii(0x1013_a377, 1); push(ebp);                              /* push ebp */
            ii(0x1013_a378, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_a37a, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1013_a380, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_a383, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_a386, 5); mov(eax, 0x12);                         /* mov eax, 0x12 */
            ii(0x1013_a38b, 5); call(Definitions.sys_new, 0x2_ba70);    /* call 0x10165e00 */
            ii(0x1013_a390, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_a393, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_a396, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1013_a399, 4); cmp(memd[ss, ebp - 0x14], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1013_a39d, 2); if(jz(0x1013_a3b5, 0x16)) goto l_0x1013_a3b5; /* jz 0x1013a3b5 */
            ii(0x1013_a39f, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1013_a3a2, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_a3a5, 5); call(0x1013_9eb4, -0x4f6);              /* call 0x10139eb4 */
            ii(0x1013_a3aa, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1013_a3ad, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_a3b0, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_a3b3, 2); jmp(0x1013_a3bb, 0x6); goto l_0x1013_a3bb; /* jmp 0x1013a3bb */
        l_0x1013_a3b5:
            ii(0x1013_a3b5, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_a3b8, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
        l_0x1013_a3bb:
            ii(0x1013_a3bb, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1013_a3be, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1013_a3c1, 5); call(0x1007_6d14, -0xc_36b2);           /* call 0x10076d14 */
            ii(0x1013_a3c6, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_a3c9, 3); inc(memw[ds, eax]);                     /* inc word [eax] */
            ii(0x1013_a3cc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_a3ce, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_a3d1, 3); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x1013_a3d4, 5); call(0x1013_ad11, 0x938);               /* call 0x1013ad11 */
            ii(0x1013_a3d9, 2); test(al, al);                           /* test al, al */
            ii(0x1013_a3db, 2); if(jz(0x1013_a3ed, 0x10)) goto l_0x1013_a3ed; /* jz 0x1013a3ed */
            ii(0x1013_a3dd, 3); lea(edx, memd[ss, ebp - 0x1c]);         /* lea edx, [ebp-0x1c] */
            ii(0x1013_a3e0, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_a3e3, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1013_a3e6, 5); call(0x1013_aa70, 0x685);               /* call 0x1013aa70 */
            ii(0x1013_a3eb, 2); jmp(0x1013_a407, 0x1a); goto l_0x1013_a407; /* jmp 0x1013a407 */
        l_0x1013_a3ed:
            ii(0x1013_a3ed, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1013_a3f0, 5); call(0x1007_6c68, -0xc_378d);           /* call 0x10076c68 */
            ii(0x1013_a3f5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_a3f7, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_a3fa, 3); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x1013_a3fd, 5); call(0x1013_aa3c, 0x63a);               /* call 0x1013aa3c */
            ii(0x1013_a402, 5); call(0x1013_9fbe, -0x449);              /* call 0x10139fbe */
        l_0x1013_a407:
            ii(0x1013_a407, 3); lea(edx, memd[ss, ebp - 0x1c]);         /* lea edx, [ebp-0x1c] */
            ii(0x1013_a40a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_a40d, 3); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x1013_a410, 5); call(0x1013_aa70, 0x65b);               /* call 0x1013aa70 */
            ii(0x1013_a415, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_a417, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1013_a41a, 5); call(0x1007_5e24, -0xc_45fb);           /* call 0x10075e24 */
            ii(0x1013_a41f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_a421, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_a422, 1); pop(edi);                               /* pop edi */
            ii(0x1013_a423, 1); pop(esi);                               /* pop esi */
            ii(0x1013_a424, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_a425, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_a426, 1); ret();                                  /* ret */
        }
    }
}
