using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_e55a-23e46e5c")]
        public void Method_1008_e55a()
        {
            ii(0x1008_e55a, 5);  push(0x40);                           /* push 0x40 */
            ii(0x1008_e55f, 5);  call(Definitions.sys_check_available_stack_size, 0xd_77ee);/* call 0x10165d52 */
            ii(0x1008_e564, 1);  push(esi);                            /* push esi */
            ii(0x1008_e565, 1);  push(edi);                            /* push edi */
            ii(0x1008_e566, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_e567, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_e569, 6);  sub(esp, 0x30);                       /* sub esp, 0x30 */
            ii(0x1008_e56f, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1008_e572, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x1008_e575, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1008_e578, 3);  mov(memd[ss, ebp - 4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x1008_e57b, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x1008_e57e, 5);  call(Definitions.my_ctor_0x101b_4184, -0x1_7a93);/* call 0x10076af0 */
            ii(0x1008_e583, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x1008_e586, 5);  call(Definitions.my_ctor_0x101b_4184, -0x1_7a9b);/* call 0x10076af0 */
            ii(0x1008_e58b, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1008_e58e, 5);  call(Definitions.my_ctor_0x101b_4184, -0x1_7aa3);/* call 0x10076af0 */
            ii(0x1008_e593, 4);  mov(memb[ss, ebp - 24], 0);           /* mov byte [ebp-0x18], 0x0 */
            ii(0x1008_e597, 7);  mov(memd[ss, ebp - 32], 0);           /* mov dword [ebp-0x20], 0x0 */
            ii(0x1008_e59e, 2);  jmp(0x1008_e5a4, 4); goto l_0x1008_e5a4;/* jmp 0x1008e5a4 */
        l_0x1008_e5a0:
            ii(0x1008_e5a0, 4);  add(memd[ss, ebp - 32], 2);           /* add dword [ebp-0x20], 0x2 */
        l_0x1008_e5a4:
            ii(0x1008_e5a4, 4);  movsx(eax, memw[ss, ebp - 32]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1008_e5a8, 3);  cmp(eax, 8);                          /* cmp eax, 0x8 */
            ii(0x1008_e5ab, 6);  if(jge(0x1008_e7cf, 0x21e)) goto l_0x1008_e7cf;/* jge 0x1008e7cf */
            ii(0x1008_e5b1, 7);  mov(memd[ss, ebp - 36], 0);           /* mov dword [ebp-0x24], 0x0 */
            ii(0x1008_e5b8, 4);  mov(memb[ss, ebp - 20], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x1008_e5bc, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1008_e5bf, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x1008_e5c2, 5);  call(0x1008_8b44, -0x5a83);           /* call 0x10088b44 */
            ii(0x1008_e5c7, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1008_e5ca, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x1008_e5cd, 5);  call(0x1008_8b44, -0x5a8e);           /* call 0x10088b44 */
            ii(0x1008_e5d2, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1008_e5d5, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1008_e5d8, 5);  call(0x1008_8b44, -0x5a99);           /* call 0x10088b44 */
            ii(0x1008_e5dd, 4);  movsx(eax, memw[ss, ebp - 32]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1008_e5e1, 3);  add(eax, 2);                          /* add eax, 0x2 */
            ii(0x1008_e5e4, 3);  and(eax, 7);                          /* and eax, 0x7 */
            ii(0x1008_e5e7, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1008_e5ea, 5);  mov(edx, 0x101c_5348);                /* mov edx, 0x101c5348 */
            ii(0x1008_e5ef, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1008_e5f1, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x1008_e5f4, 5);  call(0x1008_b1a4, -0x3455);           /* call 0x1008b1a4 */
            ii(0x1008_e5f9, 4);  movsx(eax, memw[ss, ebp - 32]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1008_e5fd, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1008_e600, 3);  and(eax, 7);                          /* and eax, 0x7 */
            ii(0x1008_e603, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1008_e606, 5);  mov(edx, 0x101c_5348);                /* mov edx, 0x101c5348 */
            ii(0x1008_e60b, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1008_e60d, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1008_e610, 5);  call(0x1008_b1a4, -0x3471);           /* call 0x1008b1a4 */
            ii(0x1008_e615, 4);  movsx(eax, memw[ss, ebp - 44]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1008_e619, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_e61b, 2);  if(jl(0x1008_e629, 0xc)) goto l_0x1008_e629;/* jl 0x1008e629 */
            ii(0x1008_e61d, 3);  mov(eax, memd[ss, ebp - 44]);         /* mov eax, [ebp-0x2c] */
            ii(0x1008_e620, 7);  cmp(ax, memw[ds, 0x101c_8172]);       /* cmp ax, [0x101c8172] */
            ii(0x1008_e627, 2);  if(jl(0x1008_e62b, 2)) goto l_0x1008_e62b;/* jl 0x1008e62b */
        l_0x1008_e629:
            ii(0x1008_e629, 2);  jmp(0x1008_e633, 8); goto l_0x1008_e633;/* jmp 0x1008e633 */
        l_0x1008_e62b:
            ii(0x1008_e62b, 4);  movsx(eax, memw[ss, ebp - 42]);       /* movsx eax, word [ebp-0x2a] */
            ii(0x1008_e62f, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_e631, 2);  if(jge(0x1008_e635, 2)) goto l_0x1008_e635;/* jge 0x1008e635 */
        l_0x1008_e633:
            ii(0x1008_e633, 2);  jmp(0x1008_e641, 0xc); goto l_0x1008_e641;/* jmp 0x1008e641 */
        l_0x1008_e635:
            ii(0x1008_e635, 3);  mov(eax, memd[ss, ebp - 42]);         /* mov eax, [ebp-0x2a] */
            ii(0x1008_e638, 7);  cmp(ax, memw[ds, 0x101c_8174]);       /* cmp ax, [0x101c8174] */
            ii(0x1008_e63f, 2);  if(jl(0x1008_e64c, 0xb)) goto l_0x1008_e64c;/* jl 0x1008e64c */
        l_0x1008_e641:
            ii(0x1008_e641, 3);  lea(edx, memd[ss, ebp - 40]);         /* lea edx, [ebp-0x28] */
            ii(0x1008_e644, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x1008_e647, 5);  call(0x1008_8b44, -0x5b08);           /* call 0x10088b44 */
        l_0x1008_e64c:
            ii(0x1008_e64c, 4);  movsx(eax, memw[ss, ebp - 48]);       /* movsx eax, word [ebp-0x30] */
            ii(0x1008_e650, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_e652, 2);  if(jl(0x1008_e660, 0xc)) goto l_0x1008_e660;/* jl 0x1008e660 */
            ii(0x1008_e654, 3);  mov(eax, memd[ss, ebp - 48]);         /* mov eax, [ebp-0x30] */
            ii(0x1008_e657, 7);  cmp(ax, memw[ds, 0x101c_8172]);       /* cmp ax, [0x101c8172] */
            ii(0x1008_e65e, 2);  if(jl(0x1008_e662, 2)) goto l_0x1008_e662;/* jl 0x1008e662 */
        l_0x1008_e660:
            ii(0x1008_e660, 2);  jmp(0x1008_e66a, 8); goto l_0x1008_e66a;/* jmp 0x1008e66a */
        l_0x1008_e662:
            ii(0x1008_e662, 4);  movsx(eax, memw[ss, ebp - 46]);       /* movsx eax, word [ebp-0x2e] */
            ii(0x1008_e666, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_e668, 2);  if(jge(0x1008_e66c, 2)) goto l_0x1008_e66c;/* jge 0x1008e66c */
        l_0x1008_e66a:
            ii(0x1008_e66a, 2);  jmp(0x1008_e678, 0xc); goto l_0x1008_e678;/* jmp 0x1008e678 */
        l_0x1008_e66c:
            ii(0x1008_e66c, 3);  mov(eax, memd[ss, ebp - 46]);         /* mov eax, [ebp-0x2e] */
            ii(0x1008_e66f, 7);  cmp(ax, memw[ds, 0x101c_8174]);       /* cmp ax, [0x101c8174] */
            ii(0x1008_e676, 2);  if(jl(0x1008_e683, 0xb)) goto l_0x1008_e683;/* jl 0x1008e683 */
        l_0x1008_e678:
            ii(0x1008_e678, 3);  lea(edx, memd[ss, ebp - 40]);         /* lea edx, [ebp-0x28] */
            ii(0x1008_e67b, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1008_e67e, 5);  call(0x1008_8b44, -0x5b3f);           /* call 0x10088b44 */
        l_0x1008_e683:
            ii(0x1008_e683, 4);  movsx(eax, memw[ss, ebp - 40]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1008_e687, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_e689, 2);  if(jl(0x1008_e697, 0xc)) goto l_0x1008_e697;/* jl 0x1008e697 */
            ii(0x1008_e68b, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x1008_e68e, 7);  cmp(ax, memw[ds, 0x101c_8172]);       /* cmp ax, [0x101c8172] */
            ii(0x1008_e695, 2);  if(jl(0x1008_e699, 2)) goto l_0x1008_e699;/* jl 0x1008e699 */
        l_0x1008_e697:
            ii(0x1008_e697, 2);  jmp(0x1008_e6a1, 8); goto l_0x1008_e6a1;/* jmp 0x1008e6a1 */
        l_0x1008_e699:
            ii(0x1008_e699, 4);  movsx(eax, memw[ss, ebp - 38]);       /* movsx eax, word [ebp-0x26] */
            ii(0x1008_e69d, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_e69f, 2);  if(jge(0x1008_e6a3, 2)) goto l_0x1008_e6a3;/* jge 0x1008e6a3 */
        l_0x1008_e6a1:
            ii(0x1008_e6a1, 2);  jmp(0x1008_e6af, 0xc); goto l_0x1008_e6af;/* jmp 0x1008e6af */
        l_0x1008_e6a3:
            ii(0x1008_e6a3, 3);  mov(eax, memd[ss, ebp - 38]);         /* mov eax, [ebp-0x26] */
            ii(0x1008_e6a6, 7);  cmp(ax, memw[ds, 0x101c_8174]);       /* cmp ax, [0x101c8174] */
            ii(0x1008_e6ad, 2);  if(jl(0x1008_e6b1, 2)) goto l_0x1008_e6b1;/* jl 0x1008e6b1 */
        l_0x1008_e6af:
            ii(0x1008_e6af, 2);  jmp(0x1008_e6bc, 0xb); goto l_0x1008_e6bc;/* jmp 0x1008e6bc */
        l_0x1008_e6b1:
            ii(0x1008_e6b1, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1008_e6b4, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_e6b7, 3);  cmp(ax, memw[ds, edx]);               /* cmp ax, [edx] */
            ii(0x1008_e6ba, 2);  if(jl(0x1008_e6c1, 5)) goto l_0x1008_e6c1;/* jl 0x1008e6c1 */
        l_0x1008_e6bc:
            ii(0x1008_e6bc, 5);  jmp(0x1008_e7ae, 0xed); goto l_0x1008_e7ae;/* jmp 0x1008e7ae */
        l_0x1008_e6c1:
            ii(0x1008_e6c1, 4);  movsx(eax, memw[ss, ebp - 40]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1008_e6c5, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1008_e6c8, 3);  add(eax, memd[ss, ebp - 16]);         /* add eax, [ebp-0x10] */
            ii(0x1008_e6cb, 4);  movsx(edx, memw[ss, ebp - 38]);       /* movsx edx, word [ebp-0x26] */
            ii(0x1008_e6cf, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1008_e6d1, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1008_e6d3, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_e6d5, 2);  mov(dl, memb[ds, eax]);               /* mov dl, [eax] */
            ii(0x1008_e6d7, 4);  movsx(eax, memw[ss, ebp + 16]);       /* movsx eax, word [ebp+0x10] */
            ii(0x1008_e6db, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1008_e6dd, 2);  if(jz(0x1008_e6fd, 0x1e)) goto l_0x1008_e6fd;/* jz 0x1008e6fd */
            ii(0x1008_e6df, 4);  movsx(eax, memw[ss, ebp - 44]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1008_e6e3, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1008_e6e6, 3);  add(eax, memd[ss, ebp - 16]);         /* add eax, [ebp-0x10] */
            ii(0x1008_e6e9, 4);  movsx(edx, memw[ss, ebp - 42]);       /* movsx edx, word [ebp-0x2a] */
            ii(0x1008_e6ed, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1008_e6ef, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1008_e6f1, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_e6f3, 2);  mov(dl, memb[ds, eax]);               /* mov dl, [eax] */
            ii(0x1008_e6f5, 4);  movsx(eax, memw[ss, ebp + 16]);       /* movsx eax, word [ebp+0x10] */
            ii(0x1008_e6f9, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1008_e6fb, 2);  if(jnz(0x1008_e6ff, 2)) goto l_0x1008_e6ff;/* jnz 0x1008e6ff */
        l_0x1008_e6fd:
            ii(0x1008_e6fd, 2);  jmp(0x1008_e71d, 0x1e); goto l_0x1008_e71d;/* jmp 0x1008e71d */
        l_0x1008_e6ff:
            ii(0x1008_e6ff, 4);  movsx(eax, memw[ss, ebp - 48]);       /* movsx eax, word [ebp-0x30] */
            ii(0x1008_e703, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1008_e706, 3);  add(eax, memd[ss, ebp - 16]);         /* add eax, [ebp-0x10] */
            ii(0x1008_e709, 4);  movsx(edx, memw[ss, ebp - 46]);       /* movsx edx, word [ebp-0x2e] */
            ii(0x1008_e70d, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1008_e70f, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1008_e711, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_e713, 2);  mov(dl, memb[ds, eax]);               /* mov dl, [eax] */
            ii(0x1008_e715, 4);  movsx(eax, memw[ss, ebp + 16]);       /* movsx eax, word [ebp+0x10] */
            ii(0x1008_e719, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1008_e71b, 2);  if(jnz(0x1008_e726, 9)) goto l_0x1008_e726;/* jnz 0x1008e726 */
        l_0x1008_e71d:
            ii(0x1008_e71d, 4);  mov(memb[ss, ebp - 20], 1);           /* mov byte [ebp-0x14], 0x1 */
            ii(0x1008_e721, 5);  jmp(0x1008_e7ae, 0x88); goto l_0x1008_e7ae;/* jmp 0x1008e7ae */
        l_0x1008_e726:
            ii(0x1008_e726, 4);  movsx(eax, memw[ss, ebp - 40]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1008_e72a, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1008_e72d, 3);  add(eax, memd[ss, ebp - 16]);         /* add eax, [ebp-0x10] */
            ii(0x1008_e730, 4);  movsx(edx, memw[ss, ebp - 38]);       /* movsx edx, word [ebp-0x26] */
            ii(0x1008_e734, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1008_e736, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1008_e738, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x1008_e73a, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1008_e73f, 3);  cmp(eax, 1);                          /* cmp eax, 0x1 */
            ii(0x1008_e742, 2);  if(jnz(0x1008_e74a, 6)) goto l_0x1008_e74a;/* jnz 0x1008e74a */
            ii(0x1008_e744, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1008_e747, 3);  inc(memd[ss, ebp - 36]);              /* inc dword [ebp-0x24] */
        l_0x1008_e74a:
            ii(0x1008_e74a, 4);  movsx(eax, memw[ss, ebp - 40]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1008_e74e, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1008_e751, 3);  add(eax, memd[ss, ebp - 16]);         /* add eax, [ebp-0x10] */
            ii(0x1008_e754, 4);  movsx(edx, memw[ss, ebp - 38]);       /* movsx edx, word [ebp-0x26] */
            ii(0x1008_e758, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1008_e75a, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1008_e75c, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x1008_e75e, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1008_e763, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_e765, 2);  if(jz(0x1008_e7ae, 0x47)) goto l_0x1008_e7ae;/* jz 0x1008e7ae */
            ii(0x1008_e767, 4);  movsx(eax, memw[ss, ebp - 32]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1008_e76b, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1008_e76e, 5);  mov(edx, 0x101c_5348);                /* mov edx, 0x101c5348 */
            ii(0x1008_e773, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1008_e775, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x1008_e778, 5);  call(0x1008_b1a4, -0x35d9);           /* call 0x1008b1a4 */
            ii(0x1008_e77d, 4);  movsx(eax, memw[ss, ebp - 32]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1008_e781, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1008_e784, 5);  mov(edx, 0x101c_5348);                /* mov edx, 0x101c5348 */
            ii(0x1008_e789, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1008_e78b, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x1008_e78e, 5);  call(0x1008_b1a4, -0x35ef);           /* call 0x1008b1a4 */
            ii(0x1008_e793, 4);  movsx(eax, memw[ss, ebp - 32]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1008_e797, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1008_e79a, 5);  mov(edx, 0x101c_5348);                /* mov edx, 0x101c5348 */
            ii(0x1008_e79f, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1008_e7a1, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1008_e7a4, 5);  call(0x1008_b1a4, -0x3605);           /* call 0x1008b1a4 */
            ii(0x1008_e7a9, 5);  jmp(0x1008_e683, -0x12b); goto l_0x1008_e683;/* jmp 0x1008e683 */
        l_0x1008_e7ae:
            ii(0x1008_e7ae, 4);  cmp(memb[ss, ebp - 20], 0);           /* cmp byte [ebp-0x14], 0x0 */
            ii(0x1008_e7b2, 2);  if(jz(0x1008_e7ca, 0x16)) goto l_0x1008_e7ca;/* jz 0x1008e7ca */
            ii(0x1008_e7b4, 4);  mov(memb[ss, ebp - 24], 1);           /* mov byte [ebp-0x18], 0x1 */
            ii(0x1008_e7b8, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1008_e7bb, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_e7be, 3);  mov(memw[ds, edx], ax);               /* mov [edx], ax */
            ii(0x1008_e7c1, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1008_e7c4, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_e7c7, 3);  mov(memw[ds, edx], ax);               /* mov [edx], ax */
        l_0x1008_e7ca:
            ii(0x1008_e7ca, 5);  jmp(0x1008_e5a0, -0x22f); goto l_0x1008_e5a0;/* jmp 0x1008e5a0 */
        l_0x1008_e7cf:
            ii(0x1008_e7cf, 3);  mov(al, memb[ss, ebp - 24]);          /* mov al, [ebp-0x18] */
            ii(0x1008_e7d2, 3);  mov(memb[ss, ebp - 28], al);          /* mov [ebp-0x1c], al */
            ii(0x1008_e7d5, 3);  mov(al, memb[ss, ebp - 28]);          /* mov al, [ebp-0x1c] */
            ii(0x1008_e7d8, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_e7da, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_e7db, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_e7dc, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_e7dd, 3);  ret(4);                               /* ret 0x4 */
        }
    }
}
