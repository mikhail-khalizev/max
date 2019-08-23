using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_a1f0-b30731e6")]
        public void Method_1011_a1f0()
        {
            ii(0x1011_a1f0, 5); push(0x3c);                             /* push 0x3c */
            ii(0x1011_a1f5, 5); call(Definitions.sys_check_available_stack_size, 0x4_bb58); /* call 0x10165d52 */
            ii(0x1011_a1fa, 1); push(ebx);                              /* push ebx */
            ii(0x1011_a1fb, 1); push(ecx);                              /* push ecx */
            ii(0x1011_a1fc, 1); push(esi);                              /* push esi */
            ii(0x1011_a1fd, 1); push(edi);                              /* push edi */
            ii(0x1011_a1fe, 1); push(ebp);                              /* push ebp */
            ii(0x1011_a1ff, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_a201, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1011_a207, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_a20a, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1011_a20d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_a210, 4); mov(ax, memw[ds, eax + 0x1a]);          /* mov ax, [eax+0x1a] */
            ii(0x1011_a214, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1011_a217, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_a21a, 4); mov(ax, memw[ds, eax + 0x1c]);          /* mov ax, [eax+0x1c] */
            ii(0x1011_a21e, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1011_a221, 7); mov(memd[ss, ebp - 0x14], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x1011_a228, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_a22b, 4); mov(ax, memw[ds, eax + 0x16]);          /* mov ax, [eax+0x16] */
            ii(0x1011_a22f, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1011_a232, 2); jmp(0x1011_a23a, 0x6); goto l_0x1011_a23a; /* jmp 0x1011a23a */
        l_0x1011_a234:
            ii(0x1011_a234, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_a237, 3); inc(memd[ss, ebp - 0xc]);               /* inc dword [ebp-0xc] */
        l_0x1011_a23a:
            ii(0x1011_a23a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_a23d, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1011_a240, 5); call(0x100b_82bc, -0x6_1f89);           /* call 0x100b82bc */
            ii(0x1011_a245, 4); cmp(ax, memw[ss, ebp - 0xc]);           /* cmp ax, [ebp-0xc] */
            ii(0x1011_a249, 6); if(jle(0x1011_a31f, 0xd0)) goto l_0x1011_a31f; /* jle 0x1011a31f */
            ii(0x1011_a24f, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1011_a253, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_a256, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1011_a259, 5); call(0x100b_827c, -0x6_1fe2);           /* call 0x100b827c */
            ii(0x1011_a25e, 4); movsx(ebx, memb[ds, eax + 0x1]);        /* movsx ebx, byte [eax+0x1] */
            ii(0x1011_a262, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1011_a266, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_a269, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1011_a26c, 5); call(0x100b_827c, -0x6_1ff5);           /* call 0x100b827c */
            ii(0x1011_a271, 3); movsx(eax, memb[ds, eax]);              /* movsx eax, byte [eax] */
            ii(0x1011_a274, 2); or(eax, ebx);                           /* or eax, ebx */
            ii(0x1011_a276, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_a278, 6); if(jz(0x1011_a31a, 0x9c)) goto l_0x1011_a31a; /* jz 0x1011a31a */
            ii(0x1011_a27e, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1011_a282, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_a285, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1011_a288, 5); call(0x100b_827c, -0x6_2011);           /* call 0x100b827c */
            ii(0x1011_a28d, 4); movsx(ax, memb[ds, eax]);               /* movsx ax, byte [eax] */
            ii(0x1011_a291, 3); add(memd[ss, ebp - 0x1c], eax);         /* add [ebp-0x1c], eax */
            ii(0x1011_a294, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1011_a298, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_a29b, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1011_a29e, 5); call(0x100b_827c, -0x6_2027);           /* call 0x100b827c */
            ii(0x1011_a2a3, 5); movsx(ax, memb[ds, eax + 0x1]);         /* movsx ax, byte [eax+0x1] */
            ii(0x1011_a2a8, 3); add(memd[ss, ebp - 0x18], eax);         /* add [ebp-0x18], eax */
            ii(0x1011_a2ab, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_a2ad, 1); push(eax);                              /* push eax */
            ii(0x1011_a2ae, 4); movsx(ecx, memw[ss, ebp - 0x18]);       /* movsx ecx, word [ebp-0x18] */
            ii(0x1011_a2b2, 4); movsx(ebx, memw[ss, ebp - 0x1c]);       /* movsx ebx, word [ebp-0x1c] */
            ii(0x1011_a2b6, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_a2b9, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1011_a2bc, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1011_a2be, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_a2c1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_a2c4, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x1011_a2c7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_a2ca, 5); call(0x1007_02b9, -0xa_a016);           /* call 0x100702b9 */
            ii(0x1011_a2cf, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_a2d2, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1011_a2d6, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_a2d9, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1011_a2dc, 5); call(0x100b_827c, -0x6_2065);           /* call 0x100b827c */
            ii(0x1011_a2e1, 3); movsx(eax, memb[ds, eax]);              /* movsx eax, byte [eax] */
            ii(0x1011_a2e4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_a2e6, 2); if(jz(0x1011_a2ff, 0x17)) goto l_0x1011_a2ff; /* jz 0x1011a2ff */
            ii(0x1011_a2e8, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1011_a2ec, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_a2ef, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1011_a2f2, 5); call(0x100b_827c, -0x6_207b);           /* call 0x100b827c */
            ii(0x1011_a2f7, 4); movsx(eax, memb[ds, eax + 0x1]);        /* movsx eax, byte [eax+0x1] */
            ii(0x1011_a2fb, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_a2fd, 2); if(jnz(0x1011_a301, 0x2)) goto l_0x1011_a301; /* jnz 0x1011a301 */
        l_0x1011_a2ff:
            ii(0x1011_a2ff, 2); jmp(0x1011_a314, 0x13); goto l_0x1011_a314; /* jmp 0x1011a314 */
        l_0x1011_a301:
            ii(0x1011_a301, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1011_a305, 3); lea(edx, memd[ds, edx + edx * 2]);      /* lea edx, [edx+edx*2] */
            ii(0x1011_a308, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_a30a, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1011_a30d, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1011_a30f, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1011_a311, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
        l_0x1011_a314:
            ii(0x1011_a314, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_a317, 3); add(memd[ss, ebp - 0x14], eax);         /* add [ebp-0x14], eax */
        l_0x1011_a31a:
            ii(0x1011_a31a, 5); jmp(0x1011_a234, -0xeb); goto l_0x1011_a234; /* jmp 0x1011a234 */
        l_0x1011_a31f:
            ii(0x1011_a31f, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1011_a322, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1011_a325, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1011_a328, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_a32a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_a32b, 1); pop(edi);                               /* pop edi */
            ii(0x1011_a32c, 1); pop(esi);                               /* pop esi */
            ii(0x1011_a32d, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_a32e, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_a32f, 1); ret();                                  /* ret */
        }
    }
}
