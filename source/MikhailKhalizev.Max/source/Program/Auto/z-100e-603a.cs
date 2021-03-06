using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_603a-f02d175e")]
        public void Method_100e_603a()
        {
            ii(0x100e_603a, 5);  push(0x3c);                           /* push 0x3c */
            ii(0x100e_603f, 5);  call(Definitions.sys_check_available_stack_size, 0x7_fd0e);/* call 0x10165d52 */
            ii(0x100e_6044, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_6045, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_6046, 1);  push(esi);                            /* push esi */
            ii(0x100e_6047, 1);  push(edi);                            /* push edi */
            ii(0x100e_6048, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_6049, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_604b, 6);  sub(esp, 0x20);                       /* sub esp, 0x20 */
            ii(0x100e_6051, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_6054, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_6057, 4);  mov(memb[ss, ebp - 12], 2);           /* mov byte [ebp-0xc], 0x2 */
            ii(0x100e_605b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_605e, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_6060, 3);  mov(dl, memb[ds, eax + 38]);          /* mov dl, [eax+0x26] */
            ii(0x100e_6063, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100e_6065, 5);  mov(al, memb[ds, 0x101c_37da]);       /* mov al, [0x101c37da] */
            ii(0x100e_606a, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100e_606c, 6);  if(jnz(0x100e_6185, 0x113)) goto l_0x100e_6185;/* jnz 0x100e6185 */
            ii(0x100e_6072, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_6075, 5);  call(0x1007_611c, -0x6_ff5e);         /* call 0x1007611c */
            ii(0x100e_607a, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100e_607c, 6);  if(jz(0x100e_6185, 0x103)) goto l_0x100e_6185;/* jz 0x100e6185 */
            ii(0x100e_6082, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_6085, 5);  call(0x1007_611c, -0x6_ff6e);         /* call 0x1007611c */
            ii(0x100e_608a, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100e_608d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_6090, 4);  cmp(memb[ds, eax + 61], 0x10);        /* cmp byte [eax+0x3d], 0x10 */
            ii(0x100e_6094, 2);  if(jz(0x100e_60b5, 0x1f)) goto l_0x100e_60b5;/* jz 0x100e60b5 */
            ii(0x100e_6096, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_6099, 4);  cmp(memb[ds, eax + 61], 4);           /* cmp byte [eax+0x3d], 0x4 */
            ii(0x100e_609d, 2);  if(jnz(0x100e_60a8, 9)) goto l_0x100e_60a8;/* jnz 0x100e60a8 */
            ii(0x100e_609f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_60a2, 4);  cmp(memb[ds, eax + 62], 0x1f);        /* cmp byte [eax+0x3e], 0x1f */
            ii(0x100e_60a6, 2);  if(jz(0x100e_60aa, 2)) goto l_0x100e_60aa;/* jz 0x100e60aa */
        l_0x100e_60a8:
            ii(0x100e_60a8, 2);  jmp(0x100e_60b3, 9); goto l_0x100e_60b3;/* jmp 0x100e60b3 */
        l_0x100e_60aa:
            ii(0x100e_60aa, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_60ad, 4);  test(memb[ds, eax + 19], 2);          /* test byte [eax+0x13], 0x2 */
            ii(0x100e_60b1, 2);  if(jz(0x100e_60b5, 2)) goto l_0x100e_60b5;/* jz 0x100e60b5 */
        l_0x100e_60b3:
            ii(0x100e_60b3, 2);  jmp(0x100e_60b7, 2); goto l_0x100e_60b7;/* jmp 0x100e60b7 */
        l_0x100e_60b5:
            ii(0x100e_60b5, 2);  jmp(0x100e_60bc, 5); goto l_0x100e_60bc;/* jmp 0x100e60bc */
        l_0x100e_60b7:
            ii(0x100e_60b7, 5);  jmp(0x100e_6185, 0xc9); goto l_0x100e_6185;/* jmp 0x100e6185 */
        l_0x100e_60bc:
            ii(0x100e_60bc, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100e_60bf, 5);  cmp(memw[ds, eax + 8], 0x4e);         /* cmp word [eax+0x8], 0x4e */
            ii(0x100e_60c4, 6);  if(jz(0x100e_6185, 0xbb)) goto l_0x100e_6185;/* jz 0x100e6185 */
            ii(0x100e_60ca, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100e_60cd, 4);  mov(ax, memw[ds, eax + 28]);          /* mov ax, [eax+0x1c] */
            ii(0x100e_60d1, 1);  inc(eax);                             /* inc eax */
            ii(0x100e_60d2, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x100e_60d5, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100e_60d8, 4);  mov(ax, memw[ds, eax + 26]);          /* mov ax, [eax+0x1a] */
            ii(0x100e_60dc, 1);  dec(eax);                             /* dec eax */
            ii(0x100e_60dd, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x100e_60e0, 3);  lea(eax, memd[ss, ebp - 32]);         /* lea eax, [ebp-0x20] */
            ii(0x100e_60e3, 5);  call(0x1007_6aac, -0x6_f63c);         /* call 0x10076aac */
            ii(0x100e_60e8, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100e_60eb, 4);  test(memb[ds, eax + 18], 0x10);       /* test byte [eax+0x12], 0x10 */
            ii(0x100e_60ef, 2);  if(jz(0x100e_6101, 0x10)) goto l_0x100e_6101;/* jz 0x100e6101 */
            ii(0x100e_60f1, 3);  mov(eax, memd[ss, ebp - 30]);         /* mov eax, [ebp-0x1e] */
            ii(0x100e_60f4, 4);  inc(memw[ss, ebp - 30]);              /* inc word [ebp-0x1e] */
            ii(0x100e_60f8, 7);  mov(memd[ss, ebp - 20], 3);           /* mov dword [ebp-0x14], 0x3 */
            ii(0x100e_60ff, 2);  jmp(0x100e_6108, 7); goto l_0x100e_6108;/* jmp 0x100e6108 */
        l_0x100e_6101:
            ii(0x100e_6101, 7);  mov(memd[ss, ebp - 20], 2);           /* mov dword [ebp-0x14], 0x2 */
        l_0x100e_6108:
            ii(0x100e_6108, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x100e_610f, 2);  jmp(0x100e_6115, 4); goto l_0x100e_6115;/* jmp 0x100e6115 */
        l_0x100e_6111:
            ii(0x100e_6111, 4);  add(memd[ss, ebp - 16], 2);           /* add dword [ebp-0x10], 0x2 */
        l_0x100e_6115:
            ii(0x100e_6115, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100e_6119, 3);  cmp(eax, 8);                          /* cmp eax, 0x8 */
            ii(0x100e_611c, 2);  if(jge(0x100e_6185, 0x67)) goto l_0x100e_6185;/* jge 0x100e6185 */
            ii(0x100e_611e, 7);  mov(memd[ss, ebp - 24], 0);           /* mov dword [ebp-0x18], 0x0 */
            ii(0x100e_6125, 2);  jmp(0x100e_612d, 6); goto l_0x100e_612d;/* jmp 0x100e612d */
        l_0x100e_6127:
            ii(0x100e_6127, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x100e_612a, 3);  inc(memd[ss, ebp - 24]);              /* inc dword [ebp-0x18] */
        l_0x100e_612d:
            ii(0x100e_612d, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x100e_6130, 4);  cmp(ax, memw[ss, ebp - 20]);          /* cmp ax, [ebp-0x14] */
            ii(0x100e_6134, 2);  if(jge(0x100e_6183, 0x4d)) goto l_0x100e_6183;/* jge 0x100e6183 */
            ii(0x100e_6136, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100e_613a, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100e_613d, 5);  mov(edx, 0x101c_5348);                /* mov edx, 0x101c5348 */
            ii(0x100e_6142, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100e_6144, 3);  lea(eax, memd[ss, ebp - 32]);         /* lea eax, [ebp-0x20] */
            ii(0x100e_6147, 5);  call(0x1008_b1a4, -0x5_afa8);         /* call 0x1008b1a4 */
            ii(0x100e_614c, 4);  movsx(eax, memb[ss, ebp - 12]);       /* movsx eax, byte [ebp-0xc] */
            ii(0x100e_6150, 1);  push(eax);                            /* push eax */
            ii(0x100e_6151, 4);  movsx(ecx, memw[ss, ebp - 30]);       /* movsx ecx, word [ebp-0x1e] */
            ii(0x100e_6155, 4);  movsx(ebx, memw[ss, ebp - 32]);       /* movsx ebx, word [ebp-0x20] */
            ii(0x100e_6159, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100e_615b, 5);  mov(al, memb[ds, 0x101c_37da]);       /* mov al, [0x101c37da] */
            ii(0x100e_6160, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x100e_6163, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_6166, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x100e_6169, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100e_616c, 5);  call(0x1007_02b9, -0x7_5eb8);         /* call 0x100702b9 */
            ii(0x100e_6171, 3);  test(ax, ax);                         /* test ax, ax */
            ii(0x100e_6174, 2);  if(jz(0x100e_6181, 0xb)) goto l_0x100e_6181;/* jz 0x100e6181 */
            ii(0x100e_6176, 4);  movsx(edx, memw[ss, ebp - 30]);       /* movsx edx, word [ebp-0x1e] */
            ii(0x100e_617a, 4);  movsx(eax, memw[ss, ebp - 32]);       /* movsx eax, word [ebp-0x20] */
            ii(0x100e_617e, 3);  call_abs(memd[ss, ebp - 4]);          /* call dword [ebp-0x4] */
        l_0x100e_6181:
            ii(0x100e_6181, 2);  jmp(0x100e_6127, -0x5c); goto l_0x100e_6127;/* jmp 0x100e6127 */
        l_0x100e_6183:
            ii(0x100e_6183, 2);  jmp(0x100e_6111, -0x74); goto l_0x100e_6111;/* jmp 0x100e6111 */
        l_0x100e_6185:
            ii(0x100e_6185, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_6187, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_6188, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_6189, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_618a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_618b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_618c, 1);  ret();                                /* ret */
        }
    }
}
