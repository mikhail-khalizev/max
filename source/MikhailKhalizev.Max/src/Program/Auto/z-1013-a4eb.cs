using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_a4eb-be558d8a")]
        public void Method_1013_a4eb()
        {
            ii(0x1013_a4eb, 5); push(0x34);                             /* push 0x34 */
            ii(0x1013_a4f0, 5); call(Definitions.sys_check_available_stack_size, 0x2_b85d); /* call 0x10165d52 */
            ii(0x1013_a4f5, 1); push(ecx);                              /* push ecx */
            ii(0x1013_a4f6, 1); push(esi);                              /* push esi */
            ii(0x1013_a4f7, 1); push(edi);                              /* push edi */
            ii(0x1013_a4f8, 1); push(ebp);                              /* push ebp */
            ii(0x1013_a4f9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_a4fb, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1013_a501, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_a504, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1013_a507, 3); mov(memd[ss, ebp - 0x4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1013_a50a, 4); cmp(memd[ss, ebp - 0x8], 0);            /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1013_a50e, 2); if(jnz(0x1013_a520, 0x10)) goto l_0x1013_a520; /* jnz 0x1013a520 */
            ii(0x1013_a510, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1013_a513, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_a516, 5); call(0x1013_a369, -0x1b2);              /* call 0x1013a369 */
            ii(0x1013_a51b, 5); jmp(0x1013_a5a8, 0x88); goto l_0x1013_a5a8; /* jmp 0x1013a5a8 */
        l_0x1013_a520:
            ii(0x1013_a520, 5); mov(eax, 0x12);                         /* mov eax, 0x12 */
            ii(0x1013_a525, 5); call(Definitions.sys_new, 0x2_b8d6);    /* call 0x10165e00 */
            ii(0x1013_a52a, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1013_a52d, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_a530, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1013_a533, 4); cmp(memd[ss, ebp - 0x18], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1013_a537, 2); if(jz(0x1013_a54f, 0x16)) goto l_0x1013_a54f; /* jz 0x1013a54f */
            ii(0x1013_a539, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1013_a53c, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_a53f, 5); call(0x1013_9eb4, -0x690);              /* call 0x10139eb4 */
            ii(0x1013_a544, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1013_a547, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1013_a54a, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_a54d, 2); jmp(0x1013_a555, 0x6); goto l_0x1013_a555; /* jmp 0x1013a555 */
        l_0x1013_a54f:
            ii(0x1013_a54f, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_a552, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
        l_0x1013_a555:
            ii(0x1013_a555, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1013_a558, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_a55b, 5); call(0x1007_6d14, -0xc_384c);           /* call 0x10076d14 */
            ii(0x1013_a560, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_a563, 3); inc(memw[ds, eax]);                     /* inc word [eax] */
            ii(0x1013_a566, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_a569, 5); call(0x1007_6c68, -0xc_3906);           /* call 0x10076c68 */
            ii(0x1013_a56e, 3); mov(ebx, memd[ss, ebp - 0x8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1013_a571, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_a573, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1013_a575, 5); call(0x1013_9f45, -0x635);              /* call 0x10139f45 */
            ii(0x1013_a57a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_a57c, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_a57f, 5); call(0x1013_aa3c, 0x4b8);               /* call 0x1013aa3c */
            ii(0x1013_a584, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1013_a587, 5); call(0x1013_ad11, 0x785);               /* call 0x1013ad11 */
            ii(0x1013_a58c, 2); test(al, al);                           /* test al, al */
            ii(0x1013_a58e, 2); if(jz(0x1013_a59e, 0xe)) goto l_0x1013_a59e; /* jz 0x1013a59e */
            ii(0x1013_a590, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x1013_a593, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_a596, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1013_a599, 5); call(0x1013_aa70, 0x4d2);               /* call 0x1013aa70 */
        l_0x1013_a59e:
            ii(0x1013_a59e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_a5a0, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_a5a3, 5); call(0x1007_5e24, -0xc_4784);           /* call 0x10075e24 */
        l_0x1013_a5a8:
            ii(0x1013_a5a8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_a5aa, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_a5ab, 1); pop(edi);                               /* pop edi */
            ii(0x1013_a5ac, 1); pop(esi);                               /* pop esi */
            ii(0x1013_a5ad, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_a5ae, 1); ret();                                  /* ret */
        }
    }
}
