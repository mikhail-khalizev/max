using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_55d3-8e30d751")]
        public void Method_1009_55d3()
        {
            ii(0x1009_55d3, 5);  push(0x60);                           /* push 0x60 */
            ii(0x1009_55d8, 5);  call(Definitions.sys_check_available_stack_size, 0xd_0775);/* call 0x10165d52 */
            ii(0x1009_55dd, 1);  push(esi);                            /* push esi */
            ii(0x1009_55de, 1);  push(edi);                            /* push edi */
            ii(0x1009_55df, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_55e0, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_55e2, 6);  sub(esp, 0x4c);                       /* sub esp, 0x4c */
            ii(0x1009_55e8, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_55eb, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x1009_55ee, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1009_55f1, 3);  mov(memd[ss, ebp - 8], ecx);          /* mov [ebp-0x8], ecx */
            ii(0x1009_55f4, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_55f7, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x1009_55fa, 5);  call(0x1007_6338, -0x1_f2c7);         /* call 0x10076338 */
            ii(0x1009_55ff, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_5601, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1009_5604, 5);  call(0x1007_64b8, -0x1_f151);         /* call 0x100764b8 */
            ii(0x1009_5609, 5);  mov(eax, memd[ds, 0x101c_8172]);      /* mov eax, [0x101c8172] */
            ii(0x1009_560e, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_5611, 1);  push(eax);                            /* push eax */
            ii(0x1009_5612, 6);  mov(ecx, memd[ds, 0x101c_8170]);      /* mov ecx, [0x101c8170] */
            ii(0x1009_5618, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x1009_561b, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1009_561d, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_561f, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x1009_5622, 5);  call(0x1008_b148, -0xa4df);           /* call 0x1008b148 */
            ii(0x1009_5627, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1009_562a, 5);  call(Definitions.my_ctor_0x101b_4184, -0x1_eb3f);/* call 0x10076af0 */
            ii(0x1009_562f, 2);  jmp(0x1009_5639, 8); goto l_0x1009_5639;/* jmp 0x10095639 */
        l_0x1009_5631:
            ii(0x1009_5631, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1009_5634, 5);  call(0x1007_6bf8, -0x1_ea41);         /* call 0x10076bf8 */
        l_0x1009_5639:
            ii(0x1009_5639, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_563b, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1009_563e, 5);  call(0x1013_ad71, 0xa_572e);          /* call 0x1013ad71 */
            ii(0x1009_5643, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_5645, 6);  if(jz(0x1009_5727, 0xdc)) goto l_0x1009_5727;/* jz 0x10095727 */
            ii(0x1009_564b, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1009_564e, 5);  call(0x1007_63a0, -0x1_f2b3);         /* call 0x100763a0 */
            ii(0x1009_5653, 5);  cmp(memw[ds, eax + 8], 0xc);          /* cmp word [eax+0x8], 0xc */
            ii(0x1009_5658, 2);  if(jz(0x1009_5669, 0xf)) goto l_0x1009_5669;/* jz 0x10095669 */
            ii(0x1009_565a, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1009_565d, 5);  call(0x1007_63a0, -0x1_f2c2);         /* call 0x100763a0 */
            ii(0x1009_5662, 5);  cmp(memw[ds, eax + 8], 0x21);         /* cmp word [eax+0x8], 0x21 */
            ii(0x1009_5667, 2);  if(jnz(0x1009_566b, 2)) goto l_0x1009_566b;/* jnz 0x1009566b */
        l_0x1009_5669:
            ii(0x1009_5669, 2);  jmp(0x1009_567a, 0xf); goto l_0x1009_567a;/* jmp 0x1009567a */
        l_0x1009_566b:
            ii(0x1009_566b, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1009_566e, 5);  call(0x1007_63a0, -0x1_f2d3);         /* call 0x100763a0 */
            ii(0x1009_5673, 5);  cmp(memw[ds, eax + 8], 0x27);         /* cmp word [eax+0x8], 0x27 */
            ii(0x1009_5678, 2);  if(jnz(0x1009_567f, 5)) goto l_0x1009_567f;/* jnz 0x1009567f */
        l_0x1009_567a:
            ii(0x1009_567a, 5);  jmp(0x1009_5722, 0xa3); goto l_0x1009_5722;/* jmp 0x10095722 */
        l_0x1009_567f:
            ii(0x1009_567f, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1009_5682, 5);  call(0x1007_63a0, -0x1_f2e7);         /* call 0x100763a0 */
            ii(0x1009_5687, 4);  test(memb[ds, eax + 18], 0x10);       /* test byte [eax+0x12], 0x10 */
            ii(0x1009_568b, 2);  if(jz(0x1009_5695, 8)) goto l_0x1009_5695;/* jz 0x10095695 */
            ii(0x1009_568d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_5690, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1009_5693, 2);  jmp(0x1009_569c, 7); goto l_0x1009_569c;/* jmp 0x1009569c */
        l_0x1009_5695:
            ii(0x1009_5695, 7);  mov(memd[ss, ebp - 20], 1);           /* mov dword [ebp-0x14], 0x1 */
        l_0x1009_569c:
            ii(0x1009_569c, 3);  lea(edx, memd[ss, ebp - 64]);         /* lea edx, [ebp-0x40] */
            ii(0x1009_569f, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1009_56a2, 5);  call(0x1007_63a0, -0x1_f307);         /* call 0x100763a0 */
            ii(0x1009_56a7, 5);  call(0x1015_2532, 0xb_ce86);          /* call 0x10152532 */
            ii(0x1009_56ac, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1009_56b0, 3);  sub(memd[ss, ebp - 64], eax);         /* sub [ebp-0x40], eax */
            ii(0x1009_56b3, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1009_56b7, 3);  add(memd[ss, ebp - 56], eax);         /* add [ebp-0x38], eax */
            ii(0x1009_56ba, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1009_56be, 3);  sub(memd[ss, ebp - 60], eax);         /* sub [ebp-0x3c], eax */
            ii(0x1009_56c1, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1009_56c5, 3);  add(memd[ss, ebp - 52], eax);         /* add [ebp-0x34], eax */
            ii(0x1009_56c8, 3);  mov(eax, memd[ss, ebp - 64]);         /* mov eax, [ebp-0x40] */
            ii(0x1009_56cb, 4);  mov(memw[ss, ebp - 48], ax);          /* mov [ebp-0x30], ax */
            ii(0x1009_56cf, 2);  jmp(0x1009_56d8, 7); goto l_0x1009_56d8;/* jmp 0x100956d8 */
        l_0x1009_56d1:
            ii(0x1009_56d1, 3);  mov(eax, memd[ss, ebp - 48]);         /* mov eax, [ebp-0x30] */
            ii(0x1009_56d4, 4);  inc(memw[ss, ebp - 48]);              /* inc word [ebp-0x30] */
        l_0x1009_56d8:
            ii(0x1009_56d8, 4);  movsx(eax, memw[ss, ebp - 48]);       /* movsx eax, word [ebp-0x30] */
            ii(0x1009_56dc, 3);  cmp(eax, memd[ss, ebp - 56]);         /* cmp eax, [ebp-0x38] */
            ii(0x1009_56df, 2);  if(jge(0x1009_5722, 0x41)) goto l_0x1009_5722;/* jge 0x10095722 */
            ii(0x1009_56e1, 3);  mov(eax, memd[ss, ebp - 60]);         /* mov eax, [ebp-0x3c] */
            ii(0x1009_56e4, 4);  mov(memw[ss, ebp - 46], ax);          /* mov [ebp-0x2e], ax */
            ii(0x1009_56e8, 2);  jmp(0x1009_56f1, 7); goto l_0x1009_56f1;/* jmp 0x100956f1 */
        l_0x1009_56ea:
            ii(0x1009_56ea, 3);  mov(eax, memd[ss, ebp - 46]);         /* mov eax, [ebp-0x2e] */
            ii(0x1009_56ed, 4);  inc(memw[ss, ebp - 46]);              /* inc word [ebp-0x2e] */
        l_0x1009_56f1:
            ii(0x1009_56f1, 4);  movsx(eax, memw[ss, ebp - 46]);       /* movsx eax, word [ebp-0x2e] */
            ii(0x1009_56f5, 3);  cmp(eax, memd[ss, ebp - 52]);         /* cmp eax, [ebp-0x34] */
            ii(0x1009_56f8, 2);  if(jge(0x1009_5720, 0x26)) goto l_0x1009_5720;/* jge 0x10095720 */
            ii(0x1009_56fa, 3);  lea(edx, memd[ss, ebp - 48]);         /* lea edx, [ebp-0x30] */
            ii(0x1009_56fd, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x1009_5700, 5);  call(0x1010_82ce, 0x7_2bc9);          /* call 0x101082ce */
            ii(0x1009_5705, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_5707, 2);  if(jz(0x1009_571e, 0x15)) goto l_0x1009_571e;/* jz 0x1009571e */
            ii(0x1009_5709, 4);  movsx(eax, memw[ss, ebp - 48]);       /* movsx eax, word [ebp-0x30] */
            ii(0x1009_570d, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1009_5710, 3);  add(eax, memd[ss, ebp - 12]);         /* add eax, [ebp-0xc] */
            ii(0x1009_5713, 4);  movsx(edx, memw[ss, ebp - 46]);       /* movsx edx, word [ebp-0x2e] */
            ii(0x1009_5717, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1009_5719, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1009_571b, 3);  mov(memb[ds, eax], 0);                /* mov byte [eax], 0x0 */
        l_0x1009_571e:
            ii(0x1009_571e, 2);  jmp(0x1009_56ea, -0x36); goto l_0x1009_56ea;/* jmp 0x100956ea */
        l_0x1009_5720:
            ii(0x1009_5720, 2);  jmp(0x1009_56d1, -0x51); goto l_0x1009_56d1;/* jmp 0x100956d1 */
        l_0x1009_5722:
            ii(0x1009_5722, 5);  jmp(0x1009_5631, -0xf6); goto l_0x1009_5631;/* jmp 0x10095631 */
        l_0x1009_5727:
            ii(0x1009_5727, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_572a, 3);  add(eax, 0x21);                       /* add eax, 0x21 */
            ii(0x1009_572d, 5);  call(0x1009_c6c8, 0x6f96);            /* call 0x1009c6c8 */
            ii(0x1009_5732, 3);  lea(ebx, memd[ss, ebp - 68]);         /* lea ebx, [ebp-0x44] */
            ii(0x1009_5735, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_5737, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1009_5739, 5);  call(0x1009_c5dc, 0x6e9e);            /* call 0x1009c5dc */
            ii(0x1009_573e, 2);  jmp(0x1009_5748, 8); goto l_0x1009_5748;/* jmp 0x10095748 */
        l_0x1009_5740:
            ii(0x1009_5740, 3);  lea(eax, memd[ss, ebp - 68]);         /* lea eax, [ebp-0x44] */
            ii(0x1009_5743, 5);  call(0x1007_6bf8, -0x1_eb50);         /* call 0x10076bf8 */
        l_0x1009_5748:
            ii(0x1009_5748, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_574a, 3);  lea(eax, memd[ss, ebp - 68]);         /* lea eax, [ebp-0x44] */
            ii(0x1009_574d, 5);  call(0x1013_ad71, 0xa_561f);          /* call 0x1013ad71 */
            ii(0x1009_5752, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_5754, 6);  if(jz(0x1009_5867, 0x10d)) goto l_0x1009_5867;/* jz 0x10095867 */
            ii(0x1009_575a, 3);  lea(eax, memd[ss, ebp - 68]);         /* lea eax, [ebp-0x44] */
            ii(0x1009_575d, 5);  call(0x1009_c52c, 0x6dca);            /* call 0x1009c52c */
            ii(0x1009_5762, 3);  cmp(eax, memd[ss, ebp - 8]);          /* cmp eax, [ebp-0x8] */
            ii(0x1009_5765, 2);  if(jz(0x1009_5782, 0x1b)) goto l_0x1009_5782;/* jz 0x10095782 */
            ii(0x1009_5767, 3);  lea(eax, memd[ss, ebp - 68]);         /* lea eax, [ebp-0x44] */
            ii(0x1009_576a, 5);  call(0x1009_c4f8, 0x6d89);            /* call 0x1009c4f8 */
            ii(0x1009_576f, 3);  mov(memd[ss, ebp - 72], eax);         /* mov [ebp-0x48], eax */
            ii(0x1009_5772, 3);  mov(eax, memd[ss, ebp - 72]);         /* mov eax, [ebp-0x48] */
            ii(0x1009_5775, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x1009_5778, 3);  mov(eax, memd[ss, ebp - 72]);         /* mov eax, [ebp-0x48] */
            ii(0x1009_577b, 3);  call_abs(memd[ds, edx + 116]);        /* call dword [edx+0x74] */
            ii(0x1009_577e, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_5780, 2);  if(jnz(0x1009_5787, 5)) goto l_0x1009_5787;/* jnz 0x10095787 */
        l_0x1009_5782:
            ii(0x1009_5782, 5);  jmp(0x1009_5862, 0xdb); goto l_0x1009_5862;/* jmp 0x10095862 */
        l_0x1009_5787:
            ii(0x1009_5787, 3);  lea(eax, memd[ss, ebp - 68]);         /* lea eax, [ebp-0x44] */
            ii(0x1009_578a, 5);  call(0x1009_c4f8, 0x6d69);            /* call 0x1009c4f8 */
            ii(0x1009_578f, 5);  call(0x1009_c4c4, 0x6d30);            /* call 0x1009c4c4 */
            ii(0x1009_5794, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1009_5797, 5);  cmp(memw[ss, ebp - 24], 0xc);         /* cmp word [ebp-0x18], 0xc */
            ii(0x1009_579c, 2);  if(jz(0x1009_57a5, 7)) goto l_0x1009_57a5;/* jz 0x100957a5 */
            ii(0x1009_579e, 5);  cmp(memw[ss, ebp - 24], 0x21);        /* cmp word [ebp-0x18], 0x21 */
            ii(0x1009_57a3, 2);  if(jnz(0x1009_57a7, 2)) goto l_0x1009_57a7;/* jnz 0x100957a7 */
        l_0x1009_57a5:
            ii(0x1009_57a5, 2);  jmp(0x1009_57ae, 7); goto l_0x1009_57ae;/* jmp 0x100957ae */
        l_0x1009_57a7:
            ii(0x1009_57a7, 5);  cmp(memw[ss, ebp - 24], 0x27);        /* cmp word [ebp-0x18], 0x27 */
            ii(0x1009_57ac, 2);  if(jnz(0x1009_57b3, 5)) goto l_0x1009_57b3;/* jnz 0x100957b3 */
        l_0x1009_57ae:
            ii(0x1009_57ae, 5);  jmp(0x1009_5862, 0xaf); goto l_0x1009_5862;/* jmp 0x10095862 */
        l_0x1009_57b3:
            ii(0x1009_57b3, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1009_57b7, 3);  imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
            ii(0x1009_57ba, 7);  test(memb[ds, eax + 0x101c_81c0], 0x10);/* test byte [eax+0x101c81c0], 0x10 */
            ii(0x1009_57c1, 2);  if(jz(0x1009_57cb, 8)) goto l_0x1009_57cb;/* jz 0x100957cb */
            ii(0x1009_57c3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_57c6, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1009_57c9, 2);  jmp(0x1009_57d2, 7); goto l_0x1009_57d2;/* jmp 0x100957d2 */
        l_0x1009_57cb:
            ii(0x1009_57cb, 7);  mov(memd[ss, ebp - 20], 1);           /* mov dword [ebp-0x14], 0x1 */
        l_0x1009_57d2:
            ii(0x1009_57d2, 3);  lea(eax, memd[ss, ebp - 68]);         /* lea eax, [ebp-0x44] */
            ii(0x1009_57d5, 5);  call(0x1009_c4f8, 0x6d1e);            /* call 0x1009c4f8 */
            ii(0x1009_57da, 3);  mov(memd[ss, ebp - 76], eax);         /* mov [ebp-0x4c], eax */
            ii(0x1009_57dd, 3);  mov(eax, memd[ss, ebp - 76]);         /* mov eax, [ebp-0x4c] */
            ii(0x1009_57e0, 3);  mov(ebx, memd[ds, eax + 2]);          /* mov ebx, [eax+0x2] */
            ii(0x1009_57e3, 3);  lea(edx, memd[ss, ebp - 64]);         /* lea edx, [ebp-0x40] */
            ii(0x1009_57e6, 3);  mov(eax, memd[ss, ebp - 76]);         /* mov eax, [ebp-0x4c] */
            ii(0x1009_57e9, 3);  call_abs(memd[ds, ebx + 28]);         /* call dword [ebx+0x1c] */
            ii(0x1009_57ec, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1009_57f0, 3);  sub(memd[ss, ebp - 64], eax);         /* sub [ebp-0x40], eax */
            ii(0x1009_57f3, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1009_57f7, 3);  add(memd[ss, ebp - 56], eax);         /* add [ebp-0x38], eax */
            ii(0x1009_57fa, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1009_57fe, 3);  sub(memd[ss, ebp - 60], eax);         /* sub [ebp-0x3c], eax */
            ii(0x1009_5801, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1009_5805, 3);  add(memd[ss, ebp - 52], eax);         /* add [ebp-0x34], eax */
            ii(0x1009_5808, 3);  mov(eax, memd[ss, ebp - 64]);         /* mov eax, [ebp-0x40] */
            ii(0x1009_580b, 4);  mov(memw[ss, ebp - 48], ax);          /* mov [ebp-0x30], ax */
            ii(0x1009_580f, 2);  jmp(0x1009_5818, 7); goto l_0x1009_5818;/* jmp 0x10095818 */
        l_0x1009_5811:
            ii(0x1009_5811, 3);  mov(eax, memd[ss, ebp - 48]);         /* mov eax, [ebp-0x30] */
            ii(0x1009_5814, 4);  inc(memw[ss, ebp - 48]);              /* inc word [ebp-0x30] */
        l_0x1009_5818:
            ii(0x1009_5818, 4);  movsx(eax, memw[ss, ebp - 48]);       /* movsx eax, word [ebp-0x30] */
            ii(0x1009_581c, 3);  cmp(eax, memd[ss, ebp - 56]);         /* cmp eax, [ebp-0x38] */
            ii(0x1009_581f, 2);  if(jge(0x1009_5862, 0x41)) goto l_0x1009_5862;/* jge 0x10095862 */
            ii(0x1009_5821, 3);  mov(eax, memd[ss, ebp - 60]);         /* mov eax, [ebp-0x3c] */
            ii(0x1009_5824, 4);  mov(memw[ss, ebp - 46], ax);          /* mov [ebp-0x2e], ax */
            ii(0x1009_5828, 2);  jmp(0x1009_5831, 7); goto l_0x1009_5831;/* jmp 0x10095831 */
        l_0x1009_582a:
            ii(0x1009_582a, 3);  mov(eax, memd[ss, ebp - 46]);         /* mov eax, [ebp-0x2e] */
            ii(0x1009_582d, 4);  inc(memw[ss, ebp - 46]);              /* inc word [ebp-0x2e] */
        l_0x1009_5831:
            ii(0x1009_5831, 4);  movsx(eax, memw[ss, ebp - 46]);       /* movsx eax, word [ebp-0x2e] */
            ii(0x1009_5835, 3);  cmp(eax, memd[ss, ebp - 52]);         /* cmp eax, [ebp-0x34] */
            ii(0x1009_5838, 2);  if(jge(0x1009_5860, 0x26)) goto l_0x1009_5860;/* jge 0x10095860 */
            ii(0x1009_583a, 3);  lea(edx, memd[ss, ebp - 48]);         /* lea edx, [ebp-0x30] */
            ii(0x1009_583d, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x1009_5840, 5);  call(0x1010_82ce, 0x7_2a89);          /* call 0x101082ce */
            ii(0x1009_5845, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_5847, 2);  if(jz(0x1009_585e, 0x15)) goto l_0x1009_585e;/* jz 0x1009585e */
            ii(0x1009_5849, 4);  movsx(eax, memw[ss, ebp - 48]);       /* movsx eax, word [ebp-0x30] */
            ii(0x1009_584d, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1009_5850, 3);  add(eax, memd[ss, ebp - 12]);         /* add eax, [ebp-0xc] */
            ii(0x1009_5853, 4);  movsx(edx, memw[ss, ebp - 46]);       /* movsx edx, word [ebp-0x2e] */
            ii(0x1009_5857, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1009_5859, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1009_585b, 3);  mov(memb[ds, eax], 0);                /* mov byte [eax], 0x0 */
        l_0x1009_585e:
            ii(0x1009_585e, 2);  jmp(0x1009_582a, -0x36); goto l_0x1009_582a;/* jmp 0x1009582a */
        l_0x1009_5860:
            ii(0x1009_5860, 2);  jmp(0x1009_5811, -0x51); goto l_0x1009_5811;/* jmp 0x10095811 */
        l_0x1009_5862:
            ii(0x1009_5862, 5);  jmp(0x1009_5740, -0x127); goto l_0x1009_5740;/* jmp 0x10095740 */
        l_0x1009_5867:
            ii(0x1009_5867, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_5869, 3);  lea(eax, memd[ss, ebp - 68]);         /* lea eax, [ebp-0x44] */
            ii(0x1009_586c, 5);  call(0x1009_ba6c, 0x61fb);            /* call 0x1009ba6c */
            ii(0x1009_5871, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_5873, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1009_5876, 5);  call(0x1007_5f6c, -0x1_f90f);         /* call 0x10075f6c */
            ii(0x1009_587b, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_587d, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_587e, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_587f, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_5880, 1);  ret();                                /* ret */
        }
    }
}
