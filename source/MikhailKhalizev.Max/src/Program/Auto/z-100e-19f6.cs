using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4d1f9a07-71be-4b69-ba62-701842705cde")]
        public void Method_100e_19f6()
        {
            ii(0x100e_19f6, 5); pushd(0x68);                            /* push 0x68 */
            ii(0x100e_19fb, 5); calld(Definitions.sys_check_available_stack_size, 0x8_4352); /* call 0x10165d52 */
            ii(0x100e_1a00, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_1a01, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_1a02, 1); pushd(esi);                             /* push esi */
            ii(0x100e_1a03, 1); pushd(edi);                             /* push edi */
            ii(0x100e_1a04, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_1a05, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_1a07, 6); sub(esp, 0x3c);                         /* sub esp, 0x3c */
            ii(0x100e_1a0d, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_1a10, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x100e_1a13, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x100e_1a16, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_1a19, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100e_1a1b, 5); calld(0x100d_6a11, -0xb00f);            /* call 0x100d6a11 */
            ii(0x100e_1a20, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x100e_1a23, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_1a26, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x100e_1a29, 5); calld(0x100d_7f6c, -0x9ac2);            /* call 0x100d7f6c */
            ii(0x100e_1a2e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_1a31, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x100e_1a34, 5); calld(0x100d_4ef0, -0xcb49);            /* call 0x100d4ef0 */
            ii(0x100e_1a39, 1); cwde();                                 /* cwde */
            ii(0x100e_1a3a, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x100e_1a3d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_1a40, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x100e_1a43, 5); calld(0x100d_4ebc, -0xcb8c);            /* call 0x100d4ebc */
            ii(0x100e_1a48, 1); cwde();                                 /* cwde */
            ii(0x100e_1a49, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x100e_1a4c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_1a4f, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x100e_1a52, 5); calld(0x100d_4ef0, -0xcb67);            /* call 0x100d4ef0 */
            ii(0x100e_1a57, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_1a5a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_1a5d, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x100e_1a60, 5); calld(0x100d_4f58, -0xcb0d);            /* call 0x100d4f58 */
            ii(0x100e_1a65, 1); cwde();                                 /* cwde */
            ii(0x100e_1a66, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100e_1a68, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x100e_1a6b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_1a6e, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x100e_1a71, 5); calld(0x100d_4f24, -0xcb52);            /* call 0x100d4f24 */
            ii(0x100e_1a76, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_1a79, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_1a7b, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_1a7e, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_1a80, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100e_1a82, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x100e_1a85, 4); movsx(eax, memw_a32[ss, ebp - 0x38]);   /* movsx eax, word [ebp-0x38] */
            ii(0x100e_1a89, 3); mov(edx, memd_a32[ss, ebp - 0x30]);     /* mov edx, [ebp-0x30] */
            ii(0x100e_1a8c, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_1a8e, 3); mov(memd_a32[ss, ebp - 0x28], edx);     /* mov [ebp-0x28], edx */
            ii(0x100e_1a91, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_1a96, 1); pushd(eax);                             /* push eax */
            ii(0x100e_1a97, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x100e_1a9c, 1); pushd(eax);                             /* push eax */
            ii(0x100e_1a9d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_1aa0, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100e_1aa3, 5); calld(0x1007_6574, -0x6_b534);          /* call 0x10076574 */
            ii(0x100e_1aa8, 5); calld(0x1007_623c, -0x6_b871);          /* call 0x1007623c */
            ii(0x100e_1aad, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100e_1ab0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_1ab3, 1); pushd(eax);                             /* push eax */
            ii(0x100e_1ab4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_1ab7, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100e_1aba, 5); calld(0x1007_6574, -0x6_b54b);          /* call 0x10076574 */
            ii(0x100e_1abf, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x100e_1ac2, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100e_1ac4, 1); cwde();                                 /* cwde */
            ii(0x100e_1ac5, 1); pushd(eax);                             /* push eax */
            ii(0x100e_1ac6, 5); mov(eax, 0x277);                        /* mov eax, 0x277 */
            ii(0x100e_1acb, 1); pushd(eax);                             /* push eax */
            ii(0x100e_1acc, 5); mov(ecx, 0x276);                        /* mov ecx, 0x276 */
            ii(0x100e_1ad1, 3); lea(ebx, ebp - 0x34);                   /* lea ebx, [ebp-0x34] */
            ii(0x100e_1ad4, 3); mov(edx, memd_a32[ss, ebp - 0x12]);     /* mov edx, [ebp-0x12] */
            ii(0x100e_1ad7, 5); mov(eax, StringDefinitions.Hits4);      /* mov eax, 0x101a1b8f */
            ii(0x100e_1adc, 5); calld(0x1012_bae2, 0x4_a001);           /* call 0x1012bae2 */
            ii(0x100e_1ae1, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100e_1ae4, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x100e_1ae7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_1aea, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x100e_1aed, 5); calld(0x100d_4ebc, -0xcc36);            /* call 0x100d4ebc */
            ii(0x100e_1af2, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_1af5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_1af8, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x100e_1afb, 5); calld(0x100d_4f24, -0xcbdc);            /* call 0x100d4f24 */
            ii(0x100e_1b00, 1); cwde();                                 /* cwde */
            ii(0x100e_1b01, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_1b03, 3); mov(memd_a32[ss, ebp - 0x28], edx);     /* mov [ebp-0x28], edx */
            ii(0x100e_1b06, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_1b09, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100e_1b0c, 5); calld(0x1007_6574, -0x6_b59d);          /* call 0x10076574 */
            ii(0x100e_1b11, 5); calld(0x1007_623c, -0x6_b8da);          /* call 0x1007623c */
            ii(0x100e_1b16, 5); cmp(memw_a32[ds, eax + 0x1b], 0);       /* cmp word [eax+0x1b], 0x0 */
            ii(0x100e_1b1b, 2); if(jzd(0x100e_1b6f, 0x52)) goto l_0x100e_1b6f; /* jz 0x100e1b6f */
            ii(0x100e_1b1d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_1b1f, 1); pushd(eax);                             /* push eax */
            ii(0x100e_1b20, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100e_1b25, 1); pushd(eax);                             /* push eax */
            ii(0x100e_1b26, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_1b29, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100e_1b2c, 5); calld(0x1007_6574, -0x6_b5bd);          /* call 0x10076574 */
            ii(0x100e_1b31, 5); calld(0x1007_623c, -0x6_b8fa);          /* call 0x1007623c */
            ii(0x100e_1b36, 3); mov(eax, memd_a32[ds, eax + 0x19]);     /* mov eax, [eax+0x19] */
            ii(0x100e_1b39, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_1b3c, 1); pushd(eax);                             /* push eax */
            ii(0x100e_1b3d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_1b40, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100e_1b43, 5); calld(0x1007_6574, -0x6_b5d4);          /* call 0x10076574 */
            ii(0x100e_1b48, 3); mov(al, memb_a32[ds, eax + 0x54]);      /* mov al, [eax+0x54] */
            ii(0x100e_1b4b, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100e_1b4d, 1); cwde();                                 /* cwde */
            ii(0x100e_1b4e, 1); pushd(eax);                             /* push eax */
            ii(0x100e_1b4f, 5); mov(eax, 0x27d);                        /* mov eax, 0x27d */
            ii(0x100e_1b54, 1); pushd(eax);                             /* push eax */
            ii(0x100e_1b55, 5); mov(ecx, 0x27c);                        /* mov ecx, 0x27c */
            ii(0x100e_1b5a, 3); lea(ebx, ebp - 0x34);                   /* lea ebx, [ebp-0x34] */
            ii(0x100e_1b5d, 3); mov(edx, memd_a32[ss, ebp - 0x12]);     /* mov edx, [ebp-0x12] */
            ii(0x100e_1b60, 5); mov(eax, StringDefinitions.Ammo4);      /* mov eax, 0x101a1b94 */
            ii(0x100e_1b65, 5); calld(0x1012_bae2, 0x4_9f78);           /* call 0x1012bae2 */
            ii(0x100e_1b6a, 5); jmpd(0x100e_1c23, 0xb4); goto l_0x100e_1c23; /* jmp 0x100e1c23 */
        l_0x100e_1b6f:
            ii(0x100e_1b6f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_1b72, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100e_1b75, 5); calld(0x1007_6574, -0x6_b606);          /* call 0x10076574 */
            ii(0x100e_1b7a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_1b7c, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100e_1b7f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_1b81, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100e_1b86, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_1b88, 2); if(jnzd(0x100e_1ba4, 0x1a)) goto l_0x100e_1ba4; /* jnz 0x100e1ba4 */
            ii(0x100e_1b8a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_1b8d, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100e_1b90, 5); calld(0x1007_6574, -0x6_b621);          /* call 0x10076574 */
            ii(0x100e_1b95, 5); calld(0x1007_623c, -0x6_b95e);          /* call 0x1007623c */
            ii(0x100e_1b9a, 3); mov(eax, memd_a32[ds, eax + 0x17]);     /* mov eax, [eax+0x17] */
            ii(0x100e_1b9d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_1ba0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_1ba2, 2); if(jgd(0x100e_1ba6, 0x2)) goto l_0x100e_1ba6; /* jg 0x100e1ba6 */
        l_0x100e_1ba4:
            ii(0x100e_1ba4, 2); jmpd(0x100e_1c23, 0x7d); goto l_0x100e_1c23; /* jmp 0x100e1c23 */
        l_0x100e_1ba6:
            ii(0x100e_1ba6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_1ba9, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100e_1bac, 5); calld(0x1007_6574, -0x6_b63d);          /* call 0x10076574 */
            ii(0x100e_1bb1, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100e_1bb4, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_1bb7, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100e_1bba, 6); mov(eax, memd_a32[ds, eax + 0x101c_81d2]); /* mov eax, [eax+0x101c81d2] */
            ii(0x100e_1bc0, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x100e_1bc3, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100e_1bc6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_1bc8, 5); mov(eax, 0x101b_d33c);                  /* mov eax, 0x101bd33c */
            ii(0x100e_1bcd, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100e_1bcf, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x100e_1bd2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_1bd4, 1); pushd(eax);                             /* push eax */
            ii(0x100e_1bd5, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x100e_1bda, 1); pushd(eax);                             /* push eax */
            ii(0x100e_1bdb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_1bde, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100e_1be1, 5); calld(0x1007_6574, -0x6_b672);          /* call 0x10076574 */
            ii(0x100e_1be6, 5); calld(0x1007_623c, -0x6_b9af);          /* call 0x1007623c */
            ii(0x100e_1beb, 3); mov(eax, memd_a32[ds, eax + 0x17]);     /* mov eax, [eax+0x17] */
            ii(0x100e_1bee, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_1bf1, 1); pushd(eax);                             /* push eax */
            ii(0x100e_1bf2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_1bf5, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100e_1bf8, 5); calld(0x1007_6574, -0x6_b689);          /* call 0x10076574 */
            ii(0x100e_1bfd, 3); mov(eax, memd_a32[ds, eax + 0x50]);     /* mov eax, [eax+0x50] */
            ii(0x100e_1c00, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_1c03, 1); pushd(eax);                             /* push eax */
            ii(0x100e_1c04, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x100e_1c07, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100e_1c09, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_1c0c, 1); pushd(eax);                             /* push eax */
            ii(0x100e_1c0d, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x100e_1c10, 3); movsx(ecx, memw_a32[ds, eax]);          /* movsx ecx, word [eax] */
            ii(0x100e_1c13, 3); lea(ebx, ebp - 0x34);                   /* lea ebx, [ebp-0x34] */
            ii(0x100e_1c16, 3); mov(edx, memd_a32[ss, ebp - 0x12]);     /* mov edx, [ebp-0x12] */
            ii(0x100e_1c19, 5); mov(eax, StringDefinitions.Cargo5);     /* mov eax, 0x101a1b99 */
            ii(0x100e_1c1e, 5); calld(0x1012_bae2, 0x4_9ebf);           /* call 0x1012bae2 */
        l_0x100e_1c23:
            ii(0x100e_1c23, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100e_1c27, 2); if(jzd(0x100e_1c90, 0x67)) goto l_0x100e_1c90; /* jz 0x100e1c90 */
            ii(0x100e_1c29, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_1c2c, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x100e_1c2f, 5); calld(0x100d_4ef0, -0xcd44);            /* call 0x100d4ef0 */
            ii(0x100e_1c34, 1); cwde();                                 /* cwde */
            ii(0x100e_1c35, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x100e_1c38, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_1c3b, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x100e_1c3e, 5); calld(0x100d_4ebc, -0xcd87);            /* call 0x100d4ebc */
            ii(0x100e_1c43, 1); cwde();                                 /* cwde */
            ii(0x100e_1c44, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x100e_1c47, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_1c4a, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x100e_1c4d, 5); calld(0x100d_4ef0, -0xcd62);            /* call 0x100d4ef0 */
            ii(0x100e_1c52, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_1c55, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_1c58, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x100e_1c5b, 5); calld(0x100d_4f58, -0xcd08);            /* call 0x100d4f58 */
            ii(0x100e_1c60, 1); cwde();                                 /* cwde */
            ii(0x100e_1c61, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_1c63, 3); mov(memd_a32[ss, ebp - 0x2c], edx);     /* mov [ebp-0x2c], edx */
            ii(0x100e_1c66, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_1c69, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x100e_1c6c, 5); calld(0x100d_4ebc, -0xcdb5);            /* call 0x100d4ebc */
            ii(0x100e_1c71, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_1c74, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_1c77, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x100e_1c7a, 5); calld(0x100d_4f24, -0xcd5b);            /* call 0x100d4f24 */
            ii(0x100e_1c7f, 1); cwde();                                 /* cwde */
            ii(0x100e_1c80, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_1c82, 3); mov(memd_a32[ss, ebp - 0x28], edx);     /* mov [ebp-0x28], edx */
            ii(0x100e_1c85, 3); lea(edx, ebp - 0x34);                   /* lea edx, [ebp-0x34] */
            ii(0x100e_1c88, 3); mov(eax, memd_a32[ss, ebp - 0x12]);     /* mov eax, [ebp-0x12] */
            ii(0x100e_1c8b, 5); calld(Definitions.sys_display_draw_1, 0x8_5818); /* call 0x101674a8 */
        l_0x100e_1c90:
            ii(0x100e_1c90, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_1c92, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_1c93, 1); popd(edi);                              /* pop edi */
            ii(0x100e_1c94, 1); popd(esi);                              /* pop esi */
            ii(0x100e_1c95, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_1c96, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_1c97, 1); retd(); return;                         /* ret */
        }
    }
}
