using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_c16c-1a4ee468")]
        public void Method_1010_c16c()
        {
            ii(0x1010_c16c, 5); pushd(0xac);                            /* push 0xac */
            ii(0x1010_c171, 5); calld(Definitions.sys_check_available_stack_size, 0x5_9bdc); /* call 0x10165d52 */
            ii(0x1010_c176, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_c177, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_c178, 1); pushd(edx);                             /* push edx */
            ii(0x1010_c179, 1); pushd(esi);                             /* push esi */
            ii(0x1010_c17a, 1); pushd(edi);                             /* push edi */
            ii(0x1010_c17b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_c17c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_c17e, 6); sub(esp, 0x78);                         /* sub esp, 0x78 */
            ii(0x1010_c184, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_c186, 5); calld(0x100e_883d, -0x2_394e);          /* call 0x100e883d */
            ii(0x1010_c18b, 3); mov(memd_a32[ss, ebp - 0x54], eax);     /* mov [ebp-0x54], eax */
            ii(0x1010_c18e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_c190, 5); calld(0x1012_0d94, 0x1_4bff);           /* call 0x10120d94 */
            ii(0x1010_c195, 5); calld(0x100d_533c, -0x3_6e5e);          /* call 0x100d533c */
            ii(0x1010_c19a, 1); cwde();                                 /* cwde */
            ii(0x1010_c19b, 1); pushd(eax);                             /* push eax */
            ii(0x1010_c19c, 5); calld(0x100d_5360, -0x3_6e41);          /* call 0x100d5360 */
            ii(0x1010_c1a1, 1); cwde();                                 /* cwde */
            ii(0x1010_c1a2, 1); pushd(eax);                             /* push eax */
            ii(0x1010_c1a3, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_c1a5, 1); pushd(eax);                             /* push eax */
            ii(0x1010_c1a6, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1010_c1ab, 5); mov(ebx, 0x280);                        /* mov ebx, 0x280 */
            ii(0x1010_c1b0, 3); mov(edx, memd_a32[ss, ebp - 0x54]);     /* mov edx, [ebp-0x54] */
            ii(0x1010_c1b3, 5); mov(eax, 0x6ea);                        /* mov eax, 0x6ea */
            ii(0x1010_c1b8, 5); calld(0x100e_8c51, -0x2_356c);          /* call 0x100e8c51 */
            ii(0x1010_c1bd, 3); mov(eax, memd_a32[ss, ebp - 0x54]);     /* mov eax, [ebp-0x54] */
            ii(0x1010_c1c0, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1010_c1c3, 5); calld(Definitions.sys_display_draw_0, 0x5_b2bc); /* call 0x10167484 */
            ii(0x1010_c1c8, 7); mov(memd_a32[ss, ebp - 0x14], 0x1c2);   /* mov dword [ebp-0x14], 0x1c2 */
            ii(0x1010_c1cf, 7); mov(memd_a32[ss, ebp - 0x1c], 0xe6);    /* mov dword [ebp-0x1c], 0xe6 */
            ii(0x1010_c1d6, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1010_c1da, 5); mov(eax, 0x280);                        /* mov eax, 0x280 */
            ii(0x1010_c1df, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1010_c1e1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_c1e3, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1010_c1e5, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1010_c1e8, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1010_c1ea, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1010_c1ec, 3); mov(memd_a32[ss, ebp - 0x64], eax);     /* mov [ebp-0x64], eax */
            ii(0x1010_c1ef, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1010_c1f3, 5); mov(eax, 0x1e0);                        /* mov eax, 0x1e0 */
            ii(0x1010_c1f8, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1010_c1fa, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_c1fc, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1010_c1fe, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1010_c201, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1010_c203, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1010_c205, 3); mov(memd_a32[ss, ebp - 0x60], eax);     /* mov [ebp-0x60], eax */
            ii(0x1010_c208, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1010_c20c, 3); mov(edx, memd_a32[ss, ebp - 0x64]);     /* mov edx, [ebp-0x64] */
            ii(0x1010_c20f, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_c211, 3); mov(memd_a32[ss, ebp - 0x5c], edx);     /* mov [ebp-0x5c], edx */
            ii(0x1010_c214, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1010_c218, 3); mov(edx, memd_a32[ss, ebp - 0x60]);     /* mov edx, [ebp-0x60] */
            ii(0x1010_c21b, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_c21d, 3); mov(memd_a32[ss, ebp - 0x58], edx);     /* mov [ebp-0x58], edx */
            ii(0x1010_c220, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x1010_c225, 5); calld(Definitions.sys_new, 0x5_9bd6);   /* call 0x10165e00 */
            ii(0x1010_c22a, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x1010_c22d, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x1010_c230, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x1010_c233, 4); cmp(memd_a32[ss, ebp - 0x44], 0);       /* cmp dword [ebp-0x44], 0x0 */
            ii(0x1010_c237, 2); if(jzd(0x1010_c25d, 0x24)) goto l_0x1010_c25d; /* jz 0x1010c25d */
            ii(0x1010_c239, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1010_c23d, 1); pushd(eax);                             /* push eax */
            ii(0x1010_c23e, 4); movsx(ecx, memw_a32[ss, ebp - 0x14]);   /* movsx ecx, word [ebp-0x14] */
            ii(0x1010_c242, 4); movsx(ebx, memw_a32[ss, ebp - 0x60]);   /* movsx ebx, word [ebp-0x60] */
            ii(0x1010_c246, 4); movsx(edx, memw_a32[ss, ebp - 0x64]);   /* movsx edx, word [ebp-0x64] */
            ii(0x1010_c24a, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x1010_c24d, 5); calld(0x100d_7bdc, -0x3_4676);          /* call 0x100d7bdc */
            ii(0x1010_c252, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x1010_c255, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x1010_c258, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1010_c25b, 2); jmpd(0x1010_c263, 0x6); goto l_0x1010_c263; /* jmp 0x1010c263 */
        l_0x1010_c25d:
            ii(0x1010_c25d, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1010_c260, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
        l_0x1010_c263:
            ii(0x1010_c263, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1010_c266, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
            ii(0x1010_c269, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x1010_c26e, 5); calld(Definitions.sys_new, 0x5_9b8d);   /* call 0x10165e00 */
            ii(0x1010_c273, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1010_c276, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1010_c279, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1010_c27c, 4); cmp(memd_a32[ss, ebp - 0x34], 0);       /* cmp dword [ebp-0x34], 0x0 */
            ii(0x1010_c280, 2); if(jzd(0x1010_c2ab, 0x29)) goto l_0x1010_c2ab; /* jz 0x1010c2ab */
            ii(0x1010_c282, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1010_c285, 5); add(eax, 0x12);                         /* add eax, 0x12 */
            ii(0x1010_c28a, 1); cwde();                                 /* cwde */
            ii(0x1010_c28b, 1); pushd(eax);                             /* push eax */
            ii(0x1010_c28c, 4); movsx(ecx, memw_a32[ss, ebp - 0x14]);   /* movsx ecx, word [ebp-0x14] */
            ii(0x1010_c290, 4); movsx(ebx, memw_a32[ss, ebp - 0x60]);   /* movsx ebx, word [ebp-0x60] */
            ii(0x1010_c294, 4); movsx(edx, memw_a32[ss, ebp - 0x64]);   /* movsx edx, word [ebp-0x64] */
            ii(0x1010_c298, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1010_c29b, 5); calld(0x100d_7bdc, -0x3_46c4);          /* call 0x100d7bdc */
            ii(0x1010_c2a0, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1010_c2a3, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1010_c2a6, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1010_c2a9, 2); jmpd(0x1010_c2b1, 0x6); goto l_0x1010_c2b1; /* jmp 0x1010c2b1 */
        l_0x1010_c2ab:
            ii(0x1010_c2ab, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1010_c2ae, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
        l_0x1010_c2b1:
            ii(0x1010_c2b1, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1010_c2b4, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1010_c2b7, 3); mov(edx, memd_a32[ss, ebp - 0x54]);     /* mov edx, [ebp-0x54] */
            ii(0x1010_c2ba, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x1010_c2bd, 5); calld(0x100d_7d74, -0x3_454e);          /* call 0x100d7d74 */
            ii(0x1010_c2c2, 4); movsx(ebx, memw_a32[ss, ebp - 0x1c]);   /* movsx ebx, word [ebp-0x1c] */
            ii(0x1010_c2c6, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1010_c2ca, 3); add(ebx, 0x12);                         /* add ebx, 0x12 */
            ii(0x1010_c2cd, 3); imul(ebx, eax);                         /* imul ebx, eax */
            ii(0x1010_c2d0, 5); mov(edx, 0x80);                         /* mov edx, 0x80 */
            ii(0x1010_c2d5, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1010_c2d8, 5); calld(0x100d_4e8c, -0x3_7451);          /* call 0x100d4e8c */
            ii(0x1010_c2dd, 5); calld(Definitions.sys_memset, 0x5_9afe); /* call 0x10165de0 */
            ii(0x1010_c2e2, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1010_c2e7, 5); calld(/* sys */ 0x1016_a24c, 0x5_df60); /* call 0x1016a24c */
            ii(0x1010_c2ec, 4); mov(memb_a32[ss, ebp - 0x4], 0x1);      /* mov byte [ebp-0x4], 0x1 */
            ii(0x1010_c2f0, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1010_c2f7, 3); mov(eax, memd_a32[ss, ebp - 0x58]);     /* mov eax, [ebp-0x58] */
            ii(0x1010_c2fa, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
        l_0x1010_c2fd:
            ii(0x1010_c2fd, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1010_c301, 6); if(jzd(0x1010_c4b0, 0x1a9)) goto l_0x1010_c4b0; /* jz 0x1010c4b0 */
            ii(0x1010_c307, 3); mov(edx, memd_a32[ss, ebp - 0x54]);     /* mov edx, [ebp-0x54] */
            ii(0x1010_c30a, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x1010_c30d, 5); calld(0x100d_7f6c, -0x3_43a6);          /* call 0x100d7f6c */
            ii(0x1010_c312, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1010_c316, 4); movsx(ebx, memw_a32[ss, ebp - 0x14]);   /* movsx ebx, word [ebp-0x14] */
            ii(0x1010_c31a, 3); add(eax, 0x11);                         /* add eax, 0x11 */
            ii(0x1010_c31d, 3); imul(ebx, eax);                         /* imul ebx, eax */
            ii(0x1010_c320, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1010_c323, 5); calld(0x100d_4e8c, -0x3_749c);          /* call 0x100d4e8c */
            ii(0x1010_c328, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1010_c32c, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_c32e, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1010_c331, 5); calld(0x100d_4e8c, -0x3_74aa);          /* call 0x100d4e8c */
            ii(0x1010_c336, 5); calld(/* sys */ 0x1016_6177, 0x5_9e3c); /* call 0x10166177 */
            ii(0x1010_c33b, 4); movsx(ebx, memw_a32[ss, ebp - 0x14]);   /* movsx ebx, word [ebp-0x14] */
            ii(0x1010_c33f, 5); mov(edx, 0x80);                         /* mov edx, 0x80 */
            ii(0x1010_c344, 4); movsx(ecx, memw_a32[ss, ebp - 0x1c]);   /* movsx ecx, word [ebp-0x1c] */
            ii(0x1010_c348, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1010_c34c, 3); add(ecx, 0x11);                         /* add ecx, 0x11 */
            ii(0x1010_c34f, 3); imul(ecx, eax);                         /* imul ecx, eax */
            ii(0x1010_c352, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1010_c355, 5); calld(0x100d_4e8c, -0x3_74ce);          /* call 0x100d4e8c */
            ii(0x1010_c35a, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1010_c35c, 5); calld(Definitions.sys_memset, 0x5_9a7f); /* call 0x10165de0 */
            ii(0x1010_c361, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1010_c364, 3); dec(memd_a32[ss, ebp - 0x18]);          /* dec dword [ebp-0x18] */
            ii(0x1010_c367, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_c36b, 5); cmp(eax, 0xdf);                         /* cmp eax, 0xdf */
            ii(0x1010_c370, 2); if(jaed(0x1010_c37b, 0x9)) goto l_0x1010_c37b; /* jae 0x1010c37b */
            ii(0x1010_c372, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1010_c376, 3); cmp(eax, memd_a32[ss, ebp - 0x58]);     /* cmp eax, [ebp-0x58] */
            ii(0x1010_c379, 2); if(jled(0x1010_c37d, 0x2)) goto l_0x1010_c37d; /* jle 0x1010c37d */
        l_0x1010_c37b:
            ii(0x1010_c37b, 2); jmpd(0x1010_c3e6, 0x69); goto l_0x1010_c3e6; /* jmp 0x1010c3e6 */
        l_0x1010_c37d:
            ii(0x1010_c37d, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_c381, 3); imul(eax, eax, 0x6);                    /* imul eax, eax, 0x6 */
            ii(0x1010_c384, 6); mov(eax, memd_a32[ds, eax + 0x101b_91f6]); /* mov eax, [eax+0x101b91f6] */
            ii(0x1010_c38a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_c38d, 3); mov(memd_a32[ss, ebp - 0x68], eax);     /* mov [ebp-0x68], eax */
            ii(0x1010_c390, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1010_c395, 1); pushd(eax);                             /* push eax */
            ii(0x1010_c396, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1010_c39b, 1); pushd(eax);                             /* push eax */
            ii(0x1010_c39c, 3); mov(eax, memd_a32[ss, ebp - 0x68]);     /* mov eax, [ebp-0x68] */
            ii(0x1010_c39f, 5); or(eax, 0x1_0000);                      /* or eax, 0x10000 */
            ii(0x1010_c3a4, 1); pushd(eax);                             /* push eax */
            ii(0x1010_c3a5, 5); mov(eax, 0x12);                         /* mov eax, 0x12 */
            ii(0x1010_c3aa, 1); pushd(eax);                             /* push eax */
            ii(0x1010_c3ab, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1010_c3af, 1); pushd(eax);                             /* push eax */
            ii(0x1010_c3b0, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1010_c3b4, 1); pushd(eax);                             /* push eax */
            ii(0x1010_c3b5, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_c3b7, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x1010_c3bb, 3); imul(ebx, ebx, 0x6);                    /* imul ebx, ebx, 0x6 */
            ii(0x1010_c3be, 6); mov(ebx, memd_a32[ds, ebx + 0x101b_91fa]); /* mov ebx, [ebx+0x101b91fa] */
            ii(0x1010_c3c4, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1010_c3c8, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1010_c3cb, 5); calld(0x100d_4e8c, -0x3_7544);          /* call 0x100d4e8c */
            ii(0x1010_c3d0, 5); calld(0x100e_9ae5, -0x2_28f0);          /* call 0x100e9ae5 */
            ii(0x1010_c3d5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_c3d8, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
            ii(0x1010_c3db, 3); mov(eax, memd_a32[ss, ebp - 0x58]);     /* mov eax, [ebp-0x58] */
            ii(0x1010_c3de, 5); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x1010_c3e3, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
        l_0x1010_c3e6:
            ii(0x1010_c3e6, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1010_c3e9, 5); calld(0x100d_4e8c, -0x3_7562);          /* call 0x100d4e8c */
            ii(0x1010_c3ee, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1010_c3f1, 3); mov(eax, memd_a32[ss, ebp - 0x54]);     /* mov eax, [ebp-0x54] */
            ii(0x1010_c3f4, 3); mov(eax, memd_a32[ds, eax + 0xe]);      /* mov eax, [eax+0xe] */
            ii(0x1010_c3f7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_c3fa, 3); mov(edx, memd_a32[ss, ebp - 0x60]);     /* mov edx, [ebp-0x60] */
            ii(0x1010_c3fd, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1010_c400, 3); mov(eax, memd_a32[ss, ebp - 0x54]);     /* mov eax, [ebp-0x54] */
            ii(0x1010_c403, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1010_c406, 3); add(eax, memd_a32[ss, ebp - 0x64]);     /* add eax, [ebp-0x64] */
            ii(0x1010_c409, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_c40b, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1010_c40e, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1010_c411, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
        l_0x1010_c414:
            ii(0x1010_c414, 3); dec(memd_a32[ss, ebp - 0xc]);           /* dec dword [ebp-0xc] */
            ii(0x1010_c417, 5); cmp(memw_a32[ss, ebp - 0xc], -0x1 /* 0xff */); /* cmp word [ebp-0xc], 0xffff */
            ii(0x1010_c41c, 2); if(jzd(0x1010_c46b, 0x4d)) goto l_0x1010_c46b; /* jz 0x1010c46b */
            ii(0x1010_c41e, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1010_c421, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
        l_0x1010_c424:
            ii(0x1010_c424, 3); dec(memd_a32[ss, ebp - 0x10]);          /* dec dword [ebp-0x10] */
            ii(0x1010_c427, 5); cmp(memw_a32[ss, ebp - 0x10], -0x1 /* 0xff */); /* cmp word [ebp-0x10], 0xffff */
            ii(0x1010_c42c, 2); if(jzd(0x1010_c457, 0x29)) goto l_0x1010_c457; /* jz 0x1010c457 */
            ii(0x1010_c42e, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1010_c431, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1010_c433, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_c438, 5); cmp(eax, 0x80);                         /* cmp eax, 0x80 */
            ii(0x1010_c43d, 2); if(jzd(0x1010_c449, 0xa)) goto l_0x1010_c449; /* jz 0x1010c449 */
            ii(0x1010_c43f, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1010_c442, 2); mov(dl, memb_a32[ds, eax]);             /* mov dl, [eax] */
            ii(0x1010_c444, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1010_c447, 2); mov(memb_a32[ds, eax], dl);             /* mov [eax], dl */
        l_0x1010_c449:
            ii(0x1010_c449, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1010_c44c, 3); inc(memd_a32[ss, ebp - 0x2c]);          /* inc dword [ebp-0x2c] */
            ii(0x1010_c44f, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1010_c452, 3); inc(memd_a32[ss, ebp - 0x28]);          /* inc dword [ebp-0x28] */
            ii(0x1010_c455, 2); jmpd(0x1010_c424, -0x33); goto l_0x1010_c424; /* jmp 0x1010c424 */
        l_0x1010_c457:
            ii(0x1010_c457, 3); mov(eax, memd_a32[ss, ebp - 0x54]);     /* mov eax, [ebp-0x54] */
            ii(0x1010_c45a, 3); mov(edx, memd_a32[ds, eax + 0xe]);      /* mov edx, [eax+0xe] */
            ii(0x1010_c45d, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_c460, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1010_c464, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1010_c466, 3); add(memd_a32[ss, ebp - 0x28], edx);     /* add [ebp-0x28], edx */
            ii(0x1010_c469, 2); jmpd(0x1010_c414, -0x57); goto l_0x1010_c414; /* jmp 0x1010c414 */
        l_0x1010_c46b:
            ii(0x1010_c46b, 3); lea(edx, ebp - 0x64);                   /* lea edx, [ebp-0x64] */
            ii(0x1010_c46e, 3); mov(eax, memd_a32[ss, ebp - 0x54]);     /* mov eax, [ebp-0x54] */
            ii(0x1010_c471, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1010_c474, 5); calld(Definitions.sys_display_draw_1, 0x5_b02f); /* call 0x101674a8 */
            ii(0x1010_c479, 5); calld(0x1014_82f4, 0x3_be76);           /* call 0x101482f4 */
            ii(0x1010_c47e, 3); mov(memd_a32[ss, ebp - 0x50], eax);     /* mov [ebp-0x50], eax */
        l_0x1010_c481:
            ii(0x1010_c481, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x1010_c484, 5); calld(0x1014_85ad, 0x3_c124);           /* call 0x101485ad */
            ii(0x1010_c489, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x1010_c48c, 2); if(jaed(0x1010_c49e, 0x10)) goto l_0x1010_c49e; /* jae 0x1010c49e */
            ii(0x1010_c48e, 5); calld(/* sys */ 0x1016_b208, 0x5_ed75); /* call 0x1016b208 */
            ii(0x1010_c493, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1010_c496, 2); if(jzd(0x1010_c49c, 0x4)) goto l_0x1010_c49c; /* jz 0x1010c49c */
            ii(0x1010_c498, 4); mov(memb_a32[ss, ebp - 0x4], 0);        /* mov byte [ebp-0x4], 0x0 */
        l_0x1010_c49c:
            ii(0x1010_c49c, 2); jmpd(0x1010_c481, -0x1d); goto l_0x1010_c481; /* jmp 0x1010c481 */
        l_0x1010_c49e:
            ii(0x1010_c49e, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1010_c4a2, 3); cmp(eax, memd_a32[ss, ebp - 0x60]);     /* cmp eax, [ebp-0x60] */
            ii(0x1010_c4a5, 2); if(jgd(0x1010_c4ab, 0x4)) goto l_0x1010_c4ab; /* jg 0x1010c4ab */
            ii(0x1010_c4a7, 4); mov(memb_a32[ss, ebp - 0x4], 0);        /* mov byte [ebp-0x4], 0x0 */
        l_0x1010_c4ab:
            ii(0x1010_c4ab, 5); jmpd(0x1010_c2fd, -0x1b3); goto l_0x1010_c2fd; /* jmp 0x1010c2fd */
        l_0x1010_c4b0:
            ii(0x1010_c4b0, 4); cmp(memd_a32[ss, ebp - 0x4c], 0);       /* cmp dword [ebp-0x4c], 0x0 */
            ii(0x1010_c4b4, 2); if(jzd(0x1010_c4dd, 0x27)) goto l_0x1010_c4dd; /* jz 0x1010c4dd */
            ii(0x1010_c4b6, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x1010_c4b9, 3); mov(memd_a32[ss, ebp - 0x6c], eax);     /* mov [ebp-0x6c], eax */
            ii(0x1010_c4bc, 4); cmp(memd_a32[ss, ebp - 0x6c], 0);       /* cmp dword [ebp-0x6c], 0x0 */
            ii(0x1010_c4c0, 2); if(jzd(0x1010_c4d6, 0x14)) goto l_0x1010_c4d6; /* jz 0x1010c4d6 */
            ii(0x1010_c4c2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_c4c4, 3); mov(eax, memd_a32[ss, ebp - 0x6c]);     /* mov eax, [ebp-0x6c] */
            ii(0x1010_c4c7, 5); calld(Definitions.my_dtor_d3, -0x3_4799); /* call 0x100d7d33 */
            ii(0x1010_c4cc, 5); calld(Definitions.sys_delete, 0x5_9a93); /* call 0x10165f64 */
            ii(0x1010_c4d1, 3); mov(memd_a32[ss, ebp - 0x70], eax);     /* mov [ebp-0x70], eax */
            ii(0x1010_c4d4, 2); jmpd(0x1010_c4dd, 0x7); goto l_0x1010_c4dd; /* jmp 0x1010c4dd */
        l_0x1010_c4d6:
            ii(0x1010_c4d6, 7); mov(memd_a32[ss, ebp - 0x70], 0);       /* mov dword [ebp-0x70], 0x0 */
        l_0x1010_c4dd:
            ii(0x1010_c4dd, 4); cmp(memd_a32[ss, ebp - 0x3c], 0);       /* cmp dword [ebp-0x3c], 0x0 */
            ii(0x1010_c4e1, 2); if(jzd(0x1010_c50a, 0x27)) goto l_0x1010_c50a; /* jz 0x1010c50a */
            ii(0x1010_c4e3, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1010_c4e6, 3); mov(memd_a32[ss, ebp - 0x74], eax);     /* mov [ebp-0x74], eax */
            ii(0x1010_c4e9, 4); cmp(memd_a32[ss, ebp - 0x74], 0);       /* cmp dword [ebp-0x74], 0x0 */
            ii(0x1010_c4ed, 2); if(jzd(0x1010_c503, 0x14)) goto l_0x1010_c503; /* jz 0x1010c503 */
            ii(0x1010_c4ef, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_c4f1, 3); mov(eax, memd_a32[ss, ebp - 0x74]);     /* mov eax, [ebp-0x74] */
            ii(0x1010_c4f4, 5); calld(Definitions.my_dtor_d3, -0x3_47c6); /* call 0x100d7d33 */
            ii(0x1010_c4f9, 5); calld(Definitions.sys_delete, 0x5_9a66); /* call 0x10165f64 */
            ii(0x1010_c4fe, 3); mov(memd_a32[ss, ebp - 0x78], eax);     /* mov [ebp-0x78], eax */
            ii(0x1010_c501, 2); jmpd(0x1010_c50a, 0x7); goto l_0x1010_c50a; /* jmp 0x1010c50a */
        l_0x1010_c503:
            ii(0x1010_c503, 7); mov(memd_a32[ss, ebp - 0x78], 0);       /* mov dword [ebp-0x78], 0x0 */
        l_0x1010_c50a:
            ii(0x1010_c50a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_c50c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_c50d, 1); popd(edi);                              /* pop edi */
            ii(0x1010_c50e, 1); popd(esi);                              /* pop esi */
            ii(0x1010_c50f, 1); popd(edx);                              /* pop edx */
            ii(0x1010_c510, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_c511, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_c512, 1); retd();                                 /* ret */
        }
    }
}
