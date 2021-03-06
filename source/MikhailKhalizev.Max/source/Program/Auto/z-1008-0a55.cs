using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_0a55-423d489f")]
        public void Method_1008_0a55()
        {
            ii(0x1008_0a55, 5);  push(0x34);                           /* push 0x34 */
            ii(0x1008_0a5a, 5);  call(Definitions.sys_check_available_stack_size, 0xe_52f3);/* call 0x10165d52 */
            ii(0x1008_0a5f, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_0a60, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_0a61, 1);  push(edx);                            /* push edx */
            ii(0x1008_0a62, 1);  push(esi);                            /* push esi */
            ii(0x1008_0a63, 1);  push(edi);                            /* push edi */
            ii(0x1008_0a64, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_0a65, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_0a67, 6);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x1008_0a6d, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_0a70, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
            ii(0x1008_0a74, 4);  mov(memb[ss, ebp - 16], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x1008_0a78, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_0a7b, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1008_0a7e, 5);  call(0x1007_6338, -0xa74b);           /* call 0x10076338 */
            ii(0x1008_0a83, 3);  lea(ebx, memd[ss, ebp - 20]);         /* lea ebx, [ebp-0x14] */
            ii(0x1008_0a86, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_0a88, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1008_0a8a, 5);  call(0x1007_64b8, -0xa5d7);           /* call 0x100764b8 */
            ii(0x1008_0a8f, 2);  jmp(0x1008_0a99, 8); goto l_0x1008_0a99;/* jmp 0x10080a99 */
        l_0x1008_0a91:
            ii(0x1008_0a91, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1008_0a94, 5);  call(0x1007_6bf8, -0x9ea1);           /* call 0x10076bf8 */
        l_0x1008_0a99:
            ii(0x1008_0a99, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_0a9b, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1008_0a9e, 5);  call(0x1013_ad71, 0xb_a2ce);          /* call 0x1013ad71 */
            ii(0x1008_0aa3, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_0aa5, 2);  if(jz(0x1008_0ac2, 0x1b)) goto l_0x1008_0ac2;/* jz 0x10080ac2 */
            ii(0x1008_0aa7, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1008_0aaa, 5);  call(0x1007_63a0, -0xa70f);           /* call 0x100763a0 */
            ii(0x1008_0aaf, 5);  cmp(memw[ds, eax + 8], 0x38);         /* cmp word [eax+0x8], 0x38 */
            ii(0x1008_0ab4, 2);  if(jnz(0x1008_0abc, 6)) goto l_0x1008_0abc;/* jnz 0x10080abc */
            ii(0x1008_0ab6, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x1008_0aba, 2);  jmp(0x1008_0ac0, 4); goto l_0x1008_0ac0;/* jmp 0x10080ac0 */
        l_0x1008_0abc:
            ii(0x1008_0abc, 4);  mov(memb[ss, ebp - 16], 1);           /* mov byte [ebp-0x10], 0x1 */
        l_0x1008_0ac0:
            ii(0x1008_0ac0, 2);  jmp(0x1008_0a91, -0x31); goto l_0x1008_0a91;/* jmp 0x10080a91 */
        l_0x1008_0ac2:
            ii(0x1008_0ac2, 4);  cmp(memb[ss, ebp - 12], 0);           /* cmp byte [ebp-0xc], 0x0 */
            ii(0x1008_0ac6, 2);  if(jz(0x1008_0ace, 6)) goto l_0x1008_0ace;/* jz 0x10080ace */
            ii(0x1008_0ac8, 4);  cmp(memb[ss, ebp - 16], 0);           /* cmp byte [ebp-0x10], 0x0 */
            ii(0x1008_0acc, 2);  if(jnz(0x1008_0ad4, 6)) goto l_0x1008_0ad4;/* jnz 0x10080ad4 */
        l_0x1008_0ace:
            ii(0x1008_0ace, 4);  mov(memb[ss, ebp - 24], 1);           /* mov byte [ebp-0x18], 0x1 */
            ii(0x1008_0ad2, 2);  jmp(0x1008_0ad8, 4); goto l_0x1008_0ad8;/* jmp 0x10080ad8 */
        l_0x1008_0ad4:
            ii(0x1008_0ad4, 4);  mov(memb[ss, ebp - 24], 0);           /* mov byte [ebp-0x18], 0x0 */
        l_0x1008_0ad8:
            ii(0x1008_0ad8, 3);  mov(al, memb[ss, ebp - 24]);          /* mov al, [ebp-0x18] */
            ii(0x1008_0adb, 3);  mov(memb[ss, ebp - 8], al);           /* mov [ebp-0x8], al */
            ii(0x1008_0ade, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_0ae0, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1008_0ae3, 5);  call(0x1007_5f6c, -0xab7c);           /* call 0x10075f6c */
            ii(0x1008_0ae8, 2);  jmp(0x1008_0af4, 0xa); goto l_0x1008_0af4;/* jmp 0x10080af4 */
        //  ii(0x1008_0aea, 10);  Недостижимый код.
        l_0x1008_0af4:
            ii(0x1008_0af4, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x1008_0af7, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_0af9, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_0afa, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_0afb, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_0afc, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_0afd, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_0afe, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_0aff, 1);  ret();                                /* ret */
        }
    }
}
