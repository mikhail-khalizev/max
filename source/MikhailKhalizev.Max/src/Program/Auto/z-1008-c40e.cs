using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("da6d9795-133e-4848-9ffd-b696d3cc4737")]
        public void Method_1008_c40e()
        {
            ii(0x1008_c40e, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x1008_c413, 5); calld(Definitions.sys_check_available_stack_size, 0xd_993a); /* call 0x10165d52 */
            ii(0x1008_c418, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_c419, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_c41a, 1); pushd(edx);                             /* push edx */
            ii(0x1008_c41b, 1); pushd(esi);                             /* push esi */
            ii(0x1008_c41c, 1); pushd(edi);                             /* push edi */
            ii(0x1008_c41d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_c41e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_c420, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1008_c426, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_c429, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x1008_c42e, 5); calld(0x1007_6338, -0x1_60fb);          /* call 0x10076338 */
            ii(0x1008_c433, 3); lea(ebx, ebp - 0x14);                   /* lea ebx, [ebp-0x14] */
            ii(0x1008_c436, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_c438, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1008_c43a, 5); calld(0x1007_64b8, -0x1_5f87);          /* call 0x100764b8 */
            ii(0x1008_c43f, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1008_c446, 2); jmpd(0x1008_c450, 0x8); goto l_0x1008_c450; /* jmp 0x1008c450 */
        l_0x1008_c448:
            ii(0x1008_c448, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1008_c44b, 5); calld(0x1007_6bf8, -0x1_5858);          /* call 0x10076bf8 */
        l_0x1008_c450:
            ii(0x1008_c450, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_c452, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1008_c455, 5); calld(0x1013_ad71, 0xa_e917);           /* call 0x1013ad71 */
            ii(0x1008_c45a, 2); test(al, al);                           /* test al, al */
            ii(0x1008_c45c, 6); if(jzd(0x1008_c60a, 0x1a8)) goto l_0x1008_c60a; /* jz 0x1008c60a */
            ii(0x1008_c462, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1008_c465, 5); calld(0x1007_63a0, -0x1_60ca);          /* call 0x100763a0 */
            ii(0x1008_c46a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_c46c, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1008_c46f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_c472, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1008_c475, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_c478, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1008_c47a, 2); if(jnzd(0x1008_c496, 0x1a)) goto l_0x1008_c496; /* jnz 0x1008c496 */
            ii(0x1008_c47c, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1008_c47f, 5); calld(0x1007_63a0, -0x1_60e4);          /* call 0x100763a0 */
            ii(0x1008_c484, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1008_c487, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_c48a, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1008_c48d, 7); cmp(memb_a32[ds, eax + 0x101c_81d5], 0x1); /* cmp byte [eax+0x101c81d5], 0x1 */
            ii(0x1008_c494, 2); if(jzd(0x1008_c498, 0x2)) goto l_0x1008_c498; /* jz 0x1008c498 */
        l_0x1008_c496:
            ii(0x1008_c496, 2); jmpd(0x1008_c4aa, 0x12); goto l_0x1008_c4aa; /* jmp 0x1008c4aa */
        l_0x1008_c498:
            ii(0x1008_c498, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1008_c49b, 5); calld(0x1007_63a0, -0x1_6100);          /* call 0x100763a0 */
            ii(0x1008_c4a0, 3); mov(eax, memd_a32[ds, eax + 0x50]);     /* mov eax, [eax+0x50] */
            ii(0x1008_c4a3, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_c4a6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_c4a8, 2); if(jgd(0x1008_c4ac, 0x2)) goto l_0x1008_c4ac; /* jg 0x1008c4ac */
        l_0x1008_c4aa:
            ii(0x1008_c4aa, 2); jmpd(0x1008_c4c0, 0x14); goto l_0x1008_c4c0; /* jmp 0x1008c4c0 */
        l_0x1008_c4ac:
            ii(0x1008_c4ac, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1008_c4af, 5); calld(0x1007_63a0, -0x1_6114);          /* call 0x100763a0 */
            ii(0x1008_c4b4, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x1008_c4b7, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_c4bc, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_c4be, 2); if(jgd(0x1008_c4c2, 0x2)) goto l_0x1008_c4c2; /* jg 0x1008c4c2 */
        l_0x1008_c4c0:
            ii(0x1008_c4c0, 2); jmpd(0x1008_c4f6, 0x34); goto l_0x1008_c4f6; /* jmp 0x1008c4f6 */
        l_0x1008_c4c2:
            ii(0x1008_c4c2, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1008_c4c5, 5); calld(0x1007_63a0, -0x1_612a);          /* call 0x100763a0 */
            ii(0x1008_c4ca, 4); cmp(memb_a32[ds, eax + 0x3d], 0);       /* cmp byte [eax+0x3d], 0x0 */
            ii(0x1008_c4ce, 2); if(jzd(0x1008_c4f4, 0x24)) goto l_0x1008_c4f4; /* jz 0x1008c4f4 */
            ii(0x1008_c4d0, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1008_c4d3, 5); calld(0x1007_63a0, -0x1_6138);          /* call 0x100763a0 */
            ii(0x1008_c4d8, 4); cmp(memb_a32[ds, eax + 0x3d], 0x2);     /* cmp byte [eax+0x3d], 0x2 */
            ii(0x1008_c4dc, 2); if(jnzd(0x1008_c4f2, 0x14)) goto l_0x1008_c4f2; /* jnz 0x1008c4f2 */
            ii(0x1008_c4de, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1008_c4e1, 5); calld(0x1007_63a0, -0x1_6146);          /* call 0x100763a0 */
            ii(0x1008_c4e6, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x1008_c4e9, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_c4ee, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_c4f0, 2); if(jzd(0x1008_c4f4, 0x2)) goto l_0x1008_c4f4; /* jz 0x1008c4f4 */
        l_0x1008_c4f2:
            ii(0x1008_c4f2, 2); jmpd(0x1008_c4f6, 0x2); goto l_0x1008_c4f6; /* jmp 0x1008c4f6 */
        l_0x1008_c4f4:
            ii(0x1008_c4f4, 2); jmpd(0x1008_c4f8, 0x2); goto l_0x1008_c4f8; /* jmp 0x1008c4f8 */
        l_0x1008_c4f6:
            ii(0x1008_c4f6, 2); jmpd(0x1008_c50f, 0x17); goto l_0x1008_c50f; /* jmp 0x1008c50f */
        l_0x1008_c4f8:
            ii(0x1008_c4f8, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_c4fb, 3); add(edx, 0x13);                         /* add edx, 0x13 */
            ii(0x1008_c4fe, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1008_c501, 5); calld(0x1007_6408, -0x1_60fe);          /* call 0x10076408 */
            ii(0x1008_c506, 5); calld(0x1008_b4b4, -0x1057);            /* call 0x1008b4b4 */
            ii(0x1008_c50b, 2); test(al, al);                           /* test al, al */
            ii(0x1008_c50d, 2); if(jnzd(0x1008_c514, 0x5)) goto l_0x1008_c514; /* jnz 0x1008c514 */
        l_0x1008_c50f:
            ii(0x1008_c50f, 5); jmpd(0x1008_c605, 0xf1); goto l_0x1008_c605; /* jmp 0x1008c605 */
        l_0x1008_c514:
            ii(0x1008_c514, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1008_c517, 5); calld(0x1007_63a0, -0x1_617c);          /* call 0x100763a0 */
            ii(0x1008_c51c, 5); calld(0x1015_26ac, 0xc_618b);           /* call 0x101526ac */
            ii(0x1008_c521, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_c523, 2); if(jnzd(0x1008_c52e, 0x9)) goto l_0x1008_c52e; /* jnz 0x1008c52e */
            ii(0x1008_c525, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1008_c529, 5); jmpd(0x1008_c5c2, 0x94); goto l_0x1008_c5c2; /* jmp 0x1008c5c2 */
        l_0x1008_c52e:
            ii(0x1008_c52e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_c531, 3); mov(edx, memd_a32[ds, eax + 0xb]);      /* mov edx, [eax+0xb] */
            ii(0x1008_c534, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_c537, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1008_c53a, 5); calld(0x1007_63a0, -0x1_619f);          /* call 0x100763a0 */
            ii(0x1008_c53f, 5); calld(0x1015_26ac, 0xc_6168);           /* call 0x101526ac */
            ii(0x1008_c544, 5); calld(0x100a_2bc4, 0x1_667b);           /* call 0x100a2bc4 */
            ii(0x1008_c549, 1); cwde();                                 /* cwde */
            ii(0x1008_c54a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_c54c, 2); if(jled(0x1008_c557, 0x9)) goto l_0x1008_c557; /* jle 0x1008c557 */
            ii(0x1008_c54e, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1008_c552, 5); jmpd(0x1008_c5c2, 0x6b); goto l_0x1008_c5c2; /* jmp 0x1008c5c2 */
        l_0x1008_c557:
            ii(0x1008_c557, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_c55a, 3); mov(edx, memd_a32[ds, eax + 0xb]);      /* mov edx, [eax+0xb] */
            ii(0x1008_c55d, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_c560, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1008_c563, 5); calld(0x1007_63a0, -0x1_61c8);          /* call 0x100763a0 */
            ii(0x1008_c568, 5); calld(0x1015_26ac, 0xc_613f);           /* call 0x101526ac */
            ii(0x1008_c56d, 5); calld(0x100a_2bc4, 0x1_6652);           /* call 0x100a2bc4 */
            ii(0x1008_c572, 1); cwde();                                 /* cwde */
            ii(0x1008_c573, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_c575, 2); if(jnzd(0x1008_c597, 0x20)) goto l_0x1008_c597; /* jnz 0x1008c597 */
            ii(0x1008_c577, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1008_c57a, 5); calld(0x1007_63a0, -0x1_61df);          /* call 0x100763a0 */
            ii(0x1008_c57f, 5); calld(0x1015_26ac, 0xc_6128);           /* call 0x101526ac */
            ii(0x1008_c584, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1008_c587, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1008_c58a, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1008_c58d, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1008_c590, 3); calld_abs(memd_a32[ds, edx + 0x20]);    /* call dword [edx+0x20] */
            ii(0x1008_c593, 2); cmp(al, 0x12);                          /* cmp al, 0x12 */
            ii(0x1008_c595, 2); if(jzd(0x1008_c599, 0x2)) goto l_0x1008_c599; /* jz 0x1008c599 */
        l_0x1008_c597:
            ii(0x1008_c597, 2); jmpd(0x1008_c5b6, 0x1d); goto l_0x1008_c5b6; /* jmp 0x1008c5b6 */
        l_0x1008_c599:
            ii(0x1008_c599, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1008_c59c, 5); calld(0x1007_63a0, -0x1_6201);          /* call 0x100763a0 */
            ii(0x1008_c5a1, 5); calld(0x1015_26ac, 0xc_6106);           /* call 0x101526ac */
            ii(0x1008_c5a6, 5); calld(0x1009_c9d4, 0x1_0429);           /* call 0x1009c9d4 */
            ii(0x1008_c5ab, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_c5ad, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_c5b0, 4); cmp(dx, memw_a32[ds, eax + 0xb]);       /* cmp dx, [eax+0xb] */
            ii(0x1008_c5b4, 2); if(jgd(0x1008_c5b8, 0x2)) goto l_0x1008_c5b8; /* jg 0x1008c5b8 */
        l_0x1008_c5b6:
            ii(0x1008_c5b6, 2); jmpd(0x1008_c5be, 0x6); goto l_0x1008_c5be; /* jmp 0x1008c5be */
        l_0x1008_c5b8:
            ii(0x1008_c5b8, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1008_c5bc, 2); jmpd(0x1008_c5c2, 0x4); goto l_0x1008_c5c2; /* jmp 0x1008c5c2 */
        l_0x1008_c5be:
            ii(0x1008_c5be, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
        l_0x1008_c5c2:
            ii(0x1008_c5c2, 4); cmp(memb_a32[ss, ebp - 0x8], 0);        /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1008_c5c6, 2); if(jzd(0x1008_c605, 0x3d)) goto l_0x1008_c605; /* jz 0x1008c605 */
            ii(0x1008_c5c8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_c5cb, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_c5ce, 5); calld(0x1008_abbc, -0x1a17);            /* call 0x1008abbc */
            ii(0x1008_c5d3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_c5d5, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1008_c5d8, 5); calld(0x1007_636c, -0x1_6271);          /* call 0x1007636c */
            ii(0x1008_c5dd, 5); calld(0x100a_601a, 0x1_9a38);           /* call 0x100a601a */
            ii(0x1008_c5e2, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1008_c5e5, 4); cmp(memd_a32[ss, ebp - 0x10], 0);       /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1008_c5e9, 2); if(jzd(0x1008_c5f4, 0x9)) goto l_0x1008_c5f4; /* jz 0x1008c5f4 */
            ii(0x1008_c5eb, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1008_c5ee, 4); cmp(ax, memw_a32[ss, ebp - 0xc]);       /* cmp ax, [ebp-0xc] */
            ii(0x1008_c5f2, 2); if(jged(0x1008_c605, 0x11)) goto l_0x1008_c605; /* jge 0x1008c605 */
        l_0x1008_c5f4:
            ii(0x1008_c5f4, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1008_c5f7, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_c5fa, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1008_c5fd, 5); calld(0x1007_6408, -0x1_61fa);          /* call 0x10076408 */
            ii(0x1008_c602, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
        l_0x1008_c605:
            ii(0x1008_c605, 5); jmpd(0x1008_c448, -0x1c2); goto l_0x1008_c448; /* jmp 0x1008c448 */
        l_0x1008_c60a:
            ii(0x1008_c60a, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1008_c60d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_c610, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1008_c613, 5); calld(0x1007_6630, -0x1_5fe8);          /* call 0x10076630 */
            ii(0x1008_c618, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_c61a, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1008_c61d, 5); calld(0x1007_5f6c, -0x1_66b6);          /* call 0x10075f6c */
            ii(0x1008_c622, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_c624, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_c625, 1); popd(edi);                              /* pop edi */
            ii(0x1008_c626, 1); popd(esi);                              /* pop esi */
            ii(0x1008_c627, 1); popd(edx);                              /* pop edx */
            ii(0x1008_c628, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_c629, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_c62a, 1); retd(); return;                         /* ret */
        }
    }
}
