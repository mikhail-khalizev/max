using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_b91c-23a810dd")]
        public void Method_1007_b91c()
        {
            ii(0x1007_b91c, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1007_b921, 5);  call(Definitions.sys_check_available_stack_size, 0xe_a42c);/* call 0x10165d52 */
            ii(0x1007_b926, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_b927, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_b928, 1);  push(edx);                            /* push edx */
            ii(0x1007_b929, 1);  push(esi);                            /* push esi */
            ii(0x1007_b92a, 1);  push(edi);                            /* push edi */
            ii(0x1007_b92b, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_b92c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_b92e, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1007_b934, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_b937, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_b93a, 3);  add(eax, 0x19);                       /* add eax, 0x19 */
            ii(0x1007_b93d, 5);  call(0x1007_6338, -0x560a);           /* call 0x10076338 */
            ii(0x1007_b942, 3);  lea(ebx, memd[ss, ebp - 12]);         /* lea ebx, [ebp-0xc] */
            ii(0x1007_b945, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_b947, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1007_b949, 5);  call(0x1007_64b8, -0x5496);           /* call 0x100764b8 */
            ii(0x1007_b94e, 2);  jmp(0x1007_b958, 8); goto l_0x1007_b958;/* jmp 0x1007b958 */
        l_0x1007_b950:
            ii(0x1007_b950, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1007_b953, 5);  call(0x1007_6bf8, -0x4d60);           /* call 0x10076bf8 */
        l_0x1007_b958:
            ii(0x1007_b958, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_b95a, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1007_b95d, 5);  call(0x1013_ad71, 0xb_f40f);          /* call 0x1013ad71 */
            ii(0x1007_b962, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_b964, 2);  if(jz(0x1007_b9a1, 0x3b)) goto l_0x1007_b9a1;/* jz 0x1007b9a1 */
            ii(0x1007_b966, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1007_b969, 5);  call(0x1007_63a0, -0x55ce);           /* call 0x100763a0 */
            ii(0x1007_b96e, 3);  mov(al, memb[ds, eax + 78]);          /* mov al, [eax+0x4e] */
            ii(0x1007_b971, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1007_b976, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_b978, 2);  if(jle(0x1007_b98e, 0x14)) goto l_0x1007_b98e;/* jle 0x1007b98e */
            ii(0x1007_b97a, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_b97d, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1007_b980, 5);  call(0x1007_63a0, -0x55e5);           /* call 0x100763a0 */
            ii(0x1007_b985, 5);  call(0x1015_2a52, 0xd_70c8);          /* call 0x10152a52 */
            ii(0x1007_b98a, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_b98c, 2);  if(jnz(0x1007_b990, 2)) goto l_0x1007_b990;/* jnz 0x1007b990 */
        l_0x1007_b98e:
            ii(0x1007_b98e, 2);  jmp(0x1007_b99f, 0xf); goto l_0x1007_b99f;/* jmp 0x1007b99f */
        l_0x1007_b990:
            ii(0x1007_b990, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_b992, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1007_b995, 5);  call(0x1007_63d4, -0x55c6);           /* call 0x100763d4 */
            ii(0x1007_b99a, 5);  call(0x100a_297d, 0x2_6fde);          /* call 0x100a297d */
        l_0x1007_b99f:
            ii(0x1007_b99f, 2);  jmp(0x1007_b950, -0x51); goto l_0x1007_b950;/* jmp 0x1007b950 */
        l_0x1007_b9a1:
            ii(0x1007_b9a1, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x1007_b9a5, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_b9a7, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1007_b9aa, 5);  call(0x1007_5f6c, -0x5a43);           /* call 0x10075f6c */
            ii(0x1007_b9af, 2);  jmp(0x1007_b9bb, 0xa); goto l_0x1007_b9bb;/* jmp 0x1007b9bb */
        //  ii(0x1007_b9b1, 10);  Недостижимый код.
        l_0x1007_b9bb:
            ii(0x1007_b9bb, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x1007_b9be, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_b9c0, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_b9c1, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_b9c2, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_b9c3, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_b9c4, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_b9c5, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_b9c6, 1);  ret();                                /* ret */
        }
    }
}
