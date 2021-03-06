using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_c644-9a3dbc0f")]
        public void Method_1011_c644()
        {
            ii(0x1011_c644, 5);  push(0x5c);                           /* push 0x5c */
            ii(0x1011_c649, 5);  call(Definitions.sys_check_available_stack_size, 0x4_9704);/* call 0x10165d52 */
            ii(0x1011_c64e, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_c64f, 1);  push(esi);                            /* push esi */
            ii(0x1011_c650, 1);  push(edi);                            /* push edi */
            ii(0x1011_c651, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_c652, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_c654, 6);  sub(esp, 0x48);                       /* sub esp, 0x48 */
            ii(0x1011_c65a, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1011_c65d, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1011_c660, 3);  mov(memb[ss, ebp - 4], bl);           /* mov [ebp-0x4], bl */
            ii(0x1011_c663, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1011_c666, 5);  call(Definitions.my_ctor_0x101b_4184, -0xa_5b7b);/* call 0x10076af0 */
            ii(0x1011_c66b, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_c66e, 5);  call(Definitions.my_ctor_0x101b_4184, -0xa_5b83);/* call 0x10076af0 */
            ii(0x1011_c673, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1011_c676, 5);  call(Definitions.my_ctor_0x101b_4184, -0xa_5b8b);/* call 0x10076af0 */
            ii(0x1011_c67b, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1011_c67e, 5);  call(Definitions.my_ctor_0x101b_4184, -0xa_5b93);/* call 0x10076af0 */
            ii(0x1011_c683, 3);  lea(eax, memd[ss, ebp - 32]);         /* lea eax, [ebp-0x20] */
            ii(0x1011_c686, 5);  call(Definitions.my_ctor_0x101b_4184, -0xa_5b9b);/* call 0x10076af0 */
            ii(0x1011_c68b, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x1011_c68e, 5);  call(0x1012_04a4, 0x3e11);            /* call 0x101204a4 */
            ii(0x1011_c693, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_c696, 4);  mov(ax, memw[ds, eax + 30]);          /* mov ax, [eax+0x1e] */
            ii(0x1011_c69a, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1011_c69d, 3);  sub(ax, memw[ds, edx]);               /* sub ax, [edx] */
            ii(0x1011_c6a0, 4);  mov(memw[ss, ebp - 20], ax);          /* mov [ebp-0x14], ax */
            ii(0x1011_c6a4, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_c6a7, 4);  mov(ax, memw[ds, eax + 32]);          /* mov ax, [eax+0x20] */
            ii(0x1011_c6ab, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1011_c6ae, 4);  sub(ax, memw[ds, edx + 2]);           /* sub ax, [edx+0x2] */
            ii(0x1011_c6b2, 4);  mov(memw[ss, ebp - 18], ax);          /* mov [ebp-0x12], ax */
            ii(0x1011_c6b6, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1011_c6ba, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_c6bc, 2);  if(jle(0x1011_c6c6, 8)) goto l_0x1011_c6c6;/* jle 0x1011c6c6 */
            ii(0x1011_c6be, 6);  mov(memw[ss, ebp - 24], 1);           /* mov word [ebp-0x18], 0x1 */
            ii(0x1011_c6c4, 2);  jmp(0x1011_c6d0, 0xa); goto l_0x1011_c6d0;/* jmp 0x1011c6d0 */
        l_0x1011_c6c6:
            ii(0x1011_c6c6, 4);  neg(memw[ss, ebp - 20]);              /* neg word [ebp-0x14] */
            ii(0x1011_c6ca, 6);  mov(memw[ss, ebp - 24], 0xffff);      /* mov word [ebp-0x18], 0xffff */
        l_0x1011_c6d0:
            ii(0x1011_c6d0, 4);  movsx(eax, memw[ss, ebp - 18]);       /* movsx eax, word [ebp-0x12] */
            ii(0x1011_c6d4, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_c6d6, 2);  if(jle(0x1011_c6e0, 8)) goto l_0x1011_c6e0;/* jle 0x1011c6e0 */
            ii(0x1011_c6d8, 6);  mov(memw[ss, ebp - 22], 1);           /* mov word [ebp-0x16], 0x1 */
            ii(0x1011_c6de, 2);  jmp(0x1011_c6ea, 0xa); goto l_0x1011_c6ea;/* jmp 0x1011c6ea */
        l_0x1011_c6e0:
            ii(0x1011_c6e0, 4);  neg(memw[ss, ebp - 18]);              /* neg word [ebp-0x12] */
            ii(0x1011_c6e4, 6);  mov(memw[ss, ebp - 22], 0xffff);      /* mov word [ebp-0x16], 0xffff */
        l_0x1011_c6ea:
            ii(0x1011_c6ea, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1011_c6ed, 4);  cmp(ax, memw[ss, ebp - 18]);          /* cmp ax, [ebp-0x12] */
            ii(0x1011_c6f1, 2);  if(jge(0x1011_c74e, 0x5b)) goto l_0x1011_c74e;/* jge 0x1011c74e */
            ii(0x1011_c6f3, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1011_c6f6, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1011_c6f9, 4);  movsx(eax, memw[ss, ebp - 44]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1011_c6fd, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_c6ff, 2);  if(jnz(0x1011_c712, 0x11)) goto l_0x1011_c712;/* jnz 0x1011c712 */
            ii(0x1011_c701, 7);  mov(memd[ss, ebp - 44], 1);           /* mov dword [ebp-0x2c], 0x1 */
            ii(0x1011_c708, 4);  inc(memw[ss, ebp - 18]);              /* inc word [ebp-0x12] */
            ii(0x1011_c70c, 6);  mov(memw[ss, ebp - 20], 1);           /* mov word [ebp-0x14], 0x1 */
        l_0x1011_c712:
            ii(0x1011_c712, 3);  mov(eax, memd[ss, ebp - 22]);         /* mov eax, [ebp-0x16] */
            ii(0x1011_c715, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x1011_c717, 5);  add(eax, 2);                          /* add eax, 0x2 */
            ii(0x1011_c71c, 3);  mov(memd[ss, ebp - 48], eax);         /* mov [ebp-0x30], eax */
            ii(0x1011_c71f, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1011_c722, 4);  cmp(ax, memw[ss, ebp - 22]);          /* cmp ax, [ebp-0x16] */
            ii(0x1011_c726, 2);  if(jz(0x1011_c730, 8)) goto l_0x1011_c730;/* jz 0x1011c730 */
            ii(0x1011_c728, 6);  mov(memw[ss, ebp - 28], 1);           /* mov word [ebp-0x1c], 0x1 */
            ii(0x1011_c72e, 2);  jmp(0x1011_c746, 0x16); goto l_0x1011_c746;/* jmp 0x1011c746 */
        l_0x1011_c730:
            ii(0x1011_c730, 4);  movsx(eax, memw[ss, ebp - 48]);       /* movsx eax, word [ebp-0x30] */
            ii(0x1011_c734, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_c736, 2);  if(jnz(0x1011_c740, 8)) goto l_0x1011_c740;/* jnz 0x1011c740 */
            ii(0x1011_c738, 6);  mov(memw[ss, ebp - 28], 7);           /* mov word [ebp-0x1c], 0x7 */
            ii(0x1011_c73e, 2);  jmp(0x1011_c746, 6); goto l_0x1011_c746;/* jmp 0x1011c746 */
        l_0x1011_c740:
            ii(0x1011_c740, 6);  mov(memw[ss, ebp - 28], 0xffff);      /* mov word [ebp-0x1c], 0xffff */
        l_0x1011_c746:
            ii(0x1011_c746, 6);  mov(memw[ss, ebp - 26], 0);           /* mov word [ebp-0x1a], 0x0 */
            ii(0x1011_c74c, 2);  jmp(0x1011_c799, 0x4b); goto l_0x1011_c799;/* jmp 0x1011c799 */
        l_0x1011_c74e:
            ii(0x1011_c74e, 3);  mov(eax, memd[ss, ebp - 18]);         /* mov eax, [ebp-0x12] */
            ii(0x1011_c751, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1011_c754, 4);  movsx(eax, memw[ss, ebp - 44]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1011_c758, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_c75a, 2);  if(jnz(0x1011_c76d, 0x11)) goto l_0x1011_c76d;/* jnz 0x1011c76d */
            ii(0x1011_c75c, 7);  mov(memd[ss, ebp - 44], 1);           /* mov dword [ebp-0x2c], 0x1 */
            ii(0x1011_c763, 4);  inc(memw[ss, ebp - 20]);              /* inc word [ebp-0x14] */
            ii(0x1011_c767, 6);  mov(memw[ss, ebp - 18], 1);           /* mov word [ebp-0x12], 0x1 */
        l_0x1011_c76d:
            ii(0x1011_c76d, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1011_c770, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x1011_c772, 5);  mov(edx, 4);                          /* mov edx, 0x4 */
            ii(0x1011_c777, 2);  sub(edx, eax);                        /* sub edx, eax */
            ii(0x1011_c779, 3);  mov(memd[ss, ebp - 48], edx);         /* mov [ebp-0x30], edx */
            ii(0x1011_c77c, 3);  mov(eax, memd[ss, ebp - 22]);         /* mov eax, [ebp-0x16] */
            ii(0x1011_c77f, 4);  cmp(ax, memw[ss, ebp - 24]);          /* cmp ax, [ebp-0x18] */
            ii(0x1011_c783, 2);  if(jz(0x1011_c78d, 8)) goto l_0x1011_c78d;/* jz 0x1011c78d */
            ii(0x1011_c785, 6);  mov(memw[ss, ebp - 26], 0xffff);      /* mov word [ebp-0x1a], 0xffff */
            ii(0x1011_c78b, 2);  jmp(0x1011_c793, 6); goto l_0x1011_c793;/* jmp 0x1011c793 */
        l_0x1011_c78d:
            ii(0x1011_c78d, 6);  mov(memw[ss, ebp - 26], 1);           /* mov word [ebp-0x1a], 0x1 */
        l_0x1011_c793:
            ii(0x1011_c793, 6);  mov(memw[ss, ebp - 28], 0);           /* mov word [ebp-0x1c], 0x0 */
        l_0x1011_c799:
            ii(0x1011_c799, 6);  mov(memw[ss, ebp - 32], 0);           /* mov word [ebp-0x20], 0x0 */
            ii(0x1011_c79f, 6);  mov(memw[ss, ebp - 30], 0);           /* mov word [ebp-0x1e], 0x0 */
            ii(0x1011_c7a5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_c7a8, 3);  mov(ax, memw[ds, eax]);               /* mov ax, [eax] */
            ii(0x1011_c7ab, 4);  mov(memw[ss, ebp - 40], ax);          /* mov [ebp-0x28], ax */
            ii(0x1011_c7af, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_c7b2, 4);  mov(ax, memw[ds, eax + 2]);           /* mov ax, [eax+0x2] */
            ii(0x1011_c7b6, 4);  mov(memw[ss, ebp - 38], ax);          /* mov [ebp-0x26], ax */
            ii(0x1011_c7ba, 6);  mov(memw[ss, ebp - 36], 0);           /* mov word [ebp-0x24], 0x0 */
        l_0x1011_c7c0:
            ii(0x1011_c7c0, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x1011_c7c3, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1011_c7c6, 4);  cmp(ax, memw[ds, edx + 30]);          /* cmp ax, [edx+0x1e] */
            ii(0x1011_c7ca, 2);  if(jnz(0x1011_c7dc, 0x10)) goto l_0x1011_c7dc;/* jnz 0x1011c7dc */
            ii(0x1011_c7cc, 3);  mov(eax, memd[ss, ebp - 38]);         /* mov eax, [ebp-0x26] */
            ii(0x1011_c7cf, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1011_c7d2, 4);  cmp(ax, memw[ds, edx + 32]);          /* cmp ax, [edx+0x20] */
            ii(0x1011_c7d6, 6);  if(jz(0x1011_c92f, 0x153)) goto l_0x1011_c92f;/* jz 0x1011c92f */
        l_0x1011_c7dc:
            ii(0x1011_c7dc, 3);  mov(eax, memd[ss, ebp - 44]);         /* mov eax, [ebp-0x2c] */
            ii(0x1011_c7df, 4);  add(memw[ss, ebp - 32], ax);          /* add [ebp-0x20], ax */
            ii(0x1011_c7e3, 3);  mov(eax, memd[ss, ebp - 48]);         /* mov eax, [ebp-0x30] */
            ii(0x1011_c7e6, 3);  mov(memd[ss, ebp - 52], eax);         /* mov [ebp-0x34], eax */
            ii(0x1011_c7e9, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1011_c7ec, 4);  cmp(ax, memw[ss, ebp - 18]);          /* cmp ax, [ebp-0x12] */
            ii(0x1011_c7f0, 2);  if(jl(0x1011_c7ff, 0xd)) goto l_0x1011_c7ff;/* jl 0x1011c7ff */
            ii(0x1011_c7f2, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1011_c7f5, 3);  add(memd[ss, ebp - 52], eax);         /* add [ebp-0x34], eax */
            ii(0x1011_c7f8, 3);  mov(eax, memd[ss, ebp - 18]);         /* mov eax, [ebp-0x12] */
            ii(0x1011_c7fb, 4);  sub(memw[ss, ebp - 32], ax);          /* sub [ebp-0x20], ax */
        l_0x1011_c7ff:
            ii(0x1011_c7ff, 3);  mov(eax, memd[ss, ebp - 44]);         /* mov eax, [ebp-0x2c] */
            ii(0x1011_c802, 4);  add(memw[ss, ebp - 30], ax);          /* add [ebp-0x1e], ax */
            ii(0x1011_c806, 3);  mov(eax, memd[ss, ebp - 30]);         /* mov eax, [ebp-0x1e] */
            ii(0x1011_c809, 4);  cmp(ax, memw[ss, ebp - 20]);          /* cmp ax, [ebp-0x14] */
            ii(0x1011_c80d, 2);  if(jl(0x1011_c81c, 0xd)) goto l_0x1011_c81c;/* jl 0x1011c81c */
            ii(0x1011_c80f, 3);  mov(eax, memd[ss, ebp - 26]);         /* mov eax, [ebp-0x1a] */
            ii(0x1011_c812, 3);  add(memd[ss, ebp - 52], eax);         /* add [ebp-0x34], eax */
            ii(0x1011_c815, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1011_c818, 4);  sub(memw[ss, ebp - 30], ax);          /* sub [ebp-0x1e], ax */
        l_0x1011_c81c:
            ii(0x1011_c81c, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1011_c81f, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1011_c822, 5);  call(0x1008_8b44, -0x9_3ce3);         /* call 0x10088b44 */
            ii(0x1011_c827, 4);  movsx(eax, memw[ss, ebp - 52]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1011_c82b, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1011_c82e, 5);  mov(edx, 0x101c_5348);                /* mov edx, 0x101c5348 */
            ii(0x1011_c833, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1011_c835, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1011_c838, 5);  call(0x1008_b1a4, -0x9_1699);         /* call 0x1008b1a4 */
            ii(0x1011_c83d, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_c840, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1011_c842, 3);  mov(bl, memb[ds, eax + 34]);          /* mov bl, [eax+0x22] */
            ii(0x1011_c845, 3);  lea(edx, memd[ss, ebp - 16]);         /* lea edx, [ebp-0x10] */
            ii(0x1011_c848, 3);  lea(eax, memd[ss, ebp - 56]);         /* lea eax, [ebp-0x38] */
            ii(0x1011_c84b, 5);  call(0x1007_5e64, -0xa_69ec);         /* call 0x10075e64 */
            ii(0x1011_c850, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x1011_c852, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1011_c855, 3);  lea(eax, memd[ss, ebp - 60]);         /* lea eax, [ebp-0x3c] */
            ii(0x1011_c858, 5);  call(0x1007_5e64, -0xa_69f9);         /* call 0x10075e64 */
            ii(0x1011_c85d, 2);  mov(edx, ecx);                        /* mov edx, ecx */
            ii(0x1011_c85f, 5);  call(0x1011_bf10, -0x954);            /* call 0x1011bf10 */
            ii(0x1011_c864, 3);  mov(memd[ss, ebp - 64], eax);         /* mov [ebp-0x40], eax */
            ii(0x1011_c867, 4);  movsx(eax, memw[ss, ebp - 64]);       /* movsx eax, word [ebp-0x40] */
            ii(0x1011_c86b, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_c86d, 6);  if(jz(0x1011_c92f, 0xbc)) goto l_0x1011_c92f;/* jz 0x1011c92f */
            ii(0x1011_c873, 4);  cmp(memb[ss, ebp - 4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1011_c877, 2);  if(jnz(0x1011_c8a3, 0x2a)) goto l_0x1011_c8a3;/* jnz 0x1011c8a3 */
            ii(0x1011_c879, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_c87c, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1011_c87e, 3);  mov(bl, memb[ds, eax + 34]);          /* mov bl, [eax+0x22] */
            ii(0x1011_c881, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1011_c884, 3);  lea(eax, memd[ss, ebp - 68]);         /* lea eax, [ebp-0x44] */
            ii(0x1011_c887, 5);  call(0x1007_5e64, -0xa_6a28);         /* call 0x10075e64 */
            ii(0x1011_c88c, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x1011_c88e, 3);  lea(edx, memd[ss, ebp - 16]);         /* lea edx, [ebp-0x10] */
            ii(0x1011_c891, 3);  lea(eax, memd[ss, ebp - 72]);         /* lea eax, [ebp-0x48] */
            ii(0x1011_c894, 5);  call(0x1007_5e64, -0xa_6a35);         /* call 0x10075e64 */
            ii(0x1011_c899, 2);  mov(edx, ecx);                        /* mov edx, ecx */
            ii(0x1011_c89b, 5);  call(0x1011_bf10, -0x990);            /* call 0x1011bf10 */
            ii(0x1011_c8a0, 3);  mov(memd[ss, ebp - 64], eax);         /* mov [ebp-0x40], eax */
        l_0x1011_c8a3:
            ii(0x1011_c8a3, 6);  test(memw[ss, ebp - 52], 1);          /* test word [ebp-0x34], 0x1 */
            ii(0x1011_c8a9, 2);  if(jz(0x1011_c8be, 0x13)) goto l_0x1011_c8be;/* jz 0x1011c8be */
            ii(0x1011_c8ab, 4);  movsx(edx, memw[ss, ebp - 64]);       /* movsx edx, word [ebp-0x40] */
            ii(0x1011_c8af, 3);  lea(edx, memd[ds, edx + edx * 2]);    /* lea edx, [edx+edx*2] */
            ii(0x1011_c8b2, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1011_c8b4, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1011_c8b7, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x1011_c8b9, 2);  sar(eax, 1);                          /* sar eax, 1 */
            ii(0x1011_c8bb, 3);  mov(memd[ss, ebp - 64], eax);         /* mov [ebp-0x40], eax */
        l_0x1011_c8be:
            ii(0x1011_c8be, 3);  lea(edx, memd[ss, ebp - 16]);         /* lea edx, [ebp-0x10] */
            ii(0x1011_c8c1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_c8c4, 5);  call(0x1008_8b44, -0x9_3d85);         /* call 0x10088b44 */
            ii(0x1011_c8c9, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_c8cc, 4);  mov(memw[ss, ebp - 40], ax);          /* mov [ebp-0x28], ax */
            ii(0x1011_c8d0, 3);  mov(eax, memd[ss, ebp - 14]);         /* mov eax, [ebp-0xe] */
            ii(0x1011_c8d3, 4);  mov(memw[ss, ebp - 38], ax);          /* mov [ebp-0x26], ax */
            ii(0x1011_c8d7, 3);  mov(eax, memd[ss, ebp - 64]);         /* mov eax, [ebp-0x40] */
            ii(0x1011_c8da, 4);  add(memw[ss, ebp - 36], ax);          /* add [ebp-0x24], ax */
            ii(0x1011_c8de, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1011_c8e2, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x1011_c8e5, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_c8e8, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1011_c8ea, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1011_c8ec, 4);  movsx(edx, memw[ss, ebp - 14]);       /* movsx edx, word [ebp-0xe] */
            ii(0x1011_c8f0, 2);  add(edx, edx);                        /* add edx, edx */
            ii(0x1011_c8f2, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1011_c8f4, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1011_c8f6, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1011_c8f9, 3);  mov(memw[ds, edx], ax);               /* mov [edx], ax */
            ii(0x1011_c8fc, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1011_c900, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1011_c903, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1011_c905, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_c908, 3);  mov(eax, memd[ds, eax + 4]);          /* mov eax, [eax+0x4] */
            ii(0x1011_c90b, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1011_c90d, 4);  movsx(ebx, memw[ss, ebp - 14]);       /* movsx ebx, word [ebp-0xe] */
            ii(0x1011_c911, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x1011_c913, 2);  add(edx, ebx);                        /* add edx, ebx */
            ii(0x1011_c915, 3);  mov(al, memb[ss, ebp - 52]);          /* mov al, [ebp-0x34] */
            ii(0x1011_c918, 2);  mov(memb[ds, edx], al);               /* mov [edx], al */
            ii(0x1011_c91a, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1011_c91c, 3);  lea(edx, memd[ss, ebp - 40]);         /* lea edx, [ebp-0x28] */
            ii(0x1011_c91f, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_c922, 3);  add(eax, 0xe);                        /* add eax, 0xe */
            ii(0x1011_c925, 5);  call(0x1012_05bc, 0x3c92);            /* call 0x101205bc */
            ii(0x1011_c92a, 5);  jmp(0x1011_c7c0, -0x16f); goto l_0x1011_c7c0;/* jmp 0x1011c7c0 */
        l_0x1011_c92f:
            ii(0x1011_c92f, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_c931, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_c932, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_c933, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_c934, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_c935, 1);  ret();                                /* ret */
        }
    }
}
