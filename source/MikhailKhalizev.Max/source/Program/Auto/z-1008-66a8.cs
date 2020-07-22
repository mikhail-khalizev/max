using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_66a8-8c1506f3")]
        public void Method_1008_66a8()
        {
            ii(0x1008_66a8, 5);  push(0x38);                           /* push 0x38 */
            ii(0x1008_66ad, 5);  call(Definitions.sys_check_available_stack_size, 0xd_f6a0);/* call 0x10165d52 */
            ii(0x1008_66b2, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_66b3, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_66b4, 1);  push(edx);                            /* push edx */
            ii(0x1008_66b5, 1);  push(esi);                            /* push esi */
            ii(0x1008_66b6, 1);  push(edi);                            /* push edi */
            ii(0x1008_66b7, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_66b8, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_66ba, 6);  sub(esp, 0x1c);                       /* sub esp, 0x1c */
            ii(0x1008_66c0, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_66c3, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_66c5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_66c8, 3);  add(eax, 0x2a);                       /* add eax, 0x2a */
            ii(0x1008_66cb, 5);  call(0x1013_ad11, 0xb_4641);          /* call 0x1013ad11 */
            ii(0x1008_66d0, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_66d2, 2);  if(jz(0x1008_66dd, 9)) goto l_0x1008_66dd;/* jz 0x100866dd */
            ii(0x1008_66d4, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x1008_66d8, 5);  jmp(0x1008_67f8, 0x11b); goto l_0x1008_67f8;/* jmp 0x100867f8 */
        l_0x1008_66dd:
            ii(0x1008_66dd, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_66e0, 3);  mov(edx, memd[ds, eax + 7]);          /* mov edx, [eax+0x7] */
            ii(0x1008_66e3, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1008_66e6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_66e9, 3);  add(eax, 0x2a);                       /* add eax, 0x2a */
            ii(0x1008_66ec, 5);  call(0x1008_9d7c, 0x368b);            /* call 0x10089d7c */
            ii(0x1008_66f1, 5);  call(0x1008_9f70, 0x387a);            /* call 0x10089f70 */
            ii(0x1008_66f6, 5);  call(0x1007_6074, -0x1_0687);         /* call 0x10076074 */
            ii(0x1008_66fb, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_66fd, 2);  if(jz(0x1008_6708, 9)) goto l_0x1008_6708;/* jz 0x10086708 */
            ii(0x1008_66ff, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x1008_6703, 5);  jmp(0x1008_67f8, 0xf0); goto l_0x1008_67f8;/* jmp 0x100867f8 */
        l_0x1008_6708:
            ii(0x1008_6708, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_670b, 3);  add(eax, 0x20);                       /* add eax, 0x20 */
            ii(0x1008_670e, 5);  call(0x1008_9d08, 0x35f5);            /* call 0x10089d08 */
            ii(0x1008_6713, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_6715, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_6718, 5);  call(0x1008_9be4, 0x34c7);            /* call 0x10089be4 */
            ii(0x1008_671d, 4);  or(memb[ss, ebp - 12], 1);            /* or byte [ebp-0xc], 0x1 */
            ii(0x1008_6721, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1008_6724, 5);  call(0x1007_64fc, -0x1_022d);         /* call 0x100764fc */
            ii(0x1008_6729, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1008_672c, 4);  and(memb[ss, ebp - 12], -2 /* 0xfe */);/* and byte [ebp-0xc], 0xfe */
            ii(0x1008_6730, 2);  jmp(0x1008_673a, 8); goto l_0x1008_673a;/* jmp 0x1008673a */
        l_0x1008_6732:
            ii(0x1008_6732, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_6735, 5);  call(0x1007_6bf8, -0xfb42);           /* call 0x10076bf8 */
        l_0x1008_673a:
            ii(0x1008_673a, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_673c, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_673f, 5);  call(0x1013_ad71, 0xb_462d);          /* call 0x1013ad71 */
            ii(0x1008_6744, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_6746, 6);  if(jz(0x1008_67ca, 0x7e)) goto l_0x1008_67ca;/* jz 0x100867ca */
            ii(0x1008_674c, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_674f, 5);  call(0x1008_9acc, 0x3378);            /* call 0x10089acc */
            ii(0x1008_6754, 5);  call(0x1008_9fc4, 0x386b);            /* call 0x10089fc4 */
            ii(0x1008_6759, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_675b, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1008_675e, 5);  call(0x1007_643c, -0x1_0327);         /* call 0x1007643c */
            ii(0x1008_6763, 2);  jmp(0x1008_676d, 8); goto l_0x1008_676d;/* jmp 0x1008676d */
        l_0x1008_6765:
            ii(0x1008_6765, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1008_6768, 5);  call(0x1007_6bf8, -0xfb75);           /* call 0x10076bf8 */
        l_0x1008_676d:
            ii(0x1008_676d, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_676f, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1008_6772, 5);  call(0x1013_ad71, 0xb_45fa);          /* call 0x1013ad71 */
            ii(0x1008_6777, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_6779, 2);  if(jz(0x1008_67c5, 0x4a)) goto l_0x1008_67c5;/* jz 0x100867c5 */
            ii(0x1008_677b, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1008_677e, 5);  call(0x1007_63a0, -0x1_03e3);         /* call 0x100763a0 */
            ii(0x1008_6783, 5);  call(0x1007_623c, -0x1_054c);         /* call 0x1007623c */
            ii(0x1008_6788, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1008_678b, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1008_678e, 4);  mov(dx, memw[ds, eax + 23]);          /* mov dx, [eax+0x17] */
            ii(0x1008_6792, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1008_6795, 4);  cmp(dx, memw[ds, eax + 18]);          /* cmp dx, [eax+0x12] */
            ii(0x1008_6799, 2);  if(jl(0x1008_67a9, 0xe)) goto l_0x1008_67a9;/* jl 0x100867a9 */
            ii(0x1008_679b, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1008_679e, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x1008_67a1, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1008_67a4, 3);  cmp(eax, 8);                          /* cmp eax, 0x8 */
            ii(0x1008_67a7, 2);  if(jl(0x1008_67c3, 0x1a)) goto l_0x1008_67c3;/* jl 0x100867c3 */
        l_0x1008_67a9:
            ii(0x1008_67a9, 4);  mov(memb[ss, ebp - 8], 1);            /* mov byte [ebp-0x8], 0x1 */
            ii(0x1008_67ad, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_67af, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1008_67b2, 5);  call(0x1007_5f6c, -0x1_084b);         /* call 0x10075f6c */
            ii(0x1008_67b7, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_67b9, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_67bc, 5);  call(0x1008_9044, 0x2883);            /* call 0x10089044 */
            ii(0x1008_67c1, 2);  jmp(0x1008_67f8, 0x35); goto l_0x1008_67f8;/* jmp 0x100867f8 */
        l_0x1008_67c3:
            ii(0x1008_67c3, 2);  jmp(0x1008_6765, -0x60); goto l_0x1008_6765;/* jmp 0x10086765 */
        l_0x1008_67c5:
            ii(0x1008_67c5, 5);  jmp(0x1008_6732, -0x98); goto l_0x1008_6732;/* jmp 0x10086732 */
        l_0x1008_67ca:
            ii(0x1008_67ca, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x1008_67ce, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_67d0, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1008_67d3, 5);  call(0x1007_5f6c, -0x1_086c);         /* call 0x10075f6c */
            ii(0x1008_67d8, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_67da, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_67dd, 5);  call(0x1008_9044, 0x2862);            /* call 0x10089044 */
            ii(0x1008_67e2, 2);  jmp(0x1008_67f8, 0x14); goto l_0x1008_67f8;/* jmp 0x100867f8 */
        //  ii(0x1008_67e4, 20);  Недостижимый код.
        l_0x1008_67f8:
            ii(0x1008_67f8, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x1008_67fb, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_67fd, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_67fe, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_67ff, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_6800, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_6801, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_6802, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_6803, 1);  ret();                                /* ret */
        }
    }
}
