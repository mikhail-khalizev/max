using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fe96f955-f9e7-4a87-b67b-4117dbf419bb")]
        public void Method_1011_5d23()
        {
            ii(0x1011_5d23, 5); pushd(0xac);                            /* push 0xac */
            ii(0x1011_5d28, 5); calld(Definitions.sys_check_available_stack_size, 0x5_0025); /* call 0x10165d52 */
            ii(0x1011_5d2d, 1); pushd(esi);                             /* push esi */
            ii(0x1011_5d2e, 1); pushd(edi);                             /* push edi */
            ii(0x1011_5d2f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_5d30, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_5d32, 6); sub(esp, 0x9c);                         /* sub esp, 0x9c */
            ii(0x1011_5d38, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_5d3b, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x1011_5d3e, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1011_5d41, 3); mov(memd_a32[ss, ebp - 0xc], ecx);      /* mov [ebp-0xc], ecx */
            ii(0x1011_5d44, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_5d47, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1011_5d49, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_5d4e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_5d50, 6); if(jzd(0x1011_5f96, 0x240)) goto l_0x1011_5f96; /* jz 0x10115f96 */
            ii(0x1011_5d56, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1011_5d5a, 2); if(jzd(0x1011_5d8e, 0x32)) goto l_0x1011_5d8e; /* jz 0x10115d8e */
            ii(0x1011_5d5c, 4); or(memb_a32[ss, ebp - 0x14], 0x1);      /* or byte [ebp-0x14], 0x1 */
            ii(0x1011_5d60, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_5d62, 3); mov(bl, memb_a32[ss, ebp - 0xc]);       /* mov bl, [ebp-0xc] */
            ii(0x1011_5d65, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1011_5d68, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1011_5d6b, 5); calld(0x1011_61a2, 0x432);              /* call 0x101161a2 */
            ii(0x1011_5d70, 3); mov(memd_a32[ss, ebp - 0x68], eax);     /* mov [ebp-0x68], eax */
            ii(0x1011_5d73, 4); and(memb_a32[ss, ebp - 0x14], -0x2 /* 0xfe */); /* and byte [ebp-0x14], 0xfe */
            ii(0x1011_5d77, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1011_5d7a, 5); calld(0x1011_6a19, 0xc9a);              /* call 0x10116a19 */
            ii(0x1011_5d7f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_5d81, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x1011_5d84, 5); calld(0x1011_6536, 0x7ad);              /* call 0x10116536 */
            ii(0x1011_5d89, 5); jmpd(0x1011_5f96, 0x208); goto l_0x1011_5f96; /* jmp 0x10115f96 */
        l_0x1011_5d8e:
            ii(0x1011_5d8e, 7); cmp(memb_a32[ds, 0x101c_391d], 0);      /* cmp byte [0x101c391d], 0x0 */
            ii(0x1011_5d95, 2); if(jzd(0x1011_5d9c, 0x5)) goto l_0x1011_5d9c; /* jz 0x10115d9c */
            ii(0x1011_5d97, 5); calld(0x1011_606c, 0x2d0);              /* call 0x1011606c */
        l_0x1011_5d9c:
            ii(0x1011_5d9c, 4); cmp(memb_a32[ss, ebp + 0x10], 0);       /* cmp byte [ebp+0x10], 0x0 */
            ii(0x1011_5da0, 6); if(jzd(0x1011_5e46, 0xa0)) goto l_0x1011_5e46; /* jz 0x10115e46 */
            ii(0x1011_5da6, 5); mov(eax, 0x15);                         /* mov eax, 0x15 */
            ii(0x1011_5dab, 5); calld(Definitions.sys_new, 0x5_0050);   /* call 0x10165e00 */
            ii(0x1011_5db0, 3); mov(memd_a32[ss, ebp - 0x6c], eax);     /* mov [ebp-0x6c], eax */
            ii(0x1011_5db3, 3); mov(eax, memd_a32[ss, ebp - 0x6c]);     /* mov eax, [ebp-0x6c] */
            ii(0x1011_5db6, 3); mov(memd_a32[ss, ebp - 0x70], eax);     /* mov [ebp-0x70], eax */
            ii(0x1011_5db9, 4); cmp(memd_a32[ss, ebp - 0x70], 0);       /* cmp dword [ebp-0x70], 0x0 */
            ii(0x1011_5dbd, 2); if(jzd(0x1011_5dda, 0x1b)) goto l_0x1011_5dda; /* jz 0x10115dda */
            ii(0x1011_5dbf, 5); mov(ebx, 0x296);                        /* mov ebx, 0x296 */
            ii(0x1011_5dc4, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1011_5dc7, 3); mov(eax, memd_a32[ss, ebp - 0x6c]);     /* mov eax, [ebp-0x6c] */
            ii(0x1011_5dca, 5); calld(0x1011_7635, 0x1866);             /* call 0x10117635 */
            ii(0x1011_5dcf, 3); mov(memd_a32[ss, ebp - 0x74], eax);     /* mov [ebp-0x74], eax */
            ii(0x1011_5dd2, 3); mov(eax, memd_a32[ss, ebp - 0x74]);     /* mov eax, [ebp-0x74] */
            ii(0x1011_5dd5, 3); mov(memd_a32[ss, ebp - 0x78], eax);     /* mov [ebp-0x78], eax */
            ii(0x1011_5dd8, 2); jmpd(0x1011_5de0, 0x6); goto l_0x1011_5de0; /* jmp 0x10115de0 */
        l_0x1011_5dda:
            ii(0x1011_5dda, 3); mov(eax, memd_a32[ss, ebp - 0x70]);     /* mov eax, [ebp-0x70] */
            ii(0x1011_5ddd, 3); mov(memd_a32[ss, ebp - 0x78], eax);     /* mov [ebp-0x78], eax */
        l_0x1011_5de0:
            ii(0x1011_5de0, 3); mov(edx, memd_a32[ss, ebp - 0x78]);     /* mov edx, [ebp-0x78] */
            ii(0x1011_5de3, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_5de5, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1011_5dea, 3); imul(eax, eax, 0xa);                    /* imul eax, eax, 0xa */
            ii(0x1011_5ded, 5); mov(ebx, 0x101c_52bc);                  /* mov ebx, 0x101c52bc */
            ii(0x1011_5df2, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1011_5df4, 5); calld(0x1011_7c3c, 0x1e43);             /* call 0x10117c3c */
            ii(0x1011_5df9, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_5dfb, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1011_5e00, 3); imul(edx, eax, 0xa);                    /* imul edx, eax, 0xa */
            ii(0x1011_5e03, 5); mov(eax, 0x101c_52bc);                  /* mov eax, 0x101c52bc */
            ii(0x1011_5e08, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_5e0a, 5); calld(0x1007_6b90, -0x9_f27f);          /* call 0x10076b90 */
            ii(0x1011_5e0f, 1); cwde();                                 /* cwde */
            ii(0x1011_5e10, 3); cmp(eax, 0x32);                         /* cmp eax, 0x32 */
            ii(0x1011_5e13, 2); if(jled(0x1011_5e46, 0x31)) goto l_0x1011_5e46; /* jle 0x10115e46 */
            ii(0x1011_5e15, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_5e17, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1011_5e1c, 3); imul(eax, eax, 0xa);                    /* imul eax, eax, 0xa */
            ii(0x1011_5e1f, 5); mov(ebx, 0x101c_52bc);                  /* mov ebx, 0x101c52bc */
            ii(0x1011_5e24, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1011_5e26, 5); calld(0x1011_7c6c, 0x1e41);             /* call 0x10117c6c */
            ii(0x1011_5e2b, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_5e2d, 6); mov(bl, memb_a32[ds, 0x101c_37da]);     /* mov bl, [0x101c37da] */
            ii(0x1011_5e33, 3); imul(edx, ebx, 0xa);                    /* imul edx, ebx, 0xa */
            ii(0x1011_5e36, 5); mov(ebx, 0x101c_52bc);                  /* mov ebx, 0x101c52bc */
            ii(0x1011_5e3b, 2); add(ebx, edx);                          /* add ebx, edx */
            ii(0x1011_5e3d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_5e3f, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1011_5e41, 5); calld(0x1011_7c0c, 0x1dc6);             /* call 0x10117c0c */
        l_0x1011_5e46:
            ii(0x1011_5e46, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1011_5e4b, 5); calld(/* sys */ 0x1016_a24c, 0x5_43fc); /* call 0x1016a24c */
            ii(0x1011_5e50, 5); mov(eax, 0x26);                         /* mov eax, 0x26 */
            ii(0x1011_5e55, 5); calld(0x100e_883d, -0x2_d61d);          /* call 0x100e883d */
            ii(0x1011_5e5a, 3); mov(memd_a32[ss, ebp - 0x7c], eax);     /* mov [ebp-0x7c], eax */
            ii(0x1011_5e5d, 3); mov(eax, memd_a32[ss, ebp - 0x7c]);     /* mov eax, [ebp-0x7c] */
            ii(0x1011_5e60, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x1011_5e64, 3); mov(edx, memd_a32[ss, ebp - 0x7c]);     /* mov edx, [ebp-0x7c] */
            ii(0x1011_5e67, 3); sub(ax, memw_a32[ds, edx]);             /* sub ax, [edx] */
            ii(0x1011_5e6a, 3); mov(memd_a32[ss, ebp - 0x80], eax);     /* mov [ebp-0x80], eax */
            ii(0x1011_5e6d, 9); mov(memw_a32[ds, 0x101c_52b2], 0);      /* mov word [0x101c52b2], 0x0 */
            ii(0x1011_5e76, 6); mov(ax, memw_a32[ds, 0x101c_52b2]);     /* mov ax, [0x101c52b2] */
            ii(0x1011_5e7c, 6); mov(memw_a32[ds, 0x101c_52b0], ax);     /* mov [0x101c52b0], ax */
            ii(0x1011_5e82, 9); mov(memw_a32[ds, 0x101c_52b4], 0x14);   /* mov word [0x101c52b4], 0x14 */
            ii(0x1011_5e8b, 3); mov(eax, memd_a32[ss, ebp - 0x80]);     /* mov eax, [ebp-0x80] */
            ii(0x1011_5e8e, 3); sub(eax, 0x14);                         /* sub eax, 0x14 */
            ii(0x1011_5e91, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_5e94, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_5e97, 5); calld(0x1011_58d2, -0x5ca);             /* call 0x101158d2 */
            ii(0x1011_5e9c, 5); mov(eax, memd_a32[ds, 0x101c_52ae]);    /* mov eax, [0x101c52ae] */
            ii(0x1011_5ea1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_5ea4, 7); mov(memb_a32[ds, eax + 0x101c_4e64], 0); /* mov byte [eax+0x101c4e64], 0x0 */
            ii(0x1011_5eab, 8); add(memw_a32[ds, 0x101c_52b2], 0x14);   /* add word [0x101c52b2], 0x14 */
            ii(0x1011_5eb3, 10); mov(memd_a32[ss, ebp - 0x84], 0);      /* mov dword [ebp-0x84], 0x0 */
            ii(0x1011_5ebd, 10); mov(memd_a32[ss, ebp - 0x88], 0xa);    /* mov dword [ebp-0x88], 0xa */
            ii(0x1011_5ec7, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1011_5ecc, 5); calld(0x100e_883d, -0x2_d694);          /* call 0x100e883d */
            ii(0x1011_5ed1, 6); mov(memd_a32[ss, ebp - 0x8c], eax);     /* mov [ebp-0x8c], eax */
            ii(0x1011_5ed7, 7); movsx(eax, memw_a32[ss, ebp - 0x84]);   /* movsx eax, word [ebp-0x84] */
            ii(0x1011_5ede, 3); mov(edx, memd_a32[ss, ebp - 0x7c]);     /* mov edx, [ebp-0x7c] */
            ii(0x1011_5ee1, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1011_5ee3, 6); mov(ebx, memd_a32[ss, ebp - 0x8c]);     /* mov ebx, [ebp-0x8c] */
            ii(0x1011_5ee9, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_5eeb, 2); mov(memd_a32[ds, ebx], eax);            /* mov [ebx], eax */
            ii(0x1011_5eed, 7); movsx(edx, memw_a32[ss, ebp - 0x88]);   /* movsx edx, word [ebp-0x88] */
            ii(0x1011_5ef4, 3); mov(eax, memd_a32[ss, ebp - 0x7c]);     /* mov eax, [ebp-0x7c] */
            ii(0x1011_5ef7, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x1011_5efa, 6); mov(ebx, memd_a32[ss, ebp - 0x8c]);     /* mov ebx, [ebp-0x8c] */
            ii(0x1011_5f00, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_5f02, 3); mov(memd_a32[ds, ebx + 0x4], edx);      /* mov [ebx+0x4], edx */
            ii(0x1011_5f05, 6); mov(edx, memd_a32[ds, 0x101c_52b0]);    /* mov edx, [0x101c52b0] */
            ii(0x1011_5f0b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_5f0e, 6); mov(eax, memd_a32[ss, ebp - 0x8c]);     /* mov eax, [ebp-0x8c] */
            ii(0x1011_5f14, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_5f16, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_5f18, 6); mov(edx, memd_a32[ss, ebp - 0x8c]);     /* mov edx, [ebp-0x8c] */
            ii(0x1011_5f1e, 3); mov(memd_a32[ds, edx + 0x8], eax);      /* mov [edx+0x8], eax */
            ii(0x1011_5f21, 6); mov(edx, memd_a32[ds, 0x101c_52b2]);    /* mov edx, [0x101c52b2] */
            ii(0x1011_5f27, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_5f2a, 6); mov(eax, memd_a32[ss, ebp - 0x8c]);     /* mov eax, [ebp-0x8c] */
            ii(0x1011_5f30, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x1011_5f33, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_5f35, 6); mov(edx, memd_a32[ss, ebp - 0x8c]);     /* mov edx, [ebp-0x8c] */
            ii(0x1011_5f3b, 3); mov(memd_a32[ds, edx + 0xc], eax);      /* mov [edx+0xc], eax */
            ii(0x1011_5f3e, 7); movsx(eax, memw_a32[ss, ebp - 0x88]);   /* movsx eax, word [ebp-0x88] */
            ii(0x1011_5f45, 6); imul(edx, eax, 0x280);                  /* imul edx, eax, 0x280 */
            ii(0x1011_5f4b, 3); mov(eax, memd_a32[ss, ebp - 0x7c]);     /* mov eax, [ebp-0x7c] */
            ii(0x1011_5f4e, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1011_5f51, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_5f53, 7); movsx(edx, memw_a32[ss, ebp - 0x84]);   /* movsx edx, word [ebp-0x84] */
            ii(0x1011_5f5a, 6); mov(ebx, memd_a32[ss, ebp - 0x8c]);     /* mov ebx, [ebp-0x8c] */
            ii(0x1011_5f60, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_5f62, 3); mov(memd_a32[ds, ebx + 0x16], eax);     /* mov [ebx+0x16], eax */
            ii(0x1011_5f65, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1011_5f69, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_5f6c, 6); mov(eax, memd_a32[ds, eax + 0x101b_af88]); /* mov eax, [eax+0x101baf88] */
            ii(0x1011_5f72, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_5f74, 5); mov(memd_a32[ds, 0x101c_52b8], eax);    /* mov [0x101c52b8], eax */
            ii(0x1011_5f79, 7); mov(memb_a32[ds, 0x101c_391d], 0x1);    /* mov byte [0x101c391d], 0x1 */
            ii(0x1011_5f80, 6); lea(eax, ebp - 0x9c);                   /* lea eax, [ebp-0x9c] */
            ii(0x1011_5f86, 5); calld(0x100f_a9fd, -0x1_b58e);          /* call 0x100fa9fd */
            ii(0x1011_5f8b, 6); lea(eax, ebp - 0x9c);                   /* lea eax, [ebp-0x9c] */
            ii(0x1011_5f91, 5); calld(0x100f_f562, -0x1_6a34);          /* call 0x100ff562 */
        l_0x1011_5f96:
            ii(0x1011_5f96, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_5f98, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_5f99, 1); popd(edi);                              /* pop edi */
            ii(0x1011_5f9a, 1); popd(esi);                              /* pop esi */
            ii(0x1011_5f9b, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}
