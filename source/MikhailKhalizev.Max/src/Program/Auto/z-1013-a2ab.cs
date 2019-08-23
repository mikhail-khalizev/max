using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_a2ab-392adbdb")]
        public void Method_1013_a2ab()
        {
            ii(0x1013_a2ab, 5); push(0x34);                             /* push 0x34 */
            ii(0x1013_a2b0, 5); call(Definitions.sys_check_available_stack_size, 0x2_ba9d); /* call 0x10165d52 */
            ii(0x1013_a2b5, 1); push(ebx);                              /* push ebx */
            ii(0x1013_a2b6, 1); push(ecx);                              /* push ecx */
            ii(0x1013_a2b7, 1); push(esi);                              /* push esi */
            ii(0x1013_a2b8, 1); push(edi);                              /* push edi */
            ii(0x1013_a2b9, 1); push(ebp);                              /* push ebp */
            ii(0x1013_a2ba, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_a2bc, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1013_a2c2, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_a2c5, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_a2c8, 5); mov(eax, 0x12);                         /* mov eax, 0x12 */
            ii(0x1013_a2cd, 5); call(Definitions.sys_new, 0x2_bb2e);    /* call 0x10165e00 */
            ii(0x1013_a2d2, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_a2d5, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_a2d8, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1013_a2db, 4); cmp(memd[ss, ebp - 0x14], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1013_a2df, 2); if(jz(0x1013_a2f7, 0x16)) goto l_0x1013_a2f7; /* jz 0x1013a2f7 */
            ii(0x1013_a2e1, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1013_a2e4, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_a2e7, 5); call(0x1013_9eb4, -0x438);              /* call 0x10139eb4 */
            ii(0x1013_a2ec, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1013_a2ef, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_a2f2, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_a2f5, 2); jmp(0x1013_a2fd, 0x6); goto l_0x1013_a2fd; /* jmp 0x1013a2fd */
        l_0x1013_a2f7:
            ii(0x1013_a2f7, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_a2fa, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
        l_0x1013_a2fd:
            ii(0x1013_a2fd, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1013_a300, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1013_a303, 5); call(0x1007_6d14, -0xc_35f4);           /* call 0x10076d14 */
            ii(0x1013_a308, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_a30b, 3); inc(memw[ds, eax]);                     /* inc word [eax] */
            ii(0x1013_a30e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_a310, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_a313, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1013_a316, 5); call(0x1013_ad11, 0x9f6);               /* call 0x1013ad11 */
            ii(0x1013_a31b, 2); test(al, al);                           /* test al, al */
            ii(0x1013_a31d, 2); if(jz(0x1013_a32f, 0x10)) goto l_0x1013_a32f; /* jz 0x1013a32f */
            ii(0x1013_a31f, 3); lea(edx, memd[ss, ebp - 0x1c]);         /* lea edx, [ebp-0x1c] */
            ii(0x1013_a322, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_a325, 3); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x1013_a328, 5); call(0x1013_aa70, 0x743);               /* call 0x1013aa70 */
            ii(0x1013_a32d, 2); jmp(0x1013_a349, 0x1a); goto l_0x1013_a349; /* jmp 0x1013a349 */
        l_0x1013_a32f:
            ii(0x1013_a32f, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1013_a332, 5); call(0x1007_6c68, -0xc_36cf);           /* call 0x10076c68 */
            ii(0x1013_a337, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_a339, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_a33c, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1013_a33f, 5); call(0x1013_aa3c, 0x6f8);               /* call 0x1013aa3c */
            ii(0x1013_a344, 5); call(0x1013_9f45, -0x404);              /* call 0x10139f45 */
        l_0x1013_a349:
            ii(0x1013_a349, 3); lea(edx, memd[ss, ebp - 0x1c]);         /* lea edx, [ebp-0x1c] */
            ii(0x1013_a34c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_a34f, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1013_a352, 5); call(0x1013_aa70, 0x719);               /* call 0x1013aa70 */
            ii(0x1013_a357, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_a359, 3); lea(eax, memd[ss, ebp - 0x1c]);         /* lea eax, [ebp-0x1c] */
            ii(0x1013_a35c, 5); call(0x1007_5e24, -0xc_453d);           /* call 0x10075e24 */
            ii(0x1013_a361, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_a363, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_a364, 1); pop(edi);                               /* pop edi */
            ii(0x1013_a365, 1); pop(esi);                               /* pop esi */
            ii(0x1013_a366, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_a367, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_a368, 1); ret();                                  /* ret */
        }
    }
}
