using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_625f-b0913539")]
        public void Method_1009_625f()
        {
            ii(0x1009_625f, 5);  push(0x38);                           /* push 0x38 */
            ii(0x1009_6264, 5);  call(Definitions.sys_check_available_stack_size, 0xc_fae9);/* call 0x10165d52 */
            ii(0x1009_6269, 1);  push(esi);                            /* push esi */
            ii(0x1009_626a, 1);  push(edi);                            /* push edi */
            ii(0x1009_626b, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_626c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_626e, 6);  sub(esp, 0x28);                       /* sub esp, 0x28 */
            ii(0x1009_6274, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_6277, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x1009_627a, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1009_627d, 3);  mov(memd[ss, ebp - 8], ecx);          /* mov [ebp-0x8], ecx */
            ii(0x1009_6280, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_6283, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x1009_6286, 5);  call(0x1007_6338, -0x1_ff53);         /* call 0x10076338 */
            ii(0x1009_628b, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_628d, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1009_6290, 5);  call(0x1007_64b8, -0x1_fddd);         /* call 0x100764b8 */
            ii(0x1009_6295, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1009_6298, 5);  call(Definitions.my_ctor_0x101b_4184, -0x1_f7ad);/* call 0x10076af0 */
            ii(0x1009_629d, 2);  jmp(0x1009_62a7, 8); goto l_0x1009_62a7;/* jmp 0x100962a7 */
        l_0x1009_629f:
            ii(0x1009_629f, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1009_62a2, 5);  call(0x1007_6bf8, -0x1_f6af);         /* call 0x10076bf8 */
        l_0x1009_62a7:
            ii(0x1009_62a7, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_62a9, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1009_62ac, 5);  call(0x1013_ad71, 0xa_4ac0);          /* call 0x1013ad71 */
            ii(0x1009_62b1, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_62b3, 6);  if(jz(0x1009_6353, 0x9a)) goto l_0x1009_6353;/* jz 0x10096353 */
            ii(0x1009_62b9, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1009_62bc, 5);  call(0x1007_63a0, -0x1_ff21);         /* call 0x100763a0 */
            ii(0x1009_62c1, 5);  cmp(memw[ds, eax + 8], 5);            /* cmp word [eax+0x8], 0x5 */
            ii(0x1009_62c6, 6);  if(jnz(0x1009_634e, 0x82)) goto l_0x1009_634e;/* jnz 0x1009634e */
            ii(0x1009_62cc, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1009_62cf, 5);  call(0x1007_63a0, -0x1_ff34);         /* call 0x100763a0 */
            ii(0x1009_62d4, 5);  call(0x1007_623c, -0x2_009d);         /* call 0x1007623c */
            ii(0x1009_62d9, 4);  mov(ax, memw[ds, eax + 23]);          /* mov ax, [eax+0x17] */
            ii(0x1009_62dd, 3);  sub(eax, memd[ss, ebp - 4]);          /* sub eax, [ebp-0x4] */
            ii(0x1009_62e0, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1009_62e3, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1009_62e6, 5);  call(0x1007_63a0, -0x1_ff4b);         /* call 0x100763a0 */
            ii(0x1009_62eb, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_62ed, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_62f0, 3);  mov(ax, memw[ds, eax]);               /* mov ax, [eax] */
            ii(0x1009_62f3, 4);  sub(ax, memw[ds, edx + 26]);          /* sub ax, [edx+0x1a] */
            ii(0x1009_62f7, 4);  mov(memw[ss, ebp - 28], ax);          /* mov [ebp-0x1c], ax */
            ii(0x1009_62fb, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1009_62fe, 5);  call(0x1007_63a0, -0x1_ff63);         /* call 0x100763a0 */
            ii(0x1009_6303, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1009_6306, 4);  mov(dx, memw[ds, edx + 2]);           /* mov dx, [edx+0x2] */
            ii(0x1009_630a, 4);  sub(dx, memw[ds, eax + 28]);          /* sub dx, [eax+0x1c] */
            ii(0x1009_630e, 4);  mov(memw[ss, ebp - 26], dx);          /* mov [ebp-0x1a], dx */
            ii(0x1009_6312, 4);  movsx(edx, memw[ss, ebp - 26]);       /* movsx edx, word [ebp-0x1a] */
            ii(0x1009_6316, 4);  movsx(eax, memw[ss, ebp - 26]);       /* movsx eax, word [ebp-0x1a] */
            ii(0x1009_631a, 3);  imul(edx, eax);                       /* imul edx, eax */
            ii(0x1009_631d, 2);  mov(ebx, edx);                        /* mov ebx, edx */
            ii(0x1009_631f, 4);  movsx(edx, memw[ss, ebp - 28]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x1009_6323, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1009_6327, 3);  imul(eax, edx);                       /* imul eax, edx */
            ii(0x1009_632a, 2);  add(ebx, eax);                        /* add ebx, eax */
            ii(0x1009_632c, 4);  movsx(edx, memw[ss, ebp - 32]);       /* movsx edx, word [ebp-0x20] */
            ii(0x1009_6330, 4);  movsx(eax, memw[ss, ebp - 32]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1009_6334, 3);  imul(eax, edx);                       /* imul eax, edx */
            ii(0x1009_6337, 2);  cmp(ebx, eax);                        /* cmp ebx, eax */
            ii(0x1009_6339, 2);  if(jg(0x1009_634e, 0x13)) goto l_0x1009_634e;/* jg 0x1009634e */
            ii(0x1009_633b, 4);  mov(memb[ss, ebp - 20], 1);           /* mov byte [ebp-0x14], 0x1 */
            ii(0x1009_633f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_6341, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1009_6344, 5);  call(0x1007_5f6c, -0x2_03dd);         /* call 0x10075f6c */
            ii(0x1009_6349, 5);  jmp(0x1009_646f, 0x121); goto l_0x1009_646f;/* jmp 0x1009646f */
        l_0x1009_634e:
            ii(0x1009_634e, 5);  jmp(0x1009_629f, -0xb4); goto l_0x1009_629f;/* jmp 0x1009629f */
        l_0x1009_6353:
            ii(0x1009_6353, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_6356, 3);  add(eax, 0x21);                       /* add eax, 0x21 */
            ii(0x1009_6359, 5);  call(0x1009_c6c8, 0x636a);            /* call 0x1009c6c8 */
            ii(0x1009_635e, 3);  lea(ebx, memd[ss, ebp - 36]);         /* lea ebx, [ebp-0x24] */
            ii(0x1009_6361, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_6363, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1009_6365, 5);  call(0x1009_c5dc, 0x6272);            /* call 0x1009c5dc */
            ii(0x1009_636a, 2);  jmp(0x1009_6374, 8); goto l_0x1009_6374;/* jmp 0x10096374 */
        l_0x1009_636c:
            ii(0x1009_636c, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x1009_636f, 5);  call(0x1007_6bf8, -0x1_f77c);         /* call 0x10076bf8 */
        l_0x1009_6374:
            ii(0x1009_6374, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_6376, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x1009_6379, 5);  call(0x1013_ad71, 0xa_49f3);          /* call 0x1013ad71 */
            ii(0x1009_637e, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_6380, 6);  if(jz(0x1009_6441, 0xbb)) goto l_0x1009_6441;/* jz 0x10096441 */
            ii(0x1009_6386, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x1009_6389, 5);  call(0x1009_c4f8, 0x616a);            /* call 0x1009c4f8 */
            ii(0x1009_638e, 5);  call(0x1009_c4c4, 0x6131);            /* call 0x1009c4c4 */
            ii(0x1009_6393, 4);  cmp(ax, 5);                           /* cmp ax, 0x5 */
            ii(0x1009_6397, 2);  if(jnz(0x1009_63a6, 0xd)) goto l_0x1009_63a6;/* jnz 0x100963a6 */
            ii(0x1009_6399, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x1009_639c, 5);  call(0x1009_c52c, 0x618b);            /* call 0x1009c52c */
            ii(0x1009_63a1, 3);  cmp(eax, memd[ss, ebp - 8]);          /* cmp eax, [ebp-0x8] */
            ii(0x1009_63a4, 2);  if(jnz(0x1009_63ab, 5)) goto l_0x1009_63ab;/* jnz 0x100963ab */
        l_0x1009_63a6:
            ii(0x1009_63a6, 5);  jmp(0x1009_643c, 0x91); goto l_0x1009_643c;/* jmp 0x1009643c */
        l_0x1009_63ab:
            ii(0x1009_63ab, 5);  mov(edx, 5);                          /* mov edx, 0x5 */
            ii(0x1009_63b0, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_63b3, 3);  mov(eax, memd[ds, eax + 7]);          /* mov eax, [eax+0x7] */
            ii(0x1009_63b6, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_63b9, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x1009_63bf, 6);  mov(eax, memd[ds, eax + 0x101c_a562]);/* mov eax, [eax+0x101ca562] */
            ii(0x1009_63c5, 5);  call(0x1008_b104, -0xb2c6);           /* call 0x1008b104 */
            ii(0x1009_63ca, 4);  mov(ax, memw[ds, eax + 23]);          /* mov ax, [eax+0x17] */
            ii(0x1009_63ce, 3);  sub(eax, memd[ss, ebp - 4]);          /* sub eax, [ebp-0x4] */
            ii(0x1009_63d1, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1009_63d4, 3);  lea(edx, memd[ss, ebp - 40]);         /* lea edx, [ebp-0x28] */
            ii(0x1009_63d7, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x1009_63da, 5);  call(0x1009_c4f8, 0x6119);            /* call 0x1009c4f8 */
            ii(0x1009_63df, 5);  call(0x100a_2d3d, 0xc959);            /* call 0x100a2d3d */
            ii(0x1009_63e4, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_63e6, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1009_63e9, 5);  call(0x1008_8b44, -0xd8aa);           /* call 0x10088b44 */
            ii(0x1009_63ee, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1009_63f1, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1009_63f4, 5);  call(0x1007_6a6c, -0x1_f98d);         /* call 0x10076a6c */
            ii(0x1009_63f9, 4);  movsx(edx, memw[ss, ebp - 26]);       /* movsx edx, word [ebp-0x1a] */
            ii(0x1009_63fd, 4);  movsx(eax, memw[ss, ebp - 26]);       /* movsx eax, word [ebp-0x1a] */
            ii(0x1009_6401, 3);  imul(edx, eax);                       /* imul edx, eax */
            ii(0x1009_6404, 2);  mov(ebx, edx);                        /* mov ebx, edx */
            ii(0x1009_6406, 4);  movsx(edx, memw[ss, ebp - 28]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x1009_640a, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1009_640e, 3);  imul(eax, edx);                       /* imul eax, edx */
            ii(0x1009_6411, 2);  add(ebx, eax);                        /* add ebx, eax */
            ii(0x1009_6413, 4);  movsx(edx, memw[ss, ebp - 32]);       /* movsx edx, word [ebp-0x20] */
            ii(0x1009_6417, 4);  movsx(eax, memw[ss, ebp - 32]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1009_641b, 3);  imul(eax, edx);                       /* imul eax, edx */
            ii(0x1009_641e, 2);  cmp(ebx, eax);                        /* cmp ebx, eax */
            ii(0x1009_6420, 2);  if(jg(0x1009_643c, 0x1a)) goto l_0x1009_643c;/* jg 0x1009643c */
            ii(0x1009_6422, 4);  mov(memb[ss, ebp - 20], 1);           /* mov byte [ebp-0x14], 0x1 */
            ii(0x1009_6426, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_6428, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x1009_642b, 5);  call(0x1009_ba6c, 0x563c);            /* call 0x1009ba6c */
            ii(0x1009_6430, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_6432, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1009_6435, 5);  call(0x1007_5f6c, -0x2_04ce);         /* call 0x10075f6c */
            ii(0x1009_643a, 2);  jmp(0x1009_646f, 0x33); goto l_0x1009_646f;/* jmp 0x1009646f */
        l_0x1009_643c:
            ii(0x1009_643c, 5);  jmp(0x1009_636c, -0xd5); goto l_0x1009_636c;/* jmp 0x1009636c */
        l_0x1009_6441:
            ii(0x1009_6441, 4);  mov(memb[ss, ebp - 20], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x1009_6445, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_6447, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x1009_644a, 5);  call(0x1009_ba6c, 0x561d);            /* call 0x1009ba6c */
            ii(0x1009_644f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_6451, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1009_6454, 5);  call(0x1007_5f6c, -0x2_04ed);         /* call 0x10075f6c */
            ii(0x1009_6459, 2);  jmp(0x1009_646f, 0x14); goto l_0x1009_646f;/* jmp 0x1009646f */
        //  ii(0x1009_645b, 2);  xor(edx, edx);                        /* xor edx, edx */
        //  ii(0x1009_645d, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
        //  ii(0x1009_6460, 5);  call(0x1009_ba6c, 0x5607);            /* call 0x1009ba6c */
        //  ii(0x1009_6465, 2);  xor(edx, edx);                        /* xor edx, edx */
        //  ii(0x1009_6467, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
        //  ii(0x1009_646a, 5);  call(0x1007_5f6c, -0x2_0503);         /* call 0x10075f6c */
        l_0x1009_646f:
            ii(0x1009_646f, 3);  mov(al, memb[ss, ebp - 20]);          /* mov al, [ebp-0x14] */
            ii(0x1009_6472, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_6474, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_6475, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_6476, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_6477, 1);  ret();                                /* ret */
        }
    }
}
