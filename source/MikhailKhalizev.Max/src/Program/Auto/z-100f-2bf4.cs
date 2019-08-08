using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("975b08a8-21c8-441f-827c-12fdc676901e")]
        public void Method_100f_2bf4()
        {
            ii(0x100f_2bf4, 5); pushd(0xda4);                           /* push 0xda4 */
            ii(0x100f_2bf9, 5); calld(Definitions.sys_check_available_stack_size, 0x7_3154); /* call 0x10165d52 */
            ii(0x100f_2bfe, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_2bff, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_2c00, 1); pushd(edx);                             /* push edx */
            ii(0x100f_2c01, 1); pushd(esi);                             /* push esi */
            ii(0x100f_2c02, 1); pushd(edi);                             /* push edi */
            ii(0x100f_2c03, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_2c04, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_2c06, 6); sub(esp, 0xd78);                        /* sub esp, 0xd78 */
            ii(0x100f_2c0c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100f_2c0f, 3); lea(edi, ebp - 0x20);                   /* lea edi, [ebp-0x20] */
            ii(0x100f_2c12, 5); mov(esi, 0x101b_8aa0);                  /* mov esi, 0x101b8aa0 */
            ii(0x100f_2c17, 1); movsd_a32();                            /* movsd */
            ii(0x100f_2c18, 1); movsd_a32();                            /* movsd */
            ii(0x100f_2c19, 1); movsd_a32();                            /* movsd */
            ii(0x100f_2c1a, 3); lea(edi, ebp - 0x2c);                   /* lea edi, [ebp-0x2c] */
            ii(0x100f_2c1d, 5); mov(esi, 0x101b_8aac);                  /* mov esi, 0x101b8aac */
            ii(0x100f_2c22, 1); movsd_a32();                            /* movsd */
            ii(0x100f_2c23, 1); movsd_a32();                            /* movsd */
            ii(0x100f_2c24, 1); movsd_a32();                            /* movsd */
            ii(0x100f_2c25, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x100f_2c2c, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x100f_2c33, 7); mov(memb_a32[ss, ebp - 0xbe4], 0);      /* mov byte [ebp-0xbe4], 0x0 */
            ii(0x100f_2c3a, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x100f_2c3e, 7); mov(memd_a32[ss, ebp - 0x14], 0x5c);    /* mov dword [ebp-0x14], 0x5c */
            ii(0x100f_2c45, 2); jmpd(0x100f_2c4d, 0x6); goto l_0x100f_2c4d; /* jmp 0x100f2c4d */
        l_0x100f_2c47:
            ii(0x100f_2c47, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100f_2c4a, 3); dec(memd_a32[ss, ebp - 0x14]);          /* dec dword [ebp-0x14] */
        l_0x100f_2c4d:
            ii(0x100f_2c4d, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_2c51, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_2c53, 6); if(jld(0x100f_2dcd, 0x174)) goto l_0x100f_2dcd; /* jl 0x100f2dcd */
            ii(0x100f_2c59, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_2c5d, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100f_2c5f, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x100f_2c62, 4); cmp(memw_a32[ds, eax], 0);              /* cmp word [eax], 0x0 */
            ii(0x100f_2c66, 6); if(jzd(0x100f_2dc8, 0x15c)) goto l_0x100f_2dc8; /* jz 0x100f2dc8 */
            ii(0x100f_2c6c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_2c6e, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_2c73, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100f_2c76, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_2c7a, 5); calld(0x100d_4b64, -0x1_e11b);          /* call 0x100d4b64 */
            ii(0x100f_2c7f, 1); cwde();                                 /* cwde */
            ii(0x100f_2c80, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100f_2c83, 2); if(jled(0x100f_2c89, 0x4)) goto l_0x100f_2c89; /* jle 0x100f2c89 */
            ii(0x100f_2c85, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
        l_0x100f_2c89:
            ii(0x100f_2c89, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_2c8d, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100f_2c8f, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x100f_2c92, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100f_2c95, 3); add(memd_a32[ss, ebp - 0x10], eax);     /* add [ebp-0x10], eax */
            ii(0x100f_2c98, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_2c9b, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
            ii(0x100f_2c9e, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_2ca2, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100f_2ca4, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x100f_2ca7, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100f_2caa, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100f_2cad, 2); if(jled(0x100f_2cf1, 0x42)) goto l_0x100f_2cf1; /* jle 0x100f2cf1 */
            ii(0x100f_2caf, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_2cb3, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100f_2cb6, 6); pushd(memd_a32[ds, eax + 0x101c_81db]); /* push dword [eax+0x101c81db] */
            ii(0x100f_2cbc, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_2cc0, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100f_2cc2, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x100f_2cc5, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100f_2cc8, 1); pushd(eax);                             /* push eax */
            ii(0x100f_2cc9, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_2ccd, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100f_2cd0, 6); mov(eax, memd_a32[ds, eax + 0x101c_81d3]); /* mov eax, [eax+0x101c81d3] */
            ii(0x100f_2cd6, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x100f_2cd9, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100f_2cdc, 4); pushd(memd_a32[ds, eax + ebp - 0x2c]);  /* push dword [eax+ebp-0x2c] */
            ii(0x100f_2ce0, 6); lea(eax, ebp - 0xd74);                  /* lea eax, [ebp-0xd74] */
            ii(0x100f_2ce6, 1); pushd(eax);                             /* push eax */
            ii(0x100f_2ce7, 5); calld(Definitions.sys_sprintf, 0x7_3215); /* call 0x10165f01 */
            ii(0x100f_2cec, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x100f_2cef, 2); jmpd(0x100f_2d24, 0x33); goto l_0x100f_2d24; /* jmp 0x100f2d24 */
        l_0x100f_2cf1:
            ii(0x100f_2cf1, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_2cf5, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100f_2cf8, 6); pushd(memd_a32[ds, eax + 0x101c_81d7]); /* push dword [eax+0x101c81d7] */
            ii(0x100f_2cfe, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_2d02, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100f_2d05, 6); mov(eax, memd_a32[ds, eax + 0x101c_81d3]); /* mov eax, [eax+0x101c81d3] */
            ii(0x100f_2d0b, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x100f_2d0e, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100f_2d11, 4); pushd(memd_a32[ds, eax + ebp - 0x20]);  /* push dword [eax+ebp-0x20] */
            ii(0x100f_2d15, 6); lea(eax, ebp - 0xd74);                  /* lea eax, [ebp-0xd74] */
            ii(0x100f_2d1b, 1); pushd(eax);                             /* push eax */
            ii(0x100f_2d1c, 5); calld(Definitions.sys_sprintf, 0x7_31e0); /* call 0x10165f01 */
            ii(0x100f_2d21, 3); add(esp, 0xc);                          /* add esp, 0xc */
        l_0x100f_2d24:
            ii(0x100f_2d24, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100f_2d28, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100f_2d2b, 2); if(jnzd(0x100f_2d43, 0x16)) goto l_0x100f_2d43; /* jnz 0x100f2d43 */
            ii(0x100f_2d2d, 6); lea(edx, ebp - 0xd74);                  /* lea edx, [ebp-0xd74] */
            ii(0x100f_2d33, 6); lea(eax, ebp - 0xbe4);                  /* lea eax, [ebp-0xbe4] */
            ii(0x100f_2d39, 5); calld(Definitions.sys_strcat, 0x7_31f3); /* call 0x10165f31 */
            ii(0x100f_2d3e, 5); jmpd(0x100f_2dc8, 0x85); goto l_0x100f_2dc8; /* jmp 0x100f2dc8 */
        l_0x100f_2d43:
            ii(0x100f_2d43, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100f_2d47, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100f_2d4a, 2); if(jnzd(0x100f_2d5e, 0x12)) goto l_0x100f_2d5e; /* jnz 0x100f2d5e */
            ii(0x100f_2d4c, 5); mov(edx, StringDefinitions.And);        /* mov edx, 0x101a23cf */
            ii(0x100f_2d51, 6); lea(eax, ebp - 0xd74);                  /* lea eax, [ebp-0xd74] */
            ii(0x100f_2d57, 5); calld(Definitions.sys_strcat, 0x7_31d5); /* call 0x10165f31 */
            ii(0x100f_2d5c, 2); jmpd(0x100f_2d6e, 0x10); goto l_0x100f_2d6e; /* jmp 0x100f2d6e */
        l_0x100f_2d5e:
            ii(0x100f_2d5e, 5); mov(edx, StringDefinitions.Control24);  /* mov edx, 0x101a23d5 */
            ii(0x100f_2d63, 6); lea(eax, ebp - 0xd74);                  /* lea eax, [ebp-0xd74] */
            ii(0x100f_2d69, 5); calld(Definitions.sys_strcat, 0x7_31c3); /* call 0x10165f31 */
        l_0x100f_2d6e:
            ii(0x100f_2d6e, 6); lea(eax, ebp - 0xd74);                  /* lea eax, [ebp-0xd74] */
            ii(0x100f_2d74, 5); calld(Definitions.sys_strlen, 0x7_f14e); /* call 0x10171ec7 */
            ii(0x100f_2d79, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_2d7b, 6); lea(eax, ebp - 0xbe4);                  /* lea eax, [ebp-0xbe4] */
            ii(0x100f_2d81, 5); calld(Definitions.sys_strlen, 0x7_f141); /* call 0x10171ec7 */
            ii(0x100f_2d86, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100f_2d88, 5); cmp(eax, 0xbb9);                        /* cmp eax, 0xbb9 */
            ii(0x100f_2d8d, 2); if(jaed(0x100f_2d9b, 0xc)) goto l_0x100f_2d9b; /* jae 0x100f2d9b */
            ii(0x100f_2d8f, 10); mov(memd_a32[ss, ebp - 0xd78], 0);     /* mov dword [ebp-0xd78], 0x0 */
            ii(0x100f_2d99, 2); jmpd(0x100f_2db7, 0x1c); goto l_0x100f_2db7; /* jmp 0x100f2db7 */
        l_0x100f_2d9b:
            ii(0x100f_2d9b, 5); mov(ecx, 0x592);                        /* mov ecx, 0x592 */
            ii(0x100f_2da0, 5); mov(ebx, StringDefinitions.GamemgrCpp3); /* mov ebx, 0x101a23d8 */
            ii(0x100f_2da5, 5); mov(edx, StringDefinitions.StrlenNewChunkStrlenMessageLessSizeofMessage1); /* mov edx, 0x101a23e4 */
            ii(0x100f_2daa, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_2dac, 5); calld(Definitions.sys_assert, 0x7_2fe1); /* call 0x10165d92 */
            ii(0x100f_2db1, 6); mov(memd_a32[ss, ebp - 0xd78], eax);    /* mov [ebp-0xd78], eax */
        l_0x100f_2db7:
            ii(0x100f_2db7, 6); lea(edx, ebp - 0xbe4);                  /* lea edx, [ebp-0xbe4] */
            ii(0x100f_2dbd, 6); lea(eax, ebp - 0xd74);                  /* lea eax, [ebp-0xd74] */
            ii(0x100f_2dc3, 5); calld(0x100f_2b93, -0x235);             /* call 0x100f2b93 */
        l_0x100f_2dc8:
            ii(0x100f_2dc8, 5); jmpd(0x100f_2c47, -0x186); goto l_0x100f_2c47; /* jmp 0x100f2c47 */
        l_0x100f_2dcd:
            ii(0x100f_2dcd, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100f_2dd1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_2dd3, 6); if(jled(0x100f_2e7b, 0xa2)) goto l_0x100f_2e7b; /* jle 0x100f2e7b */
            ii(0x100f_2dd9, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_2ddb, 6); mov(al, memb_a32[ss, ebp - 0xbe4]);     /* mov al, [ebp-0xbe4] */
            ii(0x100f_2de1, 5); calld(Definitions.sys_tolower, 0x7_fcaf); /* call 0x10172a95 */
            ii(0x100f_2de6, 6); mov(memb_a32[ss, ebp - 0xbe4], al);     /* mov [ebp-0xbe4], al */
            ii(0x100f_2dec, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100f_2df0, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100f_2df3, 2); if(jnzd(0x100f_2e39, 0x44)) goto l_0x100f_2e39; /* jnz 0x100f2e39 */
            ii(0x100f_2df5, 5); mov(edx, StringDefinitions.Is);         /* mov edx, 0x101a2424 */
            ii(0x100f_2dfa, 6); lea(eax, ebp - 0xbe4);                  /* lea eax, [ebp-0xbe4] */
            ii(0x100f_2e00, 5); calld(Definitions.sys_strcat, 0x7_312c); /* call 0x10165f31 */
            ii(0x100f_2e05, 5); mov(edx, StringDefinitions.AvailableThisTurn); /* mov edx, 0x101a2428 */
            ii(0x100f_2e0a, 6); lea(eax, ebp - 0xbe4);                  /* lea eax, [ebp-0xbe4] */
            ii(0x100f_2e10, 5); calld(Definitions.sys_strcat, 0x7_311c); /* call 0x10165f31 */
            ii(0x100f_2e15, 4); cmp(memb_a32[ss, ebp - 0x8], 0);        /* cmp byte [ebp-0x8], 0x0 */
            ii(0x100f_2e19, 2); if(jzd(0x100f_2e37, 0x1c)) goto l_0x100f_2e37; /* jz 0x100f2e37 */
            ii(0x100f_2e1b, 5); calld(0x100d_5470, -0x1_d9b0);          /* call 0x100d5470 */
            ii(0x100f_2e20, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100f_2e23, 5); mov(ebx, 0x454);                        /* mov ebx, 0x454 */
            ii(0x100f_2e28, 5); mov(edx, 0x44f);                        /* mov edx, 0x44f */
            ii(0x100f_2e2d, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_2e32, 5); calld(0x1013_daea, 0x4_acb3);           /* call 0x1013daea */
        l_0x100f_2e37:
            ii(0x100f_2e37, 2); jmpd(0x100f_2e7b, 0x42); goto l_0x100f_2e7b; /* jmp 0x100f2e7b */
        l_0x100f_2e39:
            ii(0x100f_2e39, 5); mov(edx, StringDefinitions.Are);        /* mov edx, 0x101a243e */
            ii(0x100f_2e3e, 6); lea(eax, ebp - 0xbe4);                  /* lea eax, [ebp-0xbe4] */
            ii(0x100f_2e44, 5); calld(Definitions.sys_strcat, 0x7_30e8); /* call 0x10165f31 */
            ii(0x100f_2e49, 5); mov(edx, StringDefinitions.AvailableThisTurn2); /* mov edx, 0x101a2443 */
            ii(0x100f_2e4e, 6); lea(eax, ebp - 0xbe4);                  /* lea eax, [ebp-0xbe4] */
            ii(0x100f_2e54, 5); calld(Definitions.sys_strcat, 0x7_30d8); /* call 0x10165f31 */
            ii(0x100f_2e59, 4); cmp(memb_a32[ss, ebp - 0x8], 0);        /* cmp byte [ebp-0x8], 0x0 */
            ii(0x100f_2e5d, 2); if(jzd(0x100f_2e7b, 0x1c)) goto l_0x100f_2e7b; /* jz 0x100f2e7b */
            ii(0x100f_2e5f, 5); calld(0x100d_5470, -0x1_d9f4);          /* call 0x100d5470 */
            ii(0x100f_2e64, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100f_2e67, 5); mov(ebx, 0x44e);                        /* mov ebx, 0x44e */
            ii(0x100f_2e6c, 5); mov(edx, 0x44b);                        /* mov edx, 0x44b */
            ii(0x100f_2e71, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_2e76, 5); calld(0x1013_daea, 0x4_ac6f);           /* call 0x1013daea */
        l_0x100f_2e7b:
            ii(0x100f_2e7b, 6); pushd(memd_a32[ds, 0x101c_37dc]);       /* push dword [0x101c37dc] */
            ii(0x100f_2e81, 5); mov(eax, StringDefinitions.BeginTurnI); /* mov eax, 0x101a2459 */
            ii(0x100f_2e86, 1); pushd(eax);                             /* push eax */
            ii(0x100f_2e87, 6); lea(eax, ebp - 0xd74);                  /* lea eax, [ebp-0xd74] */
            ii(0x100f_2e8d, 1); pushd(eax);                             /* push eax */
            ii(0x100f_2e8e, 5); calld(Definitions.sys_sprintf, 0x7_306e); /* call 0x10165f01 */
            ii(0x100f_2e93, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x100f_2e96, 6); lea(edx, ebp - 0xbe4);                  /* lea edx, [ebp-0xbe4] */
            ii(0x100f_2e9c, 6); lea(eax, ebp - 0xd74);                  /* lea eax, [ebp-0xd74] */
            ii(0x100f_2ea2, 5); calld(0x100f_2b93, -0x314);             /* call 0x100f2b93 */
            ii(0x100f_2ea7, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_2eac, 1); pushd(eax);                             /* push eax */
            ii(0x100f_2ead, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100f_2eaf, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_2eb1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_2eb3, 6); lea(eax, ebp - 0xbe4);                  /* lea eax, [ebp-0xbe4] */
            ii(0x100f_2eb9, 5); calld(0x1011_5d23, 0x2_2e65);           /* call 0x10115d23 */
            ii(0x100f_2ebe, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_2ec0, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_2ec1, 1); popd(edi);                              /* pop edi */
            ii(0x100f_2ec2, 1); popd(esi);                              /* pop esi */
            ii(0x100f_2ec3, 1); popd(edx);                              /* pop edx */
            ii(0x100f_2ec4, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_2ec5, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_2ec6, 1); retd(); return;                         /* ret */
        }
    }
}
