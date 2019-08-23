using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_a067-37ab02d")]
        public void Method_100e_a067()
        {
            ii(0x100e_a067, 5); push(0x34);                             /* push 0x34 */
            ii(0x100e_a06c, 5); call(Definitions.sys_check_available_stack_size, 0x7_bce1); /* call 0x10165d52 */
            ii(0x100e_a071, 1); push(ebx);                              /* push ebx */
            ii(0x100e_a072, 1); push(ecx);                              /* push ecx */
            ii(0x100e_a073, 1); push(esi);                              /* push esi */
            ii(0x100e_a074, 1); push(edi);                              /* push edi */
            ii(0x100e_a075, 1); push(ebp);                              /* push ebp */
            ii(0x100e_a076, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_a078, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100e_a07e, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_a081, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_a084, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_a087, 4); movsx(eax, memb[ds, eax + 0x1]);        /* movsx eax, byte [eax+0x1] */
            ii(0x100e_a08b, 3); shl(eax, 0x5);                          /* shl eax, 0x5 */
            ii(0x100e_a08e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_a090, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_a093, 3); movsx(eax, memb[ds, eax]);              /* movsx eax, byte [eax] */
            ii(0x100e_a096, 3); shl(eax, 0xa);                          /* shl eax, 0xa */
            ii(0x100e_a099, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_a09b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_a09e, 4); movsx(eax, memb[ds, eax + 0x2]);        /* movsx eax, byte [eax+0x2] */
            ii(0x100e_a0a2, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100e_a0a4, 5); mov(edx, 0x1020_0520);                  /* mov edx, 0x10200520 */
            ii(0x100e_a0a9, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_a0ab, 3); mov(memd[ss, ebp - 0x1c], edx);         /* mov [ebp-0x1c], edx */
            ii(0x100e_a0ae, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100e_a0b1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_a0b3, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x100e_a0b5, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_a0b8, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100e_a0bb, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_a0bd, 2); if(jnz(0x100e_a0c5, 0x6)) goto l_0x100e_a0c5; /* jnz 0x100ea0c5 */
            ii(0x100e_a0bf, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
            ii(0x100e_a0c3, 2); jmp(0x100e_a111, 0x4c); goto l_0x100e_a111; /* jmp 0x100ea111 */
        l_0x100e_a0c5:
            ii(0x100e_a0c5, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x100e_a0c8, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100e_a0cb, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x100e_a0cd, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100e_a0cf, 1); cwde();                                 /* cwde */
            ii(0x100e_a0d0, 5); call(0x100e_9f69, -0x16c);              /* call 0x100e9f69 */
            ii(0x100e_a0d5, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100e_a0d8, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_a0db, 3); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x100e_a0de, 5); call(0x100e_9fe3, -0x100);              /* call 0x100e9fe3 */
            ii(0x100e_a0e3, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100e_a0e6, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100e_a0e9, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_a0ec, 5); call(0x100e_9fe3, -0x10e);              /* call 0x100e9fe3 */
            ii(0x100e_a0f1, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100e_a0f4, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100e_a0f7, 4); cmp(ax, memw[ss, ebp - 0x10]);          /* cmp ax, [ebp-0x10] */
            ii(0x100e_a0fb, 2); if(jge(0x100e_a10d, 0x10)) goto l_0x100e_a10d; /* jge 0x100ea10d */
            ii(0x100e_a0fd, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_a100, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x100e_a102, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100e_a105, 2); mov(memb[ds, eax], dl);                 /* mov [eax], dl */
            ii(0x100e_a107, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
            ii(0x100e_a10b, 2); jmp(0x100e_a111, 0x4); goto l_0x100e_a111; /* jmp 0x100ea111 */
        l_0x100e_a10d:
            ii(0x100e_a10d, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
        l_0x100e_a111:
            ii(0x100e_a111, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x100e_a114, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_a116, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_a117, 1); pop(edi);                               /* pop edi */
            ii(0x100e_a118, 1); pop(esi);                               /* pop esi */
            ii(0x100e_a119, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_a11a, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_a11b, 1); ret();                                  /* ret */
        }
    }
}
