using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_99aa-648fbb09")]
        public void Method_100a_99aa()
        {
            ii(0x100a_99aa, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x100a_99af, 5);  call(Definitions.sys_check_available_stack_size, 0xb_c39e);/* call 0x10165d52 */
            ii(0x100a_99b4, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_99b5, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_99b6, 1);  push(edx);                            /* push edx */
            ii(0x100a_99b7, 1);  push(esi);                            /* push esi */
            ii(0x100a_99b8, 1);  push(edi);                            /* push edi */
            ii(0x100a_99b9, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_99ba, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_99bc, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x100a_99c2, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
        l_0x100a_99c5:
            ii(0x100a_99c5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_99c8, 3);  mov(eax, memd[ds, eax + 2]);          /* mov eax, [eax+0x2] */
            ii(0x100a_99cb, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100a_99ce, 3);  cmp(eax, 8);                          /* cmp eax, 0x8 */
            ii(0x100a_99d1, 6);  if(jge(0x100a_9ad0, 0xf9)) goto l_0x100a_9ad0;/* jge 0x100a9ad0 */
            ii(0x100a_99d7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_99da, 4);  test(memb[ds, eax + 4], 1);           /* test byte [eax+0x4], 0x1 */
            ii(0x100a_99de, 2);  if(jz(0x100a_99f8, 0x18)) goto l_0x100a_99f8;/* jz 0x100a99f8 */
            ii(0x100a_99e0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_99e3, 3);  mov(eax, memd[ds, eax + 18]);         /* mov eax, [eax+0x12] */
            ii(0x100a_99e6, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x100a_99e9, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100a_99eb, 2);  if(jz(0x100a_99f6, 9)) goto l_0x100a_99f6;/* jz 0x100a99f6 */
            ii(0x100a_99ed, 4);  mov(memb[ss, ebp - 8], 1);            /* mov byte [ebp-0x8], 0x1 */
            ii(0x100a_99f1, 5);  jmp(0x100a_9ad4, 0xde); goto l_0x100a_9ad4;/* jmp 0x100a9ad4 */
        l_0x100a_99f6:
            ii(0x100a_99f6, 2);  jmp(0x100a_9a23, 0x2b); goto l_0x100a_9a23;/* jmp 0x100a9a23 */
        l_0x100a_99f8:
            ii(0x100a_99f8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_99fb, 3);  mov(eax, memd[ds, eax + 18]);         /* mov eax, [eax+0x12] */
            ii(0x100a_99fe, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x100a_9a01, 5);  call(/* sys */ 0x1016_5df8, 0xb_c3f2);/* call 0x10165df8 */
            ii(0x100a_9a06, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100a_9a08, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_9a0b, 3);  mov(eax, memd[ds, eax + 22]);         /* mov eax, [eax+0x16] */
            ii(0x100a_9a0e, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x100a_9a11, 5);  call(/* sys */ 0x1016_5df8, 0xb_c3e2);/* call 0x10165df8 */
            ii(0x100a_9a16, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100a_9a18, 2);  if(jge(0x100a_9a23, 9)) goto l_0x100a_9a23;/* jge 0x100a9a23 */
            ii(0x100a_9a1a, 4);  mov(memb[ss, ebp - 8], 1);            /* mov byte [ebp-0x8], 0x1 */
            ii(0x100a_9a1e, 5);  jmp(0x100a_9ad4, 0xb1); goto l_0x100a_9ad4;/* jmp 0x100a9ad4 */
        l_0x100a_9a23:
            ii(0x100a_9a23, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_9a26, 4);  inc(memw[ds, eax + 4]);               /* inc word [eax+0x4] */
            ii(0x100a_9a2a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_9a2d, 3);  mov(eax, memd[ds, eax + 2]);          /* mov eax, [eax+0x2] */
            ii(0x100a_9a30, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100a_9a33, 3);  add(eax, 2);                          /* add eax, 0x2 */
            ii(0x100a_9a36, 2);  test(al, 4);                          /* test al, 0x4 */
            ii(0x100a_9a38, 2);  if(jz(0x100a_9a43, 9)) goto l_0x100a_9a43;/* jz 0x100a9a43 */
            ii(0x100a_9a3a, 7);  mov(memd[ss, ebp - 12], 0xffff_ffff); /* mov dword [ebp-0xc], 0xffffffff */
            ii(0x100a_9a41, 2);  jmp(0x100a_9a4a, 7); goto l_0x100a_9a4a;/* jmp 0x100a9a4a */
        l_0x100a_9a43:
            ii(0x100a_9a43, 7);  mov(memd[ss, ebp - 12], 1);           /* mov dword [ebp-0xc], 0x1 */
        l_0x100a_9a4a:
            ii(0x100a_9a4a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_9a4d, 4);  test(memb[ds, eax + 4], 4);           /* test byte [eax+0x4], 0x4 */
            ii(0x100a_9a51, 2);  if(jz(0x100a_9a5c, 9)) goto l_0x100a_9a5c;/* jz 0x100a9a5c */
            ii(0x100a_9a53, 7);  mov(memd[ss, ebp - 16], 0xffff_ffff); /* mov dword [ebp-0x10], 0xffffffff */
            ii(0x100a_9a5a, 2);  jmp(0x100a_9a63, 7); goto l_0x100a_9a63;/* jmp 0x100a9a63 */
        l_0x100a_9a5c:
            ii(0x100a_9a5c, 7);  mov(memd[ss, ebp - 16], 1);           /* mov dword [ebp-0x10], 0x1 */
        l_0x100a_9a63:
            ii(0x100a_9a63, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_9a66, 3);  mov(eax, memd[ds, eax + 2]);          /* mov eax, [eax+0x2] */
            ii(0x100a_9a69, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100a_9a6c, 1);  inc(eax);                             /* inc eax */
            ii(0x100a_9a6d, 2);  test(al, 2);                          /* test al, 0x2 */
            ii(0x100a_9a6f, 2);  if(jz(0x100a_9a9f, 0x2e)) goto l_0x100a_9a9f;/* jz 0x100a9a9f */
            ii(0x100a_9a71, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_9a74, 3);  add(eax, 0xc);                        /* add eax, 0xc */
            ii(0x100a_9a77, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_9a7a, 3);  mov(memd[ds, edx + 18], eax);         /* mov [edx+0x12], eax */
            ii(0x100a_9a7d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_9a80, 3);  add(eax, 0xa);                        /* add eax, 0xa */
            ii(0x100a_9a83, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_9a86, 3);  mov(memd[ds, edx + 22], eax);         /* mov [edx+0x16], eax */
            ii(0x100a_9a89, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_9a8c, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_9a8f, 4);  mov(memw[ds, edx + 26], ax);          /* mov [edx+0x1a], ax */
            ii(0x100a_9a93, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100a_9a96, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_9a99, 4);  mov(memw[ds, edx + 28], ax);          /* mov [edx+0x1c], ax */
            ii(0x100a_9a9d, 2);  jmp(0x100a_9acb, 0x2c); goto l_0x100a_9acb;/* jmp 0x100a9acb */
        l_0x100a_9a9f:
            ii(0x100a_9a9f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_9aa2, 3);  add(eax, 0xa);                        /* add eax, 0xa */
            ii(0x100a_9aa5, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_9aa8, 3);  mov(memd[ds, edx + 18], eax);         /* mov [edx+0x12], eax */
            ii(0x100a_9aab, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_9aae, 3);  add(eax, 0xc);                        /* add eax, 0xc */
            ii(0x100a_9ab1, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_9ab4, 3);  mov(memd[ds, edx + 22], eax);         /* mov [edx+0x16], eax */
            ii(0x100a_9ab7, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100a_9aba, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_9abd, 4);  mov(memw[ds, edx + 26], ax);          /* mov [edx+0x1a], ax */
            ii(0x100a_9ac1, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_9ac4, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_9ac7, 4);  mov(memw[ds, edx + 28], ax);          /* mov [edx+0x1c], ax */
        l_0x100a_9acb:
            ii(0x100a_9acb, 5);  jmp(0x100a_99c5, -0x10b); goto l_0x100a_99c5;/* jmp 0x100a99c5 */
        l_0x100a_9ad0:
            ii(0x100a_9ad0, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
        l_0x100a_9ad4:
            ii(0x100a_9ad4, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x100a_9ad7, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_9ad9, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_9ada, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_9adb, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_9adc, 1);  pop(edx);                             /* pop edx */
            ii(0x100a_9add, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_9ade, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_9adf, 1);  ret();                                /* ret */
        }
    }
}
