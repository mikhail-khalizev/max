using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_564c-65f4fedc")]
        public void Method_1016_564c()
        {
            ii(0x1016_564c, 5);  push(0x70);                           /* push 0x70 */
            ii(0x1016_5651, 5);  call(Definitions.sys_check_available_stack_size, 0x6fc);/* call 0x10165d52 */
            ii(0x1016_5656, 1);  push(ebx);                            /* push ebx */
            ii(0x1016_5657, 1);  push(ecx);                            /* push ecx */
            ii(0x1016_5658, 1);  push(esi);                            /* push esi */
            ii(0x1016_5659, 1);  push(edi);                            /* push edi */
            ii(0x1016_565a, 1);  push(ebp);                            /* push ebp */
            ii(0x1016_565b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1016_565d, 6);  sub(esp, 0x58);                       /* sub esp, 0x58 */
            ii(0x1016_5663, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1016_5666, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1016_5669, 7);  test(memd[ss, ebp - 4], 4);           /* test dword [ebp-0x4], 0x4 */
            ii(0x1016_5670, 2);  if(jz(0x1016_5689, 0x17)) goto l_0x1016_5689;/* jz 0x10165689 */
            ii(0x1016_5672, 5);  mov(edx, 0x101b_75a4);                /* mov edx, 0x101b75a4 */
            ii(0x1016_5677, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_567a, 5);  call(Definitions.sys_call_dtor_arr, 0x939);/* call 0x10165fb8 */
            ii(0x1016_567f, 5);  call(Definitions.sys_delete_arr, 0x954);/* call 0x10165fd8 */
            ii(0x1016_5684, 5);  jmp(0x1016_584e, 0x1c5); goto l_0x1016_584e;/* jmp 0x1016584e */
        l_0x1016_5689:
            ii(0x1016_5689, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_568c, 7);  mov(memd[ds, eax + 19], 0x101b_75b8); /* mov dword [eax+0x13], 0x101b75b8 */
            ii(0x1016_5693, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_5696, 3);  mov(eax, memd[ds, eax + 100]);        /* mov eax, [eax+0x64] */
            ii(0x1016_5699, 3);  mov(memd[ss, ebp - 88], eax);         /* mov [ebp-0x58], eax */
            ii(0x1016_569c, 4);  cmp(memd[ss, ebp - 88], 0);           /* cmp dword [ebp-0x58], 0x0 */
            ii(0x1016_56a0, 2);  if(jz(0x1016_56b6, 0x14)) goto l_0x1016_56b6;/* jz 0x101656b6 */
            ii(0x1016_56a2, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1016_56a4, 3);  mov(eax, memd[ss, ebp - 88]);         /* mov eax, [ebp-0x58] */
            ii(0x1016_56a7, 5);  call(Definitions.my_dtor_d3, -0x8_d979);/* call 0x100d7d33 */
            ii(0x1016_56ac, 5);  call(Definitions.sys_delete, 0x8b3);  /* call 0x10165f64 */
            ii(0x1016_56b1, 3);  mov(memd[ss, ebp - 48], eax);         /* mov [ebp-0x30], eax */
            ii(0x1016_56b4, 2);  jmp(0x1016_56bd, 7); goto l_0x1016_56bd;/* jmp 0x101656bd */
        l_0x1016_56b6:
            ii(0x1016_56b6, 7);  mov(memd[ss, ebp - 48], 0);           /* mov dword [ebp-0x30], 0x0 */
        l_0x1016_56bd:
            ii(0x1016_56bd, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_56c0, 3);  mov(eax, memd[ds, eax + 104]);        /* mov eax, [eax+0x68] */
            ii(0x1016_56c3, 3);  mov(memd[ss, ebp - 84], eax);         /* mov [ebp-0x54], eax */
            ii(0x1016_56c6, 4);  cmp(memd[ss, ebp - 84], 0);           /* cmp dword [ebp-0x54], 0x0 */
            ii(0x1016_56ca, 2);  if(jz(0x1016_56e0, 0x14)) goto l_0x1016_56e0;/* jz 0x101656e0 */
            ii(0x1016_56cc, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1016_56ce, 3);  mov(eax, memd[ss, ebp - 84]);         /* mov eax, [ebp-0x54] */
            ii(0x1016_56d1, 5);  call(Definitions.my_dtor_d3, -0x8_d9a3);/* call 0x100d7d33 */
            ii(0x1016_56d6, 5);  call(Definitions.sys_delete, 0x889);  /* call 0x10165f64 */
            ii(0x1016_56db, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1016_56de, 2);  jmp(0x1016_56e7, 7); goto l_0x1016_56e7;/* jmp 0x101656e7 */
        l_0x1016_56e0:
            ii(0x1016_56e0, 7);  mov(memd[ss, ebp - 44], 0);           /* mov dword [ebp-0x2c], 0x0 */
        l_0x1016_56e7:
            ii(0x1016_56e7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_56ea, 3);  mov(eax, memd[ds, eax + 108]);        /* mov eax, [eax+0x6c] */
            ii(0x1016_56ed, 3);  mov(memd[ss, ebp - 80], eax);         /* mov [ebp-0x50], eax */
            ii(0x1016_56f0, 4);  cmp(memd[ss, ebp - 80], 0);           /* cmp dword [ebp-0x50], 0x0 */
            ii(0x1016_56f4, 2);  if(jz(0x1016_570a, 0x14)) goto l_0x1016_570a;/* jz 0x1016570a */
            ii(0x1016_56f6, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1016_56f8, 3);  mov(eax, memd[ss, ebp - 80]);         /* mov eax, [ebp-0x50] */
            ii(0x1016_56fb, 5);  call(Definitions.my_dtor_d3, -0x8_d9cd);/* call 0x100d7d33 */
            ii(0x1016_5700, 5);  call(Definitions.sys_delete, 0x85f);  /* call 0x10165f64 */
            ii(0x1016_5705, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x1016_5708, 2);  jmp(0x1016_5711, 7); goto l_0x1016_5711;/* jmp 0x10165711 */
        l_0x1016_570a:
            ii(0x1016_570a, 7);  mov(memd[ss, ebp - 40], 0);           /* mov dword [ebp-0x28], 0x0 */
        l_0x1016_5711:
            ii(0x1016_5711, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_5714, 3);  mov(eax, memd[ds, eax + 84]);         /* mov eax, [eax+0x54] */
            ii(0x1016_5717, 3);  mov(memd[ss, ebp - 76], eax);         /* mov [ebp-0x4c], eax */
            ii(0x1016_571a, 4);  cmp(memd[ss, ebp - 76], 0);           /* cmp dword [ebp-0x4c], 0x0 */
            ii(0x1016_571e, 2);  if(jz(0x1016_5734, 0x14)) goto l_0x1016_5734;/* jz 0x10165734 */
            ii(0x1016_5720, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1016_5722, 3);  mov(eax, memd[ss, ebp - 76]);         /* mov eax, [ebp-0x4c] */
            ii(0x1016_5725, 5);  call(Definitions.my_dtor_d2, -0x9_71f2);/* call 0x100ce538 */
            ii(0x1016_572a, 5);  call(Definitions.sys_delete, 0x835);  /* call 0x10165f64 */
            ii(0x1016_572f, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1016_5732, 2);  jmp(0x1016_573b, 7); goto l_0x1016_573b;/* jmp 0x1016573b */
        l_0x1016_5734:
            ii(0x1016_5734, 7);  mov(memd[ss, ebp - 36], 0);           /* mov dword [ebp-0x24], 0x0 */
        l_0x1016_573b:
            ii(0x1016_573b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_573e, 3);  mov(eax, memd[ds, eax + 88]);         /* mov eax, [eax+0x58] */
            ii(0x1016_5741, 3);  mov(memd[ss, ebp - 72], eax);         /* mov [ebp-0x48], eax */
            ii(0x1016_5744, 4);  cmp(memd[ss, ebp - 72], 0);           /* cmp dword [ebp-0x48], 0x0 */
            ii(0x1016_5748, 2);  if(jz(0x1016_575e, 0x14)) goto l_0x1016_575e;/* jz 0x1016575e */
            ii(0x1016_574a, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1016_574c, 3);  mov(eax, memd[ss, ebp - 72]);         /* mov eax, [ebp-0x48] */
            ii(0x1016_574f, 5);  call(Definitions.my_dtor_d2, -0x9_721c);/* call 0x100ce538 */
            ii(0x1016_5754, 5);  call(Definitions.sys_delete, 0x80b);  /* call 0x10165f64 */
            ii(0x1016_5759, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1016_575c, 2);  jmp(0x1016_5765, 7); goto l_0x1016_5765;/* jmp 0x10165765 */
        l_0x1016_575e:
            ii(0x1016_575e, 7);  mov(memd[ss, ebp - 32], 0);           /* mov dword [ebp-0x20], 0x0 */
        l_0x1016_5765:
            ii(0x1016_5765, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_5768, 3);  mov(eax, memd[ds, eax + 72]);         /* mov eax, [eax+0x48] */
            ii(0x1016_576b, 3);  mov(memd[ss, ebp - 68], eax);         /* mov [ebp-0x44], eax */
            ii(0x1016_576e, 4);  cmp(memd[ss, ebp - 68], 0);           /* cmp dword [ebp-0x44], 0x0 */
            ii(0x1016_5772, 2);  if(jz(0x1016_5788, 0x14)) goto l_0x1016_5788;/* jz 0x10165788 */
            ii(0x1016_5774, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1016_5776, 3);  mov(eax, memd[ss, ebp - 68]);         /* mov eax, [ebp-0x44] */
            ii(0x1016_5779, 5);  call(Definitions.my_dtor_d2, -0x9_7246);/* call 0x100ce538 */
            ii(0x1016_577e, 5);  call(Definitions.sys_delete, 0x7e1);  /* call 0x10165f64 */
            ii(0x1016_5783, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1016_5786, 2);  jmp(0x1016_578f, 7); goto l_0x1016_578f;/* jmp 0x1016578f */
        l_0x1016_5788:
            ii(0x1016_5788, 7);  mov(memd[ss, ebp - 28], 0);           /* mov dword [ebp-0x1c], 0x0 */
        l_0x1016_578f:
            ii(0x1016_578f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_5792, 3);  mov(eax, memd[ds, eax + 76]);         /* mov eax, [eax+0x4c] */
            ii(0x1016_5795, 3);  mov(memd[ss, ebp - 64], eax);         /* mov [ebp-0x40], eax */
            ii(0x1016_5798, 4);  cmp(memd[ss, ebp - 64], 0);           /* cmp dword [ebp-0x40], 0x0 */
            ii(0x1016_579c, 2);  if(jz(0x1016_57b2, 0x14)) goto l_0x1016_57b2;/* jz 0x101657b2 */
            ii(0x1016_579e, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1016_57a0, 3);  mov(eax, memd[ss, ebp - 64]);         /* mov eax, [ebp-0x40] */
            ii(0x1016_57a3, 5);  call(Definitions.my_dtor_d2, -0x9_7270);/* call 0x100ce538 */
            ii(0x1016_57a8, 5);  call(Definitions.sys_delete, 0x7b7);  /* call 0x10165f64 */
            ii(0x1016_57ad, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1016_57b0, 2);  jmp(0x1016_57b9, 7); goto l_0x1016_57b9;/* jmp 0x101657b9 */
        l_0x1016_57b2:
            ii(0x1016_57b2, 7);  mov(memd[ss, ebp - 24], 0);           /* mov dword [ebp-0x18], 0x0 */
        l_0x1016_57b9:
            ii(0x1016_57b9, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_57bc, 3);  mov(eax, memd[ds, eax + 80]);         /* mov eax, [eax+0x50] */
            ii(0x1016_57bf, 3);  mov(memd[ss, ebp - 60], eax);         /* mov [ebp-0x3c], eax */
            ii(0x1016_57c2, 4);  cmp(memd[ss, ebp - 60], 0);           /* cmp dword [ebp-0x3c], 0x0 */
            ii(0x1016_57c6, 2);  if(jz(0x1016_57dc, 0x14)) goto l_0x1016_57dc;/* jz 0x101657dc */
            ii(0x1016_57c8, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1016_57ca, 3);  mov(eax, memd[ss, ebp - 60]);         /* mov eax, [ebp-0x3c] */
            ii(0x1016_57cd, 5);  call(Definitions.my_dtor_d2, -0x9_729a);/* call 0x100ce538 */
            ii(0x1016_57d2, 5);  call(Definitions.sys_delete, 0x78d);  /* call 0x10165f64 */
            ii(0x1016_57d7, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1016_57da, 2);  jmp(0x1016_57e3, 7); goto l_0x1016_57e3;/* jmp 0x101657e3 */
        l_0x1016_57dc:
            ii(0x1016_57dc, 7);  mov(memd[ss, ebp - 20], 0);           /* mov dword [ebp-0x14], 0x0 */
        l_0x1016_57e3:
            ii(0x1016_57e3, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_57e6, 3);  mov(eax, memd[ds, eax + 96]);         /* mov eax, [eax+0x60] */
            ii(0x1016_57e9, 3);  mov(memd[ss, ebp - 52], eax);         /* mov [ebp-0x34], eax */
            ii(0x1016_57ec, 4);  cmp(memd[ss, ebp - 52], 0);           /* cmp dword [ebp-0x34], 0x0 */
            ii(0x1016_57f0, 2);  if(jz(0x1016_580d, 0x1b)) goto l_0x1016_580d;/* jz 0x1016580d */
            ii(0x1016_57f2, 3);  mov(eax, memd[ss, ebp - 52]);         /* mov eax, [ebp-0x34] */
            ii(0x1016_57f5, 3);  mov(memd[ss, ebp - 56], eax);         /* mov [ebp-0x38], eax */
            ii(0x1016_57f8, 3);  mov(eax, memd[ss, ebp - 56]);         /* mov eax, [ebp-0x38] */
            ii(0x1016_57fb, 3);  mov(ebx, memd[ds, eax + 39]);         /* mov ebx, [eax+0x27] */
            ii(0x1016_57fe, 5);  mov(edx, 2);                          /* mov edx, 0x2 */
            ii(0x1016_5803, 3);  mov(eax, memd[ss, ebp - 56]);         /* mov eax, [ebp-0x38] */
            ii(0x1016_5806, 2);  call_abs(memd[ds, ebx]);              /* call dword [ebx] */
            ii(0x1016_5808, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1016_580b, 2);  jmp(0x1016_5814, 7); goto l_0x1016_5814;/* jmp 0x10165814 */
        l_0x1016_580d:
            ii(0x1016_580d, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
        l_0x1016_5814:
            ii(0x1016_5814, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x1016_5819, 5);  call(0x1007_6600, -0xe_f21e);         /* call 0x10076600 */
            ii(0x1016_581e, 5);  call(0x100f_fa70, -0x6_5db3);         /* call 0x100ffa70 */
            ii(0x1016_5823, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1016_5828, 5);  call(0x1010_0efe, -0x6_492f);         /* call 0x10100efe */
            ii(0x1016_582d, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1016_5832, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_5835, 5);  call(0x100d_6999, -0x8_eea1);         /* call 0x100d6999 */
            ii(0x1016_583a, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1016_583d, 7);  test(memd[ss, ebp - 4], 2);           /* test dword [ebp-0x4], 0x2 */
            ii(0x1016_5844, 2);  if(jz(0x1016_584e, 8)) goto l_0x1016_584e;/* jz 0x1016584e */
            ii(0x1016_5846, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_5849, 5);  call(Definitions.sys_delete, 0x716);  /* call 0x10165f64 */
        l_0x1016_584e:
            ii(0x1016_584e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_5851, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1016_5854, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1016_5857, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1016_5859, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1016_585a, 1);  pop(edi);                             /* pop edi */
            ii(0x1016_585b, 1);  pop(esi);                             /* pop esi */
            ii(0x1016_585c, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1016_585d, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1016_585e, 1);  ret();                                /* ret */
        }
    }
}
