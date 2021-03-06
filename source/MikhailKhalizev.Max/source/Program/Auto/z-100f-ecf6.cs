using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_ecf6-a76e680c")]
        public void Method_100f_ecf6()
        {
            ii(0x100f_ecf6, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100f_ecfb, 5);  call(Definitions.sys_check_available_stack_size, 0x6_7052);/* call 0x10165d52 */
            ii(0x100f_ed00, 1);  push(ebx);                            /* push ebx */
            ii(0x100f_ed01, 1);  push(ecx);                            /* push ecx */
            ii(0x100f_ed02, 1);  push(esi);                            /* push esi */
            ii(0x100f_ed03, 1);  push(edi);                            /* push edi */
            ii(0x100f_ed04, 1);  push(ebp);                            /* push ebp */
            ii(0x100f_ed05, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100f_ed07, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100f_ed0d, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100f_ed10, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100f_ed13, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_ed16, 5);  call(0x1007_6338, -0x8_89e3);         /* call 0x10076338 */
            ii(0x100f_ed1b, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100f_ed1d, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100f_ed20, 5);  call(0x1007_64b8, -0x8_886d);         /* call 0x100764b8 */
        l_0x100f_ed25:
            ii(0x100f_ed25, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100f_ed27, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100f_ed2a, 5);  call(0x1013_ad71, 0x3_c042);          /* call 0x1013ad71 */
            ii(0x100f_ed2f, 2);  test(al, al);                         /* test al, al */
            ii(0x100f_ed31, 2);  if(jz(0x100f_ed5f, 0x2c)) goto l_0x100f_ed5f;/* jz 0x100fed5f */
            ii(0x100f_ed33, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100f_ed36, 5);  call(0x1007_63a0, -0x8_899b);         /* call 0x100763a0 */
            ii(0x100f_ed3b, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100f_ed3d, 3);  mov(dl, memb[ds, eax + 38]);          /* mov dl, [eax+0x26] */
            ii(0x100f_ed40, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_ed44, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100f_ed46, 2);  if(jnz(0x100f_ed55, 0xd)) goto l_0x100f_ed55;/* jnz 0x100fed55 */
            ii(0x100f_ed48, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100f_ed4b, 5);  call(0x1007_63a0, -0x8_89b0);         /* call 0x100763a0 */
            ii(0x100f_ed50, 5);  call(0x1015_0413, 0x5_16be);          /* call 0x10150413 */
        l_0x100f_ed55:
            ii(0x100f_ed55, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100f_ed58, 5);  call(0x1007_6bf8, -0x8_8165);         /* call 0x10076bf8 */
            ii(0x100f_ed5d, 2);  jmp(0x100f_ed25, -0x3a); goto l_0x100f_ed25;/* jmp 0x100fed25 */
        l_0x100f_ed5f:
            ii(0x100f_ed5f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100f_ed61, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100f_ed64, 5);  call(0x1007_5f6c, -0x8_8dfd);         /* call 0x10075f6c */
            ii(0x100f_ed69, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100f_ed6b, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100f_ed6c, 1);  pop(edi);                             /* pop edi */
            ii(0x100f_ed6d, 1);  pop(esi);                             /* pop esi */
            ii(0x100f_ed6e, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100f_ed6f, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100f_ed70, 1);  ret();                                /* ret */
        }
    }
}
