using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_2590-1cf970cf")]
        public void Method_1014_2590()
        {
            ii(0x1014_2590, 5); push(0x40);                             /* push 0x40 */
            ii(0x1014_2595, 5); call(Definitions.sys_check_available_stack_size, 0x2_37b8); /* call 0x10165d52 */
            ii(0x1014_259a, 1); push(esi);                              /* push esi */
            ii(0x1014_259b, 1); push(edi);                              /* push edi */
            ii(0x1014_259c, 1); push(ebp);                              /* push ebp */
            ii(0x1014_259d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_259f, 6); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x1014_25a5, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_25a8, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1014_25ab, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x1014_25ae, 3); mov(memd[ss, ebp - 4], ecx);            /* mov [ebp-0x4], ecx */
            ii(0x1014_25b1, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x1014_25b5, 5); mov(edx, 0x10);                         /* mov edx, 0x10 */
            ii(0x1014_25ba, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_25bd, 5); and(eax, 0x1f);                         /* and eax, 0x1f */
            ii(0x1014_25c2, 1); cwde();                                 /* cwde */
            ii(0x1014_25c3, 5); call(Definitions.my_min, -0xb_8e44);    /* call 0x10089784 */
            ii(0x1014_25c8, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1014_25cb, 7); test(memd[ss, ebp - 4], 0x40);          /* test dword [ebp-0x4], 0x40 */
            ii(0x1014_25d2, 2); if(jz(0x1014_25ec, 0x18)) goto l_0x1014_25ec; /* jz 0x101425ec */
            ii(0x1014_25d4, 5); mov(eax, memd[ds, 0x101c_70c4]);        /* mov eax, [0x101c70c4] */
            ii(0x1014_25d9, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1014_25dc, 7); mov(memd[ss, ebp - 0x18], 0x1bc);       /* mov dword [ebp-0x18], 0x1bc */
            ii(0x1014_25e3, 7); mov(memd[ss, ebp - 0x1c], 0x1ed);       /* mov dword [ebp-0x1c], 0x1ed */
            ii(0x1014_25ea, 2); jmp(0x1014_2623, 0x37); goto l_0x1014_2623; /* jmp 0x10142623 */
        l_0x1014_25ec:
            ii(0x1014_25ec, 7); test(memd[ss, ebp - 4], 0x20);          /* test dword [ebp-0x4], 0x20 */
            ii(0x1014_25f3, 2); if(jz(0x1014_260d, 0x18)) goto l_0x1014_260d; /* jz 0x1014260d */
            ii(0x1014_25f5, 5); mov(eax, memd[ds, 0x101c_70c8]);        /* mov eax, [0x101c70c8] */
            ii(0x1014_25fa, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1014_25fd, 7); mov(memd[ss, ebp - 0x18], 0x1ab);       /* mov dword [ebp-0x18], 0x1ab */
            ii(0x1014_2604, 7); mov(memd[ss, ebp - 0x1c], 0x1dd);       /* mov dword [ebp-0x1c], 0x1dd */
            ii(0x1014_260b, 2); jmp(0x1014_2623, 0x16); goto l_0x1014_2623; /* jmp 0x10142623 */
        l_0x1014_260d:
            ii(0x1014_260d, 5); mov(eax, memd[ds, 0x101c_70c0]);        /* mov eax, [0x101c70c0] */
            ii(0x1014_2612, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1014_2615, 7); mov(memd[ss, ebp - 0x18], 0x19a);       /* mov dword [ebp-0x18], 0x19a */
            ii(0x1014_261c, 7); mov(memd[ss, ebp - 0x1c], 0x1cd);       /* mov dword [ebp-0x1c], 0x1cd */
        l_0x1014_2623:
            ii(0x1014_2623, 7); cmp(memd[ds, 0x101c_38c0], 0x10);       /* cmp dword [0x101c38c0], 0x10 */
            ii(0x1014_262a, 2); if(jle(0x1014_265b, 0x2f)) goto l_0x1014_265b; /* jle 0x1014265b */
            ii(0x1014_262c, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1014_262f, 3); add(eax, memd[ss, ebp - 0x18]);         /* add eax, [ebp-0x18] */
            ii(0x1014_2632, 1); cwde();                                 /* cwde */
            ii(0x1014_2633, 5); call(Definitions.my_get_res_data_by_id, -0xe660); /* call 0x10133fd8 */
            ii(0x1014_2638, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1014_263b, 7); cmp(memd[ds, 0x101c_38c0], 0x40);       /* cmp dword [0x101c38c0], 0x40 */
            ii(0x1014_2642, 2); if(jz(0x1014_2659, 0x15)) goto l_0x1014_2659; /* jz 0x10142659 */
            ii(0x1014_2644, 6); mov(edx, memd[ds, 0x101c_38c4]);        /* mov edx, [0x101c38c4] */
            ii(0x1014_264a, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1014_264d, 5); call(0x100e_8f38, -0x5_971a);           /* call 0x100e8f38 */
            ii(0x1014_2652, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1014_2655, 4); mov(memb[ss, ebp - 0x14], 1);           /* mov byte [ebp-0x14], 0x1 */
        l_0x1014_2659:
            ii(0x1014_2659, 2); jmp(0x1014_26ab, 0x50); goto l_0x1014_26ab; /* jmp 0x101426ab */
        l_0x1014_265b:
            ii(0x1014_265b, 4); movsx(eax, memw[ss, ebp - 0x20]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1014_265f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_2661, 6); if(jz(0x1014_2718, 0xb1)) goto l_0x1014_2718; /* jz 0x10142718 */
            ii(0x1014_2667, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1014_266a, 3); add(eax, memd[ss, ebp - 0x1c]);         /* add eax, [ebp-0x1c] */
            ii(0x1014_266d, 1); dec(eax);                               /* dec eax */
            ii(0x1014_266e, 1); cwde();                                 /* cwde */
            ii(0x1014_266f, 5); call(Definitions.my_get_res_data_by_id, -0xe69c); /* call 0x10133fd8 */
            ii(0x1014_2674, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1014_2677, 7); cmp(memd[ds, 0x101c_38c0], 0x10);       /* cmp dword [0x101c38c0], 0x10 */
            ii(0x1014_267e, 2); if(jz(0x1014_26ab, 0x2b)) goto l_0x1014_26ab; /* jz 0x101426ab */
            ii(0x1014_2680, 5); mov(eax, memd[ds, 0x101c_38c4]);        /* mov eax, [0x101c38c4] */
            ii(0x1014_2685, 6); mov(edx, memd[ds, 0x101c_38c4]);        /* mov edx, [0x101c38c4] */
            ii(0x1014_268b, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1014_268e, 3); shl(edx, 2);                            /* shl edx, 0x2 */
            ii(0x1014_2691, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x1014_2693, 3); sar(eax, 2);                            /* sar eax, 0x2 */
            ii(0x1014_2696, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1014_2699, 3); mov(edx, memd[ss, ebp - 0x2c]);         /* mov edx, [ebp-0x2c] */
            ii(0x1014_269c, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1014_269f, 5); call(0x100e_8f38, -0x5_976c);           /* call 0x100e8f38 */
            ii(0x1014_26a4, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1014_26a7, 4); mov(memb[ss, ebp - 0x14], 1);           /* mov byte [ebp-0x14], 0x1 */
        l_0x1014_26ab:
            ii(0x1014_26ab, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_26ae, 1); push(eax);                              /* push eax */
            ii(0x1014_26af, 5); mov(ecx, 1);                            /* mov ecx, 0x1 */
            ii(0x1014_26b4, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_26b7, 3); shl(eax, 6);                            /* shl eax, 0x6 */
            ii(0x1014_26ba, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1014_26bd, 3); shl(eax, 0x10);                         /* shl eax, 0x10 */
            ii(0x1014_26c0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_26c2, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1014_26c4, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1014_26c7, 6); idiv(memd[ds, 0x101c_38c4]);            /* idiv dword [0x101c38c4] */
            ii(0x1014_26cd, 6); mov(edx, memd[ds, 0x101c_38fc]);        /* mov edx, [0x101c38fc] */
            ii(0x1014_26d3, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_26d6, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1014_26d8, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1014_26db, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_26de, 3); shl(eax, 6);                            /* shl eax, 0x6 */
            ii(0x1014_26e1, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1014_26e4, 3); shl(eax, 0x10);                         /* shl eax, 0x10 */
            ii(0x1014_26e7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_26e9, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1014_26eb, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1014_26ee, 6); idiv(memd[ds, 0x101c_38c4]);            /* idiv dword [0x101c38c4] */
            ii(0x1014_26f4, 6); mov(edx, memd[ds, 0x101c_38fa]);        /* mov edx, [0x101c38fa] */
            ii(0x1014_26fa, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_26fd, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1014_26ff, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1014_2702, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1014_2705, 5); call(0x100e_8d1e, -0x5_99ec);           /* call 0x100e8d1e */
            ii(0x1014_270a, 4); cmp(memb[ss, ebp - 0x14], 0);           /* cmp byte [ebp-0x14], 0x0 */
            ii(0x1014_270e, 2); if(jz(0x1014_2718, 8)) goto l_0x1014_2718; /* jz 0x10142718 */
            ii(0x1014_2710, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1014_2713, 5); call(Definitions.sys_free, 0x2_89a9);   /* call 0x1016b0c1 */
        l_0x1014_2718:
            ii(0x1014_2718, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_271a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_271b, 1); pop(edi);                               /* pop edi */
            ii(0x1014_271c, 1); pop(esi);                               /* pop esi */
            ii(0x1014_271d, 1); ret();                                  /* ret */
        }
    }
}
