using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_baca-44437bf5")]
        public void Method_1011_baca()
        {
            ii(0x1011_baca, 5);  push(0x38);                           /* push 0x38 */
            ii(0x1011_bacf, 5);  call(Definitions.sys_check_available_stack_size, 0x4_a27e);/* call 0x10165d52 */
            ii(0x1011_bad4, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_bad5, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_bad6, 1);  push(esi);                            /* push esi */
            ii(0x1011_bad7, 1);  push(edi);                            /* push edi */
            ii(0x1011_bad8, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_bad9, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_badb, 6);  sub(esp, 0x20);                       /* sub esp, 0x20 */
            ii(0x1011_bae1, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_bae4, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1011_bae7, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1011_bae9, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_baec, 3);  mov(al, memb[ds, edx + 38]);          /* mov al, [edx+0x26] */
            ii(0x1011_baef, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1011_baf2, 4);  or(memb[ss, ebp - 16], 1);            /* or byte [ebp-0x10], 0x1 */
            ii(0x1011_baf6, 3);  lea(eax, memd[ss, ebp - 32]);         /* lea eax, [ebp-0x20] */
            ii(0x1011_baf9, 5);  call(0x100a_b3f4, -0x7_070a);         /* call 0x100ab3f4 */
            ii(0x1011_bafe, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1011_bb01, 4);  and(memb[ss, ebp - 16], -2 /* 0xfe */);/* and byte [ebp-0x10], 0xfe */
            ii(0x1011_bb05, 5);  mov(eax, 0x52);                       /* mov eax, 0x52 */
            ii(0x1011_bb0a, 5);  call(0x1007_5fdc, -0xa_5b33);         /* call 0x10075fdc */
            ii(0x1011_bb0f, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_bb11, 2);  if(jz(0x1011_bb1b, 8)) goto l_0x1011_bb1b;/* jz 0x1011bb1b */
            ii(0x1011_bb13, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_bb16, 5);  call(0x1014_9fa8, 0x2_e48d);          /* call 0x10149fa8 */
        l_0x1011_bb1b:
            ii(0x1011_bb1b, 7);  cmp(memd[ds, 0x101c_5624], 0);        /* cmp dword [0x101c5624], 0x0 */
            ii(0x1011_bb22, 2);  if(jnz(0x1011_bb3a, 0x16)) goto l_0x1011_bb3a;/* jnz 0x1011bb3a */
            ii(0x1011_bb24, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1011_bb26, 5);  mov(al, memb[ds, 0x101c_37da]);       /* mov al, [0x101c37da] */
            ii(0x1011_bb2b, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1011_bb2e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_bb31, 5);  call(0x1007_6074, -0xa_5ac2);         /* call 0x10076074 */
            ii(0x1011_bb36, 2);  test(al, al);                         /* test al, al */
            ii(0x1011_bb38, 2);  if(jz(0x1011_bb3c, 2)) goto l_0x1011_bb3c;/* jz 0x1011bb3c */
        l_0x1011_bb3a:
            ii(0x1011_bb3a, 2);  jmp(0x1011_bb4f, 0x13); goto l_0x1011_bb4f;/* jmp 0x1011bb4f */
        l_0x1011_bb3c:
            ii(0x1011_bb3c, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
            ii(0x1011_bb40, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_bb42, 3);  lea(eax, memd[ss, ebp - 32]);         /* lea eax, [ebp-0x20] */
            ii(0x1011_bb45, 5);  call(0x100a_9f38, -0x7_1c12);         /* call 0x100a9f38 */
            ii(0x1011_bb4a, 5);  jmp(0x1011_bbcf, 0x80); goto l_0x1011_bbcf;/* jmp 0x1011bbcf */
        l_0x1011_bb4f:
            ii(0x1011_bb4f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_bb52, 3);  mov(al, memb[ds, eax + 41]);          /* mov al, [eax+0x29] */
            ii(0x1011_bb55, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1011_bb5a, 3);  add(eax, 2);                          /* add eax, 0x2 */
            ii(0x1011_bb5d, 3);  and(eax, 7);                          /* and eax, 0x7 */
            ii(0x1011_bb60, 8);  movsx(dx, memb[ds, eax + 0x101b_d914]);/* movsx dx, byte [eax+0x101bd914] */
            ii(0x1011_bb68, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_bb6b, 4);  mov(memw[ds, eax + 22], dx);          /* mov [eax+0x16], dx */
            ii(0x1011_bb6f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_bb72, 3);  mov(al, memb[ds, eax + 41]);          /* mov al, [eax+0x29] */
            ii(0x1011_bb75, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1011_bb7a, 3);  add(eax, 2);                          /* add eax, 0x2 */
            ii(0x1011_bb7d, 3);  and(eax, 7);                          /* and eax, 0x7 */
            ii(0x1011_bb80, 8);  movsx(dx, memb[ds, eax + 0x101b_d91c]);/* movsx dx, byte [eax+0x101bd91c] */
            ii(0x1011_bb88, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_bb8b, 4);  mov(memw[ds, eax + 24], dx);          /* mov [eax+0x18], dx */
            ii(0x1011_bb8f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_bb92, 3);  mov(edx, memd[ds, eax + 22]);         /* mov edx, [eax+0x16] */
            ii(0x1011_bb95, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1011_bb98, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_bb9b, 3);  mov(eax, memd[ds, eax + 20]);         /* mov eax, [eax+0x14] */
            ii(0x1011_bb9e, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1011_bba1, 5);  call(0x1011_9e3a, -0x1d6c);           /* call 0x10119e3a */
            ii(0x1011_bba6, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1011_bba9, 4);  movsx(edx, memw[ss, ebp - 20]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1011_bbad, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_bbb0, 5);  call(0x1011_7fb8, -0x3bfd);           /* call 0x10117fb8 */
            ii(0x1011_bbb5, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
            ii(0x1011_bbb9, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_bbbb, 3);  lea(eax, memd[ss, ebp - 32]);         /* lea eax, [ebp-0x20] */
            ii(0x1011_bbbe, 5);  call(0x100a_9f38, -0x7_1c8b);         /* call 0x100a9f38 */
            ii(0x1011_bbc3, 2);  jmp(0x1011_bbcf, 0xa); goto l_0x1011_bbcf;/* jmp 0x1011bbcf */
        //  ii(0x1011_bbc5, 2);  xor(edx, edx);                        /* xor edx, edx */
        //  ii(0x1011_bbc7, 3);  lea(eax, memd[ss, ebp - 32]);         /* lea eax, [ebp-0x20] */
        //  ii(0x1011_bbca, 5);  call(0x100a_9f38, -0x7_1c97);         /* call 0x100a9f38 */
        l_0x1011_bbcf:
            ii(0x1011_bbcf, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1011_bbd2, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_bbd4, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_bbd5, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_bbd6, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_bbd7, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_bbd8, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_bbd9, 1);  ret();                                /* ret */
        }
    }
}
