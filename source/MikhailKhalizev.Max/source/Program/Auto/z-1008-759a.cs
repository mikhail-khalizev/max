using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_759a-af4f6cd1")]
        public void Method_1008_759a()
        {
            ii(0x1008_759a, 5);  push(0x34);                           /* push 0x34 */
            ii(0x1008_759f, 5);  call(Definitions.sys_check_available_stack_size, 0xd_e7ae);/* call 0x10165d52 */
            ii(0x1008_75a4, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_75a5, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_75a6, 1);  push(edx);                            /* push edx */
            ii(0x1008_75a7, 1);  push(esi);                            /* push esi */
            ii(0x1008_75a8, 1);  push(edi);                            /* push edi */
            ii(0x1008_75a9, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_75aa, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_75ac, 6);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x1008_75b2, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_75b5, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_75b7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_75ba, 3);  add(eax, 0xf);                        /* add eax, 0xf */
            ii(0x1008_75bd, 5);  call(0x1013_ad71, 0xb_37af);          /* call 0x1013ad71 */
            ii(0x1008_75c2, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_75c4, 6);  if(jz(0x1008_7644, 0x7a)) goto l_0x1008_7644;/* jz 0x10087644 */
            ii(0x1008_75ca, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_75cd, 3);  add(eax, 0xf);                        /* add eax, 0xf */
            ii(0x1008_75d0, 5);  call(0x1008_afb4, 0x39df);            /* call 0x1008afb4 */
            ii(0x1008_75d5, 5);  call(0x1008_98f8, 0x231e);            /* call 0x100898f8 */
            ii(0x1008_75da, 3);  mov(ebx, memd[ss, ebp - 4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1008_75dd, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_75df, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1008_75e1, 5);  call(0x1008_7082, -0x564);            /* call 0x10087082 */
            ii(0x1008_75e6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_75e9, 5);  call(0x1008_ad28, 0x373a);            /* call 0x1008ad28 */
            ii(0x1008_75ee, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_75f0, 2);  if(jnz(0x1008_7644, 0x52)) goto l_0x1008_7644;/* jnz 0x10087644 */
            ii(0x1008_75f2, 5);  call(0x1008_a7bc, 0x31c5);            /* call 0x1008a7bc */
            ii(0x1008_75f7, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1008_75fc, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_75ff, 5);  mov(eax, 0xa);                        /* mov eax, 0xa */
            ii(0x1008_7604, 5);  call(Definitions.sys_new, 0xd_e7f7);  /* call 0x10165e00 */
            ii(0x1008_7609, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1008_760c, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_760f, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1008_7612, 4);  cmp(memd[ss, ebp - 16], 0);           /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1008_7616, 2);  if(jz(0x1008_762e, 0x16)) goto l_0x1008_762e;/* jz 0x1008762e */
            ii(0x1008_7618, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_761b, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_761e, 5);  call(Definitions.my_ctor_c11, 0x1_c2a6);/* call 0x100a38c9 */
            ii(0x1008_7623, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1008_7626, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1008_7629, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1008_762c, 2);  jmp(0x1008_7634, 6); goto l_0x1008_7634;/* jmp 0x10087634 */
        l_0x1008_762e:
            ii(0x1008_762e, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_7631, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
        l_0x1008_7634:
            ii(0x1008_7634, 3);  mov(edx, memd[ss, ebp - 24]);         /* mov edx, [ebp-0x18] */
            ii(0x1008_7637, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1008_763c, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1008_763f, 5);  call(0x100a_4db6, 0x1_d772);          /* call 0x100a4db6 */
        l_0x1008_7644:
            ii(0x1008_7644, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_7646, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_7647, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_7648, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_7649, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_764a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_764b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_764c, 1);  ret();                                /* ret */
        }
    }
}
