using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_5d35-717140dd")]
        public void Method_1007_5d35()
        {
            ii(0x1007_5d35, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x1007_5d3a, 5);  call(Definitions.sys_check_available_stack_size, 0xf_0013);/* call 0x10165d52 */
            ii(0x1007_5d3f, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_5d40, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_5d41, 1);  push(edx);                            /* push edx */
            ii(0x1007_5d42, 1);  push(esi);                            /* push esi */
            ii(0x1007_5d43, 1);  push(edi);                            /* push edi */
            ii(0x1007_5d44, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_5d45, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_5d47, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1007_5d4d, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_5d50, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_5d53, 5);  call(0x1007_61d4, 0x47c);             /* call 0x100761d4 */
            ii(0x1007_5d58, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1007_5d5b, 4);  cmp(memd[ss, ebp - 12], 0);           /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1007_5d5f, 2);  if(jnz(0x1007_5d6d, 0xc)) goto l_0x1007_5d6d;/* jnz 0x10075d6d */
            ii(0x1007_5d61, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1007_5d68, 5);  jmp(0x1007_5e17, 0xaa); goto l_0x1007_5e17;/* jmp 0x10075e17 */
        l_0x1007_5d6d:
            ii(0x1007_5d6d, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1007_5d70, 5);  call(0x1007_6338, 0x5c3);             /* call 0x10076338 */
            ii(0x1007_5d75, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_5d77, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_5d7a, 5);  call(0x1007_64b8, 0x739);             /* call 0x100764b8 */
        l_0x1007_5d7f:
            ii(0x1007_5d7f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_5d81, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_5d84, 5);  call(0x1013_ad71, 0xc_4fe8);          /* call 0x1013ad71 */
            ii(0x1007_5d89, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_5d8b, 6);  if(jz(0x1007_5dfa, 0x69)) goto l_0x1007_5dfa;/* jz 0x10075dfa */
            ii(0x1007_5d91, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_5d94, 5);  call(0x1007_63a0, 0x607);             /* call 0x100763a0 */
            ii(0x1007_5d99, 4);  cmp(memb[ds, eax + 61], 2);           /* cmp byte [eax+0x3d], 0x2 */
            ii(0x1007_5d9d, 2);  if(jz(0x1007_5dad, 0xe)) goto l_0x1007_5dad;/* jz 0x10075dad */
            ii(0x1007_5d9f, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_5da2, 5);  call(0x1007_63a0, 0x5f9);             /* call 0x100763a0 */
            ii(0x1007_5da7, 4);  cmp(memb[ds, eax + 61], 0x1e);        /* cmp byte [eax+0x3d], 0x1e */
            ii(0x1007_5dab, 2);  if(jnz(0x1007_5ddb, 0x2e)) goto l_0x1007_5ddb;/* jnz 0x10075ddb */
        l_0x1007_5dad:
            ii(0x1007_5dad, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_5db0, 5);  call(0x1007_63a0, 0x5eb);             /* call 0x100763a0 */
            ii(0x1007_5db5, 4);  cmp(memb[ds, eax + 62], 5);           /* cmp byte [eax+0x3e], 0x5 */
            ii(0x1007_5db9, 2);  if(jz(0x1007_5dc9, 0xe)) goto l_0x1007_5dc9;/* jz 0x10075dc9 */
            ii(0x1007_5dbb, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_5dbe, 5);  call(0x1007_63a0, 0x5dd);             /* call 0x100763a0 */
            ii(0x1007_5dc3, 4);  cmp(memb[ds, eax + 62], 6);           /* cmp byte [eax+0x3e], 0x6 */
            ii(0x1007_5dc7, 2);  if(jnz(0x1007_5dcb, 2)) goto l_0x1007_5dcb;/* jnz 0x10075dcb */
        l_0x1007_5dc9:
            ii(0x1007_5dc9, 2);  jmp(0x1007_5dd9, 0xe); goto l_0x1007_5dd9;/* jmp 0x10075dd9 */
        l_0x1007_5dcb:
            ii(0x1007_5dcb, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_5dce, 5);  call(0x1007_63a0, 0x5cd);             /* call 0x100763a0 */
            ii(0x1007_5dd3, 4);  cmp(memb[ds, eax + 62], 0x2a);        /* cmp byte [eax+0x3e], 0x2a */
            ii(0x1007_5dd7, 2);  if(jnz(0x1007_5ddb, 2)) goto l_0x1007_5ddb;/* jnz 0x10075ddb */
        l_0x1007_5dd9:
            ii(0x1007_5dd9, 2);  jmp(0x1007_5ddd, 2); goto l_0x1007_5ddd;/* jmp 0x10075ddd */
        l_0x1007_5ddb:
            ii(0x1007_5ddb, 2);  jmp(0x1007_5df0, 0x13); goto l_0x1007_5df0;/* jmp 0x10075df0 */
        l_0x1007_5ddd:
            ii(0x1007_5ddd, 7);  mov(memd[ss, ebp - 16], 1);           /* mov dword [ebp-0x10], 0x1 */
            ii(0x1007_5de4, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_5de6, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_5de9, 5);  call(0x1007_5f6c, 0x17e);             /* call 0x10075f6c */
            ii(0x1007_5dee, 2);  jmp(0x1007_5e17, 0x27); goto l_0x1007_5e17;/* jmp 0x10075e17 */
        l_0x1007_5df0:
            ii(0x1007_5df0, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_5df3, 5);  call(0x1007_6bf8, 0xe00);             /* call 0x10076bf8 */
            ii(0x1007_5df8, 2);  jmp(0x1007_5d7f, -0x7b); goto l_0x1007_5d7f;/* jmp 0x10075d7f */
        l_0x1007_5dfa:
            ii(0x1007_5dfa, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1007_5e01, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_5e03, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_5e06, 5);  call(0x1007_5f6c, 0x161);             /* call 0x10075f6c */
            ii(0x1007_5e0b, 2);  jmp(0x1007_5e17, 0xa); goto l_0x1007_5e17;/* jmp 0x10075e17 */
        //  ii(0x1007_5e0d, 2);  xor(edx, edx);                        /* xor edx, edx */
        //  ii(0x1007_5e0f, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
        //  ii(0x1007_5e12, 5);  call(0x1007_5f6c, 0x155);             /* call 0x10075f6c */
        l_0x1007_5e17:
            ii(0x1007_5e17, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_5e1a, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_5e1c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_5e1d, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_5e1e, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_5e1f, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_5e20, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_5e21, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_5e22, 1);  ret();                                /* ret */
        }
    }
}
