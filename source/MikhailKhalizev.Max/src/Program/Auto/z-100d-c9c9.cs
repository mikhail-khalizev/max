using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e2274e3e-9ae7-4c49-aba2-f4b6c2fe84cb")]
        public void Method_100d_c9c9()
        {
            ii(0x100d_c9c9, 5); pushd(0x304);                           /* push 0x304 */
            ii(0x100d_c9ce, 5); calld(Definitions.sys_check_available_stack_size, 0x8937f); /* call 0x10165d52 */
            ii(0x100d_c9d3, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_c9d4, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_c9d5, 1); pushd(esi);                             /* push esi */
            ii(0x100d_c9d6, 1); pushd(edi);                             /* push edi */
            ii(0x100d_c9d7, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_c9d8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_c9da, 6); sub(esp, 0x2d4);                        /* sub esp, 0x2d4 */
            ii(0x100d_c9e0, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_c9e3, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_c9e6, 5); mov(ebx, 0x6cb);                        /* mov ebx, 0x6cb */
            ii(0x100d_c9eb, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100d_c9ef, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_c9f2, 5); calld(0x100d_8f7b, -0x3a7c);            /* call 0x100d8f7b */
            ii(0x100d_c9f7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_c9fa, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100d_c9fd, 3); mov(memd_a32[ss, ebp - 0x50], eax);     /* mov [ebp-0x50], eax */
            ii(0x100d_ca00, 5); calld(0x1008_b3ec, -0x51619);           /* call 0x1008b3ec */
            ii(0x100d_ca05, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_ca08, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_ca0b, 5); add(eax, 0x3af);                        /* add eax, 0x3af */
            ii(0x100d_ca10, 5); calld(0x1008_b1e4, -0x51831);           /* call 0x1008b1e4 */
            ii(0x100d_ca15, 5); sub(eax, 0x3af);                        /* sub eax, 0x3af */
            ii(0x100d_ca1a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_ca1d, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100d_ca20, 3); mov(memd_a32[ss, ebp - 0x54], eax);     /* mov [ebp-0x54], eax */
            ii(0x100d_ca23, 5); calld(0x1008_b3ec, -0x5163c);           /* call 0x1008b3ec */
            ii(0x100d_ca28, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_ca2b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_ca2e, 5); add(eax, 0x3b3);                        /* add eax, 0x3b3 */
            ii(0x100d_ca33, 5); calld(0x1008_b1e4, -0x51854);           /* call 0x1008b1e4 */
            ii(0x100d_ca38, 5); sub(eax, 0x3b3);                        /* sub eax, 0x3b3 */
            ii(0x100d_ca3d, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_ca40, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100d_ca43, 3); mov(memd_a32[ss, ebp - 0x58], eax);     /* mov [ebp-0x58], eax */
            ii(0x100d_ca46, 5); calld(0x100e_0a20, 0x3fd5);             /* call 0x100e0a20 */
            ii(0x100d_ca4b, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_ca4e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_ca51, 5); add(eax, 0x3b7);                        /* add eax, 0x3b7 */
            ii(0x100d_ca56, 5); calld(0x100e_09b8, 0x3f5d);             /* call 0x100e09b8 */
            ii(0x100d_ca5b, 5); sub(eax, 0x3b7);                        /* sub eax, 0x3b7 */
            ii(0x100d_ca60, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_ca63, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100d_ca66, 3); mov(memd_a32[ss, ebp - 0x5c], eax);     /* mov [ebp-0x5c], eax */
            ii(0x100d_ca69, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_ca6c, 7); mov(memd_a32[ds, eax + 0x13], 0x101b_5ee0); /* mov dword [eax+0x13], 0x101b5ee0 */
            ii(0x100d_ca73, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_ca76, 10); mov(memd_a32[ds, eax + 0x345], 0);     /* mov dword [eax+0x345], 0x0 */
            ii(0x100d_ca80, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_ca83, 7); mov(memb_a32[ds, eax + 0x39d], 0x1);    /* mov byte [eax+0x39d], 0x1 */
            ii(0x100d_ca8a, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100d_ca8e, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100d_ca94, 6); mov(al, memb_a32[ds, eax + 0x101c_a4ef]); /* mov al, [eax+0x101ca4ef] */
            ii(0x100d_ca9a, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100d_ca9c, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_ca9f, 5); mov(eax, 0x101c_3c4c);                  /* mov eax, 0x101c3c4c */
            ii(0x100d_caa4, 5); calld(0x1010_6752, 0x29ca9);            /* call 0x10106752 */
            ii(0x100d_caa9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_caab, 5); mov(eax, 0x48);                         /* mov eax, 0x48 */
            ii(0x100d_cab0, 5); calld(0x1007_5fdc, -0x66ad9);           /* call 0x10075fdc */
            ii(0x100d_cab5, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x100d_cab8, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_caba, 4); mov(memw_a32[ds, ebx + 0x4d], ax);      /* mov [ebx+0x4d], ax */
            ii(0x100d_cabe, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_cac1, 3); mov(eax, memd_a32[ds, eax + 0x49]);     /* mov eax, [eax+0x49] */
            ii(0x100d_cac4, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_cac7, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100d_cacd, 9); mov(memw_a32[ds, eax + 0x101c_a583], 0); /* mov word [eax+0x101ca583], 0x0 */
            ii(0x100d_cad6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_cad9, 6); mov(memw_a32[ds, eax + 0x55], 0x272);   /* mov word [eax+0x55], 0x272 */
            ii(0x100d_cadf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_cae2, 6); mov(memw_a32[ds, eax + 0x57], 0x273);   /* mov word [eax+0x57], 0x273 */
            ii(0x100d_cae8, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100d_caec, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100d_caef, 5); mov(edx, 0x101c_35b4);                  /* mov edx, 0x101c35b4 */
            ii(0x100d_caf4, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100d_caf6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_caf9, 5); add(eax, 0x3b3);                        /* add eax, 0x3b3 */
            ii(0x100d_cafe, 5); calld(0x100d_5494, -0x766f);            /* call 0x100d5494 */
            ii(0x100d_cb03, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100d_cb07, 3); imul(edx, eax, 0x13);                   /* imul edx, eax, 0x13 */
            ii(0x100d_cb0a, 5); mov(eax, 0x101c_35b4);                  /* mov eax, 0x101c35b4 */
            ii(0x100d_cb0f, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_cb11, 3); lea(edx, eax + 0x4);                    /* lea edx, [eax+0x4] */
            ii(0x100d_cb14, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_cb17, 5); add(eax, 0x3b7);                        /* add eax, 0x3b7 */
            ii(0x100d_cb1c, 5); calld(0x100e_08fc, 0x3ddb);             /* call 0x100e08fc */
            ii(0x100d_cb21, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_cb24, 5); add(eax, 0x3b3);                        /* add eax, 0x3b3 */
            ii(0x100d_cb29, 5); calld(Definitions.my_2_get_count, -0x517c6); /* call 0x1008b368 */
            ii(0x100d_cb2e, 1); cwde();                                 /* cwde */
            ii(0x100d_cb2f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_cb31, 6); if(jled(0x100d_cbf6, 0xbf)) goto l_0x100d_cbf6; /* jle 0x100dcbf6 */
            ii(0x100d_cb37, 4); or(memb_a32[ss, ebp - 0xc], 0x1);       /* or byte [ebp-0xc], 0x1 */
            ii(0x100d_cb3b, 3); lea(eax, ebp - 0x60);                   /* lea eax, [ebp-0x60] */
            ii(0x100d_cb3e, 5); calld(0x100c_a02c, -0x12b17);           /* call 0x100ca02c */
            ii(0x100d_cb43, 3); mov(memd_a32[ss, ebp - 0x64], eax);     /* mov [ebp-0x64], eax */
            ii(0x100d_cb46, 4); and(memb_a32[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x100d_cb4a, 5); calld(0x1009_cb74, -0x3ffdb);           /* call 0x1009cb74 */
            ii(0x100d_cb4f, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100d_cb51, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100d_cb53, 3); lea(edx, ebp - 0x60);                   /* lea edx, [ebp-0x60] */
            ii(0x100d_cb56, 3); lea(eax, ebp - 0x68);                   /* lea eax, [ebp-0x68] */
            ii(0x100d_cb59, 5); calld(0x1009_cab0, -0x400ae);           /* call 0x1009cab0 */
            ii(0x100d_cb5e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_cb60, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100d_cb64, 5); calld(0x100d_c405, -0x764);             /* call 0x100dc405 */
            ii(0x100d_cb69, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_cb6b, 3); lea(eax, ebp - 0x68);                   /* lea eax, [ebp-0x68] */
            ii(0x100d_cb6e, 5); calld(0x1008_8b04, -0x5406f);           /* call 0x10088b04 */
            ii(0x100d_cb73, 3); lea(eax, ebp - 0x60);                   /* lea eax, [ebp-0x60] */
            ii(0x100d_cb76, 5); calld(Definitions.my_2_get_count, -0x51813); /* call 0x1008b368 */
            ii(0x100d_cb7b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_cb7d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_cb80, 3); add(edx, 0x3);                          /* add edx, 0x3 */
            ii(0x100d_cb83, 7); mov(memw_a32[ds, eax + 0x3e3], dx);     /* mov [eax+0x3e3], dx */
            ii(0x100d_cb8a, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100d_cb8e, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100d_cb91, 7); mov(dx, memw_a32[ds, eax + 0x101c_35c4]); /* mov dx, [eax+0x101c35c4] */
            ii(0x100d_cb98, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_cb9b, 4); mov(memw_a32[ds, eax + 0x4f], dx);      /* mov [eax+0x4f], dx */
            ii(0x100d_cb9f, 7); mov(memd_a32[ss, ebp - 0x4c], 0);       /* mov dword [ebp-0x4c], 0x0 */
            ii(0x100d_cba6, 2); jmpd(0x100d_cbae, 0x6); goto l_0x100d_cbae; /* jmp 0x100dcbae */
        l_0x100d_cba8:
            ii(0x100d_cba8, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x100d_cbab, 3); inc(memd_a32[ss, ebp - 0x4c]);          /* inc dword [ebp-0x4c] */
        l_0x100d_cbae:
            ii(0x100d_cbae, 4); movsx(eax, memw_a32[ss, ebp - 0x4c]);   /* movsx eax, word [ebp-0x4c] */
            ii(0x100d_cbb2, 3); cmp(eax, 0x5d);                         /* cmp eax, 0x5d */
            ii(0x100d_cbb5, 2); if(jged(0x100d_cbea, 0x33)) goto l_0x100d_cbea; /* jge 0x100dcbea */
            ii(0x100d_cbb7, 4); movsx(edx, memw_a32[ss, ebp - 0x4c]);   /* movsx edx, word [ebp-0x4c] */
            ii(0x100d_cbbb, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100d_cbbf, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100d_cbc5, 6); mov(eax, memd_a32[ds, eax + 0x101c_a562]); /* mov eax, [eax+0x101ca562] */
            ii(0x100d_cbcb, 5); calld(0x100c_b6b0, -0x11520);           /* call 0x100cb6b0 */
            ii(0x100d_cbd0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_cbd2, 4); movsx(eax, memw_a32[ss, ebp - 0x4c]);   /* movsx eax, word [ebp-0x4c] */
            ii(0x100d_cbd6, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100d_cbd9, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100d_cbdb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_cbde, 3); add(eax, 0x5b);                         /* add eax, 0x5b */
            ii(0x100d_cbe1, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100d_cbe3, 5); calld(0x100c_b77c, -0x1146c);           /* call 0x100cb77c */
            ii(0x100d_cbe8, 2); jmpd(0x100d_cba8, -0x42); goto l_0x100d_cba8; /* jmp 0x100dcba8 */
        l_0x100d_cbea:
            ii(0x100d_cbea, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_cbec, 3); lea(eax, ebp - 0x60);                   /* lea eax, [ebp-0x60] */
            ii(0x100d_cbef, 5); calld(0x1008_8b04, -0x540f0);           /* call 0x10088b04 */
            ii(0x100d_cbf4, 2); jmpd(0x100d_cc19, 0x23); goto l_0x100d_cc19; /* jmp 0x100dcc19 */
        l_0x100d_cbf6:
            ii(0x100d_cbf6, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100d_cbfa, 5); calld(0x100d_c4fb, -0x704);             /* call 0x100dc4fb */
            ii(0x100d_cbff, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_cc01, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_cc04, 7); mov(memw_a32[ds, eax + 0x3e3], dx);     /* mov [eax+0x3e3], dx */
            ii(0x100d_cc0b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_cc0e, 4); mov(dx, memw_a32[ds, eax + 0x4d]);      /* mov dx, [eax+0x4d] */
            ii(0x100d_cc12, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_cc15, 4); mov(memw_a32[ds, eax + 0x4f], dx);      /* mov [eax+0x4f], dx */
        l_0x100d_cc19:
            ii(0x100d_cc19, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100d_cc1e, 5); calld(Definitions.sys_new, 0x891dd);    /* call 0x10165e00 */
            ii(0x100d_cc23, 3); mov(memd_a32[ss, ebp - 0x6c], eax);     /* mov [ebp-0x6c], eax */
            ii(0x100d_cc26, 3); mov(eax, memd_a32[ss, ebp - 0x6c]);     /* mov eax, [ebp-0x6c] */
            ii(0x100d_cc29, 3); mov(memd_a32[ss, ebp - 0x70], eax);     /* mov [ebp-0x70], eax */
            ii(0x100d_cc2c, 4); cmp(memd_a32[ss, ebp - 0x70], 0);       /* cmp dword [ebp-0x70], 0x0 */
            ii(0x100d_cc30, 2); if(jzd(0x100d_cc5a, 0x28)) goto l_0x100d_cc5a; /* jz 0x100dcc5a */
            ii(0x100d_cc32, 5); mov(eax, 0xae);                         /* mov eax, 0xae */
            ii(0x100d_cc37, 1); pushd(eax);                             /* push eax */
            ii(0x100d_cc38, 5); mov(ecx, 0xfa);                         /* mov ecx, 0xfa */
            ii(0x100d_cc3d, 5); mov(ebx, 0x125);                        /* mov ebx, 0x125 */
            ii(0x100d_cc42, 5); mov(edx, 0xb);                          /* mov edx, 0xb */
            ii(0x100d_cc47, 3); mov(eax, memd_a32[ss, ebp - 0x6c]);     /* mov eax, [ebp-0x6c] */
            ii(0x100d_cc4a, 5); calld(0x100d_7bdc, -0x5073);            /* call 0x100d7bdc */
            ii(0x100d_cc4f, 3); mov(memd_a32[ss, ebp - 0x74], eax);     /* mov [ebp-0x74], eax */
            ii(0x100d_cc52, 3); mov(eax, memd_a32[ss, ebp - 0x74]);     /* mov eax, [ebp-0x74] */
            ii(0x100d_cc55, 3); mov(memd_a32[ss, ebp - 0x78], eax);     /* mov [ebp-0x78], eax */
            ii(0x100d_cc58, 2); jmpd(0x100d_cc60, 0x6); goto l_0x100d_cc60; /* jmp 0x100dcc60 */
        l_0x100d_cc5a:
            ii(0x100d_cc5a, 3); mov(eax, memd_a32[ss, ebp - 0x70]);     /* mov eax, [ebp-0x70] */
            ii(0x100d_cc5d, 3); mov(memd_a32[ss, ebp - 0x78], eax);     /* mov [ebp-0x78], eax */
        l_0x100d_cc60:
            ii(0x100d_cc60, 3); mov(eax, memd_a32[ss, ebp - 0x78]);     /* mov eax, [ebp-0x78] */
            ii(0x100d_cc63, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_cc66, 6); mov(memd_a32[ds, edx + 0x39f], eax);    /* mov [edx+0x39f], eax */
            ii(0x100d_cc6c, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100d_cc71, 5); calld(Definitions.sys_new, 0x8918a);    /* call 0x10165e00 */
            ii(0x100d_cc76, 3); mov(memd_a32[ss, ebp - 0x7c], eax);     /* mov [ebp-0x7c], eax */
            ii(0x100d_cc79, 3); mov(eax, memd_a32[ss, ebp - 0x7c]);     /* mov eax, [ebp-0x7c] */
            ii(0x100d_cc7c, 3); mov(memd_a32[ss, ebp - 0x80], eax);     /* mov [ebp-0x80], eax */
            ii(0x100d_cc7f, 4); cmp(memd_a32[ss, ebp - 0x80], 0);       /* cmp dword [ebp-0x80], 0x0 */
            ii(0x100d_cc83, 2); if(jzd(0x100d_ccb6, 0x31)) goto l_0x100d_ccb6; /* jz 0x100dccb6 */
            ii(0x100d_cc85, 5); mov(eax, 0xae);                         /* mov eax, 0xae */
            ii(0x100d_cc8a, 1); pushd(eax);                             /* push eax */
            ii(0x100d_cc8b, 5); mov(ecx, 0x28);                         /* mov ecx, 0x28 */
            ii(0x100d_cc90, 5); mov(ebx, 0x125);                        /* mov ebx, 0x125 */
            ii(0x100d_cc95, 5); mov(edx, 0x141);                        /* mov edx, 0x141 */
            ii(0x100d_cc9a, 3); mov(eax, memd_a32[ss, ebp - 0x7c]);     /* mov eax, [ebp-0x7c] */
            ii(0x100d_cc9d, 5); calld(0x100d_7bdc, -0x50c6);            /* call 0x100d7bdc */
            ii(0x100d_cca2, 6); mov(memd_a32[ss, ebp - 0x84], eax);     /* mov [ebp-0x84], eax */
            ii(0x100d_cca8, 6); mov(eax, memd_a32[ss, ebp - 0x84]);     /* mov eax, [ebp-0x84] */
            ii(0x100d_ccae, 6); mov(memd_a32[ss, ebp - 0x88], eax);     /* mov [ebp-0x88], eax */
            ii(0x100d_ccb4, 2); jmpd(0x100d_ccbf, 0x9); goto l_0x100d_ccbf; /* jmp 0x100dccbf */
        l_0x100d_ccb6:
            ii(0x100d_ccb6, 3); mov(eax, memd_a32[ss, ebp - 0x80]);     /* mov eax, [ebp-0x80] */
            ii(0x100d_ccb9, 6); mov(memd_a32[ss, ebp - 0x88], eax);     /* mov [ebp-0x88], eax */
        l_0x100d_ccbf:
            ii(0x100d_ccbf, 6); mov(eax, memd_a32[ss, ebp - 0x88]);     /* mov eax, [ebp-0x88] */
            ii(0x100d_ccc5, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_ccc8, 6); mov(memd_a32[ds, edx + 0x3a3], eax);    /* mov [edx+0x3a3], eax */
            ii(0x100d_ccce, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100d_ccd3, 5); calld(Definitions.sys_new, 0x89128);    /* call 0x10165e00 */
            ii(0x100d_ccd8, 6); mov(memd_a32[ss, ebp - 0x8c], eax);     /* mov [ebp-0x8c], eax */
            ii(0x100d_ccde, 6); mov(eax, memd_a32[ss, ebp - 0x8c]);     /* mov eax, [ebp-0x8c] */
            ii(0x100d_cce4, 6); mov(memd_a32[ss, ebp - 0x90], eax);     /* mov [ebp-0x90], eax */
            ii(0x100d_ccea, 7); cmp(memd_a32[ss, ebp - 0x90], 0);       /* cmp dword [ebp-0x90], 0x0 */
            ii(0x100d_ccf1, 2); if(jzd(0x100d_cd27, 0x34)) goto l_0x100d_cd27; /* jz 0x100dcd27 */
            ii(0x100d_ccf3, 5); mov(eax, 0xae);                         /* mov eax, 0xae */
            ii(0x100d_ccf8, 1); pushd(eax);                             /* push eax */
            ii(0x100d_ccf9, 5); mov(ecx, 0x26);                         /* mov ecx, 0x26 */
            ii(0x100d_ccfe, 5); mov(ebx, 0x125);                        /* mov ebx, 0x125 */
            ii(0x100d_cd03, 5); mov(edx, 0x11b);                        /* mov edx, 0x11b */
            ii(0x100d_cd08, 6); mov(eax, memd_a32[ss, ebp - 0x8c]);     /* mov eax, [ebp-0x8c] */
            ii(0x100d_cd0e, 5); calld(0x100d_7bdc, -0x5137);            /* call 0x100d7bdc */
            ii(0x100d_cd13, 6); mov(memd_a32[ss, ebp - 0x94], eax);     /* mov [ebp-0x94], eax */
            ii(0x100d_cd19, 6); mov(eax, memd_a32[ss, ebp - 0x94]);     /* mov eax, [ebp-0x94] */
            ii(0x100d_cd1f, 6); mov(memd_a32[ss, ebp - 0x98], eax);     /* mov [ebp-0x98], eax */
            ii(0x100d_cd25, 2); jmpd(0x100d_cd33, 0xc); goto l_0x100d_cd33; /* jmp 0x100dcd33 */
        l_0x100d_cd27:
            ii(0x100d_cd27, 6); mov(eax, memd_a32[ss, ebp - 0x90]);     /* mov eax, [ebp-0x90] */
            ii(0x100d_cd2d, 6); mov(memd_a32[ss, ebp - 0x98], eax);     /* mov [ebp-0x98], eax */
        l_0x100d_cd33:
            ii(0x100d_cd33, 6); mov(eax, memd_a32[ss, ebp - 0x98]);     /* mov eax, [ebp-0x98] */
            ii(0x100d_cd39, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_cd3c, 6); mov(memd_a32[ds, edx + 0x3ab], eax);    /* mov [edx+0x3ab], eax */
            ii(0x100d_cd42, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100d_cd47, 5); calld(Definitions.sys_new, 0x890b4);    /* call 0x10165e00 */
            ii(0x100d_cd4c, 6); mov(memd_a32[ss, ebp - 0x9c], eax);     /* mov [ebp-0x9c], eax */
            ii(0x100d_cd52, 6); mov(eax, memd_a32[ss, ebp - 0x9c]);     /* mov eax, [ebp-0x9c] */
            ii(0x100d_cd58, 6); mov(memd_a32[ss, ebp - 0xa0], eax);     /* mov [ebp-0xa0], eax */
            ii(0x100d_cd5e, 7); cmp(memd_a32[ss, ebp - 0xa0], 0);       /* cmp dword [ebp-0xa0], 0x0 */
            ii(0x100d_cd65, 2); if(jzd(0x100d_cd9b, 0x34)) goto l_0x100d_cd9b; /* jz 0x100dcd9b */
            ii(0x100d_cd67, 5); mov(eax, 0x8c);                         /* mov eax, 0x8c */
            ii(0x100d_cd6c, 1); pushd(eax);                             /* push eax */
            ii(0x100d_cd6d, 5); mov(ecx, 0x28);                         /* mov ecx, 0x28 */
            ii(0x100d_cd72, 5); mov(ebx, 0x114);                        /* mov ebx, 0x114 */
            ii(0x100d_cd77, 5); mov(edx, 0x169);                        /* mov edx, 0x169 */
            ii(0x100d_cd7c, 6); mov(eax, memd_a32[ss, ebp - 0x9c]);     /* mov eax, [ebp-0x9c] */
            ii(0x100d_cd82, 5); calld(0x100d_7bdc, -0x51ab);            /* call 0x100d7bdc */
            ii(0x100d_cd87, 6); mov(memd_a32[ss, ebp - 0xa4], eax);     /* mov [ebp-0xa4], eax */
            ii(0x100d_cd8d, 6); mov(eax, memd_a32[ss, ebp - 0xa4]);     /* mov eax, [ebp-0xa4] */
            ii(0x100d_cd93, 6); mov(memd_a32[ss, ebp - 0xa8], eax);     /* mov [ebp-0xa8], eax */
            ii(0x100d_cd99, 2); jmpd(0x100d_cda7, 0xc); goto l_0x100d_cda7; /* jmp 0x100dcda7 */
        l_0x100d_cd9b:
            ii(0x100d_cd9b, 6); mov(eax, memd_a32[ss, ebp - 0xa0]);     /* mov eax, [ebp-0xa0] */
            ii(0x100d_cda1, 6); mov(memd_a32[ss, ebp - 0xa8], eax);     /* mov [ebp-0xa8], eax */
        l_0x100d_cda7:
            ii(0x100d_cda7, 6); mov(eax, memd_a32[ss, ebp - 0xa8]);     /* mov eax, [ebp-0xa8] */
            ii(0x100d_cdad, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_cdb0, 6); mov(memd_a32[ds, edx + 0x3a7], eax);    /* mov [edx+0x3a7], eax */
            ii(0x100d_cdb6, 5); mov(eax, 0x2f);                         /* mov eax, 0x2f */
            ii(0x100d_cdbb, 5); calld(Definitions.sys_new, 0x89040);    /* call 0x10165e00 */
            ii(0x100d_cdc0, 6); mov(memd_a32[ss, ebp - 0xac], eax);     /* mov [ebp-0xac], eax */
            ii(0x100d_cdc6, 6); mov(eax, memd_a32[ss, ebp - 0xac]);     /* mov eax, [ebp-0xac] */
            ii(0x100d_cdcc, 6); mov(memd_a32[ss, ebp - 0xb0], eax);     /* mov [ebp-0xb0], eax */
            ii(0x100d_cdd2, 7); cmp(memd_a32[ss, ebp - 0xb0], 0);       /* cmp dword [ebp-0xb0], 0x0 */
            ii(0x100d_cdd9, 6); if(jzd(0x100d_ce68, 0x89)) goto l_0x100d_ce68; /* jz 0x100dce68 */
            ii(0x100d_cddf, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100d_cde4, 1); pushd(eax);                             /* push eax */
            ii(0x100d_cde5, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x100d_cdea, 1); pushd(eax);                             /* push eax */
            ii(0x100d_cdeb, 5); pushd(0x452);                           /* push 0x452 */
            ii(0x100d_cdf0, 5); pushd(0x451);                           /* push 0x451 */
            ii(0x100d_cdf5, 5); pushd(0x450);                           /* push 0x450 */
            ii(0x100d_cdfa, 5); mov(eax, 0x221);                        /* mov eax, 0x221 */
            ii(0x100d_cdff, 1); pushd(eax);                             /* push eax */
            ii(0x100d_ce00, 5); mov(eax, 0x11e);                        /* mov eax, 0x11e */
            ii(0x100d_ce05, 1); pushd(eax);                             /* push eax */
            ii(0x100d_ce06, 5); mov(ecx, 0x1b9);                        /* mov ecx, 0x1b9 */
            ii(0x100d_ce0b, 5); mov(ebx, 0x114);                        /* mov ebx, 0x114 */
            ii(0x100d_ce10, 5); mov(edx, 0x1a5);                        /* mov edx, 0x1a5 */
            ii(0x100d_ce15, 6); lea(eax, ebp - 0xc0);                   /* lea eax, [ebp-0xc0] */
            ii(0x100d_ce1b, 5); calld(0x1008_b148, -0x51cd8);           /* call 0x1008b148 */
            ii(0x100d_ce20, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x100d_ce22, 5); mov(eax, 0x1a0);                        /* mov eax, 0x1a0 */
            ii(0x100d_ce27, 1); pushd(eax);                             /* push eax */
            ii(0x100d_ce28, 5); mov(ecx, 0x1b9);                        /* mov ecx, 0x1b9 */
            ii(0x100d_ce2d, 5); mov(ebx, 0x12d);                        /* mov ebx, 0x12d */
            ii(0x100d_ce32, 5); mov(edx, 0x1a5);                        /* mov edx, 0x1a5 */
            ii(0x100d_ce37, 6); lea(eax, ebp - 0xd0);                   /* lea eax, [ebp-0xd0] */
            ii(0x100d_ce3d, 5); calld(0x1008_b148, -0x51cfa);           /* call 0x1008b148 */
            ii(0x100d_ce42, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100d_ce44, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_ce47, 6); mov(eax, memd_a32[ss, ebp - 0xac]);     /* mov eax, [ebp-0xac] */
            ii(0x100d_ce4d, 2); mov(ecx, esi);                          /* mov ecx, esi */
            ii(0x100d_ce4f, 5); calld(0x100d_7706, -0x574e);            /* call 0x100d7706 */
            ii(0x100d_ce54, 6); mov(memd_a32[ss, ebp - 0xd4], eax);     /* mov [ebp-0xd4], eax */
            ii(0x100d_ce5a, 6); mov(eax, memd_a32[ss, ebp - 0xd4]);     /* mov eax, [ebp-0xd4] */
            ii(0x100d_ce60, 6); mov(memd_a32[ss, ebp - 0xd8], eax);     /* mov [ebp-0xd8], eax */
            ii(0x100d_ce66, 2); jmpd(0x100d_ce74, 0xc); goto l_0x100d_ce74; /* jmp 0x100dce74 */
        l_0x100d_ce68:
            ii(0x100d_ce68, 6); mov(eax, memd_a32[ss, ebp - 0xb0]);     /* mov eax, [ebp-0xb0] */
            ii(0x100d_ce6e, 6); mov(memd_a32[ss, ebp - 0xd8], eax);     /* mov [ebp-0xd8], eax */
        l_0x100d_ce74:
            ii(0x100d_ce74, 6); mov(eax, memd_a32[ss, ebp - 0xd8]);     /* mov eax, [ebp-0xd8] */
            ii(0x100d_ce7a, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_ce7d, 6); mov(memd_a32[ds, edx + 0x3df], eax);    /* mov [edx+0x3df], eax */
            ii(0x100d_ce83, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_ce88, 5); calld(Definitions.sys_new, 0x88f73);    /* call 0x10165e00 */
            ii(0x100d_ce8d, 6); mov(memd_a32[ss, ebp - 0xdc], eax);     /* mov [ebp-0xdc], eax */
            ii(0x100d_ce93, 6); mov(eax, memd_a32[ss, ebp - 0xdc]);     /* mov eax, [ebp-0xdc] */
            ii(0x100d_ce99, 6); mov(memd_a32[ss, ebp - 0xe0], eax);     /* mov [ebp-0xe0], eax */
            ii(0x100d_ce9f, 7); cmp(memd_a32[ss, ebp - 0xe0], 0);       /* cmp dword [ebp-0xe0], 0x0 */
            ii(0x100d_cea6, 2); if(jzd(0x100d_cedc, 0x34)) goto l_0x100d_cedc; /* jz 0x100dcedc */
            ii(0x100d_cea8, 5); mov(eax, 0x183);                        /* mov eax, 0x183 */
            ii(0x100d_cead, 1); pushd(eax);                             /* push eax */
            ii(0x100d_ceae, 5); mov(ecx, 0x1d7);                        /* mov ecx, 0x1d7 */
            ii(0x100d_ceb3, 5); mov(ebx, 0x11b);                        /* mov ebx, 0x11b */
            ii(0x100d_ceb8, 5); mov(edx, 0x11a);                        /* mov edx, 0x11a */
            ii(0x100d_cebd, 6); mov(eax, memd_a32[ss, ebp - 0xdc]);     /* mov eax, [ebp-0xdc] */
            ii(0x100d_cec3, 5); calld(Definitions.my_ctor_c17, -0xeab9); /* call 0x100ce40f */
            ii(0x100d_cec8, 6); mov(memd_a32[ss, ebp - 0xe4], eax);     /* mov [ebp-0xe4], eax */
            ii(0x100d_cece, 6); mov(eax, memd_a32[ss, ebp - 0xe4]);     /* mov eax, [ebp-0xe4] */
            ii(0x100d_ced4, 6); mov(memd_a32[ss, ebp - 0xe8], eax);     /* mov [ebp-0xe8], eax */
            ii(0x100d_ceda, 2); jmpd(0x100d_cee8, 0xc); goto l_0x100d_cee8; /* jmp 0x100dcee8 */
        l_0x100d_cedc:
            ii(0x100d_cedc, 6); mov(eax, memd_a32[ss, ebp - 0xe0]);     /* mov eax, [ebp-0xe0] */
            ii(0x100d_cee2, 6); mov(memd_a32[ss, ebp - 0xe8], eax);     /* mov [ebp-0xe8], eax */
        l_0x100d_cee8:
            ii(0x100d_cee8, 6); mov(eax, memd_a32[ss, ebp - 0xe8]);     /* mov eax, [ebp-0xe8] */
            ii(0x100d_ceee, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_cef1, 6); mov(memd_a32[ds, edx + 0x349], eax);    /* mov [edx+0x349], eax */
            ii(0x100d_cef7, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_cefc, 5); calld(Definitions.sys_new, 0x88eff);    /* call 0x10165e00 */
            ii(0x100d_cf01, 6); mov(memd_a32[ss, ebp - 0xec], eax);     /* mov [ebp-0xec], eax */
            ii(0x100d_cf07, 6); mov(eax, memd_a32[ss, ebp - 0xec]);     /* mov eax, [ebp-0xec] */
            ii(0x100d_cf0d, 6); mov(memd_a32[ss, ebp - 0xf0], eax);     /* mov [ebp-0xf0], eax */
            ii(0x100d_cf13, 7); cmp(memd_a32[ss, ebp - 0xf0], 0);       /* cmp dword [ebp-0xf0], 0x0 */
            ii(0x100d_cf1a, 2); if(jzd(0x100d_cf50, 0x34)) goto l_0x100d_cf50; /* jz 0x100dcf50 */
            ii(0x100d_cf1c, 5); mov(eax, 0x183);                        /* mov eax, 0x183 */
            ii(0x100d_cf21, 1); pushd(eax);                             /* push eax */
            ii(0x100d_cf22, 5); mov(ecx, 0x1eb);                        /* mov ecx, 0x1eb */
            ii(0x100d_cf27, 5); mov(ebx, 0x11e);                        /* mov ebx, 0x11e */
            ii(0x100d_cf2c, 5); mov(edx, 0x11d);                        /* mov edx, 0x11d */
            ii(0x100d_cf31, 6); mov(eax, memd_a32[ss, ebp - 0xec]);     /* mov eax, [ebp-0xec] */
            ii(0x100d_cf37, 5); calld(Definitions.my_ctor_c17, -0xeb2d); /* call 0x100ce40f */
            ii(0x100d_cf3c, 6); mov(memd_a32[ss, ebp - 0xf4], eax);     /* mov [ebp-0xf4], eax */
            ii(0x100d_cf42, 6); mov(eax, memd_a32[ss, ebp - 0xf4]);     /* mov eax, [ebp-0xf4] */
            ii(0x100d_cf48, 6); mov(memd_a32[ss, ebp - 0xf8], eax);     /* mov [ebp-0xf8], eax */
            ii(0x100d_cf4e, 2); jmpd(0x100d_cf5c, 0xc); goto l_0x100d_cf5c; /* jmp 0x100dcf5c */
        l_0x100d_cf50:
            ii(0x100d_cf50, 6); mov(eax, memd_a32[ss, ebp - 0xf0]);     /* mov eax, [ebp-0xf0] */
            ii(0x100d_cf56, 6); mov(memd_a32[ss, ebp - 0xf8], eax);     /* mov [ebp-0xf8], eax */
        l_0x100d_cf5c:
            ii(0x100d_cf5c, 6); mov(eax, memd_a32[ss, ebp - 0xf8]);     /* mov eax, [ebp-0xf8] */
            ii(0x100d_cf62, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_cf65, 6); mov(memd_a32[ds, edx + 0x34d], eax);    /* mov [edx+0x34d], eax */
            ii(0x100d_cf6b, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_cf70, 5); calld(Definitions.sys_new, 0x88e8b);    /* call 0x10165e00 */
            ii(0x100d_cf75, 6); mov(memd_a32[ss, ebp - 0xfc], eax);     /* mov [ebp-0xfc], eax */
            ii(0x100d_cf7b, 6); mov(eax, memd_a32[ss, ebp - 0xfc]);     /* mov eax, [ebp-0xfc] */
            ii(0x100d_cf81, 6); mov(memd_a32[ss, ebp - 0x100], eax);    /* mov [ebp-0x100], eax */
            ii(0x100d_cf87, 7); cmp(memd_a32[ss, ebp - 0x100], 0);      /* cmp dword [ebp-0x100], 0x0 */
            ii(0x100d_cf8e, 2); if(jzd(0x100d_cfc4, 0x34)) goto l_0x100d_cfc4; /* jz 0x100dcfc4 */
            ii(0x100d_cf90, 5); mov(eax, 0x108);                        /* mov eax, 0x108 */
            ii(0x100d_cf95, 1); pushd(eax);                             /* push eax */
            ii(0x100d_cf96, 5); mov(ecx, 0x124);                        /* mov ecx, 0x124 */
            ii(0x100d_cf9b, 5); mov(ebx, 0x129);                        /* mov ebx, 0x129 */
            ii(0x100d_cfa0, 5); mov(edx, 0x128);                        /* mov edx, 0x128 */
            ii(0x100d_cfa5, 6); mov(eax, memd_a32[ss, ebp - 0xfc]);     /* mov eax, [ebp-0xfc] */
            ii(0x100d_cfab, 5); calld(Definitions.my_ctor_c17, -0xeba1); /* call 0x100ce40f */
            ii(0x100d_cfb0, 6); mov(memd_a32[ss, ebp - 0x104], eax);    /* mov [ebp-0x104], eax */
            ii(0x100d_cfb6, 6); mov(eax, memd_a32[ss, ebp - 0x104]);    /* mov eax, [ebp-0x104] */
            ii(0x100d_cfbc, 6); mov(memd_a32[ss, ebp - 0x108], eax);    /* mov [ebp-0x108], eax */
            ii(0x100d_cfc2, 2); jmpd(0x100d_cfd0, 0xc); goto l_0x100d_cfd0; /* jmp 0x100dcfd0 */
        l_0x100d_cfc4:
            ii(0x100d_cfc4, 6); mov(eax, memd_a32[ss, ebp - 0x100]);    /* mov eax, [ebp-0x100] */
            ii(0x100d_cfca, 6); mov(memd_a32[ss, ebp - 0x108], eax);    /* mov [ebp-0x108], eax */
        l_0x100d_cfd0:
            ii(0x100d_cfd0, 6); mov(eax, memd_a32[ss, ebp - 0x108]);    /* mov eax, [ebp-0x108] */
            ii(0x100d_cfd6, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_cfd9, 6); mov(memd_a32[ds, edx + 0x371], eax);    /* mov [edx+0x371], eax */
            ii(0x100d_cfdf, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_cfe4, 5); calld(Definitions.sys_new, 0x88e17);    /* call 0x10165e00 */
            ii(0x100d_cfe9, 6); mov(memd_a32[ss, ebp - 0x10c], eax);    /* mov [ebp-0x10c], eax */
            ii(0x100d_cfef, 6); mov(eax, memd_a32[ss, ebp - 0x10c]);    /* mov eax, [ebp-0x10c] */
            ii(0x100d_cff5, 6); mov(memd_a32[ss, ebp - 0x110], eax);    /* mov [ebp-0x110], eax */
            ii(0x100d_cffb, 7); cmp(memd_a32[ss, ebp - 0x110], 0);      /* cmp dword [ebp-0x110], 0x0 */
            ii(0x100d_d002, 2); if(jzd(0x100d_d038, 0x34)) goto l_0x100d_d038; /* jz 0x100dd038 */
            ii(0x100d_d004, 5); mov(eax, 0x1c4);                        /* mov eax, 0x1c4 */
            ii(0x100d_d009, 1); pushd(eax);                             /* push eax */
            ii(0x100d_d00a, 5); mov(ecx, 0x1bf);                        /* mov ecx, 0x1bf */
            ii(0x100d_d00f, 5); mov(ebx, 0x123);                        /* mov ebx, 0x123 */
            ii(0x100d_d014, 5); mov(edx, 0x122);                        /* mov edx, 0x122 */
            ii(0x100d_d019, 6); mov(eax, memd_a32[ss, ebp - 0x10c]);    /* mov eax, [ebp-0x10c] */
            ii(0x100d_d01f, 5); calld(Definitions.my_ctor_c17, -0xec15); /* call 0x100ce40f */
            ii(0x100d_d024, 6); mov(memd_a32[ss, ebp - 0x114], eax);    /* mov [ebp-0x114], eax */
            ii(0x100d_d02a, 6); mov(eax, memd_a32[ss, ebp - 0x114]);    /* mov eax, [ebp-0x114] */
            ii(0x100d_d030, 6); mov(memd_a32[ss, ebp - 0x118], eax);    /* mov [ebp-0x118], eax */
            ii(0x100d_d036, 2); jmpd(0x100d_d044, 0xc); goto l_0x100d_d044; /* jmp 0x100dd044 */
        l_0x100d_d038:
            ii(0x100d_d038, 6); mov(eax, memd_a32[ss, ebp - 0x110]);    /* mov eax, [ebp-0x110] */
            ii(0x100d_d03e, 6); mov(memd_a32[ss, ebp - 0x118], eax);    /* mov [ebp-0x118], eax */
        l_0x100d_d044:
            ii(0x100d_d044, 6); mov(eax, memd_a32[ss, ebp - 0x118]);    /* mov eax, [ebp-0x118] */
            ii(0x100d_d04a, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_d04d, 6); mov(memd_a32[ds, edx + 0x351], eax);    /* mov [edx+0x351], eax */
            ii(0x100d_d053, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_d058, 5); calld(Definitions.sys_new, 0x88da3);    /* call 0x10165e00 */
            ii(0x100d_d05d, 6); mov(memd_a32[ss, ebp - 0x11c], eax);    /* mov [ebp-0x11c], eax */
            ii(0x100d_d063, 6); mov(eax, memd_a32[ss, ebp - 0x11c]);    /* mov eax, [ebp-0x11c] */
            ii(0x100d_d069, 6); mov(memd_a32[ss, ebp - 0x120], eax);    /* mov [ebp-0x120], eax */
            ii(0x100d_d06f, 7); cmp(memd_a32[ss, ebp - 0x120], 0);      /* cmp dword [ebp-0x120], 0x0 */
            ii(0x100d_d076, 2); if(jzd(0x100d_d0ac, 0x34)) goto l_0x100d_d0ac; /* jz 0x100dd0ac */
            ii(0x100d_d078, 5); mov(eax, 0x1c4);                        /* mov eax, 0x1c4 */
            ii(0x100d_d07d, 1); pushd(eax);                             /* push eax */
            ii(0x100d_d07e, 5); mov(ecx, 0x1a4);                        /* mov ecx, 0x1a4 */
            ii(0x100d_d083, 5); mov(ebx, 0x12d);                        /* mov ebx, 0x12d */
            ii(0x100d_d088, 5); mov(edx, 0x12c);                        /* mov edx, 0x12c */
            ii(0x100d_d08d, 6); mov(eax, memd_a32[ss, ebp - 0x11c]);    /* mov eax, [ebp-0x11c] */
            ii(0x100d_d093, 5); calld(Definitions.my_ctor_c17, -0xec89); /* call 0x100ce40f */
            ii(0x100d_d098, 6); mov(memd_a32[ss, ebp - 0x124], eax);    /* mov [ebp-0x124], eax */
            ii(0x100d_d09e, 6); mov(eax, memd_a32[ss, ebp - 0x124]);    /* mov eax, [ebp-0x124] */
            ii(0x100d_d0a4, 6); mov(memd_a32[ss, ebp - 0x128], eax);    /* mov [ebp-0x128], eax */
            ii(0x100d_d0aa, 2); jmpd(0x100d_d0b8, 0xc); goto l_0x100d_d0b8; /* jmp 0x100dd0b8 */
        l_0x100d_d0ac:
            ii(0x100d_d0ac, 6); mov(eax, memd_a32[ss, ebp - 0x120]);    /* mov eax, [ebp-0x120] */
            ii(0x100d_d0b2, 6); mov(memd_a32[ss, ebp - 0x128], eax);    /* mov [ebp-0x128], eax */
        l_0x100d_d0b8:
            ii(0x100d_d0b8, 6); mov(eax, memd_a32[ss, ebp - 0x128]);    /* mov eax, [ebp-0x128] */
            ii(0x100d_d0be, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_d0c1, 6); mov(memd_a32[ds, edx + 0x355], eax);    /* mov [edx+0x355], eax */
            ii(0x100d_d0c7, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_d0cc, 5); calld(Definitions.sys_new, 0x88d2f);    /* call 0x10165e00 */
            ii(0x100d_d0d1, 6); mov(memd_a32[ss, ebp - 0x12c], eax);    /* mov [ebp-0x12c], eax */
            ii(0x100d_d0d7, 6); mov(eax, memd_a32[ss, ebp - 0x12c]);    /* mov eax, [ebp-0x12c] */
            ii(0x100d_d0dd, 6); mov(memd_a32[ss, ebp - 0x130], eax);    /* mov [ebp-0x130], eax */
            ii(0x100d_d0e3, 7); cmp(memd_a32[ss, ebp - 0x130], 0);      /* cmp dword [ebp-0x130], 0x0 */
            ii(0x100d_d0ea, 2); if(jzd(0x100d_d120, 0x34)) goto l_0x100d_d120; /* jz 0x100dd120 */
            ii(0x100d_d0ec, 5); mov(eax, 0x1c4);                        /* mov eax, 0x1c4 */
            ii(0x100d_d0f1, 1); pushd(eax);                             /* push eax */
            ii(0x100d_d0f2, 5); mov(ecx, 0x165);                        /* mov ecx, 0x165 */
            ii(0x100d_d0f7, 5); mov(ebx, 0x12b);                        /* mov ebx, 0x12b */
            ii(0x100d_d0fc, 5); mov(edx, 0x12a);                        /* mov edx, 0x12a */
            ii(0x100d_d101, 6); mov(eax, memd_a32[ss, ebp - 0x12c]);    /* mov eax, [ebp-0x12c] */
            ii(0x100d_d107, 5); calld(Definitions.my_ctor_c17, -0xecfd); /* call 0x100ce40f */
            ii(0x100d_d10c, 6); mov(memd_a32[ss, ebp - 0x134], eax);    /* mov [ebp-0x134], eax */
            ii(0x100d_d112, 6); mov(eax, memd_a32[ss, ebp - 0x134]);    /* mov eax, [ebp-0x134] */
            ii(0x100d_d118, 6); mov(memd_a32[ss, ebp - 0x138], eax);    /* mov [ebp-0x138], eax */
            ii(0x100d_d11e, 2); jmpd(0x100d_d12c, 0xc); goto l_0x100d_d12c; /* jmp 0x100dd12c */
        l_0x100d_d120:
            ii(0x100d_d120, 6); mov(eax, memd_a32[ss, ebp - 0x130]);    /* mov eax, [ebp-0x130] */
            ii(0x100d_d126, 6); mov(memd_a32[ss, ebp - 0x138], eax);    /* mov [ebp-0x138], eax */
        l_0x100d_d12c:
            ii(0x100d_d12c, 6); mov(eax, memd_a32[ss, ebp - 0x138]);    /* mov eax, [ebp-0x138] */
            ii(0x100d_d132, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_d135, 6); mov(memd_a32[ds, edx + 0x359], eax);    /* mov [edx+0x359], eax */
            ii(0x100d_d13b, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_d140, 5); calld(Definitions.sys_new, 0x88cbb);    /* call 0x10165e00 */
            ii(0x100d_d145, 6); mov(memd_a32[ss, ebp - 0x13c], eax);    /* mov [ebp-0x13c], eax */
            ii(0x100d_d14b, 6); mov(eax, memd_a32[ss, ebp - 0x13c]);    /* mov eax, [ebp-0x13c] */
            ii(0x100d_d151, 6); mov(memd_a32[ss, ebp - 0x140], eax);    /* mov [ebp-0x140], eax */
            ii(0x100d_d157, 7); cmp(memd_a32[ss, ebp - 0x140], 0);      /* cmp dword [ebp-0x140], 0x0 */
            ii(0x100d_d15e, 2); if(jzd(0x100d_d194, 0x34)) goto l_0x100d_d194; /* jz 0x100dd194 */
            ii(0x100d_d160, 5); mov(eax, 0x19b);                        /* mov eax, 0x19b */
            ii(0x100d_d165, 1); pushd(eax);                             /* push eax */
            ii(0x100d_d166, 5); mov(ecx, 0x1d3);                        /* mov ecx, 0x1d3 */
            ii(0x100d_d16b, 5); mov(ebx, 0x141);                        /* mov ebx, 0x141 */
            ii(0x100d_d170, 5); mov(edx, 0x140);                        /* mov edx, 0x140 */
            ii(0x100d_d175, 6); mov(eax, memd_a32[ss, ebp - 0x13c]);    /* mov eax, [ebp-0x13c] */
            ii(0x100d_d17b, 5); calld(Definitions.my_ctor_c17, -0xed71); /* call 0x100ce40f */
            ii(0x100d_d180, 6); mov(memd_a32[ss, ebp - 0x144], eax);    /* mov [ebp-0x144], eax */
            ii(0x100d_d186, 6); mov(eax, memd_a32[ss, ebp - 0x144]);    /* mov eax, [ebp-0x144] */
            ii(0x100d_d18c, 6); mov(memd_a32[ss, ebp - 0x148], eax);    /* mov [ebp-0x148], eax */
            ii(0x100d_d192, 2); jmpd(0x100d_d1a0, 0xc); goto l_0x100d_d1a0; /* jmp 0x100dd1a0 */
        l_0x100d_d194:
            ii(0x100d_d194, 6); mov(eax, memd_a32[ss, ebp - 0x140]);    /* mov eax, [ebp-0x140] */
            ii(0x100d_d19a, 6); mov(memd_a32[ss, ebp - 0x148], eax);    /* mov [ebp-0x148], eax */
        l_0x100d_d1a0:
            ii(0x100d_d1a0, 6); mov(eax, memd_a32[ss, ebp - 0x148]);    /* mov eax, [ebp-0x148] */
            ii(0x100d_d1a6, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_d1a9, 6); mov(memd_a32[ds, edx + 0x35d], eax);    /* mov [edx+0x35d], eax */
            ii(0x100d_d1af, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_d1b4, 5); calld(Definitions.sys_new, 0x88c47);    /* call 0x10165e00 */
            ii(0x100d_d1b9, 6); mov(memd_a32[ss, ebp - 0x14c], eax);    /* mov [ebp-0x14c], eax */
            ii(0x100d_d1bf, 6); mov(eax, memd_a32[ss, ebp - 0x14c]);    /* mov eax, [ebp-0x14c] */
            ii(0x100d_d1c5, 6); mov(memd_a32[ss, ebp - 0x150], eax);    /* mov [ebp-0x150], eax */
            ii(0x100d_d1cb, 7); cmp(memd_a32[ss, ebp - 0x150], 0);      /* cmp dword [ebp-0x150], 0x0 */
            ii(0x100d_d1d2, 2); if(jzd(0x100d_d208, 0x34)) goto l_0x100d_d208; /* jz 0x100dd208 */
            ii(0x100d_d1d4, 5); mov(eax, 0x19b);                        /* mov eax, 0x19b */
            ii(0x100d_d1d9, 1); pushd(eax);                             /* push eax */
            ii(0x100d_d1da, 5); mov(ecx, 0x1f4);                        /* mov ecx, 0x1f4 */
            ii(0x100d_d1df, 5); mov(ebx, 0x143);                        /* mov ebx, 0x143 */
            ii(0x100d_d1e4, 5); mov(edx, 0x142);                        /* mov edx, 0x142 */
            ii(0x100d_d1e9, 6); mov(eax, memd_a32[ss, ebp - 0x14c]);    /* mov eax, [ebp-0x14c] */
            ii(0x100d_d1ef, 5); calld(Definitions.my_ctor_c17, -0xede5); /* call 0x100ce40f */
            ii(0x100d_d1f4, 6); mov(memd_a32[ss, ebp - 0x154], eax);    /* mov [ebp-0x154], eax */
            ii(0x100d_d1fa, 6); mov(eax, memd_a32[ss, ebp - 0x154]);    /* mov eax, [ebp-0x154] */
            ii(0x100d_d200, 6); mov(memd_a32[ss, ebp - 0x158], eax);    /* mov [ebp-0x158], eax */
            ii(0x100d_d206, 2); jmpd(0x100d_d214, 0xc); goto l_0x100d_d214; /* jmp 0x100dd214 */
        l_0x100d_d208:
            ii(0x100d_d208, 6); mov(eax, memd_a32[ss, ebp - 0x150]);    /* mov eax, [ebp-0x150] */
            ii(0x100d_d20e, 6); mov(memd_a32[ss, ebp - 0x158], eax);    /* mov [ebp-0x158], eax */
        l_0x100d_d214:
            ii(0x100d_d214, 6); mov(eax, memd_a32[ss, ebp - 0x158]);    /* mov eax, [ebp-0x158] */
            ii(0x100d_d21a, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_d21d, 6); mov(memd_a32[ds, edx + 0x361], eax);    /* mov [edx+0x361], eax */
            ii(0x100d_d223, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_d228, 5); calld(Definitions.sys_new, 0x88bd3);    /* call 0x10165e00 */
            ii(0x100d_d22d, 6); mov(memd_a32[ss, ebp - 0x15c], eax);    /* mov [ebp-0x15c], eax */
            ii(0x100d_d233, 6); mov(eax, memd_a32[ss, ebp - 0x15c]);    /* mov eax, [ebp-0x15c] */
            ii(0x100d_d239, 6); mov(memd_a32[ss, ebp - 0x160], eax);    /* mov [ebp-0x160], eax */
            ii(0x100d_d23f, 7); cmp(memd_a32[ss, ebp - 0x160], 0);      /* cmp dword [ebp-0x160], 0x0 */
            ii(0x100d_d246, 2); if(jzd(0x100d_d27c, 0x34)) goto l_0x100d_d27c; /* jz 0x100dd27c */
            ii(0x100d_d248, 5); mov(eax, 0x19b);                        /* mov eax, 0x19b */
            ii(0x100d_d24d, 1); pushd(eax);                             /* push eax */
            ii(0x100d_d24e, 5); mov(ecx, 0x215);                        /* mov ecx, 0x215 */
            ii(0x100d_d253, 5); mov(ebx, 0x145);                        /* mov ebx, 0x145 */
            ii(0x100d_d258, 5); mov(edx, 0x144);                        /* mov edx, 0x144 */
            ii(0x100d_d25d, 6); mov(eax, memd_a32[ss, ebp - 0x15c]);    /* mov eax, [ebp-0x15c] */
            ii(0x100d_d263, 5); calld(Definitions.my_ctor_c17, -0xee59); /* call 0x100ce40f */
            ii(0x100d_d268, 6); mov(memd_a32[ss, ebp - 0x164], eax);    /* mov [ebp-0x164], eax */
            ii(0x100d_d26e, 6); mov(eax, memd_a32[ss, ebp - 0x164]);    /* mov eax, [ebp-0x164] */
            ii(0x100d_d274, 6); mov(memd_a32[ss, ebp - 0x168], eax);    /* mov [ebp-0x168], eax */
            ii(0x100d_d27a, 2); jmpd(0x100d_d288, 0xc); goto l_0x100d_d288; /* jmp 0x100dd288 */
        l_0x100d_d27c:
            ii(0x100d_d27c, 6); mov(eax, memd_a32[ss, ebp - 0x160]);    /* mov eax, [ebp-0x160] */
            ii(0x100d_d282, 6); mov(memd_a32[ss, ebp - 0x168], eax);    /* mov [ebp-0x168], eax */
        l_0x100d_d288:
            ii(0x100d_d288, 6); mov(eax, memd_a32[ss, ebp - 0x168]);    /* mov eax, [ebp-0x168] */
            ii(0x100d_d28e, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_d291, 6); mov(memd_a32[ds, edx + 0x365], eax);    /* mov [edx+0x365], eax */
            ii(0x100d_d297, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_d29c, 5); calld(Definitions.sys_new, 0x88b5f);    /* call 0x10165e00 */
            ii(0x100d_d2a1, 6); mov(memd_a32[ss, ebp - 0x16c], eax);    /* mov [ebp-0x16c], eax */
            ii(0x100d_d2a7, 6); mov(eax, memd_a32[ss, ebp - 0x16c]);    /* mov eax, [ebp-0x16c] */
            ii(0x100d_d2ad, 6); mov(memd_a32[ss, ebp - 0x170], eax);    /* mov [ebp-0x170], eax */
            ii(0x100d_d2b3, 7); cmp(memd_a32[ss, ebp - 0x170], 0);      /* cmp dword [ebp-0x170], 0x0 */
            ii(0x100d_d2ba, 2); if(jzd(0x100d_d2f0, 0x34)) goto l_0x100d_d2f0; /* jz 0x100dd2f0 */
            ii(0x100d_d2bc, 5); mov(eax, 0x19b);                        /* mov eax, 0x19b */
            ii(0x100d_d2c1, 1); pushd(eax);                             /* push eax */
            ii(0x100d_d2c2, 5); mov(ecx, 0x235);                        /* mov ecx, 0x235 */
            ii(0x100d_d2c7, 5); mov(ebx, 0x147);                        /* mov ebx, 0x147 */
            ii(0x100d_d2cc, 5); mov(edx, 0x146);                        /* mov edx, 0x146 */
            ii(0x100d_d2d1, 6); mov(eax, memd_a32[ss, ebp - 0x16c]);    /* mov eax, [ebp-0x16c] */
            ii(0x100d_d2d7, 5); calld(Definitions.my_ctor_c17, -0xeecd); /* call 0x100ce40f */
            ii(0x100d_d2dc, 6); mov(memd_a32[ss, ebp - 0x174], eax);    /* mov [ebp-0x174], eax */
            ii(0x100d_d2e2, 6); mov(eax, memd_a32[ss, ebp - 0x174]);    /* mov eax, [ebp-0x174] */
            ii(0x100d_d2e8, 6); mov(memd_a32[ss, ebp - 0x178], eax);    /* mov [ebp-0x178], eax */
            ii(0x100d_d2ee, 2); jmpd(0x100d_d2fc, 0xc); goto l_0x100d_d2fc; /* jmp 0x100dd2fc */
        l_0x100d_d2f0:
            ii(0x100d_d2f0, 6); mov(eax, memd_a32[ss, ebp - 0x170]);    /* mov eax, [ebp-0x170] */
            ii(0x100d_d2f6, 6); mov(memd_a32[ss, ebp - 0x178], eax);    /* mov [ebp-0x178], eax */
        l_0x100d_d2fc:
            ii(0x100d_d2fc, 6); mov(eax, memd_a32[ss, ebp - 0x178]);    /* mov eax, [ebp-0x178] */
            ii(0x100d_d302, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_d305, 6); mov(memd_a32[ds, edx + 0x369], eax);    /* mov [edx+0x369], eax */
            ii(0x100d_d30b, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_d310, 5); calld(Definitions.sys_new, 0x88aeb);    /* call 0x10165e00 */
            ii(0x100d_d315, 6); mov(memd_a32[ss, ebp - 0x17c], eax);    /* mov [ebp-0x17c], eax */
            ii(0x100d_d31b, 6); mov(eax, memd_a32[ss, ebp - 0x17c]);    /* mov eax, [ebp-0x17c] */
            ii(0x100d_d321, 6); mov(memd_a32[ss, ebp - 0x180], eax);    /* mov [ebp-0x180], eax */
            ii(0x100d_d327, 7); cmp(memd_a32[ss, ebp - 0x180], 0);      /* cmp dword [ebp-0x180], 0x0 */
            ii(0x100d_d32e, 2); if(jzd(0x100d_d364, 0x34)) goto l_0x100d_d364; /* jz 0x100dd364 */
            ii(0x100d_d330, 5); mov(eax, 0x19b);                        /* mov eax, 0x19b */
            ii(0x100d_d335, 1); pushd(eax);                             /* push eax */
            ii(0x100d_d336, 5); mov(ecx, 0x256);                        /* mov ecx, 0x256 */
            ii(0x100d_d33b, 5); mov(ebx, 0x149);                        /* mov ebx, 0x149 */
            ii(0x100d_d340, 5); mov(edx, 0x148);                        /* mov edx, 0x148 */
            ii(0x100d_d345, 6); mov(eax, memd_a32[ss, ebp - 0x17c]);    /* mov eax, [ebp-0x17c] */
            ii(0x100d_d34b, 5); calld(Definitions.my_ctor_c17, -0xef41); /* call 0x100ce40f */
            ii(0x100d_d350, 6); mov(memd_a32[ss, ebp - 0x184], eax);    /* mov [ebp-0x184], eax */
            ii(0x100d_d356, 6); mov(eax, memd_a32[ss, ebp - 0x184]);    /* mov eax, [ebp-0x184] */
            ii(0x100d_d35c, 6); mov(memd_a32[ss, ebp - 0x188], eax);    /* mov [ebp-0x188], eax */
            ii(0x100d_d362, 2); jmpd(0x100d_d370, 0xc); goto l_0x100d_d370; /* jmp 0x100dd370 */
        l_0x100d_d364:
            ii(0x100d_d364, 6); mov(eax, memd_a32[ss, ebp - 0x180]);    /* mov eax, [ebp-0x180] */
            ii(0x100d_d36a, 6); mov(memd_a32[ss, ebp - 0x188], eax);    /* mov [ebp-0x188], eax */
        l_0x100d_d370:
            ii(0x100d_d370, 6); mov(eax, memd_a32[ss, ebp - 0x188]);    /* mov eax, [ebp-0x188] */
            ii(0x100d_d376, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_d379, 6); mov(memd_a32[ds, edx + 0x36d], eax);    /* mov [edx+0x36d], eax */
            ii(0x100d_d37f, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_d384, 5); calld(Definitions.sys_new, 0x88a77);    /* call 0x10165e00 */
            ii(0x100d_d389, 6); mov(memd_a32[ss, ebp - 0x18c], eax);    /* mov [ebp-0x18c], eax */
            ii(0x100d_d38f, 6); mov(eax, memd_a32[ss, ebp - 0x18c]);    /* mov eax, [ebp-0x18c] */
            ii(0x100d_d395, 6); mov(memd_a32[ss, ebp - 0x190], eax);    /* mov [ebp-0x190], eax */
            ii(0x100d_d39b, 7); cmp(memd_a32[ss, ebp - 0x190], 0);      /* cmp dword [ebp-0x190], 0x0 */
            ii(0x100d_d3a2, 2); if(jzd(0x100d_d3d8, 0x34)) goto l_0x100d_d3d8; /* jz 0x100dd3d8 */
            ii(0x100d_d3a4, 5); mov(eax, 0x1a8);                        /* mov eax, 0x1a8 */
            ii(0x100d_d3a9, 1); pushd(eax);                             /* push eax */
            ii(0x100d_d3aa, 5); mov(ecx, 0x19d);                        /* mov ecx, 0x19d */
            ii(0x100d_d3af, 5); mov(ebx, 0x11b);                        /* mov ebx, 0x11b */
            ii(0x100d_d3b4, 5); mov(edx, 0x11a);                        /* mov edx, 0x11a */
            ii(0x100d_d3b9, 6); mov(eax, memd_a32[ss, ebp - 0x18c]);    /* mov eax, [ebp-0x18c] */
            ii(0x100d_d3bf, 5); calld(Definitions.my_ctor_c17, -0xefb5); /* call 0x100ce40f */
            ii(0x100d_d3c4, 6); mov(memd_a32[ss, ebp - 0x194], eax);    /* mov [ebp-0x194], eax */
            ii(0x100d_d3ca, 6); mov(eax, memd_a32[ss, ebp - 0x194]);    /* mov eax, [ebp-0x194] */
            ii(0x100d_d3d0, 6); mov(memd_a32[ss, ebp - 0x198], eax);    /* mov [ebp-0x198], eax */
            ii(0x100d_d3d6, 2); jmpd(0x100d_d3e4, 0xc); goto l_0x100d_d3e4; /* jmp 0x100dd3e4 */
        l_0x100d_d3d8:
            ii(0x100d_d3d8, 6); mov(eax, memd_a32[ss, ebp - 0x190]);    /* mov eax, [ebp-0x190] */
            ii(0x100d_d3de, 6); mov(memd_a32[ss, ebp - 0x198], eax);    /* mov [ebp-0x198], eax */
        l_0x100d_d3e4:
            ii(0x100d_d3e4, 6); mov(eax, memd_a32[ss, ebp - 0x198]);    /* mov eax, [ebp-0x198] */
            ii(0x100d_d3ea, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_d3ed, 6); mov(memd_a32[ds, edx + 0x3cb], eax);    /* mov [edx+0x3cb], eax */
            ii(0x100d_d3f3, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_d3f8, 5); calld(Definitions.sys_new, 0x88a03);    /* call 0x10165e00 */
            ii(0x100d_d3fd, 6); mov(memd_a32[ss, ebp - 0x19c], eax);    /* mov [ebp-0x19c], eax */
            ii(0x100d_d403, 6); mov(eax, memd_a32[ss, ebp - 0x19c]);    /* mov eax, [ebp-0x19c] */
            ii(0x100d_d409, 6); mov(memd_a32[ss, ebp - 0x1a0], eax);    /* mov [ebp-0x1a0], eax */
            ii(0x100d_d40f, 7); cmp(memd_a32[ss, ebp - 0x1a0], 0);      /* cmp dword [ebp-0x1a0], 0x0 */
            ii(0x100d_d416, 2); if(jzd(0x100d_d44c, 0x34)) goto l_0x100d_d44c; /* jz 0x100dd44c */
            ii(0x100d_d418, 5); mov(eax, 0x1a8);                        /* mov eax, 0x1a8 */
            ii(0x100d_d41d, 1); pushd(eax);                             /* push eax */
            ii(0x100d_d41e, 5); mov(ecx, 0x1b1);                        /* mov ecx, 0x1b1 */
            ii(0x100d_d423, 5); mov(ebx, 0x11e);                        /* mov ebx, 0x11e */
            ii(0x100d_d428, 5); mov(edx, 0x11d);                        /* mov edx, 0x11d */
            ii(0x100d_d42d, 6); mov(eax, memd_a32[ss, ebp - 0x19c]);    /* mov eax, [ebp-0x19c] */
            ii(0x100d_d433, 5); calld(Definitions.my_ctor_c17, -0xf029); /* call 0x100ce40f */
            ii(0x100d_d438, 6); mov(memd_a32[ss, ebp - 0x1a4], eax);    /* mov [ebp-0x1a4], eax */
            ii(0x100d_d43e, 6); mov(eax, memd_a32[ss, ebp - 0x1a4]);    /* mov eax, [ebp-0x1a4] */
            ii(0x100d_d444, 6); mov(memd_a32[ss, ebp - 0x1a8], eax);    /* mov [ebp-0x1a8], eax */
            ii(0x100d_d44a, 2); jmpd(0x100d_d458, 0xc); goto l_0x100d_d458; /* jmp 0x100dd458 */
        l_0x100d_d44c:
            ii(0x100d_d44c, 6); mov(eax, memd_a32[ss, ebp - 0x1a0]);    /* mov eax, [ebp-0x1a0] */
            ii(0x100d_d452, 6); mov(memd_a32[ss, ebp - 0x1a8], eax);    /* mov [ebp-0x1a8], eax */
        l_0x100d_d458:
            ii(0x100d_d458, 6); mov(eax, memd_a32[ss, ebp - 0x1a8]);    /* mov eax, [ebp-0x1a8] */
            ii(0x100d_d45e, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_d461, 6); mov(memd_a32[ds, edx + 0x3cf], eax);    /* mov [edx+0x3cf], eax */
            ii(0x100d_d467, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_d46c, 5); calld(Definitions.sys_new, 0x8898f);    /* call 0x10165e00 */
            ii(0x100d_d471, 6); mov(memd_a32[ss, ebp - 0x1ac], eax);    /* mov [ebp-0x1ac], eax */
            ii(0x100d_d477, 6); mov(eax, memd_a32[ss, ebp - 0x1ac]);    /* mov eax, [ebp-0x1ac] */
            ii(0x100d_d47d, 6); mov(memd_a32[ss, ebp - 0x1b0], eax);    /* mov [ebp-0x1b0], eax */
            ii(0x100d_d483, 7); cmp(memd_a32[ss, ebp - 0x1b0], 0);      /* cmp dword [ebp-0x1b0], 0x0 */
            ii(0x100d_d48a, 2); if(jzd(0x100d_d4c0, 0x34)) goto l_0x100d_d4c0; /* jz 0x100dd4c0 */
            ii(0x100d_d48c, 5); mov(eax, 0xf0);                         /* mov eax, 0xf0 */
            ii(0x100d_d491, 1); pushd(eax);                             /* push eax */
            ii(0x100d_d492, 5); mov(ecx, 0x147);                        /* mov ecx, 0x147 */
            ii(0x100d_d497, 5); mov(ebx, 0x11b);                        /* mov ebx, 0x11b */
            ii(0x100d_d49c, 5); mov(edx, 0x11a);                        /* mov edx, 0x11a */
            ii(0x100d_d4a1, 6); mov(eax, memd_a32[ss, ebp - 0x1ac]);    /* mov eax, [ebp-0x1ac] */
            ii(0x100d_d4a7, 5); calld(Definitions.my_ctor_c17, -0xf09d); /* call 0x100ce40f */
            ii(0x100d_d4ac, 6); mov(memd_a32[ss, ebp - 0x1b4], eax);    /* mov [ebp-0x1b4], eax */
            ii(0x100d_d4b2, 6); mov(eax, memd_a32[ss, ebp - 0x1b4]);    /* mov eax, [ebp-0x1b4] */
            ii(0x100d_d4b8, 6); mov(memd_a32[ss, ebp - 0x1b8], eax);    /* mov [ebp-0x1b8], eax */
            ii(0x100d_d4be, 2); jmpd(0x100d_d4cc, 0xc); goto l_0x100d_d4cc; /* jmp 0x100dd4cc */
        l_0x100d_d4c0:
            ii(0x100d_d4c0, 6); mov(eax, memd_a32[ss, ebp - 0x1b0]);    /* mov eax, [ebp-0x1b0] */
            ii(0x100d_d4c6, 6); mov(memd_a32[ss, ebp - 0x1b8], eax);    /* mov [ebp-0x1b8], eax */
        l_0x100d_d4cc:
            ii(0x100d_d4cc, 6); mov(eax, memd_a32[ss, ebp - 0x1b8]);    /* mov eax, [ebp-0x1b8] */
            ii(0x100d_d4d2, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_d4d5, 6); mov(memd_a32[ds, edx + 0x3c3], eax);    /* mov [edx+0x3c3], eax */
            ii(0x100d_d4db, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_d4e0, 5); calld(Definitions.sys_new, 0x8891b);    /* call 0x10165e00 */
            ii(0x100d_d4e5, 6); mov(memd_a32[ss, ebp - 0x1bc], eax);    /* mov [ebp-0x1bc], eax */
            ii(0x100d_d4eb, 6); mov(eax, memd_a32[ss, ebp - 0x1bc]);    /* mov eax, [ebp-0x1bc] */
            ii(0x100d_d4f1, 6); mov(memd_a32[ss, ebp - 0x1c0], eax);    /* mov [ebp-0x1c0], eax */
            ii(0x100d_d4f7, 7); cmp(memd_a32[ss, ebp - 0x1c0], 0);      /* cmp dword [ebp-0x1c0], 0x0 */
            ii(0x100d_d4fe, 2); if(jzd(0x100d_d534, 0x34)) goto l_0x100d_d534; /* jz 0x100dd534 */
            ii(0x100d_d500, 5); mov(eax, 0xf0);                         /* mov eax, 0xf0 */
            ii(0x100d_d505, 1); pushd(eax);                             /* push eax */
            ii(0x100d_d506, 5); mov(ecx, 0x15c);                        /* mov ecx, 0x15c */
            ii(0x100d_d50b, 5); mov(ebx, 0x11e);                        /* mov ebx, 0x11e */
            ii(0x100d_d510, 5); mov(edx, 0x11d);                        /* mov edx, 0x11d */
            ii(0x100d_d515, 6); mov(eax, memd_a32[ss, ebp - 0x1bc]);    /* mov eax, [ebp-0x1bc] */
            ii(0x100d_d51b, 5); calld(Definitions.my_ctor_c17, -0xf111); /* call 0x100ce40f */
            ii(0x100d_d520, 6); mov(memd_a32[ss, ebp - 0x1c4], eax);    /* mov [ebp-0x1c4], eax */
            ii(0x100d_d526, 6); mov(eax, memd_a32[ss, ebp - 0x1c4]);    /* mov eax, [ebp-0x1c4] */
            ii(0x100d_d52c, 6); mov(memd_a32[ss, ebp - 0x1c8], eax);    /* mov [ebp-0x1c8], eax */
            ii(0x100d_d532, 2); jmpd(0x100d_d540, 0xc); goto l_0x100d_d540; /* jmp 0x100dd540 */
        l_0x100d_d534:
            ii(0x100d_d534, 6); mov(eax, memd_a32[ss, ebp - 0x1c0]);    /* mov eax, [ebp-0x1c0] */
            ii(0x100d_d53a, 6); mov(memd_a32[ss, ebp - 0x1c8], eax);    /* mov [ebp-0x1c8], eax */
        l_0x100d_d540:
            ii(0x100d_d540, 6); mov(eax, memd_a32[ss, ebp - 0x1c8]);    /* mov eax, [ebp-0x1c8] */
            ii(0x100d_d546, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_d549, 6); mov(memd_a32[ds, edx + 0x3c7], eax);    /* mov [edx+0x3c7], eax */
            ii(0x100d_d54f, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_d554, 5); calld(Definitions.sys_new, 0x888a7);    /* call 0x10165e00 */
            ii(0x100d_d559, 6); mov(memd_a32[ss, ebp - 0x1cc], eax);    /* mov [ebp-0x1cc], eax */
            ii(0x100d_d55f, 6); mov(eax, memd_a32[ss, ebp - 0x1cc]);    /* mov eax, [ebp-0x1cc] */
            ii(0x100d_d565, 6); mov(memd_a32[ss, ebp - 0x1d0], eax);    /* mov [ebp-0x1d0], eax */
            ii(0x100d_d56b, 7); cmp(memd_a32[ss, ebp - 0x1d0], 0);      /* cmp dword [ebp-0x1d0], 0x0 */
            ii(0x100d_d572, 2); if(jzd(0x100d_d5a8, 0x34)) goto l_0x100d_d5a8; /* jz 0x100dd5a8 */
            ii(0x100d_d574, 5); mov(eax, 0x1be);                        /* mov eax, 0x1be */
            ii(0x100d_d579, 1); pushd(eax);                             /* push eax */
            ii(0x100d_d57a, 5); mov(ecx, 0x21e);                        /* mov ecx, 0x21e */
            ii(0x100d_d57f, 5); mov(ebx, 0x185);                        /* mov ebx, 0x185 */
            ii(0x100d_d584, 5); mov(edx, 0x184);                        /* mov edx, 0x184 */
            ii(0x100d_d589, 6); mov(eax, memd_a32[ss, ebp - 0x1cc]);    /* mov eax, [ebp-0x1cc] */
            ii(0x100d_d58f, 5); calld(Definitions.my_ctor_c17, -0xf185); /* call 0x100ce40f */
            ii(0x100d_d594, 6); mov(memd_a32[ss, ebp - 0x1d4], eax);    /* mov [ebp-0x1d4], eax */
            ii(0x100d_d59a, 6); mov(eax, memd_a32[ss, ebp - 0x1d4]);    /* mov eax, [ebp-0x1d4] */
            ii(0x100d_d5a0, 6); mov(memd_a32[ss, ebp - 0x1d8], eax);    /* mov [ebp-0x1d8], eax */
            ii(0x100d_d5a6, 2); jmpd(0x100d_d5b4, 0xc); goto l_0x100d_d5b4; /* jmp 0x100dd5b4 */
        l_0x100d_d5a8:
            ii(0x100d_d5a8, 6); mov(eax, memd_a32[ss, ebp - 0x1d0]);    /* mov eax, [ebp-0x1d0] */
            ii(0x100d_d5ae, 6); mov(memd_a32[ss, ebp - 0x1d8], eax);    /* mov [ebp-0x1d8], eax */
        l_0x100d_d5b4:
            ii(0x100d_d5b4, 6); mov(eax, memd_a32[ss, ebp - 0x1d8]);    /* mov eax, [ebp-0x1d8] */
            ii(0x100d_d5ba, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_d5bd, 6); mov(memd_a32[ds, edx + 0x3d3], eax);    /* mov [edx+0x3d3], eax */
            ii(0x100d_d5c3, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_d5c8, 5); calld(Definitions.sys_new, 0x88833);    /* call 0x10165e00 */
            ii(0x100d_d5cd, 6); mov(memd_a32[ss, ebp - 0x1dc], eax);    /* mov [ebp-0x1dc], eax */
            ii(0x100d_d5d3, 6); mov(eax, memd_a32[ss, ebp - 0x1dc]);    /* mov eax, [ebp-0x1dc] */
            ii(0x100d_d5d9, 6); mov(memd_a32[ss, ebp - 0x1e0], eax);    /* mov [ebp-0x1e0], eax */
            ii(0x100d_d5df, 7); cmp(memd_a32[ss, ebp - 0x1e0], 0);      /* cmp dword [ebp-0x1e0], 0x0 */
            ii(0x100d_d5e6, 2); if(jzd(0x100d_d61c, 0x34)) goto l_0x100d_d61c; /* jz 0x100dd61c */
            ii(0x100d_d5e8, 5); mov(eax, 0xf0);                         /* mov eax, 0xf0 */
            ii(0x100d_d5ed, 1); pushd(eax);                             /* push eax */
            ii(0x100d_d5ee, 5); mov(ecx, 0x19c);                        /* mov ecx, 0x19c */
            ii(0x100d_d5f3, 5); mov(ebx, 0x187);                        /* mov ebx, 0x187 */
            ii(0x100d_d5f8, 5); mov(edx, 0x186);                        /* mov edx, 0x186 */
            ii(0x100d_d5fd, 6); mov(eax, memd_a32[ss, ebp - 0x1dc]);    /* mov eax, [ebp-0x1dc] */
            ii(0x100d_d603, 5); calld(Definitions.my_ctor_c17, -0xf1f9); /* call 0x100ce40f */
            ii(0x100d_d608, 6); mov(memd_a32[ss, ebp - 0x1e4], eax);    /* mov [ebp-0x1e4], eax */
            ii(0x100d_d60e, 6); mov(eax, memd_a32[ss, ebp - 0x1e4]);    /* mov eax, [ebp-0x1e4] */
            ii(0x100d_d614, 6); mov(memd_a32[ss, ebp - 0x1e8], eax);    /* mov [ebp-0x1e8], eax */
            ii(0x100d_d61a, 2); jmpd(0x100d_d628, 0xc); goto l_0x100d_d628; /* jmp 0x100dd628 */
        l_0x100d_d61c:
            ii(0x100d_d61c, 6); mov(eax, memd_a32[ss, ebp - 0x1e0]);    /* mov eax, [ebp-0x1e0] */
            ii(0x100d_d622, 6); mov(memd_a32[ss, ebp - 0x1e8], eax);    /* mov [ebp-0x1e8], eax */
        l_0x100d_d628:
            ii(0x100d_d628, 6); mov(eax, memd_a32[ss, ebp - 0x1e8]);    /* mov eax, [ebp-0x1e8] */
            ii(0x100d_d62e, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_d631, 6); mov(memd_a32[ds, edx + 0x3d7], eax);    /* mov [edx+0x3d7], eax */
            ii(0x100d_d637, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_d63c, 5); calld(Definitions.sys_new, 0x887bf);    /* call 0x10165e00 */
            ii(0x100d_d641, 6); mov(memd_a32[ss, ebp - 0x1ec], eax);    /* mov [ebp-0x1ec], eax */
            ii(0x100d_d647, 6); mov(eax, memd_a32[ss, ebp - 0x1ec]);    /* mov eax, [ebp-0x1ec] */
            ii(0x100d_d64d, 6); mov(memd_a32[ss, ebp - 0x1f0], eax);    /* mov [ebp-0x1f0], eax */
            ii(0x100d_d653, 7); cmp(memd_a32[ss, ebp - 0x1f0], 0);      /* cmp dword [ebp-0x1f0], 0x0 */
            ii(0x100d_d65a, 2); if(jzd(0x100d_d690, 0x34)) goto l_0x100d_d690; /* jz 0x100dd690 */
            ii(0x100d_d65c, 5); mov(eax, 0x182);                        /* mov eax, 0x182 */
            ii(0x100d_d661, 1); pushd(eax);                             /* push eax */
            ii(0x100d_d662, 5); mov(ecx, 0x24e);                        /* mov ecx, 0x24e */
            ii(0x100d_d667, 5); mov(ebx, 0x18a);                        /* mov ebx, 0x18a */
            ii(0x100d_d66c, 5); mov(edx, 0x189);                        /* mov edx, 0x189 */
            ii(0x100d_d671, 6); mov(eax, memd_a32[ss, ebp - 0x1ec]);    /* mov eax, [ebp-0x1ec] */
            ii(0x100d_d677, 5); calld(Definitions.my_ctor_c17, -0xf26d); /* call 0x100ce40f */
            ii(0x100d_d67c, 6); mov(memd_a32[ss, ebp - 0x1f4], eax);    /* mov [ebp-0x1f4], eax */
            ii(0x100d_d682, 6); mov(eax, memd_a32[ss, ebp - 0x1f4]);    /* mov eax, [ebp-0x1f4] */
            ii(0x100d_d688, 6); mov(memd_a32[ss, ebp - 0x1f8], eax);    /* mov [ebp-0x1f8], eax */
            ii(0x100d_d68e, 2); jmpd(0x100d_d69c, 0xc); goto l_0x100d_d69c; /* jmp 0x100dd69c */
        l_0x100d_d690:
            ii(0x100d_d690, 6); mov(eax, memd_a32[ss, ebp - 0x1f0]);    /* mov eax, [ebp-0x1f0] */
            ii(0x100d_d696, 6); mov(memd_a32[ss, ebp - 0x1f8], eax);    /* mov [ebp-0x1f8], eax */
        l_0x100d_d69c:
            ii(0x100d_d69c, 6); mov(eax, memd_a32[ss, ebp - 0x1f8]);    /* mov eax, [ebp-0x1f8] */
            ii(0x100d_d6a2, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_d6a5, 6); mov(memd_a32[ds, edx + 0x3db], eax);    /* mov [edx+0x3db], eax */
            ii(0x100d_d6ab, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x100d_d6b0, 5); calld(/* sys */ 0x1016_a24c, 0x8cb97);  /* call 0x1016a24c */
            ii(0x100d_d6b5, 6); lea(eax, ebp - 0x1fc);                  /* lea eax, [ebp-0x1fc] */
            ii(0x100d_d6bb, 5); calld(0x100d_5224, -0x849c);            /* call 0x100d5224 */
            ii(0x100d_d6c0, 1); pushd(eax);                             /* push eax */
            ii(0x100d_d6c1, 6); lea(eax, ebp - 0x200);                  /* lea eax, [ebp-0x200] */
            ii(0x100d_d6c7, 5); calld(0x100d_5250, -0x847c);            /* call 0x100d5250 */
            ii(0x100d_d6cc, 1); pushd(eax);                             /* push eax */
            ii(0x100d_d6cd, 6); lea(eax, ebp - 0x204);                  /* lea eax, [ebp-0x204] */
            ii(0x100d_d6d3, 5); calld(0x100d_527c, -0x845c);            /* call 0x100d527c */
            ii(0x100d_d6d8, 1); pushd(eax);                             /* push eax */
            ii(0x100d_d6d9, 6); lea(eax, ebp - 0x208);                  /* lea eax, [ebp-0x208] */
            ii(0x100d_d6df, 5); calld(0x100d_52a8, -0x843c);            /* call 0x100d52a8 */
            ii(0x100d_d6e4, 1); pushd(eax);                             /* push eax */
            ii(0x100d_d6e5, 5); calld(0x100d_52d4, -0x8416);            /* call 0x100d52d4 */
            ii(0x100d_d6ea, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100d_d6ed, 5); calld(0x100d_52f8, -0x83fa);            /* call 0x100d52f8 */
            ii(0x100d_d6f2, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100d_d6f5, 5); mov(edx, 0x101a_1a47);                  /* mov edx, 0x101a1a47 */ /* "Delete" */
            ii(0x100d_d6fa, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_d6fd, 6); mov(eax, memd_a32[ds, eax + 0x3d7]);    /* mov eax, [eax+0x3d7] */
            ii(0x100d_d703, 5); calld(0x100c_ef64, -0xe7a4);            /* call 0x100cef64 */
            ii(0x100d_d708, 6); lea(eax, ebp - 0x20c);                  /* lea eax, [ebp-0x20c] */
            ii(0x100d_d70e, 5); calld(0x100d_5224, -0x84ef);            /* call 0x100d5224 */
            ii(0x100d_d713, 1); pushd(eax);                             /* push eax */
            ii(0x100d_d714, 6); lea(eax, ebp - 0x210);                  /* lea eax, [ebp-0x210] */
            ii(0x100d_d71a, 5); calld(0x100d_5250, -0x84cf);            /* call 0x100d5250 */
            ii(0x100d_d71f, 1); pushd(eax);                             /* push eax */
            ii(0x100d_d720, 6); lea(eax, ebp - 0x214);                  /* lea eax, [ebp-0x214] */
            ii(0x100d_d726, 5); calld(0x100d_527c, -0x84af);            /* call 0x100d527c */
            ii(0x100d_d72b, 1); pushd(eax);                             /* push eax */
            ii(0x100d_d72c, 6); lea(eax, ebp - 0x218);                  /* lea eax, [ebp-0x218] */
            ii(0x100d_d732, 5); calld(0x100d_52a8, -0x848f);            /* call 0x100d52a8 */
            ii(0x100d_d737, 1); pushd(eax);                             /* push eax */
            ii(0x100d_d738, 5); calld(0x100d_52d4, -0x8469);            /* call 0x100d52d4 */
            ii(0x100d_d73d, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100d_d740, 5); calld(0x100d_52f8, -0x844d);            /* call 0x100d52f8 */
            ii(0x100d_d745, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100d_d748, 5); mov(edx, 0x101a_1a4e);                  /* mov edx, 0x101a1a4e */ /* "Buy" */
            ii(0x100d_d74d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_d750, 6); mov(eax, memd_a32[ds, eax + 0x3db]);    /* mov eax, [eax+0x3db] */
            ii(0x100d_d756, 5); calld(0x100c_ef64, -0xe7f7);            /* call 0x100cef64 */
            ii(0x100d_d75b, 6); lea(eax, ebp - 0x21c);                  /* lea eax, [ebp-0x21c] */
            ii(0x100d_d761, 5); calld(0x100e_0ba4, 0x343e);             /* call 0x100e0ba4 */
            ii(0x100d_d766, 1); pushd(eax);                             /* push eax */
            ii(0x100d_d767, 6); lea(eax, ebp - 0x220);                  /* lea eax, [ebp-0x220] */
            ii(0x100d_d76d, 5); calld(0x100e_0bd0, 0x345e);             /* call 0x100e0bd0 */
            ii(0x100d_d772, 1); pushd(eax);                             /* push eax */
            ii(0x100d_d773, 5); mov(edx, 0x101c_3678);                  /* mov edx, 0x101c3678 */
            ii(0x100d_d778, 6); lea(eax, ebp - 0x224);                  /* lea eax, [ebp-0x224] */
            ii(0x100d_d77e, 5); calld(0x100d_4d78, -0x8a0b);            /* call 0x100d4d78 */
            ii(0x100d_d783, 1); pushd(eax);                             /* push eax */
            ii(0x100d_d784, 5); mov(edx, 0x101c_35a4);                  /* mov edx, 0x101c35a4 */
            ii(0x100d_d789, 6); lea(eax, ebp - 0x228);                  /* lea eax, [ebp-0x228] */
            ii(0x100d_d78f, 5); calld(0x100d_4d78, -0x8a1c);            /* call 0x100d4d78 */
            ii(0x100d_d794, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x100d_d796, 5); mov(eax, 0xf);                          /* mov eax, 0xf */
            ii(0x100d_d79b, 1); pushd(eax);                             /* push eax */
            ii(0x100d_d79c, 5); mov(ecx, 0x50);                         /* mov ecx, 0x50 */
            ii(0x100d_d7a1, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100d_d7a3, 5); mov(edx, 0x14);                         /* mov edx, 0x14 */
            ii(0x100d_d7a8, 6); lea(eax, ebp - 0x238);                  /* lea eax, [ebp-0x238] */
            ii(0x100d_d7ae, 5); calld(0x1008_b148, -0x5266b);           /* call 0x1008b148 */
            ii(0x100d_d7b3, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100d_d7b5, 5); mov(edx, 0x101a_1a52);                  /* mov edx, 0x101a1a52 */ /* "Buy Units" */
            ii(0x100d_d7ba, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_d7bd, 6); mov(eax, memd_a32[ds, eax + 0x3d3]);    /* mov eax, [eax+0x3d3] */
            ii(0x100d_d7c3, 2); mov(ecx, esi);                          /* mov ecx, esi */
            ii(0x100d_d7c5, 5); calld(0x100c_edcd, -0xe9fd);            /* call 0x100cedcd */
            ii(0x100d_d7ca, 6); lea(eax, ebp - 0x23c);                  /* lea eax, [ebp-0x23c] */
            ii(0x100d_d7d0, 5); calld(0x100e_0ba4, 0x33cf);             /* call 0x100e0ba4 */
            ii(0x100d_d7d5, 1); pushd(eax);                             /* push eax */
            ii(0x100d_d7d6, 6); lea(eax, ebp - 0x240);                  /* lea eax, [ebp-0x240] */
            ii(0x100d_d7dc, 5); calld(0x100e_0bd0, 0x33ef);             /* call 0x100e0bd0 */
            ii(0x100d_d7e1, 1); pushd(eax);                             /* push eax */
            ii(0x100d_d7e2, 6); lea(eax, ebp - 0x244);                  /* lea eax, [ebp-0x244] */
            ii(0x100d_d7e8, 5); calld(0x100e_0bfc, 0x340f);             /* call 0x100e0bfc */
            ii(0x100d_d7ed, 1); pushd(eax);                             /* push eax */
            ii(0x100d_d7ee, 6); lea(eax, ebp - 0x248);                  /* lea eax, [ebp-0x248] */
            ii(0x100d_d7f4, 5); calld(0x100e_0c28, 0x342f);             /* call 0x100e0c28 */
            ii(0x100d_d7f9, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x100d_d7fb, 5); mov(eax, 0x1f);                         /* mov eax, 0x1f */
            ii(0x100d_d800, 1); pushd(eax);                             /* push eax */
            ii(0x100d_d801, 5); mov(ecx, 0x50);                         /* mov ecx, 0x50 */
            ii(0x100d_d806, 5); mov(ebx, 0xf);                          /* mov ebx, 0xf */
            ii(0x100d_d80b, 5); mov(edx, 0x14);                         /* mov edx, 0x14 */
            ii(0x100d_d810, 6); lea(eax, ebp - 0x258);                  /* lea eax, [ebp-0x258] */
            ii(0x100d_d816, 5); calld(0x1008_b148, -0x526d3);           /* call 0x1008b148 */
            ii(0x100d_d81b, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100d_d81d, 5); mov(edx, 0x101a_1a5c);                  /* mov edx, 0x101a1a5c */ /* "Upgrades" */
            ii(0x100d_d822, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_d825, 6); mov(eax, memd_a32[ds, eax + 0x3d3]);    /* mov eax, [eax+0x3d3] */
            ii(0x100d_d82b, 2); mov(ecx, esi);                          /* mov ecx, esi */
            ii(0x100d_d82d, 5); calld(0x100c_edcd, -0xea65);            /* call 0x100cedcd */
            ii(0x100d_d832, 5); mov(edx, 0x11c);                        /* mov edx, 0x11c */
            ii(0x100d_d837, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_d83a, 6); mov(eax, memd_a32[ds, eax + 0x349]);    /* mov eax, [eax+0x349] */
            ii(0x100d_d840, 5); calld(0x100c_f2ba, -0xe58b);            /* call 0x100cf2ba */
            ii(0x100d_d845, 5); mov(edx, 0x11f);                        /* mov edx, 0x11f */
            ii(0x100d_d84a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_d84d, 6); mov(eax, memd_a32[ds, eax + 0x34d]);    /* mov eax, [eax+0x34d] */
            ii(0x100d_d853, 5); calld(0x100c_f2ba, -0xe59e);            /* call 0x100cf2ba */
            ii(0x100d_d858, 5); mov(edx, 0x11c);                        /* mov edx, 0x11c */
            ii(0x100d_d85d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_d860, 6); mov(eax, memd_a32[ds, eax + 0x3cb]);    /* mov eax, [eax+0x3cb] */
            ii(0x100d_d866, 5); calld(0x100c_f2ba, -0xe5b1);            /* call 0x100cf2ba */
            ii(0x100d_d86b, 5); mov(edx, 0x11f);                        /* mov edx, 0x11f */
            ii(0x100d_d870, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_d873, 6); mov(eax, memd_a32[ds, eax + 0x3cf]);    /* mov eax, [eax+0x3cf] */
            ii(0x100d_d879, 5); calld(0x100c_f2ba, -0xe5c4);            /* call 0x100cf2ba */
            ii(0x100d_d87e, 5); mov(edx, 0x18d);                        /* mov edx, 0x18d */
            ii(0x100d_d883, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_d886, 6); mov(eax, memd_a32[ds, eax + 0x35d]);    /* mov eax, [eax+0x35d] */
            ii(0x100d_d88c, 5); calld(0x100c_f2ba, -0xe5d7);            /* call 0x100cf2ba */
            ii(0x100d_d891, 5); mov(edx, 0x18d);                        /* mov edx, 0x18d */
            ii(0x100d_d896, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_d899, 6); mov(eax, memd_a32[ds, eax + 0x35d]);    /* mov eax, [eax+0x35d] */
            ii(0x100d_d89f, 5); calld(0x100c_f363, -0xe541);            /* call 0x100cf363 */
            ii(0x100d_d8a4, 5); mov(edx, 0x18d);                        /* mov edx, 0x18d */
            ii(0x100d_d8a9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_d8ac, 6); mov(eax, memd_a32[ds, eax + 0x361]);    /* mov eax, [eax+0x361] */
            ii(0x100d_d8b2, 5); calld(0x100c_f2ba, -0xe5fd);            /* call 0x100cf2ba */
            ii(0x100d_d8b7, 5); mov(edx, 0x18d);                        /* mov edx, 0x18d */
            ii(0x100d_d8bc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_d8bf, 6); mov(eax, memd_a32[ds, eax + 0x361]);    /* mov eax, [eax+0x361] */
            ii(0x100d_d8c5, 5); calld(0x100c_f363, -0xe567);            /* call 0x100cf363 */
            ii(0x100d_d8ca, 5); mov(edx, 0x18d);                        /* mov edx, 0x18d */
            ii(0x100d_d8cf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_d8d2, 6); mov(eax, memd_a32[ds, eax + 0x365]);    /* mov eax, [eax+0x365] */
            ii(0x100d_d8d8, 5); calld(0x100c_f2ba, -0xe623);            /* call 0x100cf2ba */
            ii(0x100d_d8dd, 5); mov(edx, 0x18d);                        /* mov edx, 0x18d */
            ii(0x100d_d8e2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_d8e5, 6); mov(eax, memd_a32[ds, eax + 0x365]);    /* mov eax, [eax+0x365] */
            ii(0x100d_d8eb, 5); calld(0x100c_f363, -0xe58d);            /* call 0x100cf363 */
            ii(0x100d_d8f0, 5); mov(edx, 0x18d);                        /* mov edx, 0x18d */
            ii(0x100d_d8f5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_d8f8, 6); mov(eax, memd_a32[ds, eax + 0x369]);    /* mov eax, [eax+0x369] */
            ii(0x100d_d8fe, 5); calld(0x100c_f2ba, -0xe649);            /* call 0x100cf2ba */
            ii(0x100d_d903, 5); mov(edx, 0x18d);                        /* mov edx, 0x18d */
            ii(0x100d_d908, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_d90b, 6); mov(eax, memd_a32[ds, eax + 0x369]);    /* mov eax, [eax+0x369] */
            ii(0x100d_d911, 5); calld(0x100c_f363, -0xe5b3);            /* call 0x100cf363 */
            ii(0x100d_d916, 5); mov(edx, 0x18d);                        /* mov edx, 0x18d */
            ii(0x100d_d91b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_d91e, 6); mov(eax, memd_a32[ds, eax + 0x36d]);    /* mov eax, [eax+0x36d] */
            ii(0x100d_d924, 5); calld(0x100c_f2ba, -0xe66f);            /* call 0x100cf2ba */
            ii(0x100d_d929, 5); mov(edx, 0x18d);                        /* mov edx, 0x18d */
            ii(0x100d_d92e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_d931, 6); mov(eax, memd_a32[ds, eax + 0x36d]);    /* mov eax, [eax+0x36d] */
            ii(0x100d_d937, 5); calld(0x100c_f363, -0xe5d9);            /* call 0x100cf363 */
            ii(0x100d_d93c, 5); mov(edx, 0x11c);                        /* mov edx, 0x11c */
            ii(0x100d_d941, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_d944, 6); mov(eax, memd_a32[ds, eax + 0x3c3]);    /* mov eax, [eax+0x3c3] */
            ii(0x100d_d94a, 5); calld(0x100c_f2ba, -0xe695);            /* call 0x100cf2ba */
            ii(0x100d_d94f, 5); mov(edx, 0x11f);                        /* mov edx, 0x11f */
            ii(0x100d_d954, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_d957, 6); mov(eax, memd_a32[ds, eax + 0x3c7]);    /* mov eax, [eax+0x3c7] */
            ii(0x100d_d95d, 5); calld(0x100c_f2ba, -0xe6a8);            /* call 0x100cf2ba */
            ii(0x100d_d962, 5); mov(edx, 0x18b);                        /* mov edx, 0x18b */
            ii(0x100d_d967, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_d96a, 6); mov(eax, memd_a32[ds, eax + 0x3db]);    /* mov eax, [eax+0x3db] */
            ii(0x100d_d970, 5); calld(0x100c_f2ba, -0xe6bb);            /* call 0x100cf2ba */
            ii(0x100d_d975, 5); mov(edx, 0x188);                        /* mov edx, 0x188 */
            ii(0x100d_d97a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_d97d, 6); mov(eax, memd_a32[ds, eax + 0x3d7]);    /* mov eax, [eax+0x3d7] */
            ii(0x100d_d983, 5); calld(0x100c_f2ba, -0xe6ce);            /* call 0x100cf2ba */
            ii(0x100d_d988, 5); mov(edx, 0x450);                        /* mov edx, 0x450 */
            ii(0x100d_d98d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_d990, 6); mov(eax, memd_a32[ds, eax + 0x3cb]);    /* mov eax, [eax+0x3cb] */
            ii(0x100d_d996, 5); calld(0x100d_5164, -0x8837);            /* call 0x100d5164 */
            ii(0x100d_d99b, 5); mov(edx, 0x451);                        /* mov edx, 0x451 */
            ii(0x100d_d9a0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_d9a3, 6); mov(eax, memd_a32[ds, eax + 0x3cf]);    /* mov eax, [eax+0x3cf] */
            ii(0x100d_d9a9, 5); calld(0x100d_5164, -0x884a);            /* call 0x100d5164 */
            ii(0x100d_d9ae, 5); mov(edx, 0x44d);                        /* mov edx, 0x44d */
            ii(0x100d_d9b3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_d9b6, 6); mov(eax, memd_a32[ds, eax + 0x3d3]);    /* mov eax, [eax+0x3d3] */
            ii(0x100d_d9bc, 5); calld(0x100d_5164, -0x885d);            /* call 0x100d5164 */
            ii(0x100d_d9c1, 5); mov(edx, 0x44c);                        /* mov edx, 0x44c */
            ii(0x100d_d9c6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_d9c9, 6); mov(eax, memd_a32[ds, eax + 0x3d3]);    /* mov eax, [eax+0x3d3] */
            ii(0x100d_d9cf, 5); calld(0x100d_5134, -0x88a0);            /* call 0x100d5134 */
            ii(0x100d_d9d4, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100d_d9d9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_d9dc, 6); mov(eax, memd_a32[ds, eax + 0x3d3]);    /* mov eax, [eax+0x3d3] */
            ii(0x100d_d9e2, 5); calld(0x100d_5194, -0x8853);            /* call 0x100d5194 */
            ii(0x100d_d9e7, 5); mov(edx, 0x44f);                        /* mov edx, 0x44f */
            ii(0x100d_d9ec, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_d9ef, 6); mov(eax, memd_a32[ds, eax + 0x3d7]);    /* mov eax, [eax+0x3d7] */
            ii(0x100d_d9f5, 5); calld(0x100d_5134, -0x88c6);            /* call 0x100d5134 */
            ii(0x100d_d9fa, 5); mov(edx, 0x44e);                        /* mov edx, 0x44e */
            ii(0x100d_d9ff, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_da02, 6); mov(eax, memd_a32[ds, eax + 0x3db]);    /* mov eax, [eax+0x3db] */
            ii(0x100d_da08, 5); calld(0x100d_5134, -0x88d9);            /* call 0x100d5134 */
            ii(0x100d_da0d, 5); mov(edx, 0x4ff);                        /* mov edx, 0x4ff */
            ii(0x100d_da12, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_da15, 6); mov(eax, memd_a32[ds, eax + 0x3d3]);    /* mov eax, [eax+0x3d3] */
            ii(0x100d_da1b, 5); calld(0x100d_50d4, -0x894c);            /* call 0x100d50d4 */
            ii(0x100d_da20, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_da23, 3); mov(edx, memd_a32[ds, edx + 0x29]);     /* mov edx, [edx+0x29] */
            ii(0x100d_da26, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_da29, 6); mov(eax, memd_a32[ds, eax + 0x3cb]);    /* mov eax, [eax+0x3cb] */
            ii(0x100d_da2f, 5); calld(0x100c_f85c, -0xe1d8);            /* call 0x100cf85c */
            ii(0x100d_da34, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_da37, 3); mov(edx, memd_a32[ds, edx + 0x29]);     /* mov edx, [edx+0x29] */
            ii(0x100d_da3a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_da3d, 6); mov(eax, memd_a32[ds, eax + 0x3cf]);    /* mov eax, [eax+0x3cf] */
            ii(0x100d_da43, 5); calld(0x100c_f85c, -0xe1ec);            /* call 0x100cf85c */
            ii(0x100d_da48, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_da4b, 3); mov(edx, memd_a32[ds, edx + 0x29]);     /* mov edx, [edx+0x29] */
            ii(0x100d_da4e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_da51, 6); mov(eax, memd_a32[ds, eax + 0x3d3]);    /* mov eax, [eax+0x3d3] */
            ii(0x100d_da57, 5); calld(0x100c_f85c, -0xe200);            /* call 0x100cf85c */
            ii(0x100d_da5c, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_da5f, 3); mov(edx, memd_a32[ds, edx + 0x29]);     /* mov edx, [edx+0x29] */
            ii(0x100d_da62, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_da65, 6); mov(eax, memd_a32[ds, eax + 0x3d7]);    /* mov eax, [eax+0x3d7] */
            ii(0x100d_da6b, 5); calld(0x100c_f85c, -0xe214);            /* call 0x100cf85c */
            ii(0x100d_da70, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_da73, 3); mov(edx, memd_a32[ds, edx + 0x29]);     /* mov edx, [edx+0x29] */
            ii(0x100d_da76, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_da79, 6); mov(eax, memd_a32[ds, eax + 0x3db]);    /* mov eax, [eax+0x3db] */
            ii(0x100d_da7f, 5); calld(0x100c_f85c, -0xe228);            /* call 0x100cf85c */
            ii(0x100d_da84, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_da87, 6); mov(eax, memd_a32[ds, eax + 0x3df]);    /* mov eax, [eax+0x3df] */
            ii(0x100d_da8d, 6); mov(memd_a32[ss, ebp - 0x25c], eax);    /* mov [ebp-0x25c], eax */
            ii(0x100d_da93, 6); mov(edx, memd_a32[ss, ebp - 0x25c]);    /* mov edx, [ebp-0x25c] */
            ii(0x100d_da99, 3); mov(edx, memd_a32[ds, edx + 0x27]);     /* mov edx, [edx+0x27] */
            ii(0x100d_da9c, 6); mov(eax, memd_a32[ss, ebp - 0x25c]);    /* mov eax, [ebp-0x25c] */
            ii(0x100d_daa2, 3); calld_abs(memd_a32[ds, edx + 0x4]);     /* call dword [edx+0x4] */
            ii(0x100d_daa5, 5); mov(ecx, 0x6);                          /* mov ecx, 0x6 */
            ii(0x100d_daaa, 3); mov(edi, memd_a32[ss, ebp - 0x8]);      /* mov edi, [ebp-0x8] */
            ii(0x100d_daad, 3); lea(edi, edi + 0x31);                   /* lea edi, [edi+0x31] */
            ii(0x100d_dab0, 3); mov(esi, memd_a32[ss, ebp - 0x8]);      /* mov esi, [ebp-0x8] */
            ii(0x100d_dab3, 3); lea(esi, esi + 0x17);                   /* lea esi, [esi+0x17] */
            ii(0x100d_dab6, 2); rep_a32(() => movsd_a32());             /* rep movsd */
            ii(0x100d_dab8, 2); movsw_a32();                            /* movsw */
            ii(0x100d_daba, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_dabd, 7); mov(memd_a32[ds, eax + 0x31], 0xb);     /* mov dword [eax+0x31], 0xb */
            ii(0x100d_dac4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_dac7, 7); mov(memd_a32[ds, eax + 0x35], 0xd);     /* mov dword [eax+0x35], 0xd */
            ii(0x100d_dace, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_dad1, 3); mov(edx, memd_a32[ds, eax + 0x25]);     /* mov edx, [eax+0x25] */
            ii(0x100d_dad4, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_dad7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_dada, 4); imul(edx, memd_a32[ds, eax + 0x35]);    /* imul edx, [eax+0x35] */
            ii(0x100d_dade, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_dae1, 3); mov(esi, memd_a32[ds, eax + 0x2d]);     /* mov esi, [eax+0x2d] */
            ii(0x100d_dae4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_dae7, 3); add(esi, memd_a32[ds, eax + 0x31]);     /* add esi, [eax+0x31] */
            ii(0x100d_daea, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_daed, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x100d_daef, 3); mov(memd_a32[ds, eax + 0x47], esi);     /* mov [eax+0x47], esi */
            ii(0x100d_daf2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_daf5, 3); mov(eax, memd_a32[ds, eax + 0x31]);     /* mov eax, [eax+0x31] */
            ii(0x100d_daf8, 5); add(eax, 0x118);                        /* add eax, 0x118 */
            ii(0x100d_dafd, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_db00, 3); mov(memd_a32[ds, edx + 0x39], eax);     /* mov [edx+0x39], eax */
            ii(0x100d_db03, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_db06, 3); mov(eax, memd_a32[ds, eax + 0x35]);     /* mov eax, [eax+0x35] */
            ii(0x100d_db09, 5); add(eax, 0xf0);                         /* add eax, 0xf0 */
            ii(0x100d_db0e, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_db11, 3); mov(memd_a32[ds, edx + 0x3d], eax);     /* mov [edx+0x3d], eax */
            ii(0x100d_db14, 7); mov(memd_a32[ss, ebp - 0x40], 0x31);    /* mov dword [ebp-0x40], 0x31 */
            ii(0x100d_db1b, 3); lea(edx, ebp - 0x40);                   /* lea edx, [ebp-0x40] */
            ii(0x100d_db1e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_db21, 5); add(eax, 0x3af);                        /* add eax, 0x3af */
            ii(0x100d_db26, 5); calld(0x1008_b2a8, -0x52883);           /* call 0x1008b2a8 */
            ii(0x100d_db2b, 7); mov(memd_a32[ss, ebp - 0x3c], 0x3d);    /* mov dword [ebp-0x3c], 0x3d */
            ii(0x100d_db32, 3); lea(edx, ebp - 0x3c);                   /* lea edx, [ebp-0x3c] */
            ii(0x100d_db35, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_db38, 5); add(eax, 0x3af);                        /* add eax, 0x3af */
            ii(0x100d_db3d, 5); calld(0x1008_b2a8, -0x5289a);           /* call 0x1008b2a8 */
            ii(0x100d_db42, 7); mov(memd_a32[ss, ebp - 0x38], 0x39);    /* mov dword [ebp-0x38], 0x39 */
            ii(0x100d_db49, 3); lea(edx, ebp - 0x38);                   /* lea edx, [ebp-0x38] */
            ii(0x100d_db4c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_db4f, 5); add(eax, 0x3af);                        /* add eax, 0x3af */
            ii(0x100d_db54, 5); calld(0x1008_b2a8, -0x528b1);           /* call 0x1008b2a8 */
            ii(0x100d_db59, 7); mov(memd_a32[ss, ebp - 0x18], 0x32);    /* mov dword [ebp-0x18], 0x32 */
            ii(0x100d_db60, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x100d_db63, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_db66, 5); add(eax, 0x3af);                        /* add eax, 0x3af */
            ii(0x100d_db6b, 5); calld(0x1008_b2a8, -0x528c8);           /* call 0x1008b2a8 */
            ii(0x100d_db70, 7); mov(memd_a32[ss, ebp - 0x14], 0x3a);    /* mov dword [ebp-0x14], 0x3a */
            ii(0x100d_db77, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x100d_db7a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_db7d, 5); add(eax, 0x3af);                        /* add eax, 0x3af */
            ii(0x100d_db82, 5); calld(0x1008_b2a8, -0x528df);           /* call 0x1008b2a8 */
            ii(0x100d_db87, 7); mov(memd_a32[ss, ebp - 0x34], 0x33);    /* mov dword [ebp-0x34], 0x33 */
            ii(0x100d_db8e, 3); lea(edx, ebp - 0x34);                   /* lea edx, [ebp-0x34] */
            ii(0x100d_db91, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_db94, 5); add(eax, 0x3af);                        /* add eax, 0x3af */
            ii(0x100d_db99, 5); calld(0x1008_b2a8, -0x528f6);           /* call 0x1008b2a8 */
            ii(0x100d_db9e, 7); mov(memd_a32[ss, ebp - 0x10], 0x34);    /* mov dword [ebp-0x10], 0x34 */
            ii(0x100d_dba5, 3); lea(edx, ebp - 0x10);                   /* lea edx, [ebp-0x10] */
            ii(0x100d_dba8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_dbab, 5); add(eax, 0x3af);                        /* add eax, 0x3af */
            ii(0x100d_dbb0, 5); calld(0x1008_b2a8, -0x5290d);           /* call 0x1008b2a8 */
            ii(0x100d_dbb5, 7); mov(memd_a32[ss, ebp - 0x48], 0x35);    /* mov dword [ebp-0x48], 0x35 */
            ii(0x100d_dbbc, 3); lea(edx, ebp - 0x48);                   /* lea edx, [ebp-0x48] */
            ii(0x100d_dbbf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_dbc2, 5); add(eax, 0x3af);                        /* add eax, 0x3af */
            ii(0x100d_dbc7, 5); calld(0x1008_b2a8, -0x52924);           /* call 0x1008b2a8 */
            ii(0x100d_dbcc, 7); mov(memd_a32[ss, ebp - 0x30], 0x36);    /* mov dword [ebp-0x30], 0x36 */
            ii(0x100d_dbd3, 3); lea(edx, ebp - 0x30);                   /* lea edx, [ebp-0x30] */
            ii(0x100d_dbd6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_dbd9, 5); add(eax, 0x3af);                        /* add eax, 0x3af */
            ii(0x100d_dbde, 5); calld(0x1008_b2a8, -0x5293b);           /* call 0x1008b2a8 */
            ii(0x100d_dbe3, 7); mov(memd_a32[ss, ebp - 0x2c], 0x38);    /* mov dword [ebp-0x2c], 0x38 */
            ii(0x100d_dbea, 3); lea(edx, ebp - 0x2c);                   /* lea edx, [ebp-0x2c] */
            ii(0x100d_dbed, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_dbf0, 5); add(eax, 0x3af);                        /* add eax, 0x3af */
            ii(0x100d_dbf5, 5); calld(0x1008_b2a8, -0x52952);           /* call 0x1008b2a8 */
            ii(0x100d_dbfa, 7); mov(memd_a32[ss, ebp - 0x28], 0x3f);    /* mov dword [ebp-0x28], 0x3f */
            ii(0x100d_dc01, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x100d_dc04, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_dc07, 5); add(eax, 0x3af);                        /* add eax, 0x3af */
            ii(0x100d_dc0c, 5); calld(0x1008_b2a8, -0x52969);           /* call 0x1008b2a8 */
            ii(0x100d_dc11, 7); mov(memd_a32[ss, ebp - 0x44], 0x3b);    /* mov dword [ebp-0x44], 0x3b */
            ii(0x100d_dc18, 3); lea(edx, ebp - 0x44);                   /* lea edx, [ebp-0x44] */
            ii(0x100d_dc1b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_dc1e, 5); add(eax, 0x3af);                        /* add eax, 0x3af */
            ii(0x100d_dc23, 5); calld(0x1008_b2a8, -0x52980);           /* call 0x1008b2a8 */
            ii(0x100d_dc28, 7); mov(memd_a32[ss, ebp - 0x24], 0x40);    /* mov dword [ebp-0x24], 0x40 */
            ii(0x100d_dc2f, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x100d_dc32, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_dc35, 5); add(eax, 0x3af);                        /* add eax, 0x3af */
            ii(0x100d_dc3a, 5); calld(0x1008_b2a8, -0x52997);           /* call 0x1008b2a8 */
            ii(0x100d_dc3f, 7); mov(memd_a32[ss, ebp - 0x20], 0x37);    /* mov dword [ebp-0x20], 0x37 */
            ii(0x100d_dc46, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x100d_dc49, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_dc4c, 5); add(eax, 0x3af);                        /* add eax, 0x3af */
            ii(0x100d_dc51, 5); calld(0x1008_b2a8, -0x529ae);           /* call 0x1008b2a8 */
            ii(0x100d_dc56, 7); mov(memd_a32[ss, ebp - 0x1c], 0x3c);    /* mov dword [ebp-0x1c], 0x3c */
            ii(0x100d_dc5d, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x100d_dc60, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_dc63, 5); add(eax, 0x3af);                        /* add eax, 0x3af */
            ii(0x100d_dc68, 5); calld(0x1008_b2a8, -0x529c5);           /* call 0x1008b2a8 */
            ii(0x100d_dc6d, 5); mov(ecx, 0x6);                          /* mov ecx, 0x6 */
            ii(0x100d_dc72, 6); lea(edi, ebp - 0x278);                  /* lea edi, [ebp-0x278] */
            ii(0x100d_dc78, 3); mov(esi, memd_a32[ss, ebp - 0x8]);      /* mov esi, [ebp-0x8] */
            ii(0x100d_dc7b, 3); lea(esi, esi + 0x17);                   /* lea esi, [esi+0x17] */
            ii(0x100d_dc7e, 2); rep_a32(() => movsd_a32());             /* rep movsd */
            ii(0x100d_dc80, 2); movsw_a32();                            /* movsw */
            ii(0x100d_dc82, 10); mov(memd_a32[ss, ebp - 0x278], 0x1e2); /* mov dword [ebp-0x278], 0x1e2 */
            ii(0x100d_dc8c, 10); mov(memd_a32[ss, ebp - 0x274], 0x50);  /* mov dword [ebp-0x274], 0x50 */
            ii(0x100d_dc96, 10); mov(memd_a32[ss, ebp - 0x270], 0x25d); /* mov dword [ebp-0x270], 0x25d */
            ii(0x100d_dca0, 10); mov(memd_a32[ss, ebp - 0x26c], 0x172); /* mov dword [ebp-0x26c], 0x172 */
            ii(0x100d_dcaa, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_dcad, 3); mov(eax, memd_a32[ds, eax + 0x25]);     /* mov eax, [eax+0x25] */
            ii(0x100d_dcb0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_dcb3, 7); imul(eax, memd_a32[ss, ebp - 0x274]);   /* imul eax, [ebp-0x274] */
            ii(0x100d_dcba, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_dcbd, 3); mov(edx, memd_a32[ds, edx + 0x2d]);     /* mov edx, [edx+0x2d] */
            ii(0x100d_dcc0, 6); add(edx, memd_a32[ss, ebp - 0x278]);    /* add edx, [ebp-0x278] */
            ii(0x100d_dcc6, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100d_dcc8, 6); mov(memd_a32[ss, ebp - 0x262], edx);    /* mov [ebp-0x262], edx */
            ii(0x100d_dcce, 5); calld(0x100d_531c, -0x89b7);            /* call 0x100d531c */
            ii(0x100d_dcd3, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100d_dcd8, 1); pushd(eax);                             /* push eax */
            ii(0x100d_dcd9, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_dcdb, 1); pushd(eax);                             /* push eax */
            ii(0x100d_dcdc, 5); pushd(0xa2);                            /* push 0xa2 */
            ii(0x100d_dce1, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x100d_dce6, 1); pushd(eax);                             /* push eax */
            ii(0x100d_dce7, 5); mov(eax, 0x8f);                         /* mov eax, 0x8f */
            ii(0x100d_dcec, 1); pushd(eax);                             /* push eax */
            ii(0x100d_dced, 5); mov(eax, 0x39);                         /* mov eax, 0x39 */
            ii(0x100d_dcf2, 1); pushd(eax);                             /* push eax */
            ii(0x100d_dcf3, 5); mov(ecx, 0x1e2);                        /* mov ecx, 0x1e2 */
            ii(0x100d_dcf8, 5); mov(ebx, 0x101a_1a65);                  /* mov ebx, 0x101a1a65 */ /* "Available" */
            ii(0x100d_dcfd, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_dd00, 3); mov(edx, memd_a32[ds, edx + 0x25]);     /* mov edx, [edx+0x25] */
            ii(0x100d_dd03, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_dd06, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_dd09, 3); mov(eax, memd_a32[ds, eax + 0x2d]);     /* mov eax, [eax+0x2d] */
            ii(0x100d_dd0c, 5); calld(0x100e_9ae5, 0xbdd4);             /* call 0x100e9ae5 */
            ii(0x100d_dd11, 5); calld(0x100d_531c, -0x89fa);            /* call 0x100d531c */
            ii(0x100d_dd16, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100d_dd1b, 1); pushd(eax);                             /* push eax */
            ii(0x100d_dd1c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_dd1e, 1); pushd(eax);                             /* push eax */
            ii(0x100d_dd1f, 2); pushd(0x4);                             /* push 0x4 */
            ii(0x100d_dd21, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x100d_dd26, 1); pushd(eax);                             /* push eax */
            ii(0x100d_dd27, 5); mov(eax, 0x101a_1a6f);                  /* mov eax, 0x101a1a6f */ /* "Cost" */
            ii(0x100d_dd2c, 6); calld_abs(memd_a32[ds, 0x101b_ddf4]);   /* call dword [0x101bddf4] */
            ii(0x100d_dd32, 1); cwde();                                 /* cwde */
            ii(0x100d_dd33, 1); pushd(eax);                             /* push eax */
            ii(0x100d_dd34, 5); mov(eax, 0x39);                         /* mov eax, 0x39 */
            ii(0x100d_dd39, 1); pushd(eax);                             /* push eax */
            ii(0x100d_dd3a, 5); mov(eax, 0x101a_1a74);                  /* mov eax, 0x101a1a74 */ /* "Cost" */
            ii(0x100d_dd3f, 6); calld_abs(memd_a32[ds, 0x101b_ddf4]);   /* call dword [0x101bddf4] */
            ii(0x100d_dd45, 5); mov(edx, 0x271);                        /* mov edx, 0x271 */
            ii(0x100d_dd4a, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100d_dd4c, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100d_dd4e, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100d_dd51, 5); mov(ebx, 0x101a_1a79);                  /* mov ebx, 0x101a1a79 */ /* "Cost" */
            ii(0x100d_dd56, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_dd59, 3); mov(edx, memd_a32[ds, eax + 0x25]);     /* mov edx, [eax+0x25] */
            ii(0x100d_dd5c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_dd5f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_dd62, 3); mov(eax, memd_a32[ds, eax + 0x2d]);     /* mov eax, [eax+0x2d] */
            ii(0x100d_dd65, 5); calld(0x100e_9ae5, 0xbd7b);             /* call 0x100e9ae5 */
            ii(0x100d_dd6a, 2); pushd(0x5);                             /* push 0x5 */
            ii(0x100d_dd6c, 2); pushd(0x45);                            /* push 0x45 */
            ii(0x100d_dd6e, 5); pushd(0x271);                           /* push 0x271 */
            ii(0x100d_dd73, 5); mov(ecx, 0x45);                         /* mov ecx, 0x45 */
            ii(0x100d_dd78, 5); mov(ebx, 0x1e2);                        /* mov ebx, 0x1e2 */
            ii(0x100d_dd7d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_dd80, 3); mov(edx, memd_a32[ds, eax + 0x25]);     /* mov edx, [eax+0x25] */
            ii(0x100d_dd83, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_dd86, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_dd89, 3); mov(eax, memd_a32[ds, eax + 0x2d]);     /* mov eax, [eax+0x2d] */
            ii(0x100d_dd8c, 5); calld(/* sys */ 0x1016_a5a0, 0x8c80f);  /* call 0x1016a5a0 */
            ii(0x100d_dd91, 5); mov(ecx, 0x6);                          /* mov ecx, 0x6 */
            ii(0x100d_dd96, 6); lea(edi, ebp - 0x294);                  /* lea edi, [ebp-0x294] */
            ii(0x100d_dd9c, 3); mov(esi, memd_a32[ss, ebp - 0x8]);      /* mov esi, [ebp-0x8] */
            ii(0x100d_dd9f, 3); lea(esi, esi + 0x17);                   /* lea esi, [esi+0x17] */
            ii(0x100d_dda2, 2); rep_a32(() => movsd_a32());             /* rep movsd */
            ii(0x100d_dda4, 2); movsw_a32();                            /* movsw */
            ii(0x100d_dda6, 10); mov(memd_a32[ss, ebp - 0x294], 0x151); /* mov dword [ebp-0x294], 0x151 */
            ii(0x100d_ddb0, 10); mov(memd_a32[ss, ebp - 0x290], 0x2d);  /* mov dword [ebp-0x290], 0x2d */
            ii(0x100d_ddba, 10); mov(memd_a32[ss, ebp - 0x28c], 0x1c7); /* mov dword [ebp-0x28c], 0x1c7 */
            ii(0x100d_ddc4, 10); mov(memd_a32[ss, ebp - 0x288], 0xe6);  /* mov dword [ebp-0x288], 0xe6 */
            ii(0x100d_ddce, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_ddd1, 3); mov(eax, memd_a32[ds, eax + 0x25]);     /* mov eax, [eax+0x25] */
            ii(0x100d_ddd4, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_ddd7, 7); imul(eax, memd_a32[ss, ebp - 0x290]);   /* imul eax, [ebp-0x290] */
            ii(0x100d_ddde, 6); mov(edx, memd_a32[ss, ebp - 0x27e]);    /* mov edx, [ebp-0x27e] */
            ii(0x100d_dde4, 6); add(edx, memd_a32[ss, ebp - 0x294]);    /* add edx, [ebp-0x294] */
            ii(0x100d_ddea, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100d_ddec, 6); mov(memd_a32[ss, ebp - 0x27e], edx);    /* mov [ebp-0x27e], edx */
            ii(0x100d_ddf2, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x100d_ddf7, 5); calld(Definitions.sys_new, 0x88004);    /* call 0x10165e00 */
            ii(0x100d_ddfc, 6); mov(memd_a32[ss, ebp - 0x298], eax);    /* mov [ebp-0x298], eax */
            ii(0x100d_de02, 6); mov(eax, memd_a32[ss, ebp - 0x298]);    /* mov eax, [ebp-0x298] */
            ii(0x100d_de08, 6); mov(memd_a32[ss, ebp - 0x29c], eax);    /* mov [ebp-0x29c], eax */
            ii(0x100d_de0e, 7); cmp(memd_a32[ss, ebp - 0x29c], 0);      /* cmp dword [ebp-0x29c], 0x0 */
            ii(0x100d_de15, 2); if(jzd(0x100d_de6e, 0x57)) goto l_0x100d_de6e; /* jz 0x100dde6e */
            ii(0x100d_de17, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_de1a, 6); pushd(memd_a32[ds, eax + 0x3c7]);       /* push dword [eax+0x3c7] */
            ii(0x100d_de20, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_de23, 6); pushd(memd_a32[ds, eax + 0x3c3]);       /* push dword [eax+0x3c3] */
            ii(0x100d_de29, 5); mov(eax, 0xbb8);                        /* mov eax, 0xbb8 */
            ii(0x100d_de2e, 1); pushd(eax);                             /* push eax */
            ii(0x100d_de2f, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100d_de33, 1); pushd(eax);                             /* push eax */
            ii(0x100d_de34, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_de37, 5); add(eax, 0x3b7);                        /* add eax, 0x3b7 */
            ii(0x100d_de3c, 1); pushd(eax);                             /* push eax */
            ii(0x100d_de3d, 3); mov(ecx, memd_a32[ss, ebp - 0x8]);      /* mov ecx, [ebp-0x8] */
            ii(0x100d_de40, 6); add(ecx, 0x3b3);                        /* add ecx, 0x3b3 */
            ii(0x100d_de46, 6); lea(ebx, ebp - 0x294);                  /* lea ebx, [ebp-0x294] */
            ii(0x100d_de4c, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_de4f, 6); mov(eax, memd_a32[ss, ebp - 0x298]);    /* mov eax, [ebp-0x298] */
            ii(0x100d_de55, 5); calld(0x100d_be05, -0x2055);            /* call 0x100dbe05 */
            ii(0x100d_de5a, 6); mov(memd_a32[ss, ebp - 0x2a0], eax);    /* mov [ebp-0x2a0], eax */
            ii(0x100d_de60, 6); mov(eax, memd_a32[ss, ebp - 0x2a0]);    /* mov eax, [ebp-0x2a0] */
            ii(0x100d_de66, 6); mov(memd_a32[ss, ebp - 0x2a4], eax);    /* mov [ebp-0x2a4], eax */
            ii(0x100d_de6c, 2); jmpd(0x100d_de7a, 0xc); goto l_0x100d_de7a; /* jmp 0x100dde7a */
        l_0x100d_de6e:
            ii(0x100d_de6e, 6); mov(eax, memd_a32[ss, ebp - 0x29c]);    /* mov eax, [ebp-0x29c] */
            ii(0x100d_de74, 6); mov(memd_a32[ss, ebp - 0x2a4], eax);    /* mov [ebp-0x2a4], eax */
        l_0x100d_de7a:
            ii(0x100d_de7a, 6); mov(eax, memd_a32[ss, ebp - 0x2a4]);    /* mov eax, [ebp-0x2a4] */
            ii(0x100d_de80, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_de83, 6); mov(memd_a32[ds, edx + 0x3bb], eax);    /* mov [edx+0x3bb], eax */
            ii(0x100d_de89, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x100d_de8e, 5); calld(/* sys */ 0x1016_a24c, 0x8c3b9);  /* call 0x1016a24c */
            ii(0x100d_de93, 5); calld(0x100d_531c, -0x8b7c);            /* call 0x100d531c */
            ii(0x100d_de98, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100d_de9d, 1); pushd(eax);                             /* push eax */
            ii(0x100d_de9e, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100d_dea3, 1); pushd(eax);                             /* push eax */
            ii(0x100d_dea4, 5); pushd(0xa2);                            /* push 0xa2 */
            ii(0x100d_dea9, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x100d_deae, 1); pushd(eax);                             /* push eax */
            ii(0x100d_deaf, 5); mov(eax, 0x76);                         /* mov eax, 0x76 */
            ii(0x100d_deb4, 1); pushd(eax);                             /* push eax */
            ii(0x100d_deb5, 5); mov(eax, 0x16);                         /* mov eax, 0x16 */
            ii(0x100d_deba, 1); pushd(eax);                             /* push eax */
            ii(0x100d_debb, 5); mov(ecx, 0x151);                        /* mov ecx, 0x151 */
            ii(0x100d_dec0, 5); mov(ebx, 0x101a_1a7e);                  /* mov ebx, 0x101a1a7e */ /* "Purchased" */
            ii(0x100d_dec5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_dec8, 3); mov(edx, memd_a32[ds, eax + 0x25]);     /* mov edx, [eax+0x25] */
            ii(0x100d_decb, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_dece, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_ded1, 3); mov(eax, memd_a32[ds, eax + 0x2d]);     /* mov eax, [eax+0x2d] */
            ii(0x100d_ded4, 5); calld(0x100e_9ae5, 0xbc0c);             /* call 0x100e9ae5 */
            ii(0x100d_ded9, 2); pushd(0x5);                             /* push 0x5 */
            ii(0x100d_dedb, 2); pushd(0x22);                            /* push 0x22 */
            ii(0x100d_dedd, 5); pushd(0x1c7);                           /* push 0x1c7 */
            ii(0x100d_dee2, 5); mov(ecx, 0x22);                         /* mov ecx, 0x22 */
            ii(0x100d_dee7, 5); mov(ebx, 0x151);                        /* mov ebx, 0x151 */
            ii(0x100d_deec, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_deef, 3); mov(edx, memd_a32[ds, edx + 0x25]);     /* mov edx, [edx+0x25] */
            ii(0x100d_def2, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_def5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_def8, 3); mov(eax, memd_a32[ds, eax + 0x2d]);     /* mov eax, [eax+0x2d] */
            ii(0x100d_defb, 5); calld(/* sys */ 0x1016_a5a0, 0x8c6a0);  /* call 0x1016a5a0 */
            ii(0x100d_df00, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x100d_df05, 5); calld(/* sys */ 0x1016_a24c, 0x8c342);  /* call 0x1016a24c */
            ii(0x100d_df0a, 5); calld(0x100d_531c, -0x8bf3);            /* call 0x100d531c */
            ii(0x100d_df0f, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100d_df14, 1); pushd(eax);                             /* push eax */
            ii(0x100d_df15, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100d_df1a, 1); pushd(eax);                             /* push eax */
            ii(0x100d_df1b, 2); pushd(0x2);                             /* push 0x2 */
            ii(0x100d_df1d, 5); mov(eax, 0x12);                         /* mov eax, 0x12 */
            ii(0x100d_df22, 1); pushd(eax);                             /* push eax */
            ii(0x100d_df23, 5); mov(eax, 0x9e);                         /* mov eax, 0x9e */
            ii(0x100d_df28, 1); pushd(eax);                             /* push eax */
            ii(0x100d_df29, 5); mov(eax, 0x7);                          /* mov eax, 0x7 */
            ii(0x100d_df2e, 1); pushd(eax);                             /* push eax */
            ii(0x100d_df2f, 5); mov(ecx, 0x1d9);                        /* mov ecx, 0x1d9 */
            ii(0x100d_df34, 5); mov(ebx, 0x101a_1a88);                  /* mov ebx, 0x101a1a88 */ /* "Purchase Menu" */
            ii(0x100d_df39, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_df3c, 3); mov(edx, memd_a32[ds, edx + 0x25]);     /* mov edx, [edx+0x25] */
            ii(0x100d_df3f, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_df42, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_df45, 3); mov(eax, memd_a32[ds, eax + 0x2d]);     /* mov eax, [eax+0x2d] */
            ii(0x100d_df48, 5); calld(0x100e_9ae5, 0xbb98);             /* call 0x100e9ae5 */
            ii(0x100d_df4d, 5); mov(edx, 0x101c_3678);                  /* mov edx, 0x101c3678 */
            ii(0x100d_df52, 6); lea(eax, ebp - 0x2a8);                  /* lea eax, [ebp-0x2a8] */
            ii(0x100d_df58, 5); calld(0x100d_4d78, -0x91e5);            /* call 0x100d4d78 */
            ii(0x100d_df5d, 1); pushd(eax);                             /* push eax */
            ii(0x100d_df5e, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100d_df63, 1); pushd(eax);                             /* push eax */
            ii(0x100d_df64, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100d_df69, 1); pushd(eax);                             /* push eax */
            ii(0x100d_df6a, 5); mov(eax, 0x11);                         /* mov eax, 0x11 */
            ii(0x100d_df6f, 1); pushd(eax);                             /* push eax */
            ii(0x100d_df70, 5); mov(eax, 0x50);                         /* mov eax, 0x50 */
            ii(0x100d_df75, 1); pushd(eax);                             /* push eax */
            ii(0x100d_df76, 5); mov(ecx, 0x108);                        /* mov ecx, 0x108 */
            ii(0x100d_df7b, 5); mov(ebx, 0xd1);                         /* mov ebx, 0xd1 */
            ii(0x100d_df80, 5); mov(edx, 0x101a_1a96);                  /* mov edx, 0x101a1a96 */ /* "Description" */
            ii(0x100d_df85, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_df88, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100d_df8b, 5); calld(0x100e_ab9d, 0xcc0d);             /* call 0x100eab9d */
            ii(0x100d_df90, 5); mov(edx, 0x101c_3678);                  /* mov edx, 0x101c3678 */
            ii(0x100d_df95, 6); lea(eax, ebp - 0x2ac);                  /* lea eax, [ebp-0x2ac] */
            ii(0x100d_df9b, 5); calld(0x100d_4d78, -0x9228);            /* call 0x100d4d78 */
            ii(0x100d_dfa0, 1); pushd(eax);                             /* push eax */
            ii(0x100d_dfa1, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100d_dfa6, 1); pushd(eax);                             /* push eax */
            ii(0x100d_dfa7, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100d_dfac, 1); pushd(eax);                             /* push eax */
            ii(0x100d_dfad, 5); mov(eax, 0x10);                         /* mov eax, 0x10 */
            ii(0x100d_dfb2, 1); pushd(eax);                             /* push eax */
            ii(0x100d_dfb3, 5); mov(eax, 0x30);                         /* mov eax, 0x30 */
            ii(0x100d_dfb8, 1); pushd(eax);                             /* push eax */
            ii(0x100d_dfb9, 5); mov(ecx, 0x11b);                        /* mov ecx, 0x11b */
            ii(0x100d_dfbe, 5); mov(ebx, 0x140);                        /* mov ebx, 0x140 */
            ii(0x100d_dfc3, 5); mov(edx, 0x101a_1aa2);                  /* mov edx, 0x101a1aa2 */ /* "Cost" */
            ii(0x100d_dfc8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_dfcb, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100d_dfce, 5); calld(0x100e_ab9d, 0xcbca);             /* call 0x100eab9d */
            ii(0x100d_dfd3, 5); mov(edx, 0x101c_3678);                  /* mov edx, 0x101c3678 */
            ii(0x100d_dfd8, 6); lea(eax, ebp - 0x2b0);                  /* lea eax, [ebp-0x2b0] */
            ii(0x100d_dfde, 5); calld(0x100d_4d78, -0x926b);            /* call 0x100d4d78 */
            ii(0x100d_dfe3, 1); pushd(eax);                             /* push eax */
            ii(0x100d_dfe4, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100d_dfe9, 1); pushd(eax);                             /* push eax */
            ii(0x100d_dfea, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100d_dfef, 1); pushd(eax);                             /* push eax */
            ii(0x100d_dff0, 5); mov(eax, 0x10);                         /* mov eax, 0x10 */
            ii(0x100d_dff5, 1); pushd(eax);                             /* push eax */
            ii(0x100d_dff6, 5); mov(eax, 0x30);                         /* mov eax, 0x30 */
            ii(0x100d_dffb, 1); pushd(eax);                             /* push eax */
            ii(0x100d_dffc, 5); mov(ecx, 0x11b);                        /* mov ecx, 0x11b */
            ii(0x100d_e001, 5); mov(ebx, 0x166);                        /* mov ebx, 0x166 */
            ii(0x100d_e006, 5); mov(edx, 0x101a_1aa7);                  /* mov edx, 0x101a1aa7 */ /* "Credit" */
            ii(0x100d_e00b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e00e, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100d_e011, 5); calld(0x100e_ab9d, 0xcb87);             /* call 0x100eab9d */
            ii(0x100d_e016, 5); mov(edx, 0x101c_3678);                  /* mov edx, 0x101c3678 */
            ii(0x100d_e01b, 6); lea(eax, ebp - 0x2b4);                  /* lea eax, [ebp-0x2b4] */
            ii(0x100d_e021, 5); calld(0x100d_4d78, -0x92ae);            /* call 0x100d4d78 */
            ii(0x100d_e026, 1); pushd(eax);                             /* push eax */
            ii(0x100d_e027, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100d_e02c, 1); pushd(eax);                             /* push eax */
            ii(0x100d_e02d, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100d_e032, 1); pushd(eax);                             /* push eax */
            ii(0x100d_e033, 5); mov(eax, 0x10);                         /* mov eax, 0x10 */
            ii(0x100d_e038, 1); pushd(eax);                             /* push eax */
            ii(0x100d_e039, 5); mov(eax, 0x30);                         /* mov eax, 0x30 */
            ii(0x100d_e03e, 1); pushd(eax);                             /* push eax */
            ii(0x100d_e03f, 5); mov(ecx, 0x11b);                        /* mov ecx, 0x11b */
            ii(0x100d_e044, 5); mov(ebx, 0x199);                        /* mov ebx, 0x199 */
            ii(0x100d_e049, 5); mov(edx, 0x101a_1aae);                  /* mov edx, 0x101a1aae */ /* "Cargo" */
            ii(0x100d_e04e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e051, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100d_e054, 5); calld(0x100e_ab9d, 0xcb44);             /* call 0x100eab9d */
            ii(0x100d_e059, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e05c, 5); calld(0x100d_9269, -0x4df8);            /* call 0x100d9269 */
            ii(0x100d_e061, 5); mov(eax, 0x48);                         /* mov eax, 0x48 */
            ii(0x100d_e066, 5); calld(Definitions.sys_new, 0x87d95);    /* call 0x10165e00 */
            ii(0x100d_e06b, 6); mov(memd_a32[ss, ebp - 0x2b8], eax);    /* mov [ebp-0x2b8], eax */
            ii(0x100d_e071, 6); mov(eax, memd_a32[ss, ebp - 0x2b8]);    /* mov eax, [ebp-0x2b8] */
            ii(0x100d_e077, 6); mov(memd_a32[ss, ebp - 0x2bc], eax);    /* mov [ebp-0x2bc], eax */
            ii(0x100d_e07d, 7); cmp(memd_a32[ss, ebp - 0x2bc], 0);      /* cmp dword [ebp-0x2bc], 0x0 */
            ii(0x100d_e084, 2); if(jzd(0x100d_e0f1, 0x6b)) goto l_0x100d_e0f1; /* jz 0x100de0f1 */
            ii(0x100d_e086, 5); mov(eax, 0xf);                          /* mov eax, 0xf */
            ii(0x100d_e08b, 1); pushd(eax);                             /* push eax */
            ii(0x100d_e08c, 5); mov(eax, 0x80);                         /* mov eax, 0x80 */
            ii(0x100d_e091, 1); pushd(eax);                             /* push eax */
            ii(0x100d_e092, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e095, 6); pushd(memd_a32[ds, eax + 0x34d]);       /* push dword [eax+0x34d] */
            ii(0x100d_e09b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e09e, 6); pushd(memd_a32[ds, eax + 0x349]);       /* push dword [eax+0x349] */
            ii(0x100d_e0a4, 5); mov(eax, 0x7d0);                        /* mov eax, 0x7d0 */
            ii(0x100d_e0a9, 1); pushd(eax);                             /* push eax */
            ii(0x100d_e0aa, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e0ad, 3); mov(eax, memd_a32[ds, eax + 0x49]);     /* mov eax, [eax+0x49] */
            ii(0x100d_e0b0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_e0b3, 1); pushd(eax);                             /* push eax */
            ii(0x100d_e0b4, 5); calld(0x1008_b3ec, -0x52ccd);           /* call 0x1008b3ec */
            ii(0x100d_e0b9, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_e0bc, 6); lea(eax, ebp - 0x2c0);                  /* lea eax, [ebp-0x2c0] */
            ii(0x100d_e0c2, 5); calld(0x1008_b1e4, -0x52ee3);           /* call 0x1008b1e4 */
            ii(0x100d_e0c7, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100d_e0c9, 6); lea(ebx, ebp - 0x278);                  /* lea ebx, [ebp-0x278] */
            ii(0x100d_e0cf, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_e0d2, 6); mov(eax, memd_a32[ss, ebp - 0x2b8]);    /* mov eax, [ebp-0x2b8] */
            ii(0x100d_e0d8, 5); calld(0x100d_c680, -0x1a5d);            /* call 0x100dc680 */
            ii(0x100d_e0dd, 6); mov(memd_a32[ss, ebp - 0x2c4], eax);    /* mov [ebp-0x2c4], eax */
            ii(0x100d_e0e3, 6); mov(eax, memd_a32[ss, ebp - 0x2c4]);    /* mov eax, [ebp-0x2c4] */
            ii(0x100d_e0e9, 6); mov(memd_a32[ss, ebp - 0x2c8], eax);    /* mov [ebp-0x2c8], eax */
            ii(0x100d_e0ef, 2); jmpd(0x100d_e0fd, 0xc); goto l_0x100d_e0fd; /* jmp 0x100de0fd */
        l_0x100d_e0f1:
            ii(0x100d_e0f1, 6); mov(eax, memd_a32[ss, ebp - 0x2bc]);    /* mov eax, [ebp-0x2bc] */
            ii(0x100d_e0f7, 6); mov(memd_a32[ss, ebp - 0x2c8], eax);    /* mov [ebp-0x2c8], eax */
        l_0x100d_e0fd:
            ii(0x100d_e0fd, 6); mov(eax, memd_a32[ss, ebp - 0x2c8]);    /* mov eax, [ebp-0x2c8] */
            ii(0x100d_e103, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_e106, 6); mov(memd_a32[ds, edx + 0x345], eax);    /* mov [edx+0x345], eax */
            ii(0x100d_e10c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_e10e, 6); lea(eax, ebp - 0x2c0);                  /* lea eax, [ebp-0x2c0] */
            ii(0x100d_e114, 5); calld(0x1008_8b04, -0x55615);           /* call 0x10088b04 */
            ii(0x100d_e119, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e11c, 6); mov(edx, memd_a32[ds, eax + 0x345]);    /* mov edx, [eax+0x345] */
            ii(0x100d_e122, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e125, 6); mov(memd_a32[ds, eax + 0x3bf], edx);    /* mov [eax+0x3bf], edx */
            ii(0x100d_e12b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e12e, 6); mov(memd_a32[ss, ebp - 0x2cc], eax);    /* mov [ebp-0x2cc], eax */
            ii(0x100d_e134, 6); mov(eax, memd_a32[ss, ebp - 0x2cc]);    /* mov eax, [ebp-0x2cc] */
            ii(0x100d_e13a, 3); mov(edx, memd_a32[ds, eax + 0x13]);     /* mov edx, [eax+0x13] */
            ii(0x100d_e13d, 6); mov(eax, memd_a32[ss, ebp - 0x2cc]);    /* mov eax, [ebp-0x2cc] */
            ii(0x100d_e143, 3); calld_abs(memd_a32[ds, edx + 0x14]);    /* call dword [edx+0x14] */
            ii(0x100d_e146, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e149, 6); mov(eax, memd_a32[ds, eax + 0x3bb]);    /* mov eax, [eax+0x3bb] */
            ii(0x100d_e14f, 6); mov(memd_a32[ss, ebp - 0x2d0], eax);    /* mov [ebp-0x2d0], eax */
            ii(0x100d_e155, 6); mov(eax, memd_a32[ss, ebp - 0x2d0]);    /* mov eax, [ebp-0x2d0] */
            ii(0x100d_e15b, 3); mov(edx, memd_a32[ds, eax + 0x40]);     /* mov edx, [eax+0x40] */
            ii(0x100d_e15e, 6); mov(eax, memd_a32[ss, ebp - 0x2d0]);    /* mov eax, [ebp-0x2d0] */
            ii(0x100d_e164, 3); calld_abs(memd_a32[ds, edx + 0x10]);    /* call dword [edx+0x10] */
            ii(0x100d_e167, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_e169, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e16c, 5); calld(0x100d_e7d6, 0x665);              /* call 0x100de7d6 */
            ii(0x100d_e171, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e174, 6); mov(memd_a32[ss, ebp - 0x2d4], eax);    /* mov [ebp-0x2d4], eax */
            ii(0x100d_e17a, 6); mov(eax, memd_a32[ss, ebp - 0x2d4]);    /* mov eax, [ebp-0x2d4] */
            ii(0x100d_e180, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_e182, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_e183, 1); popd(edi);                              /* pop edi */
            ii(0x100d_e184, 1); popd(esi);                              /* pop esi */
            ii(0x100d_e185, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_e186, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_e187, 1); retd(); return;                         /* ret */
        }
    }
}
