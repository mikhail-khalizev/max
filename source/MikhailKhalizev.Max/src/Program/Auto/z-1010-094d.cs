using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c1ed5ade-2994-4103-900a-18faccc57219")]
        public void Method_1010_094d()
        {
            ii(0x1010_094d, 5); pushd(0x6c);                            /* push 0x6c */
            ii(0x1010_0952, 5); calld(Definitions.sys_check_available_stack_size, 0x653fb); /* call 0x10165d52 */
            ii(0x1010_0957, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_0958, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_0959, 1); pushd(edx);                             /* push edx */
            ii(0x1010_095a, 1); pushd(esi);                             /* push esi */
            ii(0x1010_095b, 1); pushd(edi);                             /* push edi */
            ii(0x1010_095c, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_095d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_095f, 6); sub(esp, 0x48);                         /* sub esp, 0x48 */
            ii(0x1010_0965, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_0968, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_096a, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1010_096f, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1010_0972, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_0975, 5); calld(0x1007_6074, -0x8a906);           /* call 0x10076074 */
            ii(0x1010_097a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_097f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_0981, 2); if(jnzd(0x1010_098c, 0x9)) goto l_0x1010_098c; /* jnz 0x1010098c */
            ii(0x1010_0983, 7); cmp(memb_a32[ds, 0x101c_3980], 0);      /* cmp byte [0x101c3980], 0x0 */
            ii(0x1010_098a, 2); if(jzd(0x1010_098e, 0x2)) goto l_0x1010_098e; /* jz 0x1010098e */
        l_0x1010_098c:
            ii(0x1010_098c, 2); jmpd(0x1010_0993, 0x5); goto l_0x1010_0993; /* jmp 0x10100993 */
        l_0x1010_098e:
            ii(0x1010_098e, 5); jmpd(0x1010_0d9b, 0x408); goto l_0x1010_0d9b; /* jmp 0x10100d9b */
        l_0x1010_0993:
            ii(0x1010_0993, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_0996, 5); calld(0x1007_623c, -0x8a75f);           /* call 0x1007623c */
            ii(0x1010_099b, 3); lea(ebx, ebp - 0x1c);                   /* lea ebx, [ebp-0x1c] */
            ii(0x1010_099e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_09a0, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1010_09a2, 5); calld(0x1007_6800, -0x8a1a7);           /* call 0x10076800 */
            ii(0x1010_09a7, 5); mov(eax, 0x6);                          /* mov eax, 0x6 */
            ii(0x1010_09ac, 5); calld(0x100e_883d, -0x18174);           /* call 0x100e883d */
            ii(0x1010_09b1, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1010_09b4, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1010_09b9, 5); calld(/* sys */ 0x1016_a24c, 0x6988e);  /* call 0x1016a24c */
            ii(0x1010_09be, 5); pushd(0x500_00a2);                      /* push 0x50000a2 */
            ii(0x1010_09c3, 6); calld_abs(memd_a32[ds, 0x101b_ddf0]);   /* call dword [0x101bddf0] */
            ii(0x1010_09c9, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x1010_09cc, 3); add(eax, memd_a32[ds, edx + 0x4]);      /* add eax, [edx+0x4] */
            ii(0x1010_09cf, 1); pushd(eax);                             /* push eax */
            ii(0x1010_09d0, 3); mov(ecx, memd_a32[ss, ebp - 0x18]);     /* mov ecx, [ebp-0x18] */
            ii(0x1010_09d3, 2); mov(ecx, memd_a32[ds, ecx]);            /* mov ecx, [ecx] */
            ii(0x1010_09d5, 5); mov(ebx, 0x80);                         /* mov ebx, 0x80 */
            ii(0x1010_09da, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_09dd, 5); calld(0x1010_07c8, -0x21a);             /* call 0x101007c8 */
            ii(0x1010_09e2, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1010_09e5, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1010_09e8, 5); calld(Definitions.my_strobj_c_str_v2, -0x77225); /* call 0x100897c8 */
            ii(0x1010_09ed, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_09ef, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1010_09f2, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1010_09f5, 5); calld(/* sys */ 0x1016_6d74, 0x6637a);  /* call 0x10166d74 */
            ii(0x1010_09fa, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_09fc, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1010_09ff, 5); calld(Definitions.my_string_dtor, 0x41126); /* call 0x10141b2a */
            ii(0x1010_0a04, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_0a06, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_0a08, 5); mov(eax, 0x9);                          /* mov eax, 0x9 */
            ii(0x1010_0a0d, 5); calld(0x100f_fca3, -0xd6f);             /* call 0x100ffca3 */
            ii(0x1010_0a12, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1010_0a17, 1); pushd(eax);                             /* push eax */
            ii(0x1010_0a18, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1010_0a1b, 5); calld(0x1007_6730, -0x8a2f0);           /* call 0x10076730 */
            ii(0x1010_0a20, 4); mov(ax, memw_a32[ds, eax + 0xa]);       /* mov ax, [eax+0xa] */
            ii(0x1010_0a24, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1010_0a29, 1); pushd(eax);                             /* push eax */
            ii(0x1010_0a2a, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_0a2d, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1010_0a2f, 3); mov(al, memb_a32[ds, edx + 0x4d]);      /* mov al, [edx+0x4d] */
            ii(0x1010_0a32, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_0a34, 3); mov(cx, ax);                            /* mov cx, ax */
            ii(0x1010_0a37, 5); mov(ebx, 0x276);                        /* mov ebx, 0x276 */
            ii(0x1010_0a3c, 5); mov(edx, 0xa);                          /* mov edx, 0xa */
            ii(0x1010_0a41, 5); mov(eax, 0x101a_2bd1);                  /* mov eax, 0x101a2bd1 */ /* "Hits" */
            ii(0x1010_0a46, 5); calld(0x100f_ff95, -0xab6);             /* call 0x100fff95 */
            ii(0x1010_0a4b, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1010_0a4e, 5); calld(0x1007_6730, -0x8a323);           /* call 0x10076730 */
            ii(0x1010_0a53, 5); cmp(memw_a32[ds, eax + 0xe], 0);        /* cmp word [eax+0xe], 0x0 */
            ii(0x1010_0a58, 2); if(jzd(0x1010_0ac0, 0x66)) goto l_0x1010_0ac0; /* jz 0x10100ac0 */
            ii(0x1010_0a5a, 7); mov(memd_a32[ss, ebp - 0x20], 0x1);     /* mov dword [ebp-0x20], 0x1 */
            ii(0x1010_0a61, 3); pushd(memd_a32[ss, ebp - 0x20]);        /* push dword [ebp-0x20] */
            ii(0x1010_0a64, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_0a67, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_0a69, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1010_0a6c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_0a6e, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1010_0a73, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1010_0a75, 2); if(jnzd(0x1010_0a8a, 0x13)) goto l_0x1010_0a8a; /* jnz 0x10100a8a */
            ii(0x1010_0a77, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1010_0a7a, 5); calld(0x1007_6730, -0x8a34f);           /* call 0x10076730 */
            ii(0x1010_0a7f, 3); mov(eax, memd_a32[ds, eax + 0x19]);     /* mov eax, [eax+0x19] */
            ii(0x1010_0a82, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_0a85, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1010_0a88, 2); jmpd(0x1010_0a91, 0x7); goto l_0x1010_0a91; /* jmp 0x10100a91 */
        l_0x1010_0a8a:
            ii(0x1010_0a8a, 7); mov(memd_a32[ss, ebp - 0x24], 0);       /* mov dword [ebp-0x24], 0x0 */
        l_0x1010_0a91:
            ii(0x1010_0a91, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1010_0a94, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1010_0a99, 1); pushd(eax);                             /* push eax */
            ii(0x1010_0a9a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_0a9d, 3); mov(al, memb_a32[ds, eax + 0x54]);      /* mov al, [eax+0x54] */
            ii(0x1010_0aa0, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1010_0aa2, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_0aa4, 3); mov(cx, ax);                            /* mov cx, ax */
            ii(0x1010_0aa7, 5); mov(ebx, 0x27c);                        /* mov ebx, 0x27c */
            ii(0x1010_0aac, 5); mov(edx, 0xb);                          /* mov edx, 0xb */
            ii(0x1010_0ab1, 5); mov(eax, 0x101a_2bd6);                  /* mov eax, 0x101a2bd6 */ /* "Ammo" */
            ii(0x1010_0ab6, 5); calld(0x100f_ff95, -0xb26);             /* call 0x100fff95 */
            ii(0x1010_0abb, 5); jmpd(0x1010_0b83, 0xc3); goto l_0x1010_0b83; /* jmp 0x10100b83 */
        l_0x1010_0ac0:
            ii(0x1010_0ac0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_0ac3, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1010_0ac6, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_0ac9, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1010_0acc, 6); mov(al, memb_a32[ds, eax + 0x101c_81d5]); /* mov al, [eax+0x101c81d5] */
            ii(0x1010_0ad2, 3); mov(memb_a32[ss, ebp - 0x28], al);      /* mov [ebp-0x28], al */
            ii(0x1010_0ad5, 7); mov(memd_a32[ss, ebp - 0x8], 0x3);      /* mov dword [ebp-0x8], 0x3 */
            ii(0x1010_0adc, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1010_0adf, 5); calld(0x1007_6730, -0x8a3b4);           /* call 0x10076730 */
            ii(0x1010_0ae4, 3); mov(eax, memd_a32[ds, eax + 0x17]);     /* mov eax, [eax+0x17] */
            ii(0x1010_0ae7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_0aea, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1010_0aed, 2); if(jgd(0x1010_0af8, 0x9)) goto l_0x1010_0af8; /* jg 0x10100af8 */
            ii(0x1010_0aef, 7); mov(memd_a32[ss, ebp - 0x8], 0x1);      /* mov dword [ebp-0x8], 0x1 */
            ii(0x1010_0af6, 2); jmpd(0x1010_0b12, 0x1a); goto l_0x1010_0b12; /* jmp 0x10100b12 */
        l_0x1010_0af8:
            ii(0x1010_0af8, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1010_0afb, 5); calld(0x1007_6730, -0x8a3d0);           /* call 0x10076730 */
            ii(0x1010_0b00, 3); mov(eax, memd_a32[ds, eax + 0x17]);     /* mov eax, [eax+0x17] */
            ii(0x1010_0b03, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_0b06, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1010_0b09, 2); if(jgd(0x1010_0b12, 0x7)) goto l_0x1010_0b12; /* jg 0x10100b12 */
            ii(0x1010_0b0b, 7); mov(memd_a32[ss, ebp - 0x8], 0x2);      /* mov dword [ebp-0x8], 0x2 */
        l_0x1010_0b12:
            ii(0x1010_0b12, 4); cmp(memb_a32[ss, ebp - 0x28], 0x4);     /* cmp byte [ebp-0x28], 0x4 */
            ii(0x1010_0b16, 2); if(jged(0x1010_0b1f, 0x7)) goto l_0x1010_0b1f; /* jge 0x10100b1f */
            ii(0x1010_0b18, 7); mov(memd_a32[ss, ebp - 0x8], 0xa);      /* mov dword [ebp-0x8], 0xa */
        l_0x1010_0b1f:
            ii(0x1010_0b1f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_0b22, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_0b24, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1010_0b27, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_0b29, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1010_0b2e, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1010_0b30, 2); if(jzd(0x1010_0b3b, 0x9)) goto l_0x1010_0b3b; /* jz 0x10100b3b */
            ii(0x1010_0b32, 7); cmp(memb_a32[ds, 0x101c_3980], 0);      /* cmp byte [0x101c3980], 0x0 */
            ii(0x1010_0b39, 2); if(jzd(0x1010_0b3d, 0x2)) goto l_0x1010_0b3d; /* jz 0x10100b3d */
        l_0x1010_0b3b:
            ii(0x1010_0b3b, 2); jmpd(0x1010_0b44, 0x7); goto l_0x1010_0b44; /* jmp 0x10100b44 */
        l_0x1010_0b3d:
            ii(0x1010_0b3d, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
        l_0x1010_0b44:
            ii(0x1010_0b44, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_0b48, 1); pushd(eax);                             /* push eax */
            ii(0x1010_0b49, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1010_0b4c, 5); calld(0x1007_6730, -0x8a421);           /* call 0x10076730 */
            ii(0x1010_0b51, 4); mov(ax, memw_a32[ds, eax + 0x19]);      /* mov ax, [eax+0x19] */
            ii(0x1010_0b55, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1010_0b5a, 1); pushd(eax);                             /* push eax */
            ii(0x1010_0b5b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_0b5e, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_0b60, 4); mov(cx, memw_a32[ds, eax + 0x52]);      /* mov cx, [eax+0x52] */
            ii(0x1010_0b64, 4); movsx(eax, memb_a32[ss, ebp - 0x28]);   /* movsx eax, byte [ebp-0x28] */
            ii(0x1010_0b68, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_0b6b, 6); mov(ebx, memd_a32[ds, eax + 0x101b_d33a]); /* mov ebx, [eax+0x101bd33a] */
            ii(0x1010_0b71, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1010_0b74, 5); mov(edx, 0xb);                          /* mov edx, 0xb */
            ii(0x1010_0b79, 5); mov(eax, 0x101a_2bdb);                  /* mov eax, 0x101a2bdb */ /* "Cargo" */
            ii(0x1010_0b7e, 5); calld(0x100f_ff95, -0xbee);             /* call 0x100fff95 */
        l_0x1010_0b83:
            ii(0x1010_0b83, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1010_0b88, 1); pushd(eax);                             /* push eax */
            ii(0x1010_0b89, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1010_0b8c, 5); calld(0x1007_6730, -0x8a461);           /* call 0x10076730 */
            ii(0x1010_0b91, 4); mov(ax, memw_a32[ds, eax + 0x10]);      /* mov ax, [eax+0x10] */
            ii(0x1010_0b95, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1010_0b9a, 1); pushd(eax);                             /* push eax */
            ii(0x1010_0b9b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_0b9e, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x1010_0ba1, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1010_0ba3, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_0ba5, 3); mov(cx, ax);                            /* mov cx, ax */
            ii(0x1010_0ba8, 5); mov(ebx, 0x28c);                        /* mov ebx, 0x28c */
            ii(0x1010_0bad, 5); mov(edx, 0xc);                          /* mov edx, 0xc */
            ii(0x1010_0bb2, 5); mov(eax, 0x101a_2be1);                  /* mov eax, 0x101a2be1 */ /* "Speed" */
            ii(0x1010_0bb7, 5); calld(0x100f_ff95, -0xc27);             /* call 0x100fff95 */
            ii(0x1010_0bbc, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1010_0bc1, 1); pushd(eax);                             /* push eax */
            ii(0x1010_0bc2, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1010_0bc5, 5); calld(0x1007_6730, -0x8a49a);           /* call 0x10076730 */
            ii(0x1010_0bca, 4); mov(ax, memw_a32[ds, eax + 0x14]);      /* mov ax, [eax+0x14] */
            ii(0x1010_0bce, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1010_0bd3, 1); pushd(eax);                             /* push eax */
            ii(0x1010_0bd4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_0bd7, 3); mov(al, memb_a32[ds, eax + 0x50]);      /* mov al, [eax+0x50] */
            ii(0x1010_0bda, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1010_0bdc, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_0bde, 3); mov(cx, ax);                            /* mov cx, ax */
            ii(0x1010_0be1, 5); mov(ebx, 0x28e);                        /* mov ebx, 0x28e */
            ii(0x1010_0be6, 5); mov(edx, 0xd);                          /* mov edx, 0xd */
            ii(0x1010_0beb, 5); mov(eax, 0x101a_2be7);                  /* mov eax, 0x101a2be7 */ /* "Shots" */
            ii(0x1010_0bf0, 5); calld(0x100f_ff95, -0xc60);             /* call 0x100fff95 */
            ii(0x1010_0bf5, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1010_0bf8, 5); calld(0x1007_6730, -0x8a4cd);           /* call 0x10076730 */
            ii(0x1010_0bfd, 3); mov(eax, memd_a32[ds, eax + 0x17]);     /* mov eax, [eax+0x17] */
            ii(0x1010_0c00, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_0c03, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_0c05, 2); if(jnzd(0x1010_0c0f, 0x8)) goto l_0x1010_0c0f; /* jnz 0x10100c0f */
            ii(0x1010_0c07, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_0c0a, 5); calld(0x1010_01f8, -0xa17);             /* call 0x101001f8 */
        l_0x1010_0c0f:
            ii(0x1010_0c0f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_0c12, 5); cmp(memw_a32[ds, eax + 0x8], 0x1e);     /* cmp word [eax+0x8], 0x1e */
            ii(0x1010_0c17, 2); if(jnzd(0x1010_0c2c, 0x13)) goto l_0x1010_0c2c; /* jnz 0x10100c2c */
            ii(0x1010_0c19, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_0c1c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_0c1e, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1010_0c21, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_0c23, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1010_0c28, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1010_0c2a, 2); if(jzd(0x1010_0c2e, 0x2)) goto l_0x1010_0c2e; /* jz 0x10100c2e */
        l_0x1010_0c2c:
            ii(0x1010_0c2c, 2); jmpd(0x1010_0c38, 0xa); goto l_0x1010_0c38; /* jmp 0x10100c38 */
        l_0x1010_0c2e:
            ii(0x1010_0c2e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_0c31, 5); calld(0x1010_0683, -0x5b3);             /* call 0x10100683 */
            ii(0x1010_0c36, 2); jmpd(0x1010_0c40, 0x8); goto l_0x1010_0c40; /* jmp 0x10100c40 */
        l_0x1010_0c38:
            ii(0x1010_0c38, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_0c3b, 5); calld(0x1010_0448, -0x7f8);             /* call 0x10100448 */
        l_0x1010_0c40:
            ii(0x1010_0c40, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_0c43, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_0c45, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1010_0c48, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_0c4a, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1010_0c4f, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1010_0c51, 2); if(jzd(0x1010_0c5c, 0x9)) goto l_0x1010_0c5c; /* jz 0x10100c5c */
            ii(0x1010_0c53, 7); cmp(memb_a32[ds, 0x101c_3980], 0);      /* cmp byte [0x101c3980], 0x0 */
            ii(0x1010_0c5a, 2); if(jzd(0x1010_0c6e, 0x12)) goto l_0x1010_0c6e; /* jz 0x10100c6e */
        l_0x1010_0c5c:
            ii(0x1010_0c5c, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1010_0c5f, 5); calld(0x1007_6730, -0x8a534);           /* call 0x10076730 */
            ii(0x1010_0c64, 3); mov(eax, memd_a32[ds, eax + 0x17]);     /* mov eax, [eax+0x17] */
            ii(0x1010_0c67, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_0c6a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_0c6c, 2); if(jgd(0x1010_0c70, 0x2)) goto l_0x1010_0c70; /* jg 0x10100c70 */
        l_0x1010_0c6e:
            ii(0x1010_0c6e, 2); jmpd(0x1010_0c79, 0x9); goto l_0x1010_0c79; /* jmp 0x10100c79 */
        l_0x1010_0c70:
            ii(0x1010_0c70, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_0c73, 4); test(memb_a32[ds, eax + 0x13], 0x2);    /* test byte [eax+0x13], 0x2 */
            ii(0x1010_0c77, 2); if(jnzd(0x1010_0c7b, 0x2)) goto l_0x1010_0c7b; /* jnz 0x10100c7b */
        l_0x1010_0c79:
            ii(0x1010_0c79, 2); jmpd(0x1010_0c90, 0x15); goto l_0x1010_0c90; /* jmp 0x10100c90 */
        l_0x1010_0c7b:
            ii(0x1010_0c7b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_0c7e, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1010_0c81, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_0c84, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1010_0c87, 7); cmp(memb_a32[ds, eax + 0x101c_81d5], 0x1); /* cmp byte [eax+0x101c81d5], 0x1 */
            ii(0x1010_0c8e, 2); if(jged(0x1010_0c92, 0x2)) goto l_0x1010_0c92; /* jge 0x10100c92 */
        l_0x1010_0c90:
            ii(0x1010_0c90, 2); jmpd(0x1010_0ca7, 0x15); goto l_0x1010_0ca7; /* jmp 0x10100ca7 */
        l_0x1010_0c92:
            ii(0x1010_0c92, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_0c95, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1010_0c98, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_0c9b, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1010_0c9e, 7); cmp(memb_a32[ds, eax + 0x101c_81d5], 0x3); /* cmp byte [eax+0x101c81d5], 0x3 */
            ii(0x1010_0ca5, 2); if(jled(0x1010_0cac, 0x5)) goto l_0x1010_0cac; /* jle 0x10100cac */
        l_0x1010_0ca7:
            ii(0x1010_0ca7, 5); jmpd(0x1010_0d76, 0xca); goto l_0x1010_0d76; /* jmp 0x10100d76 */
        l_0x1010_0cac:
            ii(0x1010_0cac, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1010_0caf, 5); calld(0x1007_20b1, -0x8ec03);           /* call 0x100720b1 */
            ii(0x1010_0cb4, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1010_0cb7, 5); calld(0x1007_20b1, -0x8ec0b);           /* call 0x100720b1 */
            ii(0x1010_0cbc, 3); lea(ebx, ebp - 0x44);                   /* lea ebx, [ebp-0x44] */
            ii(0x1010_0cbf, 3); lea(edx, ebp - 0x38);                   /* lea edx, [ebp-0x38] */
            ii(0x1010_0cc2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_0cc5, 5); calld(0x1007_6204, -0x8aac6);           /* call 0x10076204 */
            ii(0x1010_0cca, 5); calld(0x1014_3616, 0x42947);            /* call 0x10143616 */
            ii(0x1010_0ccf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_0cd2, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1010_0cd5, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_0cd8, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1010_0cdb, 6); mov(al, memb_a32[ds, eax + 0x101c_81d5]); /* mov al, [eax+0x101c81d5] */
            ii(0x1010_0ce1, 3); mov(memb_a32[ss, ebp - 0x2c], al);      /* mov [ebp-0x2c], al */
            ii(0x1010_0ce4, 2); jmpd(0x1010_0d12, 0x2c); goto l_0x1010_0d12; /* jmp 0x10100d12 */
        l_0x1010_0ce6:
            ii(0x1010_0ce6, 3); mov(eax, memd_a32[ss, ebp - 0x36]);     /* mov eax, [ebp-0x36] */
            ii(0x1010_0ce9, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_0cec, 3); mov(eax, memd_a32[ss, ebp - 0x42]);     /* mov eax, [ebp-0x42] */
            ii(0x1010_0cef, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_0cf2, 2); jmpd(0x1010_0d34, 0x40); goto l_0x1010_0d34; /* jmp 0x10100d34 */
        l_0x1010_0cf4:
            ii(0x1010_0cf4, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1010_0cf7, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_0cfa, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x1010_0cfd, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_0d00, 2); jmpd(0x1010_0d34, 0x32); goto l_0x1010_0d34; /* jmp 0x10100d34 */
        l_0x1010_0d02:
            ii(0x1010_0d02, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1010_0d05, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_0d08, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1010_0d0b, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_0d0e, 2); jmpd(0x1010_0d34, 0x24); goto l_0x1010_0d34; /* jmp 0x10100d34 */
        l_0x1010_0d10:
            ii(0x1010_0d10, 2); jmpd(0x1010_0d34, 0x22); goto l_0x1010_0d34; /* jmp 0x10100d34 */
        l_0x1010_0d12:
            ii(0x1010_0d12, 3); mov(al, memb_a32[ss, ebp - 0x2c]);      /* mov al, [ebp-0x2c] */
            ii(0x1010_0d15, 3); mov(memb_a32[ss, ebp - 0x48], al);      /* mov [ebp-0x48], al */
            ii(0x1010_0d18, 4); cmp(memb_a32[ss, ebp - 0x48], 0x2);     /* cmp byte [ebp-0x48], 0x2 */
            ii(0x1010_0d1c, 2); if(jbd(0x1010_0d2c, 0xe)) goto l_0x1010_0d2c; /* jb 0x10100d2c */
            ii(0x1010_0d1e, 4); cmp(memb_a32[ss, ebp - 0x48], 0x2);     /* cmp byte [ebp-0x48], 0x2 */
            ii(0x1010_0d22, 2); if(jbed(0x1010_0cf4, -0x30)) goto l_0x1010_0cf4; /* jbe 0x10100cf4 */
            ii(0x1010_0d24, 4); cmp(memb_a32[ss, ebp - 0x48], 0x3);     /* cmp byte [ebp-0x48], 0x3 */
            ii(0x1010_0d28, 2); if(jzd(0x1010_0d02, -0x28)) goto l_0x1010_0d02; /* jz 0x10100d02 */
            ii(0x1010_0d2a, 2); jmpd(0x1010_0d10, -0x1c); goto l_0x1010_0d10; /* jmp 0x10100d10 */
        l_0x1010_0d2c:
            ii(0x1010_0d2c, 4); cmp(memb_a32[ss, ebp - 0x48], 0x1);     /* cmp byte [ebp-0x48], 0x1 */
            ii(0x1010_0d30, 2); if(jzd(0x1010_0ce6, -0x4c)) goto l_0x1010_0ce6; /* jz 0x10100ce6 */
            ii(0x1010_0d32, 2); jmpd(0x1010_0d10, -0x24); goto l_0x1010_0d10; /* jmp 0x10100d10 */
        l_0x1010_0d34:
            ii(0x1010_0d34, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_0d38, 1); pushd(eax);                             /* push eax */
            ii(0x1010_0d39, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_0d3b, 4); mov(ax, memw_a32[ss, ebp - 0x10]);      /* mov ax, [ebp-0x10] */
            ii(0x1010_0d3f, 1); pushd(eax);                             /* push eax */
            ii(0x1010_0d40, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_0d42, 4); mov(cx, memw_a32[ss, ebp - 0xc]);       /* mov cx, [ebp-0xc] */
            ii(0x1010_0d46, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_0d49, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1010_0d4c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_0d4f, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1010_0d52, 6); mov(ebx, memd_a32[ds, eax + 0x101c_81d2]); /* mov ebx, [eax+0x101c81d2] */
            ii(0x1010_0d58, 3); sar(ebx, 0x18);                         /* sar ebx, 0x18 */
            ii(0x1010_0d5b, 3); shl(ebx, 0x2);                          /* shl ebx, 0x2 */
            ii(0x1010_0d5e, 6); mov(ebx, memd_a32[ds, ebx + 0x101b_d33a]); /* mov ebx, [ebx+0x101bd33a] */
            ii(0x1010_0d64, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1010_0d67, 5); mov(edx, 0xc);                          /* mov edx, 0xc */
            ii(0x1010_0d6c, 5); mov(eax, 0x101a_2bed);                  /* mov eax, 0x101a2bed */ /* "Total" */
            ii(0x1010_0d71, 5); calld(0x100f_ff95, -0xde1);             /* call 0x100fff95 */
        l_0x1010_0d76:
            ii(0x1010_0d76, 5); mov(eax, 0x9);                          /* mov eax, 0x9 */
            ii(0x1010_0d7b, 5); calld(0x100e_883d, -0x18543);           /* call 0x100e883d */
            ii(0x1010_0d80, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1010_0d83, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x1010_0d86, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1010_0d89, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1010_0d8c, 5); calld(Definitions.sys_display_draw_1, 0x66717); /* call 0x101674a8 */
            ii(0x1010_0d91, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_0d93, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1010_0d96, 5); calld(0x1007_5eec, -0x8aeaf);           /* call 0x10075eec */
        l_0x1010_0d9b:
            ii(0x1010_0d9b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_0d9d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_0d9e, 1); popd(edi);                              /* pop edi */
            ii(0x1010_0d9f, 1); popd(esi);                              /* pop esi */
            ii(0x1010_0da0, 1); popd(edx);                              /* pop edx */
            ii(0x1010_0da1, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_0da2, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_0da3, 1); retd(); return;                         /* ret */
        }
    }
}
