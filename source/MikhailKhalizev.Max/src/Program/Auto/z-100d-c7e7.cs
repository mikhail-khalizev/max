using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_c7e7-8265531e")]
        public void Method_100d_c7e7()
        {
            ii(0x100d_c7e7, 5);  push(0x44);                           /* push 0x44 */
            ii(0x100d_c7ec, 5);  call(Definitions.sys_check_available_stack_size, 0x8_9561);/* call 0x10165d52 */
            ii(0x100d_c7f1, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_c7f2, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_c7f3, 1);  push(edx);                            /* push edx */
            ii(0x100d_c7f4, 1);  push(esi);                            /* push esi */
            ii(0x100d_c7f5, 1);  push(edi);                            /* push edi */
            ii(0x100d_c7f6, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_c7f7, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_c7f9, 6);  sub(esp, 0x24);                       /* sub esp, 0x24 */
            ii(0x100d_c7ff, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100d_c802, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c805, 5);  call(0x100d_0803, -0xc007);           /* call 0x100d0803 */
            ii(0x100d_c80a, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100d_c80d, 3);  add(edx, 4);                          /* add edx, 0x4 */
            ii(0x100d_c810, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c813, 3);  mov(eax, memd[ds, eax + 68]);         /* mov eax, [eax+0x44] */
            ii(0x100d_c816, 5);  call(0x100d_7f6c, -0x48af);           /* call 0x100d7f6c */
            ii(0x100d_c81b, 5);  mov(eax, 5);                          /* mov eax, 0x5 */
            ii(0x100d_c820, 5);  call(/* sys */ 0x1016_a24c, 0x8_da27);/* call 0x1016a24c */
            ii(0x100d_c825, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
            ii(0x100d_c82c, 2);  jmp(0x100d_c834, 6); goto l_0x100d_c834;/* jmp 0x100dc834 */
        l_0x100d_c82e:
            ii(0x100d_c82e, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_c831, 3);  inc(memd[ss, ebp - 12]);              /* inc dword [ebp-0xc] */
        l_0x100d_c834:
            ii(0x100d_c834, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_c837, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100d_c83a, 4);  cmp(ax, memw[ds, edx + 40]);          /* cmp ax, [edx+0x28] */
            ii(0x100d_c83e, 2);  if(jge(0x100d_c851, 0x11)) goto l_0x100d_c851;/* jge 0x100dc851 */
            ii(0x100d_c840, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c843, 3);  add(eax, 0x1e);                       /* add eax, 0x1e */
            ii(0x100d_c846, 5);  call(Definitions.my_2_get_count, -0x5_14e3);/* call 0x1008b368 */
            ii(0x100d_c84b, 4);  cmp(ax, memw[ss, ebp - 12]);          /* cmp ax, [ebp-0xc] */
            ii(0x100d_c84f, 2);  if(jg(0x100d_c856, 5)) goto l_0x100d_c856;/* jg 0x100dc856 */
        l_0x100d_c851:
            ii(0x100d_c851, 5);  jmp(0x100d_c968, 0x112); goto l_0x100d_c968;/* jmp 0x100dc968 */
        l_0x100d_c856:
            ii(0x100d_c856, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c859, 4);  mov(ax, memw[ds, eax + 36]);          /* mov ax, [eax+0x24] */
            ii(0x100d_c85d, 3);  add(eax, memd[ss, ebp - 12]);         /* add eax, [ebp-0xc] */
            ii(0x100d_c860, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x100d_c863, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c866, 3);  add(eax, 0x1e);                       /* add eax, 0x1e */
            ii(0x100d_c869, 5);  call(0x1008_b228, -0x5_1646);         /* call 0x1008b228 */
            ii(0x100d_c86e, 3);  movsx(edx, memw[ds, eax]);            /* movsx edx, word [eax] */
            ii(0x100d_c871, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c874, 3);  mov(eax, memd[ds, eax + 32]);         /* mov eax, [eax+0x20] */
            ii(0x100d_c877, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100d_c87a, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x100d_c880, 5);  mov(ebx, 0x101c_a468);                /* mov ebx, 0x101ca468 */
            ii(0x100d_c885, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x100d_c887, 5);  call(0x100d_fd2c, 0x34a0);            /* call 0x100dfd2c */
            ii(0x100d_c88c, 4);  mov(ax, memw[ds, eax + 8]);           /* mov ax, [eax+0x8] */
            ii(0x100d_c890, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_c893, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c896, 4);  mov(ax, memw[ds, eax + 36]);          /* mov ax, [eax+0x24] */
            ii(0x100d_c89a, 3);  add(eax, memd[ss, ebp - 12]);         /* add eax, [ebp-0xc] */
            ii(0x100d_c89d, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x100d_c8a0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c8a3, 3);  add(eax, 0x1e);                       /* add eax, 0x1e */
            ii(0x100d_c8a6, 5);  call(0x1008_b228, -0x5_1683);         /* call 0x1008b228 */
            ii(0x100d_c8ab, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x100d_c8ae, 3);  imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
            ii(0x100d_c8b1, 7);  test(memb[ds, eax + 0x101c_81c1], 2); /* test byte [eax+0x101c81c1], 0x2 */
            ii(0x100d_c8b8, 2);  if(jz(0x100d_c8d4, 0x1a)) goto l_0x100d_c8d4;/* jz 0x100dc8d4 */
            ii(0x100d_c8ba, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x100d_c8bf, 5);  mov(eax, 0x31);                       /* mov eax, 0x31 */
            ii(0x100d_c8c4, 5);  call(0x1007_1e00, -0x6_aac9);         /* call 0x10071e00 */
            ii(0x100d_c8c9, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100d_c8cc, 3);  imul(edx, eax);                       /* imul edx, eax */
            ii(0x100d_c8cf, 3);  mov(memd[ss, ebp - 16], edx);         /* mov [ebp-0x10], edx */
            ii(0x100d_c8d2, 2);  jmp(0x100d_c8ec, 0x18); goto l_0x100d_c8ec;/* jmp 0x100dc8ec */
        l_0x100d_c8d4:
            ii(0x100d_c8d4, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x100d_c8d9, 5);  mov(eax, 0x19);                       /* mov eax, 0x19 */
            ii(0x100d_c8de, 5);  call(0x1007_1e00, -0x6_aae3);         /* call 0x10071e00 */
            ii(0x100d_c8e3, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100d_c8e6, 3);  imul(edx, eax);                       /* imul edx, eax */
            ii(0x100d_c8e9, 3);  mov(memd[ss, ebp - 16], edx);         /* mov [ebp-0x10], edx */
        l_0x100d_c8ec:
            ii(0x100d_c8ec, 2);  push(4);                              /* push 0x4 */
            ii(0x100d_c8ee, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100d_c8f1, 3);  mov(ecx, memd[ds, edx + 18]);         /* mov ecx, [edx+0x12] */
            ii(0x100d_c8f4, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x100d_c8f7, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100d_c8fa, 3);  mov(eax, memd[ds, edx + 68]);         /* mov eax, [edx+0x44] */
            ii(0x100d_c8fd, 5);  call(0x100d_4f58, -0x79aa);           /* call 0x100d4f58 */
            ii(0x100d_c902, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x100d_c905, 4);  movsx(esi, memw[ss, ebp - 16]);       /* movsx esi, word [ebp-0x10] */
            ii(0x100d_c909, 4);  movsx(edi, memw[ss, ebp - 12]);       /* movsx edi, word [ebp-0xc] */
            ii(0x100d_c90d, 3);  shl(edi, 5);                          /* shl edi, 0x5 */
            ii(0x100d_c910, 6);  call_abs(memd[ds, 0x101b_ddf0]);      /* call dword [0x101bddf0] */
            ii(0x100d_c916, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100d_c918, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100d_c91a, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100d_c91d, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x100d_c91f, 2);  sar(eax, 1);                          /* sar eax, 1 */
            ii(0x100d_c921, 3);  add(edi, 0x10);                       /* add edi, 0x10 */
            ii(0x100d_c924, 2);  sub(edi, eax);                        /* sub edi, eax */
            ii(0x100d_c926, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100d_c929, 3);  mov(eax, memd[ds, edx + 18]);         /* mov eax, [edx+0x12] */
            ii(0x100d_c92c, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100d_c92f, 3);  imul(edi, eax);                       /* imul edi, eax */
            ii(0x100d_c932, 3);  mov(memd[ss, ebp - 20], edi);         /* mov [ebp-0x14], edi */
            ii(0x100d_c935, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100d_c938, 3);  mov(eax, memd[ds, edx + 68]);         /* mov eax, [edx+0x44] */
            ii(0x100d_c93b, 5);  call(0x100d_4ef0, -0x7a50);           /* call 0x100d4ef0 */
            ii(0x100d_c940, 3);  movsx(edi, ax);                       /* movsx edi, ax */
            ii(0x100d_c943, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c946, 3);  mov(eax, memd[ds, eax + 26]);         /* mov eax, [eax+0x1a] */
            ii(0x100d_c949, 2);  add(edi, eax);                        /* add edi, eax */
            ii(0x100d_c94b, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100d_c94e, 3);  mov(eax, memd[ds, edx + 68]);         /* mov eax, [edx+0x44] */
            ii(0x100d_c951, 5);  call(0x100d_4f58, -0x79fe);           /* call 0x100d4f58 */
            ii(0x100d_c956, 1);  cwde();                               /* cwde */
            ii(0x100d_c957, 2);  add(eax, edi);                        /* add eax, edi */
            ii(0x100d_c959, 3);  add(eax, memd[ss, ebp - 20]);         /* add eax, [ebp-0x14] */
            ii(0x100d_c95c, 2);  mov(edx, esi);                        /* mov edx, esi */
            ii(0x100d_c95e, 5);  call(0x1012_b658, 0x4_ecf5);          /* call 0x1012b658 */
            ii(0x100d_c963, 5);  jmp(0x100d_c82e, -0x13a); goto l_0x100d_c82e;/* jmp 0x100dc82e */
        l_0x100d_c968:
            ii(0x100d_c968, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c96b, 3);  mov(eax, memd[ds, eax + 68]);         /* mov eax, [eax+0x44] */
            ii(0x100d_c96e, 5);  call(0x100d_4ef0, -0x7a83);           /* call 0x100d4ef0 */
            ii(0x100d_c973, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x100d_c976, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c979, 3);  mov(eax, memd[ds, eax + 4]);          /* mov eax, [eax+0x4] */
            ii(0x100d_c97c, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100d_c97e, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x100d_c981, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c984, 3);  mov(eax, memd[ds, eax + 8]);          /* mov eax, [eax+0x8] */
            ii(0x100d_c987, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x100d_c98a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c98d, 3);  mov(eax, memd[ds, eax + 68]);         /* mov eax, [eax+0x44] */
            ii(0x100d_c990, 5);  call(0x100d_4f58, -0x7a3d);           /* call 0x100d4f58 */
            ii(0x100d_c995, 1);  cwde();                               /* cwde */
            ii(0x100d_c996, 3);  mov(edx, memd[ss, ebp - 36]);         /* mov edx, [ebp-0x24] */
            ii(0x100d_c999, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100d_c99b, 3);  mov(memd[ss, ebp - 28], edx);         /* mov [ebp-0x1c], edx */
            ii(0x100d_c99e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c9a1, 3);  mov(eax, memd[ds, eax + 68]);         /* mov eax, [eax+0x44] */
            ii(0x100d_c9a4, 5);  call(0x100d_4f24, -0x7a85);           /* call 0x100d4f24 */
            ii(0x100d_c9a9, 1);  cwde();                               /* cwde */
            ii(0x100d_c9aa, 3);  mov(edx, memd[ss, ebp - 32]);         /* mov edx, [ebp-0x20] */
            ii(0x100d_c9ad, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100d_c9af, 3);  mov(memd[ss, ebp - 24], edx);         /* mov [ebp-0x18], edx */
            ii(0x100d_c9b2, 3);  lea(edx, memd[ss, ebp - 36]);         /* lea edx, [ebp-0x24] */
            ii(0x100d_c9b5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c9b8, 3);  mov(eax, memd[ds, eax + 22]);         /* mov eax, [eax+0x16] */
            ii(0x100d_c9bb, 5);  call(Definitions.sys_display_draw_1, 0x8_aae8);/* call 0x101674a8 */
            ii(0x100d_c9c0, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_c9c2, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_c9c3, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_c9c4, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_c9c5, 1);  pop(edx);                             /* pop edx */
            ii(0x100d_c9c6, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_c9c7, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_c9c8, 1);  ret();                                /* ret */
        }
    }
}
