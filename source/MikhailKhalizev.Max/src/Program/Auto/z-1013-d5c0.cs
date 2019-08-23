using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_d5c0-88c4378f")]
        public void Method_1013_d5c0()
        {
            ii(0x1013_d5c0, 5); push(0x80);                             /* push 0x80 */
            ii(0x1013_d5c5, 5); call(Definitions.sys_check_available_stack_size, 0x2_8788); /* call 0x10165d52 */
            ii(0x1013_d5ca, 1); push(esi);                              /* push esi */
            ii(0x1013_d5cb, 1); push(edi);                              /* push edi */
            ii(0x1013_d5cc, 1); push(ebp);                              /* push ebp */
            ii(0x1013_d5cd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_d5cf, 6); sub(esp, 0x70);                         /* sub esp, 0x70 */
            ii(0x1013_d5d5, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_d5d8, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1013_d5db, 3); mov(memb[ss, ebp - 0x8], bl);           /* mov [ebp-0x8], bl */
            ii(0x1013_d5de, 3); mov(memb[ss, ebp - 0x4], cl);           /* mov [ebp-0x4], cl */
            ii(0x1013_d5e1, 4); movsx(eax, memb[ss, ebp - 0x8]);        /* movsx eax, byte [ebp-0x8] */
            ii(0x1013_d5e5, 6); mov(al, memb[ds, eax + 0x101b_d538]);   /* mov al, [eax+0x101bd538] */
            ii(0x1013_d5eb, 3); mov(memb[ss, ebp - 0x18], al);          /* mov [ebp-0x18], al */
            ii(0x1013_d5ee, 4); cmp(memb[ss, ebp - 0x4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1013_d5f2, 2); if(jz(0x1013_d5f8, 0x4)) goto l_0x1013_d5f8; /* jz 0x1013d5f8 */
            ii(0x1013_d5f4, 4); mov(memb[ss, ebp - 0x18], 0x1);         /* mov byte [ebp-0x18], 0x1 */
        l_0x1013_d5f8:
            ii(0x1013_d5f8, 4); test(memb[ss, ebp - 0x18], 0x2);        /* test byte [ebp-0x18], 0x2 */
            ii(0x1013_d5fc, 2); if(jz(0x1013_d621, 0x23)) goto l_0x1013_d621; /* jz 0x1013d621 */
            ii(0x1013_d5fe, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_d601, 3); mov(al, memb[ds, eax + 0x2c]);          /* mov al, [eax+0x2c] */
            ii(0x1013_d604, 3); mov(memb[ss, ebp - 0x1c], al);          /* mov [ebp-0x1c], al */
            ii(0x1013_d607, 3); mov(al, memb[ss, ebp - 0x8]);           /* mov al, [ebp-0x8] */
            ii(0x1013_d60a, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1013_d60d, 3); mov(memb[ds, edx + 0x2c], al);          /* mov [edx+0x2c], al */
            ii(0x1013_d610, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_d612, 3); mov(dl, memb[ss, ebp - 0x1c]);          /* mov dl, [ebp-0x1c] */
            ii(0x1013_d615, 4); movsx(eax, memb[ss, ebp - 0x8]);        /* movsx eax, byte [ebp-0x8] */
            ii(0x1013_d619, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1013_d61b, 6); if(jz(0x1013_d90a, 0x2e9)) goto l_0x1013_d90a; /* jz 0x1013d90a */
        l_0x1013_d621:
            ii(0x1013_d621, 4); cmp(memb[ss, ebp - 0x8], 0);            /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1013_d625, 2); if(jnz(0x1013_d637, 0x10)) goto l_0x1013_d637; /* jnz 0x1013d637 */
            ii(0x1013_d627, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1013_d62a, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_d62d, 5); call(0x1013_d4da, -0x158);              /* call 0x1013d4da */
            ii(0x1013_d632, 5); jmp(0x1013_d90a, 0x2d3); goto l_0x1013_d90a; /* jmp 0x1013d90a */
        l_0x1013_d637:
            ii(0x1013_d637, 5); mov(eax, 0x3a);                         /* mov eax, 0x3a */
            ii(0x1013_d63c, 5); call(0x1007_5fdc, -0xc_7665);           /* call 0x10075fdc */
            ii(0x1013_d641, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_d643, 2); if(jnz(0x1013_d651, 0xc)) goto l_0x1013_d651; /* jnz 0x1013d651 */
            ii(0x1013_d645, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_d648, 7); cmp(memd[ds, eax + 0x1c], 0xffff);      /* cmp dword [eax+0x1c], 0xffff */
            ii(0x1013_d64f, 2); if(jnz(0x1013_d656, 0x5)) goto l_0x1013_d656; /* jnz 0x1013d656 */
        l_0x1013_d651:
            ii(0x1013_d651, 5); jmp(0x1013_d90a, 0x2b4); goto l_0x1013_d90a; /* jmp 0x1013d90a */
        l_0x1013_d656:
            ii(0x1013_d656, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_d659, 3); mov(eax, memd[ds, eax + 0xe]);          /* mov eax, [eax+0xe] */
            ii(0x1013_d65c, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1013_d65e, 3); mov(memb[ss, ebp - 0x14], al);          /* mov [ebp-0x14], al */
            ii(0x1013_d661, 4); mov(memb[ss, ebp - 0x20], 0);           /* mov byte [ebp-0x20], 0x0 */
            ii(0x1013_d665, 2); jmp(0x1013_d66d, 0x6); goto l_0x1013_d66d; /* jmp 0x1013d66d */
        l_0x1013_d667:
            ii(0x1013_d667, 3); mov(al, memb[ss, ebp - 0x20]);          /* mov al, [ebp-0x20] */
            ii(0x1013_d66a, 3); inc(memb[ss, ebp - 0x20]);              /* inc byte [ebp-0x20] */
        l_0x1013_d66d:
            ii(0x1013_d66d, 3); mov(al, memb[ss, ebp - 0x20]);          /* mov al, [ebp-0x20] */
            ii(0x1013_d670, 3); cmp(al, memb[ss, ebp - 0x14]);          /* cmp al, [ebp-0x14] */
            ii(0x1013_d673, 2); if(jz(0x1013_d68d, 0x18)) goto l_0x1013_d68d; /* jz 0x1013d68d */
            ii(0x1013_d675, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_d678, 3); mov(edx, memd[ds, eax + 0xe]);          /* mov edx, [eax+0xe] */
            ii(0x1013_d67b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_d67d, 3); mov(al, memb[ss, ebp - 0x20]);          /* mov al, [ebp-0x20] */
            ii(0x1013_d680, 3); lea(eax, memd[ds, eax + eax * 2]);      /* lea eax, [eax+eax*2] */
            ii(0x1013_d683, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_d685, 3); mov(al, memb[ds, eax + 0x1]);           /* mov al, [eax+0x1] */
            ii(0x1013_d688, 3); cmp(al, memb[ss, ebp - 0x8]);           /* cmp al, [ebp-0x8] */
            ii(0x1013_d68b, 2); if(jnz(0x1013_d667, -0x26)) goto l_0x1013_d667; /* jnz 0x1013d667 */
        l_0x1013_d68d:
            ii(0x1013_d68d, 3); mov(al, memb[ss, ebp - 0x20]);          /* mov al, [ebp-0x20] */
            ii(0x1013_d690, 3); cmp(al, memb[ss, ebp - 0x14]);          /* cmp al, [ebp-0x14] */
            ii(0x1013_d693, 2); if(jnz(0x1013_d6c8, 0x33)) goto l_0x1013_d6c8; /* jnz 0x1013d6c8 */
            ii(0x1013_d695, 4); movsx(eax, memb[ss, ebp - 0x8]);        /* movsx eax, byte [ebp-0x8] */
            ii(0x1013_d699, 6); mov(al, memb[ds, eax + 0x101b_d538]);   /* mov al, [eax+0x101bd538] */
            ii(0x1013_d69f, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_d6a4, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1013_d6a7, 2); if(jz(0x1013_d6b9, 0x10)) goto l_0x1013_d6b9; /* jz 0x1013d6b9 */
            ii(0x1013_d6a9, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1013_d6ac, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_d6af, 5); call(0x1013_d4da, -0x1da);              /* call 0x1013d4da */
            ii(0x1013_d6b4, 5); jmp(0x1013_d90a, 0x251); goto l_0x1013_d90a; /* jmp 0x1013d90a */
        l_0x1013_d6b9:
            ii(0x1013_d6b9, 5); movsx(ax, memb[ss, ebp - 0x8]);         /* movsx ax, byte [ebp-0x8] */
            ii(0x1013_d6be, 5); add(eax, 0x51c);                        /* add eax, 0x51c */
            ii(0x1013_d6c3, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1013_d6c6, 2); jmp(0x1013_d6df, 0x17); goto l_0x1013_d6df; /* jmp 0x1013d6df */
        l_0x1013_d6c8:
            ii(0x1013_d6c8, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_d6cb, 3); mov(edx, memd[ds, eax + 0xe]);          /* mov edx, [eax+0xe] */
            ii(0x1013_d6ce, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_d6d0, 3); mov(al, memb[ss, ebp - 0x20]);          /* mov al, [ebp-0x20] */
            ii(0x1013_d6d3, 3); lea(eax, memd[ds, eax + eax * 2]);      /* lea eax, [eax+eax*2] */
            ii(0x1013_d6d6, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_d6d8, 4); mov(ax, memw[ds, eax + 0x2]);           /* mov ax, [eax+0x2] */
            ii(0x1013_d6dc, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
        l_0x1013_d6df:
            ii(0x1013_d6df, 4); cmp(memb[ss, ebp - 0x8], 0x1);          /* cmp byte [ebp-0x8], 0x1 */
            ii(0x1013_d6e3, 2); if(jl(0x1013_d6eb, 0x6)) goto l_0x1013_d6eb; /* jl 0x1013d6eb */
            ii(0x1013_d6e5, 4); cmp(memb[ss, ebp - 0x8], 0x5);          /* cmp byte [ebp-0x8], 0x5 */
            ii(0x1013_d6e9, 2); if(jle(0x1013_d6ed, 0x2)) goto l_0x1013_d6ed; /* jle 0x1013d6ed */
        l_0x1013_d6eb:
            ii(0x1013_d6eb, 2); jmp(0x1013_d6ff, 0x12); goto l_0x1013_d6ff; /* jmp 0x1013d6ff */
        l_0x1013_d6ed:
            ii(0x1013_d6ed, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_d6f0, 3); mov(eax, memd[ds, eax + 0x12]);         /* mov eax, [eax+0x12] */
            ii(0x1013_d6f3, 5); and(eax, 0x180);                        /* and eax, 0x180 */
            ii(0x1013_d6f8, 5); cmp(eax, 0x180);                        /* cmp eax, 0x180 */
            ii(0x1013_d6fd, 2); if(jz(0x1013_d701, 0x2)) goto l_0x1013_d701; /* jz 0x1013d701 */
        l_0x1013_d6ff:
            ii(0x1013_d6ff, 2); jmp(0x1013_d70f, 0xe); goto l_0x1013_d70f; /* jmp 0x1013d70f */
        l_0x1013_d701:
            ii(0x1013_d701, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_d704, 3); mov(eax, memd[ds, eax + 0x31]);         /* mov eax, [eax+0x31] */
            ii(0x1013_d707, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_d70a, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1013_d70d, 2); if(jz(0x1013_d711, 0x2)) goto l_0x1013_d711; /* jz 0x1013d711 */
        l_0x1013_d70f:
            ii(0x1013_d70f, 2); jmp(0x1013_d714, 0x3); goto l_0x1013_d714; /* jmp 0x1013d714 */
        l_0x1013_d711:
            ii(0x1013_d711, 3); inc(memd[ss, ebp - 0x24]);              /* inc dword [ebp-0x24] */
        l_0x1013_d714:
            ii(0x1013_d714, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1013_d717, 6); sub(eax, 0x51d);                        /* sub eax, 0x51d */
            ii(0x1013_d71d, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1013_d720, 4); movsx(edx, memw[ss, ebp - 0x28]);       /* movsx edx, word [ebp-0x28] */
            ii(0x1013_d724, 3); lea(edx, memd[ds, edx + edx * 4]);      /* lea edx, [edx+edx*4] */
            ii(0x1013_d727, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_d72a, 6); mov(eax, memd[ds, eax + 0xdad]);        /* mov eax, [eax+0xdad] */
            ii(0x1013_d730, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_d732, 3); mov(al, memb[ds, eax + 0x4]);           /* mov al, [eax+0x4] */
            ii(0x1013_d735, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_d73a, 5); cmp(eax, 0xff);                         /* cmp eax, 0xff */
            ii(0x1013_d73f, 2); if(jnz(0x1013_d7a5, 0x64)) goto l_0x1013_d7a5; /* jnz 0x1013d7a5 */
            ii(0x1013_d741, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1013_d745, 3); lea(edx, memd[ds, eax + eax * 4]);      /* lea edx, [eax+eax*4] */
            ii(0x1013_d748, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_d74b, 6); mov(eax, memd[ds, eax + 0xdad]);        /* mov eax, [eax+0xdad] */
            ii(0x1013_d751, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_d753, 4); mov(memb[ds, eax + 0x4], 0x1);          /* mov byte [eax+0x4], 0x1 */
            ii(0x1013_d757, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1013_d75b, 5); call(Definitions.my_get_res_data_by_id_malloc, -0x9575); /* call 0x101341eb */
            ii(0x1013_d760, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1013_d763, 4); cmp(memd[ss, ebp - 0x2c], 0);           /* cmp dword [ebp-0x2c], 0x0 */
            ii(0x1013_d767, 2); if(jz(0x1013_d7a5, 0x3c)) goto l_0x1013_d7a5; /* jz 0x1013d7a5 */
            ii(0x1013_d769, 5); mov(edx, StringDefinitions.Rb8);        /* mov edx, 0x101acd38 */
            ii(0x1013_d76e, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x1013_d771, 5); call(Definitions.my_fopen, -0x4_e357);  /* call 0x100ef41f */
            ii(0x1013_d776, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x1013_d779, 4); cmp(memd[ss, ebp - 0x30], 0);           /* cmp dword [ebp-0x30], 0x0 */
            ii(0x1013_d77d, 2); if(jz(0x1013_d79d, 0x1e)) goto l_0x1013_d79d; /* jz 0x1013d79d */
            ii(0x1013_d77f, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1013_d783, 3); lea(edx, memd[ds, eax + eax * 4]);      /* lea edx, [eax+eax*4] */
            ii(0x1013_d786, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_d789, 6); mov(eax, memd[ds, eax + 0xdad]);        /* mov eax, [eax+0xdad] */
            ii(0x1013_d78f, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_d791, 4); mov(memb[ds, eax + 0x4], 0);            /* mov byte [eax+0x4], 0x0 */
            ii(0x1013_d795, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1013_d798, 5); call(Definitions.sys_fclose, 0x3_48cc); /* call 0x10172069 */
        l_0x1013_d79d:
            ii(0x1013_d79d, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x1013_d7a0, 5); call(Definitions.sys_delete, 0x2_87bf); /* call 0x10165f64 */
        l_0x1013_d7a5:
            ii(0x1013_d7a5, 4); movsx(edx, memw[ss, ebp - 0x28]);       /* movsx edx, word [ebp-0x28] */
            ii(0x1013_d7a9, 3); lea(edx, memd[ds, edx + edx * 4]);      /* lea edx, [edx+edx*4] */
            ii(0x1013_d7ac, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_d7af, 6); mov(eax, memd[ds, eax + 0xdad]);        /* mov eax, [eax+0xdad] */
            ii(0x1013_d7b5, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_d7b7, 3); mov(al, memb[ds, eax + 0x4]);           /* mov al, [eax+0x4] */
            ii(0x1013_d7ba, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_d7bf, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1013_d7c2, 2); if(jnz(0x1013_d7dd, 0x19)) goto l_0x1013_d7dd; /* jnz 0x1013d7dd */
            ii(0x1013_d7c4, 5); movsx(ax, memb[ss, ebp - 0x8]);         /* movsx ax, byte [ebp-0x8] */
            ii(0x1013_d7c9, 5); add(eax, 0x51c);                        /* add eax, 0x51c */
            ii(0x1013_d7ce, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1013_d7d1, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1013_d7d4, 6); sub(eax, 0x51d);                        /* sub eax, 0x51d */
            ii(0x1013_d7da, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
        l_0x1013_d7dd:
            ii(0x1013_d7dd, 4); test(memb[ss, ebp - 0x18], 0x2);        /* test byte [ebp-0x18], 0x2 */
            ii(0x1013_d7e1, 2); if(jz(0x1013_d7e9, 0x6)) goto l_0x1013_d7e9; /* jz 0x1013d7e9 */
            ii(0x1013_d7e3, 4); mov(memb[ss, ebp - 0x38], 0x1);         /* mov byte [ebp-0x38], 0x1 */
            ii(0x1013_d7e7, 2); jmp(0x1013_d7ed, 0x4); goto l_0x1013_d7ed; /* jmp 0x1013d7ed */
        l_0x1013_d7e9:
            ii(0x1013_d7e9, 4); mov(memb[ss, ebp - 0x38], 0);           /* mov byte [ebp-0x38], 0x0 */
        l_0x1013_d7ed:
            ii(0x1013_d7ed, 3); mov(al, memb[ss, ebp - 0x38]);          /* mov al, [ebp-0x38] */
            ii(0x1013_d7f0, 3); mov(memb[ss, ebp - 0x4a], al);          /* mov [ebp-0x4a], al */
            ii(0x1013_d7f3, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1013_d7f6, 4); mov(memw[ss, ebp - 0x54], ax);          /* mov [ebp-0x54], ax */
            ii(0x1013_d7fa, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_d7fd, 4); mov(ax, memw[ds, eax + 0x1a]);          /* mov ax, [eax+0x1a] */
            ii(0x1013_d801, 4); mov(memw[ss, ebp - 0x41], ax);          /* mov [ebp-0x41], ax */
            ii(0x1013_d805, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_d808, 4); mov(ax, memw[ds, eax + 0x1c]);          /* mov ax, [eax+0x1c] */
            ii(0x1013_d80c, 4); mov(memw[ss, ebp - 0x3f], ax);          /* mov [ebp-0x3f], ax */
            ii(0x1013_d810, 4); test(memb[ss, ebp - 0x18], 0x4);        /* test byte [ebp-0x18], 0x4 */
            ii(0x1013_d814, 2); if(jz(0x1013_d81f, 0x9)) goto l_0x1013_d81f; /* jz 0x1013d81f */
            ii(0x1013_d816, 7); mov(memd[ss, ebp - 0x58], 0xffff_ffff); /* mov dword [ebp-0x58], 0xffffffff */
            ii(0x1013_d81d, 2); jmp(0x1013_d826, 0x7); goto l_0x1013_d826; /* jmp 0x1013d826 */
        l_0x1013_d81f:
            ii(0x1013_d81f, 7); mov(memd[ss, ebp - 0x58], 0);           /* mov dword [ebp-0x58], 0x0 */
        l_0x1013_d826:
            ii(0x1013_d826, 3); mov(eax, memd[ss, ebp - 0x58]);         /* mov eax, [ebp-0x58] */
            ii(0x1013_d829, 3); mov(memd[ss, ebp - 0x45], eax);         /* mov [ebp-0x45], eax */
            ii(0x1013_d82c, 3); mov(al, memb[ss, ebp - 0x8]);           /* mov al, [ebp-0x8] */
            ii(0x1013_d82f, 3); mov(memb[ss, ebp - 0x3b], al);          /* mov [ebp-0x3b], al */
            ii(0x1013_d832, 6); mov(edx, memd[ds, 0x101c_38dc]);        /* mov edx, [0x101c38dc] */
            ii(0x1013_d838, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_d83b, 5); mov(eax, memd[ds, 0x101c_38d8]);        /* mov eax, [0x101c38d8] */
            ii(0x1013_d840, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_d843, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_d845, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1013_d847, 3); mov(memd[ss, ebp - 0x5c], eax);         /* mov [ebp-0x5c], eax */
            ii(0x1013_d84a, 6); mov(edx, memd[ds, 0x101c_38de]);        /* mov edx, [0x101c38de] */
            ii(0x1013_d850, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_d853, 5); mov(eax, memd[ds, 0x101c_38da]);        /* mov eax, [0x101c38da] */
            ii(0x1013_d858, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_d85b, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_d85d, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1013_d85f, 3); mov(memd[ss, ebp - 0x60], eax);         /* mov [ebp-0x60], eax */
            ii(0x1013_d862, 3); mov(eax, memd[ss, ebp - 0x41]);         /* mov eax, [ebp-0x41] */
            ii(0x1013_d865, 3); sub(eax, memd[ss, ebp - 0x5c]);         /* sub eax, [ebp-0x5c] */
            ii(0x1013_d868, 3); mov(memd[ss, ebp - 0x64], eax);         /* mov [ebp-0x64], eax */
            ii(0x1013_d86b, 4); movsx(eax, memw[ss, ebp - 0x64]);       /* movsx eax, word [ebp-0x64] */
            ii(0x1013_d86f, 5); call(/* sys */ 0x1016_5df8, 0x2_8584);  /* call 0x10165df8 */
            ii(0x1013_d874, 3); mov(memd[ss, ebp - 0x68], eax);         /* mov [ebp-0x68], eax */
            ii(0x1013_d877, 4); movsx(edx, memw[ss, ebp - 0x3f]);       /* movsx edx, word [ebp-0x3f] */
            ii(0x1013_d87b, 4); movsx(eax, memw[ss, ebp - 0x60]);       /* movsx eax, word [ebp-0x60] */
            ii(0x1013_d87f, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1013_d881, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_d883, 5); call(/* sys */ 0x1016_5df8, 0x2_8570);  /* call 0x10165df8 */
            ii(0x1013_d888, 3); mov(memd[ss, ebp - 0x6c], eax);         /* mov [ebp-0x6c], eax */
            ii(0x1013_d88b, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1013_d88f, 3); lea(edx, memd[ds, eax + eax * 4]);      /* lea edx, [eax+eax*4] */
            ii(0x1013_d892, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_d895, 6); mov(eax, memd[ds, eax + 0xdad]);        /* mov eax, [eax+0xdad] */
            ii(0x1013_d89b, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_d89d, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1013_d89f, 3); mov(memd[ss, ebp - 0x70], eax);         /* mov [ebp-0x70], eax */
            ii(0x1013_d8a2, 3); mov(eax, memd[ss, ebp - 0x70]);         /* mov eax, [ebp-0x70] */
            ii(0x1013_d8a5, 3); mov(memd[ss, ebp - 0x4e], eax);         /* mov [ebp-0x4e], eax */
            ii(0x1013_d8a8, 4); movsx(edx, memw[ss, ebp - 0x6c]);       /* movsx edx, word [ebp-0x6c] */
            ii(0x1013_d8ac, 4); movsx(eax, memw[ss, ebp - 0x68]);       /* movsx eax, word [ebp-0x68] */
            ii(0x1013_d8b0, 5); call(0x1007_6e7c, -0xc_6a39);           /* call 0x10076e7c */
            ii(0x1013_d8b5, 4); imul(eax, memd[ss, ebp - 0x70]);        /* imul eax, [ebp-0x70] */
            ii(0x1013_d8b9, 5); mov(ebx, 0x70);                         /* mov ebx, 0x70 */
            ii(0x1013_d8be, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_d8c0, 2); div(ebx);                               /* div ebx */
            ii(0x1013_d8c2, 3); mov(edx, memd[ss, ebp - 0x70]);         /* mov edx, [ebp-0x70] */
            ii(0x1013_d8c5, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1013_d8c7, 3); mov(memd[ss, ebp - 0x52], edx);         /* mov [ebp-0x52], edx */
            ii(0x1013_d8ca, 4); movsx(eax, memw[ss, ebp - 0x64]);       /* movsx eax, word [ebp-0x64] */
            ii(0x1013_d8ce, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_d8d0, 2); if(jge(0x1013_d8d8, 0x6)) goto l_0x1013_d8d8; /* jge 0x1013d8d8 */
            ii(0x1013_d8d2, 4); mov(memb[ss, ebp - 0x34], 0x1);         /* mov byte [ebp-0x34], 0x1 */
            ii(0x1013_d8d6, 2); jmp(0x1013_d8dc, 0x4); goto l_0x1013_d8dc; /* jmp 0x1013d8dc */
        l_0x1013_d8d8:
            ii(0x1013_d8d8, 4); mov(memb[ss, ebp - 0x34], 0);           /* mov byte [ebp-0x34], 0x0 */
        l_0x1013_d8dc:
            ii(0x1013_d8dc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_d8de, 3); mov(dl, memb[ss, ebp - 0x34]);          /* mov dl, [ebp-0x34] */
            ii(0x1013_d8e1, 4); movsx(eax, memw[ss, ebp - 0x68]);       /* movsx eax, word [ebp-0x68] */
            ii(0x1013_d8e5, 5); call(0x1013_d45e, -0x48c);              /* call 0x1013d45e */
            ii(0x1013_d8ea, 3); mov(memd[ss, ebp - 0x49], eax);         /* mov [ebp-0x49], eax */
            ii(0x1013_d8ed, 6); mov(memw[ss, ebp - 0x3d], 0);           /* mov word [ebp-0x3d], 0x0 */
            ii(0x1013_d8f3, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_d8f6, 5); call(0x1007_6154, -0xc_77a7);           /* call 0x10076154 */
            ii(0x1013_d8fb, 4); mov(memw[ss, ebp - 0x3a], ax);          /* mov [ebp-0x3a], ax */
            ii(0x1013_d8ff, 3); lea(edx, memd[ss, ebp - 0x54]);         /* lea edx, [ebp-0x54] */
            ii(0x1013_d902, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_d905, 5); call(0x1013_dfd1, 0x6c7);               /* call 0x1013dfd1 */
        l_0x1013_d90a:
            ii(0x1013_d90a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_d90c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_d90d, 1); pop(edi);                               /* pop edi */
            ii(0x1013_d90e, 1); pop(esi);                               /* pop esi */
            ii(0x1013_d90f, 1); ret();                                  /* ret */
        }
    }
}
