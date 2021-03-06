using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_c8fe-dfa3d9b8")]
        public void Method_1007_c8fe()
        {
            ii(0x1007_c8fe, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1007_c903, 5);  call(Definitions.sys_check_available_stack_size, 0xe_944a);/* call 0x10165d52 */
            ii(0x1007_c908, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_c909, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_c90a, 1);  push(esi);                            /* push esi */
            ii(0x1007_c90b, 1);  push(edi);                            /* push edi */
            ii(0x1007_c90c, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_c90d, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_c90f, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1007_c915, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_c918, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_c91b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_c91e, 5);  call(0x1008_9f70, 0xd64d);            /* call 0x10089f70 */
            ii(0x1007_c923, 3);  cmp(eax, memd[ss, ebp - 4]);          /* cmp eax, [ebp-0x4] */
            ii(0x1007_c926, 2);  if(jnz(0x1007_c999, 0x71)) goto l_0x1007_c999;/* jnz 0x1007c999 */
            ii(0x1007_c928, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_c92b, 3);  add(eax, 0x19);                       /* add eax, 0x19 */
            ii(0x1007_c92e, 5);  call(0x1007_6338, -0x65fb);           /* call 0x10076338 */
            ii(0x1007_c933, 3);  lea(ebx, memd[ss, ebp - 16]);         /* lea ebx, [ebp-0x10] */
            ii(0x1007_c936, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_c938, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1007_c93a, 5);  call(0x1007_64b8, -0x6487);           /* call 0x100764b8 */
            ii(0x1007_c93f, 2);  jmp(0x1007_c949, 8); goto l_0x1007_c949;/* jmp 0x1007c949 */
        l_0x1007_c941:
            ii(0x1007_c941, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_c944, 5);  call(0x1007_6bf8, -0x5d51);           /* call 0x10076bf8 */
        l_0x1007_c949:
            ii(0x1007_c949, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_c94b, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_c94e, 5);  call(0x1013_ad71, 0xb_e41e);          /* call 0x1013ad71 */
            ii(0x1007_c953, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_c955, 2);  if(jz(0x1007_c972, 0x1b)) goto l_0x1007_c972;/* jz 0x1007c972 */
            ii(0x1007_c957, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x1007_c95c, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_c95f, 5);  call(0x1007_63d4, -0x6590);           /* call 0x100763d4 */
            ii(0x1007_c964, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_c966, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1007_c96b, 5);  call(0x100a_53ac, 0x2_8a3c);          /* call 0x100a53ac */
            ii(0x1007_c970, 2);  jmp(0x1007_c941, -0x31); goto l_0x1007_c941;/* jmp 0x1007c941 */
        l_0x1007_c972:
            ii(0x1007_c972, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_c975, 3);  add(eax, 0x19);                       /* add eax, 0x19 */
            ii(0x1007_c978, 5);  call(0x1013_a6f4, 0xb_dd77);          /* call 0x1013a6f4 */
            ii(0x1007_c97d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_c980, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1007_c983, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1007_c986, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x1007_c989, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1007_c98c, 3);  call_abs(memd[ds, edx + 72]);         /* call dword [edx+0x48] */
            ii(0x1007_c98f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_c991, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_c994, 5);  call(0x1007_5f6c, -0x6a2d);           /* call 0x10075f6c */
        l_0x1007_c999:
            ii(0x1007_c999, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_c99b, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_c99c, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_c99d, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_c99e, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_c99f, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_c9a0, 1);  ret();                                /* ret */
        }
    }
}
