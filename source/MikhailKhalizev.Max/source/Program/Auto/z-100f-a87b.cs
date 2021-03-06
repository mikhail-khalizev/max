using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_a87b-723f1d47")]
        public void Method_100f_a87b()
        {
            ii(0x100f_a87b, 5);  push(0x4c);                           /* push 0x4c */
            ii(0x100f_a880, 5);  call(Definitions.sys_check_available_stack_size, 0x6_b4cd);/* call 0x10165d52 */
            ii(0x100f_a885, 1);  push(esi);                            /* push esi */
            ii(0x100f_a886, 1);  push(edi);                            /* push edi */
            ii(0x100f_a887, 1);  push(ebp);                            /* push ebp */
            ii(0x100f_a888, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100f_a88a, 6);  sub(esp, 0x2c);                       /* sub esp, 0x2c */
            ii(0x100f_a890, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100f_a893, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x100f_a896, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x100f_a899, 3);  mov(memd[ss, ebp - 4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x100f_a89c, 5);  cmp(memw[ss, ebp - 8], 0);            /* cmp word [ebp-0x8], 0x0 */
            ii(0x100f_a8a1, 2);  if(jz(0x100f_a8ac, 9)) goto l_0x100f_a8ac;/* jz 0x100fa8ac */
            ii(0x100f_a8a3, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_a8a6, 4);  cmp(memb[ds, eax + 61], 0x1a);        /* cmp byte [eax+0x3d], 0x1a */
            ii(0x100f_a8aa, 2);  if(jnz(0x100f_a8b1, 5)) goto l_0x100f_a8b1;/* jnz 0x100fa8b1 */
        l_0x100f_a8ac:
            ii(0x100f_a8ac, 5);  jmp(0x100f_a9f7, 0x146); goto l_0x100f_a9f7;/* jmp 0x100fa9f7 */
        l_0x100f_a8b1:
            ii(0x100f_a8b1, 4);  shl(memd[ss, ebp - 8], 6);            /* shl dword [ebp-0x8], 0x6 */
            ii(0x100f_a8b5, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100f_a8b9, 3);  shl(edx, 0x10);                       /* shl edx, 0x10 */
            ii(0x100f_a8bc, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100f_a8be, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100f_a8c1, 6);  idiv(memd[ds, 0x101c_38c4]);          /* idiv dword [0x101c38c4] */
            ii(0x100f_a8c7, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100f_a8ca, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_a8ce, 3);  cmp(eax, 4);                          /* cmp eax, 0x4 */
            ii(0x100f_a8d1, 2);  if(jnz(0x100f_a8d9, 6)) goto l_0x100f_a8d9;/* jnz 0x100fa8d9 */
            ii(0x100f_a8d3, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100f_a8d6, 3);  inc(memd[ss, ebp - 20]);              /* inc dword [ebp-0x14] */
        l_0x100f_a8d9:
            ii(0x100f_a8d9, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_a8dc, 4);  test(memb[ds, eax + 18], 0x10);       /* test byte [eax+0x12], 0x10 */
            ii(0x100f_a8e0, 2);  if(jz(0x100f_a8eb, 9)) goto l_0x100f_a8eb;/* jz 0x100fa8eb */
            ii(0x100f_a8e2, 7);  mov(memd[ss, ebp - 24], 1);           /* mov dword [ebp-0x18], 0x1 */
            ii(0x100f_a8e9, 2);  jmp(0x100f_a8f2, 7); goto l_0x100f_a8f2;/* jmp 0x100fa8f2 */
        l_0x100f_a8eb:
            ii(0x100f_a8eb, 7);  mov(memd[ss, ebp - 24], 2);           /* mov dword [ebp-0x18], 0x2 */
        l_0x100f_a8f2:
            ii(0x100f_a8f2, 5);  mov(eax, 0x40);                       /* mov eax, 0x40 */
            ii(0x100f_a8f7, 5);  mov(edx, 0x40);                       /* mov edx, 0x40 */
            ii(0x100f_a8fc, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100f_a8ff, 3);  idiv(memd[ss, ebp - 24]);             /* idiv dword [ebp-0x18] */
            ii(0x100f_a902, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100f_a904, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_a907, 3);  mov(eax, memd[ds, eax + 24]);         /* mov eax, [eax+0x18] */
            ii(0x100f_a90a, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100f_a90d, 3);  shl(eax, 6);                          /* shl eax, 0x6 */
            ii(0x100f_a910, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100f_a912, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x100f_a915, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_a918, 4);  test(memb[ds, eax + 18], 0x10);       /* test byte [eax+0x12], 0x10 */
            ii(0x100f_a91c, 2);  if(jz(0x100f_a927, 9)) goto l_0x100f_a927;/* jz 0x100fa927 */
            ii(0x100f_a91e, 7);  mov(memd[ss, ebp - 44], 1);           /* mov dword [ebp-0x2c], 0x1 */
            ii(0x100f_a925, 2);  jmp(0x100f_a92e, 7); goto l_0x100f_a92e;/* jmp 0x100fa92e */
        l_0x100f_a927:
            ii(0x100f_a927, 7);  mov(memd[ss, ebp - 44], 2);           /* mov dword [ebp-0x2c], 0x2 */
        l_0x100f_a92e:
            ii(0x100f_a92e, 5);  mov(eax, 0x40);                       /* mov eax, 0x40 */
            ii(0x100f_a933, 5);  mov(edx, 0x40);                       /* mov edx, 0x40 */
            ii(0x100f_a938, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100f_a93b, 3);  idiv(memd[ss, ebp - 44]);             /* idiv dword [ebp-0x2c] */
            ii(0x100f_a93e, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100f_a941, 3);  mov(edx, memd[ds, edx + 26]);         /* mov edx, [edx+0x1a] */
            ii(0x100f_a944, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100f_a947, 3);  shl(edx, 6);                          /* shl edx, 0x6 */
            ii(0x100f_a94a, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100f_a94c, 3);  mov(memd[ss, ebp - 36], edx);         /* mov [ebp-0x24], edx */
            ii(0x100f_a94f, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_a951, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x100f_a954, 1);  push(eax);                            /* push eax */
            ii(0x100f_a955, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x100f_a959, 1);  push(eax);                            /* push eax */
            ii(0x100f_a95a, 3);  mov(edx, memd[ss, ebp - 36]);         /* mov edx, [ebp-0x24] */
            ii(0x100f_a95d, 3);  shl(edx, 0x10);                       /* shl edx, 0x10 */
            ii(0x100f_a960, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100f_a962, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100f_a965, 6);  idiv(memd[ds, 0x101c_38c4]);          /* idiv dword [0x101c38c4] */
            ii(0x100f_a96b, 6);  mov(edx, memd[ds, 0x101c_38fc]);      /* mov edx, [0x101c38fc] */
            ii(0x100f_a971, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100f_a974, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x100f_a976, 1);  cwde();                               /* cwde */
            ii(0x100f_a977, 1);  push(eax);                            /* push eax */
            ii(0x100f_a978, 3);  mov(edx, memd[ss, ebp - 40]);         /* mov edx, [ebp-0x28] */
            ii(0x100f_a97b, 3);  shl(edx, 0x10);                       /* shl edx, 0x10 */
            ii(0x100f_a97e, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100f_a980, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100f_a983, 6);  idiv(memd[ds, 0x101c_38c4]);          /* idiv dword [0x101c38c4] */
            ii(0x100f_a989, 6);  mov(edx, memd[ds, 0x101c_38fa]);      /* mov edx, [0x101c38fa] */
            ii(0x100f_a98f, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100f_a992, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x100f_a994, 1);  cwde();                               /* cwde */
            ii(0x100f_a995, 1);  push(eax);                            /* push eax */
            ii(0x100f_a996, 6);  mov(ecx, memd[ds, 0x101b_8748]);      /* mov ecx, [0x101b8748] */
            ii(0x100f_a99c, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x100f_a99f, 6);  mov(ebx, memd[ds, 0x101b_8746]);      /* mov ebx, [0x101b8746] */
            ii(0x100f_a9a5, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x100f_a9a8, 5);  mov(edx, 0x280);                      /* mov edx, 0x280 */
            ii(0x100f_a9ad, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100f_a9b0, 3);  mov(eax, memd[ds, eax + 22]);         /* mov eax, [eax+0x16] */
            ii(0x100f_a9b3, 5);  call(0x100d_6144, -0x2_4874);         /* call 0x100d6144 */
            ii(0x100f_a9b8, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x100f_a9bc, 7);  imul(eax, memd[ds, 0x101c_38c4]);     /* imul eax, [0x101c38c4] */
            ii(0x100f_a9c3, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100f_a9c6, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100f_a9c9, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100f_a9cd, 3);  mov(edx, memd[ss, ebp - 40]);         /* mov edx, [ebp-0x28] */
            ii(0x100f_a9d0, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100f_a9d2, 3);  mov(memd[ss, ebp - 32], edx);         /* mov [ebp-0x20], edx */
            ii(0x100f_a9d5, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100f_a9d9, 3);  mov(edx, memd[ss, ebp - 36]);         /* mov edx, [ebp-0x24] */
            ii(0x100f_a9dc, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100f_a9de, 3);  mov(memd[ss, ebp - 28], edx);         /* mov [ebp-0x1c], edx */
            ii(0x100f_a9e1, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100f_a9e5, 3);  sub(memd[ss, ebp - 40], eax);         /* sub [ebp-0x28], eax */
            ii(0x100f_a9e8, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100f_a9ec, 3);  sub(memd[ss, ebp - 36], eax);         /* sub [ebp-0x24], eax */
            ii(0x100f_a9ef, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x100f_a9f2, 5);  call(0x100f_f562, 0x4b6b);            /* call 0x100ff562 */
        l_0x100f_a9f7:
            ii(0x100f_a9f7, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100f_a9f9, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100f_a9fa, 1);  pop(edi);                             /* pop edi */
            ii(0x100f_a9fb, 1);  pop(esi);                             /* pop esi */
            ii(0x100f_a9fc, 1);  ret();                                /* ret */
        }
    }
}
