using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_f52c-7cdad0b6")]
        public void Method_1008_f52c()
        {
            ii(0x1008_f52c, 5);  push(0x74);                           /* push 0x74 */
            ii(0x1008_f531, 5);  call(Definitions.sys_check_available_stack_size, 0xd_681c);/* call 0x10165d52 */
            ii(0x1008_f536, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_f537, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_f538, 1);  push(edx);                            /* push edx */
            ii(0x1008_f539, 1);  push(esi);                            /* push esi */
            ii(0x1008_f53a, 1);  push(edi);                            /* push edi */
            ii(0x1008_f53b, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_f53c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_f53e, 6);  sub(esp, 0x50);                       /* sub esp, 0x50 */
            ii(0x1008_f544, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_f547, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_f54a, 3);  add(eax, 0x2b);                       /* add eax, 0x2b */
            ii(0x1008_f54d, 5);  call(0x1007_6b90, -0x1_89c2);         /* call 0x10076b90 */
            ii(0x1008_f552, 1);  cwde();                               /* cwde */
            ii(0x1008_f553, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_f555, 2);  if(jnz(0x1008_f579, 0x22)) goto l_0x1008_f579;/* jnz 0x1008f579 */
            ii(0x1008_f557, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_f55a, 3);  add(edx, 0x21);                       /* add edx, 0x21 */
            ii(0x1008_f55d, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_f560, 5);  call(0x1007_5e64, -0x1_9701);         /* call 0x10075e64 */
            ii(0x1008_f565, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_f567, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_f56a, 3);  mov(eax, memd[ds, eax + 17]);         /* mov eax, [eax+0x11] */
            ii(0x1008_f56d, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1008_f570, 5);  call(0x1008_ba6a, -0x3b0b);           /* call 0x1008ba6a */
            ii(0x1008_f575, 2);  cmp(al, 2);                           /* cmp al, 0x2 */
            ii(0x1008_f577, 2);  if(jz(0x1008_f57e, 5)) goto l_0x1008_f57e;/* jz 0x1008f57e */
        l_0x1008_f579:
            ii(0x1008_f579, 5);  jmp(0x1008_f753, 0x1d5); goto l_0x1008_f753;/* jmp 0x1008f753 */
        l_0x1008_f57e:
            ii(0x1008_f57e, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1008_f581, 5);  call(Definitions.my_ctor_0x101b_4184, -0x1_8a96);/* call 0x10076af0 */
            ii(0x1008_f586, 4);  or(memb[ss, ebp - 12], 1);            /* or byte [ebp-0xc], 0x1 */
            ii(0x1008_f58a, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_f58d, 5);  call(0x1009_c350, 0xcdbe);            /* call 0x1009c350 */
            ii(0x1008_f592, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1008_f595, 4);  and(memb[ss, ebp - 12], -2 /* 0xfe */);/* and byte [ebp-0xc], 0xfe */
            ii(0x1008_f599, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_f59c, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1008_f59f, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1008_f5a2, 3);  mov(ebx, memd[ds, eax + 2]);          /* mov ebx, [eax+0x2] */
            ii(0x1008_f5a5, 3);  lea(edx, memd[ss, ebp - 48]);         /* lea edx, [ebp-0x30] */
            ii(0x1008_f5a8, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1008_f5ab, 3);  call_abs(memd[ds, ebx + 28]);         /* call dword [ebx+0x1c] */
            ii(0x1008_f5ae, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_f5b1, 4);  mov(memb[ds, eax + 37], 7);           /* mov byte [eax+0x25], 0x7 */
            ii(0x1008_f5b5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_f5b8, 3);  mov(eax, memd[ds, eax + 31]);         /* mov eax, [eax+0x1f] */
            ii(0x1008_f5bb, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1008_f5be, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_f5c0, 2);  if(jle(0x1008_f5cf, 0xd)) goto l_0x1008_f5cf;/* jle 0x1008f5cf */
            ii(0x1008_f5c2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_f5c5, 3);  mov(eax, memd[ds, eax + 33]);         /* mov eax, [eax+0x21] */
            ii(0x1008_f5c8, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1008_f5cb, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_f5cd, 2);  if(jg(0x1008_f5d1, 2)) goto l_0x1008_f5d1;/* jg 0x1008f5d1 */
        l_0x1008_f5cf:
            ii(0x1008_f5cf, 2);  jmp(0x1008_f5da, 9); goto l_0x1008_f5da;/* jmp 0x1008f5da */
        l_0x1008_f5d1:
            ii(0x1008_f5d1, 7);  mov(memd[ss, ebp - 52], 0);           /* mov dword [ebp-0x34], 0x0 */
            ii(0x1008_f5d8, 2);  jmp(0x1008_f5f3, 0x19); goto l_0x1008_f5f3;/* jmp 0x1008f5f3 */
        l_0x1008_f5da:
            ii(0x1008_f5da, 5);  mov(ecx, 0x5fb);                      /* mov ecx, 0x5fb */
            ii(0x1008_f5df, 5);  mov(ebx, StringDefinitions.AiBuildCpp3);/* mov ebx, 0x101a0563 */
            ii(0x1008_f5e4, 5);  mov(edx, StringDefinitions.SiteXGreater0SiteYGreater0);/* mov edx, 0x101a0570 */
            ii(0x1008_f5e9, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1008_f5eb, 5);  call(Definitions.sys_assert, 0xd_67a2);/* call 0x10165d92 */
            ii(0x1008_f5f0, 3);  mov(memd[ss, ebp - 52], eax);         /* mov [ebp-0x34], eax */
        l_0x1008_f5f3:
            ii(0x1008_f5f3, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_f5f5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_f5f8, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x1008_f5fb, 5);  call(0x1013_ad71, 0xa_b771);          /* call 0x1013ad71 */
            ii(0x1008_f600, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_f602, 2);  if(jz(0x1008_f61b, 0x17)) goto l_0x1008_f61b;/* jz 0x1008f61b */
            ii(0x1008_f604, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_f607, 4);  mov(memb[ds, eax + 37], 1);           /* mov byte [eax+0x25], 0x1 */
            ii(0x1008_f60b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_f60e, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x1008_f611, 5);  call(0x1007_6574, -0x1_90a2);         /* call 0x10076574 */
            ii(0x1008_f616, 5);  call(0x1015_287d, 0xc_3262);          /* call 0x1015287d */
        l_0x1008_f61b:
            ii(0x1008_f61b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_f61e, 3);  mov(eax, memd[ds, eax + 17]);         /* mov eax, [eax+0x11] */
            ii(0x1008_f621, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1008_f624, 3);  imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
            ii(0x1008_f627, 7);  test(memb[ds, eax + 0x101c_81c0], 0x10);/* test byte [eax+0x101c81c0], 0x10 */
            ii(0x1008_f62e, 2);  if(jz(0x1008_f638, 8)) goto l_0x1008_f638;/* jz 0x1008f638 */
            ii(0x1008_f630, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_f633, 5);  call(0x1008_f29d, -0x39b);            /* call 0x1008f29d */
        l_0x1008_f638:
            ii(0x1008_f638, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_f63b, 5);  call(0x1008_ed2b, -0x915);            /* call 0x1008ed2b */
            ii(0x1008_f640, 3);  mov(eax, memd[ss, ebp - 48]);         /* mov eax, [ebp-0x30] */
            ii(0x1008_f643, 4);  mov(memw[ss, ebp - 20], ax);          /* mov [ebp-0x14], ax */
            ii(0x1008_f647, 2);  jmp(0x1008_f650, 7); goto l_0x1008_f650;/* jmp 0x1008f650 */
        l_0x1008_f649:
            ii(0x1008_f649, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1008_f64c, 4);  inc(memw[ss, ebp - 20]);              /* inc word [ebp-0x14] */
        l_0x1008_f650:
            ii(0x1008_f650, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1008_f654, 3);  cmp(eax, memd[ss, ebp - 40]);         /* cmp eax, [ebp-0x28] */
            ii(0x1008_f657, 6);  if(jge(0x1008_f743, 0xe6)) goto l_0x1008_f743;/* jge 0x1008f743 */
            ii(0x1008_f65d, 3);  mov(eax, memd[ss, ebp - 44]);         /* mov eax, [ebp-0x2c] */
            ii(0x1008_f660, 4);  mov(memw[ss, ebp - 18], ax);          /* mov [ebp-0x12], ax */
            ii(0x1008_f664, 2);  jmp(0x1008_f66d, 7); goto l_0x1008_f66d;/* jmp 0x1008f66d */
        l_0x1008_f666:
            ii(0x1008_f666, 3);  mov(eax, memd[ss, ebp - 18]);         /* mov eax, [ebp-0x12] */
            ii(0x1008_f669, 4);  inc(memw[ss, ebp - 18]);              /* inc word [ebp-0x12] */
        l_0x1008_f66d:
            ii(0x1008_f66d, 4);  movsx(eax, memw[ss, ebp - 18]);       /* movsx eax, word [ebp-0x12] */
            ii(0x1008_f671, 3);  cmp(eax, memd[ss, ebp - 36]);         /* cmp eax, [ebp-0x24] */
            ii(0x1008_f674, 6);  if(jge(0x1008_f73e, 0xc4)) goto l_0x1008_f73e;/* jge 0x1008f73e */
            ii(0x1008_f67a, 3);  lea(edx, memd[ss, ebp - 20]);         /* lea edx, [ebp-0x14] */
            ii(0x1008_f67d, 3);  lea(eax, memd[ss, ebp - 56]);         /* lea eax, [ebp-0x38] */
            ii(0x1008_f680, 5);  call(0x1007_5e64, -0x1_9821);         /* call 0x10075e64 */
            ii(0x1008_f685, 5);  mov(ebx, 0x21);                       /* mov ebx, 0x21 */
            ii(0x1008_f68a, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_f68c, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1008_f68e, 5);  call(0x1008_ba6a, -0x3c29);           /* call 0x1008ba6a */
            ii(0x1008_f693, 2);  cmp(al, 1);                           /* cmp al, 0x1 */
            ii(0x1008_f695, 6);  if(jnz(0x1008_f739, 0x9e)) goto l_0x1008_f739;/* jnz 0x1008f739 */
            ii(0x1008_f69b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_f69e, 4);  mov(memb[ds, eax + 42], 1);           /* mov byte [eax+0x2a], 0x1 */
            ii(0x1008_f6a2, 5);  mov(eax, 0x35);                       /* mov eax, 0x35 */
            ii(0x1008_f6a7, 5);  call(Definitions.sys_new, 0xd_6754);  /* call 0x10165e00 */
            ii(0x1008_f6ac, 3);  mov(memd[ss, ebp - 60], eax);         /* mov [ebp-0x3c], eax */
            ii(0x1008_f6af, 3);  mov(eax, memd[ss, ebp - 60]);         /* mov eax, [ebp-0x3c] */
            ii(0x1008_f6b2, 3);  mov(memd[ss, ebp - 64], eax);         /* mov [ebp-0x40], eax */
            ii(0x1008_f6b5, 4);  cmp(memd[ss, ebp - 64], 0);           /* cmp dword [ebp-0x40], 0x0 */
            ii(0x1008_f6b9, 2);  if(jz(0x1008_f6ff, 0x44)) goto l_0x1008_f6ff;/* jz 0x1008f6ff */
            ii(0x1008_f6bb, 2);  push(0);                              /* push 0x0 */
            ii(0x1008_f6bd, 3);  lea(edx, memd[ss, ebp - 20]);         /* lea edx, [ebp-0x14] */
            ii(0x1008_f6c0, 3);  lea(eax, memd[ss, ebp - 68]);         /* lea eax, [ebp-0x44] */
            ii(0x1008_f6c3, 5);  call(0x1007_5e64, -0x1_9864);         /* call 0x10075e64 */
            ii(0x1008_f6c8, 1);  push(eax);                            /* push eax */
            ii(0x1008_f6c9, 5);  mov(ecx, 0x21);                       /* mov ecx, 0x21 */
            ii(0x1008_f6ce, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_f6d1, 3);  mov(memd[ss, ebp - 72], eax);         /* mov [ebp-0x48], eax */
            ii(0x1008_f6d4, 3);  mov(eax, memd[ss, ebp - 72]);         /* mov eax, [ebp-0x48] */
            ii(0x1008_f6d7, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x1008_f6da, 3);  mov(eax, memd[ss, ebp - 72]);         /* mov eax, [ebp-0x48] */
            ii(0x1008_f6dd, 3);  call_abs(memd[ds, edx + 20]);         /* call dword [edx+0x14] */
            ii(0x1008_f6e0, 6);  sub(eax, 0x80);                       /* sub eax, 0x80 */
            ii(0x1008_f6e6, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1008_f6e9, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_f6ec, 3);  mov(eax, memd[ss, ebp - 60]);         /* mov eax, [ebp-0x3c] */
            ii(0x1008_f6ef, 5);  call(0x1008_c999, -0x2d5b);           /* call 0x1008c999 */
            ii(0x1008_f6f4, 3);  mov(memd[ss, ebp - 76], eax);         /* mov [ebp-0x4c], eax */
            ii(0x1008_f6f7, 3);  mov(eax, memd[ss, ebp - 76]);         /* mov eax, [ebp-0x4c] */
            ii(0x1008_f6fa, 3);  mov(memd[ss, ebp - 80], eax);         /* mov [ebp-0x50], eax */
            ii(0x1008_f6fd, 2);  jmp(0x1008_f705, 6); goto l_0x1008_f705;/* jmp 0x1008f705 */
        l_0x1008_f6ff:
            ii(0x1008_f6ff, 3);  mov(eax, memd[ss, ebp - 64]);         /* mov eax, [ebp-0x40] */
            ii(0x1008_f702, 3);  mov(memd[ss, ebp - 80], eax);         /* mov [ebp-0x50], eax */
        l_0x1008_f705:
            ii(0x1008_f705, 3);  mov(edx, memd[ss, ebp - 80]);         /* mov edx, [ebp-0x50] */
            ii(0x1008_f708, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_f70b, 5);  call(0x1009_c2d4, 0xcbc4);            /* call 0x1009c2d4 */
            ii(0x1008_f710, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_f713, 5);  call(0x1009_c274, 0xcb5c);            /* call 0x1009c274 */
            ii(0x1008_f718, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_f71a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_f71d, 3);  add(eax, 0x2b);                       /* add eax, 0x2b */
            ii(0x1008_f720, 5);  call(0x1009_ca40, 0xd31b);            /* call 0x1009ca40 */
            ii(0x1008_f725, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_f728, 5);  call(0x1009_c274, 0xcb47);            /* call 0x1009c274 */
            ii(0x1008_f72d, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_f72f, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1008_f734, 5);  call(0x100a_4d50, 0x1_5617);          /* call 0x100a4d50 */
        l_0x1008_f739:
            ii(0x1008_f739, 5);  jmp(0x1008_f666, -0xd8); goto l_0x1008_f666;/* jmp 0x1008f666 */
        l_0x1008_f73e:
            ii(0x1008_f73e, 5);  jmp(0x1008_f649, -0xfa); goto l_0x1008_f649;/* jmp 0x1008f649 */
        l_0x1008_f743:
            ii(0x1008_f743, 4);  mov(memb[ss, ebp - 8], 1);            /* mov byte [ebp-0x8], 0x1 */
            ii(0x1008_f747, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_f749, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_f74c, 5);  call(0x1009_c0a4, 0xc953);            /* call 0x1009c0a4 */
            ii(0x1008_f751, 2);  jmp(0x1008_f75f, 0xc); goto l_0x1008_f75f;/* jmp 0x1008f75f */
        l_0x1008_f753:
            ii(0x1008_f753, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_f756, 5);  call(0x1008_ed2b, -0xa30);            /* call 0x1008ed2b */
            ii(0x1008_f75b, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
        l_0x1008_f75f:
            ii(0x1008_f75f, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x1008_f762, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_f764, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_f765, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_f766, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_f767, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_f768, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_f769, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_f76a, 1);  ret();                                /* ret */
        }
    }
}
