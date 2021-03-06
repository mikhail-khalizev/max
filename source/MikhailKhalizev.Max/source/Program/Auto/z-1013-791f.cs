using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_791f-ca07836d")]
        public void Method_1013_791f()
        {
            ii(0x1013_791f, 5);  push(0x58);                           /* push 0x58 */
            ii(0x1013_7924, 5);  call(Definitions.sys_check_available_stack_size, 0x2_e429);/* call 0x10165d52 */
            ii(0x1013_7929, 1);  push(esi);                            /* push esi */
            ii(0x1013_792a, 1);  push(edi);                            /* push edi */
            ii(0x1013_792b, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_792c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_792e, 6);  sub(esp, 0x38);                       /* sub esp, 0x38 */
            ii(0x1013_7934, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_7937, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x1013_793a, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1013_793d, 3);  mov(memd[ss, ebp - 4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x1013_7940, 5);  mov(eax, 0x38);                       /* mov eax, 0x38 */
            ii(0x1013_7945, 5);  call(Definitions.sys_new, 0x2_e4b6);  /* call 0x10165e00 */
            ii(0x1013_794a, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1013_794d, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_7950, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1013_7953, 4);  cmp(memd[ss, ebp - 24], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1013_7957, 2);  if(jz(0x1013_797d, 0x24)) goto l_0x1013_797d;/* jz 0x1013797d */
            ii(0x1013_7959, 4);  movsx(eax, memw[ss, ebp + 16]);       /* movsx eax, word [ebp+0x10] */
            ii(0x1013_795d, 1);  push(eax);                            /* push eax */
            ii(0x1013_795e, 4);  movsx(ecx, memw[ss, ebp - 4]);        /* movsx ecx, word [ebp-0x4] */
            ii(0x1013_7962, 4);  movsx(ebx, memw[ss, ebp - 8]);        /* movsx ebx, word [ebp-0x8] */
            ii(0x1013_7966, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1013_796a, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_796d, 5);  call(Definitions.my_ctor_c17, -0x6_9563);/* call 0x100ce40f */
            ii(0x1013_7972, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1013_7975, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1013_7978, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1013_797b, 2);  jmp(0x1013_7983, 6); goto l_0x1013_7983;/* jmp 0x10137983 */
        l_0x1013_797d:
            ii(0x1013_797d, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_7980, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
        l_0x1013_7983:
            ii(0x1013_7983, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1013_7986, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1013_7989, 4);  cmp(memd[ss, ebp + 20], 0);           /* cmp dword [ebp+0x14], 0x0 */
            ii(0x1013_798d, 2);  if(jz(0x1013_79ce, 0x3f)) goto l_0x1013_79ce;/* jz 0x101379ce */
            ii(0x1013_798f, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x1013_7992, 5);  call(0x100d_5224, -0x6_2773);         /* call 0x100d5224 */
            ii(0x1013_7997, 1);  push(eax);                            /* push eax */
            ii(0x1013_7998, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x1013_799b, 5);  call(0x100d_5250, -0x6_2750);         /* call 0x100d5250 */
            ii(0x1013_79a0, 1);  push(eax);                            /* push eax */
            ii(0x1013_79a1, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1013_79a4, 5);  call(0x100d_527c, -0x6_272d);         /* call 0x100d527c */
            ii(0x1013_79a9, 1);  push(eax);                            /* push eax */
            ii(0x1013_79aa, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1013_79ad, 5);  call(0x100d_52a8, -0x6_270a);         /* call 0x100d52a8 */
            ii(0x1013_79b2, 1);  push(eax);                            /* push eax */
            ii(0x1013_79b3, 5);  call(0x100d_52d4, -0x6_26e4);         /* call 0x100d52d4 */
            ii(0x1013_79b8, 3);  movsx(ecx, ax);                       /* movsx ecx, ax */
            ii(0x1013_79bb, 5);  call(0x100d_52f8, -0x6_26c8);         /* call 0x100d52f8 */
            ii(0x1013_79c0, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1013_79c3, 3);  mov(edx, memd[ss, ebp + 20]);         /* mov edx, [ebp+0x14] */
            ii(0x1013_79c6, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1013_79c9, 5);  call(0x100c_ef64, -0x6_8a6a);         /* call 0x100cef64 */
        l_0x1013_79ce:
            ii(0x1013_79ce, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1013_79d0, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1013_79d3, 5);  call(0x100d_5194, -0x6_2844);         /* call 0x100d5194 */
            ii(0x1013_79d8, 3);  mov(edx, memd[ss, ebp + 24]);         /* mov edx, [ebp+0x18] */
            ii(0x1013_79db, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1013_79de, 5);  call(0x100d_5134, -0x6_28af);         /* call 0x100d5134 */
            ii(0x1013_79e3, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1013_79e6, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1013_79e9, 5);  call(0x100c_f85c, -0x6_8192);         /* call 0x100cf85c */
            ii(0x1013_79ee, 5);  call(0x100d_51e4, -0x6_280f);         /* call 0x100d51e4 */
            ii(0x1013_79f3, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1013_79f5, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x1013_79f7, 5);  call(0x100d_5204, -0x6_27f8);         /* call 0x100d5204 */
            ii(0x1013_79fc, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1013_79fe, 2);  mov(dl, al);                          /* mov dl, al */
            ii(0x1013_7a00, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1013_7a03, 5);  call(0x100c_fa7c, -0x6_7f8c);         /* call 0x100cfa7c */
            ii(0x1013_7a08, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1013_7a0b, 3);  mov(memd[ss, ebp - 56], eax);         /* mov [ebp-0x38], eax */
            ii(0x1013_7a0e, 3);  mov(eax, memd[ss, ebp - 56]);         /* mov eax, [ebp-0x38] */
            ii(0x1013_7a11, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_7a13, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_7a14, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_7a15, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_7a16, 3);  ret(0xc);                             /* ret 0xc */
        }
    }
}
