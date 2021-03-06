using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_3079-db9efb6b")]
        public void Method_1015_3079()
        {
            ii(0x1015_3079, 5);  push(0x30);                           /* push 0x30 */
            ii(0x1015_307e, 5);  call(Definitions.sys_check_available_stack_size, 0x1_2ccf);/* call 0x10165d52 */
            ii(0x1015_3083, 1);  push(esi);                            /* push esi */
            ii(0x1015_3084, 1);  push(edi);                            /* push edi */
            ii(0x1015_3085, 1);  push(ebp);                            /* push ebp */
            ii(0x1015_3086, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1015_3088, 6);  sub(esp, 0x20);                       /* sub esp, 0x20 */
            ii(0x1015_308e, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1015_3091, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x1015_3094, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1015_3097, 3);  mov(memd[ss, ebp - 8], ecx);          /* mov [ebp-0x8], ecx */
            ii(0x1015_309a, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1015_309d, 2);  xor(ecx, ecx);                        /* xor ecx, ecx */
            ii(0x1015_309f, 3);  mov(cl, memb[ds, eax + 45]);          /* mov cl, [eax+0x2d] */
            ii(0x1015_30a2, 1);  inc(ecx);                             /* inc ecx */
            ii(0x1015_30a3, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1015_30a8, 2);  shl(eax, cl);                         /* shl eax, cl */
            ii(0x1015_30aa, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1015_30ad, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1015_30b0, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x1015_30b3, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1015_30b6, 3);  imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
            ii(0x1015_30b9, 7);  cmp(memd[ds, eax + 0x101c_81e7], 0);  /* cmp dword [eax+0x101c81e7], 0x0 */
            ii(0x1015_30c0, 6);  if(jz(0x1015_31e9, 0x123)) goto l_0x1015_31e9;/* jz 0x101531e9 */
            ii(0x1015_30c6, 6);  mov(edx, memd[ds, 0x101c_38c0]);      /* mov edx, [0x101c38c0] */
            ii(0x1015_30cc, 2);  add(edx, edx);                        /* add edx, edx */
            ii(0x1015_30ce, 4);  movsx(ebx, memw[ss, ebp - 20]);       /* movsx ebx, word [ebp-0x14] */
            ii(0x1015_30d2, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1015_30d4, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1015_30d7, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x1015_30d9, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1015_30dc, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1015_30df, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x1015_30e2, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1015_30e5, 3);  imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
            ii(0x1015_30e8, 7);  cmp(memd[ds, eax + 0x101c_81e7], 0);  /* cmp dword [eax+0x101c81e7], 0x0 */
            ii(0x1015_30ef, 2);  if(jz(0x1015_30fa, 9)) goto l_0x1015_30fa;/* jz 0x101530fa */
            ii(0x1015_30f1, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1015_30f5, 3);  cmp(eax, 4);                          /* cmp eax, 0x4 */
            ii(0x1015_30f8, 2);  if(jge(0x1015_30ff, 5)) goto l_0x1015_30ff;/* jge 0x101530ff */
        l_0x1015_30fa:
            ii(0x1015_30fa, 5);  jmp(0x1015_31e9, 0xea); goto l_0x1015_31e9;/* jmp 0x101531e9 */
        l_0x1015_30ff:
            ii(0x1015_30ff, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1015_3102, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x1015_3105, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1015_3108, 3);  imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
            ii(0x1015_310b, 6);  mov(eax, memd[ds, eax + 0x101c_81e7]);/* mov eax, [eax+0x101c81e7] */
            ii(0x1015_3111, 5);  mov(memd[ds, 0x101c_363c], eax);      /* mov [0x101c363c], eax */
            ii(0x1015_3116, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1015_311a, 5);  mov(eax, memd[ds, 0x101c_363c]);      /* mov eax, [0x101c363c] */
            ii(0x1015_311f, 5);  call(0x1014_98f1, -0x9833);           /* call 0x101498f1 */
            ii(0x1015_3124, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1015_3127, 7);  cmp(memb[ds, 0x101c_814a], 0);        /* cmp byte [0x101c814a], 0x0 */
            ii(0x1015_312e, 2);  if(jz(0x1015_313e, 0xe)) goto l_0x1015_313e;/* jz 0x1015313e */
            ii(0x1015_3130, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1015_3133, 2);  cwd();                                /* cwd */
            ii(0x1015_3135, 3);  sub(ax, dx);                          /* sub ax, dx */
            ii(0x1015_3138, 3);  sar(ax, 1);                           /* sar ax, 1 */
            ii(0x1015_313b, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
        l_0x1015_313e:
            ii(0x1015_313e, 3);  mov(ecx, memd[ss, ebp - 8]);          /* mov ecx, [ebp-0x8] */
            ii(0x1015_3141, 4);  movsx(ebx, memw[ss, ebp - 20]);       /* movsx ebx, word [ebp-0x14] */
            ii(0x1015_3145, 3);  mov(esi, memd[ss, ebp - 28]);         /* mov esi, [ebp-0x1c] */
            ii(0x1015_3148, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1015_314b, 3);  lea(eax, memd[ss, ebp - 32]);         /* lea eax, [ebp-0x20] */
            ii(0x1015_314e, 5);  call(0x1007_5e64, -0xd_d2ef);         /* call 0x10075e64 */
            ii(0x1015_3153, 2);  mov(edx, esi);                        /* mov edx, esi */
            ii(0x1015_3155, 5);  call(0x1015_2cba, -0x4a0);            /* call 0x10152cba */
            ii(0x1015_315a, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1015_315c, 6);  if(jz(0x1015_31e9, 0x87)) goto l_0x1015_31e9;/* jz 0x101531e9 */
            ii(0x1015_3162, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1015_3165, 3);  add(eax, 8);                          /* add eax, 0x8 */
            ii(0x1015_3168, 5);  mov(memd[ds, 0x101c_3634], eax);      /* mov [0x101c3634], eax */
            ii(0x1015_316d, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1015_3170, 3);  mov(eax, memd[ds, eax + 34]);         /* mov eax, [eax+0x22] */
            ii(0x1015_3173, 5);  mov(memd[ds, 0x101c_3640], eax);      /* mov [0x101c3640], eax */
            ii(0x1015_3178, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1015_317b, 3);  mov(al, memb[ds, eax + 40]);          /* mov al, [eax+0x28] */
            ii(0x1015_317e, 5);  mov(memb[ds, 0x101c_3644], al);       /* mov [0x101c3644], al */
            ii(0x1015_3183, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1015_3187, 3);  cmp(eax, 8);                          /* cmp eax, 0x8 */
            ii(0x1015_318a, 2);  if(jge(0x1015_31dd, 0x51)) goto l_0x1015_31dd;/* jge 0x101531dd */
            ii(0x1015_318c, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1015_318f, 4);  test(memb[ds, eax + 19], 0x20);       /* test byte [eax+0x13], 0x20 */
            ii(0x1015_3193, 2);  if(jz(0x1015_319e, 9)) goto l_0x1015_319e;/* jz 0x1015319e */
            ii(0x1015_3195, 7);  mov(memb[ds, 0x101c_3645], 1);        /* mov byte [0x101c3645], 0x1 */
            ii(0x1015_319c, 2);  jmp(0x1015_31db, 0x3d); goto l_0x1015_31db;/* jmp 0x101531db */
        l_0x1015_319e:
            ii(0x1015_319e, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1015_31a1, 4);  test(memb[ds, eax + 19], 0x10);       /* test byte [eax+0x13], 0x10 */
            ii(0x1015_31a5, 2);  if(jz(0x1015_31b0, 9)) goto l_0x1015_31b0;/* jz 0x101531b0 */
            ii(0x1015_31a7, 7);  mov(memb[ds, 0x101c_3645], 2);        /* mov byte [0x101c3645], 0x2 */
            ii(0x1015_31ae, 2);  jmp(0x1015_31db, 0x2b); goto l_0x1015_31db;/* jmp 0x101531db */
        l_0x1015_31b0:
            ii(0x1015_31b0, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1015_31b3, 4);  test(memb[ds, eax + 19], 8);          /* test byte [eax+0x13], 0x8 */
            ii(0x1015_31b7, 2);  if(jz(0x1015_31c2, 9)) goto l_0x1015_31c2;/* jz 0x101531c2 */
            ii(0x1015_31b9, 7);  mov(memb[ds, 0x101c_3645], 3);        /* mov byte [0x101c3645], 0x3 */
            ii(0x1015_31c0, 2);  jmp(0x1015_31db, 0x19); goto l_0x1015_31db;/* jmp 0x101531db */
        l_0x1015_31c2:
            ii(0x1015_31c2, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1015_31c5, 4);  test(memb[ds, eax + 19], 4);          /* test byte [eax+0x13], 0x4 */
            ii(0x1015_31c9, 2);  if(jz(0x1015_31d4, 9)) goto l_0x1015_31d4;/* jz 0x101531d4 */
            ii(0x1015_31cb, 7);  mov(memb[ds, 0x101c_3645], 0xff);     /* mov byte [0x101c3645], 0xff */
            ii(0x1015_31d2, 2);  jmp(0x1015_31db, 7); goto l_0x1015_31db;/* jmp 0x101531db */
        l_0x1015_31d4:
            ii(0x1015_31d4, 7);  mov(memb[ds, 0x101c_3645], 4);        /* mov byte [0x101c3645], 0x4 */
        l_0x1015_31db:
            ii(0x1015_31db, 2);  jmp(0x1015_31e4, 7); goto l_0x1015_31e4;/* jmp 0x101531e4 */
        l_0x1015_31dd:
            ii(0x1015_31dd, 7);  mov(memb[ds, 0x101c_3645], 0);        /* mov byte [0x101c3645], 0x0 */
        l_0x1015_31e4:
            ii(0x1015_31e4, 5);  call(0x100e_f7f8, -0x6_39f1);         /* call 0x100ef7f8 */
        l_0x1015_31e9:
            ii(0x1015_31e9, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1015_31eb, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1015_31ec, 1);  pop(edi);                             /* pop edi */
            ii(0x1015_31ed, 1);  pop(esi);                             /* pop esi */
            ii(0x1015_31ee, 1);  ret();                                /* ret */
        }
    }
}
