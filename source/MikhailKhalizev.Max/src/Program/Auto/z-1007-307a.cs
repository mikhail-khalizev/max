using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_307a-4f62b588")]
        public void Method_1007_307a()
        {
            ii(0x1007_307a, 5);  push(0x38);                           /* push 0x38 */
            ii(0x1007_307f, 5);  call(Definitions.sys_check_available_stack_size, 0xf_2cce);/* call 0x10165d52 */
            ii(0x1007_3084, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_3085, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_3086, 1);  push(edx);                            /* push edx */
            ii(0x1007_3087, 1);  push(esi);                            /* push esi */
            ii(0x1007_3088, 1);  push(edi);                            /* push edi */
            ii(0x1007_3089, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_308a, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_308c, 6);  sub(esp, 0x1c);                       /* sub esp, 0x1c */
            ii(0x1007_3092, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_3095, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_3098, 5);  call(0x1007_61d4, 0x3137);            /* call 0x100761d4 */
            ii(0x1007_309d, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1007_30a0, 4);  or(memb[ss, ebp - 8], 1);             /* or byte [ebp-0x8], 0x1 */
            ii(0x1007_30a4, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_30a7, 5);  call(0x1007_64fc, 0x3450);            /* call 0x100764fc */
            ii(0x1007_30ac, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_30af, 4);  and(memb[ss, ebp - 8], -2 /* 0xfe */);/* and byte [ebp-0x8], 0xfe */
            ii(0x1007_30b3, 4);  mov(memb[ss, ebp - 12], 0xff);        /* mov byte [ebp-0xc], 0xff */
            ii(0x1007_30b7, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1007_30ba, 5);  call(0x1007_6338, 0x3279);            /* call 0x10076338 */
            ii(0x1007_30bf, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_30c1, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_30c4, 5);  call(0x1007_643c, 0x3373);            /* call 0x1007643c */
            ii(0x1007_30c9, 2);  jmp(0x1007_30d3, 8); goto l_0x1007_30d3;/* jmp 0x100730d3 */
        l_0x1007_30cb:
            ii(0x1007_30cb, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_30ce, 5);  call(0x1007_6bf8, 0x3b25);            /* call 0x10076bf8 */
        l_0x1007_30d3:
            ii(0x1007_30d3, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_30d5, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_30d8, 5);  call(0x1013_ad71, 0xc_7c94);          /* call 0x1013ad71 */
            ii(0x1007_30dd, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_30df, 6);  if(jz(0x1007_316a, 0x85)) goto l_0x1007_316a;/* jz 0x1007316a */
            ii(0x1007_30e5, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_30e8, 5);  call(0x1007_63a0, 0x32b3);            /* call 0x100763a0 */
            ii(0x1007_30ed, 4);  cmp(memb[ds, eax + 61], 2);           /* cmp byte [eax+0x3d], 0x2 */
            ii(0x1007_30f1, 2);  if(jz(0x1007_3101, 0xe)) goto l_0x1007_3101;/* jz 0x10073101 */
            ii(0x1007_30f3, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_30f6, 5);  call(0x1007_63a0, 0x32a5);            /* call 0x100763a0 */
            ii(0x1007_30fb, 4);  cmp(memb[ds, eax + 61], 0x1e);        /* cmp byte [eax+0x3d], 0x1e */
            ii(0x1007_30ff, 2);  if(jnz(0x1007_312f, 0x2e)) goto l_0x1007_312f;/* jnz 0x1007312f */
        l_0x1007_3101:
            ii(0x1007_3101, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_3104, 5);  call(0x1007_63a0, 0x3297);            /* call 0x100763a0 */
            ii(0x1007_3109, 4);  cmp(memb[ds, eax + 62], 5);           /* cmp byte [eax+0x3e], 0x5 */
            ii(0x1007_310d, 2);  if(jz(0x1007_311d, 0xe)) goto l_0x1007_311d;/* jz 0x1007311d */
            ii(0x1007_310f, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_3112, 5);  call(0x1007_63a0, 0x3289);            /* call 0x100763a0 */
            ii(0x1007_3117, 4);  cmp(memb[ds, eax + 62], 6);           /* cmp byte [eax+0x3e], 0x6 */
            ii(0x1007_311b, 2);  if(jnz(0x1007_311f, 2)) goto l_0x1007_311f;/* jnz 0x1007311f */
        l_0x1007_311d:
            ii(0x1007_311d, 2);  jmp(0x1007_312d, 0xe); goto l_0x1007_312d;/* jmp 0x1007312d */
        l_0x1007_311f:
            ii(0x1007_311f, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_3122, 5);  call(0x1007_63a0, 0x3279);            /* call 0x100763a0 */
            ii(0x1007_3127, 4);  cmp(memb[ds, eax + 62], 0x2a);        /* cmp byte [eax+0x3e], 0x2a */
            ii(0x1007_312b, 2);  if(jnz(0x1007_312f, 2)) goto l_0x1007_312f;/* jnz 0x1007312f */
        l_0x1007_312d:
            ii(0x1007_312d, 2);  jmp(0x1007_3131, 2); goto l_0x1007_3131;/* jmp 0x10073131 */
        l_0x1007_312f:
            ii(0x1007_312f, 2);  jmp(0x1007_3147, 0x16); goto l_0x1007_3147;/* jmp 0x10073147 */
        l_0x1007_3131:
            ii(0x1007_3131, 7);  mov(memd[ss, ebp - 28], 0);           /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1007_3138, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_313a, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_313d, 5);  call(0x1007_5f6c, 0x2e2a);            /* call 0x10075f6c */
            ii(0x1007_3142, 5);  jmp(0x1007_31c3, 0x7c); goto l_0x1007_31c3;/* jmp 0x100731c3 */
        l_0x1007_3147:
            ii(0x1007_3147, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_314a, 5);  call(0x1007_63a0, 0x3251);            /* call 0x100763a0 */
            ii(0x1007_314f, 3);  mov(al, memb[ds, eax + 78]);          /* mov al, [eax+0x4e] */
            ii(0x1007_3152, 3);  cmp(al, memb[ss, ebp - 12]);          /* cmp al, [ebp-0xc] */
            ii(0x1007_3155, 2);  if(jae(0x1007_3165, 0xe)) goto l_0x1007_3165;/* jae 0x10073165 */
            ii(0x1007_3157, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_315a, 5);  call(0x1007_63a0, 0x3241);            /* call 0x100763a0 */
            ii(0x1007_315f, 3);  mov(al, memb[ds, eax + 78]);          /* mov al, [eax+0x4e] */
            ii(0x1007_3162, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
        l_0x1007_3165:
            ii(0x1007_3165, 5);  jmp(0x1007_30cb, -0x9f); goto l_0x1007_30cb;/* jmp 0x100730cb */
        l_0x1007_316a:
            ii(0x1007_316a, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1007_316d, 5);  call(0x1007_6338, 0x31c6);            /* call 0x10076338 */
            ii(0x1007_3172, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_3174, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_3177, 5);  call(0x1007_643c, 0x32c0);            /* call 0x1007643c */
            ii(0x1007_317c, 2);  jmp(0x1007_3186, 8); goto l_0x1007_3186;/* jmp 0x10073186 */
        l_0x1007_317e:
            ii(0x1007_317e, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_3181, 5);  call(0x1007_6bf8, 0x3a72);            /* call 0x10076bf8 */
        l_0x1007_3186:
            ii(0x1007_3186, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_3188, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_318b, 5);  call(0x1013_ad71, 0xc_7be1);          /* call 0x1013ad71 */
            ii(0x1007_3190, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_3192, 2);  if(jz(0x1007_31a6, 0x12)) goto l_0x1007_31a6;/* jz 0x100731a6 */
            ii(0x1007_3194, 3);  mov(dl, memb[ss, ebp - 12]);          /* mov dl, [ebp-0xc] */
            ii(0x1007_3197, 2);  inc(dl);                              /* inc dl */
            ii(0x1007_3199, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_319c, 5);  call(0x1007_63a0, 0x31ff);            /* call 0x100763a0 */
            ii(0x1007_31a1, 3);  mov(memb[ds, eax + 79], dl);          /* mov [eax+0x4f], dl */
            ii(0x1007_31a4, 2);  jmp(0x1007_317e, -0x28); goto l_0x1007_317e;/* jmp 0x1007317e */
        l_0x1007_31a6:
            ii(0x1007_31a6, 7);  mov(memd[ss, ebp - 28], 1);           /* mov dword [ebp-0x1c], 0x1 */
            ii(0x1007_31ad, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_31af, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_31b2, 5);  call(0x1007_5f6c, 0x2db5);            /* call 0x10075f6c */
            ii(0x1007_31b7, 2);  jmp(0x1007_31c3, 0xa); goto l_0x1007_31c3;/* jmp 0x100731c3 */
        //  ii(0x1007_31b9, 2);  xor(edx, edx);                        /* xor edx, edx */
        //  ii(0x1007_31bb, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
        //  ii(0x1007_31be, 5);  call(0x1007_5f6c, 0x2da9);            /* call 0x10075f6c */
        l_0x1007_31c3:
            ii(0x1007_31c3, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1007_31c6, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_31c8, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_31c9, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_31ca, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_31cb, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_31cc, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_31cd, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_31ce, 1);  ret();                                /* ret */
        }
    }
}
