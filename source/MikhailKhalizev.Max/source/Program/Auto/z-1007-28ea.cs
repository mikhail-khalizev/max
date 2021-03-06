using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_28ea-8aceb0ae")]
        public void Method_1007_28ea()
        {
            ii(0x1007_28ea, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1007_28ef, 5);  call(Definitions.sys_check_available_stack_size, 0xf_345e);/* call 0x10165d52 */
            ii(0x1007_28f4, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_28f5, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_28f6, 1);  push(edx);                            /* push edx */
            ii(0x1007_28f7, 1);  push(esi);                            /* push esi */
            ii(0x1007_28f8, 1);  push(edi);                            /* push edi */
            ii(0x1007_28f9, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_28fa, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_28fc, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1007_2902, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_2905, 5);  mov(eax, 0x101c_819c);                /* mov eax, 0x101c819c */
            ii(0x1007_290a, 5);  call(0x1007_6338, 0x3a29);            /* call 0x10076338 */
            ii(0x1007_290f, 3);  lea(ebx, memd[ss, ebp - 8]);          /* lea ebx, [ebp-0x8] */
            ii(0x1007_2912, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_2914, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1007_2916, 5);  call(0x1007_64b8, 0x3b9d);            /* call 0x100764b8 */
        l_0x1007_291b:
            ii(0x1007_291b, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_291d, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_2920, 5);  call(0x1013_ad71, 0xc_844c);          /* call 0x1013ad71 */
            ii(0x1007_2925, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_2927, 2);  if(jz(0x1007_2970, 0x47)) goto l_0x1007_2970;/* jz 0x10072970 */
            ii(0x1007_2929, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_292c, 5);  call(0x1007_63a0, 0x3a6f);            /* call 0x100763a0 */
            ii(0x1007_2931, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_2933, 3);  mov(dl, memb[ds, eax + 38]);          /* mov dl, [eax+0x26] */
            ii(0x1007_2936, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1007_293a, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1007_293c, 2);  if(jnz(0x1007_294d, 0xf)) goto l_0x1007_294d;/* jnz 0x1007294d */
            ii(0x1007_293e, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_2941, 5);  call(0x1007_63a0, 0x3a5a);            /* call 0x100763a0 */
            ii(0x1007_2946, 5);  cmp(memw[ds, eax + 8], 0x28);         /* cmp word [eax+0x8], 0x28 */
            ii(0x1007_294b, 2);  if(jz(0x1007_294f, 2)) goto l_0x1007_294f;/* jz 0x1007294f */
        l_0x1007_294d:
            ii(0x1007_294d, 2);  jmp(0x1007_2966, 0x17); goto l_0x1007_2966;/* jmp 0x10072966 */
        l_0x1007_294f:
            ii(0x1007_294f, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_2952, 5);  call(0x1007_6408, 0x3ab1);            /* call 0x10076408 */
            ii(0x1007_2957, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1007_295a, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_295c, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_295f, 5);  call(0x1007_5f6c, 0x3608);            /* call 0x10075f6c */
            ii(0x1007_2964, 2);  jmp(0x1007_298d, 0x27); goto l_0x1007_298d;/* jmp 0x1007298d */
        l_0x1007_2966:
            ii(0x1007_2966, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_2969, 5);  call(0x1007_6bf8, 0x428a);            /* call 0x10076bf8 */
            ii(0x1007_296e, 2);  jmp(0x1007_291b, -0x55); goto l_0x1007_291b;/* jmp 0x1007291b */
        l_0x1007_2970:
            ii(0x1007_2970, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
            ii(0x1007_2977, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_2979, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_297c, 5);  call(0x1007_5f6c, 0x35eb);            /* call 0x10075f6c */
            ii(0x1007_2981, 2);  jmp(0x1007_298d, 0xa); goto l_0x1007_298d;/* jmp 0x1007298d */
        //  ii(0x1007_2983, 10);  Недостижимый код.
        l_0x1007_298d:
            ii(0x1007_298d, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1007_2990, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_2992, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_2993, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_2994, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_2995, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_2996, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_2997, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_2998, 1);  ret();                                /* ret */
        }
    }
}
