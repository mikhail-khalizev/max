using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1176dbb3-a3a3-47ac-a471-c9f988de0f17")]
        public void Method_1011_a570()
        {
            ii(0x1011_a570, 5); pushd(0x78);                            /* push 0x78 */
            ii(0x1011_a575, 5); calld(Definitions.sys_check_available_stack_size, 0x4_b7d8); /* call 0x10165d52 */
            ii(0x1011_a57a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_a57b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_a57c, 1); pushd(esi);                             /* push esi */
            ii(0x1011_a57d, 1); pushd(edi);                             /* push edi */
            ii(0x1011_a57e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_a57f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_a581, 6); sub(esp, 0x5c);                         /* sub esp, 0x5c */
            ii(0x1011_a587, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_a58a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1011_a58d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_a590, 4); mov(dx, memw_a32[ds, eax + 0x8]);       /* mov dx, [eax+0x8] */
            ii(0x1011_a594, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_a597, 4); mov(memw_a32[ds, eax + 0x41], dx);      /* mov [eax+0x41], dx */
            ii(0x1011_a59b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_a59e, 4); mov(dx, memw_a32[ds, eax + 0xa]);       /* mov dx, [eax+0xa] */
            ii(0x1011_a5a2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_a5a5, 4); mov(memw_a32[ds, eax + 0x43], dx);      /* mov [eax+0x43], dx */
            ii(0x1011_a5a9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_a5ac, 3); mov(edx, memd_a32[ds, eax + 0x14]);     /* mov edx, [eax+0x14] */
            ii(0x1011_a5af, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_a5b2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_a5b5, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1011_a5b8, 5); calld(0x100b_827c, -0x6_2341);          /* call 0x100b827c */
            ii(0x1011_a5bd, 4); movsx(ax, memb_a32[ds, eax]);           /* movsx ax, byte [eax] */
            ii(0x1011_a5c1, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1011_a5c4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_a5c7, 3); mov(edx, memd_a32[ds, eax + 0x14]);     /* mov edx, [eax+0x14] */
            ii(0x1011_a5ca, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_a5cd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_a5d0, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1011_a5d3, 5); calld(0x100b_827c, -0x6_235c);          /* call 0x100b827c */
            ii(0x1011_a5d8, 5); movsx(ax, memb_a32[ds, eax + 0x1]);     /* movsx ax, byte [eax+0x1] */
            ii(0x1011_a5dd, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
        l_0x1011_a5e0:
            ii(0x1011_a5e0, 4); movsx(edx, memw_a32[ss, ebp - 0x3c]);   /* movsx edx, word [ebp-0x3c] */
            ii(0x1011_a5e4, 4); movsx(eax, memw_a32[ss, ebp - 0x30]);   /* movsx eax, word [ebp-0x30] */
            ii(0x1011_a5e8, 2); or(eax, edx);                           /* or eax, edx */
            ii(0x1011_a5ea, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_a5ec, 6); if(jnzd(0x1011_a67c, 0x8a)) goto l_0x1011_a67c; /* jnz 0x1011a67c */
            ii(0x1011_a5f2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_a5f5, 4); inc(memw_a32[ds, eax + 0x16]);          /* inc word [eax+0x16] */
            ii(0x1011_a5f9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_a5fc, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1011_a5ff, 5); calld(0x100b_82bc, -0x6_2348);          /* call 0x100b82bc */
            ii(0x1011_a604, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_a606, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_a609, 4); cmp(dx, memw_a32[ds, eax + 0x16]);      /* cmp dx, [eax+0x16] */
            ii(0x1011_a60d, 2); if(jled(0x1011_a648, 0x39)) goto l_0x1011_a648; /* jle 0x1011a648 */
            ii(0x1011_a60f, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_a612, 3); mov(edx, memd_a32[ds, edx + 0x14]);     /* mov edx, [edx+0x14] */
            ii(0x1011_a615, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_a618, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_a61b, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1011_a61e, 5); calld(0x100b_827c, -0x6_23a7);          /* call 0x100b827c */
            ii(0x1011_a623, 4); movsx(ax, memb_a32[ds, eax]);           /* movsx ax, byte [eax] */
            ii(0x1011_a627, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1011_a62a, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_a62d, 3); mov(edx, memd_a32[ds, edx + 0x14]);     /* mov edx, [edx+0x14] */
            ii(0x1011_a630, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_a633, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_a636, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1011_a639, 5); calld(0x100b_827c, -0x6_23c2);          /* call 0x100b827c */
            ii(0x1011_a63e, 5); movsx(ax, memb_a32[ds, eax + 0x1]);     /* movsx ax, byte [eax+0x1] */
            ii(0x1011_a643, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1011_a646, 2); jmpd(0x1011_a677, 0x2f); goto l_0x1011_a677; /* jmp 0x1011a677 */
        l_0x1011_a648:
            ii(0x1011_a648, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_a64b, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x1011_a64e, 5); calld(0x1012_0ce0, 0x668d);             /* call 0x10120ce0 */
            ii(0x1011_a653, 5); calld(0x1012_0a90, 0x6438);             /* call 0x10120a90 */
            ii(0x1011_a658, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_a65a, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1011_a65c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_a65f, 5); calld(0x1014_f017, 0x3_49b3);           /* call 0x1014f017 */
            ii(0x1011_a664, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
            ii(0x1011_a668, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_a66a, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x1011_a66d, 5); calld(0x1012_030c, 0x5c9a);             /* call 0x1012030c */
            ii(0x1011_a672, 5); jmpd(0x1011_ac06, 0x58f); goto l_0x1011_ac06; /* jmp 0x1011ac06 */
        l_0x1011_a677:
            ii(0x1011_a677, 5); jmpd(0x1011_a5e0, -0x9c); goto l_0x1011_a5e0; /* jmp 0x1011a5e0 */
        l_0x1011_a67c:
            ii(0x1011_a67c, 4); movsx(edx, memw_a32[ss, ebp - 0x30]);   /* movsx edx, word [ebp-0x30] */
            ii(0x1011_a680, 4); movsx(eax, memw_a32[ss, ebp - 0x3c]);   /* movsx eax, word [ebp-0x3c] */
            ii(0x1011_a684, 5); calld(0x1011_9e3a, -0x84f);             /* call 0x10119e3a */
            ii(0x1011_a689, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1011_a68c, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x1011_a690, 8); movsx(ax, memb_a32[ds, eax + 0x101b_d914]); /* movsx ax, byte [eax+0x101bd914] */
            ii(0x1011_a698, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1011_a69b, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x1011_a69f, 8); movsx(ax, memb_a32[ds, eax + 0x101b_d91c]); /* movsx ax, byte [eax+0x101bd91c] */
            ii(0x1011_a6a7, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1011_a6aa, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_a6ad, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x1011_a6b0, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x1011_a6b3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_a6b6, 4); cmp(memb_a32[ds, eax + 0x4f], 0);       /* cmp byte [eax+0x4f], 0x0 */
            ii(0x1011_a6ba, 2); if(jzd(0x1011_a6c7, 0xb)) goto l_0x1011_a6c7; /* jz 0x1011a6c7 */
            ii(0x1011_a6bc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_a6bf, 3); mov(al, memb_a32[ds, eax + 0x4f]);      /* mov al, [eax+0x4f] */
            ii(0x1011_a6c2, 2); dec(al);                                /* dec al */
            ii(0x1011_a6c4, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
        l_0x1011_a6c7:
            ii(0x1011_a6c7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_a6c9, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1011_a6cc, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_a6ce, 2); if(jzd(0x1011_a6df, 0xf)) goto l_0x1011_a6df; /* jz 0x1011a6df */
            ii(0x1011_a6d0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_a6d3, 3); mov(al, memb_a32[ds, eax + 0x60]);      /* mov al, [eax+0x60] */
            ii(0x1011_a6d6, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_a6db, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_a6dd, 2); if(jnzd(0x1011_a72a, 0x4b)) goto l_0x1011_a72a; /* jnz 0x1011a72a */
        l_0x1011_a6df:
            ii(0x1011_a6df, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_a6e2, 3); mov(al, memb_a32[ds, eax + 0x60]);      /* mov al, [eax+0x60] */
            ii(0x1011_a6e5, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_a6ea, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_a6ec, 2); if(jnzd(0x1011_a709, 0x1b)) goto l_0x1011_a709; /* jnz 0x1011a709 */
            ii(0x1011_a6ee, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_a6f1, 5); calld(0x1014_b6bd, 0x3_0fc7);           /* call 0x1014b6bd */
            ii(0x1011_a6f6, 5); calld(0x1012_0a90, 0x6395);             /* call 0x10120a90 */
            ii(0x1011_a6fb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_a6fd, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1011_a6ff, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_a702, 5); calld(0x1014_f017, 0x3_4910);           /* call 0x1014f017 */
            ii(0x1011_a707, 2); jmpd(0x1011_a721, 0x18); goto l_0x1011_a721; /* jmp 0x1011a721 */
        l_0x1011_a709:
            ii(0x1011_a709, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_a70c, 4); mov(memb_a32[ds, eax + 0x3e], 0x1);     /* mov byte [eax+0x3e], 0x1 */
            ii(0x1011_a710, 5); calld(0x1012_0ab0, 0x639b);             /* call 0x10120ab0 */
            ii(0x1011_a715, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_a717, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1011_a719, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_a71c, 5); calld(0x1014_eea8, 0x3_4787);           /* call 0x1014eea8 */
        l_0x1011_a721:
            ii(0x1011_a721, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
            ii(0x1011_a725, 5); jmpd(0x1011_ac06, 0x4dc); goto l_0x1011_ac06; /* jmp 0x1011ac06 */
        l_0x1011_a72a:
            ii(0x1011_a72a, 4); movsx(edx, memw_a32[ss, ebp - 0x24]);   /* movsx edx, word [ebp-0x24] */
            ii(0x1011_a72e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_a731, 5); calld(0x1011_7fb8, -0x277e);            /* call 0x10117fb8 */
            ii(0x1011_a736, 2); test(al, al);                           /* test al, al */
            ii(0x1011_a738, 2); if(jzd(0x1011_a743, 0x9)) goto l_0x1011_a743; /* jz 0x1011a743 */
            ii(0x1011_a73a, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
            ii(0x1011_a73e, 5); jmpd(0x1011_ac06, 0x4c3); goto l_0x1011_ac06; /* jmp 0x1011ac06 */
        l_0x1011_a743:
            ii(0x1011_a743, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_a746, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x1011_a74a, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1011_a74d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_a750, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x1011_a754, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1011_a757, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1011_a75a, 3); add(eax, memd_a32[ss, ebp - 0x20]);     /* add eax, [ebp-0x20] */
            ii(0x1011_a75d, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1011_a760, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1011_a763, 3); add(eax, memd_a32[ss, ebp - 0x28]);     /* add eax, [ebp-0x28] */
            ii(0x1011_a766, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1011_a769, 7); mov(memd_a32[ss, ebp - 0x38], 0x4);     /* mov dword [ebp-0x38], 0x4 */
            ii(0x1011_a770, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_a773, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1b);    /* cmp byte [eax+0x3d], 0x1b */
            ii(0x1011_a777, 6); if(jnzd(0x1011_a8a0, 0x123)) goto l_0x1011_a8a0; /* jnz 0x1011a8a0 */
            ii(0x1011_a77d, 4); or(memb_a32[ss, ebp - 0x10], 0x1);      /* or byte [ebp-0x10], 0x1 */
            ii(0x1011_a781, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1011_a784, 5); calld(Definitions.my_ctor_0x101b_38f8, -0xa_4099); /* call 0x100766f0 */
            ii(0x1011_a789, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x1011_a78c, 4); and(memb_a32[ss, ebp - 0x10], -0x2 /* 0xfe */); /* and byte [ebp-0x10], 0xfe */
            ii(0x1011_a790, 4); movsx(ebx, memw_a32[ss, ebp - 0x34]);   /* movsx ebx, word [ebp-0x34] */
            ii(0x1011_a794, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x1011_a798, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_a79b, 5); calld(0x1007_510b, -0xa_5695);          /* call 0x1007510b */
            ii(0x1011_a7a0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_a7a2, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1011_a7a5, 5); calld(0x1007_6630, -0xa_417a);          /* call 0x10076630 */
            ii(0x1011_a7aa, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_a7ac, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1011_a7af, 5); calld(0x1013_ad71, 0x2_05bd);           /* call 0x1013ad71 */
            ii(0x1011_a7b4, 2); test(al, al);                           /* test al, al */
            ii(0x1011_a7b6, 6); if(jzd(0x1011_a896, 0xda)) goto l_0x1011_a896; /* jz 0x1011a896 */
            ii(0x1011_a7bc, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1011_a7bf, 5); calld(0x1007_6574, -0xa_4250);          /* call 0x10076574 */
            ii(0x1011_a7c4, 5); calld(0x1007_623c, -0xa_458d);          /* call 0x1007623c */
            ii(0x1011_a7c9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_a7cb, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1011_a7ce, 5); calld(0x1007_65d0, -0xa_4203);          /* call 0x100765d0 */
            ii(0x1011_a7d3, 5); calld(0x1007_34d7, -0xa_7301);          /* call 0x100734d7 */
            ii(0x1011_a7d8, 4); cmp(ax, memw_a32[ds, edx + 0x19]);      /* cmp ax, [edx+0x19] */
            ii(0x1011_a7dc, 2); if(jnzd(0x1011_a802, 0x24)) goto l_0x1011_a802; /* jnz 0x1011a802 */
            ii(0x1011_a7de, 5); calld(0x1012_0a90, 0x62ad);             /* call 0x10120a90 */
            ii(0x1011_a7e3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_a7e5, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1011_a7e7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_a7ea, 5); calld(0x1014_f017, 0x3_4828);           /* call 0x1014f017 */
            ii(0x1011_a7ef, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
            ii(0x1011_a7f3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_a7f5, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1011_a7f8, 5); calld(0x1007_5f2c, -0xa_48d1);          /* call 0x10075f2c */
            ii(0x1011_a7fd, 5); jmpd(0x1011_ac06, 0x404); goto l_0x1011_ac06; /* jmp 0x1011ac06 */
        l_0x1011_a802:
            ii(0x1011_a802, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_a805, 4); mov(memb_a32[ds, eax + 0x3d], 0x10);    /* mov byte [eax+0x3d], 0x10 */
            ii(0x1011_a809, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1011_a80c, 5); calld(0x1007_6574, -0xa_429d);          /* call 0x10076574 */
            ii(0x1011_a811, 5); cmp(memw_a32[ds, eax + 0x8], 0x48);     /* cmp word [eax+0x8], 0x48 */
            ii(0x1011_a816, 2); if(jzd(0x1011_a827, 0xf)) goto l_0x1011_a827; /* jz 0x1011a827 */
            ii(0x1011_a818, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1011_a81b, 5); calld(0x1007_6574, -0xa_42ac);          /* call 0x10076574 */
            ii(0x1011_a820, 5); cmp(memw_a32[ds, eax + 0x8], 0x41);     /* cmp word [eax+0x8], 0x41 */
            ii(0x1011_a825, 2); if(jnzd(0x1011_a830, 0x9)) goto l_0x1011_a830; /* jnz 0x1011a830 */
        l_0x1011_a827:
            ii(0x1011_a827, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_a82a, 4); mov(memb_a32[ds, eax + 0x3e], 0x4);     /* mov byte [eax+0x3e], 0x4 */
            ii(0x1011_a82e, 2); jmpd(0x1011_a837, 0x7); goto l_0x1011_a837; /* jmp 0x1011a837 */
        l_0x1011_a830:
            ii(0x1011_a830, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_a833, 4); mov(memb_a32[ds, eax + 0x3e], 0x3);     /* mov byte [eax+0x3e], 0x3 */
        l_0x1011_a837:
            ii(0x1011_a837, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1011_a83a, 5); calld(0x1007_65d0, -0xa_426f);          /* call 0x100765d0 */
            ii(0x1011_a83f, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1011_a842, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_a844, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1011_a846, 5); calld(0x1008_a998, -0x8_feb3);          /* call 0x1008a998 */
            ii(0x1011_a84b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_a84d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_a850, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1011_a853, 5); calld(0x1007_6a34, -0xa_3e24);          /* call 0x10076a34 */
            ii(0x1011_a858, 5); mov(edx, 0x21);                         /* mov edx, 0x21 */
            ii(0x1011_a85d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_a860, 5); calld(0x1016_2f0a, 0x4_86a5);           /* call 0x10162f0a */
            ii(0x1011_a865, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1011_a86a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_a86d, 5); calld(0x1007_6d98, -0xa_3ada);          /* call 0x10076d98 */
            ii(0x1011_a872, 2); test(al, al);                           /* test al, al */
            ii(0x1011_a874, 2); if(jzd(0x1011_a883, 0xd)) goto l_0x1011_a883; /* jz 0x1011a883 */
            ii(0x1011_a876, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1011_a879, 5); calld(0x1007_65d0, -0xa_42ae);          /* call 0x100765d0 */
            ii(0x1011_a87e, 5); calld(0x100f_f637, -0x1_b24c);          /* call 0x100ff637 */
        l_0x1011_a883:
            ii(0x1011_a883, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
            ii(0x1011_a887, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_a889, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1011_a88c, 5); calld(0x1007_5f2c, -0xa_4965);          /* call 0x10075f2c */
            ii(0x1011_a891, 5); jmpd(0x1011_ac06, 0x370); goto l_0x1011_ac06; /* jmp 0x1011ac06 */
        l_0x1011_a896:
            ii(0x1011_a896, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_a898, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1011_a89b, 5); calld(0x1007_5f2c, -0xa_4974);          /* call 0x10075f2c */
        l_0x1011_a8a0:
            ii(0x1011_a8a0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_a8a3, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1011_a8a6, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1011_a8a8, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1011_a8ab, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_a8ae, 3); mov(al, memb_a32[ds, eax + 0x29]);      /* mov al, [eax+0x29] */
            ii(0x1011_a8b1, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1011_a8b3, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1011_a8b6, 4); movsx(edx, memw_a32[ss, ebp - 0x34]);   /* movsx edx, word [ebp-0x34] */
            ii(0x1011_a8ba, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1011_a8be, 5); calld(0x1011_a3f7, -0x4cc);             /* call 0x1011a3f7 */
            ii(0x1011_a8c3, 5); mov(eax, 0x1a);                         /* mov eax, 0x1a */
            ii(0x1011_a8c8, 1); pushd(eax);                             /* push eax */
            ii(0x1011_a8c9, 4); movsx(ecx, memw_a32[ss, ebp - 0x34]);   /* movsx ecx, word [ebp-0x34] */
            ii(0x1011_a8cd, 4); movsx(ebx, memw_a32[ss, ebp - 0x18]);   /* movsx ebx, word [ebp-0x18] */
            ii(0x1011_a8d1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_a8d4, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1011_a8d7, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1011_a8d9, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_a8dc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_a8df, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1011_a8e2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_a8e5, 5); calld(0x1007_02b9, -0xa_a631);          /* call 0x100702b9 */
            ii(0x1011_a8ea, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1011_a8ed, 4); movsx(eax, memw_a32[ss, ebp - 0x38]);   /* movsx eax, word [ebp-0x38] */
            ii(0x1011_a8f1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_a8f3, 6); if(jnzd(0x1011_a9e5, 0xec)) goto l_0x1011_a9e5; /* jnz 0x1011a9e5 */
            ii(0x1011_a8f9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_a8fc, 3); mov(al, memb_a32[ds, eax + 0x12]);      /* mov al, [eax+0x12] */
            ii(0x1011_a8ff, 2); and(al, 0);                             /* and al, 0x0 */
            ii(0x1011_a901, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_a906, 1); pushd(eax);                             /* push eax */
            ii(0x1011_a907, 4); movsx(ecx, memw_a32[ss, ebp - 0x34]);   /* movsx ecx, word [ebp-0x34] */
            ii(0x1011_a90b, 4); movsx(ebx, memw_a32[ss, ebp - 0x18]);   /* movsx ebx, word [ebp-0x18] */
            ii(0x1011_a90f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_a912, 3); mov(edx, memd_a32[ds, eax + 0x1a]);     /* mov edx, [eax+0x1a] */
            ii(0x1011_a915, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_a918, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_a91b, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x1011_a91e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_a921, 5); calld(0x1007_0010, -0xa_a916);          /* call 0x10070010 */
            ii(0x1011_a926, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x1011_a929, 6); if(jnzd(0x1011_a9dc, 0xad)) goto l_0x1011_a9dc; /* jnz 0x1011a9dc */
            ii(0x1011_a92f, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_a932, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x1011_a935, 5); calld(0x1012_0ce0, 0x63a6);             /* call 0x10120ce0 */
            ii(0x1011_a93a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_a93d, 4); cmp(memb_a32[ds, eax + 0x3d], 0x4);     /* cmp byte [eax+0x3d], 0x4 */
            ii(0x1011_a941, 2); if(jzd(0x1011_a964, 0x21)) goto l_0x1011_a964; /* jz 0x1011a964 */
            ii(0x1011_a943, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_a946, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1011_a949, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_a94e, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1011_a954, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1011_a95a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_a95f, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1011_a962, 2); if(jnzd(0x1011_a966, 0x2)) goto l_0x1011_a966; /* jnz 0x1011a966 */
        l_0x1011_a964:
            ii(0x1011_a964, 2); jmpd(0x1011_a97d, 0x17); goto l_0x1011_a97d; /* jmp 0x1011a97d */
        l_0x1011_a966:
            ii(0x1011_a966, 7); cmp(memb_a32[ds, 0x101c_391e], 0x9);    /* cmp byte [0x101c391e], 0x9 */
            ii(0x1011_a96d, 2); if(jnzd(0x1011_a97b, 0xc)) goto l_0x1011_a97b; /* jnz 0x1011a97b */
            ii(0x1011_a96f, 5); mov(eax, memd_a32[ds, 0x101c_3960]);    /* mov eax, [0x101c3960] */
            ii(0x1011_a974, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_a977, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_a979, 2); if(jzd(0x1011_a97d, 0x2)) goto l_0x1011_a97d; /* jz 0x1011a97d */
        l_0x1011_a97b:
            ii(0x1011_a97b, 2); jmpd(0x1011_a990, 0x13); goto l_0x1011_a990; /* jmp 0x1011a990 */
        l_0x1011_a97d:
            ii(0x1011_a97d, 5); calld(0x1012_0a90, 0x610e);             /* call 0x10120a90 */
            ii(0x1011_a982, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_a984, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1011_a986, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_a989, 5); calld(0x1014_f017, 0x3_4689);           /* call 0x1014f017 */
            ii(0x1011_a98e, 2); jmpd(0x1011_a9d2, 0x42); goto l_0x1011_a9d2; /* jmp 0x1011a9d2 */
        l_0x1011_a990:
            ii(0x1011_a990, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_a993, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1011_a996, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_a99b, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1011_a9a1, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1011_a9a7, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_a9ac, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1011_a9af, 2); if(jnzd(0x1011_a9ba, 0x9)) goto l_0x1011_a9ba; /* jnz 0x1011a9ba */
            ii(0x1011_a9b1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_a9b4, 4); mov(memb_a32[ds, eax + 0x3e], 0x2a);    /* mov byte [eax+0x3e], 0x2a */
            ii(0x1011_a9b8, 2); jmpd(0x1011_a9d2, 0x18); goto l_0x1011_a9d2; /* jmp 0x1011a9d2 */
        l_0x1011_a9ba:
            ii(0x1011_a9ba, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1011_a9bf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_a9c2, 5); calld(0x1011_b7de, 0xe17);              /* call 0x1011b7de */
            ii(0x1011_a9c7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_a9c9, 2); if(jzd(0x1011_a9d2, 0x7)) goto l_0x1011_a9d2; /* jz 0x1011a9d2 */
            ii(0x1011_a9cb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_a9ce, 4); mov(memb_a32[ds, eax + 0x3e], 0x2a);    /* mov byte [eax+0x3e], 0x2a */
        l_0x1011_a9d2:
            ii(0x1011_a9d2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_a9d4, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x1011_a9d7, 5); calld(0x1012_030c, 0x5930);             /* call 0x1012030c */
        l_0x1011_a9dc:
            ii(0x1011_a9dc, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
            ii(0x1011_a9e0, 5); jmpd(0x1011_ac06, 0x221); goto l_0x1011_ac06; /* jmp 0x1011ac06 */
        l_0x1011_a9e5:
            ii(0x1011_a9e5, 5); cmp(memw_a32[ss, ebp - 0x20], 0);       /* cmp word [ebp-0x20], 0x0 */
            ii(0x1011_a9ea, 2); if(jzd(0x1011_a9f3, 0x7)) goto l_0x1011_a9f3; /* jz 0x1011a9f3 */
            ii(0x1011_a9ec, 5); cmp(memw_a32[ss, ebp - 0x28], 0);       /* cmp word [ebp-0x28], 0x0 */
            ii(0x1011_a9f1, 2); if(jnzd(0x1011_a9f5, 0x2)) goto l_0x1011_a9f5; /* jnz 0x1011a9f5 */
        l_0x1011_a9f3:
            ii(0x1011_a9f3, 2); jmpd(0x1011_a9fb, 0x6); goto l_0x1011_a9fb; /* jmp 0x1011a9fb */
        l_0x1011_a9f5:
            ii(0x1011_a9f5, 4); mov(memb_a32[ss, ebp - 0x50], 0x1);     /* mov byte [ebp-0x50], 0x1 */
            ii(0x1011_a9f9, 2); jmpd(0x1011_a9ff, 0x4); goto l_0x1011_a9ff; /* jmp 0x1011a9ff */
        l_0x1011_a9fb:
            ii(0x1011_a9fb, 4); mov(memb_a32[ss, ebp - 0x50], 0);       /* mov byte [ebp-0x50], 0x0 */
        l_0x1011_a9ff:
            ii(0x1011_a9ff, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1011_aa01, 3); mov(cl, memb_a32[ss, ebp - 0x50]);      /* mov cl, [ebp-0x50] */
            ii(0x1011_aa04, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x1011_aa09, 4); movsx(edx, memw_a32[ss, ebp - 0x38]);   /* movsx edx, word [ebp-0x38] */
            ii(0x1011_aa0d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_aa10, 5); calld(0x1011_a08d, -0x988);             /* call 0x1011a08d */
            ii(0x1011_aa15, 2); test(al, al);                           /* test al, al */
            ii(0x1011_aa17, 2); if(jnzd(0x1011_aa3a, 0x21)) goto l_0x1011_aa3a; /* jnz 0x1011aa3a */
            ii(0x1011_aa19, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_aa1c, 4); mov(memb_a32[ds, eax + 0x3e], 0x1);     /* mov byte [eax+0x3e], 0x1 */
            ii(0x1011_aa20, 5); calld(0x1012_0ab0, 0x608b);             /* call 0x10120ab0 */
            ii(0x1011_aa25, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_aa27, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1011_aa29, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_aa2c, 5); calld(0x1014_eea8, 0x3_4477);           /* call 0x1014eea8 */
            ii(0x1011_aa31, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
            ii(0x1011_aa35, 5); jmpd(0x1011_ac06, 0x1cc); goto l_0x1011_ac06; /* jmp 0x1011ac06 */
        l_0x1011_aa3a:
            ii(0x1011_aa3a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_aa3d, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1011_aa40, 5); and(eax, 0x180);                        /* and eax, 0x180 */
            ii(0x1011_aa45, 5); cmp(eax, 0x180);                        /* cmp eax, 0x180 */
            ii(0x1011_aa4a, 6); if(jnzd(0x1011_abcb, 0x17b)) goto l_0x1011_abcb; /* jnz 0x1011abcb */
            ii(0x1011_aa50, 4); movsx(edx, memw_a32[ss, ebp - 0x34]);   /* movsx edx, word [ebp-0x34] */
            ii(0x1011_aa54, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1011_aa58, 5); calld(0x1007_3d48, -0xa_6d15);          /* call 0x10073d48 */
            ii(0x1011_aa5d, 3); mov(memd_a32[ss, ebp - 0x54], eax);     /* mov [ebp-0x54], eax */
            ii(0x1011_aa60, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_aa63, 5); cmp(memw_a32[ds, eax + 0x8], 0x41);     /* cmp word [eax+0x8], 0x41 */
            ii(0x1011_aa68, 6); if(jnzd(0x1011_ab6a, 0xfc)) goto l_0x1011_ab6a; /* jnz 0x1011ab6a */
            ii(0x1011_aa6e, 7); mov(memd_a32[ss, ebp - 0x58], 0);       /* mov dword [ebp-0x58], 0x0 */
            ii(0x1011_aa75, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_aa77, 4); mov(ax, memw_a32[ss, ebp - 0x54]);      /* mov ax, [ebp-0x54] */
            ii(0x1011_aa7b, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1011_aa7e, 2); if(jzd(0x1011_aa8c, 0xc)) goto l_0x1011_aa8c; /* jz 0x1011aa8c */
            ii(0x1011_aa80, 7); mov(memd_a32[ss, ebp - 0x58], 0x8);     /* mov dword [ebp-0x58], 0x8 */
            ii(0x1011_aa87, 5); jmpd(0x1011_ab58, 0xcc); goto l_0x1011_ab58; /* jmp 0x1011ab58 */
        l_0x1011_aa8c:
            ii(0x1011_aa8c, 7); mov(memd_a32[ss, ebp - 0x5c], 0);       /* mov dword [ebp-0x5c], 0x0 */
            ii(0x1011_aa93, 2); jmpd(0x1011_aa9b, 0x6); goto l_0x1011_aa9b; /* jmp 0x1011aa9b */
        l_0x1011_aa95:
            ii(0x1011_aa95, 3); mov(eax, memd_a32[ss, ebp - 0x5c]);     /* mov eax, [ebp-0x5c] */
            ii(0x1011_aa98, 3); inc(memd_a32[ss, ebp - 0x5c]);          /* inc dword [ebp-0x5c] */
        l_0x1011_aa9b:
            ii(0x1011_aa9b, 4); movsx(eax, memw_a32[ss, ebp - 0x5c]);   /* movsx eax, word [ebp-0x5c] */
            ii(0x1011_aa9f, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1011_aaa2, 6); if(jged(0x1011_ab58, 0xb0)) goto l_0x1011_ab58; /* jge 0x1011ab58 */
            ii(0x1011_aaa8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_aaab, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1011_aaae, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_aab3, 4); movsx(edx, memw_a32[ss, ebp - 0x5c]);   /* movsx edx, word [ebp-0x5c] */
            ii(0x1011_aab7, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1011_aab9, 2); if(jzd(0x1011_aad4, 0x19)) goto l_0x1011_aad4; /* jz 0x1011aad4 */
            ii(0x1011_aabb, 4); movsx(eax, memw_a32[ss, ebp - 0x5c]);   /* movsx eax, word [ebp-0x5c] */
            ii(0x1011_aabf, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1011_aac5, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1011_aacb, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_aad0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_aad2, 2); if(jnzd(0x1011_aad9, 0x5)) goto l_0x1011_aad9; /* jnz 0x1011aad9 */
        l_0x1011_aad4:
            ii(0x1011_aad4, 5); jmpd(0x1011_ab53, 0x7a); goto l_0x1011_ab53; /* jmp 0x1011ab53 */
        l_0x1011_aad9:
            ii(0x1011_aad9, 4); movsx(eax, memw_a32[ss, ebp - 0x34]);   /* movsx eax, word [ebp-0x34] */
            ii(0x1011_aadd, 6); mov(edx, memd_a32[ds, 0x101c_8170]);    /* mov edx, [0x101c8170] */
            ii(0x1011_aae3, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_aae6, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1011_aae9, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x1011_aaed, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_aaef, 4); movsx(eax, memw_a32[ss, ebp - 0x5c]);   /* movsx eax, word [ebp-0x5c] */
            ii(0x1011_aaf3, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1011_aaf9, 6); mov(eax, memd_a32[ds, eax + 0x101c_a6a7]); /* mov eax, [eax+0x101ca6a7] */
            ii(0x1011_aaff, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_ab01, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1011_ab03, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_ab08, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_ab0a, 2); if(jnzd(0x1011_ab58, 0x4c)) goto l_0x1011_ab58; /* jnz 0x1011ab58 */
            ii(0x1011_ab0c, 4); movsx(edx, memw_a32[ss, ebp - 0x5c]);   /* movsx edx, word [ebp-0x5c] */
            ii(0x1011_ab10, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_ab13, 5); calld(0x1007_6274, -0xa_48a4);          /* call 0x10076274 */
            ii(0x1011_ab18, 2); test(al, al);                           /* test al, al */
            ii(0x1011_ab1a, 2); if(jzd(0x1011_ab4f, 0x33)) goto l_0x1011_ab4f; /* jz 0x1011ab4f */
            ii(0x1011_ab1c, 4); movsx(eax, memw_a32[ss, ebp - 0x34]);   /* movsx eax, word [ebp-0x34] */
            ii(0x1011_ab20, 6); mov(edx, memd_a32[ds, 0x101c_8170]);    /* mov edx, [0x101c8170] */
            ii(0x1011_ab26, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_ab29, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1011_ab2c, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x1011_ab30, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_ab32, 4); movsx(eax, memw_a32[ss, ebp - 0x5c]);   /* movsx eax, word [ebp-0x5c] */
            ii(0x1011_ab36, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1011_ab3c, 6); mov(eax, memd_a32[ds, eax + 0x101c_a6a3]); /* mov eax, [eax+0x101ca6a3] */
            ii(0x1011_ab42, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_ab44, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1011_ab46, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_ab4b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_ab4d, 2); if(jnzd(0x1011_ab51, 0x2)) goto l_0x1011_ab51; /* jnz 0x1011ab51 */
        l_0x1011_ab4f:
            ii(0x1011_ab4f, 2); jmpd(0x1011_ab53, 0x2); goto l_0x1011_ab53; /* jmp 0x1011ab53 */
        l_0x1011_ab51:
            ii(0x1011_ab51, 2); jmpd(0x1011_ab58, 0x5); goto l_0x1011_ab58; /* jmp 0x1011ab58 */
        l_0x1011_ab53:
            ii(0x1011_ab53, 5); jmpd(0x1011_aa95, -0xc3); goto l_0x1011_aa95; /* jmp 0x1011aa95 */
        l_0x1011_ab58:
            ii(0x1011_ab58, 4); movsx(eax, memw_a32[ss, ebp - 0x5c]);   /* movsx eax, word [ebp-0x5c] */
            ii(0x1011_ab5c, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1011_ab5f, 2); if(jged(0x1011_ab68, 0x7)) goto l_0x1011_ab68; /* jge 0x1011ab68 */
            ii(0x1011_ab61, 7); mov(memd_a32[ss, ebp - 0x58], 0x8);     /* mov dword [ebp-0x58], 0x8 */
        l_0x1011_ab68:
            ii(0x1011_ab68, 2); jmpd(0x1011_ab85, 0x1b); goto l_0x1011_ab85; /* jmp 0x1011ab85 */
        l_0x1011_ab6a:
            ii(0x1011_ab6a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_ab6c, 4); mov(ax, memw_a32[ss, ebp - 0x54]);      /* mov ax, [ebp-0x54] */
            ii(0x1011_ab70, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1011_ab73, 2); if(jnzd(0x1011_ab7e, 0x9)) goto l_0x1011_ab7e; /* jnz 0x1011ab7e */
            ii(0x1011_ab75, 7); mov(memd_a32[ss, ebp - 0x58], 0x8);     /* mov dword [ebp-0x58], 0x8 */
            ii(0x1011_ab7c, 2); jmpd(0x1011_ab85, 0x7); goto l_0x1011_ab85; /* jmp 0x1011ab85 */
        l_0x1011_ab7e:
            ii(0x1011_ab7e, 7); mov(memd_a32[ss, ebp - 0x58], 0);       /* mov dword [ebp-0x58], 0x0 */
        l_0x1011_ab85:
            ii(0x1011_ab85, 3); mov(eax, memd_a32[ss, ebp - 0x58]);     /* mov eax, [ebp-0x58] */
            ii(0x1011_ab88, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1011_ab8b, 4); cmp(ax, memw_a32[ds, edx + 0x33]);      /* cmp ax, [edx+0x33] */
            ii(0x1011_ab8f, 2); if(jzd(0x1011_abcb, 0x3a)) goto l_0x1011_abcb; /* jz 0x1011abcb */
            ii(0x1011_ab91, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_ab94, 5); cmp(memw_a32[ds, eax + 0x8], 0x41);     /* cmp word [eax+0x8], 0x41 */
            ii(0x1011_ab99, 2); if(jnzd(0x1011_aba7, 0xc)) goto l_0x1011_aba7; /* jnz 0x1011aba7 */
            ii(0x1011_ab9b, 3); mov(eax, memd_a32[ss, ebp - 0x58]);     /* mov eax, [ebp-0x58] */
            ii(0x1011_ab9e, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1011_aba1, 4); mov(memw_a32[ds, edx + 0x37], ax);      /* mov [edx+0x37], ax */
            ii(0x1011_aba5, 2); jmpd(0x1011_abb6, 0xf); goto l_0x1011_abb6; /* jmp 0x1011abb6 */
        l_0x1011_aba7:
            ii(0x1011_aba7, 3); mov(eax, memd_a32[ss, ebp - 0x58]);     /* mov eax, [ebp-0x58] */
            ii(0x1011_abaa, 5); add(eax, 0x10);                         /* add eax, 0x10 */
            ii(0x1011_abaf, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1011_abb2, 4); mov(memw_a32[ds, edx + 0x37], ax);      /* mov [edx+0x37], ax */
        l_0x1011_abb6:
            ii(0x1011_abb6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_abb9, 3); mov(ebx, memd_a32[ds, eax + 0x39]);     /* mov ebx, [eax+0x39] */
            ii(0x1011_abbc, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_abbf, 4); movsx(edx, memw_a32[ss, ebp - 0x58]);   /* movsx edx, word [ebp-0x58] */
            ii(0x1011_abc3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_abc6, 5); calld(0x1014_9ab7, 0x2_eeec);           /* call 0x10149ab7 */
        l_0x1011_abcb:
            ii(0x1011_abcb, 4); movsx(ebx, memw_a32[ss, ebp - 0x34]);   /* movsx ebx, word [ebp-0x34] */
            ii(0x1011_abcf, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x1011_abd3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_abd6, 5); calld(0x1015_23fd, 0x3_7822);           /* call 0x101523fd */
            ii(0x1011_abdb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_abde, 4); mov(memb_a32[ds, eax + 0x5e], 0);       /* mov byte [eax+0x5e], 0x0 */
            ii(0x1011_abe2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_abe5, 4); mov(memb_a32[ds, eax + 0x3e], 0x6);     /* mov byte [eax+0x3e], 0x6 */
            ii(0x1011_abe9, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1011_abee, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_abf1, 5); calld(0x1007_6d98, -0xa_3e5e);          /* call 0x10076d98 */
            ii(0x1011_abf6, 2); test(al, al);                           /* test al, al */
            ii(0x1011_abf8, 2); if(jzd(0x1011_ac02, 0x8)) goto l_0x1011_ac02; /* jz 0x1011ac02 */
            ii(0x1011_abfa, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_abfd, 5); calld(0x1010_094d, -0x1_a2b5);          /* call 0x1010094d */
        l_0x1011_ac02:
            ii(0x1011_ac02, 4); mov(memb_a32[ss, ebp - 0x14], 0x1);     /* mov byte [ebp-0x14], 0x1 */
        l_0x1011_ac06:
            ii(0x1011_ac06, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x1011_ac09, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_ac0b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_ac0c, 1); popd(edi);                              /* pop edi */
            ii(0x1011_ac0d, 1); popd(esi);                              /* pop esi */
            ii(0x1011_ac0e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_ac0f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_ac10, 1); retd(); return;                         /* ret */
        }
    }
}
