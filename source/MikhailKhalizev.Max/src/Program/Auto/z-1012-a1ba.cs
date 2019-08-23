using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_a1ba-eafd5b38")]
        public void Method_1012_a1ba()
        {
            ii(0x1012_a1ba, 5); push(0xec);                             /* push 0xec */
            ii(0x1012_a1bf, 5); call(Definitions.sys_check_available_stack_size, 0x3_bb8e); /* call 0x10165d52 */
            ii(0x1012_a1c4, 1); push(esi);                              /* push esi */
            ii(0x1012_a1c5, 1); push(edi);                              /* push edi */
            ii(0x1012_a1c6, 1); push(ebp);                              /* push ebp */
            ii(0x1012_a1c7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_a1c9, 6); sub(esp, 0xcc);                         /* sub esp, 0xcc */
            ii(0x1012_a1cf, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1012_a1d2, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1012_a1d5, 3); mov(memd[ss, ebp - 0x4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1012_a1d8, 3); mov(memd[ss, ebp - 0x8], ecx);          /* mov [ebp-0x8], ecx */
            ii(0x1012_a1db, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1012_a1df, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_a1e1, 2); if(jnz(0x1012_a1e9, 0x6)) goto l_0x1012_a1e9; /* jnz 0x1012a1e9 */
            ii(0x1012_a1e3, 4); cmp(memd[ss, ebp - 0xc], 0);            /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1012_a1e7, 2); if(jz(0x1012_a1eb, 0x2)) goto l_0x1012_a1eb; /* jz 0x1012a1eb */
        l_0x1012_a1e9:
            ii(0x1012_a1e9, 2); jmp(0x1012_a1f4, 0x9); goto l_0x1012_a1f4; /* jmp 0x1012a1f4 */
        l_0x1012_a1eb:
            ii(0x1012_a1eb, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x1012_a1ef, 5); jmp(0x1012_a2a5, 0xb1); goto l_0x1012_a2a5; /* jmp 0x1012a2a5 */
        l_0x1012_a1f4:
            ii(0x1012_a1f4, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1012_a1f8, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_a1fa, 2); if(jnz(0x1012_a205, 0x9)) goto l_0x1012_a205; /* jnz 0x1012a205 */
            ii(0x1012_a1fc, 7); mov(memd[ss, ebp - 0x18], 0);           /* mov dword [ebp-0x18], 0x0 */
            ii(0x1012_a203, 2); jmp(0x1012_a257, 0x52); goto l_0x1012_a257; /* jmp 0x1012a257 */
        l_0x1012_a205:
            ii(0x1012_a205, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_a207, 4); mov(dx, memw[ss, ebp - 0x4]);           /* mov dx, [ebp-0x4] */
            ii(0x1012_a20b, 5); mov(eax, 0x101c_39c0);                  /* mov eax, 0x101c39c0 */
            ii(0x1012_a210, 5); call(0x1010_3eba, -0x2_635b);           /* call 0x10103eba */
            ii(0x1012_a215, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1012_a218, 4); cmp(memd[ss, ebp - 0x18], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1012_a21c, 2); if(jnz(0x1012_a257, 0x39)) goto l_0x1012_a257; /* jnz 0x1012a257 */
            ii(0x1012_a21e, 5); mov(eax, StringDefinitions.Unknown);    /* mov eax, 0x101a83dc */
            ii(0x1012_a223, 1); push(eax);                              /* push eax */
            ii(0x1012_a224, 3); lea(edx, memd[ss, ebp - 0x40]);         /* lea edx, [ebp-0x40] */
            ii(0x1012_a227, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_a22a, 5); call(0x1012_a15b, -0xd4);               /* call 0x1012a15b */
            ii(0x1012_a22f, 1); push(eax);                              /* push eax */
            ii(0x1012_a230, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_a233, 1); push(eax);                              /* push eax */
            ii(0x1012_a234, 6); lea(eax, memd[ss, ebp - 0xa4]);         /* lea eax, [ebp-0xa4] */
            ii(0x1012_a23a, 1); push(eax);                              /* push eax */
            ii(0x1012_a23b, 5); call(Definitions.sys_sprintf, 0x3_bcc1); /* call 0x10165f01 */
            ii(0x1012_a240, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1012_a243, 6); lea(edx, memd[ss, ebp - 0xa4]);         /* lea edx, [ebp-0xa4] */
            ii(0x1012_a249, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_a24c, 5); call(Definitions.sys_strcat, 0x3_bce0); /* call 0x10165f31 */
            ii(0x1012_a251, 4); mov(memb[ss, ebp - 0x14], 0x1);         /* mov byte [ebp-0x14], 0x1 */
            ii(0x1012_a255, 2); jmp(0x1012_a2a5, 0x4e); goto l_0x1012_a2a5; /* jmp 0x1012a2a5 */
        l_0x1012_a257:
            ii(0x1012_a257, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_a25a, 3); cmp(eax, memd[ss, ebp - 0x18]);         /* cmp eax, [ebp-0x18] */
            ii(0x1012_a25d, 2); if(jz(0x1012_a2a1, 0x42)) goto l_0x1012_a2a1; /* jz 0x1012a2a1 */
            ii(0x1012_a25f, 6); lea(edx, memd[ss, ebp - 0xcc]);         /* lea edx, [ebp-0xcc] */
            ii(0x1012_a265, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_a268, 5); call(0x1012_a15b, -0x112);              /* call 0x1012a15b */
            ii(0x1012_a26d, 1); push(eax);                              /* push eax */
            ii(0x1012_a26e, 3); lea(edx, memd[ss, ebp - 0x40]);         /* lea edx, [ebp-0x40] */
            ii(0x1012_a271, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_a274, 5); call(0x1012_a15b, -0x11e);              /* call 0x1012a15b */
            ii(0x1012_a279, 1); push(eax);                              /* push eax */
            ii(0x1012_a27a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_a27d, 1); push(eax);                              /* push eax */
            ii(0x1012_a27e, 6); lea(eax, memd[ss, ebp - 0xa4]);         /* lea eax, [ebp-0xa4] */
            ii(0x1012_a284, 1); push(eax);                              /* push eax */
            ii(0x1012_a285, 5); call(Definitions.sys_sprintf, 0x3_bc77); /* call 0x10165f01 */
            ii(0x1012_a28a, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1012_a28d, 6); lea(edx, memd[ss, ebp - 0xa4]);         /* lea edx, [ebp-0xa4] */
            ii(0x1012_a293, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_a296, 5); call(Definitions.sys_strcat, 0x3_bc96); /* call 0x10165f31 */
            ii(0x1012_a29b, 4); mov(memb[ss, ebp - 0x14], 0x1);         /* mov byte [ebp-0x14], 0x1 */
            ii(0x1012_a29f, 2); jmp(0x1012_a2a5, 0x4); goto l_0x1012_a2a5; /* jmp 0x1012a2a5 */
        l_0x1012_a2a1:
            ii(0x1012_a2a1, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
        l_0x1012_a2a5:
            ii(0x1012_a2a5, 3); mov(al, memb[ss, ebp - 0x14]);          /* mov al, [ebp-0x14] */
            ii(0x1012_a2a8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_a2aa, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_a2ab, 1); pop(edi);                               /* pop edi */
            ii(0x1012_a2ac, 1); pop(esi);                               /* pop esi */
            ii(0x1012_a2ad, 1); ret();                                  /* ret */
        }
    }
}
