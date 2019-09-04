using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_58d2-b2d5760b")]
        public void Method_1011_58d2()
        {
            ii(0x1011_58d2, 5);  push(0x3c);                           /* push 0x3c */
            ii(0x1011_58d7, 5);  call(Definitions.sys_check_available_stack_size, 0x5_0476);/* call 0x10165d52 */
            ii(0x1011_58dc, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_58dd, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_58de, 1);  push(esi);                            /* push esi */
            ii(0x1011_58df, 1);  push(edi);                            /* push edi */
            ii(0x1011_58e0, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_58e1, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_58e3, 6);  sub(esp, 0x24);                       /* sub esp, 0x24 */
            ii(0x1011_58e9, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_58ec, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1011_58ef, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1011_58f6, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
            ii(0x1011_58fd, 7);  mov(memd[ss, ebp - 28], 0x101c_4e64); /* mov dword [ebp-0x1c], 0x101c4e64 */
            ii(0x1011_5904, 4);  mov(memb[ss, ebp - 19], 0);           /* mov byte [ebp-0x13], 0x0 */
        l_0x1011_5908:
            ii(0x1011_5908, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1011_590c, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1011_590f, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x1011_5911, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1011_5916, 3);  cmp(eax, 0xa);                        /* cmp eax, 0xa */
            ii(0x1011_5919, 2);  if(jnz(0x1011_5982, 0x67)) goto l_0x1011_5982;/* jnz 0x10115982 */
            ii(0x1011_591b, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1011_591f, 5);  mov(eax, memd[ds, 0x101c_52b0]);      /* mov eax, [0x101c52b0] */
            ii(0x1011_5924, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1011_5927, 5);  call(0x1007_6e7c, -0x9_eab0);         /* call 0x10076e7c */
            ii(0x1011_592c, 6);  mov(memw[ds, 0x101c_52b2], ax);       /* mov [0x101c52b2], ax */
            ii(0x1011_5932, 8);  add(memw[ds, 0x101c_52b4], 0xa);      /* add word [0x101c52b4], 0xa */
            ii(0x1011_593a, 6);  mov(ax, memw[ds, 0x101c_52b0]);       /* mov ax, [0x101c52b0] */
            ii(0x1011_5940, 7);  inc(memw[ds, 0x101c_52b0]);           /* inc word [0x101c52b0] */
            ii(0x1011_5947, 1);  cwde();                               /* cwde */
            ii(0x1011_5948, 7);  mov(memb[ds, eax + 0x101c_4e64], 0x20);/* mov byte [eax+0x101c4e64], 0x20 */
            ii(0x1011_594f, 6);  mov(ax, memw[ds, 0x101c_52b0]);       /* mov ax, [0x101c52b0] */
            ii(0x1011_5955, 7);  inc(memw[ds, 0x101c_52b0]);           /* inc word [0x101c52b0] */
            ii(0x1011_595c, 1);  cwde();                               /* cwde */
            ii(0x1011_595d, 7);  mov(memb[ds, eax + 0x101c_4e64], 0);  /* mov byte [eax+0x101c4e64], 0x0 */
            ii(0x1011_5964, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
            ii(0x1011_596b, 5);  mov(eax, memd[ds, 0x101c_52ae]);      /* mov eax, [0x101c52ae] */
            ii(0x1011_5970, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1011_5973, 5);  mov(edx, 0x101c_4e64);                /* mov edx, 0x101c4e64 */
            ii(0x1011_5978, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1011_597a, 3);  mov(memd[ss, ebp - 28], edx);         /* mov [ebp-0x1c], edx */
            ii(0x1011_597d, 5);  jmp(0x1011_5a6f, 0xed); goto l_0x1011_5a6f;/* jmp 0x10115a6f */
        l_0x1011_5982:
            ii(0x1011_5982, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1011_5986, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1011_5989, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x1011_598b, 3);  mov(memb[ss, ebp - 20], al);          /* mov [ebp-0x14], al */
            ii(0x1011_598e, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_5991, 6);  call_abs(memd[ds, 0x101b_ddf4]);      /* call dword [0x101bddf4] */
            ii(0x1011_5997, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1011_599a, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1011_599e, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1011_59a2, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1011_59a4, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1011_59a8, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1011_59aa, 2);  if(jle(0x1011_5a1b, 0x6f)) goto l_0x1011_5a1b;/* jle 0x10115a1b */
            ii(0x1011_59ac, 5);  mov(eax, memd[ds, 0x101c_52ae]);      /* mov eax, [0x101c52ae] */
            ii(0x1011_59b1, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1011_59b4, 5);  mov(edx, 0x101c_4e64);                /* mov edx, 0x101c4e64 */
            ii(0x1011_59b9, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1011_59bb, 3);  mov(memd[ss, ebp - 32], edx);         /* mov [ebp-0x20], edx */
            ii(0x1011_59be, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1011_59c1, 3);  dec(memd[ss, ebp - 32]);              /* dec dword [ebp-0x20] */
            ii(0x1011_59c4, 3);  mov(memb[ds, eax], 0);                /* mov byte [eax], 0x0 */
        l_0x1011_59c7:
            ii(0x1011_59c7, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1011_59ca, 3);  cmp(memb[ds, eax], 0x20);             /* cmp byte [eax], 0x20 */
            ii(0x1011_59cd, 2);  if(jz(0x1011_59d7, 8)) goto l_0x1011_59d7;/* jz 0x101159d7 */
            ii(0x1011_59cf, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1011_59d2, 3);  dec(memd[ss, ebp - 32]);              /* dec dword [ebp-0x20] */
            ii(0x1011_59d5, 2);  jmp(0x1011_59c7, -0x10); goto l_0x1011_59c7;/* jmp 0x101159c7 */
        l_0x1011_59d7:
            ii(0x1011_59d7, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1011_59da, 3);  mov(memb[ds, eax], 0);                /* mov byte [eax], 0x0 */
            ii(0x1011_59dd, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1011_59e0, 6);  call_abs(memd[ds, 0x101b_ddf4]);      /* call dword [0x101bddf4] */
            ii(0x1011_59e6, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1011_59e9, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1011_59ed, 5);  mov(eax, memd[ds, 0x101c_52b0]);      /* mov eax, [0x101c52b0] */
            ii(0x1011_59f2, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1011_59f5, 5);  call(0x1007_6e7c, -0x9_eb7e);         /* call 0x10076e7c */
            ii(0x1011_59fa, 6);  mov(memw[ds, 0x101c_52b2], ax);       /* mov [0x101c52b2], ax */
            ii(0x1011_5a00, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1011_5a03, 1);  inc(eax);                             /* inc eax */
            ii(0x1011_5a04, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1011_5a07, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1011_5a0a, 6);  call_abs(memd[ds, 0x101b_ddf4]);      /* call dword [0x101bddf4] */
            ii(0x1011_5a10, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1011_5a13, 8);  add(memw[ds, 0x101c_52b4], 0xa);      /* add word [0x101c52b4], 0xa */
        l_0x1011_5a1b:
            ii(0x1011_5a1b, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1011_5a1e, 3);  add(memd[ss, ebp - 12], eax);         /* add [ebp-0xc], eax */
            ii(0x1011_5a21, 5);  mov(eax, memd[ds, 0x101c_52ae]);      /* mov eax, [0x101c52ae] */
            ii(0x1011_5a26, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1011_5a29, 5);  cmp(eax, 0x320);                      /* cmp eax, 0x320 */
            ii(0x1011_5a2e, 2);  if(jae(0x1011_5a39, 9)) goto l_0x1011_5a39;/* jae 0x10115a39 */
            ii(0x1011_5a30, 7);  mov(memd[ss, ebp - 36], 0);           /* mov dword [ebp-0x24], 0x0 */
            ii(0x1011_5a37, 2);  jmp(0x1011_5a52, 0x19); goto l_0x1011_5a52;/* jmp 0x10115a52 */
        l_0x1011_5a39:
            ii(0x1011_5a39, 5);  mov(ecx, 0x71);                       /* mov ecx, 0x71 */
            ii(0x1011_5a3e, 5);  mov(ebx, StringDefinitions.MssgsmgrCpp);/* mov ebx, 0x101a7ac4 */
            ii(0x1011_5a43, 5);  mov(edx, StringDefinitions.MssglenLessSizeofMssgbfr);/* mov edx, 0x101a7ad1 */
            ii(0x1011_5a48, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1011_5a4a, 5);  call(Definitions.sys_assert, 0x5_0343);/* call 0x10165d92 */
            ii(0x1011_5a4f, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
        l_0x1011_5a52:
            ii(0x1011_5a52, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1011_5a56, 3);  add(edx, memd[ss, ebp - 8]);          /* add edx, [ebp-0x8] */
            ii(0x1011_5a59, 6);  mov(ax, memw[ds, 0x101c_52b0]);       /* mov ax, [0x101c52b0] */
            ii(0x1011_5a5f, 7);  inc(memw[ds, 0x101c_52b0]);           /* inc word [0x101c52b0] */
            ii(0x1011_5a66, 1);  cwde();                               /* cwde */
            ii(0x1011_5a67, 2);  mov(dl, memb[ds, edx]);               /* mov dl, [edx] */
            ii(0x1011_5a69, 6);  mov(memb[ds, eax + 0x101c_4e64], dl); /* mov [eax+0x101c4e64], dl */
        l_0x1011_5a6f:
            ii(0x1011_5a6f, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_5a72, 3);  inc(memd[ss, ebp - 16]);              /* inc dword [ebp-0x10] */
            ii(0x1011_5a75, 1);  cwde();                               /* cwde */
            ii(0x1011_5a76, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1011_5a79, 3);  cmp(memb[ds, eax], 0);                /* cmp byte [eax], 0x0 */
            ii(0x1011_5a7c, 6);  if(jnz(0x1011_5908, -0x17a)) goto l_0x1011_5908;/* jnz 0x10115908 */
            ii(0x1011_5a82, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1011_5a86, 5);  mov(eax, memd[ds, 0x101c_52b0]);      /* mov eax, [0x101c52b0] */
            ii(0x1011_5a8b, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1011_5a8e, 5);  call(0x1007_6e7c, -0x9_ec17);         /* call 0x10076e7c */
            ii(0x1011_5a93, 6);  mov(memw[ds, 0x101c_52b2], ax);       /* mov [0x101c52b2], ax */
            ii(0x1011_5a99, 8);  add(memw[ds, 0x101c_52b4], 0xa);      /* add word [0x101c52b4], 0xa */
            ii(0x1011_5aa1, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_5aa3, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_5aa4, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_5aa5, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_5aa6, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_5aa7, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_5aa8, 1);  ret();                                /* ret */
        }
    }
}
