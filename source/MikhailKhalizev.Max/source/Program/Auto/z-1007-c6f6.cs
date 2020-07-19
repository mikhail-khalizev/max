using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_c6f6-5a9c3d7c")]
        public void Method_1007_c6f6()
        {
            ii(0x1007_c6f6, 5);  push(0x3c);                           /* push 0x3c */
            ii(0x1007_c6fb, 5);  call(Definitions.sys_check_available_stack_size, 0xe_9652);/* call 0x10165d52 */
            ii(0x1007_c700, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_c701, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_c702, 1);  push(esi);                            /* push esi */
            ii(0x1007_c703, 1);  push(edi);                            /* push edi */
            ii(0x1007_c704, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_c705, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_c707, 6);  sub(esp, 0x24);                       /* sub esp, 0x24 */
            ii(0x1007_c70d, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_c710, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_c713, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1007_c716, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1007_c719, 5);  call(0x1008_b060, 0xe942);            /* call 0x1008b060 */
            ii(0x1007_c71e, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_c721, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_c724, 3);  add(eax, 0x19);                       /* add eax, 0x19 */
            ii(0x1007_c727, 5);  call(0x1008_aab4, 0xe388);            /* call 0x1008aab4 */
            ii(0x1007_c72c, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_c72e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_c731, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x1007_c734, 5);  call(0x1013_ad71, 0xb_e638);          /* call 0x1013ad71 */
            ii(0x1007_c739, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_c73b, 2);  if(jz(0x1007_c762, 0x25)) goto l_0x1007_c762;/* jz 0x1007c762 */
            ii(0x1007_c73d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_c740, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x1007_c743, 5);  call(0x1008_a228, 0xdae0);            /* call 0x1008a228 */
            ii(0x1007_c748, 5);  call(0x1008_a370, 0xdc23);            /* call 0x1008a370 */
            ii(0x1007_c74d, 3);  mov(ebx, memd[ss, ebp - 4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1007_c750, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_c752, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1007_c754, 5);  call(0x1007_af7a, -0x17df);           /* call 0x1007af7a */
            ii(0x1007_c759, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_c75b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_c75e, 4);  sub(memw[ds, eax + 37], dx);          /* sub [eax+0x25], dx */
        l_0x1007_c762:
            ii(0x1007_c762, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_c764, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_c767, 3);  add(eax, 0xf);                        /* add eax, 0xf */
            ii(0x1007_c76a, 5);  call(0x1013_ad71, 0xb_e602);          /* call 0x1013ad71 */
            ii(0x1007_c76f, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_c771, 2);  if(jz(0x1007_c790, 0x1d)) goto l_0x1007_c790;/* jz 0x1007c790 */
            ii(0x1007_c773, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_c776, 3);  add(eax, 0xf);                        /* add eax, 0xf */
            ii(0x1007_c779, 5);  call(0x1008_af28, 0xe7aa);            /* call 0x1008af28 */
            ii(0x1007_c77e, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_c781, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_c784, 3);  mov(ebx, memd[ds, eax + 2]);          /* mov ebx, [eax+0x2] */
            ii(0x1007_c787, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_c78a, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_c78d, 3);  call_abs(memd[ds, ebx + 84]);         /* call dword [ebx+0x54] */
        l_0x1007_c790:
            ii(0x1007_c790, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_c793, 5);  call(0x1008_acf8, 0xe560);            /* call 0x1008acf8 */
            ii(0x1007_c798, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_c79a, 2);  if(jnz(0x1007_c7ee, 0x52)) goto l_0x1007_c7ee;/* jnz 0x1007c7ee */
            ii(0x1007_c79c, 5);  call(0x1008_a7bc, 0xe01b);            /* call 0x1008a7bc */
            ii(0x1007_c7a1, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1007_c7a6, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1007_c7a9, 5);  mov(eax, 0xa);                        /* mov eax, 0xa */
            ii(0x1007_c7ae, 5);  call(Definitions.sys_new, 0xe_964d);  /* call 0x10165e00 */
            ii(0x1007_c7b3, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1007_c7b6, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1007_c7b9, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1007_c7bc, 4);  cmp(memd[ss, ebp - 28], 0);           /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1007_c7c0, 2);  if(jz(0x1007_c7d8, 0x16)) goto l_0x1007_c7d8;/* jz 0x1007c7d8 */
            ii(0x1007_c7c2, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1007_c7c5, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1007_c7c8, 5);  call(0x100a_3711, 0x2_6f44);          /* call 0x100a3711 */
            ii(0x1007_c7cd, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1007_c7d0, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1007_c7d3, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1007_c7d6, 2);  jmp(0x1007_c7de, 6); goto l_0x1007_c7de;/* jmp 0x1007c7de */
        l_0x1007_c7d8:
            ii(0x1007_c7d8, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1007_c7db, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
        l_0x1007_c7de:
            ii(0x1007_c7de, 3);  mov(edx, memd[ss, ebp - 36]);         /* mov edx, [ebp-0x24] */
            ii(0x1007_c7e1, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1007_c7e6, 3);  mov(ebx, memd[ss, ebp - 20]);         /* mov ebx, [ebp-0x14] */
            ii(0x1007_c7e9, 5);  call(0x100a_4db6, 0x2_85c8);          /* call 0x100a4db6 */
        l_0x1007_c7ee:
            ii(0x1007_c7ee, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_c7f0, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1007_c7f3, 5);  call(0x1008_8b7c, 0xc384);            /* call 0x10088b7c */
            ii(0x1007_c7f8, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_c7fa, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_c7fb, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_c7fc, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_c7fd, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_c7fe, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_c7ff, 1);  ret();                                /* ret */
        }
    }
}
