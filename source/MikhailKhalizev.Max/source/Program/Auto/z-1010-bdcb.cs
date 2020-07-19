using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_bdcb-b2f8bb7f")]
        public void Method_1010_bdcb()
        {
            ii(0x1010_bdcb, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1010_bdd0, 5);  call(Definitions.sys_check_available_stack_size, 0x5_9f7d);/* call 0x10165d52 */
            ii(0x1010_bdd5, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_bdd6, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_bdd7, 1);  push(edx);                            /* push edx */
            ii(0x1010_bdd8, 1);  push(esi);                            /* push esi */
            ii(0x1010_bdd9, 1);  push(edi);                            /* push edi */
            ii(0x1010_bdda, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_bddb, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_bddd, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1010_bde3, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_bde6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_bde9, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_bdeb, 6);  mov(dl, memb[ds, eax + 871]);         /* mov dl, [eax+0x367] */
            ii(0x1010_bdf1, 5);  mov(eax, 0x49);                       /* mov eax, 0x49 */
            ii(0x1010_bdf6, 5);  call(0x100c_aafc, -0x4_12ff);         /* call 0x100caafc */
            ii(0x1010_bdfb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_bdfe, 6);  mov(edx, memd[ds, eax + 870]);        /* mov edx, [eax+0x366] */
            ii(0x1010_be04, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1010_be07, 5);  mov(eax, 0x46);                       /* mov eax, 0x46 */
            ii(0x1010_be0c, 5);  call(0x100c_aafc, -0x4_1315);         /* call 0x100caafc */
            ii(0x1010_be11, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_be14, 6);  mov(edx, memd[ds, eax + 872]);        /* mov edx, [eax+0x368] */
            ii(0x1010_be1a, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1010_be1d, 5);  mov(eax, 0x47);                       /* mov eax, 0x47 */
            ii(0x1010_be22, 5);  call(0x100c_aafc, -0x4_132b);         /* call 0x100caafc */
            ii(0x1010_be27, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_be2a, 6);  mov(edx, memd[ds, eax + 875]);        /* mov edx, [eax+0x36b] */
            ii(0x1010_be30, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1010_be33, 5);  mov(eax, 0x48);                       /* mov eax, 0x48 */
            ii(0x1010_be38, 5);  call(0x100c_aafc, -0x4_1341);         /* call 0x100caafc */
            ii(0x1010_be3d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_be40, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_be42, 6);  mov(dl, memb[ds, eax + 876]);         /* mov dl, [eax+0x36c] */
            ii(0x1010_be48, 5);  mov(eax, 0x4c);                       /* mov eax, 0x4c */
            ii(0x1010_be4d, 5);  call(0x100c_aafc, -0x4_1356);         /* call 0x100caafc */
            ii(0x1010_be52, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_be55, 3);  mov(al, memb[ds, eax + 12]);          /* mov al, [eax+0xc] */
            ii(0x1010_be58, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1010_be5d, 3);  cmp(eax, 3);                          /* cmp eax, 0x3 */
            ii(0x1010_be60, 2);  if(jz(0x1010_be72, 0x10)) goto l_0x1010_be72;/* jz 0x1010be72 */
            ii(0x1010_be62, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_be65, 3);  mov(al, memb[ds, eax + 12]);          /* mov al, [eax+0xc] */
            ii(0x1010_be68, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1010_be6d, 3);  cmp(eax, 4);                          /* cmp eax, 0x4 */
            ii(0x1010_be70, 2);  if(jnz(0x1010_be74, 2)) goto l_0x1010_be74;/* jnz 0x1010be74 */
        l_0x1010_be72:
            ii(0x1010_be72, 2);  jmp(0x1010_be9f, 0x2b); goto l_0x1010_be9f;/* jmp 0x1010be9f */
        l_0x1010_be74:
            ii(0x1010_be74, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_be77, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_be79, 6);  mov(dl, memb[ds, eax + 883]);         /* mov dl, [eax+0x373] */
            ii(0x1010_be7f, 5);  mov(eax, 0x4a);                       /* mov eax, 0x4a */
            ii(0x1010_be84, 5);  call(0x100c_aafc, -0x4_138d);         /* call 0x100caafc */
            ii(0x1010_be89, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_be8c, 6);  mov(edx, memd[ds, eax + 906]);        /* mov edx, [eax+0x38a] */
            ii(0x1010_be92, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1010_be95, 5);  mov(eax, 0x4b);                       /* mov eax, 0x4b */
            ii(0x1010_be9a, 5);  call(0x100c_aafc, -0x4_13a3);         /* call 0x100caafc */
        l_0x1010_be9f:
            ii(0x1010_be9f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_bea2, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_bea4, 6);  mov(dl, memb[ds, eax + 879]);         /* mov dl, [eax+0x36f] */
            ii(0x1010_beaa, 5);  mov(eax, 0x4d);                       /* mov eax, 0x4d */
            ii(0x1010_beaf, 5);  call(0x100c_aafc, -0x4_13b8);         /* call 0x100caafc */
            ii(0x1010_beb4, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_beb7, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_beb9, 6);  mov(dl, memb[ds, eax + 880]);         /* mov dl, [eax+0x370] */
            ii(0x1010_bebf, 5);  mov(eax, 0x4e);                       /* mov eax, 0x4e */
            ii(0x1010_bec4, 5);  call(0x100c_aafc, -0x4_13cd);         /* call 0x100caafc */
            ii(0x1010_bec9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_becc, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_bece, 6);  mov(dl, memb[ds, eax + 881]);         /* mov dl, [eax+0x371] */
            ii(0x1010_bed4, 5);  mov(eax, 0x4f);                       /* mov eax, 0x4f */
            ii(0x1010_bed9, 5);  call(0x100c_aafc, -0x4_13e2);         /* call 0x100caafc */
            ii(0x1010_bede, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_bee1, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_bee3, 6);  mov(dl, memb[ds, eax + 882]);         /* mov dl, [eax+0x372] */
            ii(0x1010_bee9, 5);  mov(eax, 0x50);                       /* mov eax, 0x50 */
            ii(0x1010_beee, 5);  call(0x100c_aafc, -0x4_13f7);         /* call 0x100caafc */
            ii(0x1010_bef3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_bef6, 7);  mov(memd[ds, eax + 8], 1);            /* mov dword [eax+0x8], 0x1 */
            ii(0x1010_befd, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_beff, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_bf00, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_bf01, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_bf02, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_bf03, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_bf04, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_bf05, 1);  ret();                                /* ret */
        }
    }
}
