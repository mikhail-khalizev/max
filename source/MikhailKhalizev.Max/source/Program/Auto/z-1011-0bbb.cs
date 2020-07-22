using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_0bbb-36f2c312")]
        public void Method_1011_0bbb()
        {
            ii(0x1011_0bbb, 5);  push(0x30);                           /* push 0x30 */
            ii(0x1011_0bc0, 5);  call(Definitions.sys_check_available_stack_size, 0x5_518d);/* call 0x10165d52 */
            ii(0x1011_0bc5, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_0bc6, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_0bc7, 1);  push(esi);                            /* push esi */
            ii(0x1011_0bc8, 1);  push(edi);                            /* push edi */
            ii(0x1011_0bc9, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_0bca, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_0bcc, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1011_0bd2, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_0bd5, 3);  mov(memb[ss, ebp - 4], dl);           /* mov [ebp-0x4], dl */
            ii(0x1011_0bd8, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1011_0bda, 5);  call(0x100e_883d, -0x2_83a2);         /* call 0x100e883d */
            ii(0x1011_0bdf, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1011_0be1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_0be4, 2);  mov(memd[ds, eax], edx);              /* mov [eax], edx */
            ii(0x1011_0be6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_0be9, 7);  mov(memd[ds, eax + 4], 0);            /* mov dword [eax+0x4], 0x0 */
            ii(0x1011_0bf0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_0bf3, 7);  mov(memd[ds, eax + 8], 0);            /* mov dword [eax+0x8], 0x0 */
            ii(0x1011_0bfa, 5);  mov(eax, 0x3d);                       /* mov eax, 0x3d */
            ii(0x1011_0bff, 5);  call(0x1007_5fdc, -0x9_ac28);         /* call 0x10075fdc */
            ii(0x1011_0c04, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1011_0c07, 6);  mov(memb[ds, edx + 322], al);         /* mov [edx+0x142], al */
            ii(0x1011_0c0d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_0c10, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_0c12, 6);  mov(dl, memb[ds, eax + 322]);         /* mov dl, [eax+0x142] */
            ii(0x1011_0c18, 1);  dec(edx);                             /* dec edx */
            ii(0x1011_0c19, 5);  mov(ebx, 0xc);                        /* mov ebx, 0xc */
            ii(0x1011_0c1e, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1011_0c20, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1011_0c23, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x1011_0c25, 3);  imul(eax, eax, 0xc);                  /* imul eax, eax, 0xc */
            ii(0x1011_0c28, 1);  inc(eax);                             /* inc eax */
            ii(0x1011_0c29, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1011_0c2c, 6);  mov(memb[ds, edx + 320], al);         /* mov [edx+0x140], al */
            ii(0x1011_0c32, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1011_0c35, 10);  mov(memd[ds, edx + 324], 0);         /* mov dword [edx+0x144], 0x0 */
            ii(0x1011_0c3f, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1011_0c42, 9);  mov(memw[ds, edx + 330], 0);          /* mov word [edx+0x14a], 0x0 */
            ii(0x1011_0c4b, 5);  call(/* sys */ 0x1016_be34, 0x5_b1e4);/* call 0x1016be34 */
            ii(0x1011_0c50, 5);  call(0x100d_533c, -0x3_b919);         /* call 0x100d533c */
            ii(0x1011_0c55, 1);  cwde();                               /* cwde */
            ii(0x1011_0c56, 1);  push(eax);                            /* push eax */
            ii(0x1011_0c57, 5);  call(0x100d_5360, -0x3_b8fc);         /* call 0x100d5360 */
            ii(0x1011_0c5c, 1);  cwde();                               /* cwde */
            ii(0x1011_0c5d, 1);  push(eax);                            /* push eax */
            ii(0x1011_0c5e, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1011_0c60, 1);  push(eax);                            /* push eax */
            ii(0x1011_0c61, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1011_0c63, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1011_0c66, 3);  movsx(ecx, ax);                       /* movsx ecx, ax */
            ii(0x1011_0c69, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1011_0c6c, 2);  mov(ebx, memd[ds, edx]);              /* mov ebx, [edx] */
            ii(0x1011_0c6e, 3);  mov(ebx, memd[ds, ebx + 14]);         /* mov ebx, [ebx+0xe] */
            ii(0x1011_0c71, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1011_0c74, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_0c77, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x1011_0c79, 5);  mov(eax, 0x6c0);                      /* mov eax, 0x6c0 */
            ii(0x1011_0c7e, 5);  call(0x100e_8c51, -0x2_8032);         /* call 0x100e8c51 */
            ii(0x1011_0c83, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1011_0c86, 7);  cmp(memb[ds, edx + 323], 1);          /* cmp byte [edx+0x143], 0x1 */
            ii(0x1011_0c8d, 2);  if(jnz(0x1011_0ca0, 0x11)) goto l_0x1011_0ca0;/* jnz 0x10110ca0 */
            ii(0x1011_0c8f, 5);  mov(edx, StringDefinitions.TrainingMissions);/* mov edx, 0x101a4682 */
            ii(0x1011_0c94, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_0c97, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1011_0c99, 5);  call(0x1010_c628, -0x4676);           /* call 0x1010c628 */
            ii(0x1011_0c9e, 2);  jmp(0x1011_0ce9, 0x49); goto l_0x1011_0ce9;/* jmp 0x10110ce9 */
        l_0x1011_0ca0:
            ii(0x1011_0ca0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_0ca3, 7);  cmp(memb[ds, eax + 323], 8);          /* cmp byte [eax+0x143], 0x8 */
            ii(0x1011_0caa, 2);  if(jnz(0x1011_0cbd, 0x11)) goto l_0x1011_0cbd;/* jnz 0x10110cbd */
            ii(0x1011_0cac, 5);  mov(edx, StringDefinitions.StandAloneMissions);/* mov edx, 0x101a4694 */
            ii(0x1011_0cb1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_0cb4, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1011_0cb6, 5);  call(0x1010_c628, -0x4693);           /* call 0x1010c628 */
            ii(0x1011_0cbb, 2);  jmp(0x1011_0ce9, 0x2c); goto l_0x1011_0ce9;/* jmp 0x10110ce9 */
        l_0x1011_0cbd:
            ii(0x1011_0cbd, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_0cc0, 7);  cmp(memb[ds, eax + 323], 2);          /* cmp byte [eax+0x143], 0x2 */
            ii(0x1011_0cc7, 2);  if(jnz(0x1011_0cda, 0x11)) goto l_0x1011_0cda;/* jnz 0x10110cda */
            ii(0x1011_0cc9, 5);  mov(edx, StringDefinitions.CampaignGame);/* mov edx, 0x101a46a9 */
            ii(0x1011_0cce, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_0cd1, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1011_0cd3, 5);  call(0x1010_c628, -0x46b0);           /* call 0x1010c628 */
            ii(0x1011_0cd8, 2);  jmp(0x1011_0ce9, 0xf); goto l_0x1011_0ce9;/* jmp 0x10110ce9 */
        l_0x1011_0cda:
            ii(0x1011_0cda, 5);  mov(edx, StringDefinitions.MultiplayerScenarios);/* mov edx, 0x101a46b7 */
            ii(0x1011_0cdf, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_0ce2, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1011_0ce4, 5);  call(0x1010_c628, -0x46c1);           /* call 0x1010c628 */
        l_0x1011_0ce9:
            ii(0x1011_0ce9, 7);  mov(memd[ss, ebp - 12], 0x13);        /* mov dword [ebp-0xc], 0x13 */
        l_0x1011_0cf0:
            ii(0x1011_0cf0, 3);  dec(memd[ss, ebp - 12]);              /* dec dword [ebp-0xc] */
            ii(0x1011_0cf3, 5);  cmp(memw[ss, ebp - 12], -1 /* 0xff */);/* cmp word [ebp-0xc], 0xffff */
            ii(0x1011_0cf8, 2);  if(jz(0x1011_0d19, 0x1f)) goto l_0x1011_0d19;/* jz 0x10110d19 */
            ii(0x1011_0cfa, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1011_0cfe, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1011_0d01, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1011_0d04, 7);  mov(memd[ds, eax + 16], 0);           /* mov dword [eax+0x10], 0x0 */
            ii(0x1011_0d0b, 4);  movsx(edx, memb[ss, ebp - 12]);       /* movsx edx, byte [ebp-0xc] */
            ii(0x1011_0d0f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_0d12, 5);  call(0x1011_05a5, -0x772);            /* call 0x101105a5 */
            ii(0x1011_0d17, 2);  jmp(0x1011_0cf0, -0x29); goto l_0x1011_0cf0;/* jmp 0x10110cf0 */
        l_0x1011_0d19:
            ii(0x1011_0d19, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_0d1c, 5);  call(0x1011_0812, -0x50f);            /* call 0x10110812 */
            ii(0x1011_0d21, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_0d24, 5);  call(0x1011_09f0, -0x339);            /* call 0x101109f0 */
            ii(0x1011_0d29, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_0d2c, 5);  call(0x1011_0496, -0x89b);            /* call 0x10110496 */
            ii(0x1011_0d31, 5);  call(/* sys */ 0x1016_bcc4, 0x5_af8e);/* call 0x1016bcc4 */
            ii(0x1011_0d36, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_0d38, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_0d39, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_0d3a, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_0d3b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_0d3c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_0d3d, 1);  ret();                                /* ret */
        }
    }
}
