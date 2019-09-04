using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_b6f4-ac3b8e4")]
        public void Method_1008_b6f4()
        {
            ii(0x1008_b6f4, 5);  push(0x40);                           /* push 0x40 */
            ii(0x1008_b6f9, 5);  call(Definitions.sys_check_available_stack_size, 0xd_a654);/* call 0x10165d52 */
            ii(0x1008_b6fe, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_b6ff, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_b700, 1);  push(edx);                            /* push edx */
            ii(0x1008_b701, 1);  push(esi);                            /* push esi */
            ii(0x1008_b702, 1);  push(edi);                            /* push edi */
            ii(0x1008_b703, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_b704, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_b706, 6);  sub(esp, 0x24);                       /* sub esp, 0x24 */
            ii(0x1008_b70c, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_b70f, 5);  mov(eax, 0x101c_819c);                /* mov eax, 0x101c819c */
            ii(0x1008_b714, 5);  call(0x1007_6338, -0x1_53e1);         /* call 0x10076338 */
            ii(0x1008_b719, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_b71b, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1008_b71e, 5);  call(0x1007_64b8, -0x1_526b);         /* call 0x100764b8 */
            ii(0x1008_b723, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1008_b728, 5);  call(0x1008_a768, -0xfc5);            /* call 0x1008a768 */
            ii(0x1008_b72d, 3);  lea(ebx, memd[ss, ebp - 16]);         /* lea ebx, [ebp-0x10] */
            ii(0x1008_b730, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_b732, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1008_b734, 5);  call(0x1008_ae70, -0x8c9);            /* call 0x1008ae70 */
            ii(0x1008_b739, 7);  mov(memd[ss, ebp - 20], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x1008_b740, 2);  jmp(0x1008_b74a, 8); goto l_0x1008_b74a;/* jmp 0x1008b74a */
        l_0x1008_b742:
            ii(0x1008_b742, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1008_b745, 5);  call(0x1007_6bf8, -0x1_4b52);         /* call 0x10076bf8 */
        l_0x1008_b74a:
            ii(0x1008_b74a, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_b74c, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1008_b74f, 5);  call(0x1013_ad71, 0xa_f61d);          /* call 0x1013ad71 */
            ii(0x1008_b754, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_b756, 2);  if(jz(0x1008_b785, 0x2d)) goto l_0x1008_b785;/* jz 0x1008b785 */
            ii(0x1008_b758, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1008_b75b, 5);  call(0x1007_63a0, -0x1_53c0);         /* call 0x100763a0 */
            ii(0x1008_b760, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_b762, 3);  mov(dl, memb[ds, eax + 38]);          /* mov dl, [eax+0x26] */
            ii(0x1008_b765, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1008_b769, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1008_b76b, 2);  if(jnz(0x1008_b783, 0x16)) goto l_0x1008_b783;/* jnz 0x1008b783 */
            ii(0x1008_b76d, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1008_b770, 5);  call(0x1007_63a0, -0x1_53d5);         /* call 0x100763a0 */
            ii(0x1008_b775, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x1008_b778, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1008_b77b, 5);  call(0x1007_1ff5, -0x1_978b);         /* call 0x10071ff5 */
            ii(0x1008_b780, 3);  add(memd[ss, ebp - 20], eax);         /* add [ebp-0x14], eax */
        l_0x1008_b783:
            ii(0x1008_b783, 2);  jmp(0x1008_b742, -0x43); goto l_0x1008_b742;/* jmp 0x1008b742 */
        l_0x1008_b785:
            ii(0x1008_b785, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1008_b789, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_b78b, 2);  if(jg(0x1008_b7aa, 0x1d)) goto l_0x1008_b7aa;/* jg 0x1008b7aa */
            ii(0x1008_b78d, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x1008_b791, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_b793, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_b796, 5);  call(0x1008_8bbc, -0x2bdf);           /* call 0x10088bbc */
            ii(0x1008_b79b, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_b79d, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1008_b7a0, 5);  call(0x1007_5f6c, -0x1_5839);         /* call 0x10075f6c */
            ii(0x1008_b7a5, 5);  jmp(0x1008_b868, 0xbe); goto l_0x1008_b868;/* jmp 0x1008b868 */
        l_0x1008_b7aa:
            ii(0x1008_b7aa, 2);  jmp(0x1008_b7b4, 8); goto l_0x1008_b7b4;/* jmp 0x1008b7b4 */
        l_0x1008_b7ac:
            ii(0x1008_b7ac, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_b7af, 5);  call(0x1007_6bf8, -0x1_4bbc);         /* call 0x10076bf8 */
        l_0x1008_b7b4:
            ii(0x1008_b7b4, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_b7b6, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_b7b9, 5);  call(0x1013_ad71, 0xa_f5b3);          /* call 0x1013ad71 */
            ii(0x1008_b7be, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_b7c0, 2);  if(jz(0x1008_b826, 0x64)) goto l_0x1008_b826;/* jz 0x1008b826 */
            ii(0x1008_b7c2, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_b7c5, 5);  call(0x1008_adc4, -0xa06);            /* call 0x1008adc4 */
            ii(0x1008_b7ca, 5);  call(0x1008_ad90, -0xa3f);            /* call 0x1008ad90 */
            ii(0x1008_b7cf, 4);  cmp(ax, memw[ss, ebp - 4]);           /* cmp ax, [ebp-0x4] */
            ii(0x1008_b7d3, 2);  if(jnz(0x1008_b7f0, 0x1b)) goto l_0x1008_b7f0;/* jnz 0x1008b7f0 */
            ii(0x1008_b7d5, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_b7d8, 5);  call(0x1008_adc4, -0xa19);            /* call 0x1008adc4 */
            ii(0x1008_b7dd, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1008_b7e0, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1008_b7e3, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x1008_b7e6, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1008_b7e9, 3);  call_abs(memd[ds, edx + 32]);         /* call dword [edx+0x20] */
            ii(0x1008_b7ec, 2);  cmp(al, 9);                           /* cmp al, 0x9 */
            ii(0x1008_b7ee, 2);  if(jz(0x1008_b7f2, 2)) goto l_0x1008_b7f2;/* jz 0x1008b7f2 */
        l_0x1008_b7f0:
            ii(0x1008_b7f0, 2);  jmp(0x1008_b824, 0x32); goto l_0x1008_b824;/* jmp 0x1008b824 */
        l_0x1008_b7f2:
            ii(0x1008_b7f2, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_b7f5, 5);  call(0x1008_adf8, -0xa02);            /* call 0x1008adf8 */
            ii(0x1008_b7fa, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1008_b7fd, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1008_b800, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1008_b803, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1008_b806, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x1008_b809, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1008_b80c, 3);  call_abs(memd[ds, edx + 112]);        /* call dword [edx+0x70] */
            ii(0x1008_b80f, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_b811, 2);  if(jz(0x1008_b824, 0x11)) goto l_0x1008_b824;/* jz 0x1008b824 */
            ii(0x1008_b813, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1008_b816, 5);  call(0x1009_c4c4, 0x1_0ca9);          /* call 0x1009c4c4 */
            ii(0x1008_b81b, 1);  cwde();                               /* cwde */
            ii(0x1008_b81c, 5);  call(0x1007_1ff5, -0x1_982c);         /* call 0x10071ff5 */
            ii(0x1008_b821, 3);  add(memd[ss, ebp - 20], eax);         /* add [ebp-0x14], eax */
        l_0x1008_b824:
            ii(0x1008_b824, 2);  jmp(0x1008_b7ac, -0x7a); goto l_0x1008_b7ac;/* jmp 0x1008b7ac */
        l_0x1008_b826:
            ii(0x1008_b826, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1008_b82a, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_b82c, 2);  if(jle(0x1008_b834, 6)) goto l_0x1008_b834;/* jle 0x1008b834 */
            ii(0x1008_b82e, 4);  mov(memb[ss, ebp - 36], 1);           /* mov byte [ebp-0x24], 0x1 */
            ii(0x1008_b832, 2);  jmp(0x1008_b838, 4); goto l_0x1008_b838;/* jmp 0x1008b838 */
        l_0x1008_b834:
            ii(0x1008_b834, 4);  mov(memb[ss, ebp - 36], 0);           /* mov byte [ebp-0x24], 0x0 */
        l_0x1008_b838:
            ii(0x1008_b838, 3);  mov(al, memb[ss, ebp - 36]);          /* mov al, [ebp-0x24] */
            ii(0x1008_b83b, 3);  mov(memb[ss, ebp - 8], al);           /* mov [ebp-0x8], al */
            ii(0x1008_b83e, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_b840, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_b843, 5);  call(0x1008_8bbc, -0x2c8c);           /* call 0x10088bbc */
            ii(0x1008_b848, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_b84a, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1008_b84d, 5);  call(0x1007_5f6c, -0x1_58e6);         /* call 0x10075f6c */
            ii(0x1008_b852, 2);  jmp(0x1008_b868, 0x14); goto l_0x1008_b868;/* jmp 0x1008b868 */
        //  ii(0x1008_b854, 2);  xor(edx, edx);                        /* xor edx, edx */
        //  ii(0x1008_b856, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
        //  ii(0x1008_b859, 5);  call(0x1008_8bbc, -0x2ca2);           /* call 0x10088bbc */
        //  ii(0x1008_b85e, 2);  xor(edx, edx);                        /* xor edx, edx */
        //  ii(0x1008_b860, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
        //  ii(0x1008_b863, 5);  call(0x1007_5f6c, -0x1_58fc);         /* call 0x10075f6c */
        l_0x1008_b868:
            ii(0x1008_b868, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x1008_b86b, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_b86d, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_b86e, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_b86f, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_b870, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_b871, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_b872, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_b873, 1);  ret();                                /* ret */
        }
    }
}
