using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_709a-33af8040")]
        public void Method_1011_709a()
        {
            ii(0x1011_709a, 5);  push(0x80);                           /* push 0x80 */
            ii(0x1011_709f, 5);  call(Definitions.sys_check_available_stack_size, 0x4_ecae);/* call 0x10165d52 */
            ii(0x1011_70a4, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_70a5, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_70a6, 1);  push(edx);                            /* push edx */
            ii(0x1011_70a7, 1);  push(esi);                            /* push esi */
            ii(0x1011_70a8, 1);  push(edi);                            /* push edi */
            ii(0x1011_70a9, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_70aa, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_70ac, 6);  sub(esp, 0x4c);                       /* sub esp, 0x4c */
            ii(0x1011_70b2, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_70b5, 5);  mov(ebx, 0x26);                       /* mov ebx, 0x26 */
            ii(0x1011_70ba, 5);  mov(edx, 0x6e6);                      /* mov edx, 0x6e6 */
            ii(0x1011_70bf, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_70c2, 5);  call(0x100d_68a3, -0x4_0824);         /* call 0x100d68a3 */
            ii(0x1011_70c7, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_70ca, 3);  lea(eax, memd[ss, ebp - 4]);          /* lea eax, [ebp-0x4] */
            ii(0x1011_70cd, 3);  mov(memd[ss, ebp - 72], eax);         /* mov [ebp-0x48], eax */
            ii(0x1011_70d0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_70d3, 7);  mov(memd[ds, eax + 19], 0x101b_6734); /* mov dword [eax+0x13], 0x101b6734 */
            ii(0x1011_70da, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1011_70df, 5);  call(0x1012_0d94, 0x9cb0);            /* call 0x10120d94 */
            ii(0x1011_70e4, 5);  mov(edx, 0x10);                       /* mov edx, 0x10 */
            ii(0x1011_70e9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_70ec, 5);  call(0x100e_f318, -0x2_7dd9);         /* call 0x100ef318 */
            ii(0x1011_70f1, 5);  call(0x100d_6124, -0x4_0fd2);         /* call 0x100d6124 */
            ii(0x1011_70f6, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_70f8, 2);  mov(dl, al);                          /* mov dl, al */
            ii(0x1011_70fa, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_70fd, 5);  call(0x100d_6adf, -0x4_0623);         /* call 0x100d6adf */
            ii(0x1011_7102, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_7105, 3);  add(edx, 0x17);                       /* add edx, 0x17 */
            ii(0x1011_7108, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_710b, 5);  call(0x100d_6a11, -0x4_06ff);         /* call 0x100d6a11 */
            ii(0x1011_7110, 5);  mov(eax, 5);                          /* mov eax, 0x5 */
            ii(0x1011_7115, 5);  call(/* sys */ 0x1016_a24c, 0x5_3132);/* call 0x1016a24c */
            ii(0x1011_711a, 5);  mov(eax, 0x38);                       /* mov eax, 0x38 */
            ii(0x1011_711f, 5);  call(Definitions.sys_new, 0x4_ecdc);  /* call 0x10165e00 */
            ii(0x1011_7124, 3);  mov(memd[ss, ebp - 60], eax);         /* mov [ebp-0x3c], eax */
            ii(0x1011_7127, 3);  mov(eax, memd[ss, ebp - 60]);         /* mov eax, [ebp-0x3c] */
            ii(0x1011_712a, 3);  mov(memd[ss, ebp - 64], eax);         /* mov [ebp-0x40], eax */
            ii(0x1011_712d, 4);  cmp(memd[ss, ebp - 64], 0);           /* cmp dword [ebp-0x40], 0x0 */
            ii(0x1011_7131, 2);  if(jz(0x1011_715b, 0x28)) goto l_0x1011_715b;/* jz 0x1011715b */
            ii(0x1011_7133, 5);  mov(eax, 0xc1);                       /* mov eax, 0xc1 */
            ii(0x1011_7138, 1);  push(eax);                            /* push eax */
            ii(0x1011_7139, 5);  mov(ecx, 0x9b);                       /* mov ecx, 0x9b */
            ii(0x1011_713e, 5);  mov(ebx, 0x159);                      /* mov ebx, 0x159 */
            ii(0x1011_7143, 5);  mov(edx, 0x158);                      /* mov edx, 0x158 */
            ii(0x1011_7148, 3);  mov(eax, memd[ss, ebp - 60]);         /* mov eax, [ebp-0x3c] */
            ii(0x1011_714b, 5);  call(Definitions.my_ctor_c17, -0x4_8d41);/* call 0x100ce40f */
            ii(0x1011_7150, 3);  mov(memd[ss, ebp - 68], eax);         /* mov [ebp-0x44], eax */
            ii(0x1011_7153, 3);  mov(eax, memd[ss, ebp - 68]);         /* mov eax, [ebp-0x44] */
            ii(0x1011_7156, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1011_7159, 2);  jmp(0x1011_7161, 6); goto l_0x1011_7161;/* jmp 0x10117161 */
        l_0x1011_715b:
            ii(0x1011_715b, 3);  mov(eax, memd[ss, ebp - 64]);         /* mov eax, [ebp-0x40] */
            ii(0x1011_715e, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
        l_0x1011_7161:
            ii(0x1011_7161, 3);  mov(eax, memd[ss, ebp - 44]);         /* mov eax, [ebp-0x2c] */
            ii(0x1011_7164, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_7167, 3);  mov(memd[ds, edx + 51], eax);         /* mov [edx+0x33], eax */
            ii(0x1011_716a, 5);  mov(eax, 0x38);                       /* mov eax, 0x38 */
            ii(0x1011_716f, 5);  call(Definitions.sys_new, 0x4_ec8c);  /* call 0x10165e00 */
            ii(0x1011_7174, 3);  mov(memd[ss, ebp - 48], eax);         /* mov [ebp-0x30], eax */
            ii(0x1011_7177, 3);  mov(eax, memd[ss, ebp - 48]);         /* mov eax, [ebp-0x30] */
            ii(0x1011_717a, 3);  mov(memd[ss, ebp - 52], eax);         /* mov [ebp-0x34], eax */
            ii(0x1011_717d, 4);  cmp(memd[ss, ebp - 52], 0);           /* cmp dword [ebp-0x34], 0x0 */
            ii(0x1011_7181, 2);  if(jz(0x1011_71ab, 0x28)) goto l_0x1011_71ab;/* jz 0x101171ab */
            ii(0x1011_7183, 5);  mov(eax, 0xc1);                       /* mov eax, 0xc1 */
            ii(0x1011_7188, 1);  push(eax);                            /* push eax */
            ii(0x1011_7189, 5);  mov(ecx, 0x55);                       /* mov ecx, 0x55 */
            ii(0x1011_718e, 5);  mov(ebx, 0x14f);                      /* mov ebx, 0x14f */
            ii(0x1011_7193, 5);  mov(edx, 0x14e);                      /* mov edx, 0x14e */
            ii(0x1011_7198, 3);  mov(eax, memd[ss, ebp - 48]);         /* mov eax, [ebp-0x30] */
            ii(0x1011_719b, 5);  call(Definitions.my_ctor_c17, -0x4_8d91);/* call 0x100ce40f */
            ii(0x1011_71a0, 3);  mov(memd[ss, ebp - 56], eax);         /* mov [ebp-0x38], eax */
            ii(0x1011_71a3, 3);  mov(eax, memd[ss, ebp - 56]);         /* mov eax, [ebp-0x38] */
            ii(0x1011_71a6, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x1011_71a9, 2);  jmp(0x1011_71b1, 6); goto l_0x1011_71b1;/* jmp 0x101171b1 */
        l_0x1011_71ab:
            ii(0x1011_71ab, 3);  mov(eax, memd[ss, ebp - 52]);         /* mov eax, [ebp-0x34] */
            ii(0x1011_71ae, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
        l_0x1011_71b1:
            ii(0x1011_71b1, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x1011_71b4, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_71b7, 3);  mov(memd[ds, edx + 55], eax);         /* mov [edx+0x37], eax */
            ii(0x1011_71ba, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1011_71bd, 5);  call(0x100d_5224, -0x4_1f9e);         /* call 0x100d5224 */
            ii(0x1011_71c2, 1);  push(eax);                            /* push eax */
            ii(0x1011_71c3, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1011_71c6, 5);  call(0x100d_5250, -0x4_1f7b);         /* call 0x100d5250 */
            ii(0x1011_71cb, 1);  push(eax);                            /* push eax */
            ii(0x1011_71cc, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1011_71cf, 5);  call(0x100d_527c, -0x4_1f58);         /* call 0x100d527c */
            ii(0x1011_71d4, 1);  push(eax);                            /* push eax */
            ii(0x1011_71d5, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x1011_71d8, 5);  call(0x100d_52a8, -0x4_1f35);         /* call 0x100d52a8 */
            ii(0x1011_71dd, 1);  push(eax);                            /* push eax */
            ii(0x1011_71de, 5);  mov(ecx, 2);                          /* mov ecx, 0x2 */
            ii(0x1011_71e3, 5);  mov(ebx, 2);                          /* mov ebx, 0x2 */
            ii(0x1011_71e8, 5);  mov(edx, StringDefinitions.Restart);  /* mov edx, 0x101a7b1d */
            ii(0x1011_71ed, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_71f0, 3);  mov(eax, memd[ds, eax + 51]);         /* mov eax, [eax+0x33] */
            ii(0x1011_71f3, 5);  call(0x100c_ef64, -0x4_8294);         /* call 0x100cef64 */
            ii(0x1011_71f8, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1011_71fb, 5);  call(0x100d_5224, -0x4_1fdc);         /* call 0x100d5224 */
            ii(0x1011_7200, 1);  push(eax);                            /* push eax */
            ii(0x1011_7201, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1011_7204, 5);  call(0x100d_5250, -0x4_1fb9);         /* call 0x100d5250 */
            ii(0x1011_7209, 1);  push(eax);                            /* push eax */
            ii(0x1011_720a, 3);  lea(eax, memd[ss, ebp - 32]);         /* lea eax, [ebp-0x20] */
            ii(0x1011_720d, 5);  call(0x100d_527c, -0x4_1f96);         /* call 0x100d527c */
            ii(0x1011_7212, 1);  push(eax);                            /* push eax */
            ii(0x1011_7213, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_7216, 5);  call(0x100d_52a8, -0x4_1f73);         /* call 0x100d52a8 */
            ii(0x1011_721b, 1);  push(eax);                            /* push eax */
            ii(0x1011_721c, 5);  mov(ecx, 2);                          /* mov ecx, 0x2 */
            ii(0x1011_7221, 5);  mov(ebx, 2);                          /* mov ebx, 0x2 */
            ii(0x1011_7226, 5);  mov(edx, StringDefinitions.Quit2);    /* mov edx, 0x101a7b25 */
            ii(0x1011_722b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_722e, 3);  mov(eax, memd[ds, eax + 55]);         /* mov eax, [eax+0x37] */
            ii(0x1011_7231, 5);  call(0x100c_ef64, -0x4_82d2);         /* call 0x100cef64 */
            ii(0x1011_7236, 5);  mov(edx, 0xd);                        /* mov edx, 0xd */
            ii(0x1011_723b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_723e, 3);  mov(eax, memd[ds, eax + 51]);         /* mov eax, [eax+0x33] */
            ii(0x1011_7241, 5);  call(0x100d_5134, -0x4_2112);         /* call 0x100d5134 */
            ii(0x1011_7246, 5);  mov(edx, 0x1b);                       /* mov edx, 0x1b */
            ii(0x1011_724b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_724e, 3);  mov(eax, memd[ds, eax + 55]);         /* mov eax, [eax+0x37] */
            ii(0x1011_7251, 5);  call(0x100d_5134, -0x4_2122);         /* call 0x100d5134 */
            ii(0x1011_7256, 5);  mov(edx, 0x700d);                     /* mov edx, 0x700d */
            ii(0x1011_725b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_725e, 3);  mov(eax, memd[ds, eax + 51]);         /* mov eax, [eax+0x33] */
            ii(0x1011_7261, 5);  call(0x100d_5164, -0x4_2102);         /* call 0x100d5164 */
            ii(0x1011_7266, 5);  mov(edx, 0x701b);                     /* mov edx, 0x701b */
            ii(0x1011_726b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_726e, 3);  mov(eax, memd[ds, eax + 55]);         /* mov eax, [eax+0x37] */
            ii(0x1011_7271, 5);  call(0x100d_5164, -0x4_2112);         /* call 0x100d5164 */
            ii(0x1011_7276, 5);  mov(edx, 0x4e6);                      /* mov edx, 0x4e6 */
            ii(0x1011_727b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_727e, 3);  mov(eax, memd[ds, eax + 51]);         /* mov eax, [eax+0x33] */
            ii(0x1011_7281, 5);  call(0x100d_50d4, -0x4_21b2);         /* call 0x100d50d4 */
            ii(0x1011_7286, 5);  mov(edx, 0x4e4);                      /* mov edx, 0x4e4 */
            ii(0x1011_728b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_728e, 3);  mov(eax, memd[ds, eax + 55]);         /* mov eax, [eax+0x37] */
            ii(0x1011_7291, 5);  call(0x100d_50d4, -0x4_21c2);         /* call 0x100d50d4 */
            ii(0x1011_7296, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_7299, 3);  mov(edx, memd[ds, edx + 41]);         /* mov edx, [edx+0x29] */
            ii(0x1011_729c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_729f, 3);  mov(eax, memd[ds, eax + 51]);         /* mov eax, [eax+0x33] */
            ii(0x1011_72a2, 5);  call(0x100c_f85c, -0x4_7a4b);         /* call 0x100cf85c */
            ii(0x1011_72a7, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_72aa, 3);  mov(edx, memd[ds, edx + 41]);         /* mov edx, [edx+0x29] */
            ii(0x1011_72ad, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_72b0, 3);  mov(eax, memd[ds, eax + 55]);         /* mov eax, [eax+0x37] */
            ii(0x1011_72b3, 5);  call(0x100c_f85c, -0x4_7a5c);         /* call 0x100cf85c */
            ii(0x1011_72b8, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1011_72bd, 1);  push(eax);                            /* push eax */
            ii(0x1011_72be, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1011_72c0, 1);  push(eax);                            /* push eax */
            ii(0x1011_72c1, 5);  push(0x1_00ff);                       /* push 0x100ff */
            ii(0x1011_72c6, 5);  mov(eax, 0xaf);                       /* mov eax, 0xaf */
            ii(0x1011_72cb, 1);  push(eax);                            /* push eax */
            ii(0x1011_72cc, 5);  mov(eax, 0x109);                      /* mov eax, 0x109 */
            ii(0x1011_72d1, 1);  push(eax);                            /* push eax */
            ii(0x1011_72d2, 5);  mov(eax, 0xe);                        /* mov eax, 0xe */
            ii(0x1011_72d7, 1);  push(eax);                            /* push eax */
            ii(0x1011_72d8, 5);  mov(ecx, 0x14);                       /* mov ecx, 0x14 */
            ii(0x1011_72dd, 5);  mov(ebx, StringDefinitions.UnableToContinueWithNextTurnRemotePlayersAreNoLongerSynchronizedPressRestartToLoadFromLastAutoSavedFilePressQuitToExitThisGame);/* mov ebx, 0x101a7b2a */
            ii(0x1011_72e2, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_72e5, 3);  mov(edx, memd[ds, edx + 37]);         /* mov edx, [edx+0x25] */
            ii(0x1011_72e8, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1011_72eb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_72ee, 3);  mov(eax, memd[ds, eax + 45]);         /* mov eax, [eax+0x2d] */
            ii(0x1011_72f1, 5);  call(0x100e_9ae5, -0x2_d811);         /* call 0x100e9ae5 */
            ii(0x1011_72f6, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_72f9, 3);  add(edx, 0x17);                       /* add edx, 0x17 */
            ii(0x1011_72fc, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_72ff, 3);  mov(eax, memd[ds, eax + 41]);         /* mov eax, [eax+0x29] */
            ii(0x1011_7302, 5);  call(Definitions.sys_display_draw_1, 0x5_01a1);/* call 0x101674a8 */
            ii(0x1011_7307, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_730a, 3);  mov(memd[ss, ebp - 76], eax);         /* mov [ebp-0x4c], eax */
            ii(0x1011_730d, 3);  mov(eax, memd[ss, ebp - 76]);         /* mov eax, [ebp-0x4c] */
            ii(0x1011_7310, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_7312, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_7313, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_7314, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_7315, 1);  pop(edx);                             /* pop edx */
            ii(0x1011_7316, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_7317, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_7318, 1);  ret();                                /* ret */
        }
    }
}
