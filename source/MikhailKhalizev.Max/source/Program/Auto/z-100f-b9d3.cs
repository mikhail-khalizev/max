using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_b9d3-5e1627fe")]
        public void Method_100f_b9d3()
        {
            ii(0x100f_b9d3, 5);  push(0x44);                           /* push 0x44 */
            ii(0x100f_b9d8, 5);  call(Definitions.sys_check_available_stack_size, 0x6_a375);/* call 0x10165d52 */
            ii(0x100f_b9dd, 1);  push(ebx);                            /* push ebx */
            ii(0x100f_b9de, 1);  push(ecx);                            /* push ecx */
            ii(0x100f_b9df, 1);  push(esi);                            /* push esi */
            ii(0x100f_b9e0, 1);  push(edi);                            /* push edi */
            ii(0x100f_b9e1, 1);  push(ebp);                            /* push ebp */
            ii(0x100f_b9e2, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100f_b9e4, 6);  sub(esp, 0x2c);                       /* sub esp, 0x2c */
            ii(0x100f_b9ea, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100f_b9ed, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100f_b9f0, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_b9f4, 3);  imul(edx, eax, 0x13);                 /* imul edx, eax, 0x13 */
            ii(0x100f_b9f7, 5);  mov(eax, 0x101c_35b4);                /* mov eax, 0x101c35b4 */
            ii(0x100f_b9fc, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100f_b9fe, 5);  call(Definitions.my_2_get_count, -0x7_069b);/* call 0x1008b368 */
            ii(0x100f_ba03, 1);  cwde();                               /* cwde */
            ii(0x100f_ba04, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100f_ba06, 2);  if(jnz(0x100f_ba11, 9)) goto l_0x100f_ba11;/* jnz 0x100fba11 */
            ii(0x100f_ba08, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
            ii(0x100f_ba0c, 5);  jmp(0x100f_baf1, 0xe0); goto l_0x100f_baf1;/* jmp 0x100fbaf1 */
        l_0x100f_ba11:
            ii(0x100f_ba11, 5);  mov(eax, 7);                          /* mov eax, 0x7 */
            ii(0x100f_ba16, 5);  call(0x1007_5fdc, -0x8_5a3f);         /* call 0x10075fdc */
            ii(0x100f_ba1b, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x100f_ba1e, 5);  mov(eax, 6);                          /* mov eax, 0x6 */
            ii(0x100f_ba23, 5);  call(0x1007_5fdc, -0x8_5a4c);         /* call 0x10075fdc */
            ii(0x100f_ba28, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
            ii(0x100f_ba2b, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100f_ba2f, 3);  imul(eax, eax, 0x13);                 /* imul eax, eax, 0x13 */
            ii(0x100f_ba32, 7);  mov(ax, memw[ds, eax + 0x101c_35bc]); /* mov ax, [eax+0x101c35bc] */
            ii(0x100f_ba39, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100f_ba3c, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100f_ba40, 3);  imul(eax, eax, 0x13);                 /* imul eax, eax, 0x13 */
            ii(0x100f_ba43, 7);  mov(ax, memw[ds, eax + 0x101c_35be]); /* mov ax, [eax+0x101c35be] */
            ii(0x100f_ba4a, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x100f_ba4d, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100f_ba51, 3);  imul(eax, eax, 0x13);                 /* imul eax, eax, 0x13 */
            ii(0x100f_ba54, 6);  mov(al, memb[ds, eax + 0x101c_35c6]); /* mov al, [eax+0x101c35c6] */
            ii(0x100f_ba5a, 3);  mov(memb[ss, ebp - 16], al);          /* mov [ebp-0x10], al */
            ii(0x100f_ba5d, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_ba61, 3);  imul(eax, eax, 0x13);                 /* imul eax, eax, 0x13 */
            ii(0x100f_ba64, 6);  mov(edx, memd[ds, eax + 0x101c_35ba]);/* mov edx, [eax+0x101c35ba] */
            ii(0x100f_ba6a, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100f_ba6d, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x100f_ba71, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x100f_ba73, 5);  call(/* sys */ 0x1016_5df8, 0x6_a380);/* call 0x10165df8 */
            ii(0x100f_ba78, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100f_ba7b, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_ba7f, 3);  imul(eax, eax, 0x13);                 /* imul eax, eax, 0x13 */
            ii(0x100f_ba82, 6);  mov(edx, memd[ds, eax + 0x101c_35bc]);/* mov edx, [eax+0x101c35bc] */
            ii(0x100f_ba88, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100f_ba8b, 4);  movsx(eax, memw[ss, ebp - 40]);       /* movsx eax, word [ebp-0x28] */
            ii(0x100f_ba8f, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x100f_ba91, 5);  call(/* sys */ 0x1016_5df8, 0x6_a362);/* call 0x10165df8 */
            ii(0x100f_ba96, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x100f_ba99, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_ba9d, 3);  imul(eax, eax, 0x13);                 /* imul eax, eax, 0x13 */
            ii(0x100f_baa0, 6);  mov(al, memb[ds, eax + 0x101c_35c6]); /* mov al, [eax+0x101c35c6] */
            ii(0x100f_baa6, 3);  mov(memb[ss, ebp - 20], al);          /* mov [ebp-0x14], al */
            ii(0x100f_baa9, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100f_baac, 4);  cmp(ax, memw[ss, ebp - 44]);          /* cmp ax, [ebp-0x2c] */
            ii(0x100f_bab0, 2);  if(jg(0x100f_babb, 9)) goto l_0x100f_babb;/* jg 0x100fbabb */
            ii(0x100f_bab2, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x100f_bab5, 4);  cmp(ax, memw[ss, ebp - 44]);          /* cmp ax, [ebp-0x2c] */
            ii(0x100f_bab9, 2);  if(jle(0x100f_babd, 2)) goto l_0x100f_babd;/* jle 0x100fbabd */
        l_0x100f_babb:
            ii(0x100f_babb, 2);  jmp(0x100f_bac3, 6); goto l_0x100f_bac3;/* jmp 0x100fbac3 */
        l_0x100f_babd:
            ii(0x100f_babd, 4);  mov(memb[ss, ebp - 12], 3);           /* mov byte [ebp-0xc], 0x3 */
            ii(0x100f_bac1, 2);  jmp(0x100f_baf1, 0x2e); goto l_0x100f_baf1;/* jmp 0x100fbaf1 */
        l_0x100f_bac3:
            ii(0x100f_bac3, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100f_bac6, 4);  cmp(ax, memw[ss, ebp - 32]);          /* cmp ax, [ebp-0x20] */
            ii(0x100f_baca, 2);  if(jg(0x100f_bad5, 9)) goto l_0x100f_bad5;/* jg 0x100fbad5 */
            ii(0x100f_bacc, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x100f_bacf, 4);  cmp(ax, memw[ss, ebp - 32]);          /* cmp ax, [ebp-0x20] */
            ii(0x100f_bad3, 2);  if(jle(0x100f_bad7, 2)) goto l_0x100f_bad7;/* jle 0x100fbad7 */
        l_0x100f_bad5:
            ii(0x100f_bad5, 2);  jmp(0x100f_bae5, 0xe); goto l_0x100f_bae5;/* jmp 0x100fbae5 */
        l_0x100f_bad7:
            ii(0x100f_bad7, 4);  cmp(memb[ss, ebp - 16], 4);           /* cmp byte [ebp-0x10], 0x4 */
            ii(0x100f_badb, 2);  if(jnz(0x100f_bae3, 6)) goto l_0x100f_bae3;/* jnz 0x100fbae3 */
            ii(0x100f_badd, 4);  cmp(memb[ss, ebp - 20], 4);           /* cmp byte [ebp-0x14], 0x4 */
            ii(0x100f_bae1, 2);  if(jz(0x100f_bae5, 2)) goto l_0x100f_bae5;/* jz 0x100fbae5 */
        l_0x100f_bae3:
            ii(0x100f_bae3, 2);  jmp(0x100f_bae7, 2); goto l_0x100f_bae7;/* jmp 0x100fbae7 */
        l_0x100f_bae5:
            ii(0x100f_bae5, 2);  jmp(0x100f_baed, 6); goto l_0x100f_baed;/* jmp 0x100fbaed */
        l_0x100f_bae7:
            ii(0x100f_bae7, 4);  mov(memb[ss, ebp - 12], 2);           /* mov byte [ebp-0xc], 0x2 */
            ii(0x100f_baeb, 2);  jmp(0x100f_baf1, 4); goto l_0x100f_baf1;/* jmp 0x100fbaf1 */
        l_0x100f_baed:
            ii(0x100f_baed, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
        l_0x100f_baf1:
            ii(0x100f_baf1, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x100f_baf4, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100f_baf6, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100f_baf7, 1);  pop(edi);                             /* pop edi */
            ii(0x100f_baf8, 1);  pop(esi);                             /* pop esi */
            ii(0x100f_baf9, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100f_bafa, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100f_bafb, 1);  ret();                                /* ret */
        }
    }
}
