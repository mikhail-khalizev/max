using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_7c9d-49f74479")]
        public void Method_1007_7c9d()
        {
            ii(0x1007_7c9d, 5); push(0x28);                             /* push 0x28 */
            ii(0x1007_7ca2, 5); call(Definitions.sys_check_available_stack_size, 0xe_e0ab); /* call 0x10165d52 */
            ii(0x1007_7ca7, 1); push(ebx);                              /* push ebx */
            ii(0x1007_7ca8, 1); push(ecx);                              /* push ecx */
            ii(0x1007_7ca9, 1); push(esi);                              /* push esi */
            ii(0x1007_7caa, 1); push(edi);                              /* push edi */
            ii(0x1007_7cab, 1); push(ebp);                              /* push ebp */
            ii(0x1007_7cac, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_7cae, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1007_7cb4, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_7cb7, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_7cba, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_7cbd, 5); cmp(memw[ds, eax + 0x8], 0x42);         /* cmp word [eax+0x8], 0x42 */
            ii(0x1007_7cc2, 6); if(jnz(0x1007_7d33, 0x6b)) goto l_0x1007_7d33; /* jnz 0x10077d33 */
            ii(0x1007_7cc8, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_7ccb, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_7cce, 5); call(0x1007_78a5, -0x42e);              /* call 0x100778a5 */
            ii(0x1007_7cd3, 2); test(al, al);                           /* test al, al */
            ii(0x1007_7cd5, 2); if(jz(0x1007_7cf5, 0x1e)) goto l_0x1007_7cf5; /* jz 0x10077cf5 */
            ii(0x1007_7cd7, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_7cda, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x1007_7cdd, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1007_7ce0, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_7ce3, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x1007_7ce6, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1007_7ce9, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_7cec, 5); call(0x100a_30a2, 0x2_b3b1);            /* call 0x100a30a2 */
            ii(0x1007_7cf1, 2); test(al, al);                           /* test al, al */
            ii(0x1007_7cf3, 2); if(jnz(0x1007_7cf7, 0x2)) goto l_0x1007_7cf7; /* jnz 0x10077cf7 */
        l_0x1007_7cf5:
            ii(0x1007_7cf5, 2); jmp(0x1007_7d16, 0x1f); goto l_0x1007_7d16; /* jmp 0x10077d16 */
        l_0x1007_7cf7:
            ii(0x1007_7cf7, 5); mov(ebx, 0x19);                         /* mov ebx, 0x19 */
            ii(0x1007_7cfc, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_7cff, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_7d02, 5); call(0x1015_c75a, 0xe_4a53);            /* call 0x1015c75a */
            ii(0x1007_7d07, 1); cwde();                                 /* cwde */
            ii(0x1007_7d08, 3); cmp(eax, 0x55);                         /* cmp eax, 0x55 */
            ii(0x1007_7d0b, 2); if(jle(0x1007_7d16, 0x9)) goto l_0x1007_7d16; /* jle 0x10077d16 */
            ii(0x1007_7d0d, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
            ii(0x1007_7d11, 5); jmp(0x1007_7d80, 0x6a); goto l_0x1007_7d80; /* jmp 0x10077d80 */
        l_0x1007_7d16:
            ii(0x1007_7d16, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_7d19, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1007_7d1c, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1007_7d1e, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1007_7d21, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_7d24, 5); call(0x1007_6074, -0x1cb5);             /* call 0x10076074 */
            ii(0x1007_7d29, 2); test(al, al);                           /* test al, al */
            ii(0x1007_7d2b, 2); if(jnz(0x1007_7d33, 0x6)) goto l_0x1007_7d33; /* jnz 0x10077d33 */
            ii(0x1007_7d2d, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x1007_7d31, 2); jmp(0x1007_7d80, 0x4d); goto l_0x1007_7d80; /* jmp 0x10077d80 */
        l_0x1007_7d33:
            ii(0x1007_7d33, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_7d36, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_7d39, 5); call(0x1007_4bde, -0x3160);             /* call 0x10074bde */
            ii(0x1007_7d3e, 2); test(al, al);                           /* test al, al */
            ii(0x1007_7d40, 2); if(jz(0x1007_7d6e, 0x2c)) goto l_0x1007_7d6e; /* jz 0x10077d6e */
            ii(0x1007_7d42, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_7d45, 5); call(0x1007_623c, -0x1b0e);             /* call 0x1007623c */
            ii(0x1007_7d4a, 3); mov(ecx, memd[ds, eax + 0x10]);         /* mov ecx, [eax+0x10] */
            ii(0x1007_7d4d, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1007_7d50, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_7d53, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x1007_7d56, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1007_7d59, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_7d5c, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x1007_7d5f, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1007_7d62, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_7d65, 5); call(0x1007_0d68, -0x7002);             /* call 0x10070d68 */
            ii(0x1007_7d6a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_7d6c, 2); if(jnz(0x1007_7d70, 0x2)) goto l_0x1007_7d70; /* jnz 0x10077d70 */
        l_0x1007_7d6e:
            ii(0x1007_7d6e, 2); jmp(0x1007_7d76, 0x6); goto l_0x1007_7d76; /* jmp 0x10077d76 */
        l_0x1007_7d70:
            ii(0x1007_7d70, 4); mov(memb[ss, ebp - 0x10], 0x1);         /* mov byte [ebp-0x10], 0x1 */
            ii(0x1007_7d74, 2); jmp(0x1007_7d7a, 0x4); goto l_0x1007_7d7a; /* jmp 0x10077d7a */
        l_0x1007_7d76:
            ii(0x1007_7d76, 4); mov(memb[ss, ebp - 0x10], 0);           /* mov byte [ebp-0x10], 0x0 */
        l_0x1007_7d7a:
            ii(0x1007_7d7a, 3); mov(al, memb[ss, ebp - 0x10]);          /* mov al, [ebp-0x10] */
            ii(0x1007_7d7d, 3); mov(memb[ss, ebp - 0xc], al);           /* mov [ebp-0xc], al */
        l_0x1007_7d80:
            ii(0x1007_7d80, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1007_7d83, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_7d85, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_7d86, 1); pop(edi);                               /* pop edi */
            ii(0x1007_7d87, 1); pop(esi);                               /* pop esi */
            ii(0x1007_7d88, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_7d89, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_7d8a, 1); ret();                                  /* ret */
        }
    }
}
