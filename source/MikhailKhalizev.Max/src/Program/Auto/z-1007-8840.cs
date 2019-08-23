using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_8840-bbf59b2e")]
        public void Method_1007_8840()
        {
            ii(0x1007_8840, 5); push(0x78);                             /* push 0x78 */
            ii(0x1007_8845, 5); call(Definitions.sys_check_available_stack_size, 0xe_d508); /* call 0x10165d52 */
            ii(0x1007_884a, 1); push(ebx);                              /* push ebx */
            ii(0x1007_884b, 1); push(ecx);                              /* push ecx */
            ii(0x1007_884c, 1); push(esi);                              /* push esi */
            ii(0x1007_884d, 1); push(edi);                              /* push edi */
            ii(0x1007_884e, 1); push(ebp);                              /* push ebp */
            ii(0x1007_884f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_8851, 6); sub(esp, 0x5c);                         /* sub esp, 0x5c */
            ii(0x1007_8857, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_885a, 3); mov(memb[ss, ebp - 0x4], dl);           /* mov [ebp-0x4], dl */
            ii(0x1007_885d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_885f, 5); mov(al, memb[ds, 0x101c_37c9]);         /* mov al, [0x101c37c9] */
            ii(0x1007_8864, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1007_8867, 2); if(jnz(0x1007_8872, 0x9)) goto l_0x1007_8872; /* jnz 0x10078872 */
            ii(0x1007_8869, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x1007_886d, 5); jmp(0x1007_8d3f, 0x4cd); goto l_0x1007_8d3f; /* jmp 0x10078d3f */
        l_0x1007_8872:
            ii(0x1007_8872, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_8875, 3); mov(al, memb[ds, eax + 0x54]);          /* mov al, [eax+0x54] */
            ii(0x1007_8878, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_887d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_887f, 2); if(jz(0x1007_88a5, 0x24)) goto l_0x1007_88a5; /* jz 0x100788a5 */
            ii(0x1007_8881, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_8883, 5); mov(al, memb[ds, 0x101c_37c9]);         /* mov al, [0x101c37c9] */
            ii(0x1007_8888, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_888a, 2); if(jnz(0x1007_88a3, 0x17)) goto l_0x1007_88a3; /* jnz 0x100788a3 */
            ii(0x1007_888c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_888f, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1007_8892, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_8897, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_8899, 6); mov(dl, memb[ds, 0x101c_37c8]);         /* mov dl, [0x101c37c8] */
            ii(0x1007_889f, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_88a1, 2); if(jnz(0x1007_88a5, 0x2)) goto l_0x1007_88a5; /* jnz 0x100788a5 */
        l_0x1007_88a3:
            ii(0x1007_88a3, 2); jmp(0x1007_88ae, 0x9); goto l_0x1007_88ae; /* jmp 0x100788ae */
        l_0x1007_88a5:
            ii(0x1007_88a5, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x1007_88a9, 5); jmp(0x1007_8d3f, 0x491); goto l_0x1007_8d3f; /* jmp 0x10078d3f */
        l_0x1007_88ae:
            ii(0x1007_88ae, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_88b1, 3); mov(al, memb[ds, eax + 0x50]);          /* mov al, [eax+0x50] */
            ii(0x1007_88b4, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_88b9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_88bb, 2); if(jnz(0x1007_88cb, 0xe)) goto l_0x1007_88cb; /* jnz 0x100788cb */
            ii(0x1007_88bd, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_88c0, 5); call(0x1007_623c, -0x2689);             /* call 0x1007623c */
            ii(0x1007_88c5, 4); cmp(memb[ds, eax + 0x16], 0);           /* cmp byte [eax+0x16], 0x0 */
            ii(0x1007_88c9, 2); if(jnz(0x1007_88cd, 0x2)) goto l_0x1007_88cd; /* jnz 0x100788cd */
        l_0x1007_88cb:
            ii(0x1007_88cb, 2); jmp(0x1007_88d6, 0x9); goto l_0x1007_88d6; /* jmp 0x100788d6 */
        l_0x1007_88cd:
            ii(0x1007_88cd, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x1007_88d1, 5); jmp(0x1007_8d3f, 0x469); goto l_0x1007_8d3f; /* jmp 0x10078d3f */
        l_0x1007_88d6:
            ii(0x1007_88d6, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_88d9, 4); cmp(memb[ds, eax + 0x59], 0);           /* cmp byte [eax+0x59], 0x0 */
            ii(0x1007_88dd, 2); if(jnz(0x1007_88f0, 0x11)) goto l_0x1007_88f0; /* jnz 0x100788f0 */
            ii(0x1007_88df, 5); mov(eax, memd[ds, 0x101c_31be]);        /* mov eax, [0x101c31be] */
            ii(0x1007_88e4, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_88e7, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1007_88ea, 6); if(jnz(0x1007_8970, 0x80)) goto l_0x1007_8970; /* jnz 0x10078970 */
        l_0x1007_88f0:
            ii(0x1007_88f0, 5); mov(eax, 0x17);                         /* mov eax, 0x17 */
            ii(0x1007_88f5, 5); call(Definitions.sys_new, 0xe_d506);    /* call 0x10165e00 */
            ii(0x1007_88fa, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1007_88fd, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1007_8900, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1007_8903, 4); cmp(memd[ss, ebp - 0x18], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1007_8907, 2); if(jz(0x1007_891f, 0x16)) goto l_0x1007_891f; /* jz 0x1007891f */
            ii(0x1007_8909, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1007_890c, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1007_890f, 5); call(0x1007_ee7d, 0x6569);              /* call 0x1007ee7d */
            ii(0x1007_8914, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1007_8917, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1007_891a, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1007_891d, 2); jmp(0x1007_8925, 0x6); goto l_0x1007_8925; /* jmp 0x10078925 */
        l_0x1007_891f:
            ii(0x1007_891f, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1007_8922, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
        l_0x1007_8925:
            ii(0x1007_8925, 3); mov(edx, memd[ss, ebp - 0x20]);         /* mov edx, [ebp-0x20] */
            ii(0x1007_8928, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1007_892b, 5); call(0x1008_b060, 0x1_2730);            /* call 0x1008b060 */
            ii(0x1007_8930, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1007_8933, 5); call(0x1008_af84, 0x1_264c);            /* call 0x1008af84 */
            ii(0x1007_8938, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_893a, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1007_893f, 5); call(0x100a_4d50, 0x2_c40c);            /* call 0x100a4d50 */
            ii(0x1007_8944, 5); mov(eax, memd[ds, 0x101c_31be]);        /* mov eax, [0x101c31be] */
            ii(0x1007_8949, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_894c, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1007_894f, 2); if(jnz(0x1007_8957, 0x6)) goto l_0x1007_8957; /* jnz 0x10078957 */
            ii(0x1007_8951, 4); mov(memb[ss, ebp - 0x10], 0x1);         /* mov byte [ebp-0x10], 0x1 */
            ii(0x1007_8955, 2); jmp(0x1007_895b, 0x4); goto l_0x1007_895b; /* jmp 0x1007895b */
        l_0x1007_8957:
            ii(0x1007_8957, 4); mov(memb[ss, ebp - 0x10], 0);           /* mov byte [ebp-0x10], 0x0 */
        l_0x1007_895b:
            ii(0x1007_895b, 3); mov(al, memb[ss, ebp - 0x10]);          /* mov al, [ebp-0x10] */
            ii(0x1007_895e, 3); mov(memb[ss, ebp - 0xc], al);           /* mov [ebp-0xc], al */
            ii(0x1007_8961, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_8963, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1007_8966, 5); call(0x1008_8b7c, 0x1_0211);            /* call 0x10088b7c */
            ii(0x1007_896b, 5); jmp(0x1007_8d3f, 0x3cf); goto l_0x1007_8d3f; /* jmp 0x10078d3f */
        l_0x1007_8970:
            ii(0x1007_8970, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_8973, 4); cmp(memb[ds, eax + 0x3d], 0x1e);        /* cmp byte [eax+0x3d], 0x1e */
            ii(0x1007_8977, 2); if(jnz(0x1007_89a0, 0x27)) goto l_0x1007_89a0; /* jnz 0x100789a0 */
            ii(0x1007_8979, 5); call(0x1007_6034, -0x294a);             /* call 0x10076034 */
            ii(0x1007_897e, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1007_8980, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1007_8982, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_8985, 3); mov(ebx, memd[ds, eax + 0x41]);         /* mov ebx, [eax+0x41] */
            ii(0x1007_8988, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1007_898b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_898e, 3); mov(edx, memd[ds, eax + 0x3f]);         /* mov edx, [eax+0x3f] */
            ii(0x1007_8991, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1007_8994, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_8997, 5); call(0x1007_4c30, -0x3d6c);             /* call 0x10074c30 */
            ii(0x1007_899c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_899e, 2); if(jz(0x1007_89a2, 0x2)) goto l_0x1007_89a2; /* jz 0x100789a2 */
        l_0x1007_89a0:
            ii(0x1007_89a0, 2); jmp(0x1007_89b1, 0xf); goto l_0x1007_89b1; /* jmp 0x100789b1 */
        l_0x1007_89a2:
            ii(0x1007_89a2, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1007_89a7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_89a9, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_89ac, 5); call(0x1016_3053, 0xe_a6a2);            /* call 0x10163053 */
        l_0x1007_89b1:
            ii(0x1007_89b1, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_89b4, 5); call(0x100a_2edb, 0x2_a522);            /* call 0x100a2edb */
            ii(0x1007_89b9, 2); test(al, al);                           /* test al, al */
            ii(0x1007_89bb, 2); if(jnz(0x1007_89c6, 0x9)) goto l_0x1007_89c6; /* jnz 0x100789c6 */
            ii(0x1007_89bd, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x1007_89c1, 5); jmp(0x1007_8d3f, 0x379); goto l_0x1007_8d3f; /* jmp 0x10078d3f */
        l_0x1007_89c6:
            ii(0x1007_89c6, 4); or(memb[ss, ebp - 0x28], 0x1);          /* or byte [ebp-0x28], 0x1 */
            ii(0x1007_89ca, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x1007_89cd, 5); call(0x1008_a330, 0x1_195e);            /* call 0x1008a330 */
            ii(0x1007_89d2, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x1007_89d5, 4); and(memb[ss, ebp - 0x28], -0x2 /* 0xfe */); /* and byte [ebp-0x28], 0xfe */
            ii(0x1007_89d9, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_89dc, 3); mov(al, memb[ds, eax + 0x50]);          /* mov al, [eax+0x50] */
            ii(0x1007_89df, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_89e4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_89e6, 2); if(jnz(0x1007_89f1, 0x9)) goto l_0x1007_89f1; /* jnz 0x100789f1 */
            ii(0x1007_89e8, 7); mov(memd[ss, ebp - 0x34], 0);           /* mov dword [ebp-0x34], 0x0 */
            ii(0x1007_89ef, 2); jmp(0x1007_8a0b, 0x1a); goto l_0x1007_8a0b; /* jmp 0x10078a0b */
        l_0x1007_89f1:
            ii(0x1007_89f1, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_89f4, 5); call(0x1007_623c, -0x27bd);             /* call 0x1007623c */
            ii(0x1007_89f9, 3); mov(edx, memd[ds, eax + 0x1b]);         /* mov edx, [eax+0x1b] */
            ii(0x1007_89fc, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1007_89ff, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1007_8a01, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1007_8a04, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1007_8a06, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1007_8a08, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
        l_0x1007_8a0b:
            ii(0x1007_8a0b, 5); call(/* sys */ 0x1016_5e9b, 0xe_d48b);  /* call 0x10165e9b */
            ii(0x1007_8a10, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1007_8a12, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x1007_8a15, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_8a17, 2); if(jnz(0x1007_8a1f, 0x6)) goto l_0x1007_8a1f; /* jnz 0x10078a1f */
            ii(0x1007_8a19, 4); mov(memb[ss, ebp - 0x38], 0);           /* mov byte [ebp-0x38], 0x0 */
            ii(0x1007_8a1d, 2); jmp(0x1007_8a23, 0x4); goto l_0x1007_8a23; /* jmp 0x10078a23 */
        l_0x1007_8a1f:
            ii(0x1007_8a1f, 4); mov(memb[ss, ebp - 0x38], 0x1);         /* mov byte [ebp-0x38], 0x1 */
        l_0x1007_8a23:
            ii(0x1007_8a23, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_8a25, 3); mov(al, memb[ss, ebp - 0x38]);          /* mov al, [ebp-0x38] */
            ii(0x1007_8a28, 1); push(eax);                              /* push eax */
            ii(0x1007_8a29, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1007_8a2b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_8a2e, 5); call(0x1007_623c, -0x27f7);             /* call 0x1007623c */
            ii(0x1007_8a33, 3); mov(ebx, memd[ds, eax + 0x15]);         /* mov ebx, [eax+0x15] */
            ii(0x1007_8a36, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1007_8a39, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_8a3c, 5); call(0x1007_623c, -0x2805);             /* call 0x1007623c */
            ii(0x1007_8a41, 4); mov(ax, memw[ds, eax + 0x12]);          /* mov ax, [eax+0x12] */
            ii(0x1007_8a45, 3); add(eax, memd[ss, ebp - 0x34]);         /* add eax, [ebp-0x34] */
            ii(0x1007_8a48, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1007_8a4b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_8a4e, 5); call(0x1007_8266, -0x7ed);              /* call 0x10078266 */
            ii(0x1007_8a53, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_8a55, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x1007_8a58, 5); call(0x1008_a2b4, 0x1_1857);            /* call 0x1008a2b4 */
            ii(0x1007_8a5d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_8a5f, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x1007_8a62, 5); call(0x1013_ad11, 0xc_22aa);            /* call 0x1013ad11 */
            ii(0x1007_8a67, 2); test(al, al);                           /* test al, al */
            ii(0x1007_8a69, 2); if(jz(0x1007_8a7e, 0x13)) goto l_0x1007_8a7e; /* jz 0x10078a7e */
            ii(0x1007_8a6b, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x1007_8a6f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_8a71, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x1007_8a74, 5); call(0x1008_8e0c, 0x1_0393);            /* call 0x10088e0c */
            ii(0x1007_8a79, 5); jmp(0x1007_8d3f, 0x2c1); goto l_0x1007_8d3f; /* jmp 0x10078d3f */
        l_0x1007_8a7e:
            ii(0x1007_8a7e, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x1007_8a81, 5); call(0x1008_a228, 0x1_17a2);            /* call 0x1008a228 */
            ii(0x1007_8a86, 5); call(0x1008_a370, 0x1_18e5);            /* call 0x1008a370 */
            ii(0x1007_8a8b, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
            ii(0x1007_8a8e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_8a91, 5); cmp(memw[ds, eax + 0x8], 0x42);         /* cmp word [eax+0x8], 0x42 */
            ii(0x1007_8a96, 2); if(jnz(0x1007_8aa7, 0xf)) goto l_0x1007_8aa7; /* jnz 0x10078aa7 */
            ii(0x1007_8a98, 3); mov(edx, memd[ss, ebp - 0x3c]);         /* mov edx, [ebp-0x3c] */
            ii(0x1007_8a9b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_8a9e, 5); call(0x1007_78a5, -0x11fe);             /* call 0x100778a5 */
            ii(0x1007_8aa3, 2); test(al, al);                           /* test al, al */
            ii(0x1007_8aa5, 2); if(jnz(0x1007_8aa9, 0x2)) goto l_0x1007_8aa9; /* jnz 0x10078aa9 */
        l_0x1007_8aa7:
            ii(0x1007_8aa7, 2); jmp(0x1007_8ac7, 0x1e); goto l_0x1007_8ac7; /* jmp 0x10078ac7 */
        l_0x1007_8aa9:
            ii(0x1007_8aa9, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_8aac, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x1007_8aaf, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1007_8ab2, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_8ab5, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x1007_8ab8, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1007_8abb, 3); mov(eax, memd[ss, ebp - 0x3c]);         /* mov eax, [ebp-0x3c] */
            ii(0x1007_8abe, 5); call(0x100a_30a2, 0x2_a5df);            /* call 0x100a30a2 */
            ii(0x1007_8ac3, 2); test(al, al);                           /* test al, al */
            ii(0x1007_8ac5, 2); if(jz(0x1007_8ac9, 0x2)) goto l_0x1007_8ac9; /* jz 0x10078ac9 */
        l_0x1007_8ac7:
            ii(0x1007_8ac7, 2); jmp(0x1007_8adc, 0x13); goto l_0x1007_8adc; /* jmp 0x10078adc */
        l_0x1007_8ac9:
            ii(0x1007_8ac9, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x1007_8acd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_8acf, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x1007_8ad2, 5); call(0x1008_8e0c, 0x1_0335);            /* call 0x10088e0c */
            ii(0x1007_8ad7, 5); jmp(0x1007_8d3f, 0x263); goto l_0x1007_8d3f; /* jmp 0x10078d3f */
        l_0x1007_8adc:
            ii(0x1007_8adc, 3); mov(eax, memd[ss, ebp - 0x3c]);         /* mov eax, [ebp-0x3c] */
            ii(0x1007_8adf, 5); call(0x1008_aa04, 0x1_1f20);            /* call 0x1008aa04 */
            ii(0x1007_8ae4, 2); test(al, al);                           /* test al, al */
            ii(0x1007_8ae6, 2); if(jz(0x1007_8b59, 0x71)) goto l_0x1007_8b59; /* jz 0x10078b59 */
            ii(0x1007_8ae8, 5); mov(eax, 0x17);                         /* mov eax, 0x17 */
            ii(0x1007_8aed, 5); call(Definitions.sys_new, 0xe_d30e);    /* call 0x10165e00 */
            ii(0x1007_8af2, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
            ii(0x1007_8af5, 3); mov(eax, memd[ss, ebp - 0x40]);         /* mov eax, [ebp-0x40] */
            ii(0x1007_8af8, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
            ii(0x1007_8afb, 4); cmp(memd[ss, ebp - 0x44], 0);           /* cmp dword [ebp-0x44], 0x0 */
            ii(0x1007_8aff, 2); if(jz(0x1007_8b17, 0x16)) goto l_0x1007_8b17; /* jz 0x10078b17 */
            ii(0x1007_8b01, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1007_8b04, 3); mov(eax, memd[ss, ebp - 0x40]);         /* mov eax, [ebp-0x40] */
            ii(0x1007_8b07, 5); call(0x1007_ee7d, 0x6371);              /* call 0x1007ee7d */
            ii(0x1007_8b0c, 3); mov(memd[ss, ebp - 0x48], eax);         /* mov [ebp-0x48], eax */
            ii(0x1007_8b0f, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x1007_8b12, 3); mov(memd[ss, ebp - 0x4c], eax);         /* mov [ebp-0x4c], eax */
            ii(0x1007_8b15, 2); jmp(0x1007_8b1d, 0x6); goto l_0x1007_8b1d; /* jmp 0x10078b1d */
        l_0x1007_8b17:
            ii(0x1007_8b17, 3); mov(eax, memd[ss, ebp - 0x44]);         /* mov eax, [ebp-0x44] */
            ii(0x1007_8b1a, 3); mov(memd[ss, ebp - 0x4c], eax);         /* mov [ebp-0x4c], eax */
        l_0x1007_8b1d:
            ii(0x1007_8b1d, 3); mov(edx, memd[ss, ebp - 0x4c]);         /* mov edx, [ebp-0x4c] */
            ii(0x1007_8b20, 3); lea(eax, memd[ss, ebp - 0x50]);         /* lea eax, [ebp-0x50] */
            ii(0x1007_8b23, 5); call(0x1008_b060, 0x1_2538);            /* call 0x1008b060 */
            ii(0x1007_8b28, 3); lea(eax, memd[ss, ebp - 0x50]);         /* lea eax, [ebp-0x50] */
            ii(0x1007_8b2b, 5); call(0x1008_af84, 0x1_2454);            /* call 0x1008af84 */
            ii(0x1007_8b30, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_8b32, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1007_8b37, 5); call(0x100a_4d50, 0x2_c214);            /* call 0x100a4d50 */
            ii(0x1007_8b3c, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
            ii(0x1007_8b40, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_8b42, 3); lea(eax, memd[ss, ebp - 0x50]);         /* lea eax, [ebp-0x50] */
            ii(0x1007_8b45, 5); call(0x1008_8b7c, 0x1_0032);            /* call 0x10088b7c */
            ii(0x1007_8b4a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_8b4c, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x1007_8b4f, 5); call(0x1008_8e0c, 0x1_02b8);            /* call 0x10088e0c */
            ii(0x1007_8b54, 5); jmp(0x1007_8d3f, 0x1e6); goto l_0x1007_8d3f; /* jmp 0x10078d3f */
        l_0x1007_8b59:
            ii(0x1007_8b59, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x1007_8b5e, 5); call(0x1007_5fdc, -0x2b87);             /* call 0x10075fdc */
            ii(0x1007_8b63, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1007_8b66, 2); if(jge(0x1007_8b6c, 0x4)) goto l_0x1007_8b6c; /* jge 0x10078b6c */
            ii(0x1007_8b68, 4); mov(memb[ss, ebp - 0x4], 0);            /* mov byte [ebp-0x4], 0x0 */
        l_0x1007_8b6c:
            ii(0x1007_8b6c, 4); cmp(memb[ss, ebp - 0x4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1007_8b70, 2); if(jz(0x1007_8b81, 0xf)) goto l_0x1007_8b81; /* jz 0x10078b81 */
            ii(0x1007_8b72, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_8b75, 3); mov(al, memb[ds, eax + 0x4e]);          /* mov al, [eax+0x4e] */
            ii(0x1007_8b78, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_8b7d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_8b7f, 2); if(jg(0x1007_8b86, 0x5)) goto l_0x1007_8b86; /* jg 0x10078b86 */
        l_0x1007_8b81:
            ii(0x1007_8b81, 5); jmp(0x1007_8d1a, 0x194); goto l_0x1007_8d1a; /* jmp 0x10078d1a */
        l_0x1007_8b86:
            ii(0x1007_8b86, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_8b89, 5); call(0x1007_623c, -0x2952);             /* call 0x1007623c */
            ii(0x1007_8b8e, 4); cmp(memb[ds, eax + 0x16], 0);           /* cmp byte [eax+0x16], 0x0 */
            ii(0x1007_8b92, 2); if(jz(0x1007_8ba7, 0x13)) goto l_0x1007_8ba7; /* jz 0x10078ba7 */
            ii(0x1007_8b94, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x1007_8b99, 5); call(0x1007_5fdc, -0x2bc2);             /* call 0x10075fdc */
            ii(0x1007_8b9e, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1007_8ba1, 6); if(jge(0x1007_8d1a, 0x173)) goto l_0x1007_8d1a; /* jge 0x10078d1a */
        l_0x1007_8ba7:
            ii(0x1007_8ba7, 3); mov(eax, memd[ss, ebp - 0x3c]);         /* mov eax, [ebp-0x3c] */
            ii(0x1007_8baa, 5); call(0x1007_623c, -0x2973);             /* call 0x1007623c */
            ii(0x1007_8baf, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_8bb1, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_8bb4, 5); call(0x1007_623c, -0x297d);             /* call 0x1007623c */
            ii(0x1007_8bb9, 4); mov(dx, memw[ds, edx + 0x8]);           /* mov dx, [edx+0x8] */
            ii(0x1007_8bbd, 4); cmp(dx, memw[ds, eax + 0x8]);           /* cmp dx, [eax+0x8] */
            ii(0x1007_8bc1, 2); if(jl(0x1007_8bef, 0x2c)) goto l_0x1007_8bef; /* jl 0x10078bef */
            ii(0x1007_8bc3, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_8bc6, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1007_8bc8, 3); mov(cl, memb[ds, eax + 0x50]);          /* mov cl, [eax+0x50] */
            ii(0x1007_8bcb, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1007_8bcd, 3); mov(edx, memd[ss, ebp - 0x3c]);         /* mov edx, [ebp-0x3c] */
            ii(0x1007_8bd0, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_8bd3, 5); call(0x1015_d211, 0xe_4639);            /* call 0x1015d211 */
            ii(0x1007_8bd8, 1); cwde();                                 /* cwde */
            ii(0x1007_8bd9, 3); imul(ecx, eax);                         /* imul ecx, eax */
            ii(0x1007_8bdc, 3); mov(eax, memd[ss, ebp - 0x3c]);         /* mov eax, [ebp-0x3c] */
            ii(0x1007_8bdf, 3); mov(al, memb[ds, eax + 0x4d]);          /* mov al, [eax+0x4d] */
            ii(0x1007_8be2, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_8be7, 2); cmp(ecx, eax);                          /* cmp ecx, eax */
            ii(0x1007_8be9, 6); if(jge(0x1007_8d1a, 0x12b)) goto l_0x1007_8d1a; /* jge 0x10078d1a */
        l_0x1007_8bef:
            ii(0x1007_8bef, 7); mov(memd[ss, ebp - 0x54], 0);           /* mov dword [ebp-0x54], 0x0 */
            ii(0x1007_8bf6, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_8bf9, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x1007_8bfc, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1007_8bff, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_8c02, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x1007_8c05, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1007_8c08, 3); lea(eax, memd[ss, ebp - 0x58]);         /* lea eax, [ebp-0x58] */
            ii(0x1007_8c0b, 5); call(0x1007_6aac, -0x2164);             /* call 0x10076aac */
            ii(0x1007_8c10, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1007_8c15, 1); push(eax);                              /* push eax */
            ii(0x1007_8c16, 5); mov(ecx, 0x2);                          /* mov ecx, 0x2 */
            ii(0x1007_8c1b, 3); lea(edx, memd[ss, ebp - 0x58]);         /* lea edx, [ebp-0x58] */
            ii(0x1007_8c1e, 3); lea(eax, memd[ss, ebp - 0x5c]);         /* lea eax, [ebp-0x5c] */
            ii(0x1007_8c21, 5); call(0x1007_5e64, -0x2dc2);             /* call 0x10075e64 */
            ii(0x1007_8c26, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1007_8c28, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1007_8c2b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_8c2e, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1007_8c31, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_8c36, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x1007_8c3c, 5); mov(esi, 0x101c_31c4);                  /* mov esi, 0x101c31c4 */
            ii(0x1007_8c41, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1007_8c43, 5); call(0x100c_20df, 0x4_9497);            /* call 0x100c20df */
            ii(0x1007_8c48, 3); mov(memd[ss, ebp - 0x54], eax);         /* mov [ebp-0x54], eax */
            ii(0x1007_8c4b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_8c4e, 3); mov(al, memb[ds, eax + 0x4d]);          /* mov al, [eax+0x4d] */
            ii(0x1007_8c51, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_8c56, 4); movsx(edx, memw[ss, ebp - 0x54]);       /* movsx edx, word [ebp-0x54] */
            ii(0x1007_8c5a, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_8c5c, 6); if(jl(0x1007_8d1a, 0xb8)) goto l_0x1007_8d1a; /* jl 0x10078d1a */
            ii(0x1007_8c62, 5); mov(ecx, 0x2);                          /* mov ecx, 0x2 */
            ii(0x1007_8c67, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_8c6a, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1007_8c6d, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1007_8c6f, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1007_8c72, 5); mov(edx, 0x101c_81a8);                  /* mov edx, 0x101c81a8 */
            ii(0x1007_8c77, 3); mov(eax, memd[ss, ebp - 0x3c]);         /* mov eax, [ebp-0x3c] */
            ii(0x1007_8c7a, 5); call(0x1007_7d8b, -0xef4);              /* call 0x10077d8b */
            ii(0x1007_8c7f, 2); test(al, al);                           /* test al, al */
            ii(0x1007_8c81, 2); if(jnz(0x1007_8ca4, 0x21)) goto l_0x1007_8ca4; /* jnz 0x10078ca4 */
            ii(0x1007_8c83, 5); mov(ecx, 0x2);                          /* mov ecx, 0x2 */
            ii(0x1007_8c88, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_8c8b, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1007_8c8e, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1007_8c90, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1007_8c93, 5); mov(edx, 0x101c_8184);                  /* mov edx, 0x101c8184 */
            ii(0x1007_8c98, 3); mov(eax, memd[ss, ebp - 0x3c]);         /* mov eax, [ebp-0x3c] */
            ii(0x1007_8c9b, 5); call(0x1007_7d8b, -0xf15);              /* call 0x10077d8b */
            ii(0x1007_8ca0, 2); test(al, al);                           /* test al, al */
            ii(0x1007_8ca2, 2); if(jz(0x1007_8cb7, 0x13)) goto l_0x1007_8cb7; /* jz 0x10078cb7 */
        l_0x1007_8ca4:
            ii(0x1007_8ca4, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
            ii(0x1007_8ca8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_8caa, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x1007_8cad, 5); call(0x1008_8e0c, 0x1_015a);            /* call 0x10088e0c */
            ii(0x1007_8cb2, 5); jmp(0x1007_8d3f, 0x88); goto l_0x1007_8d3f; /* jmp 0x10078d3f */
        l_0x1007_8cb7:
            ii(0x1007_8cb7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_8cb9, 1); push(eax);                              /* push eax */
            ii(0x1007_8cba, 5); mov(ecx, 0x2);                          /* mov ecx, 0x2 */
            ii(0x1007_8cbf, 4); movsx(ebx, memw[ss, ebp - 0x54]);       /* movsx ebx, word [ebp-0x54] */
            ii(0x1007_8cc3, 3); mov(edx, memd[ss, ebp - 0x3c]);         /* mov edx, [ebp-0x3c] */
            ii(0x1007_8cc6, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_8cc9, 5); call(0x1007_80c3, -0xc0b);              /* call 0x100780c3 */
            ii(0x1007_8cce, 2); test(al, al);                           /* test al, al */
            ii(0x1007_8cd0, 2); if(jnz(0x1007_8ce1, 0xf)) goto l_0x1007_8ce1; /* jnz 0x10078ce1 */
            ii(0x1007_8cd2, 3); mov(edx, memd[ss, ebp - 0x3c]);         /* mov edx, [ebp-0x3c] */
            ii(0x1007_8cd5, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_8cd8, 5); call(0x1007_6f5d, -0x1d80);             /* call 0x10076f5d */
            ii(0x1007_8cdd, 2); test(al, al);                           /* test al, al */
            ii(0x1007_8cdf, 2); if(jz(0x1007_8ce3, 0x2)) goto l_0x1007_8ce3; /* jz 0x10078ce3 */
        l_0x1007_8ce1:
            ii(0x1007_8ce1, 2); jmp(0x1007_8d1a, 0x37); goto l_0x1007_8d1a; /* jmp 0x10078d1a */
        l_0x1007_8ce3:
            ii(0x1007_8ce3, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_8ce6, 5); call(0x100a_9d1a, 0x3_102f);            /* call 0x100a9d1a */
            ii(0x1007_8ceb, 3); movsx(ebx, al);                         /* movsx ebx, al */
            ii(0x1007_8cee, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1007_8cf1, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_8cf3, 5); call(0x100a_346a, 0x2_a772);            /* call 0x100a346a */
            ii(0x1007_8cf8, 2); test(al, al);                           /* test al, al */
            ii(0x1007_8cfa, 2); if(jz(0x1007_8d1a, 0x1e)) goto l_0x1007_8d1a; /* jz 0x10078d1a */
            ii(0x1007_8cfc, 4); cmp(memb[ss, ebp - 0x38], 0);           /* cmp byte [ebp-0x38], 0x0 */
            ii(0x1007_8d00, 2); if(jz(0x1007_8d0a, 0x8)) goto l_0x1007_8d0a; /* jz 0x10078d0a */
            ii(0x1007_8d02, 3); mov(eax, memd[ss, ebp - 0x3c]);         /* mov eax, [ebp-0x3c] */
            ii(0x1007_8d05, 5); call(0x1007_87ff, -0x50b);              /* call 0x100787ff */
        l_0x1007_8d0a:
            ii(0x1007_8d0a, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x1007_8d0e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_8d10, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x1007_8d13, 5); call(0x1008_8e0c, 0x1_00f4);            /* call 0x10088e0c */
            ii(0x1007_8d18, 2); jmp(0x1007_8d3f, 0x25); goto l_0x1007_8d3f; /* jmp 0x10078d3f */
        l_0x1007_8d1a:
            ii(0x1007_8d1a, 3); mov(edx, memd[ss, ebp - 0x3c]);         /* mov edx, [ebp-0x3c] */
            ii(0x1007_8d1d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_8d20, 5); call(0x1007_7913, -0x1412);             /* call 0x10077913 */
            ii(0x1007_8d25, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
            ii(0x1007_8d29, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_8d2b, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x1007_8d2e, 5); call(0x1008_8e0c, 0x1_00d9);            /* call 0x10088e0c */
            ii(0x1007_8d33, 2); jmp(0x1007_8d3f, 0xa); goto l_0x1007_8d3f; /* jmp 0x10078d3f */
        //  ii(0x1007_8d35, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1007_8d37, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
        //  ii(0x1007_8d3a, 5); call(0x1008_8e0c, 0x1_00cd);            /* call 0x10088e0c */
        l_0x1007_8d3f:
            ii(0x1007_8d3f, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1007_8d42, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_8d44, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_8d45, 1); pop(edi);                               /* pop edi */
            ii(0x1007_8d46, 1); pop(esi);                               /* pop esi */
            ii(0x1007_8d47, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_8d48, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_8d49, 1); ret();                                  /* ret */
        }
    }
}
