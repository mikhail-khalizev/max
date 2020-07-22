using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_785d-dd69b4d7")]
        public void Method_1008_785d()
        {
            ii(0x1008_785d, 5);  push(0x3c);                           /* push 0x3c */
            ii(0x1008_7862, 5);  call(Definitions.sys_check_available_stack_size, 0xd_e4eb);/* call 0x10165d52 */
            ii(0x1008_7867, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_7868, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_7869, 1);  push(esi);                            /* push esi */
            ii(0x1008_786a, 1);  push(edi);                            /* push edi */
            ii(0x1008_786b, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_786c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_786e, 6);  sub(esp, 0x24);                       /* sub esp, 0x24 */
            ii(0x1008_7874, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_7877, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1008_787a, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_787d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_7880, 5);  call(0x1015_2a52, 0xc_b1cd);          /* call 0x10152a52 */
            ii(0x1008_7885, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_7887, 2);  if(jz(0x1008_789a, 0x11)) goto l_0x1008_789a;/* jz 0x1008789a */
            ii(0x1008_7889, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_788b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_788e, 3);  add(eax, 0xf);                        /* add eax, 0xf */
            ii(0x1008_7891, 5);  call(0x1013_ad11, 0xb_347b);          /* call 0x1013ad11 */
            ii(0x1008_7896, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_7898, 2);  if(jz(0x1008_789c, 2)) goto l_0x1008_789c;/* jz 0x1008789c */
        l_0x1008_789a:
            ii(0x1008_789a, 2);  jmp(0x1008_78ab, 0xf); goto l_0x1008_78ab;/* jmp 0x100878ab */
        l_0x1008_789c:
            ii(0x1008_789c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_789f, 3);  mov(al, memb[ds, eax + 78]);          /* mov al, [eax+0x4e] */
            ii(0x1008_78a2, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1008_78a7, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_78a9, 2);  if(jnz(0x1008_78b4, 9)) goto l_0x1008_78b4;/* jnz 0x100878b4 */
        l_0x1008_78ab:
            ii(0x1008_78ab, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
            ii(0x1008_78af, 5);  jmp(0x1008_79a7, 0xf3); goto l_0x1008_79a7;/* jmp 0x100879a7 */
        l_0x1008_78b4:
            ii(0x1008_78b4, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_78b7, 5);  call(0x1007_623c, -0x1_1680);         /* call 0x1007623c */
            ii(0x1008_78bc, 3);  mov(edx, memd[ds, eax + 18]);         /* mov edx, [eax+0x12] */
            ii(0x1008_78bf, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1008_78c2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_78c5, 3);  mov(al, memb[ds, eax + 84]);          /* mov al, [eax+0x54] */
            ii(0x1008_78c8, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1008_78cd, 2);  cmp(eax, edx);                        /* cmp eax, edx */
            ii(0x1008_78cf, 2);  if(jge(0x1008_78f0, 0x1f)) goto l_0x1008_78f0;/* jge 0x100878f0 */
            ii(0x1008_78d1, 5);  call(0x1008_a79c, 0x2ec6);            /* call 0x1008a79c */
            ii(0x1008_78d6, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1008_78d8, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x1008_78da, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_78dd, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1008_78e2, 5);  call(0x100a_53ac, 0x1_dac5);          /* call 0x100a53ac */
            ii(0x1008_78e7, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
            ii(0x1008_78eb, 5);  jmp(0x1008_79a7, 0xb7); goto l_0x1008_79a7;/* jmp 0x100879a7 */
        l_0x1008_78f0:
            ii(0x1008_78f0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_78f3, 5);  call(0x1007_623c, -0x1_16bc);         /* call 0x1007623c */
            ii(0x1008_78f8, 3);  mov(edx, memd[ds, eax + 8]);          /* mov edx, [eax+0x8] */
            ii(0x1008_78fb, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1008_78fe, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1008_7900, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1008_7903, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x1008_7906, 2);  sbb(eax, edx);                        /* sbb eax, edx */
            ii(0x1008_7908, 3);  sar(eax, 2);                          /* sar eax, 0x2 */
            ii(0x1008_790b, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_790d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_7910, 3);  mov(al, memb[ds, eax + 77]);          /* mov al, [eax+0x4d] */
            ii(0x1008_7913, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1008_7918, 2);  cmp(eax, edx);                        /* cmp eax, edx */
            ii(0x1008_791a, 2);  if(jge(0x1008_7988, 0x6c)) goto l_0x1008_7988;/* jge 0x10087988 */
            ii(0x1008_791c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_791f, 5);  call(0x1015_287d, 0xc_af59);          /* call 0x1015287d */
            ii(0x1008_7924, 5);  mov(eax, 0x1b);                       /* mov eax, 0x1b */
            ii(0x1008_7929, 5);  call(Definitions.sys_new, 0xd_e4d2);  /* call 0x10165e00 */
            ii(0x1008_792e, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1008_7931, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1008_7934, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1008_7937, 4);  cmp(memd[ss, ebp - 24], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1008_793b, 2);  if(jz(0x1008_7953, 0x16)) goto l_0x1008_7953;/* jz 0x10087953 */
            ii(0x1008_793d, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_7940, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1008_7943, 5);  call(Definitions.my_ctor_c15, 0x4_3f40);/* call 0x100cb888 */
            ii(0x1008_7948, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1008_794b, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1008_794e, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1008_7951, 2);  jmp(0x1008_7959, 6); goto l_0x1008_7959;/* jmp 0x10087959 */
        l_0x1008_7953:
            ii(0x1008_7953, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1008_7956, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
        l_0x1008_7959:
            ii(0x1008_7959, 3);  mov(edx, memd[ss, ebp - 32]);         /* mov edx, [ebp-0x20] */
            ii(0x1008_795c, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x1008_795f, 5);  call(0x1008_b060, 0x36fc);            /* call 0x1008b060 */
            ii(0x1008_7964, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x1008_7967, 5);  call(0x1008_af84, 0x3618);            /* call 0x1008af84 */
            ii(0x1008_796c, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_796e, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1008_7973, 5);  call(0x100a_4d50, 0x1_d3d8);          /* call 0x100a4d50 */
            ii(0x1008_7978, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x1008_797c, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_797e, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x1008_7981, 5);  call(0x1008_8b7c, 0x11f6);            /* call 0x10088b7c */
            ii(0x1008_7986, 2);  jmp(0x1008_79a7, 0x1f); goto l_0x1008_79a7;/* jmp 0x100879a7 */
        l_0x1008_7988:
            ii(0x1008_7988, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_798b, 3);  add(eax, 0xf);                        /* add eax, 0xf */
            ii(0x1008_798e, 5);  call(0x1008_afb4, 0x3621);            /* call 0x1008afb4 */
            ii(0x1008_7993, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1008_7996, 3);  mov(ebx, memd[ss, ebp - 4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1008_7999, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_799c, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_799f, 5);  call(0x1008_58d6, -0x20ce);           /* call 0x100858d6 */
            ii(0x1008_79a4, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
        l_0x1008_79a7:
            ii(0x1008_79a7, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1008_79aa, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_79ac, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_79ad, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_79ae, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_79af, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_79b0, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_79b1, 1);  ret();                                /* ret */
        }
    }
}
