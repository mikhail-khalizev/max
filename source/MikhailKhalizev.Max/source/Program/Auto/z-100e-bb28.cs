using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_bb28-19c8962a")]
        public void Method_100e_bb28()
        {
            ii(0x100e_bb28, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100e_bb2d, 5);  call(Definitions.sys_check_available_stack_size, 0x7_a220);/* call 0x10165d52 */
            ii(0x100e_bb32, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_bb33, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_bb34, 1);  push(esi);                            /* push esi */
            ii(0x100e_bb35, 1);  push(edi);                            /* push edi */
            ii(0x100e_bb36, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_bb37, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_bb39, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x100e_bb3f, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100e_bb42, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100e_bb45, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_bb48, 5);  call(0x1007_6338, -0x7_5815);         /* call 0x10076338 */
            ii(0x100e_bb4d, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100e_bb4f, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100e_bb52, 5);  call(0x1007_64b8, -0x7_569f);         /* call 0x100764b8 */
            ii(0x100e_bb57, 2);  jmp(0x100e_bb61, 8); goto l_0x100e_bb61;/* jmp 0x100ebb61 */
        l_0x100e_bb59:
            ii(0x100e_bb59, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100e_bb5c, 5);  call(0x1007_6bf8, -0x7_4f69);         /* call 0x10076bf8 */
        l_0x100e_bb61:
            ii(0x100e_bb61, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_bb63, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100e_bb66, 5);  call(0x1013_ad71, 0x4_f206);          /* call 0x1013ad71 */
            ii(0x100e_bb6b, 2);  test(al, al);                         /* test al, al */
            ii(0x100e_bb6d, 6);  if(jz(0x100e_bbd2, 0x5f)) goto l_0x100e_bbd2;/* jz 0x100ebbd2 */
            ii(0x100e_bb73, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100e_bb76, 5);  call(0x1007_63a0, -0x7_57db);         /* call 0x100763a0 */
            ii(0x100e_bb7b, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_bb7d, 3);  mov(dl, memb[ds, eax + 38]);          /* mov dl, [eax+0x26] */
            ii(0x100e_bb80, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100e_bb84, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100e_bb86, 2);  if(jnz(0x100e_bb9c, 0x14)) goto l_0x100e_bb9c;/* jnz 0x100ebb9c */
            ii(0x100e_bb88, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100e_bb8b, 5);  call(0x1007_63a0, -0x7_57f0);         /* call 0x100763a0 */
            ii(0x100e_bb90, 3);  mov(al, memb[ds, eax + 84]);          /* mov al, [eax+0x54] */
            ii(0x100e_bb93, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100e_bb98, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100e_bb9a, 2);  if(jg(0x100e_bb9e, 2)) goto l_0x100e_bb9e;/* jg 0x100ebb9e */
        l_0x100e_bb9c:
            ii(0x100e_bb9c, 2);  jmp(0x100e_bbad, 0xf); goto l_0x100e_bbad;/* jmp 0x100ebbad */
        l_0x100e_bb9e:
            ii(0x100e_bb9e, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100e_bba1, 5);  call(0x1007_63a0, -0x7_5806);         /* call 0x100763a0 */
            ii(0x100e_bba6, 5);  cmp(memw[ds, eax + 8], 0x47);         /* cmp word [eax+0x8], 0x47 */
            ii(0x100e_bbab, 2);  if(jnz(0x100e_bbaf, 2)) goto l_0x100e_bbaf;/* jnz 0x100ebbaf */
        l_0x100e_bbad:
            ii(0x100e_bbad, 2);  jmp(0x100e_bbbe, 0xf); goto l_0x100e_bbbe;/* jmp 0x100ebbbe */
        l_0x100e_bbaf:
            ii(0x100e_bbaf, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100e_bbb2, 5);  call(0x1007_63a0, -0x7_5817);         /* call 0x100763a0 */
            ii(0x100e_bbb7, 5);  cmp(memw[ds, eax + 8], 0x42);         /* cmp word [eax+0x8], 0x42 */
            ii(0x100e_bbbc, 2);  if(jnz(0x100e_bbc0, 2)) goto l_0x100e_bbc0;/* jnz 0x100ebbc0 */
        l_0x100e_bbbe:
            ii(0x100e_bbbe, 2);  jmp(0x100e_bbd0, 0x10); goto l_0x100e_bbd0;/* jmp 0x100ebbd0 */
        l_0x100e_bbc0:
            ii(0x100e_bbc0, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x100e_bbc4, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_bbc6, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100e_bbc9, 5);  call(0x1007_5f6c, -0x7_5c62);         /* call 0x10075f6c */
            ii(0x100e_bbce, 2);  jmp(0x100e_bbec, 0x1c); goto l_0x100e_bbec;/* jmp 0x100ebbec */
        l_0x100e_bbd0:
            ii(0x100e_bbd0, 2);  jmp(0x100e_bb59, -0x79); goto l_0x100e_bb59;/* jmp 0x100ebb59 */
        l_0x100e_bbd2:
            ii(0x100e_bbd2, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
            ii(0x100e_bbd6, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_bbd8, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100e_bbdb, 5);  call(0x1007_5f6c, -0x7_5c74);         /* call 0x10075f6c */
            ii(0x100e_bbe0, 2);  jmp(0x100e_bbec, 0xa); goto l_0x100e_bbec;/* jmp 0x100ebbec */
        //  ii(0x100e_bbe2, 10);  Недостижимый код.
        l_0x100e_bbec:
            ii(0x100e_bbec, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x100e_bbef, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_bbf1, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_bbf2, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_bbf3, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_bbf4, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_bbf5, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_bbf6, 1);  ret();                                /* ret */
        }
    }
}
