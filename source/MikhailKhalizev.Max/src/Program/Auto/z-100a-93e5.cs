using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_93e5-c04d6ff7")]
        public void Method_100a_93e5()
        {
            ii(0x100a_93e5, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100a_93ea, 5);  call(Definitions.sys_check_available_stack_size, 0xb_c963);/* call 0x10165d52 */
            ii(0x100a_93ef, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_93f0, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_93f1, 1);  push(edx);                            /* push edx */
            ii(0x100a_93f2, 1);  push(esi);                            /* push esi */
            ii(0x100a_93f3, 1);  push(edi);                            /* push edi */
            ii(0x100a_93f4, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_93f5, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_93f7, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100a_93fd, 5);  mov(eax, 0x101c_8184);                /* mov eax, 0x101c8184 */
            ii(0x100a_9402, 5);  call(0x1007_6338, -0x3_30cf);         /* call 0x10076338 */
            ii(0x100a_9407, 3);  lea(ebx, memd[ss, ebp - 8]);          /* lea ebx, [ebp-0x8] */
            ii(0x100a_940a, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100a_940c, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x100a_940e, 5);  call(0x1007_64b8, -0x3_2f5b);         /* call 0x100764b8 */
            ii(0x100a_9413, 2);  jmp(0x100a_941d, 8); goto l_0x100a_941d;/* jmp 0x100a941d */
        l_0x100a_9415:
            ii(0x100a_9415, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x100a_9418, 5);  call(0x1007_6bf8, -0x3_2825);         /* call 0x10076bf8 */
        l_0x100a_941d:
            ii(0x100a_941d, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_941f, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x100a_9422, 5);  call(0x1013_ad71, 0x9_194a);          /* call 0x1013ad71 */
            ii(0x100a_9427, 2);  test(al, al);                         /* test al, al */
            ii(0x100a_9429, 2);  if(jz(0x100a_946e, 0x43)) goto l_0x100a_946e;/* jz 0x100a946e */
            ii(0x100a_942b, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x100a_942e, 5);  call(0x1007_63a0, -0x3_3093);         /* call 0x100763a0 */
            ii(0x100a_9433, 4);  cmp(memb[ds, eax + 61], 2);           /* cmp byte [eax+0x3d], 0x2 */
            ii(0x100a_9437, 2);  if(jnz(0x100a_9457, 0x1e)) goto l_0x100a_9457;/* jnz 0x100a9457 */
            ii(0x100a_9439, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x100a_943c, 5);  call(0x1007_63a0, -0x3_30a1);         /* call 0x100763a0 */
            ii(0x100a_9441, 4);  cmp(memb[ds, eax + 62], 5);           /* cmp byte [eax+0x3e], 0x5 */
            ii(0x100a_9445, 2);  if(jz(0x100a_9455, 0xe)) goto l_0x100a_9455;/* jz 0x100a9455 */
            ii(0x100a_9447, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x100a_944a, 5);  call(0x1007_63a0, -0x3_30af);         /* call 0x100763a0 */
            ii(0x100a_944f, 4);  cmp(memb[ds, eax + 62], 6);           /* cmp byte [eax+0x3e], 0x6 */
            ii(0x100a_9453, 2);  if(jnz(0x100a_9457, 2)) goto l_0x100a_9457;/* jnz 0x100a9457 */
        l_0x100a_9455:
            ii(0x100a_9455, 2);  jmp(0x100a_9459, 2); goto l_0x100a_9459;/* jmp 0x100a9459 */
        l_0x100a_9457:
            ii(0x100a_9457, 2);  jmp(0x100a_946c, 0x13); goto l_0x100a_946c;/* jmp 0x100a946c */
        l_0x100a_9459:
            ii(0x100a_9459, 4);  mov(memb[ss, ebp - 4], 1);            /* mov byte [ebp-0x4], 0x1 */
            ii(0x100a_945d, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_945f, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x100a_9462, 5);  call(0x1007_5f6c, -0x3_34fb);         /* call 0x10075f6c */
            ii(0x100a_9467, 5);  jmp(0x100a_94f6, 0x8a); goto l_0x100a_94f6;/* jmp 0x100a94f6 */
        l_0x100a_946c:
            ii(0x100a_946c, 2);  jmp(0x100a_9415, -0x59); goto l_0x100a_9415;/* jmp 0x100a9415 */
        l_0x100a_946e:
            ii(0x100a_946e, 5);  mov(eax, 0x101c_81a8);                /* mov eax, 0x101c81a8 */
            ii(0x100a_9473, 5);  call(0x1007_6338, -0x3_3140);         /* call 0x10076338 */
            ii(0x100a_9478, 3);  lea(ebx, memd[ss, ebp - 8]);          /* lea ebx, [ebp-0x8] */
            ii(0x100a_947b, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100a_947d, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x100a_947f, 5);  call(0x1007_643c, -0x3_3048);         /* call 0x1007643c */
            ii(0x100a_9484, 2);  jmp(0x100a_948e, 8); goto l_0x100a_948e;/* jmp 0x100a948e */
        l_0x100a_9486:
            ii(0x100a_9486, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x100a_9489, 5);  call(0x1007_6bf8, -0x3_2896);         /* call 0x10076bf8 */
        l_0x100a_948e:
            ii(0x100a_948e, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_9490, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x100a_9493, 5);  call(0x1013_ad71, 0x9_18d9);          /* call 0x1013ad71 */
            ii(0x100a_9498, 2);  test(al, al);                         /* test al, al */
            ii(0x100a_949a, 2);  if(jz(0x100a_94dc, 0x40)) goto l_0x100a_94dc;/* jz 0x100a94dc */
            ii(0x100a_949c, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x100a_949f, 5);  call(0x1007_63a0, -0x3_3104);         /* call 0x100763a0 */
            ii(0x100a_94a4, 4);  cmp(memb[ds, eax + 61], 2);           /* cmp byte [eax+0x3d], 0x2 */
            ii(0x100a_94a8, 2);  if(jnz(0x100a_94c8, 0x1e)) goto l_0x100a_94c8;/* jnz 0x100a94c8 */
            ii(0x100a_94aa, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x100a_94ad, 5);  call(0x1007_63a0, -0x3_3112);         /* call 0x100763a0 */
            ii(0x100a_94b2, 4);  cmp(memb[ds, eax + 62], 5);           /* cmp byte [eax+0x3e], 0x5 */
            ii(0x100a_94b6, 2);  if(jz(0x100a_94c6, 0xe)) goto l_0x100a_94c6;/* jz 0x100a94c6 */
            ii(0x100a_94b8, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x100a_94bb, 5);  call(0x1007_63a0, -0x3_3120);         /* call 0x100763a0 */
            ii(0x100a_94c0, 4);  cmp(memb[ds, eax + 62], 6);           /* cmp byte [eax+0x3e], 0x6 */
            ii(0x100a_94c4, 2);  if(jnz(0x100a_94c8, 2)) goto l_0x100a_94c8;/* jnz 0x100a94c8 */
        l_0x100a_94c6:
            ii(0x100a_94c6, 2);  jmp(0x100a_94ca, 2); goto l_0x100a_94ca;/* jmp 0x100a94ca */
        l_0x100a_94c8:
            ii(0x100a_94c8, 2);  jmp(0x100a_94da, 0x10); goto l_0x100a_94da;/* jmp 0x100a94da */
        l_0x100a_94ca:
            ii(0x100a_94ca, 4);  mov(memb[ss, ebp - 4], 1);            /* mov byte [ebp-0x4], 0x1 */
            ii(0x100a_94ce, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_94d0, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x100a_94d3, 5);  call(0x1007_5f6c, -0x3_356c);         /* call 0x10075f6c */
            ii(0x100a_94d8, 2);  jmp(0x100a_94f6, 0x1c); goto l_0x100a_94f6;/* jmp 0x100a94f6 */
        l_0x100a_94da:
            ii(0x100a_94da, 2);  jmp(0x100a_9486, -0x56); goto l_0x100a_9486;/* jmp 0x100a9486 */
        l_0x100a_94dc:
            ii(0x100a_94dc, 4);  mov(memb[ss, ebp - 4], 0);            /* mov byte [ebp-0x4], 0x0 */
            ii(0x100a_94e0, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_94e2, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x100a_94e5, 5);  call(0x1007_5f6c, -0x3_357e);         /* call 0x10075f6c */
            ii(0x100a_94ea, 2);  jmp(0x100a_94f6, 0xa); goto l_0x100a_94f6;/* jmp 0x100a94f6 */
        //  ii(0x100a_94ec, 2);  xor(edx, edx);                        /* xor edx, edx */
        //  ii(0x100a_94ee, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
        //  ii(0x100a_94f1, 5);  call(0x1007_5f6c, -0x3_358a);         /* call 0x10075f6c */
        l_0x100a_94f6:
            ii(0x100a_94f6, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x100a_94f9, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_94fb, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_94fc, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_94fd, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_94fe, 1);  pop(edx);                             /* pop edx */
            ii(0x100a_94ff, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_9500, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_9501, 1);  ret();                                /* ret */
        }
    }
}
