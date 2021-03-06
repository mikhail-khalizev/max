using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_d921-64405b6a")]
        public void Method_1015_d921()
        {
            ii(0x1015_d921, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1015_d926, 5);  call(Definitions.sys_check_available_stack_size, 0x8427);/* call 0x10165d52 */
            ii(0x1015_d92b, 1);  push(ebx);                            /* push ebx */
            ii(0x1015_d92c, 1);  push(ecx);                            /* push ecx */
            ii(0x1015_d92d, 1);  push(esi);                            /* push esi */
            ii(0x1015_d92e, 1);  push(edi);                            /* push edi */
            ii(0x1015_d92f, 1);  push(ebp);                            /* push ebp */
            ii(0x1015_d930, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1015_d932, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1015_d938, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_d93b, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1015_d93e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_d941, 5);  call(0x1007_6338, -0xe_760e);         /* call 0x10076338 */
            ii(0x1015_d946, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1015_d948, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1015_d94b, 5);  call(0x1007_64b8, -0xe_7498);         /* call 0x100764b8 */
        l_0x1015_d950:
            ii(0x1015_d950, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1015_d952, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1015_d955, 5);  call(0x1013_ad71, -0x2_2be9);         /* call 0x1013ad71 */
            ii(0x1015_d95a, 2);  test(al, al);                         /* test al, al */
            ii(0x1015_d95c, 2);  if(jz(0x1015_d98c, 0x2e)) goto l_0x1015_d98c;/* jz 0x1015d98c */
            ii(0x1015_d95e, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_d961, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1015_d964, 5);  call(0x1007_6408, -0xe_7561);         /* call 0x10076408 */
            ii(0x1015_d969, 5);  call(0x1015_d68c, -0x2e2);            /* call 0x1015d68c */
            ii(0x1015_d96e, 2);  test(al, al);                         /* test al, al */
            ii(0x1015_d970, 2);  if(jz(0x1015_d982, 0x10)) goto l_0x1015_d982;/* jz 0x1015d982 */
            ii(0x1015_d972, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x1015_d976, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1015_d978, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1015_d97b, 5);  call(0x1007_5f6c, -0xe_7a14);         /* call 0x10075f6c */
            ii(0x1015_d980, 2);  jmp(0x1015_d9a6, 0x24); goto l_0x1015_d9a6;/* jmp 0x1015d9a6 */
        l_0x1015_d982:
            ii(0x1015_d982, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1015_d985, 5);  call(0x1007_6bf8, -0xe_6d92);         /* call 0x10076bf8 */
            ii(0x1015_d98a, 2);  jmp(0x1015_d950, -0x3c); goto l_0x1015_d950;/* jmp 0x1015d950 */
        l_0x1015_d98c:
            ii(0x1015_d98c, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
            ii(0x1015_d990, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1015_d992, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1015_d995, 5);  call(0x1007_5f6c, -0xe_7a2e);         /* call 0x10075f6c */
            ii(0x1015_d99a, 2);  jmp(0x1015_d9a6, 0xa); goto l_0x1015_d9a6;/* jmp 0x1015d9a6 */
        //  ii(0x1015_d99c, 10);  Недостижимый код.
        l_0x1015_d9a6:
            ii(0x1015_d9a6, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1015_d9a9, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1015_d9ab, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1015_d9ac, 1);  pop(edi);                             /* pop edi */
            ii(0x1015_d9ad, 1);  pop(esi);                             /* pop esi */
            ii(0x1015_d9ae, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1015_d9af, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1015_d9b0, 1);  ret();                                /* ret */
        }
    }
}
