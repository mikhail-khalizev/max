using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_f332-d83a689")]
        public void Method_1007_f332()
        {
            ii(0x1007_f332, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1007_f337, 5);  call(Definitions.sys_check_available_stack_size, 0xe_6a16);/* call 0x10165d52 */
            ii(0x1007_f33c, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_f33d, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_f33e, 1);  push(edx);                            /* push edx */
            ii(0x1007_f33f, 1);  push(esi);                            /* push esi */
            ii(0x1007_f340, 1);  push(edi);                            /* push edi */
            ii(0x1007_f341, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_f342, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_f344, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1007_f34a, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_f34d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_f350, 3);  add(eax, 0x18);                       /* add eax, 0x18 */
            ii(0x1007_f353, 5);  call(0x1007_6338, -0x9020);           /* call 0x10076338 */
            ii(0x1007_f358, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_f35a, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_f35d, 5);  call(0x1007_64b8, -0x8eaa);           /* call 0x100764b8 */
            ii(0x1007_f362, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_f364, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_f367, 3);  add(eax, 0xf);                        /* add eax, 0xf */
            ii(0x1007_f36a, 5);  call(0x1008_afe4, 0xbc75);            /* call 0x1008afe4 */
            ii(0x1007_f36f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_f371, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_f374, 3);  add(eax, 0x14);                       /* add eax, 0x14 */
            ii(0x1007_f377, 5);  call(0x1008_a2b4, 0xaf38);            /* call 0x1008a2b4 */
            ii(0x1007_f37c, 2);  jmp(0x1007_f386, 8); goto l_0x1007_f386;/* jmp 0x1007f386 */
        l_0x1007_f37e:
            ii(0x1007_f37e, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_f381, 5);  call(0x1007_6bf8, -0x878e);           /* call 0x10076bf8 */
        l_0x1007_f386:
            ii(0x1007_f386, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_f388, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_f38b, 5);  call(0x1013_ad71, 0xb_b9e1);          /* call 0x1013ad71 */
            ii(0x1007_f390, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_f392, 2);  if(jz(0x1007_f3b3, 0x1f)) goto l_0x1007_f3b3;/* jz 0x1007f3b3 */
            ii(0x1007_f394, 5);  call(0x1008_a79c, 0xb403);            /* call 0x1008a79c */
            ii(0x1007_f399, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1007_f39b, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x1007_f39d, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_f3a0, 5);  call(0x1007_63d4, -0x8fd1);           /* call 0x100763d4 */
            ii(0x1007_f3a5, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_f3a7, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1007_f3ac, 5);  call(0x100a_53ac, 0x2_5ffb);          /* call 0x100a53ac */
            ii(0x1007_f3b1, 2);  jmp(0x1007_f37e, -0x35); goto l_0x1007_f37e;/* jmp 0x1007f37e */
        l_0x1007_f3b3:
            ii(0x1007_f3b3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_f3b6, 3);  add(eax, 0x18);                       /* add eax, 0x18 */
            ii(0x1007_f3b9, 5);  call(0x1013_a6f4, 0xb_b336);          /* call 0x1013a6f4 */
            ii(0x1007_f3be, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_f3c1, 3);  add(eax, 0x22);                       /* add eax, 0x22 */
            ii(0x1007_f3c4, 5);  call(0x1007_6338, -0x9091);           /* call 0x10076338 */
            ii(0x1007_f3c9, 3);  lea(ebx, memd[ss, ebp - 8]);          /* lea ebx, [ebp-0x8] */
            ii(0x1007_f3cc, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_f3ce, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1007_f3d0, 5);  call(0x1007_643c, -0x8f99);           /* call 0x1007643c */
            ii(0x1007_f3d5, 2);  jmp(0x1007_f3df, 8); goto l_0x1007_f3df;/* jmp 0x1007f3df */
        l_0x1007_f3d7:
            ii(0x1007_f3d7, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_f3da, 5);  call(0x1007_6bf8, -0x87e7);           /* call 0x10076bf8 */
        l_0x1007_f3df:
            ii(0x1007_f3df, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_f3e1, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_f3e4, 5);  call(0x1013_ad71, 0xb_b988);          /* call 0x1013ad71 */
            ii(0x1007_f3e9, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_f3eb, 2);  if(jz(0x1007_f40c, 0x1f)) goto l_0x1007_f40c;/* jz 0x1007f40c */
            ii(0x1007_f3ed, 5);  call(0x1008_a79c, 0xb3aa);            /* call 0x1008a79c */
            ii(0x1007_f3f2, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1007_f3f4, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x1007_f3f6, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_f3f9, 5);  call(0x1007_63d4, -0x902a);           /* call 0x100763d4 */
            ii(0x1007_f3fe, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_f400, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1007_f405, 5);  call(0x100a_53ac, 0x2_5fa2);          /* call 0x100a53ac */
            ii(0x1007_f40a, 2);  jmp(0x1007_f3d7, -0x35); goto l_0x1007_f3d7;/* jmp 0x1007f3d7 */
        l_0x1007_f40c:
            ii(0x1007_f40c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_f40f, 3);  add(eax, 0x22);                       /* add eax, 0x22 */
            ii(0x1007_f412, 5);  call(0x1013_a6f4, 0xb_b2dd);          /* call 0x1013a6f4 */
            ii(0x1007_f417, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_f41a, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1007_f41f, 5);  call(0x100a_5e27, 0x2_6a03);          /* call 0x100a5e27 */
            ii(0x1007_f424, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_f426, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_f429, 5);  call(0x1007_5f6c, -0x94c2);           /* call 0x10075f6c */
            ii(0x1007_f42e, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_f430, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_f431, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_f432, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_f433, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_f434, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_f435, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_f436, 1);  ret();                                /* ret */
        }
    }
}
