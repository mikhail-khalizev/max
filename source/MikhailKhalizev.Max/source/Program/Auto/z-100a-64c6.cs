using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_64c6-16ac5bb3")]
        public void Method_100a_64c6()
        {
            ii(0x100a_64c6, 5);  push(0x30);                           /* push 0x30 */
            ii(0x100a_64cb, 5);  call(Definitions.sys_check_available_stack_size, 0xb_f882);/* call 0x10165d52 */
            ii(0x100a_64d0, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_64d1, 1);  push(esi);                            /* push esi */
            ii(0x100a_64d2, 1);  push(edi);                            /* push edi */
            ii(0x100a_64d3, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_64d4, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_64d6, 6);  sub(esp, 0x1c);                       /* sub esp, 0x1c */
            ii(0x100a_64dc, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100a_64df, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100a_64e2, 3);  mov(memb[ss, ebp - 4], bl);           /* mov [ebp-0x4], bl */
            ii(0x100a_64e5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_64e8, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_64ea, 3);  mov(dl, memb[ds, eax + 38]);          /* mov dl, [eax+0x26] */
            ii(0x100a_64ed, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100a_64f0, 3);  mov(eax, memd[ds, eax + 7]);          /* mov eax, [eax+0x7] */
            ii(0x100a_64f3, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100a_64f6, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100a_64f8, 2);  if(jnz(0x100a_6509, 0xf)) goto l_0x100a_6509;/* jnz 0x100a6509 */
            ii(0x100a_64fa, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_64fd, 3);  mov(al, memb[ds, eax + 77]);          /* mov al, [eax+0x4d] */
            ii(0x100a_6500, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100a_6505, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100a_6507, 2);  if(jg(0x100a_6512, 9)) goto l_0x100a_6512;/* jg 0x100a6512 */
        l_0x100a_6509:
            ii(0x100a_6509, 4);  mov(memb[ss, ebp - 16], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x100a_650d, 5);  jmp(0x100a_65ea, 0xd8); goto l_0x100a_65ea;/* jmp 0x100a65ea */
        l_0x100a_6512:
            ii(0x100a_6512, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_6515, 4);  cmp(memb[ds, eax + 61], 0);           /* cmp byte [eax+0x3d], 0x0 */
            ii(0x100a_6519, 2);  if(jz(0x100a_6524, 9)) goto l_0x100a_6524;/* jz 0x100a6524 */
            ii(0x100a_651b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_651e, 4);  cmp(memb[ds, eax + 61], 0xc);         /* cmp byte [eax+0x3d], 0xc */
            ii(0x100a_6522, 2);  if(jnz(0x100a_6526, 2)) goto l_0x100a_6526;/* jnz 0x100a6526 */
        l_0x100a_6524:
            ii(0x100a_6524, 2);  jmp(0x100a_653a, 0x14); goto l_0x100a_653a;/* jmp 0x100a653a */
        l_0x100a_6526:
            ii(0x100a_6526, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_6529, 4);  cmp(memb[ds, eax + 61], 2);           /* cmp byte [eax+0x3d], 0x2 */
            ii(0x100a_652d, 2);  if(jnz(0x100a_6538, 9)) goto l_0x100a_6538;/* jnz 0x100a6538 */
            ii(0x100a_652f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_6532, 4);  cmp(memb[ds, eax + 62], 1);           /* cmp byte [eax+0x3e], 0x1 */
            ii(0x100a_6536, 2);  if(jz(0x100a_653a, 2)) goto l_0x100a_653a;/* jz 0x100a653a */
        l_0x100a_6538:
            ii(0x100a_6538, 2);  jmp(0x100a_653c, 2); goto l_0x100a_653c;/* jmp 0x100a653c */
        l_0x100a_653a:
            ii(0x100a_653a, 2);  jmp(0x100a_6550, 0x14); goto l_0x100a_6550;/* jmp 0x100a6550 */
        l_0x100a_653c:
            ii(0x100a_653c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_653f, 4);  cmp(memb[ds, eax + 61], 0x1b);        /* cmp byte [eax+0x3d], 0x1b */
            ii(0x100a_6543, 2);  if(jnz(0x100a_654e, 9)) goto l_0x100a_654e;/* jnz 0x100a654e */
            ii(0x100a_6545, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_6548, 4);  cmp(memb[ds, eax + 62], 1);           /* cmp byte [eax+0x3e], 0x1 */
            ii(0x100a_654c, 2);  if(jz(0x100a_6550, 2)) goto l_0x100a_6550;/* jz 0x100a6550 */
        l_0x100a_654e:
            ii(0x100a_654e, 2);  jmp(0x100a_6552, 2); goto l_0x100a_6552;/* jmp 0x100a6552 */
        l_0x100a_6550:
            ii(0x100a_6550, 2);  jmp(0x100a_6566, 0x14); goto l_0x100a_6566;/* jmp 0x100a6566 */
        l_0x100a_6552:
            ii(0x100a_6552, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_6555, 4);  cmp(memb[ds, eax + 61], 0x1e);        /* cmp byte [eax+0x3d], 0x1e */
            ii(0x100a_6559, 2);  if(jnz(0x100a_6564, 9)) goto l_0x100a_6564;/* jnz 0x100a6564 */
            ii(0x100a_655b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_655e, 4);  cmp(memb[ds, eax + 62], 1);           /* cmp byte [eax+0x3e], 0x1 */
            ii(0x100a_6562, 2);  if(jz(0x100a_6566, 2)) goto l_0x100a_6566;/* jz 0x100a6566 */
        l_0x100a_6564:
            ii(0x100a_6564, 2);  jmp(0x100a_6568, 2); goto l_0x100a_6568;/* jmp 0x100a6568 */
        l_0x100a_6566:
            ii(0x100a_6566, 2);  jmp(0x100a_6571, 9); goto l_0x100a_6571;/* jmp 0x100a6571 */
        l_0x100a_6568:
            ii(0x100a_6568, 4);  mov(memb[ss, ebp - 16], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x100a_656c, 5);  jmp(0x100a_65ea, 0x79); goto l_0x100a_65ea;/* jmp 0x100a65ea */
        l_0x100a_6571:
            ii(0x100a_6571, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_6574, 5);  call(0x1015_26ac, 0xa_c133);          /* call 0x101526ac */
            ii(0x100a_6579, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100a_657b, 2);  if(jnz(0x100a_6583, 6)) goto l_0x100a_6583;/* jnz 0x100a6583 */
            ii(0x100a_657d, 4);  mov(memb[ss, ebp - 16], 1);           /* mov byte [ebp-0x10], 0x1 */
            ii(0x100a_6581, 2);  jmp(0x100a_65ea, 0x67); goto l_0x100a_65ea;/* jmp 0x100a65ea */
        l_0x100a_6583:
            ii(0x100a_6583, 4);  cmp(memb[ss, ebp - 4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100a_6587, 2);  if(jz(0x100a_658f, 6)) goto l_0x100a_658f;/* jz 0x100a658f */
            ii(0x100a_6589, 4);  mov(memb[ss, ebp - 16], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x100a_658d, 2);  jmp(0x100a_65ea, 0x5b); goto l_0x100a_65ea;/* jmp 0x100a65ea */
        l_0x100a_658f:
            ii(0x100a_658f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_6592, 5);  call(0x1015_26ac, 0xa_c115);          /* call 0x101526ac */
            ii(0x100a_6597, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100a_659a, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100a_659d, 3);  mov(ebx, memd[ds, eax + 2]);          /* mov ebx, [eax+0x2] */
            ii(0x100a_65a0, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_65a3, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100a_65a6, 3);  call_abs(memd[ds, ebx + 4]);          /* call dword [ebx+0x4] */
            ii(0x100a_65a9, 2);  test(al, al);                         /* test al, al */
            ii(0x100a_65ab, 2);  if(jnz(0x100a_65b3, 6)) goto l_0x100a_65b3;/* jnz 0x100a65b3 */
            ii(0x100a_65ad, 4);  mov(memb[ss, ebp - 16], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x100a_65b1, 2);  jmp(0x100a_65ea, 0x37); goto l_0x100a_65ea;/* jmp 0x100a65ea */
        l_0x100a_65b3:
            ii(0x100a_65b3, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100a_65b6, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100a_65b9, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100a_65bc, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x100a_65bf, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100a_65c2, 3);  call_abs(memd[ds, edx + 20]);         /* call dword [edx+0x14] */
            ii(0x100a_65c5, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x100a_65c8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_65cb, 5);  call(0x1015_26ac, 0xa_c0dc);          /* call 0x101526ac */
            ii(0x100a_65d0, 5);  call(0x100a_2bc4, -0x3a11);           /* call 0x100a2bc4 */
            ii(0x100a_65d5, 1);  cwde();                               /* cwde */
            ii(0x100a_65d6, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100a_65d8, 2);  if(jle(0x100a_65e0, 6)) goto l_0x100a_65e0;/* jle 0x100a65e0 */
            ii(0x100a_65da, 4);  mov(memb[ss, ebp - 24], 1);           /* mov byte [ebp-0x18], 0x1 */
            ii(0x100a_65de, 2);  jmp(0x100a_65e4, 4); goto l_0x100a_65e4;/* jmp 0x100a65e4 */
        l_0x100a_65e0:
            ii(0x100a_65e0, 4);  mov(memb[ss, ebp - 24], 0);           /* mov byte [ebp-0x18], 0x0 */
        l_0x100a_65e4:
            ii(0x100a_65e4, 3);  mov(al, memb[ss, ebp - 24]);          /* mov al, [ebp-0x18] */
            ii(0x100a_65e7, 3);  mov(memb[ss, ebp - 16], al);          /* mov [ebp-0x10], al */
        l_0x100a_65ea:
            ii(0x100a_65ea, 3);  mov(al, memb[ss, ebp - 16]);          /* mov al, [ebp-0x10] */
            ii(0x100a_65ed, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_65ef, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_65f0, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_65f1, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_65f2, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_65f3, 1);  ret();                                /* ret */
        }
    }
}
