using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_c486-7520ec07")]
        public void Method_100e_c486()
        {
            ii(0x100e_c486, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x100e_c48b, 5);  call(Definitions.sys_check_available_stack_size, 0x7_98c2);/* call 0x10165d52 */
            ii(0x100e_c490, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_c491, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_c492, 1);  push(esi);                            /* push esi */
            ii(0x100e_c493, 1);  push(edi);                            /* push edi */
            ii(0x100e_c494, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_c495, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_c497, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x100e_c49d, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_c4a0, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_c4a3, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100e_c4a7, 5);  call(0x100e_c3fc, -0xb0);             /* call 0x100ec3fc */
            ii(0x100e_c4ac, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100e_c4ae, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100e_c4b1, 5);  call(0x1007_64b8, -0x7_5ffe);         /* call 0x100764b8 */
            ii(0x100e_c4b6, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x100e_c4bd, 2);  jmp(0x100e_c4c7, 8); goto l_0x100e_c4c7;/* jmp 0x100ec4c7 */
        l_0x100e_c4bf:
            ii(0x100e_c4bf, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100e_c4c2, 5);  call(0x1007_6bf8, -0x7_58cf);         /* call 0x10076bf8 */
        l_0x100e_c4c7:
            ii(0x100e_c4c7, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_c4c9, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100e_c4cc, 5);  call(0x1013_ad71, 0x4_e8a0);          /* call 0x1013ad71 */
            ii(0x100e_c4d1, 2);  test(al, al);                         /* test al, al */
            ii(0x100e_c4d3, 2);  if(jz(0x100e_c516, 0x41)) goto l_0x100e_c516;/* jz 0x100ec516 */
            ii(0x100e_c4d5, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100e_c4d8, 5);  call(0x1007_63a0, -0x7_613d);         /* call 0x100763a0 */
            ii(0x100e_c4dd, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_c4df, 3);  mov(dl, memb[ds, eax + 38]);          /* mov dl, [eax+0x26] */
            ii(0x100e_c4e2, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100e_c4e6, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100e_c4e8, 2);  if(jnz(0x100e_c4fc, 0x12)) goto l_0x100e_c4fc;/* jnz 0x100ec4fc */
            ii(0x100e_c4ea, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100e_c4ed, 5);  call(0x1007_63a0, -0x7_6152);         /* call 0x100763a0 */
            ii(0x100e_c4f2, 4);  mov(ax, memw[ds, eax + 8]);           /* mov ax, [eax+0x8] */
            ii(0x100e_c4f6, 4);  cmp(ax, memw[ss, ebp - 4]);           /* cmp ax, [ebp-0x4] */
            ii(0x100e_c4fa, 2);  if(jz(0x100e_c4fe, 2)) goto l_0x100e_c4fe;/* jz 0x100ec4fe */
        l_0x100e_c4fc:
            ii(0x100e_c4fc, 2);  jmp(0x100e_c50c, 0xe); goto l_0x100e_c50c;/* jmp 0x100ec50c */
        l_0x100e_c4fe:
            ii(0x100e_c4fe, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100e_c501, 5);  call(0x1007_63a0, -0x7_6166);         /* call 0x100763a0 */
            ii(0x100e_c506, 4);  cmp(memb[ds, eax + 62], 0x1e);        /* cmp byte [eax+0x3e], 0x1e */
            ii(0x100e_c50a, 2);  if(jnz(0x100e_c50e, 2)) goto l_0x100e_c50e;/* jnz 0x100ec50e */
        l_0x100e_c50c:
            ii(0x100e_c50c, 2);  jmp(0x100e_c514, 6); goto l_0x100e_c514;/* jmp 0x100ec514 */
        l_0x100e_c50e:
            ii(0x100e_c50e, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_c511, 3);  inc(memd[ss, ebp - 16]);              /* inc dword [ebp-0x10] */
        l_0x100e_c514:
            ii(0x100e_c514, 2);  jmp(0x100e_c4bf, -0x57); goto l_0x100e_c4bf;/* jmp 0x100ec4bf */
        l_0x100e_c516:
            ii(0x100e_c516, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_c519, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100e_c51c, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_c51e, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100e_c521, 5);  call(0x1007_5f6c, -0x7_65ba);         /* call 0x10075f6c */
            ii(0x100e_c526, 2);  jmp(0x100e_c532, 0xa); goto l_0x100e_c532;/* jmp 0x100ec532 */
        //  ii(0x100e_c528, 2);  xor(edx, edx);                        /* xor edx, edx */
        //  ii(0x100e_c52a, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
        //  ii(0x100e_c52d, 5);  call(0x1007_5f6c, -0x7_65c6);         /* call 0x10075f6c */
        l_0x100e_c532:
            ii(0x100e_c532, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100e_c535, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_c537, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_c538, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_c539, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_c53a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_c53b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_c53c, 1);  ret();                                /* ret */
        }
    }
}
